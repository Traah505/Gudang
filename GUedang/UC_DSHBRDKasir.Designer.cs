namespace GUedang
{
    partial class UC_DSHBRDKasir
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
            this.components = new System.ComponentModel.Container();
            this.tlpRoot = new System.Windows.Forms.TableLayoutPanel();
            this.pnlHeader = new GUedang.RoundedPanelUI();
            this.lblJudul = new System.Windows.Forms.Label();
            this.lblSapaan = new System.Windows.Forms.Label();
            this.lblJam = new System.Windows.Forms.Label();
            this.lblTanggal = new System.Windows.Forms.Label();
            this.btnRefresh = new GUedang.RoundedButtonUI();
            this.tlpCards = new System.Windows.Forms.TableLayoutPanel();
            this.cardPendapatan = new GUedang.RoundedPanelUI();
            this.lblPendapatanJudul = new System.Windows.Forms.Label();
            this.lblPendapatanNilai = new System.Windows.Forms.Label();
            this.lblPendapatanKet = new System.Windows.Forms.Label();
            this.cardTransaksi = new GUedang.RoundedPanelUI();
            this.lblTransaksiJudulKartu = new System.Windows.Forms.Label();
            this.lblTransaksiNilai = new System.Windows.Forms.Label();
            this.lblTransaksiKet = new System.Windows.Forms.Label();
            this.cardTerjual = new GUedang.RoundedPanelUI();
            this.lblTerjualJudul = new System.Windows.Forms.Label();
            this.lblTerjualNilai = new System.Windows.Forms.Label();
            this.lblTerjualKet = new System.Windows.Forms.Label();
            this.cardKeranjang = new GUedang.RoundedPanelUI();
            this.lblKeranjangKartuJudul = new System.Windows.Forms.Label();
            this.lblKeranjangKartuNilai = new System.Windows.Forms.Label();
            this.lblKeranjangKartuKet = new System.Windows.Forms.Label();
            this.tlpContent = new System.Windows.Forms.TableLayoutPanel();
            this.pnlTransaksi = new GUedang.RoundedPanelUI();
            this.dgvTransaksi = new System.Windows.Forms.DataGridView();
            this.colNoTransaksi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWaktu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKasir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTransaksiJudul = new System.Windows.Forms.Label();
            this.tlpKanan = new System.Windows.Forms.TableLayoutPanel();
            this.pnlKeranjang = new GUedang.RoundedPanelUI();
            this.tlpKeranjang = new System.Windows.Forms.TableLayoutPanel();
            this.lblItemJudul = new System.Windows.Forms.Label();
            this.lblTotalBelanjaJudul = new System.Windows.Forms.Label();
            this.lblItemNilai = new System.Windows.Forms.Label();
            this.lblTotalBelanjaNilai = new System.Windows.Forms.Label();
            this.lblKeranjangJudul = new System.Windows.Forms.Label();
            this.pnlRingkasan = new GUedang.RoundedPanelUI();
            this.tlpRingkasan = new System.Windows.Forms.TableLayoutPanel();
            this.lblRingkasanPendapatanJudul = new System.Windows.Forms.Label();
            this.lblRingkasanPendapatanNilai = new System.Windows.Forms.Label();
            this.lblRingkasanTransaksiJudul = new System.Windows.Forms.Label();
            this.lblRingkasanTransaksiNilai = new System.Windows.Forms.Label();
            this.lblRingkasanRataJudul = new System.Windows.Forms.Label();
            this.lblRingkasanRataNilai = new System.Windows.Forms.Label();
            this.lblRingkasanJudul = new System.Windows.Forms.Label();
            this.flowAksi = new System.Windows.Forms.FlowLayoutPanel();
            this.btnTransaksiBaru = new GUedang.RoundedButtonUI();
            this.btnKeranjang = new GUedang.RoundedButtonUI();
            this.btnRiwayat = new GUedang.RoundedButtonUI();
            this.timerJam = new System.Windows.Forms.Timer(this.components);
            this.tlpRoot.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.tlpCards.SuspendLayout();
            this.cardPendapatan.SuspendLayout();
            this.cardTransaksi.SuspendLayout();
            this.cardTerjual.SuspendLayout();
            this.cardKeranjang.SuspendLayout();
            this.tlpContent.SuspendLayout();
            this.pnlTransaksi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransaksi)).BeginInit();
            this.tlpKanan.SuspendLayout();
            this.pnlKeranjang.SuspendLayout();
            this.tlpKeranjang.SuspendLayout();
            this.pnlRingkasan.SuspendLayout();
            this.tlpRingkasan.SuspendLayout();
            this.flowAksi.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpRoot
            // 
            this.tlpRoot.ColumnCount = 1;
            this.tlpRoot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpRoot.Controls.Add(this.pnlHeader, 0, 0);
            this.tlpRoot.Controls.Add(this.tlpCards, 0, 1);
            this.tlpRoot.Controls.Add(this.tlpContent, 0, 2);
            this.tlpRoot.Controls.Add(this.flowAksi, 0, 3);
            this.tlpRoot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpRoot.Location = new System.Drawing.Point(0, 0);
            this.tlpRoot.Name = "tlpRoot";
            this.tlpRoot.Padding = new System.Windows.Forms.Padding(16, 16, 16, 12);
            this.tlpRoot.RowCount = 4;
            this.tlpRoot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 94F));
            this.tlpRoot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 116F));
            this.tlpRoot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpRoot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.tlpRoot.Size = new System.Drawing.Size(1100, 700);
            this.tlpRoot.TabIndex = 0;
            // 
            // pnlHeader
            // 
            this.pnlHeader.AccentColor = System.Drawing.Color.Transparent;
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.BorderColor = System.Drawing.Color.FromArgb(214, 228, 245);
            this.pnlHeader.Controls.Add(this.btnRefresh);
            this.pnlHeader.Controls.Add(this.lblTanggal);
            this.pnlHeader.Controls.Add(this.lblJam);
            this.pnlHeader.Controls.Add(this.lblSapaan);
            this.pnlHeader.Controls.Add(this.lblJudul);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(0, 0, 0, 12);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Radius = 20;
            this.pnlHeader.Size = new System.Drawing.Size(1068, 82);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblJudul
            // 
            this.lblJudul.AutoSize = true;
            this.lblJudul.BackColor = System.Drawing.Color.Transparent;
            this.lblJudul.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.lblJudul.ForeColor = System.Drawing.Color.FromArgb(13, 47, 110);
            this.lblJudul.Location = new System.Drawing.Point(24, 12);
            this.lblJudul.Name = "lblJudul";
            this.lblJudul.Size = new System.Drawing.Size(200, 32);
            this.lblJudul.TabIndex = 0;
            this.lblJudul.Text = "Dashboard Kasir";
            // 
            // lblSapaan
            // 
            this.lblSapaan.AutoSize = true;
            this.lblSapaan.BackColor = System.Drawing.Color.Transparent;
            this.lblSapaan.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblSapaan.ForeColor = System.Drawing.Color.FromArgb(90, 110, 140);
            this.lblSapaan.Location = new System.Drawing.Point(27, 48);
            this.lblSapaan.Name = "lblSapaan";
            this.lblSapaan.Size = new System.Drawing.Size(120, 17);
            this.lblSapaan.TabIndex = 1;
            this.lblSapaan.Text = "Selamat Datang, Kasir";
            // 
            // lblJam
            // 
            this.lblJam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblJam.BackColor = System.Drawing.Color.Transparent;
            this.lblJam.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.lblJam.ForeColor = System.Drawing.Color.FromArgb(24, 94, 224);
            this.lblJam.Location = new System.Drawing.Point(700, 10);
            this.lblJam.Name = "lblJam";
            this.lblJam.Size = new System.Drawing.Size(210, 32);
            this.lblJam.TabIndex = 2;
            this.lblJam.Text = "00:00:00";
            this.lblJam.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTanggal
            // 
            this.lblTanggal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTanggal.BackColor = System.Drawing.Color.Transparent;
            this.lblTanggal.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTanggal.ForeColor = System.Drawing.Color.FromArgb(90, 110, 140);
            this.lblTanggal.Location = new System.Drawing.Point(660, 46);
            this.lblTanggal.Name = "lblTanggal";
            this.lblTanggal.Size = new System.Drawing.Size(250, 20);
            this.lblTanggal.TabIndex = 3;
            this.lblTanggal.Text = "Kamis, 19 November 2026";
            this.lblTanggal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnRefresh.BorderColor = System.Drawing.Color.FromArgb(200, 210, 225);
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.HoverColor = System.Drawing.Color.FromArgb(240, 245, 252);
            this.btnRefresh.Location = new System.Drawing.Point(934, 23);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(110, 36);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            // 
            // tlpCards
            // 
            this.tlpCards.ColumnCount = 4;
            this.tlpCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpCards.Controls.Add(this.cardPendapatan, 0, 0);
            this.tlpCards.Controls.Add(this.cardTransaksi, 1, 0);
            this.tlpCards.Controls.Add(this.cardTerjual, 2, 0);
            this.tlpCards.Controls.Add(this.cardKeranjang, 3, 0);
            this.tlpCards.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpCards.Margin = new System.Windows.Forms.Padding(0);
            this.tlpCards.Name = "tlpCards";
            this.tlpCards.RowCount = 1;
            this.tlpCards.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCards.Size = new System.Drawing.Size(1068, 116);
            this.tlpCards.TabIndex = 1;
            // 
            // cardPendapatan
            // 
            this.cardPendapatan.AccentColor = System.Drawing.Color.FromArgb(30, 136, 229);
            this.cardPendapatan.BackColor = System.Drawing.Color.White;
            this.cardPendapatan.Controls.Add(this.lblPendapatanKet);
            this.cardPendapatan.Controls.Add(this.lblPendapatanNilai);
            this.cardPendapatan.Controls.Add(this.lblPendapatanJudul);
            this.cardPendapatan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardPendapatan.Margin = new System.Windows.Forms.Padding(0, 0, 12, 12);
            this.cardPendapatan.Name = "cardPendapatan";
            this.cardPendapatan.Radius = 18;
            this.cardPendapatan.Size = new System.Drawing.Size(255, 92);
            this.cardPendapatan.TabIndex = 0;
            // 
            // lblPendapatanJudul
            // 
            this.lblPendapatanJudul.AutoSize = true;
            this.lblPendapatanJudul.BackColor = System.Drawing.Color.Transparent;
            this.lblPendapatanJudul.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblPendapatanJudul.ForeColor = System.Drawing.Color.FromArgb(90, 110, 140);
            this.lblPendapatanJudul.Location = new System.Drawing.Point(30, 14);
            this.lblPendapatanJudul.Name = "lblPendapatanJudul";
            this.lblPendapatanJudul.TabIndex = 0;
            this.lblPendapatanJudul.Text = "Total Pendapatan";
            // 
            // lblPendapatanNilai
            // 
            this.lblPendapatanNilai.AutoSize = true;
            this.lblPendapatanNilai.BackColor = System.Drawing.Color.Transparent;
            this.lblPendapatanNilai.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.lblPendapatanNilai.ForeColor = System.Drawing.Color.FromArgb(24, 94, 224);
            this.lblPendapatanNilai.Location = new System.Drawing.Point(28, 32);
            this.lblPendapatanNilai.Name = "lblPendapatanNilai";
            this.lblPendapatanNilai.TabIndex = 1;
            this.lblPendapatanNilai.Text = "Rp 0";
            // 
            // lblPendapatanKet
            // 
            this.lblPendapatanKet.AutoSize = true;
            this.lblPendapatanKet.BackColor = System.Drawing.Color.Transparent;
            this.lblPendapatanKet.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblPendapatanKet.ForeColor = System.Drawing.Color.FromArgb(120, 135, 160);
            this.lblPendapatanKet.Location = new System.Drawing.Point(30, 68);
            this.lblPendapatanKet.Name = "lblPendapatanKet";
            this.lblPendapatanKet.TabIndex = 2;
            this.lblPendapatanKet.Text = "Hari ini";
            // 
            // cardTransaksi
            // 
            this.cardTransaksi.AccentColor = System.Drawing.Color.FromArgb(46, 160, 100);
            this.cardTransaksi.BackColor = System.Drawing.Color.White;
            this.cardTransaksi.Controls.Add(this.lblTransaksiKet);
            this.cardTransaksi.Controls.Add(this.lblTransaksiNilai);
            this.cardTransaksi.Controls.Add(this.lblTransaksiJudulKartu);
            this.cardTransaksi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardTransaksi.Margin = new System.Windows.Forms.Padding(0, 0, 12, 12);
            this.cardTransaksi.Name = "cardTransaksi";
            this.cardTransaksi.Radius = 18;
            this.cardTransaksi.Size = new System.Drawing.Size(255, 92);
            this.cardTransaksi.TabIndex = 1;
            // 
            // lblTransaksiJudulKartu
            // 
            this.lblTransaksiJudulKartu.AutoSize = true;
            this.lblTransaksiJudulKartu.BackColor = System.Drawing.Color.Transparent;
            this.lblTransaksiJudulKartu.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblTransaksiJudulKartu.ForeColor = System.Drawing.Color.FromArgb(90, 110, 140);
            this.lblTransaksiJudulKartu.Location = new System.Drawing.Point(30, 14);
            this.lblTransaksiJudulKartu.Name = "lblTransaksiJudulKartu";
            this.lblTransaksiJudulKartu.TabIndex = 0;
            this.lblTransaksiJudulKartu.Text = "Jumlah Transaksi";
            // 
            // lblTransaksiNilai
            // 
            this.lblTransaksiNilai.AutoSize = true;
            this.lblTransaksiNilai.BackColor = System.Drawing.Color.Transparent;
            this.lblTransaksiNilai.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.lblTransaksiNilai.ForeColor = System.Drawing.Color.FromArgb(40, 140, 90);
            this.lblTransaksiNilai.Location = new System.Drawing.Point(28, 32);
            this.lblTransaksiNilai.Name = "lblTransaksiNilai";
            this.lblTransaksiNilai.TabIndex = 1;
            this.lblTransaksiNilai.Text = "0";
            // 
            // lblTransaksiKet
            // 
            this.lblTransaksiKet.AutoSize = true;
            this.lblTransaksiKet.BackColor = System.Drawing.Color.Transparent;
            this.lblTransaksiKet.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblTransaksiKet.ForeColor = System.Drawing.Color.FromArgb(120, 135, 160);
            this.lblTransaksiKet.Location = new System.Drawing.Point(30, 68);
            this.lblTransaksiKet.Name = "lblTransaksiKet";
            this.lblTransaksiKet.TabIndex = 2;
            this.lblTransaksiKet.Text = "Transaksi selesai";
            // 
            // cardTerjual
            // 
            this.cardTerjual.AccentColor = System.Drawing.Color.FromArgb(126, 87, 194);
            this.cardTerjual.BackColor = System.Drawing.Color.White;
            this.cardTerjual.Controls.Add(this.lblTerjualKet);
            this.cardTerjual.Controls.Add(this.lblTerjualNilai);
            this.cardTerjual.Controls.Add(this.lblTerjualJudul);
            this.cardTerjual.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardTerjual.Margin = new System.Windows.Forms.Padding(0, 0, 12, 12);
            this.cardTerjual.Name = "cardTerjual";
            this.cardTerjual.Radius = 18;
            this.cardTerjual.Size = new System.Drawing.Size(255, 92);
            this.cardTerjual.TabIndex = 2;
            // 
            // lblTerjualJudul
            // 
            this.lblTerjualJudul.AutoSize = true;
            this.lblTerjualJudul.BackColor = System.Drawing.Color.Transparent;
            this.lblTerjualJudul.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblTerjualJudul.ForeColor = System.Drawing.Color.FromArgb(90, 110, 140);
            this.lblTerjualJudul.Location = new System.Drawing.Point(30, 14);
            this.lblTerjualJudul.Name = "lblTerjualJudul";
            this.lblTerjualJudul.TabIndex = 0;
            this.lblTerjualJudul.Text = "Item Terjual";
            // 
            // lblTerjualNilai
            // 
            this.lblTerjualNilai.AutoSize = true;
            this.lblTerjualNilai.BackColor = System.Drawing.Color.Transparent;
            this.lblTerjualNilai.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.lblTerjualNilai.ForeColor = System.Drawing.Color.FromArgb(126, 87, 194);
            this.lblTerjualNilai.Location = new System.Drawing.Point(28, 32);
            this.lblTerjualNilai.Name = "lblTerjualNilai";
            this.lblTerjualNilai.TabIndex = 1;
            this.lblTerjualNilai.Text = "0";
            // 
            // lblTerjualKet
            // 
            this.lblTerjualKet.AutoSize = true;
            this.lblTerjualKet.BackColor = System.Drawing.Color.Transparent;
            this.lblTerjualKet.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblTerjualKet.ForeColor = System.Drawing.Color.FromArgb(120, 135, 160);
            this.lblTerjualKet.Location = new System.Drawing.Point(30, 68);
            this.lblTerjualKet.Name = "lblTerjualKet";
            this.lblTerjualKet.TabIndex = 2;
            this.lblTerjualKet.Text = "Total barang keluar kasir";
            // 
            // cardKeranjang
            // 
            this.cardKeranjang.AccentColor = System.Drawing.Color.FromArgb(230, 150, 20);
            this.cardKeranjang.BackColor = System.Drawing.Color.White;
            this.cardKeranjang.Controls.Add(this.lblKeranjangKartuKet);
            this.cardKeranjang.Controls.Add(this.lblKeranjangKartuNilai);
            this.cardKeranjang.Controls.Add(this.lblKeranjangKartuJudul);
            this.cardKeranjang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardKeranjang.Margin = new System.Windows.Forms.Padding(0, 0, 0, 12);
            this.cardKeranjang.Name = "cardKeranjang";
            this.cardKeranjang.Radius = 18;
            this.cardKeranjang.Size = new System.Drawing.Size(255, 92);
            this.cardKeranjang.TabIndex = 3;
            // 
            // lblKeranjangKartuJudul
            // 
            this.lblKeranjangKartuJudul.AutoSize = true;
            this.lblKeranjangKartuJudul.BackColor = System.Drawing.Color.Transparent;
            this.lblKeranjangKartuJudul.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblKeranjangKartuJudul.ForeColor = System.Drawing.Color.FromArgb(90, 110, 140);
            this.lblKeranjangKartuJudul.Location = new System.Drawing.Point(30, 14);
            this.lblKeranjangKartuJudul.Name = "lblKeranjangKartuJudul";
            this.lblKeranjangKartuJudul.TabIndex = 0;
            this.lblKeranjangKartuJudul.Text = "Item di Keranjang";
            // 
            // lblKeranjangKartuNilai
            // 
            this.lblKeranjangKartuNilai.AutoSize = true;
            this.lblKeranjangKartuNilai.BackColor = System.Drawing.Color.Transparent;
            this.lblKeranjangKartuNilai.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.lblKeranjangKartuNilai.ForeColor = System.Drawing.Color.FromArgb(200, 125, 10);
            this.lblKeranjangKartuNilai.Location = new System.Drawing.Point(28, 32);
            this.lblKeranjangKartuNilai.Name = "lblKeranjangKartuNilai";
            this.lblKeranjangKartuNilai.TabIndex = 1;
            this.lblKeranjangKartuNilai.Text = "0";
            // 
            // lblKeranjangKartuKet
            // 
            this.lblKeranjangKartuKet.AutoSize = true;
            this.lblKeranjangKartuKet.BackColor = System.Drawing.Color.Transparent;
            this.lblKeranjangKartuKet.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblKeranjangKartuKet.ForeColor = System.Drawing.Color.FromArgb(120, 135, 160);
            this.lblKeranjangKartuKet.Location = new System.Drawing.Point(30, 68);
            this.lblKeranjangKartuKet.Name = "lblKeranjangKartuKet";
            this.lblKeranjangKartuKet.TabIndex = 2;
            this.lblKeranjangKartuKet.Text = "Belum dibayar";
            // 
            // tlpContent
            // 
            this.tlpContent.ColumnCount = 2;
            this.tlpContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62F));
            this.tlpContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38F));
            this.tlpContent.Controls.Add(this.pnlTransaksi, 0, 0);
            this.tlpContent.Controls.Add(this.tlpKanan, 1, 0);
            this.tlpContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpContent.Margin = new System.Windows.Forms.Padding(0, 0, 0, 12);
            this.tlpContent.Name = "tlpContent";
            this.tlpContent.RowCount = 1;
            this.tlpContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpContent.Size = new System.Drawing.Size(1068, 398);
            this.tlpContent.TabIndex = 2;
            // 
            // pnlTransaksi
            // 
            this.pnlTransaksi.BackColor = System.Drawing.Color.White;
            this.pnlTransaksi.Controls.Add(this.dgvTransaksi);
            this.pnlTransaksi.Controls.Add(this.lblTransaksiJudul);
            this.pnlTransaksi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTransaksi.Margin = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.pnlTransaksi.Name = "pnlTransaksi";
            this.pnlTransaksi.Padding = new System.Windows.Forms.Padding(20, 14, 20, 16);
            this.pnlTransaksi.Radius = 18;
            this.pnlTransaksi.Size = new System.Drawing.Size(650, 398);
            this.pnlTransaksi.TabIndex = 0;
            // 
            // dgvTransaksi
            // 
            this.dgvTransaksi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNoTransaksi,
            this.colWaktu,
            this.colKasir,
            this.colTotal});
            this.dgvTransaksi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTransaksi.Name = "dgvTransaksi";
            this.dgvTransaksi.TabIndex = 1;
            // 
            // colNoTransaksi
            // 
            this.colNoTransaksi.FillWeight = 30F;
            this.colNoTransaksi.HeaderText = "No Transaksi";
            this.colNoTransaksi.Name = "colNoTransaksi";
            // 
            // colWaktu
            // 
            this.colWaktu.FillWeight = 20F;
            this.colWaktu.HeaderText = "Waktu";
            this.colWaktu.Name = "colWaktu";
            // 
            // colKasir
            // 
            this.colKasir.FillWeight = 22F;
            this.colKasir.HeaderText = "Kasir";
            this.colKasir.Name = "colKasir";
            // 
            // colTotal
            // 
            this.colTotal.FillWeight = 28F;
            this.colTotal.HeaderText = "Total";
            this.colTotal.Name = "colTotal";
            // 
            // lblTransaksiJudul
            // 
            this.lblTransaksiJudul.BackColor = System.Drawing.Color.Transparent;
            this.lblTransaksiJudul.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTransaksiJudul.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblTransaksiJudul.ForeColor = System.Drawing.Color.FromArgb(13, 47, 110);
            this.lblTransaksiJudul.Name = "lblTransaksiJudul";
            this.lblTransaksiJudul.Size = new System.Drawing.Size(610, 34);
            this.lblTransaksiJudul.TabIndex = 0;
            this.lblTransaksiJudul.Text = "Transaksi Hari Ini";
            this.lblTransaksiJudul.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tlpKanan
            // 
            this.tlpKanan.ColumnCount = 1;
            this.tlpKanan.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpKanan.Controls.Add(this.pnlKeranjang, 0, 0);
            this.tlpKanan.Controls.Add(this.pnlRingkasan, 0, 1);
            this.tlpKanan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpKanan.Margin = new System.Windows.Forms.Padding(0);
            this.tlpKanan.Name = "tlpKanan";
            this.tlpKanan.RowCount = 2;
            this.tlpKanan.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpKanan.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpKanan.Size = new System.Drawing.Size(406, 398);
            this.tlpKanan.TabIndex = 1;
            // 
            // pnlKeranjang
            // 
            this.pnlKeranjang.BackColor = System.Drawing.Color.White;
            this.pnlKeranjang.Controls.Add(this.tlpKeranjang);
            this.pnlKeranjang.Controls.Add(this.lblKeranjangJudul);
            this.pnlKeranjang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlKeranjang.Margin = new System.Windows.Forms.Padding(0, 0, 0, 12);
            this.pnlKeranjang.Name = "pnlKeranjang";
            this.pnlKeranjang.Padding = new System.Windows.Forms.Padding(20, 14, 20, 14);
            this.pnlKeranjang.Radius = 18;
            this.pnlKeranjang.Size = new System.Drawing.Size(406, 187);
            this.pnlKeranjang.TabIndex = 0;
            // 
            // tlpKeranjang
            // 
            this.tlpKeranjang.ColumnCount = 2;
            this.tlpKeranjang.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tlpKeranjang.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tlpKeranjang.Controls.Add(this.lblItemJudul, 0, 0);
            this.tlpKeranjang.Controls.Add(this.lblTotalBelanjaJudul, 1, 0);
            this.tlpKeranjang.Controls.Add(this.lblItemNilai, 0, 1);
            this.tlpKeranjang.Controls.Add(this.lblTotalBelanjaNilai, 1, 1);
            this.tlpKeranjang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpKeranjang.Name = "tlpKeranjang";
            this.tlpKeranjang.RowCount = 2;
            this.tlpKeranjang.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tlpKeranjang.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpKeranjang.TabIndex = 1;
            // 
            // lblItemJudul
            // 
            this.lblItemJudul.BackColor = System.Drawing.Color.Transparent;
            this.lblItemJudul.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblItemJudul.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblItemJudul.ForeColor = System.Drawing.Color.FromArgb(90, 110, 140);
            this.lblItemJudul.Name = "lblItemJudul";
            this.lblItemJudul.Text = "Item";
            this.lblItemJudul.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblTotalBelanjaJudul
            // 
            this.lblTotalBelanjaJudul.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalBelanjaJudul.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotalBelanjaJudul.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTotalBelanjaJudul.ForeColor = System.Drawing.Color.FromArgb(90, 110, 140);
            this.lblTotalBelanjaJudul.Name = "lblTotalBelanjaJudul";
            this.lblTotalBelanjaJudul.Text = "Total Belanja";
            this.lblTotalBelanjaJudul.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblItemNilai
            // 
            this.lblItemNilai.BackColor = System.Drawing.Color.Transparent;
            this.lblItemNilai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblItemNilai.Font = new System.Drawing.Font("Segoe UI Semibold", 22F, System.Drawing.FontStyle.Bold);
            this.lblItemNilai.ForeColor = System.Drawing.Color.FromArgb(24, 94, 224);
            this.lblItemNilai.Name = "lblItemNilai";
            this.lblItemNilai.Text = "0";
            this.lblItemNilai.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotalBelanjaNilai
            // 
            this.lblTotalBelanjaNilai.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalBelanjaNilai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotalBelanjaNilai.Font = new System.Drawing.Font("Segoe UI Semibold", 22F, System.Drawing.FontStyle.Bold);
            this.lblTotalBelanjaNilai.ForeColor = System.Drawing.Color.FromArgb(24, 94, 224);
            this.lblTotalBelanjaNilai.Name = "lblTotalBelanjaNilai";
            this.lblTotalBelanjaNilai.Text = "Rp 0";
            this.lblTotalBelanjaNilai.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblKeranjangJudul
            // 
            this.lblKeranjangJudul.BackColor = System.Drawing.Color.Transparent;
            this.lblKeranjangJudul.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblKeranjangJudul.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblKeranjangJudul.ForeColor = System.Drawing.Color.FromArgb(13, 47, 110);
            this.lblKeranjangJudul.Name = "lblKeranjangJudul";
            this.lblKeranjangJudul.Size = new System.Drawing.Size(366, 32);
            this.lblKeranjangJudul.TabIndex = 0;
            this.lblKeranjangJudul.Text = "Keranjang Belanja Saat Ini";
            this.lblKeranjangJudul.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlRingkasan
            // 
            this.pnlRingkasan.BackColor = System.Drawing.Color.White;
            this.pnlRingkasan.Controls.Add(this.tlpRingkasan);
            this.pnlRingkasan.Controls.Add(this.lblRingkasanJudul);
            this.pnlRingkasan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRingkasan.Margin = new System.Windows.Forms.Padding(0);
            this.pnlRingkasan.Name = "pnlRingkasan";
            this.pnlRingkasan.Padding = new System.Windows.Forms.Padding(20, 14, 20, 14);
            this.pnlRingkasan.Radius = 18;
            this.pnlRingkasan.Size = new System.Drawing.Size(406, 199);
            this.pnlRingkasan.TabIndex = 1;
            // 
            // tlpRingkasan
            // 
            this.tlpRingkasan.ColumnCount = 2;
            this.tlpRingkasan.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tlpRingkasan.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tlpRingkasan.Controls.Add(this.lblRingkasanPendapatanJudul, 0, 0);
            this.tlpRingkasan.Controls.Add(this.lblRingkasanPendapatanNilai, 1, 0);
            this.tlpRingkasan.Controls.Add(this.lblRingkasanTransaksiJudul, 0, 1);
            this.tlpRingkasan.Controls.Add(this.lblRingkasanTransaksiNilai, 1, 1);
            this.tlpRingkasan.Controls.Add(this.lblRingkasanRataJudul, 0, 2);
            this.tlpRingkasan.Controls.Add(this.lblRingkasanRataNilai, 1, 2);
            this.tlpRingkasan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpRingkasan.Name = "tlpRingkasan";
            this.tlpRingkasan.RowCount = 3;
            this.tlpRingkasan.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tlpRingkasan.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tlpRingkasan.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.34F));
            this.tlpRingkasan.TabIndex = 1;
            // 
            // lblRingkasanPendapatanJudul
            // 
            this.lblRingkasanPendapatanJudul.BackColor = System.Drawing.Color.Transparent;
            this.lblRingkasanPendapatanJudul.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRingkasanPendapatanJudul.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblRingkasanPendapatanJudul.ForeColor = System.Drawing.Color.FromArgb(90, 110, 140);
            this.lblRingkasanPendapatanJudul.Name = "lblRingkasanPendapatanJudul";
            this.lblRingkasanPendapatanJudul.Text = "Total Pendapatan";
            this.lblRingkasanPendapatanJudul.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRingkasanPendapatanNilai
            // 
            this.lblRingkasanPendapatanNilai.BackColor = System.Drawing.Color.Transparent;
            this.lblRingkasanPendapatanNilai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRingkasanPendapatanNilai.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblRingkasanPendapatanNilai.ForeColor = System.Drawing.Color.FromArgb(13, 47, 110);
            this.lblRingkasanPendapatanNilai.Name = "lblRingkasanPendapatanNilai";
            this.lblRingkasanPendapatanNilai.Text = "Rp 0";
            this.lblRingkasanPendapatanNilai.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblRingkasanTransaksiJudul
            // 
            this.lblRingkasanTransaksiJudul.BackColor = System.Drawing.Color.Transparent;
            this.lblRingkasanTransaksiJudul.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRingkasanTransaksiJudul.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblRingkasanTransaksiJudul.ForeColor = System.Drawing.Color.FromArgb(90, 110, 140);
            this.lblRingkasanTransaksiJudul.Name = "lblRingkasanTransaksiJudul";
            this.lblRingkasanTransaksiJudul.Text = "Total Transaksi";
            this.lblRingkasanTransaksiJudul.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRingkasanTransaksiNilai
            // 
            this.lblRingkasanTransaksiNilai.BackColor = System.Drawing.Color.Transparent;
            this.lblRingkasanTransaksiNilai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRingkasanTransaksiNilai.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblRingkasanTransaksiNilai.ForeColor = System.Drawing.Color.FromArgb(13, 47, 110);
            this.lblRingkasanTransaksiNilai.Name = "lblRingkasanTransaksiNilai";
            this.lblRingkasanTransaksiNilai.Text = "0";
            this.lblRingkasanTransaksiNilai.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblRingkasanRataJudul
            // 
            this.lblRingkasanRataJudul.BackColor = System.Drawing.Color.Transparent;
            this.lblRingkasanRataJudul.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRingkasanRataJudul.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblRingkasanRataJudul.ForeColor = System.Drawing.Color.FromArgb(90, 110, 140);
            this.lblRingkasanRataJudul.Name = "lblRingkasanRataJudul";
            this.lblRingkasanRataJudul.Text = "Rata-rata / Transaksi";
            this.lblRingkasanRataJudul.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRingkasanRataNilai
            // 
            this.lblRingkasanRataNilai.BackColor = System.Drawing.Color.Transparent;
            this.lblRingkasanRataNilai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRingkasanRataNilai.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblRingkasanRataNilai.ForeColor = System.Drawing.Color.FromArgb(13, 47, 110);
            this.lblRingkasanRataNilai.Name = "lblRingkasanRataNilai";
            this.lblRingkasanRataNilai.Text = "Rp 0";
            this.lblRingkasanRataNilai.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblRingkasanJudul
            // 
            this.lblRingkasanJudul.BackColor = System.Drawing.Color.Transparent;
            this.lblRingkasanJudul.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblRingkasanJudul.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblRingkasanJudul.ForeColor = System.Drawing.Color.FromArgb(13, 47, 110);
            this.lblRingkasanJudul.Name = "lblRingkasanJudul";
            this.lblRingkasanJudul.Size = new System.Drawing.Size(366, 32);
            this.lblRingkasanJudul.TabIndex = 0;
            this.lblRingkasanJudul.Text = "Penjualan Hari Ini";
            this.lblRingkasanJudul.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flowAksi
            // 
            this.flowAksi.BackColor = System.Drawing.Color.FromArgb(234, 243, 252);
            this.flowAksi.Controls.Add(this.btnTransaksiBaru);
            this.flowAksi.Controls.Add(this.btnKeranjang);
            this.flowAksi.Controls.Add(this.btnRiwayat);
            this.flowAksi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowAksi.Margin = new System.Windows.Forms.Padding(0);
            this.flowAksi.Name = "flowAksi";
            this.flowAksi.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.flowAksi.Size = new System.Drawing.Size(1068, 46);
            this.flowAksi.TabIndex = 3;
            this.flowAksi.WrapContents = false;
            // 
            // btnTransaksiBaru
            // 
            this.btnTransaksiBaru.BackColor = System.Drawing.Color.FromArgb(30, 136, 229);
            this.btnTransaksiBaru.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnTransaksiBaru.ForeColor = System.Drawing.Color.White;
            this.btnTransaksiBaru.Margin = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.btnTransaksiBaru.Name = "btnTransaksiBaru";
            this.btnTransaksiBaru.Size = new System.Drawing.Size(180, 40);
            this.btnTransaksiBaru.TabIndex = 0;
            this.btnTransaksiBaru.Text = "+ Transaksi Baru";
            this.btnTransaksiBaru.UseVisualStyleBackColor = false;
            // 
            // btnKeranjang
            // 
            this.btnKeranjang.BackColor = System.Drawing.Color.FromArgb(30, 136, 229);
            this.btnKeranjang.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnKeranjang.ForeColor = System.Drawing.Color.White;
            this.btnKeranjang.Margin = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.btnKeranjang.Name = "btnKeranjang";
            this.btnKeranjang.Size = new System.Drawing.Size(180, 40);
            this.btnKeranjang.TabIndex = 1;
            this.btnKeranjang.Text = "Keranjang Belanja";
            this.btnKeranjang.UseVisualStyleBackColor = false;
            // 
            // btnRiwayat
            // 
            this.btnRiwayat.BackColor = System.Drawing.Color.White;
            this.btnRiwayat.BorderColor = System.Drawing.Color.FromArgb(30, 136, 229);
            this.btnRiwayat.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnRiwayat.ForeColor = System.Drawing.Color.FromArgb(30, 136, 229);
            this.btnRiwayat.HoverColor = System.Drawing.Color.FromArgb(225, 240, 255);
            this.btnRiwayat.Margin = new System.Windows.Forms.Padding(0);
            this.btnRiwayat.Name = "btnRiwayat";
            this.btnRiwayat.Size = new System.Drawing.Size(180, 40);
            this.btnRiwayat.TabIndex = 2;
            this.btnRiwayat.Text = "Riwayat Transaksi";
            this.btnRiwayat.UseVisualStyleBackColor = false;
            // 
            // timerJam
            // 
            this.timerJam.Interval = 1000;
            // 
            // UC_DSHBRDKasir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(234, 243, 252);
            this.Controls.Add(this.tlpRoot);
            this.Name = "UC_DSHBRDKasir";
            this.Size = new System.Drawing.Size(1100, 700);
            this.tlpRoot.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.tlpCards.ResumeLayout(false);
            this.cardPendapatan.ResumeLayout(false);
            this.cardPendapatan.PerformLayout();
            this.cardTransaksi.ResumeLayout(false);
            this.cardTransaksi.PerformLayout();
            this.cardTerjual.ResumeLayout(false);
            this.cardTerjual.PerformLayout();
            this.cardKeranjang.ResumeLayout(false);
            this.cardKeranjang.PerformLayout();
            this.tlpContent.ResumeLayout(false);
            this.pnlTransaksi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransaksi)).EndInit();
            this.tlpKanan.ResumeLayout(false);
            this.pnlKeranjang.ResumeLayout(false);
            this.tlpKeranjang.ResumeLayout(false);
            this.pnlRingkasan.ResumeLayout(false);
            this.tlpRingkasan.ResumeLayout(false);
            this.flowAksi.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpRoot;
        private RoundedPanelUI pnlHeader;
        private System.Windows.Forms.Label lblJudul;
        private System.Windows.Forms.Label lblSapaan;
        private System.Windows.Forms.Label lblJam;
        private System.Windows.Forms.Label lblTanggal;
        private RoundedButtonUI btnRefresh;
        private System.Windows.Forms.TableLayoutPanel tlpCards;
        private RoundedPanelUI cardPendapatan;
        private System.Windows.Forms.Label lblPendapatanJudul;
        private System.Windows.Forms.Label lblPendapatanNilai;
        private System.Windows.Forms.Label lblPendapatanKet;
        private RoundedPanelUI cardTransaksi;
        private System.Windows.Forms.Label lblTransaksiJudulKartu;
        private System.Windows.Forms.Label lblTransaksiNilai;
        private System.Windows.Forms.Label lblTransaksiKet;
        private RoundedPanelUI cardTerjual;
        private System.Windows.Forms.Label lblTerjualJudul;
        private System.Windows.Forms.Label lblTerjualNilai;
        private System.Windows.Forms.Label lblTerjualKet;
        private RoundedPanelUI cardKeranjang;
        private System.Windows.Forms.Label lblKeranjangKartuJudul;
        private System.Windows.Forms.Label lblKeranjangKartuNilai;
        private System.Windows.Forms.Label lblKeranjangKartuKet;
        private System.Windows.Forms.TableLayoutPanel tlpContent;
        private RoundedPanelUI pnlTransaksi;
        private System.Windows.Forms.DataGridView dgvTransaksi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNoTransaksi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWaktu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKasir;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
        private System.Windows.Forms.Label lblTransaksiJudul;
        private System.Windows.Forms.TableLayoutPanel tlpKanan;
        private RoundedPanelUI pnlKeranjang;
        private System.Windows.Forms.TableLayoutPanel tlpKeranjang;
        private System.Windows.Forms.Label lblItemJudul;
        private System.Windows.Forms.Label lblTotalBelanjaJudul;
        private System.Windows.Forms.Label lblItemNilai;
        private System.Windows.Forms.Label lblTotalBelanjaNilai;
        private System.Windows.Forms.Label lblKeranjangJudul;
        private RoundedPanelUI pnlRingkasan;
        private System.Windows.Forms.TableLayoutPanel tlpRingkasan;
        private System.Windows.Forms.Label lblRingkasanPendapatanJudul;
        private System.Windows.Forms.Label lblRingkasanPendapatanNilai;
        private System.Windows.Forms.Label lblRingkasanTransaksiJudul;
        private System.Windows.Forms.Label lblRingkasanTransaksiNilai;
        private System.Windows.Forms.Label lblRingkasanRataJudul;
        private System.Windows.Forms.Label lblRingkasanRataNilai;
        private System.Windows.Forms.Label lblRingkasanJudul;
        private System.Windows.Forms.FlowLayoutPanel flowAksi;
        private RoundedButtonUI btnTransaksiBaru;
        private RoundedButtonUI btnKeranjang;
        private RoundedButtonUI btnRiwayat;
        private System.Windows.Forms.Timer timerJam;
    }
}