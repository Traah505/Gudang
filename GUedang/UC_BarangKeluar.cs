using System.Globalization;

namespace GUedang
{
    public partial class UC_BarangKeluar : UserControl
    {
        private readonly CultureInfo _id = new("id-ID");
        private Barang? _terpilih;

        public UC_BarangKeluar()
        {
            InitializeComponent();

            // pilihan tujuan
            if (cmbTujuan.Items.Count == 0)
                cmbTujuan.Items.AddRange(new object[]
                {
                    "Rusak", "Kadaluarsa", "Hilang", "Retur ke supplier",
                    "Pemakaian internal", "Lainnya"
                });
            cmbTujuan.DropDownStyle = ComboBoxStyle.DropDownList;

            btnCari.Click += (s, e) => CariBarang();
            txtCari.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter) { e.SuppressKeyPress = true; CariBarang(); }
            };
            nudJumlah.ValueChanged += (s, e) => HitungNilai();
            btnSimpan.Click += btnSimpan_Click;

            dgvRiwayat.CellClick += dgvRiwayat_CellClick;
            dtpTanggal.ValueChanged += (s, e) => MuatRiwayat();
            chkSemua.CheckedChanged += (s, e) =>
            {
                dtpTanggal.Enabled = !chkSemua.Checked;
                MuatRiwayat();
            };
            txtCariRiwayat.TextChanged += (s, e) => MuatRiwayat();

