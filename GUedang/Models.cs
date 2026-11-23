using System;
using System.Collections.Generic;

namespace GUedang
{
    public class BarangItem
    {
        public string Kode { get; set; }
        public string Nama { get; set; }
        public string Kategori { get; set; }
        public decimal HargaBeli { get; set; }
        public decimal HargaJual { get; set; }
        public int Stok { get; set; }
        public int Minimum { get; set; }

        public string StatusStok
        {
            get
            {
                if (Stok <= 0) return "Habis";
                if (Stok <= Minimum) return "Menipis";
                return "Aman";
            }
        }
    }

    public class DetailTransaksiItem
    {
        public string KodeBarang { get; set; }
        public string NamaBarang { get; set; }
        public int Qty { get; set; }
        public decimal HargaSatuan { get; set; }
        public decimal HargaModal { get; set; }
        public decimal Subtotal { get; set; }
    }

    public class TransaksiItem
    {
        public string KodeTransaksi { get; set; }
        public DateTime Tanggal { get; set; }
        public string NamaKasir { get; set; }
        public string MetodeBayar { get; set; }
        public decimal Subtotal { get; set; }
        public decimal Diskon { get; set; }
        public decimal TotalHarga { get; set; }
        public decimal UangDiterima { get; set; }
        public decimal Kembalian { get; set; }
        public List<DetailTransaksiItem> Items { get; set; } = new List<DetailTransaksiItem>();
    }

    public class RiwayatGudangItem
    {
        public DateTime TanggalWaktu { get; set; }
        public string JenisTransaksi { get; set; } // "Barang Masuk", "Barang Keluar", "Penyesuaian"
        public string KodeBarang { get; set; }
        public string NamaBarang { get; set; }
        public int Jumlah { get; set; }
        public decimal HargaSatuan { get; set; }
        public decimal TotalNilai { get; set; }
        public int StokAkhir { get; set; }
        public string SupplierTujuan { get; set; }
        public string Keterangan { get; set; }
        public string Petugas { get; set; }
    }

    public class LogAktivitasItem
    {
        public DateTime Waktu { get; set; }
        public string Role { get; set; }
        public string NamaUser { get; set; }
        public string Aktivitas { get; set; }
    }

    public class DatabaseJson
    {
        public List<BarangItem> Barang { get; set; } = new List<BarangItem>();
        public List<TransaksiItem> Transaksi { get; set; } = new List<TransaksiItem>();
        public List<RiwayatGudangItem> RiwayatGudang { get; set; } = new List<RiwayatGudangItem>();
        public List<LogAktivitasItem> LogAktivitas { get; set; } = new List<LogAktivitasItem>();
    }
}