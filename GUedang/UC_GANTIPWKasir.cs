using System;
using System.ComponentModel;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace GUedang
{
    /// <summary>Halaman ganti password. Dipakai bersama oleh Kasir dan Gudang.</summary>
    public partial class UC_GANTIPWKasir : UserControl
    {
        private const int MinPanjang = 6;

        /// <summary>Isi dari form login, mis. ganti.Username = "Ditra2";</summary>
        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Username { get; set; } = "";

        /// <summary>Dipanggil setelah password berhasil diganti.</summary>
        public event EventHandler PasswordBerubah;

        public UC_GANTIPWKasir()
        {
            InitializeComponent();

            chkTampil.CheckedChanged += (s, e) =>
            {
                bool sembunyi = !chkTampil.Checked;
                txtLama.UseSystemPasswordChar = sembunyi;
                txtBaru.UseSystemPasswordChar = sembunyi;
                txtKonf.UseSystemPasswordChar = sembunyi;
            };
            btnSimpan.Click += BtnSimpan_Click;
            btnBatal.Click += (s, e) => BersihkanForm();
            txtBaru.TextChanged += (s, e) => TampilKekuatan();
        }

        /// <summary>Indikator kekuatan password: Lemah, Sedang, atau Kuat.</summary>
        private void TampilKekuatan()
        {
            string p = txtBaru.Text;

            if (p.Length == 0)
            {
                lblKekuatan.Text = "Kekuatan: -";
                lblKekuatan.ForeColor = Color.FromArgb(90, 110, 140);
                return;
            }

            bool kecil = false, besar = false, angka = false, simbol = false;
            foreach (char c in p)
            {
                if (char.IsLower(c)) kecil = true;
                else if (char.IsUpper(c)) besar = true;
                else if (char.IsDigit(c)) angka = true;
                else simbol = true;
            }

            int skor = 0;
            if (p.Length >= 8) skor++;
            if (kecil && besar) skor++;
            if (angka) skor++;
            if (simbol) skor++;

            if (p.Length < MinPanjang)
            {
                lblKekuatan.Text = "Kekuatan: Terlalu pendek";
                lblKekuatan.ForeColor = Color.FromArgb(210, 50, 50);
            }
            else if (skor <= 1)
            {
                lblKekuatan.Text = "Kekuatan: Lemah";
                lblKekuatan.ForeColor = Color.FromArgb(210, 50, 50);
            }
            else if (skor == 2)
            {
                lblKekuatan.Text = "Kekuatan: Sedang";
                lblKekuatan.ForeColor = Color.FromArgb(220, 130, 10);
            }
            else
            {
                lblKekuatan.Text = "Kekuatan: Kuat";
                lblKekuatan.ForeColor = Color.FromArgb(30, 140, 80);
            }
        }

        private void BersihkanForm()
        {
            txtLama.Clear();
            txtBaru.Clear();
            txtKonf.Clear();
            chkTampil.Checked = false;
            txtLama.Focus();
        }

        private void Peringatan(string pesan, Control fokus)
        {
            MessageBox.Show(pesan, "Ganti Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            if (fokus != null) fokus.Focus();
        }

        private void BtnSimpan_Click(object sender, EventArgs e)
        {
            string lama = txtLama.Text;
            string baru = txtBaru.Text;
            string konf = txtKonf.Text;

            string targetUser = !string.IsNullOrWhiteSpace(Username)
                ? Username.Trim()
                : (Session.UserAktif?.Nama ?? Sesi.NamaUser ?? "");

            if (string.IsNullOrWhiteSpace(targetUser))
            {
                Peringatan("Username aktif tidak terdeteksi. Silakan login ulang.", null);
                return;
            }

            if (lama.Length == 0) { Peringatan("Password lama wajib diisi.", txtLama); return; }
            if (baru.Length < MinPanjang) { Peringatan("Password baru minimal " + MinPanjang + " karakter.", txtBaru); return; }
            if (baru == lama) { Peringatan("Password baru harus berbeda dari password lama.", txtBaru); return; }
            if (baru != konf) { Peringatan("Konfirmasi password tidak sama dengan password baru.", txtKonf); return; }

            try
            {
                string pesan;
                bool berhasil = UserStore.GantiPassword(targetUser, lama, baru, out pesan);

                if (!berhasil)
                {
                    Peringatan(pesan, txtLama);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan:\n" + ex.Message, "Ganti Password",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Password berhasil diubah.", "Ganti Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
            BersihkanForm();
            PasswordBerubah?.Invoke(this, EventArgs.Empty);
        }
        // ------------------------------------------------------------- DATA
        // TODO: sambungkan dua method di bawah ke database kamu.
        // PENTING: cara menyimpan password (teks biasa atau hash) harus SAMA dengan yang dipakai form login,
        // kalau tidak, login dengan password baru akan gagal.

        private bool CekPasswordLama(string username, string passwordLama)
        {
            // Memakai data pengguna di DataAdmin.cs. Jika akun tidak ada di sana (mis. login kamu
            // memakai tabel sendiri), ganti isi method ini dengan query database kamu:
            // SELECT COUNT(*) FROM users WHERE username = @username AND password = @hash;
            var r = DataPengguna.Cari(username);
            if (r == null) return true;
            return r["password"].ToString() == DataPengguna.Hash(passwordLama);
        }


        /// <summary>SHA-256 dalam format hex. Pakai hanya jika login kamu juga memakai SHA-256.</summary>
        public static string Hash(string teks)
        {
            using (var sha = SHA256.Create())
            {
                byte[] bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(teks));
                var sb = new StringBuilder(bytes.Length * 2);
                foreach (byte b in bytes) sb.Append(b.ToString("x2"));
                return sb.ToString();
            }
        }
        private void tlpRoot_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chkTampil_CheckedChanged(object sender, EventArgs e)
        {
            txtLama.UseSystemPasswordChar = !chkTampil.Checked;
            txtBaru.UseSystemPasswordChar = !chkTampil.Checked;
            txtKonf.UseSystemPasswordChar = !chkTampil.Checked;
        }
    }
}
