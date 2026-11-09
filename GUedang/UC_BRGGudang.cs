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
            string kode = "BRG-" + DateTime.Now.ToString("yyyyMMddHHmmss");

            string namaBarang = txtNamaBarang.Text.Trim();
            string kategori = cmbKategori.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(namaBarang) || string.IsNullOrEmpty(kategori))
            {
                MessageBox.Show("Nama barang dan kategori harus diisi.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(!int.TryParse(numStokAwal.Text.Trim(), out int stokAwal) || stokAwal < 0)
            {
                MessageBox.Show("Stok awal harus berupa angka .", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
                
            }
            List<ModelBarang> daftarBarang = HelperJson.BacaData<ModelBarang>("DataBarang.json");
            daftarBarang.Add(new ModelBarang
            {
                NamaBarang = namaBarang,
                Kategori = kategori,
                Stok = stokAwal,
            });
            HelperJson.SimpanData("DataBarang.json", daftarBarang); 
        }

        private void dgvBarang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
