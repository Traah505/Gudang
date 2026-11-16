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
                Load += (s, e) => MuatDashboard();
                VisibleChanged += (s, e) => { if (Visible) MuatDashboard(); };
        }

            private void SiapkanGrid(DataGridView g)
            {
                g.AutoGenerateColumns = false;
                g.AllowUserToAddRows = false;
                g.ReadOnly = true;
                g.RowHeadersVisible = false;
                g.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }

            private void MuatDashboard()
            {
                if (DesignMode || LicenseManager.UsageMode == LicenseUsageMode.Designtime) return;

                if (dgvAktivitas.Columns.Count == 0)
                {
                    SiapkanGrid(dgvAktivitas);
                    dgvAktivitas.Columns.Add("colWaktu", "Waktu");
                    dgvAktivitas.Columns.Add("colJenis", "Jenis");
                    dgvAktivitas.Columns.Add("colNama", "Nama");
                    dgvAktivitas.Columns.Add("colJumlah", "Jumlah");
                    dgvAktivitas.Columns.Add("colStok", "Stok");
                }

                if (dgvPerhatian.Columns.Count == 0)
                {
                    SiapkanGrid(dgvPerhatian);
                    dgvPerhatian.Columns.Add("colNama", "Nama Barang");
                    dgvPerhatian.Columns.Add("colStok", "Stok");
                    dgvPerhatian.Columns.Add("colMin", "Minimum");
                    dgvPerhatian.Columns.Add("colStatus", "Status");
                }

                var barang = BarangStore.Muat();
                var semua = HelperJson.BacaData<ModelTransaksi>("DataTransaksi.json");
                var hariIni = semua.Where(t => t.Tanggal.Date == DateTime.Today).ToList();

                lblMasukHariIni.Text = hariIni.Where(t => t.Jenis == "Masuk")
                                              .Sum(t => t.Jumlah).ToString("0.##");
                lblKeluarHariIni.Text = Math.Abs(hariIni.Where(t => t.Jenis == "Keluar")
                                              .Sum(t => t.Jumlah)).ToString("0.##");
                lblStokSaatIni.Text = barang.Sum(b => b.Stok).ToString("0.##");

                // Stok perlu perhatian
                var perhatian = barang.Where(b => b.Status != "Aman").ToList();
                lblPerluPerhatian.Text = perhatian.Count.ToString();

                dgvPerhatian.Rows.Clear();
                foreach (var b in perhatian)
                {
                    int i = dgvPerhatian.Rows.Add(b.NamaBarang, b.Stok.ToString("0.##"),
                                                  b.Minimum.ToString("0.##"), b.Status);
                    dgvPerhatian.Rows[i].Cells["colStatus"].Style.ForeColor =
                        b.Status == "Habis" ? Color.IndianRed : Color.DarkGoldenrod;
                }

                // Aktivitas terbaru
                dgvAktivitas.Rows.Clear();
                foreach (var t in semua.OrderByDescending(x => x.Tanggal).Take(10))
                    dgvAktivitas.Rows.Add(t.Tanggal.ToString("dd/MM HH:mm"), t.Jenis, t.Nama,
                        t.Jumlah.ToString("+0.##;-0.##"), t.StokAkhir.ToString("0.##"));
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
        
        private void dgvPerhatian_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void roundedPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
