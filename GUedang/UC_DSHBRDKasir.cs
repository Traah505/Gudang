using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace GUedang
{
    public partial class UC_DSHBRDKasir : UserControl
    {
        public UC_DSHBRDKasir()
        {
            InitializeComponent();
            VisibleChanged += (s, e) => { if (Visible) MuatDashboard(); };
        }

        private void MuatDashboard()
        {
            // isi lblTotalTransaksi.Text dst. di sini
        }

        private void roundedPanel2_Paint(object sender, PaintEventArgs e) { }
        private void panelKasir_Paint(object sender, PaintEventArgs e) { }
        
    }
}