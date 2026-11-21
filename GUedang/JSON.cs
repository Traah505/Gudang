using System;
using System.Data;
using System.Globalization;
using System.IO;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Windows.Forms;

namespace GUedang
{
    /// <summary>
    /// Penyimpanan data ke file JSON (tanpa database).
    /// Setiap tabel disimpan sebagai satu file array JSON di folder <see cref="Folder"/>:
    ///   barang.json, mutasi.json, transaksi.json, transaksi_detail.json, pengguna.json, aktivitas.json
    /// </summary>
    public static class JsonStore
    {
        /// <summary>
        /// Folder tempat file JSON disimpan. Bisa diganti sebelum form pertama dibuka (mis. di Program.cs):
        ///   JsonStore.Folder = @"C:\SMKMart\Data";
        /// </summary>
        public static string Folder = Path.Combine(AppContext.BaseDirectory, "Data");

        /// <summary>
        /// true  = jika file JSON belum ada, isi dengan data contoh (untuk mencoba tampilan).
        /// false = mulai dari data kosong (untuk pemakaian sebenarnya). Atur ke false di Program.cs.
        /// </summary>
        public static bool DataContoh = true;

        private static readonly object Kunci = new object();
        private static readonly CultureInfo Inv = CultureInfo.InvariantCulture;

        /// <summary>
        /// Baca file JSON ke DataTable dengan kolom sesuai <paramref name="skema"/>.
        /// Mengembalikan null jika file belum ada. Kolom yang tidak ada di file diisi nilai bawaan.
        /// Jika file rusak, salinannya disimpan dengan akhiran .rusak-… dan null dikembalikan.
        /// </summary>
        public static DataTable Muat(string namaFile, DataTable skema)
        {
            lock (Kunci)
            {
                string path = Path.Combine(Folder, namaFile);
                if (!File.Exists(path)) return null;

                try
                {
                    string isi = File.ReadAllText(path, Encoding.UTF8);
                    DataTable hasil = skema.Clone();
                    if (isi.Trim().Length == 0) return hasil;

                    using (JsonDocument doc = JsonDocument.Parse(isi))
                    {
                        if (doc.RootElement.ValueKind != JsonValueKind.Array)
                            throw new JsonException("Isi file harus berupa array [ ... ].");

                        foreach (JsonElement el in doc.RootElement.EnumerateArray())
                        {
                            DataRow row = hasil.NewRow();
                            foreach (DataColumn c in hasil.Columns) row[c] = Ambil(el, c);
                            hasil.Rows.Add(row);
                        }
                    }
                    hasil.AcceptChanges();
                    return hasil;
                }
                catch (Exception ex)
                {
                    string cadangan = path + ".rusak-" + DateTime.Now.ToString("yyyyMMdd-HHmmss");
                    try { File.Copy(path, cadangan, true); } catch { }
                    MessageBox.Show("File data \"" + namaFile + "\" tidak bisa dibaca:\n" + ex.Message +
                        "\n\nSalinannya disimpan di:\n" + cadangan +
                        "\n\nUntuk file ini aplikasi memakai data kosong.",
                        "Data JSON", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return null;
                }
            }
        }

        /// <summary>Simpan DataTable ke file JSON. File lama dicadangkan sebagai .bak.</summary>
        public static void Simpan(string namaFile, DataTable tabel)
        {
            lock (Kunci)
            {
                try
                {
                    Directory.CreateDirectory(Folder);
                    string path = Path.Combine(Folder, namaFile);
                    string tmp = path + ".tmp";

                    var opsi = new JsonWriterOptions { Indented = true, Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping };
                    using (FileStream fs = File.Create(tmp))
                    using (var w = new Utf8JsonWriter(fs, opsi))
                    {
                        w.WriteStartArray();
                        foreach (DataRow r in tabel.Rows)
                        {
                            w.WriteStartObject();
                            foreach (DataColumn c in tabel.Columns)
                            {
                                object v = r[c];
                                if (v == null || v == DBNull.Value) { w.WriteNull(c.ColumnName); continue; }

                                if (c.DataType == typeof(int)) w.WriteNumber(c.ColumnName, Convert.ToInt32(v));
                                else if (c.DataType == typeof(decimal)) w.WriteNumber(c.ColumnName, Convert.ToDecimal(v));
                                else if (c.DataType == typeof(DateTime)) w.WriteString(c.ColumnName, ((DateTime)v).ToString("yyyy-MM-ddTHH:mm:ss", Inv));
                                else w.WriteString(c.ColumnName, Convert.ToString(v, Inv));
                            }
                            w.WriteEndObject();
                        }
                        w.WriteEndArray();
                    }

                    if (File.Exists(path)) File.Copy(path, path + ".bak", true);
                    File.Move(tmp, path, true);
                }
                catch (Exception ex)
                {
                    throw new InvalidOperationException("Gagal menyimpan file " + namaFile + ": " + ex.Message);
                }
            }
        }

        // ------------------------------------------------------------ konversi

        private static object Ambil(JsonElement el, DataColumn c)
        {
            JsonElement p = default(JsonElement);
            bool ada = false;
            if (el.ValueKind == JsonValueKind.Object)
            {
                foreach (JsonProperty prop in el.EnumerateObject())
                {
                    if (string.Equals(prop.Name, c.ColumnName, StringComparison.OrdinalIgnoreCase))
                    {
                        p = prop.Value;
                        ada = true;
                        break;
                    }
                }
            }

            Type t = c.DataType;
            if (!ada || p.ValueKind == JsonValueKind.Null || p.ValueKind == JsonValueKind.Undefined) return Bawaan(t);

            try
            {
                if (t == typeof(string))
                    return p.ValueKind == JsonValueKind.String ? p.GetString() : p.ToString();

                if (t == typeof(int))
                {
                    if (p.ValueKind == JsonValueKind.Number) return (int)Math.Round(p.GetDecimal());
                    int n;
                    return int.TryParse(p.GetString(), NumberStyles.Any, Inv, out n) ? n : 0;
                }

                if (t == typeof(decimal))
                {
                    if (p.ValueKind == JsonValueKind.Number) return p.GetDecimal();
                    decimal d;
                    return decimal.TryParse(p.GetString(), NumberStyles.Any, Inv, out d) ? d : 0m;
                }

                if (t == typeof(DateTime))
                {
                    DateTime tgl;
                    if (p.ValueKind == JsonValueKind.String && DateTime.TryParse(p.GetString(), Inv, DateTimeStyles.None, out tgl)) return tgl;
                    return DateTime.Today;
                }
            }
            catch
            {
                // nilai tidak cocok dengan tipe kolom: pakai nilai bawaan
            }
            return Bawaan(t);
        }

        private static object Bawaan(Type t)
        {
            if (t == typeof(string)) return "";
            if (t == typeof(int)) return 0;
            if (t == typeof(decimal)) return 0m;
            if (t == typeof(DateTime)) return DateTime.Today;
            return DBNull.Value;
        }
    }
}