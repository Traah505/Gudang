using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GUedang
{
    public partial class UC_Kasir : UserControl

    {
        private UC_KRNJGBLNJKasir _ucKeranjang = null!;
        private UC_RIWYTTRNKSIKasir _ucRiwayat = null!;

        private string _namaKasir = "kasir";

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string NamaKasir
        {
            get => _namaKasir;
            set
            {
                _namaKasir = value;
                if (_ucKeranjang != null) _ucKeranjang.NamaKasir = value;
                if (_ucRiwayat != null) _ucRiwayat.NamaKasir = value;
            }
        }
        public UC_Kasir()
        {
            InitializeComponent();

            // Buat objek terlebih dahulu
            _ucKeranjang = new UC_KRNJGBLNJKasir();
            _ucRiwayat = new UC_RIWYTTRNKSIKasir();

            // Atur nama kasir
            _ucKeranjang.NamaKasir = _namaKasir;
            _ucRiwayat.NamaKasir = _namaKasir;

            // Hubungkan transaksi selesai
            _ucKeranjang.TransaksiSelesai += trx =>
            {
                TampilkanMenu(_ucRiwayat);
                _ucRiwayat.PilihTransaksi(trx.Kode);
            };
        }
        private void TampilkanMenu(UserControl uc)
        {
            panelKasir.Controls.Clear();   // ganti pnlKonten dengan nama panel putih kamu
            panelKasir.Controls.Add(uc);
        }
        private void TampilkanHalaman(UserControl Halaman)
        {
            panelKasir.Controls.Clear();
            Halaman.Dock = DockStyle.Fill;
            panelKasir.Controls.Add(Halaman);
        }
        private void roundedButtonDSHBRDKasir_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            roundedButtonDSHBRDKasir.BackColor = Color.DodgerBlue;
            UC_DSHBRDKasir halamanDashboard = new UC_DSHBRDKasir();
            TampilkanHalaman(halamanDashboard);
        }
        private void ResetButtonColors()
        {
            roundedButtonDSHBRDKasir.BackColor = Color.Navy;
            roundedButtonKRNJGBLNJKasir.BackColor = Color.Navy;
            roundedButtonRIWYTTRNKSIKasir.BackColor = Color.Navy;
            roundedButtonGANTIPWKasir.BackColor = Color.Navy;

        }
        private void roundedButtonKRNJGBLNJKasir_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            roundedButtonKRNJGBLNJKasir.BackColor = Color.DodgerBlue;

            TampilkanHalaman(_ucKeranjang);
        }

        private void roundedButtonRIWYTTRNKSIKasir_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            roundedButtonRIWYTTRNKSIKasir.BackColor = Color.DodgerBlue;

            TampilkanHalaman(_ucRiwayat);
        }


        private void panelKasir_Paint(object sender, PaintEventArgs e)
        {

        }
        
        private void UC_Kasir_Load(object sender, EventArgs e)
        {

        }
        private void btnKeranjang_Click(object sender, EventArgs e) => TampilkanMenu(_ucKeranjang);
        private void btnRiwayat_Click(object sender, EventArgs e) => TampilkanMenu(_ucRiwayat);
        private void roundedButtonGANTIPWKasir_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            roundedButtonGANTIPWKasir.BackColor = Color.DodgerBlue;
            UC_GANTIPWKasir halamanDashboard = new UC_GANTIPWKasir();
            TampilkanHalaman(halamanDashboard);
        }
    }
}
