using System.ComponentModel;
using System.Globalization;

namespace GUedang
{
    public partial class UC_Barang : UserControl
    {
        private readonly CultureInfo _id = new("id-ID");
        private string _filter = "Semua";  
        private Barang? _terpilih;          // barang yang sedang diedit (null = mode tambah)
        private bool _loading;

        public UC_Barang()
        {
            InitializeComponent();

            Load += UC_Barang_Load;
            BarangStore.DataChanged += OnDataChanged;
            Disposed += (s, e) => BarangStore.DataChanged -= OnDataChanged;
        }

        private void OnDataChanged()
        {
            if (IsHandleCreated && !IsDisposed)
                BeginInvoke(new Action(MuatData));
        }

        private void UC_Barang_Load(object? sender, EventArgs e)
        {
            if (DesignMode || LicenseManager.UsageMode == LicenseUsageMode.Designtime) return;

            // Kontrol sisa di designer yang tidak dipakai
            textBox1.Visible = false;

            // event
            txtCari.TextChanged += (s, ev) => MuatData();
            btnSemua.Click += (s, ev) => SetFilter("Semua");
            btnAman.Click += (s, ev) => SetFilter("Aman");
            btnMenipis.Click += (s, ev) => SetFilter("Menipis");
            btnHabis.Click += (s, ev) => SetFilter("Habis");

            dgvBarang.SelectionChanged += dgvBarang_SelectionChanged;
            dgvBarang.CellFormatting += dgvBarang_CellFormatting;
            dgvBarang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            btnSimpan.Click += btnSimpan_Click;
            btnReset.Click += (s, ev) => ResetForm();
            btnHapus.Click += btnHapus_Click;

            txtBeli.TextChanged += (s, ev) => HitungMargin();
            txtJual.TextChanged += (s, ev) => HitungMargin();
            txtBeli.Leave += (s, ev) => FormatRupiah(txtBeli);
            txtJual.Leave += (s, ev) => FormatRupiah(txtJual);
            txtBeli.KeyPress += HanyaAngka;
            txtJual.KeyPress += HanyaAngka;

            // rata kanan kolom angka
            foreach (var c in new[] { colBeli, colJual, colStok, colMin })
                c.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            ResetForm();
            MuatData();
        }

        // ================= DATA / TABEL =================
        private void MuatData()
        {
            var semua = BarangStore.GetAll();

            // kartu statistik
            lblTotalNilai.Text = semua.Count.ToString();
            lblAmanNilai.Text = semua.Count(b => b.Status == "Aman").ToString();
            lblMenipisNilai.Text = semua.Count(b => b.Status == "Menipis").ToString();
            lblHabisNilai.Text = semua.Count(b => b.Status == "Habis").ToString();
            lblNilaiPersediaan.Text = "Rp " + semua.Sum(b => b.NilaiPersediaan).ToString("N0", _id);

            // filter + pencarian
            string key = txtCari.Text.Trim();
            var tampil = semua.Where(b =>
                (_filter == "Semua" || b.Status == _filter) &&
                (key.Length == 0
                    || b.Nama.Contains(key, StringComparison.OrdinalIgnoreCase)
                    || b.Kode.Contains(key, StringComparison.OrdinalIgnoreCase)))
                .OrderBy(b => b.Kode).ToList();

            _loading = true;
            dgvBarang.Rows.Clear();
            foreach (var b in tampil)
            {
                int i = dgvBarang.Rows.Add(
                    b.Kode, b.Nama, b.Kategori,
                    b.HargaBeli.ToString("N0", _id),
                    b.HargaJual.ToString("N0", _id),
                    b.Stok, b.StokMinimum, b.Status);
                dgvBarang.Rows[i].Tag = b;

                if (_terpilih != null && b.Kode == _terpilih.Kode)
                    dgvBarang.Rows[i].Selected = true;
            }
            if (_terpilih == null) dgvBarang.ClearSelection();
            _loading = false;
        }

        private void SetFilter(string filter)
        {
            _filter = filter;
            MuatData();
        }

        private void dgvBarang_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != colStatus.Index || e.Value == null) return;

