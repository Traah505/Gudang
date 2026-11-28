using System.Text.Json;

namespace GUedang
{
    /// <summary>Satu lapisan stok = satu kali barang masuk dengan harga tertentu.</summary>
    public class LapisanStok
    {
        public string Id { get; set; } = Guid.NewGuid().ToString("N");
        public string Kode { get; set; } = "";
        public DateTime Tanggal { get; set; } = DateTime.Now;
        public int JumlahAwal { get; set; }
        public int Sisa { get; set; }
        public decimal HargaBeli { get; set; }
        public decimal HargaJual { get; set; }
        public string Sumber { get; set; } = "";       // "Stok awal" | "Barang masuk"
        public string Keterangan { get; set; } = "";
    }

    public class PeristiwaHarga
    {
        public DateTime Tanggal { get; set; } = DateTime.Now;
        public string Kode { get; set; } = "";
        public string Jenis { get; set; } = "";        // "Harga jual naik" | "Harga jual turun"
        public decimal HargaLama { get; set; }
        public decimal HargaBaru { get; set; }

        public string Keterangan { get; set; } = "";
    }

    /// <summary>Hasil pembagian jumlah ke lapisan stok.</summary>
    public class AlokasiFifo
    {
        public string LapisanId { get; set; } = "";
        public int Qty { get; set; }
        public decimal HargaJual { get; set; }
        public decimal HargaBeli { get; set; }
    }

    public class DataLapisan
    {
        public List<LapisanStok> Lapisan { get; set; } = new();
        public List<PeristiwaHarga> Peristiwa { get; set; } = new();
    }

    public static class LapisanStokStore
    {
        private static readonly object _lock = new();
        private static readonly string _folder = Path.Combine(AppContext.BaseDirectory, "Data");
        private static readonly string _file = Path.Combine(_folder, "lapisan_stok.json");
        private static readonly JsonSerializerOptions _opt = new() { WriteIndented = true };
        private static DataLapisan? _cache;
        

        private static bool Sama(string a, string b) =>
            a.Equals(b, StringComparison.OrdinalIgnoreCase);

        // ---------- baca ----------
        /// <summary>Lapisan satu barang, urut dari yang paling lama (dijual lebih dulu).</summary>
        public static List<LapisanStok> Lapisan(string kode)
        {
            lock (_lock)
            {
                return Load().Lapisan
                    .Where(x => Sama(x.Kode, kode))
                    .OrderBy(x => x.Tanggal)
                    .Select(Salin).ToList();
            }
        }

        public static List<PeristiwaHarga> Peristiwa(string kode)
        {
            lock (_lock)
            {
                return Load().Peristiwa
                    .Where(x => Sama(x.Kode, kode))
                    .OrderBy(x => x.Tanggal).ToList();
            }
        }

        /// <summary>Harga jual yang berlaku sekarang (lapisan tertua yang masih ada sisa).</summary>
        public static decimal HargaJualAktif(string kode)
        {
            Sinkronkan(kode);
            lock (_lock)
            {
                var l = Load().Lapisan
                    .Where(x => Sama(x.Kode, kode) && x.Sisa > 0)
                    .OrderBy(x => x.Tanggal).FirstOrDefault();
                if (l != null) return l.HargaJual;
            }
            return BarangStore.GetByKode(kode)?.HargaJual ?? 0;
        }

        /// <summary>Pratinjau: jumlah ini akan diambil dari lapisan mana saja (belum mengubah apa pun).</summary>
        public static List<AlokasiFifo> HitungFifo(string kode, int qty)
        {
            Sinkronkan(kode);
            var hasil = new List<AlokasiFifo>();
            lock (_lock)
            {
                int sisaQty = qty;
                foreach (var l in Load().Lapisan
                             .Where(x => Sama(x.Kode, kode))
                             .OrderBy(x => x.Tanggal))
                {
                    if (sisaQty <= 0) break;
                    if (l.Sisa <= 0) continue;

                    int ambil = Math.Min(l.Sisa, sisaQty);
                    hasil.Add(new AlokasiFifo
                    {
                        LapisanId = l.Id,
                        Qty = ambil,
                        HargaJual = l.HargaJual,
                        HargaBeli = l.HargaBeli
                    });
                    sisaQty -= ambil;
                }
            }
            return hasil;
        }

        // ---------- tulis ----------
        /// <summary>
        /// Samakan jumlah semua lapisan dengan Stok barang.
        /// Kurang  -> buat lapisan "Stok awal" (stok lama sebelum FIFO).
        /// Berlebih -> potong dari lapisan tertua (mis. setelah Barang Keluar / penyesuaian).
        /// </summary>
        public static void Sinkronkan(string kode)
        {
            var b = BarangStore.GetByKode(kode);
            if (b == null) return;

            lock (_lock)
            {
                var d = Load();
                var lap = d.Lapisan.Where(x => Sama(x.Kode, kode)).OrderBy(x => x.Tanggal).ToList();
                int total = lap.Sum(x => x.Sisa);

                if (total < b.Stok)
                {
                    int selisih = b.Stok - total;
                    d.Lapisan.Add(new LapisanStok
                    {
                        Kode = b.Kode,
                        Tanggal = lap.Count > 0 ? lap.Min(x => x.Tanggal).AddMinutes(-1) : DateTime.Now,
                        JumlahAwal = selisih,
                        Sisa = selisih,
                        HargaBeli = b.HargaBeli,
                        HargaJual = b.HargaJual,
                        Sumber = "Stok awal",
                        Keterangan = "Stok yang sudah ada sebelum FIFO"
                    });
                    Simpan(d);
                }
                else if (total > b.Stok)
                {
                    Kurangi(lap, total - b.Stok);
                    Simpan(d);
                }
            }
        }

