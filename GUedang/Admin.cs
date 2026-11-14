using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Text;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace GUedang
{
    public partial class Admin : UserControl
    {
        public Admin(string namaUser)
        {
            InitializeComponent();
            lblAdmin.Text = Sesi.NamaUser;
            UC_DashboardAdmin dashboardAdmin = new UC_DashboardAdmin();
            dashboardAdmin.Dock = DockStyle.Fill;
            panelContent.Controls.Clear();
            panelContent.Controls.Add(dashboardAdmin);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            lblAdmin.Text = Sesi.NamaUser;
        }


        private void flowLayoutPanel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BukaHalaman(UserControl halaman)
        {
            panelContent.Controls.Clear();

            halaman.Dock = DockStyle.Fill;

            panelContent.Controls.Add(halaman);
        }
        private void panel3_Paint(object sender, PaintEventArgs e)
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void roundedPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}