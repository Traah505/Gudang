namespace GUedang
{
    partial class UC_Barang
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
            cardTotal = new RoundedPanelUI();
            lblTotalKet = new Label();
            lblTotalNilai = new Label();
            lblTotalJudul = new Label();
            cardAman = new RoundedPanelUI();
            lblAmanKet = new Label();
            lblAmanNilai = new Label();
            lblAmanJudul = new Label();
            cardMenipis = new RoundedPanelUI();
            lblMenipisKet = new Label();
            lblMenipisNilai = new Label();
            lblMenipisJudul = new Label();
            cardHabis = new RoundedPanelUI();
            lblHabisKet = new Label();
            lblHabisNilai = new Label();
            lblHabisJudul = new Label();
            cardNilai = new RoundedPanelUI();
            lblNilaiKet = new Label();
            lblNilaiNilai = new Label();
            lblNilaiJudul = new Label();
            pnlFilter = new RoundedPanelUI();
            txtCari = new TextBox();
            btnSemua = new RoundedButtonUI();
            btnAman = new RoundedButtonUI();
            btnMenipis = new RoundedButtonUI();
            btnHabis = new RoundedButtonUI();
            cmbKategoriFilter = new ComboBox();
            btnExport = new RoundedButtonUI();
            tlpMain = new TableLayoutPanel();
            pnlTabel = new RoundedPanelUI();
            dgvBarang = new DataGridView();
            colKode = new DataGridViewTextBoxColumn();
            colNama = new DataGridViewTextBoxColumn();
            colKategori = new DataGridViewTextBoxColumn();
            colBeli = new DataGridViewTextBoxColumn();
            colJual = new DataGridViewTextBoxColumn();
            colStok = new DataGridViewTextBoxColumn();
            colMin = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            lblTabelJudul = new Label();
            pnlForm = new RoundedPanelUI();
            tlpForm = new TableLayoutPanel();
            lblKode = new Label();
            txtKode = new TextBox();
            lblNama = new Label();
            txtNama = new TextBox();
            lblKategori = new Label();
            lblSatuan = new Label();
            cmbKategori = new ComboBox();
            cmbSatuan = new ComboBox();
            lblStok = new Label();
            lblMin = new Label();
            nudStok = new NumericUpDown();
            nudMin = new NumericUpDown();
            lblBeli = new Label();
            lblJual = new Label();
            txtBeli = new TextBox();
            txtJual = new TextBox();
            lblMargin = new Label();
            flowTombol = new FlowLayoutPanel();
            btnSimpan = new RoundedButtonUI();
            btnReset = new RoundedButtonUI();
            btnHapus = new RoundedButtonUI();
            lblFormJudul = new Label();
            tlpRoot.SuspendLayout();
            pnlJudul.SuspendLayout();
            tlpContent.SuspendLayout();
            tlpStats.SuspendLayout();
            cardTotal.SuspendLayout();
            cardAman.SuspendLayout();
            cardMenipis.SuspendLayout();
            cardHabis.SuspendLayout();
            cardNilai.SuspendLayout();
            pnlFilter.SuspendLayout();
            tlpMain.SuspendLayout();
            pnlTabel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBarang).BeginInit();
            pnlForm.SuspendLayout();
            tlpForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudStok).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudMin).BeginInit();
            flowTombol.SuspendLayout();
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
            lblSub.Size = new Size(309, 17);
            lblSub.TabIndex = 0;
            lblSub.Text = "Pantau stok, tambah, ubah, dan hapus data barang.";
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
            lblJudul.Size = new Size(149, 30);
            lblJudul.TabIndex = 1;
            lblJudul.Text = "Kelola Barang";
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
            tlpStats.ColumnCount = 5;
            tlpStats.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlpStats.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlpStats.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlpStats.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlpStats.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlpStats.Controls.Add(cardTotal, 0, 0);
            tlpStats.Controls.Add(cardAman, 1, 0);
            tlpStats.Controls.Add(cardMenipis, 2, 0);
            tlpStats.Controls.Add(cardHabis, 3, 0);
            tlpStats.Controls.Add(cardNilai, 4, 0);
            tlpStats.Dock = DockStyle.Fill;
            tlpStats.Location = new Point(0, 0);
            tlpStats.Margin = new Padding(0, 0, 0, 14);
            tlpStats.Name = "tlpStats";
            tlpStats.RowCount = 1;
            tlpStats.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpStats.Size = new Size(1245, 120);
            tlpStats.TabIndex = 0;
            // 
            // cardTotal
            // 
            cardTotal.AccentColor = Color.FromArgb(30, 136, 229);
            cardTotal.BackColor = Color.White;
            cardTotal.BorderColor = Color.FromArgb(214, 228, 245);
            cardTotal.Controls.Add(lblTotalKet);
            cardTotal.Controls.Add(lblTotalNilai);
            cardTotal.Controls.Add(lblTotalJudul);
            cardTotal.Dock = DockStyle.Fill;
            cardTotal.Location = new Point(0, 0);
            cardTotal.Margin = new Padding(0, 0, 14, 0);
            cardTotal.Name = "cardTotal";
            cardTotal.Radius = 18;
            cardTotal.Size = new Size(235, 120);
            cardTotal.TabIndex = 0;
            // 
            // lblTotalKet
            // 
            lblTotalKet.AutoSize = true;
            lblTotalKet.BackColor = Color.Transparent;
            lblTotalKet.Font = new Font("Segoe UI", 8.5F);
            lblTotalKet.ForeColor = Color.FromArgb(120, 135, 160);
            lblTotalKet.Location = new Point(35, 78);
            lblTotalKet.Margin = new Padding(4, 0, 4, 0);
            lblTotalKet.Name = "lblTotalKet";
            lblTotalKet.Size = new Size(72, 15);
            lblTotalKet.TabIndex = 0;
            lblTotalKet.Text = "Jenis barang";
            // 
            // lblTotalNilai
            // 
            lblTotalNilai.AutoSize = true;
            lblTotalNilai.BackColor = Color.Transparent;
            lblTotalNilai.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            lblTotalNilai.ForeColor = Color.FromArgb(24, 94, 224);
            lblTotalNilai.Location = new Point(33, 37);
            lblTotalNilai.Margin = new Padding(4, 0, 4, 0);
            lblTotalNilai.Name = "lblTotalNilai";
            lblTotalNilai.Size = new Size(25, 30);
            lblTotalNilai.TabIndex = 1;
            lblTotalNilai.Text = "0";
            // 
            // lblTotalJudul
            // 
            lblTotalJudul.AutoSize = true;
            lblTotalJudul.BackColor = Color.Transparent;
            lblTotalJudul.Font = new Font("Segoe UI", 9.5F);
            lblTotalJudul.ForeColor = Color.FromArgb(90, 110, 140);
            lblTotalJudul.Location = new Point(35, 16);
            lblTotalJudul.Margin = new Padding(4, 0, 4, 0);
            lblTotalJudul.Name = "lblTotalJudul";
            lblTotalJudul.Size = new Size(81, 17);
            lblTotalJudul.TabIndex = 2;
            lblTotalJudul.Text = "Total Barang";
            // 
            // cardAman
            // 
            cardAman.AccentColor = Color.FromArgb(46, 160, 100);
            cardAman.BackColor = Color.White;
            cardAman.BorderColor = Color.FromArgb(214, 228, 245);
            cardAman.Controls.Add(lblAmanKet);
            cardAman.Controls.Add(lblAmanNilai);
            cardAman.Controls.Add(lblAmanJudul);
            cardAman.Dock = DockStyle.Fill;
            cardAman.Location = new Point(249, 0);
            cardAman.Margin = new Padding(0, 0, 14, 0);
            cardAman.Name = "cardAman";
            cardAman.Radius = 18;
            cardAman.Size = new Size(235, 120);
            cardAman.TabIndex = 1;
            // 
            // lblAmanKet
            // 
            lblAmanKet.AutoSize = true;
            lblAmanKet.BackColor = Color.Transparent;
            lblAmanKet.Font = new Font("Segoe UI", 8.5F);
            lblAmanKet.ForeColor = Color.FromArgb(120, 135, 160);
            lblAmanKet.Location = new Point(35, 78);
            lblAmanKet.Margin = new Padding(4, 0, 4, 0);
            lblAmanKet.Name = "lblAmanKet";
            lblAmanKet.Size = new Size(98, 15);
            lblAmanKet.TabIndex = 0;
            lblAmanKet.Text = "Di atas minimum";
            // 
            // lblAmanNilai
            // 
            lblAmanNilai.AutoSize = true;
            lblAmanNilai.BackColor = Color.Transparent;
            lblAmanNilai.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            lblAmanNilai.ForeColor = Color.FromArgb(40, 140, 90);
            lblAmanNilai.Location = new Point(33, 37);
            lblAmanNilai.Margin = new Padding(4, 0, 4, 0);
            lblAmanNilai.Name = "lblAmanNilai";
            lblAmanNilai.Size = new Size(25, 30);
            lblAmanNilai.TabIndex = 1;
            lblAmanNilai.Text = "0";
            // 
            // lblAmanJudul
            // 
            lblAmanJudul.AutoSize = true;
            lblAmanJudul.BackColor = Color.Transparent;
            lblAmanJudul.Font = new Font("Segoe UI", 9.5F);
            lblAmanJudul.ForeColor = Color.FromArgb(90, 110, 140);
            lblAmanJudul.Location = new Point(35, 16);
            lblAmanJudul.Margin = new Padding(4, 0, 4, 0);
            lblAmanJudul.Name = "lblAmanJudul";
            lblAmanJudul.Size = new Size(70, 17);
            lblAmanJudul.TabIndex = 2;
            lblAmanJudul.Text = "Stok Aman";
            // 
            // cardMenipis
            // 
            cardMenipis.AccentColor = Color.FromArgb(230, 150, 20);
            cardMenipis.BackColor = Color.White;
            cardMenipis.BorderColor = Color.FromArgb(214, 228, 245);
            cardMenipis.Controls.Add(lblMenipisKet);
            cardMenipis.Controls.Add(lblMenipisNilai);
            cardMenipis.Controls.Add(lblMenipisJudul);
            cardMenipis.Dock = DockStyle.Fill;
            cardMenipis.Location = new Point(498, 0);
            cardMenipis.Margin = new Padding(0, 0, 14, 0);
            cardMenipis.Name = "cardMenipis";
            cardMenipis.Radius = 18;
            cardMenipis.Size = new Size(235, 120);
            cardMenipis.TabIndex = 2;
            // 
            // lblMenipisKet
            // 
            lblMenipisKet.AutoSize = true;
            lblMenipisKet.BackColor = Color.Transparent;
            lblMenipisKet.Font = new Font("Segoe UI", 8.5F);
            lblMenipisKet.ForeColor = Color.FromArgb(120, 135, 160);
            lblMenipisKet.Location = new Point(35, 78);
            lblMenipisKet.Margin = new Padding(4, 0, 4, 0);
            lblMenipisKet.Name = "lblMenipisKet";
            lblMenipisKet.Size = new Size(84, 15);
            lblMenipisKet.TabIndex = 0;
            lblMenipisKet.Text = "Perlu diperiksa";
            // 
            // lblMenipisNilai
            // 
            lblMenipisNilai.AutoSize = true;
            lblMenipisNilai.BackColor = Color.Transparent;
            lblMenipisNilai.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            lblMenipisNilai.ForeColor = Color.FromArgb(200, 125, 10);
            lblMenipisNilai.Location = new Point(33, 37);
            lblMenipisNilai.Margin = new Padding(4, 0, 4, 0);
            lblMenipisNilai.Name = "lblMenipisNilai";
            lblMenipisNilai.Size = new Size(25, 30);
            lblMenipisNilai.TabIndex = 1;
            lblMenipisNilai.Text = "0";
            // 
            // lblMenipisJudul
            // 
            lblMenipisJudul.AutoSize = true;
            lblMenipisJudul.BackColor = Color.Transparent;
            lblMenipisJudul.Font = new Font("Segoe UI", 9.5F);
            lblMenipisJudul.ForeColor = Color.FromArgb(90, 110, 140);
            lblMenipisJudul.Location = new Point(35, 16);
            lblMenipisJudul.Margin = new Padding(4, 0, 4, 0);
            lblMenipisJudul.Name = "lblMenipisJudul";
            lblMenipisJudul.Size = new Size(83, 17);
            lblMenipisJudul.TabIndex = 2;
            lblMenipisJudul.Text = "Stok Menipis";
            // 
            // cardHabis
            // 
            cardHabis.AccentColor = Color.FromArgb(214, 69, 65);
            cardHabis.BackColor = Color.White;
            cardHabis.BorderColor = Color.FromArgb(214, 228, 245);
            cardHabis.Controls.Add(lblHabisKet);
            cardHabis.Controls.Add(lblHabisNilai);
            cardHabis.Controls.Add(lblHabisJudul);
            cardHabis.Dock = DockStyle.Fill;
            cardHabis.Location = new Point(747, 0);
            cardHabis.Margin = new Padding(0, 0, 14, 0);
            cardHabis.Name = "cardHabis";
            cardHabis.Radius = 18;
            cardHabis.Size = new Size(235, 120);
            cardHabis.TabIndex = 3;
            // 
            // lblHabisKet
            // 
            lblHabisKet.AutoSize = true;
            lblHabisKet.BackColor = Color.Transparent;
            lblHabisKet.Font = new Font("Segoe UI", 8.5F);
            lblHabisKet.ForeColor = Color.FromArgb(120, 135, 160);
            lblHabisKet.Location = new Point(35, 78);
            lblHabisKet.Margin = new Padding(4, 0, 4, 0);
            lblHabisKet.Name = "lblHabisKet";
            lblHabisKet.Size = new Size(88, 15);
            lblHabisKet.TabIndex = 0;
            lblHabisKet.Text = "Perlu ditambah";
            // 
            // lblHabisNilai
            // 
            lblHabisNilai.AutoSize = true;
            lblHabisNilai.BackColor = Color.Transparent;
            lblHabisNilai.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            lblHabisNilai.ForeColor = Color.FromArgb(210, 50, 50);
            lblHabisNilai.Location = new Point(33, 37);
            lblHabisNilai.Margin = new Padding(4, 0, 4, 0);
            lblHabisNilai.Name = "lblHabisNilai";
            lblHabisNilai.Size = new Size(25, 30);
            lblHabisNilai.TabIndex = 1;
            lblHabisNilai.Text = "0";
            // 
            // lblHabisJudul
            // 
            lblHabisJudul.AutoSize = true;
            lblHabisJudul.BackColor = Color.Transparent;
            lblHabisJudul.Font = new Font("Segoe UI", 9.5F);
            lblHabisJudul.ForeColor = Color.FromArgb(90, 110, 140);
            lblHabisJudul.Location = new Point(35, 16);
            lblHabisJudul.Margin = new Padding(4, 0, 4, 0);
            lblHabisJudul.Name = "lblHabisJudul";
            lblHabisJudul.Size = new Size(70, 17);
            lblHabisJudul.TabIndex = 2;
            lblHabisJudul.Text = "Stok Habis";
            // 
            // cardNilai
            // 
            cardNilai.AccentColor = Color.FromArgb(126, 87, 194);
            cardNilai.BackColor = Color.White;
            cardNilai.BorderColor = Color.FromArgb(214, 228, 245);
            cardNilai.Controls.Add(lblNilaiKet);
            cardNilai.Controls.Add(lblNilaiNilai);
            cardNilai.Controls.Add(lblNilaiJudul);
            cardNilai.Dock = DockStyle.Fill;
            cardNilai.Location = new Point(996, 0);
            cardNilai.Margin = new Padding(0);
            cardNilai.Name = "cardNilai";
            cardNilai.Radius = 18;
            cardNilai.Size = new Size(249, 120);
            cardNilai.TabIndex = 4;
            // 
            // lblNilaiKet
            // 
            lblNilaiKet.AutoSize = true;
            lblNilaiKet.BackColor = Color.Transparent;
            lblNilaiKet.Font = new Font("Segoe UI", 8.5F);
            lblNilaiKet.ForeColor = Color.FromArgb(120, 135, 160);
            lblNilaiKet.Location = new Point(35, 78);
            lblNilaiKet.Margin = new Padding(4, 0, 4, 0);
            lblNilaiKet.Name = "lblNilaiKet";
            lblNilaiKet.Size = new Size(94, 15);
            lblNilaiKet.TabIndex = 0;
            lblNilaiKet.Text = "Stok x harga beli";
            // 
            // lblNilaiNilai
            // 
            lblNilaiNilai.AutoSize = true;
            lblNilaiNilai.BackColor = Color.Transparent;
            lblNilaiNilai.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            lblNilaiNilai.ForeColor = Color.FromArgb(126, 87, 194);
            lblNilaiNilai.Location = new Point(33, 37);
            lblNilaiNilai.Margin = new Padding(4, 0, 4, 0);
            lblNilaiNilai.Name = "lblNilaiNilai";
            lblNilaiNilai.Size = new Size(58, 30);
            lblNilaiNilai.TabIndex = 1;
            lblNilaiNilai.Text = "Rp 0";
            // 
            // lblNilaiJudul
            // 
            lblNilaiJudul.AutoSize = true;
            lblNilaiJudul.BackColor = Color.Transparent;
            lblNilaiJudul.Font = new Font("Segoe UI", 9.5F);
            lblNilaiJudul.ForeColor = Color.FromArgb(90, 110, 140);
            lblNilaiJudul.Location = new Point(35, 16);
            lblNilaiJudul.Margin = new Padding(4, 0, 4, 0);
            lblNilaiJudul.Name = "lblNilaiJudul";
            lblNilaiJudul.Size = new Size(102, 17);
            lblNilaiJudul.TabIndex = 2;
            lblNilaiJudul.Text = "Nilai Persediaan";
            // 
            // pnlFilter
            // 
            pnlFilter.AccentColor = Color.Transparent;
            pnlFilter.BackColor = Color.White;
            pnlFilter.BorderColor = Color.FromArgb(214, 228, 245);
            pnlFilter.Controls.Add(txtCari);
            pnlFilter.Controls.Add(btnSemua);
            pnlFilter.Controls.Add(btnAman);
            pnlFilter.Controls.Add(btnMenipis);
            pnlFilter.Controls.Add(btnHabis);
            pnlFilter.Controls.Add(cmbKategoriFilter);
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
            // txtCari
            // 
            txtCari.Font = new Font("Segoe UI", 10F);
            txtCari.Location = new Point(23, 21);
            txtCari.Margin = new Padding(0);
            txtCari.Name = "txtCari";
            txtCari.PlaceholderText = "Cari nama barang atau kode...";
            txtCari.Size = new Size(291, 25);
            txtCari.TabIndex = 0;
            // 
            // btnSemua
            // 
            btnSemua.BackColor = Color.FromArgb(30, 136, 229);
            btnSemua.BorderColor = Color.Transparent;
            btnSemua.FlatStyle = FlatStyle.Flat;
            btnSemua.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            btnSemua.ForeColor = Color.White;
            btnSemua.HoverColor = Color.FromArgb(21, 101, 192);
            btnSemua.Location = new Point(334, 14);
            btnSemua.Margin = new Padding(4, 3, 4, 3);
            btnSemua.Name = "btnSemua";
            btnSemua.Size = new Size(93, 42);
            btnSemua.TabIndex = 1;
            btnSemua.Text = "Semua";
            btnSemua.UseVisualStyleBackColor = false;
            // 
            // btnAman
            // 
            btnAman.BackColor = Color.White;
            btnAman.BorderColor = Color.FromArgb(30, 136, 229);
            btnAman.FlatStyle = FlatStyle.Flat;
            btnAman.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            btnAman.ForeColor = Color.FromArgb(30, 136, 229);
            btnAman.HoverColor = Color.FromArgb(225, 240, 255);
            btnAman.Location = new Point(434, 14);
            btnAman.Margin = new Padding(4, 3, 4, 3);
            btnAman.Name = "btnAman";
            btnAman.Size = new Size(93, 42);
            btnAman.TabIndex = 2;
            btnAman.Text = "Aman";
            btnAman.UseVisualStyleBackColor = false;
            // 
            // btnMenipis
            // 
            btnMenipis.BackColor = Color.White;
            btnMenipis.BorderColor = Color.FromArgb(30, 136, 229);
            btnMenipis.FlatStyle = FlatStyle.Flat;
            btnMenipis.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            btnMenipis.ForeColor = Color.FromArgb(30, 136, 229);
            btnMenipis.HoverColor = Color.FromArgb(225, 240, 255);
            btnMenipis.Location = new Point(534, 14);
            btnMenipis.Margin = new Padding(4, 3, 4, 3);
            btnMenipis.Name = "btnMenipis";
            btnMenipis.Size = new Size(105, 42);
            btnMenipis.TabIndex = 3;
            btnMenipis.Text = "Menipis";
            btnMenipis.UseVisualStyleBackColor = false;
            // 
            // btnHabis
            // 
            btnHabis.BackColor = Color.White;
            btnHabis.BorderColor = Color.FromArgb(30, 136, 229);
            btnHabis.FlatStyle = FlatStyle.Flat;
            btnHabis.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            btnHabis.ForeColor = Color.FromArgb(30, 136, 229);
            btnHabis.HoverColor = Color.FromArgb(225, 240, 255);
            btnHabis.Location = new Point(646, 14);
            btnHabis.Margin = new Padding(4, 3, 4, 3);
            btnHabis.Name = "btnHabis";
            btnHabis.Size = new Size(93, 42);
            btnHabis.TabIndex = 4;
            btnHabis.Text = "Habis";
            btnHabis.UseVisualStyleBackColor = false;
            // 
            // cmbKategoriFilter
            // 
            cmbKategoriFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbKategoriFilter.Font = new Font("Segoe UI", 10F);
            cmbKategoriFilter.FormattingEnabled = true;
            cmbKategoriFilter.Location = new Point(758, 21);
            cmbKategoriFilter.Margin = new Padding(0);
            cmbKategoriFilter.Name = "cmbKategoriFilter";
            cmbKategoriFilter.Size = new Size(186, 25);
            cmbKategoriFilter.TabIndex = 5;
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
            btnExport.Location = new Point(1093, 14);
            btnExport.Margin = new Padding(4, 3, 4, 3);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(128, 42);
            btnExport.TabIndex = 6;
            btnExport.Text = "Export CSV";
            btnExport.UseVisualStyleBackColor = false;
            // 
            // tlpMain
            // 
            tlpMain.ColumnCount = 2;
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 66F));
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34F));
            tlpMain.Controls.Add(pnlTabel, 0, 0);
            tlpMain.Controls.Add(pnlForm, 1, 0);
            tlpMain.Dock = DockStyle.Fill;
            tlpMain.Location = new Point(0, 222);
            tlpMain.Margin = new Padding(0);
            tlpMain.Name = "tlpMain";
            tlpMain.RowCount = 1;
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpMain.Size = new Size(1245, 570);
            tlpMain.TabIndex = 2;
            // 
            // pnlTabel
            // 
            pnlTabel.AccentColor = Color.Transparent;
            pnlTabel.BackColor = Color.White;
            pnlTabel.BorderColor = Color.FromArgb(214, 228, 245);
            pnlTabel.Controls.Add(dgvBarang);
            pnlTabel.Controls.Add(lblTabelJudul);
            pnlTabel.Dock = DockStyle.Fill;
            pnlTabel.Location = new Point(0, 0);
            pnlTabel.Margin = new Padding(0, 0, 14, 0);
            pnlTabel.Name = "pnlTabel";
            pnlTabel.Padding = new Padding(23, 16, 23, 18);
            pnlTabel.Radius = 18;
            pnlTabel.Size = new Size(807, 570);
            pnlTabel.TabIndex = 0;
            // 
            // dgvBarang
            // 
            dgvBarang.Columns.AddRange(new DataGridViewColumn[] { colKode, colNama, colKategori, colBeli, colJual, colStok, colMin, colStatus });
            dgvBarang.Dock = DockStyle.Fill;
            dgvBarang.Location = new Point(23, 55);
            dgvBarang.Margin = new Padding(0);
            dgvBarang.Name = "dgvBarang";
            dgvBarang.Size = new Size(761, 497);
            dgvBarang.TabIndex = 0;
            // 
            // colKode
            // 
            colKode.FillWeight = 11F;
            colKode.HeaderText = "Kode";
            colKode.Name = "colKode";
            // 
            // colNama
            // 
            colNama.FillWeight = 25F;
            colNama.HeaderText = "Nama";
            colNama.Name = "colNama";
            // 
            // colKategori
            // 
            colKategori.FillWeight = 14F;
            colKategori.HeaderText = "Kategori";
            colKategori.Name = "colKategori";
            // 
            // colBeli
            // 
            colBeli.FillWeight = 12F;
            colBeli.HeaderText = "Hrg Beli";
            colBeli.Name = "colBeli";
            // 
            // colJual
            // 
            colJual.FillWeight = 12F;
            colJual.HeaderText = "Hrg Jual";
            colJual.Name = "colJual";
            // 
            // colStok
            // 
            colStok.FillWeight = 8F;
            colStok.HeaderText = "Stok";
            colStok.Name = "colStok";
            // 
            // colMin
            // 
            colMin.FillWeight = 9F;
            colMin.HeaderText = "Minimum";
            colMin.Name = "colMin";
            // 
            // colStatus
            // 
            colStatus.FillWeight = 10F;
            colStatus.HeaderText = "Status";
            colStatus.Name = "colStatus";
            // 
            // lblTabelJudul
            // 
            lblTabelJudul.BackColor = Color.Transparent;
            lblTabelJudul.Dock = DockStyle.Top;
            lblTabelJudul.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblTabelJudul.ForeColor = Color.FromArgb(13, 47, 110);
            lblTabelJudul.Location = new Point(23, 16);
            lblTabelJudul.Margin = new Padding(4, 0, 4, 0);
            lblTabelJudul.Name = "lblTabelJudul";
            lblTabelJudul.Size = new Size(761, 39);
            lblTabelJudul.TabIndex = 1;
            lblTabelJudul.Text = "Daftar Barang";
            lblTabelJudul.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlForm
            // 
            pnlForm.AccentColor = Color.Transparent;
            pnlForm.BackColor = Color.White;
            pnlForm.BorderColor = Color.FromArgb(214, 228, 245);
            pnlForm.Controls.Add(tlpForm);
            pnlForm.Controls.Add(lblFormJudul);
            pnlForm.Dock = DockStyle.Fill;
            pnlForm.Location = new Point(821, 0);
            pnlForm.Margin = new Padding(0);
            pnlForm.Name = "pnlForm";
            pnlForm.Padding = new Padding(23, 16, 23, 18);
            pnlForm.Radius = 18;
            pnlForm.Size = new Size(424, 570);
            pnlForm.TabIndex = 1;
            // 
            // tlpForm
            // 
            tlpForm.ColumnCount = 2;
            tlpForm.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpForm.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpForm.Controls.Add(lblKode, 0, 0);
            tlpForm.Controls.Add(txtKode, 0, 1);
            tlpForm.Controls.Add(lblNama, 0, 2);
            tlpForm.Controls.Add(txtNama, 0, 3);
            tlpForm.Controls.Add(lblKategori, 0, 4);
            tlpForm.Controls.Add(lblSatuan, 1, 4);
            tlpForm.Controls.Add(cmbKategori, 0, 5);
            tlpForm.Controls.Add(cmbSatuan, 1, 5);
            tlpForm.Controls.Add(lblStok, 0, 6);
            tlpForm.Controls.Add(lblMin, 1, 6);
            tlpForm.Controls.Add(nudStok, 0, 7);
            tlpForm.Controls.Add(nudMin, 1, 7);
            tlpForm.Controls.Add(lblBeli, 0, 8);
            tlpForm.Controls.Add(lblJual, 1, 8);
            tlpForm.Controls.Add(txtBeli, 0, 9);
            tlpForm.Controls.Add(txtJual, 1, 9);
            tlpForm.Controls.Add(lblMargin, 0, 10);
            tlpForm.Controls.Add(flowTombol, 0, 11);
            tlpForm.Dock = DockStyle.Fill;
            tlpForm.Location = new Point(23, 55);
            tlpForm.Margin = new Padding(0);
            tlpForm.Name = "tlpForm";
            tlpForm.RowCount = 12;
            tlpForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tlpForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 39F));
            tlpForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tlpForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 39F));
            tlpForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tlpForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 39F));
            tlpForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tlpForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 39F));
            tlpForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tlpForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 39F));
            tlpForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tlpForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 53F));
            tlpForm.Size = new Size(378, 497);
            tlpForm.TabIndex = 0;
            // 
            // lblKode
            // 
            lblKode.BackColor = Color.Transparent;
            tlpForm.SetColumnSpan(lblKode, 2);
            lblKode.Dock = DockStyle.Fill;
            lblKode.Font = new Font("Segoe UI", 9F);
            lblKode.ForeColor = Color.FromArgb(90, 110, 140);
            lblKode.Location = new Point(0, 0);
            lblKode.Margin = new Padding(0);
            lblKode.Name = "lblKode";
            lblKode.Size = new Size(378, 25);
            lblKode.TabIndex = 0;
            lblKode.Text = "Kode barang";
            lblKode.TextAlign = ContentAlignment.BottomLeft;
            // 
            // txtKode
            // 
            txtKode.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtKode.BackColor = Color.FromArgb(244, 247, 251);
            tlpForm.SetColumnSpan(txtKode, 2);
            txtKode.Font = new Font("Segoe UI", 10F);
            txtKode.Location = new Point(0, 25);
            txtKode.Margin = new Padding(0);
            txtKode.Name = "txtKode";
            txtKode.ReadOnly = true;
            txtKode.Size = new Size(378, 25);
            txtKode.TabIndex = 1;
            // 
            // lblNama
            // 
            lblNama.BackColor = Color.Transparent;
            tlpForm.SetColumnSpan(lblNama, 2);
            lblNama.Dock = DockStyle.Fill;
            lblNama.Font = new Font("Segoe UI", 9F);
            lblNama.ForeColor = Color.FromArgb(90, 110, 140);
            lblNama.Location = new Point(0, 64);
            lblNama.Margin = new Padding(0);
            lblNama.Name = "lblNama";
            lblNama.Size = new Size(378, 25);
            lblNama.TabIndex = 2;
            lblNama.Text = "Nama barang";
            lblNama.TextAlign = ContentAlignment.BottomLeft;
            // 
            // txtNama
            // 
            txtNama.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tlpForm.SetColumnSpan(txtNama, 2);
            txtNama.Font = new Font("Segoe UI", 10F);
            txtNama.Location = new Point(0, 89);
            txtNama.Margin = new Padding(0);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(378, 25);
            txtNama.TabIndex = 3;
            // 
            // lblKategori
            // 
            lblKategori.BackColor = Color.Transparent;
            lblKategori.Dock = DockStyle.Fill;
            lblKategori.Font = new Font("Segoe UI", 9F);
            lblKategori.ForeColor = Color.FromArgb(90, 110, 140);
            lblKategori.Location = new Point(0, 128);
            lblKategori.Margin = new Padding(0);
            lblKategori.Name = "lblKategori";
            lblKategori.Size = new Size(189, 25);
            lblKategori.TabIndex = 4;
            lblKategori.Text = "Kategori";
            lblKategori.TextAlign = ContentAlignment.BottomLeft;
            // 
            // lblSatuan
            // 
            lblSatuan.BackColor = Color.Transparent;
            lblSatuan.Dock = DockStyle.Fill;
            lblSatuan.Font = new Font("Segoe UI", 9F);
            lblSatuan.ForeColor = Color.FromArgb(90, 110, 140);
            lblSatuan.Location = new Point(189, 128);
            lblSatuan.Margin = new Padding(0);
            lblSatuan.Name = "lblSatuan";
            lblSatuan.Size = new Size(189, 25);
            lblSatuan.TabIndex = 5;
            lblSatuan.Text = "Satuan";
            lblSatuan.TextAlign = ContentAlignment.BottomLeft;
            // 
            // cmbKategori
            // 
            cmbKategori.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cmbKategori.Font = new Font("Segoe UI", 10F);
            cmbKategori.FormattingEnabled = true;
            cmbKategori.Location = new Point(0, 153);
            cmbKategori.Margin = new Padding(0, 0, 9, 0);
            cmbKategori.Name = "cmbKategori";
            cmbKategori.Size = new Size(180, 25);
            cmbKategori.TabIndex = 6;
            // 
            // cmbSatuan
            // 
            cmbSatuan.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cmbSatuan.Font = new Font("Segoe UI", 10F);
            cmbSatuan.FormattingEnabled = true;
            cmbSatuan.Items.AddRange(new object[] { "pcs", "sak", "kg", "liter", "box", "pak", "botol" });
            cmbSatuan.Location = new Point(189, 153);
            cmbSatuan.Margin = new Padding(0);
            cmbSatuan.Name = "cmbSatuan";
            cmbSatuan.Size = new Size(189, 25);
            cmbSatuan.TabIndex = 7;
            // 
            // lblStok
            // 
            lblStok.BackColor = Color.Transparent;
            lblStok.Dock = DockStyle.Fill;
            lblStok.Font = new Font("Segoe UI", 9F);
            lblStok.ForeColor = Color.FromArgb(90, 110, 140);
            lblStok.Location = new Point(0, 192);
            lblStok.Margin = new Padding(0);
            lblStok.Name = "lblStok";
            lblStok.Size = new Size(189, 25);
            lblStok.TabIndex = 8;
            lblStok.Text = "Stok";
            lblStok.TextAlign = ContentAlignment.BottomLeft;
            // 
            // lblMin
            // 
            lblMin.BackColor = Color.Transparent;
            lblMin.Dock = DockStyle.Fill;
            lblMin.Font = new Font("Segoe UI", 9F);
            lblMin.ForeColor = Color.FromArgb(90, 110, 140);
            lblMin.Location = new Point(189, 192);
            lblMin.Margin = new Padding(0);
            lblMin.Name = "lblMin";
            lblMin.Size = new Size(189, 25);
            lblMin.TabIndex = 9;
            lblMin.Text = "Stok minimum";
            lblMin.TextAlign = ContentAlignment.BottomLeft;
            // 
            // nudStok
            // 
            nudStok.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            nudStok.Font = new Font("Segoe UI", 10F);
            nudStok.Location = new Point(0, 217);
            nudStok.Margin = new Padding(0, 0, 9, 0);
            nudStok.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nudStok.Name = "nudStok";
            nudStok.Size = new Size(180, 25);
            nudStok.TabIndex = 10;
            // 
            // nudMin
            // 
            nudMin.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            nudMin.Font = new Font("Segoe UI", 10F);
            nudMin.Location = new Point(189, 217);
            nudMin.Margin = new Padding(0);
            nudMin.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nudMin.Name = "nudMin";
            nudMin.Size = new Size(189, 25);
            nudMin.TabIndex = 11;
            // 
            // lblBeli
            // 
            lblBeli.BackColor = Color.Transparent;
            lblBeli.Dock = DockStyle.Fill;
            lblBeli.Font = new Font("Segoe UI", 9F);
            lblBeli.ForeColor = Color.FromArgb(90, 110, 140);
            lblBeli.Location = new Point(0, 256);
            lblBeli.Margin = new Padding(0);
            lblBeli.Name = "lblBeli";
            lblBeli.Size = new Size(189, 25);
            lblBeli.TabIndex = 12;
            lblBeli.Text = "Harga beli (Rp)";
            lblBeli.TextAlign = ContentAlignment.BottomLeft;
            // 
            // lblJual
            // 
            lblJual.BackColor = Color.Transparent;
            lblJual.Dock = DockStyle.Fill;
            lblJual.Font = new Font("Segoe UI", 9F);
            lblJual.ForeColor = Color.FromArgb(90, 110, 140);
            lblJual.Location = new Point(189, 256);
            lblJual.Margin = new Padding(0);
            lblJual.Name = "lblJual";
            lblJual.Size = new Size(189, 25);
            lblJual.TabIndex = 13;
            lblJual.Text = "Harga jual (Rp)";
            lblJual.TextAlign = ContentAlignment.BottomLeft;
            // 
            // txtBeli
            // 
            txtBeli.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBeli.Font = new Font("Segoe UI", 10F);
            txtBeli.Location = new Point(0, 281);
            txtBeli.Margin = new Padding(0, 0, 9, 0);
            txtBeli.Name = "txtBeli";
            txtBeli.Size = new Size(180, 25);
            txtBeli.TabIndex = 14;
            txtBeli.TextAlign = HorizontalAlignment.Right;
            // 
            // txtJual
            // 
            txtJual.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtJual.Font = new Font("Segoe UI", 10F);
            txtJual.Location = new Point(189, 281);
            txtJual.Margin = new Padding(0);
            txtJual.Name = "txtJual";
            txtJual.Size = new Size(189, 25);
            txtJual.TabIndex = 15;
            txtJual.TextAlign = HorizontalAlignment.Right;
            // 
            // lblMargin
            // 
            lblMargin.BackColor = Color.Transparent;
            tlpForm.SetColumnSpan(lblMargin, 2);
            lblMargin.Dock = DockStyle.Fill;
            lblMargin.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblMargin.ForeColor = Color.FromArgb(30, 136, 229);
            lblMargin.Location = new Point(0, 320);
            lblMargin.Margin = new Padding(0);
            lblMargin.Name = "lblMargin";
            lblMargin.Size = new Size(378, 28);
            lblMargin.TabIndex = 16;
            lblMargin.Text = "Margin: -";
            lblMargin.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // flowTombol
            // 
            flowTombol.BackColor = Color.White;
            tlpForm.SetColumnSpan(flowTombol, 2);
            flowTombol.Controls.Add(btnSimpan);
            flowTombol.Controls.Add(btnReset);
            flowTombol.Controls.Add(btnHapus);
            flowTombol.Dock = DockStyle.Fill;
            flowTombol.Location = new Point(0, 348);
            flowTombol.Margin = new Padding(0);
            flowTombol.Name = "flowTombol";
            flowTombol.Padding = new Padding(0, 7, 0, 0);
            flowTombol.Size = new Size(378, 149);
            flowTombol.TabIndex = 17;
            flowTombol.WrapContents = false;
            // 
            // btnSimpan
            // 
            btnSimpan.BackColor = Color.FromArgb(30, 136, 229);
            btnSimpan.BorderColor = Color.Transparent;
            btnSimpan.FlatStyle = FlatStyle.Flat;
            btnSimpan.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            btnSimpan.ForeColor = Color.White;
            btnSimpan.HoverColor = Color.FromArgb(21, 101, 192);
            btnSimpan.Location = new Point(0, 7);
            btnSimpan.Margin = new Padding(0, 0, 9, 0);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(117, 44);
            btnSimpan.TabIndex = 0;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = false;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.White;
            btnReset.BorderColor = Color.FromArgb(30, 136, 229);
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            btnReset.ForeColor = Color.FromArgb(30, 136, 229);
            btnReset.HoverColor = Color.FromArgb(225, 240, 255);
            btnReset.Location = new Point(126, 7);
            btnReset.Margin = new Padding(0, 0, 9, 0);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(93, 44);
            btnReset.TabIndex = 1;
            btnReset.Text = "Baru";
            btnReset.UseVisualStyleBackColor = false;
            // 
            // btnHapus
            // 
            btnHapus.BackColor = Color.White;
            btnHapus.BorderColor = Color.FromArgb(214, 69, 65);
            btnHapus.FlatStyle = FlatStyle.Flat;
            btnHapus.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            btnHapus.ForeColor = Color.FromArgb(214, 69, 65);
            btnHapus.HoverColor = Color.FromArgb(253, 236, 235);
            btnHapus.Location = new Point(228, 7);
            btnHapus.Margin = new Padding(0);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(93, 44);
            btnHapus.TabIndex = 2;
            btnHapus.Text = "Hapus";
            btnHapus.UseVisualStyleBackColor = false;
            // 
            // lblFormJudul
            // 
            lblFormJudul.BackColor = Color.Transparent;
            lblFormJudul.Dock = DockStyle.Top;
            lblFormJudul.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblFormJudul.ForeColor = Color.FromArgb(13, 47, 110);
            lblFormJudul.Location = new Point(23, 16);
            lblFormJudul.Margin = new Padding(4, 0, 4, 0);
            lblFormJudul.Name = "lblFormJudul";
            lblFormJudul.Size = new Size(378, 39);
            lblFormJudul.TabIndex = 1;
            lblFormJudul.Text = "Tambah Barang";
            lblFormJudul.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // UC_Barang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(234, 243, 252);
            Controls.Add(tlpRoot);
            Margin = new Padding(4, 3, 4, 3);
            Name = "UC_Barang";
            Size = new Size(1283, 923);
            tlpRoot.ResumeLayout(false);
            pnlJudul.ResumeLayout(false);
            pnlJudul.PerformLayout();
            tlpContent.ResumeLayout(false);
            tlpStats.ResumeLayout(false);
            cardTotal.ResumeLayout(false);
            cardTotal.PerformLayout();
            cardAman.ResumeLayout(false);
            cardAman.PerformLayout();
            cardMenipis.ResumeLayout(false);
            cardMenipis.PerformLayout();
            cardHabis.ResumeLayout(false);
            cardHabis.PerformLayout();
            cardNilai.ResumeLayout(false);
            cardNilai.PerformLayout();
            pnlFilter.ResumeLayout(false);
            pnlFilter.PerformLayout();
            tlpMain.ResumeLayout(false);
            pnlTabel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvBarang).EndInit();
            pnlForm.ResumeLayout(false);
            tlpForm.ResumeLayout(false);
            tlpForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudStok).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudMin).EndInit();
            flowTombol.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpRoot;
        private RoundedPanelUI pnlJudul;
        private System.Windows.Forms.Label lblSub;
        private System.Windows.Forms.Label lblJudul;
        private System.Windows.Forms.TableLayoutPanel tlpContent;
        private System.Windows.Forms.TableLayoutPanel tlpStats;
        private RoundedPanelUI cardTotal;
        private System.Windows.Forms.Label lblTotalKet;
        private System.Windows.Forms.Label lblTotalNilai;
        private System.Windows.Forms.Label lblTotalJudul;
        private RoundedPanelUI cardAman;
        private System.Windows.Forms.Label lblAmanKet;
        private System.Windows.Forms.Label lblAmanNilai;
        private System.Windows.Forms.Label lblAmanJudul;
        private RoundedPanelUI cardMenipis;
        private System.Windows.Forms.Label lblMenipisKet;
        private System.Windows.Forms.Label lblMenipisNilai;
        private System.Windows.Forms.Label lblMenipisJudul;
        private RoundedPanelUI cardHabis;
        private System.Windows.Forms.Label lblHabisKet;
        private System.Windows.Forms.Label lblHabisNilai;
        private System.Windows.Forms.Label lblHabisJudul;
        private RoundedPanelUI cardNilai;
        private System.Windows.Forms.Label lblNilaiKet;
        private System.Windows.Forms.Label lblNilaiNilai;
        private System.Windows.Forms.Label lblNilaiJudul;
        private RoundedPanelUI pnlFilter;
        private System.Windows.Forms.TextBox txtCari;
        private RoundedButtonUI btnSemua;
        private RoundedButtonUI btnAman;
        private RoundedButtonUI btnMenipis;
        private RoundedButtonUI btnHabis;
        private System.Windows.Forms.ComboBox cmbKategoriFilter;
        private RoundedButtonUI btnExport;
        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private RoundedPanelUI pnlTabel;
        private System.Windows.Forms.DataGridView dgvBarang;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNama;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKategori;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBeli;
        private System.Windows.Forms.DataGridViewTextBoxColumn colJual;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStok;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMin;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.Label lblTabelJudul;
        private RoundedPanelUI pnlForm;
        private System.Windows.Forms.TableLayoutPanel tlpForm;
        private System.Windows.Forms.Label lblKode;
        private System.Windows.Forms.TextBox txtKode;
        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.Label lblKategori;
        private System.Windows.Forms.Label lblSatuan;
        private System.Windows.Forms.ComboBox cmbKategori;
        private System.Windows.Forms.ComboBox cmbSatuan;
        private System.Windows.Forms.Label lblStok;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.NumericUpDown nudStok;
        private System.Windows.Forms.NumericUpDown nudMin;
        private System.Windows.Forms.Label lblBeli;
        private System.Windows.Forms.Label lblJual;
        private System.Windows.Forms.TextBox txtBeli;
        private System.Windows.Forms.TextBox txtJual;
        private System.Windows.Forms.Label lblMargin;
        private System.Windows.Forms.FlowLayoutPanel flowTombol;
        private RoundedButtonUI btnSimpan;
        private RoundedButtonUI btnReset;
        private RoundedButtonUI btnHapus;
        private System.Windows.Forms.Label lblFormJudul;
    }
}