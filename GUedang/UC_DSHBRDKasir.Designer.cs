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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            tlpRoot = new TableLayoutPanel();
            pnlHeader = new RoundedPanelUI();
            btnRefresh = new RoundedButtonUI();
            lblTanggal = new Label();
            lblJam = new Label();
            lblSapaan = new Label();
            lblJudul = new Label();
            tlpCards = new TableLayoutPanel();
            cardPendapatan = new RoundedPanelUI();
            lblPendapatanKet = new Label();
            lblPendapatanNilai = new Label();
            lblPendapatanJudul = new Label();
            cardTransaksi = new RoundedPanelUI();
            lblTransaksiKet = new Label();
            lblTransaksiNilai = new Label();
            lblTransaksiJudulKartu = new Label();
            cardTerjual = new RoundedPanelUI();
            lblTerjualKet = new Label();
            lblTerjualNilai = new Label();
            lblTerjualJudul = new Label();
            cardKeranjang = new RoundedPanelUI();
            lblKeranjangKartuKet = new Label();
            lblKeranjangKartuNilai = new Label();
            lblKeranjangKartuJudul = new Label();
            tlpContent = new TableLayoutPanel();
            pnlTransaksi = new RoundedPanelUI();
            dgvTransaksi = new DataGridView();
            colNoTransaksi = new DataGridViewTextBoxColumn();
            colWaktu = new DataGridViewTextBoxColumn();
            colKasir = new DataGridViewTextBoxColumn();
            colTotal = new DataGridViewTextBoxColumn();
            lblTransaksiJudul = new Label();
            tlpKanan = new TableLayoutPanel();
            pnlKeranjang = new RoundedPanelUI();
            tlpKeranjang = new TableLayoutPanel();
            lblItemJudul = new Label();
            lblTotalBelanjaJudul = new Label();
            lblItemNilai = new Label();
            lblTotalBelanjaNilai = new Label();
            lblKeranjangJudul = new Label();
            pnlRingkasan = new RoundedPanelUI();
            tlpRingkasan = new TableLayoutPanel();
            lblRingkasanPendapatanJudul = new Label();
            lblRingkasanTransaksiJudul = new Label();
            lblRingkasanTransaksiNilai = new Label();
            lblRingkasanRataJudul = new Label();
            lblRingkasanPendapatanNilai = new Label();
            lblRingkasanRataNilai = new Label();
            lblRingkasanJudul = new Label();
            timerJam = new System.Windows.Forms.Timer(components);
            tlpRoot.SuspendLayout();
            pnlHeader.SuspendLayout();
            tlpCards.SuspendLayout();
            cardPendapatan.SuspendLayout();
            cardTransaksi.SuspendLayout();
            cardTerjual.SuspendLayout();
            cardKeranjang.SuspendLayout();
            tlpContent.SuspendLayout();
            pnlTransaksi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTransaksi).BeginInit();
            tlpKanan.SuspendLayout();
            pnlKeranjang.SuspendLayout();
            tlpKeranjang.SuspendLayout();
            pnlRingkasan.SuspendLayout();
            tlpRingkasan.SuspendLayout();
            SuspendLayout();
            // 
            // tlpRoot
            // 
            tlpRoot.ColumnCount = 1;
            tlpRoot.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpRoot.Controls.Add(pnlHeader, 0, 0);
            tlpRoot.Controls.Add(tlpCards, 0, 1);
            tlpRoot.Controls.Add(tlpContent, 0, 2);
            tlpRoot.Dock = DockStyle.Fill;
            tlpRoot.Location = new Point(0, 0);
            tlpRoot.Margin = new Padding(5, 6, 5, 6);
            tlpRoot.Name = "tlpRoot";
            tlpRoot.Padding = new Padding(27, 31, 27, 23);
            tlpRoot.RowCount = 4;
            tlpRoot.RowStyles.Add(new RowStyle(SizeType.Absolute, 129F));
            tlpRoot.RowStyles.Add(new RowStyle(SizeType.Absolute, 147F));
            tlpRoot.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpRoot.RowStyles.Add(new RowStyle(SizeType.Absolute, 8F));
            tlpRoot.Size = new Size(1833, 1346);
            tlpRoot.TabIndex = 0;
            // 
            // pnlHeader
            // 
            pnlHeader.AccentColor = Color.Transparent;
            pnlHeader.BackColor = Color.White;
            pnlHeader.BorderColor = Color.FromArgb(214, 228, 245);
            pnlHeader.Controls.Add(btnRefresh);
            pnlHeader.Controls.Add(lblTanggal);
            pnlHeader.Controls.Add(lblJam);
            pnlHeader.Controls.Add(lblSapaan);
            pnlHeader.Controls.Add(lblJudul);
            pnlHeader.Location = new Point(27, 31);
            pnlHeader.Margin = new Padding(0, 0, 0, 23);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Radius = 20;
            pnlHeader.Size = new Size(1779, 106);
            pnlHeader.TabIndex = 0;
            // 
            // btnRefresh
            // 
            btnRefresh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRefresh.BackColor = Color.RoyalBlue;
            btnRefresh.BorderColor = Color.FromArgb(200, 210, 225);
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.HoverColor = Color.FromArgb(240, 245, 252);
            btnRefresh.Location = new Point(1548, 32);
            btnRefresh.Margin = new Padding(5, 6, 5, 6);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(183, 49);
            btnRefresh.TabIndex = 4;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            // 
            // lblTanggal
            // 
            lblTanggal.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTanggal.BackColor = Color.Transparent;
            lblTanggal.Font = new Font("Segoe UI", 9F);
            lblTanggal.ForeColor = Color.FromArgb(90, 110, 140);
            lblTanggal.Location = new Point(1102, 71);
            lblTanggal.Margin = new Padding(5, 0, 5, 0);
            lblTanggal.Name = "lblTanggal";
            lblTanggal.Size = new Size(417, 38);
            lblTanggal.TabIndex = 3;
            lblTanggal.Text = "Kamis, 19 November 2026";
            lblTanggal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblJam
            // 
            lblJam.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblJam.BackColor = Color.Transparent;
            lblJam.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            lblJam.ForeColor = Color.FromArgb(24, 94, 224);
            lblJam.Location = new Point(1166, 19);
            lblJam.Margin = new Padding(5, 0, 5, 0);
            lblJam.Name = "lblJam";
            lblJam.Size = new Size(350, 62);
            lblJam.TabIndex = 2;
            lblJam.Text = "00:00:00";
            lblJam.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblSapaan
            // 
            lblSapaan.AutoSize = true;
            lblSapaan.BackColor = Color.Transparent;
            lblSapaan.Font = new Font("Segoe UI", 9.5F);
            lblSapaan.ForeColor = Color.FromArgb(90, 110, 140);
            lblSapaan.Location = new Point(47, 71);
            lblSapaan.Margin = new Padding(5, 0, 5, 0);
            lblSapaan.Name = "lblSapaan";
            lblSapaan.Size = new Size(195, 25);
            lblSapaan.TabIndex = 1;
            lblSapaan.Text = "Selamat Datang, Kasir";
            // 
            // lblJudul
            // 
            lblJudul.AutoSize = true;
            lblJudul.BackColor = Color.Transparent;
            lblJudul.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            lblJudul.ForeColor = Color.FromArgb(13, 47, 110);
            lblJudul.Location = new Point(40, 23);
            lblJudul.Margin = new Padding(5, 0, 5, 0);
            lblJudul.Name = "lblJudul";
            lblJudul.Size = new Size(289, 48);
            lblJudul.TabIndex = 0;
            lblJudul.Text = "Dashboard Kasir";
            // 
            // tlpCards
            // 
            tlpCards.ColumnCount = 4;
            tlpCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpCards.Controls.Add(cardPendapatan, 0, 0);
            tlpCards.Controls.Add(cardTransaksi, 1, 0);
            tlpCards.Controls.Add(cardTerjual, 2, 0);
            tlpCards.Controls.Add(cardKeranjang, 3, 0);
            tlpCards.Location = new Point(27, 160);
            tlpCards.Margin = new Padding(0);
            tlpCards.Name = "tlpCards";
            tlpCards.RowCount = 1;
            tlpCards.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpCards.Size = new Size(1779, 147);
            tlpCards.TabIndex = 1;
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
            cardPendapatan.Margin = new Padding(0, 0, 20, 23);
            cardPendapatan.Name = "cardPendapatan";
            cardPendapatan.Radius = 18;
            cardPendapatan.Size = new Size(424, 124);
            cardPendapatan.TabIndex = 0;
            // 
            // lblPendapatanKet
            // 
            lblPendapatanKet.AutoSize = true;
            lblPendapatanKet.BackColor = Color.Transparent;
            lblPendapatanKet.Font = new Font("Segoe UI", 8.5F);
            lblPendapatanKet.ForeColor = Color.FromArgb(120, 135, 160);
            lblPendapatanKet.Location = new Point(143, 87);
            lblPendapatanKet.Margin = new Padding(5, 0, 5, 0);
            lblPendapatanKet.Name = "lblPendapatanKet";
            lblPendapatanKet.Size = new Size(64, 23);
            lblPendapatanKet.TabIndex = 2;
            lblPendapatanKet.Text = "Hari ini";
            // 
            // lblPendapatanNilai
            // 
            lblPendapatanNilai.AutoSize = true;
            lblPendapatanNilai.BackColor = Color.Transparent;
            lblPendapatanNilai.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            lblPendapatanNilai.ForeColor = Color.FromArgb(24, 94, 224);
            lblPendapatanNilai.Location = new Point(50, 40);
            lblPendapatanNilai.Margin = new Padding(5, 0, 5, 0);
            lblPendapatanNilai.Name = "lblPendapatanNilai";
            lblPendapatanNilai.Size = new Size(94, 48);
            lblPendapatanNilai.TabIndex = 1;
            lblPendapatanNilai.Text = "Rp 0";
            // 
            // lblPendapatanJudul
            // 
            lblPendapatanJudul.AutoSize = true;
            lblPendapatanJudul.BackColor = Color.Transparent;
            lblPendapatanJudul.Font = new Font("Segoe UI", 9.5F);
            lblPendapatanJudul.ForeColor = Color.FromArgb(90, 110, 140);
            lblPendapatanJudul.Location = new Point(50, 15);
            lblPendapatanJudul.Margin = new Padding(5, 0, 5, 0);
            lblPendapatanJudul.Name = "lblPendapatanJudul";
            lblPendapatanJudul.Size = new Size(157, 25);
            lblPendapatanJudul.TabIndex = 0;
            lblPendapatanJudul.Text = "Total Pendapatan";
            // 
            // cardTransaksi
            // 
            cardTransaksi.AccentColor = Color.FromArgb(46, 160, 100);
            cardTransaksi.BackColor = Color.White;
            cardTransaksi.BorderColor = Color.FromArgb(214, 228, 245);
            cardTransaksi.Controls.Add(lblTransaksiKet);
            cardTransaksi.Controls.Add(lblTransaksiNilai);
            cardTransaksi.Controls.Add(lblTransaksiJudulKartu);
            cardTransaksi.Dock = DockStyle.Fill;
            cardTransaksi.Location = new Point(444, 0);
            cardTransaksi.Margin = new Padding(0, 0, 20, 23);
            cardTransaksi.Name = "cardTransaksi";
            cardTransaksi.Radius = 18;
            cardTransaksi.Size = new Size(424, 124);
            cardTransaksi.TabIndex = 1;
            // 
            // lblTransaksiKet
            // 
            lblTransaksiKet.AutoSize = true;
            lblTransaksiKet.BackColor = Color.Transparent;
            lblTransaksiKet.Font = new Font("Segoe UI", 8.5F);
            lblTransaksiKet.ForeColor = Color.FromArgb(120, 135, 160);
            lblTransaksiKet.Location = new Point(99, 87);
            lblTransaksiKet.Margin = new Padding(5, 0, 5, 0);
            lblTransaksiKet.Name = "lblTransaksiKet";
            lblTransaksiKet.Size = new Size(132, 23);
            lblTransaksiKet.TabIndex = 2;
            lblTransaksiKet.Text = "Transaksi selesai";
            // 
            // lblTransaksiNilai
            // 
            lblTransaksiNilai.AutoSize = true;
            lblTransaksiNilai.BackColor = Color.Transparent;
            lblTransaksiNilai.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            lblTransaksiNilai.ForeColor = Color.FromArgb(40, 140, 90);
            lblTransaksiNilai.Location = new Point(50, 40);
            lblTransaksiNilai.Margin = new Padding(5, 0, 5, 0);
            lblTransaksiNilai.Name = "lblTransaksiNilai";
            lblTransaksiNilai.Size = new Size(40, 48);
            lblTransaksiNilai.TabIndex = 1;
            lblTransaksiNilai.Text = "0";
            // 
            // lblTransaksiJudulKartu
            // 
            lblTransaksiJudulKartu.AutoSize = true;
            lblTransaksiJudulKartu.BackColor = Color.Transparent;
            lblTransaksiJudulKartu.Font = new Font("Segoe UI", 9.5F);
            lblTransaksiJudulKartu.ForeColor = Color.FromArgb(90, 110, 140);
            lblTransaksiJudulKartu.Location = new Point(47, 15);
            lblTransaksiJudulKartu.Margin = new Padding(5, 0, 5, 0);
            lblTransaksiJudulKartu.Name = "lblTransaksiJudulKartu";
            lblTransaksiJudulKartu.Size = new Size(153, 25);
            lblTransaksiJudulKartu.TabIndex = 0;
            lblTransaksiJudulKartu.Text = "Jumlah Transaksi";
            // 
            // cardTerjual
            // 
            cardTerjual.AccentColor = Color.FromArgb(126, 87, 194);
            cardTerjual.BackColor = Color.White;
            cardTerjual.BorderColor = Color.FromArgb(214, 228, 245);
            cardTerjual.Controls.Add(lblTerjualKet);
            cardTerjual.Controls.Add(lblTerjualNilai);
            cardTerjual.Controls.Add(lblTerjualJudul);
            cardTerjual.Dock = DockStyle.Fill;
            cardTerjual.Location = new Point(888, 0);
            cardTerjual.Margin = new Padding(0, 0, 20, 23);
            cardTerjual.Name = "cardTerjual";
            cardTerjual.Radius = 18;
            cardTerjual.Size = new Size(424, 124);
            cardTerjual.TabIndex = 2;
            // 
            // lblTerjualKet
            // 
            lblTerjualKet.AutoSize = true;
            lblTerjualKet.BackColor = Color.Transparent;
            lblTerjualKet.Font = new Font("Segoe UI", 8.5F);
            lblTerjualKet.ForeColor = Color.FromArgb(120, 135, 160);
            lblTerjualKet.Location = new Point(101, 87);
            lblTerjualKet.Margin = new Padding(5, 0, 5, 0);
            lblTerjualKet.Name = "lblTerjualKet";
            lblTerjualKet.Size = new Size(195, 23);
            lblTerjualKet.TabIndex = 2;
            lblTerjualKet.Text = "Total barang keluar kasir";
            // 
            // lblTerjualNilai
            // 
            lblTerjualNilai.AutoSize = true;
            lblTerjualNilai.BackColor = Color.Transparent;
            lblTerjualNilai.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            lblTerjualNilai.ForeColor = Color.FromArgb(126, 87, 194);
            lblTerjualNilai.Location = new Point(51, 40);
            lblTerjualNilai.Margin = new Padding(5, 0, 5, 0);
            lblTerjualNilai.Name = "lblTerjualNilai";
            lblTerjualNilai.Size = new Size(40, 48);
            lblTerjualNilai.TabIndex = 1;
            lblTerjualNilai.Text = "0";
            // 
            // lblTerjualJudul
            // 
            lblTerjualJudul.AutoSize = true;
            lblTerjualJudul.BackColor = Color.Transparent;
            lblTerjualJudul.Font = new Font("Segoe UI", 9.5F);
            lblTerjualJudul.ForeColor = Color.FromArgb(90, 110, 140);
            lblTerjualJudul.Location = new Point(51, 15);
            lblTerjualJudul.Margin = new Padding(5, 0, 5, 0);
            lblTerjualJudul.Name = "lblTerjualJudul";
            lblTerjualJudul.Size = new Size(110, 25);
            lblTerjualJudul.TabIndex = 0;
            lblTerjualJudul.Text = "Item Terjual";
            // 
            // cardKeranjang
            // 
            cardKeranjang.AccentColor = Color.FromArgb(230, 150, 20);
            cardKeranjang.BackColor = Color.White;
            cardKeranjang.BorderColor = Color.FromArgb(214, 228, 245);
            cardKeranjang.Controls.Add(lblKeranjangKartuKet);
            cardKeranjang.Controls.Add(lblKeranjangKartuNilai);
            cardKeranjang.Controls.Add(lblKeranjangKartuJudul);
            cardKeranjang.Dock = DockStyle.Fill;
            cardKeranjang.Location = new Point(1332, 0);
            cardKeranjang.Margin = new Padding(0, 0, 0, 23);
            cardKeranjang.Name = "cardKeranjang";
            cardKeranjang.Radius = 18;
            cardKeranjang.Size = new Size(447, 124);
            cardKeranjang.TabIndex = 3;
            // 
            // lblKeranjangKartuKet
            // 
            lblKeranjangKartuKet.AutoSize = true;
            lblKeranjangKartuKet.BackColor = Color.Transparent;
            lblKeranjangKartuKet.Font = new Font("Segoe UI", 8.5F);
            lblKeranjangKartuKet.ForeColor = Color.FromArgb(120, 135, 160);
            lblKeranjangKartuKet.Location = new Point(100, 87);
            lblKeranjangKartuKet.Margin = new Padding(5, 0, 5, 0);
            lblKeranjangKartuKet.Name = "lblKeranjangKartuKet";
            lblKeranjangKartuKet.Size = new Size(119, 23);
            lblKeranjangKartuKet.TabIndex = 2;
            lblKeranjangKartuKet.Text = "Belum dibayar";
            // 
            // lblKeranjangKartuNilai
            // 
            lblKeranjangKartuNilai.AutoSize = true;
            lblKeranjangKartuNilai.BackColor = Color.Transparent;
            lblKeranjangKartuNilai.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            lblKeranjangKartuNilai.ForeColor = Color.FromArgb(200, 125, 10);
            lblKeranjangKartuNilai.Location = new Point(50, 40);
            lblKeranjangKartuNilai.Margin = new Padding(5, 0, 5, 0);
            lblKeranjangKartuNilai.Name = "lblKeranjangKartuNilai";
            lblKeranjangKartuNilai.Size = new Size(40, 48);
            lblKeranjangKartuNilai.TabIndex = 1;
            lblKeranjangKartuNilai.Text = "0";
            // 
            // lblKeranjangKartuJudul
            // 
            lblKeranjangKartuJudul.AutoSize = true;
            lblKeranjangKartuJudul.BackColor = Color.Transparent;
            lblKeranjangKartuJudul.Font = new Font("Segoe UI", 9.5F);
            lblKeranjangKartuJudul.ForeColor = Color.FromArgb(90, 110, 140);
            lblKeranjangKartuJudul.Location = new Point(50, 15);
            lblKeranjangKartuJudul.Margin = new Padding(5, 0, 5, 0);
            lblKeranjangKartuJudul.Name = "lblKeranjangKartuJudul";
            lblKeranjangKartuJudul.Size = new Size(161, 25);
            lblKeranjangKartuJudul.TabIndex = 0;
            lblKeranjangKartuJudul.Text = "Item di Keranjang";
            // 
            // tlpContent
            // 
            tlpContent.ColumnCount = 2;
            tlpContent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 62F));
            tlpContent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38F));
            tlpContent.Controls.Add(pnlTransaksi, 0, 0);
            tlpContent.Controls.Add(tlpKanan, 1, 0);
            tlpContent.Dock = DockStyle.Fill;
            tlpContent.Location = new Point(27, 307);
            tlpContent.Margin = new Padding(0, 0, 0, 23);
            tlpContent.Name = "tlpContent";
            tlpContent.RowCount = 1;
            tlpContent.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpContent.Size = new Size(1779, 985);
            tlpContent.TabIndex = 2;
            // 
            // pnlTransaksi
            // 
            pnlTransaksi.AccentColor = Color.Transparent;
            pnlTransaksi.BackColor = Color.White;
            pnlTransaksi.BorderColor = Color.FromArgb(214, 228, 245);
            pnlTransaksi.Controls.Add(dgvTransaksi);
            pnlTransaksi.Controls.Add(lblTransaksiJudul);
            pnlTransaksi.Dock = DockStyle.Fill;
            pnlTransaksi.Location = new Point(0, 0);
            pnlTransaksi.Margin = new Padding(0, 0, 20, 0);
            pnlTransaksi.Name = "pnlTransaksi";
            pnlTransaksi.Padding = new Padding(33, 27, 33, 31);
            pnlTransaksi.Radius = 18;
            pnlTransaksi.Size = new Size(1082, 985);
            pnlTransaksi.TabIndex = 0;
            // 
            // dgvTransaksi
            // 
            dgvTransaksi.AllowUserToAddRows = false;
            dgvTransaksi.AllowUserToDeleteRows = false;
            dgvTransaksi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTransaksi.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.RoyalBlue;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.AliceBlue;
            dataGridViewCellStyle1.SelectionBackColor = Color.AliceBlue;
            dataGridViewCellStyle1.SelectionForeColor = Color.RoyalBlue;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvTransaksi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvTransaksi.ColumnHeadersHeight = 40;
            dgvTransaksi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvTransaksi.Columns.AddRange(new DataGridViewColumn[] { colNoTransaksi, colWaktu, colKasir, colTotal });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.AliceBlue;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.Blue;
            dataGridViewCellStyle2.SelectionBackColor = Color.RoyalBlue;
            dataGridViewCellStyle2.SelectionForeColor = Color.AliceBlue;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvTransaksi.DefaultCellStyle = dataGridViewCellStyle2;
            dgvTransaksi.Dock = DockStyle.Fill;
            dgvTransaksi.EnableHeadersVisualStyles = false;
            dgvTransaksi.Location = new Point(33, 92);
            dgvTransaksi.Margin = new Padding(5, 6, 5, 6);
            dgvTransaksi.MultiSelect = false;
            dgvTransaksi.Name = "dgvTransaksi";
            dgvTransaksi.ReadOnly = true;
            dgvTransaksi.RowHeadersVisible = false;
            dgvTransaksi.RowHeadersWidth = 62;
            dgvTransaksi.Size = new Size(1016, 862);
            dgvTransaksi.TabIndex = 1;
            // 
            // colNoTransaksi
            // 
            colNoTransaksi.FillWeight = 30F;
            colNoTransaksi.HeaderText = "No Transaksi";
            colNoTransaksi.MinimumWidth = 8;
            colNoTransaksi.Name = "colNoTransaksi";
            colNoTransaksi.ReadOnly = true;
            // 
            // colWaktu
            // 
            colWaktu.FillWeight = 20F;
            colWaktu.HeaderText = "Waktu";
            colWaktu.MinimumWidth = 8;
            colWaktu.Name = "colWaktu";
            colWaktu.ReadOnly = true;
            // 
            // colKasir
            // 
            colKasir.FillWeight = 22F;
            colKasir.HeaderText = "Kasir";
            colKasir.MinimumWidth = 8;
            colKasir.Name = "colKasir";
            colKasir.ReadOnly = true;
            // 
            // colTotal
            // 
            colTotal.FillWeight = 28F;
            colTotal.HeaderText = "Total";
            colTotal.MinimumWidth = 8;
            colTotal.Name = "colTotal";
            colTotal.ReadOnly = true;
            // 
            // lblTransaksiJudul
            // 
            lblTransaksiJudul.BackColor = Color.Transparent;
            lblTransaksiJudul.Dock = DockStyle.Top;
            lblTransaksiJudul.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblTransaksiJudul.ForeColor = Color.FromArgb(13, 47, 110);
            lblTransaksiJudul.Location = new Point(33, 27);
            lblTransaksiJudul.Margin = new Padding(5, 0, 5, 0);
            lblTransaksiJudul.Name = "lblTransaksiJudul";
            lblTransaksiJudul.Size = new Size(1016, 65);
            lblTransaksiJudul.TabIndex = 0;
            lblTransaksiJudul.Text = "Transaksi Hari Ini";
            lblTransaksiJudul.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tlpKanan
            // 
            tlpKanan.ColumnCount = 1;
            tlpKanan.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpKanan.Controls.Add(pnlKeranjang, 0, 0);
            tlpKanan.Controls.Add(pnlRingkasan, 0, 1);
            tlpKanan.Dock = DockStyle.Fill;
            tlpKanan.Location = new Point(1102, 0);
            tlpKanan.Margin = new Padding(0);
            tlpKanan.Name = "tlpKanan";
            tlpKanan.RowCount = 2;
            tlpKanan.RowStyles.Add(new RowStyle(SizeType.Percent, 53.90863F));
            tlpKanan.RowStyles.Add(new RowStyle(SizeType.Percent, 46.09137F));
            tlpKanan.Size = new Size(677, 985);
            tlpKanan.TabIndex = 1;
            // 
            // pnlKeranjang
            // 
            pnlKeranjang.AccentColor = Color.Transparent;
            pnlKeranjang.BackColor = Color.White;
            pnlKeranjang.BorderColor = Color.FromArgb(214, 228, 245);
            pnlKeranjang.Controls.Add(tlpKeranjang);
            pnlKeranjang.Controls.Add(lblKeranjangJudul);
            pnlKeranjang.Location = new Point(0, 0);
            pnlKeranjang.Margin = new Padding(0, 0, 0, 23);
            pnlKeranjang.Name = "pnlKeranjang";
            pnlKeranjang.Padding = new Padding(33, 27, 33, 27);
            pnlKeranjang.Radius = 18;
            pnlKeranjang.Size = new Size(677, 239);
            pnlKeranjang.TabIndex = 0;
            // 
            // tlpKeranjang
            // 
            tlpKeranjang.ColumnCount = 2;
            tlpKeranjang.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tlpKeranjang.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65F));
            tlpKeranjang.Controls.Add(lblItemJudul, 0, 0);
            tlpKeranjang.Controls.Add(lblTotalBelanjaJudul, 1, 0);
            tlpKeranjang.Controls.Add(lblItemNilai, 0, 1);
            tlpKeranjang.Controls.Add(lblTotalBelanjaNilai, 1, 1);
            tlpKeranjang.Location = new Point(33, 89);
            tlpKeranjang.Margin = new Padding(5, 6, 5, 6);
            tlpKeranjang.Name = "tlpKeranjang";
            tlpKeranjang.RowCount = 2;
            tlpKeranjang.RowStyles.Add(new RowStyle(SizeType.Absolute, 46F));
            tlpKeranjang.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpKeranjang.Size = new Size(611, 301);
            tlpKeranjang.TabIndex = 1;
            // 
            // lblItemJudul
            // 
            lblItemJudul.BackColor = Color.Transparent;
            lblItemJudul.Font = new Font("Segoe UI", 9F);
            lblItemJudul.ForeColor = Color.FromArgb(90, 110, 140);
            lblItemJudul.Location = new Point(5, 0);
            lblItemJudul.Margin = new Padding(5, 0, 5, 0);
            lblItemJudul.Name = "lblItemJudul";
            lblItemJudul.Size = new Size(172, 46);
            lblItemJudul.TabIndex = 0;
            lblItemJudul.Text = "Item";
            lblItemJudul.TextAlign = ContentAlignment.BottomLeft;
            // 
            // lblTotalBelanjaJudul
            // 
            lblTotalBelanjaJudul.BackColor = Color.Transparent;
            lblTotalBelanjaJudul.Font = new Font("Segoe UI", 9F);
            lblTotalBelanjaJudul.ForeColor = Color.FromArgb(90, 110, 140);
            lblTotalBelanjaJudul.Location = new Point(218, 0);
            lblTotalBelanjaJudul.Margin = new Padding(5, 0, 5, 0);
            lblTotalBelanjaJudul.Name = "lblTotalBelanjaJudul";
            lblTotalBelanjaJudul.Size = new Size(356, 46);
            lblTotalBelanjaJudul.TabIndex = 1;
            lblTotalBelanjaJudul.Text = "Total Belanja";
            lblTotalBelanjaJudul.TextAlign = ContentAlignment.BottomLeft;
            // 
            // lblItemNilai
            // 
            lblItemNilai.BackColor = Color.Transparent;
            lblItemNilai.Font = new Font("Segoe UI Semibold", 22F, FontStyle.Bold);
            lblItemNilai.ForeColor = Color.FromArgb(24, 94, 224);
            lblItemNilai.Location = new Point(5, 46);
            lblItemNilai.Margin = new Padding(5, 0, 5, 0);
            lblItemNilai.Name = "lblItemNilai";
            lblItemNilai.Size = new Size(203, 71);
            lblItemNilai.TabIndex = 2;
            lblItemNilai.Text = "0";
            lblItemNilai.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTotalBelanjaNilai
            // 
            lblTotalBelanjaNilai.BackColor = Color.Transparent;
            lblTotalBelanjaNilai.Font = new Font("Segoe UI Semibold", 22F, FontStyle.Bold);
            lblTotalBelanjaNilai.ForeColor = Color.FromArgb(24, 94, 224);
            lblTotalBelanjaNilai.Location = new Point(218, 46);
            lblTotalBelanjaNilai.Margin = new Padding(5, 0, 5, 0);
            lblTotalBelanjaNilai.Name = "lblTotalBelanjaNilai";
            lblTotalBelanjaNilai.Size = new Size(243, 71);
            lblTotalBelanjaNilai.TabIndex = 3;
            lblTotalBelanjaNilai.Text = "Rp 0";
            lblTotalBelanjaNilai.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblKeranjangJudul
            // 
            lblKeranjangJudul.BackColor = Color.Transparent;
            lblKeranjangJudul.Dock = DockStyle.Top;
            lblKeranjangJudul.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblKeranjangJudul.ForeColor = Color.FromArgb(13, 47, 110);
            lblKeranjangJudul.Location = new Point(33, 27);
            lblKeranjangJudul.Margin = new Padding(5, 0, 5, 0);
            lblKeranjangJudul.Name = "lblKeranjangJudul";
            lblKeranjangJudul.Size = new Size(611, 34);
            lblKeranjangJudul.TabIndex = 0;
            lblKeranjangJudul.Text = "Keranjang Belanja Saat Ini";
            lblKeranjangJudul.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlRingkasan
            // 
            pnlRingkasan.AccentColor = Color.Transparent;
            pnlRingkasan.BackColor = Color.White;
            pnlRingkasan.BorderColor = Color.FromArgb(214, 228, 245);
            pnlRingkasan.Controls.Add(tlpRingkasan);
            pnlRingkasan.Controls.Add(lblRingkasanJudul);
            pnlRingkasan.Location = new Point(0, 531);
            pnlRingkasan.Margin = new Padding(0);
            pnlRingkasan.Name = "pnlRingkasan";
            pnlRingkasan.Padding = new Padding(33, 27, 33, 27);
            pnlRingkasan.Radius = 18;
            pnlRingkasan.Size = new Size(677, 208);
            pnlRingkasan.TabIndex = 1;
            // 
            // tlpRingkasan
            // 
            tlpRingkasan.ColumnCount = 2;
            tlpRingkasan.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55F));
            tlpRingkasan.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            tlpRingkasan.Controls.Add(lblRingkasanPendapatanJudul, 0, 0);
            tlpRingkasan.Controls.Add(lblRingkasanTransaksiJudul, 0, 1);
            tlpRingkasan.Controls.Add(lblRingkasanTransaksiNilai, 1, 1);
            tlpRingkasan.Controls.Add(lblRingkasanRataJudul, 0, 2);
            tlpRingkasan.Controls.Add(lblRingkasanPendapatanNilai, 1, 0);
            tlpRingkasan.Controls.Add(lblRingkasanRataNilai, 1, 2);
            tlpRingkasan.Location = new Point(33, 88);
            tlpRingkasan.Margin = new Padding(5, 6, 5, 6);
            tlpRingkasan.Name = "tlpRingkasan";
            tlpRingkasan.RowCount = 3;
            tlpRingkasan.RowStyles.Add(new RowStyle(SizeType.Percent, 4.83559F));
            tlpRingkasan.RowStyles.Add(new RowStyle(SizeType.Percent, 6.382979F));
            tlpRingkasan.RowStyles.Add(new RowStyle(SizeType.Percent, 88.78143F));
            tlpRingkasan.Size = new Size(554, 517);
            tlpRingkasan.TabIndex = 1;
            // 
            // lblRingkasanPendapatanJudul
            // 
            lblRingkasanPendapatanJudul.BackColor = Color.Transparent;
            lblRingkasanPendapatanJudul.Font = new Font("Segoe UI", 9.5F);
            lblRingkasanPendapatanJudul.ForeColor = Color.FromArgb(90, 110, 140);
            lblRingkasanPendapatanJudul.Location = new Point(5, 0);
            lblRingkasanPendapatanJudul.Margin = new Padding(5, 0, 5, 0);
            lblRingkasanPendapatanJudul.Name = "lblRingkasanPendapatanJudul";
            lblRingkasanPendapatanJudul.Size = new Size(276, 25);
            lblRingkasanPendapatanJudul.TabIndex = 0;
            lblRingkasanPendapatanJudul.Text = "Total Pendapatan";
            lblRingkasanPendapatanJudul.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblRingkasanTransaksiJudul
            // 
            lblRingkasanTransaksiJudul.BackColor = Color.Transparent;
            lblRingkasanTransaksiJudul.Font = new Font("Segoe UI", 9.5F);
            lblRingkasanTransaksiJudul.ForeColor = Color.FromArgb(90, 110, 140);
            lblRingkasanTransaksiJudul.Location = new Point(5, 25);
            lblRingkasanTransaksiJudul.Margin = new Padding(5, 0, 5, 0);
            lblRingkasanTransaksiJudul.Name = "lblRingkasanTransaksiJudul";
            lblRingkasanTransaksiJudul.Size = new Size(282, 33);
            lblRingkasanTransaksiJudul.TabIndex = 2;
            lblRingkasanTransaksiJudul.Text = "Total Transaksi";
            lblRingkasanTransaksiJudul.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblRingkasanTransaksiNilai
            // 
            lblRingkasanTransaksiNilai.BackColor = Color.Transparent;
            lblRingkasanTransaksiNilai.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold);
            lblRingkasanTransaksiNilai.ForeColor = Color.FromArgb(13, 47, 110);
            lblRingkasanTransaksiNilai.Location = new Point(309, 25);
            lblRingkasanTransaksiNilai.Margin = new Padding(5, 0, 5, 0);
            lblRingkasanTransaksiNilai.Name = "lblRingkasanTransaksiNilai";
            lblRingkasanTransaksiNilai.Size = new Size(240, 33);
            lblRingkasanTransaksiNilai.TabIndex = 3;
            lblRingkasanTransaksiNilai.Text = "0";
            lblRingkasanTransaksiNilai.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblRingkasanRataJudul
            // 
            lblRingkasanRataJudul.BackColor = Color.Transparent;
            lblRingkasanRataJudul.Font = new Font("Segoe UI", 9.5F);
            lblRingkasanRataJudul.ForeColor = Color.FromArgb(90, 110, 140);
            lblRingkasanRataJudul.Location = new Point(5, 58);
            lblRingkasanRataJudul.Margin = new Padding(5, 0, 5, 0);
            lblRingkasanRataJudul.Name = "lblRingkasanRataJudul";
            lblRingkasanRataJudul.Size = new Size(294, 37);
            lblRingkasanRataJudul.TabIndex = 4;
            lblRingkasanRataJudul.Text = "Rata-rata / Transaksi";
            lblRingkasanRataJudul.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblRingkasanPendapatanNilai
            // 
            lblRingkasanPendapatanNilai.BackColor = Color.Transparent;
            lblRingkasanPendapatanNilai.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold);
            lblRingkasanPendapatanNilai.ForeColor = Color.FromArgb(13, 47, 110);
            lblRingkasanPendapatanNilai.Location = new Point(309, 0);
            lblRingkasanPendapatanNilai.Margin = new Padding(5, 0, 5, 0);
            lblRingkasanPendapatanNilai.Name = "lblRingkasanPendapatanNilai";
            lblRingkasanPendapatanNilai.Size = new Size(240, 25);
            lblRingkasanPendapatanNilai.TabIndex = 1;
            lblRingkasanPendapatanNilai.Text = "Rp 0";
            lblRingkasanPendapatanNilai.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblRingkasanRataNilai
            // 
            lblRingkasanRataNilai.BackColor = Color.Transparent;
            lblRingkasanRataNilai.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold);
            lblRingkasanRataNilai.ForeColor = Color.FromArgb(13, 47, 110);
            lblRingkasanRataNilai.Location = new Point(309, 58);
            lblRingkasanRataNilai.Margin = new Padding(5, 0, 5, 0);
            lblRingkasanRataNilai.Name = "lblRingkasanRataNilai";
            lblRingkasanRataNilai.Size = new Size(240, 37);
            lblRingkasanRataNilai.TabIndex = 5;
            lblRingkasanRataNilai.Text = "Rp 0";
            lblRingkasanRataNilai.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblRingkasanJudul
            // 
            lblRingkasanJudul.BackColor = Color.Transparent;
            lblRingkasanJudul.Dock = DockStyle.Top;
            lblRingkasanJudul.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblRingkasanJudul.ForeColor = Color.FromArgb(13, 47, 110);
            lblRingkasanJudul.Location = new Point(33, 27);
            lblRingkasanJudul.Margin = new Padding(5, 0, 5, 0);
            lblRingkasanJudul.Name = "lblRingkasanJudul";
            lblRingkasanJudul.Size = new Size(611, 62);
            lblRingkasanJudul.TabIndex = 0;
            lblRingkasanJudul.Text = "Penjualan Hari Ini";
            lblRingkasanJudul.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // timerJam
            // 
            timerJam.Interval = 1000;
            // 
            // UC_DSHBRDKasir
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(234, 243, 252);
            Controls.Add(tlpRoot);
            Margin = new Padding(5, 6, 5, 6);
            Name = "UC_DSHBRDKasir";
            Size = new Size(1833, 1346);
            tlpRoot.ResumeLayout(false);
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            tlpCards.ResumeLayout(false);
            cardPendapatan.ResumeLayout(false);
            cardPendapatan.PerformLayout();
            cardTransaksi.ResumeLayout(false);
            cardTransaksi.PerformLayout();
            cardTerjual.ResumeLayout(false);
            cardTerjual.PerformLayout();
            cardKeranjang.ResumeLayout(false);
            cardKeranjang.PerformLayout();
            tlpContent.ResumeLayout(false);
            pnlTransaksi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTransaksi).EndInit();
            tlpKanan.ResumeLayout(false);
            pnlKeranjang.ResumeLayout(false);
            tlpKeranjang.ResumeLayout(false);
            pnlRingkasan.ResumeLayout(false);
            tlpRingkasan.ResumeLayout(false);
            ResumeLayout(false);
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
        private System.Windows.Forms.Timer timerJam;
    }
}