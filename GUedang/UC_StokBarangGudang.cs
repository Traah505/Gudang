using System.Globalization;

namespace GUedang
{
    public partial class UC_StokBarangGudang : UserControl
    {
        private static readonly CultureInfo _id = new("id-ID");

        private bool _loading;
        private string _kodeTerpilih = "";
        private Barang? _terpilih;

        public UC_StokBarangGudang()
        {
            InitializeComponent();

            // ---- pengaturan grid ----
            dgvStok.ReadOnly = true;
            dgvStok.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            foreach (var nama in new[] { "colNo", "colStok", "colMin", "colNilai" })
                dgvStok.Columns[nama].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            // ---- isi awal combo ----
            _loading = true;
            cmbStatus.SelectedIndex = 0;
            _loading = false;

            // ---- event ----
            txtCari.TextChanged += Filter_Changed;
            cmbKategori.SelectedIndexChanged += Filter_Changed;
            cmbStatus.SelectedIndexChanged += Filter_Changed;
            btnReset.Click += btnReset_Click;

            dgvStok.SelectionChanged += dgvStok_SelectionChanged;
            dgvStok.CellFormatting += dgvStok_CellFormatting;

            nudFisik.ValueChanged += (s, e) => HitungSelisih();
            btnSimpanAdj.Click += btnSimpanAdj_Click;
            btnSimpanMin.Click += btnSimpanMin_Click;

            VisibleChanged += (s, e) => { if (Visible) MuatData(); };
            HandleCreated += (s, e) => { BarangStore.DataChanged -= OnDataChanged; BarangStore.DataChanged += OnDataChanged; };
            HandleDestroyed += (s, e) => BarangStore.DataChanged -= OnDataChanged;

            MuatData();
        }

        // ===== handler yang dirujuk designer (hapus jika sudah ada di file lain) =====
        private void tlpRoot_Paint(object? sender, PaintEventArgs e) { }
        private void lblDetailStok_Click(object? sender, EventArgs e) { }
        private void nudMinBaru_ValueChanged(object? sender, EventArgs e) => UpdateTombolMin();

        private void OnDataChanged()
        {
            if (IsHandleCreated && !IsDisposed) BeginInvoke(new Action(MuatData));
        }

        // ================= STATUS =================
        private static string StatusBarang(Barang b)
            => b.Stok <= 0 ? "Habis" : b.Stok <= b.StokMinimum ? "Menipis" : "Aman";

        private static Color WarnaStatus(string status) => status switch
        {
            "Habis" => Color.FromArgb(211, 47, 47),
            "Menipis" => Color.FromArgb(200, 125, 10),
            "Aman" => Color.FromArgb(40, 140, 90),
            _ => Color.RoyalBlue
        };

        private static string Satuan(Barang b)
            => string.IsNullOrWhiteSpace(b.Satuan) ? "Item" : b.Satuan;

        // ================= LOAD DATA =================
        public void MuatData()
        {
            if (DesignMode) return;

            _loading = true;
            try
            {
                var semua = BarangStore.GetAll();
                IsiKategori(semua);

                string cari = txtCari.Text.Trim();
                string kategori = cmbKategori.SelectedIndex > 0 ? cmbKategori.Text : "";
                string status = cmbStatus.SelectedIndex > 0 ? cmbStatus.Text : "";

                var data = semua
                    .Where(b => cari == ""
                        || b.Nama.Contains(cari, StringComparison.OrdinalIgnoreCase)
                        || b.Kode.Contains(cari, StringComparison.OrdinalIgnoreCase))
                    .Where(b => kategori == "" || string.Equals(b.Kategori, kategori, StringComparison.OrdinalIgnoreCase))
                    .Where(b => status == "" || StatusBarang(b) == status)
                    .OrderBy(b => b.Nama)
                    .ToList();

                dgvStok.Rows.Clear();
                int no = 1;
                foreach (var b in data)
                {
                    int idx = dgvStok.Rows.Add(
                        no++,
                        b.Kode,
                        b.Nama,
                        b.Kategori,
                        b.Stok.ToString("N0", _id),
                        b.StokMinimum.ToString("N0", _id),
                        string.Format(_id, "{0:N0}", b.Stok * b.HargaBeli),
                        StatusBarang(b));
                    dgvStok.Rows[idx].Tag = b.Kode;
                }

                // pilih ulang barang yang tadi terpilih
                dgvStok.ClearSelection();
                if (_kodeTerpilih != "")
                {
                    foreach (DataGridViewRow r in dgvStok.Rows)
                    {
                        if ((r.Tag as string) == _kodeTerpilih)
                        {
                            r.Selected = true;
                            dgvStok.CurrentCell = r.Cells["colNama"];
                            break;
                        }
                    }
                }

                // ringkasan (berdasarkan hasil filter)
                int menipis = data.Count(b => StatusBarang(b) == "Menipis");
                int habis = data.Count(b => StatusBarang(b) == "Habis");
                lblRingkasan.Text = $"{data.Count} barang • {menipis} menipis • {habis} habis";
            }
            finally
            {
                _loading = false;
            }

            TampilkanDetail();
        }

