namespace GUedang
{
    partial class UC_DSHBRDGudang
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            tlpRoot = new TableLayoutPanel();
            pnlHeader = new RoundedPanelUI();
            btnRefresh = new RoundedButtonUI();
            lblTanggal = new Label();
            lblJam = new Label();
            lblSapaan = new Label();
            lblJudul = new Label();
            tlpCards = new TableLayoutPanel();
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
            cardPerhatian = new RoundedPanelUI();
            lblPerhatianKet = new Label();
            lblPerhatianNilai = new Label();
            lblPerhatianJudul = new Label();
            tlpContent = new TableLayoutPanel();
            pnlAktivitas = new RoundedPanelUI();
            dgvAktivitas = new DataGridView();
            colWaktu = new DataGridViewTextBoxColumn();
            colJenis = new DataGridViewTextBoxColumn();
            colBarang = new DataGridViewTextBoxColumn();
            colJumlah = new DataGridViewTextBoxColumn();
            colStokAkhir = new DataGridViewTextBoxColumn();
            lblAktivitasJudul = new Label();
            pnlPerhatian = new RoundedPanelUI();
            dgvPerhatian = new DataGridView();
            colKode = new DataGridViewTextBoxColumn();
            colNama = new DataGridViewTextBoxColumn();
            colStok = new DataGridViewTextBoxColumn();
            colMin = new DataGridViewTextBoxColumn();
            lblPerhatianPanelJudul = new Label();
            timerJam = new System.Windows.Forms.Timer(components);
            tlpRoot.SuspendLayout();
            pnlHeader.SuspendLayout();
            tlpCards.SuspendLayout();
            cardMasuk.SuspendLayout();
            cardKeluar.SuspendLayout();
            cardStok.SuspendLayout();
            cardPerhatian.SuspendLayout();
            tlpContent.SuspendLayout();
            pnlAktivitas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAktivitas).BeginInit();
            pnlPerhatian.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPerhatian).BeginInit();
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
            tlpRoot.Margin = new Padding(4, 3, 4, 3);
            tlpRoot.Name = "tlpRoot";
            tlpRoot.Padding = new Padding(19, 18, 19, 14);
            tlpRoot.RowCount = 4;
            tlpRoot.RowStyles.Add(new RowStyle(SizeType.Absolute, 108F));
            tlpRoot.RowStyles.Add(new RowStyle(SizeType.Absolute, 134F));
            tlpRoot.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpRoot.RowStyles.Add(new RowStyle(SizeType.Absolute, 5F));
            tlpRoot.Size = new Size(1283, 808);
            tlpRoot.TabIndex = 0;
            tlpRoot.Paint += tlpRoot_Paint;
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
            pnlHeader.Dock = DockStyle.Fill;
            pnlHeader.Location = new Point(19, 18);
            pnlHeader.Margin = new Padding(0, 0, 0, 14);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Radius = 20;
            pnlHeader.Size = new Size(1245, 94);
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
            btnRefresh.Location = new Point(1089, 27);
            btnRefresh.Margin = new Padding(4, 3, 4, 3);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(128, 42);
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
            lblTanggal.Location = new Point(769, 53);
            lblTanggal.Margin = new Padding(4, 0, 4, 0);
            lblTanggal.Name = "lblTanggal";
            lblTanggal.Size = new Size(292, 23);
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
            lblJam.Location = new Point(816, 12);
            lblJam.Margin = new Padding(4, 0, 4, 0);
            lblJam.Name = "lblJam";
            lblJam.Size = new Size(245, 37);
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
            lblSapaan.Location = new Point(31, 55);
            lblSapaan.Margin = new Padding(4, 0, 4, 0);
            lblSapaan.Name = "lblSapaan";
            lblSapaan.Size = new Size(153, 17);
            lblSapaan.TabIndex = 1;
            lblSapaan.Text = "Selamat Datang, Gudang";
            // 
            // lblJudul
            // 
            lblJudul.AutoSize = true;
            lblJudul.BackColor = Color.Transparent;
            lblJudul.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            lblJudul.ForeColor = Color.FromArgb(13, 47, 110);
            lblJudul.Location = new Point(28, 14);
            lblJudul.Margin = new Padding(4, 0, 4, 0);
            lblJudul.Name = "lblJudul";
            lblJudul.Size = new Size(225, 32);
            lblJudul.TabIndex = 0;
            lblJudul.Text = "Dashboard Gudang";
            // 
            // tlpCards
            // 
            tlpCards.ColumnCount = 4;
            tlpCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpCards.Controls.Add(cardMasuk, 0, 0);
            tlpCards.Controls.Add(cardKeluar, 1, 0);
            tlpCards.Controls.Add(cardStok, 2, 0);
            tlpCards.Controls.Add(cardPerhatian, 3, 0);
            tlpCards.Dock = DockStyle.Fill;
            tlpCards.Location = new Point(19, 126);
            tlpCards.Margin = new Padding(0);
            tlpCards.Name = "tlpCards";
            tlpCards.RowCount = 1;
            tlpCards.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpCards.Size = new Size(1245, 134);
            tlpCards.TabIndex = 1;
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
            cardMasuk.Margin = new Padding(0, 0, 14, 14);
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
            lblMasukKet.Size = new Size(76, 15);
            lblMasukKet.TabIndex = 2;
            lblMasukKet.Text = "Unit diterima";
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
            lblMasukJudul.Size = new Size(136, 17);
            lblMasukJudul.TabIndex = 0;
            lblMasukJudul.Text = "Barang Masuk Hari Ini";
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
            cardKeluar.Margin = new Padding(0, 0, 14, 14);
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
            lblKeluarKet.Size = new Size(93, 15);
            lblKeluarKet.TabIndex = 2;
            lblKeluarKet.Text = "Unit dikeluarkan";
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
            lblKeluarJudul.Size = new Size(135, 17);
            lblKeluarJudul.TabIndex = 0;
            lblKeluarJudul.Text = "Barang Keluar Hari Ini";
            // 
            // cardStok
            // 
            cardStok.AccentColor = Color.FromArgb(0, 172, 193);
            cardStok.BackColor = Color.White;
            cardStok.BorderColor = Color.FromArgb(214, 228, 245);
            cardStok.Controls.Add(lblStokKet);
            cardStok.Controls.Add(lblStokNilai);
            cardStok.Controls.Add(lblStokJudul);
            cardStok.Dock = DockStyle.Fill;
            cardStok.Location = new Point(622, 0);
            cardStok.Margin = new Padding(0, 0, 14, 14);
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
            lblStokKet.Size = new Size(110, 15);
            lblStokKet.TabIndex = 2;
            lblStokKet.Text = "Total semua barang";
            // 
            // lblStokNilai
            // 
            lblStokNilai.AutoSize = true;
            lblStokNilai.BackColor = Color.Transparent;
            lblStokNilai.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            lblStokNilai.ForeColor = Color.FromArgb(0, 150, 170);
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
            lblStokJudul.TabIndex = 0;
            lblStokJudul.Text = "Stok Saat Ini";
            // 
            // cardPerhatian
            // 
            cardPerhatian.AccentColor = Color.FromArgb(126, 87, 194);
            cardPerhatian.BackColor = Color.White;
            cardPerhatian.BorderColor = Color.FromArgb(214, 228, 245);
            cardPerhatian.Controls.Add(lblPerhatianKet);
            cardPerhatian.Controls.Add(lblPerhatianNilai);
            cardPerhatian.Controls.Add(lblPerhatianJudul);
            cardPerhatian.Dock = DockStyle.Fill;
            cardPerhatian.Location = new Point(933, 0);
            cardPerhatian.Margin = new Padding(0, 0, 0, 14);
            cardPerhatian.Name = "cardPerhatian";
            cardPerhatian.Radius = 18;
            cardPerhatian.Size = new Size(312, 120);
            cardPerhatian.TabIndex = 3;
            // 
            // lblPerhatianKet
            // 
            lblPerhatianKet.AutoSize = true;
            lblPerhatianKet.BackColor = Color.Transparent;
            lblPerhatianKet.Font = new Font("Segoe UI", 8.5F);
            lblPerhatianKet.ForeColor = Color.FromArgb(120, 135, 160);
            lblPerhatianKet.Location = new Point(35, 78);
            lblPerhatianKet.Margin = new Padding(4, 0, 4, 0);
            lblPerhatianKet.Name = "lblPerhatianKet";
            lblPerhatianKet.Size = new Size(114, 15);
            lblPerhatianKet.TabIndex = 2;
            lblPerhatianKet.Text = "Stok menipis / habis";
            // 
            // lblPerhatianNilai
            // 
            lblPerhatianNilai.AutoSize = true;
            lblPerhatianNilai.BackColor = Color.Transparent;
            lblPerhatianNilai.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            lblPerhatianNilai.ForeColor = Color.FromArgb(126, 87, 194);
            lblPerhatianNilai.Location = new Point(33, 37);
            lblPerhatianNilai.Margin = new Padding(4, 0, 4, 0);
            lblPerhatianNilai.Name = "lblPerhatianNilai";
            lblPerhatianNilai.Size = new Size(27, 32);
            lblPerhatianNilai.TabIndex = 1;
            lblPerhatianNilai.Text = "0";
            // 
            // lblPerhatianJudul
            // 
            lblPerhatianJudul.AutoSize = true;
            lblPerhatianJudul.BackColor = Color.Transparent;
            lblPerhatianJudul.Font = new Font("Segoe UI", 9.5F);
            lblPerhatianJudul.ForeColor = Color.FromArgb(90, 110, 140);
            lblPerhatianJudul.Location = new Point(35, 16);
            lblPerhatianJudul.Margin = new Padding(4, 0, 4, 0);
            lblPerhatianJudul.Name = "lblPerhatianJudul";
            lblPerhatianJudul.Size = new Size(95, 17);
            lblPerhatianJudul.TabIndex = 0;
            lblPerhatianJudul.Text = "Perlu Perhatian";
            // 
            // tlpContent
            // 
            tlpContent.ColumnCount = 2;
            tlpContent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 58F));
            tlpContent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 42F));
            tlpContent.Controls.Add(pnlAktivitas, 0, 0);
            tlpContent.Controls.Add(pnlPerhatian, 1, 0);
            tlpContent.Location = new Point(19, 260);
            tlpContent.Margin = new Padding(0, 0, 0, 14);
            tlpContent.Name = "tlpContent";
            tlpContent.RowCount = 1;
            tlpContent.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpContent.Size = new Size(1245, 502);
            tlpContent.TabIndex = 2;
            // 
            // pnlAktivitas
            // 
            pnlAktivitas.AccentColor = Color.Transparent;
            pnlAktivitas.BackColor = Color.White;
            pnlAktivitas.BorderColor = Color.FromArgb(214, 228, 245);
            pnlAktivitas.Controls.Add(dgvAktivitas);
            pnlAktivitas.Controls.Add(lblAktivitasJudul);
            pnlAktivitas.Dock = DockStyle.Fill;
            pnlAktivitas.Location = new Point(0, 0);
            pnlAktivitas.Margin = new Padding(0, 0, 14, 0);
            pnlAktivitas.Name = "pnlAktivitas";
            pnlAktivitas.Padding = new Padding(23, 16, 23, 18);
            pnlAktivitas.Radius = 18;
            pnlAktivitas.Size = new Size(708, 502);
            pnlAktivitas.TabIndex = 0;
            // 
            // dgvAktivitas
            // 
            dgvAktivitas.AllowUserToAddRows = false;
            dgvAktivitas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.AliceBlue;
            dgvAktivitas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvAktivitas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAktivitas.BackgroundColor = Color.White;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.AliceBlue;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.RoyalBlue;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvAktivitas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvAktivitas.ColumnHeadersHeight = 40;
            dgvAktivitas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvAktivitas.Columns.AddRange(new DataGridViewColumn[] { colWaktu, colJenis, colBarang, colJumlah, colStokAkhir });
            dgvAktivitas.Dock = DockStyle.Fill;
            dgvAktivitas.EnableHeadersVisualStyles = false;
            dgvAktivitas.Location = new Point(23, 55);
            dgvAktivitas.Margin = new Padding(4, 3, 4, 3);
            dgvAktivitas.MultiSelect = false;
            dgvAktivitas.Name = "dgvAktivitas";
            dgvAktivitas.ReadOnly = true;
            dgvAktivitas.RowHeadersVisible = false;
            dgvAktivitas.RowHeadersWidth = 62;
            dgvAktivitas.Size = new Size(662, 429);
            dgvAktivitas.TabIndex = 1;
            // 
            // colWaktu
            // 
            colWaktu.FillWeight = 24F;
            colWaktu.HeaderText = "Waktu";
            colWaktu.MinimumWidth = 8;
            colWaktu.Name = "colWaktu";
            colWaktu.ReadOnly = true;
            // 
            // colJenis
            // 
            colJenis.FillWeight = 16F;
            colJenis.HeaderText = "Jenis";
            colJenis.MinimumWidth = 8;
            colJenis.Name = "colJenis";
            colJenis.ReadOnly = true;
            // 
            // colBarang
            // 
            colBarang.FillWeight = 30F;
            colBarang.HeaderText = "Nama Barang";
            colBarang.MinimumWidth = 8;
            colBarang.Name = "colBarang";
            colBarang.ReadOnly = true;
            // 
            // colJumlah
            // 
            colJumlah.FillWeight = 14F;
            colJumlah.HeaderText = "Jumlah";
            colJumlah.MinimumWidth = 8;
            colJumlah.Name = "colJumlah";
            colJumlah.ReadOnly = true;
            // 
            // colStokAkhir
            // 
            colStokAkhir.FillWeight = 16F;
            colStokAkhir.HeaderText = "Stok Akhir";
            colStokAkhir.MinimumWidth = 8;
            colStokAkhir.Name = "colStokAkhir";
            colStokAkhir.ReadOnly = true;
            // 
            // lblAktivitasJudul
            // 
            lblAktivitasJudul.BackColor = Color.Transparent;
            lblAktivitasJudul.Dock = DockStyle.Top;
            lblAktivitasJudul.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblAktivitasJudul.ForeColor = Color.FromArgb(13, 47, 110);
            lblAktivitasJudul.Location = new Point(23, 16);
            lblAktivitasJudul.Margin = new Padding(4, 0, 4, 0);
            lblAktivitasJudul.Name = "lblAktivitasJudul";
            lblAktivitasJudul.Size = new Size(662, 39);
            lblAktivitasJudul.TabIndex = 0;
            lblAktivitasJudul.Text = "Aktivitas Gudang Terakhir";
            lblAktivitasJudul.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlPerhatian
            // 
            pnlPerhatian.AccentColor = Color.Transparent;
            pnlPerhatian.BackColor = Color.White;
            pnlPerhatian.BorderColor = Color.FromArgb(214, 228, 245);
            pnlPerhatian.Controls.Add(dgvPerhatian);
            pnlPerhatian.Controls.Add(lblPerhatianPanelJudul);
            pnlPerhatian.Dock = DockStyle.Fill;
            pnlPerhatian.Location = new Point(722, 0);
            pnlPerhatian.Margin = new Padding(0);
            pnlPerhatian.Name = "pnlPerhatian";
            pnlPerhatian.Padding = new Padding(23, 16, 23, 18);
            pnlPerhatian.Radius = 18;
            pnlPerhatian.Size = new Size(523, 502);
            pnlPerhatian.TabIndex = 1;
            // 
            // dgvPerhatian
            // 
            dgvPerhatian.AllowUserToAddRows = false;
            dgvPerhatian.AllowUserToDeleteRows = false;
            dgvPerhatian.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPerhatian.BackgroundColor = Color.White;
            dgvPerhatian.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.Honeydew;
            dataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.SeaGreen;
            dataGridViewCellStyle3.SelectionBackColor = Color.DarkGreen;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvPerhatian.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvPerhatian.ColumnHeadersHeight = 40;
            dgvPerhatian.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvPerhatian.Columns.AddRange(new DataGridViewColumn[] { colKode, colNama, colStok, colMin });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.Honeydew;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = Color.Green;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvPerhatian.DefaultCellStyle = dataGridViewCellStyle4;
            dgvPerhatian.Dock = DockStyle.Fill;
            dgvPerhatian.EnableHeadersVisualStyles = false;
            dgvPerhatian.Location = new Point(23, 55);
            dgvPerhatian.Margin = new Padding(4, 3, 4, 3);
            dgvPerhatian.MultiSelect = false;
            dgvPerhatian.Name = "dgvPerhatian";
            dgvPerhatian.ReadOnly = true;
            dgvPerhatian.RowHeadersVisible = false;
            dgvPerhatian.RowHeadersWidth = 62;
            dgvPerhatian.Size = new Size(477, 429);
            dgvPerhatian.TabIndex = 1;
            // 
            // colKode
            // 
            colKode.FillWeight = 22F;
            colKode.HeaderText = "Kode";
            colKode.MinimumWidth = 8;
            colKode.Name = "colKode";
            colKode.ReadOnly = true;
            // 
            // colNama
            // 
            colNama.FillWeight = 42F;
            colNama.HeaderText = "Nama Barang";
            colNama.MinimumWidth = 8;
            colNama.Name = "colNama";
            colNama.ReadOnly = true;
            // 
            // colStok
            // 
            colStok.FillWeight = 18F;
            colStok.HeaderText = "Stok";
            colStok.MinimumWidth = 8;
            colStok.Name = "colStok";
            colStok.ReadOnly = true;
            // 
            // colMin
            // 
            colMin.FillWeight = 18F;
            colMin.HeaderText = "Min";
            colMin.MinimumWidth = 8;
            colMin.Name = "colMin";
            colMin.ReadOnly = true;
            // 
            // lblPerhatianPanelJudul
            // 
            lblPerhatianPanelJudul.BackColor = Color.Transparent;
            lblPerhatianPanelJudul.Dock = DockStyle.Top;
            lblPerhatianPanelJudul.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblPerhatianPanelJudul.ForeColor = Color.FromArgb(13, 47, 110);
            lblPerhatianPanelJudul.Location = new Point(23, 16);
            lblPerhatianPanelJudul.Margin = new Padding(4, 0, 4, 0);
            lblPerhatianPanelJudul.Name = "lblPerhatianPanelJudul";
            lblPerhatianPanelJudul.Size = new Size(477, 39);
            lblPerhatianPanelJudul.TabIndex = 0;
            lblPerhatianPanelJudul.Text = "Stok Perlu Perhatian";
            lblPerhatianPanelJudul.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // timerJam
            // 
            timerJam.Interval = 1000;
            // 
            // UC_DSHBRDGudang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(234, 243, 252);
            Controls.Add(tlpRoot);
            Margin = new Padding(4, 3, 4, 3);
            Name = "UC_DSHBRDGudang";
            Size = new Size(1283, 808);
            tlpRoot.ResumeLayout(false);
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            tlpCards.ResumeLayout(false);
            cardMasuk.ResumeLayout(false);
            cardMasuk.PerformLayout();
            cardKeluar.ResumeLayout(false);
            cardKeluar.PerformLayout();
            cardStok.ResumeLayout(false);
            cardStok.PerformLayout();
            cardPerhatian.ResumeLayout(false);
            cardPerhatian.PerformLayout();
            tlpContent.ResumeLayout(false);
            pnlAktivitas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAktivitas).EndInit();
            pnlPerhatian.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPerhatian).EndInit();
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
        private RoundedPanelUI cardMasuk;
        private System.Windows.Forms.Label lblMasukJudul;
        private System.Windows.Forms.Label lblMasukNilai;
        private System.Windows.Forms.Label lblMasukKet;
        private RoundedPanelUI cardKeluar;
        private System.Windows.Forms.Label lblKeluarJudul;
        private System.Windows.Forms.Label lblKeluarNilai;
        private System.Windows.Forms.Label lblKeluarKet;
        private RoundedPanelUI cardStok;
        private System.Windows.Forms.Label lblStokJudul;
        private System.Windows.Forms.Label lblStokNilai;
        private System.Windows.Forms.Label lblStokKet;
        private RoundedPanelUI cardPerhatian;
        private System.Windows.Forms.Label lblPerhatianJudul;
        private System.Windows.Forms.Label lblPerhatianNilai;
        private System.Windows.Forms.Label lblPerhatianKet;
        private System.Windows.Forms.TableLayoutPanel tlpContent;
        private RoundedPanelUI pnlAktivitas;
        private System.Windows.Forms.DataGridView dgvAktivitas;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWaktu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colJenis;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBarang;
        private System.Windows.Forms.DataGridViewTextBoxColumn colJumlah;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStokAkhir;
        private System.Windows.Forms.Label lblAktivitasJudul;
        private RoundedPanelUI pnlPerhatian;
        private System.Windows.Forms.DataGridView dgvPerhatian;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNama;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStok;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMin;
        private System.Windows.Forms.Label lblPerhatianPanelJudul;
        private System.Windows.Forms.Timer timerJam;
    }
}