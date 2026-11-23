using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace GUedang
{
    /// <summary>
    /// Pengguna yang sedang login, dipakai halaman-halaman baru untuk mencatat siapa yang bekerja.
    /// TODO: isi dari form login setelah login berhasil, mis.
    ///   SesiAktif.Nama = ...; SesiAktif.Peran = "Admin" / "Kasir" / "Gudang";
    /// (Class Sesi milikmu tidak saya sentuh.)
    /// </summary>
    public static class SesiAktif
    {
        public static string Nama = "Administrator";
        public static string Peran = "Admin";
    }

    /// <summary>Pilihan rentang tanggal cepat untuk halaman laporan.</summary>
    public static class Rentang
    {
        public static readonly string[] Pilihan = { "Hari ini", "7 hari terakhir", "30 hari terakhir", "Bulan ini", "Semua", "Pilih manual" };

        public static void Terapkan(string pilihan, DateTimePicker dari, DateTimePicker sampai)
        {
            DateTime hari = DateTime.Today;
            switch (pilihan)
            {
                case "Hari ini": dari.Value = hari; sampai.Value = hari; break;
                case "7 hari terakhir": dari.Value = hari.AddDays(-6); sampai.Value = hari; break;
                case "30 hari terakhir": dari.Value = hari.AddDays(-29); sampai.Value = hari; break;
                case "Bulan ini": dari.Value = new DateTime(hari.Year, hari.Month, 1); sampai.Value = hari; break;
                case "Semua": dari.Value = new DateTime(2000, 1, 1); sampai.Value = hari; break;
            }
        }
    }

    /// <summary>
    /// Log aktivitas di database_smkmart.json (LogAktivitas), lewat JsonStore.CatatLog.
    /// (Dinamai LogApp supaya tidak bentrok dengan DataAktivitas milikmu.)
    /// </summary>
    public static class LogApp
    {
        /// <summary>Kolom: waktu, nama, peran, aktivitas. Terbaru di atas.</summary>
        public static DataRow[] GetSemua()
        {
            var dt = new DataTable();
            dt.Columns.Add("waktu", typeof(DateTime));
            dt.Columns.Add("nama", typeof(string));
            dt.Columns.Add("peran", typeof(string));
            dt.Columns.Add("aktivitas", typeof(string));

            foreach (LogAktivitasItem l in JsonStore.Load().LogAktivitas)
                dt.Rows.Add(l.Waktu, l.NamaUser ?? "", l.Role ?? "", l.Aktivitas ?? "");
            return dt.Select("", "waktu DESC");
        }

        public static void Catat(string aktivitas)
        {
            Catat(SesiAktif.Nama, SesiAktif.Peran, aktivitas);
        }

        public static void Catat(string nama, string peran, string aktivitas)
        {
            JsonStore.CatatLog(peran, nama, aktivitas);
        }

        /// <summary>Hapus log yang lebih lama dari sekian hari. Mengembalikan jumlah yang dihapus.</summary>
        public static int HapusLama(int hari)
        {
            DatabaseJson db = JsonStore.Load();
            DateTime batas = DateTime.Now.AddDays(-hari);
            int n = db.LogAktivitas.RemoveAll(l => l.Waktu < batas);
            JsonStore.Save(db);
            return n;
        }
    }

    /// <summary>Bentuk data akun di file DataJson/pengguna.json.</summary>
    public class PenggunaJson
    {
        public string Nama;
        public string Jenis;
        public string Status;
        public string Password;   // hash SHA-256
        public DateTime Dibuat;
    }

    /// <summary>
    /// Data akun pengguna, disimpan di DataJson/pengguna.json (di samping database_smkmart.json).
    /// Database JsonStore milikmu belum punya data pengguna, jadi akun disimpan di file terpisah ini.
    /// TODO: kalau form login-mu membaca akun dari tempat lain, arahkan Buat() dan Tulis() ke sana.
    /// Akun contoh: Administrator / admin123, Siti Aminah dan Ditra2 / kasir123, Gudang / gudang123.
    /// </summary>
    public static class DataPengguna
    {
        public const int MinPassword = 6;
        public const string PasswordDefault = "123456";

        private static readonly string FileAkun =
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DataJson", "pengguna.json");

        private static DataTable _tabel;

        /// <summary>Kolom: nama, jenis (Admin/Kasir/Gudang), status (Aktif/Nonaktif), password (hash), dibuat</summary>
        public static DataTable GetSemua()
        {
            if (_tabel == null) Buat();
            return _tabel;
        }

        public static DataRow Cari(string nama)
        {
            foreach (DataRow r in GetSemua().Rows)
                if (string.Equals(r["nama"].ToString(), nama, StringComparison.OrdinalIgnoreCase)) return r;
            return null;
        }

        public static string Hash(string teks)
        {
            using (var sha = SHA256.Create())
            {
                byte[] bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(teks ?? ""));
                var sb = new StringBuilder(bytes.Length * 2);
                foreach (byte b in bytes) sb.Append(b.ToString("x2"));
                return sb.ToString();
            }
        }

        /// <summary>Simpan data pengguna ke pengguna.json. Panggil juga setelah mengubah baris secara langsung.</summary>
        public static void Tulis()
        {
            var daftar = new List<PenggunaJson>();
            foreach (DataRow r in GetSemua().Rows)
            {
                daftar.Add(new PenggunaJson
                {
                    Nama = r["nama"].ToString(),
                    Jenis = r["jenis"].ToString(),
                    Status = r["status"].ToString(),
                    Password = r["password"].ToString(),
                    Dibuat = (DateTime)r["dibuat"]
                });
            }

            Directory.CreateDirectory(Path.GetDirectoryName(FileAkun));
            File.WriteAllText(FileAkun, JsonConvert.SerializeObject(daftar, Formatting.Indented));
        }

        public static void Tambah(string nama, string jenis, string password)
        {
            nama = (nama ?? "").Trim();
            if (nama.Length < 3) throw new InvalidOperationException("Nama minimal 3 karakter.");
            if (Cari(nama) != null) throw new InvalidOperationException("Nama pengguna sudah dipakai.");
            if (Array.IndexOf(new[] { "Admin", "Kasir", "Gudang" }, jenis) < 0) throw new InvalidOperationException("Pilih jenis pengguna.");
            if ((password ?? "").Length < MinPassword) throw new InvalidOperationException("Password minimal " + MinPassword + " karakter.");

            GetSemua().Rows.Add(nama, jenis, "Aktif", Hash(password), DateTime.Now);
            Tulis();
            LogApp.Catat("Menambah pengguna: " + nama + " (" + jenis + ")");
        }

        public static void UbahPassword(string nama, string lama, string baru)
        {
            DataRow r = Cari(nama);
            if (r == null) throw new InvalidOperationException("Pengguna tidak ditemukan.");
            if (r["password"].ToString() != Hash(lama)) throw new InvalidOperationException("Kata sandi lama salah.");
            if ((baru ?? "").Length < MinPassword) throw new InvalidOperationException("Kata sandi baru minimal " + MinPassword + " karakter.");
            if (baru == lama) throw new InvalidOperationException("Kata sandi baru harus berbeda dari yang lama.");

            r["password"] = Hash(baru);
            Tulis();
            LogApp.Catat("Mengganti password: " + r["nama"]);
        }

        public static void ResetPassword(string nama, string baru)
        {
            DataRow r = Cari(nama);
            if (r == null) throw new InvalidOperationException("Pengguna tidak ditemukan.");
            r["password"] = Hash(baru);
            Tulis();
            LogApp.Catat("Reset password: " + r["nama"]);
        }

        public static void SetStatus(string nama, bool aktif)
        {
            DataRow r = Cari(nama);
            if (r == null) throw new InvalidOperationException("Pengguna tidak ditemukan.");
            if (!aktif) CekBolehDihapusAtauDinonaktifkan(r, "dinonaktifkan");

            r["status"] = aktif ? "Aktif" : "Nonaktif";
            Tulis();
            LogApp.Catat((aktif ? "Mengaktifkan" : "Menonaktifkan") + " pengguna: " + r["nama"]);
        }

        public static void Hapus(string nama)
        {
            DataRow r = Cari(nama);
            if (r == null) throw new InvalidOperationException("Pengguna tidak ditemukan.");
            CekBolehDihapusAtauDinonaktifkan(r, "dihapus");

            string n = r["nama"].ToString();
            r.Delete();
            GetSemua().AcceptChanges();
            Tulis();
            LogApp.Catat("Menghapus pengguna: " + n);
        }

        private static void CekBolehDihapusAtauDinonaktifkan(DataRow r, string kata)
        {
            if (string.Equals(r["nama"].ToString(), SesiAktif.Nama, StringComparison.OrdinalIgnoreCase))
                throw new InvalidOperationException("Akun yang sedang dipakai tidak bisa " + kata + ".");

            if (r["jenis"].ToString() == "Admin" && r["status"].ToString() == "Aktif")
            {
                int aktif = 0;
                foreach (DataRow x in GetSemua().Rows)
                    if (x["jenis"].ToString() == "Admin" && x["status"].ToString() == "Aktif") aktif++;
                if (aktif <= 1) throw new InvalidOperationException("Minimal harus ada satu Admin aktif.");
            }
        }

        private static void Buat()
        {
            var dt = new DataTable();
            dt.Columns.Add("nama", typeof(string));
            dt.Columns.Add("jenis", typeof(string));
            dt.Columns.Add("status", typeof(string));
            dt.Columns.Add("password", typeof(string));
            dt.Columns.Add("dibuat", typeof(DateTime));

            if (File.Exists(FileAkun))
            {
                List<PenggunaJson> daftar = null;
                try { daftar = JsonConvert.DeserializeObject<List<PenggunaJson>>(File.ReadAllText(FileAkun)); }
                catch { }

                if (daftar != null)
                {
                    foreach (PenggunaJson p in daftar)
                        dt.Rows.Add(p.Nama ?? "", p.Jenis ?? "Kasir", p.Status ?? "Aktif", p.Password ?? "", p.Dibuat);
                    _tabel = dt;
                    return;
                }
            }

            DateTime h = DateTime.Today;
            dt.Rows.Add("Administrator", "Admin", "Aktif", Hash("admin123"), h.AddDays(-200));
            dt.Rows.Add("Siti Aminah", "Kasir", "Aktif", Hash("kasir123"), h.AddDays(-120));
            dt.Rows.Add("Ditra2", "Kasir", "Aktif", Hash("kasir123"), h.AddDays(-60));
            dt.Rows.Add("Gudang", "Gudang", "Aktif", Hash("gudang123"), h.AddDays(-90));
            dt.Rows.Add("Budi Santoso", "Kasir", "Nonaktif", Hash("kasir123"), h.AddDays(-30));
            _tabel = dt;
            Tulis();
        }
    }
}