using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Security.Cryptography;
using System.Text;

namespace GUedang
{
    [DataContract]
    public class UserAkun
    {
        [DataMember(Order = 1)] public int Id { get; set; }
        [DataMember(Order = 2)] public string Nama { get; set; }
        [DataMember(Order = 3)] public string Role { get; set; }
        [DataMember(Order = 4)] public bool Aktif { get; set; }
        [DataMember(Order = 5)] public string Salt { get; set; }
        [DataMember(Order = 6)] public string PasswordHash { get; set; }
        [DataMember(Order = 7)] public string Dibuat { get; set; }   // BARU: yyyy-MM-dd HH:mm
    }

    public static class Roles
    {
        public const string Admin = "Admin";
        public const string Kasir = "Kasir";
        public const string Gudang = "Gudang";

        // hanya role pekerja yang boleh dipilih saat tambah user (Admin tidak ada di sini)
        public static readonly string[] Semua = { Kasir, Gudang };
    }

    // menyimpan user yang sedang login
    public static class Session
    {
        public static UserAkun UserAktif { get; set; }
    }

    public static class UserStore
    {
        private const int Iterations = 10000;
        public const int MinPanjangPassword = 6;

        private static readonly string FilePath =
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "users.json");

        // ---------- baca / tulis file ----------

        public static List<UserAkun> Muat()
        {
            if (!File.Exists(FilePath))
            {
                // pertama kali jalan: buat akun admin bawaan
                var awal = new List<UserAkun> { BuatUser(1, "admin", Roles.Admin, "admin123") };
                Simpan(awal);
                return awal;
            }

            using (var fs = File.OpenRead(FilePath))
            {
                var ser = new DataContractJsonSerializer(typeof(List<UserAkun>));
                var hasil = (List<UserAkun>)ser.ReadObject(fs);
                return hasil ?? new List<UserAkun>();
            }
        }

        public static void Simpan(List<UserAkun> daftar)
        {
            var ser = new DataContractJsonSerializer(typeof(List<UserAkun>));
            using (var fs = new FileStream(FilePath, FileMode.Create, FileAccess.Write))
            using (var writer = JsonReaderWriterFactory.CreateJsonWriter(fs, Encoding.UTF8, false, true))
            {
                ser.WriteObject(writer, daftar);
            }
        }

        // ---------- operasi user ----------

        public static bool TambahUser(string nama, string role, string password, out string pesan)
        {
            nama = (nama ?? "").Trim();

            if (nama.Length == 0) { pesan = "Nama tidak boleh kosong."; return false; }
            if (string.IsNullOrEmpty(role) || !Roles.Semua.Contains(role))
            { pesan = "Pilih jenis (role) user."; return false; }
            if (string.IsNullOrEmpty(password) || password.Length < MinPanjangPassword)
            { pesan = "Password minimal " + MinPanjangPassword + " karakter."; return false; }

            var daftar = Muat();

            if (daftar.Any(u => string.Equals(u.Nama, nama, StringComparison.OrdinalIgnoreCase)))
            { pesan = "Nama \"" + nama + "\" sudah dipakai."; return false; }

            int idBaru = daftar.Count == 0 ? 1 : daftar.Max(u => u.Id) + 1;
            daftar.Add(BuatUser(idBaru, nama, role, password));
            Simpan(daftar);

            pesan = "User berhasil ditambahkan.";
            return true;
        }

        public static bool Hapus(int id, out string pesan)
        {
            var daftar = Muat();
            var user = daftar.FirstOrDefault(u => u.Id == id);
            if (user == null) { pesan = "User tidak ditemukan."; return false; }

            if (Session.UserAktif != null && Session.UserAktif.Id == id)
            { pesan = "Kamu tidak bisa menghapus akun yang sedang dipakai."; return false; }

            if (AdminTerakhir(daftar, user))
            { pesan = "Tidak bisa menghapus admin aktif terakhir."; return false; }

            daftar.Remove(user);
            Simpan(daftar);
            pesan = "User dihapus.";
            return true;
        }

