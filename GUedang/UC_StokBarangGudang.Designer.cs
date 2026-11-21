namespace GUedang
{
    partial class UC_StokBarangGudang
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
            pnlFilter = new RoundedPanelUI();
            lblRingkasan = new Label();
            txtCari = new TextBox();
            cmbKategori = new ComboBox();
            cmbStatus = new ComboBox();
            btnReset = new RoundedButtonUI();
            btnExport = new RoundedButtonUI();
            pnlTabel = new RoundedPanelUI();
            dgvStok = new DataGridView();
            colNo = new DataGridViewTextBoxColumn();
            colKode = new DataGridViewTextBoxColumn();
            colNama = new DataGridViewTextBoxColumn();
            colKategori = new DataGridViewTextBoxColumn();
            colStok = new DataGridViewTextBoxColumn();
            colMin = new DataGridViewTextBoxColumn();
            colNilai = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            lblTabelJudul = new Label();
            tlpKanan = new TableLayoutPanel();
            pnlDetail = new RoundedPanelUI();
            tlpDetail = new TableLayoutPanel();
            lblDetailNama = new Label();
            lblDetailStok = new Label();
            lblTerakhir = new Label();
            tlpMini = new TableLayoutPanel();
            pnlMiniMin = new RoundedPanelUI();
            lblMiniMinJudul = new Label();
            lblMiniMinNilai = new Label();
            pnlMiniStatus = new RoundedPanelUI();
            lblMiniStatusJudul = new Label();
            lblMiniStatusNilai = new Label();
            lblDetailJudul = new Label();
            pnlAdj = new RoundedPanelUI();
            tlpAdj = new TableLayoutPanel();
            lblFisik = new Label();
            lblSelisih = new Label();
            nudFisik = new NumericUpDown();
            txtSelisih = new TextBox();
            lblAlasan = new Label();
            txtAlasan = new TextBox();
            lblMinBaru = new Label();
            nudMinBaru = new NumericUpDown();
            btnSimpanMin = new RoundedButtonUI();
            btnSimpanAdj = new RoundedButtonUI();
            lblAdjJudul = new Label();
            tlpRoot.SuspendLayout();
            pnlJudul.SuspendLayout();
            tlpContent.SuspendLayout();
            pnlFilter.SuspendLayout();
            pnlTabel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStok).BeginInit();
            tlpKanan.SuspendLayout();
            pnlDetail.SuspendLayout();
            tlpDetail.SuspendLayout();
            tlpMini.SuspendLayout();
            pnlMiniMin.SuspendLayout();
            pnlMiniStatus.SuspendLayout();
            pnlAdj.SuspendLayout();
            tlpAdj.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudFisik).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudMinBaru).BeginInit();
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
            tlpRoot.Size = new Size(1283, 808);
            tlpRoot.TabIndex = 0;
            // 
            // pnlJudul
            // 
            pnlJudul.AccentColor = Color.Transparent;
            pnlJudul.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlJudul.BackColor = Color.White;
            pnlJudul.BorderColor = Color.FromArgb(214, 228, 245);
            pnlJudul.Controls.Add(lblSub);
            pnlJudul.Controls.Add(lblJudul);
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
            lblSub.Size = new Size(439, 17);
            lblSub.TabIndex = 0;
            lblSub.Text = "Pantau stok, ubah stok minimum, dan lakukan penyesuaian (stok opname).";
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
            lblJudul.Size = new Size(132, 30);
            lblJudul.TabIndex = 1;
            lblJudul.Text = "Stok Barang";
            // 
            // tlpContent
            // 
            tlpContent.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tlpContent.ColumnCount = 2;
            tlpContent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 66F));
            tlpContent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34F));
            tlpContent.Controls.Add(pnlFilter, 0, 0);
            tlpContent.Controls.Add(pnlTabel, 0, 1);
            tlpContent.Controls.Add(tlpKanan, 1, 1);
            tlpContent.Location = new Point(19, 113);
            tlpContent.Margin = new Padding(0);
            tlpContent.Name = "tlpContent";
            tlpContent.RowCount = 2;
            tlpContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 88F));
            tlpContent.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpContent.Size = new Size(1245, 677);
            tlpContent.TabIndex = 1;
            // 
            // pnlFilter
            // 
            pnlFilter.AccentColor = Color.Transparent;
            pnlFilter.BackColor = Color.White;
            pnlFilter.BorderColor = Color.FromArgb(214, 228, 245);
            tlpContent.SetColumnSpan(pnlFilter, 2);
            pnlFilter.Controls.Add(lblRingkasan);
            pnlFilter.Controls.Add(txtCari);
            pnlFilter.Controls.Add(cmbKategori);
            pnlFilter.Controls.Add(cmbStatus);
            pnlFilter.Controls.Add(btnReset);
            pnlFilter.Controls.Add(btnExport);
            pnlFilter.Dock = DockStyle.Fill;
            pnlFilter.Location = new Point(0, 0);
            pnlFilter.Margin = new Padding(0, 0, 0, 14);
            pnlFilter.Name = "pnlFilter";
            pnlFilter.Padding = new Padding(23, 0, 23, 0);
            pnlFilter.Radius = 18;
            pnlFilter.Size = new Size(1245, 74);
            pnlFilter.TabIndex = 0;
            // 
            // lblRingkasan
            // 
            lblRingkasan.BackColor = Color.Transparent;
            lblRingkasan.Dock = DockStyle.Right;
            lblRingkasan.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            lblRingkasan.ForeColor = Color.FromArgb(13, 47, 110);
            lblRingkasan.Location = new Point(1093, 0);
            lblRingkasan.Margin = new Padding(4, 0, 4, 0);
            lblRingkasan.Name = "lblRingkasan";
            lblRingkasan.Size = new Size(129, 74);
            lblRingkasan.TabIndex = 0;
            lblRingkasan.Text = "0 barang";
            lblRingkasan.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtCari
            // 
            txtCari.Font = new Font("Segoe UI", 10F);
            txtCari.Location = new Point(23, 21);
            txtCari.Margin = new Padding(0);
            txtCari.Name = "txtCari";
            txtCari.PlaceholderText = "Cari kode / nama barang...";
            txtCari.Size = new Size(279, 25);
            txtCari.TabIndex = 1;
            // 
            // cmbKategori
            // 
            cmbKategori.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbKategori.Font = new Font("Segoe UI", 10F);
            cmbKategori.FormattingEnabled = true;
            cmbKategori.Location = new Point(317, 21);
            cmbKategori.Margin = new Padding(0);
            cmbKategori.Name = "cmbKategori";
            cmbKategori.Size = new Size(174, 25);
            cmbKategori.TabIndex = 2;
            // 
            // cmbStatus
            // 
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.Font = new Font("Segoe UI", 10F);
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "Semua status", "Aman", "Menipis", "Habis" });
            cmbStatus.Location = new Point(506, 21);
            cmbStatus.Margin = new Padding(0);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(151, 25);
            cmbStatus.TabIndex = 3;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.RoyalBlue;
            btnReset.BorderColor = Color.FromArgb(30, 136, 229);
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            btnReset.ForeColor = Color.White;
            btnReset.HoverColor = Color.FromArgb(225, 240, 255);
            btnReset.Location = new Point(672, 14);
            btnReset.Margin = new Padding(4, 3, 4, 3);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(93, 42);
            btnReset.TabIndex = 4;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            // 
            // btnExport
            // 
            btnExport.BackColor = Color.RoyalBlue;
            btnExport.BorderColor = Color.FromArgb(30, 136, 229);
            btnExport.FlatStyle = FlatStyle.Flat;
            btnExport.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            btnExport.ForeColor = Color.White;
            btnExport.HoverColor = Color.FromArgb(225, 240, 255);
            btnExport.Location = new Point(775, 14);
            btnExport.Margin = new Padding(4, 3, 4, 3);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(128, 42);
            btnExport.TabIndex = 5;
            btnExport.Text = "Print";
            btnExport.UseVisualStyleBackColor = false;
            // 
            // pnlTabel
            // 
            pnlTabel.AccentColor = Color.Transparent;
            pnlTabel.BackColor = Color.White;
            pnlTabel.BorderColor = Color.FromArgb(214, 228, 245);
            pnlTabel.Controls.Add(dgvStok);
            pnlTabel.Controls.Add(lblTabelJudul);
            pnlTabel.Dock = DockStyle.Fill;
            pnlTabel.Location = new Point(0, 88);
            pnlTabel.Margin = new Padding(0, 0, 14, 0);
            pnlTabel.Name = "pnlTabel";
            pnlTabel.Padding = new Padding(23, 16, 23, 18);
            pnlTabel.Radius = 18;
            pnlTabel.Size = new Size(807, 589);
            pnlTabel.TabIndex = 1;
            // 
            // dgvStok
            // 
            dgvStok.Columns.AddRange(new DataGridViewColumn[] { colNo, colKode, colNama, colKategori, colStok, colMin, colNilai, colStatus });
            dgvStok.Dock = DockStyle.Fill;
            dgvStok.Location = new Point(23, 55);
            dgvStok.Margin = new Padding(0);
            dgvStok.Name = "dgvStok";
            dgvStok.Size = new Size(761, 516);
            dgvStok.TabIndex = 0;
            // 
            // colNo
            // 
            colNo.FillWeight = 6F;
            colNo.HeaderText = "No";
            colNo.Name = "colNo";
            // 
            // colKode
            // 
            colKode.FillWeight = 13F;
            colKode.HeaderText = "Kode";
            colKode.Name = "colKode";
            // 
            // colNama
            // 
            colNama.FillWeight = 26F;
            colNama.HeaderText = "Nama Barang";
            colNama.Name = "colNama";
            // 
            // colKategori
            // 
            colKategori.FillWeight = 14F;
            colKategori.HeaderText = "Kategori";
            colKategori.Name = "colKategori";
            // 
            // colStok
            // 
            colStok.FillWeight = 9F;
            colStok.HeaderText = "Stok";
            colStok.Name = "colStok";
            // 
            // colMin
            // 
            colMin.FillWeight = 10F;
            colMin.HeaderText = "Minimum";
            colMin.Name = "colMin";
            // 
            // colNilai
            // 
            colNilai.FillWeight = 12F;
            colNilai.HeaderText = "Nilai (Rp)";
            colNilai.Name = "colNilai";
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
            lblTabelJudul.Text = "Stok Barang";
            lblTabelJudul.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tlpKanan
            // 
            tlpKanan.ColumnCount = 1;
            tlpKanan.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpKanan.Controls.Add(pnlDetail, 0, 0);
            tlpKanan.Controls.Add(pnlAdj, 0, 1);
            tlpKanan.Dock = DockStyle.Fill;
            tlpKanan.Location = new Point(821, 88);
            tlpKanan.Margin = new Padding(0);
            tlpKanan.Name = "tlpKanan";
            tlpKanan.RowCount = 2;
            tlpKanan.RowStyles.Add(new RowStyle(SizeType.Absolute, 256F));
            tlpKanan.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpKanan.Size = new Size(424, 589);
            tlpKanan.TabIndex = 2;
            // 
            // pnlDetail
            // 
            pnlDetail.AccentColor = Color.Transparent;
            pnlDetail.BackColor = Color.White;
            pnlDetail.BorderColor = Color.FromArgb(214, 228, 245);
            pnlDetail.Controls.Add(tlpDetail);
            pnlDetail.Controls.Add(lblDetailJudul);
            pnlDetail.Dock = DockStyle.Fill;
            pnlDetail.Location = new Point(0, 0);
            pnlDetail.Margin = new Padding(0, 0, 0, 14);
            pnlDetail.Name = "pnlDetail";
            pnlDetail.Padding = new Padding(23, 16, 23, 18);
            pnlDetail.Radius = 18;
            pnlDetail.Size = new Size(424, 242);
            pnlDetail.TabIndex = 0;
            // 
            // tlpDetail
            // 
            tlpDetail.ColumnCount = 1;
            tlpDetail.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpDetail.Controls.Add(lblDetailNama, 0, 0);
            tlpDetail.Controls.Add(lblDetailStok, 0, 1);
            tlpDetail.Controls.Add(lblTerakhir, 0, 2);
            tlpDetail.Controls.Add(tlpMini, 0, 3);
            tlpDetail.Dock = DockStyle.Fill;
            tlpDetail.Location = new Point(23, 55);
            tlpDetail.Margin = new Padding(0);
            tlpDetail.Name = "tlpDetail";
            tlpDetail.RowCount = 4;
            tlpDetail.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tlpDetail.RowStyles.Add(new RowStyle(SizeType.Absolute, 53F));
            tlpDetail.RowStyles.Add(new RowStyle(SizeType.Absolute, 23F));
            tlpDetail.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpDetail.Size = new Size(378, 169);
            tlpDetail.TabIndex = 0;
            // 
            // lblDetailNama
            // 
            lblDetailNama.BackColor = Color.Transparent;
            lblDetailNama.Dock = DockStyle.Fill;
            lblDetailNama.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblDetailNama.ForeColor = Color.FromArgb(13, 47, 110);
            lblDetailNama.Location = new Point(0, 0);
            lblDetailNama.Margin = new Padding(0);
            lblDetailNama.Name = "lblDetailNama";
            lblDetailNama.Size = new Size(378, 28);
            lblDetailNama.TabIndex = 0;
            lblDetailNama.Text = "Pilih barang di tabel";
            lblDetailNama.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblDetailStok
            // 
            lblDetailStok.BackColor = Color.Transparent;
            lblDetailStok.Dock = DockStyle.Fill;
            lblDetailStok.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            lblDetailStok.ForeColor = Color.FromArgb(30, 136, 229);
            lblDetailStok.Location = new Point(0, 28);
            lblDetailStok.Margin = new Padding(0);
            lblDetailStok.Name = "lblDetailStok";
            lblDetailStok.Size = new Size(378, 53);
            lblDetailStok.TabIndex = 1;
            lblDetailStok.Text = "0 Item";
            lblDetailStok.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTerakhir
            // 
            lblTerakhir.BackColor = Color.Transparent;
            lblTerakhir.Dock = DockStyle.Fill;
            lblTerakhir.Font = new Font("Segoe UI", 8.5F);
            lblTerakhir.ForeColor = Color.FromArgb(90, 110, 140);
            lblTerakhir.Location = new Point(0, 81);
            lblTerakhir.Margin = new Padding(0);
            lblTerakhir.Name = "lblTerakhir";
            lblTerakhir.Size = new Size(378, 23);
            lblTerakhir.TabIndex = 2;
            lblTerakhir.Text = "-";
            lblTerakhir.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tlpMini
            // 
            tlpMini.ColumnCount = 2;
            tlpMini.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpMini.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpMini.Controls.Add(pnlMiniMin, 0, 0);
            tlpMini.Controls.Add(pnlMiniStatus, 1, 0);
            tlpMini.Dock = DockStyle.Fill;
            tlpMini.Location = new Point(0, 104);
            tlpMini.Margin = new Padding(0);
            tlpMini.Name = "tlpMini";
            tlpMini.RowCount = 1;
            tlpMini.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpMini.Size = new Size(378, 65);
            tlpMini.TabIndex = 3;
            // 
            // pnlMiniMin
            // 
            pnlMiniMin.AccentColor = Color.Transparent;
            pnlMiniMin.BackColor = Color.FromArgb(244, 247, 251);
            pnlMiniMin.BorderColor = Color.FromArgb(214, 228, 245);
            pnlMiniMin.Controls.Add(lblMiniMinJudul);
            pnlMiniMin.Controls.Add(lblMiniMinNilai);
            pnlMiniMin.Dock = DockStyle.Fill;
            pnlMiniMin.Location = new Point(0, 7);
            pnlMiniMin.Margin = new Padding(0, 7, 7, 0);
            pnlMiniMin.Name = "pnlMiniMin";
            pnlMiniMin.Radius = 12;
            pnlMiniMin.Size = new Size(182, 58);
            pnlMiniMin.TabIndex = 0;
            // 
            // lblMiniMinJudul
            // 
            lblMiniMinJudul.AutoSize = true;
            lblMiniMinJudul.BackColor = Color.Transparent;
            lblMiniMinJudul.Font = new Font("Segoe UI", 8.5F);
            lblMiniMinJudul.ForeColor = Color.FromArgb(90, 110, 140);
            lblMiniMinJudul.Location = new Point(14, 7);
            lblMiniMinJudul.Margin = new Padding(4, 0, 4, 0);
            lblMiniMinJudul.Name = "lblMiniMinJudul";
            lblMiniMinJudul.Size = new Size(86, 15);
            lblMiniMinJudul.TabIndex = 0;
            lblMiniMinJudul.Text = "Stok Minimum";
            // 
            // lblMiniMinNilai
            // 
            lblMiniMinNilai.AutoSize = true;
            lblMiniMinNilai.BackColor = Color.Transparent;
            lblMiniMinNilai.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblMiniMinNilai.ForeColor = Color.FromArgb(13, 47, 110);
            lblMiniMinNilai.Location = new Point(14, 30);
            lblMiniMinNilai.Margin = new Padding(4, 0, 4, 0);
            lblMiniMinNilai.Name = "lblMiniMinNilai";
            lblMiniMinNilai.Size = new Size(51, 20);
            lblMiniMinNilai.TabIndex = 1;
            lblMiniMinNilai.Text = "0 Item";
            // 
            // pnlMiniStatus
            // 
            pnlMiniStatus.AccentColor = Color.Transparent;
            pnlMiniStatus.BackColor = Color.FromArgb(244, 247, 251);
            pnlMiniStatus.BorderColor = Color.FromArgb(214, 228, 245);
            pnlMiniStatus.Controls.Add(lblMiniStatusJudul);
            pnlMiniStatus.Controls.Add(lblMiniStatusNilai);
            pnlMiniStatus.Dock = DockStyle.Fill;
            pnlMiniStatus.Location = new Point(196, 7);
            pnlMiniStatus.Margin = new Padding(7, 7, 0, 0);
            pnlMiniStatus.Name = "pnlMiniStatus";
            pnlMiniStatus.Radius = 12;
            pnlMiniStatus.Size = new Size(182, 58);
            pnlMiniStatus.TabIndex = 1;
            // 
            // lblMiniStatusJudul
            // 
            lblMiniStatusJudul.AutoSize = true;
            lblMiniStatusJudul.BackColor = Color.Transparent;
            lblMiniStatusJudul.Font = new Font("Segoe UI", 8.5F);
            lblMiniStatusJudul.ForeColor = Color.FromArgb(90, 110, 140);
            lblMiniStatusJudul.Location = new Point(14, 7);
            lblMiniStatusJudul.Margin = new Padding(4, 0, 4, 0);
            lblMiniStatusJudul.Name = "lblMiniStatusJudul";
            lblMiniStatusJudul.Size = new Size(39, 15);
            lblMiniStatusJudul.TabIndex = 0;
            lblMiniStatusJudul.Text = "Status";
            // 
            // lblMiniStatusNilai
            // 
            lblMiniStatusNilai.AutoSize = true;
            lblMiniStatusNilai.BackColor = Color.Transparent;
            lblMiniStatusNilai.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblMiniStatusNilai.ForeColor = Color.FromArgb(40, 140, 90);
            lblMiniStatusNilai.Location = new Point(14, 30);
            lblMiniStatusNilai.Margin = new Padding(4, 0, 4, 0);
            lblMiniStatusNilai.Name = "lblMiniStatusNilai";
            lblMiniStatusNilai.Size = new Size(15, 20);
            lblMiniStatusNilai.TabIndex = 1;
            lblMiniStatusNilai.Text = "-";
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
            lblDetailJudul.Size = new Size(378, 39);
            lblDetailJudul.TabIndex = 1;
            lblDetailJudul.Text = "Detail Persediaan";
            lblDetailJudul.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlAdj
            // 
            pnlAdj.AccentColor = Color.Transparent;
            pnlAdj.BackColor = Color.White;
            pnlAdj.BorderColor = Color.FromArgb(214, 228, 245);
            pnlAdj.Controls.Add(tlpAdj);
            pnlAdj.Controls.Add(lblAdjJudul);
            pnlAdj.Dock = DockStyle.Fill;
            pnlAdj.Location = new Point(0, 256);
            pnlAdj.Margin = new Padding(0);
            pnlAdj.Name = "pnlAdj";
            pnlAdj.Padding = new Padding(23, 16, 23, 18);
            pnlAdj.Radius = 18;
            pnlAdj.Size = new Size(424, 333);
            pnlAdj.TabIndex = 1;
            // 
            // tlpAdj
            // 
            tlpAdj.ColumnCount = 2;
            tlpAdj.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpAdj.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpAdj.Controls.Add(lblFisik, 0, 0);
            tlpAdj.Controls.Add(lblSelisih, 1, 0);
            tlpAdj.Controls.Add(nudFisik, 0, 1);
            tlpAdj.Controls.Add(txtSelisih, 1, 1);
            tlpAdj.Controls.Add(lblAlasan, 0, 2);
            tlpAdj.Controls.Add(txtAlasan, 0, 3);
            tlpAdj.Controls.Add(lblMinBaru, 0, 4);
            tlpAdj.Controls.Add(nudMinBaru, 0, 5);
            tlpAdj.Controls.Add(btnSimpanMin, 1, 5);
            tlpAdj.Controls.Add(btnSimpanAdj, 0, 6);
            tlpAdj.Dock = DockStyle.Fill;
            tlpAdj.Location = new Point(23, 55);
            tlpAdj.Margin = new Padding(0);
            tlpAdj.Name = "tlpAdj";
            tlpAdj.RowCount = 7;
            tlpAdj.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tlpAdj.RowStyles.Add(new RowStyle(SizeType.Absolute, 39F));
            tlpAdj.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tlpAdj.RowStyles.Add(new RowStyle(SizeType.Absolute, 39F));
            tlpAdj.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tlpAdj.RowStyles.Add(new RowStyle(SizeType.Absolute, 39F));
            tlpAdj.RowStyles.Add(new RowStyle(SizeType.Absolute, 58F));
            tlpAdj.Size = new Size(378, 260);
            tlpAdj.TabIndex = 0;
            // 
            // lblFisik
            // 
            lblFisik.BackColor = Color.Transparent;
            lblFisik.Dock = DockStyle.Fill;
            lblFisik.Font = new Font("Segoe UI", 9F);
            lblFisik.ForeColor = Color.FromArgb(90, 110, 140);
            lblFisik.Location = new Point(0, 0);
            lblFisik.Margin = new Padding(0);
            lblFisik.Name = "lblFisik";
            lblFisik.Size = new Size(189, 25);
            lblFisik.TabIndex = 0;
            lblFisik.Text = "Jumlah fisik (hasil hitung)";
            lblFisik.TextAlign = ContentAlignment.BottomLeft;
            // 
            // lblSelisih
            // 
            lblSelisih.BackColor = Color.Transparent;
            lblSelisih.Dock = DockStyle.Fill;
            lblSelisih.Font = new Font("Segoe UI", 9F);
            lblSelisih.ForeColor = Color.FromArgb(90, 110, 140);
            lblSelisih.Location = new Point(189, 0);
            lblSelisih.Margin = new Padding(0);
            lblSelisih.Name = "lblSelisih";
            lblSelisih.Size = new Size(189, 25);
            lblSelisih.TabIndex = 1;
            lblSelisih.Text = "Selisih stok";
            lblSelisih.TextAlign = ContentAlignment.BottomLeft;
            // 
            // nudFisik
            // 
            nudFisik.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            nudFisik.Font = new Font("Segoe UI", 10F);
            nudFisik.Location = new Point(0, 25);
            nudFisik.Margin = new Padding(0, 0, 9, 0);
            nudFisik.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nudFisik.Name = "nudFisik";
            nudFisik.Size = new Size(180, 25);
            nudFisik.TabIndex = 2;
            // 
            // txtSelisih
            // 
            txtSelisih.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSelisih.BackColor = Color.FromArgb(244, 247, 251);
            txtSelisih.Font = new Font("Segoe UI", 10F);
            txtSelisih.Location = new Point(189, 25);
            txtSelisih.Margin = new Padding(0);
            txtSelisih.Name = "txtSelisih";
            txtSelisih.ReadOnly = true;
            txtSelisih.Size = new Size(189, 25);
            txtSelisih.TabIndex = 3;
            txtSelisih.Text = "0";
            txtSelisih.TextAlign = HorizontalAlignment.Right;
            // 
            // lblAlasan
            // 
            lblAlasan.BackColor = Color.Transparent;
            tlpAdj.SetColumnSpan(lblAlasan, 2);
            lblAlasan.Dock = DockStyle.Fill;
            lblAlasan.Font = new Font("Segoe UI", 9F);
            lblAlasan.ForeColor = Color.FromArgb(90, 110, 140);
            lblAlasan.Location = new Point(0, 64);
            lblAlasan.Margin = new Padding(0);
            lblAlasan.Name = "lblAlasan";
            lblAlasan.Size = new Size(378, 25);
            lblAlasan.TabIndex = 4;
            lblAlasan.Text = "Alasan penyesuaian";
            lblAlasan.TextAlign = ContentAlignment.BottomLeft;
            // 
            // txtAlasan
            // 
            txtAlasan.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tlpAdj.SetColumnSpan(txtAlasan, 2);
            txtAlasan.Font = new Font("Segoe UI", 10F);
            txtAlasan.Location = new Point(0, 89);
            txtAlasan.Margin = new Padding(0);
            txtAlasan.Name = "txtAlasan";
            txtAlasan.PlaceholderText = "Contoh: barang rusak / salah hitung";
            txtAlasan.Size = new Size(378, 25);
            txtAlasan.TabIndex = 5;
            // 
            // lblMinBaru
            // 
            lblMinBaru.BackColor = Color.Transparent;
            tlpAdj.SetColumnSpan(lblMinBaru, 2);
            lblMinBaru.Dock = DockStyle.Fill;
            lblMinBaru.Font = new Font("Segoe UI", 9F);
            lblMinBaru.ForeColor = Color.FromArgb(90, 110, 140);
            lblMinBaru.Location = new Point(0, 128);
            lblMinBaru.Margin = new Padding(0);
            lblMinBaru.Name = "lblMinBaru";
            lblMinBaru.Size = new Size(378, 25);
            lblMinBaru.TabIndex = 6;
            lblMinBaru.Text = "Stok minimum";
            lblMinBaru.TextAlign = ContentAlignment.BottomLeft;
            // 
            // nudMinBaru
            // 
            nudMinBaru.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            nudMinBaru.Font = new Font("Segoe UI", 10F);
            nudMinBaru.Location = new Point(0, 153);
            nudMinBaru.Margin = new Padding(0, 0, 9, 0);
            nudMinBaru.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nudMinBaru.Name = "nudMinBaru";
            nudMinBaru.Size = new Size(180, 25);
            nudMinBaru.TabIndex = 7;
            // 
            // btnSimpanMin
            // 
            btnSimpanMin.BackColor = Color.White;
            btnSimpanMin.BorderColor = Color.FromArgb(30, 136, 229);
            btnSimpanMin.Dock = DockStyle.Fill;
            btnSimpanMin.FlatStyle = FlatStyle.Flat;
            btnSimpanMin.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            btnSimpanMin.ForeColor = Color.FromArgb(30, 136, 229);
            btnSimpanMin.HoverColor = Color.FromArgb(225, 240, 255);
            btnSimpanMin.Location = new Point(189, 153);
            btnSimpanMin.Margin = new Padding(0, 0, 0, 5);
            btnSimpanMin.Name = "btnSimpanMin";
            btnSimpanMin.Size = new Size(189, 34);
            btnSimpanMin.TabIndex = 8;
            btnSimpanMin.Text = "Ubah Minimum";
            btnSimpanMin.UseVisualStyleBackColor = false;
            // 
            // btnSimpanAdj
            // 
            btnSimpanAdj.BackColor = Color.FromArgb(30, 136, 229);
            btnSimpanAdj.BorderColor = Color.Transparent;
            tlpAdj.SetColumnSpan(btnSimpanAdj, 2);
            btnSimpanAdj.Dock = DockStyle.Fill;
            btnSimpanAdj.FlatStyle = FlatStyle.Flat;
            btnSimpanAdj.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            btnSimpanAdj.ForeColor = Color.White;
            btnSimpanAdj.HoverColor = Color.FromArgb(21, 101, 192);
            btnSimpanAdj.Location = new Point(0, 201);
            btnSimpanAdj.Margin = new Padding(0, 9, 0, 0);
            btnSimpanAdj.Name = "btnSimpanAdj";
            btnSimpanAdj.Size = new Size(378, 59);
            btnSimpanAdj.TabIndex = 9;
            btnSimpanAdj.Text = "Simpan Penyesuaian";
            btnSimpanAdj.UseVisualStyleBackColor = false;
            // 
            // lblAdjJudul
            // 
            lblAdjJudul.BackColor = Color.Transparent;
            lblAdjJudul.Dock = DockStyle.Top;
            lblAdjJudul.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblAdjJudul.ForeColor = Color.FromArgb(13, 47, 110);
            lblAdjJudul.Location = new Point(23, 16);
            lblAdjJudul.Margin = new Padding(4, 0, 4, 0);
            lblAdjJudul.Name = "lblAdjJudul";
            lblAdjJudul.Size = new Size(378, 39);
            lblAdjJudul.TabIndex = 1;
            lblAdjJudul.Text = "Penyesuaian Stok";
            lblAdjJudul.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // UC_StokBarangGudang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(234, 243, 252);
            Controls.Add(tlpRoot);
            Margin = new Padding(4, 3, 4, 3);
            Name = "UC_StokBarangGudang";
            Size = new Size(1283, 808);
            tlpRoot.ResumeLayout(false);
            pnlJudul.ResumeLayout(false);
            pnlJudul.PerformLayout();
            tlpContent.ResumeLayout(false);
            pnlFilter.ResumeLayout(false);
            pnlFilter.PerformLayout();
            pnlTabel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvStok).EndInit();
            tlpKanan.ResumeLayout(false);
            pnlDetail.ResumeLayout(false);
            tlpDetail.ResumeLayout(false);
            tlpMini.ResumeLayout(false);
            pnlMiniMin.ResumeLayout(false);
            pnlMiniMin.PerformLayout();
            pnlMiniStatus.ResumeLayout(false);
            pnlMiniStatus.PerformLayout();
            pnlAdj.ResumeLayout(false);
            tlpAdj.ResumeLayout(false);
            tlpAdj.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudFisik).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudMinBaru).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpRoot;
        private RoundedPanelUI pnlJudul;
        private System.Windows.Forms.Label lblSub;
        private System.Windows.Forms.Label lblJudul;
        private System.Windows.Forms.TableLayoutPanel tlpContent;
        private RoundedPanelUI pnlFilter;
        private System.Windows.Forms.Label lblRingkasan;
        private System.Windows.Forms.TextBox txtCari;
        private System.Windows.Forms.ComboBox cmbKategori;
        private System.Windows.Forms.ComboBox cmbStatus;
        private RoundedButtonUI btnReset;
        private RoundedButtonUI btnExport;
        private RoundedPanelUI pnlTabel;
        private System.Windows.Forms.DataGridView dgvStok;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNama;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKategori;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStok;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMin;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNilai;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.Label lblTabelJudul;
        private System.Windows.Forms.TableLayoutPanel tlpKanan;
        private RoundedPanelUI pnlDetail;
        private System.Windows.Forms.TableLayoutPanel tlpDetail;
        private System.Windows.Forms.Label lblDetailNama;
        private System.Windows.Forms.Label lblDetailStok;
        private System.Windows.Forms.Label lblTerakhir;
        private System.Windows.Forms.TableLayoutPanel tlpMini;
        private RoundedPanelUI pnlMiniMin;
        private System.Windows.Forms.Label lblMiniMinJudul;
        private System.Windows.Forms.Label lblMiniMinNilai;
        private RoundedPanelUI pnlMiniStatus;
        private System.Windows.Forms.Label lblMiniStatusJudul;
        private System.Windows.Forms.Label lblMiniStatusNilai;
        private System.Windows.Forms.Label lblDetailJudul;
        private RoundedPanelUI pnlAdj;
        private System.Windows.Forms.TableLayoutPanel tlpAdj;
        private System.Windows.Forms.Label lblFisik;
        private System.Windows.Forms.Label lblSelisih;
        private System.Windows.Forms.NumericUpDown nudFisik;
        private System.Windows.Forms.TextBox txtSelisih;
        private System.Windows.Forms.Label lblAlasan;
        private System.Windows.Forms.TextBox txtAlasan;
        private System.Windows.Forms.Label lblMinBaru;
        private System.Windows.Forms.NumericUpDown nudMinBaru;
        private RoundedButtonUI btnSimpanMin;
        private RoundedButtonUI btnSimpanAdj;
        private System.Windows.Forms.Label lblAdjJudul;
    }
}