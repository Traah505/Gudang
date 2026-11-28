using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace GUedang
{
    public partial class UC_User : UserControl
    {
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string NamaAdminAktif { get; set; } = "admin";

        // Satu baris di tabel
        private class BarisUser
        {
            public int Id { get; set; }          // tidak ditampilkan, dipakai untuk mengenali user
            public int No { get; set; }
            public string Nama { get; set; }
            public string Jenis { get; set; }
            public string Status { get; set; }
            public string Dibuat { get; set; }
        }

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

            // Event yang BELUM dipasang di Designer (btnTambah, btnGanti, btnStatus, btnHapus
            // sudah dipasang di Designer, jadi tidak ditulis lagi di sini)
            txtCari.TextChanged += (s, e) => MuatTabel();
            cmbFilterJenis.SelectedIndexChanged += (s, e) => MuatTabel();
            dgvUser.CellClick += DgvUser_CellClick;
            btnResetTambah.Click += (s, e) => KosongkanFormTambah();
            btnBatalGanti.Click += (s, e) => KosongkanPilihan();
            btnResetPw.Click += (s, e) => ResetPassword();

            MuatTabel();
            KosongkanPilihan();
        }

        // ---------- Tabel ----------

        private void SiapkanGrid()
        {
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
        }

        private List<BarisUser> AmbilBaris(string kataCari, string jenis)
        {
            var q = UserStore.Muat().AsEnumerable();

            if (!string.IsNullOrWhiteSpace(kataCari))
            {
                string k = kataCari.Trim().ToLower();
                q = q.Where(u =>
                    (u.Nama ?? "").ToLower().Contains(k) ||
                    (u.Role ?? "").ToLower().Contains(k) ||
                    (u.Aktif ? "aktif" : "nonaktif").Contains(k));
            }

            if (!string.IsNullOrWhiteSpace(jenis) && jenis != "Semua")
            {
                if (jenis == "Nonaktif")
                    q = q.Where(u => !u.Aktif);
                else
                    q = q.Where(u => string.Equals(u.Role, jenis, StringComparison.OrdinalIgnoreCase));
            }

            return q.OrderBy(u => u.Id)
                    .Select((u, i) => new BarisUser
                    {
                        Id = u.Id,
                        No = i + 1,
                        Nama = u.Nama,
                        Jenis = u.Role,
                        Status = u.Aktif ? "Aktif" : "Nonaktif",
                        Dibuat = FormatTanggal(u.Dibuat)
                    })
                    .ToList();
        }

        // Tetap tersedia seperti sebelumnya (boleh dipanggil dari form lain)
        public void RefreshData(DataGridView dgv, string kataCari = "", string jenis = "Semua")
        {
            dgv.DataSource = AmbilBaris(kataCari, jenis);
        }

        private void MuatTabel()
        {
            var semua = UserStore.Muat();

            // Kartu statistik
            lblTotalNilai.Text = semua.Count.ToString();
            lblKasirNilai.Text = semua.Count(a => a.Role == Roles.Kasir).ToString();
            lblGudangNilai.Text = semua.Count(a => a.Role == Roles.Gudang).ToString();
            lblNonaktifNilai.Text = semua.Count(a => !a.Aktif).ToString();

            RefreshData(dgvUser, txtCari.Text, cmbFilterJenis.SelectedItem as string ?? "Semua");
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
            var baris = dgvUser.Rows[e.RowIndex].DataBoundItem as BarisUser;
            if (baris != null) PilihPengguna(baris.Id);
        }

        // ---------- Operasi ke UserStore (tetap seperti sebelumnya) ----------

        public bool Tambah(string nama, string jenis, string password, out string pesan)
            => UserStore.TambahUser(nama, jenis, password, out pesan);

        public bool HapusUser(int idUser, out string pesan)
            => UserStore.Hapus(idUser, out pesan);

        public bool UbahStatus(int idUser, out string pesan)
            => UserStore.UbahStatus(idUser, out pesan);

        public bool ResetPwUser(int idUser, out string passwordBaru, out string pesan)
            => UserStore.ResetPassword(idUser, out passwordBaru, out pesan);

        // ---------- Tambah pengguna ----------

        private void btnTambah_Click(object sender, EventArgs e)
        {
            string pesan;
            bool ok = Tambah(txtNama.Text, cmbJenis.Text, txtPass.Text, out pesan);
            Tampilkan(ok, pesan);
            if (!ok) return;

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

        private void btnGanti_Click(object sender, EventArgs e)
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
            if (!ResetPwUser(a.Id, out baru, out pesan))
            {
                Tampilkan(false, pesan);
                return;
            }

            Tampilkan(true, "Password baru untuk " + a.Nama + ":\n\n" + baru +
                            "\n\nBerikan ke pengguna dan minta segera menggantinya.");
        }

        private void btnStatus_Click(object sender, EventArgs e)
        {
            var a = AkunTerpilih();
            if (a == null) { PilihDulu(); return; }

            string pesan;
            if (!UbahStatus(a.Id, out pesan))
            {
                Tampilkan(false, pesan);   // mis. tidak bisa menonaktifkan akun yang sedang dipakai
                return;
            }

            MuatTabel();
            PilihPengguna(a.Id);   // segarkan label dan teks tombol
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            var a = AkunTerpilih();
            if (a == null) { PilihDulu(); return; }

            var tanya = MessageBox.Show(
                "Hapus pengguna \"" + a.Nama + "\"? Tindakan ini tidak bisa dibatalkan.",
                "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (tanya != DialogResult.Yes) return;

            string pesan;
            if (!HapusUser(a.Id, out pesan))
            {
                Tampilkan(false, pesan);
                return;
            }

            KosongkanPilihan();
            MuatTabel();
        }

        private void tlpRoot_Paint(object sender, PaintEventArgs e)
        {
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

        private void tlpTambah_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ChkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtPass.UseSystemPasswordChar = !ChkBox1.Checked;
        }
    }
}