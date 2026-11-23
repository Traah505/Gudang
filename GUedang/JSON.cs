using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

namespace GUedang
{
    public static class JsonStore
    {
        private static readonly string FolderData = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DataJson");
        private static readonly string FileDb = Path.Combine(FolderData, "database_smkmart.json");
        private static readonly object _lock = new object();

        public static event EventHandler DataChanged;

        public static DatabaseJson Load()
        {
            lock (_lock)
            {
                if (!Directory.Exists(FolderData))
                    Directory.CreateDirectory(FolderData);

                if (!File.Exists(FileDb))
                {
                    var seed = BuatDataAwal();
                    SimpanInternal(seed);
                    return seed;
                }

                string json = File.ReadAllText(FileDb);
                if (string.IsNullOrWhiteSpace(json))
                    return BuatDataAwal();

                var db = JsonConvert.DeserializeObject<DatabaseJson>(json) ?? new DatabaseJson();
                db.Barang ??= new List<BarangItem>();
                db.Transaksi ??= new List<TransaksiItem>();
                db.RiwayatGudang ??= new List<RiwayatGudangItem>();
                db.LogAktivitas ??= new List<LogAktivitasItem>();
                return db;
            }
        }

        public static void Save(DatabaseJson db)
        {
            lock (_lock)
            {
                SimpanInternal(db);
            }
            DataChanged?.Invoke(null, EventArgs.Empty);
        }

        private static void SimpanInternal(DatabaseJson db)
        {
            if (!Directory.Exists(FolderData))
                Directory.CreateDirectory(FolderData);
            File.WriteAllText(FileDb, JsonConvert.SerializeObject(db, Formatting.Indented));
        }

        public static void CatatLog(string role, string namaUser, string aktivitas)
        {
            var db = Load();
            db.LogAktivitas.Insert(0, new LogAktivitasItem
            {
                Waktu = DateTime.Now,
                Role = role,
                NamaUser = namaUser,
                Aktivitas = aktivitas
            });
            Save(db);
        }

        public static bool ProsesTransaksiKasir(
            string kodeTransaksi,
            string namaKasir,
            string metodeBayar,
            decimal diskonNominal,
            decimal uangDiterima,
            List<DetailTransaksiItem> keranjang,
            out string pesanError)
        {
            pesanError = "";
            var db = Load();

            foreach (var item in keranjang)
            {
                var brg = db.Barang.FirstOrDefault(b => b.Kode.Equals(item.KodeBarang, StringComparison.OrdinalIgnoreCase));
                if (brg == null)
                {
                    pesanError = $"Barang {item.KodeBarang} tidak ditemukan.";
                    return false;
                }
                if (brg.Stok < item.Qty)
                {
                    pesanError = $"Stok {brg.Nama} tidak cukup (tersedia: {brg.Stok}).";
                    return false;
                }
            }

            foreach (var item in keranjang)
            {
                var brg = db.Barang.First(b => b.Kode.Equals(item.KodeBarang, StringComparison.OrdinalIgnoreCase));
                brg.Stok -= item.Qty;
                item.HargaModal = brg.HargaBeli;
                item.HargaSatuan = brg.HargaJual;
                item.Subtotal = item.Qty * brg.HargaJual;

                db.RiwayatGudang.Insert(0, new RiwayatGudangItem
                {
                    TanggalWaktu = DateTime.Now,
                    JenisTransaksi = "Barang Keluar",
                    KodeBarang = brg.Kode,
                    NamaBarang = brg.Nama,
                    Jumlah = item.Qty,
                    HargaSatuan = brg.HargaBeli,
                    TotalNilai = item.Qty * brg.HargaBeli,
                    StokAkhir = brg.Stok,
                    SupplierTujuan = "Penjualan Kasir",
                    Keterangan = $"Transaksi {kodeTransaksi}",
                    Petugas = namaKasir
                });
            }

            decimal subtotal = keranjang.Sum(x => x.Subtotal);
            decimal diskonValid = Math.Max(0, Math.Min(diskonNominal, subtotal));
            decimal totalAkhir = subtotal - diskonValid;
            decimal kembalian = Math.Max(0, uangDiterima - totalAkhir);

            db.Transaksi.Insert(0, new TransaksiItem
            {
                KodeTransaksi = kodeTransaksi,
                Tanggal = DateTime.Now,
                NamaKasir = namaKasir,
                MetodeBayar = string.IsNullOrWhiteSpace(metodeBayar) ? "Tunai" : metodeBayar,
                Subtotal = subtotal,
                Diskon = diskonValid,
                TotalHarga = totalAkhir,
                UangDiterima = uangDiterima,
                Kembalian = kembalian,
                Items = keranjang
            });

            db.LogAktivitas.Insert(0, new LogAktivitasItem
            {
                Waktu = DateTime.Now,
                Role = Roles.Kasir,
                NamaUser = namaKasir,
                Aktivitas = $"Transaksi {kodeTransaksi} ({metodeBayar}) total Rp {totalAkhir:N0}"
            });

            Save(db);
            return true;
        }

