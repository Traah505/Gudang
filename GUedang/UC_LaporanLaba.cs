using System.Globalization;
using System.Linq;

namespace GUedang
{
    public partial class UC_LaporanLaba : UserControl
    {
        private static readonly CultureInfo Id = new("id-ID");
        private bool _loading;

        public UC_LaporanLaba()
        {
            InitializeComponent();

            // chartLaba dideklarasikan di Designer tapi belum dibuat -> dibuat di sini.
            chartLaba = new MiniBarChartUI { Dock = DockStyle.Fill };
            pnlChart.Controls.Add(chartLaba);
            chartLaba.BringToFront(); // supaya Fill tidak menutupi judul & label

            btnTampilkan.Click += (s, e) => Muat();
            cmbRentang.SelectedIndexChanged += cmbRentang_SelectedIndexChanged;
            cmbKelompok.SelectedIndexChanged += (s, e) => Muat();

            // Otomatis refresh kalau kasir menyimpan transaksi baru
            TransaksiStore.DataChanged += OnDataChanged;
            HandleDestroyed += (s, e) => TransaksiStore.DataChanged -= OnDataChanged;

            // Align angka ke kanan
            foreach (var c in new[] { colTransaksi, colPenjualan, colModal, colLaba, colMargin })
                c.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            _loading = true;
            cmbRentang.SelectedIndex = 3;   // Bulan ini
            cmbKelompok.SelectedIndex = 0;  // Per Tanggal
            _loading = false;
            AturRentang();

            // UJI COBA saja (hapus setelah kasir jadi):
            // if (TransaksiStore.GetAll().Count == 0) TransaksiStore.BuatDataContoh(40);

            Muat();
        }

        // Dibutuhkan karena Designer mendaftarkan: tlpRoot.Paint += tlpRoot_Paint;
        private void tlpRoot_Paint(object? sender, PaintEventArgs e) { }

        private void OnDataChanged()
        {
            if (IsDisposed || !IsHandleCreated) return;
            BeginInvoke(new Action(Muat));
        }

        private void cmbRentang_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (_loading) return;
            AturRentang();
            if (cmbRentang.SelectedItem?.ToString() != "Pilih manual") Muat();
        }

        private void AturRentang()
        {
            string pilih = cmbRentang.SelectedItem?.ToString() ?? "";
            DateTime hari = DateTime.Today;
            _loading = true;
            switch (pilih)
            {
                case "Hari ini": dtpDari.Value = hari; dtpSampai.Value = hari; break;
                case "7 hari terakhir": dtpDari.Value = hari.AddDays(-6); dtpSampai.Value = hari; break;
                case "30 hari terakhir": dtpDari.Value = hari.AddDays(-29); dtpSampai.Value = hari; break;
                case "Bulan ini": dtpDari.Value = new DateTime(hari.Year, hari.Month, 1); dtpSampai.Value = hari; break;
                case "Semua": dtpDari.Value = LabaStore.TanggalPertama(); dtpSampai.Value = hari; break;
            }
            _loading = false;
            bool manual = pilih == "Pilih manual";
            dtpDari.Enabled = manual;
            dtpSampai.Enabled = manual;
        }

        private static string Rp(decimal v) =>
            (v < 0 ? "-Rp " : "Rp ") + Math.Abs(v).ToString("N0", Id);

        public void Muat()
        {
            if (_loading) return;

            if (dtpDari.Value.Date > dtpSampai.Value.Date)
            {
                MessageBox.Show("Tanggal 'Dari' tidak boleh lebih besar dari 'Sampai'.",
                    "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool perBarang = cmbKelompok.SelectedIndex == 1;
            var hasil = LabaStore.Hitung(dtpDari.Value, dtpSampai.Value, perBarang);

            // Kartu ringkasan
            lblJualNilai.Text = Rp(hasil.TotalPenjualan);
            lblModalNilai.Text = Rp(hasil.TotalModal);
            lblLabaNilai.Text = Rp(hasil.TotalLaba);
            lblPersenNilai.Text = hasil.Persen.ToString("0.0", Id) + "%";

            // Tabel
            colKelompok.HeaderText = perBarang ? "Barang" : "Tanggal";
            dgvLaba.Rows.Clear();
            int no = 1;
            foreach (var b in hasil.Baris)
            {
                dgvLaba.Rows.Add(no++, b.Kelompok, b.Transaksi,
                    Rp(b.Penjualan), Rp(b.Modal), Rp(b.Laba),
                    b.Margin.ToString("0.0", Id) + "%");
            }

            // Grafik (maks 10 batang)
            var dataGrafik = perBarang
                ? hasil.Baris.Take(10)
                : hasil.Baris.TakeLast(10);
            chartLaba.SetData(
     dataGrafik.Select(b => b.Kelompok).ToList(),
     dataGrafik.Select(b => b.Laba).ToList()
 );
            lblChartJudul.Text = perBarang ? "Grafik Laba per Barang" : "Grafik Laba per Tanggal";

            // Info terbaik
            if (hasil.Baris.Count == 0)
                lblTerbaik.Text = "-";
            else
            {
                var best = hasil.Baris.OrderByDescending(b => b.Laba).First();
                lblTerbaik.Text = $"Laba tertinggi: {best.Kelompok} ({Rp(best.Laba)})";
            }
        }
    }
}