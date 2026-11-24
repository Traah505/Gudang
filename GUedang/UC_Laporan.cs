using System.ComponentModel;
using System.Globalization;

namespace GUedang
{
    public partial class UC_Laporan : UserControl
    {
        private readonly CultureInfo _id = new("id-ID");
        private bool _loading;
        private List<Transaksi> _tampil = new();

        public UC_Laporan()
        {
            InitializeComponent();

            Load += UC_Laporan_Load;
            TransaksiStore.DataChanged += OnDataChanged;
            BarangStore.DataChanged += OnDataChanged;
            Disposed += (s, e) =>
            {
                TransaksiStore.DataChanged -= OnDataChanged;
                BarangStore.DataChanged -= OnDataChanged;
            };
        }

        private void OnDataChanged()
        {
            if (IsHandleCreated && !IsDisposed)
                BeginInvoke(new Action(() => { if (!IsPeriodeManual()) ApplyRentang(); Muat(); }));
        }

        private void UC_Laporan_Load(object? sender, EventArgs e)
        {
            if (DesignMode || LicenseManager.UsageMode == LicenseUsageMode.Designtime) return;

            // grid: pilih per baris
            foreach (var g in new[] { dgvTrx, dgvDetail, dgvTop })
                g.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // rata kanan kolom angka
            foreach (var c in new[] { colNo, colItem, colTotal, colDQty, colDSubtotal, colTQty, colTOmzet })
                c.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            _loading = true;
            cmbRentang.SelectedIndex = 0;   // Hari ini
            ApplyRentang();
            _loading = false;

            // event (dipasang setelah nilai awal supaya tidak memicu muat berulang)
            cmbRentang.SelectedIndexChanged += (s, ev) => { ApplyRentang(); Muat(); };
            dtpDari.ValueChanged += (s, ev) => { if (!_loading && IsPeriodeManual()) Muat(); };
            dtpSampai.ValueChanged += (s, ev) => { if (!_loading && IsPeriodeManual()) Muat(); };
            txtCari.TextChanged += (s, ev) => Muat();
            txtKasir.TextChanged += (s, ev) => Muat();
            btnTampilkan.Click += (s, ev) => { if (!IsPeriodeManual()) ApplyRentang(); Muat(); };
            dgvTrx.SelectionChanged += dgvTrx_SelectionChanged;
            dgvTrx.CellDoubleClick += (s, ev) =>
            {
                if (ev.RowIndex >= 0) TampilStruk();
            };

            Muat();
        }

