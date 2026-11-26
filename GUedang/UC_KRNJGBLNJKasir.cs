using System.ComponentModel;
using System.Globalization;

namespace GUedang
{
    public partial class UC_KRNJGBLNJKasir : UserControl
    {
        private class ItemKeranjang
        {
            public string Kode = "";
            public string Nama = "";
            public decimal Harga;
            public int Qty;
            public decimal Subtotal => Harga * Qty;
        }

        private readonly CultureInfo _id = new("id-ID");
        private readonly List<ItemKeranjang> _keranjang = new();
        private bool _loading;
        private bool _updating;

        /// <summary>Isi dari user yang login, mis. new UC_KRNJGBLNJKasir { NamaKasir = user.Username }</summary>
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string NamaKasir { get; set; } = "kasir";

        public UC_KRNJGBLNJKasir()
        {
            InitializeComponent();

            Load += UC_Kasir_Load;
            BarangStore.DataChanged += OnDataChanged;
            Disposed += (s, e) => BarangStore.DataChanged -= OnDataChanged;
        }

        private void OnDataChanged()
        {
            if (IsHandleCreated && !IsDisposed)
                BeginInvoke(new Action(MuatProduk));
        }

        private void UC_Kasir_Load(object? sender, EventArgs e)
        {
            if (DesignMode || LicenseManager.UsageMode == LicenseUsageMode.Designtime) return;

            // grid hanya tampil, pilih per baris
            foreach (var g in new[] { dgvProduk, dgvKeranjang })
            {
                g.ReadOnly = true;
                g.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                g.AllowUserToResizeRows = false;
            }
            foreach (var c in new[] { colNo, colHarga, colStok, colKQty, colKHarga, colKSubtotal })
                c.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            cmbMetode.SelectedIndex = 0;   // Tunai

            // pencarian barang
            txtKode.TextChanged += (s, ev) => MuatProduk();
            txtNama.TextChanged += (s, ev) => MuatProduk();
            cmbKategori.SelectedIndexChanged += (s, ev) => { if (!_loading) MuatProduk(); };
            txtKode.KeyDown += txtKode_KeyDown;

            // tambah ke keranjang
            btnTambah.Click += (s, ev) => TambahDariDaftar();
            dgvProduk.CellDoubleClick += (s, ev) => { if (ev.RowIndex >= 0) TambahDariDaftar(); };

            // ubah keranjang
            btnTambahQty.Click += (s, ev) => UbahQty(+1);
            btnKurang.Click += (s, ev) => UbahQty(-1);
            btnHapusItem.Click += (s, ev) => HapusItem();
            btnHapusSemua.Click += (s, ev) => Kosongkan(true);
            btnBatal.Click += (s, ev) => Kosongkan(true);

            // pembayaran
            txtDiskon.TextChanged += (s, ev) => Hitung();
            cmbMetode.SelectedIndexChanged += (s, ev) => Hitung();
            txtBayar.TextChanged += (s, ev) => { if (!_updating) Hitung(); };
            txtBayar.KeyPress += HanyaAngka;
            txtBayar.Leave += (s, ev) => FormatBayar();
            txtBayar.KeyDown += (s, ev) =>
            {
                if (ev.KeyCode == Keys.Enter) { ev.SuppressKeyPress = true; Bayar(); }
            };
            btnBayar.Click += (s, ev) => Bayar();

            MuatProduk();
            RefreshKeranjang();
            txtKode.Focus();
        }

