using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GUedang
{
    public partial class UC_Laporan : UserControl
    {
        public UC_Laporan()
        {
            InitializeComponent();
        }

        private void lblTitleLaporan_Click(object sender, EventArgs e)
        {

        }

        private void lblSampaiTanggal_Click(object sender, EventArgs e)
        {

        }

        private void UC_Laporan_Load(object sender, EventArgs e)
        {
            cmbJenisLaporan.Items.Clear();

            cmbJenisLaporan.Items.Add("Penjualan");
            cmbJenisLaporan.Items.Add("Barang");
            cmbJenisLaporan.Items.Add("Kasir");

            cmbJenisLaporan.SelectedIndex = 0;
        }

        private void btnTampilkan_Click(object sender, EventArgs e)
        {
            string jenis = cmbJenisLaporan.Text;

            MessageBox.Show("Jenis laporan yang dipilih: " + jenis);
        }
        private void TampilkanLaporanPenjualan()
        {
            // Nanti isi kode laporan penjualan di sini
        }

        private void TampilkanLaporanBarang()
        {
            // Nanti isi kode laporan barang di sini
        }

        private void TampilkanLaporanKasir()
        {
            // Nanti isi kode laporan kasir di sini
        }
    }
}
