using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GUedang
{
    public partial class UC_BRGGudang : UserControl
    {
        public UC_BRGGudang()
        {
            InitializeComponent();
        }

        private void btnTambahBarang_Click(object sender, EventArgs e)
        {

        }

        private void dgvBarang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void roundedPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            
            bool ok = BarangStore.UbahStok(txtNamaAtauKode.Text.Trim(), "Masuk",
                (int)numJumlah.Value, decimal.TryParse(txtHargaBeli.Text, out var h) ? h : 0,
                txtKeterangan.Text.Trim(), out string pesan);
            MessageBox.Show(pesan, "Barang Masuk", MessageBoxButtons.OK,
                ok ? MessageBoxIcon.Information : MessageBoxIcon.Warning);
            if (ok) { numJumlah.Value = 0; txtKeterangan.Text = ""; MuatRiwayat(); }
        }

        private void MuatRiwayat()
        {
            var log = HelperJson.BacaData<ModelTransaksi>("DataTransaksi.json")
                                .Where(t => t.Jenis == "Masuk").ToList();
            dgvBarang.Rows.Clear();
            int no = 1;
            foreach (var t in log)
                dgvBarang.Rows.Add(no++, t.Tanggal.ToString("dd/MM/yyyy"), t.Kode, t.Nama,
                                    t.Jumlah, t.Harga, t.Keterangan);
            lbl.Text = log.Sum(t => t.Jumlah) + " Barang";
            lblTotalNilai.Text = "Rp " + log.Sum(t => t.Jumlah * t.Harga).ToString("N0");
        }
    }
    
}
