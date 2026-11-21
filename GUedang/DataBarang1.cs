using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;

namespace GUedang
{
    /// <summary>Format tampilan yang dipakai semua halaman.</summary>
    public static class Fmt
    {
        public static readonly CultureInfo Id = new CultureInfo("id-ID");

        public static string Rupiah(decimal nilai)
        {
            return string.Format(Id, "Rp {0:N0}", nilai);
        }

        /// <summary>Ambil angka dari teks, mis. "Rp 68.000" menjadi 68000.</summary>
        public static decimal ParseRupiah(string teks)
        {
            var sb = new System.Text.StringBuilder();
            foreach (char ch in teks ?? "")
                if (char.IsDigit(ch)) sb.Append(ch);
            decimal nilai;
            return decimal.TryParse(sb.ToString(), out nilai) ? nilai : 0;
        }
    }

    /// <summary>
    /// Sumber data barang + mutasi stok (masuk / keluar / opname) untuk halaman Gudang dan Kasir.
    /// TODO: ganti isi method di class ini dengan query database kamu.
    /// Sementara data disimpan di memori supaya semua halaman bisa dicoba langsung
    /// (data akan kembali ke awal setiap aplikasi dijalankan ulang).
    /// </summary>
    public static class DataBarang
    {
        private static DataTable _barang;
        private static DataTable _mutasi;
        private static int _idBerikut = 1;

        /// <summary>Kolom: kode, nama, kategori, satuan, harga (jual), stok, stok_min, harga_beli</summary>
        public static DataTable GetSemua()
        {
            if (_barang == null) BuatBarang();
            return _barang;
        }

        /// <summary>Cari satu barang berdasarkan kode. Null jika tidak ada.</summary>
        public static DataRow Cari(string kode)
        {
            DataRow[] hasil = GetSemua().Select("kode = '" + kode.Replace("'", "''") + "'");
            return hasil.Length > 0 ? hasil[0] : null;
        }

        public static List<string> GetKategori()
        {
            var daftar = new List<string>();
            foreach (DataRow r in GetSemua().Rows)
            {
                string k = r["kategori"].ToString();
                if (!daftar.Contains(k)) daftar.Add(k);
            }
            daftar.Sort();
            return daftar;
        }

        public static string Status(int stok, int stokMin)
        {
            if (stok <= 0) return "Habis";
            if (stok <= stokMin) return "Menipis";
            return "Aman";
        }

        /// <summary>
        /// Riwayat mutasi, terbaru di atas. jenis = "Masuk", "Keluar", atau "Opname".
        /// Kolom: waktu, jenis, kode, nama, jumlah, pihak, keterangan, id, harga
        /// </summary>
        public static DataRow[] GetMutasi(string jenis)
        {
            if (_mutasi == null) BuatMutasi();
            return _mutasi.Select("jenis = '" + jenis + "'", "waktu DESC");
        }

        /// <summary>Mutasi terakhir (jenis apa pun) untuk satu barang. Null jika belum ada.</summary>
        public static DataRow MutasiTerakhir(string kode)
        {
            if (_mutasi == null) BuatMutasi();
            DataRow[] hasil = _mutasi.Select("kode = '" + kode.Replace("'", "''") + "'", "waktu DESC");
            return hasil.Length > 0 ? hasil[0] : null;
        }

