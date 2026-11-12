using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GUedang
{
    public partial class UC_LaporanAktivitas : UserControl
    {
        public UC_LaporanAktivitas()
        {
            InitializeComponent();

            string waktu = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panelLaporanAktivitas_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timerJam_Tick(object sender, EventArgs e)
        {
            dtpWaktu.Value = DateTime.Now;

        }
    }
}
