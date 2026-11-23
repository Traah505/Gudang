using System.Text.Json.Serialization;

namespace GUedang
{
    public class DetailTransaksi
    {
        public string KodeBarang { get; set; } = "";
        public string NamaBarang { get; set; } = "";   // snapshot nama saat transaksi
        public decimal Harga { get; set; }             // harga jual per unit saat transaksi
        public decimal HargaBeli { get; set; }         // snapshot harga beli (untuk Laporan Laba)
        public int Qty { get; set; }

        [JsonIgnore] public decimal Subtotal => Harga * Qty;
        [JsonIgnore] public decimal Laba => (Harga - HargaBeli) * Qty;
    }

    public class Transaksi
    {
        public string Kode { get; set; } = "";
        public DateTime Tanggal { get; set; } = DateTime.Now;
        public string Kasir { get; set; } = "";
        public List<DetailTransaksi> Detail { get; set; } = new();

        [JsonIgnore] public decimal Total => Detail.Sum(d => d.Subtotal);
        [JsonIgnore] public int TotalItem => Detail.Sum(d => d.Qty);
        [JsonIgnore] public decimal Laba => Detail.Sum(d => d.Laba);
    }
}