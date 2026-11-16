using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace GUedang
{
    public partial class UC_Dashboard : UserControl
    {
        private bool _gridSiap = false;

        public UC_Dashboard()
        {
            InitializeComponent();
            roundedPanel1.PanelColor = Color.AliceBlue;
            roundedPanel2.PanelColor = Color.AliceBlue;
            roundedPanel3.PanelColor = Color.Honeydew;
            roundedPanel4.PanelColor = Color.LemonChiffon;
            roundedPanel5.PanelColor = Color.MistyRose;
            roundedPanel6.PanelColor = Color.Azure;

        
            InitializeComponent();
            Load += (s, e) => MuatDashboard();
            VisibleChanged += (s, e) => { if (Visible) MuatDashboard(); };
        }

        private void MuatDashboard()
        {
            if (DesignMode || LicenseManager.UsageMode == LicenseUsageMode.Designtime) return;

            if (dgvPengguna.Columns.Count == 0)
            {
                dgvPengguna.AutoGenerateColumns = false;
                dgvPengguna.AllowUserToAddRows = false;
                dgvPengguna.ReadOnly = true;
                dgvPengguna.RowHeadersVisible = false;
                dgvPengguna.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvPengguna.Columns.Add("colNo", "No");
                dgvPengguna.Columns.Add("colNama", "Nama");
                dgvPengguna.Columns.Add("colJenis", "Jenis");
                dgvPengguna.Columns.Add("colStatus", "Status");
            }

            var users = UserStore.Muat();
            var barang = BarangStore.Muat();
            var jual = PenjualanStore.Muat().Where(t => t.Waktu.Date == DateTime.Today).ToList();
            var log = HelperJson.BacaData<ModelTransaksi>("DataTransaksi.json")
                                .Where(t => t.Tanggal.Date == DateTime.Today).ToList();

            lblJumlahKasir.Text = users.Count(u => u.Role == "Kasir").ToString();
            lblJumlahGudang.Text = users.Count(u => u.Role == "Gudang").ToString();
            lblBarangMenipis.Text = barang.Count(b => b.Status == "Menipis").ToString();
            lblBarangHabis.Text = barang.Count(b => b.Status == "Habis").ToString();

            dgvPengguna.Rows.Clear();
            int no = 1;
            foreach (var u in users)
                dgvPengguna.Rows.Add(no++, u.Nama, u.Role, u.Aktif ? "Aktif" : "Nonaktif");

            lblPendapatanHariIni.Text = "Rp " + jual.Sum(t => t.Total).ToString("N0");
            lblTransaksiHariIni.Text = jual.Count.ToString();

            lblMasuk.Text = log.Where(t => t.Jenis == "Masuk").Sum(t => t.Jumlah).ToString("0.##");
            lblKeluar.Text = Math.Abs(log.Where(t => t.Jenis == "Keluar").Sum(t => t.Jumlah)).ToString("0.##");
            lblStokSaatIni.Text = barang.Sum(b => b.Stok).ToString("0.##");
        }




        private void panelContent2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}