        /// <summary>
        /// Catat barang masuk/keluar sekaligus mengubah stok.
        /// harga = harga satuan (harga beli). Jika 0, dipakai harga beli terakhir barang tersebut.
        /// Untuk "Masuk" dengan harga &gt; 0, harga beli barang ikut diperbarui.
        /// TODO database: INSERT ke tabel barang_masuk / barang_keluar, lalu UPDATE barang (dalam satu transaksi).
        /// </summary>
        public static void CatatMutasi(string jenis, string kode, int jumlah, string pihak, string keterangan, decimal harga = 0)
        {
            if (_mutasi == null) BuatMutasi();
            DataRow b = Cari(kode);
            if (b == null) throw new InvalidOperationException("Barang tidak ditemukan.");
            if (jumlah <= 0) throw new InvalidOperationException("Jumlah harus lebih dari 0.");

            int stok = Convert.ToInt32(b["stok"]);
            int baru = jenis == "Masuk" ? stok + jumlah : stok - jumlah;
            if (baru < 0)
                throw new InvalidOperationException("Stok tidak cukup. Stok tersedia: " + stok + ".");

            if (jenis == "Masuk" && harga > 0) b["harga_beli"] = harga;
            else if (harga <= 0) harga = Convert.ToDecimal(b["harga_beli"]);

            b["stok"] = baru;
            TambahMutasi(DateTime.Now, jenis, b, jumlah, pihak, keterangan, harga);
            if (pihak != "Penjualan kasir")
                DataAktivitas.Catat((jenis == "Masuk" ? "Barang masuk: " : "Barang keluar: ") + b["nama"] + " (" + jumlah + ")");
            Tulis();
        }

        /// <summary>
        /// Batalkan satu entri mutasi dan kembalikan stoknya.
        /// Entri dari penjualan kasir tidak bisa dibatalkan dari sini.
        /// </summary>
        public static void BatalkanMutasi(int id)
        {
            if (_mutasi == null) BuatMutasi();
            DataRow[] hit = _mutasi.Select("id = " + id);
            if (hit.Length == 0) throw new InvalidOperationException("Data tidak ditemukan.");

            DataRow m = hit[0];
            if (m["pihak"].ToString() == "Penjualan kasir")
                throw new InvalidOperationException("Mutasi dari penjualan kasir tidak bisa dibatalkan di sini.");

            DataRow b = Cari(m["kode"].ToString());
            if (b == null) throw new InvalidOperationException("Barang tidak ditemukan.");

            int jumlah = Convert.ToInt32(m["jumlah"]);
            int stok = Convert.ToInt32(b["stok"]);
            int baru = m["jenis"].ToString() == "Keluar" ? stok + jumlah : stok - jumlah;
            if (baru < 0)
                throw new InvalidOperationException("Tidak bisa dibatalkan karena stok akan menjadi minus.");

            b["stok"] = baru;
            DataAktivitas.Catat("Membatalkan " + m["jenis"].ToString().ToLower() + ": " + m["nama"] + " (" + jumlah + ")");
            m.Delete();
            _mutasi.AcceptChanges();
            Tulis();
        }

        /// <summary>Stok opname: samakan stok sistem dengan hasil hitung fisik dan catat selisihnya.</summary>
        public static void Sesuaikan(string kode, int stokFisik, string alasan)
        {
            if (_mutasi == null) BuatMutasi();
            DataRow b = Cari(kode);
            if (b == null) throw new InvalidOperationException("Barang tidak ditemukan.");
            if (stokFisik < 0) throw new InvalidOperationException("Jumlah fisik tidak boleh minus.");

            int selisih = stokFisik - Convert.ToInt32(b["stok"]);
            if (selisih == 0) throw new InvalidOperationException("Tidak ada selisih stok.");

            b["stok"] = stokFisik;
            TambahMutasi(DateTime.Now, "Opname", b, selisih, "Penyesuaian", alasan, Convert.ToDecimal(b["harga_beli"]));
            DataAktivitas.Catat("Penyesuaian stok " + b["nama"] + ": " + (selisih > 0 ? "+" : "") + selisih);
            Tulis();
        }

        public static void UbahStokMin(string kode, int stokMin)
        {
            DataRow b = Cari(kode);
            if (b == null) throw new InvalidOperationException("Barang tidak ditemukan.");
            if (stokMin < 0) throw new InvalidOperationException("Stok minimum tidak boleh minus.");
            b["stok_min"] = stokMin;
            Tulis();
        }

        /// <summary>Semua mutasi (masuk, keluar, opname), terbaru di atas.</summary>
        public static DataRow[] GetMutasiSemua()
        {
            if (_mutasi == null) BuatMutasi();
            return _mutasi.Select("", "waktu DESC");
        }

