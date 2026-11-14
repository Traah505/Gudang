using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GUedang
{
    public partial class UC_DSHBRDKasir : UserControl
    {
        public UC_DSHBRDKasir()
        {
            InitializeComponent();
            VisibleChanged += (s, e) => { if (Visible) MuatDashboard(); };
        }

        private void MuatDashboard()
        {
            if (DesignMode || LicenseManager.UsageMode == LicenseUsageMode.Designtime) return;

            var jual = PenjualanStore.Muat();
            var hariIni = jual.Where(t => t.Waktu.Date == DateTime.Today).ToList();

            lblTotalTransaksi.Text = hariIni.Count.ToString();
            lblTotalPendapatan.Text = "Rp " + hariIni.Sum(t => t.Total).ToString("N0");
            lblBarangTerjual.Text = hariIni.Sum(t => t.Items.Sum(i => i.Jumlah)).ToString("0.##");
            lblUserAktif.Text = UserStore.Muat().Count(u => u.Aktif).ToString();

            // tabel Transaksi Terbaru (kolom: No, Tanggal, Nama Kasir, Total)
            dgvTransaksiTerbaru.Rows.Clear();
            int no = 1;
            foreach (var t in jual.OrderByDescending(x => x.Waktu).Take(10))
                dgvTransaksiTerbaru.Rows.Add(no++, t.Waktu.ToString("dd/MM/yyyy HH:mm"), t.Kasir, t.Total.ToString("N0"));
        }
        private void roundedPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelKasir_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
