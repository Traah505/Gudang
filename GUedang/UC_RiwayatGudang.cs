using System.Globalization;

namespace GUedang
{
    public partial class UC_RiwayatGudang : UserControl
    {
        private bool _loading;
        private static readonly CultureInfo _id = new("id-ID");

        public UC_RiwayatGudang()
        {
            InitializeComponent();

           

            // lebar kolom (urutan sama dengan kolom di tabel, Petugas paling akhir)
            double[] bobot = { 5, 15, 11, 17, 8, 9, 13, 13, 10 };
            for (int i = 0; i < bobot.Length && i < dgvRiwayat.Columns.Count; i++)
                dgvRiwayat.Columns[i].FillWeight = (float)bobot[i];

            _loading = true;
            cmbRentang.SelectedIndex = 0;   // Hari ini
            cmbJenis.SelectedIndex = 0;     // Semua jenis
            _loading = false;

            cmbRentang.SelectedIndexChanged += cmbRentang_SelectedIndexChanged;
            dtpDari.ValueChanged += Tanggal_ValueChanged;
            dtpSampai.ValueChanged += Tanggal_ValueChanged;
            cmbJenis.SelectedIndexChanged += (s, e) => MuatData();
            txtCari.TextChanged += (s, e) => MuatData();
            dgvRiwayat.CellFormatting += dgvRiwayat_CellFormatting;
            dgvRiwayat.CellDoubleClick += dgvRiwayat_CellDoubleClick;
            VisibleChanged += (s, e) => { if (Visible) MuatData(); };
            HandleCreated += (s, e) => { BarangStore.DataChanged -= OnDataChanged; BarangStore.DataChanged += OnDataChanged; };
            HandleDestroyed += (s, e) => BarangStore.DataChanged -= OnDataChanged;

            TerapkanRentang();
        }

        // Dirujuk designer (hapus jika sudah ada di file lain)
        private void tlpRoot_Paint(object? sender, PaintEventArgs e) { }

        private void OnDataChanged()
        {
            if (IsHandleCreated && !IsDisposed) BeginInvoke(new Action(MuatData));
        }

        // ================= FILTER TANGGAL =================
        private void cmbRentang_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (_loading) return;
            TerapkanRentang();
        }

        private void TerapkanRentang()
        {
            _loading = true;
            var today = DateTime.Today;
            bool manual = cmbRentang.SelectedIndex == 5;

            switch (cmbRentang.SelectedIndex)
            {
                case 0: dtpDari.Value = today; dtpSampai.Value = today; break;
                case 1: dtpDari.Value = today.AddDays(-6); dtpSampai.Value = today; break;
                case 2: dtpDari.Value = today.AddDays(-29); dtpSampai.Value = today; break;
                case 3: dtpDari.Value = new DateTime(today.Year, today.Month, 1); dtpSampai.Value = today; break;
                case 4:
                    var semua = StoreRiwayatGudang.Semua();
                    dtpDari.Value = semua.Count > 0 ? semua.Min(x => x.Waktu).Date : today;
                    dtpSampai.Value = today;
                    break;
            }

            dtpDari.Enabled = manual;
            dtpSampai.Enabled = manual;
            _loading = false;
            MuatData();
        }

        private void Tanggal_ValueChanged(object? sender, EventArgs e)
        {
            if (_loading) return;
            if (dtpDari.Value.Date > dtpSampai.Value.Date)
            {
                _loading = true;
                dtpSampai.Value = dtpDari.Value;
                _loading = false;
            }
            MuatData();
        }

        // ================= LOAD DATA =================
        public void MuatData()
        {
            if (DesignMode || _loading) return;

            var semua = StoreRiwayatGudang.Semua();

            DateTime dari = dtpDari.Value.Date;
            DateTime sampai = dtpSampai.Value.Date.AddDays(1).AddTicks(-1);
            string jenis = cmbJenis.SelectedIndex > 0 ? cmbJenis.Text : "";
            string cari = txtCari.Text.Trim();

            var data = semua
                .Where(x => x.Waktu >= dari && x.Waktu <= sampai)
                .Where(x => jenis == "" || x.Jenis.Equals(jenis, StringComparison.OrdinalIgnoreCase))
                .Where(x => cari == ""
                    || x.NamaBarang.Contains(cari, StringComparison.OrdinalIgnoreCase)
                    || x.KodeBarang.Contains(cari, StringComparison.OrdinalIgnoreCase)
                    || x.Keterangan.Contains(cari, StringComparison.OrdinalIgnoreCase)
                    || x.Pihak.Contains(cari, StringComparison.OrdinalIgnoreCase))
                .OrderByDescending(x => x.Waktu)
                .ToList();

            dgvRiwayat.Rows.Clear();
            int no = 1;
            foreach (var x in data)
            {
                string jumlahTeks = x.JumlahBertanda > 0 ? "+" + x.JumlahBertanda : x.JumlahBertanda.ToString();

                int idx = dgvRiwayat.Rows.Add(
     no++,
     x.Waktu.ToString("dd/MM/yyyy HH:mm", _id),
     x.Jenis,
     x.NamaBarang,
     jumlahTeks,
     x.StokAkhir,
     string.IsNullOrWhiteSpace(x.Pihak) ? "-" : x.Pihak,
     string.IsNullOrWhiteSpace(x.Keterangan) ? "-" : x.Keterangan,
     string.IsNullOrWhiteSpace(x.Oleh) ? "-" : x.Oleh);      // <- kolom baru

                dgvRiwayat.Rows[idx].Cells["colPetugas"].Value =
     string.IsNullOrWhiteSpace(x.Oleh) ? "-" : x.Oleh;

                dgvRiwayat.Rows[idx].Tag = x.Id;   // untuk buka Kartu Stok
            }

            var periode = semua.Where(x => x.Waktu >= dari && x.Waktu <= sampai).ToList();
            lblMasukNilai.Text = periode.Where(x => x.Jenis == "Masuk").Sum(x => Math.Abs(x.Jumlah)).ToString("N0", _id);
            lblKeluarNilai.Text = periode.Where(x => x.Jenis == "Keluar").Sum(x => Math.Abs(x.Jumlah)).ToString("N0", _id);
            lblOpnameNilai.Text = periode.Count(x => x.Jenis == "Penyesuaian").ToString("N0", _id);
            lblStokNilai.Text = BarangStore.GetAll().Sum(b => b.Stok).ToString("N0", _id);
        }

        // ================= KLIK 2X => KARTU STOK =================
        private void dgvRiwayat_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string? idBaris = dgvRiwayat.Rows[e.RowIndex].Tag as string;
            var entri = StoreRiwayatGudang.Semua().FirstOrDefault(x => x.Id == idBaris);
            if (entri == null) return;

            using var f = new FormKartuStok(entri.KodeBarang, entri.NamaBarang, entri.Id);
            f.ShowDialog(FindForm());
        }

        // ================= WARNA KOLOM JENIS & JUMLAH =================
        private void dgvRiwayat_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.Value == null) return;
            string kolom = dgvRiwayat.Columns[e.ColumnIndex].Name;
            if (kolom != "colJenis" && kolom != "colJumlah") return;

            string jenis = dgvRiwayat.Rows[e.RowIndex].Cells["colJenis"].Value?.ToString() ?? "";
            Color warna = jenis switch
            {
                "Masuk" => Color.FromArgb(24, 94, 224),
                "Keluar" => Color.FromArgb(40, 140, 90),
                "Penyesuaian" => Color.FromArgb(200, 125, 10),
                _ => Color.RoyalBlue
            };

            e.CellStyle!.ForeColor = warna;
            e.CellStyle.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
        }
    }
}