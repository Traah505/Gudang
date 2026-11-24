using System.ComponentModel;
using System.Globalization;

namespace GUedang
{
    public partial class UC_RIWYTTRNKSIKasir : UserControl
    {
        private readonly CultureInfo _id = new("id-ID");
        private bool _loading;
        private List<Transaksi> _tampil = new();
        private System.Windows.Forms.Timer? _timer;
        private string? _kodeDipilihDariLuar;

        /// <summary>Isi dengan username kasir login. Jika FilterKasirIni = true, hanya transaksi kasir ini yang tampil.</summary>
        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string NamaKasir { get; set; } = "kasir";

        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool FilterKasirIni { get; set; } = false;

        public UC_RIWYTTRNKSIKasir()
        {
            InitializeComponent();

            Load += UC_Load;
            TransaksiStore.DataChanged += OnDataChanged;
            Disposed += (s, e) =>
            {
                TransaksiStore.DataChanged -= OnDataChanged;
                _timer?.Stop();
                _timer?.Dispose();
            };
        }

        private void OnDataChanged()
        {
            if (IsHandleCreated && !IsDisposed)
                BeginInvoke(new Action(() => { if (!IsPeriodeManual()) ApplyRentang(); Muat(); }));
        }

        private void UC_Load(object? sender, EventArgs e)
        {
            if (DesignMode || LicenseManager.UsageMode == LicenseUsageMode.Designtime) return;

            // grid
            foreach (var g in new[] { dgvRiwayat, dgvDetail })
            {
                g.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                g.ReadOnly = true;
                g.AllowUserToResizeRows = false;
            }
            foreach (var c in new[] { colNo, colItem, colTotal, colDQty, colDHarga, colDSubtotal })
                c.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            // jam
            JamTick();
            _timer = new System.Windows.Forms.Timer { Interval = 1000 };
            _timer.Tick += (s, ev) => JamTick();
            _timer.Start();

            // nilai awal filter
            _loading = true;
            cmbRentang.SelectedIndex = 0;   // Hari ini
            cmbMetode.SelectedIndex = 0;    // Semua metode
            ApplyRentang();
            _loading = false;

            // event
            cmbRentang.SelectedIndexChanged += (s, ev) => { ApplyRentang(); Muat(); };
            dtpDari.ValueChanged += (s, ev) => { if (!_loading && IsPeriodeManual()) Muat(); };
            dtpSampai.ValueChanged += (s, ev) => { if (!_loading && IsPeriodeManual()) Muat(); };
            cmbMetode.SelectedIndexChanged += (s, ev) => Muat();
            txtCari.TextChanged += (s, ev) => Muat();

            dgvRiwayat.SelectionChanged += dgvRiwayat_SelectionChanged;
            dgvRiwayat.CellDoubleClick += (s, ev) => { if (ev.RowIndex >= 0) CetakStruk(); };
            btnCetak.Click += (s, ev) => CetakStruk();

            Muat();
        }

        private void JamTick()
        {
            DateTime n = DateTime.Now;
            lblJam.Text = n.ToString("HH:mm:ss");
            lblTanggal.Text = n.ToString("dddd, dd MMMM yyyy", _id);
        }

        // ================= PERIODE =================
        private bool IsPeriodeManual() => cmbRentang.SelectedItem?.ToString() == "Pilih manual";

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
            }

            bool lama = _loading;
            _loading = true;
            dtpDari.Value = dari;
            dtpSampai.Value = sampai;
            _loading = lama;

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

            string cari = txtCari.Text.Trim();
            string metode = cmbMetode.SelectedItem?.ToString() ?? "Semua metode";
            string kodeLama = _kodeDipilihDariLuar
                              ?? (dgvRiwayat.SelectedRows.Count > 0 ? (dgvRiwayat.SelectedRows[0].Tag as Transaksi)?.Kode : null)
                              ?? "";
            _kodeDipilihDariLuar = null;

            _tampil = TransaksiStore.GetByPeriode(dtpDari.Value, dtpSampai.Value)
                .Where(t => (!FilterKasirIni || t.Kasir.Equals(NamaKasir, StringComparison.OrdinalIgnoreCase))
                         && (metode == "Semua metode" || t.Metode.Equals(metode, StringComparison.OrdinalIgnoreCase))
                         && (cari.Length == 0
                             || t.Kode.Contains(cari, StringComparison.OrdinalIgnoreCase)
                             || t.Kasir.Contains(cari, StringComparison.OrdinalIgnoreCase)))
                .OrderByDescending(t => t.Tanggal)
                .ToList();