        /// <summary>Kode berikutnya, mis. BRG-015.</summary>
        public static string KodeBerikut()
        {
            int maks = 0;
            foreach (DataRow r in GetSemua().Rows)
            {
                string k = r["kode"].ToString();
                int n;
                if (k.StartsWith("BRG-") && int.TryParse(k.Substring(4), out n) && n > maks) maks = n;
            }
            return "BRG-" + (maks + 1).ToString("000");
        }

        /// <summary>
        /// Tambah barang baru (baru = true) atau ubah barang yang ada (baru = false).
        /// Jika stok diubah lewat sini, perubahannya dicatat sebagai penyesuaian (opname).
        /// TODO database: INSERT / UPDATE tabel barang.
        /// </summary>
        public static void SimpanBarang(string kode, string nama, string kategori, string satuan,
            decimal hargaBeli, decimal hargaJual, int stok, int stokMin, bool baru)
        {
            if (_mutasi == null) BuatMutasi();
            if (string.IsNullOrWhiteSpace(nama)) throw new InvalidOperationException("Nama barang wajib diisi.");
            if (string.IsNullOrWhiteSpace(kategori)) throw new InvalidOperationException("Kategori wajib diisi.");
            if (hargaJual <= 0) throw new InvalidOperationException("Harga jual harus lebih dari 0.");
            if (hargaBeli < 0 || stok < 0 || stokMin < 0) throw new InvalidOperationException("Nilai tidak boleh minus.");

            nama = nama.Trim();
            kategori = kategori.Trim();
            satuan = string.IsNullOrWhiteSpace(satuan) ? "pcs" : satuan.Trim();

            DataTable dt = GetSemua();
            foreach (DataRow r in dt.Rows)
                if (string.Equals(r["nama"].ToString(), nama, StringComparison.OrdinalIgnoreCase) && r["kode"].ToString() != kode)
                    throw new InvalidOperationException("Nama barang sudah dipakai oleh barang lain.");

            if (baru)
            {
                if (Cari(kode) != null) throw new InvalidOperationException("Kode barang sudah ada.");
                dt.Rows.Add(kode, nama, kategori, satuan, hargaJual, stok, stokMin, hargaBeli);
                DataRow b = Cari(kode);
                if (stok > 0) TambahMutasi(DateTime.Now, "Masuk", b, stok, "Stok awal", "Barang baru", hargaBeli);
                DataAktivitas.Catat("Menambah barang: " + nama);
                Tulis();
            }
            else
            {
                DataRow b = Cari(kode);
                if (b == null) throw new InvalidOperationException("Barang tidak ditemukan.");

                int lama = Convert.ToInt32(b["stok"]);
                b["nama"] = nama;
                b["kategori"] = kategori;
                b["satuan"] = satuan;
                b["harga"] = hargaJual;
                b["harga_beli"] = hargaBeli;
                b["stok_min"] = stokMin;
                b["stok"] = stok;
                if (stok != lama)
                    TambahMutasi(DateTime.Now, "Opname", b, stok - lama, "Koreksi admin", "Ubah data barang", hargaBeli);
                DataAktivitas.Catat("Mengubah barang: " + nama);
                Tulis();
            }
        }

        /// <summary>Hapus barang. Riwayat mutasi lama tetap tersimpan. TODO database: DELETE FROM barang.</summary>
        public static void HapusBarang(string kode)
        {
            DataRow b = Cari(kode);
            if (b == null) throw new InvalidOperationException("Barang tidak ditemukan.");
            string nama = b["nama"].ToString();
            b.Delete();
            GetSemua().AcceptChanges();
            DataAktivitas.Catat("Menghapus barang: " + nama);
            Tulis();
        }

        /// <summary>Simpan data barang dan mutasi ke file JSON.</summary>
        private static void Tulis()
        {
            JsonStore.Simpan("barang.json", GetSemua());
            JsonStore.Simpan("mutasi.json", _mutasi);
        }