        public static bool UbahStatus(int id, out string pesan)
        {
            var daftar = Muat();
            var user = daftar.FirstOrDefault(u => u.Id == id);
            if (user == null) { pesan = "User tidak ditemukan."; return false; }

            if (user.Aktif && Session.UserAktif != null && Session.UserAktif.Id == id)
            { pesan = "Kamu tidak bisa menonaktifkan akun yang sedang dipakai."; return false; }

            if (AdminTerakhir(daftar, user))
            { pesan = "Tidak bisa menonaktifkan admin aktif terakhir."; return false; }

            user.Aktif = !user.Aktif;
            Simpan(daftar);
            pesan = user.Aktif ? "User diaktifkan." : "User dinonaktifkan.";
            return true;
        }

        // Mengembalikan user kalau nama + password benar, null kalau gagal (pesan berisi alasannya)
        public static UserAkun Login(string nama, string password, out string pesan)
        {
            nama = (nama ?? "").Trim();
            var user = Muat().FirstOrDefault(u =>
                string.Equals(u.Nama, nama, StringComparison.OrdinalIgnoreCase));

            if (user == null || user.PasswordHash != Hash(password ?? "", Convert.FromBase64String(user.Salt)))
            {
                pesan = "Nama atau password salah.";
                return null;
            }

            if (!user.Aktif)
            {
                pesan = "Akun ini dinonaktifkan. Hubungi admin.";
                return null;
            }

            pesan = null;
            return user;
        }

        public static bool GantiPassword(string nama, string lama, string baru, out string pesan)
        {
            var daftar = Muat();
            var u = daftar.FirstOrDefault(x =>
                x.Nama.Equals(nama, StringComparison.OrdinalIgnoreCase));

            if (u == null) { pesan = "User tidak ditemukan."; return false; }
            if (u.PasswordHash != Hash(lama, Convert.FromBase64String(u.Salt))) { pesan = "Kata sandi lama salah."; return false; }
            if (baru.Length < MinPanjangPassword)
            { pesan = "Kata sandi baru minimal " + MinPanjangPassword + " karakter."; return false; }

            u.PasswordHash = Hash(baru, Convert.FromBase64String(u.Salt));
            Simpan(daftar);
            pesan = "Kata sandi berhasil diganti.";
            return true;
        }

        // BARU: admin mereset password user lain dengan password sementara acak
        public static bool ResetPassword(int id, out string passwordBaru, out string pesan)
        {
            passwordBaru = null;
            var daftar = Muat();
            var u = daftar.FirstOrDefault(x => x.Id == id);
            if (u == null) { pesan = "User tidak ditemukan."; return false; }

            passwordBaru = BuatPasswordSementara();
            u.PasswordHash = Hash(passwordBaru, Convert.FromBase64String(u.Salt));
            Simpan(daftar);
            pesan = "Password direset.";
            return true;
        }

        // ---------- helper ----------

        private static bool AdminTerakhir(List<UserAkun> daftar, UserAkun user)
        {
            return user.Role == Roles.Admin && user.Aktif &&
                   daftar.Count(u => u.Role == Roles.Admin && u.Aktif) == 1;
        }

        private static UserAkun BuatUser(int id, string nama, string role, string password)
        {
            byte[] salt = new byte[16];
            using (var rng = new RNGCryptoServiceProvider())
                rng.GetBytes(salt);

            return new UserAkun
            {
                Id = id,
                Nama = nama,
                Role = role,
                Aktif = true,
                Salt = Convert.ToBase64String(salt),
                PasswordHash = Hash(password, salt),
                Dibuat = DateTime.Now.ToString("yyyy-MM-dd HH:mm")
            };
        }

        private static string Hash(string password, byte[] salt)
        {
            using (var pbkdf2 = new Rfc2898DeriveBytes(password, salt, Iterations))
                return Convert.ToBase64String(pbkdf2.GetBytes(32));
        }

        // Password acak 8 karakter (tanpa karakter yang mirip seperti 0/O dan 1/l)
        private static string BuatPasswordSementara()
        {
            const string huruf = "ABCDEFGHJKLMNPQRSTUVWXYZabcdefghijkmnpqrstuvwxyz23456789";
            var bytes = new byte[8];
            using (var rng = new RNGCryptoServiceProvider())
                rng.GetBytes(bytes);

            var sb = new StringBuilder();
            foreach (byte b in bytes)
                sb.Append(huruf[b % huruf.Length]);
            return sb.ToString();
        }
    }
}