using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace GUedang
{
    public partial class UC_KRNJGBLNJKasir : UserControl   // samakan nama class dengan file-mu
    {
        private List<ItemJual> keranjang = new List<ItemJual>();

        public UC_KRNJGBLNJKasir()
        {
            InitializeComponent();

            Load += UC_Keranjang_Load;
            dgvBarang.CellClick += dgvBarang_CellClick;
            dgvBarang.CellDoubleClick += dgvBarang_CellDoubleClick;   // klik 2x = tambah ke keranjang
            txtUangDiterima.TextChanged += (s, e) => Hitung();
            btnBayar.Click += btnBayar_Click;
            btnBatal.Click += (s, e) => KosongkanKeranjang();
            btnHapusSemua.Click += (s, e) => KosongkanKeranjang();
        }

        private void UC_Keranjang_Load(object sender, EventArgs e)
        {
            if (DesignMode || LicenseManager.UsageMode == LicenseUsageMode.Designtime) return;

            foreach (var g in new[] { dgvBarang, dgvKeranjang })
            {
                g.AutoGenerateColumns = false;
                g.AllowUserToAddRows = false;
                g.ReadOnly = true;
                g.RowHeadersVisible = false;
                g.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                g.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                g.Columns.Clear();
            }

            dgvBarang.Columns.Add("colNo", "No");
            dgvBarang.Columns.Add("colKode", "Kode Barang");
            dgvBarang.Columns.Add("colNama", "Nama Barang");
            dgvBarang.Columns.Add("colHarga", "Harga");
            dgvBarang.Columns.Add("colKategori", "Kategori");
            dgvBarang.Columns.Add("colStok", "Stok");

            dgvKeranjang.Columns.Add("colNama", "Nama Barang");
            dgvKeranjang.Columns.Add("colJumlah", "Jumlah");
            dgvKeranjang.Columns.Add("colHarga", "Harga");

            MuatBarang();
            Hitung();
        }

        private void MuatBarang()
        {
            dgvBarang.Rows.Clear();
            int no = 1;
            foreach (var b in BarangStore.Muat().Where(x => x.Stok > 0))
                dgvBarang.Rows.Add(no++, b.KodeBarang, b.NamaBarang, b.HargaJual, b.Kategori, b.Stok);
        }

        private void dgvBarang_CellClick(object s, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var r = dgvBarang.Rows[e.RowIndex];
            txtKodeKasir.Text = r.Cells[1].Value?.ToString();
            txtNamaKasir.Text = r.Cells[2].Value?.ToString();
            textKategoriKasir.Text = r.Cells[4].Value?.ToString();
            numJumlah.Value = 1;
        }

        private void dgvBarang_CellDoubleClick(object s, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || numJumlah.Value <= 0) return;
            var r = dgvBarang.Rows[e.RowIndex];
            string kode = r.Cells[1].Value.ToString();
            decimal harga = Convert.ToDecimal(r.Cells[3].Value);
            decimal stok = Convert.ToDecimal(r.Cells[5].Value);

            var ada = keranjang.FirstOrDefault(i => i.Kode == kode);
            decimal sudah = ada?.Jumlah ?? 0;
            if (sudah + numJumlah.Value > stok)
            {
                MessageBox.Show("Stok tidak cukup (sisa " + stok.ToString("0.##") + ").");
                return;
            }

            if (ada != null) ada.Jumlah += numJumlah.Value;
            else keranjang.Add(new ItemJual
            {
                Kode = kode,
                Nama = r.Cells[2].Value.ToString(),
                Jumlah = numJumlah.Value,
                Harga = harga
            });
            RefreshKeranjang();
        }

        private void RefreshKeranjang()
        {
            dgvKeranjang.Rows.Clear();
            foreach (var i in keranjang)
                dgvKeranjang.Rows.Add(i.Nama, i.Jumlah.ToString("0.##"), i.Subtotal);
            Hitung();
        }

        private void KosongkanKeranjang()
        {
            keranjang = new List<ItemJual>();
            txtUangDiterima.Text = "";
            RefreshKeranjang();
        }

        private void Hitung()
        {
            decimal total = keranjang.Sum(i => i.Subtotal);
            lblSubtotal.Text = "Rp " + total.ToString("N0");
            lblNominalTotalBelanja.Text = "Rp " + total.ToString("N0");
            lblTotalBayar.Text = "Rp " + total.ToString("N0");
            decimal.TryParse(txtUangDiterima.Text, out decimal uang);
            lblKembalian.Text = "Rp " + Math.Max(0, uang - total).ToString("N0");
        }

        private void btnBayar_Click(object s, EventArgs e)
        {
            decimal.TryParse(txtUangDiterima.Text, out decimal uang);
            bool ok = PenjualanStore.Bayar(Sesi.NamaUser, keranjang, uang, out string pesan);
            MessageBox.Show(pesan, "Pembayaran", MessageBoxButtons.OK,
                ok ? MessageBoxIcon.Information : MessageBoxIcon.Warning);
            if (ok)
            {
                KosongkanKeranjang();
                MuatBarang();
            }
        }
        

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void rondedbuton1_Click(object sender, EventArgs e)
        {

        }

        private void roundedPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void roundedPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvBarang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
