namespace GUedang
{
    partial class UC_KRNJGBLNJKasir
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            tlpRoot = new TableLayoutPanel();
            pnlJudul = new RoundedPanelUI();
            btnHapusSemua = new RoundedButtonUI();
            lblSub = new Label();
            lblJudul = new Label();
            tlpContent = new TableLayoutPanel();
            pnlProduk = new RoundedPanelUI();
            tlpProduk = new TableLayoutPanel();
            tlpInput = new TableLayoutPanel();
            lblKode = new Label();
            lblNama = new Label();
            lblKategori = new Label();
            lblJumlah = new Label();
            txtKode = new TextBox();
            txtNama = new TextBox();
            cmbKategori = new ComboBox();
            nudJumlah = new NumericUpDown();
            btnTambah = new RoundedButtonUI();
            dgvProduk = new DataGridView();
            colNo = new DataGridViewTextBoxColumn();
            colKode = new DataGridViewTextBoxColumn();
            colNama = new DataGridViewTextBoxColumn();
            colHarga = new DataGridViewTextBoxColumn();
            colKategori = new DataGridViewTextBoxColumn();
            colStok = new DataGridViewTextBoxColumn();
            lblProdukJudul = new Label();
            pnlKeranjang = new RoundedPanelUI();
            tlpKeranjang = new TableLayoutPanel();
            dgvKeranjang = new DataGridView();
            colKKode = new DataGridViewTextBoxColumn();
            colKNama = new DataGridViewTextBoxColumn();
            colKQty = new DataGridViewTextBoxColumn();
            colKHarga = new DataGridViewTextBoxColumn();
            colKSubtotal = new DataGridViewTextBoxColumn();
            flowQty = new FlowLayoutPanel();
            btnKurang = new RoundedButtonUI();
            btnTambahQty = new RoundedButtonUI();
            btnHapusItem = new RoundedButtonUI();
            tlpTotal = new TableLayoutPanel();
            lblSubtotalJudul = new Label();
            lblSubtotalNilai = new Label();
            lblDiskonJudul = new Label();
            txtDiskon = new TextBox();
            lblTotalJudul = new Label();
            lblTotalNilai = new Label();
            lblMetodeJudul = new Label();
            cmbMetode = new ComboBox();
            lblBayarJudul = new Label();
            txtBayar = new TextBox();
            flowUang = new FlowLayoutPanel();
            btnPas = new RoundedButtonUI();
            btnUang50 = new RoundedButtonUI();
            btnUang100 = new RoundedButtonUI();
            lblKembaliJudul = new Label();
            lblKembaliNilai = new Label();
            flowBayar = new FlowLayoutPanel();
            btnBayar = new RoundedButtonUI();
            btnBatal = new RoundedButtonUI();
            lblKeranjangJudul = new Label();
            tlpRoot.SuspendLayout();
            pnlJudul.SuspendLayout();
            tlpContent.SuspendLayout();
            pnlProduk.SuspendLayout();
            tlpProduk.SuspendLayout();
            tlpInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudJumlah).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProduk).BeginInit();
            pnlKeranjang.SuspendLayout();
            tlpKeranjang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKeranjang).BeginInit();
            flowQty.SuspendLayout();
            tlpTotal.SuspendLayout();
            flowUang.SuspendLayout();
            flowBayar.SuspendLayout();
            SuspendLayout();
            // 
            // tlpRoot
            // 
            tlpRoot.ColumnCount = 1;
            tlpRoot.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpRoot.Controls.Add(pnlJudul, 0, 0);
            tlpRoot.Controls.Add(tlpContent, 0, 1);
            tlpRoot.Dock = DockStyle.Fill;
            tlpRoot.Location = new Point(0, 0);
            tlpRoot.Margin = new Padding(0);
            tlpRoot.Name = "tlpRoot";
            tlpRoot.Padding = new Padding(19, 18, 19, 18);
            tlpRoot.RowCount = 2;
            tlpRoot.RowStyles.Add(new RowStyle(SizeType.Absolute, 95F));
            tlpRoot.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpRoot.Size = new Size(1283, 923);
            tlpRoot.TabIndex = 0;
            tlpRoot.Paint += tlpRoot_Paint;
            // 
            // pnlJudul
            // 
            pnlJudul.AccentColor = Color.Transparent;
            pnlJudul.BackColor = Color.White;
            pnlJudul.BorderColor = Color.FromArgb(214, 228, 245);
            pnlJudul.Controls.Add(btnHapusSemua);
            pnlJudul.Controls.Add(lblSub);
            pnlJudul.Controls.Add(lblJudul);
            pnlJudul.Dock = DockStyle.Fill;
            pnlJudul.Location = new Point(19, 18);
            pnlJudul.Margin = new Padding(0, 0, 0, 14);
            pnlJudul.Name = "pnlJudul";
            pnlJudul.Radius = 18;
            pnlJudul.Size = new Size(1245, 81);
            pnlJudul.TabIndex = 0;
            // 
            // btnHapusSemua
            // 
            btnHapusSemua.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnHapusSemua.BackColor = Color.White;
            btnHapusSemua.BorderColor = Color.FromArgb(214, 69, 65);
            btnHapusSemua.FlatStyle = FlatStyle.Flat;
            btnHapusSemua.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            btnHapusSemua.ForeColor = Color.FromArgb(214, 69, 65);
            btnHapusSemua.HoverColor = Color.FromArgb(253, 236, 235);
            btnHapusSemua.Location = new Point(1056, 20);
            btnHapusSemua.Margin = new Padding(4, 3, 4, 3);
            btnHapusSemua.Name = "btnHapusSemua";
            btnHapusSemua.Size = new Size(152, 42);
            btnHapusSemua.TabIndex = 0;
            btnHapusSemua.Text = "Hapus Semua";
            btnHapusSemua.UseVisualStyleBackColor = false;
            // 
            // lblSub
            // 
            lblSub.AutoSize = true;
            lblSub.BackColor = Color.Transparent;
            lblSub.Font = new Font("Segoe UI", 9.5F);
            lblSub.ForeColor = Color.FromArgb(90, 110, 140);
            lblSub.Location = new Point(28, 51);
            lblSub.Margin = new Padding(4, 0, 4, 0);
            lblSub.Name = "lblSub";
            lblSub.Size = new Size(377, 17);
            lblSub.TabIndex = 1;
            lblSub.Text = "Cari barang, tambahkan ke keranjang, lalu proses pembayaran.";
            // 
            // lblJudul
            // 
            lblJudul.AutoSize = true;
            lblJudul.BackColor = Color.Transparent;
            lblJudul.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            lblJudul.ForeColor = Color.FromArgb(13, 47, 110);
            lblJudul.Location = new Point(26, 9);
            lblJudul.Margin = new Padding(4, 0, 4, 0);
            lblJudul.Name = "lblJudul";
            lblJudul.Size = new Size(191, 30);
            lblJudul.TabIndex = 2;
            lblJudul.Text = "Keranjang Belanja";
            // 
            // tlpContent
            // 
            tlpContent.ColumnCount = 2;
            tlpContent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 56F));
            tlpContent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 44F));
            tlpContent.Controls.Add(pnlProduk, 0, 0);
            tlpContent.Controls.Add(pnlKeranjang, 1, 0);
            tlpContent.Dock = DockStyle.Fill;
            tlpContent.Location = new Point(19, 113);
            tlpContent.Margin = new Padding(0);
            tlpContent.Name = "tlpContent";
            tlpContent.RowCount = 1;
            tlpContent.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpContent.Size = new Size(1245, 792);
            tlpContent.TabIndex = 1;
            // 
            // pnlProduk
            // 
            pnlProduk.AccentColor = Color.Transparent;
            pnlProduk.BackColor = Color.White;
            pnlProduk.BorderColor = Color.FromArgb(214, 228, 245);
            pnlProduk.Controls.Add(tlpProduk);
            pnlProduk.Controls.Add(lblProdukJudul);
            pnlProduk.Dock = DockStyle.Fill;
            pnlProduk.Location = new Point(0, 0);
            pnlProduk.Margin = new Padding(0, 0, 14, 0);
            pnlProduk.Name = "pnlProduk";
            pnlProduk.Padding = new Padding(23, 16, 23, 18);
            pnlProduk.Radius = 18;
            pnlProduk.Size = new Size(683, 792);
            pnlProduk.TabIndex = 0;
            // 
            // tlpProduk
            // 
            tlpProduk.ColumnCount = 1;
            tlpProduk.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpProduk.Controls.Add(tlpInput, 0, 0);
            tlpProduk.Controls.Add(dgvProduk, 0, 1);
            tlpProduk.Dock = DockStyle.Fill;
            tlpProduk.Location = new Point(23, 55);
            tlpProduk.Margin = new Padding(0);
            tlpProduk.Name = "tlpProduk";
            tlpProduk.RowCount = 2;
            tlpProduk.RowStyles.Add(new RowStyle(SizeType.Absolute, 67F));
            tlpProduk.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpProduk.Size = new Size(637, 719);
            tlpProduk.TabIndex = 0;
            // 
            // tlpInput
            // 
            tlpInput.ColumnCount = 5;
            tlpInput.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22F));
            tlpInput.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tlpInput.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22F));
            tlpInput.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tlpInput.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 54F));
            tlpInput.Controls.Add(lblKode, 0, 0);
            tlpInput.Controls.Add(lblNama, 1, 0);
            tlpInput.Controls.Add(lblKategori, 2, 0);
            tlpInput.Controls.Add(lblJumlah, 3, 0);
            tlpInput.Controls.Add(txtKode, 0, 1);
            tlpInput.Controls.Add(txtNama, 1, 1);
            tlpInput.Controls.Add(cmbKategori, 2, 1);
            tlpInput.Controls.Add(nudJumlah, 3, 1);
            tlpInput.Controls.Add(btnTambah, 4, 1);
            tlpInput.Dock = DockStyle.Fill;
            tlpInput.Location = new Point(0, 0);
            tlpInput.Margin = new Padding(0);
            tlpInput.Name = "tlpInput";
            tlpInput.RowCount = 2;
            tlpInput.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tlpInput.RowStyles.Add(new RowStyle(SizeType.Absolute, 39F));
            tlpInput.Size = new Size(637, 67);
            tlpInput.TabIndex = 0;
            // 
            // lblKode
            // 
            lblKode.BackColor = Color.Transparent;
            lblKode.Dock = DockStyle.Fill;
            lblKode.Font = new Font("Segoe UI", 9F);
            lblKode.ForeColor = Color.FromArgb(90, 110, 140);
            lblKode.Location = new Point(0, 0);
            lblKode.Margin = new Padding(0);
            lblKode.Name = "lblKode";
            lblKode.Size = new Size(143, 25);
            lblKode.TabIndex = 0;
            lblKode.Text = "Kode barang";
            lblKode.TextAlign = ContentAlignment.BottomLeft;
            // 
            // lblNama
            // 
            lblNama.BackColor = Color.Transparent;
            lblNama.Dock = DockStyle.Fill;
            lblNama.Font = new Font("Segoe UI", 9F);
            lblNama.ForeColor = Color.FromArgb(90, 110, 140);
            lblNama.Location = new Point(143, 0);
            lblNama.Margin = new Padding(0);
            lblNama.Name = "lblNama";
            lblNama.Size = new Size(195, 25);
            lblNama.TabIndex = 1;
            lblNama.Text = "Nama barang";
            lblNama.TextAlign = ContentAlignment.BottomLeft;
            // 
            // lblKategori
            // 
            lblKategori.BackColor = Color.Transparent;
            lblKategori.Dock = DockStyle.Fill;
            lblKategori.Font = new Font("Segoe UI", 9F);
            lblKategori.ForeColor = Color.FromArgb(90, 110, 140);
            lblKategori.Location = new Point(338, 0);
            lblKategori.Margin = new Padding(0);
            lblKategori.Name = "lblKategori";
            lblKategori.Size = new Size(143, 25);
            lblKategori.TabIndex = 2;
            lblKategori.Text = "Kategori";
            lblKategori.TextAlign = ContentAlignment.BottomLeft;
            // 
            // lblJumlah
            // 
            lblJumlah.BackColor = Color.Transparent;
            lblJumlah.Dock = DockStyle.Fill;
            lblJumlah.Font = new Font("Segoe UI", 9F);
            lblJumlah.ForeColor = Color.FromArgb(90, 110, 140);
            lblJumlah.Location = new Point(481, 0);
            lblJumlah.Margin = new Padding(0);
            lblJumlah.Name = "lblJumlah";
            lblJumlah.Size = new Size(100, 25);
            lblJumlah.TabIndex = 3;
            lblJumlah.Text = "Jumlah";
            lblJumlah.TextAlign = ContentAlignment.BottomLeft;
            // 
            // txtKode
            // 
            txtKode.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtKode.Font = new Font("Segoe UI", 10F);
            txtKode.Location = new Point(0, 25);
            txtKode.Margin = new Padding(0, 0, 9, 0);
            txtKode.Name = "txtKode";
            txtKode.PlaceholderText = "Scan / ketik kode";
            txtKode.Size = new Size(134, 25);
            txtKode.TabIndex = 4;
            // 
            // txtNama
            // 
            txtNama.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtNama.Font = new Font("Segoe UI", 10F);
            txtNama.Location = new Point(143, 25);
            txtNama.Margin = new Padding(0, 0, 9, 0);
            txtNama.Name = "txtNama";
            txtNama.PlaceholderText = "Cari nama";
            txtNama.Size = new Size(186, 25);
            txtNama.TabIndex = 5;
            // 
            // cmbKategori
            // 
            cmbKategori.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cmbKategori.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbKategori.Font = new Font("Segoe UI", 10F);
            cmbKategori.FormattingEnabled = true;
            cmbKategori.Location = new Point(338, 25);
            cmbKategori.Margin = new Padding(0, 0, 9, 0);
            cmbKategori.Name = "cmbKategori";
            cmbKategori.Size = new Size(134, 25);
            cmbKategori.TabIndex = 6;
            // 
            // nudJumlah
            // 
            nudJumlah.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            nudJumlah.Font = new Font("Segoe UI", 10F);
            nudJumlah.Location = new Point(481, 25);
            nudJumlah.Margin = new Padding(0, 0, 9, 0);
            nudJumlah.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            nudJumlah.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudJumlah.Name = "nudJumlah";
            nudJumlah.Size = new Size(91, 25);
            nudJumlah.TabIndex = 7;
            nudJumlah.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnTambah
            // 
            btnTambah.BackColor = Color.FromArgb(30, 136, 229);
            btnTambah.BorderColor = Color.Transparent;
            btnTambah.FlatStyle = FlatStyle.Flat;
            btnTambah.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnTambah.ForeColor = Color.White;
            btnTambah.HoverColor = Color.FromArgb(21, 101, 192);
            btnTambah.Location = new Point(581, 25);
            btnTambah.Margin = new Padding(0);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(51, 35);
            btnTambah.TabIndex = 8;
            btnTambah.Text = "+";
            btnTambah.UseVisualStyleBackColor = false;
            // 
            // dgvProduk
            // 
            dgvProduk.Columns.AddRange(new DataGridViewColumn[] { colNo, colKode, colNama, colHarga, colKategori, colStok });
            dgvProduk.Dock = DockStyle.Fill;
            dgvProduk.Location = new Point(0, 67);
            dgvProduk.Margin = new Padding(0);
            dgvProduk.Name = "dgvProduk";
            dgvProduk.Size = new Size(637, 652);
            dgvProduk.TabIndex = 1;
            // 
            // colNo
            // 
            colNo.FillWeight = 6F;
            colNo.HeaderText = "No";
            colNo.Name = "colNo";
            // 
            // colKode
            // 
            colKode.FillWeight = 14F;
            colKode.HeaderText = "Kode Barang";
            colKode.Name = "colKode";
            // 
            // colNama
            // 
            colNama.FillWeight = 30F;
            colNama.HeaderText = "Nama Barang";
            colNama.Name = "colNama";
            // 
            // colHarga
            // 
            colHarga.FillWeight = 16F;
            colHarga.HeaderText = "Harga";
            colHarga.Name = "colHarga";
            // 
            // colKategori
            // 
            colKategori.FillWeight = 18F;
            colKategori.HeaderText = "Kategori";
            colKategori.Name = "colKategori";
            // 
            // colStok
            // 
            colStok.FillWeight = 10F;
            colStok.HeaderText = "Stok";
            colStok.Name = "colStok";
            // 
            // lblProdukJudul
            // 
            lblProdukJudul.BackColor = Color.Transparent;
            lblProdukJudul.Dock = DockStyle.Top;
            lblProdukJudul.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblProdukJudul.ForeColor = Color.FromArgb(13, 47, 110);
            lblProdukJudul.Location = new Point(23, 16);
            lblProdukJudul.Margin = new Padding(4, 0, 4, 0);
            lblProdukJudul.Name = "lblProdukJudul";
            lblProdukJudul.Size = new Size(637, 39);
            lblProdukJudul.TabIndex = 1;
            lblProdukJudul.Text = "Daftar Barang";
            lblProdukJudul.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlKeranjang
            // 
            pnlKeranjang.AccentColor = Color.Transparent;
            pnlKeranjang.BackColor = Color.White;
            pnlKeranjang.BorderColor = Color.FromArgb(214, 228, 245);
            pnlKeranjang.Controls.Add(tlpKeranjang);
            pnlKeranjang.Controls.Add(lblKeranjangJudul);
            pnlKeranjang.Dock = DockStyle.Fill;
            pnlKeranjang.Location = new Point(697, 0);
            pnlKeranjang.Margin = new Padding(0);
            pnlKeranjang.Name = "pnlKeranjang";
            pnlKeranjang.Padding = new Padding(23, 16, 23, 18);
            pnlKeranjang.Radius = 18;
            pnlKeranjang.Size = new Size(548, 792);
            pnlKeranjang.TabIndex = 1;
            // 
            // tlpKeranjang
            // 
            tlpKeranjang.ColumnCount = 1;
            tlpKeranjang.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpKeranjang.Controls.Add(dgvKeranjang, 0, 0);
            tlpKeranjang.Controls.Add(flowQty, 0, 1);
            tlpKeranjang.Controls.Add(tlpTotal, 0, 2);
            tlpKeranjang.Controls.Add(flowBayar, 0, 3);
            tlpKeranjang.Dock = DockStyle.Fill;
            tlpKeranjang.Location = new Point(23, 55);
            tlpKeranjang.Margin = new Padding(0);
            tlpKeranjang.Name = "tlpKeranjang";
            tlpKeranjang.RowCount = 4;
            tlpKeranjang.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpKeranjang.RowStyles.Add(new RowStyle(SizeType.Absolute, 51F));
            tlpKeranjang.RowStyles.Add(new RowStyle(SizeType.Absolute, 275F));
            tlpKeranjang.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tlpKeranjang.Size = new Size(502, 719);
            tlpKeranjang.TabIndex = 0;
            // 
            // dgvKeranjang
            // 
            dgvKeranjang.Columns.AddRange(new DataGridViewColumn[] { colKKode, colKNama, colKQty, colKHarga, colKSubtotal });
            dgvKeranjang.Dock = DockStyle.Fill;
            dgvKeranjang.Location = new Point(0, 0);
            dgvKeranjang.Margin = new Padding(0);
            dgvKeranjang.Name = "dgvKeranjang";
            dgvKeranjang.Size = new Size(502, 333);
            dgvKeranjang.TabIndex = 0;
            // 
            // colKKode
            // 
            colKKode.FillWeight = 16F;
            colKKode.HeaderText = "Kode";
            colKKode.Name = "colKKode";
            // 
            // colKNama
            // 
            colKNama.FillWeight = 32F;
            colKNama.HeaderText = "Nama Barang";
            colKNama.Name = "colKNama";
            // 
            // colKQty
            // 
            colKQty.FillWeight = 12F;
            colKQty.HeaderText = "Jumlah";
            colKQty.Name = "colKQty";
            // 
            // colKHarga
            // 
            colKHarga.FillWeight = 20F;
            colKHarga.HeaderText = "Harga";
            colKHarga.Name = "colKHarga";
            // 
            // colKSubtotal
            // 
            colKSubtotal.FillWeight = 20F;
            colKSubtotal.HeaderText = "Subtotal";
            colKSubtotal.Name = "colKSubtotal";
            // 
            // flowQty
            // 
            flowQty.BackColor = Color.White;
            flowQty.Controls.Add(btnKurang);
            flowQty.Controls.Add(btnTambahQty);
            flowQty.Controls.Add(btnHapusItem);
            flowQty.Dock = DockStyle.Fill;
            flowQty.Location = new Point(0, 333);
            flowQty.Margin = new Padding(0);
            flowQty.Name = "flowQty";
            flowQty.Padding = new Padding(0, 7, 0, 0);
            flowQty.Size = new Size(502, 51);
            flowQty.TabIndex = 1;
            flowQty.WrapContents = false;
            // 
            // btnKurang
            // 
            btnKurang.BackColor = Color.White;
            btnKurang.BorderColor = Color.FromArgb(30, 136, 229);
            btnKurang.FlatStyle = FlatStyle.Flat;
            btnKurang.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnKurang.ForeColor = Color.FromArgb(30, 136, 229);
            btnKurang.HoverColor = Color.FromArgb(225, 240, 255);
            btnKurang.Location = new Point(0, 7);
            btnKurang.Margin = new Padding(0, 0, 9, 0);
            btnKurang.Name = "btnKurang";
            btnKurang.Size = new Size(51, 37);
            btnKurang.TabIndex = 0;
            btnKurang.Text = "-";
            btnKurang.UseVisualStyleBackColor = false;
            // 
            // btnTambahQty
            // 
            btnTambahQty.BackColor = Color.White;
            btnTambahQty.BorderColor = Color.FromArgb(30, 136, 229);
            btnTambahQty.FlatStyle = FlatStyle.Flat;
            btnTambahQty.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnTambahQty.ForeColor = Color.FromArgb(30, 136, 229);
            btnTambahQty.HoverColor = Color.FromArgb(225, 240, 255);
            btnTambahQty.Location = new Point(60, 7);
            btnTambahQty.Margin = new Padding(0, 0, 9, 0);
            btnTambahQty.Name = "btnTambahQty";
            btnTambahQty.Size = new Size(51, 37);
            btnTambahQty.TabIndex = 1;
            btnTambahQty.Text = "+";
            btnTambahQty.UseVisualStyleBackColor = false;
            // 
            // btnHapusItem
            // 
            btnHapusItem.BackColor = Color.White;
            btnHapusItem.BorderColor = Color.FromArgb(214, 69, 65);
            btnHapusItem.FlatStyle = FlatStyle.Flat;
            btnHapusItem.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            btnHapusItem.ForeColor = Color.FromArgb(214, 69, 65);
            btnHapusItem.HoverColor = Color.FromArgb(253, 236, 235);
            btnHapusItem.Location = new Point(120, 7);
            btnHapusItem.Margin = new Padding(0);
            btnHapusItem.Name = "btnHapusItem";
            btnHapusItem.Size = new Size(128, 37);
            btnHapusItem.TabIndex = 2;
            btnHapusItem.Text = "Hapus Item";
            btnHapusItem.UseVisualStyleBackColor = false;
            // 
            // tlpTotal
            // 
            tlpTotal.ColumnCount = 2;
            tlpTotal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            tlpTotal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55F));
            tlpTotal.Controls.Add(lblSubtotalJudul, 0, 0);
            tlpTotal.Controls.Add(lblSubtotalNilai, 1, 0);
            tlpTotal.Controls.Add(lblDiskonJudul, 0, 1);
            tlpTotal.Controls.Add(txtDiskon, 1, 1);
            tlpTotal.Controls.Add(lblTotalJudul, 0, 2);
            tlpTotal.Controls.Add(lblTotalNilai, 1, 2);
            tlpTotal.Controls.Add(lblMetodeJudul, 0, 3);
            tlpTotal.Controls.Add(cmbMetode, 1, 3);
            tlpTotal.Controls.Add(lblBayarJudul, 0, 4);
            tlpTotal.Controls.Add(txtBayar, 1, 4);
            tlpTotal.Controls.Add(flowUang, 0, 5);
            tlpTotal.Controls.Add(lblKembaliJudul, 0, 6);
            tlpTotal.Controls.Add(lblKembaliNilai, 1, 6);
            tlpTotal.Dock = DockStyle.Fill;
            tlpTotal.Location = new Point(0, 384);
            tlpTotal.Margin = new Padding(0);
            tlpTotal.Name = "tlpTotal";
            tlpTotal.RowCount = 7;
            tlpTotal.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tlpTotal.RowStyles.Add(new RowStyle(SizeType.Absolute, 39F));
            tlpTotal.RowStyles.Add(new RowStyle(SizeType.Absolute, 46F));
            tlpTotal.RowStyles.Add(new RowStyle(SizeType.Absolute, 39F));
            tlpTotal.RowStyles.Add(new RowStyle(SizeType.Absolute, 39F));
            tlpTotal.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            tlpTotal.RowStyles.Add(new RowStyle(SizeType.Absolute, 37F));
            tlpTotal.Size = new Size(502, 275);
            tlpTotal.TabIndex = 2;
            // 
            // lblSubtotalJudul
            // 
            lblSubtotalJudul.BackColor = Color.Transparent;
            lblSubtotalJudul.Dock = DockStyle.Fill;
            lblSubtotalJudul.Font = new Font("Segoe UI", 10F);
            lblSubtotalJudul.ForeColor = Color.FromArgb(90, 110, 140);
            lblSubtotalJudul.Location = new Point(0, 0);
            lblSubtotalJudul.Margin = new Padding(0);
            lblSubtotalJudul.Name = "lblSubtotalJudul";
            lblSubtotalJudul.Size = new Size(225, 30);
            lblSubtotalJudul.TabIndex = 0;
            lblSubtotalJudul.Text = "Subtotal";
            lblSubtotalJudul.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblSubtotalNilai
            // 
            lblSubtotalNilai.BackColor = Color.Transparent;
            lblSubtotalNilai.Dock = DockStyle.Fill;
            lblSubtotalNilai.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblSubtotalNilai.ForeColor = Color.FromArgb(13, 47, 110);
            lblSubtotalNilai.Location = new Point(225, 0);
            lblSubtotalNilai.Margin = new Padding(0);
            lblSubtotalNilai.Name = "lblSubtotalNilai";
            lblSubtotalNilai.Size = new Size(277, 30);
            lblSubtotalNilai.TabIndex = 1;
            lblSubtotalNilai.Text = "Rp 0";
            lblSubtotalNilai.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblDiskonJudul
            // 
            lblDiskonJudul.BackColor = Color.Transparent;
            lblDiskonJudul.Dock = DockStyle.Fill;
            lblDiskonJudul.Font = new Font("Segoe UI", 10F);
            lblDiskonJudul.ForeColor = Color.FromArgb(90, 110, 140);
            lblDiskonJudul.Location = new Point(0, 30);
            lblDiskonJudul.Margin = new Padding(0);
            lblDiskonJudul.Name = "lblDiskonJudul";
            lblDiskonJudul.Size = new Size(225, 39);
            lblDiskonJudul.TabIndex = 2;
            lblDiskonJudul.Text = "Diskon (Rp atau %)";
            lblDiskonJudul.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtDiskon
            // 
            txtDiskon.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtDiskon.Font = new Font("Segoe UI", 10F);
            txtDiskon.Location = new Point(225, 37);
            txtDiskon.Margin = new Padding(0);
            txtDiskon.Name = "txtDiskon";
            txtDiskon.PlaceholderText = "5000 atau 10%";
            txtDiskon.Size = new Size(277, 25);
            txtDiskon.TabIndex = 3;
            txtDiskon.TextAlign = HorizontalAlignment.Right;
            // 
            // lblTotalJudul
            // 
            lblTotalJudul.BackColor = Color.Transparent;
            lblTotalJudul.Dock = DockStyle.Fill;
            lblTotalJudul.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold);
            lblTotalJudul.ForeColor = Color.FromArgb(13, 47, 110);
            lblTotalJudul.Location = new Point(0, 69);
            lblTotalJudul.Margin = new Padding(0);
            lblTotalJudul.Name = "lblTotalJudul";
            lblTotalJudul.Size = new Size(225, 46);
            lblTotalJudul.TabIndex = 4;
            lblTotalJudul.Text = "Total Belanja";
            lblTotalJudul.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTotalNilai
            // 
            lblTotalNilai.BackColor = Color.Transparent;
            lblTotalNilai.Dock = DockStyle.Fill;
            lblTotalNilai.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            lblTotalNilai.ForeColor = Color.FromArgb(30, 136, 229);
            lblTotalNilai.Location = new Point(225, 69);
            lblTotalNilai.Margin = new Padding(0);
            lblTotalNilai.Name = "lblTotalNilai";
            lblTotalNilai.Size = new Size(277, 46);
            lblTotalNilai.TabIndex = 5;
            lblTotalNilai.Text = "Rp 0";
            lblTotalNilai.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblMetodeJudul
            // 
            lblMetodeJudul.BackColor = Color.Transparent;
            lblMetodeJudul.Dock = DockStyle.Fill;
            lblMetodeJudul.Font = new Font("Segoe UI", 10F);
            lblMetodeJudul.ForeColor = Color.FromArgb(90, 110, 140);
            lblMetodeJudul.Location = new Point(0, 115);
            lblMetodeJudul.Margin = new Padding(0);
            lblMetodeJudul.Name = "lblMetodeJudul";
            lblMetodeJudul.Size = new Size(225, 39);
            lblMetodeJudul.TabIndex = 6;
            lblMetodeJudul.Text = "Metode bayar";
            lblMetodeJudul.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cmbMetode
            // 
            cmbMetode.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cmbMetode.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMetode.Font = new Font("Segoe UI", 10F);
            cmbMetode.FormattingEnabled = true;
            cmbMetode.Items.AddRange(new object[] { "Tunai", "QRIS", "Transfer" });
            cmbMetode.Location = new Point(225, 121);
            cmbMetode.Margin = new Padding(0);
            cmbMetode.Name = "cmbMetode";
            cmbMetode.Size = new Size(277, 25);
            cmbMetode.TabIndex = 7;
            // 
            // lblBayarJudul
            // 
            lblBayarJudul.BackColor = Color.Transparent;
            lblBayarJudul.Dock = DockStyle.Fill;
            lblBayarJudul.Font = new Font("Segoe UI", 10F);
            lblBayarJudul.ForeColor = Color.FromArgb(90, 110, 140);
            lblBayarJudul.Location = new Point(0, 154);
            lblBayarJudul.Margin = new Padding(0);
            lblBayarJudul.Name = "lblBayarJudul";
            lblBayarJudul.Size = new Size(225, 39);
            lblBayarJudul.TabIndex = 8;
            lblBayarJudul.Text = "Uang diterima";
            lblBayarJudul.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtBayar
            // 
            txtBayar.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtBayar.Font = new Font("Segoe UI", 11F);
            txtBayar.Location = new Point(225, 160);
            txtBayar.Margin = new Padding(0);
            txtBayar.Name = "txtBayar";
            txtBayar.Size = new Size(277, 27);
            txtBayar.TabIndex = 9;
            txtBayar.TextAlign = HorizontalAlignment.Right;
            // 
            // flowUang
            // 
            flowUang.BackColor = Color.White;
            tlpTotal.SetColumnSpan(flowUang, 2);
            flowUang.Controls.Add(btnPas);
            flowUang.Controls.Add(btnUang50);
            flowUang.Controls.Add(btnUang100);
            flowUang.Dock = DockStyle.Fill;
            flowUang.Location = new Point(0, 193);
            flowUang.Margin = new Padding(0);
            flowUang.Name = "flowUang";
            flowUang.Padding = new Padding(0, 7, 0, 0);
            flowUang.Size = new Size(502, 44);
            flowUang.TabIndex = 10;
            flowUang.WrapContents = false;
            // 
            // btnPas
            // 
            btnPas.BackColor = Color.White;
            btnPas.BorderColor = Color.FromArgb(30, 136, 229);
            btnPas.FlatStyle = FlatStyle.Flat;
            btnPas.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            btnPas.ForeColor = Color.FromArgb(30, 136, 229);
            btnPas.HoverColor = Color.FromArgb(225, 240, 255);
            btnPas.Location = new Point(0, 7);
            btnPas.Margin = new Padding(0, 0, 7, 0);
            btnPas.Name = "btnPas";
            btnPas.Size = new Size(105, 32);
            btnPas.TabIndex = 0;
            btnPas.Text = "Uang Pas";
            btnPas.UseVisualStyleBackColor = false;
            // 
            // btnUang50
            // 
            btnUang50.BackColor = Color.White;
            btnUang50.BorderColor = Color.FromArgb(30, 136, 229);
            btnUang50.FlatStyle = FlatStyle.Flat;
            btnUang50.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            btnUang50.ForeColor = Color.FromArgb(30, 136, 229);
            btnUang50.HoverColor = Color.FromArgb(225, 240, 255);
            btnUang50.Location = new Point(112, 7);
            btnUang50.Margin = new Padding(0, 0, 7, 0);
            btnUang50.Name = "btnUang50";
            btnUang50.Size = new Size(82, 32);
            btnUang50.TabIndex = 1;
            btnUang50.Text = "50.000";
            btnUang50.UseVisualStyleBackColor = false;
            // 
            // btnUang100
            // 
            btnUang100.BackColor = Color.White;
            btnUang100.BorderColor = Color.FromArgb(30, 136, 229);
            btnUang100.FlatStyle = FlatStyle.Flat;
            btnUang100.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            btnUang100.ForeColor = Color.FromArgb(30, 136, 229);
            btnUang100.HoverColor = Color.FromArgb(225, 240, 255);
            btnUang100.Location = new Point(201, 7);
            btnUang100.Margin = new Padding(0);
            btnUang100.Name = "btnUang100";
            btnUang100.Size = new Size(93, 32);
            btnUang100.TabIndex = 2;
            btnUang100.Text = "100.000";
            btnUang100.UseVisualStyleBackColor = false;
            // 
            // lblKembaliJudul
            // 
            lblKembaliJudul.BackColor = Color.Transparent;
            lblKembaliJudul.Dock = DockStyle.Fill;
            lblKembaliJudul.Font = new Font("Segoe UI", 10F);
            lblKembaliJudul.ForeColor = Color.FromArgb(90, 110, 140);
            lblKembaliJudul.Location = new Point(0, 237);
            lblKembaliJudul.Margin = new Padding(0);
            lblKembaliJudul.Name = "lblKembaliJudul";
            lblKembaliJudul.Size = new Size(225, 38);
            lblKembaliJudul.TabIndex = 11;
            lblKembaliJudul.Text = "Kembalian";
            lblKembaliJudul.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblKembaliNilai
            // 
            lblKembaliNilai.BackColor = Color.Transparent;
            lblKembaliNilai.Dock = DockStyle.Fill;
            lblKembaliNilai.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblKembaliNilai.ForeColor = Color.FromArgb(40, 140, 90);
            lblKembaliNilai.Location = new Point(225, 237);
            lblKembaliNilai.Margin = new Padding(0);
            lblKembaliNilai.Name = "lblKembaliNilai";
            lblKembaliNilai.Size = new Size(277, 38);
            lblKembaliNilai.TabIndex = 12;
            lblKembaliNilai.Text = "Rp 0";
            lblKembaliNilai.TextAlign = ContentAlignment.MiddleRight;
            // 
            // flowBayar
            // 
            flowBayar.BackColor = Color.White;
            flowBayar.Controls.Add(btnBayar);
            flowBayar.Controls.Add(btnBatal);
            flowBayar.Dock = DockStyle.Fill;
            flowBayar.Location = new Point(0, 659);
            flowBayar.Margin = new Padding(0);
            flowBayar.Name = "flowBayar";
            flowBayar.Padding = new Padding(0, 7, 0, 0);
            flowBayar.Size = new Size(502, 60);
            flowBayar.TabIndex = 3;
            flowBayar.WrapContents = false;
            // 
            // btnBayar
            // 
            btnBayar.BackColor = Color.FromArgb(46, 160, 100);
            btnBayar.BorderColor = Color.Transparent;
            btnBayar.FlatStyle = FlatStyle.Flat;
            btnBayar.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            btnBayar.ForeColor = Color.White;
            btnBayar.HoverColor = Color.FromArgb(32, 128, 78);
            btnBayar.Location = new Point(0, 7);
            btnBayar.Margin = new Padding(0, 0, 12, 0);
            btnBayar.Name = "btnBayar";
            btnBayar.Size = new Size(222, 48);
            btnBayar.TabIndex = 0;
            btnBayar.Text = "Bayar";
            btnBayar.UseVisualStyleBackColor = false;
            // 
            // btnBatal
            // 
            btnBatal.BackColor = Color.White;
            btnBatal.BorderColor = Color.FromArgb(30, 136, 229);
            btnBatal.FlatStyle = FlatStyle.Flat;
            btnBatal.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            btnBatal.ForeColor = Color.FromArgb(30, 136, 229);
            btnBatal.HoverColor = Color.FromArgb(225, 240, 255);
            btnBatal.Location = new Point(234, 7);
            btnBatal.Margin = new Padding(0);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(117, 48);
            btnBatal.TabIndex = 1;
            btnBatal.Text = "Batal";
            btnBatal.UseVisualStyleBackColor = false;
            // 
            // lblKeranjangJudul
            // 
            lblKeranjangJudul.BackColor = Color.Transparent;
            lblKeranjangJudul.Dock = DockStyle.Top;
            lblKeranjangJudul.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblKeranjangJudul.ForeColor = Color.FromArgb(13, 47, 110);
            lblKeranjangJudul.Location = new Point(23, 16);
            lblKeranjangJudul.Margin = new Padding(4, 0, 4, 0);
            lblKeranjangJudul.Name = "lblKeranjangJudul";
            lblKeranjangJudul.Size = new Size(502, 39);
            lblKeranjangJudul.TabIndex = 1;
            lblKeranjangJudul.Text = "Keranjang";
            lblKeranjangJudul.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // UC_KRNJGBLNJKasir
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(234, 243, 252);
            Controls.Add(tlpRoot);
            Margin = new Padding(4, 3, 4, 3);
            Name = "UC_KRNJGBLNJKasir";
            Size = new Size(1283, 923);
            tlpRoot.ResumeLayout(false);
            pnlJudul.ResumeLayout(false);
            pnlJudul.PerformLayout();
            tlpContent.ResumeLayout(false);
            pnlProduk.ResumeLayout(false);
            tlpProduk.ResumeLayout(false);
            tlpInput.ResumeLayout(false);
            tlpInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudJumlah).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProduk).EndInit();
            pnlKeranjang.ResumeLayout(false);
            tlpKeranjang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvKeranjang).EndInit();
            flowQty.ResumeLayout(false);
            tlpTotal.ResumeLayout(false);
            tlpTotal.PerformLayout();
            flowUang.ResumeLayout(false);
            flowBayar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpRoot;
        private RoundedPanelUI pnlJudul;
        private RoundedButtonUI btnHapusSemua;
        private System.Windows.Forms.Label lblSub;
        private System.Windows.Forms.Label lblJudul;
        private System.Windows.Forms.TableLayoutPanel tlpContent;
        private RoundedPanelUI pnlProduk;
        private System.Windows.Forms.TableLayoutPanel tlpProduk;
        private System.Windows.Forms.TableLayoutPanel tlpInput;
        private System.Windows.Forms.Label lblKode;
        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.Label lblKategori;
        private System.Windows.Forms.Label lblJumlah;
        private System.Windows.Forms.TextBox txtKode;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.ComboBox cmbKategori;
        private System.Windows.Forms.NumericUpDown nudJumlah;
        private RoundedButtonUI btnTambah;
        private System.Windows.Forms.DataGridView dgvProduk;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNama;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHarga;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKategori;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStok;
        private System.Windows.Forms.Label lblProdukJudul;
        private RoundedPanelUI pnlKeranjang;
        private System.Windows.Forms.TableLayoutPanel tlpKeranjang;
        private System.Windows.Forms.DataGridView dgvKeranjang;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKKode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKNama;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKHarga;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKSubtotal;
        private System.Windows.Forms.FlowLayoutPanel flowQty;
        private RoundedButtonUI btnKurang;
        private RoundedButtonUI btnTambahQty;
        private RoundedButtonUI btnHapusItem;
        private System.Windows.Forms.TableLayoutPanel tlpTotal;
        private System.Windows.Forms.Label lblSubtotalJudul;
        private System.Windows.Forms.Label lblSubtotalNilai;
        private System.Windows.Forms.Label lblDiskonJudul;
        private System.Windows.Forms.TextBox txtDiskon;
        private System.Windows.Forms.Label lblTotalJudul;
        private System.Windows.Forms.Label lblTotalNilai;
        private System.Windows.Forms.Label lblMetodeJudul;
        private System.Windows.Forms.ComboBox cmbMetode;
        private System.Windows.Forms.Label lblBayarJudul;
        private System.Windows.Forms.TextBox txtBayar;
        private System.Windows.Forms.FlowLayoutPanel flowUang;
        private RoundedButtonUI btnPas;
        private RoundedButtonUI btnUang50;
        private RoundedButtonUI btnUang100;
        private System.Windows.Forms.Label lblKembaliJudul;
        private System.Windows.Forms.Label lblKembaliNilai;
        private System.Windows.Forms.FlowLayoutPanel flowBayar;
        private RoundedButtonUI btnBayar;
        private RoundedButtonUI btnBatal;
        private System.Windows.Forms.Label lblKeranjangJudul;
    }
}