using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System;
using System.Linq;
using System.Windows.Forms;

namespace GUedang
{
    public partial class UC_LaporanLaba : UserControl   // samakan nama class dengan file-mu
    {
        public UC_LaporanLaba()
        {
            InitializeComponent();
            Load += UC_LaporanLaba_Load;
            btnTampilkanLaba.Click += (s, e) => MuatLaporan();
            VisibleChanged += (s, e) => { if (Visible) MuatLaporan(); };
        }

        private void UC_LaporanLaba_Load(object sender, EventArgs e)
        {
            if (DesignMode || LicenseManager.UsageMode == LicenseUsageMode.Designtime) return;

            dgvLaporanLaba.AutoGenerateColumns = false;
            dgvLaporanLaba.AllowUserToAddRows = false;
            dgvLaporanLaba.ReadOnly = true;
            dgvLaporanLaba.RowHeadersVisible = false;
            dgvLaporanLaba.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLaporanLaba.Columns.Clear();
            dgvLaporanLaba.Columns.Add("colNo", "No");
            dgvLaporanLaba.Columns.Add("colTanggal", "Tanggal");
            dgvLaporanLaba.Columns.Add("colTransaksi", "Transaksi");
            dgvLaporanLaba.Columns.Add("colPenjualan", "Penjualan");
            dgvLaporanLaba.Columns.Add("colModal", "Modal");
            dgvLaporanLaba.Columns.Add("colLaba", "Laba");

            dtpTanggalAwal.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            dtpTanggalAkhir.Value = DateTime.Today;
            MuatLaporan();
        }

        private void MuatLaporan()
        {
            if (dgvLaporanLaba.Columns.Count == 0) return;

            DateTime awal = dtpTanggalAwal.Value.Date;
            DateTime akhir = dtpTanggalAkhir.Value.Date.AddDays(1).AddTicks(-1);

            var barang = BarangStore.Muat();
            var data = PenjualanStore.Muat()
                .Where(t => t.Waktu >= awal && t.Waktu <= akhir)
                .OrderBy(t => t.Waktu).ToList();

            decimal totalJual = 0, totalModal = 0;
            dgvLaporanLaba.Rows.Clear();
            int no = 1;

            foreach (var t in data)
            {
                // transaksi lama belum punya HargaBeli: pakai harga beli barang saat ini
                decimal modal = t.Items.Sum(i =>
                {
                    decimal hb = i.HargaBeli;
                    if (hb == 0)
                        hb = barang.FirstOrDefault(b => b.KodeBarang == i.Kode)?.HargaBeli ?? 0;
                    return i.Jumlah * hb;
                });

                decimal laba = t.Total - modal;
                totalJual += t.Total;
                totalModal += modal;

                dgvLaporanLaba.Rows.Add(no++, t.Waktu.ToString("dd/MM/yyyy HH:mm"), t.NoTransaksi,
                    t.Total.ToString("N0"), modal.ToString("N0"), laba.ToString("N0"));
            }

            decimal totalLaba = totalJual - totalModal;
            lblTotalPenjualan.Text =  totalJual.ToString("N0");
            lblTotalBarangTerjual.Text =  totalModal.ToString("N0");
            lblTotalLaba.Text =  totalLaba.ToString("N0");
            lblPersentase.Text = (totalJual > 0 ? totalLaba / totalJual * 100 : 0).ToString("0.##") + "%";
        }
    }
}