        // ================= DAFTAR BARANG =================
        private void MuatProduk()
        {
            if (_loading) return;

            // hanya barang yang stoknya sudah diisi gudang (stok > 0)
            var semua = BarangStore.GetAll().Where(b => b.Stok > 0).ToList();

            // isi combo kategori (hanya jika daftar kategori berubah)
            var kats = semua.Select(b => b.Kategori)
                            .Where(k => !string.IsNullOrWhiteSpace(k))
                            .Distinct(StringComparer.OrdinalIgnoreCase)
                            .OrderBy(k => k).ToList();
            var sekarang = cmbKategori.Items.Cast<object>().Skip(1).Select(x => x.ToString()).ToList();
            if (!kats.SequenceEqual(sekarang))
            {
                string pilih = cmbKategori.SelectedItem?.ToString() ?? "Semua";
                _loading = true;
                cmbKategori.Items.Clear();
                cmbKategori.Items.Add("Semua");
                cmbKategori.Items.AddRange(kats.Cast<object>().ToArray());
                int idx = cmbKategori.Items.IndexOf(pilih);
                cmbKategori.SelectedIndex = idx >= 0 ? idx : 0;
                _loading = false;
            }
            else if (cmbKategori.SelectedIndex < 0 && cmbKategori.Items.Count > 0)
            {
                _loading = true; cmbKategori.SelectedIndex = 0; _loading = false;
            }

            string kode = txtKode.Text.Trim();
            string nama = txtNama.Text.Trim();
            string kat = cmbKategori.SelectedItem?.ToString() ?? "Semua";

            var tampil = semua.Where(b =>
                    (kode.Length == 0 || b.Kode.Contains(kode, StringComparison.OrdinalIgnoreCase)) &&
                    (nama.Length == 0 || b.Nama.Contains(nama, StringComparison.OrdinalIgnoreCase)) &&
                    (kat == "Semua" || b.Kategori.Equals(kat, StringComparison.OrdinalIgnoreCase)))
                .OrderBy(b => b.Nama).ToList();

            dgvProduk.Rows.Clear();
            int no = 1;
            foreach (var b in tampil)
            {
                int i = dgvProduk.Rows.Add(no++, b.Kode, b.Nama,
                    b.HargaJual.ToString("N0", _id), b.Kategori, b.Stok);
                dgvProduk.Rows[i].Tag = b;
            }

            dgvProduk.ClearSelection();
            // saat mencari, baris pertama langsung terpilih supaya tinggal klik "+"
            if ((kode.Length > 0 || nama.Length > 0) && dgvProduk.Rows.Count > 0)
                dgvProduk.Rows[0].Selected = true;
        }

        private void txtKode_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;
            e.SuppressKeyPress = true;
            e.Handled = true;

            string kode = txtKode.Text.Trim();
            if (kode.Length == 0) return;

            var b = BarangStore.GetByKode(kode);   // pas dengan hasil scan barcode
            if (b == null)
            {
                MessageBox.Show($"Barang dengan kode \"{kode}\" tidak ditemukan.", "Tidak ditemukan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtKode.SelectAll();
                return;
            }

            if (Tambah(b, (int)nudJumlah.Value))
                txtKode.Clear();
            txtKode.Focus();
        }

