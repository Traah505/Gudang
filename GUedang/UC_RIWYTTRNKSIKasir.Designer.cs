namespace GUedang
{
    partial class UC_RIWYTTRNKSIKasir
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
            lblJam = new Label();
            lblTanggal = new Label();
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
            cmbMetode = new ComboBox();
            txtCari = new TextBox();
            btnExport = new RoundedButtonUI();
            tlpMain = new TableLayoutPanel();
            pnlRiwayat = new RoundedPanelUI();
            dgvRiwayat = new DataGridView();
            colNo = new DataGridViewTextBoxColumn();
            colKode = new DataGridViewTextBoxColumn();
            colWaktu = new DataGridViewTextBoxColumn();
            colKasir = new DataGridViewTextBoxColumn();
            colItem = new DataGridViewTextBoxColumn();
            colMetode = new DataGridViewTextBoxColumn();
            colTotal = new DataGridViewTextBoxColumn();
            lblRiwayatJudul = new Label();
            pnlDetail = new RoundedPanelUI();
            tlpDetail = new TableLayoutPanel();
            lblDetailNo = new Label();
            dgvDetail = new DataGridView();
            colDBarang = new DataGridViewTextBoxColumn();
            colDQty = new DataGridViewTextBoxColumn();
            colDHarga = new DataGridViewTextBoxColumn();
            colDSubtotal = new DataGridViewTextBoxColumn();
            tlpSum = new TableLayoutPanel();
            lblSumSubtotalJudul = new Label();
            lblSumSubtotalNilai = new Label();
            lblSumDiskonJudul = new Label();
            lblSumDiskonNilai = new Label();
            lblSumTotalJudul = new Label();
            lblSumTotalNilai = new Label();
            lblSumBayarJudul = new Label();
            lblSumBayarNilai = new Label();
            lblSumKembaliJudul = new Label();
            lblSumKembaliNilai = new Label();
            flowCetak = new FlowLayoutPanel();
            btnCetak = new RoundedButtonUI();
            lblDetailJudul = new Label();
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
            pnlRiwayat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRiwayat).BeginInit();
            pnlDetail.SuspendLayout();
            tlpDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetail).BeginInit();
            tlpSum.SuspendLayout();
            flowCetak.SuspendLayout();
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
            // 
            // pnlJudul
            // 
            pnlJudul.AccentColor = Color.Transparent;
            pnlJudul.BackColor = Color.White;
            pnlJudul.BorderColor = Color.FromArgb(214, 228, 245);
            pnlJudul.Controls.Add(lblJam);
            pnlJudul.Controls.Add(lblTanggal);
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
            // lblJam
            // 
            lblJam.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblJam.BackColor = Color.Transparent;
            lblJam.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            lblJam.ForeColor = Color.FromArgb(24, 94, 224);
            lblJam.Location = new Point(897, 9);
            lblJam.Margin = new Padding(4, 0, 4, 0);
            lblJam.Name = "lblJam";
            lblJam.Size = new Size(315, 37);
            lblJam.TabIndex = 0;
            lblJam.Text = "00:00:00";
            lblJam.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblTanggal
            // 
            lblTanggal.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTanggal.BackColor = Color.Transparent;
            lblTanggal.Font = new Font("Segoe UI", 9F);
            lblTanggal.ForeColor = Color.FromArgb(90, 110, 140);
            lblTanggal.Location = new Point(862, 48);
            lblTanggal.Margin = new Padding(4, 0, 4, 0);
            lblTanggal.Name = "lblTanggal";
            lblTanggal.Size = new Size(350, 23);
            lblTanggal.TabIndex = 1;
            lblTanggal.Text = "Sabtu, 21 November 2026";
            lblTanggal.TextAlign = ContentAlignment.MiddleRight;
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
            lblSub.Size = new Size(375, 17);
            lblSub.TabIndex = 2;
            lblSub.Text = "Lihat semua transaksi penjualan, detail barang, dan cetak struk.";
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
            lblJudul.Size = new Size(186, 30);
            lblJudul.TabIndex = 3;
            lblJudul.Text = "Riwayat Transaksi";
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
            tlpContent.Paint += tlpContent_Paint;
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
            pnlFilter.Controls.Add(cmbMetode);
            pnlFilter.Controls.Add(txtCari);
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
            // cmbMetode
            // 
            cmbMetode.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMetode.Font = new Font("Segoe UI", 10F);
            cmbMetode.FormattingEnabled = true;
            cmbMetode.Items.AddRange(new object[] { "Semua metode", "Tunai", "QRIS", "Transfer" });
            cmbMetode.Location = new Point(614, 21);
            cmbMetode.Margin = new Padding(0);
            cmbMetode.Name = "cmbMetode";
            cmbMetode.Size = new Size(151, 25);
            cmbMetode.TabIndex = 5;
            // 
            // txtCari
            // 
            txtCari.Font = new Font("Segoe UI", 10F);
            txtCari.Location = new Point(779, 21);
            txtCari.Margin = new Padding(0);
            txtCari.Name = "txtCari";
            txtCari.PlaceholderText = "Cari no transaksi / kasir...";
            txtCari.Size = new Size(233, 25);
            txtCari.TabIndex = 6;
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
            btnExport.TabIndex = 7;
            btnExport.Text = "Export CSV";
            btnExport.UseVisualStyleBackColor = false;
            // 
            // tlpMain
            // 
            tlpMain.ColumnCount = 2;
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 62F));
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38F));
            tlpMain.Controls.Add(pnlRiwayat, 0, 0);
            tlpMain.Controls.Add(pnlDetail, 1, 0);
            tlpMain.Dock = DockStyle.Fill;
            tlpMain.Location = new Point(0, 222);
            tlpMain.Margin = new Padding(0);
            tlpMain.Name = "tlpMain";
            tlpMain.RowCount = 1;
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpMain.Size = new Size(1245, 570);
            tlpMain.TabIndex = 2;
            // 
            // pnlRiwayat
            // 
            pnlRiwayat.AccentColor = Color.Transparent;
            pnlRiwayat.BackColor = Color.White;
            pnlRiwayat.BorderColor = Color.FromArgb(214, 228, 245);
            pnlRiwayat.Controls.Add(dgvRiwayat);
            pnlRiwayat.Controls.Add(lblRiwayatJudul);
            pnlRiwayat.Dock = DockStyle.Fill;
            pnlRiwayat.Location = new Point(0, 0);
            pnlRiwayat.Margin = new Padding(0, 0, 14, 0);
            pnlRiwayat.Name = "pnlRiwayat";
            pnlRiwayat.Padding = new Padding(23, 16, 23, 18);
            pnlRiwayat.Radius = 18;
            pnlRiwayat.Size = new Size(757, 570);
            pnlRiwayat.TabIndex = 0;
            // 
            // dgvRiwayat
            // 
            dgvRiwayat.Columns.AddRange(new DataGridViewColumn[] { colNo, colKode, colWaktu, colKasir, colItem, colMetode, colTotal });
            dgvRiwayat.Dock = DockStyle.Fill;
            dgvRiwayat.Location = new Point(23, 55);
            dgvRiwayat.Margin = new Padding(0);
            dgvRiwayat.Name = "dgvRiwayat";
            dgvRiwayat.Size = new Size(711, 497);
            dgvRiwayat.TabIndex = 0;
            // 
            // colNo
            // 
            colNo.FillWeight = 6F;
            colNo.HeaderText = "No";
            colNo.Name = "colNo";
            // 
            // colKode
            // 
            colKode.FillWeight = 17F;
            colKode.HeaderText = "No Transaksi";
            colKode.Name = "colKode";
            // 
            // colWaktu
            // 
            colWaktu.FillWeight = 20F;
            colWaktu.HeaderText = "Waktu";
            colWaktu.Name = "colWaktu";
            // 
            // colKasir
            // 
            colKasir.FillWeight = 16F;
            colKasir.HeaderText = "Kasir";
            colKasir.Name = "colKasir";
            // 
            // colItem
            // 
            colItem.FillWeight = 8F;
            colItem.HeaderText = "Item";
            colItem.Name = "colItem";
            // 
            // colMetode
            // 
            colMetode.FillWeight = 12F;
            colMetode.HeaderText = "Metode";
            colMetode.Name = "colMetode";
            // 
            // colTotal
            // 
            colTotal.FillWeight = 21F;
            colTotal.HeaderText = "Total";
            colTotal.Name = "colTotal";
            // 
            // lblRiwayatJudul
            // 
            lblRiwayatJudul.BackColor = Color.Transparent;
            lblRiwayatJudul.Dock = DockStyle.Top;
            lblRiwayatJudul.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblRiwayatJudul.ForeColor = Color.FromArgb(13, 47, 110);
            lblRiwayatJudul.Location = new Point(23, 16);
            lblRiwayatJudul.Margin = new Padding(4, 0, 4, 0);
            lblRiwayatJudul.Name = "lblRiwayatJudul";
            lblRiwayatJudul.Size = new Size(711, 39);
            lblRiwayatJudul.TabIndex = 1;
            lblRiwayatJudul.Text = "Daftar Transaksi";
            lblRiwayatJudul.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlDetail
            // 
            pnlDetail.AccentColor = Color.Transparent;
            pnlDetail.BackColor = Color.White;
            pnlDetail.BorderColor = Color.FromArgb(214, 228, 245);
            pnlDetail.Controls.Add(tlpDetail);
            pnlDetail.Controls.Add(lblDetailJudul);
            pnlDetail.Dock = DockStyle.Fill;
            pnlDetail.Location = new Point(771, 0);
            pnlDetail.Margin = new Padding(0);
            pnlDetail.Name = "pnlDetail";
            pnlDetail.Padding = new Padding(23, 16, 23, 18);
            pnlDetail.Radius = 18;
            pnlDetail.Size = new Size(474, 570);
            pnlDetail.TabIndex = 1;
            // 
            // tlpDetail
            // 
            tlpDetail.ColumnCount = 1;
            tlpDetail.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpDetail.Controls.Add(lblDetailNo, 0, 0);
            tlpDetail.Controls.Add(dgvDetail, 0, 1);
            tlpDetail.Controls.Add(tlpSum, 0, 2);
            tlpDetail.Controls.Add(flowCetak, 0, 3);
            tlpDetail.Dock = DockStyle.Fill;
            tlpDetail.Location = new Point(23, 55);
            tlpDetail.Margin = new Padding(0);
            tlpDetail.Name = "tlpDetail";
            tlpDetail.RowCount = 4;
            tlpDetail.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tlpDetail.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpDetail.RowStyles.Add(new RowStyle(SizeType.Absolute, 134F));
            tlpDetail.RowStyles.Add(new RowStyle(SizeType.Absolute, 58F));
            tlpDetail.Size = new Size(428, 497);
            tlpDetail.TabIndex = 0;
            // 
            // lblDetailNo
            // 
            lblDetailNo.BackColor = Color.Transparent;
            lblDetailNo.Dock = DockStyle.Fill;
            lblDetailNo.Font = new Font("Segoe UI", 9F);
            lblDetailNo.ForeColor = Color.FromArgb(90, 110, 140);
            lblDetailNo.Location = new Point(0, 0);
            lblDetailNo.Margin = new Padding(0);
            lblDetailNo.Name = "lblDetailNo";
            lblDetailNo.Size = new Size(428, 28);
            lblDetailNo.TabIndex = 0;
            lblDetailNo.Text = "Pilih transaksi untuk melihat detail";
            lblDetailNo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dgvDetail
            // 
            dgvDetail.Columns.AddRange(new DataGridViewColumn[] { colDBarang, colDQty, colDHarga, colDSubtotal });
            dgvDetail.Dock = DockStyle.Fill;
            dgvDetail.Location = new Point(0, 28);
            dgvDetail.Margin = new Padding(0);
            dgvDetail.Name = "dgvDetail";
            dgvDetail.Size = new Size(428, 277);
            dgvDetail.TabIndex = 1;
            // 
            // colDBarang
            // 
            colDBarang.FillWeight = 40F;
            colDBarang.HeaderText = "Barang";
            colDBarang.Name = "colDBarang";
            // 
            // colDQty
            // 
            colDQty.FillWeight = 12F;
            colDQty.HeaderText = "Qty";
            colDQty.Name = "colDQty";
            // 
            // colDHarga
            // 
            colDHarga.FillWeight = 22F;
            colDHarga.HeaderText = "Harga";
            colDHarga.Name = "colDHarga";
            // 
            // colDSubtotal
            // 
            colDSubtotal.FillWeight = 26F;
            colDSubtotal.HeaderText = "Subtotal";
            colDSubtotal.Name = "colDSubtotal";
            // 
            // tlpSum
            // 
            tlpSum.ColumnCount = 2;
            tlpSum.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55F));
            tlpSum.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            tlpSum.Controls.Add(lblSumSubtotalJudul, 0, 0);
            tlpSum.Controls.Add(lblSumSubtotalNilai, 1, 0);
            tlpSum.Controls.Add(lblSumDiskonJudul, 0, 1);
            tlpSum.Controls.Add(lblSumDiskonNilai, 1, 1);
            tlpSum.Controls.Add(lblSumTotalJudul, 0, 2);
            tlpSum.Controls.Add(lblSumTotalNilai, 1, 2);
            tlpSum.Controls.Add(lblSumBayarJudul, 0, 3);
            tlpSum.Controls.Add(lblSumBayarNilai, 1, 3);
            tlpSum.Controls.Add(lblSumKembaliJudul, 0, 4);
            tlpSum.Controls.Add(lblSumKembaliNilai, 1, 4);
            tlpSum.Dock = DockStyle.Fill;
            tlpSum.Location = new Point(0, 305);
            tlpSum.Margin = new Padding(0);
            tlpSum.Name = "tlpSum";
            tlpSum.RowCount = 5;
            tlpSum.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tlpSum.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tlpSum.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tlpSum.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tlpSum.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tlpSum.Size = new Size(428, 134);
            tlpSum.TabIndex = 2;
            // 
            // lblSumSubtotalJudul
            // 
            lblSumSubtotalJudul.BackColor = Color.Transparent;
            lblSumSubtotalJudul.Dock = DockStyle.Fill;
            lblSumSubtotalJudul.Font = new Font("Segoe UI", 9.5F);
            lblSumSubtotalJudul.ForeColor = Color.FromArgb(90, 110, 140);
            lblSumSubtotalJudul.Location = new Point(0, 0);
            lblSumSubtotalJudul.Margin = new Padding(0);
            lblSumSubtotalJudul.Name = "lblSumSubtotalJudul";
            lblSumSubtotalJudul.Size = new Size(235, 25);
            lblSumSubtotalJudul.TabIndex = 0;
            lblSumSubtotalJudul.Text = "Subtotal";
            lblSumSubtotalJudul.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblSumSubtotalNilai
            // 
            lblSumSubtotalNilai.BackColor = Color.Transparent;
            lblSumSubtotalNilai.Dock = DockStyle.Fill;
            lblSumSubtotalNilai.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblSumSubtotalNilai.ForeColor = Color.FromArgb(13, 47, 110);
            lblSumSubtotalNilai.Location = new Point(235, 0);
            lblSumSubtotalNilai.Margin = new Padding(0);
            lblSumSubtotalNilai.Name = "lblSumSubtotalNilai";
            lblSumSubtotalNilai.Size = new Size(193, 25);
            lblSumSubtotalNilai.TabIndex = 1;
            lblSumSubtotalNilai.Text = "Rp 0";
            lblSumSubtotalNilai.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblSumDiskonJudul
            // 
            lblSumDiskonJudul.BackColor = Color.Transparent;
            lblSumDiskonJudul.Dock = DockStyle.Fill;
            lblSumDiskonJudul.Font = new Font("Segoe UI", 9.5F);
            lblSumDiskonJudul.ForeColor = Color.FromArgb(90, 110, 140);
            lblSumDiskonJudul.Location = new Point(0, 25);
            lblSumDiskonJudul.Margin = new Padding(0);
            lblSumDiskonJudul.Name = "lblSumDiskonJudul";
            lblSumDiskonJudul.Size = new Size(235, 25);
            lblSumDiskonJudul.TabIndex = 2;
            lblSumDiskonJudul.Text = "Diskon";
            lblSumDiskonJudul.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblSumDiskonNilai
            // 
            lblSumDiskonNilai.BackColor = Color.Transparent;
            lblSumDiskonNilai.Dock = DockStyle.Fill;
            lblSumDiskonNilai.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblSumDiskonNilai.ForeColor = Color.FromArgb(13, 47, 110);
            lblSumDiskonNilai.Location = new Point(235, 25);
            lblSumDiskonNilai.Margin = new Padding(0);
            lblSumDiskonNilai.Name = "lblSumDiskonNilai";
            lblSumDiskonNilai.Size = new Size(193, 25);
            lblSumDiskonNilai.TabIndex = 3;
            lblSumDiskonNilai.Text = "Rp 0";
            lblSumDiskonNilai.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblSumTotalJudul
            // 
            lblSumTotalJudul.BackColor = Color.Transparent;
            lblSumTotalJudul.Dock = DockStyle.Fill;
            lblSumTotalJudul.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold);
            lblSumTotalJudul.ForeColor = Color.FromArgb(13, 47, 110);
            lblSumTotalJudul.Location = new Point(0, 50);
            lblSumTotalJudul.Margin = new Padding(0);
            lblSumTotalJudul.Name = "lblSumTotalJudul";
            lblSumTotalJudul.Size = new Size(235, 32);
            lblSumTotalJudul.TabIndex = 4;
            lblSumTotalJudul.Text = "Total";
            lblSumTotalJudul.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblSumTotalNilai
            // 
            lblSumTotalNilai.BackColor = Color.Transparent;
            lblSumTotalNilai.Dock = DockStyle.Fill;
            lblSumTotalNilai.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblSumTotalNilai.ForeColor = Color.FromArgb(30, 136, 229);
            lblSumTotalNilai.Location = new Point(235, 50);
            lblSumTotalNilai.Margin = new Padding(0);
            lblSumTotalNilai.Name = "lblSumTotalNilai";
            lblSumTotalNilai.Size = new Size(193, 32);
            lblSumTotalNilai.TabIndex = 5;
            lblSumTotalNilai.Text = "Rp 0";
            lblSumTotalNilai.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblSumBayarJudul
            // 
            lblSumBayarJudul.BackColor = Color.Transparent;
            lblSumBayarJudul.Dock = DockStyle.Fill;
            lblSumBayarJudul.Font = new Font("Segoe UI", 9.5F);
            lblSumBayarJudul.ForeColor = Color.FromArgb(90, 110, 140);
            lblSumBayarJudul.Location = new Point(0, 82);
            lblSumBayarJudul.Margin = new Padding(0);
            lblSumBayarJudul.Name = "lblSumBayarJudul";
            lblSumBayarJudul.Size = new Size(235, 25);
            lblSumBayarJudul.TabIndex = 6;
            lblSumBayarJudul.Text = "Bayar";
            lblSumBayarJudul.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblSumBayarNilai
            // 
            lblSumBayarNilai.BackColor = Color.Transparent;
            lblSumBayarNilai.Dock = DockStyle.Fill;
            lblSumBayarNilai.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblSumBayarNilai.ForeColor = Color.FromArgb(13, 47, 110);
            lblSumBayarNilai.Location = new Point(235, 82);
            lblSumBayarNilai.Margin = new Padding(0);
            lblSumBayarNilai.Name = "lblSumBayarNilai";
            lblSumBayarNilai.Size = new Size(193, 25);
            lblSumBayarNilai.TabIndex = 7;
            lblSumBayarNilai.Text = "Rp 0";
            lblSumBayarNilai.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblSumKembaliJudul
            // 
            lblSumKembaliJudul.BackColor = Color.Transparent;
            lblSumKembaliJudul.Dock = DockStyle.Fill;
            lblSumKembaliJudul.Font = new Font("Segoe UI", 9.5F);
            lblSumKembaliJudul.ForeColor = Color.FromArgb(90, 110, 140);
            lblSumKembaliJudul.Location = new Point(0, 107);
            lblSumKembaliJudul.Margin = new Padding(0);
            lblSumKembaliJudul.Name = "lblSumKembaliJudul";
            lblSumKembaliJudul.Size = new Size(235, 27);
            lblSumKembaliJudul.TabIndex = 8;
            lblSumKembaliJudul.Text = "Kembali";
            lblSumKembaliJudul.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblSumKembaliNilai
            // 
            lblSumKembaliNilai.BackColor = Color.Transparent;
            lblSumKembaliNilai.Dock = DockStyle.Fill;
            lblSumKembaliNilai.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblSumKembaliNilai.ForeColor = Color.FromArgb(40, 140, 90);
            lblSumKembaliNilai.Location = new Point(235, 107);
            lblSumKembaliNilai.Margin = new Padding(0);
            lblSumKembaliNilai.Name = "lblSumKembaliNilai";
            lblSumKembaliNilai.Size = new Size(193, 27);
            lblSumKembaliNilai.TabIndex = 9;
            lblSumKembaliNilai.Text = "Rp 0";
            lblSumKembaliNilai.TextAlign = ContentAlignment.MiddleRight;
            // 
            // flowCetak
            // 
            flowCetak.BackColor = Color.White;
            flowCetak.Controls.Add(btnCetak);
            flowCetak.Dock = DockStyle.Fill;
            flowCetak.Location = new Point(0, 439);
            flowCetak.Margin = new Padding(0);
            flowCetak.Name = "flowCetak";
            flowCetak.Padding = new Padding(0, 7, 0, 0);
            flowCetak.Size = new Size(428, 58);
            flowCetak.TabIndex = 3;
            flowCetak.WrapContents = false;
            // 
            // btnCetak
            // 
            btnCetak.BackColor = Color.FromArgb(30, 136, 229);
            btnCetak.BorderColor = Color.Transparent;
            btnCetak.FlatStyle = FlatStyle.Flat;
            btnCetak.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            btnCetak.ForeColor = Color.White;
            btnCetak.HoverColor = Color.FromArgb(21, 101, 192);
            btnCetak.Location = new Point(0, 7);
            btnCetak.Margin = new Padding(0);
            btnCetak.Name = "btnCetak";
            btnCetak.Size = new Size(187, 44);
            btnCetak.TabIndex = 0;
            btnCetak.Text = "Cetak Struk";
            btnCetak.UseVisualStyleBackColor = false;
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
            lblDetailJudul.Size = new Size(428, 39);
            lblDetailJudul.TabIndex = 1;
            lblDetailJudul.Text = "Detail Transaksi";
            lblDetailJudul.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // UC_RIWYTTRNKSIKasir
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(234, 243, 252);
            Controls.Add(tlpRoot);
            Margin = new Padding(4, 3, 4, 3);
            Name = "UC_RIWYTTRNKSIKasir";
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
            pnlRiwayat.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRiwayat).EndInit();
            pnlDetail.ResumeLayout(false);
            tlpDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDetail).EndInit();
            tlpSum.ResumeLayout(false);
            flowCetak.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpRoot;
        private RoundedPanelUI pnlJudul;
        private System.Windows.Forms.Label lblJam;
        private System.Windows.Forms.Label lblTanggal;
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
        private System.Windows.Forms.ComboBox cmbMetode;
        private System.Windows.Forms.TextBox txtCari;
        private RoundedButtonUI btnExport;
        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private RoundedPanelUI pnlRiwayat;
        private System.Windows.Forms.DataGridView dgvRiwayat;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWaktu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKasir;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMetode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
        private System.Windows.Forms.Label lblRiwayatJudul;
        private RoundedPanelUI pnlDetail;
        private System.Windows.Forms.TableLayoutPanel tlpDetail;
        private System.Windows.Forms.Label lblDetailNo;
        private System.Windows.Forms.DataGridView dgvDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDBarang;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDHarga;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDSubtotal;
        private System.Windows.Forms.TableLayoutPanel tlpSum;
        private System.Windows.Forms.Label lblSumSubtotalJudul;
        private System.Windows.Forms.Label lblSumSubtotalNilai;
        private System.Windows.Forms.Label lblSumDiskonJudul;
        private System.Windows.Forms.Label lblSumDiskonNilai;
        private System.Windows.Forms.Label lblSumTotalJudul;
        private System.Windows.Forms.Label lblSumTotalNilai;
        private System.Windows.Forms.Label lblSumBayarJudul;
        private System.Windows.Forms.Label lblSumBayarNilai;
        private System.Windows.Forms.Label lblSumKembaliJudul;
        private System.Windows.Forms.Label lblSumKembaliNilai;
        private System.Windows.Forms.FlowLayoutPanel flowCetak;
        private RoundedButtonUI btnCetak;
        private System.Windows.Forms.Label lblDetailJudul;
    }
}