using System.Text.Json;

namespace GUedang
{
    /// <summary>
    /// Penyimpanan data barang ke file JSON (Data/barang.json di folder aplikasi).
    /// Static + lock supaya aman dipakai dari banyak form/modul
    /// (kasir, riwayat gudang, laporan) tanpa data saling menimpa.
    /// Perubahan stok otomatis dicatat ke StoreRiwayatGudang.
    /// </summary>
    public static class BarangStore
    {
        private static readonly object _lock = new();
        private static readonly string _folder = Path.Combine(AppContext.BaseDirectory, "Data");
        private static readonly string _file = Path.Combine(_folder, "barang.json");
        private static readonly JsonSerializerOptions _opt = new() { WriteIndented = true };

        private static List<Barang>? _cache;

        /// <summary>Dipicu setiap data berubah (untuk refresh modul lain, mis. Dashboard).</summary>
        public static event Action? DataChanged;

        // ---------- baca ----------
        public static List<Barang> GetAll()
        {
            lock (_lock)
            {
                return Load().Select(Clone).ToList();
            }
        }

        public static Barang? GetByKode(string kode)
        {
            lock (_lock)
            {
                var b = Load().FirstOrDefault(x =>
                    x.Kode.Equals(kode, StringComparison.OrdinalIgnoreCase));
                return b == null ? null : Clone(b);
            }
        }

        public static List<Barang> Cari(string keyword)
        {
            keyword = (keyword ?? "").Trim();
            lock (_lock)
            {
                return Load()
                    .Where(b => keyword.Length == 0
                        || b.Nama.Contains(keyword, StringComparison.OrdinalIgnoreCase)
                        || b.Kode.Contains(keyword, StringComparison.OrdinalIgnoreCase))
                    .Select(Clone).ToList();
            }
        }

        /// <summary>Kode berikutnya, format BRG-001, BRG-002, ...</summary>
        public static string BuatKode()
        {
            lock (_lock)
            {
                int max = 0;
                foreach (var b in Load())
                {
                    if (b.Kode.StartsWith("BRG-", StringComparison.OrdinalIgnoreCase)
                        && int.TryParse(b.Kode.AsSpan(4), out int n) && n > max)
                        max = n;
                }
                return $"BRG-{max + 1:D3}";
            }
        }

        // ---------- tulis ----------
        /// <summary>Tambah baru, atau update jika kode sudah ada.</summary>
        public static void Simpan(Barang barang)
        {
            lock (_lock)
            {
                var list = Load();
                int idx = list.FindIndex(x =>
                    x.Kode.Equals(barang.Kode, StringComparison.OrdinalIgnoreCase));
                if (idx >= 0) list[idx] = Clone(barang);
                else list.Add(Clone(barang));
                Save(list);
            }
            DataChanged?.Invoke();
        }

        public static bool Hapus(string kode)
        {
            bool ok;
            lock (_lock)
            {
                var list = Load();
                ok = list.RemoveAll(x =>
                    x.Kode.Equals(kode, StringComparison.OrdinalIgnoreCase)) > 0;
                if (ok) Save(list);
            }
            if (ok) DataChanged?.Invoke();
            return ok;
        }

        /// <summary>
        /// Ubah stok (delta negatif = berkurang, mis. saat penjualan).
        /// Mengembalikan false jika barang tidak ada atau stok jadi minus.
        /// Jika 'jenis' diisi ("Keluar" / "Penyesuaian" / "Masuk"), otomatis dicatat ke riwayat gudang.
        /// Untuk Penyesuaian, jumlah yang dicatat = delta (boleh negatif).
        /// </summary>
        public static bool UbahStok(string kode, int delta,
                                    string jenis = "", string pihak = "", string keterangan = "")
        {
            string nama;
            int stokAkhir;

            lock (_lock)
            {
                var list = Load();
                var b = list.FirstOrDefault(x =>
                    x.Kode.Equals(kode, StringComparison.OrdinalIgnoreCase));
                if (b == null || b.Stok + delta < 0) return false;
                b.Stok += delta;
                Save(list);
                nama = b.Nama;
                stokAkhir = b.Stok;
            }

            if (jenis != "")
            {
                int jumlah = jenis == "Penyesuaian" ? delta : Math.Abs(delta);
                StoreRiwayatGudang.Catat(jenis, kode, nama, jumlah, stokAkhir, pihak, keterangan);
            }

            DataChanged?.Invoke();
            return true;
        }

        /// <summary>
        /// Barang masuk (restock). Otomatis dicatat sebagai "Masuk" di riwayat gudang.
        /// Parameter pihak (supplier) dan keterangan opsional, form lama tetap bisa memanggil tanpa keduanya.
        /// </summary>
        public static bool TambahStok(string kode, int jumlah, decimal? hargaBeliBaru = null,
                                      string pihak = "", string keterangan = "")
        {
            if (jumlah <= 0) return false;

            string nama;
            int stokAkhir;

            lock (_lock)
            {
                var list = Load();
                var b = list.FirstOrDefault(x =>
                    x.Kode.Equals(kode, StringComparison.OrdinalIgnoreCase));
                if (b == null) return false;

                b.Stok += jumlah;
                if (hargaBeliBaru is > 0) b.HargaBeli = hargaBeliBaru.Value;
                Save(list);
                nama = b.Nama;
                stokAkhir = b.Stok;
            }

            StoreRiwayatGudang.Catat("Masuk", kode, nama, jumlah, stokAkhir, pihak, keterangan);
            DataChanged?.Invoke();
            return true;
        }

        // ---------- internal ----------
        private static List<Barang> Load()
        {
            if (_cache != null) return _cache;

            try
            {
                if (File.Exists(_file))
                {
                    string json = File.ReadAllText(_file);
                    _cache = JsonSerializer.Deserialize<List<Barang>>(json) ?? new();
                }
                else _cache = new();
            }
            catch (JsonException)
            {
                // File rusak: simpan cadangan lalu mulai kosong
                File.Copy(_file, _file + ".rusak", true);
                _cache = new();
            }
            return _cache;
        }

        private static void Save(List<Barang> list)
        {
            Directory.CreateDirectory(_folder);
            // tulis ke file sementara dulu agar tidak korup bila aplikasi tertutup mendadak
            string tmp = _file + ".tmp";
            File.WriteAllText(tmp, JsonSerializer.Serialize(list, _opt));
            File.Move(tmp, _file, true);
            _cache = list;
        }

        private static Barang Clone(Barang b) => new()
        {
            Kode = b.Kode,
            Nama = b.Nama,
            Kategori = b.Kategori,
            Satuan = b.Satuan,
            HargaBeli = b.HargaBeli,
            HargaJual = b.HargaJual,
            Stok = b.Stok,
            StokMinimum = b.StokMinimum
        };
    }
}