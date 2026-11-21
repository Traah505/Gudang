namespace GUedang
{
    partial class UC_Laporan
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
            lblSub = new Label();
            lblJudul = new Label();
            tlpContent = new TableLayoutPanel();
            tlpStats = new TableLayoutPanel();
            cardPendapatan = new RoundedPanelUI();
            lblPendapatanKet = new Label();
            lblPendapatanNilai = new Label();
            lblPendapatanJudul = new Label();
            cardTrx = new RoundedPanelUI();
            lblTrxKet = new Label();
            lblTrxNilai = new Label();
            lblTrxJudul = new Label();
            cardItem = new RoundedPanelUI();
            lblItemKet = new Label();
            lblItemNilai = new Label();
            lblItemJudul = new Label();
            cardRata = new RoundedPanelUI();
            lblRataKet = new Label();
            lblRataNilai = new Label();
            lblRataJudul = new Label();
            pnlFilter = new RoundedPanelUI();
            cmbRentang = new ComboBox();
            lblDari = new Label();
            dtpDari = new DateTimePicker();
            lblSampai = new Label();
            dtpSampai = new DateTimePicker();
            cmbKasir = new ComboBox();
            txtCari = new TextBox();
            btnTampilkan = new RoundedButtonUI();
            btnExport = new RoundedButtonUI();
            tlpMain = new TableLayoutPanel();
            pnlTrx = new RoundedPanelUI();
            dgvTrx = new DataGridView();
            colNo = new DataGridViewTextBoxColumn();
            colKode = new DataGridViewTextBoxColumn();
            colTanggal = new DataGridViewTextBoxColumn();
            colKasir = new DataGridViewTextBoxColumn();
            colItem = new DataGridViewTextBoxColumn();
            colTotal = new DataGridViewTextBoxColumn();
            lblDaftarTrxJudul = new Label();
            tlpKanan = new TableLayoutPanel();
            pnlDetail = new RoundedPanelUI();
            dgvDetail = new DataGridView();
            colDBarang = new DataGridViewTextBoxColumn();
            colDQty = new DataGridViewTextBoxColumn();
            colDSubtotal = new DataGridViewTextBoxColumn();
            lblDetailTotal = new Label();
            lblDetailNo = new Label();
            lblDetailJudul = new Label();
            pnlTop = new RoundedPanelUI();
            dgvTop = new DataGridView();
            colTBarang = new DataGridViewTextBoxColumn();
            colTQty = new DataGridViewTextBoxColumn();
            colTOmzet = new DataGridViewTextBoxColumn();
            lblTopJudul = new Label();
            tlpRoot.SuspendLayout();
            pnlJudul.SuspendLayout();
            tlpContent.SuspendLayout();
            tlpStats.SuspendLayout();
            cardPendapatan.SuspendLayout();
            cardTrx.SuspendLayout();
            cardItem.SuspendLayout();
            cardRata.SuspendLayout();
            pnlFilter.SuspendLayout();
            tlpMain.SuspendLayout();
            pnlTrx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTrx).BeginInit();
            tlpKanan.SuspendLayout();
            pnlDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetail).BeginInit();
            pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTop).BeginInit();
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
            // lblSub
            // 
            lblSub.AutoSize = true;
            lblSub.BackColor = Color.Transparent;
            lblSub.Font = new Font("Segoe UI", 9.5F);
            lblSub.ForeColor = Color.FromArgb(90, 110, 140);
            lblSub.Location = new Point(28, 51);
            lblSub.Margin = new Padding(4, 0, 4, 0);
            lblSub.Name = "lblSub";
            lblSub.Size = new Size(354, 17);
            lblSub.TabIndex = 0;
            lblSub.Text = "Ringkasan transaksi penjualan kasir beserta barang terlaris.";
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
            lblJudul.Size = new Size(196, 30);
            lblJudul.TabIndex = 1;
            lblJudul.Text = "Laporan Penjualan";
            // 
            // tlpContent
            // 
            tlpContent.ColumnCount = 1;
            tlpContent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpContent.Controls.Add(tlpStats, 0, 0);
            tlpContent.Controls.Add(pnlFilter, 0, 1);
            tlpContent.Controls.Add(tlpMain, 0, 2);
            tlpContent.Dock = DockStyle.Fill;
            tlpContent.Location = new Point(19, 113);
            tlpContent.Margin = new Padding(0);
            tlpContent.Name = "tlpContent";
            tlpContent.RowCount = 3;
            tlpContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 134F));
            tlpContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 88F));
            tlpContent.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpContent.Size = new Size(1245, 792);
            tlpContent.TabIndex = 1;
            // 
            // tlpStats
            // 
            tlpStats.ColumnCount = 4;
            tlpStats.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpStats.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpStats.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpStats.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpStats.Controls.Add(cardPendapatan, 0, 0);
            tlpStats.Controls.Add(cardTrx, 1, 0);
            tlpStats.Controls.Add(cardItem, 2, 0);
            tlpStats.Controls.Add(cardRata, 3, 0);
            tlpStats.Dock = DockStyle.Fill;
            tlpStats.Location = new Point(0, 0);
            tlpStats.Margin = new Padding(0, 0, 0, 14);
            tlpStats.Name = "tlpStats";
            tlpStats.RowCount = 1;
            tlpStats.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpStats.Size = new Size(1245, 120);
            tlpStats.TabIndex = 0;
            // 
            // cardPendapatan
            // 
            cardPendapatan.AccentColor = Color.FromArgb(30, 136, 229);
            cardPendapatan.BackColor = Color.White;
            cardPendapatan.BorderColor = Color.FromArgb(214, 228, 245);
            cardPendapatan.Controls.Add(lblPendapatanKet);
            cardPendapatan.Controls.Add(lblPendapatanNilai);
            cardPendapatan.Controls.Add(lblPendapatanJudul);
            cardPendapatan.Dock = DockStyle.Fill;
            cardPendapatan.Location = new Point(0, 0);
            cardPendapatan.Margin = new Padding(0, 0, 14, 0);
            cardPendapatan.Name = "cardPendapatan";
            cardPendapatan.Radius = 18;
            cardPendapatan.Size = new Size(297, 120);
            cardPendapatan.TabIndex = 0;
            // 
            // lblPendapatanKet
            // 
            lblPendapatanKet.AutoSize = true;
            lblPendapatanKet.BackColor = Color.Transparent;
            lblPendapatanKet.Font = new Font("Segoe UI", 8.5F);
            lblPendapatanKet.ForeColor = Color.FromArgb(120, 135, 160);
            lblPendapatanKet.Location = new Point(35, 78);
            lblPendapatanKet.Margin = new Padding(4, 0, 4, 0);
            lblPendapatanKet.Name = "lblPendapatanKet";
            lblPendapatanKet.Size = new Size(87, 15);
            lblPendapatanKet.TabIndex = 0;
            lblPendapatanKet.Text = "Periode terpilih";
            // 
            // lblPendapatanNilai
            // 
            lblPendapatanNilai.AutoSize = true;
            lblPendapatanNilai.BackColor = Color.Transparent;
            lblPendapatanNilai.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            lblPendapatanNilai.ForeColor = Color.FromArgb(24, 94, 224);
            lblPendapatanNilai.Location = new Point(33, 37);
            lblPendapatanNilai.Margin = new Padding(4, 0, 4, 0);
            lblPendapatanNilai.Name = "lblPendapatanNilai";
            lblPendapatanNilai.Size = new Size(63, 32);
            lblPendapatanNilai.TabIndex = 1;
            lblPendapatanNilai.Text = "Rp 0";
            // 
            // lblPendapatanJudul
            // 
            lblPendapatanJudul.AutoSize = true;
            lblPendapatanJudul.BackColor = Color.Transparent;
            lblPendapatanJudul.Font = new Font("Segoe UI", 9.5F);
            lblPendapatanJudul.ForeColor = Color.FromArgb(90, 110, 140);
            lblPendapatanJudul.Location = new Point(35, 16);
            lblPendapatanJudul.Margin = new Padding(4, 0, 4, 0);
            lblPendapatanJudul.Name = "lblPendapatanJudul";
            lblPendapatanJudul.Size = new Size(109, 17);
            lblPendapatanJudul.TabIndex = 2;
            lblPendapatanJudul.Text = "Total Pendapatan";
            // 
            // cardTrx
            // 
            cardTrx.AccentColor = Color.FromArgb(46, 160, 100);
            cardTrx.BackColor = Color.White;
            cardTrx.BorderColor = Color.FromArgb(214, 228, 245);
            cardTrx.Controls.Add(lblTrxKet);
            cardTrx.Controls.Add(lblTrxNilai);
            cardTrx.Controls.Add(lblTrxJudul);
            cardTrx.Dock = DockStyle.Fill;
            cardTrx.Location = new Point(311, 0);
            cardTrx.Margin = new Padding(0, 0, 14, 0);
            cardTrx.Name = "cardTrx";
            cardTrx.Radius = 18;
            cardTrx.Size = new Size(297, 120);
            cardTrx.TabIndex = 1;
            // 
            // lblTrxKet
            // 
            lblTrxKet.AutoSize = true;
            lblTrxKet.BackColor = Color.Transparent;
            lblTrxKet.Font = new Font("Segoe UI", 8.5F);
            lblTrxKet.ForeColor = Color.FromArgb(120, 135, 160);
            lblTrxKet.Location = new Point(35, 78);
            lblTrxKet.Margin = new Padding(4, 0, 4, 0);
            lblTrxKet.Name = "lblTrxKet";
            lblTrxKet.Size = new Size(91, 15);
            lblTrxKet.TabIndex = 0;
            lblTrxKet.Text = "Transaksi selesai";
            // 
            // lblTrxNilai
            // 
            lblTrxNilai.AutoSize = true;
            lblTrxNilai.BackColor = Color.Transparent;
            lblTrxNilai.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            lblTrxNilai.ForeColor = Color.FromArgb(40, 140, 90);
            lblTrxNilai.Location = new Point(33, 37);
            lblTrxNilai.Margin = new Padding(4, 0, 4, 0);
            lblTrxNilai.Name = "lblTrxNilai";
            lblTrxNilai.Size = new Size(27, 32);
            lblTrxNilai.TabIndex = 1;
            lblTrxNilai.Text = "0";
            // 
            // lblTrxJudul
            // 
            lblTrxJudul.AutoSize = true;
            lblTrxJudul.BackColor = Color.Transparent;
            lblTrxJudul.Font = new Font("Segoe UI", 9.5F);
            lblTrxJudul.ForeColor = Color.FromArgb(90, 110, 140);
            lblTrxJudul.Location = new Point(35, 16);
            lblTrxJudul.Margin = new Padding(4, 0, 4, 0);
            lblTrxJudul.Name = "lblTrxJudul";
            lblTrxJudul.Size = new Size(105, 17);
            lblTrxJudul.TabIndex = 2;
            lblTrxJudul.Text = "Jumlah Transaksi";
            // 
            // cardItem
            // 
            cardItem.AccentColor = Color.FromArgb(126, 87, 194);
            cardItem.BackColor = Color.White;
            cardItem.BorderColor = Color.FromArgb(214, 228, 245);
            cardItem.Controls.Add(lblItemKet);
            cardItem.Controls.Add(lblItemNilai);
            cardItem.Controls.Add(lblItemJudul);
            cardItem.Dock = DockStyle.Fill;
            cardItem.Location = new Point(622, 0);
            cardItem.Margin = new Padding(0, 0, 14, 0);
            cardItem.Name = "cardItem";
            cardItem.Radius = 18;
            cardItem.Size = new Size(297, 120);
            cardItem.TabIndex = 2;
            // 
            // lblItemKet
            // 
            lblItemKet.AutoSize = true;
            lblItemKet.BackColor = Color.Transparent;
            lblItemKet.Font = new Font("Segoe UI", 8.5F);
            lblItemKet.ForeColor = Color.FromArgb(120, 135, 160);
            lblItemKet.Location = new Point(35, 78);
            lblItemKet.Margin = new Padding(4, 0, 4, 0);
            lblItemKet.Name = "lblItemKet";
            lblItemKet.Size = new Size(92, 15);
            lblItemKet.TabIndex = 0;
            lblItemKet.Text = "Total qty barang";
            // 
            // lblItemNilai
            // 
            lblItemNilai.AutoSize = true;
            lblItemNilai.BackColor = Color.Transparent;
            lblItemNilai.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            lblItemNilai.ForeColor = Color.FromArgb(126, 87, 194);
            lblItemNilai.Location = new Point(33, 37);
            lblItemNilai.Margin = new Padding(4, 0, 4, 0);
            lblItemNilai.Name = "lblItemNilai";
            lblItemNilai.Size = new Size(27, 32);
            lblItemNilai.TabIndex = 1;
            lblItemNilai.Text = "0";
            // 
            // lblItemJudul
            // 
            lblItemJudul.AutoSize = true;
            lblItemJudul.BackColor = Color.Transparent;
            lblItemJudul.Font = new Font("Segoe UI", 9.5F);
            lblItemJudul.ForeColor = Color.FromArgb(90, 110, 140);
            lblItemJudul.Location = new Point(35, 16);
            lblItemJudul.Margin = new Padding(4, 0, 4, 0);
            lblItemJudul.Name = "lblItemJudul";
            lblItemJudul.Size = new Size(75, 17);
            lblItemJudul.TabIndex = 2;
            lblItemJudul.Text = "Item Terjual";
            // 
            // cardRata
            // 
            cardRata.AccentColor = Color.FromArgb(230, 150, 20);
            cardRata.BackColor = Color.White;
            cardRata.BorderColor = Color.FromArgb(214, 228, 245);
            cardRata.Controls.Add(lblRataKet);
            cardRata.Controls.Add(lblRataNilai);
            cardRata.Controls.Add(lblRataJudul);
            cardRata.Dock = DockStyle.Fill;
            cardRata.Location = new Point(933, 0);
            cardRata.Margin = new Padding(0);
            cardRata.Name = "cardRata";
            cardRata.Radius = 18;
            cardRata.Size = new Size(312, 120);
            cardRata.TabIndex = 3;
            // 
            // lblRataKet
            // 
            lblRataKet.AutoSize = true;
            lblRataKet.BackColor = Color.Transparent;
            lblRataKet.Font = new Font("Segoe UI", 8.5F);
            lblRataKet.ForeColor = Color.FromArgb(120, 135, 160);
            lblRataKet.Location = new Point(35, 78);
            lblRataKet.Margin = new Padding(4, 0, 4, 0);
            lblRataKet.Name = "lblRataKet";
            lblRataKet.Size = new Size(127, 15);
            lblRataKet.TabIndex = 0;
            lblRataKet.Text = "Pendapatan / transaksi";
            // 
            // lblRataNilai
            // 
            lblRataNilai.AutoSize = true;
            lblRataNilai.BackColor = Color.Transparent;
            lblRataNilai.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            lblRataNilai.ForeColor = Color.FromArgb(200, 125, 10);
            lblRataNilai.Location = new Point(33, 37);
            lblRataNilai.Margin = new Padding(4, 0, 4, 0);
            lblRataNilai.Name = "lblRataNilai";
            lblRataNilai.Size = new Size(63, 32);
            lblRataNilai.TabIndex = 1;
            lblRataNilai.Text = "Rp 0";
            // 
            // lblRataJudul
            // 
            lblRataJudul.AutoSize = true;
            lblRataJudul.BackColor = Color.Transparent;
            lblRataJudul.Font = new Font("Segoe UI", 9.5F);
            lblRataJudul.ForeColor = Color.FromArgb(90, 110, 140);
            lblRataJudul.Location = new Point(35, 16);
            lblRataJudul.Margin = new Padding(4, 0, 4, 0);
            lblRataJudul.Name = "lblRataJudul";
            lblRataJudul.Size = new Size(128, 17);
            lblRataJudul.TabIndex = 2;
            lblRataJudul.Text = "Rata-rata / Transaksi";
            // 
            // pnlFilter
            // 
            pnlFilter.AccentColor = Color.Transparent;
            pnlFilter.BackColor = Color.White;
            pnlFilter.BorderColor = Color.FromArgb(214, 228, 245);
            pnlFilter.Controls.Add(cmbRentang);
            pnlFilter.Controls.Add(lblDari);
            pnlFilter.Controls.Add(dtpDari);
            pnlFilter.Controls.Add(lblSampai);
            pnlFilter.Controls.Add(dtpSampai);
            pnlFilter.Controls.Add(cmbKasir);
            pnlFilter.Controls.Add(txtCari);
            pnlFilter.Controls.Add(btnTampilkan);
            pnlFilter.Controls.Add(btnExport);
            pnlFilter.Dock = DockStyle.Fill;
            pnlFilter.Location = new Point(0, 134);
            pnlFilter.Margin = new Padding(0, 0, 0, 14);
            pnlFilter.Name = "pnlFilter";
            pnlFilter.Padding = new Padding(23, 0, 23, 0);
            pnlFilter.Radius = 18;
            pnlFilter.Size = new Size(1245, 74);
            pnlFilter.TabIndex = 1;
            // 
            // cmbRentang
            // 
            cmbRentang.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRentang.Font = new Font("Segoe UI", 10F);
            cmbRentang.FormattingEnabled = true;
            cmbRentang.Items.AddRange(new object[] { "Hari ini", "7 hari terakhir", "30 hari terakhir", "Bulan ini", "Semua", "Pilih manual" });
            cmbRentang.Location = new Point(23, 21);
            cmbRentang.Margin = new Padding(0);
            cmbRentang.Name = "cmbRentang";
            cmbRentang.Size = new Size(174, 25);
            cmbRentang.TabIndex = 0;
            // 
            // lblDari
            // 
            lblDari.AutoSize = true;
            lblDari.BackColor = Color.Transparent;
            lblDari.Font = new Font("Segoe UI", 9.5F);
            lblDari.ForeColor = Color.FromArgb(90, 110, 140);
            lblDari.Location = new Point(212, 25);
            lblDari.Margin = new Padding(4, 0, 4, 0);
            lblDari.Name = "lblDari";
            lblDari.Size = new Size(32, 17);
            lblDari.TabIndex = 1;
            lblDari.Text = "Dari";
            // 
            // dtpDari
            // 
            dtpDari.Font = new Font("Segoe UI", 9.5F);
            dtpDari.Format = DateTimePickerFormat.Short;
            dtpDari.Location = new Point(250, 21);
            dtpDari.Margin = new Padding(4, 3, 4, 3);
            dtpDari.Name = "dtpDari";
            dtpDari.Size = new Size(139, 24);
            dtpDari.TabIndex = 2;
            // 
            // lblSampai
            // 
            lblSampai.AutoSize = true;
            lblSampai.BackColor = Color.Transparent;
            lblSampai.Font = new Font("Segoe UI", 9.5F);
            lblSampai.ForeColor = Color.FromArgb(90, 110, 140);
            lblSampai.Location = new Point(404, 25);
            lblSampai.Margin = new Padding(4, 0, 4, 0);
            lblSampai.Name = "lblSampai";
            lblSampai.Size = new Size(51, 17);
            lblSampai.TabIndex = 3;
            lblSampai.Text = "Sampai";
            // 
            // dtpSampai
            // 
            dtpSampai.Font = new Font("Segoe UI", 9.5F);
            dtpSampai.Format = DateTimePickerFormat.Short;
            dtpSampai.Location = new Point(460, 21);
            dtpSampai.Margin = new Padding(4, 3, 4, 3);
            dtpSampai.Name = "dtpSampai";
            dtpSampai.Size = new Size(139, 24);
            dtpSampai.TabIndex = 4;
            // 
            // cmbKasir
            // 
            cmbKasir.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbKasir.Font = new Font("Segoe UI", 10F);
            cmbKasir.FormattingEnabled = true;
            cmbKasir.Location = new Point(614, 21);
            cmbKasir.Margin = new Padding(0);
            cmbKasir.Name = "cmbKasir";
            cmbKasir.Size = new Size(151, 25);
            cmbKasir.TabIndex = 5;
            // 
            // txtCari
            // 
            txtCari.Font = new Font("Segoe UI", 10F);
            txtCari.Location = new Point(779, 21);
            txtCari.Margin = new Padding(0);
            txtCari.Name = "txtCari";
            txtCari.PlaceholderText = "Cari kode transaksi...";
            txtCari.Size = new Size(198, 25);
            txtCari.TabIndex = 6;
            // 
            // btnTampilkan
            // 
            btnTampilkan.BackColor = Color.FromArgb(30, 136, 229);
            btnTampilkan.BorderColor = Color.Transparent;
            btnTampilkan.FlatStyle = FlatStyle.Flat;
            btnTampilkan.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            btnTampilkan.ForeColor = Color.White;
            btnTampilkan.HoverColor = Color.FromArgb(21, 101, 192);
            btnTampilkan.Location = new Point(992, 14);
            btnTampilkan.Margin = new Padding(4, 3, 4, 3);
            btnTampilkan.Name = "btnTampilkan";
            btnTampilkan.Size = new Size(100, 42);
            btnTampilkan.TabIndex = 7;
            btnTampilkan.Text = "Tampilkan";
            btnTampilkan.UseVisualStyleBackColor = false;
            // 
            // btnExport
            // 
            btnExport.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExport.BackColor = Color.White;
            btnExport.BorderColor = Color.FromArgb(30, 136, 229);
            btnExport.FlatStyle = FlatStyle.Flat;
            btnExport.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            btnExport.ForeColor = Color.FromArgb(30, 136, 229);
            btnExport.HoverColor = Color.FromArgb(225, 240, 255);
            btnExport.Location = new Point(1098, 14);
            btnExport.Margin = new Padding(4, 3, 4, 3);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(124, 42);
            btnExport.TabIndex = 8;
            btnExport.Text = "Export CSV";
            btnExport.UseVisualStyleBackColor = false;
            // 
            // tlpMain
            // 
            tlpMain.ColumnCount = 2;
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tlpMain.Controls.Add(pnlTrx, 0, 0);
            tlpMain.Controls.Add(tlpKanan, 1, 0);
            tlpMain.Dock = DockStyle.Fill;
            tlpMain.Location = new Point(0, 222);
            tlpMain.Margin = new Padding(0);
            tlpMain.Name = "tlpMain";
            tlpMain.RowCount = 1;
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpMain.Size = new Size(1245, 570);
            tlpMain.TabIndex = 2;
            // 
            // pnlTrx
            // 
            pnlTrx.AccentColor = Color.Transparent;
            pnlTrx.BackColor = Color.White;
            pnlTrx.BorderColor = Color.FromArgb(214, 228, 245);
            pnlTrx.Controls.Add(dgvTrx);
            pnlTrx.Controls.Add(lblDaftarTrxJudul);
            pnlTrx.Dock = DockStyle.Fill;
            pnlTrx.Location = new Point(0, 0);
            pnlTrx.Margin = new Padding(0, 0, 14, 0);
            pnlTrx.Name = "pnlTrx";
            pnlTrx.Padding = new Padding(23, 16, 23, 18);
            pnlTrx.Radius = 18;
            pnlTrx.Size = new Size(733, 570);
            pnlTrx.TabIndex = 0;
            // 
            // dgvTrx
            // 
            dgvTrx.Columns.AddRange(new DataGridViewColumn[] { colNo, colKode, colTanggal, colKasir, colItem, colTotal });
            dgvTrx.Dock = DockStyle.Fill;
            dgvTrx.Location = new Point(23, 55);
            dgvTrx.Margin = new Padding(0);
            dgvTrx.Name = "dgvTrx";
            dgvTrx.Size = new Size(687, 497);
            dgvTrx.TabIndex = 0;
            // 
            // colNo
            // 
            colNo.FillWeight = 7F;
            colNo.HeaderText = "No";
            colNo.Name = "colNo";
            // 
            // colKode
            // 
            colKode.FillWeight = 20F;
            colKode.HeaderText = "Kode Transaksi";
            colKode.Name = "colKode";
            // 
            // colTanggal
            // 
            colTanggal.FillWeight = 22F;
            colTanggal.HeaderText = "Tanggal";
            colTanggal.Name = "colTanggal";
            // 
            // colKasir
            // 
            colKasir.FillWeight = 20F;
            colKasir.HeaderText = "Nama Kasir";
            colKasir.Name = "colKasir";
            // 
            // colItem
            // 
            colItem.FillWeight = 9F;
            colItem.HeaderText = "Item";
            colItem.Name = "colItem";
            // 
            // colTotal
            // 
            colTotal.FillWeight = 22F;
            colTotal.HeaderText = "Total Harga";
            colTotal.Name = "colTotal";
            // 
            // lblDaftarTrxJudul
            // 
            lblDaftarTrxJudul.BackColor = Color.Transparent;
            lblDaftarTrxJudul.Dock = DockStyle.Top;
            lblDaftarTrxJudul.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblDaftarTrxJudul.ForeColor = Color.FromArgb(13, 47, 110);
            lblDaftarTrxJudul.Location = new Point(23, 16);
            lblDaftarTrxJudul.Margin = new Padding(4, 0, 4, 0);
            lblDaftarTrxJudul.Name = "lblDaftarTrxJudul";
            lblDaftarTrxJudul.Size = new Size(687, 39);
            lblDaftarTrxJudul.TabIndex = 1;
            lblDaftarTrxJudul.Text = "Daftar Transaksi";
            lblDaftarTrxJudul.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tlpKanan
            // 
            tlpKanan.ColumnCount = 1;
            tlpKanan.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpKanan.Controls.Add(pnlDetail, 0, 0);
            tlpKanan.Controls.Add(pnlTop, 0, 1);
            tlpKanan.Dock = DockStyle.Fill;
            tlpKanan.Location = new Point(747, 0);
            tlpKanan.Margin = new Padding(0);
            tlpKanan.Name = "tlpKanan";
            tlpKanan.RowCount = 2;
            tlpKanan.RowStyles.Add(new RowStyle(SizeType.Percent, 55F));
            tlpKanan.RowStyles.Add(new RowStyle(SizeType.Percent, 45F));
            tlpKanan.Size = new Size(498, 570);
            tlpKanan.TabIndex = 1;
            // 
            // pnlDetail
            // 
            pnlDetail.AccentColor = Color.Transparent;
            pnlDetail.BackColor = Color.White;
            pnlDetail.BorderColor = Color.FromArgb(214, 228, 245);
            pnlDetail.Controls.Add(dgvDetail);
            pnlDetail.Controls.Add(lblDetailTotal);
            pnlDetail.Controls.Add(lblDetailNo);
            pnlDetail.Controls.Add(lblDetailJudul);
            pnlDetail.Dock = DockStyle.Fill;
            pnlDetail.Location = new Point(0, 0);
            pnlDetail.Margin = new Padding(0, 0, 0, 14);
            pnlDetail.Name = "pnlDetail";
            pnlDetail.Padding = new Padding(23, 16, 23, 18);
            pnlDetail.Radius = 18;
            pnlDetail.Size = new Size(498, 299);
            pnlDetail.TabIndex = 0;
            // 
            // dgvDetail
            // 
            dgvDetail.Columns.AddRange(new DataGridViewColumn[] { colDBarang, colDQty, colDSubtotal });
            dgvDetail.Dock = DockStyle.Fill;
            dgvDetail.Location = new Point(23, 83);
            dgvDetail.Margin = new Padding(0);
            dgvDetail.Name = "dgvDetail";
            dgvDetail.Size = new Size(452, 159);
            dgvDetail.TabIndex = 0;
            // 
            // colDBarang
            // 
            colDBarang.FillWeight = 52F;
            colDBarang.HeaderText = "Barang";
            colDBarang.Name = "colDBarang";
            // 
            // colDQty
            // 
            colDQty.FillWeight = 14F;
            colDQty.HeaderText = "Qty";
            colDQty.Name = "colDQty";
            // 
            // colDSubtotal
            // 
            colDSubtotal.FillWeight = 34F;
            colDSubtotal.HeaderText = "Subtotal";
            colDSubtotal.Name = "colDSubtotal";
            // 
            // lblDetailTotal
            // 
            lblDetailTotal.BackColor = Color.Transparent;
            lblDetailTotal.Dock = DockStyle.Bottom;
            lblDetailTotal.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold);
            lblDetailTotal.ForeColor = Color.FromArgb(30, 136, 229);
            lblDetailTotal.Location = new Point(23, 242);
            lblDetailTotal.Margin = new Padding(4, 0, 4, 0);
            lblDetailTotal.Name = "lblDetailTotal";
            lblDetailTotal.Size = new Size(452, 39);
            lblDetailTotal.TabIndex = 1;
            lblDetailTotal.Text = "Total: Rp 0";
            lblDetailTotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblDetailNo
            // 
            lblDetailNo.BackColor = Color.Transparent;
            lblDetailNo.Dock = DockStyle.Top;
            lblDetailNo.Font = new Font("Segoe UI", 9F);
            lblDetailNo.ForeColor = Color.FromArgb(90, 110, 140);
            lblDetailNo.Location = new Point(23, 55);
            lblDetailNo.Margin = new Padding(4, 0, 4, 0);
            lblDetailNo.Name = "lblDetailNo";
            lblDetailNo.Size = new Size(452, 28);
            lblDetailNo.TabIndex = 2;
            lblDetailNo.Text = "Pilih transaksi untuk melihat detail";
            lblDetailNo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblDetailJudul
            // 
            lblDetailJudul.BackColor = Color.Transparent;
            lblDetailJudul.Dock = DockStyle.Top;
            lblDetailJudul.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblDetailJudul.ForeColor = Color.FromArgb(13, 47, 110);
            lblDetailJudul.Location = new Point(23, 16);
            lblDetailJudul.Margin = new Padding(4, 0, 4, 0);
            lblDetailJudul.Name = "lblDetailJudul";
            lblDetailJudul.Size = new Size(452, 39);
            lblDetailJudul.TabIndex = 3;
            lblDetailJudul.Text = "Detail Transaksi";
            lblDetailJudul.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlTop
            // 
            pnlTop.AccentColor = Color.Transparent;
            pnlTop.BackColor = Color.White;
            pnlTop.BorderColor = Color.FromArgb(214, 228, 245);
            pnlTop.Controls.Add(dgvTop);
            pnlTop.Controls.Add(lblTopJudul);
            pnlTop.Dock = DockStyle.Fill;
            pnlTop.Location = new Point(0, 313);
            pnlTop.Margin = new Padding(0);
            pnlTop.Name = "pnlTop";
            pnlTop.Padding = new Padding(23, 16, 23, 18);
            pnlTop.Radius = 18;
            pnlTop.Size = new Size(498, 257);
            pnlTop.TabIndex = 1;
            // 
            // dgvTop
            // 
            dgvTop.Columns.AddRange(new DataGridViewColumn[] { colTBarang, colTQty, colTOmzet });
            dgvTop.Dock = DockStyle.Fill;
            dgvTop.Location = new Point(23, 55);
            dgvTop.Margin = new Padding(0);
            dgvTop.Name = "dgvTop";
            dgvTop.Size = new Size(452, 184);
            dgvTop.TabIndex = 0;
            // 
            // colTBarang
            // 
            colTBarang.FillWeight = 50F;
            colTBarang.HeaderText = "Barang";
            colTBarang.Name = "colTBarang";
            // 
            // colTQty
            // 
            colTQty.FillWeight = 18F;
            colTQty.HeaderText = "Terjual";
            colTQty.Name = "colTQty";
            // 
            // colTOmzet
            // 
            colTOmzet.FillWeight = 32F;
            colTOmzet.HeaderText = "Omzet";
            colTOmzet.Name = "colTOmzet";
            // 
            // lblTopJudul
            // 
            lblTopJudul.BackColor = Color.Transparent;
            lblTopJudul.Dock = DockStyle.Top;
            lblTopJudul.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblTopJudul.ForeColor = Color.FromArgb(13, 47, 110);
            lblTopJudul.Location = new Point(23, 16);
            lblTopJudul.Margin = new Padding(4, 0, 4, 0);
            lblTopJudul.Name = "lblTopJudul";
            lblTopJudul.Size = new Size(452, 39);
            lblTopJudul.TabIndex = 1;
            lblTopJudul.Text = "5 Barang Terlaris";
            lblTopJudul.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // UC_Laporan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(234, 243, 252);
            Controls.Add(tlpRoot);
            Margin = new Padding(4, 3, 4, 3);
            Name = "UC_Laporan";
            Size = new Size(1283, 923);
            tlpRoot.ResumeLayout(false);
            pnlJudul.ResumeLayout(false);
            pnlJudul.PerformLayout();
            tlpContent.ResumeLayout(false);
            tlpStats.ResumeLayout(false);
            cardPendapatan.ResumeLayout(false);
            cardPendapatan.PerformLayout();
            cardTrx.ResumeLayout(false);
            cardTrx.PerformLayout();
            cardItem.ResumeLayout(false);
            cardItem.PerformLayout();
            cardRata.ResumeLayout(false);
            cardRata.PerformLayout();
            pnlFilter.ResumeLayout(false);
            pnlFilter.PerformLayout();
            tlpMain.ResumeLayout(false);
            pnlTrx.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTrx).EndInit();
            tlpKanan.ResumeLayout(false);
            pnlDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDetail).EndInit();
            pnlTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTop).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpRoot;
        private RoundedPanelUI pnlJudul;
        private System.Windows.Forms.Label lblSub;
        private System.Windows.Forms.Label lblJudul;
        private System.Windows.Forms.TableLayoutPanel tlpContent;
        private System.Windows.Forms.TableLayoutPanel tlpStats;
        private RoundedPanelUI cardPendapatan;
        private System.Windows.Forms.Label lblPendapatanKet;
        private System.Windows.Forms.Label lblPendapatanNilai;
        private System.Windows.Forms.Label lblPendapatanJudul;
        private RoundedPanelUI cardTrx;
        private System.Windows.Forms.Label lblTrxKet;
        private System.Windows.Forms.Label lblTrxNilai;
        private System.Windows.Forms.Label lblTrxJudul;
        private RoundedPanelUI cardItem;
        private System.Windows.Forms.Label lblItemKet;
        private System.Windows.Forms.Label lblItemNilai;
        private System.Windows.Forms.Label lblItemJudul;
        private RoundedPanelUI cardRata;
        private System.Windows.Forms.Label lblRataKet;
        private System.Windows.Forms.Label lblRataNilai;
        private System.Windows.Forms.Label lblRataJudul;
        private RoundedPanelUI pnlFilter;
        private System.Windows.Forms.ComboBox cmbRentang;
        private System.Windows.Forms.Label lblDari;
        private System.Windows.Forms.DateTimePicker dtpDari;
        private System.Windows.Forms.Label lblSampai;
        private System.Windows.Forms.DateTimePicker dtpSampai;
        private System.Windows.Forms.ComboBox cmbKasir;
        private System.Windows.Forms.TextBox txtCari;
        private RoundedButtonUI btnTampilkan;
        private RoundedButtonUI btnExport;
        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private RoundedPanelUI pnlTrx;
        private System.Windows.Forms.DataGridView dgvTrx;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTanggal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKasir;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
        private System.Windows.Forms.Label lblDaftarTrxJudul;
        private System.Windows.Forms.TableLayoutPanel tlpKanan;
        private RoundedPanelUI pnlDetail;
        private System.Windows.Forms.DataGridView dgvDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDBarang;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDSubtotal;
        private System.Windows.Forms.Label lblDetailTotal;
        private System.Windows.Forms.Label lblDetailNo;
        private System.Windows.Forms.Label lblDetailJudul;
        private RoundedPanelUI pnlTop;
        private System.Windows.Forms.DataGridView dgvTop;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTBarang;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTOmzet;
        private System.Windows.Forms.Label lblTopJudul;
    }
}