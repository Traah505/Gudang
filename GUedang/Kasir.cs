using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GUedang
{
    public partial class Kasir : UserControl
    {
        public Kasir()
        {
            InitializeComponent();
            UC_Kasir dashoardKasir = new UC_Kasir();
            dashoardKasir.Dock = DockStyle.Fill;
            panelKasirHalaman.Controls.Add(dashoardKasir);

        }

        private void panelKasirHalaman_Paint(object sender, PaintEventArgs e)
        {
        }

        private void BukaHalaman(UserControl halaman)
        {
            panelKasirHalaman.Controls.Clear();

            halaman.Dock = DockStyle.Fill;

            panelKasirHalaman.Controls.Add(halaman);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Kasir_Load(object sender, EventArgs e)
        {
            UC_Kasir halamanKasir = new UC_Kasir();
            halamanKasir.Dock = DockStyle.Fill;
            panelKasirHalaman.Controls.Clear();
            panelKasirHalaman.Controls.Add(halamanKasir);
        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            DialogResult hasil = MessageBox.Show("Apakah Anda yakin ingin keluar?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (hasil == DialogResult.Yes)
            {
                LoginAkun DashboardLogin = new LoginAkun();
                DashboardLogin.Show();
                this.Hide();

            }
        }

        private void roundedButton1_Click_1(object sender, EventArgs e)
        {
            DialogResult hasil = MessageBox.Show("Apakah Anda yakin ingin keluar?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (hasil == DialogResult.Yes)
            {
                LoginAkun DashboardLogin = new LoginAkun();
                DashboardLogin.Show();
                this.Hide();


            }
        }

        private void lblKasir_Click(object sender, EventArgs e)
        {
            lblKasir.Text = lblKasir.Text.Replace("Kasir : ", "");
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void roundedButton1_Click_2(object sender, EventArgs e)
        {

        }
    }
}
