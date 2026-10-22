using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUedang
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                textBox4.UseSystemPasswordChar = false;
            }
            else
            {
                textBox4.UseSystemPasswordChar = true;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                textBox3.UseSystemPasswordChar = false;
            }
            else
            {
                textBox3.UseSystemPasswordChar = true;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 1. Ambil data dari TextBox di Form Register
            // (Catatan: Sesuaikan nama 'textBox1', 'textBox2', dst. dengan nama asli di Properties Visual Studio kamu)
            string username = textBox21.Text.Trim();
            string password = textBox3.Text.Trim();
            string email = textBox4.Text.Trim();
            string noHp = textBox5.Text.Trim();

            // 2. Validasi sederhana agar kolom utama tidak kosong
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Username dan Password wajib diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // 3. Buat objek baru dari class Gacor
                Gacor akunBaru = new Gacor(username, password, email, noHp);

                // 4. Panggil method SaveToJson untuk langsung menyimpannya ke file Login.json
                akunBaru.SaveToJson("Login.json");

                MessageBox.Show("Akun berhasil didaftarkan dan disimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // 5. Bersihkan form setelah berhasil mendaftar (opsional)
                textBox21.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();

                 Form1 loginForm = new Form1();
                 loginForm.Show();
                 this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