        // ================= PERIODE =================
        private bool IsPeriodeManual() => cmbRentang.SelectedItem?.ToString() == "Pilih manual";
        private void TampilStruk()
        {
            if (dgvTrx.SelectedRows.Count == 0 || dgvTrx.SelectedRows[0].Tag is not Transaksi t)
            {
                MessageBox.Show("Pilih transaksi dulu.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            StrukHelper.Tampilkan(FindForm(), t);
        }
        private void ApplyRentang()
        {
            DateTime today = DateTime.Today;
            DateTime dari = dtpDari.Value.Date, sampai = dtpSampai.Value.Date;

            switch (cmbRentang.SelectedItem?.ToString())
            {
                case "Hari ini": dari = today; sampai = today; break;
                case "7 hari terakhir": dari = today.AddDays(-6); sampai = today; break;
                case "30 hari terakhir": dari = today.AddDays(-29); sampai = today; break;
                case "Bulan ini": dari = new DateTime(today.Year, today.Month, 1); sampai = today; break;
                case "Semua":
                    var semua = TransaksiStore.GetAll();
                    dari = semua.Count > 0 ? semua.Min(t => t.Tanggal).Date : today;
                    sampai = today;
                    break;
                    // "Pilih manual": biarkan nilai yang dipilih user
            }

            bool lamaLoading = _loading;
            _loading = true;
            dtpDari.Value = dari;
            dtpSampai.Value = sampai;
            _loading = lamaLoading;

            bool manual = IsPeriodeManual();
            dtpDari.Enabled = manual;
            dtpSampai.Enabled = manual;
        }

        // ================= DATA =================
        private void Muat()
        {
            if (_loading) return;

            if (dtpDari.Value.Date > dtpSampai.Value.Date)
            {
                MessageBox.Show("Tanggal 'Dari' tidak boleh lebih besar dari 'Sampai'.",
                    "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string kode = txtCari.Text.Trim();
            string kasir = txtKasir.Text.Trim();

            _tampil = TransaksiStore.GetByPeriode(dtpDari.Value, dtpSampai.Value)
                .Where(t => (kode.Length == 0 || t.Kode.Contains(kode, StringComparison.OrdinalIgnoreCase))
                         && (kasir.Length == 0 || t.Kasir.Contains(kasir, StringComparison.OrdinalIgnoreCase)))
                .OrderByDescending(t => t.Tanggal)
                .ToList();

            // --- kartu statistik ---
            decimal pendapatan = _tampil.Sum(t => t.Total);
            int jumlahTrx = _tampil.Count;
            int totalQty = _tampil.Sum(t => t.TotalItem);
            decimal rata = jumlahTrx > 0 ? pendapatan / jumlahTrx : 0;

            lblPendapatanNilai.Text = Rp(pendapatan);
            lblTrxNilai.Text = jumlahTrx.ToString("N0", _id);
            lblItemNilai.Text = totalQty.ToString("N0", _id);
            lblRataNilai.Text = Rp(rata);

            // --- tabel transaksi ---
            _loading = true;
            dgvTrx.Rows.Clear();
            int no = 1;
            foreach (var t in _tampil)
            {
                int i = dgvTrx.Rows.Add(
                    no++,
                    t.Kode,
                    t.Tanggal.ToString("dd/MM/yyyy HH:mm"),
                    t.Kasir,
                    t.TotalItem,
                    Rp(t.Total));
                dgvTrx.Rows[i].Tag = t;
            }
            _loading = false;

            // --- 5 barang terlaris ---
            dgvTop.Rows.Clear();
            var top = _tampil.SelectMany(t => t.Detail)
                .GroupBy(d => d.KodeBarang)
                .Select(g => new
                {
                    Nama = g.Last().NamaBarang,
                    Qty = g.Sum(x => x.Qty),
                    Omzet = g.Sum(x => x.Subtotal)
                })
                .OrderByDescending(x => x.Qty).ThenByDescending(x => x.Omzet)
                .Take(5);
            foreach (var x in top)
                dgvTop.Rows.Add(x.Nama, x.Qty.ToString("N0", _id), Rp(x.Omzet));
            dgvTop.ClearSelection();

            // --- detail: otomatis tampilkan transaksi pertama ---
            if (dgvTrx.Rows.Count > 0)
            {
                dgvTrx.ClearSelection();
                dgvTrx.Rows[0].Selected = true;
                TampilDetail(_tampil[0]);
            }
            else TampilDetail(null);
        }

        private void dgvTrx_SelectionChanged(object? sender, EventArgs e)
        {
            if (_loading || dgvTrx.SelectedRows.Count == 0) return;
            TampilDetail(dgvTrx.SelectedRows[0].Tag as Transaksi);
        }

        private void TampilDetail(Transaksi? t)
        {
            dgvDetail.Rows.Clear();

            if (t == null)
            {
                lblDetailNo.Text = "Pilih transaksi untuk melihat detail";
                lblDetailTotal.Text = "Total: Rp 0";
                return;
            }

            lblDetailNo.Text = $"{t.Kode}  •  {t.Tanggal:dd/MM/yyyy HH:mm}  •  {t.Kasir}";
            foreach (var d in t.Detail)
                dgvDetail.Rows.Add(d.NamaBarang, d.Qty, Rp(d.Subtotal));
            dgvDetail.ClearSelection();
            lblDetailTotal.Text = "Total: " + Rp(t.Total);
        }

        // ================= HELPER =================
        private string Rp(decimal nilai) => "Rp " + nilai.ToString("N0", _id);

        // Pintasan uji coba: Ctrl+Shift+D untuk membuat data contoh.
        // HAPUS blok ini setelah modul kasir selesai.
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.Shift | Keys.D))
            {
                if (MessageBox.Show("Buat 40 transaksi contoh dari data barang yang ada?",
                        "Data contoh", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int n = TransaksiStore.BuatDataContoh(40);
                    if (n == 0)
                        MessageBox.Show("Belum ada barang. Tambahkan barang dulu di Kelola Barang.",
                            "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        // handler yang dirujuk Designer (hapus jika sudah ada di file Anda)
        private void tlpRoot_Paint(object? sender, PaintEventArgs e) { }
    }
}