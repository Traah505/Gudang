using System;
using System.ComponentModel;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace GUedang
{
    // Kode ini memakai nama kontrol yang sudah ada di UC_User.Designer.cs:
    //   Kartu     : lblTotalNilai, lblKasirNilai, lblGudangNilai, lblNonaktifNilai
    //   Daftar    : txtCari, cmbFilterJenis, dgvUser (colNo, colNama, colJenis, colStatus, colDibuat, colAksi)
    //   Tambah    : txtNama, cmbJenis, txtPass, lblPass, btnTambah, btnResetTambah
    //   Terpilih  : lblTerpilih, txtLama, txtBaru, btnGanti, btnBatalGanti, btnResetPw, btnStatus, btnHapus
    public partial class UC_User : UserControl
    {
        private readonly DataTable _tabel = new DataTable();
        private int? _terpilihId;   // Id user yang dipilih di tabel (null = belum ada)

        public UC_User()
        {
            InitializeComponent();
            if (LicenseManager.UsageMode == LicenseUsageMode.Designtime) return;

            txtPass.UseSystemPasswordChar = true;
            txtLama.UseSystemPasswordChar = true;
            txtBaru.UseSystemPasswordChar = true;

            // Teks label mengikuti aturan di UserStore, jadi selalu cocok
            lblPass.Text = "Password (minimal " + UserStore.MinPanjangPassword + " karakter)";

            // Roles.Semua hanya berisi Kasir dan Gudang, jadi Admin tidak muncul
            cmbJenis.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbJenis.Items.Clear();
            cmbJenis.Items.AddRange(Roles.Semua);

            cmbFilterJenis.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFilterJenis.Items.Clear();
            cmbFilterJenis.Items.AddRange(new object[] { "Semua", "Admin", "Kasir", "Gudang", "Nonaktif" });
            cmbFilterJenis.SelectedIndex = 0;

            SiapkanGrid();

            // Event dipasang di sini. Kalau di Designer sudah ada event Click untuk tombol-tombol ini,
            // kosongkan dulu supaya tidak jalan dua kali.
            txtCari.TextChanged += (s, e) => MuatTabel();
            cmbFilterJenis.SelectedIndexChanged += (s, e) => MuatTabel();
            dgvUser.CellClick += DgvUser_CellClick;
            btnTambah.Click += (s, e) => TambahPengguna();
            btnResetTambah.Click += (s, e) => KosongkanFormTambah();
            btnGanti.Click += (s, e) => GantiPassword();
            btnBatalGanti.Click += (s, e) => KosongkanPilihan();
            btnResetPw.Click += (s, e) => ResetPassword();
            btnStatus.Click += (s, e) => UbahStatus();
            btnHapus.Click += (s, e) => HapusPengguna();

            MuatTabel();
            KosongkanPilihan();
        }

        // ---------- Tabel ----------

        private void SiapkanGrid()
        {
            _tabel.Columns.Add("Id", typeof(int));      // tidak ditampilkan, dipakai untuk mengenali user
            _tabel.Columns.Add("No", typeof(int));
            _tabel.Columns.Add("Nama", typeof(string));
            _tabel.Columns.Add("Jenis", typeof(string));
            _tabel.Columns.Add("Status", typeof(string));
            _tabel.Columns.Add("Dibuat", typeof(string));

            // Kolom sudah dibuat di Designer, di sini hanya dihubungkan ke data
            dgvUser.AutoGenerateColumns = false;
            colNo.DataPropertyName = "No";
            colNama.DataPropertyName = "Nama";
            colJenis.DataPropertyName = "Jenis";
            colStatus.DataPropertyName = "Status";
            colDibuat.DataPropertyName = "Dibuat";

            // Tombol di kolom Aksi: klik = pilih user itu (sama seperti klik barisnya)
            if (string.IsNullOrEmpty(colAksi.Text)) colAksi.Text = "Kelola";
            colAksi.UseColumnTextForButtonValue = true;

            dgvUser.AllowUserToAddRows = false;
            dgvUser.AllowUserToDeleteRows = false;
            dgvUser.ReadOnly = true;
            dgvUser.RowHeadersVisible = false;
            dgvUser.MultiSelect = false;
            dgvUser.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUser.DataSource = _tabel;
        }

        private void MuatTabel()
        {
            var semua = UserStore.Muat();

            // Kartu statistik
            lblTotalNilai.Text = semua.Count.ToString();
            lblKasirNilai.Text = semua.Count(a => a.Role == Roles.Kasir).ToString();
            lblGudangNilai.Text = semua.Count(a => a.Role == Roles.Gudang).ToString();
            lblNonaktifNilai.Text = semua.Count(a => !a.Aktif).ToString();

            // Cari + filter
            string kata = (txtCari.Text ?? "").Trim();
            string filter = cmbFilterJenis.SelectedItem as string ?? "Semua";

            var hasil = semua
                .Where(a => kata.Length == 0 ||
                            a.Nama.IndexOf(kata, StringComparison.OrdinalIgnoreCase) >= 0)
                .Where(a => filter == "Semua" ||
                            (filter == "Nonaktif" ? !a.Aktif : a.Role == filter))
                .OrderBy(a => a.Nama)
                .ToList();

            _tabel.Clear();
            int no = 1;
            foreach (var a in hasil)
            {
                _tabel.Rows.Add(a.Id, no++, a.Nama, a.Role, a.Aktif ? "Aktif" : "Nonaktif", FormatTanggal(a.Dibuat));
            }
            dgvUser.ClearSelection();
        }

        private static string FormatTanggal(string teks)
        {
            DateTime t;
            if (DateTime.TryParseExact(teks, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture,
                    DateTimeStyles.None, out t))
                return t.ToString("dd/MM/yyyy");
            return "-";   // akun lama yang dibuat sebelum ada kolom Dibuat
        }

        private void DgvUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var baris = dgvUser.Rows[e.RowIndex].DataBoundItem as DataRowView;
            if (baris != null) PilihPengguna(Convert.ToInt32(baris["Id"]));
        }

        // ---------- Tambah pengguna ----------

        private void TambahPengguna()
        {
            string pesan;
            bool ok = UserStore.TambahUser(txtNama.Text, cmbJenis.Text, txtPass.Text, out pesan);
            Tampilkan(ok, pesan);
            if (!ok) return;
            AktivitasStore.Catat(
    Sesi.NamaUser,
    Sesi.RoleUser.ToString(),
    "Menambahkan pengguna: " + txtNama.Text
);

            KosongkanFormTambah();
            MuatTabel();
        }

        private void KosongkanFormTambah()
        {
            txtNama.Text = "";
            cmbJenis.SelectedIndex = -1;
            txtPass.Text = "";
        }

        // ---------- Kelola pengguna terpilih ----------

        private UserAkun AkunTerpilih()
        {
            if (_terpilihId == null) return null;
            return UserStore.Muat().FirstOrDefault(u => u.Id == _terpilihId.Value);
        }

        private void PilihPengguna(int id)
        {
            var a = UserStore.Muat().FirstOrDefault(u => u.Id == id);
            if (a == null) { KosongkanPilihan(); return; }

            _terpilihId = a.Id;
            lblTerpilih.Text = a.Nama + "  ·  " + a.Role + "  ·  " + (a.Aktif ? "Aktif" : "Nonaktif");
            btnStatus.Text = a.Aktif ? "Nonaktifkan" : "Aktifkan";
            txtLama.Text = "";
            txtBaru.Text = "";
            AturTombolPilihan(true);
        }

        private void KosongkanPilihan()
        {
            _terpilihId = null;
            lblTerpilih.Text = "Pilih pengguna di tabel";
            btnStatus.Text = "Nonaktifkan";
            txtLama.Text = "";
            txtBaru.Text = "";
            dgvUser.ClearSelection();
            AturTombolPilihan(false);
        }

        private void AturTombolPilihan(bool aktif)
        {
            btnGanti.Enabled = aktif;
            btnResetPw.Enabled = aktif;
            btnStatus.Enabled = aktif;
            btnHapus.Enabled = aktif;
        }

        private void GantiPassword()
        {
            var a = AkunTerpilih();
            if (a == null) { PilihDulu(); return; }

            string pesan;
            bool ok = UserStore.GantiPassword(a.Nama, txtLama.Text, txtBaru.Text, out pesan);
            Tampilkan(ok, pesan);
            if (!ok) return;



            txtLama.Text = "";
            txtBaru.Text = "";
        }

        private void ResetPassword()
        {
            var a = AkunTerpilih();
            if (a == null) { PilihDulu(); return; }

            var tanya = MessageBox.Show(
                "Reset password \"" + a.Nama + "\"? Password lama tidak berlaku lagi.",
                "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (tanya != DialogResult.Yes) return;

            string baru, pesan;
            if (!UserStore.ResetPassword(a.Id, out baru, out pesan))
            {
                Tampilkan(false, pesan);
                return;
            }
            AktivitasStore.Catat(
    Sesi.NamaUser,
    Sesi.RoleUser.ToString(),
    "Reset Password pengguna: " + a.Nama
);
            Tampilkan(true, "Password baru untuk " + a.Nama + ":\n\n" + baru +
                            "\n\nBerikan ke pengguna dan minta segera menggantinya.");
        }

        private void UbahStatus()
        {
            var a = AkunTerpilih();
            if (a == null) { PilihDulu(); return; }

            string pesan;
            if (!UserStore.UbahStatus(a.Id, out pesan))
            {
                Tampilkan(false, pesan);   // mis. tidak bisa menonaktifkan akun yang sedang dipakai
                return;
            }
            AktivitasStore.Catat(
    Sesi.NamaUser,
    Sesi.RoleUser.ToString(),
    "Mengubah status pengguna: " + a.Nama
);
            MuatTabel();
            PilihPengguna(a.Id);   // segarkan label dan teks tombol
        }

        private void HapusPengguna()
        {
            var a = AkunTerpilih();
            if (a == null) { PilihDulu(); return; }

            var tanya = MessageBox.Show(
                "Hapus pengguna \"" + a.Nama + "\"? Tindakan ini tidak bisa dibatalkan.",
                "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (tanya != DialogResult.Yes) return;

            string pesan;
            if (!UserStore.Hapus(a.Id, out pesan))
            {
                Tampilkan(false, pesan);
                return;
            }
            AktivitasStore.Catat(
    Sesi.NamaUser,
    Sesi.RoleUser.ToString(),
    "Menghapus pengguna: " + a.Nama
);
            KosongkanPilihan();
            MuatTabel();
        }

        // ---------- Bantuan ----------

        private static void PilihDulu()
        {
            MessageBox.Show("Pilih pengguna di tabel terlebih dahulu.", "SMK Mart",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private static void Tampilkan(bool berhasil, string pesan)
        {
            MessageBox.Show(pesan, "SMK Mart", MessageBoxButtons.OK,
                berhasil ? MessageBoxIcon.Information : MessageBoxIcon.Warning);
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {

        }

        private void btnTambah_Click(object sender, EventArgs e)
        {

        }

        private void btnStatus_Click(object sender, EventArgs e)
        {

        }

        private void btnGanti_Click(object sender, EventArgs e)
        {

        }
    }
}