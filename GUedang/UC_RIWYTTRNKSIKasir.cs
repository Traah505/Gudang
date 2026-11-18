using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GUedang
{
    public partial class UC_RIWYTTRNKSIKasir : UserControl
    {
        public UC_RIWYTTRNKSIKasir()
        {
            InitializeComponent();


            roundedPanel1.PanelColor = Color.RoyalBlue;
            roundedPanel2.PanelColor = Color.DeepSkyBlue;
        }

        private void btnCetakLaporan_Click(object sender, EventArgs e)
        {

        }

        private void lblNominalTransaksi_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void MuatRiwayat()
        {
            var data = PenjualanStore.Muat()
                .Where(t => t.Waktu.Date == dtpTransaksi.Value.Date).ToList();
            dgvRiwayatTransaksi.Rows.Clear();
            foreach (var t in data)
                dgvRiwayatTransaksi.Rows.Add(t.NoTransaksi, t.Waktu.ToString("HH:mm"), t.Kasir,
                    t.Items.Sum(i => i.Jumlah).ToString("0.##"), t.Total.ToString("N0"));
            lblPendapatan.Text = "Rp " + data.Sum(t => t.Total).ToString("N0");
            lblJumlahTransaksi.Text = data.Count.ToString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCetakLaporan_Click_1(object sender, EventArgs e)
        {
            if (dgvRiwayatTransaksi.CurrentRow == null)
            {
                MessageBox.Show("Pilih transaksi di tabel dulu.", "Cetak Struk");
                return;
            }

            string no = dgvRiwayatTransaksi.CurrentRow.Cells[0].Value?.ToString();
            var t = PenjualanStore.Muat().FirstOrDefault(x => x.NoTransaksi == no);

            if (t == null)
            {
                MessageBox.Show("Transaksi tidak ditemukan.", "Cetak Struk");
                return;
            }

            StrukPrinter.Tampilkan(t);
        }
    }
    
}
