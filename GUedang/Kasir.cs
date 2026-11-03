using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GUedang
{
    public partial class Kasir : Form
    {
        public Kasir()
        {
            InitializeComponent();
   
            
            UC_Kasir dashboardAdmin = new UC_Kasir();
            dashboardAdmin.Dock = DockStyle.Fill;
            panelKasirHalaman.Controls.Add(dashboardAdmin);
        
        }

        private void panelKasirHalaman_Paint(object sender, PaintEventArgs e)
        {
        }
        private void BukaHalaman(UserControl halaman)
        {
            panelKasirHalaman.Controls.Clear();

            halaman.Dock = DockStyle.Fill;

            panelKasirHalaman.Controls.Add(halaman);
        }
    }
}
