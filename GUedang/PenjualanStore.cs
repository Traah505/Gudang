using System;
using System.Collections.Generic;
using System.Text;

namespace GUedang
{
    public static class PenjualanStore
    {
        const string File = "DataPenjualan.json";

        public static List<ModelPenjualan> Muat() =>
            HelperJson.BacaData<ModelPenjualan>(File);

        public static bool Bayar(string kasir, List<ItemJual> items, decimal uang, out string pesan)
        {
            if (items.Count == 0) { pesan = "Keranjang kosong."; return false; }
            decimal total = items.Sum(i => i.Subtotal);
            if (uang < total) { pesan = "Uang diterima kurang."; return false; }

            var barang = BarangStore.Muat();
            foreach (var it in items)
            {
                var b = barang.FirstOrDefault(x => x.KodeBarang == it.Kode);
                if (b == null || b.Stok < it.Jumlah)
                { pesan = "Stok " + it.Nama + " tidak cukup."; return false; }
            }

            string no = "TRX-" + DateTime.Now.ToString("yyyyMMddHHmmss");
            foreach (var it in items)
                BarangStore.UbahStok(it.Kode, "Keluar", it.Jumlah, it.Harga, "Terjual " + no, out _);

            var data = Muat();
            data.Add(new ModelPenjualan
            {
                NoTransaksi = no,
                Waktu = DateTime.Now,
                Kasir = kasir,
                Items = items,
                Total = total,
                Bayar = uang
            });
            HelperJson.SimpanData(File, data);

            pesan = "Transaksi " + no + " berhasil. Kembalian Rp " + (uang - total).ToString("N0");
            return true;
        }
    }
}
