using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Windows.Forms;

namespace GUedang
{
    public static class StrukPrinter
    {
        public static void Tampilkan(ModelPenjualan t)
        {
            var doc = new PrintDocument();
            doc.DefaultPageSettings.PaperSize = new PaperSize("Struk", 300, 200 + t.Items.Count * 45);
            doc.DefaultPageSettings.Margins = new Margins(10, 10, 10, 10);
            doc.PrintPage += (s, e) => Gambar(e, t);

            using (var preview = new PrintPreviewDialog())
            {
                preview.Document = doc;
                preview.Width = 500;
                preview.Height = 700;
                preview.ShowDialog();
            }
        }

        private static void Gambar(PrintPageEventArgs e, ModelPenjualan t)
        {
            var g = e.Graphics;
            var fN = new Font("Consolas", 9);
            var fB = new Font("Consolas", 12, FontStyle.Bold);
            float lebar = e.MarginBounds.Width;
            float x = e.MarginBounds.Left;
            float y = e.MarginBounds.Top;

            var tengah = new StringFormat { Alignment = StringAlignment.Center };
            var kanan = new StringFormat { Alignment = StringAlignment.Far };

            void Tengah(string teks, Font f)
            {
                g.DrawString(teks, f, Brushes.Black, new RectangleF(x, y, lebar, 25), tengah);
                y += f.GetHeight(g) + 2;
            }
            void Garis()
            {
                g.DrawString(new string('-', 34), fN, Brushes.Black, x, y);
                y += fN.GetHeight(g);
            }
            void Baris(string kiri, string kananTeks)
            {
                g.DrawString(kiri, fN, Brushes.Black, x, y);
                g.DrawString(kananTeks, fN, Brushes.Black, new RectangleF(x, y, lebar, 20), kanan);
                y += fN.GetHeight(g) + 1;
            }

            Tengah("SMK MART", fB);
            Tengah("Struk Pembelian", fN);
            Garis();
            Baris("No", t.NoTransaksi);
            Baris("Tanggal", t.Waktu.ToString("dd/MM/yyyy HH:mm"));
            Baris("Kasir", t.Kasir);
            Garis();

            foreach (var i in t.Items)
            {
                g.DrawString(i.Nama, fN, Brushes.Black, x, y);
                y += fN.GetHeight(g);
                Baris("  " + i.Jumlah.ToString("0.##") + " x " + i.Harga.ToString("N0"),
                      i.Subtotal.ToString("N0"));
            }

            Garis();
            Baris("TOTAL", "Rp " + t.Total.ToString("N0"));
            Baris("BAYAR", "Rp " + t.Bayar.ToString("N0"));
            Baris("KEMBALI", "Rp " + (t.Bayar - t.Total).ToString("N0"));
            Garis();
            y += 5;
            Tengah("Terima kasih", fN);
            Tengah("Selamat datang kembali", fN);

            e.HasMorePages = false;
        }
    }
}