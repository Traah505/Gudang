using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace GUedang
{
    public partial class UC_DSHBRDKasir : UserControl
    {
        public UC_DSHBRDKasir()
        {
            InitializeComponent();
            Load += (s, e) => MuatDashboard();
            VisibleChanged += (s, e) => { if (Visible) MuatDashboard(); };
        }

        private void MuatDashboard()
        {
            if (DesignMode || LicenseManager.UsageMode == LicenseUsageMode.Designtime) return;

            if (dgvTransaksi.Columns.Count == 0)
            {
                dgvTransaksi.AutoGenerateColumns = false;
                dgvTransaksi.AllowUserToAddRows = false;
                dgvTransaksi.ReadOnly = true;
                dgvTransaksi.RowHeadersVisible = false;
                dgvTransaksi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvTransaksi.Columns.Add("colNo", "No Transaksi");
                dgvTransaksi.Columns.Add("colWaktu", "Waktu");
                dgvTransaksi.Columns.Add("colKasir", "Kasir");
                dgvTransaksi.Columns.Add("colTotal", "Total");
            }

            var hariIni = PenjualanStore.Muat()
                .Where(t => t.Waktu.Date == DateTime.Today)
                .OrderByDescending(t => t.Waktu).ToList();

            lblPendapatan.Text = "Rp " + hariIni.Sum(t => t.Total).ToString("N0");
            lblJumlahTransaksi.Text = hariIni.Count.ToString();
            lblItemTerjual.Text = hariIni.Sum(t => t.Items.Sum(i => i.Jumlah)).ToString("0.##");

            dgvTransaksi.Rows.Clear();
            foreach (var t in hariIni.Take(10))
                dgvTransaksi.Rows.Add(t.NoTransaksi, t.Waktu.ToString("HH:mm"), t.Kasir, t.Total.ToString("N0"));

            // "Keranjang Belanja Hari Ini" = total semua belanja hari ini
            lblKeranjangItem.Text = hariIni.Sum(t => t.Items.Count).ToString();
            lblKeranjangTotal.Text = "Rp " + hariIni.Sum(t => t.Total).ToString("N0");
        }
        



        private void roundedPanel2_Paint(object sender, PaintEventArgs e) { }
        private void panelKasir_Paint(object sender, PaintEventArgs e) { }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}