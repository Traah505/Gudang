using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GUedang
{
    public partial class UC_BarangKeluar : UserControl
    {
        public UC_BarangKeluar()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
           
            bool ok = BarangStore.UbahStok(txtCariKeluar.Text.Trim(), "Keluar",
                numJumlah.Value, 0,
                txtKeteranganKeluar.Text.Trim(), out string pesan);
            MessageBox.Show(pesan, "Barang Keluar", MessageBoxButtons.OK,
                ok ? MessageBoxIcon.Information : MessageBoxIcon.Warning);
            if (ok) { numJumlah.Value = 0; txtKeteranganKeluar.Text = ""; MuatRiwayat(); }
        }

        private void MuatRiwayat()
        {
            var log = HelperJson.BacaData<ModelTransaksi>("DataTransaksi.json")
                                .Where(t => t.Jenis == "Keluar").ToList();
            dgvRiwayatKeluar.Rows.Clear();
            int no = 1;
            foreach (var t in log)
                dgvRiwayatKeluar.Rows.Add(no++, t.Tanggal.ToString("dd/MM/yyyy"), t.Kode, t.Nama,
                                    t.Jumlah, t.Harga, t.Keterangan);
            lblBarangKeluar.Text = log.Sum(t => t.Jumlah) + " Barang";
            lblTotalPengeluaran.Text = "Rp " + log.Sum(t => t.Jumlah * t.Harga).ToString("N0");
        }
    }
    
}
