using System.Globalization;

namespace GUedang
{
    /// <summary>Kartu stok satu barang. Dibuat lewat kode (tanpa designer).</summary>
    public class FormKartuStok : Form
    {
        private static readonly CultureInfo _id = new("id-ID");
        private readonly DataGridView dgv = new();

        public FormKartuStok(string kode, string nama, string idDisorot = "")
        {
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            Text = "Kartu Stok";
            StartPosition = FormStartPosition.CenterParent;
            BackColor = Color.White;
            ClientSize = new Size(1150, 620);
            MinimumSize = new Size(900, 450);
            Padding = new Padding(20, 12, 20, 12);

            // ---- judul ----
            var lblJudul = new Label
            {
                Dock = DockStyle.Top,
                Height = 48,
                Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold),
                ForeColor = Color.FromArgb(13, 47, 110),
                TextAlign = ContentAlignment.MiddleLeft,
                Text = $"Kartu Stok • {(kode == "" ? "-" : kode)}: {nama}"
            };

            // ---- footer ----
            var pnlBawah = new Panel { Dock = DockStyle.Bottom, Height = 54 };
            var lblFooter = new Label
            {
                Dock = DockStyle.Fill,
                Font = new Font("Segoe UI", 9.5F),
                ForeColor = Color.FromArgb(90, 110, 140),
                TextAlign = ContentAlignment.MiddleLeft
            };
            var btnTutup = new Button
            {
                Text = "Tutup",
                Dock = DockStyle.Right,
                Width = 120,
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.RoyalBlue,
                ForeColor = Color.White,
                Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold)
            };
            btnTutup.FlatAppearance.BorderSize = 0;
            btnTutup.Click += (s, e) => Close();
            pnlBawah.Controls.Add(lblFooter);
            pnlBawah.Controls.Add(btnTutup);

            // ---- grid ----
            SiapkanGrid();

            // urutan Add penting untuk docking: Fill dulu, lalu Bottom, lalu Top
            Controls.Add(dgv);
            Controls.Add(pnlBawah);
            Controls.Add(lblJudul);

            AcceptButton = btnTutup;
            CancelButton = btnTutup;

            // ---- isi data ----
            var catatan = StoreRiwayatGudang.Semua()
                .Where(x => kode != ""
                    ? x.KodeBarang.Equals(kode, StringComparison.OrdinalIgnoreCase)
                    : x.NamaBarang.Equals(nama, StringComparison.OrdinalIgnoreCase))
                .OrderByDescending(x => x.Waktu)
                .ToList();

            int barisSorot = -1;
            foreach (var x in catatan)
            {
                string jumlah = x.JumlahBertanda > 0 ? "+" + x.JumlahBertanda : x.JumlahBertanda.ToString();
                int idx = dgv.Rows.Add(
                    x.Waktu.ToString("dd/MM/yyyy HH:mm", _id),
                    x.Jenis,
                    x.StokAwal,
                    jumlah,
                    x.StokAkhir,
                    string.IsNullOrWhiteSpace(x.Pihak) ? "-" : x.Pihak,
                    string.IsNullOrWhiteSpace(x.Keterangan) ? "-" : x.Keterangan,
                    string.IsNullOrWhiteSpace(x.Oleh) ? "-" : x.Oleh);

                if (x.Id == idDisorot)
                {
                    barisSorot = idx;
                    var row = dgv.Rows[idx];
                    row.DefaultCellStyle.BackColor = Color.FromArgb(255, 236, 160);
                    row.DefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 236, 160);
                }
            }

            int stokSekarang = BarangStore.GetByKode(kode)?.Stok
                               ?? (catatan.Count > 0 ? catatan[0].StokAkhir : 0);
            lblFooter.Text = $"{nama} • Stok saat ini: {stokSekarang:N0} • {catatan.Count} catatan";

            Shown += (s, e) =>
            {
                dgv.ClearSelection();
                if (barisSorot >= 0)
                    dgv.FirstDisplayedScrollingRowIndex = Math.Max(0, barisSorot - 3);
            };
        }

        private void SiapkanGrid()
        {
            dgv.Dock = DockStyle.Fill;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.ReadOnly = true;
            dgv.MultiSelect = false;
            dgv.RowHeadersVisible = false;
            dgv.BorderStyle = BorderStyle.None;
            dgv.BackgroundColor = Color.White;
            dgv.EnableHeadersVisualStyles = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgv.ColumnHeadersHeight = 40;

            dgv.ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle
            {
                Alignment = DataGridViewContentAlignment.MiddleLeft,
                BackColor = Color.RoyalBlue,
                ForeColor = Color.White,
                Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold),
                SelectionBackColor = Color.RoyalBlue,
                SelectionForeColor = Color.White,
                WrapMode = DataGridViewTriState.True
            };
            dgv.DefaultCellStyle = new DataGridViewCellStyle
            {
                Alignment = DataGridViewContentAlignment.MiddleLeft,
                BackColor = Color.AliceBlue,
                ForeColor = Color.FromArgb(13, 47, 110),
                Font = new Font("Segoe UI", 9F),
                SelectionBackColor = Color.SkyBlue,
                SelectionForeColor = Color.FromArgb(13, 47, 110)
            };

            void Kol(string nama, string header, float bobot, bool kanan = false)
            {
                var c = new DataGridViewTextBoxColumn
                {
                    Name = nama,
                    HeaderText = header,
                    FillWeight = bobot,
                    MinimumWidth = 8
                };
                if (kanan) c.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgv.Columns.Add(c);
            }

            Kol("colWaktu", "Tanggal", 16);
            Kol("colJenis", "Jenis", 12);
            Kol("colAwal", "Stok Awal", 9, true);
            Kol("colJumlah", "Jumlah", 9, true);
            Kol("colAkhir", "Stok Akhir", 9, true);
            Kol("colPihak", "Supplier / Tujuan", 16);
            Kol("colKet", "Keterangan", 20);
            Kol("colOleh", "Oleh", 9);

            dgv.CellFormatting += (s, e) =>
            {
                if (e.RowIndex < 0 || e.Value == null) return;
                string kolom = dgv.Columns[e.ColumnIndex].Name;
                if (kolom != "colJenis" && kolom != "colJumlah") return;

                string jenis = dgv.Rows[e.RowIndex].Cells["colJenis"].Value?.ToString() ?? "";
                e.CellStyle!.ForeColor = jenis switch
                {
                    "Masuk" => Color.FromArgb(24, 94, 224),
                    "Keluar" => Color.FromArgb(40, 140, 90),
                    "Penyesuaian" => Color.FromArgb(200, 125, 10),
                    _ => Color.RoyalBlue
                };
                e.CellStyle.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            };
        }
    }
}