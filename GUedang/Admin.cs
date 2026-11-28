using Microsoft.VisualBasic.ApplicationServices;
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

            // 1) Gambar dekorasi menutupi seluruh panel header dan ikut melebar saat form di-resize
            pictureBox3.Dock = DockStyle.Fill;
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;

            // 2) Semua kontrol yang menimpa dekorasi dipindah menjadi anak pictureBox3.
            //    Kontrol 'transparan' di WinForms hanya melihat milik parent-nya,
            //    jadi parent-nya harus gambar dekorasi itu sendiri.
            PindahkanKeLatar(pictureBox3,
                pictureBox1,      // logo SMK Mart
                pictureBox2,      // ikon user
                lblAdmin,         // nama admin
                label2,           // "Selamat datang, ..."
                panel2,           // garis pemisah hitam
                roundedButton1);  // tombol Keluar
        }

        private static void PindahkanKeLatar(Control latar, params Control[] daftar)
        {
            foreach (var c in daftar)
            {
                // simpan posisi di layar, lalu hitung ulang relatif terhadap parent baru
                Point posisi = latar.PointToClient(c.Parent!.PointToScreen(c.Location));
                c.Parent = latar;
                c.Location = posisi;

                // panel2 (garis hitam) dan tombol tetap berwarna aslinya
                if (c is not Panel && c is not Button)
                    c.BackColor = Color.Transparent;
            }
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
                Sesi.Logout();
               
                if (Session.UserAktif != null)
                {
                    AktivitasStore.Catat(
                        Session.UserAktif.Nama,
                        Session.UserAktif.Role.ToString(),
                        "Logout"
                    );
                }
                Form admin = this.FindForm();
                LoginAkun dashboardLogin = new LoginAkun();
                dashboardLogin.Show();

                if (admin != null)
                {
                    admin.Close();
                }

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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}