using System.Drawing.Printing;
using System.Globalization;
using System.Text;

namespace GUedang
{
    public static class StrukHelper
    {
        private static readonly CultureInfo Id = new("id-ID");
        private const int Lebar = 32;   // jumlah karakter per baris (kertas 58mm)

        private static string Rp(decimal n) => "Rp " + n.ToString("N0", Id);
        private static string Tengah(string s) => s.Length >= Lebar ? s : new string(' ', (Lebar - s.Length) / 2) + s;
        private static string Garis(char c = '-') => new string(c, Lebar);
        private static string KiriKanan(string kiri, string kanan)
        {
            int spasi = Math.Max(1, Lebar - kiri.Length - kanan.Length);
            return kiri + new string(' ', spasi) + kanan;
        }

        public static string BuatTeks(Transaksi t)
        {
            var sb = new StringBuilder();
            sb.AppendLine(Tengah("SMK MART"));
            sb.AppendLine(Tengah("Struk Penjualan"));
            sb.AppendLine(Garis('='));
            sb.AppendLine("No    : " + t.Kode);
            sb.AppendLine("Waktu : " + t.Tanggal.ToString("dd/MM/yyyy HH:mm"));
            sb.AppendLine("Kasir : " + t.Kasir);
            sb.AppendLine(Garis());

            foreach (var d in t.Detail)
            {
                string nama = d.NamaBarang.Length > Lebar ? d.NamaBarang[..Lebar] : d.NamaBarang;
                sb.AppendLine(nama);
                sb.AppendLine(KiriKanan($"  {d.Qty} x {d.Harga.ToString("N0", Id)}", d.Subtotal.ToString("N0", Id)));
            }

            sb.AppendLine(Garis());
            sb.AppendLine(KiriKanan("Subtotal", Rp(t.Subtotal)));
            sb.AppendLine(KiriKanan("Diskon", Rp(t.Diskon)));
            sb.AppendLine(KiriKanan("TOTAL", Rp(t.Total)));
            sb.AppendLine(Garis());
            sb.AppendLine(KiriKanan("Metode", t.Metode));
            sb.AppendLine(KiriKanan("Bayar", Rp(t.Bayar)));
            sb.AppendLine(KiriKanan("Kembali", Rp(t.Kembali)));
            sb.AppendLine(Garis('='));
            sb.AppendLine(Tengah("Terima kasih"));
            sb.AppendLine(Tengah("Selamat berbelanja kembali"));
            return sb.ToString();
        }

        /// <summary>Tampilkan jendela struk (preview) dengan tombol Cetak.</summary>
        public static void Tampilkan(IWin32Window? owner, Transaksi t)
        {
            string teks = BuatTeks(t);

            using var f = new Form
            {
                Text = "Struk - " + t.Kode,
                StartPosition = FormStartPosition.CenterParent,
                ClientSize = new Size(420, 640),
                FormBorderStyle = FormBorderStyle.FixedDialog,
                MaximizeBox = false,
                MinimizeBox = false,
                BackColor = Color.White
            };
            var rtb = new RichTextBox
            {
                Dock = DockStyle.Fill,
                ReadOnly = true,
                BorderStyle = BorderStyle.None,
                Font = new Font("Consolas", 11F),
                Text = teks,
                BackColor = Color.White
            };
            var pnl = new FlowLayoutPanel
            {
                Dock = DockStyle.Bottom,
                Height = 56,
                FlowDirection = FlowDirection.RightToLeft,
                Padding = new Padding(10)
            };
            var btnTutup = new Button { Text = "Tutup", Width = 100, Height = 36, DialogResult = DialogResult.Cancel };
            var btnCetak = new Button { Text = "Cetak", Width = 100, Height = 36 };
            btnCetak.Click += (s, e) => Cetak(teks);
            pnl.Controls.Add(btnTutup);
            pnl.Controls.Add(btnCetak);

            f.Controls.Add(rtb);
            f.Controls.Add(pnl);
            f.CancelButton = btnTutup;
            f.ShowDialog(owner);
        }

        private static void Cetak(string teks)
        {
            try
            {
                var lines = teks.Split(new[] { "\r\n", "\n" }, StringSplitOptions.None);
                using var font = new Font("Consolas", 8F);
                using var pd = new PrintDocument();
                pd.DefaultPageSettings.PaperSize = new PaperSize("Struk", 227, 1000); // ± 58mm
                pd.DefaultPageSettings.Margins = new Margins(5, 5, 10, 10);
                pd.PrintPage += (s, e) =>
                {
                    float y = e.MarginBounds.Top;
                    foreach (var line in lines)
                    {
                        e.Graphics!.DrawString(line, font, Brushes.Black, e.MarginBounds.Left, y);
                        y += font.GetHeight(e.Graphics);
                    }
                    e.HasMorePages = false;
                };
                pd.Print();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mencetak: " + ex.Message, "Cetak", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}