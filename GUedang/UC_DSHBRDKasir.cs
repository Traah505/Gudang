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