        private static void TambahMutasi(DateTime waktu, string jenis, DataRow b, int jumlah, string pihak, string keterangan, decimal harga)
        {
            _mutasi.Rows.Add(waktu, jenis, b["kode"], b["nama"], jumlah, pihak ?? "", keterangan ?? "", _idBerikut++, harga, b["stok"]);
        }

        private static void BuatBarang()
        {
            var dt = new DataTable();
            dt.Columns.Add("kode", typeof(string));
            dt.Columns.Add("nama", typeof(string));
            dt.Columns.Add("kategori", typeof(string));
            dt.Columns.Add("satuan", typeof(string));
            dt.Columns.Add("harga", typeof(decimal));
            dt.Columns.Add("stok", typeof(int));
            dt.Columns.Add("stok_min", typeof(int));
            dt.Columns.Add("harga_beli", typeof(decimal));

            DataTable dariFile = JsonStore.Muat("barang.json", dt);
            if (dariFile != null) { _barang = dariFile; return; }

            if (JsonStore.DataContoh)
            {
                dt.Rows.Add("BRG-001", "Beras 5 Kg", "Sembako", "sak", 68000m, 4, 10);
                dt.Rows.Add("BRG-002", "Gula Pasir 1 Kg", "Sembako", "pcs", 16500m, 42, 15);
                dt.Rows.Add("BRG-003", "Telur Ayam 1 Kg", "Sembako", "kg", 29000m, 25, 10);
                dt.Rows.Add("BRG-004", "Mie Instan Goreng", "Makanan", "pcs", 3500m, 120, 40);
                dt.Rows.Add("BRG-005", "Susu UHT 1 L", "Minuman", "pcs", 18500m, 18, 12);
                dt.Rows.Add("BRG-006", "Teh Botol 450 ml", "Minuman", "pcs", 5000m, 60, 24);
                dt.Rows.Add("BRG-007", "Kopi Sachet", "Minuman", "pcs", 1500m, 200, 60);
                dt.Rows.Add("BRG-008", "Sabun Mandi", "Kebersihan", "pcs", 4500m, 9, 12);
                dt.Rows.Add("BRG-009", "Deterjen 800 g", "Kebersihan", "pcs", 22000m, 30, 10);
                dt.Rows.Add("BRG-014", "Minyak Goreng 2 L", "Sembako", "pcs", 38000m, 0, 12);

                // Harga beli contoh: sekitar 85% dari harga jual, dibulatkan ke 500.
                foreach (DataRow r in dt.Rows)
                    r["harga_beli"] = Math.Round(Convert.ToDecimal(r["harga"]) * 0.85m / 500m) * 500m;

            }

            _barang = dt;
            JsonStore.Simpan("barang.json", _barang);
        }

        private static void BuatMutasi()
        {
            var dt = new DataTable();
            dt.Columns.Add("waktu", typeof(DateTime));
            dt.Columns.Add("jenis", typeof(string));
            dt.Columns.Add("kode", typeof(string));
            dt.Columns.Add("nama", typeof(string));
            dt.Columns.Add("jumlah", typeof(int));
            dt.Columns.Add("pihak", typeof(string));
            dt.Columns.Add("keterangan", typeof(string));
            dt.Columns.Add("id", typeof(int));
            dt.Columns.Add("harga", typeof(decimal));
            dt.Columns.Add("stok_akhir", typeof(int));
            _mutasi = dt;

            DataTable dariFile = JsonStore.Muat("mutasi.json", dt);
            if (dariFile != null)
            {
                _mutasi = dariFile;
                foreach (DataRow r in _mutasi.Rows)
                    _idBerikut = Math.Max(_idBerikut, Convert.ToInt32(r["id"]) + 1);
                return;
            }

            if (JsonStore.DataContoh)
            {
                DateTime h = DateTime.Today;
                Seed(h.AddDays(-6).AddHours(9), "Masuk", "BRG-002", 50, "CV Sumber Rejeki", "Pengiriman rutin");
                Seed(h.AddDays(-4).AddHours(14), "Masuk", "BRG-004", 100, "PT Indo Pangan", "");
                Seed(h.AddDays(-2).AddHours(11), "Keluar", "BRG-006", 6, "Rusak", "Botol bocor");
                Seed(h.AddDays(-1).AddHours(16), "Keluar", "BRG-003", 3, "Kadaluarsa", "");
                Seed(h.AddHours(8.5), "Masuk", "BRG-007", 100, "CV Sumber Rejeki", "Stok kopi");
                Seed(h.AddHours(9.75), "Masuk", "BRG-005", 24, "PT Susu Nusantara", "");
                Seed(h.AddHours(10.3), "Keluar", "BRG-009", 2, "Rusak", "Kemasan penyok");
            }

            JsonStore.Simpan("mutasi.json", _mutasi);
        }

