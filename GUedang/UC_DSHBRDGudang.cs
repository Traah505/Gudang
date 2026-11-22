using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace GUedang
{
    public partial class UC_DSHBRDGudang : UserControl
    {
        private static readonly CultureInfo Id = new CultureInfo("id-ID");

        private static readonly Color Hijau = Color.FromArgb(30, 140, 80);
        private static readonly Color Merah = Color.FromArgb(210, 50, 50);
        private static readonly Color Oranye = Color.FromArgb(220, 130, 10);

        /// <summary>Isi dari form login, mis. dashboard.NamaPetugas = "Gudang";</summary>
        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string NamaPetugas { get; set; } = "Gudang";

        // Event supaya form utama yang mengatur perpindahan halaman.
        public event EventHandler BarangMasukClicked;
        public event EventHandler BarangKeluarClicked;
        public event EventHandler StokBarangClicked;

        public UC_DSHBRDGudang()
        {
            InitializeComponent();

            UiStyle.ApplyGrid(dgvAktivitas);
            UiStyle.ApplyGrid(dgvPerhatian);
            colJumlah.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            colStokAkhir.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            colStok.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            colMin.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgvAktivitas.CellFormatting += dgvAktivitas_CellFormatting;
            dgvPerhatian.CellFormatting += dgvPerhatian_CellFormatting;

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
            lblSapaan.Text = "Selamat " + Sapaan(now.Hour) + ", " + NamaPetugas;
        }

        private static string Sapaan(int jam)
        {
            if (jam < 11) return "Pagi";
            if (jam < 15) return "Siang";
            if (jam < 18) return "Sore";
            return "Malam";
        }

        /// <summary>Muat ulang semua data dashboard. Dipanggil saat load dan tombol Refresh.</summary>
        public void LoadData()
        {
            if (IsDesigner) return;

            int masuk, keluar, stok;
            GetRingkasanHariIni(out masuk, out keluar, out stok);

            DataTable perhatian = GetStokPerhatian();

            lblMasukNilai.Text = masuk.ToString("N0", Id);
            lblKeluarNilai.Text = keluar.ToString("N0", Id);
            lblStokNilai.Text = stok.ToString("N0", Id);
            lblPerhatianNilai.Text = perhatian.Rows.Count.ToString(Id);

            // Aktivitas terakhir
            dgvAktivitas.Rows.Clear();
            foreach (DataRow r in GetAktivitasTerakhir().Rows)
            {
                string jenis = r["jenis"].ToString();
                int jumlah = Convert.ToInt32(r["jumlah"]);
                string teksJumlah = (jumlah > 0 ? "+" : "") + jumlah.ToString(Id);

                dgvAktivitas.Rows.Add(
                    ((DateTime)r["waktu"]).ToString("dd/MM HH:mm", Id),
                    jenis,
                    r["nama_barang"],
                    teksJumlah,
                    r["stok_akhir"]);
            }

            // Stok perlu perhatian
            dgvPerhatian.Rows.Clear();
            foreach (DataRow r in perhatian.Rows)
                dgvPerhatian.Rows.Add(r["kode"], r["nama_barang"], r["stok"], r["stok_min"]);
        }

        // Warna kolom Jenis & Jumlah: hijau = masuk, merah = keluar
        private void dgvAktivitas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.Value == null) return;

            if (e.ColumnIndex == colJenis.Index || e.ColumnIndex == colJumlah.Index)
            {
                string jenis = dgvAktivitas.Rows[e.RowIndex].Cells[colJenis.Index].Value as string;
                e.CellStyle.ForeColor = (jenis == "Masuk") ? Hijau : Merah;
            }
        }

        // Stok 0 = merah, stok menipis = oranye
        private void dgvPerhatian_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != colStok.Index || e.Value == null) return;

            int stok;
            if (int.TryParse(e.Value.ToString(), out stok))
                e.CellStyle.ForeColor = (stok == 0) ? Merah : Oranye;
        }

        // ------------------------------------------------------------- DATA
        // TODO: ganti isi 3 method di bawah dengan query database kamu.
        // Sementara berisi data contoh supaya tampilan langsung bisa dicoba.

        private void GetRingkasanHariIni(out int masuk, out int keluar, out int stok)
        {
            // Contoh SQL:
            // SELECT IFNULL(SUM(jumlah),0) FROM barang_masuk  WHERE DATE(tanggal) = CURDATE();
            // SELECT IFNULL(SUM(jumlah),0) FROM barang_keluar WHERE DATE(tanggal) = CURDATE();
            // SELECT IFNULL(SUM(stok),0)   FROM barang;
            masuk = 0;
            keluar = 0;
            stok = 358;
        }

        private DataTable GetAktivitasTerakhir()
        {
            // Contoh SQL (gabungan masuk + keluar, urut waktu terbaru, LIMIT 10):
            // SELECT m.tanggal AS waktu, 'Masuk' AS jenis, b.nama_barang, m.jumlah, b.stok AS stok_akhir
            //   FROM barang_masuk m JOIN barang b ON b.id = m.id_barang
            // UNION ALL
            // SELECT k.tanggal, 'Keluar', b.nama_barang, -k.jumlah, b.stok
            //   FROM barang_keluar k JOIN barang b ON b.id = k.id_barang
            // ORDER BY waktu DESC LIMIT 10;
            var dt = new DataTable();
            dt.Columns.Add("waktu", typeof(DateTime));
            dt.Columns.Add("jenis", typeof(string));
            dt.Columns.Add("nama_barang", typeof(string));
            dt.Columns.Add("jumlah", typeof(int));
            dt.Columns.Add("stok_akhir", typeof(int));

            dt.Rows.Add(new DateTime(2026, 11, 18, 11, 16, 0), "Keluar", "KFC", -2, 38);
            dt.Rows.Add(new DateTime(2026, 11, 14, 18, 57, 0), "Masuk", "KFC", 20, 40);
            return dt;
        }

        private DataTable GetStokPerhatian()
        {
            // Contoh SQL:
            // SELECT kode, nama_barang, stok, stok_min FROM barang
            //  WHERE stok <= stok_min ORDER BY stok ASC;
            var dt = new DataTable();
            dt.Columns.Add("kode", typeof(string));
            dt.Columns.Add("nama_barang", typeof(string));
            dt.Columns.Add("stok", typeof(int));
            dt.Columns.Add("stok_min", typeof(int));

            dt.Rows.Add("BRG-014", "Minyak Goreng 2L", 0, 12);
            dt.Rows.Add("BRG-001", "Beras 5 Kg", 4, 10);
            return dt;
        }
        private void tlpRoot_Paint(object sender, PaintEventArgs e)
        {
            // Garis pemisah header
            using (var p = new Pen(Color.FromArgb(214, 228, 245)))
                e.Graphics.DrawLine(p, 0, pnlHeader.Bottom - 1, tlpRoot.Width, pnlHeader.Bottom - 1);
        }
    }
}