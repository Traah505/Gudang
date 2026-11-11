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
        private const string PhCari = "Cari Kode atau Nama Barang";
        public UC_KLLABRGGudang()
        {
            InitializeComponent();
            

                Load += UC_KLLABRGGudang_Load;
                btnSimpan.Click += btnSimpan_Click;
                btnReset.Click += btnReset_Click;
                btnHapus.Click += btnHapus_Click;
                dgvKelolaBarang.CellClick += dgvKelolaBarang_CellClick;
                txtCari.TextChanged += txtCari_TextChanged;
        }

            private void UC_KLLABRGGudang_Load(object sender, EventArgs e)
            {
                if (DesignMode || System.ComponentModel.LicenseManager.UsageMode == System.ComponentModel.LicenseUsageMode.Designtime)
                    return;

                SiapkanGrid();

               
                cmbKategori.DropDownStyle = ComboBoxStyle.DropDownList;
                cmbKategori.Items.Clear();
                cmbKategori.Items.AddRange(new string[] { "Semua", "Elektronik", "Makanan", "Minuman", "Pakaian", "Lainnya" });

                MuatGrid();
            }

            private void SiapkanGrid()
            {
                dgvKelolaBarang.AutoGenerateColumns = false;
                dgvKelolaBarang.AllowUserToAddRows = false;
                dgvKelolaBarang.AllowUserToDeleteRows = false;
                dgvKelolaBarang.ReadOnly = true;
                dgvKelolaBarang.RowHeadersVisible = false;
                dgvKelolaBarang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvKelolaBarang.MultiSelect = false;
                dgvKelolaBarang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                dgvKelolaBarang.Columns.Clear();
                dgvKelolaBarang.Columns.Add(new DataGridViewTextBoxColumn { Name = "colNo", HeaderText = "No", FillWeight = 10 });
                dgvKelolaBarang.Columns.Add(new DataGridViewTextBoxColumn { Name = "colKode", HeaderText = "Kode", FillWeight = 20 });
                dgvKelolaBarang.Columns.Add(new DataGridViewTextBoxColumn { Name = "colNama", HeaderText = "Nama Barang", FillWeight = 35 });
                dgvKelolaBarang.Columns.Add(new DataGridViewTextBoxColumn { Name = "colKategori", HeaderText = "Kategori", FillWeight = 20 });
                dgvKelolaBarang.Columns.Add(new DataGridViewTextBoxColumn { Name = "colStok", HeaderText = "Stok", FillWeight = 15 });
                dgvKelolaBarang.Columns.Add(new DataGridViewTextBoxColumn { Name = "colHargaBeli", HeaderText = "Harga Beli", FillWeight = 20 });
                dgvKelolaBarang.Columns.Add(new DataGridViewTextBoxColumn { Name = "colHargaJual", HeaderText = "Harga Jual", FillWeight = 20 });
            }

            private void MuatGrid(string kataKunci = "")
            {
                try
                {
                    var daftarBarang = BarangStore.Muat();
                    dgvKelolaBarang.Rows.Clear();

                    int no = 1;
                    foreach (var b in daftarBarang)
                    {
                        if (!string.IsNullOrEmpty(kataKunci) && kataKunci != PhCari)
                        {
                            bool matchKode = b.KodeBarang != null && b.KodeBarang.ToLower().Contains(kataKunci.ToLower());
                            bool matchNama = b.NamaBarang != null && b.NamaBarang.ToLower().Contains(kataKunci.ToLower());
                            if (!matchKode && !matchNama) continue;
                        }

                        int i = dgvKelolaBarang.Rows.Add(no++, b.KodeBarang, b.NamaBarang, b.Kategori, b.Stok, b.HargaBeli, b.HargaJual);
                        dgvKelolaBarang.Rows[i].Tag = b.KodeBarang;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal membaca data barang:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            private void btnSimpan_Click(object sender, EventArgs e)
            {
                string kode = txtKode.Text.Trim();
                string nama = txtNamaBarang.Text.Trim();
                string kategori = cmbKategori.SelectedItem?.ToString();
                int stok = (int)numStok.Value;
                decimal hargaBeli = numHargaBeli.Value;
                decimal hargaJual = numHargaJual.Value;

                if (string.IsNullOrEmpty(kode) || string.IsNullOrEmpty(nama) || string.IsNullOrEmpty(kategori))
                {
                    MessageBox.Show("Kode, Nama Barang, dan Kategori harus diisi.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                try
                {
                    bool ok = BarangStore.TambahAtauUbahBarang(kode, nama, kategori, stok, hargaBeli, hargaJual, out string pesan);
                    if (!ok)
                    {
                        MessageBox.Show(pesan, "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    MessageBox.Show(pesan, "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    KosongkanForm();
                    MuatGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal menyimpan data:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            private void btnReset_Click(object sender, EventArgs e)
            {
                KosongkanForm();
            }

            private void btnHapus_Click(object sender, EventArgs e)
            {
                if (dgvKelolaBarang.CurrentRow == null || dgvKelolaBarang.CurrentRow.Tag == null)
                {
                    MessageBox.Show("Pilih barang yang ingin dihapus terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string kode = dgvKelolaBarang.CurrentRow.Tag?.ToString();
                string nama = dgvKelolaBarang.CurrentRow.Cells["colNama"].Value?.ToString();

                var konfirmasi = MessageBox.Show($"Apakah Anda yakin ingin menghapus barang \"{nama}\"?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (konfirmasi != DialogResult.Yes) return;

                if (BarangStore.Hapus(kode, out string pesan))
                {
                    MessageBox.Show(pesan, "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    KosongkanForm();
                    MuatGrid();
                }
                else
                {
                    MessageBox.Show(pesan, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            private void dgvKelolaBarang_CellClick(object sender, DataGridViewCellEventArgs e)
            {
                if (e.RowIndex < 0) return;

                DataGridViewRow row = dgvKelolaBarang.Rows[e.RowIndex];
                txtKode.Text = row.Cells["colKode"].Value?.ToString();
                txtNamaBarang.Text = row.Cells["colNama"].Value?.ToString();
                cmbKategori.SelectedItem = row.Cells["colKategori"].Value?.ToString();

                if (int.TryParse(row.Cells["colStok"].Value?.ToString(), out int stok))
                    numStok.Value = stok;
                if (decimal.TryParse(row.Cells["colHargaBeli"].Value?.ToString(), out decimal hBeli))
                    numHargaBeli.Value = hBeli;
                if (decimal.TryParse(row.Cells["colHargaJual"].Value?.ToString(), out decimal hJual))
                    numHargaJual.Value = hJual;
            }

            private void txtCari_TextChanged(object sender, EventArgs e)
            {
                MuatGrid(txtCari.Text.Trim());
            }

            private void KosongkanForm()
            {
                txtKode.Text = "";
                txtNamaBarang.Text = "";
            if (cmbKategori.Items.Count > 0) cmbKategori.SelectedIndex = -1;

                numStok.Value = 0;
                numHargaBeli.Value = 0;
                numHargaJual.Value = 0;

                txtKode.Focus();
            }
    }
}



