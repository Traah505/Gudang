using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GUedang
{
    public partial class UC_RiwayatGudang : UserControl
    {
        public UC_RiwayatGudang()
        {
            InitializeComponent();
            Load += UC_RiwayatGudang_Load;
            btnCari.Click += (s, e) => MuatRiwayat();
            VisibleChanged += (s, e) => { if (Visible) MuatRiwayat(); };
        }

        private void UC_RiwayatGudang_Load(object sender, EventArgs e)
        {
            if (DesignMode || LicenseManager.UsageMode == LicenseUsageMode.Designtime) return;

            dgvRiwayatGudang.AutoGenerateColumns = false;
            dgvRiwayatGudang.AllowUserToAddRows = false;
            dgvRiwayatGudang.ReadOnly = true;
            dgvRiwayatGudang.RowHeadersVisible = false;
            dgvRiwayatGudang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRiwayatGudang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRiwayatGudang.Columns.Clear();
            dgvRiwayatGudang.Columns.Add("colNo", "No");
            dgvRiwayatGudang.Columns.Add("colWaktu", "Tanggal Waktu");
            dgvRiwayatGudang.Columns.Add("colJenis", "Jenis Transaksi");
            dgvRiwayatGudang.Columns.Add("colNama", "Nama Barang");
            dgvRiwayatGudang.Columns.Add("colJumlah", "Jumlah");
            dgvRiwayatGudang.Columns.Add("colStokAkhir", "Stok Akhir");
            dgvRiwayatGudang.Columns.Add("colKet", "Keterangan");

            cmbJenisTransaksi.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbJenisTransaksi.Items.Clear();
            cmbJenisTransaksi.Items.AddRange(new object[] { "Semua", "Masuk", "Keluar", "Penyesuaian" });
            cmbJenisTransaksi.SelectedIndex = 0;

            MuatRiwayat();
        }

        private void MuatRiwayat()
        {
            if (dgvRiwayatGudang.Columns.Count == 0) return;

            DateTime dari = dtpDari.Value.Date;
            DateTime sampai = dtpSampai.Value.Date.AddDays(1).AddTicks(-1);
            string jenis = cmbJenisTransaksi.SelectedItem?.ToString() ?? "Semua";

            var data = HelperJson.BacaData<ModelTransaksi>("DataTransaksi.json")
                .Where(t => t.Tanggal >= dari && t.Tanggal <= sampai)
                .Where(t => jenis == "Semua" || t.Jenis == jenis)
                .OrderByDescending(t => t.Tanggal)
                .ToList();

            dgvRiwayatGudang.Rows.Clear();
            int no = 1;
            foreach (var t in data)
                dgvRiwayatGudang.Rows.Add(no++, t.Tanggal.ToString("dd/MM/yyyy HH:mm"), t.Jenis, t.Nama,
                    t.Jumlah.ToString("+0.##;-0.##"), t.StokAkhir.ToString("0.##"), t.Keterangan);

            lblTotalBrgMasuk.Text = data.Where(t => t.Jenis == "Masuk").Sum(t => t.Jumlah).ToString("0.##");
            lblTotalBrgKeluar.Text = Math.Abs(data.Where(t => t.Jenis == "Keluar").Sum(t => t.Jumlah)).ToString("0.##");
            lblStokSaatIni.Text = BarangStore.Muat().Sum(b => b.Stok).ToString("0.##");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
