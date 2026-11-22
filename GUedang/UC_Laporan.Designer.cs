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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
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
            txtCari = new TextBox();
            btnTampilkan = new RoundedButtonUI();
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
            txtKasir = new TextBox();
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
            tlpRoot.Padding = new Padding(27, 30, 27, 30);
            tlpRoot.RowCount = 2;
            tlpRoot.RowStyles.Add(new RowStyle(SizeType.Absolute, 112F));
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
            pnlJudul.Controls.Add(lblSub);
            pnlJudul.Controls.Add(lblJudul);
            pnlJudul.Location = new Point(27, 30);
            pnlJudul.Margin = new Padding(0, 0, 0, 23);
            pnlJudul.Name = "pnlJudul";
            pnlJudul.Radius = 18;
            pnlJudul.Size = new Size(1779, 89);
            pnlJudul.TabIndex = 0;
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
            lblSub.Size = new Size(509, 25);
            lblSub.TabIndex = 0;
            lblSub.Text = "Ringkasan transaksi penjualan kasir beserta barang terlaris.";
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
            lblJudul.Size = new Size(290, 45);
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
            tlpContent.Location = new Point(27, 142);
            tlpContent.Margin = new Padding(0);
            tlpContent.Name = "tlpContent";
            tlpContent.RowCount = 3;
            tlpContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 160F));
            tlpContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 110F));
            tlpContent.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpContent.Size = new Size(1779, 1366);
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
            tlpStats.Location = new Point(0, 0);
            tlpStats.Margin = new Padding(0, 0, 0, 23);
            tlpStats.Name = "tlpStats";
            tlpStats.RowCount = 1;
            tlpStats.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpStats.Size = new Size(1779, 136);
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
            cardPendapatan.Margin = new Padding(0, 0, 20, 0);
            cardPendapatan.Name = "cardPendapatan";
            cardPendapatan.Radius = 18;
            cardPendapatan.Size = new Size(424, 136);
            cardPendapatan.TabIndex = 0;
            // 
            // lblPendapatanKet
            // 
            lblPendapatanKet.AutoSize = true;
            lblPendapatanKet.BackColor = Color.Transparent;
            lblPendapatanKet.Font = new Font("Segoe UI", 8.5F);
            lblPendapatanKet.ForeColor = Color.FromArgb(120, 135, 160);
            lblPendapatanKet.Location = new Point(109, 110);
            lblPendapatanKet.Margin = new Padding(6, 0, 6, 0);
            lblPendapatanKet.Name = "lblPendapatanKet";
            lblPendapatanKet.Size = new Size(125, 23);
            lblPendapatanKet.TabIndex = 0;
            lblPendapatanKet.Text = "Periode terpilih";
            // 
            // lblPendapatanNilai
            // 
            lblPendapatanNilai.AutoSize = true;
            lblPendapatanNilai.BackColor = Color.Transparent;
            lblPendapatanNilai.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            lblPendapatanNilai.ForeColor = Color.FromArgb(24, 94, 224);
            lblPendapatanNilai.Location = new Point(47, 62);
            lblPendapatanNilai.Margin = new Padding(6, 0, 6, 0);
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
            lblPendapatanJudul.Location = new Point(50, 27);
            lblPendapatanJudul.Margin = new Padding(6, 0, 6, 0);
            lblPendapatanJudul.Name = "lblPendapatanJudul";
            lblPendapatanJudul.Size = new Size(157, 25);
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
            cardTrx.Location = new Point(444, 0);
            cardTrx.Margin = new Padding(0, 0, 20, 0);
            cardTrx.Name = "cardTrx";
            cardTrx.Radius = 18;
            cardTrx.Size = new Size(424, 136);
            cardTrx.TabIndex = 1;
            // 
            // lblTrxKet
            // 
            lblTrxKet.AutoSize = true;
            lblTrxKet.BackColor = Color.Transparent;
            lblTrxKet.Font = new Font("Segoe UI", 8.5F);
            lblTrxKet.ForeColor = Color.FromArgb(120, 135, 160);
            lblTrxKet.Location = new Point(91, 110);
            lblTrxKet.Margin = new Padding(6, 0, 6, 0);
            lblTrxKet.Name = "lblTrxKet";
            lblTrxKet.Size = new Size(132, 23);
            lblTrxKet.TabIndex = 0;
            lblTrxKet.Text = "Transaksi selesai";
            // 
            // lblTrxNilai
            // 
            lblTrxNilai.AutoSize = true;
            lblTrxNilai.BackColor = Color.Transparent;
            lblTrxNilai.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            lblTrxNilai.ForeColor = Color.FromArgb(40, 140, 90);
            lblTrxNilai.Location = new Point(47, 62);
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
            // cardItem
            // 
            cardItem.AccentColor = Color.FromArgb(126, 87, 194);
            cardItem.BackColor = Color.White;
            cardItem.BorderColor = Color.FromArgb(214, 228, 245);
            cardItem.Controls.Add(lblItemKet);
            cardItem.Controls.Add(lblItemNilai);
            cardItem.Controls.Add(lblItemJudul);
            cardItem.Dock = DockStyle.Fill;
            cardItem.Location = new Point(888, 0);
            cardItem.Margin = new Padding(0, 0, 20, 0);
            cardItem.Name = "cardItem";
            cardItem.Radius = 18;
            cardItem.Size = new Size(424, 136);
            cardItem.TabIndex = 2;
            // 
            // lblItemKet
            // 
            lblItemKet.AutoSize = true;
            lblItemKet.BackColor = Color.Transparent;
            lblItemKet.Font = new Font("Segoe UI", 8.5F);
            lblItemKet.ForeColor = Color.FromArgb(120, 135, 160);
            lblItemKet.Location = new Point(83, 110);
            lblItemKet.Margin = new Padding(6, 0, 6, 0);
            lblItemKet.Name = "lblItemKet";
            lblItemKet.Size = new Size(134, 23);
            lblItemKet.TabIndex = 0;
            lblItemKet.Text = "Total qty barang";
            // 
            // lblItemNilai
            // 
            lblItemNilai.AutoSize = true;
            lblItemNilai.BackColor = Color.Transparent;
            lblItemNilai.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            lblItemNilai.ForeColor = Color.FromArgb(126, 87, 194);
            lblItemNilai.Location = new Point(47, 62);
            lblItemNilai.Margin = new Padding(6, 0, 6, 0);
            lblItemNilai.Name = "lblItemNilai";
            lblItemNilai.Size = new Size(40, 48);
            lblItemNilai.TabIndex = 1;
            lblItemNilai.Text = "0";
            // 
            // lblItemJudul
            // 
            lblItemJudul.AutoSize = true;
            lblItemJudul.BackColor = Color.Transparent;
            lblItemJudul.Font = new Font("Segoe UI", 9.5F);
            lblItemJudul.ForeColor = Color.FromArgb(90, 110, 140);
            lblItemJudul.Location = new Point(50, 27);
            lblItemJudul.Margin = new Padding(6, 0, 6, 0);
            lblItemJudul.Name = "lblItemJudul";
            lblItemJudul.Size = new Size(110, 25);
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
            cardRata.Location = new Point(1332, 0);
            cardRata.Margin = new Padding(0);
            cardRata.Name = "cardRata";
            cardRata.Radius = 18;
            cardRata.Size = new Size(447, 136);
            cardRata.TabIndex = 3;
            // 
            // lblRataKet
            // 
            lblRataKet.AutoSize = true;
            lblRataKet.BackColor = Color.Transparent;
            lblRataKet.Font = new Font("Segoe UI", 8.5F);
            lblRataKet.ForeColor = Color.FromArgb(120, 135, 160);
            lblRataKet.Location = new Point(85, 110);
            lblRataKet.Margin = new Padding(6, 0, 6, 0);
            lblRataKet.Name = "lblRataKet";
            lblRataKet.Size = new Size(184, 23);
            lblRataKet.TabIndex = 0;
            lblRataKet.Text = "Pendapatan / transaksi";
            // 
            // lblRataNilai
            // 
            lblRataNilai.AutoSize = true;
            lblRataNilai.BackColor = Color.Transparent;
            lblRataNilai.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            lblRataNilai.ForeColor = Color.FromArgb(200, 125, 10);
            lblRataNilai.Location = new Point(47, 62);
            lblRataNilai.Margin = new Padding(6, 0, 6, 0);
            lblRataNilai.Name = "lblRataNilai";
            lblRataNilai.Size = new Size(94, 48);
            lblRataNilai.TabIndex = 1;
            lblRataNilai.Text = "Rp 0";
            // 
            // lblRataJudul
            // 
            lblRataJudul.AutoSize = true;
            lblRataJudul.BackColor = Color.Transparent;
            lblRataJudul.Font = new Font("Segoe UI", 9.5F);
            lblRataJudul.ForeColor = Color.FromArgb(90, 110, 140);
            lblRataJudul.Location = new Point(50, 27);
            lblRataJudul.Margin = new Padding(6, 0, 6, 0);
            lblRataJudul.Name = "lblRataJudul";
            lblRataJudul.Size = new Size(183, 25);
            lblRataJudul.TabIndex = 2;
            lblRataJudul.Text = "Rata-rata / Transaksi";
            // 
            // pnlFilter
            // 
            pnlFilter.AccentColor = Color.Transparent;
            pnlFilter.BackColor = Color.White;
            pnlFilter.BorderColor = Color.FromArgb(214, 228, 245);
            pnlFilter.Controls.Add(txtKasir);
            pnlFilter.Controls.Add(cmbRentang);
            pnlFilter.Controls.Add(lblDari);
            pnlFilter.Controls.Add(dtpDari);
            pnlFilter.Controls.Add(lblSampai);
            pnlFilter.Controls.Add(dtpSampai);
            pnlFilter.Controls.Add(txtCari);
            pnlFilter.Controls.Add(btnTampilkan);
            pnlFilter.Location = new Point(0, 160);
            pnlFilter.Margin = new Padding(0, 0, 0, 23);
            pnlFilter.Name = "pnlFilter";
            pnlFilter.Padding = new Padding(33, 0, 33, 0);
            pnlFilter.Radius = 18;
            pnlFilter.Size = new Size(1779, 87);
            pnlFilter.TabIndex = 1;
            // 
            // cmbRentang
            // 
            cmbRentang.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRentang.Font = new Font("Segoe UI", 10F);
            cmbRentang.FormattingEnabled = true;
            cmbRentang.Items.AddRange(new object[] { "Hari ini", "7 hari terakhir", "30 hari terakhir", "Bulan ini", "Semua", "Pilih manual" });
            cmbRentang.Location = new Point(33, 35);
            cmbRentang.Margin = new Padding(0);
            cmbRentang.Name = "cmbRentang";
            cmbRentang.Size = new Size(247, 36);
            cmbRentang.TabIndex = 0;
            // 
            // lblDari
            // 
            lblDari.AutoSize = true;
            lblDari.BackColor = Color.Transparent;
            lblDari.Font = new Font("Segoe UI", 9.5F);
            lblDari.ForeColor = Color.FromArgb(90, 110, 140);
            lblDari.Location = new Point(303, 42);
            lblDari.Margin = new Padding(6, 0, 6, 0);
            lblDari.Name = "lblDari";
            lblDari.Size = new Size(47, 25);
            lblDari.TabIndex = 1;
            lblDari.Text = "Dari";
            // 
            // dtpDari
            // 
            dtpDari.Font = new Font("Segoe UI", 9.5F);
            dtpDari.Format = DateTimePickerFormat.Short;
            dtpDari.Location = new Point(357, 35);
            dtpDari.Margin = new Padding(6, 5, 6, 5);
            dtpDari.Name = "dtpDari";
            dtpDari.Size = new Size(197, 33);
            dtpDari.TabIndex = 2;
            // 
            // lblSampai
            // 
            lblSampai.AutoSize = true;
            lblSampai.BackColor = Color.Transparent;
            lblSampai.Font = new Font("Segoe UI", 9.5F);
            lblSampai.ForeColor = Color.FromArgb(90, 110, 140);
            lblSampai.Location = new Point(577, 42);
            lblSampai.Margin = new Padding(6, 0, 6, 0);
            lblSampai.Name = "lblSampai";
            lblSampai.Size = new Size(74, 25);
            lblSampai.TabIndex = 3;
            lblSampai.Text = "Sampai";
            // 
            // dtpSampai
            // 
            dtpSampai.Font = new Font("Segoe UI", 9.5F);
            dtpSampai.Format = DateTimePickerFormat.Short;
            dtpSampai.Location = new Point(657, 35);
            dtpSampai.Margin = new Padding(6, 5, 6, 5);
            dtpSampai.Name = "dtpSampai";
            dtpSampai.Size = new Size(197, 33);
            dtpSampai.TabIndex = 4;
            // 
            // txtCari
            // 
            txtCari.Font = new Font("Segoe UI", 10F);
            txtCari.Location = new Point(1113, 35);
            txtCari.Margin = new Padding(0);
            txtCari.Name = "txtCari";
            txtCari.PlaceholderText = "Cari kode transaksi...";
            txtCari.Size = new Size(281, 34);
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
            btnTampilkan.Location = new Point(1417, 23);
            btnTampilkan.Margin = new Padding(6, 5, 6, 5);
            btnTampilkan.Name = "btnTampilkan";
            btnTampilkan.Size = new Size(143, 48);
            btnTampilkan.TabIndex = 7;
            btnTampilkan.Text = "Tampilkan";
            btnTampilkan.UseVisualStyleBackColor = false;
            // 
            // tlpMain
            // 
            tlpMain.ColumnCount = 2;
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tlpMain.Controls.Add(pnlTrx, 0, 0);
            tlpMain.Controls.Add(tlpKanan, 1, 0);
            tlpMain.Dock = DockStyle.Fill;
            tlpMain.Location = new Point(0, 270);
            tlpMain.Margin = new Padding(0);
            tlpMain.Name = "tlpMain";
            tlpMain.RowCount = 1;
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpMain.Size = new Size(1779, 1096);
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
            pnlTrx.Margin = new Padding(0, 0, 20, 0);
            pnlTrx.Name = "pnlTrx";
            pnlTrx.Padding = new Padding(33, 27, 33, 30);
            pnlTrx.Radius = 18;
            pnlTrx.Size = new Size(1047, 1096);
            pnlTrx.TabIndex = 0;
            // 
            // dgvTrx
            // 
            dgvTrx.AllowUserToAddRows = false;
            dgvTrx.AllowUserToDeleteRows = false;
            dgvTrx.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTrx.BackgroundColor = Color.White;
            dgvTrx.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.RoyalBlue;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            dataGridViewCellStyle1.SelectionForeColor = Color.RoyalBlue;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvTrx.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvTrx.ColumnHeadersHeight = 40;
            dgvTrx.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvTrx.Columns.AddRange(new DataGridViewColumn[] { colNo, colKode, colTanggal, colKasir, colItem, colTotal });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.AliceBlue;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.RoyalBlue;
            dataGridViewCellStyle2.SelectionBackColor = Color.RoyalBlue;
            dataGridViewCellStyle2.SelectionForeColor = Color.AliceBlue;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvTrx.DefaultCellStyle = dataGridViewCellStyle2;
            dgvTrx.Dock = DockStyle.Fill;
            dgvTrx.EnableHeadersVisualStyles = false;
            dgvTrx.Location = new Point(33, 92);
            dgvTrx.Margin = new Padding(0);
            dgvTrx.MultiSelect = false;
            dgvTrx.Name = "dgvTrx";
            dgvTrx.ReadOnly = true;
            dgvTrx.RowHeadersVisible = false;
            dgvTrx.RowHeadersWidth = 62;
            dgvTrx.Size = new Size(981, 974);
            dgvTrx.TabIndex = 0;
            // 
            // colNo
            // 
            colNo.FillWeight = 7F;
            colNo.HeaderText = "No";
            colNo.MinimumWidth = 8;
            colNo.Name = "colNo";
            colNo.ReadOnly = true;
            // 
            // colKode
            // 
            colKode.FillWeight = 20F;
            colKode.HeaderText = "Kode Transaksi";
            colKode.MinimumWidth = 8;
            colKode.Name = "colKode";
            colKode.ReadOnly = true;
            // 
            // colTanggal
            // 
            colTanggal.FillWeight = 22F;
            colTanggal.HeaderText = "Tanggal";
            colTanggal.MinimumWidth = 8;
            colTanggal.Name = "colTanggal";
            colTanggal.ReadOnly = true;
            // 
            // colKasir
            // 
            colKasir.FillWeight = 20F;
            colKasir.HeaderText = "Nama Kasir";
            colKasir.MinimumWidth = 8;
            colKasir.Name = "colKasir";
            colKasir.ReadOnly = true;
            // 
            // colItem
            // 
            colItem.FillWeight = 9F;
            colItem.HeaderText = "Item";
            colItem.MinimumWidth = 8;
            colItem.Name = "colItem";
            colItem.ReadOnly = true;
            // 
            // colTotal
            // 
            colTotal.FillWeight = 22F;
            colTotal.HeaderText = "Total Harga";
            colTotal.MinimumWidth = 8;
            colTotal.Name = "colTotal";
            colTotal.ReadOnly = true;
            // 
            // lblDaftarTrxJudul
            // 
            lblDaftarTrxJudul.BackColor = Color.Transparent;
            lblDaftarTrxJudul.Dock = DockStyle.Top;
            lblDaftarTrxJudul.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblDaftarTrxJudul.ForeColor = Color.FromArgb(13, 47, 110);
            lblDaftarTrxJudul.Location = new Point(33, 27);
            lblDaftarTrxJudul.Margin = new Padding(6, 0, 6, 0);
            lblDaftarTrxJudul.Name = "lblDaftarTrxJudul";
            lblDaftarTrxJudul.Size = new Size(981, 65);
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
            tlpKanan.Location = new Point(1067, 0);
            tlpKanan.Margin = new Padding(0);
            tlpKanan.Name = "tlpKanan";
            tlpKanan.RowCount = 2;
            tlpKanan.RowStyles.Add(new RowStyle(SizeType.Percent, 52.6459846F));
            tlpKanan.RowStyles.Add(new RowStyle(SizeType.Percent, 47.3540154F));
            tlpKanan.Size = new Size(712, 1096);
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
            pnlDetail.Location = new Point(0, 0);
            pnlDetail.Margin = new Padding(0, 0, 0, 23);
            pnlDetail.Name = "pnlDetail";
            pnlDetail.Padding = new Padding(33, 27, 33, 30);
            pnlDetail.Radius = 18;
            pnlDetail.Size = new Size(711, 500);
            pnlDetail.TabIndex = 0;
            // 
            // dgvDetail
            // 
            dgvDetail.AllowUserToAddRows = false;
            dgvDetail.AllowUserToDeleteRows = false;
            dgvDetail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDetail.BackgroundColor = Color.White;
            dgvDetail.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.DarkGreen;
            dataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.MintCream;
            dataGridViewCellStyle3.SelectionBackColor = Color.MintCream;
            dataGridViewCellStyle3.SelectionForeColor = Color.DarkGreen;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvDetail.ColumnHeadersHeight = 40;
            dgvDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvDetail.Columns.AddRange(new DataGridViewColumn[] { colDBarang, colDQty, colDSubtotal });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.Honeydew;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = Color.SeaGreen;
            dataGridViewCellStyle4.SelectionBackColor = Color.SeaGreen;
            dataGridViewCellStyle4.SelectionForeColor = Color.Honeydew;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvDetail.DefaultCellStyle = dataGridViewCellStyle4;
            dgvDetail.EnableHeadersVisualStyles = false;
            dgvDetail.Location = new Point(33, 72);
            dgvDetail.Margin = new Padding(0);
            dgvDetail.MultiSelect = false;
            dgvDetail.Name = "dgvDetail";
            dgvDetail.ReadOnly = true;
            dgvDetail.RowHeadersVisible = false;
            dgvDetail.RowHeadersWidth = 62;
            dgvDetail.Size = new Size(646, 286);
            dgvDetail.TabIndex = 0;
            // 
            // colDBarang
            // 
            colDBarang.FillWeight = 52F;
            colDBarang.HeaderText = "Barang";
            colDBarang.MinimumWidth = 8;
            colDBarang.Name = "colDBarang";
            colDBarang.ReadOnly = true;
            // 
            // colDQty
            // 
            colDQty.FillWeight = 14F;
            colDQty.HeaderText = "Qty";
            colDQty.MinimumWidth = 8;
            colDQty.Name = "colDQty";
            colDQty.ReadOnly = true;
            // 
            // colDSubtotal
            // 
            colDSubtotal.FillWeight = 34F;
            colDSubtotal.HeaderText = "Subtotal";
            colDSubtotal.MinimumWidth = 8;
            colDSubtotal.Name = "colDSubtotal";
            colDSubtotal.ReadOnly = true;
            // 
            // lblDetailTotal
            // 
            lblDetailTotal.BackColor = Color.Transparent;
            lblDetailTotal.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold);
            lblDetailTotal.ForeColor = Color.FromArgb(30, 136, 229);
            lblDetailTotal.Location = new Point(426, 29);
            lblDetailTotal.Margin = new Padding(6, 0, 6, 0);
            lblDetailTotal.Name = "lblDetailTotal";
            lblDetailTotal.Size = new Size(198, 43);
            lblDetailTotal.TabIndex = 1;
            lblDetailTotal.Text = "Total: Rp 0";
            lblDetailTotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblDetailNo
            // 
            lblDetailNo.BackColor = Color.Transparent;
            lblDetailNo.Font = new Font("Segoe UI", 9F);
            lblDetailNo.ForeColor = Color.FromArgb(90, 110, 140);
            lblDetailNo.Location = new Point(33, 49);
            lblDetailNo.Margin = new Padding(6, 0, 6, 0);
            lblDetailNo.Name = "lblDetailNo";
            lblDetailNo.Size = new Size(646, 23);
            lblDetailNo.TabIndex = 2;
            lblDetailNo.Text = "Pilih transaksi untuk melihat detail";
            lblDetailNo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblDetailJudul
            // 
            lblDetailJudul.BackColor = Color.Transparent;
            lblDetailJudul.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblDetailJudul.ForeColor = Color.FromArgb(13, 47, 110);
            lblDetailJudul.Location = new Point(33, 4);
            lblDetailJudul.Margin = new Padding(6, 0, 6, 0);
            lblDetailJudul.Name = "lblDetailJudul";
            lblDetailJudul.Size = new Size(646, 65);
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
            pnlTop.Location = new Point(0, 577);
            pnlTop.Margin = new Padding(0);
            pnlTop.Name = "pnlTop";
            pnlTop.Padding = new Padding(33, 27, 33, 30);
            pnlTop.Radius = 18;
            pnlTop.Size = new Size(711, 390);
            pnlTop.TabIndex = 1;
            // 
            // dgvTop
            // 
            dgvTop.AllowUserToAddRows = false;
            dgvTop.AllowUserToDeleteRows = false;
            dgvTop.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTop.BackgroundColor = Color.White;
            dgvTop.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.Teal;
            dataGridViewCellStyle5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.LightCyan;
            dataGridViewCellStyle5.SelectionBackColor = Color.LightCyan;
            dataGridViewCellStyle5.SelectionForeColor = Color.Teal;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvTop.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvTop.ColumnHeadersHeight = 40;
            dgvTop.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvTop.Columns.AddRange(new DataGridViewColumn[] { colTBarang, colTQty, colTOmzet });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.Azure;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = Color.DarkCyan;
            dataGridViewCellStyle6.SelectionBackColor = Color.DarkCyan;
            dataGridViewCellStyle6.SelectionForeColor = Color.Azure;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvTop.DefaultCellStyle = dataGridViewCellStyle6;
            dgvTop.EnableHeadersVisualStyles = false;
            dgvTop.Location = new Point(33, 61);
            dgvTop.Margin = new Padding(0);
            dgvTop.MultiSelect = false;
            dgvTop.Name = "dgvTop";
            dgvTop.ReadOnly = true;
            dgvTop.RowHeadersVisible = false;
            dgvTop.RowHeadersWidth = 62;
            dgvTop.Size = new Size(646, 338);
            dgvTop.TabIndex = 0;
            // 
            // colTBarang
            // 
            colTBarang.FillWeight = 50F;
            colTBarang.HeaderText = "Barang";
            colTBarang.MinimumWidth = 8;
            colTBarang.Name = "colTBarang";
            colTBarang.ReadOnly = true;
            // 
            // colTQty
            // 
            colTQty.FillWeight = 18F;
            colTQty.HeaderText = "Terjual";
            colTQty.MinimumWidth = 8;
            colTQty.Name = "colTQty";
            colTQty.ReadOnly = true;
            // 
            // colTOmzet
            // 
            colTOmzet.FillWeight = 32F;
            colTOmzet.HeaderText = "Omzet";
            colTOmzet.MinimumWidth = 8;
            colTOmzet.Name = "colTOmzet";
            colTOmzet.ReadOnly = true;
            // 
            // lblTopJudul
            // 
            lblTopJudul.BackColor = Color.Transparent;
            lblTopJudul.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblTopJudul.ForeColor = Color.FromArgb(13, 47, 110);
            lblTopJudul.Location = new Point(33, 27);
            lblTopJudul.Margin = new Padding(6, 0, 6, 0);
            lblTopJudul.Name = "lblTopJudul";
            lblTopJudul.Size = new Size(646, 34);
            lblTopJudul.TabIndex = 1;
            lblTopJudul.Text = "5 Barang Terlaris";
            lblTopJudul.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtKasir
            // 
            txtKasir.Font = new Font("Segoe UI", 10F);
            txtKasir.Location = new Point(870, 34);
            txtKasir.Margin = new Padding(0);
            txtKasir.Name = "txtKasir";
            txtKasir.PlaceholderText = "Cari Kasir...";
            txtKasir.Size = new Size(222, 34);
            txtKasir.TabIndex = 8;
            // 
            // UC_Laporan
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(234, 243, 252);
            Controls.Add(tlpRoot);
            Margin = new Padding(6, 5, 6, 5);
            Name = "UC_Laporan";
            Size = new Size(1833, 1538);
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
        private System.Windows.Forms.TextBox txtCari;
        private RoundedButtonUI btnTampilkan;
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
        private TextBox txtKasir;
    }
}