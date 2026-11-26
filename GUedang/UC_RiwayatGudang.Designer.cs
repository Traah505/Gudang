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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
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
            pnlTabel = new RoundedPanelUI();
            dgvRiwayat = new DataGridView();
            lblTabelJudul = new Label();
            colNo = new DataGridViewTextBoxColumn();
            colWaktu = new DataGridViewTextBoxColumn();
            colJenis = new DataGridViewTextBoxColumn();
            colNama = new DataGridViewTextBoxColumn();
            colJumlah = new DataGridViewTextBoxColumn();
            colStokAkhir = new DataGridViewTextBoxColumn();
            colPihak = new DataGridViewTextBoxColumn();
            colKeterangan = new DataGridViewTextBoxColumn();
            colPetugas = new DataGridViewTextBoxColumn();
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
            tlpRoot.Padding = new Padding(27, 30, 27, 30);
            tlpRoot.RowCount = 2;
            tlpRoot.RowStyles.Add(new RowStyle(SizeType.Absolute, 123F));
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
            pnlJudul.Size = new Size(1779, 100);
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
            lblSub.Size = new Size(554, 25);
            lblSub.TabIndex = 0;
            lblSub.Text = "Semua pergerakan stok: barang masuk, keluar, dan penyesuaian.";
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
            lblJudul.Size = new Size(258, 45);
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
            tlpContent.Location = new Point(27, 153);
            tlpContent.Margin = new Padding(0);
            tlpContent.Name = "tlpContent";
            tlpContent.RowCount = 3;
            tlpContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 190F));
            tlpContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 123F));
            tlpContent.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpContent.Size = new Size(1779, 1355);
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
            tlpStats.Location = new Point(0, 0);
            tlpStats.Margin = new Padding(0, 0, 0, 23);
            tlpStats.Name = "tlpStats";
            tlpStats.RowCount = 1;
            tlpStats.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpStats.Size = new Size(1779, 167);
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
            cardMasuk.Margin = new Padding(0, 0, 20, 0);
            cardMasuk.Name = "cardMasuk";
            cardMasuk.Radius = 18;
            cardMasuk.Size = new Size(424, 167);
            cardMasuk.TabIndex = 0;
            // 
            // lblMasukKet
            // 
            lblMasukKet.AutoSize = true;
            lblMasukKet.BackColor = Color.Transparent;
            lblMasukKet.Font = new Font("Segoe UI", 8.5F);
            lblMasukKet.ForeColor = Color.FromArgb(120, 135, 160);
            lblMasukKet.Location = new Point(50, 130);
            lblMasukKet.Margin = new Padding(6, 0, 6, 0);
            lblMasukKet.Name = "lblMasukKet";
            lblMasukKet.Size = new Size(148, 23);
            lblMasukKet.TabIndex = 0;
            lblMasukKet.Text = "Unit pada periode";
            // 
            // lblMasukNilai
            // 
            lblMasukNilai.AutoSize = true;
            lblMasukNilai.BackColor = Color.Transparent;
            lblMasukNilai.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            lblMasukNilai.ForeColor = Color.FromArgb(24, 94, 224);
            lblMasukNilai.Location = new Point(47, 62);
            lblMasukNilai.Margin = new Padding(6, 0, 6, 0);
            lblMasukNilai.Name = "lblMasukNilai";
            lblMasukNilai.Size = new Size(40, 48);
            lblMasukNilai.TabIndex = 1;
            lblMasukNilai.Text = "0";
            // 
            // lblMasukJudul
            // 
            lblMasukJudul.AutoSize = true;
            lblMasukJudul.BackColor = Color.Transparent;
            lblMasukJudul.Font = new Font("Segoe UI", 9.5F);
            lblMasukJudul.ForeColor = Color.FromArgb(90, 110, 140);
            lblMasukJudul.Location = new Point(50, 27);
            lblMasukJudul.Margin = new Padding(6, 0, 6, 0);
            lblMasukJudul.Name = "lblMasukJudul";
            lblMasukJudul.Size = new Size(177, 25);
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
            cardKeluar.Location = new Point(444, 0);
            cardKeluar.Margin = new Padding(0, 0, 20, 0);
            cardKeluar.Name = "cardKeluar";
            cardKeluar.Radius = 18;
            cardKeluar.Size = new Size(424, 167);
            cardKeluar.TabIndex = 1;
            // 
            // lblKeluarKet
            // 
            lblKeluarKet.AutoSize = true;
            lblKeluarKet.BackColor = Color.Transparent;
            lblKeluarKet.Font = new Font("Segoe UI", 8.5F);
            lblKeluarKet.ForeColor = Color.FromArgb(120, 135, 160);
            lblKeluarKet.Location = new Point(50, 130);
            lblKeluarKet.Margin = new Padding(6, 0, 6, 0);
            lblKeluarKet.Name = "lblKeluarKet";
            lblKeluarKet.Size = new Size(148, 23);
            lblKeluarKet.TabIndex = 0;
            lblKeluarKet.Text = "Unit pada periode";
            // 
            // lblKeluarNilai
            // 
            lblKeluarNilai.AutoSize = true;
            lblKeluarNilai.BackColor = Color.Transparent;
            lblKeluarNilai.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            lblKeluarNilai.ForeColor = Color.FromArgb(40, 140, 90);
            lblKeluarNilai.Location = new Point(47, 62);
            lblKeluarNilai.Margin = new Padding(6, 0, 6, 0);
            lblKeluarNilai.Name = "lblKeluarNilai";
            lblKeluarNilai.Size = new Size(40, 48);
            lblKeluarNilai.TabIndex = 1;
            lblKeluarNilai.Text = "0";
            // 
            // lblKeluarJudul
            // 
            lblKeluarJudul.AutoSize = true;
            lblKeluarJudul.BackColor = Color.Transparent;
            lblKeluarJudul.Font = new Font("Segoe UI", 9.5F);
            lblKeluarJudul.ForeColor = Color.FromArgb(90, 110, 140);
            lblKeluarJudul.Location = new Point(50, 27);
            lblKeluarJudul.Margin = new Padding(6, 0, 6, 0);
            lblKeluarJudul.Name = "lblKeluarJudul";
            lblKeluarJudul.Size = new Size(176, 25);
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
            cardStok.Location = new Point(888, 0);
            cardStok.Margin = new Padding(0, 0, 20, 0);
            cardStok.Name = "cardStok";
            cardStok.Radius = 18;
            cardStok.Size = new Size(424, 167);
            cardStok.TabIndex = 2;
            // 
            // lblStokKet
            // 
            lblStokKet.AutoSize = true;
            lblStokKet.BackColor = Color.Transparent;
            lblStokKet.Font = new Font("Segoe UI", 8.5F);
            lblStokKet.ForeColor = Color.FromArgb(120, 135, 160);
            lblStokKet.Location = new Point(50, 130);
            lblStokKet.Margin = new Padding(6, 0, 6, 0);
            lblStokKet.Name = "lblStokKet";
            lblStokKet.Size = new Size(121, 23);
            lblStokKet.TabIndex = 0;
            lblStokKet.Text = "Semua barang";
            // 
            // lblStokNilai
            // 
            lblStokNilai.AutoSize = true;
            lblStokNilai.BackColor = Color.Transparent;
            lblStokNilai.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            lblStokNilai.ForeColor = Color.FromArgb(126, 87, 194);
            lblStokNilai.Location = new Point(47, 62);
            lblStokNilai.Margin = new Padding(6, 0, 6, 0);
            lblStokNilai.Name = "lblStokNilai";
            lblStokNilai.Size = new Size(40, 48);
            lblStokNilai.TabIndex = 1;
            lblStokNilai.Text = "0";
            // 
            // lblStokJudul
            // 
            lblStokJudul.AutoSize = true;
            lblStokJudul.BackColor = Color.Transparent;
            lblStokJudul.Font = new Font("Segoe UI", 9.5F);
            lblStokJudul.ForeColor = Color.FromArgb(90, 110, 140);
            lblStokJudul.Location = new Point(50, 27);
            lblStokJudul.Margin = new Padding(6, 0, 6, 0);
            lblStokJudul.Name = "lblStokJudul";
            lblStokJudul.Size = new Size(114, 25);
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
            cardOpname.Location = new Point(1332, 0);
            cardOpname.Margin = new Padding(0);
            cardOpname.Name = "cardOpname";
            cardOpname.Radius = 18;
            cardOpname.Size = new Size(447, 167);
            cardOpname.TabIndex = 3;
            // 
            // lblOpnameKet
            // 
            lblOpnameKet.AutoSize = true;
            lblOpnameKet.BackColor = Color.Transparent;
            lblOpnameKet.Font = new Font("Segoe UI", 8.5F);
            lblOpnameKet.ForeColor = Color.FromArgb(120, 135, 160);
            lblOpnameKet.Location = new Point(50, 130);
            lblOpnameKet.Margin = new Padding(6, 0, 6, 0);
            lblOpnameKet.Name = "lblOpnameKet";
            lblOpnameKet.Size = new Size(151, 23);
            lblOpnameKet.TabIndex = 0;
            lblOpnameKet.Text = "Entri pada periode";
            // 
            // lblOpnameNilai
            // 
            lblOpnameNilai.AutoSize = true;
            lblOpnameNilai.BackColor = Color.Transparent;
            lblOpnameNilai.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            lblOpnameNilai.ForeColor = Color.FromArgb(200, 125, 10);
            lblOpnameNilai.Location = new Point(47, 62);
            lblOpnameNilai.Margin = new Padding(6, 0, 6, 0);
            lblOpnameNilai.Name = "lblOpnameNilai";
            lblOpnameNilai.Size = new Size(40, 48);
            lblOpnameNilai.TabIndex = 1;
            lblOpnameNilai.Text = "0";
            // 
            // lblOpnameJudul
            // 
            lblOpnameJudul.AutoSize = true;
            lblOpnameJudul.BackColor = Color.Transparent;
            lblOpnameJudul.Font = new Font("Segoe UI", 9.5F);
            lblOpnameJudul.ForeColor = Color.FromArgb(90, 110, 140);
            lblOpnameJudul.Location = new Point(50, 27);
            lblOpnameJudul.Margin = new Padding(6, 0, 6, 0);
            lblOpnameJudul.Name = "lblOpnameJudul";
            lblOpnameJudul.Size = new Size(117, 25);
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
            pnlFilter.Location = new Point(0, 190);
            pnlFilter.Margin = new Padding(0, 0, 0, 23);
            pnlFilter.Name = "pnlFilter";
            pnlFilter.Padding = new Padding(33, 0, 33, 0);
            pnlFilter.Radius = 18;
            pnlFilter.Size = new Size(1779, 100);
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
            // cmbJenis
            // 
            cmbJenis.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbJenis.Font = new Font("Segoe UI", 10F);
            cmbJenis.FormattingEnabled = true;
            cmbJenis.Items.AddRange(new object[] { "Semua jenis", "Masuk", "Keluar", "Penyesuaian" });
            cmbJenis.Location = new Point(877, 35);
            cmbJenis.Margin = new Padding(0);
            cmbJenis.Name = "cmbJenis";
            cmbJenis.Size = new Size(214, 36);
            cmbJenis.TabIndex = 5;
            // 
            // txtCari
            // 
            txtCari.Font = new Font("Segoe UI", 10F);
            txtCari.Location = new Point(1113, 35);
            txtCari.Margin = new Padding(0);
            txtCari.Name = "txtCari";
            txtCari.PlaceholderText = "Cari barang / keterangan...";
            txtCari.Size = new Size(331, 34);
            txtCari.TabIndex = 6;
            // 
            // pnlTabel
            // 
            pnlTabel.AccentColor = Color.Transparent;
            pnlTabel.BackColor = Color.White;
            pnlTabel.BorderColor = Color.FromArgb(214, 228, 245);
            pnlTabel.Controls.Add(dgvRiwayat);
            pnlTabel.Controls.Add(lblTabelJudul);
            pnlTabel.Dock = DockStyle.Fill;
            pnlTabel.Location = new Point(0, 313);
            pnlTabel.Margin = new Padding(0);
            pnlTabel.Name = "pnlTabel";
            pnlTabel.Padding = new Padding(33, 27, 33, 30);
            pnlTabel.Radius = 18;
            pnlTabel.Size = new Size(1779, 1042);
            pnlTabel.TabIndex = 2;
            // 
            // dgvRiwayat
            // 
            dgvRiwayat.AllowUserToAddRows = false;
            dgvRiwayat.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.AliceBlue;
            dgvRiwayat.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvRiwayat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRiwayat.BackgroundColor = Color.White;
            dgvRiwayat.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.RoyalBlue;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.AliceBlue;
            dataGridViewCellStyle2.SelectionBackColor = Color.AliceBlue;
            dataGridViewCellStyle2.SelectionForeColor = Color.RoyalBlue;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvRiwayat.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvRiwayat.ColumnHeadersHeight = 40;
            dgvRiwayat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvRiwayat.Columns.AddRange(new DataGridViewColumn[] { colNo, colWaktu, colJenis, colNama, colJumlah, colStokAkhir, colPihak, colKeterangan, colPetugas });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.AliceBlue;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.RoyalBlue;
            dataGridViewCellStyle3.SelectionBackColor = Color.SkyBlue;
            dataGridViewCellStyle3.SelectionForeColor = Color.AliceBlue;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvRiwayat.DefaultCellStyle = dataGridViewCellStyle3;
            dgvRiwayat.Dock = DockStyle.Fill;
            dgvRiwayat.EnableHeadersVisualStyles = false;
            dgvRiwayat.Location = new Point(33, 92);
            dgvRiwayat.Margin = new Padding(0);
            dgvRiwayat.MultiSelect = false;
            dgvRiwayat.Name = "dgvRiwayat";
            dgvRiwayat.ReadOnly = true;
            dgvRiwayat.RowHeadersVisible = false;
            dgvRiwayat.RowHeadersWidth = 62;
            dgvRiwayat.Size = new Size(1713, 920);
            dgvRiwayat.TabIndex = 0;
            // 
            // lblTabelJudul
            // 
            lblTabelJudul.BackColor = Color.Transparent;
            lblTabelJudul.Dock = DockStyle.Top;
            lblTabelJudul.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblTabelJudul.ForeColor = Color.FromArgb(13, 47, 110);
            lblTabelJudul.Location = new Point(33, 27);
            lblTabelJudul.Margin = new Padding(6, 0, 6, 0);
            lblTabelJudul.Name = "lblTabelJudul";
            lblTabelJudul.Size = new Size(1713, 65);
            lblTabelJudul.TabIndex = 1;
            lblTabelJudul.Text = "Riwayat Pergerakan Stok";
            lblTabelJudul.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // colNo
            // 
            colNo.FillWeight = 5.140187F;
            colNo.HeaderText = "No";
            colNo.MinimumWidth = 8;
            colNo.Name = "colNo";
            colNo.ReadOnly = true;
            // 
            // colWaktu
            // 
            colWaktu.FillWeight = 12.9698639F;
            colWaktu.HeaderText = "Tanggal Waktu";
            colWaktu.MinimumWidth = 8;
            colWaktu.Name = "colWaktu";
            colWaktu.ReadOnly = true;
            // 
            // colJenis
            // 
            colJenis.FillWeight = 10.3982143F;
            colJenis.HeaderText = "Jenis Transaksi";
            colJenis.MinimumWidth = 8;
            colJenis.Name = "colJenis";
            colJenis.ReadOnly = true;
            // 
            // colNama
            // 
            colNama.FillWeight = 18.105772F;
            colNama.HeaderText = "Nama Barang";
            colNama.MinimumWidth = 8;
            colNama.Name = "colNama";
            colNama.ReadOnly = true;
            // 
            // colJumlah
            // 
            colJumlah.FillWeight = 7.82730055F;
            colJumlah.HeaderText = "Jumlah";
            colJumlah.MinimumWidth = 8;
            colJumlah.Name = "colJumlah";
            colJumlah.ReadOnly = true;
            // 
            // colStokAkhir
            // 
            colStokAkhir.FillWeight = 7.70826054F;
            colStokAkhir.HeaderText = "Stok Akhir";
            colStokAkhir.MinimumWidth = 8;
            colStokAkhir.Name = "colStokAkhir";
            colStokAkhir.ReadOnly = true;
            // 
            // colPihak
            // 
            colPihak.FillWeight = 12.9678841F;
            colPihak.HeaderText = "Supplier / Tujuan";
            colPihak.MinimumWidth = 8;
            colPihak.Name = "colPihak";
            colPihak.ReadOnly = true;
            // 
            // colKeterangan
            // 
            colKeterangan.FillWeight = 11.2144527F;
            colKeterangan.HeaderText = "Keterangan";
            colKeterangan.MinimumWidth = 8;
            colKeterangan.Name = "colKeterangan";
            colKeterangan.ReadOnly = true;
            // 
            // colPetugas
            // 
            colPetugas.FillWeight = 113.66806F;
            colPetugas.HeaderText = "Petugas";
            colPetugas.MinimumWidth = 8;
            colPetugas.Name = "colPetugas";
            colPetugas.ReadOnly = true;
            // 
            // UC_RiwayatGudang
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(234, 243, 252);
            Controls.Add(tlpRoot);
            Margin = new Padding(6, 5, 6, 5);
            Name = "UC_RiwayatGudang";
            Size = new Size(1833, 1538);
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
        private RoundedPanelUI pnlTabel;
        private System.Windows.Forms.DataGridView dgvRiwayat;
        private System.Windows.Forms.Label lblTabelJudul;
        private DataGridViewTextBoxColumn colNo;
        private DataGridViewTextBoxColumn colWaktu;
        private DataGridViewTextBoxColumn colJenis;
        private DataGridViewTextBoxColumn colNama;
        private DataGridViewTextBoxColumn colJumlah;
        private DataGridViewTextBoxColumn colStokAkhir;
        private DataGridViewTextBoxColumn colPihak;
        private DataGridViewTextBoxColumn colKeterangan;
        private DataGridViewTextBoxColumn colPetugas;
    }
}