using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GUedang
{
    public partial class DashBoardkeranjang1 : Form
    {
        public DashBoardkeranjang1(string namaUser)
        {
            InitializeComponent();
            lblTanggal.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy");
            lblTanggal.Font = new Font("Segoe UI", 10F, FontStyle.Bold);

        }
        private void HitungRingkasan()
        {
            int totalItem = 0;
            decimal totalHarga = 0;

            foreach (DataGridViewRow row in dgvKeranjang.Rows)
            {
                if (row.IsNewRow) continue;

                int jumlah = Convert.ToInt32(
                    row.Cells["colJumlah"].Value
                );

                decimal harga = Convert.ToDecimal(
                    row.Cells["colHarga"].Value
                );

                totalItem += jumlah;
                totalHarga += harga * jumlah;
            }

            lblTotalItem.Text = totalItem.ToString();
            lblTotalHarga.Text = totalHarga.ToString("C0");
        }
        private void HitungKembalian()
        {
            decimal totalHarga = 0;
            decimal jumlahBayar = 0;

            decimal.TryParse(
                lblTotalHarga.Text.Replace("Rp", "").Trim(),
                out totalHarga
            );

            decimal.TryParse(
                txtJumlahBayar.Text,
                out jumlahBayar
            );

            decimal kembalian = jumlahBayar - totalHarga;

            lblKembalian.Text = kembalian >= 0
                ? kembalian.ToString("C0")
                : "Uang kurang";
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel19_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {

        }

        private void label39_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblTanggal_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void roundedTextBox1_TextChanged(object sender, EventArgs e)
        {
            HitungKembalian();
        }

        private void btnProsesPembayaran_Click(object sender, EventArgs e)

        {
            HitungKembalian();

            if (lblKembalian.Text == "Uang kurang")
            {
                MessageBox.Show("Uang pembayaran belum cukup!");
                return;
            }

            MessageBox.Show("Pembayaran berhasil!");
        }
    }
    
}