        // Data contoh: hanya untuk riwayat, stok tidak diubah.
        private static void Seed(DateTime waktu, string jenis, string kode, int jumlah, string pihak, string ket)
        {
            DataRow b = Cari(kode);
            if (b == null) return;
            TambahMutasi(waktu, jenis, b, jumlah, pihak, ket, Convert.ToDecimal(b["harga_beli"]));
        }
    }

    public class ItemTransaksi
    {
        public string Kode;
        public string Nama;
        public decimal Harga;
        public int Qty;
        public decimal Subtotal { get { return Harga * Qty; } }
    }

    /// <summary>
    /// Data transaksi penjualan kasir.
    /// TODO: ganti dengan query database (tabel transaksi + detail_transaksi).
    /// </summary>
    public static class DataTransaksi
    {
        private static DataTable _header;
        private static DataTable _detail;

        /// <summary>Kolom: no_transaksi, waktu, kasir, item, total</summary>
        public static DataTable Header { get { Pastikan(); return _header; } }

        /// <summary>Kolom: no_transaksi, kode, nama, harga, qty, subtotal</summary>
        public static DataTable Detail { get { Pastikan(); return _detail; } }

        /// <summary>
        /// Simpan transaksi baru, kurangi stok, dan kembalikan nomor transaksinya.
        /// TODO database: INSERT transaksi + detail, UPDATE stok (dalam satu transaksi database).
        /// </summary>
        public static string Simpan(string kasir, List<ItemTransaksi> items)
        {
            Pastikan();
            if (items == null || items.Count == 0)
                throw new InvalidOperationException("Keranjang masih kosong.");

            // Cek stok dulu supaya tidak ada transaksi setengah jadi.
            foreach (ItemTransaksi it in items)
            {
                DataRow b = DataBarang.Cari(it.Kode);
                if (b == null || Convert.ToInt32(b["stok"]) < it.Qty)
                    throw new InvalidOperationException("Stok " + it.Nama + " tidak cukup.");
            }

            string no = "TRX-" + (_header.Rows.Count + 1).ToString("0000");
            decimal total = 0;
            int qty = 0;
            foreach (ItemTransaksi it in items)
            {
                decimal modal = Convert.ToDecimal(DataBarang.Cari(it.Kode)["harga_beli"]);
                _detail.Rows.Add(no, it.Kode, it.Nama, it.Harga, it.Qty, it.Subtotal, modal);
                DataBarang.CatatMutasi("Keluar", it.Kode, it.Qty, "Penjualan kasir", no);
                total += it.Subtotal;
                qty += it.Qty;
            }
            _header.Rows.Add(no, DateTime.Now, kasir, qty, total);
            Tulis();
            DataAktivitas.Catat(kasir, "Kasir", "Transaksi " + no + " (" + Fmt.Rupiah(total) + ")");
            return no;
        }

        /// <summary>Simpan data transaksi ke file JSON.</summary>
        private static void Tulis()
        {
            JsonStore.Simpan("transaksi.json", _header);
            JsonStore.Simpan("transaksi_detail.json", _detail);
        }

