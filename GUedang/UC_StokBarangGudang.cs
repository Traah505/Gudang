using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GUedang
{
    public partial class UC_StokBarangGudang : UserControl
    {
        private string kodeTerpilih = "";
        private decimal stokSistem = 0;

        public UC_StokBarangGudang()
        {
            InitializeComponent();
            Load += UC_StokBarang_Load;
            txtCariStok.TextChanged += (s, e) => MuatGrid();
            txtKategoriStok.TextChanged += (s, e) => MuatGrid();
            cmbStatusStok.SelectedIndexChanged += (s, e) => MuatGrid();
            dgvStok.CellClick += dgvStok_CellClick;
        }

        private void UC_StokBarang_Load(object sender, EventArgs e)
        {
            if (DesignMode || LicenseManager.UsageMode == LicenseUsageMode.Designtime) return;

            dgvStok.AutoGenerateColumns = false;
            dgvStok.AllowUserToAddRows = false;
            dgvStok.ReadOnly = true;
            dgvStok.RowHeadersVisible = false;
            dgvStok.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStok.MultiSelect = false;
            dgvStok.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStok.Columns.Clear();
            dgvStok.Columns.Add("colNo", "No");
            dgvStok.Columns.Add("colKode", "Kode");
            dgvStok.Columns.Add("colNama", "Nama Barang");
            dgvStok.Columns.Add("colStok", "Stok");
            dgvStok.Columns.Add("colMin", "Minimum");
            dgvStok.Columns.Add("colStatus", "Status");

            cmbStatusStok.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatusStok.Items.Clear();
            cmbStatusStok.Items.AddRange(new object[] { "Semua", "Aman", "Menipis", "Habis" });
            cmbStatusStok.SelectedIndex = 0;   // ini memanggil MuatGrid()
        }

        private void MuatGrid()
        {
            if (DesignMode || dgvStok.Columns.Count == 0) return;

            string cari = txtCariStok.Text.Trim().ToLower();
            string kat = txtKategoriStok.Text.Trim().ToLower();
            string status = cmbStatusStok.SelectedItem?.ToString() ?? "Semua";

            dgvStok.Rows.Clear();
            int no = 1;
            foreach (var b in BarangStore.Muat())
            {
                if (cari != "" &&
                    !(b.KodeBarang ?? "").ToLower().Contains(cari) &&
                    !(b.NamaBarang ?? "").ToLower().Contains(cari)) continue;
                if (kat != "" && !(b.Kategori ?? "").ToLower().Contains(kat)) continue;
                if (status != "Semua" && b.Status != status) continue;

                dgvStok.Rows.Add(no++, b.KodeBarang, b.NamaBarang,
                    b.Stok.ToString("0.##"), b.Minimum.ToString("0.##"), b.Status);
            }
        }

        private void dgvStok_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = dgvStok.Rows[e.RowIndex];
            kodeTerpilih = row.Cells["colKode"].Value?.ToString();
            decimal.TryParse(row.Cells["colStok"].Value?.ToString(), out stokSistem);

            lblStokTersedia.Text = stokSistem.ToString("0.##") + " Item";
            lblStokMinimum.Text = row.Cells["colMin"].Value + " Item";
            lblStatusStok.Text = row.Cells["colStatus"].Value?.ToString();

            numJumlahFisik.Value = stokSistem;   // otomatis memicu numFisik_ValueChanged
        }

        private void numJumlahFisik_ValueChanged(object s, EventArgs e)
        {
            txtSelisih.Text = (numJumlahFisik.Value - stokSistem).ToString("0.##");
        }

        private void btnSimpanPenyesuaian_Click(object s, EventArgs e)
        {
            if (string.IsNullOrEmpty(kodeTerpilih))
            {
                MessageBox.Show("Pilih barang di tabel dulu.", "Penyesuaian");
                return;
            }
            bool ok = BarangStore.UbahStok(kodeTerpilih, "Penyesuaian",
                numJumlahFisik.Value, 0, txtAlasan.Text.Trim(), out string pesan);
            MessageBox.Show(pesan, "Penyesuaian", MessageBoxButtons.OK,
                ok ? MessageBoxIcon.Information : MessageBoxIcon.Warning);
            if (ok)
            {
                txtAlasan.Text = "";
                kodeTerpilih = "";
                MuatGrid();
            }
        }

        private void panelContent2_Paint(object sender, PaintEventArgs e)
        {
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        
    }
}




