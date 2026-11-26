using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace GUedang
{
    public partial class UC_Dashboard : UserControl
    {
        private static readonly Color Biru = Color.FromArgb(30, 100, 220);
        private static readonly Color BiruTua = Color.FromArgb(13, 71, 161);
        private static readonly Color BiruMuda = Color.FromArgb(232, 242, 255);
        private static readonly Color BiruBaris = Color.FromArgb(246, 250, 255);
        private static readonly Color BiruGaris = Color.FromArgb(214, 228, 250);

        private static readonly CultureInfo ID = new CultureInfo("id-ID");

        private DataTable _dtPengguna;
        private DataTable _dtStokMenipis;
        private List<KeyValuePair<string, decimal>> _penjualan7Hari = new List<KeyValuePair<string, decimal>>();
        private Rectangle[] _barRects = new Rectangle[0];
        private int _barHover = -1;

        public event EventHandler TambahBarangClicked;
        public event EventHandler TransaksiBaruClicked;
        public event EventHandler LaporanClicked;
        public event EventHandler OpnameClicked;

        private string _namaAdmin = "Admin";
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string NamaAdmin
        {
            get { return _namaAdmin; }
            set { _namaAdmin = value; UpdateSalam(); }
        }

        public UC_Dashboard()
        {
            InitializeComponent();

            typeof(Panel).InvokeMember("DoubleBuffered",
                BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic,
                null, panelChart, new object[] { true });

            if (!DesignMode && LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                // dashboard ikut refresh saat stok atau transaksi berubah
                BarangStore.DataChanged += OnDataBerubah;
                TransaksiStore.DataChanged += OnDataBerubah;
                this.Disposed += (s, e) =>
                {
                    BarangStore.DataChanged -= OnDataBerubah;
                    TransaksiStore.DataChanged -= OnDataBerubah;
                };
            }
        }

        private void OnDataBerubah()
        {
            if (IsDisposed || !IsHandleCreated) return;
            BeginInvoke(new Action(MuatData));
        }

        private void UC_Dashboard_Load(object sender, EventArgs e)
        {
            if (DesignMode || LicenseManager.UsageMode == LicenseUsageMode.Designtime) return;

            StyleSemua();

            cmbJenis.Items.Clear();
            cmbJenis.Items.AddRange(new object[] { "Semua", Roles.Admin, Roles.Kasir, Roles.Gudang });
            cmbJenis.SelectedIndex = 0;

            MuatData();
            UpdateJam();
            timerJam.Start();
            timerRefresh.Start();
        }

        // ================= DATA =================
        public void MuatData()
        {
            var barang = BarangStore.GetAll();
            var transaksi = TransaksiStore.GetAll();
            var daftarUser = UserStore.Muat();

            _dtPengguna = AmbilPengguna(daftarUser);
            _dtStokMenipis = AmbilStokMenipis(barang);
            _penjualan7Hari = AmbilPenjualan7Hari(transaksi);

            dgvPengguna.DataSource = _dtPengguna.DefaultView;
            dgvStokMenipis.DataSource = _dtStokMenipis;
            FormatKolomGrid();
            FilterPengguna_Changed(null, EventArgs.Empty);

            // kartu atas
            lblKasirNilai.Text = daftarUser.Count(u => u.Role == Roles.Kasir).ToString();
            lblGudangNilai.Text = daftarUser.Count(u => u.Role == Roles.Gudang).ToString();
            lblMenipisNilai.Text = barang.Count(b => b.Stok > 0 && b.Stok <= b.StokMinimum).ToString();
            lblHabisNilai.Text = barang.Count(b => b.Stok <= 0).ToString();

            // penjualan hari ini
            decimal pendapatan;
            int jumlahTrx;
            AmbilPenjualanHariIni(transaksi, out pendapatan, out jumlahTrx);
            lblPendapatanNilai.Text = Rupiah(pendapatan);
            lblTransaksiNilai.Text = jumlahTrx.ToString("N0", ID);
            lblRataNilai.Text = Rupiah(jumlahTrx > 0 ? pendapatan / jumlahTrx : 0);

            // aktivitas gudang hari ini
            int masuk, keluar, stok;
            AmbilAktivitasGudang(barang, out masuk, out keluar, out stok);
            lblMasukNilai.Text = masuk.ToString("N0", ID);
            lblKeluarNilai.Text = keluar.ToString("N0", ID);
            lblStokNilai.Text = stok.ToString("N0", ID);

            UpdateSalam();
            panelChart.Invalidate();
        }

        private DataTable AmbilPengguna(List<UserAkun> daftarUser)
        {
            var dt = new DataTable();
            dt.Columns.Add("No", typeof(int));
            dt.Columns.Add("Nama", typeof(string));
            dt.Columns.Add("Jenis", typeof(string));
            dt.Columns.Add("Status", typeof(string));

            int no = 1;
            foreach (var u in daftarUser.OrderBy(x => x.Id))
            {
                dt.Rows.Add(no++, u.Nama, u.Role, u.Aktif ? "Aktif" : "Nonaktif");
            }
            return dt;
        }

        // "Perlu Diperiksa / Ditambah": barang yang stoknya <= stok minimum (termasuk yang habis)
        private DataTable AmbilStokMenipis(List<Barang> barang)
        {
            var dt = new DataTable();
            dt.Columns.Add("Kode", typeof(string));
            dt.Columns.Add("Nama Barang", typeof(string));
            dt.Columns.Add("Stok", typeof(int));
            dt.Columns.Add("Min", typeof(int));

            foreach (var b in barang.Where(x => x.Stok <= x.StokMinimum)
                                    .OrderBy(x => x.Stok).ThenBy(x => x.Kode))
            {
                dt.Rows.Add(b.Kode, b.Nama, b.Stok, b.StokMinimum);
            }
            return dt;
        }

        private List<KeyValuePair<string, decimal>> AmbilPenjualan7Hari(List<Transaksi> transaksi)
        {
            var list = new List<KeyValuePair<string, decimal>>();
            for (int i = 6; i >= 0; i--)
            {
                DateTime d = DateTime.Today.AddDays(-i);
                decimal totalHari = transaksi
                    .Where(t => t.Tanggal.Date == d.Date)
                    .Sum(t => t.Total);

                list.Add(new KeyValuePair<string, decimal>(d.ToString("ddd", ID), totalHari));
            }
            return list;
        }

        private void AmbilPenjualanHariIni(List<Transaksi> transaksi, out decimal pendapatan, out int jumlah)
        {
            var hariIni = transaksi.Where(t => t.Tanggal.Date == DateTime.Today).ToList();
            pendapatan = hariIni.Sum(t => t.Total);
            jumlah = hariIni.Count;
        }

        private void AmbilAktivitasGudang(List<Barang> barang, out int masuk, out int keluar, out int stok)
        {
            masuk = BarangMasukStore.GetAll()
                .Where(x => x.Tanggal.Date == DateTime.Today).Sum(x => x.Jumlah);
            keluar = BarangKeluarStore.GetAll()
                .Where(x => x.Tanggal.Date == DateTime.Today).Sum(x => x.Jumlah);
            stok = barang.Sum(b => b.Stok);
        }

        // ================= FILTER PENGGUNA =================
        private void FilterPengguna_Changed(object sender, EventArgs e)
        {
            if (_dtPengguna == null) return;

            var filter = new List<string>();
            string kata = txtCari.Text.Trim().Replace("'", "''");
            if (kata.Length > 0)
                filter.Add("(Nama LIKE '%" + kata + "%' OR Status LIKE '%" + kata + "%')");

            string jenis = cmbJenis.SelectedItem as string;
            if (!string.IsNullOrEmpty(jenis) && jenis != "Semua")
                filter.Add("Jenis = '" + jenis.Replace("'", "''") + "'");

            _dtPengguna.DefaultView.RowFilter = string.Join(" AND ", filter);
        }

        // ================= JAM & SALAM =================
        private void timerJam_Tick(object sender, EventArgs e) { UpdateJam(); }

        private void UpdateJam()
        {
            DateTime now = DateTime.Now;
            lblJam.Text = now.ToString("HH:mm:ss");
            lblTanggal.Text = now.ToString("dddd, dd MMMM yyyy", ID);
        }

        private void UpdateSalam()
        {
            int jam = DateTime.Now.Hour;
            string sapaan = jam < 11 ? "Selamat Pagi" : jam < 15 ? "Selamat Siang" : jam < 18 ? "Selamat Sore" : "Selamat Malam";
            string namaAktif = Session.UserAktif != null && !string.IsNullOrWhiteSpace(Session.UserAktif.Nama)
                ? Session.UserAktif.Nama
                : _namaAdmin;
            lblSalam.Text = sapaan + ", " + namaAktif;
        }

        private void timerRefresh_Tick(object sender, EventArgs e) { MuatData(); }
        private void btnRefresh_Click(object sender, EventArgs e) { MuatData(); }

        private void btnTambahBarang_Click(object sender, EventArgs e) { TambahBarangClicked?.Invoke(this, e); }
        private void btnTransaksi_Click(object sender, EventArgs e) { TransaksiBaruClicked?.Invoke(this, e); }
        private void btnLaporan_Click(object sender, EventArgs e) { LaporanClicked?.Invoke(this, e); }
        private void btnOpname_Click(object sender, EventArgs e) { OpnameClicked?.Invoke(this, e); }

        private void btnExport_Click(object sender, EventArgs e)
        {
            using (var sfd = new SaveFileDialog())
            {
                sfd.Filter = "CSV (*.csv)|*.csv";
                sfd.FileName = "stok_menipis_" + DateTime.Now.ToString("yyyyMMdd") + ".csv";
                if (sfd.ShowDialog() != DialogResult.OK) return;

                var sb = new StringBuilder();
                sb.AppendLine(string.Join(";", _dtStokMenipis.Columns.Cast<DataColumn>().Select(c => c.ColumnName)));
                foreach (DataRow r in _dtStokMenipis.Rows)
                    sb.AppendLine(string.Join(";", r.ItemArray.Select(v => "\"" + v + "\"")));

                File.WriteAllText(sfd.FileName, sb.ToString(), Encoding.UTF8);
                MessageBox.Show("Data stok berhasil diexport.", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // ================= GRAFIK =================
        private void panelChart_Resize(object sender, EventArgs e) { panelChart.Invalidate(); }

        private void panelChart_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.Clear(Color.White);

            if (_penjualan7Hari == null || _penjualan7Hari.Count == 0) return;

            int kiri = 56, kanan = 16, atas = 8, bawah = 26;
            var plot = new Rectangle(kiri, atas, panelChart.Width - kiri - kanan, panelChart.Height - atas - bawah);
            if (plot.Width <= 20 || plot.Height <= 20) return;

            decimal max = _penjualan7Hari.Max(x => x.Value);
            if (max <= 0) max = 100000m;
            max = BulatkanAtas(max);

            using (var fontKecil = new Font("Segoe UI", 8F))
            using (var sikatTeks = new SolidBrush(Color.FromArgb(100, 120, 160)))
            using (var penGaris = new Pen(BiruGaris) { DashStyle = DashStyle.Dash })
            {
                for (int i = 0; i <= 4; i++)
                {
                    int y = plot.Bottom - (int)(plot.Height * i / 4.0);
                    g.DrawLine(penGaris, plot.Left, y, plot.Right, y);
                    string teks = Singkat(max * i / 4);
                    SizeF s = g.MeasureString(teks, fontKecil);
                    g.DrawString(teks, fontKecil, sikatTeks, plot.Left - s.Width - 4, y - s.Height / 2);
                }

                int n = _penjualan7Hari.Count;
                float slot = plot.Width / (float)n;
                float lebar = slot * 0.55f;
                _barRects = new Rectangle[n];

                for (int i = 0; i < n; i++)
                {
                    decimal nilai = _penjualan7Hari[i].Value;
                    int tinggi = (int)(plot.Height * (double)(nilai / max));
                    int x = (int)(plot.Left + slot * i + (slot - lebar) / 2);
                    var bar = new Rectangle(x, plot.Bottom - tinggi, (int)lebar, Math.Max(tinggi, 2));
                    _barRects[i] = bar;

                    bool hover = (i == _barHover);
                    bool hariIni = (i == n - 1);
                    Color c1 = hover ? BiruTua : (hariIni ? Biru : Color.FromArgb(120, 170, 240));
                    Color c2 = hover ? Biru : (hariIni ? BiruTua : Biru);

                    using (var br = new LinearGradientBrush(bar, c1, c2, LinearGradientMode.Vertical))
                    using (GraphicsPath pb = GfxUtil.RoundTop(bar, Math.Min(8, bar.Width / 2)))
                        g.FillPath(br, pb);

                    string hari = _penjualan7Hari[i].Key;
                    SizeF sh = g.MeasureString(hari, fontKecil);
                    g.DrawString(hari, fontKecil, sikatTeks, x + lebar / 2 - sh.Width / 2, plot.Bottom + 5);

                    if (hover)
                    {
                        string v = Rupiah(nilai);
                        SizeF sv = g.MeasureString(v, fontKecil);
                        float tx = Math.Max(plot.Left, Math.Min(x + lebar / 2 - sv.Width / 2, plot.Right - sv.Width));
                        float ty = Math.Max(0, bar.Top - sv.Height - 2);
                        using (var latar = new SolidBrush(BiruTua))
                            g.FillRectangle(latar, tx - 3, ty, sv.Width + 6, sv.Height);
                        g.DrawString(v, fontKecil, Brushes.White, tx, ty);
                    }
                }

                using (var penAxis = new Pen(BiruGaris))
                    g.DrawLine(penAxis, plot.Left, plot.Bottom, plot.Right, plot.Bottom);
            }
        }

        private void panelChart_MouseMove(object sender, MouseEventArgs e)
        {
            int idx = -1;
            for (int i = 0; i < _barRects.Length; i++)
                if (_barRects[i].Contains(e.Location)) { idx = i; break; }

            if (idx != _barHover)
            {
                _barHover = idx;
                panelChart.Cursor = idx >= 0 ? Cursors.Hand : Cursors.Default;
                panelChart.Invalidate();
            }
        }

        private void panelChart_MouseLeave(object sender, EventArgs e)
        {
            if (_barHover != -1) { _barHover = -1; panelChart.Invalidate(); }
        }

        // ================= STYLE =================
        private void StyleSemua()
        {
            StyleGrid(dgvPengguna);
            StyleGrid(dgvStokMenipis);

            StyleTombol(btnRefresh, Biru, Color.White, BiruTua);
            btnRefresh.CornerRadius = 19;

            toolTip1.SetToolTip(btnRefresh, "Muat ulang data dashboard");
            toolTip1.SetToolTip(txtCari, "Cari nama atau status pengguna");
        }

        private void StyleTombol(RoundedButton3 b, Color latar, Color teks, Color hover, bool garis = false)
        {
            b.BackColor = latar;
            b.ForeColor = teks;
            b.HoverColor = hover;
            b.BorderColor = Biru;
            b.BorderSize = garis ? 1 : 0;
            b.CornerRadius = 12;
        }

        private void StyleGrid(DataGridView g)
        {
            g.BackgroundColor = Color.White;
            g.BorderStyle = BorderStyle.None;
            g.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            g.GridColor = BiruGaris;
            g.EnableHeadersVisualStyles = false;
            g.RowHeadersVisible = false;
            g.AllowUserToAddRows = false;
            g.AllowUserToDeleteRows = false;
            g.AllowUserToResizeRows = false;
            g.ReadOnly = true;
            g.MultiSelect = false;
            g.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            g.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            g.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            g.ColumnHeadersHeight = 32;
            g.RowTemplate.Height = 28;

            g.ColumnHeadersDefaultCellStyle.BackColor = Biru;
            g.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            g.ColumnHeadersDefaultCellStyle.SelectionBackColor = Biru;
            g.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            g.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            g.DefaultCellStyle.BackColor = Color.White;
            g.DefaultCellStyle.ForeColor = Color.FromArgb(30, 50, 90);
            g.DefaultCellStyle.SelectionBackColor = BiruMuda;
            g.DefaultCellStyle.SelectionForeColor = BiruTua;
            g.DefaultCellStyle.Font = new Font("Segoe UI", 9.5F);
            g.DefaultCellStyle.Padding = new Padding(4, 0, 0, 0);
            g.AlternatingRowsDefaultCellStyle.BackColor = BiruBaris;
        }

        private void FormatKolomGrid()
        {
            if (dgvPengguna.Columns.Contains("No")) dgvPengguna.Columns["No"].FillWeight = 20;
            if (dgvPengguna.Columns.Contains("Nama")) dgvPengguna.Columns["Nama"].FillWeight = 60;

            if (dgvStokMenipis.Columns.Contains("Kode")) dgvStokMenipis.Columns["Kode"].FillWeight = 28;
            if (dgvStokMenipis.Columns.Contains("Nama Barang")) dgvStokMenipis.Columns["Nama Barang"].FillWeight = 50;
            if (dgvStokMenipis.Columns.Contains("Stok")) dgvStokMenipis.Columns["Stok"].FillWeight = 16;
            if (dgvStokMenipis.Columns.Contains("Min")) dgvStokMenipis.Columns["Min"].FillWeight = 16;

            dgvStokMenipis.CellFormatting -= dgvStokMenipis_CellFormatting;
            dgvStokMenipis.CellFormatting += dgvStokMenipis_CellFormatting;
            dgvPengguna.CellFormatting -= dgvPengguna_CellFormatting;
            dgvPengguna.CellFormatting += dgvPengguna_CellFormatting;
        }

        private void dgvStokMenipis_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = dgvStokMenipis.Rows[e.RowIndex];
            int stok;
            if (row.Cells["Stok"].Value != null && int.TryParse(row.Cells["Stok"].Value.ToString(), out stok) && stok == 0)
            {
                e.CellStyle.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
                e.CellStyle.ForeColor = BiruTua;
                e.CellStyle.BackColor = Color.FromArgb(220, 234, 255);
            }
        }

        private void dgvPengguna_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || dgvPengguna.Columns[e.ColumnIndex].Name != "Status") return;
            bool aktif = Convert.ToString(e.Value) == "Aktif";
            e.CellStyle.ForeColor = aktif ? Biru : Color.FromArgb(130, 150, 190);
            e.CellStyle.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
        }

        // ================= HELPER =================
        private static string Rupiah(decimal v) { return "Rp " + v.ToString("N0", ID); }

        private static string Singkat(decimal v)
        {
            if (v >= 1000000m) return (v / 1000000m).ToString("0.#", ID) + " jt";
            if (v >= 1000m) return (v / 1000m).ToString("0.#", ID) + " rb";
            return v.ToString("0", ID);
        }

        private static decimal BulatkanAtas(decimal v)
        {
            double pangkat = Math.Pow(10, Math.Floor(Math.Log10((double)v)));
            double hasil = Math.Ceiling((double)v / pangkat * 2) / 2 * pangkat;
            return (decimal)hasil;
        }

        // handler kosong yang dirujuk Designer (jangan dihapus)
        private void dgvStokMenipis_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void panel2_Paint(object sender, PaintEventArgs e) { }
        private void dgvPengguna_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void lblJam_Click(object sender, EventArgs e) { }
        private void tblKanan_Paint(object sender, PaintEventArgs e) { }
        private void tblKiri_Paint(object sender, PaintEventArgs e) { }
        private void panelBody_Paint(object sender, PaintEventArgs e) { }
    }
}