        private void TambahDariDaftar()
        {
            if (dgvProduk.SelectedRows.Count == 0 || dgvProduk.SelectedRows[0].Tag is not Barang b)
            {
                MessageBox.Show("Pilih barang dari daftar, atau ketik/scan kodenya lalu tekan Enter.",
                    "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Tambah(b, (int)nudJumlah.Value);
        }

        // ================= KERANJANG =================
        private bool Tambah(Barang b, int qty)
        {
            var terbaru = BarangStore.GetByKode(b.Kode);   // stok paling baru
            if (terbaru == null)
            {
                MessageBox.Show("Barang ini sudah dihapus dari data.", "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MuatProduk();
                return false;
            }

            var item = _keranjang.FirstOrDefault(x => x.Kode.Equals(terbaru.Kode, StringComparison.OrdinalIgnoreCase));
            int sudah = item?.Qty ?? 0;

            if (terbaru.Stok <= 0)
            {
                MessageBox.Show($"Stok {terbaru.Nama} habis.", "Stok habis",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (sudah + qty > terbaru.Stok)
            {
                MessageBox.Show($"Stok {terbaru.Nama} tidak cukup.\nSisa stok: {terbaru.Stok}, di keranjang: {sudah}.",
                    "Stok tidak cukup", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (item == null)
                _keranjang.Add(new ItemKeranjang
                {
                    Kode = terbaru.Kode,
                    Nama = terbaru.Nama,
                    Harga = terbaru.HargaJual,
                    Qty = qty
                });
            else
                item.Qty += qty;

            nudJumlah.Value = 1;
            RefreshKeranjang(terbaru.Kode);
            return true;
        }

        private ItemKeranjang? ItemTerpilih()
        {
            if (dgvKeranjang.SelectedRows.Count == 0) return null;
            string kode = dgvKeranjang.SelectedRows[0].Cells[colKKode.Index].Value?.ToString() ?? "";
            return _keranjang.FirstOrDefault(x => x.Kode == kode);
        }

        private void UbahQty(int delta)
        {
            var item = ItemTerpilih();
            if (item == null)
            {
                MessageBox.Show("Pilih item di keranjang terlebih dahulu.", "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (delta > 0)
            {
                var b = BarangStore.GetByKode(item.Kode);
                if (b == null || item.Qty + delta > b.Stok)
                {
                    MessageBox.Show($"Stok {item.Nama} tidak cukup (sisa {b?.Stok ?? 0}).", "Stok tidak cukup",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            item.Qty += delta;
            if (item.Qty <= 0)
            {
                _keranjang.Remove(item);
                RefreshKeranjang();
            }
            else RefreshKeranjang(item.Kode);
        }

        private void HapusItem()
        {
            var item = ItemTerpilih();
            if (item == null)
            {
                MessageBox.Show("Pilih item di keranjang terlebih dahulu.", "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            _keranjang.Remove(item);
            RefreshKeranjang();
        }

        private void Kosongkan(bool konfirmasi)
        {
            bool adaIsi = _keranjang.Count > 0 || txtDiskon.Text.Length > 0 || txtBayar.Text.Length > 0;
            if (konfirmasi && adaIsi &&
                MessageBox.Show("Kosongkan keranjang dan batalkan transaksi ini?", "Konfirmasi",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            _keranjang.Clear();
            _updating = true;
            txtDiskon.Clear();
            txtBayar.Clear();
            _updating = false;
            cmbMetode.SelectedIndex = 0;
            nudJumlah.Value = 1;
            RefreshKeranjang();
            txtKode.Focus();
        }

        private void RefreshKeranjang(string? pilihKode = null)
        {
            pilihKode ??= ItemTerpilih()?.Kode;

            dgvKeranjang.Rows.Clear();
            foreach (var x in _keranjang)
            {
                int i = dgvKeranjang.Rows.Add(x.Kode, x.Nama, x.Qty,
                    x.Harga.ToString("N0", _id), x.Subtotal.ToString("N0", _id));
                if (x.Kode == pilihKode) dgvKeranjang.Rows[i].Selected = true;
            }
            if (pilihKode == null || !_keranjang.Any(x => x.Kode == pilihKode))
                dgvKeranjang.ClearSelection();

            Hitung();
        }

        // ================= HITUNG & BAYAR =================
        private void Hitung(out decimal subtotal, out decimal diskon, out decimal total)
        {
            subtotal = _keranjang.Sum(x => x.Subtotal);
            diskon = HitungDiskon(subtotal);
            total = subtotal - diskon;
        }

        private void Hitung()
        {
            Hitung(out decimal subtotal, out decimal diskon, out decimal total);

            lblSubtotalNilai.Text = Rp(subtotal);
            lblTotalNilai.Text = Rp(total);

            // non-tunai: uang diterima otomatis = total
            bool tunai = (cmbMetode.SelectedItem?.ToString() ?? "Tunai") == "Tunai";
            txtBayar.ReadOnly = !tunai;
            if (!tunai)
            {
                _updating = true;
                txtBayar.Text = total > 0 ? total.ToString("N0", _id) : "";
                _updating = false;
            }

            decimal bayar = ParseRupiah(txtBayar.Text);
            decimal kembali = bayar - total;

            if (total <= 0 || bayar == 0)
            {
                lblKembaliJudul.Text = "Kembalian";
                lblKembaliNilai.Text = "Rp 0";
                lblKembaliNilai.ForeColor = Color.FromArgb(40, 140, 90);
            }
            else if (kembali >= 0)
            {
                lblKembaliJudul.Text = "Kembalian";
                lblKembaliNilai.Text = Rp(kembali);
                lblKembaliNilai.ForeColor = Color.FromArgb(40, 140, 90);
            }
            else
            {
                lblKembaliJudul.Text = "Kurang";
                lblKembaliNilai.Text = Rp(-kembali);
                lblKembaliNilai.ForeColor = Color.FromArgb(210, 50, 50);
            }
        }

        /// <summary>Diskon: "5000" (rupiah) atau "10%" (persen).</summary>
        private decimal HitungDiskon(decimal subtotal)
        {
            string t = txtDiskon.Text.Trim();
            if (t.Length == 0 || subtotal <= 0) return 0;

            decimal diskon;
            if (t.EndsWith('%'))
            {
                string angka = t.TrimEnd('%').Trim().Replace(',', '.');
                if (!decimal.TryParse(angka, NumberStyles.Number, CultureInfo.InvariantCulture, out decimal persen))
                    return 0;
                persen = Math.Clamp(persen, 0, 100);
                diskon = Math.Round(subtotal * persen / 100m, 0);
            }
            else
            {
                diskon = ParseRupiah(t);
            }
            return Math.Clamp(diskon, 0, subtotal);
        }

        private void Bayar()
        {
            if (_keranjang.Count == 0)
            {
                MessageBox.Show("Keranjang masih kosong.", "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Hitung(out decimal subtotal, out decimal diskon, out decimal total);
            string metode = cmbMetode.SelectedItem?.ToString() ?? "Tunai";
            decimal bayar = metode == "Tunai" ? ParseRupiah(txtBayar.Text) : total;

            if (total <= 0)
            {
                MessageBox.Show("Total belanja tidak boleh 0.", "Validasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (bayar < total)
            {
                MessageBox.Show($"Uang diterima kurang {Rp(total - bayar)}.", "Pembayaran kurang",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBayar.Focus();
                return;
            }

            var trx = new Transaksi
            {
                Kode = TransaksiStore.BuatKode(),
                Tanggal = DateTime.Now,
                Kasir = Session.UserAktif.Nama,
                Diskon = diskon,
                Metode = metode,
                Bayar = bayar,
                Kembali = bayar - total,
                Detail = _keranjang.Select(x =>
                {
                    var brg = BarangStore.GetByKode(x.Kode);
                    return new DetailTransaksi
                    {
                        KodeBarang = x.Kode,
                        NamaBarang = x.Nama,
                        Harga = x.Harga,
                        HargaBeli = brg?.HargaBeli ?? 0,
                        Qty = x.Qty
                    };
                }).ToList()
            };

            // cek stok + kurangi stok + simpan, semua dilakukan oleh store
            if (!TransaksiStore.Simpan(trx, out string error))
            {
                MessageBox.Show(error, "Transaksi gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MuatProduk();
                return;
            }

            Kosongkan(false);
            MuatProduk();

            // tampilkan struk
            StrukHelper.Tampilkan(FindForm(), trx);

            // DIMATIKAN: kasir tetap di halaman Keranjang belanja setelah struk ditutup.
            // Hapus tanda // di bawah kalau ingin pindah otomatis ke Riwayat Transaksi lagi.
            // TransaksiSelesai?.Invoke(trx);
        }

        // ================= HELPER =================
        private string Rp(decimal nilai) => "Rp " + nilai.ToString("N0", _id);

        private static decimal ParseRupiah(string teks)
        {
            string digit = new string(teks.Where(char.IsDigit).ToArray());
            return decimal.TryParse(digit, out var v) ? v : 0;
        }

        private void FormatBayar()
        {
            if (txtBayar.ReadOnly) return;
            decimal v = ParseRupiah(txtBayar.Text);
            _updating = true;
            txtBayar.Text = v > 0 ? v.ToString("N0", _id) : "";
            _updating = false;
        }

        private static void HanyaAngka(object? sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        // F2 = fokus ke kode barang, F12 = bayar
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.F2) { txtKode.Focus(); txtKode.SelectAll(); return true; }
            if (keyData == Keys.F12) { Bayar(); return true; }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        public event Action<Transaksi>? TransaksiSelesai;

        // handler yang dirujuk Designer (hapus jika sudah ada di file Anda)
        private void tlpRoot_Paint(object? sender, PaintEventArgs e) { }
    }
}