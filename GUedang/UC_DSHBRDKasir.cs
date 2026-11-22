using System;
using System.ComponentModel;
using System.Data;
using System.Globalization;
using System.Windows.Forms;

namespace GUedang
{
    public partial class UC_DSHBRDKasir : UserControl
    {
        private static readonly CultureInfo Id = new CultureInfo("id-ID");

        /// <summary>Isi dari form login, mis. dashboard.NamaKasir = "Ditra2";</summary>
        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string NamaKasir { get; set; } = "Kasir";

        // Event supaya form utama yang mengatur perpindahan halaman.
        public event EventHandler TransaksiBaruClicked;
        public event EventHandler KeranjangClicked;
        public event EventHandler RiwayatClicked;

        public UC_DSHBRDKasir()
        {
            InitializeComponent();

            UiStyle.ApplyGrid(dgvTransaksi);
            colTotal.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            btnRefresh.Click += (s, e) => LoadData();
           
            timerJam.Tick += (s, e) => UpdateJam();
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
            lblJam.Text = now.ToString("HH:mm:ss");
            lblTanggal.Text = now.ToString("dddd, dd MMMM yyyy", Id);
            lblSapaan.Text = "Selamat " + Sapaan(now.Hour) + ", " + NamaKasir;
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

        /// <summary>Muat ulang semua data dashboard. Dipanggil saat load dan tombol Refresh.</summary>
        public void LoadData()
        {
            if (IsDesigner) return;

            decimal pendapatan; int jumlahTransaksi; int itemTerjual;
            GetRingkasanHariIni(out pendapatan, out jumlahTransaksi, out itemTerjual);

            int itemKeranjang; decimal totalKeranjang;
            GetKeranjangAktif(out itemKeranjang, out totalKeranjang);

            decimal rata = jumlahTransaksi > 0 ? pendapatan / jumlahTransaksi : 0;

            // Kartu atas
            lblPendapatanNilai.Text = Rupiah(pendapatan);
            lblTransaksiNilai.Text = jumlahTransaksi.ToString(Id);
            lblTerjualNilai.Text = itemTerjual.ToString(Id);
            lblKeranjangKartuNilai.Text = itemKeranjang.ToString(Id);

            // Keranjang saat ini  (catatan: "Rp" hanya ditulis SEKALI, lewat Rupiah())
            lblItemNilai.Text = itemKeranjang.ToString(Id);
            lblTotalBelanjaNilai.Text = Rupiah(totalKeranjang);

            // Ringkasan
            lblRingkasanPendapatanNilai.Text = Rupiah(pendapatan);
            lblRingkasanTransaksiNilai.Text = jumlahTransaksi.ToString(Id);
            lblRingkasanRataNilai.Text = Rupiah(rata);

            // Tabel transaksi
            dgvTransaksi.Rows.Clear();
            foreach (DataRow r in GetTransaksiHariIni().Rows)
            {
                dgvTransaksi.Rows.Add(
                    r["no_transaksi"],
                    ((DateTime)r["waktu"]).ToString("HH:mm", Id),
                    r["kasir"],
                    Rupiah(Convert.ToDecimal(r["total"])));
            }
        }

        // ------------------------------------------------------------- DATA
        // TODO: ganti isi 3 method di bawah dengan query database kamu.
        // Sementara berisi data contoh supaya tampilan langsung bisa dicoba.

        private void GetRingkasanHariIni(out decimal pendapatan, out int jumlahTransaksi, out int itemTerjual)
        {
            // Contoh SQL:
            // SELECT IFNULL(SUM(total),0), COUNT(*)
            //   FROM transaksi
            //  WHERE DATE(waktu) = CURDATE() AND id_kasir = @idKasir;
            // SELECT IFNULL(SUM(d.qty),0)
            //   FROM detail_transaksi d JOIN transaksi t ON t.id = d.id_transaksi
            //  WHERE DATE(t.waktu) = CURDATE() AND t.id_kasir = @idKasir;
            pendapatan = 1320000;
            jumlahTransaksi = 18;
            itemTerjual = 64;
        }

        private void GetKeranjangAktif(out int item, out decimal total)
        {
            // Isi dari keranjang yang sedang dibuka kasir (belum dibayar).
            item = 3;
            total = 45500;
        }

        private DataTable GetTransaksiHariIni()
        {
            // Contoh SQL:
            // SELECT no_transaksi, waktu, nama_kasir AS kasir, total
            //   FROM transaksi
            //  WHERE DATE(waktu) = CURDATE() AND id_kasir = @idKasir
            //  ORDER BY waktu DESC;
            var dt = new DataTable();
            dt.Columns.Add("no_transaksi", typeof(string));
            dt.Columns.Add("waktu", typeof(DateTime));
            dt.Columns.Add("kasir", typeof(string));
            dt.Columns.Add("total", typeof(decimal));

            DateTime hariIni = DateTime.Today;
            dt.Rows.Add("TRX-0018", hariIni.AddHours(17).AddMinutes(42), NamaKasir, 73500m);
            dt.Rows.Add("TRX-0017", hariIni.AddHours(17).AddMinutes(10), NamaKasir, 112000m);
            dt.Rows.Add("TRX-0016", hariIni.AddHours(16).AddMinutes(25), NamaKasir, 48000m);
            dt.Rows.Add("TRX-0015", hariIni.AddHours(15).AddMinutes(51), NamaKasir, 25500m);
            return dt;
        }

        private void flowAksi_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}