            e.CellStyle!.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            e.CellStyle.ForeColor = e.Value.ToString() switch
            {
                "Aman" => Color.FromArgb(40, 140, 90),
                "Menipis" => Color.FromArgb(200, 125, 10),
                "Habis" => Color.FromArgb(210, 50, 50),
                _ => e.CellStyle.ForeColor
            };
        }

        private void dgvBarang_SelectionChanged(object? sender, EventArgs e)
        {
            if (_loading || dgvBarang.SelectedRows.Count == 0) return;
            if (dgvBarang.SelectedRows[0].Tag is Barang b)
                IsiForm(b);
        }

        // ================= FORM =================
        private void IsiForm(Barang b)
        {
            _terpilih = b;
            lblFormJudul.Text = "Ubah Barang";
            btnSimpan.Text = "Perbarui";
            btnHapus.Enabled = true;

            txtKode.Text = b.Kode;
            txtNama.Text = b.Nama;
            txtKategori.Text = b.Kategori;
            txtSatuan.Text = b.Satuan;
            nudStok.Value = Math.Min(b.Stok, nudStok.Maximum);
            nudMin.Value = Math.Min(b.StokMinimum, nudMin.Maximum);
            txtBeli.Text = b.HargaBeli.ToString("N0", _id);
            txtJual.Text = b.HargaJual.ToString("N0", _id);
            HitungMargin();
        }

        private void ResetForm()
        {
            _terpilih = null;
            lblFormJudul.Text = "Tambah Barang";
            btnSimpan.Text = "Simpan";
            btnHapus.Enabled = false;

            txtKode.Text = BarangStore.BuatKode();
            txtNama.Clear();
            txtKategori.Clear();
            txtSatuan.Clear();
            nudStok.Value = 0;
            nudMin.Value = 0;
            txtBeli.Clear();
            txtJual.Clear();
            lblMargin.Text = "Margin: -";

            dgvBarang.ClearSelection();
            txtNama.Focus();
        }

        private void btnSimpan_Click(object? sender, EventArgs e)
        {
            string nama = txtNama.Text.Trim();
            string kategori = txtKategori.Text.Trim();
            string satuan = txtSatuan.Text.Trim();
            decimal beli = ParseRupiah(txtBeli.Text);
            decimal jual = ParseRupiah(txtJual.Text);

            if (nama.Length == 0) { Peringatan("Nama barang wajib diisi.", txtNama); return; }
            if (kategori.Length == 0) { Peringatan("Kategori wajib diisi.", txtKategori); return; }
            if (satuan.Length == 0) { Peringatan("Satuan wajib diisi (mis. pcs, dus, kg).", txtSatuan); return; }
            if (beli <= 0) { Peringatan("Harga beli harus lebih dari 0.", txtBeli); return; }
            if (jual <= 0) { Peringatan("Harga jual harus lebih dari 0.", txtJual); return; }

            if (jual < beli &&
                MessageBox.Show("Harga jual lebih rendah dari harga beli (rugi). Tetap simpan?",
                    "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            // cegah nama ganda (kode berbeda)
            bool kembar = BarangStore.GetAll().Any(b =>
                b.Nama.Equals(nama, StringComparison.OrdinalIgnoreCase) && b.Kode != txtKode.Text);
            if (kembar) { Peringatan("Barang dengan nama tersebut sudah ada.", txtNama); return; }

            var barang = new Barang
            {
                Kode = txtKode.Text,
                Nama = nama,
                Kategori = kategori,
                Satuan = satuan,
                HargaBeli = beli,
                HargaJual = jual,
                Stok = (int)nudStok.Value,
                StokMinimum = (int)nudMin.Value
            };

            bool baru = _terpilih == null;
            BarangStore.Simpan(barang);

            MessageBox.Show(baru ? "Barang berhasil ditambahkan." : "Barang berhasil diperbarui.",
                "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ResetForm();
            MuatData();
        }

        private void btnHapus_Click(object? sender, EventArgs e)
        {
            if (_terpilih == null)
            {
                MessageBox.Show("Pilih barang di tabel terlebih dahulu.", "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show($"Hapus barang \"{_terpilih.Nama}\"?", "Konfirmasi hapus",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
                return;

            BarangStore.Hapus(_terpilih.Kode);
            ResetForm();
            MuatData();
        }

        // ================= HELPER =================
        private void HitungMargin()
        {
            decimal beli = ParseRupiah(txtBeli.Text);
            decimal jual = ParseRupiah(txtJual.Text);

            if (beli <= 0 || jual <= 0) { lblMargin.Text = "Margin: -"; return; }

            decimal selisih = jual - beli;
            decimal persen = selisih / beli * 100m;
            lblMargin.Text = $"Margin: Rp {selisih.ToString("N0", _id)} ({persen.ToString("0.#", _id)}%)";
            lblMargin.ForeColor = selisih >= 0
                ? Color.FromArgb(30, 136, 229)
                : Color.FromArgb(210, 50, 50);
        }

        private static decimal ParseRupiah(string teks)
        {
            string digit = new string(teks.Where(char.IsDigit).ToArray());
            return decimal.TryParse(digit, out var v) ? v : 0;
        }

        private void FormatRupiah(TextBox tb)
        {
            decimal v = ParseRupiah(tb.Text);
            tb.Text = v > 0 ? v.ToString("N0", _id) : "";
        }

        private static void HanyaAngka(object? sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;
        }

        private static void Peringatan(string pesan, Control fokus)
        {
            MessageBox.Show(pesan, "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            fokus.Focus();
        }

        // ================= handler yang dirujuk Designer =================
        // (hapus yang sudah ada di file Anda agar tidak dobel)
        private void tlpRoot_Paint(object? sender, PaintEventArgs e) { }
        private void tlpContent_Paint(object? sender, PaintEventArgs e) { }
        private void tlpForm_Paint(object? sender, PaintEventArgs e) { }
        private void txtKategori_TextChanged(object? sender, EventArgs e) { }
    }
}