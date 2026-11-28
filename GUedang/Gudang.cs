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

            lblGudang .BackColor = Color.Transparent;
            pictureBox2.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;

            PindahkanKeLatar(pictureBox3,
                pictureBox1,      // logo SMK Mart
                pictureBox2,      // ikon user
                lblGudang,         // nama admin
                label2,           // "Selamat datang, ..."
                panel2,           // garis pemisah hitam
                roundedButton1);  // tombol Keluar
        }

        private static void PindahkanKeLatar(Control latar, params Control[] daftar)
        {
            foreach (var c in daftar)
            {
                Point posisi = latar.PointToClient(c.Parent!.PointToScreen(c.Location));
                c.Parent = latar;
                c.Location = posisi;

                if (c is not Panel && c is not Button)
                    c.BackColor = Color.Transparent;
            }
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
                Sesi.Logout();
                LoginAkun DashboardLogin = new LoginAkun();
                DashboardLogin.Show();
                this.Hide();

                if (Session.UserAktif != null)
                {
                    AktivitasStore.Catat(
                        Session.UserAktif.Nama,
                        Session.UserAktif.Role.ToString(),
                        "Logout"
                    );
                }

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
