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
            roundedButtonBRG.BackColor = Color.Navy;

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
            roundedButtonBRG.BackColor = Color.DodgerBlue;
            UC_BRGGudang halamanGudang = new UC_BRGGudang();
            TampilkanHalaman(halamanGudang);
        }
    }
}
