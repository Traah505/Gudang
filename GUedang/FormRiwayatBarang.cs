using System.Globalization;

namespace GUedang
{
    /// <summary>Antrian stok FIFO + riwayat stok masuk dan perubahan harga satu barang.</summary>
    public class FormRiwayatBarang : Form
    {
        private static readonly CultureInfo _id = new("id-ID");

        public FormRiwayatBarang(string kode, string nama)
        {
            LapisanStokStore.Sinkronkan(kode);
            string satuan = BarangStore.GetByKode(kode)?.Satuan ?? "";

            Text = $"Riwayat Barang - {kode} {nama}";
            StartPosition = FormStartPosition.CenterParent;
            ClientSize = new Size(1000, 640);
            MinimumSize = new Size(820, 520);
            BackColor = Color.FromArgb(234, 243, 252);
            Font = new Font("Segoe UI", 9.5F);

            var judul = Judul($"{nama}  ({kode})", 15F);
            var sub1 = Judul("Antrian stok (FIFO): baris paling atas dijual lebih dulu", 10.5F);
            var sub2 = Judul("Riwayat stok masuk dan perubahan harga", 10.5F);

            var dgvLapisan = BuatGrid("No", "Tanggal masuk", "Sumber", "Jumlah awal", "Sisa",
                                      "Harga beli", "Harga jual", "Status");
            dgvLapisan.Columns[0].FillWeight = 30;
            var dgvRiwayat = BuatGrid("Tanggal", "Kejadian", "Keterangan");
            dgvRiwayat.Columns[2].FillWeight = 200;

            // ---- antrian FIFO ----
            bool sudahAdaAktif = false;
            int no = 1;
            foreach (var l in LapisanStokStore.Lapisan(kode))
            {
                string status; Color warna;
                if (l.Sisa <= 0) { status = "Habis terjual"; warna = Color.Gray; }
                else if (!sudahAdaAktif) { status = "Sedang dijual"; warna = Color.FromArgb(40, 140, 90); sudahAdaAktif = true; }
                else { status = "Antri"; warna = Color.RoyalBlue; }

                int i = dgvLapisan.Rows.Add(no++, l.Tanggal.ToString("dd/MM/yyyy HH:mm"), l.Sumber,
                    l.JumlahAwal, l.Sisa, l.HargaBeli.ToString("N0", _id), l.HargaJual.ToString("N0", _id), status);
                dgvLapisan.Rows[i].Cells[7].Style.ForeColor = warna;
                dgvLapisan.Rows[i].Cells[7].Style.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            }

            // ---- riwayat kejadian ----
            var kejadian = new List<(DateTime tgl, string jenis, string ket)>();
            foreach (var l in LapisanStokStore.Lapisan(kode))
            {
                string tambahan = string.IsNullOrWhiteSpace(l.Keterangan) ? "" : $"  ({l.Keterangan})";
                kejadian.Add((l.Tanggal, l.Sumber == "Stok awal" ? "Stok awal" : "Stok masuk",
                    $"+{l.JumlahAwal} {satuan}, harga beli Rp {l.HargaBeli.ToString("N0", _id)}, " +
                    $"harga jual Rp {l.HargaJual.ToString("N0", _id)}{tambahan}"));
            }
            foreach (var p in LapisanStokStore.Peristiwa(kode))
                kejadian.Add((p.Tanggal, p.Jenis,
                    $"Harga jual Rp {p.HargaLama.ToString("N0", _id)}  →  Rp {p.HargaBaru.ToString("N0", _id)}" +
                    (string.IsNullOrWhiteSpace(p.Keterangan) ? "" : $"  ({p.Keterangan})")));

            foreach (var k in kejadian.OrderByDescending(x => x.tgl))
                dgvRiwayat.Rows.Add(k.tgl.ToString("dd/MM/yyyy HH:mm"), k.jenis, k.ket);

            // ---- susunan ----
            var btnTutup = new Button
            {
                Text = "Tutup",
                DialogResult = DialogResult.Cancel,
                Size = new Size(100, 32),
                Anchor = AnchorStyles.Right,
                Margin = new Padding(0, 10, 0, 0)
            };
            CancelButton = btnTutup;

            var tlp = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 1,
                RowCount = 6,
                Padding = new Padding(18)
            };
            tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlp.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            tlp.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            tlp.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlp.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            tlp.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlp.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            tlp.Controls.Add(judul, 0, 0);
            tlp.Controls.Add(sub1, 0, 1);
            tlp.Controls.Add(dgvLapisan, 0, 2);
            tlp.Controls.Add(sub2, 0, 3);
            tlp.Controls.Add(dgvRiwayat, 0, 4);
            tlp.Controls.Add(btnTutup, 0, 5);
            Controls.Add(tlp);
        }

        private static Label Judul(string teks, float ukuran) => new()
        {
            Text = teks,
            AutoSize = true,
            Font = new Font("Segoe UI Semibold", ukuran, FontStyle.Bold),
            ForeColor = Color.FromArgb(13, 47, 110),
            Margin = new Padding(0, 6, 0, 6)
        };

        private static DataGridView BuatGrid(params string[] kolom)
        {
            var g = new DataGridView
            {
                Dock = DockStyle.Fill,
                ReadOnly = true,
                AllowUserToAddRows = false,
                AllowUserToDeleteRows = false,
                AllowUserToResizeRows = false,
                RowHeadersVisible = false,
                MultiSelect = false,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                BackgroundColor = Color.White,
                BorderStyle = BorderStyle.None,
                EnableHeadersVisualStyles = false,
                ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing,
                ColumnHeadersHeight = 34,
                Margin = new Padding(0, 0, 0, 6)
            };
            g.ColumnHeadersDefaultCellStyle.BackColor = Color.RoyalBlue;
            g.ColumnHeadersDefaultCellStyle.ForeColor = Color.AliceBlue;
            g.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.RoyalBlue;
            g.DefaultCellStyle.BackColor = Color.AliceBlue;
            g.DefaultCellStyle.ForeColor = Color.RoyalBlue;
            foreach (var k in kolom)
                g.Columns.Add("col" + k.Replace(" ", ""), k);
            return g;
        }
    }
}