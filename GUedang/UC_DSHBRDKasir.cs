using System;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace GUedang
{
    public partial class UC_DSHBRDKasir : UserControl
    {
        private static readonly CultureInfo Id = new CultureInfo("id-ID");

        /// <summary>Cadangan jika Session belum terisi.</summary>
        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string NamaKasir { get; set; } = "Kasir";

        // Event supaya form utama yang mengatur perpindahan halaman.
        public event EventHandler TransaksiBaruClicked;
        public event EventHandler KeranjangClicked;
        public event EventHandler RiwayatClicked;

        // nama kasir yang sedang login (dipakai untuk filter & sapaan)
        private string KasirAktif
        {
            get
            {
                if (Session.UserAktif != null && !string.IsNullOrWhiteSpace(Session.UserAktif.Nama))
                    return Session.UserAktif.Nama;
                return NamaKasir;
            }
        }

        public UC_DSHBRDKasir()
        {
            InitializeComponent();

            foreach (var l in new[] { lblItemNilai, lblTotalBelanjaNilai })
            {
                l.AutoSize = true;
                l.MaximumSize = Size.Empty;
            }

            UiStyle.ApplyGrid(dgvTransaksi);
            colTotal.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            // ganti tulisan yang lama (tidak perlu buka Designer)
            GantiTeks("Item di Keranjang", "Transaksi Terakhir");
            GantiTeks("Belum dibayar", "Jam transaksi terakhir");
            GantiTeks("Keranjang Belanja Saat Ini", "Transaksi Terakhir Hari Ini");

            btnRefresh.Click += (s, e) => LoadData();
            timerJam.Tick += (s, e) => UpdateJam();

            // otomatis refresh saat ada transaksi baru
            if (!IsDesigner)
            {
                TransaksiStore.DataChanged += OnDataBerubah;
                Disposed += (s, e) => TransaksiStore.DataChanged -= OnDataBerubah;
            }
        }

        private void OnDataBerubah()
        {
            if (IsHandleCreated && !IsDisposed)
                BeginInvoke(new Action(LoadData));
        }

        private bool IsDesigner
        {
            get { return LicenseManager.UsageMode == LicenseUsageMode.Designtime || DesignMode; }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (IsDesigner) return;

            UpdateJam();
            timerJam.Start();
            LoadData();
        }

        // ---------------------------------------------------------------- UI

        private void UpdateJam()
        {
            DateTime now = DateTime.Now;
            lblJam.Text = now.ToString("HH:mm:ss", CultureInfo.InvariantCulture);
            lblTanggal.Text = now.ToString("dddd, dd MMMM yyyy", Id);
            lblSapaan.Text = "Selamat " + Sapaan(now.Hour) + ", " + KasirAktif;
        }

        private static string Sapaan(int jam)
        {
            if (jam < 11) return "Pagi";
            if (jam < 15) return "Siang";
            if (jam < 18) return "Sore";
            return "Malam";
        }

        private static string Rupiah(decimal nilai)
        {
            return string.Format(Id, "Rp {0:N0}", nilai);
        }

        /// <summary>Muat ulang semua data dashboard. Dipanggil saat load, tombol Refresh, dan setelah transaksi.</summary>
        public void LoadData()
        {
            if (IsDesigner) return;

            // transaksi hari ini milik kasir yang login, terbaru di atas
            var hariIni = TransaksiStore.GetByPeriode(DateTime.Today, DateTime.Today)
                .Where(t => t.Kasir.Equals(KasirAktif, StringComparison.OrdinalIgnoreCase))
                .OrderByDescending(t => t.Tanggal)
                .ToList();

            decimal pendapatan = hariIni.Sum(t => t.Total);
            int jumlahTransaksi = hariIni.Count;
            int itemTerjual = hariIni.Sum(t => t.TotalItem);
            decimal rata = jumlahTransaksi > 0 ? pendapatan / jumlahTransaksi : 0;

            var terakhir = hariIni.FirstOrDefault();

            // Kartu atas
            lblPendapatanNilai.Text = Rupiah(pendapatan);
            lblTransaksiNilai.Text = jumlahTransaksi.ToString("N0", Id);
            lblTerjualNilai.Text = itemTerjual.ToString("N0", Id);
            lblKeranjangKartuNilai.Text = terakhir != null
                ? terakhir.Tanggal.ToString("HH:mm", CultureInfo.InvariantCulture)
                : "-";

            // Panel "Transaksi Terakhir Hari Ini"
            lblItemNilai.Text = terakhir != null ? terakhir.TotalItem.ToString("N0", Id) : "0";
            lblTotalBelanjaNilai.Text = Rupiah(terakhir != null ? terakhir.Total : 0);

            // Ringkasan penjualan hari ini
            lblRingkasanPendapatanNilai.Text = Rupiah(pendapatan);
            lblRingkasanTransaksiNilai.Text = jumlahTransaksi.ToString("N0", Id);
            lblRingkasanRataNilai.Text = Rupiah(rata);

            // Tabel transaksi hari ini
            dgvTransaksi.Rows.Clear();
            foreach (var t in hariIni)
            {
                dgvTransaksi.Rows.Add(
                    t.Kode,
                    t.Tanggal.ToString("HH:mm", CultureInfo.InvariantCulture),
                    t.Kasir,
                    Rupiah(t.Total));
            }
            dgvTransaksi.ClearSelection();

            UpdateJam();
        }

        // ------------------------------------------------------------ HELPER

        /// <summary>Cari Label (di mana pun letaknya) yang tulisannya persis sama, lalu ganti.</summary>
        private void GantiTeks(string lama, string baru)
        {
            var lbl = CariLabel(this, lama);
            if (lbl != null) lbl.Text = baru;
        }

        private static Label CariLabel(Control induk, string teks)
        {
            foreach (Control c in induk.Controls)
            {
                var l = c as Label;
                if (l != null && l.Text == teks) return l;

                var hasil = CariLabel(c, teks);
                if (hasil != null) return hasil;
            }
            return null;
        }

        private void flowAksi_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}