        private void IsiKategori(List<Barang> semua)
        {
            string sebelum = cmbKategori.SelectedIndex > 0 ? cmbKategori.Text : "";

            var daftar = semua
                .Select(b => b.Kategori)
                .Where(k => !string.IsNullOrWhiteSpace(k))
                .Distinct(StringComparer.OrdinalIgnoreCase)
                .OrderBy(k => k)
                .Cast<object>()
                .ToArray();

            cmbKategori.Items.Clear();
            cmbKategori.Items.Add("Semua kategori");
            cmbKategori.Items.AddRange(daftar);

            int i = sebelum == "" ? 0 : cmbKategori.Items.IndexOf(sebelum);
            cmbKategori.SelectedIndex = i < 0 ? 0 : i;
        }

        // ================= FILTER =================
        private void Filter_Changed(object? sender, EventArgs e)
        {
            if (_loading) return;
            MuatData();
        }

        private void btnReset_Click(object? sender, EventArgs e)
        {
            _loading = true;
            txtCari.Clear();
            cmbKategori.SelectedIndex = 0;
            cmbStatus.SelectedIndex = 0;
            _loading = false;
            MuatData();
        }

        // ================= PILIH BARANG & DETAIL =================
        private void dgvStok_SelectionChanged(object? sender, EventArgs e)
        {
            if (_loading) return;
            _kodeTerpilih = dgvStok.SelectedRows.Count > 0
                ? (dgvStok.SelectedRows[0].Tag as string ?? "")
                : "";
            TampilkanDetail();
        }

        private void TampilkanDetail()
        {
            _terpilih = _kodeTerpilih == "" ? null : BarangStore.GetByKode(_kodeTerpilih);
            if (_terpilih == null) _kodeTerpilih = "";

            bool ada = _terpilih != null;
            nudFisik.Enabled = ada;
            txtAlasan.Enabled = ada;
            nudMinBaru.Enabled = ada;
            btnSimpanAdj.Enabled = ada;

            if (_terpilih == null)
            {
                lblDetailNama.Text = "Pilih barang di tabel";
                lblDetailStok.Text = "0 Item";
                lblMiniMinNilai.Text = "0 Item";
                lblMiniStatusNilai.Text = "-";
                lblMiniStatusNilai.ForeColor = Color.FromArgb(13, 47, 110);
                lblTerakhir.Text = "-";
                nudFisik.Value = 0;
                nudMinBaru.Value = 0;
                txtAlasan.Clear();
                HitungSelisih();
                UpdateTombolMin();
                return;
            }

            var b = _terpilih;
            string status = StatusBarang(b);

            lblDetailNama.Text = $"{b.Nama} ({b.Kode})";
            lblDetailStok.Text = $"{b.Stok:N0} {Satuan(b)}";
            lblMiniMinNilai.Text = $"{b.StokMinimum:N0} {Satuan(b)}";
            lblMiniStatusNilai.Text = status;
            lblMiniStatusNilai.ForeColor = WarnaStatus(status);

            var terakhir = StoreRiwayatGudang.Semua()
                .Where(x => x.KodeBarang.Equals(b.Kode, StringComparison.OrdinalIgnoreCase))
                .OrderByDescending(x => x.Waktu)
                .FirstOrDefault();
            lblTerakhir.Text = terakhir == null
                ? "Belum ada pergerakan stok"
                : $"Terakhir: {terakhir.Jenis} • {terakhir.Waktu:dd/MM/yyyy HH:mm}";

            nudFisik.Value = Math.Clamp(b.Stok, (int)nudFisik.Minimum, (int)nudFisik.Maximum);
            nudMinBaru.Value = Math.Clamp(b.StokMinimum, (int)nudMinBaru.Minimum, (int)nudMinBaru.Maximum);
            txtAlasan.Clear();
            HitungSelisih();
            UpdateTombolMin();
        }

