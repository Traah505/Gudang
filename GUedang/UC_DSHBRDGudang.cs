using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GUedang
{
    public partial class UC_DSHBRDGudang : UserControl
    {
        public UC_DSHBRDGudang()
        {
            InitializeComponent();
            dgvPerhatian.ColumnHeadersVisible = false;
            dgvPerhatian.RowHeadersVisible = false;
            dgvPerhatian.AllowUserToAddRows = false;
            dgvPerhatian.ReadOnly = true;
            dgvPerhatian.BorderStyle = BorderStyle.None;
            dgvPerhatian.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvPerhatian.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPerhatian.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPerhatian.RowTemplate.Height = 40;

            roundedPanel4.PanelColor = Color.Azure;
            roundedPanel5.PanelColor = Color.Lavender;
            roundedPanel6.PanelColor = Color.Honeydew;
            roundedPanel7.PanelColor = Color.AliceBlue;

        }

        private void chartStokBarang_Click(object sender, EventArgs e)
        {

        }

        private void UC_DSHBRDGudang_Load(object sender, EventArgs e)
        {

        }

        private void roundedPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void dgvPerhatian_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dgvPerhatian.Columns["Status"].Index)
            {
                string s = Convert.ToString(e.Value);
                e.CellStyle.ForeColor = s == "Habis"
                    ? Color.FromArgb(185, 28, 28)    // merah
                    : Color.FromArgb(133, 77, 14);   // kuning tua
            }
        }
        private void dgvPerhatian_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