        private static void Pastikan()
        {
            if (_header != null) return;

            _header = new DataTable();
            _header.Columns.Add("no_transaksi", typeof(string));
            _header.Columns.Add("waktu", typeof(DateTime));
            _header.Columns.Add("kasir", typeof(string));
            _header.Columns.Add("item", typeof(int));
            _header.Columns.Add("total", typeof(decimal));

            _detail = new DataTable();
            _detail.Columns.Add("no_transaksi", typeof(string));
            _detail.Columns.Add("kode", typeof(string));
            _detail.Columns.Add("nama", typeof(string));
            _detail.Columns.Add("harga", typeof(decimal));
            _detail.Columns.Add("qty", typeof(int));
            _detail.Columns.Add("subtotal", typeof(decimal));
            _detail.Columns.Add("modal", typeof(decimal));   // modal (harga beli) per unit saat transaksi

            DataTable hFile = JsonStore.Muat("transaksi.json", _header);
            DataTable dFile = JsonStore.Muat("transaksi_detail.json", _detail);
            if (hFile != null && dFile != null) { _header = hFile; _detail = dFile; return; }

            if (JsonStore.DataContoh)
            {
                // Data contoh: 9 hari terakhir (acak tetap) + 3 transaksi hari ini
                DateTime h = DateTime.Today;
                var rnd = new Random(7);
                string[] kasirs = { "Ditra2", "Siti Aminah" };
                DataTable brg = DataBarang.GetSemua();

                for (int hari = 9; hari >= 1; hari--)
                {
                    int jumlahTrx = rnd.Next(2, 5);
                    for (int i = 0; i < jumlahTrx; i++)
                    {
                        var baris = new List<object[]>();
                        int macam = rnd.Next(1, 4);
                        for (int j = 0; j < macam; j++)
                        {
                            DataRow br = brg.Rows[rnd.Next(brg.Rows.Count)];
                            baris.Add(new object[] { br["kode"], br["nama"], (decimal)br["harga"], rnd.Next(1, 6) });
                        }
                        Seed("TRX-" + (_header.Rows.Count + 1).ToString("0000"),
                            h.AddDays(-hari).AddHours(8 + i * 3).AddMinutes(rnd.Next(0, 59)),
                            kasirs[rnd.Next(kasirs.Length)], baris.ToArray());
                    }
                }

                Seed("TRX-" + (_header.Rows.Count + 1).ToString("0000"), h.AddHours(9).AddMinutes(12), "Ditra2",
                    new[] { new object[] { "BRG-004", "Mie Instan Goreng", 3500m, 5 }, new object[] { "BRG-007", "Kopi Sachet", 1500m, 4 } });
                Seed("TRX-" + (_header.Rows.Count + 1).ToString("0000"), h.AddHours(11).AddMinutes(40), "Ditra2",
                    new[] { new object[] { "BRG-002", "Gula Pasir 1 Kg", 16500m, 2 }, new object[] { "BRG-005", "Susu UHT 1 L", 18500m, 1 } });
                Seed("TRX-" + (_header.Rows.Count + 1).ToString("0000"), h.AddHours(14).AddMinutes(5), "Siti Aminah",
                    new[] { new object[] { "BRG-009", "Deterjen 800 g", 22000m, 1 } });
            }

            Tulis();
        }

        private static void Seed(string no, DateTime waktu, string kasir, object[][] baris)
        {
            decimal total = 0;
            int qty = 0;
            foreach (object[] b in baris)
            {
                decimal harga = (decimal)b[2];
                int q = (int)b[3];
                decimal modal = Convert.ToDecimal(DataBarang.Cari(b[0].ToString())["harga_beli"]);
                _detail.Rows.Add(no, b[0], b[1], harga, q, harga * q, modal);
                total += harga * q;
                qty += q;
            }
            _header.Rows.Add(no, waktu, kasir, qty, total);
        }
    }
}