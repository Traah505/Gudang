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
            timerTransaksi.Start();

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

        private void timerTransaksi_Tick(object sender, EventArgs e)
        {
            dtpTransaksi.Value = DateTime.Now;
        }
    }
}
