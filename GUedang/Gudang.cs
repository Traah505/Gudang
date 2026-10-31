using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GUedang
{
    public partial class Gudang : Form
    {
        public Gudang()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void BukaHalaman(UserControl halaman)
        {
            panelGudang.Controls.Clear();

            halaman.Dock = DockStyle.Fill;

            panelGudang.Controls.Add(halaman);
        }
    }
}
