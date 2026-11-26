using System.Text.Json;
using System.Text.Json.Serialization;

namespace GUedang
{
    public class RiwayatGudang
    {
        public string Id { get; set; } = Guid.NewGuid().ToString("N");
        public DateTime Waktu { get; set; } = DateTime.Now;

        // "Masuk" | "Keluar" | "Penyesuaian"
        public string Jenis { get; set; } = "";

        public string KodeBarang { get; set; } = "";
        public string NamaBarang { get; set; } = "";

        // Masuk/Keluar: positif. Penyesuaian: selisih (boleh negatif).
        public int Jumlah { get; set; }

        public int StokAkhir { get; set; }
        public string Pihak { get; set; } = "";       // Supplier / Tujuan
        public string Keterangan { get; set; } = "";
        public string Oleh { get; set; } = "";        // username pelaku

        /// <summary>Jumlah dengan tanda: Masuk +, Keluar -, Penyesuaian apa adanya.</summary>
        [JsonIgnore]
        public int JumlahBertanda => Jenis switch
        {
            "Masuk" => Math.Abs(Jumlah),
            "Keluar" => -Math.Abs(Jumlah),
            _ => Jumlah
        };

        [JsonIgnore]
        public int StokAwal => StokAkhir - JumlahBertanda;
    }

    public static class StoreRiwayatGudang
    {
        private static readonly object _lock = new();
        private static readonly string _folder = Path.Combine(AppContext.BaseDirectory, "Data");
        private static readonly string _file = Path.Combine(_folder, "riwayat_gudang.json");
        private static readonly JsonSerializerOptions _opt = new() { WriteIndented = true };

        /// <summary>Boleh diisi saat login. Jika kosong, nama diambil dari Session.UserAktif.</summary>
        public static string PenggunaAktif { get; set; } = "";

        // nama pelaku yang dicatat di kolom Petugas
        private static string Pelaku =>
            !string.IsNullOrWhiteSpace(PenggunaAktif) ? PenggunaAktif
            : (Session.UserAktif?.Nama ?? "");

        public static List<RiwayatGudang> Semua()
        {
            lock (_lock)
            {
                try
                {
                    if (!File.Exists(_file)) return new List<RiwayatGudang>();
                    var json = File.ReadAllText(_file);
                    return JsonSerializer.Deserialize<List<RiwayatGudang>>(json) ?? new List<RiwayatGudang>();
                }
                catch
                {
                    return new List<RiwayatGudang>();
                }
            }
        }

        private static void Simpan(List<RiwayatGudang> data)
        {
            Directory.CreateDirectory(_folder);
            File.WriteAllText(_file, JsonSerializer.Serialize(data, _opt));
        }

        /// <summary>
        /// Jika entri yang baru saja dibuat otomatis (mis. oleh BarangStore) sudah ada,
        /// lengkapi Supplier/Tujuan, Keterangan, dan Petugasnya. Jika belum ada, buat entri baru.
        /// Aman dipakai tanpa takut tercatat dobel.
        /// </summary>
        public static void CatatAtauPerbarui(string jenis, string kode, string nama, int jumlah,
                                             int stokAkhir, string pihak = "", string keterangan = "")
        {
            lock (_lock)
            {
                var data = Semua();
                var cocok = data.LastOrDefault(x =>
                    x.Jenis == jenis &&
                    x.KodeBarang.Equals(kode, StringComparison.OrdinalIgnoreCase) &&
                    Math.Abs(x.Jumlah) == Math.Abs(jumlah) &&
                    (DateTime.Now - x.Waktu).TotalSeconds < 10);

                if (cocok != null)
                {
                    cocok.Pihak = pihak;
                    cocok.Keterangan = keterangan;
                    if (string.IsNullOrWhiteSpace(cocok.Oleh)) cocok.Oleh = Pelaku;
                    Simpan(data);
                }
                else
                {
                    Catat(jenis, kode, nama, jumlah, stokAkhir, pihak, keterangan);
                }
            }
        }

        public static void Catat(string jenis, string kode, string nama, int jumlah,
                                 int stokAkhir, string pihak = "", string keterangan = "")
        {
            lock (_lock)
            {
                var data = Semua();
                data.Add(new RiwayatGudang
                {
                    Waktu = DateTime.Now,
                    Jenis = jenis,
                    KodeBarang = kode,
                    NamaBarang = nama,
                    Jumlah = jumlah,
                    StokAkhir = stokAkhir,
                    Pihak = pihak,
                    Keterangan = keterangan,
                    Oleh = Pelaku
                });
                Simpan(data);
            }
        }
    }
}