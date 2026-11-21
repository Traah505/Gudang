namespace GUedang
{
    partial class UC_BRGGudang
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
            dtpTanggal = new DateTimePicker();
            chkSemua = new CheckBox();
            lblSub = new Label();
            lblJudul = new Label();
            tlpContent = new TableLayoutPanel();
            tlpStats = new TableLayoutPanel();
            cardQty = new RoundedPanelUI();
            lblQtyKet = new Label();
            lblQtyNilai = new Label();
            lblQtyJudul = new Label();
            cardRp = new RoundedPanelUI();
            lblRpKet = new Label();
            lblRpNilai = new Label();
            lblRpJudul = new Label();
            cardTrx = new RoundedPanelUI();
            lblTrxKet = new Label();
            lblTrxNilai = new Label();
            lblTrxJudul = new Label();
            pnlInput = new RoundedPanelUI();
            tlpInput = new TableLayoutPanel();
            lblCari = new Label();
            lblJumlah = new Label();
            lblHarga = new Label();
            lblSupplier = new Label();
            lblKet = new Label();
            txtCari = new TextBox();
            btnCari = new RoundedButtonUI();
            nudJumlah = new NumericUpDown();
            txtHarga = new TextBox();
            txtSupplier = new TextBox();
            txtKeterangan = new TextBox();
            btnSimpan = new RoundedButtonUI();
            lblInfoBarang = new Label();
            lblTotalHarga = new Label();
            lblInputJudul = new Label();
            pnlRiwayat = new RoundedPanelUI();
            tlpRiwayat = new TableLayoutPanel();
            tlpToolbar = new TableLayoutPanel();
            lblRiwayatJudul = new Label();
            txtCariRiwayat = new TextBox();
            btnExport = new RoundedButtonUI();
            btnBatal = new RoundedButtonUI();
            dgvRiwayat = new DataGridView();
            colNo = new DataGridViewTextBoxColumn();
            colTanggal = new DataGridViewTextBoxColumn();
            colKode = new DataGridViewTextBoxColumn();
            colNama = new DataGridViewTextBoxColumn();
            colJumlah = new DataGridViewTextBoxColumn();
            colHarga = new DataGridViewTextBoxColumn();
            colTotal = new DataGridViewTextBoxColumn();
            colSupplier = new DataGridViewTextBoxColumn();
            colKeterangan = new DataGridViewTextBoxColumn();
            tlpRoot.SuspendLayout();
            pnlJudul.SuspendLayout();
            tlpContent.SuspendLayout();
            tlpStats.SuspendLayout();
            cardQty.SuspendLayout();
            cardRp.SuspendLayout();
            cardTrx.SuspendLayout();
            pnlInput.SuspendLayout();
            tlpInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudJumlah).BeginInit();
            pnlRiwayat.SuspendLayout();
            tlpRiwayat.SuspendLayout();
            tlpToolbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRiwayat).BeginInit();
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
            tlpRoot.RowStyles.Add(new RowStyle(SizeType.Absolute, 158F));
            tlpRoot.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpRoot.Size = new Size(1833, 1347);
            tlpRoot.TabIndex = 0;
            // 
            // pnlJudul
            // 
            pnlJudul.AccentColor = Color.Transparent;
            pnlJudul.BackColor = Color.White;
            pnlJudul.BorderColor = Color.FromArgb(214, 228, 245);
            pnlJudul.Controls.Add(dtpTanggal);
            pnlJudul.Controls.Add(chkSemua);
            pnlJudul.Controls.Add(lblSub);
            pnlJudul.Controls.Add(lblJudul);
            pnlJudul.Location = new Point(27, 30);
            pnlJudul.Margin = new Padding(0, 0, 0, 23);
            pnlJudul.Name = "pnlJudul";
            pnlJudul.Radius = 18;
            pnlJudul.Size = new Size(1779, 135);
            pnlJudul.TabIndex = 0;
            // 
            // dtpTanggal
            // 
            dtpTanggal.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dtpTanggal.Font = new Font("Segoe UI", 9.5F);
            dtpTanggal.Format = DateTimePickerFormat.Short;
            dtpTanggal.Location = new Point(1499, 42);
            dtpTanggal.Margin = new Padding(6, 5, 6, 5);
            dtpTanggal.Name = "dtpTanggal";
            dtpTanggal.Size = new Size(231, 33);
            dtpTanggal.TabIndex = 0;
            // 
            // chkSemua
            // 
            chkSemua.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            chkSemua.AutoSize = true;
            chkSemua.BackColor = Color.Transparent;
            chkSemua.Font = new Font("Segoe UI", 9F);
            chkSemua.ForeColor = Color.FromArgb(90, 110, 140);
            chkSemua.Location = new Point(1297, 50);
            chkSemua.Margin = new Padding(6, 5, 6, 5);
            chkSemua.Name = "chkSemua";
            chkSemua.Size = new Size(157, 29);
            chkSemua.TabIndex = 1;
            chkSemua.Text = "Semua tanggal";
            chkSemua.UseVisualStyleBackColor = true;
            // 
            // lblSub
            // 
            lblSub.AutoSize = true;
            lblSub.BackColor = Color.Transparent;
            lblSub.Font = new Font("Segoe UI", 9.5F);
            lblSub.ForeColor = Color.FromArgb(90, 110, 140);
            lblSub.Location = new Point(47, 76);
            lblSub.Margin = new Padding(6, 0, 6, 0);
            lblSub.Name = "lblSub";
            lblSub.Size = new Size(658, 25);
            lblSub.TabIndex = 2;
            lblSub.Text = "Catat barang yang diterima. Stok dan harga beli terakhir diperbarui otomatis.";
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
            lblJudul.Size = new Size(229, 45);
            lblJudul.TabIndex = 3;
            lblJudul.Text = "Barang Masuk";
            // 
            // tlpContent
            // 
            tlpContent.ColumnCount = 1;
            tlpContent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpContent.Controls.Add(tlpStats, 0, 0);
            tlpContent.Controls.Add(pnlInput, 0, 1);
            tlpContent.Controls.Add(pnlRiwayat, 0, 2);
            tlpContent.Dock = DockStyle.Fill;
            tlpContent.Location = new Point(27, 188);
            tlpContent.Margin = new Padding(0);
            tlpContent.Name = "tlpContent";
            tlpContent.RowCount = 3;
            tlpContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 223F));
            tlpContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 273F));
            tlpContent.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpContent.Size = new Size(1779, 1129);
            tlpContent.TabIndex = 1;
            // 
            // tlpStats
            // 
            tlpStats.ColumnCount = 3;
            tlpStats.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3F));
            tlpStats.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3F));
            tlpStats.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.4F));
            tlpStats.Controls.Add(cardQty, 0, 0);
            tlpStats.Controls.Add(cardRp, 1, 0);
            tlpStats.Controls.Add(cardTrx, 2, 0);
            tlpStats.Location = new Point(0, 0);
            tlpStats.Margin = new Padding(0, 0, 0, 23);
            tlpStats.Name = "tlpStats";
            tlpStats.RowCount = 1;
            tlpStats.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpStats.Size = new Size(1779, 139);
            tlpStats.TabIndex = 0;
            // 
            // cardQty
            // 
            cardQty.AccentColor = Color.FromArgb(30, 136, 229);
            cardQty.BackColor = Color.White;
            cardQty.BorderColor = Color.FromArgb(214, 228, 245);
            cardQty.Controls.Add(lblQtyKet);
            cardQty.Controls.Add(lblQtyNilai);
            cardQty.Controls.Add(lblQtyJudul);
            cardQty.Dock = DockStyle.Fill;
            cardQty.Location = new Point(0, 0);
            cardQty.Margin = new Padding(0, 0, 20, 0);
            cardQty.Name = "cardQty";
            cardQty.Radius = 18;
            cardQty.Size = new Size(572, 139);
            cardQty.TabIndex = 0;
            // 
            // lblQtyKet
            // 
            lblQtyKet.AutoSize = true;
            lblQtyKet.BackColor = Color.Transparent;
            lblQtyKet.Font = new Font("Segoe UI", 8.5F);
            lblQtyKet.ForeColor = Color.FromArgb(120, 135, 160);
            lblQtyKet.Location = new Point(50, 100);
            lblQtyKet.Margin = new Padding(6, 0, 6, 0);
            lblQtyKet.Name = "lblQtyKet";
            lblQtyKet.Size = new Size(127, 23);
            lblQtyKet.TabIndex = 0;
            lblQtyKet.Text = "Tanggal terpilih";
            // 
            // lblQtyNilai
            // 
            lblQtyNilai.AutoSize = true;
            lblQtyNilai.BackColor = Color.Transparent;
            lblQtyNilai.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            lblQtyNilai.ForeColor = Color.FromArgb(24, 94, 224);
            lblQtyNilai.Location = new Point(50, 52);
            lblQtyNilai.Margin = new Padding(6, 0, 6, 0);
            lblQtyNilai.Name = "lblQtyNilai";
            lblQtyNilai.Size = new Size(166, 48);
            lblQtyNilai.TabIndex = 1;
            lblQtyNilai.Text = "0 Barang";
            // 
            // lblQtyJudul
            // 
            lblQtyJudul.AutoSize = true;
            lblQtyJudul.BackColor = Color.Transparent;
            lblQtyJudul.Font = new Font("Segoe UI", 9.5F);
            lblQtyJudul.ForeColor = Color.FromArgb(90, 110, 140);
            lblQtyJudul.Location = new Point(50, 27);
            lblQtyJudul.Margin = new Padding(6, 0, 6, 0);
            lblQtyJudul.Name = "lblQtyJudul";
            lblQtyJudul.Size = new Size(177, 25);
            lblQtyJudul.TabIndex = 2;
            lblQtyJudul.Text = "Total Barang Masuk";
            // 
            // cardRp
            // 
            cardRp.AccentColor = Color.FromArgb(46, 160, 100);
            cardRp.BackColor = Color.White;
            cardRp.BorderColor = Color.FromArgb(214, 228, 245);
            cardRp.Controls.Add(lblRpKet);
            cardRp.Controls.Add(lblRpNilai);
            cardRp.Controls.Add(lblRpJudul);
            cardRp.Dock = DockStyle.Fill;
            cardRp.Location = new Point(592, 0);
            cardRp.Margin = new Padding(0, 0, 20, 0);
            cardRp.Name = "cardRp";
            cardRp.Radius = 18;
            cardRp.Size = new Size(572, 139);
            cardRp.TabIndex = 1;
            // 
            // lblRpKet
            // 
            lblRpKet.AutoSize = true;
            lblRpKet.BackColor = Color.Transparent;
            lblRpKet.Font = new Font("Segoe UI", 8.5F);
            lblRpKet.ForeColor = Color.FromArgb(120, 135, 160);
            lblRpKet.Location = new Point(48, 100);
            lblRpKet.Margin = new Padding(6, 0, 6, 0);
            lblRpKet.Name = "lblRpKet";
            lblRpKet.Size = new Size(158, 23);
            lblRpKet.TabIndex = 0;
            lblRpKet.Text = "Jumlah x harga beli";
            // 
            // lblRpNilai
            // 
            lblRpNilai.AutoSize = true;
            lblRpNilai.BackColor = Color.Transparent;
            lblRpNilai.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            lblRpNilai.ForeColor = Color.FromArgb(40, 140, 90);
            lblRpNilai.Location = new Point(50, 52);
            lblRpNilai.Margin = new Padding(6, 0, 6, 0);
            lblRpNilai.Name = "lblRpNilai";
            lblRpNilai.Size = new Size(94, 48);
            lblRpNilai.TabIndex = 1;
            lblRpNilai.Text = "Rp 0";
            // 
            // lblRpJudul
            // 
            lblRpJudul.AutoSize = true;
            lblRpJudul.BackColor = Color.Transparent;
            lblRpJudul.Font = new Font("Segoe UI", 9.5F);
            lblRpJudul.ForeColor = Color.FromArgb(90, 110, 140);
            lblRpJudul.Location = new Point(50, 27);
            lblRpJudul.Margin = new Padding(6, 0, 6, 0);
            lblRpJudul.Name = "lblRpJudul";
            lblRpJudul.Size = new Size(156, 25);
            lblRpJudul.TabIndex = 2;
            lblRpJudul.Text = "Total Nilai Masuk";
            // 
            // cardTrx
            // 
            cardTrx.AccentColor = Color.FromArgb(126, 87, 194);
            cardTrx.BackColor = Color.White;
            cardTrx.BorderColor = Color.FromArgb(214, 228, 245);
            cardTrx.Controls.Add(lblTrxKet);
            cardTrx.Controls.Add(lblTrxNilai);
            cardTrx.Controls.Add(lblTrxJudul);
            cardTrx.Dock = DockStyle.Fill;
            cardTrx.Location = new Point(1184, 0);
            cardTrx.Margin = new Padding(0);
            cardTrx.Name = "cardTrx";
            cardTrx.Radius = 18;
            cardTrx.Size = new Size(595, 139);
            cardTrx.TabIndex = 2;
            // 
            // lblTrxKet
            // 
            lblTrxKet.AutoSize = true;
            lblTrxKet.BackColor = Color.Transparent;
            lblTrxKet.Font = new Font("Segoe UI", 8.5F);
            lblTrxKet.ForeColor = Color.FromArgb(120, 135, 160);
            lblTrxKet.Location = new Point(45, 100);
            lblTrxKet.Margin = new Padding(6, 0, 6, 0);
            lblTrxKet.Name = "lblTrxKet";
            lblTrxKet.Size = new Size(158, 23);
            lblTrxKet.TabIndex = 0;
            lblTrxKet.Text = "Entri barang masuk";
            // 
            // lblTrxNilai
            // 
            lblTrxNilai.AutoSize = true;
            lblTrxNilai.BackColor = Color.Transparent;
            lblTrxNilai.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            lblTrxNilai.ForeColor = Color.FromArgb(126, 87, 194);
            lblTrxNilai.Location = new Point(50, 52);
            lblTrxNilai.Margin = new Padding(6, 0, 6, 0);
            lblTrxNilai.Name = "lblTrxNilai";
            lblTrxNilai.Size = new Size(40, 48);
            lblTrxNilai.TabIndex = 1;
            lblTrxNilai.Text = "0";
            // 
            // lblTrxJudul
            // 
            lblTrxJudul.AutoSize = true;
            lblTrxJudul.BackColor = Color.Transparent;
            lblTrxJudul.Font = new Font("Segoe UI", 9.5F);
            lblTrxJudul.ForeColor = Color.FromArgb(90, 110, 140);
            lblTrxJudul.Location = new Point(50, 27);
            lblTrxJudul.Margin = new Padding(6, 0, 6, 0);
            lblTrxJudul.Name = "lblTrxJudul";
            lblTrxJudul.Size = new Size(153, 25);
            lblTrxJudul.TabIndex = 2;
            lblTrxJudul.Text = "Jumlah Transaksi";
            // 
            // pnlInput
            // 
            pnlInput.AccentColor = Color.Transparent;
            pnlInput.BackColor = Color.White;
            pnlInput.BorderColor = Color.FromArgb(214, 228, 245);
            pnlInput.Controls.Add(tlpInput);
            pnlInput.Controls.Add(lblInputJudul);
            pnlInput.Location = new Point(0, 223);
            pnlInput.Margin = new Padding(0, 0, 0, 23);
            pnlInput.Name = "pnlInput";
            pnlInput.Padding = new Padding(33, 20, 33, 15);
            pnlInput.Radius = 18;
            pnlInput.Size = new Size(1779, 250);
            pnlInput.TabIndex = 1;
            // 
            // tlpInput
            // 
            tlpInput.ColumnCount = 7;
            tlpInput.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tlpInput.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 127F));
            tlpInput.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 183F));
            tlpInput.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 250F));
            tlpInput.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22F));
            tlpInput.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 26F));
            tlpInput.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 203F));
            tlpInput.Controls.Add(lblCari, 0, 0);
            tlpInput.Controls.Add(lblJumlah, 2, 0);
            tlpInput.Controls.Add(lblHarga, 3, 0);
            tlpInput.Controls.Add(lblSupplier, 4, 0);
            tlpInput.Controls.Add(lblKet, 5, 0);
            tlpInput.Controls.Add(txtCari, 0, 1);
            tlpInput.Controls.Add(btnCari, 1, 1);
            tlpInput.Controls.Add(nudJumlah, 2, 1);
            tlpInput.Controls.Add(txtHarga, 3, 1);
            tlpInput.Controls.Add(txtSupplier, 4, 1);
            tlpInput.Controls.Add(txtKeterangan, 5, 1);
            tlpInput.Controls.Add(btnSimpan, 6, 1);
            tlpInput.Controls.Add(lblInfoBarang, 0, 2);
            tlpInput.Controls.Add(lblTotalHarga, 4, 2);
            tlpInput.Dock = DockStyle.Fill;
            tlpInput.Location = new Point(33, 73);
            tlpInput.Margin = new Padding(0);
            tlpInput.Name = "tlpInput";
            tlpInput.RowCount = 3;
            tlpInput.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
            tlpInput.RowStyles.Add(new RowStyle(SizeType.Absolute, 65F));
            tlpInput.RowStyles.Add(new RowStyle(SizeType.Absolute, 53F));
            tlpInput.Size = new Size(1713, 162);
            tlpInput.TabIndex = 0;
            // 
            // lblCari
            // 
            lblCari.BackColor = Color.Transparent;
            tlpInput.SetColumnSpan(lblCari, 2);
            lblCari.Dock = DockStyle.Fill;
            lblCari.Font = new Font("Segoe UI", 9F);
            lblCari.ForeColor = Color.FromArgb(90, 110, 140);
            lblCari.Location = new Point(0, 0);
            lblCari.Margin = new Padding(0);
            lblCari.Name = "lblCari";
            lblCari.Size = new Size(492, 42);
            lblCari.TabIndex = 0;
            lblCari.Text = "Cari barang (kode / nama)";
            lblCari.TextAlign = ContentAlignment.BottomLeft;
            // 
            // lblJumlah
            // 
            lblJumlah.BackColor = Color.Transparent;
            lblJumlah.Dock = DockStyle.Fill;
            lblJumlah.Font = new Font("Segoe UI", 9F);
            lblJumlah.ForeColor = Color.FromArgb(90, 110, 140);
            lblJumlah.Location = new Point(492, 0);
            lblJumlah.Margin = new Padding(0);
            lblJumlah.Name = "lblJumlah";
            lblJumlah.Size = new Size(183, 42);
            lblJumlah.TabIndex = 1;
            lblJumlah.Text = "Jumlah";
            lblJumlah.TextAlign = ContentAlignment.BottomLeft;
            // 
            // lblHarga
            // 
            lblHarga.BackColor = Color.Transparent;
            lblHarga.Dock = DockStyle.Fill;
            lblHarga.Font = new Font("Segoe UI", 9F);
            lblHarga.ForeColor = Color.FromArgb(90, 110, 140);
            lblHarga.Location = new Point(675, 0);
            lblHarga.Margin = new Padding(0);
            lblHarga.Name = "lblHarga";
            lblHarga.Size = new Size(250, 42);
            lblHarga.TabIndex = 2;
            lblHarga.Text = "Harga beli (Rp)";
            lblHarga.TextAlign = ContentAlignment.BottomLeft;
            // 
            // lblSupplier
            // 
            lblSupplier.BackColor = Color.Transparent;
            lblSupplier.Dock = DockStyle.Fill;
            lblSupplier.Font = new Font("Segoe UI", 9F);
            lblSupplier.ForeColor = Color.FromArgb(90, 110, 140);
            lblSupplier.Location = new Point(925, 0);
            lblSupplier.Margin = new Padding(0);
            lblSupplier.Name = "lblSupplier";
            lblSupplier.Size = new Size(267, 42);
            lblSupplier.TabIndex = 3;
            lblSupplier.Text = "Supplier";
            lblSupplier.TextAlign = ContentAlignment.BottomLeft;
            // 
            // lblKet
            // 
            lblKet.BackColor = Color.Transparent;
            lblKet.Dock = DockStyle.Fill;
            lblKet.Font = new Font("Segoe UI", 9F);
            lblKet.ForeColor = Color.FromArgb(90, 110, 140);
            lblKet.Location = new Point(1192, 0);
            lblKet.Margin = new Padding(0);
            lblKet.Name = "lblKet";
            lblKet.Size = new Size(316, 42);
            lblKet.TabIndex = 4;
            lblKet.Text = "Keterangan";
            lblKet.TextAlign = ContentAlignment.BottomLeft;
            // 
            // txtCari
            // 
            txtCari.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtCari.Font = new Font("Segoe UI", 10F);
            txtCari.Location = new Point(0, 42);
            txtCari.Margin = new Padding(0, 0, 10, 0);
            txtCari.Name = "txtCari";
            txtCari.PlaceholderText = "Ketik kode atau nama barang...";
            txtCari.Size = new Size(355, 34);
            txtCari.TabIndex = 5;
            // 
            // btnCari
            // 
            btnCari.BackColor = Color.FromArgb(30, 136, 229);
            btnCari.BorderColor = Color.Transparent;
            btnCari.FlatStyle = FlatStyle.Flat;
            btnCari.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            btnCari.ForeColor = Color.White;
            btnCari.HoverColor = Color.FromArgb(21, 101, 192);
            btnCari.Location = new Point(365, 42);
            btnCari.Margin = new Padding(0, 0, 20, 0);
            btnCari.Name = "btnCari";
            btnCari.Size = new Size(107, 52);
            btnCari.TabIndex = 6;
            btnCari.Text = "Cari";
            btnCari.UseVisualStyleBackColor = false;
            // 
            // nudJumlah
            // 
            nudJumlah.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            nudJumlah.Font = new Font("Segoe UI", 10F);
            nudJumlah.Location = new Point(492, 42);
            nudJumlah.Margin = new Padding(0, 0, 20, 0);
            nudJumlah.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nudJumlah.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudJumlah.Name = "nudJumlah";
            nudJumlah.Size = new Size(163, 34);
            nudJumlah.TabIndex = 7;
            nudJumlah.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // txtHarga
            // 
            txtHarga.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtHarga.Font = new Font("Segoe UI", 10F);
            txtHarga.Location = new Point(675, 42);
            txtHarga.Margin = new Padding(0, 0, 20, 0);
            txtHarga.Name = "txtHarga";
            txtHarga.Size = new Size(230, 34);
            txtHarga.TabIndex = 8;
            txtHarga.TextAlign = HorizontalAlignment.Right;
            // 
            // txtSupplier
            // 
            txtSupplier.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSupplier.Font = new Font("Segoe UI", 10F);
            txtSupplier.Location = new Point(925, 42);
            txtSupplier.Margin = new Padding(0, 0, 20, 0);
            txtSupplier.Name = "txtSupplier";
            txtSupplier.Size = new Size(247, 34);
            txtSupplier.TabIndex = 9;
            // 
            // txtKeterangan
            // 
            txtKeterangan.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtKeterangan.Font = new Font("Segoe UI", 10F);
            txtKeterangan.Location = new Point(1192, 42);
            txtKeterangan.Margin = new Padding(0, 0, 20, 0);
            txtKeterangan.Name = "txtKeterangan";
            txtKeterangan.Size = new Size(296, 34);
            txtKeterangan.TabIndex = 10;
            // 
            // btnSimpan
            // 
            btnSimpan.BackColor = Color.RoyalBlue;
            btnSimpan.BorderColor = Color.Transparent;
            btnSimpan.FlatStyle = FlatStyle.Flat;
            btnSimpan.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            btnSimpan.ForeColor = Color.White;
            btnSimpan.HoverColor = Color.FromArgb(21, 101, 192);
            btnSimpan.Location = new Point(1508, 42);
            btnSimpan.Margin = new Padding(0);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(200, 58);
            btnSimpan.TabIndex = 11;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = false;
            // 
            // lblInfoBarang
            // 
            lblInfoBarang.BackColor = Color.Transparent;
            tlpInput.SetColumnSpan(lblInfoBarang, 4);
            lblInfoBarang.Dock = DockStyle.Fill;
            lblInfoBarang.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblInfoBarang.ForeColor = Color.FromArgb(30, 136, 229);
            lblInfoBarang.Location = new Point(0, 107);
            lblInfoBarang.Margin = new Padding(0);
            lblInfoBarang.Name = "lblInfoBarang";
            lblInfoBarang.Size = new Size(925, 55);
            lblInfoBarang.TabIndex = 12;
            lblInfoBarang.Text = "Barang belum dipilih";
            lblInfoBarang.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTotalHarga
            // 
            lblTotalHarga.BackColor = Color.Transparent;
            tlpInput.SetColumnSpan(lblTotalHarga, 3);
            lblTotalHarga.Dock = DockStyle.Fill;
            lblTotalHarga.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblTotalHarga.ForeColor = Color.FromArgb(40, 140, 90);
            lblTotalHarga.Location = new Point(925, 107);
            lblTotalHarga.Margin = new Padding(0);
            lblTotalHarga.Name = "lblTotalHarga";
            lblTotalHarga.Size = new Size(788, 55);
            lblTotalHarga.TabIndex = 13;
            lblTotalHarga.Text = "Total: Rp 0";
            lblTotalHarga.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblInputJudul
            // 
            lblInputJudul.BackColor = Color.Transparent;
            lblInputJudul.Dock = DockStyle.Top;
            lblInputJudul.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblInputJudul.ForeColor = Color.FromArgb(13, 47, 110);
            lblInputJudul.Location = new Point(33, 20);
            lblInputJudul.Margin = new Padding(6, 0, 6, 0);
            lblInputJudul.Name = "lblInputJudul";
            lblInputJudul.Size = new Size(1713, 53);
            lblInputJudul.TabIndex = 1;
            lblInputJudul.Text = "Input Barang Masuk";
            lblInputJudul.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlRiwayat
            // 
            pnlRiwayat.AccentColor = Color.Transparent;
            pnlRiwayat.BackColor = Color.White;
            pnlRiwayat.BorderColor = Color.FromArgb(214, 228, 245);
            pnlRiwayat.Controls.Add(tlpRiwayat);
            pnlRiwayat.Dock = DockStyle.Fill;
            pnlRiwayat.Location = new Point(0, 496);
            pnlRiwayat.Margin = new Padding(0);
            pnlRiwayat.Name = "pnlRiwayat";
            pnlRiwayat.Padding = new Padding(33, 27, 33, 30);
            pnlRiwayat.Radius = 18;
            pnlRiwayat.Size = new Size(1779, 633);
            pnlRiwayat.TabIndex = 2;
            // 
            // tlpRiwayat
            // 
            tlpRiwayat.ColumnCount = 1;
            tlpRiwayat.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpRiwayat.Controls.Add(tlpToolbar, 0, 0);
            tlpRiwayat.Controls.Add(dgvRiwayat, 0, 1);
            tlpRiwayat.Dock = DockStyle.Fill;
            tlpRiwayat.Location = new Point(33, 27);
            tlpRiwayat.Margin = new Padding(0);
            tlpRiwayat.Name = "tlpRiwayat";
            tlpRiwayat.RowCount = 2;
            tlpRiwayat.RowStyles.Add(new RowStyle(SizeType.Absolute, 85F));
            tlpRiwayat.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpRiwayat.Size = new Size(1713, 576);
            tlpRiwayat.TabIndex = 0;
            // 
            // tlpToolbar
            // 
            tlpToolbar.ColumnCount = 4;
            tlpToolbar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpToolbar.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 383F));
            tlpToolbar.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            tlpToolbar.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 233F));
            tlpToolbar.Controls.Add(lblRiwayatJudul, 0, 0);
            tlpToolbar.Controls.Add(txtCariRiwayat, 1, 0);
            tlpToolbar.Controls.Add(btnExport, 2, 0);
            tlpToolbar.Controls.Add(btnBatal, 3, 0);
            tlpToolbar.Dock = DockStyle.Fill;
            tlpToolbar.Location = new Point(0, 0);
            tlpToolbar.Margin = new Padding(0);
            tlpToolbar.Name = "tlpToolbar";
            tlpToolbar.RowCount = 1;
            tlpToolbar.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpToolbar.Size = new Size(1713, 85);
            tlpToolbar.TabIndex = 0;
            // 
            // lblRiwayatJudul
            // 
            lblRiwayatJudul.BackColor = Color.Transparent;
            lblRiwayatJudul.Dock = DockStyle.Fill;
            lblRiwayatJudul.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblRiwayatJudul.ForeColor = Color.FromArgb(13, 47, 110);
            lblRiwayatJudul.Location = new Point(0, 0);
            lblRiwayatJudul.Margin = new Padding(0);
            lblRiwayatJudul.Name = "lblRiwayatJudul";
            lblRiwayatJudul.Size = new Size(897, 85);
            lblRiwayatJudul.TabIndex = 0;
            lblRiwayatJudul.Text = "Riwayat Barang Masuk";
            lblRiwayatJudul.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtCariRiwayat
            // 
            txtCariRiwayat.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtCariRiwayat.Font = new Font("Segoe UI", 10F);
            txtCariRiwayat.Location = new Point(897, 17);
            txtCariRiwayat.Margin = new Padding(0, 17, 17, 0);
            txtCariRiwayat.Name = "txtCariRiwayat";
            txtCariRiwayat.PlaceholderText = "Cari di riwayat...";
            txtCariRiwayat.Size = new Size(366, 34);
            txtCariRiwayat.TabIndex = 1;
            // 
            // btnExport
            // 
            btnExport.BackColor = Color.RoyalBlue;
            btnExport.BorderColor = Color.FromArgb(30, 136, 229);
            btnExport.Dock = DockStyle.Fill;
            btnExport.FlatStyle = FlatStyle.Flat;
            btnExport.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            btnExport.ForeColor = Color.White;
            btnExport.HoverColor = Color.FromArgb(225, 240, 255);
            btnExport.Location = new Point(1280, 10);
            btnExport.Margin = new Padding(0, 10, 17, 10);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(183, 65);
            btnExport.TabIndex = 2;
            btnExport.Text = "Print";
            btnExport.UseVisualStyleBackColor = false;
            // 
            // btnBatal
            // 
            btnBatal.BackColor = Color.FromArgb(214, 69, 65);
            btnBatal.BorderColor = Color.FromArgb(214, 69, 65);
            btnBatal.Dock = DockStyle.Fill;
            btnBatal.FlatStyle = FlatStyle.Flat;
            btnBatal.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            btnBatal.ForeColor = Color.White;
            btnBatal.HoverColor = Color.FromArgb(253, 236, 235);
            btnBatal.Location = new Point(1480, 10);
            btnBatal.Margin = new Padding(0, 10, 0, 10);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(233, 65);
            btnBatal.TabIndex = 3;
            btnBatal.Text = "Batalkan Entri";
            btnBatal.UseVisualStyleBackColor = false;
            // 
            // dgvRiwayat
            // 
            dgvRiwayat.BackgroundColor = Color.White;
            dgvRiwayat.BorderStyle = BorderStyle.None;
            dgvRiwayat.ColumnHeadersHeight = 34;
            dgvRiwayat.Columns.AddRange(new DataGridViewColumn[] { colNo, colTanggal, colKode, colNama, colJumlah, colHarga, colTotal, colSupplier, colKeterangan });
            dgvRiwayat.Dock = DockStyle.Fill;
            dgvRiwayat.Location = new Point(0, 85);
            dgvRiwayat.Margin = new Padding(0);
            dgvRiwayat.Name = "dgvRiwayat";
            dgvRiwayat.RowHeadersWidth = 62;
            dgvRiwayat.Size = new Size(1713, 491);
            dgvRiwayat.TabIndex = 1;
            // 
            // colNo
            // 
            colNo.FillWeight = 6F;
            colNo.HeaderText = "No";
            colNo.MinimumWidth = 8;
            colNo.Name = "colNo";
            colNo.Width = 150;
            // 
            // colTanggal
            // 
            colTanggal.FillWeight = 14F;
            colTanggal.HeaderText = "Tanggal";
            colTanggal.MinimumWidth = 8;
            colTanggal.Name = "colTanggal";
            colTanggal.Width = 150;
            // 
            // colKode
            // 
            colKode.FillWeight = 11F;
            colKode.HeaderText = "Kode Barang";
            colKode.MinimumWidth = 8;
            colKode.Name = "colKode";
            colKode.Width = 150;
            // 
            // colNama
            // 
            colNama.FillWeight = 19F;
            colNama.HeaderText = "Nama Barang";
            colNama.MinimumWidth = 8;
            colNama.Name = "colNama";
            colNama.Width = 150;
            // 
            // colJumlah
            // 
            colJumlah.FillWeight = 8F;
            colJumlah.HeaderText = "Jumlah";
            colJumlah.MinimumWidth = 8;
            colJumlah.Name = "colJumlah";
            colJumlah.Width = 150;
            // 
            // colHarga
            // 
            colHarga.FillWeight = 11F;
            colHarga.HeaderText = "Harga Beli";
            colHarga.MinimumWidth = 8;
            colHarga.Name = "colHarga";
            colHarga.Width = 150;
            // 
            // colTotal
            // 
            colTotal.FillWeight = 11F;
            colTotal.HeaderText = "Total";
            colTotal.MinimumWidth = 8;
            colTotal.Name = "colTotal";
            colTotal.Width = 150;
            // 
            // colSupplier
            // 
            colSupplier.FillWeight = 13F;
            colSupplier.HeaderText = "Supplier";
            colSupplier.MinimumWidth = 8;
            colSupplier.Name = "colSupplier";
            colSupplier.Width = 150;
            // 
            // colKeterangan
            // 
            colKeterangan.FillWeight = 14F;
            colKeterangan.HeaderText = "Keterangan";
            colKeterangan.MinimumWidth = 8;
            colKeterangan.Name = "colKeterangan";
            colKeterangan.Width = 150;
            // 
            // UC_BRGGudang
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(234, 243, 252);
            Controls.Add(tlpRoot);
            Margin = new Padding(6, 5, 6, 5);
            Name = "UC_BRGGudang";
            Size = new Size(1833, 1347);
            tlpRoot.ResumeLayout(false);
            pnlJudul.ResumeLayout(false);
            pnlJudul.PerformLayout();
            tlpContent.ResumeLayout(false);
            tlpStats.ResumeLayout(false);
            cardQty.ResumeLayout(false);
            cardQty.PerformLayout();
            cardRp.ResumeLayout(false);
            cardRp.PerformLayout();
            cardTrx.ResumeLayout(false);
            cardTrx.PerformLayout();
            pnlInput.ResumeLayout(false);
            tlpInput.ResumeLayout(false);
            tlpInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudJumlah).EndInit();
            pnlRiwayat.ResumeLayout(false);
            tlpRiwayat.ResumeLayout(false);
            tlpToolbar.ResumeLayout(false);
            tlpToolbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRiwayat).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpRoot;
        private RoundedPanelUI pnlJudul;
        private System.Windows.Forms.DateTimePicker dtpTanggal;
        private System.Windows.Forms.CheckBox chkSemua;
        private System.Windows.Forms.Label lblSub;
        private System.Windows.Forms.Label lblJudul;
        private System.Windows.Forms.TableLayoutPanel tlpContent;
        private System.Windows.Forms.TableLayoutPanel tlpStats;
        private RoundedPanelUI cardQty;
        private System.Windows.Forms.Label lblQtyKet;
        private System.Windows.Forms.Label lblQtyNilai;
        private System.Windows.Forms.Label lblQtyJudul;
        private RoundedPanelUI cardRp;
        private System.Windows.Forms.Label lblRpKet;
        private System.Windows.Forms.Label lblRpNilai;
        private System.Windows.Forms.Label lblRpJudul;
        private RoundedPanelUI cardTrx;
        private System.Windows.Forms.Label lblTrxKet;
        private System.Windows.Forms.Label lblTrxNilai;
        private System.Windows.Forms.Label lblTrxJudul;
        private RoundedPanelUI pnlInput;
        private System.Windows.Forms.TableLayoutPanel tlpInput;
        private System.Windows.Forms.Label lblCari;
        private System.Windows.Forms.Label lblJumlah;
        private System.Windows.Forms.Label lblHarga;
        private System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.Label lblKet;
        private System.Windows.Forms.TextBox txtCari;
        private RoundedButtonUI btnCari;
        private System.Windows.Forms.NumericUpDown nudJumlah;
        private System.Windows.Forms.TextBox txtHarga;
        private System.Windows.Forms.TextBox txtSupplier;
        private System.Windows.Forms.TextBox txtKeterangan;
        private RoundedButtonUI btnSimpan;
        private System.Windows.Forms.Label lblInfoBarang;
        private System.Windows.Forms.Label lblTotalHarga;
        private System.Windows.Forms.Label lblInputJudul;
        private RoundedPanelUI pnlRiwayat;
        private System.Windows.Forms.TableLayoutPanel tlpRiwayat;
        private System.Windows.Forms.TableLayoutPanel tlpToolbar;
        private System.Windows.Forms.Label lblRiwayatJudul;
        private System.Windows.Forms.TextBox txtCariRiwayat;
        private RoundedButtonUI btnExport;
        private RoundedButtonUI btnBatal;
        private System.Windows.Forms.DataGridView dgvRiwayat;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTanggal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNama;
        private System.Windows.Forms.DataGridViewTextBoxColumn colJumlah;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHarga;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSupplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKeterangan;
    }
}