        public static bool ProsesGudang(
            string jenisTransaksi,
            string kodeBarang,
            int jumlah,
            decimal? hargaBeliBaru,
            string supplierTujuan,
            string keterangan,
            string petugas,
            out string pesanError)
        {
            pesanError = "";
            var db = Load();
            var brg = db.Barang.FirstOrDefault(b => b.Kode.Equals(kodeBarang, StringComparison.OrdinalIgnoreCase));
            if (brg == null)
            {
                pesanError = "Barang tidak ditemukan.";
                return false;
            }

            if (jenisTransaksi == "Barang Masuk")
            {
                brg.Stok += jumlah;
                if (hargaBeliBaru.HasValue && hargaBeliBaru.Value > 0)
                    brg.HargaBeli = hargaBeliBaru.Value;
            }
            else if (jenisTransaksi == "Barang Keluar")
            {
                if (brg.Stok < jumlah)
                {
                    pesanError = $"Stok tidak mencukupi. Sisa stok: {brg.Stok}";
                    return false;
                }
                brg.Stok -= jumlah;
            }
            else if (jenisTransaksi == "Penyesuaian")
            {
                brg.Stok = Math.Max(0, jumlah);
            }

            decimal hargaAcuan = (jenisTransaksi == "Barang Masuk" && hargaBeliBaru.HasValue && hargaBeliBaru.Value > 0)
                ? hargaBeliBaru.Value
                : brg.HargaBeli;

            db.RiwayatGudang.Insert(0, new RiwayatGudangItem
            {
                TanggalWaktu = DateTime.Now,
                JenisTransaksi = jenisTransaksi,
                KodeBarang = brg.Kode,
                NamaBarang = brg.Nama,
                Jumlah = jumlah,
                HargaSatuan = hargaAcuan,
                TotalNilai = jumlah * hargaAcuan,
                StokAkhir = brg.Stok,
                SupplierTujuan = supplierTujuan ?? "",
                Keterangan = keterangan ?? "",
                Petugas = petugas
            });

            db.LogAktivitas.Insert(0, new LogAktivitasItem
            {
                Waktu = DateTime.Now,
                Role = Roles.Gudang,
                NamaUser = petugas,
                Aktivitas = $"{jenisTransaksi} {brg.Nama} ({jumlah}) -> Stok akhir: {brg.Stok}"
            });

            Save(db);
            return true;
        }

        private static DatabaseJson BuatDataAwal()
        {
            var db = new DatabaseJson();
            db.Barang.AddRange(new[]
            {
                new BarangItem { Kode = "BRG-001", Nama = "Beras 5 Kg", Kategori = "Sembako", HargaBeli = 65000, HargaJual = 72000, Stok = 4, Minimum = 10 },
                new BarangItem { Kode = "BRG-014", Nama = "Minyak Goreng 2L", Kategori = "Sembako", HargaBeli = 32000, HargaJual = 36000, Stok = 0, Minimum = 12 },
                new BarangItem { Kode = "BRG-023", Nama = "Gula Pasir 1 Kg", Kategori = "Sembako", HargaBeli = 15000, HargaJual = 18000, Stok = 6, Minimum = 15 },
                new BarangItem { Kode = "BRG-031", Nama = "Telur Ayam 1 Kg", Kategori = "Sembako", HargaBeli = 24000, HargaJual = 27500, Stok = 0, Minimum = 8 },
                new BarangItem { Kode = "BRG-044", Nama = "Kopi Sachet", Kategori = "Minuman", HargaBeli = 1200, HargaJual = 2000, Stok = 3, Minimum = 20 }
            });
            return db;
        }
    }
}