            MuatRiwayat();
        }

        // ================= CARI BARANG =================
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
                MessageBox.Show("Barang tidak ditemukan.", "Barang Keluar",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (hasil.Count == 1) { PilihBarang(hasil[0]); return; }

            var menu = new ContextMenuStrip();
            foreach (var b in hasil.Take(15))
            {
                var item = new ToolStripMenuItem($"{b.Kode} - {b.Nama}  (stok {b.Stok})");
                var bb = b;
                item.Click += (s, e) => PilihBarang(bb);
                menu.Items.Add(item);
            }
            menu.Show(txtCari, new Point(0, txtCari.Height));
        }

        private void PilihBarang(Barang b)
        {
            if (b.Stok <= 0)
            {
                _terpilih = null;
                lblInfoBarang.Text = "Barang belum dipilih";
                MessageBox.Show($"Stok {b.Nama} kosong, tidak ada yang bisa dikeluarkan.",
                    "Stok kosong", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _terpilih = b;
            txtCari.Text = b.Kode;
            lblInfoBarang.Text = $"{b.Kode} - {b.Nama}  |  Stok saat ini: {b.Stok} {b.Satuan}";

            // jumlah tidak boleh melebihi stok
            nudJumlah.Maximum = b.Stok;
            if (nudJumlah.Value > b.Stok) nudJumlah.Value = b.Stok;

            nudJumlah.Focus();
            HitungNilai();
        }

        private void HitungNilai()
        {
            decimal nilai = _terpilih == null ? 0 : nudJumlah.Value * _terpilih.HargaBeli;
            lblTotalHarga.Text = $"Nilai keluar: Rp {nilai.ToString("N0", _id)}";
        }

        // ================= SIMPAN =================
        private void btnSimpan_Click(object? sender, EventArgs e)
        {
            if (_terpilih == null)
            {
                MessageBox.Show("Pilih barang dulu lewat pencarian.", "Validasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cmbTujuan.SelectedIndex < 0)
            {
                MessageBox.Show("Pilih tujuan / alasan barang keluar.", "Validasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbTujuan.Focus();
                return;
            }

            int jumlah = (int)nudJumlah.Value;

            // ambil data terbaru (stok & harga beli bisa sudah berubah)
            var terbaru = BarangStore.GetByKode(_terpilih.Kode);
            if (terbaru == null)
            {
                MessageBox.Show("Barang ini sudah dihapus admin.", "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ResetForm();
                return;
            }
            if (jumlah > terbaru.Stok)
            {
                MessageBox.Show($"Stok {terbaru.Nama} tidak cukup. Sisa stok: {terbaru.Stok}.",
                    "Stok tidak cukup", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                PilihBarang(terbaru);
                return;
            }

            // kurangi stok (store menolak kalau jadi minus)
            if (!BarangStore.UbahStok(terbaru.Kode, -jumlah))
            {
                MessageBox.Show("Gagal mengurangi stok.", "Gagal",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string tujuan = cmbTujuan.SelectedItem?.ToString() ?? "";
            string keterangan = txtKeterangan.Text.Trim();
            string petugas = Session.UserAktif?.Nama ?? "";

            BarangKeluarStore.Tambah(new BarangKeluar
            {
                Tanggal = DateTime.Now,
                Kode = terbaru.Kode,
                Nama = terbaru.Nama,
                Jumlah = jumlah,
                HargaBeli = terbaru.HargaBeli,
                Tujuan = tujuan,
                Keterangan = keterangan,
                Petugas = petugas
            });

            // Simpan juga ke riwayat gudang
            StoreRiwayatGudang.Catat(
                "Keluar",
                terbaru.Kode,
                terbaru.Nama,
                jumlah,
                terbaru.Stok - jumlah,
                tujuan,
                keterangan
            );

            ResetForm();
            MuatRiwayat();
            MessageBox.Show("Barang keluar tersimpan. Stok sudah dikurangi.", "Sukses",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ResetForm()
        {
            _terpilih = null;
            txtCari.Clear();
            txtKeterangan.Clear();
            cmbTujuan.SelectedIndex = -1;
            nudJumlah.Maximum = 100000;
            nudJumlah.Value = 1;
            lblInfoBarang.Text = "Barang belum dipilih";
            HitungNilai();
        }

        // ================= RIWAYAT + STATISTIK =================
        private void MuatRiwayat()
        {
            string key = txtCariRiwayat.Text.Trim();
            var data = BarangKeluarStore.GetAll()
                .Where(x => chkSemua.Checked || x.Tanggal.Date == dtpTanggal.Value.Date)
                .Where(x => key.Length == 0
                    || x.Nama.Contains(key, StringComparison.OrdinalIgnoreCase)
                    || x.Kode.Contains(key, StringComparison.OrdinalIgnoreCase)
                    || x.Tujuan.Contains(key, StringComparison.OrdinalIgnoreCase))
                .OrderByDescending(x => x.Tanggal)
                .ToList();

            dgvRiwayat.Rows.Clear();
            int no = 1;
            foreach (var x in data)
            {
                int i = dgvRiwayat.Rows.Add(no++, x.Tanggal.ToString("dd/MM/yyyy HH:mm"),
                    x.Kode, x.Nama, x.Jumlah, x.Tujuan,
                    x.Nilai.ToString("N0", _id), x.Keterangan);
                dgvRiwayat.Rows[i].Tag = x;
            }

            lblQtyNilai.Text = $"{data.Sum(x => x.Jumlah)} Barang";
            lblRpNilai.Text = $"Rp {data.Sum(x => x.Nilai).ToString("N0", _id)}";
            lblTrxNilai.Text = data.Count.ToString();

            // keterangan kartu ikut di kanan angka supaya tidak bertumpuk
            lblQtyKet.Left = lblQtyNilai.Right + 8;
            lblRpKet.Left = lblRpNilai.Right + 8;
            lblTrxKet.Left = lblTrxNilai.Right + 8;
        }

        // klik baris riwayat -> isi ulang kolom input di atas
        private void dgvRiwayat_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || dgvRiwayat.Rows[e.RowIndex].Tag is not BarangKeluar m) return;

            var b = BarangStore.GetByKode(m.Kode);
            if (b == null)
            {
                lblInfoBarang.Text = $"{m.Kode} - {m.Nama}  |  (barang sudah dihapus admin)";
                _terpilih = null;
                return;
            }

            PilihBarang(b);
            if (_terpilih == null) return;   // stok kosong, PilihBarang sudah memberi pesan

            nudJumlah.Value = Math.Clamp(m.Jumlah, (int)nudJumlah.Minimum, (int)nudJumlah.Maximum);
            int idx = cmbTujuan.Items.IndexOf(m.Tujuan);
            cmbTujuan.SelectedIndex = idx;
            txtKeterangan.Text = m.Keterangan;
            HitungNilai();
        }
    }
}