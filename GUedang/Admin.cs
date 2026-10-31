using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace GUedang
{
    public partial class Admin : Form
    {
        public Admin(string namaUser)
        {
            InitializeComponent();
            lblAdmin.Text = "Admin : " + namaUser;
            UC_DashboardAdmin dashboardAdmin = new UC_DashboardAdmin();
            dashboardAdmin.Dock = DockStyle.Fill;
            panelContent.Controls.Add(dashboardAdmin);
        }

        public Admin()
        {
            InitializeComponent();
            UC_DashboardAdmin dashboardAdmin = new UC_DashboardAdmin();
            dashboardAdmin.Dock = DockStyle.Fill;
            panelContent.Controls.Add(dashboardAdmin);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }
        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DashBoardkeranjang1 DashboardPengguna = new DashBoardkeranjang1(lblAdmin.Text.Replace("Admin : ", ""));
            DashboardPengguna.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            string pathFile = "logs.txt";
            string waktu = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            string username = "Admin";
            string aktivitas = "Mencatat aktivitas baru";
            string barisLog = $"{waktu} | {username} | {aktivitas}\n";
            System.IO.File.AppendAllText(pathFile, barisLog);
            MessageBox.Show("Catatan berhasil ditambahkan!");
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

        private void button5_Click(object sender, EventArgs e)
        {
            DashBoardkeranjang1 DashboardPengguna = new DashBoardkeranjang1(lblAdmin.Text.Replace("Admin : ", ""));
            DashboardPengguna.Show();
            this.Hide();
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
            Form1 loginForm = new Form1();
            loginForm.Show();
            this.Hide();
        }
    }
}