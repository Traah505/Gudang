using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GUedang
{
    public partial class UC_DashboardAdmin : UserControl
    {
        public UC_DashboardAdmin()
        {
            InitializeComponent();
        }

        private void roundedButtonDashboard_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            roundedButtonDashboard.BackColor = Color.DodgerBlue;
            UC_Dashboard halamanDashboard = new UC_Dashboard();
            TampilkanHalaman(halamanDashboard);
        }
        private void roundedButtonUser_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            roundedButtonUser.BackColor = Color.DodgerBlue;
        }
        private void roundedButtonBarang_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            roundedButtonBarang.BackColor = Color.DodgerBlue;
        }
        private void roundedButtonLaporan_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            roundedButtonLaporan.BackColor = Color.DodgerBlue;
        }

        private void ResetButtonColors()
        {
            roundedButtonDashboard.BackColor = Color.Navy;
            roundedButtonUser.BackColor = Color.Navy;
            roundedButtonLaporan.BackColor = Color.Navy;
            roundedButtonBarang.BackColor = Color.Navy;
        }

        private void TampilkanHalaman(UserControl Halaman)
        {
            panelContent2.Controls.Clear();
            Halaman.Dock = DockStyle.Fill;
            panelContent2.Controls.Add(Halaman);
        }

        private void roundedButtonUser_Click_2(object sender, EventArgs e)
        {
            ResetButtonColors();
            roundedButtonUser.BackColor = Color.DodgerBlue;
            UC_User halamanUser = new UC_User();
            TampilkanHalaman(halamanUser);
        }

        private void roundedPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblJumlahUser_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void roundedButtonBarang_Click_1(object sender, EventArgs e)
        {
            ResetButtonColors();
            roundedButtonBarang.BackColor = Color.DodgerBlue;
            UC_Barang halamanBarang = new UC_Barang();
            TampilkanHalaman(halamanBarang);
        }

        private void roundedButtonLaporan_Click_1(object sender, EventArgs e)
        {
            ResetButtonColors();
            roundedButtonLaporan.BackColor = Color.DodgerBlue;
            UC_Laporan halamanLaporan = new UC_Laporan();
            TampilkanHalaman(halamanLaporan);
        }

        private void panelContent2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
