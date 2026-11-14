public class ModelTransaksi
{
    public DateTime Tanggal { get; set; }
    public string Kode { get; set; }
    public string Nama { get; set; }
    public string Jenis { get; set; }   // "Masuk", "Keluar", "Penyesuaian"
    public decimal Jumlah { get; set; }     // Penyesuaian: boleh negatif
    public decimal Harga { get; set; }
    public string Keterangan { get; set; }

    public decimal StokAkhir { get; set; }  // Hanya untuk Penyesuaian
}