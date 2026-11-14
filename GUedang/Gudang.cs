using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GUedang
{
    public partial class Gudang : UserControl
    {
        public Gudang()
        {
            InitializeComponent();
            lblGudang.Text = Sesi.NamaUser;
            UC_Gudang dashboardAdmin = new UC_Gudang();
            dashboardAdmin.Controls.Clear();
            panelGudang.Controls.Clear();
            panelGudang.Controls.Add(dashboardAdmin);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void BukaHalaman(UserControl halaman)
        {
            panelGudang.Controls.Clear();

            halaman.Dock = DockStyle.Fill;

            panelGudang.Controls.Add(halaman);
        }

        private void Gudang_Load(object sender, EventArgs e)
        {
            UC_Gudang halamanGudang = new UC_Gudang();
            halamanGudang.Dock = DockStyle.Fill;
            panelGudang.Controls.Clear();
            panelGudang.Controls.Add(halamanGudang);
        }

        private void roundedButton2_Click(object sender, EventArgs e)
        {
            DialogResult hasil = MessageBox.Show("Apakah Anda yakin ingin keluar?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (hasil == DialogResult.Yes)
            {
                LoginAkun DashboardLogin = new LoginAkun();
                DashboardLogin.Show();
                this.Hide();

            }
        }

        private void lblGudang_Click(object sender, EventArgs e)
        {
           
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
    }
}
