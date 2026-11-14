using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;   
using System.Text;
using System.Linq;
using System.Windows.Forms;

namespace GUedang
{
    public partial class UC_Barang : UserControl
    {
        private const string PhCari = "Cari barang...";

        public UC_Barang()
        {
            InitializeComponent();
            panelTotal.PanelColor = Color.RoyalBlue;
            panelAman.PanelColor = Color.SeaGreen;
            panelMenipis.PanelColor = Color.Goldenrod;
            panelHabis.PanelColor = Color.IndianRed;


            Load += UC_Barang_Load;
            btnSimpan.Click += btnSimpan_Click;
            btnReset.Click += btnReset_Click;
            btnHapus.Click += btnHapus_Click;
            dgvKelolaBarang.CellClick += dgvKelolaBarang_CellClick;
            txtCari.TextChanged += txtCari_TextChanged;
        }
        private void btnSemua_Click(object s, EventArgs e) { filterStatus = "Semua"; MuatGrid(txtCari.Text.Trim()); }
        private void btnAman_Click(object s, EventArgs e) { filterStatus = "Aman"; MuatGrid(txtCari.Text.Trim()); }
        private void btnMenipis_Click(object s, EventArgs e) { filterStatus = "Menipis"; MuatGrid(txtCari.Text.Trim()); }
        private void btnHabis_Click(object s, EventArgs e) { filterStatus = "Habis"; MuatGrid(txtCari.Text.Trim()); }

        private void UC_Barang_Load(object sender, EventArgs e)
        {
            if (DesignMode || System.ComponentModel.LicenseManager.UsageMode == System.ComponentModel.LicenseUsageMode.Designtime)
                return;

            SiapkanGrid();

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
            dgvKelolaBarang.Columns.Add(new DataGridViewTextBoxColumn { Name = "colMinimum", HeaderText = "Minimum", FillWeight = 15 });
            dgvKelolaBarang.Columns.Add(new DataGridViewTextBoxColumn { Name = "colStatus", HeaderText = "Status", FillWeight = 15 });
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
                    if (filterStatus != "Semua" && b.Status != filterStatus) continue;
                    int i = dgvKelolaBarang.Rows.Add(no++, b.KodeBarang, b.NamaBarang, b.Kategori, b.Stok, b.HargaBeli, b.HargaJual, b.Minimum, b.Status);
                    dgvKelolaBarang.Rows[i].Tag = b.KodeBarang;

                    var sel = dgvKelolaBarang.Rows[i].Cells["colStatus"];
                    sel.Style.ForeColor =
                        b.Status == "Habis" ? Color.IndianRed :
                        b.Status == "Menipis" ? Color.DarkGoldenrod : Color.SeaGreen;
                    sel.Style.Font = new Font(dgvKelolaBarang.Font, FontStyle.Bold);
                }
                lblTotalBarang.Text = daftarBarang.Count.ToString();
                lblStokAman.Text = daftarBarang.Count(b => b.Status == "Aman").ToString();
                lblStokMenipis.Text = daftarBarang.Count(b => b.Status == "Menipis").ToString();
                lblStokHabis.Text = daftarBarang.Count(b => b.Status == "Habis").ToString();
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
            string kategori = txtKategori.Text.Trim();
            int stok = (int)numStok.Value;
            decimal hargaBeli = numHargaBeli.Value;
            decimal hargaJual = numHargaJual.Value;
            int minimum = (int)numMinimum.Value;

            if (string.IsNullOrEmpty(kode) || string.IsNullOrEmpty(nama) || string.IsNullOrEmpty(kategori))
            {
                MessageBox.Show("Kode, Nama Barang, dan Kategori harus diisi.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                bool ok = BarangStore.TambahAtauUbahBarang(kode, nama, kategori, stok, hargaBeli, hargaJual, minimum, out string pesan);
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
            txtKategori.Text = row.Cells["colKategori"].Value?.ToString();

            if (int.TryParse(row.Cells["colStok"].Value?.ToString(), out int stok))
                numStok.Value = stok;
            if (decimal.TryParse(row.Cells["colHargaBeli"].Value?.ToString(), out decimal hBeli))
                numHargaBeli.Value = hBeli;
            if (decimal.TryParse(row.Cells["colHargaJual"].Value?.ToString(), out decimal hJual))
                numHargaJual.Value = hJual;
            if (int.TryParse(row.Cells["colMinimum"].Value?.ToString(), out int minimum))
                numMinimum.Value = minimum;
        }

        private void txtCari_TextChanged(object sender, EventArgs e)
        {
            MuatGrid(txtCari.Text.Trim());
        }

        private void KosongkanForm()
        {
            txtKode.Text = "";
            txtNamaBarang.Text = "";
            txtKategori.Text = "";

            numStok.Value = 0;
            numHargaBeli.Value = 0;
            numHargaJual.Value = 0;
            numMinimum.Value = 0;

            txtKode.Focus();
        }
        private string filterStatus = "Semua";



        private void roundedPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelDaftarBarang_Paint(object sender, PaintEventArgs e)
        {

        }

        private void roundedPanel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelTotal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelAman_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}  