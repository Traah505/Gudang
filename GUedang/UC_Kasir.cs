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
        public UC_Kasir()
        {
            InitializeComponent();
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
            UC_Dashboard halamanDashboard = new UC_Dashboard();
            TampilkanHalaman(halamanDashboard);
        }
        private void ResetButtonColors()
        {
            roundedButtonDSHBRDKasir.BackColor = Color.Navy;
            roundedButtonKRNJGBLNJKasir.BackColor = Color.Navy;
            roundedButtonRIWYTTRNKSIKasir.BackColor = Color.Navy;

        }

        private void roundedButtonKRNJGBLNJKasir_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            roundedButtonKRNJGBLNJKasir.BackColor = Color.DodgerBlue;
            UC_KRNJGBLNJKasir halamanDashboard = new UC_KRNJGBLNJKasir();
            TampilkanHalaman(halamanDashboard);
        }

        private void roundedButtonRIWYTTRNKSIKasir_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            roundedButtonRIWYTTRNKSIKasir.BackColor = Color.DodgerBlue;
            UC_RIWYTTRNKSIKasir halamanDashboard = new UC_RIWYTTRNKSIKasir();
            TampilkanHalaman(halamanDashboard);
        }
    }
}
