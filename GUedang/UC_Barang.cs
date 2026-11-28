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

            nudStok.Maximum = 100000;   // stok awal bisa diisi admin
        }

        // dipertahankan kalau masih dirujuk Designer
        private void btnBaru_Click(object? sender, EventArgs e) { }

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
            dgvBarang.CellDoubleClick += dgvBarang_CellDoubleClick;
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

        // klik 2x baris barang -> antrian FIFO + riwayat stok masuk & perubahan harga
        private void dgvBarang_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || dgvBarang.Rows[e.RowIndex].Tag is not Barang b) return;
            using var f = new FormRiwayatBarang(b.Kode, b.Nama);
            f.ShowDialog(FindForm());
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
            nudStok.Enabled = false;   // mode ubah: stok hanya ditampilkan
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
            nudStok.Enabled = true;    // mode tambah: admin boleh mengisi stok awal
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
            int stokIsi = (int)nudStok.Value;   // stok yang diisi admin (hanya di mode tambah)

            if (nama.Length == 0) { Peringatan("Nama barang wajib diisi.", txtNama); return; }
            if (beli <= 0) { Peringatan("Harga beli harus lebih dari 0.", txtBeli); return; }
            if (jual <= 0) { Peringatan("Harga jual harus lebih dari 0.", txtJual); return; }

            // nama sama dengan barang lain?
            var sama = BarangStore.GetAll().FirstOrDefault(b =>
                b.Nama.Equals(nama, StringComparison.OrdinalIgnoreCase) && b.Kode != txtKode.Text);
            if (sama != null)
            {
                if (_terpilih != null)
                {
                    Peringatan("Nama itu sudah dipakai barang lain.", txtNama);
                    return;
                }
                // nama sama = barang yang sama dengan harga baru, masuk antrian FIFO
                DaftarkanHargaBaru(sama, beli, jual, stokIsi);
                return;
            }

            if (kategori.Length == 0) { Peringatan("Kategori wajib diisi.", txtKategori); return; }
            if (satuan.Length == 0) { Peringatan("Satuan wajib diisi (mis. pcs, dus, kg).", txtSatuan); return; }

            if (jual < beli &&
                MessageBox.Show("Harga jual lebih rendah dari harga beli (rugi). Tetap simpan?",
                    "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            var lama = BarangStore.GetByKode(txtKode.Text);

            // bukukan stok yang ada dengan harga lamanya sebelum harga berubah
            if (lama != null) LapisanStokStore.Sinkronkan(lama.Kode);

            var barang = new Barang
            {
                Kode = txtKode.Text,
                Nama = nama,
                Kategori = kategori,
                Satuan = satuan,
                HargaBeli = beli,
                HargaJual = jual,
                Stok = lama?.Stok ?? stokIsi,    // barang baru = stok awal dari admin, edit = stok tidak berubah
                StokMinimum = (int)nudMin.Value
            };

            bool baru = _terpilih == null;
            BarangStore.Simpan(barang);

            if (lama != null)
            {
                // harga jual naik/turun: berlaku untuk stok yang belum mulai terjual
                if (lama.HargaJual != jual)
                    LapisanStokStore.TerapkanHargaJual(lama.Kode, lama.HargaJual, jual);
            }
            else if (stokIsi > 0)
            {
                // stok awal dari admin = lapisan pertama di antrian FIFO
                LapisanStokStore.TambahLapisan(barang.Kode, stokIsi, beli, jual, "Stok awal", "Diinput admin");
                StoreRiwayatGudang.CatatAtauPerbarui("Masuk", barang.Kode, barang.Nama,
                    stokIsi, stokIsi, "Stok awal (admin)", "");
            }

            MessageBox.Show(baru ? "Barang berhasil ditambahkan." : "Barang berhasil diperbarui.",
                "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ResetForm();
            MuatData();
        }

        // nama sama = barang yang sama dengan harga baru. Stok yang diisi (jika ada)
        // jadi lapisan baru, antri di belakang stok lama.
        private void DaftarkanHargaBaru(Barang ada, decimal beli, decimal jual, int stok)
        {
            if (stok == 0 && ada.HargaBeli == beli && ada.HargaJual == jual)
            {
                MessageBox.Show($"Harga {ada.Nama} sama dengan harga yang sedang berlaku, dan stok tambahan 0. Tidak ada yang berubah.",
                    "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string pesan =
                $"\"{ada.Nama}\" sudah ada ({ada.Kode}).\n\n" +
                "Daftarkan sebagai harga baru?\n" +
                $"Harga beli : Rp {ada.HargaBeli.ToString("N0", _id)}  →  Rp {beli.ToString("N0", _id)}\n" +
                $"Harga jual : Rp {ada.HargaJual.ToString("N0", _id)}  →  Rp {jual.ToString("N0", _id)}\n";
            if (stok > 0)
                pesan += $"Tambah stok: +{stok} {ada.Satuan}\n";
            pesan += "\nStok yang ada tetap dijual dengan harga lama sampai habis.\n" +
                     "Stok baru memakai harga ini dan antri di belakangnya.";

            if (MessageBox.Show(pesan, "Harga baru (FIFO)",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            // kunci stok lama dengan harga lamanya dulu
            LapisanStokStore.Sinkronkan(ada.Kode);

            decimal beliLama = ada.HargaBeli;
            decimal jualLama = ada.HargaJual;

            ada.HargaBeli = beli;
            ada.HargaJual = jual;
            BarangStore.Simpan(ada);

            if (jual != jualLama || beli != beliLama)
            {
                string ket = $"harga beli Rp {beliLama.ToString("N0", _id)} → Rp {beli.ToString("N0", _id)}";
                ket += stok > 0 ? $"; +{stok} {ada.Satuan} masuk dengan harga ini"
                                : "; berlaku untuk stok yang masuk berikutnya";
                LapisanStokStore.DaftarkanHargaBaru(ada.Kode, jualLama, jual, ket);
            }

            if (stok > 0)
            {
                BarangStore.TambahStok(ada.Kode, stok, beli);
                LapisanStokStore.TambahLapisan(ada.Kode, stok, beli, jual, "Tambah stok", "Diinput admin");
                int stokAkhir = BarangStore.GetByKode(ada.Kode)?.Stok ?? 0;
                StoreRiwayatGudang.CatatAtauPerbarui("Masuk", ada.Kode, ada.Nama,
                    stok, stokAkhir, "Tambah stok (admin)", "");
            }

            MessageBox.Show(stok > 0
                    ? $"Harga baru {ada.Nama} terdaftar dan +{stok} {ada.Satuan} masuk ke antrian FIFO."
                    : $"Harga baru {ada.Nama} terdaftar.\nStok barunya dicatat gudang lewat Barang Masuk.",
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
            LapisanStokStore.HapusBarang(_terpilih.Kode);
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
        private void tlpRoot_Paint(object? sender, PaintEventArgs e) { }
        private void tlpContent_Paint(object? sender, PaintEventArgs e) { }
        private void tlpForm_Paint(object? sender, PaintEventArgs e) { }
        private void txtKategori_TextChanged(object? sender, EventArgs e) { }
    }
}