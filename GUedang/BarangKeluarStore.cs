using System.Text.Json;
using System.Text.Json.Serialization;

namespace GUedang
{
    public class BarangKeluar
    {
        public DateTime Tanggal { get; set; }
        public string Kode { get; set; } = "";
        public string Nama { get; set; } = "";
        public int Jumlah { get; set; }
        public decimal HargaBeli { get; set; }     // harga beli saat barang keluar
        public string Tujuan { get; set; } = "";
        public string Keterangan { get; set; } = "";
        public string Petugas { get; set; } = "";

        [JsonIgnore] public decimal Nilai => Jumlah * HargaBeli;
    }

    public static class BarangKeluarStore
    {
        private static readonly object _lock = new();
        private static readonly string _folder = Path.Combine(AppContext.BaseDirectory, "Data");
        private static readonly string _file = Path.Combine(_folder, "barang_keluar.json");
        private static readonly JsonSerializerOptions _opt = new() { WriteIndented = true };

        public static List<BarangKeluar> GetAll()
        {
            lock (_lock) return Load();
        }

        public static void Tambah(BarangKeluar m)
        {
            lock (_lock)
            {
                var list = Load();
                list.Add(m);
                Directory.CreateDirectory(_folder);
                string tmp = _file + ".tmp";
                File.WriteAllText(tmp, JsonSerializer.Serialize(list, _opt));
                File.Move(tmp, _file, true);
            }
        }

        private static List<BarangKeluar> Load()
        {
            try
            {
                if (!File.Exists(_file)) return new();
                return JsonSerializer.Deserialize<List<BarangKeluar>>(File.ReadAllText(_file)) ?? new();
            }
            catch (JsonException) { return new(); }
        }
    }
}