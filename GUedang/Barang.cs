using System.Text.Json.Serialization;

namespace GUedang
{
    public class Barang
    {
        public string Kode { get; set; } = "";
        public string Nama { get; set; } = "";
        public string Kategori { get; set; } = "";
        public string Satuan { get; set; } = "";
        public decimal HargaBeli { get; set; }
        public decimal HargaJual { get; set; }
        public int Stok { get; set; }
        public int StokMinimum { get; set; }

        // Dihitung otomatis, tidak disimpan ke JSON
        [JsonIgnore]
        public string Status =>
            Stok <= 0 ? "Habis" :
            Stok <= StokMinimum ? "Menipis" : "Aman";

        [JsonIgnore]
        public decimal NilaiPersediaan => Stok * HargaBeli;
    }
}