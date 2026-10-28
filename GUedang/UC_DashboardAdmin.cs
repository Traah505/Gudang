using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GUedang
{
    public partial class UC_DashboardAdmin : UserControl
    {
        public UC_DashboardAdmin()
        {
            InitializeComponent();
        }

        private void roundedButtonDashboard_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            roundedButtonDashboard.BackColor = Color.DodgerBlue;
        }
        private void roundedButtonUser_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            roundedButtonUser.BackColor = Color.DodgerBlue;
        }
        private void roundedButtonBarang_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            roundedButtonBarang.BackColor = Color.DodgerBlue;
        }
        private void roundedButtonLaporan_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            roundedButtonLaporan.BackColor = Color.DodgerBlue;
        }

        private void ResetButtonColors()
        {
            roundedButtonDashboard.BackColor = Color.DarkSlateGray;
            roundedButtonUser.BackColor = Color.DarkSlateGray;
            roundedButtonLaporan.BackColor = Color.DarkSlateGray;
            roundedButtonBarang.BackColor = Color.DarkSlateGray;
        }

        private void TmpilkanHalaman(UserControl Halaman)
        {
            panelContent2.Controls.Clear();
            Halaman.Dock = DockStyle.Fill;
            panelContent2.Controls.Add(Halaman);
        }

        private void roundedButtonUser_Click_2(object sender, EventArgs e)
        {
            UC_User halamanUser = new UC_User();
            TmpilkanHalaman(halamanUser);
        }

        private void roundedPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblJumlahUser_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
