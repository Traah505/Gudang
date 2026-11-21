namespace GUedang
{
    partial class UC_RiwayatGudang
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
            cardMasuk = new RoundedPanelUI();
            lblMasukKet = new Label();
            lblMasukNilai = new Label();
            lblMasukJudul = new Label();
            cardKeluar = new RoundedPanelUI();
            lblKeluarKet = new Label();
            lblKeluarNilai = new Label();
            lblKeluarJudul = new Label();
            cardStok = new RoundedPanelUI();
            lblStokKet = new Label();
            lblStokNilai = new Label();
            lblStokJudul = new Label();
            cardOpname = new RoundedPanelUI();
            lblOpnameKet = new Label();
            lblOpnameNilai = new Label();
            lblOpnameJudul = new Label();
            pnlFilter = new RoundedPanelUI();
            cmbRentang = new ComboBox();
            lblDari = new Label();
            dtpDari = new DateTimePicker();
            lblSampai = new Label();
            dtpSampai = new DateTimePicker();
            cmbJenis = new ComboBox();
            txtCari = new TextBox();
            btnExport = new RoundedButtonUI();
            pnlTabel = new RoundedPanelUI();
            dgvRiwayat = new DataGridView();
            colNo = new DataGridViewTextBoxColumn();
            colWaktu = new DataGridViewTextBoxColumn();
            colJenis = new DataGridViewTextBoxColumn();
            colNama = new DataGridViewTextBoxColumn();
            colJumlah = new DataGridViewTextBoxColumn();
            colStokAkhir = new DataGridViewTextBoxColumn();
            colPihak = new DataGridViewTextBoxColumn();
            colKeterangan = new DataGridViewTextBoxColumn();
            lblTabelJudul = new Label();
            tlpRoot.SuspendLayout();
            pnlJudul.SuspendLayout();
            tlpContent.SuspendLayout();
            tlpStats.SuspendLayout();
            cardMasuk.SuspendLayout();
            cardKeluar.SuspendLayout();
            cardStok.SuspendLayout();
            cardOpname.SuspendLayout();
            pnlFilter.SuspendLayout();
            pnlTabel.SuspendLayout();
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
            lblSub.Size = new Size(386, 17);
            lblSub.TabIndex = 0;
            lblSub.Text = "Semua pergerakan stok: barang masuk, keluar, dan penyesuaian.";
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
            lblJudul.Size = new Size(175, 30);
            lblJudul.TabIndex = 1;
            lblJudul.Text = "Riwayat Gudang";
            // 
            // tlpContent
            // 
            tlpContent.ColumnCount = 1;
            tlpContent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpContent.Controls.Add(tlpStats, 0, 0);
            tlpContent.Controls.Add(pnlFilter, 0, 1);
            tlpContent.Controls.Add(pnlTabel, 0, 2);
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
            tlpStats.Controls.Add(cardMasuk, 0, 0);
            tlpStats.Controls.Add(cardKeluar, 1, 0);
            tlpStats.Controls.Add(cardStok, 2, 0);
            tlpStats.Controls.Add(cardOpname, 3, 0);
            tlpStats.Dock = DockStyle.Fill;
            tlpStats.Location = new Point(0, 0);
            tlpStats.Margin = new Padding(0, 0, 0, 14);
            tlpStats.Name = "tlpStats";
            tlpStats.RowCount = 1;
            tlpStats.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpStats.Size = new Size(1245, 120);
            tlpStats.TabIndex = 0;
            // 
            // cardMasuk
            // 
            cardMasuk.AccentColor = Color.FromArgb(30, 136, 229);
            cardMasuk.BackColor = Color.White;
            cardMasuk.BorderColor = Color.FromArgb(214, 228, 245);
            cardMasuk.Controls.Add(lblMasukKet);
            cardMasuk.Controls.Add(lblMasukNilai);
            cardMasuk.Controls.Add(lblMasukJudul);
            cardMasuk.Dock = DockStyle.Fill;
            cardMasuk.Location = new Point(0, 0);
            cardMasuk.Margin = new Padding(0, 0, 14, 0);
            cardMasuk.Name = "cardMasuk";
            cardMasuk.Radius = 18;
            cardMasuk.Size = new Size(297, 120);
            cardMasuk.TabIndex = 0;
            // 
            // lblMasukKet
            // 
            lblMasukKet.AutoSize = true;
            lblMasukKet.BackColor = Color.Transparent;
            lblMasukKet.Font = new Font("Segoe UI", 8.5F);
            lblMasukKet.ForeColor = Color.FromArgb(120, 135, 160);
            lblMasukKet.Location = new Point(35, 78);
            lblMasukKet.Margin = new Padding(4, 0, 4, 0);
            lblMasukKet.Name = "lblMasukKet";
            lblMasukKet.Size = new Size(101, 15);
            lblMasukKet.TabIndex = 0;
            lblMasukKet.Text = "Unit pada periode";
            // 
            // lblMasukNilai
            // 
            lblMasukNilai.AutoSize = true;
            lblMasukNilai.BackColor = Color.Transparent;
            lblMasukNilai.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            lblMasukNilai.ForeColor = Color.FromArgb(24, 94, 224);
            lblMasukNilai.Location = new Point(33, 37);
            lblMasukNilai.Margin = new Padding(4, 0, 4, 0);
            lblMasukNilai.Name = "lblMasukNilai";
            lblMasukNilai.Size = new Size(27, 32);
            lblMasukNilai.TabIndex = 1;
            lblMasukNilai.Text = "0";
            // 
            // lblMasukJudul
            // 
            lblMasukJudul.AutoSize = true;
            lblMasukJudul.BackColor = Color.Transparent;
            lblMasukJudul.Font = new Font("Segoe UI", 9.5F);
            lblMasukJudul.ForeColor = Color.FromArgb(90, 110, 140);
            lblMasukJudul.Location = new Point(35, 16);
            lblMasukJudul.Margin = new Padding(4, 0, 4, 0);
            lblMasukJudul.Name = "lblMasukJudul";
            lblMasukJudul.Size = new Size(123, 17);
            lblMasukJudul.TabIndex = 2;
            lblMasukJudul.Text = "Total Barang Masuk";
            // 
            // cardKeluar
            // 
            cardKeluar.AccentColor = Color.FromArgb(46, 160, 100);
            cardKeluar.BackColor = Color.White;
            cardKeluar.BorderColor = Color.FromArgb(214, 228, 245);
            cardKeluar.Controls.Add(lblKeluarKet);
            cardKeluar.Controls.Add(lblKeluarNilai);
            cardKeluar.Controls.Add(lblKeluarJudul);
            cardKeluar.Dock = DockStyle.Fill;
            cardKeluar.Location = new Point(311, 0);
            cardKeluar.Margin = new Padding(0, 0, 14, 0);
            cardKeluar.Name = "cardKeluar";
            cardKeluar.Radius = 18;
            cardKeluar.Size = new Size(297, 120);
            cardKeluar.TabIndex = 1;
            // 
            // lblKeluarKet
            // 
            lblKeluarKet.AutoSize = true;
            lblKeluarKet.BackColor = Color.Transparent;
            lblKeluarKet.Font = new Font("Segoe UI", 8.5F);
            lblKeluarKet.ForeColor = Color.FromArgb(120, 135, 160);
            lblKeluarKet.Location = new Point(35, 78);
            lblKeluarKet.Margin = new Padding(4, 0, 4, 0);
            lblKeluarKet.Name = "lblKeluarKet";
            lblKeluarKet.Size = new Size(101, 15);
            lblKeluarKet.TabIndex = 0;
            lblKeluarKet.Text = "Unit pada periode";
            // 
            // lblKeluarNilai
            // 
            lblKeluarNilai.AutoSize = true;
            lblKeluarNilai.BackColor = Color.Transparent;
            lblKeluarNilai.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            lblKeluarNilai.ForeColor = Color.FromArgb(40, 140, 90);
            lblKeluarNilai.Location = new Point(33, 37);
            lblKeluarNilai.Margin = new Padding(4, 0, 4, 0);
            lblKeluarNilai.Name = "lblKeluarNilai";
            lblKeluarNilai.Size = new Size(27, 32);
            lblKeluarNilai.TabIndex = 1;
            lblKeluarNilai.Text = "0";
            // 
            // lblKeluarJudul
            // 
            lblKeluarJudul.AutoSize = true;
            lblKeluarJudul.BackColor = Color.Transparent;
            lblKeluarJudul.Font = new Font("Segoe UI", 9.5F);
            lblKeluarJudul.ForeColor = Color.FromArgb(90, 110, 140);
            lblKeluarJudul.Location = new Point(35, 16);
            lblKeluarJudul.Margin = new Padding(4, 0, 4, 0);
            lblKeluarJudul.Name = "lblKeluarJudul";
            lblKeluarJudul.Size = new Size(122, 17);
            lblKeluarJudul.TabIndex = 2;
            lblKeluarJudul.Text = "Total Barang Keluar";
            // 
            // cardStok
            // 
            cardStok.AccentColor = Color.FromArgb(126, 87, 194);
            cardStok.BackColor = Color.White;
            cardStok.BorderColor = Color.FromArgb(214, 228, 245);
            cardStok.Controls.Add(lblStokKet);
            cardStok.Controls.Add(lblStokNilai);
            cardStok.Controls.Add(lblStokJudul);
            cardStok.Dock = DockStyle.Fill;
            cardStok.Location = new Point(622, 0);
            cardStok.Margin = new Padding(0, 0, 14, 0);
            cardStok.Name = "cardStok";
            cardStok.Radius = 18;
            cardStok.Size = new Size(297, 120);
            cardStok.TabIndex = 2;
            // 
            // lblStokKet
            // 
            lblStokKet.AutoSize = true;
            lblStokKet.BackColor = Color.Transparent;
            lblStokKet.Font = new Font("Segoe UI", 8.5F);
            lblStokKet.ForeColor = Color.FromArgb(120, 135, 160);
            lblStokKet.Location = new Point(35, 78);
            lblStokKet.Margin = new Padding(4, 0, 4, 0);
            lblStokKet.Name = "lblStokKet";
            lblStokKet.Size = new Size(83, 15);
            lblStokKet.TabIndex = 0;
            lblStokKet.Text = "Semua barang";
            // 
            // lblStokNilai
            // 
            lblStokNilai.AutoSize = true;
            lblStokNilai.BackColor = Color.Transparent;
            lblStokNilai.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            lblStokNilai.ForeColor = Color.FromArgb(126, 87, 194);
            lblStokNilai.Location = new Point(33, 37);
            lblStokNilai.Margin = new Padding(4, 0, 4, 0);
            lblStokNilai.Name = "lblStokNilai";
            lblStokNilai.Size = new Size(27, 32);
            lblStokNilai.TabIndex = 1;
            lblStokNilai.Text = "0";
            // 
            // lblStokJudul
            // 
            lblStokJudul.AutoSize = true;
            lblStokJudul.BackColor = Color.Transparent;
            lblStokJudul.Font = new Font("Segoe UI", 9.5F);
            lblStokJudul.ForeColor = Color.FromArgb(90, 110, 140);
            lblStokJudul.Location = new Point(35, 16);
            lblStokJudul.Margin = new Padding(4, 0, 4, 0);
            lblStokJudul.Name = "lblStokJudul";
            lblStokJudul.Size = new Size(79, 17);
            lblStokJudul.TabIndex = 2;
            lblStokJudul.Text = "Stok Saat Ini";
            // 
            // cardOpname
            // 
            cardOpname.AccentColor = Color.FromArgb(230, 150, 20);
            cardOpname.BackColor = Color.White;
            cardOpname.BorderColor = Color.FromArgb(214, 228, 245);
            cardOpname.Controls.Add(lblOpnameKet);
            cardOpname.Controls.Add(lblOpnameNilai);
            cardOpname.Controls.Add(lblOpnameJudul);
            cardOpname.Dock = DockStyle.Fill;
            cardOpname.Location = new Point(933, 0);
            cardOpname.Margin = new Padding(0);
            cardOpname.Name = "cardOpname";
            cardOpname.Radius = 18;
            cardOpname.Size = new Size(312, 120);
            cardOpname.TabIndex = 3;
            // 
            // lblOpnameKet
            // 
            lblOpnameKet.AutoSize = true;
            lblOpnameKet.BackColor = Color.Transparent;
            lblOpnameKet.Font = new Font("Segoe UI", 8.5F);
            lblOpnameKet.ForeColor = Color.FromArgb(120, 135, 160);
            lblOpnameKet.Location = new Point(35, 78);
            lblOpnameKet.Margin = new Padding(4, 0, 4, 0);
            lblOpnameKet.Name = "lblOpnameKet";
            lblOpnameKet.Size = new Size(103, 15);
            lblOpnameKet.TabIndex = 0;
            lblOpnameKet.Text = "Entri pada periode";
            // 
            // lblOpnameNilai
            // 
            lblOpnameNilai.AutoSize = true;
            lblOpnameNilai.BackColor = Color.Transparent;
            lblOpnameNilai.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            lblOpnameNilai.ForeColor = Color.FromArgb(200, 125, 10);
            lblOpnameNilai.Location = new Point(33, 37);
            lblOpnameNilai.Margin = new Padding(4, 0, 4, 0);
            lblOpnameNilai.Name = "lblOpnameNilai";
            lblOpnameNilai.Size = new Size(27, 32);
            lblOpnameNilai.TabIndex = 1;
            lblOpnameNilai.Text = "0";
            // 
            // lblOpnameJudul
            // 
            lblOpnameJudul.AutoSize = true;
            lblOpnameJudul.BackColor = Color.Transparent;
            lblOpnameJudul.Font = new Font("Segoe UI", 9.5F);
            lblOpnameJudul.ForeColor = Color.FromArgb(90, 110, 140);
            lblOpnameJudul.Location = new Point(35, 16);
            lblOpnameJudul.Margin = new Padding(4, 0, 4, 0);
            lblOpnameJudul.Name = "lblOpnameJudul";
            lblOpnameJudul.Size = new Size(79, 17);
            lblOpnameJudul.TabIndex = 2;
            lblOpnameJudul.Text = "Penyesuaian";
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
            pnlFilter.Controls.Add(cmbJenis);
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
            // cmbJenis
            // 
            cmbJenis.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbJenis.Font = new Font("Segoe UI", 10F);
            cmbJenis.FormattingEnabled = true;
            cmbJenis.Items.AddRange(new object[] { "Semua jenis", "Masuk", "Keluar", "Penyesuaian" });
            cmbJenis.Location = new Point(614, 21);
            cmbJenis.Margin = new Padding(0);
            cmbJenis.Name = "cmbJenis";
            cmbJenis.Size = new Size(151, 25);
            cmbJenis.TabIndex = 5;
            // 
            // txtCari
            // 
            txtCari.Font = new Font("Segoe UI", 10F);
            txtCari.Location = new Point(779, 21);
            txtCari.Margin = new Padding(0);
            txtCari.Name = "txtCari";
            txtCari.PlaceholderText = "Cari barang / keterangan...";
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
            // pnlTabel
            // 
            pnlTabel.AccentColor = Color.Transparent;
            pnlTabel.BackColor = Color.White;
            pnlTabel.BorderColor = Color.FromArgb(214, 228, 245);
            pnlTabel.Controls.Add(dgvRiwayat);
            pnlTabel.Controls.Add(lblTabelJudul);
            pnlTabel.Dock = DockStyle.Fill;
            pnlTabel.Location = new Point(0, 222);
            pnlTabel.Margin = new Padding(0);
            pnlTabel.Name = "pnlTabel";
            pnlTabel.Padding = new Padding(23, 16, 23, 18);
            pnlTabel.Radius = 18;
            pnlTabel.Size = new Size(1245, 570);
            pnlTabel.TabIndex = 2;
            // 
            // dgvRiwayat
            // 
            dgvRiwayat.Columns.AddRange(new DataGridViewColumn[] { colNo, colWaktu, colJenis, colNama, colJumlah, colStokAkhir, colPihak, colKeterangan });
            dgvRiwayat.Dock = DockStyle.Fill;
            dgvRiwayat.Location = new Point(23, 55);
            dgvRiwayat.Margin = new Padding(0);
            dgvRiwayat.Name = "dgvRiwayat";
            dgvRiwayat.Size = new Size(1199, 497);
            dgvRiwayat.TabIndex = 0;
            // 
            // colNo
            // 
            colNo.FillWeight = 6F;
            colNo.HeaderText = "No";
            colNo.Name = "colNo";
            // 
            // colWaktu
            // 
            colWaktu.FillWeight = 15F;
            colWaktu.HeaderText = "Tanggal Waktu";
            colWaktu.Name = "colWaktu";
            // 
            // colJenis
            // 
            colJenis.FillWeight = 12F;
            colJenis.HeaderText = "Jenis Transaksi";
            colJenis.Name = "colJenis";
            // 
            // colNama
            // 
            colNama.FillWeight = 21F;
            colNama.HeaderText = "Nama Barang";
            colNama.Name = "colNama";
            // 
            // colJumlah
            // 
            colJumlah.FillWeight = 9F;
            colJumlah.HeaderText = "Jumlah";
            colJumlah.Name = "colJumlah";
            // 
            // colStokAkhir
            // 
            colStokAkhir.FillWeight = 9F;
            colStokAkhir.HeaderText = "Stok Akhir";
            colStokAkhir.Name = "colStokAkhir";
            // 
            // colPihak
            // 
            colPihak.FillWeight = 15F;
            colPihak.HeaderText = "Supplier / Tujuan";
            colPihak.Name = "colPihak";
            // 
            // colKeterangan
            // 
            colKeterangan.FillWeight = 13F;
            colKeterangan.HeaderText = "Keterangan";
            colKeterangan.Name = "colKeterangan";
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
            lblTabelJudul.Size = new Size(1199, 39);
            lblTabelJudul.TabIndex = 1;
            lblTabelJudul.Text = "Riwayat Pergerakan Stok";
            lblTabelJudul.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // UC_RiwayatGudang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(234, 243, 252);
            Controls.Add(tlpRoot);
            Margin = new Padding(4, 3, 4, 3);
            Name = "UC_RiwayatGudang";
            Size = new Size(1283, 923);
            tlpRoot.ResumeLayout(false);
            pnlJudul.ResumeLayout(false);
            pnlJudul.PerformLayout();
            tlpContent.ResumeLayout(false);
            tlpStats.ResumeLayout(false);
            cardMasuk.ResumeLayout(false);
            cardMasuk.PerformLayout();
            cardKeluar.ResumeLayout(false);
            cardKeluar.PerformLayout();
            cardStok.ResumeLayout(false);
            cardStok.PerformLayout();
            cardOpname.ResumeLayout(false);
            cardOpname.PerformLayout();
            pnlFilter.ResumeLayout(false);
            pnlFilter.PerformLayout();
            pnlTabel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRiwayat).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpRoot;
        private RoundedPanelUI pnlJudul;
        private System.Windows.Forms.Label lblSub;
        private System.Windows.Forms.Label lblJudul;
        private System.Windows.Forms.TableLayoutPanel tlpContent;
        private System.Windows.Forms.TableLayoutPanel tlpStats;
        private RoundedPanelUI cardMasuk;
        private System.Windows.Forms.Label lblMasukKet;
        private System.Windows.Forms.Label lblMasukNilai;
        private System.Windows.Forms.Label lblMasukJudul;
        private RoundedPanelUI cardKeluar;
        private System.Windows.Forms.Label lblKeluarKet;
        private System.Windows.Forms.Label lblKeluarNilai;
        private System.Windows.Forms.Label lblKeluarJudul;
        private RoundedPanelUI cardStok;
        private System.Windows.Forms.Label lblStokKet;
        private System.Windows.Forms.Label lblStokNilai;
        private System.Windows.Forms.Label lblStokJudul;
        private RoundedPanelUI cardOpname;
        private System.Windows.Forms.Label lblOpnameKet;
        private System.Windows.Forms.Label lblOpnameNilai;
        private System.Windows.Forms.Label lblOpnameJudul;
        private RoundedPanelUI pnlFilter;
        private System.Windows.Forms.ComboBox cmbRentang;
        private System.Windows.Forms.Label lblDari;
        private System.Windows.Forms.DateTimePicker dtpDari;
        private System.Windows.Forms.Label lblSampai;
        private System.Windows.Forms.DateTimePicker dtpSampai;
        private System.Windows.Forms.ComboBox cmbJenis;
        private System.Windows.Forms.TextBox txtCari;
        private RoundedButtonUI btnExport;
        private RoundedPanelUI pnlTabel;
        private System.Windows.Forms.DataGridView dgvRiwayat;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWaktu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colJenis;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNama;
        private System.Windows.Forms.DataGridViewTextBoxColumn colJumlah;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStokAkhir;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPihak;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKeterangan;
        private System.Windows.Forms.Label lblTabelJudul;
    }
}