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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            tlpRoot = new TableLayoutPanel();
            pnlJudul = new RoundedPanelUI();
            lblSub = new Label();
            lblJudul = new Label();
            tlpContent = new TableLayoutPanel();
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
            pnlAdj = new RoundedPanelUI();
            tlpAdj = new TableLayoutPanel();
            btnSimpanAdj = new RoundedButtonUI();
            btnSimpanMin = new RoundedButtonUI();
            lblMinBaru = new Label();
            nudMinBaru = new NumericUpDown();
            txtAlasan = new TextBox();
            nudFisik = new NumericUpDown();
            txtSelisih = new TextBox();
            lblAlasan = new Label();
            lblSelisih = new Label();
            lblFisik = new Label();
            lblAdjJudul = new Label();
            pnlDetail = new RoundedPanelUI();
            tlpDetail = new TableLayoutPanel();
            lblTerakhir = new Label();
            tlpMini = new TableLayoutPanel();
            pnlMiniStatus = new RoundedPanelUI();
            lblMiniStatusJudul = new Label();
            lblMiniStatusNilai = new Label();
            pnlMiniMin = new RoundedPanelUI();
            lblMiniMinJudul = new Label();
            lblMiniMinNilai = new Label();
            lblDetailStok = new Label();
            lblDetailJudul = new Label();
            lblDetailNama = new Label();
            pnlFilter = new RoundedPanelUI();
            lblRingkasan = new Label();
            txtCari = new TextBox();
            cmbKategori = new ComboBox();
            cmbStatus = new ComboBox();
            btnReset = new RoundedButtonUI();
            btnExport = new RoundedButtonUI();
            tlpRoot.SuspendLayout();
            pnlJudul.SuspendLayout();
            tlpContent.SuspendLayout();
            pnlTabel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStok).BeginInit();
            tlpKanan.SuspendLayout();
            pnlAdj.SuspendLayout();
            tlpAdj.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudMinBaru).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudFisik).BeginInit();
            pnlDetail.SuspendLayout();
            tlpDetail.SuspendLayout();
            tlpMini.SuspendLayout();
            pnlMiniStatus.SuspendLayout();
            pnlMiniMin.SuspendLayout();
            pnlFilter.SuspendLayout();
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
            tlpRoot.RowStyles.Add(new RowStyle(SizeType.Absolute, 59F));
            tlpRoot.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpRoot.Size = new Size(1283, 808);
            tlpRoot.TabIndex = 0;
            tlpRoot.Paint += tlpRoot_Paint;
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
            pnlJudul.Size = new Size(1245, 45);
            pnlJudul.TabIndex = 0;
            // 
            // lblSub
            // 
            lblSub.AutoSize = true;
            lblSub.BackColor = Color.Transparent;
            lblSub.Font = new Font("Segoe UI", 9.5F);
            lblSub.ForeColor = Color.FromArgb(90, 110, 140);
            lblSub.Location = new Point(26, 27);
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
            lblJudul.Location = new Point(26, 0);
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
            tlpContent.Controls.Add(pnlTabel, 0, 1);
            tlpContent.Controls.Add(tlpKanan, 1, 1);
            tlpContent.Controls.Add(pnlFilter, 0, 0);
            tlpContent.Location = new Point(19, 77);
            tlpContent.Margin = new Padding(0);
            tlpContent.Name = "tlpContent";
            tlpContent.RowCount = 2;
            tlpContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 66F));
            tlpContent.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpContent.Size = new Size(1245, 713);
            tlpContent.TabIndex = 1;
            // 
            // pnlTabel
            // 
            pnlTabel.AccentColor = Color.Transparent;
            pnlTabel.BackColor = Color.White;
            pnlTabel.BorderColor = Color.FromArgb(214, 228, 245);
            pnlTabel.Controls.Add(dgvStok);
            pnlTabel.Controls.Add(lblTabelJudul);
            pnlTabel.Dock = DockStyle.Fill;
            pnlTabel.Location = new Point(0, 66);
            pnlTabel.Margin = new Padding(0, 0, 14, 0);
            pnlTabel.Name = "pnlTabel";
            pnlTabel.Padding = new Padding(23, 16, 23, 18);
            pnlTabel.Radius = 18;
            pnlTabel.Size = new Size(807, 647);
            pnlTabel.TabIndex = 1;
            // 
            // dgvStok
            // 
            dgvStok.AllowUserToAddRows = false;
            dgvStok.AllowUserToDeleteRows = false;
            dgvStok.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStok.BackgroundColor = Color.White;
            dgvStok.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.RoyalBlue;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvStok.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvStok.ColumnHeadersHeight = 40;
            dgvStok.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvStok.Columns.AddRange(new DataGridViewColumn[] { colNo, colKode, colNama, colKategori, colStok, colMin, colNilai, colStatus });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.AliceBlue;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.RoyalBlue;
            dataGridViewCellStyle2.SelectionBackColor = Color.AliceBlue;
            dataGridViewCellStyle2.SelectionForeColor = Color.RoyalBlue;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvStok.DefaultCellStyle = dataGridViewCellStyle2;
            dgvStok.Dock = DockStyle.Fill;
            dgvStok.EnableHeadersVisualStyles = false;
            dgvStok.Location = new Point(23, 55);
            dgvStok.Margin = new Padding(0);
            dgvStok.MultiSelect = false;
            dgvStok.Name = "dgvStok";
            dgvStok.RowHeadersVisible = false;
            dgvStok.RowHeadersWidth = 62;
            dgvStok.Size = new Size(761, 574);
            dgvStok.TabIndex = 0;
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
            colKode.FillWeight = 13F;
            colKode.HeaderText = "Kode";
            colKode.MinimumWidth = 8;
            colKode.Name = "colKode";
            // 
            // colNama
            // 
            colNama.FillWeight = 26F;
            colNama.HeaderText = "Nama Barang";
            colNama.MinimumWidth = 8;
            colNama.Name = "colNama";
            // 
            // colKategori
            // 
            colKategori.FillWeight = 14F;
            colKategori.HeaderText = "Kategori";
            colKategori.MinimumWidth = 8;
            colKategori.Name = "colKategori";
            // 
            // colStok
            // 
            colStok.FillWeight = 9F;
            colStok.HeaderText = "Stok";
            colStok.MinimumWidth = 8;
            colStok.Name = "colStok";
            // 
            // colMin
            // 
            colMin.FillWeight = 10F;
            colMin.HeaderText = "Minimum";
            colMin.MinimumWidth = 8;
            colMin.Name = "colMin";
            // 
            // colNilai
            // 
            colNilai.FillWeight = 12F;
            colNilai.HeaderText = "Nilai (Rp)";
            colNilai.MinimumWidth = 8;
            colNilai.Name = "colNilai";
            // 
            // colStatus
            // 
            colStatus.FillWeight = 10F;
            colStatus.HeaderText = "Status";
            colStatus.MinimumWidth = 8;
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
            tlpKanan.Controls.Add(pnlAdj, 0, 1);
            tlpKanan.Controls.Add(pnlDetail, 0, 0);
            tlpKanan.Location = new Point(821, 66);
            tlpKanan.Margin = new Padding(0);
            tlpKanan.Name = "tlpKanan";
            tlpKanan.RowCount = 2;
            tlpKanan.RowStyles.Add(new RowStyle(SizeType.Absolute, 125F));
            tlpKanan.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpKanan.Size = new Size(424, 388);
            tlpKanan.TabIndex = 2;
            // 
            // pnlAdj
            // 
            pnlAdj.AccentColor = Color.Transparent;
            pnlAdj.BackColor = Color.White;
            pnlAdj.BorderColor = Color.FromArgb(214, 228, 245);
            pnlAdj.Controls.Add(tlpAdj);
            pnlAdj.Controls.Add(lblAdjJudul);
            pnlAdj.Location = new Point(0, 125);
            pnlAdj.Margin = new Padding(0);
            pnlAdj.Name = "pnlAdj";
            pnlAdj.Padding = new Padding(23, 16, 23, 18);
            pnlAdj.Radius = 18;
            pnlAdj.Size = new Size(424, 205);
            pnlAdj.TabIndex = 1;
            // 
            // tlpAdj
            // 
            tlpAdj.ColumnCount = 2;
            tlpAdj.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 48.05195F));
            tlpAdj.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 51.94805F));
            tlpAdj.Controls.Add(btnSimpanAdj, 1, 6);
            tlpAdj.Controls.Add(btnSimpanMin, 1, 5);
            tlpAdj.Controls.Add(lblMinBaru, 0, 4);
            tlpAdj.Controls.Add(nudMinBaru, 0, 5);
            tlpAdj.Controls.Add(txtAlasan, 0, 3);
            tlpAdj.Controls.Add(nudFisik, 0, 1);
            tlpAdj.Controls.Add(txtSelisih, 1, 1);
            tlpAdj.Controls.Add(lblAlasan, 0, 2);
            tlpAdj.Controls.Add(lblSelisih, 1, 0);
            tlpAdj.Controls.Add(lblFisik, 0, 0);
            tlpAdj.Location = new Point(23, 22);
            tlpAdj.Margin = new Padding(0);
            tlpAdj.Name = "tlpAdj";
            tlpAdj.RowCount = 7;
            tlpAdj.RowStyles.Add(new RowStyle(SizeType.Absolute, 17F));
            tlpAdj.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tlpAdj.RowStyles.Add(new RowStyle(SizeType.Absolute, 16F));
            tlpAdj.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tlpAdj.RowStyles.Add(new RowStyle(SizeType.Absolute, 18F));
            tlpAdj.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tlpAdj.RowStyles.Add(new RowStyle(SizeType.Absolute, 5F));
            tlpAdj.RowStyles.Add(new RowStyle(SizeType.Absolute, 160F));
            tlpAdj.Size = new Size(377, 190);
            tlpAdj.TabIndex = 0;
            // 
            // btnSimpanAdj
            // 
            btnSimpanAdj.BackColor = Color.FromArgb(30, 136, 229);
            btnSimpanAdj.BorderColor = Color.Transparent;
            tlpAdj.SetColumnSpan(btnSimpanAdj, 2);
            btnSimpanAdj.FlatStyle = FlatStyle.Flat;
            btnSimpanAdj.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            btnSimpanAdj.ForeColor = Color.White;
            btnSimpanAdj.HoverColor = Color.FromArgb(21, 101, 192);
            btnSimpanAdj.Location = new Point(0, 146);
            btnSimpanAdj.Margin = new Padding(0, 9, 0, 0);
            btnSimpanAdj.Name = "btnSimpanAdj";
            btnSimpanAdj.Size = new Size(375, 29);
            btnSimpanAdj.TabIndex = 9;
            btnSimpanAdj.Text = "Simpan Penyesuaian";
            btnSimpanAdj.TextAlign = ContentAlignment.TopCenter;
            btnSimpanAdj.UseVisualStyleBackColor = false;
            // 
            // btnSimpanMin
            // 
            btnSimpanMin.BackColor = Color.White;
            btnSimpanMin.BorderColor = Color.FromArgb(30, 136, 229);
            btnSimpanMin.FlatStyle = FlatStyle.Flat;
            btnSimpanMin.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            btnSimpanMin.ForeColor = Color.FromArgb(30, 136, 229);
            btnSimpanMin.HoverColor = Color.FromArgb(225, 240, 255);
            btnSimpanMin.Location = new Point(181, 105);
            btnSimpanMin.Margin = new Padding(0, 0, 0, 5);
            btnSimpanMin.Name = "btnSimpanMin";
            btnSimpanMin.Size = new Size(185, 22);
            btnSimpanMin.TabIndex = 8;
            btnSimpanMin.Text = "Ubah Minimum";
            btnSimpanMin.UseVisualStyleBackColor = false;
            // 
            // lblMinBaru
            // 
            lblMinBaru.BackColor = Color.Transparent;
            tlpAdj.SetColumnSpan(lblMinBaru, 2);
            lblMinBaru.Font = new Font("Segoe UI", 9F);
            lblMinBaru.ForeColor = Color.FromArgb(90, 110, 140);
            lblMinBaru.Location = new Point(0, 87);
            lblMinBaru.Margin = new Padding(0);
            lblMinBaru.Name = "lblMinBaru";
            lblMinBaru.Size = new Size(198, 15);
            lblMinBaru.TabIndex = 6;
            lblMinBaru.Text = "Stok minimum";
            lblMinBaru.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // nudMinBaru
            // 
            nudMinBaru.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            nudMinBaru.Font = new Font("Segoe UI", 10F);
            nudMinBaru.Location = new Point(0, 105);
            nudMinBaru.Margin = new Padding(0, 0, 9, 0);
            nudMinBaru.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nudMinBaru.Name = "nudMinBaru";
            nudMinBaru.Size = new Size(172, 25);
            nudMinBaru.TabIndex = 7;
            nudMinBaru.ValueChanged += nudMinBaru_ValueChanged;
            // 
            // txtAlasan
            // 
            txtAlasan.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tlpAdj.SetColumnSpan(txtAlasan, 2);
            txtAlasan.Font = new Font("Segoe UI", 10F);
            txtAlasan.Location = new Point(0, 59);
            txtAlasan.Margin = new Padding(0);
            txtAlasan.Name = "txtAlasan";
            txtAlasan.PlaceholderText = "Contoh: barang rusak / salah hitung";
            txtAlasan.Size = new Size(377, 25);
            txtAlasan.TabIndex = 5;
            // 
            // nudFisik
            // 
            nudFisik.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            nudFisik.Font = new Font("Segoe UI", 10F);
            nudFisik.Location = new Point(0, 17);
            nudFisik.Margin = new Padding(0, 0, 9, 0);
            nudFisik.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nudFisik.Name = "nudFisik";
            nudFisik.Size = new Size(172, 25);
            nudFisik.TabIndex = 2;
            // 
            // txtSelisih
            // 
            txtSelisih.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSelisih.BackColor = Color.FromArgb(244, 247, 251);
            txtSelisih.Font = new Font("Segoe UI", 10F);
            txtSelisih.Location = new Point(181, 17);
            txtSelisih.Margin = new Padding(0);
            txtSelisih.Name = "txtSelisih";
            txtSelisih.ReadOnly = true;
            txtSelisih.Size = new Size(196, 25);
            txtSelisih.TabIndex = 3;
            txtSelisih.Text = "0";
            txtSelisih.TextAlign = HorizontalAlignment.Right;
            // 
            // lblAlasan
            // 
            lblAlasan.BackColor = Color.Transparent;
            tlpAdj.SetColumnSpan(lblAlasan, 2);
            lblAlasan.Font = new Font("Segoe UI", 9F);
            lblAlasan.ForeColor = Color.FromArgb(90, 110, 140);
            lblAlasan.Location = new Point(0, 43);
            lblAlasan.Margin = new Padding(0);
            lblAlasan.Name = "lblAlasan";
            lblAlasan.Size = new Size(288, 16);
            lblAlasan.TabIndex = 4;
            lblAlasan.Text = "Alasan penyesuaian";
            // 
            // lblSelisih
            // 
            lblSelisih.BackColor = Color.Transparent;
            lblSelisih.Font = new Font("Segoe UI", 9F);
            lblSelisih.ForeColor = Color.FromArgb(90, 110, 140);
            lblSelisih.Location = new Point(181, 0);
            lblSelisih.Margin = new Padding(0);
            lblSelisih.Name = "lblSelisih";
            lblSelisih.Size = new Size(141, 17);
            lblSelisih.TabIndex = 1;
            lblSelisih.Text = "Selisih stok";
            // 
            // lblFisik
            // 
            lblFisik.BackColor = Color.Transparent;
            lblFisik.Font = new Font("Segoe UI", 9F);
            lblFisik.ForeColor = Color.FromArgb(90, 110, 140);
            lblFisik.Location = new Point(0, 0);
            lblFisik.Margin = new Padding(0);
            lblFisik.Name = "lblFisik";
            lblFisik.Size = new Size(181, 17);
            lblFisik.TabIndex = 0;
            lblFisik.Text = "Jumlah fisik (hasil hitung)";
            // 
            // lblAdjJudul
            // 
            lblAdjJudul.BackColor = Color.Transparent;
            lblAdjJudul.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblAdjJudul.ForeColor = Color.FromArgb(13, 47, 110);
            lblAdjJudul.Location = new Point(21, 7);
            lblAdjJudul.Margin = new Padding(4, 0, 4, 0);
            lblAdjJudul.Name = "lblAdjJudul";
            lblAdjJudul.Size = new Size(377, 16);
            lblAdjJudul.TabIndex = 1;
            lblAdjJudul.Text = "Penyesuaian Stok";
            lblAdjJudul.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlDetail
            // 
            pnlDetail.AccentColor = Color.Transparent;
            pnlDetail.BackColor = Color.White;
            pnlDetail.BorderColor = Color.FromArgb(214, 228, 245);
            pnlDetail.Controls.Add(tlpDetail);
            pnlDetail.Controls.Add(lblDetailStok);
            pnlDetail.Controls.Add(lblDetailJudul);
            pnlDetail.Controls.Add(lblDetailNama);
            pnlDetail.Location = new Point(0, 0);
            pnlDetail.Margin = new Padding(0, 0, 0, 14);
            pnlDetail.Name = "pnlDetail";
            pnlDetail.Padding = new Padding(23, 16, 23, 18);
            pnlDetail.Radius = 18;
            pnlDetail.Size = new Size(424, 111);
            pnlDetail.TabIndex = 0;
            // 
            // tlpDetail
            // 
            tlpDetail.Anchor = AnchorStyles.None;
            tlpDetail.ColumnCount = 1;
            tlpDetail.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpDetail.Controls.Add(lblTerakhir, 0, 2);
            tlpDetail.Controls.Add(tlpMini, 0, 1);
            tlpDetail.Location = new Point(21, 38);
            tlpDetail.Margin = new Padding(0);
            tlpDetail.Name = "tlpDetail";
            tlpDetail.RowCount = 4;
            tlpDetail.RowStyles.Add(new RowStyle(SizeType.Absolute, 5F));
            tlpDetail.RowStyles.Add(new RowStyle(SizeType.Absolute, 76F));
            tlpDetail.RowStyles.Add(new RowStyle(SizeType.Absolute, 5F));
            tlpDetail.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpDetail.Size = new Size(389, 62);
            tlpDetail.TabIndex = 0;
            // 
            // lblTerakhir
            // 
            lblTerakhir.BackColor = Color.Transparent;
            lblTerakhir.Font = new Font("Segoe UI", 8.5F);
            lblTerakhir.ForeColor = Color.FromArgb(90, 110, 140);
            lblTerakhir.Location = new Point(0, 81);
            lblTerakhir.Margin = new Padding(0);
            lblTerakhir.Name = "lblTerakhir";
            lblTerakhir.Size = new Size(378, 5);
            lblTerakhir.TabIndex = 2;
            lblTerakhir.Text = "-";
            lblTerakhir.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tlpMini
            // 
            tlpMini.ColumnCount = 2;
            tlpMini.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpMini.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpMini.Controls.Add(pnlMiniStatus, 1, 0);
            tlpMini.Controls.Add(pnlMiniMin, 0, 0);
            tlpMini.Location = new Point(0, 5);
            tlpMini.Margin = new Padding(0);
            tlpMini.Name = "tlpMini";
            tlpMini.RowCount = 1;
            tlpMini.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpMini.Size = new Size(377, 57);
            tlpMini.TabIndex = 3;
            // 
            // pnlMiniStatus
            // 
            pnlMiniStatus.AccentColor = Color.Transparent;
            pnlMiniStatus.BackColor = Color.FromArgb(244, 247, 251);
            pnlMiniStatus.BorderColor = Color.FromArgb(214, 228, 245);
            pnlMiniStatus.Controls.Add(lblMiniStatusJudul);
            pnlMiniStatus.Controls.Add(lblMiniStatusNilai);
            pnlMiniStatus.Dock = DockStyle.Fill;
            pnlMiniStatus.Location = new Point(195, 7);
            pnlMiniStatus.Margin = new Padding(7, 7, 0, 0);
            pnlMiniStatus.Name = "pnlMiniStatus";
            pnlMiniStatus.Radius = 12;
            pnlMiniStatus.Size = new Size(182, 50);
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
            lblMiniStatusNilai.Location = new Point(14, 21);
            lblMiniStatusNilai.Margin = new Padding(4, 0, 4, 0);
            lblMiniStatusNilai.Name = "lblMiniStatusNilai";
            lblMiniStatusNilai.Size = new Size(15, 20);
            lblMiniStatusNilai.TabIndex = 1;
            lblMiniStatusNilai.Text = "-";
            // 
            // pnlMiniMin
            // 
            pnlMiniMin.AccentColor = Color.Transparent;
            pnlMiniMin.BackColor = Color.FromArgb(244, 247, 251);
            pnlMiniMin.BorderColor = Color.FromArgb(214, 228, 245);
            pnlMiniMin.Controls.Add(lblMiniMinJudul);
            pnlMiniMin.Controls.Add(lblMiniMinNilai);
            pnlMiniMin.Location = new Point(0, 7);
            pnlMiniMin.Margin = new Padding(0, 7, 7, 0);
            pnlMiniMin.Name = "pnlMiniMin";
            pnlMiniMin.Radius = 12;
            pnlMiniMin.Size = new Size(181, 50);
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
            lblMiniMinNilai.Location = new Point(14, 21);
            lblMiniMinNilai.Margin = new Padding(4, 0, 4, 0);
            lblMiniMinNilai.Name = "lblMiniMinNilai";
            lblMiniMinNilai.Size = new Size(51, 20);
            lblMiniMinNilai.TabIndex = 1;
            lblMiniMinNilai.Text = "0 Item";
            // 
            // lblDetailStok
            // 
            lblDetailStok.BackColor = Color.Transparent;
            lblDetailStok.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDetailStok.ForeColor = Color.FromArgb(30, 136, 229);
            lblDetailStok.Location = new Point(244, 22);
            lblDetailStok.Margin = new Padding(0);
            lblDetailStok.Name = "lblDetailStok";
            lblDetailStok.Size = new Size(80, 19);
            lblDetailStok.TabIndex = 1;
            lblDetailStok.Text = "0 Item";
            lblDetailStok.TextAlign = ContentAlignment.MiddleLeft;
            lblDetailStok.Click += lblDetailStok_Click;
            // 
            // lblDetailJudul
            // 
            lblDetailJudul.BackColor = Color.Transparent;
            lblDetailJudul.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblDetailJudul.ForeColor = Color.FromArgb(13, 47, 110);
            lblDetailJudul.Location = new Point(21, 0);
            lblDetailJudul.Margin = new Padding(4, 0, 4, 0);
            lblDetailJudul.Name = "lblDetailJudul";
            lblDetailJudul.Size = new Size(377, 23);
            lblDetailJudul.TabIndex = 1;
            lblDetailJudul.Text = "Detail Persediaan";
            lblDetailJudul.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblDetailNama
            // 
            lblDetailNama.BackColor = Color.Transparent;
            lblDetailNama.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblDetailNama.ForeColor = Color.FromArgb(13, 47, 110);
            lblDetailNama.Location = new Point(23, 23);
            lblDetailNama.Margin = new Padding(0);
            lblDetailNama.Name = "lblDetailNama";
            lblDetailNama.Size = new Size(378, 19);
            lblDetailNama.TabIndex = 0;
            lblDetailNama.Text = "Pilih barang di tabel";
            lblDetailNama.TextAlign = ContentAlignment.MiddleLeft;
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
            pnlFilter.Location = new Point(0, 0);
            pnlFilter.Margin = new Padding(0, 0, 0, 14);
            pnlFilter.Name = "pnlFilter";
            pnlFilter.Padding = new Padding(23, 0, 23, 0);
            pnlFilter.Radius = 18;
            pnlFilter.Size = new Size(1245, 52);
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
            lblRingkasan.Size = new Size(129, 52);
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
            btnReset.Size = new Size(93, 29);
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
            btnExport.Size = new Size(128, 29);
            btnExport.TabIndex = 5;
            btnExport.Text = "Print";
            btnExport.UseVisualStyleBackColor = false;
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
            pnlTabel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvStok).EndInit();
            tlpKanan.ResumeLayout(false);
            pnlAdj.ResumeLayout(false);
            tlpAdj.ResumeLayout(false);
            tlpAdj.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudMinBaru).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudFisik).EndInit();
            pnlDetail.ResumeLayout(false);
            tlpDetail.ResumeLayout(false);
            tlpMini.ResumeLayout(false);
            pnlMiniStatus.ResumeLayout(false);
            pnlMiniStatus.PerformLayout();
            pnlMiniMin.ResumeLayout(false);
            pnlMiniMin.PerformLayout();
            pnlFilter.ResumeLayout(false);
            pnlFilter.PerformLayout();
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
        private Label lblTerakhir;
    }
}