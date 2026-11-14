using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GUedang
{
    public partial class UC_Laporan : UserControl
    {
        public UC_Laporan()
        {
            InitializeComponent();
            Load += UC_Laporan_Load;
            btnTampilkan.Click += (s, e) => MuatLaporan();
            txtCariLaporan.TextChanged += (s, e) => MuatLaporan();
            VisibleChanged += (s, e) => { if (Visible) MuatLaporan(); };
        }

        private void UC_Laporan_Load(object sender, EventArgs e)
        {
            if (DesignMode || LicenseManager.UsageMode == LicenseUsageMode.Designtime) return;

            dgvLaporan.AutoGenerateColumns = false;
            dgvLaporan.AllowUserToAddRows = false;
            dgvLaporan.ReadOnly = true;
            dgvLaporan.RowHeadersVisible = false;
            dgvLaporan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLaporan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLaporan.Columns.Clear();
            dgvLaporan.Columns.Add("colNo", "No");
            dgvLaporan.Columns.Add("colKode", "Kode Transaksi");
            dgvLaporan.Columns.Add("colTanggal", "Tanggal");
            dgvLaporan.Columns.Add("colKasir", "Nama Kasir");
            dgvLaporan.Columns.Add("colTotal", "Total Harga");

            MuatLaporan();
        }

        private void MuatLaporan()
        {
            if (dgvLaporan.Columns.Count == 0) return;

            string cari = txtCariLaporan.Text.Trim().ToLower();
            var data = PenjualanStore.Muat()
                .Where(t => t.Waktu.Date == dtpTanggal.Value.Date)
                .Where(t => cari == "" ||
                            (t.NoTransaksi ?? "").ToLower().Contains(cari) ||
                            (t.Kasir ?? "").ToLower().Contains(cari))
                .OrderByDescending(t => t.Waktu)
                .ToList();

            dgvLaporan.Rows.Clear();
            int no = 1;
            foreach (var t in data)
                dgvLaporan.Rows.Add(no++, t.NoTransaksi,
                    t.Waktu.ToString("dd/MM/yyyy HH:mm"), t.Kasir, t.Total.ToString("N0"));

            lblTotalPendapatan.Text = "Rp " + data.Sum(t => t.Total).ToString("N0");
            lblJumlahTransaksi.Text = data.Count.ToString();
        }

        private void lblTitleLaporan_Click(object sender, EventArgs e)
        {

        }

        private void lblSampaiTanggal_Click(object sender, EventArgs e)
        {

        }

        

        private void btnTampilkan_Click(object sender, EventArgs e)
        {

        }
        private void TampilkanLaporanPenjualan()
        {
            // Nanti isi kode laporan penjualan di sini
        }

        private void TampilkanLaporanBarang()
        {
            // Nanti isi kode laporan barang di sini
        }

        private void TampilkanLaporanKasir()
        {
            // Nanti isi kode laporan kasir di sini
        }

        private void panelJumlahTransaksi_Paint(object sender, PaintEventArgs e)
        {

        }

        private void roundedPanel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
