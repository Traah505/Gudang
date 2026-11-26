using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace GUedang
{
    public partial class UC_DSHBRDGudang : UserControl
    {
        private static readonly CultureInfo Id = new CultureInfo("id-ID");

        private static readonly Color Hijau = Color.FromArgb(30, 140, 80);
        private static readonly Color Merah = Color.FromArgb(210, 50, 50);
        private static readonly Color Oranye = Color.FromArgb(220, 130, 10);

        /// <summary>Cadangan jika Session belum terisi.</summary>
        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string NamaPetugas { get; set; } = "Gudang";

        // Event supaya form utama yang mengatur perpindahan halaman.
        public event EventHandler BarangMasukClicked;
        public event EventHandler BarangKeluarClicked;
        public event EventHandler StokBarangClicked;

        // nama petugas yang sedang login (untuk sapaan)
        private string PetugasAktif
        {
            get
            {
                if (Session.UserAktif != null && !string.IsNullOrWhiteSpace(Session.UserAktif.Nama))
                    return Session.UserAktif.Nama;
                return NamaPetugas;
            }
        }

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

            if (!IsDesigner)
            {
                // refresh otomatis saat stok berubah
                BarangStore.DataChanged += OnDataBerubah;
                Disposed += (s, e) => BarangStore.DataChanged -= OnDataBerubah;

                // refresh setiap halaman ini ditampilkan lagi
                VisibleChanged += (s, e) => { if (Visible) LoadData(); };
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
            lblSapaan.Text = "Selamat " + Sapaan(now.Hour) + ", " + PetugasAktif;
        }

        private static string Sapaan(int jam)
        {
            if (jam < 11) return "Pagi";
            if (jam < 15) return "Siang";
            if (jam < 18) return "Sore";
            return "Malam";
        }

        /// <summary>Muat ulang semua data dashboard.</summary>
        public void LoadData()
        {
            if (IsDesigner) return;

            var barang = BarangStore.GetAll();
            var masukSemua = BarangMasukStore.GetAll();
            var keluarSemua = BarangKeluarStore.GetAll();

            // ringkasan hari ini
            int masuk = masukSemua.Where(x => x.Tanggal.Date == DateTime.Today).Sum(x => x.Jumlah);
            int keluar = keluarSemua.Where(x => x.Tanggal.Date == DateTime.Today).Sum(x => x.Jumlah);
            int stok = barang.Sum(b => b.Stok);

            // barang yang perlu perhatian: stok <= stok minimum (termasuk habis)
            var perhatian = barang.Where(b => b.Stok <= b.StokMinimum)
                                  .OrderBy(b => b.Stok).ThenBy(b => b.Kode)
                                  .ToList();

            lblMasukNilai.Text = masuk.ToString("N0", Id);
            lblKeluarNilai.Text = keluar.ToString("N0", Id);
            lblStokNilai.Text = stok.ToString("N0", Id);
            lblPerhatianNilai.Text = perhatian.Count.ToString("N0", Id);

            IsiAktivitas(barang, masukSemua, keluarSemua);

            // Stok perlu perhatian
            dgvPerhatian.Rows.Clear();
            foreach (var b in perhatian)
                dgvPerhatian.Rows.Add(b.Kode, b.Nama, b.Stok, b.StokMinimum);
            dgvPerhatian.ClearSelection();
        }

        // 10 aktivitas terbaru (masuk + keluar). Stok akhir dihitung mundur dari stok sekarang.
        private void IsiAktivitas(List<Barang> barang, List<BarangMasuk> masukSemua, List<BarangKeluar> keluarSemua)
        {
            var kejadian = new List<(DateTime waktu, string kode, string nama, string jenis, int delta)>();
            foreach (var m in masukSemua)
                kejadian.Add((m.Tanggal, m.Kode, m.Nama, "Masuk", m.Jumlah));
            foreach (var k in keluarSemua)
                kejadian.Add((k.Tanggal, k.Kode, k.Nama, "Keluar", -k.Jumlah));

            kejadian = kejadian.OrderByDescending(x => x.waktu).ToList();

            // sisa stok per barang saat ini, dikurangi mundur tiap kejadian
            var berjalan = barang.ToDictionary(b => b.Kode, b => b.Stok, StringComparer.OrdinalIgnoreCase);

            dgvAktivitas.Rows.Clear();
            int tampil = 0;
            foreach (var x in kejadian)
            {
                int stokAkhir = berjalan.ContainsKey(x.kode) ? berjalan[x.kode] : 0;

                if (tampil < 10)
                {
                    string teksJumlah = (x.delta > 0 ? "+" : "") + x.delta.ToString("N0", Id);
                    dgvAktivitas.Rows.Add(
                        x.waktu.ToString("dd/MM HH:mm", CultureInfo.InvariantCulture),
                        x.jenis, x.nama, teksJumlah, stokAkhir);
                    tampil++;
                }

                // mundurkan stok untuk kejadian sebelumnya
                if (berjalan.ContainsKey(x.kode))
                    berjalan[x.kode] = stokAkhir - x.delta;
            }
            dgvAktivitas.ClearSelection();
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

        // handler yang dirujuk Designer
        private void tlpRoot_Paint(object sender, PaintEventArgs e)
        {
            // Garis pemisah header
            using (var p = new Pen(Color.FromArgb(214, 228, 245)))
                e.Graphics.DrawLine(p, 0, pnlHeader.Bottom - 1, tlpRoot.Width, pnlHeader.Bottom - 1);
        }
    }
}