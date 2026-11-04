using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GUedang
{
    public partial class UC_KLLABRGGudang : UserControl
    {
        public UC_KLLABRGGudang()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvKelolaBarang.Rows[e.RowIndex];

            txtKode.Text = row.Cells["colKode"].Value?.ToString();
            txtNama.Text = row.Cells["colNama"].Value?.ToString();
            cmbKategori.Text = row.Cells["colKategori"].Value?.ToString();

            numHargaBeli.Value = Convert.ToDecimal(
                row.Cells["colHargaBeli"].Value ?? 0);

            numHargaJual.Value = Convert.ToDecimal(
                row.Cells["colHargaJual"].Value ?? 0);

            numStok.Value = Convert.ToDecimal(
                row.Cells["colStok"].Value ?? 0);
        }
    }
}
