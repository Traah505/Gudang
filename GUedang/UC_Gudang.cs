using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GUedang
{
    public partial class UC_Gudang : UserControl
    {
        public UC_Gudang()
        {
            InitializeComponent();
        }
        private void TampilkanHalaman(UserControl Halaman)
        {
            panelGudang.Controls.Clear();
            Halaman.Dock = DockStyle.Fill;
            panelGudang.Controls.Add(Halaman);
        }


        private void UC_Gudang_Load(object sender, EventArgs e)
        {

        }
        private void ResetButtonColors()
        {
            roundedButtonGudang.BackColor = Color.Navy;
            roundedButtonBRGMSK.BackColor = Color.Navy;
            roundedButtonBRGKLR.BackColor = Color.Navy;
            roundedButtonStok.BackColor = Color.Navy;
            roundedButtonGNTPWGD.BackColor = Color.Navy;

        }

        private void roundedButtonGudang_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            roundedButtonGudang.BackColor = Color.DodgerBlue;
            UC_DSHBRDGudang halamanGudang = new UC_DSHBRDGudang();
            TampilkanHalaman(halamanGudang);
        }

        private void roundedButtonBRG_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            roundedButtonBRGMSK.BackColor = Color.DodgerBlue;
            UC_BRGGudang halamanGudang = new UC_BRGGudang();
            TampilkanHalaman(halamanGudang);
        }

        private void roundedButtonGNTPWGD_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            roundedButtonGNTPWGD.BackColor = Color.DodgerBlue;
            UC_GANTIPWGudang halamanGudang = new UC_GANTIPWGudang();
            TampilkanHalaman(halamanGudang);
        }

        private void roundedButtonBRGKLR_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            roundedButtonBRGKLR.BackColor = Color.DodgerBlue;
            UC_BarangKeluar halamanGudang = new UC_BarangKeluar();
            TampilkanHalaman(halamanGudang);
        }

        private void roundedButtonStok_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            roundedButtonStok.BackColor = Color.DodgerBlue;
            UC_StokBarangGudang halamanGudang = new UC_StokBarangGudang();
            TampilkanHalaman(halamanGudang);
        }
    }
}