        // ================= PENYESUAIAN =================
        private void HitungSelisih()
        {
            if (_terpilih == null)
            {
                txtSelisih.Text = "0";
                txtSelisih.ForeColor = Color.FromArgb(13, 47, 110);
                return;
            }

            int selisih = (int)nudFisik.Value - _terpilih.Stok;
            txtSelisih.Text = selisih > 0 ? "+" + selisih : selisih.ToString();
            txtSelisih.ForeColor = selisih > 0 ? WarnaStatus("Aman")
                                 : selisih < 0 ? WarnaStatus("Habis")
                                 : Color.FromArgb(13, 47, 110);
        }

        private void btnSimpanAdj_Click(object? sender, EventArgs e)
        {
            if (_terpilih == null)
            {
                MessageBox.Show("Pilih barang di tabel terlebih dahulu.", "Penyesuaian Stok",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int selisih = (int)nudFisik.Value - _terpilih.Stok;
            if (selisih == 0)
            {
                MessageBox.Show("Jumlah fisik sama dengan stok sistem, tidak ada yang perlu disesuaikan.",
                    "Penyesuaian Stok", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string alasan = txtAlasan.Text.Trim();
            if (alasan == "")
            {
                MessageBox.Show("Alasan penyesuaian wajib diisi.", "Penyesuaian Stok",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAlasan.Focus();
                return;
            }

            var konfirmasi = MessageBox.Show(
                $"Sesuaikan stok \"{_terpilih.Nama}\"?\n\nStok sistem : {_terpilih.Stok:N0}\nStok fisik  : {nudFisik.Value:N0}\nSelisih     : {(selisih > 0 ? "+" : "")}{selisih}",
                "Konfirmasi Penyesuaian", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (konfirmasi != DialogResult.Yes) return;

            // UbahStok versi yang punya parameter jenis => otomatis tercatat di Riwayat Gudang
            bool ok = BarangStore.UbahStok(_terpilih.Kode, selisih, "Penyesuaian", "-", alasan);
            if (!ok)
            {
                MessageBox.Show("Gagal menyesuaikan stok. Barang tidak ditemukan atau stok menjadi minus.",
                    "Penyesuaian Stok", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Penyesuaian stok berhasil disimpan.", "Penyesuaian Stok",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            MuatData();
        }

        // ================= STOK MINIMUM =================
        private void UpdateTombolMin()
        {
            btnSimpanMin.Enabled = _terpilih != null && (int)nudMinBaru.Value != _terpilih.StokMinimum;
        }

        private void btnSimpanMin_Click(object? sender, EventArgs e)
        {
            if (_terpilih == null) return;

            var b = BarangStore.GetByKode(_terpilih.Kode);
            if (b == null)
            {
                MessageBox.Show("Barang tidak ditemukan.", "Stok Minimum",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            b.StokMinimum = (int)nudMinBaru.Value;
            BarangStore.Simpan(b);

            MessageBox.Show("Stok minimum berhasil diubah.", "Stok Minimum",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            MuatData();
        }

        // ================= WARNA STATUS DI TABEL =================
        private void dgvStok_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.Value == null) return;
            if (dgvStok.Columns[e.ColumnIndex].Name != "colStatus") return;

            e.CellStyle!.ForeColor = WarnaStatus(e.Value.ToString() ?? "");
            e.CellStyle.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
        }
    }
}