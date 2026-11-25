using System.Text.Json;
using System.Text.Json.Serialization;

namespace GUedang
{
    public class BarangMasuk
    {
        public DateTime Tanggal { get; set; }
        public string Kode { get; set; } = "";
        public string Nama { get; set; } = "";
        public int Jumlah { get; set; }
        public decimal HargaBeli { get; set; }
        public string Supplier { get; set; } = "";
        public string Keterangan { get; set; } = "";
        public string Petugas { get; set; } = "";

        [JsonIgnore] public decimal Total => Jumlah * HargaBeli;
    }

    public static class BarangMasukStore
    {
        private static readonly object _lock = new();
        private static readonly string _folder = Path.Combine(AppContext.BaseDirectory, "Data");
        private static readonly string _file = Path.Combine(_folder, "barang_masuk.json");
        private static readonly JsonSerializerOptions _opt = new() { WriteIndented = true };

        public static List<BarangMasuk> GetAll()
        {
            lock (_lock) return Load();
        }

        public static void Tambah(BarangMasuk m)
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

        private static List<BarangMasuk> Load()
        {
            try
            {
                if (!File.Exists(_file)) return new();
                return JsonSerializer.Deserialize<List<BarangMasuk>>(File.ReadAllText(_file)) ?? new();
            }
            catch (JsonException) { return new(); }
        }
    }
}