        /// <summary>Stok baru masuk = lapisan baru, antri di belakang stok lama.</summary>
        public static void TambahLapisan(string kode, int jumlah, decimal hargaBeli, decimal hargaJual,
                                         string sumber = "Barang masuk", string keterangan = "")
        {
            if (jumlah <= 0) return;
            lock (_lock)
            {
                var d = Load();
                d.Lapisan.Add(new LapisanStok
                {
                    Kode = kode,
                    Tanggal = DateTime.Now,
                    JumlahAwal = jumlah,
                    Sisa = jumlah,
                    HargaBeli = hargaBeli,
                    HargaJual = hargaJual,
                    Sumber = sumber,
                    Keterangan = keterangan
                });
                Simpan(d);
            }
        }

        /// <summary>Dipanggil setelah stok barang berkurang karena penjualan.</summary>
        public static void Konsumsi(string kode, int qty)
        {
            lock (_lock)
            {
                var d = Load();
                var lap = d.Lapisan.Where(x => Sama(x.Kode, kode)).OrderBy(x => x.Tanggal).ToList();
                Kurangi(lap, qty);
                Simpan(d);
            }
        }

        /// <summary>
        /// Harga jual berubah. Berlaku untuk lapisan yang belum mulai terjual;
        /// lapisan yang sudah mulai terjual tetap memakai harga lamanya.
        /// </summary>
        public static void TerapkanHargaJual(string kode, decimal hargaLama, decimal hargaBaru)
        {
            if (hargaLama == hargaBaru) return;
            lock (_lock)
            {
                var d = Load();
                foreach (var l in d.Lapisan.Where(x => Sama(x.Kode, kode)))
                    if (l.Sisa > 0 && l.Sisa == l.JumlahAwal)
                        l.HargaJual = hargaBaru;

                d.Peristiwa.Add(new PeristiwaHarga
                {
                    Tanggal = DateTime.Now,
                    Kode = kode,
                    Jenis = hargaBaru > hargaLama ? "Harga jual naik" : "Harga jual turun",
                    HargaLama = hargaLama,
                    HargaBaru = hargaBaru
                });
                Simpan(d);
            }
        }
        /// <summary>
        /// Admin mendaftarkan harga baru untuk barang yang namanya sama.
        /// Lapisan stok yang sudah ada TIDAK diubah. Harga baru dipakai stok yang masuk berikutnya.
        /// </summary>
        public static void DaftarkanHargaBaru(string kode, decimal jualLama, decimal jualBaru, string keterangan)
        {
            lock (_lock)
            {
                var d = Load();
                d.Peristiwa.Add(new PeristiwaHarga
                {
                    Tanggal = DateTime.Now,
                    Kode = kode,
                    Jenis = "Harga baru",
                    HargaLama = jualLama,
                    HargaBaru = jualBaru,
                    Keterangan = keterangan
                });
                Simpan(d);
            }
        }
        public static void HapusBarang(string kode)
        {
            lock (_lock)
            {
                var d = Load();
                d.Lapisan.RemoveAll(x => Sama(x.Kode, kode));
                d.Peristiwa.RemoveAll(x => Sama(x.Kode, kode));
                Simpan(d);
            }
        }

        // ---------- internal ----------
        private static void Kurangi(List<LapisanStok> urut, int qty)
        {
            foreach (var l in urut)
            {
                if (qty <= 0) break;
                int ambil = Math.Min(l.Sisa, qty);
                l.Sisa -= ambil;
                qty -= ambil;
            }
        }

        private static LapisanStok Salin(LapisanStok l) => new()
        {
            Id = l.Id,
            Kode = l.Kode,
            Tanggal = l.Tanggal,
            JumlahAwal = l.JumlahAwal,
            Sisa = l.Sisa,
            HargaBeli = l.HargaBeli,
            HargaJual = l.HargaJual,
            Sumber = l.Sumber,
            Keterangan = l.Keterangan
        };

        private static DataLapisan Load()
        {
            if (_cache != null) return _cache;
            try
            {
                if (File.Exists(_file))
                    _cache = JsonSerializer.Deserialize<DataLapisan>(File.ReadAllText(_file)) ?? new();
                else
                    _cache = new();
            }
            catch (JsonException)
            {
                File.Copy(_file, _file + ".rusak", true);
                _cache = new();
            }
            return _cache;
        }

        private static void Simpan(DataLapisan d)
        {
            Directory.CreateDirectory(_folder);
            string tmp = _file + ".tmp";
            File.WriteAllText(tmp, JsonSerializer.Serialize(d, _opt));
            File.Move(tmp, _file, true);
            _cache = d;
        }
    }
}