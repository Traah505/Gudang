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

        public decimal Diskon { get; set; }            // dalam rupiah
        public string Metode { get; set; } = "Tunai";  // Tunai | QRIS | Transfer
        public decimal Bayar { get; set; }
        public decimal Kembali { get; set; }

        public List<DetailTransaksi> Detail { get; set; } = new();

        [JsonIgnore] public decimal Subtotal => Detail.Sum(d => d.Subtotal);   // sebelum diskon
        [JsonIgnore] public decimal Total => Subtotal - Diskon;                // yang dibayar pelanggan
        [JsonIgnore] public int TotalItem => Detail.Sum(d => d.Qty);
        [JsonIgnore] public decimal Laba => Detail.Sum(d => d.Laba) - Diskon;
    }
}