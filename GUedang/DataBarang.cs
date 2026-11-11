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

        public static bool TambahAtauUbahBarang(string kode, string nama, string kategori, int stok, decimal hBeli, decimal hJual, out string pesan)
        {
            var daftar = Muat();

            var existing = daftar.FirstOrDefault(x => x.KodeBarang == kode);
            if (existing != null)
            {
                existing.KodeBarang = kode;
                existing.NamaBarang = nama;
                existing.Kategori = kategori;
                existing.Stok = stok;
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
                    HargaJual = hJual
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
    }
}