            // kartu statistik
            decimal pendapatan = _tampil.Sum(t => t.Total);
            int jumlah = _tampil.Count;
            lblPendapatanNilai.Text = Rp(pendapatan);
            lblTrxNilai.Text = jumlah.ToString("N0", _id);
            lblItemNilai.Text = _tampil.Sum(t => t.TotalItem).ToString("N0", _id);
            lblRataNilai.Text = Rp(jumlah > 0 ? pendapatan / jumlah : 0);

            // tabel
            _loading = true;
            dgvRiwayat.Rows.Clear();
            int no = 1;
            int barisPilih = -1;
            foreach (var t in _tampil)
            {
                int i = dgvRiwayat.Rows.Add(no++, t.Kode, t.Tanggal.ToString("dd/MM/yyyy HH:mm"),
                    t.Kasir, t.TotalItem, t.Metode, Rp(t.Total));
                dgvRiwayat.Rows[i].Tag = t;
                if (t.Kode == kodeLama) barisPilih = i;
            }
            dgvRiwayat.ClearSelection();
            if (barisPilih < 0 && dgvRiwayat.Rows.Count > 0) barisPilih = 0;
            if (barisPilih >= 0)
            {
                dgvRiwayat.Rows[barisPilih].Selected = true;
                dgvRiwayat.FirstDisplayedScrollingRowIndex = barisPilih;
            }
            _loading = false;

            TampilDetail(barisPilih >= 0 ? _tampil[barisPilih] : null);
        }

        private void dgvRiwayat_SelectionChanged(object? sender, EventArgs e)
        {
            if (_loading || dgvRiwayat.SelectedRows.Count == 0) return;
            TampilDetail(dgvRiwayat.SelectedRows[0].Tag as Transaksi);
        }

        private void TampilDetail(Transaksi? t)
        {
            dgvDetail.Rows.Clear();

            if (t == null)
            {
                lblDetailNo.Text = "Pilih transaksi untuk melihat detail";
                lblSumSubtotalNilai.Text = lblSumDiskonNilai.Text = lblSumTotalNilai.Text =
                    lblSumBayarNilai.Text = lblSumKembaliNilai.Text = "Rp 0";
                btnCetak.Enabled = false;
                return;
            }

            lblDetailNo.Text = $"{t.Kode}  •  {t.Tanggal:dd/MM/yyyy HH:mm}  •  {t.Kasir}";
            foreach (var d in t.Detail)
                dgvDetail.Rows.Add(d.NamaBarang, d.Qty, d.Harga.ToString("N0", _id), d.Subtotal.ToString("N0", _id));
            dgvDetail.ClearSelection();

            lblSumSubtotalNilai.Text = Rp(t.Subtotal);
            lblSumDiskonNilai.Text = Rp(t.Diskon);
            lblSumTotalNilai.Text = Rp(t.Total);
            lblSumBayarNilai.Text = Rp(t.Bayar);
            lblSumKembaliNilai.Text = Rp(t.Kembali);
            btnCetak.Enabled = true;
        }

        // ================= STRUK =================
        private void CetakStruk()
        {
            if (dgvRiwayat.SelectedRows.Count == 0 || dgvRiwayat.SelectedRows[0].Tag is not Transaksi t)
            {
                MessageBox.Show("Pilih transaksi dulu.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            StrukHelper.Tampilkan(FindForm(), t);
        }

        /// <summary>Dipanggil setelah belanja selesai agar transaksi barunya langsung terpilih.</summary>
        public void PilihTransaksi(string kode)
        {
            _kodeDipilihDariLuar = kode;
            if (cmbRentang.SelectedIndex != 0) cmbRentang.SelectedIndex = 0;   // Hari ini
            else { ApplyRentang(); Muat(); }
        }

        // ================= HELPER =================
        private string Rp(decimal n) => "Rp " + n.ToString("N0", _id);

        // handler yang dirujuk Designer
        private void tlpContent_Paint(object? sender, PaintEventArgs e) { }
    }
}