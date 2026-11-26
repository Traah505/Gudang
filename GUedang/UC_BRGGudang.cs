

namespace GUedang
{
    public partial class UC_BRGGudang : UserControl
    {
        private Barang? _terpilih;

        public UC_BRGGudang()
        {
            InitializeComponent();

            btnCari.Click += (s, e) => CariBarang();
            txtCari.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter) { e.SuppressKeyPress = true; CariBarang(); }
            };
            nudJumlah.ValueChanged += (s, e) => HitungTotal();
            txtHarga.TextChanged += (s, e) => HitungTotal();
            btnSimpan.Click += btnSimpan_Click;

            dtpTanggal.ValueChanged += (s, e) => MuatRiwayat();
            chkSemua.CheckedChanged += (s, e) =>
            {
                dtpTanggal.Enabled = !chkSemua.Checked;
                MuatRiwayat();
            };
            txtCariRiwayat.TextChanged += (s, e) => MuatRiwayat();
            dgvRiwayat.CellClick += dgvRiwayat_CellClick;

            MuatRiwayat();
        }
        private void dgvRiwayat_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || dgvRiwayat.Rows[e.RowIndex].Tag is not BarangMasuk m) return;

            // ambil data barang terbaru (untuk info stok saat ini)
            _terpilih = BarangStore.GetByKode(m.Kode);

            txtCari.Text = m.Kode;
            nudJumlah.Value = Math.Clamp(m.Jumlah, (int)nudJumlah.Minimum, (int)nudJumlah.Maximum);
            txtHarga.Text = m.HargaBeli.ToString("N0", new System.Globalization.CultureInfo("id-ID"));
            txtSupplier.Text = m.Supplier;
            txtKeterangan.Text = m.Keterangan;

            lblInfoBarang.Text = _terpilih != null
                ? $"{_terpilih.Kode} - {_terpilih.Nama}  |  Stok saat ini: {_terpilih.Stok} {_terpilih.Satuan}"
                : $"{m.Kode} - {m.Nama}  |  (barang sudah dihapus admin)";

            HitungTotal();
        }
        // ---------- cari barang (hanya yang sudah dibuat admin) ----------
        private void CariBarang()
        {
            string key = txtCari.Text.Trim();
            if (key.Length == 0) return;

            var exact = BarangStore.GetByKode(key);
            if (exact != null) { PilihBarang(exact); return; }

            var hasil = BarangStore.Cari(key);
            if (hasil.Count == 0)
            {
                _terpilih = null;
                lblInfoBarang.Text = "Barang belum dipilih";
                MessageBox.Show(
                    "Barang tidak ditemukan.\nBarang baru hanya bisa ditambahkan oleh Admin.",
                    "Barang Masuk", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (hasil.Count == 1) { PilihBarang(hasil[0]); return; }

            // lebih dari satu: tampilkan pilihan
            var menu = new ContextMenuStrip();
            foreach (var b in hasil.Take(15))
            {
                var item = new ToolStripMenuItem($"{b.Kode} - {b.Nama}");
                var bb = b;
                item.Click += (s, e) => PilihBarang(bb);
                menu.Items.Add(item);
            }
            menu.Show(txtCari, new Point(0, txtCari.Height));
            menu.Show(txtCari, new Point(0, txtCari.Height));
        }

        private void PilihBarang(Barang b)
        {
            _terpilih = b;
            txtCari.Text = b.Kode;
            lblInfoBarang.Text = $"{b.Kode} - {b.Nama}  |  Stok saat ini: {b.Stok} {b.Satuan}";
            txtHarga.Text = b.HargaBeli > 0 ? b.HargaBeli.ToString("N0") : "";
            nudJumlah.Focus();
            HitungTotal();
        }

        // ---------- hitung total ----------
        private static decimal ParseRupiah(string s)
        {
            string digit = new string((s ?? "").Where(char.IsDigit).ToArray());
            return decimal.TryParse(digit, out var v) ? v : 0;
        }

        private void HitungTotal()
        {
            decimal total = nudJumlah.Value * ParseRupiah(txtHarga.Text);
            lblTotalHarga.Text = $"Total: Rp {total:N0}";
        }

        // ---------- simpan ----------
        private void btnSimpan_Click(object? sender, EventArgs e)
        {
            if (_terpilih == null)
            {
                MessageBox.Show("Pilih barang dulu lewat pencarian.");
                return;
            }

            int jumlah = (int)nudJumlah.Value;
            decimal harga = ParseRupiah(txtHarga.Text);

            // semua validasi DULU, sebelum stok diubah
            if (harga <= 0)
            {
                MessageBox.Show("Harga beli harus diisi.");
                txtHarga.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtSupplier.Text))
            {
                MessageBox.Show("Supplier wajib diisi.", "Validasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSupplier.Focus();
                return;
            }

            string supplier = txtSupplier.Text.Trim();
            string keterangan = txtKeterangan.Text.Trim();

            if (!BarangStore.TambahStok(_terpilih.Kode, jumlah, harga))
            {
                MessageBox.Show("Gagal menambah stok. Barang mungkin sudah dihapus admin.");
                return;
            }

            int stokAkhir = BarangStore.GetByKode(_terpilih.Kode)?.Stok ?? 0;

            // lengkapi riwayat yang dibaca halaman Riwayat Gudang (admin)
            StoreRiwayatGudang.CatatAtauPerbarui("Masuk", _terpilih.Kode, _terpilih.Nama,
                jumlah, stokAkhir, supplier, keterangan);

            // riwayat khusus halaman Barang Masuk
            BarangMasukStore.Tambah(new BarangMasuk
            {
                Tanggal = DateTime.Now,
                Kode = _terpilih.Kode,
                Nama = _terpilih.Nama,
                Jumlah = jumlah,
                HargaBeli = harga,
                Supplier = supplier,
                Keterangan = keterangan,
                Petugas = Session.UserAktif?.Nama ?? ""
            });

            // reset form
            _terpilih = null;
            txtCari.Clear();
            txtHarga.Clear();
            txtSupplier.Clear();
            txtKeterangan.Clear();
            nudJumlah.Value = 1;
            lblInfoBarang.Text = "Barang belum dipilih";
            HitungTotal();

            MuatRiwayat();
            MessageBox.Show("Barang masuk tersimpan. Stok sudah diperbarui.");
        }

        // ---------- riwayat + statistik ----------
        private void MuatRiwayat()
        {
            string key = txtCariRiwayat.Text.Trim();
            var data = BarangMasukStore.GetAll()
                .Where(x => chkSemua.Checked || x.Tanggal.Date == dtpTanggal.Value.Date)
                .Where(x => key.Length == 0
                    || x.Nama.Contains(key, StringComparison.OrdinalIgnoreCase)
                    || x.Kode.Contains(key, StringComparison.OrdinalIgnoreCase)
                    || x.Supplier.Contains(key, StringComparison.OrdinalIgnoreCase))
                .OrderByDescending(x => x.Tanggal)
                .ToList();

            dgvRiwayat.Rows.Clear();
            int no = 1;
            foreach (var x in data)
            {
                int i = dgvRiwayat.Rows.Add(no++, x.Tanggal.ToString("dd/MM/yyyy HH:mm"), x.Kode, x.Nama,
                    x.Jumlah, x.HargaBeli.ToString("N0"), x.Total.ToString("N0"),
                    x.Supplier, x.Keterangan);
                dgvRiwayat.Rows[i].Tag = x;
            }

            lblQtyNilai.Text = $"{data.Sum(x => x.Jumlah)} Barang";
            lblRpNilai.Text = $"Rp {data.Sum(x => x.Total):N0}";
            lblTrxNilai.Text = data.Count.ToString();
        }

        //faza gay
        private void tlpRoot_Paint(object? sender, PaintEventArgs e) { }
        private void tlpContent_Paint(object? sender, PaintEventArgs e) { }
    }
}