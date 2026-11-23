namespace GUedang
{
    public class BarisLaba
    {
        public string Kelompok { get; set; } = "";
        public int Transaksi { get; set; }
        public decimal Penjualan { get; set; }
        public decimal Modal { get; set; }
        public decimal Laba => Penjualan - Modal;
        public decimal Margin => Penjualan == 0 ? 0 : Laba / Penjualan * 100m;
    }

    public class HasilLaba
    {
        public List<BarisLaba> Baris { get; set; } = new();
        public decimal TotalPenjualan => Baris.Sum(b => b.Penjualan);
        public decimal TotalModal => Baris.Sum(b => b.Modal);
        public decimal TotalLaba => TotalPenjualan - TotalModal;
        public decimal Persen => TotalPenjualan == 0 ? 0 : TotalLaba / TotalPenjualan * 100m;
    }

    /// <summary>
    /// Hanya menghitung (tidak menyimpan apa pun). Sumber data: TransaksiStore.
    /// Laba = (Harga - HargaBeli) x Qty, memakai HargaBeli snapshot saat transaksi.
    /// </summary>
    public static class LabaStore
    {
        public static HasilLaba Hitung(DateTime dari, DateTime sampai, bool perBarang)
        {
            var data = TransaksiStore.GetByPeriode(dari, sampai);
            var hasil = new HasilLaba();

            if (!perBarang)
            {
                hasil.Baris = data
                    .GroupBy(t => t.Tanggal.Date)
                    .OrderBy(g => g.Key)
                    .Select(g => new BarisLaba
                    {
                        Kelompok = g.Key.ToString("dd/MM/yyyy"),
                        Transaksi = g.Count(),
                        Penjualan = g.Sum(t => t.Detail.Sum(d => d.Harga * d.Qty)),
                        Modal = g.Sum(t => t.Detail.Sum(d => d.HargaBeli * d.Qty))
                    }).ToList();
            }
            else
            {
                hasil.Baris = data
                    .SelectMany(t => t.Detail.Select(d => new { t.Kode, Detail = d }))
                    .GroupBy(x => x.Detail.NamaBarang)
                    .Select(g => new BarisLaba
                    {
                        Kelompok = g.Key,
                        Transaksi = g.Select(x => x.Kode).Distinct().Count(),
                        Penjualan = g.Sum(x => x.Detail.Harga * x.Detail.Qty),
                        Modal = g.Sum(x => x.Detail.HargaBeli * x.Detail.Qty)
                    })
                    .OrderByDescending(b => b.Laba)
                    .ToList();
            }
            return hasil;
        }

        public static DateTime TanggalPertama()
        {
            var all = TransaksiStore.GetAll();
            return all.Count == 0 ? DateTime.Today : all.Min(t => t.Tanggal).Date;
        }
    }
}