using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text.Json;

namespace GUedang
{
    public static class BarangStore
    {
        private static string filePath = "DataBarang.json";

        public static List<ModelBarang> Muat()
        {
            if (!File.Exists(filePath)) return new List<ModelBarang>();
            string json = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<List<ModelBarang>>(json) ?? new List<ModelBarang>();
        }

        public static void Simpan(List<ModelBarang> daftar)
        {
            string json = JsonSerializer.Serialize(daftar, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, json);
        }

        public static bool TambahAtauUbahBarang(string kode, string nama, string kategori, int stok, decimal hBeli, decimal hJual, int minimum, out string pesan)
        {
            var daftar = Muat();

            var existing = daftar.FirstOrDefault(x => x.KodeBarang == kode);
            if (existing != null)
            {
                existing.KodeBarang = kode;
                existing.NamaBarang = nama;
                existing.Kategori = kategori;
                existing.Stok = stok;
                existing.Minimum = minimum;
                existing.HargaBeli = hBeli;
                existing.HargaJual = hJual;
                pesan = "Data barang berhasil diperbarui.";
            }
            else
            {

                daftar.Add(new ModelBarang
                {
                    KodeBarang = kode,
                    NamaBarang = nama,
                    Kategori = kategori,
                    Stok = stok,
                    HargaBeli = hBeli,
                    HargaJual = hJual,
                    Minimum = minimum
                });
                pesan = "Barang berhasil ditambahkan.";
            }

            Simpan(daftar);
            return true;
        }

        public static bool Hapus(string kode, out string pesan)
        {
            var daftar = Muat();
            int removed = daftar.RemoveAll(b =>b.KodeBarang == kode);
            if (removed > 0)
            {
                Simpan(daftar);
                pesan = "Barang berhasil dihapus.";
                return true;
            }
            pesan = "Barang tidak ditemukan.";
            return false;
        }
        public static bool UbahStok(string kode, string jenis, decimal jumlah,
                               decimal harga, string ket, out string pesan)
        {
            var daftar = Muat();
            var b = daftar.FirstOrDefault(x =>
                x.KodeBarang.Equals(kode, StringComparison.OrdinalIgnoreCase));
            if (b == null) { pesan = "Barang tidak ditemukan."; return false; }

            decimal perubahan;
            if (jenis == "Masuk")
            {
                if (jumlah <= 0) { pesan = "Jumlah harus lebih dari 0."; return false; }
                perubahan = jumlah;
                if (harga > 0) b.HargaBeli = harga;
            }
            else if (jenis == "Keluar")
            {
                if (jumlah <= 0) { pesan = "Jumlah harus lebih dari 0."; return false; }
                if (jumlah > b.Stok) { pesan = "Stok tidak cukup (sisa " + b.Stok + ")."; return false; }
                perubahan = -jumlah;
            }
            else // Penyesuaian: jumlah = stok fisik sebenarnya
            {
                if (string.IsNullOrWhiteSpace(ket)) { pesan = "Alasan wajib diisi."; return false; }
                perubahan = jumlah - b.Stok;
                if (perubahan == 0) { pesan = "Tidak ada selisih."; return false; }
            }

            b.Stok += perubahan;
            Simpan(daftar);   // method simpan yang sudah kamu punya

            var log = HelperJson.BacaData<ModelTransaksi>("DataTransaksi.json");
            log.Add(new ModelTransaksi
            {
                Tanggal = DateTime.Now,
                Kode = b.KodeBarang,
                Nama = b.NamaBarang,
                Jenis = jenis,
                Jumlah = (int)(decimal)perubahan,
                Harga = harga,
                Keterangan = ket,
                StokAkhir = b.Stok
            });
            HelperJson.SimpanData("DataTransaksi.json", log);

            pesan = "Stok " + b.NamaBarang + " sekarang " + b.Stok + ".";
            return true;
        }
    }
}