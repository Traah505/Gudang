using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

// Ganti isi UC_Dashboard.cs (di luar InitializeComponent) dengan kode ini.
// Nama control yang diasumsikan (ubah lewat Properties > (Name) kalau berbeda):
//   dgvUser         -> tabel (No, Nama, Jenis, Status, Aksi)
//   lblJumlahKasir  -> angka "0" di bawah tulisan Kasir
//   lblJumlahGudang -> angka "0" di bawah tulisan Gudang
// Angka Barang Menipis dan Barang Habis belum disentuh.
namespace GUedang
{
    public partial class UC_Dashboard : UserControl
    {
        private bool _gridSiap = false;

        public UC_Dashboard()
        {
            InitializeComponent();

            // dimuat saat pertama dibuat, dan dimuat ulang tiap kali halaman ini
            // ditampilkan lagi (supaya user baru dari halaman User langsung muncul)
            Load += (s, e) => MuatData();
            VisibleChanged += (s, e) => { if (Visible) MuatData(); };
        }

        public void MuatData()
        {
            // jangan jalankan saat dibuka di Designer
            if (DesignMode || LicenseManager.UsageMode == LicenseUsageMode.Designtime) return;

            if (!_gridSiap) SiapkanGrid();

            try
            {
                var daftar = UserStore.Muat();

                dgvUser.Rows.Clear();
                int no = 1;
                foreach (var u in daftar)
                    dgvUser.Rows.Add(no++, u.Nama, u.Role, u.Aktif ? "Aktif" : "Nonaktif");

                // yang dihitung hanya user yang berstatus Aktif
                lblJumlahKasir.Text = daftar.Count(u => u.Aktif && u.Role == Roles.Kasir).ToString();
                lblJumlahGudang.Text = daftar.Count(u => u.Aktif && u.Role == Roles.Gudang).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal membaca data user:\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SiapkanGrid()
        {
            dgvUser.AutoGenerateColumns = false;
            dgvUser.AllowUserToAddRows = false;
            dgvUser.AllowUserToDeleteRows = false;
            dgvUser.ReadOnly = true;
            dgvUser.RowHeadersVisible = false;
            dgvUser.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUser.MultiSelect = false;
            dgvUser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvUser.Columns.Clear();
            dgvUser.Columns.Add(new DataGridViewTextBoxColumn
            { Name = "colNo", HeaderText = "No", FillWeight = 10 });
            dgvUser.Columns.Add(new DataGridViewTextBoxColumn
            { Name = "colNama", HeaderText = "Nama", FillWeight = 45 });
            dgvUser.Columns.Add(new DataGridViewTextBoxColumn
            { Name = "colJenis", HeaderText = "Jenis", FillWeight = 25 });
            dgvUser.Columns.Add(new DataGridViewTextBoxColumn
            { Name = "colStatus", HeaderText = "Status", FillWeight = 20 });

            _gridSiap = true;
        }

        private void panelContent2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}