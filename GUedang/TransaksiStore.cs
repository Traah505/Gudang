using System.Text.Json;

namespace GUedang
{
    /// <summary>
    /// Penyimpanan transaksi penjualan ke Data/transaksi.json.
    /// Kasir memanggil Simpan(); Laporan Penjualan / Laporan Laba hanya membaca.
    /// </summary>
    public static class TransaksiStore
    {
        private static readonly object _lock = new();
        private static readonly string _folder = Path.Combine(AppContext.BaseDirectory, "Data");
        private static readonly string _file = Path.Combine(_folder, "transaksi.json");
        private static readonly JsonSerializerOptions _opt = new() { WriteIndented = true };

        private static List<Transaksi>? _cache;

        public static event Action? DataChanged;

        // ---------- baca (hasil bersifat read-only, jangan diubah) ----------
        public static List<Transaksi> GetAll()
        {
            lock (_lock) { return Load().ToList(); }
        }

        /// <summary>Transaksi dari tanggal 'dari' sampai akhir hari 'sampai' (inklusif).</summary>
        public static List<Transaksi> GetByPeriode(DateTime dari, DateTime sampai)
        {
            DateTime awal = dari.Date;
            DateTime akhir = sampai.Date.AddDays(1);
            lock (_lock)
            {
                return Load().Where(t => t.Tanggal >= awal && t.Tanggal < akhir).ToList();
            }
        }

        /// <summary>Kode berikutnya: TRX-20261123-001, TRX-20261123-002, ...</summary>
        public static string BuatKode(DateTime? tanggal = null)
        {
            string prefix = $"TRX-{(tanggal ?? DateTime.Now):yyyyMMdd}-";
            lock (_lock)
            {
                int max = 0;
                foreach (var t in Load())
                {
                    if (t.Kode.StartsWith(prefix) && int.TryParse(t.Kode.AsSpan(prefix.Length), out int n) && n > max)
                        max = n;
                }
                return $"{prefix}{max + 1:D3}";
            }
        }

        // ---------- tulis ----------
        /// <summary>
        /// Dipanggil oleh KASIR saat bayar. Memvalidasi stok, mengurangi stok barang,
        /// mengisi nama + harga beli dari data barang, lalu menyimpan transaksi.
        /// </summary>
        public static bool Simpan(Transaksi trx, out string error)
        {
            error = "";

            if (trx.Detail.Count == 0) { error = "Transaksi tidak punya barang."; return false; }
            if (trx.Detail.Any(d => d.Qty <= 0)) { error = "Qty harus lebih dari 0."; return false; }

            lock (_lock)
            {
                var list = Load();
                if (list.Any(t => t.Kode.Equals(trx.Kode, StringComparison.OrdinalIgnoreCase)))
                { error = "Kode transaksi sudah ada."; return false; }

                // 1. cek stok (jumlahkan jika barang yang sama muncul di beberapa baris)
                var perBarang = trx.Detail.GroupBy(d => d.KodeBarang)
                                          .ToDictionary(g => g.Key, g => g.Sum(x => x.Qty));
                foreach (var (kode, qty) in perBarang)
                {
                    var b = BarangStore.GetByKode(kode);
                    if (b == null) { error = $"Barang {kode} tidak ditemukan."; return false; }
                    if (b.Stok < qty) { error = $"Stok {b.Nama} tidak cukup (sisa {b.Stok})."; return false; }
                }

                // 2. lengkapi snapshot data barang
                foreach (var d in trx.Detail)
                {
                    var b = BarangStore.GetByKode(d.KodeBarang)!;
                    d.NamaBarang = b.Nama;
                    d.HargaBeli = b.HargaBeli;
                    if (d.Harga <= 0) d.Harga = b.HargaJual;
                }

                // 3. kurangi stok (rollback jika ada yang gagal)
                var berhasil = new List<(string kode, int qty)>();
                foreach (var (kode, qty) in perBarang)
                {
                    if (!BarangStore.UbahStok(kode, -qty))
                    {
                        foreach (var (k, q) in berhasil) BarangStore.UbahStok(k, q);
                        error = "Gagal mengurangi stok. Coba lagi.";
                        return false;
                    }
                    berhasil.Add((kode, qty));
                }

                list.Add(trx);
                Save(list);
            }

            DataChanged?.Invoke();
            return true;
        }

        /// <summary>
        /// Untuk uji coba laporan sebelum kasir jadi: membuat transaksi acak
        /// 30 hari terakhir dari barang yang ada. TIDAK mengurangi stok.
        /// </summary>
        public static int BuatDataContoh(int jumlah = 40)
        {
            var barang = BarangStore.GetAll();
            if (barang.Count == 0) return 0;

            var rnd = new Random();
            string[] kasir = { "kasir1", "kasir2", "kasir3" };

            lock (_lock)
            {
                var list = Load();
                for (int i = 0; i < jumlah; i++)
                {
                    var tgl = DateTime.Today.AddDays(-rnd.Next(0, 30)).AddHours(rnd.Next(7, 20)).AddMinutes(rnd.Next(0, 60));
                    var trx = new Transaksi { Tanggal = tgl, Kasir = kasir[rnd.Next(kasir.Length)] };

                    int baris = rnd.Next(1, Math.Min(4, barang.Count) + 1);
                    foreach (var b in barang.OrderBy(_ => rnd.Next()).Take(baris))
                    {
                        trx.Detail.Add(new DetailTransaksi
                        {
                            KodeBarang = b.Kode,
                            NamaBarang = b.Nama,
                            Harga = b.HargaJual,
                            HargaBeli = b.HargaBeli,
                            Qty = rnd.Next(1, 6)
                        });
                    }

                    // kode unik per hari
                    string prefix = $"TRX-{tgl:yyyyMMdd}-";
                    int max = list.Where(t => t.Kode.StartsWith(prefix))
                                  .Select(t => int.TryParse(t.Kode.AsSpan(prefix.Length), out int n) ? n : 0)
                                  .DefaultIfEmpty(0).Max();
                    trx.Kode = $"{prefix}{max + 1:D3}";
                    list.Add(trx);
                }
                Save(list);
            }

            DataChanged?.Invoke();
            return jumlah;
        }

        // ---------- internal ----------
        private static List<Transaksi> Load()
        {
            if (_cache != null) return _cache;
            try
            {
                if (File.Exists(_file))
                    _cache = JsonSerializer.Deserialize<List<Transaksi>>(File.ReadAllText(_file)) ?? new();
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

        private static void Save(List<Transaksi> list)
        {
            Directory.CreateDirectory(_folder);
            string tmp = _file + ".tmp";
            File.WriteAllText(tmp, JsonSerializer.Serialize(list, _opt));
            File.Move(tmp, _file, true);
            _cache = list;
        }
    }
}