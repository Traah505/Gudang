using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace GUedang
{
    public partial class UC_User : UserControl
    {
        private const string PhNama = "Nama Lengkap";
        private const string PhPassword = "Password awal";

        public UC_User()
        {
            InitializeComponent();

            Load += UC_User_Load;
            btnSimpan.Click += btnSimpan_Click;
            btnBatal.Click += btnBatal_Click;
            dgvUser.CellClick += dgvUser_CellClick;
        }

        private void UC_User_Load(object sender, EventArgs e)
        {

            if (DesignMode || LicenseManager.UsageMode == LicenseUsageMode.Designtime) return;

            SiapkanGrid();

            cmbJenis.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbJenis.Items.Clear();
            cmbJenis.Items.AddRange(Roles.Semua);

            txtPassword.UseSystemPasswordChar = false;

            MuatGrid();
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
            { Name = "colNama", HeaderText = "Nama", FillWeight = 40 });
            dgvUser.Columns.Add(new DataGridViewTextBoxColumn
            { Name = "colJenis", HeaderText = "Jenis", FillWeight = 20 });
            dgvUser.Columns.Add(new DataGridViewTextBoxColumn
            { Name = "colStatus", HeaderText = "Status", FillWeight = 20 });
            dgvUser.Columns.Add(new DataGridViewButtonColumn
            {
                Name = "colAksi",
                HeaderText = "Aksi",
                Text = "Hapus",
                UseColumnTextForButtonValue = true,
                FillWeight = 20
            });
        }

        private void MuatGrid()
        {
            try
            {
                var daftar = UserStore.Muat();

                dgvUser.Rows.Clear();
                int no = 1;
                foreach (var u in daftar)
                {
                    int i = dgvUser.Rows.Add(no++, u.Nama, u.Role, u.Aktif ? "Aktif" : "Nonaktif");
                    dgvUser.Rows[i].Tag = u.Id;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal membaca data user:\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            string nama = txtNama.Text.Trim();
            string password = txtPassword.Text;
            string role = cmbJenis.SelectedItem as string;

            if (nama == PhNama) nama = "";
            if (password == PhPassword) password = "";

            string pesan;
            bool ok;
            try
            {
                ok = UserStore.TambahUser(nama, role, password, out pesan);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menyimpan:\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!ok)
            {
                MessageBox.Show(pesan, "Tambah User", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show(pesan, "Tambah User", MessageBoxButtons.OK, MessageBoxIcon.Information);
            KosongkanForm();
            MuatGrid();
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            KosongkanForm();
        }

        private void KosongkanForm()
        {
            txtNama.Text = "";
            txtPassword.Text = "";
            cmbJenis.SelectedIndex = -1;
            txtNama.Focus();
        }

        private void dgvUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            int id = (int)dgvUser.Rows[e.RowIndex].Tag;
            string nama = Convert.ToString(dgvUser.Rows[e.RowIndex].Cells["colNama"].Value);
            string kolom = dgvUser.Columns[e.ColumnIndex].Name;
            string pesan;
            bool ok;

            try
            {
                if (kolom == "colAksi")
                {
                    var konfirmasi = MessageBox.Show("Hapus user \"" + nama + "\"?", "Konfirmasi",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (konfirmasi != DialogResult.Yes) return;

                    ok = UserStore.Hapus(id, out pesan);
                }
                else if (kolom == "colStatus")     // klik Status = aktif / nonaktif
                {
                    ok = UserStore.UbahStatus(id, out pesan);
                }
                else
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan:\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!ok)
                MessageBox.Show(pesan, "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            MuatGrid();
        }

        private void btnSImpan_Click(object sender, EventArgs e)
        {
            string namaUser = txtNama.Text.Trim();
            string jenisRole = cmbJenis.SelectedItem?.ToString();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(namaUser) || string.IsNullOrEmpty(jenisRole) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Semua field harus diisi.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            List<ModelUser> daftarUser = HelperJson.BacaData<ModelUser>("DataUser.json");
            daftarUser.Add(new ModelUser
            {
                Username = namaUser,
                Role = jenisRole,
                Password = password
            });
            HelperJson.SimpanData("DataUser.json", daftarUser);
            MessageBox.Show("Akun berhasil ditambahkan.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtNama.Text = "";
            txtPassword.Text = "";
            cmbJenis.SelectedIndex = -1;
        }

        private void UC_User_Load_1(object sender, EventArgs e)
        {

        }


        private void roundedPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSimpan_Click_1(object sender, EventArgs e)
        {

        }


        private void btnSimpanGP_Click(object sender, EventArgs e)
        {
            if (txtBaruGP.Text != txtKonfGP.Text)
            {
                MessageBox.Show("Konfirmasi tidak sama.", "Peringatan");
                return;
            }

            bool ok = UserStore.GantiPassword(txtNamaGP.Text.Trim(), txtLamaGP.Text,
                                              txtBaruGP.Text, out string pesan);

            MessageBox.Show(pesan, "Ganti Password", MessageBoxButtons.OK,
                ok ? MessageBoxIcon.Information : MessageBoxIcon.Warning);

            if (ok) BersihkanGP();
        }

        // tombol Batal di panel Ganti Password (double-click di designer juga)
        private void btnBatalGP_Click(object sender, EventArgs e)
        {
            BersihkanGP();
        }

        private void BersihkanGP()
        {
            txtNamaGP.Text = "";
            txtLamaGP.Text = "";
            txtBaruGP.Text = "";
            txtKonfGP.Text = "";
        }

        
    }
}




