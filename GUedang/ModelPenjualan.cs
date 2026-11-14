using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace GUedang
{
    public class ItemJual
    {
        public string Kode { get; set; }
        public string Nama { get; set; }
        public decimal Jumlah { get; set; }
        public decimal Harga { get; set; }
        [JsonIgnore] public decimal Subtotal => Jumlah * Harga;
    }

    public class ModelPenjualan
    {
        public string NoTransaksi { get; set; }
        public DateTime Waktu { get; set; }
        public string Kasir { get; set; }
        public List<ItemJual> Items { get; set; } = new List<ItemJual>();
        public decimal Total { get; set; }
        public decimal Bayar { get; set; }
    }
}
