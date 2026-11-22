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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
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
            tlpRoot.Padding = new Padding(27, 30, 27, 30);
            tlpRoot.RowCount = 2;
            tlpRoot.RowStyles.Add(new RowStyle(SizeType.Absolute, 115F));
            tlpRoot.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpRoot.Size = new Size(1833, 1538);
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
            pnlJudul.Location = new Point(27, 30);
            pnlJudul.Margin = new Padding(0, 0, 0, 23);
            pnlJudul.Name = "pnlJudul";
            pnlJudul.Radius = 18;
            pnlJudul.Size = new Size(1779, 92);
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
            btnHapusSemua.Location = new Point(1511, 15);
            btnHapusSemua.Margin = new Padding(6, 5, 6, 5);
            btnHapusSemua.Name = "btnHapusSemua";
            btnHapusSemua.Size = new Size(217, 61);
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
            lblSub.Location = new Point(37, 60);
            lblSub.Margin = new Padding(6, 0, 6, 0);
            lblSub.Name = "lblSub";
            lblSub.Size = new Size(541, 25);
            lblSub.TabIndex = 1;
            lblSub.Text = "Cari barang, tambahkan ke keranjang, lalu proses pembayaran.";
            // 
            // lblJudul
            // 
            lblJudul.AutoSize = true;
            lblJudul.BackColor = Color.Transparent;
            lblJudul.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            lblJudul.ForeColor = Color.FromArgb(13, 47, 110);
            lblJudul.Location = new Point(37, 15);
            lblJudul.Margin = new Padding(6, 0, 6, 0);
            lblJudul.Name = "lblJudul";
            lblJudul.Size = new Size(282, 45);
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
            tlpContent.Location = new Point(27, 145);
            tlpContent.Margin = new Padding(0);
            tlpContent.Name = "tlpContent";
            tlpContent.RowCount = 1;
            tlpContent.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpContent.Size = new Size(1779, 1363);
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
            pnlProduk.Margin = new Padding(0, 0, 20, 0);
            pnlProduk.Name = "pnlProduk";
            pnlProduk.Padding = new Padding(33, 27, 33, 30);
            pnlProduk.Radius = 18;
            pnlProduk.Size = new Size(976, 1363);
            pnlProduk.TabIndex = 0;
            // 
            // tlpProduk
            // 
            tlpProduk.ColumnCount = 1;
            tlpProduk.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpProduk.Controls.Add(tlpInput, 0, 0);
            tlpProduk.Controls.Add(dgvProduk, 0, 1);
            tlpProduk.Dock = DockStyle.Fill;
            tlpProduk.Location = new Point(33, 92);
            tlpProduk.Margin = new Padding(0);
            tlpProduk.Name = "tlpProduk";
            tlpProduk.RowCount = 2;
            tlpProduk.RowStyles.Add(new RowStyle(SizeType.Absolute, 112F));
            tlpProduk.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpProduk.Size = new Size(910, 1241);
            tlpProduk.TabIndex = 0;
            // 
            // tlpInput
            // 
            tlpInput.ColumnCount = 5;
            tlpInput.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22F));
            tlpInput.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tlpInput.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22F));
            tlpInput.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 143F));
            tlpInput.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
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
            tlpInput.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
            tlpInput.RowStyles.Add(new RowStyle(SizeType.Absolute, 65F));
            tlpInput.Size = new Size(910, 112);
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
            lblKode.Size = new Size(204, 42);
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
            lblNama.Location = new Point(204, 0);
            lblNama.Margin = new Padding(0);
            lblNama.Name = "lblNama";
            lblNama.Size = new Size(278, 42);
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
            lblKategori.Location = new Point(482, 0);
            lblKategori.Margin = new Padding(0);
            lblKategori.Name = "lblKategori";
            lblKategori.Size = new Size(204, 42);
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
            lblJumlah.Location = new Point(686, 0);
            lblJumlah.Margin = new Padding(0);
            lblJumlah.Name = "lblJumlah";
            lblJumlah.Size = new Size(143, 42);
            lblJumlah.TabIndex = 3;
            lblJumlah.Text = "Jumlah";
            lblJumlah.TextAlign = ContentAlignment.BottomLeft;
            // 
            // txtKode
            // 
            txtKode.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtKode.Font = new Font("Segoe UI", 10F);
            txtKode.Location = new Point(0, 42);
            txtKode.Margin = new Padding(0, 0, 13, 0);
            txtKode.Name = "txtKode";
            txtKode.PlaceholderText = "Scan / ketik kode";
            txtKode.Size = new Size(191, 34);
            txtKode.TabIndex = 4;
            // 
            // txtNama
            // 
            txtNama.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtNama.Font = new Font("Segoe UI", 10F);
            txtNama.Location = new Point(204, 42);
            txtNama.Margin = new Padding(0, 0, 13, 0);
            txtNama.Name = "txtNama";
            txtNama.PlaceholderText = "Cari nama";
            txtNama.Size = new Size(265, 34);
            txtNama.TabIndex = 5;
            // 
            // cmbKategori
            // 
            cmbKategori.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cmbKategori.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbKategori.Font = new Font("Segoe UI", 10F);
            cmbKategori.FormattingEnabled = true;
            cmbKategori.Location = new Point(482, 42);
            cmbKategori.Margin = new Padding(0, 0, 13, 0);
            cmbKategori.Name = "cmbKategori";
            cmbKategori.Size = new Size(191, 36);
            cmbKategori.TabIndex = 6;
            // 
            // nudJumlah
            // 
            nudJumlah.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            nudJumlah.Font = new Font("Segoe UI", 10F);
            nudJumlah.Location = new Point(686, 42);
            nudJumlah.Margin = new Padding(0, 0, 13, 0);
            nudJumlah.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            nudJumlah.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudJumlah.Name = "nudJumlah";
            nudJumlah.Size = new Size(130, 34);
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
            btnTambah.Location = new Point(829, 42);
            btnTambah.Margin = new Padding(0);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(73, 58);
            btnTambah.TabIndex = 8;
            btnTambah.Text = "+";
            btnTambah.UseVisualStyleBackColor = false;
            // 
            // dgvProduk
            // 
            dgvProduk.AllowUserToAddRows = false;
            dgvProduk.AllowUserToDeleteRows = false;
            dgvProduk.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProduk.BackgroundColor = Color.White;
            dgvProduk.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.RoyalBlue;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvProduk.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvProduk.ColumnHeadersHeight = 40;
            dgvProduk.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvProduk.Columns.AddRange(new DataGridViewColumn[] { colNo, colKode, colNama, colHarga, colKategori, colStok });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.AliceBlue;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.MidnightBlue;
            dataGridViewCellStyle2.SelectionBackColor = Color.LightSkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvProduk.DefaultCellStyle = dataGridViewCellStyle2;
            dgvProduk.Dock = DockStyle.Fill;
            dgvProduk.EnableHeadersVisualStyles = false;
            dgvProduk.Location = new Point(0, 112);
            dgvProduk.Margin = new Padding(0);
            dgvProduk.MultiSelect = false;
            dgvProduk.Name = "dgvProduk";
            dgvProduk.RowHeadersVisible = false;
            dgvProduk.RowHeadersWidth = 62;
            dgvProduk.Size = new Size(910, 1129);
            dgvProduk.TabIndex = 1;
            // 
            // colNo
            // 
            colNo.FillWeight = 6F;
            colNo.HeaderText = "No";
            colNo.MinimumWidth = 8;
            colNo.Name = "colNo";
            // 
            // colKode
            // 
            colKode.FillWeight = 14F;
            colKode.HeaderText = "Kode Barang";
            colKode.MinimumWidth = 8;
            colKode.Name = "colKode";
            // 
            // colNama
            // 
            colNama.FillWeight = 30F;
            colNama.HeaderText = "Nama Barang";
            colNama.MinimumWidth = 8;
            colNama.Name = "colNama";
            // 
            // colHarga
            // 
            colHarga.FillWeight = 16F;
            colHarga.HeaderText = "Harga";
            colHarga.MinimumWidth = 8;
            colHarga.Name = "colHarga";
            // 
            // colKategori
            // 
            colKategori.FillWeight = 18F;
            colKategori.HeaderText = "Kategori";
            colKategori.MinimumWidth = 8;
            colKategori.Name = "colKategori";
            // 
            // colStok
            // 
            colStok.FillWeight = 10F;
            colStok.HeaderText = "Stok";
            colStok.MinimumWidth = 8;
            colStok.Name = "colStok";
            // 
            // lblProdukJudul
            // 
            lblProdukJudul.BackColor = Color.Transparent;
            lblProdukJudul.Dock = DockStyle.Top;
            lblProdukJudul.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblProdukJudul.ForeColor = Color.FromArgb(13, 47, 110);
            lblProdukJudul.Location = new Point(33, 27);
            lblProdukJudul.Margin = new Padding(6, 0, 6, 0);
            lblProdukJudul.Name = "lblProdukJudul";
            lblProdukJudul.Size = new Size(910, 65);
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
            pnlKeranjang.Location = new Point(996, 0);
            pnlKeranjang.Margin = new Padding(0);
            pnlKeranjang.Name = "pnlKeranjang";
            pnlKeranjang.Padding = new Padding(33, 27, 33, 30);
            pnlKeranjang.Radius = 18;
            pnlKeranjang.Size = new Size(768, 1363);
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
            tlpKeranjang.Location = new Point(33, 60);
            tlpKeranjang.Margin = new Padding(0);
            tlpKeranjang.Name = "tlpKeranjang";
            tlpKeranjang.RowCount = 4;
            tlpKeranjang.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpKeranjang.RowStyles.Add(new RowStyle(SizeType.Absolute, 59F));
            tlpKeranjang.RowStyles.Add(new RowStyle(SizeType.Absolute, 390F));
            tlpKeranjang.RowStyles.Add(new RowStyle(SizeType.Absolute, 615F));
            tlpKeranjang.Size = new Size(657, 1158);
            tlpKeranjang.TabIndex = 0;
            // 
            // dgvKeranjang
            // 
            dgvKeranjang.AllowUserToAddRows = false;
            dgvKeranjang.AllowUserToDeleteRows = false;
            dgvKeranjang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKeranjang.BackgroundColor = Color.White;
            dgvKeranjang.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.AliceBlue;
            dataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.RoyalBlue;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvKeranjang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvKeranjang.ColumnHeadersHeight = 40;
            dgvKeranjang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvKeranjang.Columns.AddRange(new DataGridViewColumn[] { colKKode, colKNama, colKQty, colKHarga, colKSubtotal });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = Color.MidnightBlue;
            dataGridViewCellStyle4.SelectionBackColor = Color.LightBlue;
            dataGridViewCellStyle4.SelectionForeColor = Color.DarkSlateGray;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvKeranjang.DefaultCellStyle = dataGridViewCellStyle4;
            dgvKeranjang.EnableHeadersVisualStyles = false;
            dgvKeranjang.Location = new Point(0, 0);
            dgvKeranjang.Margin = new Padding(0);
            dgvKeranjang.MultiSelect = false;
            dgvKeranjang.Name = "dgvKeranjang";
            dgvKeranjang.RowHeadersVisible = false;
            dgvKeranjang.RowHeadersWidth = 62;
            dgvKeranjang.Size = new Size(657, 94);
            dgvKeranjang.TabIndex = 0;
            // 
            // colKKode
            // 
            colKKode.FillWeight = 16F;
            colKKode.HeaderText = "Kode";
            colKKode.MinimumWidth = 8;
            colKKode.Name = "colKKode";
            // 
            // colKNama
            // 
            colKNama.FillWeight = 32F;
            colKNama.HeaderText = "Nama Barang";
            colKNama.MinimumWidth = 8;
            colKNama.Name = "colKNama";
            // 
            // colKQty
            // 
            colKQty.FillWeight = 12F;
            colKQty.HeaderText = "Jumlah";
            colKQty.MinimumWidth = 8;
            colKQty.Name = "colKQty";
            // 
            // colKHarga
            // 
            colKHarga.FillWeight = 20F;
            colKHarga.HeaderText = "Harga";
            colKHarga.MinimumWidth = 8;
            colKHarga.Name = "colKHarga";
            // 
            // colKSubtotal
            // 
            colKSubtotal.FillWeight = 20F;
            colKSubtotal.HeaderText = "Subtotal";
            colKSubtotal.MinimumWidth = 8;
            colKSubtotal.Name = "colKSubtotal";
            // 
            // flowQty
            // 
            flowQty.BackColor = Color.White;
            flowQty.Controls.Add(btnKurang);
            flowQty.Controls.Add(btnTambahQty);
            flowQty.Controls.Add(btnHapusItem);
            flowQty.Location = new Point(0, 94);
            flowQty.Margin = new Padding(0);
            flowQty.Name = "flowQty";
            flowQty.Padding = new Padding(0, 12, 0, 0);
            flowQty.Size = new Size(657, 59);
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
            btnKurang.Location = new Point(0, 12);
            btnKurang.Margin = new Padding(0, 0, 13, 0);
            btnKurang.Name = "btnKurang";
            btnKurang.Size = new Size(73, 47);
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
            btnTambahQty.Location = new Point(86, 12);
            btnTambahQty.Margin = new Padding(0, 0, 13, 0);
            btnTambahQty.Name = "btnTambahQty";
            btnTambahQty.Size = new Size(73, 47);
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
            btnHapusItem.Location = new Point(172, 12);
            btnHapusItem.Margin = new Padding(0);
            btnHapusItem.Name = "btnHapusItem";
            btnHapusItem.Size = new Size(183, 47);
            btnHapusItem.TabIndex = 2;
            btnHapusItem.Text = "Hapus Item";
            btnHapusItem.UseVisualStyleBackColor = false;
            // 
            // tlpTotal
            // 
            tlpTotal.ColumnCount = 2;
            tlpTotal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.6569023F));
            tlpTotal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 62.3430977F));
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
            tlpTotal.Controls.Add(lblKembaliJudul, 0, 6);
            tlpTotal.Controls.Add(lblKembaliNilai, 1, 6);
            tlpTotal.Location = new Point(0, 153);
            tlpTotal.Margin = new Padding(0);
            tlpTotal.Name = "tlpTotal";
            tlpTotal.RowCount = 7;
            tlpTotal.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tlpTotal.RowStyles.Add(new RowStyle(SizeType.Absolute, 65F));
            tlpTotal.RowStyles.Add(new RowStyle(SizeType.Absolute, 77F));
            tlpTotal.RowStyles.Add(new RowStyle(SizeType.Absolute, 65F));
            tlpTotal.RowStyles.Add(new RowStyle(SizeType.Absolute, 65F));
            tlpTotal.RowStyles.Add(new RowStyle(SizeType.Absolute, 8F));
            tlpTotal.RowStyles.Add(new RowStyle(SizeType.Absolute, 127F));
            tlpTotal.Size = new Size(657, 390);
            tlpTotal.TabIndex = 2;
            // 
            // lblSubtotalJudul
            // 
            lblSubtotalJudul.BackColor = Color.Transparent;
            lblSubtotalJudul.Font = new Font("Segoe UI", 10F);
            lblSubtotalJudul.ForeColor = Color.FromArgb(90, 110, 140);
            lblSubtotalJudul.Location = new Point(0, 0);
            lblSubtotalJudul.Margin = new Padding(0);
            lblSubtotalJudul.Name = "lblSubtotalJudul";
            lblSubtotalJudul.Size = new Size(247, 50);
            lblSubtotalJudul.TabIndex = 0;
            lblSubtotalJudul.Text = "Subtotal";
            lblSubtotalJudul.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblSubtotalNilai
            // 
            lblSubtotalNilai.BackColor = Color.Transparent;
            lblSubtotalNilai.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblSubtotalNilai.ForeColor = Color.FromArgb(13, 47, 110);
            lblSubtotalNilai.Location = new Point(247, 0);
            lblSubtotalNilai.Margin = new Padding(0);
            lblSubtotalNilai.Name = "lblSubtotalNilai";
            lblSubtotalNilai.Size = new Size(410, 50);
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
            lblDiskonJudul.Location = new Point(0, 50);
            lblDiskonJudul.Margin = new Padding(0);
            lblDiskonJudul.Name = "lblDiskonJudul";
            lblDiskonJudul.Size = new Size(247, 65);
            lblDiskonJudul.TabIndex = 2;
            lblDiskonJudul.Text = "Diskon (Rp atau %)";
            lblDiskonJudul.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtDiskon
            // 
            txtDiskon.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtDiskon.Font = new Font("Segoe UI", 10F);
            txtDiskon.Location = new Point(247, 65);
            txtDiskon.Margin = new Padding(0);
            txtDiskon.Name = "txtDiskon";
            txtDiskon.PlaceholderText = "5000 atau 10%";
            txtDiskon.Size = new Size(410, 34);
            txtDiskon.TabIndex = 3;
            txtDiskon.TextAlign = HorizontalAlignment.Right;
            // 
            // lblTotalJudul
            // 
            lblTotalJudul.BackColor = Color.Transparent;
            lblTotalJudul.Dock = DockStyle.Fill;
            lblTotalJudul.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold);
            lblTotalJudul.ForeColor = Color.FromArgb(13, 47, 110);
            lblTotalJudul.Location = new Point(0, 115);
            lblTotalJudul.Margin = new Padding(0);
            lblTotalJudul.Name = "lblTotalJudul";
            lblTotalJudul.Size = new Size(247, 77);
            lblTotalJudul.TabIndex = 4;
            lblTotalJudul.Text = "Total Belanja";
            lblTotalJudul.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTotalNilai
            // 
            lblTotalNilai.BackColor = Color.Transparent;
            lblTotalNilai.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            lblTotalNilai.ForeColor = Color.FromArgb(30, 136, 229);
            lblTotalNilai.Location = new Point(247, 115);
            lblTotalNilai.Margin = new Padding(0);
            lblTotalNilai.Name = "lblTotalNilai";
            lblTotalNilai.Size = new Size(410, 77);
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
            lblMetodeJudul.Location = new Point(0, 192);
            lblMetodeJudul.Margin = new Padding(0);
            lblMetodeJudul.Name = "lblMetodeJudul";
            lblMetodeJudul.Size = new Size(247, 65);
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
            cmbMetode.Location = new Point(247, 206);
            cmbMetode.Margin = new Padding(0);
            cmbMetode.Name = "cmbMetode";
            cmbMetode.Size = new Size(410, 36);
            cmbMetode.TabIndex = 7;
            // 
            // lblBayarJudul
            // 
            lblBayarJudul.BackColor = Color.Transparent;
            lblBayarJudul.Dock = DockStyle.Fill;
            lblBayarJudul.Font = new Font("Segoe UI", 10F);
            lblBayarJudul.ForeColor = Color.FromArgb(90, 110, 140);
            lblBayarJudul.Location = new Point(0, 257);
            lblBayarJudul.Margin = new Padding(0);
            lblBayarJudul.Name = "lblBayarJudul";
            lblBayarJudul.Size = new Size(247, 65);
            lblBayarJudul.TabIndex = 8;
            lblBayarJudul.Text = "Uang diterima";
            lblBayarJudul.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtBayar
            // 
            txtBayar.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtBayar.Font = new Font("Segoe UI", 11F);
            txtBayar.Location = new Point(247, 271);
            txtBayar.Margin = new Padding(0);
            txtBayar.Name = "txtBayar";
            txtBayar.Size = new Size(410, 37);
            txtBayar.TabIndex = 9;
            txtBayar.TextAlign = HorizontalAlignment.Right;
            // 
            // lblKembaliJudul
            // 
            lblKembaliJudul.BackColor = Color.Transparent;
            lblKembaliJudul.Font = new Font("Segoe UI", 10F);
            lblKembaliJudul.ForeColor = Color.FromArgb(90, 110, 140);
            lblKembaliJudul.Location = new Point(0, 330);
            lblKembaliJudul.Margin = new Padding(0);
            lblKembaliJudul.Name = "lblKembaliJudul";
            lblKembaliJudul.Size = new Size(247, 63);
            lblKembaliJudul.TabIndex = 11;
            lblKembaliJudul.Text = "Kembalian";
            lblKembaliJudul.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblKembaliNilai
            // 
            lblKembaliNilai.BackColor = Color.Transparent;
            lblKembaliNilai.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblKembaliNilai.ForeColor = Color.FromArgb(40, 140, 90);
            lblKembaliNilai.Location = new Point(247, 330);
            lblKembaliNilai.Margin = new Padding(0);
            lblKembaliNilai.Name = "lblKembaliNilai";
            lblKembaliNilai.Size = new Size(396, 63);
            lblKembaliNilai.TabIndex = 12;
            lblKembaliNilai.Text = "Rp 0";
            lblKembaliNilai.TextAlign = ContentAlignment.MiddleRight;
            // 
            // flowBayar
            // 
            flowBayar.BackColor = Color.White;
            flowBayar.Controls.Add(btnBayar);
            flowBayar.Controls.Add(btnBatal);
            flowBayar.Location = new Point(0, 543);
            flowBayar.Margin = new Padding(0);
            flowBayar.Name = "flowBayar";
            flowBayar.Padding = new Padding(0, 12, 0, 0);
            flowBayar.Size = new Size(657, 100);
            flowBayar.TabIndex = 3;
            flowBayar.WrapContents = false;
            // 
            // btnBayar
            // 
            btnBayar.BackColor = Color.RoyalBlue;
            btnBayar.BorderColor = Color.Transparent;
            btnBayar.FlatStyle = FlatStyle.Flat;
            btnBayar.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            btnBayar.ForeColor = Color.White;
            btnBayar.HoverColor = Color.RoyalBlue;
            btnBayar.Location = new Point(0, 12);
            btnBayar.Margin = new Padding(0, 0, 17, 0);
            btnBayar.Name = "btnBayar";
            btnBayar.Size = new Size(281, 61);
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
            btnBatal.Location = new Point(298, 12);
            btnBatal.Margin = new Padding(0);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(167, 61);
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
            lblKeranjangJudul.Location = new Point(33, 27);
            lblKeranjangJudul.Margin = new Padding(6, 0, 6, 0);
            lblKeranjangJudul.Name = "lblKeranjangJudul";
            lblKeranjangJudul.Size = new Size(702, 33);
            lblKeranjangJudul.TabIndex = 1;
            lblKeranjangJudul.Text = "Keranjang";
            lblKeranjangJudul.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // UC_KRNJGBLNJKasir
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(234, 243, 252);
            Controls.Add(tlpRoot);
            Margin = new Padding(6, 5, 6, 5);
            Name = "UC_KRNJGBLNJKasir";
            Size = new Size(1833, 1538);
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
        private System.Windows.Forms.Label lblKembaliJudul;
        private System.Windows.Forms.Label lblKembaliNilai;
        private System.Windows.Forms.FlowLayoutPanel flowBayar;
        private RoundedButtonUI btnBayar;
        private RoundedButtonUI btnBatal;
        private System.Windows.Forms.Label lblKeranjangJudul;
    }
}