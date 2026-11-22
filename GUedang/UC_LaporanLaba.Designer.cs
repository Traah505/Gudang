namespace GUedang
{
    partial class UC_LaporanLaba
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
            cardJual = new RoundedPanelUI();
            lblJualKet = new Label();
            lblJualNilai = new Label();
            lblJualJudul = new Label();
            cardModal = new RoundedPanelUI();
            lblModalKet = new Label();
            lblModalNilai = new Label();
            lblModalJudul = new Label();
            cardLaba = new RoundedPanelUI();
            lblLabaKet = new Label();
            lblLabaNilai = new Label();
            lblLabaJudul = new Label();
            cardPersen = new RoundedPanelUI();
            lblPersenKet = new Label();
            lblPersenNilai = new Label();
            lblPersenJudul = new Label();
            pnlFilter = new RoundedPanelUI();
            cmbRentang = new ComboBox();
            lblDari = new Label();
            dtpDari = new DateTimePicker();
            lblSampai = new Label();
            dtpSampai = new DateTimePicker();
            cmbKelompok = new ComboBox();
            btnTampilkan = new RoundedButtonUI();
            tlpMain = new TableLayoutPanel();
            pnlTabel = new RoundedPanelUI();
            dgvLaba = new DataGridView();
            colNo = new DataGridViewTextBoxColumn();
            colKelompok = new DataGridViewTextBoxColumn();
            colTransaksi = new DataGridViewTextBoxColumn();
            colPenjualan = new DataGridViewTextBoxColumn();
            colModal = new DataGridViewTextBoxColumn();
            colLaba = new DataGridViewTextBoxColumn();
            colMargin = new DataGridViewTextBoxColumn();
            lblTabelJudul = new Label();
            pnlChart = new RoundedPanelUI();
            lblTerbaik = new Label();
            lblChartJudul = new Label();
            tlpRoot.SuspendLayout();
            pnlJudul.SuspendLayout();
            tlpContent.SuspendLayout();
            tlpStats.SuspendLayout();
            cardJual.SuspendLayout();
            cardModal.SuspendLayout();
            cardLaba.SuspendLayout();
            cardPersen.SuspendLayout();
            pnlFilter.SuspendLayout();
            tlpMain.SuspendLayout();
            pnlTabel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLaba).BeginInit();
            pnlChart.SuspendLayout();
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
            tlpRoot.RowStyles.Add(new RowStyle(SizeType.Absolute, 127F));
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
            pnlJudul.Size = new Size(1779, 104);
            pnlJudul.TabIndex = 0;
            // 
            // lblSub
            // 
            lblSub.AutoSize = true;
            lblSub.BackColor = Color.Transparent;
            lblSub.Font = new Font("Segoe UI", 9.5F);
            lblSub.ForeColor = Color.FromArgb(90, 110, 140);
            lblSub.Location = new Point(39, 60);
            lblSub.Margin = new Padding(6, 0, 6, 0);
            lblSub.Name = "lblSub";
            lblSub.Size = new Size(385, 25);
            lblSub.TabIndex = 0;
            lblSub.Text = "Ringkasan keuntungan penjualan SMK Mart.";
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
            lblJudul.Size = new Size(217, 45);
            lblJudul.TabIndex = 1;
            lblJudul.Text = "Laporan Laba";
            // 
            // tlpContent
            // 
            tlpContent.ColumnCount = 1;
            tlpContent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpContent.Controls.Add(tlpStats, 0, 0);
            tlpContent.Controls.Add(pnlFilter, 0, 1);
            tlpContent.Controls.Add(tlpMain, 0, 2);
            tlpContent.Dock = DockStyle.Fill;
            tlpContent.Location = new Point(27, 157);
            tlpContent.Margin = new Padding(0);
            tlpContent.Name = "tlpContent";
            tlpContent.RowCount = 3;
            tlpContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 184F));
            tlpContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 119F));
            tlpContent.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpContent.Size = new Size(1779, 1351);
            tlpContent.TabIndex = 1;
            // 
            // tlpStats
            // 
            tlpStats.ColumnCount = 4;
            tlpStats.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpStats.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpStats.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpStats.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpStats.Controls.Add(cardJual, 0, 0);
            tlpStats.Controls.Add(cardModal, 1, 0);
            tlpStats.Controls.Add(cardLaba, 2, 0);
            tlpStats.Controls.Add(cardPersen, 3, 0);
            tlpStats.Location = new Point(0, 0);
            tlpStats.Margin = new Padding(0, 0, 0, 23);
            tlpStats.Name = "tlpStats";
            tlpStats.RowCount = 1;
            tlpStats.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpStats.Size = new Size(1779, 161);
            tlpStats.TabIndex = 0;
            // 
            // cardJual
            // 
            cardJual.AccentColor = Color.FromArgb(30, 136, 229);
            cardJual.BackColor = Color.White;
            cardJual.BorderColor = Color.FromArgb(214, 228, 245);
            cardJual.Controls.Add(lblJualKet);
            cardJual.Controls.Add(lblJualNilai);
            cardJual.Controls.Add(lblJualJudul);
            cardJual.Dock = DockStyle.Fill;
            cardJual.Location = new Point(0, 0);
            cardJual.Margin = new Padding(0, 0, 20, 0);
            cardJual.Name = "cardJual";
            cardJual.Radius = 18;
            cardJual.Size = new Size(424, 161);
            cardJual.TabIndex = 0;
            // 
            // lblJualKet
            // 
            lblJualKet.AutoSize = true;
            lblJualKet.BackColor = Color.Transparent;
            lblJualKet.Font = new Font("Segoe UI", 8.5F);
            lblJualKet.ForeColor = Color.FromArgb(120, 135, 160);
            lblJualKet.Location = new Point(50, 130);
            lblJualKet.Margin = new Padding(6, 0, 6, 0);
            lblJualKet.Name = "lblJualKet";
            lblJualKet.Size = new Size(146, 23);
            lblJualKet.TabIndex = 0;
            lblJualKet.Text = "Pendapatan kotor";
            // 
            // lblJualNilai
            // 
            lblJualNilai.AutoSize = true;
            lblJualNilai.BackColor = Color.Transparent;
            lblJualNilai.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            lblJualNilai.ForeColor = Color.FromArgb(24, 94, 224);
            lblJualNilai.Location = new Point(47, 62);
            lblJualNilai.Margin = new Padding(6, 0, 6, 0);
            lblJualNilai.Name = "lblJualNilai";
            lblJualNilai.Size = new Size(94, 48);
            lblJualNilai.TabIndex = 1;
            lblJualNilai.Text = "Rp 0";
            // 
            // lblJualJudul
            // 
            lblJualJudul.AutoSize = true;
            lblJualJudul.BackColor = Color.Transparent;
            lblJualJudul.Font = new Font("Segoe UI", 9.5F);
            lblJualJudul.ForeColor = Color.FromArgb(90, 110, 140);
            lblJualJudul.Location = new Point(50, 27);
            lblJualJudul.Margin = new Padding(6, 0, 6, 0);
            lblJualJudul.Name = "lblJualJudul";
            lblJualJudul.Size = new Size(140, 25);
            lblJualJudul.TabIndex = 2;
            lblJualJudul.Text = "Total Penjualan";
            // 
            // cardModal
            // 
            cardModal.AccentColor = Color.FromArgb(46, 160, 100);
            cardModal.BackColor = Color.White;
            cardModal.BorderColor = Color.FromArgb(214, 228, 245);
            cardModal.Controls.Add(lblModalKet);
            cardModal.Controls.Add(lblModalNilai);
            cardModal.Controls.Add(lblModalJudul);
            cardModal.Dock = DockStyle.Fill;
            cardModal.Location = new Point(444, 0);
            cardModal.Margin = new Padding(0, 0, 20, 0);
            cardModal.Name = "cardModal";
            cardModal.Radius = 18;
            cardModal.Size = new Size(424, 161);
            cardModal.TabIndex = 1;
            // 
            // lblModalKet
            // 
            lblModalKet.AutoSize = true;
            lblModalKet.BackColor = Color.Transparent;
            lblModalKet.Font = new Font("Segoe UI", 8.5F);
            lblModalKet.ForeColor = Color.FromArgb(120, 135, 160);
            lblModalKet.Location = new Point(50, 130);
            lblModalKet.Margin = new Padding(6, 0, 6, 0);
            lblModalKet.Name = "lblModalKet";
            lblModalKet.Size = new Size(130, 23);
            lblModalKet.TabIndex = 0;
            lblModalKet.Text = "Harga beli x qty";
            // 
            // lblModalNilai
            // 
            lblModalNilai.AutoSize = true;
            lblModalNilai.BackColor = Color.Transparent;
            lblModalNilai.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            lblModalNilai.ForeColor = Color.FromArgb(40, 140, 90);
            lblModalNilai.Location = new Point(47, 62);
            lblModalNilai.Margin = new Padding(6, 0, 6, 0);
            lblModalNilai.Name = "lblModalNilai";
            lblModalNilai.Size = new Size(94, 48);
            lblModalNilai.TabIndex = 1;
            lblModalNilai.Text = "Rp 0";
            // 
            // lblModalJudul
            // 
            lblModalJudul.AutoSize = true;
            lblModalJudul.BackColor = Color.Transparent;
            lblModalJudul.Font = new Font("Segoe UI", 9.5F);
            lblModalJudul.ForeColor = Color.FromArgb(90, 110, 140);
            lblModalJudul.Location = new Point(50, 27);
            lblModalJudul.Margin = new Padding(6, 0, 6, 0);
            lblModalJudul.Name = "lblModalJudul";
            lblModalJudul.Size = new Size(237, 25);
            lblModalJudul.TabIndex = 2;
            lblModalJudul.Text = "Total Modal Barang Terjual";
            // 
            // cardLaba
            // 
            cardLaba.AccentColor = Color.FromArgb(13, 47, 110);
            cardLaba.BackColor = Color.White;
            cardLaba.BorderColor = Color.FromArgb(214, 228, 245);
            cardLaba.Controls.Add(lblLabaKet);
            cardLaba.Controls.Add(lblLabaNilai);
            cardLaba.Controls.Add(lblLabaJudul);
            cardLaba.Dock = DockStyle.Fill;
            cardLaba.Location = new Point(888, 0);
            cardLaba.Margin = new Padding(0, 0, 20, 0);
            cardLaba.Name = "cardLaba";
            cardLaba.Radius = 18;
            cardLaba.Size = new Size(424, 161);
            cardLaba.TabIndex = 2;
            // 
            // lblLabaKet
            // 
            lblLabaKet.AutoSize = true;
            lblLabaKet.BackColor = Color.Transparent;
            lblLabaKet.Font = new Font("Segoe UI", 8.5F);
            lblLabaKet.ForeColor = Color.FromArgb(120, 135, 160);
            lblLabaKet.Location = new Point(50, 130);
            lblLabaKet.Margin = new Padding(6, 0, 6, 0);
            lblLabaKet.Name = "lblLabaKet";
            lblLabaKet.Size = new Size(149, 23);
            lblLabaKet.TabIndex = 0;
            lblLabaKet.Text = "Penjualan - modal";
            // 
            // lblLabaNilai
            // 
            lblLabaNilai.AutoSize = true;
            lblLabaNilai.BackColor = Color.Transparent;
            lblLabaNilai.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            lblLabaNilai.ForeColor = Color.FromArgb(13, 47, 110);
            lblLabaNilai.Location = new Point(47, 62);
            lblLabaNilai.Margin = new Padding(6, 0, 6, 0);
            lblLabaNilai.Name = "lblLabaNilai";
            lblLabaNilai.Size = new Size(94, 48);
            lblLabaNilai.TabIndex = 1;
            lblLabaNilai.Text = "Rp 0";
            // 
            // lblLabaJudul
            // 
            lblLabaJudul.AutoSize = true;
            lblLabaJudul.BackColor = Color.Transparent;
            lblLabaJudul.Font = new Font("Segoe UI", 9.5F);
            lblLabaJudul.ForeColor = Color.FromArgb(90, 110, 140);
            lblLabaJudul.Location = new Point(50, 27);
            lblLabaJudul.Margin = new Padding(6, 0, 6, 0);
            lblLabaJudul.Name = "lblLabaJudul";
            lblLabaJudul.Size = new Size(97, 25);
            lblLabaJudul.TabIndex = 2;
            lblLabaJudul.Text = "Total Laba";
            // 
            // cardPersen
            // 
            cardPersen.AccentColor = Color.FromArgb(126, 87, 194);
            cardPersen.BackColor = Color.White;
            cardPersen.BorderColor = Color.FromArgb(214, 228, 245);
            cardPersen.Controls.Add(lblPersenKet);
            cardPersen.Controls.Add(lblPersenNilai);
            cardPersen.Controls.Add(lblPersenJudul);
            cardPersen.Dock = DockStyle.Fill;
            cardPersen.Location = new Point(1332, 0);
            cardPersen.Margin = new Padding(0);
            cardPersen.Name = "cardPersen";
            cardPersen.Radius = 18;
            cardPersen.Size = new Size(447, 161);
            cardPersen.TabIndex = 3;
            // 
            // lblPersenKet
            // 
            lblPersenKet.AutoSize = true;
            lblPersenKet.BackColor = Color.Transparent;
            lblPersenKet.Font = new Font("Segoe UI", 8.5F);
            lblPersenKet.ForeColor = Color.FromArgb(120, 135, 160);
            lblPersenKet.Location = new Point(50, 130);
            lblPersenKet.Margin = new Padding(6, 0, 6, 0);
            lblPersenKet.Name = "lblPersenKet";
            lblPersenKet.Size = new Size(138, 23);
            lblPersenKet.TabIndex = 0;
            lblPersenKet.Text = "Laba / penjualan";
            // 
            // lblPersenNilai
            // 
            lblPersenNilai.AutoSize = true;
            lblPersenNilai.BackColor = Color.Transparent;
            lblPersenNilai.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            lblPersenNilai.ForeColor = Color.FromArgb(126, 87, 194);
            lblPersenNilai.Location = new Point(47, 62);
            lblPersenNilai.Margin = new Padding(6, 0, 6, 0);
            lblPersenNilai.Name = "lblPersenNilai";
            lblPersenNilai.Size = new Size(70, 48);
            lblPersenNilai.TabIndex = 1;
            lblPersenNilai.Text = "0%";
            // 
            // lblPersenJudul
            // 
            lblPersenJudul.AutoSize = true;
            lblPersenJudul.BackColor = Color.Transparent;
            lblPersenJudul.Font = new Font("Segoe UI", 9.5F);
            lblPersenJudul.ForeColor = Color.FromArgb(90, 110, 140);
            lblPersenJudul.Location = new Point(50, 27);
            lblPersenJudul.Margin = new Padding(6, 0, 6, 0);
            lblPersenJudul.Name = "lblPersenJudul";
            lblPersenJudul.Size = new Size(210, 25);
            lblPersenJudul.TabIndex = 2;
            lblPersenJudul.Text = "Persentase Keuntungan";
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
            pnlFilter.Controls.Add(cmbKelompok);
            pnlFilter.Controls.Add(btnTampilkan);
            pnlFilter.Location = new Point(0, 184);
            pnlFilter.Margin = new Padding(0, 0, 0, 23);
            pnlFilter.Name = "pnlFilter";
            pnlFilter.Padding = new Padding(33, 0, 33, 0);
            pnlFilter.Radius = 18;
            pnlFilter.Size = new Size(1779, 96);
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
            // cmbKelompok
            // 
            cmbKelompok.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbKelompok.Font = new Font("Segoe UI", 10F);
            cmbKelompok.FormattingEnabled = true;
            cmbKelompok.Items.AddRange(new object[] { "Per Tanggal", "Per Barang" });
            cmbKelompok.Location = new Point(877, 35);
            cmbKelompok.Margin = new Padding(0);
            cmbKelompok.Name = "cmbKelompok";
            cmbKelompok.Size = new Size(214, 36);
            cmbKelompok.TabIndex = 5;
            // 
            // btnTampilkan
            // 
            btnTampilkan.BackColor = Color.FromArgb(30, 136, 229);
            btnTampilkan.BorderColor = Color.Transparent;
            btnTampilkan.FlatStyle = FlatStyle.Flat;
            btnTampilkan.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            btnTampilkan.ForeColor = Color.White;
            btnTampilkan.HoverColor = Color.FromArgb(21, 101, 192);
            btnTampilkan.Location = new Point(1113, 23);
            btnTampilkan.Margin = new Padding(6, 5, 6, 5);
            btnTampilkan.Name = "btnTampilkan";
            btnTampilkan.Size = new Size(150, 48);
            btnTampilkan.TabIndex = 6;
            btnTampilkan.Text = "Tampilkan";
            btnTampilkan.UseVisualStyleBackColor = false;
            // 
            // tlpMain
            // 
            tlpMain.ColumnCount = 2;
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tlpMain.Controls.Add(pnlTabel, 0, 0);
            tlpMain.Controls.Add(pnlChart, 1, 0);
            tlpMain.Dock = DockStyle.Fill;
            tlpMain.Location = new Point(0, 303);
            tlpMain.Margin = new Padding(0);
            tlpMain.Name = "tlpMain";
            tlpMain.RowCount = 1;
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpMain.Size = new Size(1779, 1048);
            tlpMain.TabIndex = 2;
            // 
            // pnlTabel
            // 
            pnlTabel.AccentColor = Color.Transparent;
            pnlTabel.BackColor = Color.White;
            pnlTabel.BorderColor = Color.FromArgb(214, 228, 245);
            pnlTabel.Controls.Add(dgvLaba);
            pnlTabel.Controls.Add(lblTabelJudul);
            pnlTabel.Dock = DockStyle.Fill;
            pnlTabel.Location = new Point(0, 0);
            pnlTabel.Margin = new Padding(0, 0, 20, 0);
            pnlTabel.Name = "pnlTabel";
            pnlTabel.Padding = new Padding(33, 27, 33, 30);
            pnlTabel.Radius = 18;
            pnlTabel.Size = new Size(1047, 1048);
            pnlTabel.TabIndex = 0;
            // 
            // dgvLaba
            // 
            dgvLaba.AllowUserToAddRows = false;
            dgvLaba.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.Azure;
            dgvLaba.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvLaba.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLaba.BackgroundColor = Color.White;
            dgvLaba.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.RoyalBlue;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.AliceBlue;
            dataGridViewCellStyle2.SelectionBackColor = Color.AliceBlue;
            dataGridViewCellStyle2.SelectionForeColor = Color.RoyalBlue;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvLaba.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvLaba.ColumnHeadersHeight = 40;
            dgvLaba.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvLaba.Columns.AddRange(new DataGridViewColumn[] { colNo, colKelompok, colTransaksi, colPenjualan, colModal, colLaba, colMargin });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.AliceBlue;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.MediumBlue;
            dataGridViewCellStyle3.SelectionBackColor = Color.GhostWhite;
            dataGridViewCellStyle3.SelectionForeColor = Color.MidnightBlue;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvLaba.DefaultCellStyle = dataGridViewCellStyle3;
            dgvLaba.Dock = DockStyle.Fill;
            dgvLaba.EnableHeadersVisualStyles = false;
            dgvLaba.Location = new Point(33, 92);
            dgvLaba.Margin = new Padding(0);
            dgvLaba.MultiSelect = false;
            dgvLaba.Name = "dgvLaba";
            dgvLaba.ReadOnly = true;
            dgvLaba.RowHeadersVisible = false;
            dgvLaba.RowHeadersWidth = 62;
            dgvLaba.Size = new Size(981, 926);
            dgvLaba.TabIndex = 0;
            // 
            // colNo
            // 
            colNo.FillWeight = 6F;
            colNo.HeaderText = "No";
            colNo.MinimumWidth = 8;
            colNo.Name = "colNo";
            colNo.ReadOnly = true;
            // 
            // colKelompok
            // 
            colKelompok.FillWeight = 22F;
            colKelompok.HeaderText = "Tanggal";
            colKelompok.MinimumWidth = 8;
            colKelompok.Name = "colKelompok";
            colKelompok.ReadOnly = true;
            // 
            // colTransaksi
            // 
            colTransaksi.FillWeight = 11F;
            colTransaksi.HeaderText = "Transaksi";
            colTransaksi.MinimumWidth = 8;
            colTransaksi.Name = "colTransaksi";
            colTransaksi.ReadOnly = true;
            // 
            // colPenjualan
            // 
            colPenjualan.FillWeight = 20F;
            colPenjualan.HeaderText = "Penjualan";
            colPenjualan.MinimumWidth = 8;
            colPenjualan.Name = "colPenjualan";
            colPenjualan.ReadOnly = true;
            // 
            // colModal
            // 
            colModal.FillWeight = 19F;
            colModal.HeaderText = "Modal";
            colModal.MinimumWidth = 8;
            colModal.Name = "colModal";
            colModal.ReadOnly = true;
            // 
            // colLaba
            // 
            colLaba.FillWeight = 19F;
            colLaba.HeaderText = "Laba";
            colLaba.MinimumWidth = 8;
            colLaba.Name = "colLaba";
            colLaba.ReadOnly = true;
            // 
            // colMargin
            // 
            colMargin.FillWeight = 10F;
            colMargin.HeaderText = "Margin";
            colMargin.MinimumWidth = 8;
            colMargin.Name = "colMargin";
            colMargin.ReadOnly = true;
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
            lblTabelJudul.Size = new Size(981, 65);
            lblTabelJudul.TabIndex = 1;
            lblTabelJudul.Text = "Rincian Laba Penjualan";
            lblTabelJudul.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlChart
            // 
            pnlChart.AccentColor = Color.Transparent;
            pnlChart.BackColor = Color.White;
            pnlChart.BorderColor = Color.FromArgb(214, 228, 245);
            pnlChart.Controls.Add(lblTerbaik);
            pnlChart.Controls.Add(lblChartJudul);
            pnlChart.Dock = DockStyle.Fill;
            pnlChart.Location = new Point(1067, 0);
            pnlChart.Margin = new Padding(0);
            pnlChart.Name = "pnlChart";
            pnlChart.Padding = new Padding(33, 27, 33, 30);
            pnlChart.Radius = 18;
            pnlChart.Size = new Size(712, 1048);
            pnlChart.TabIndex = 1;
            // 
            // lblTerbaik
            // 
            lblTerbaik.BackColor = Color.Transparent;
            lblTerbaik.Dock = DockStyle.Bottom;
            lblTerbaik.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTerbaik.ForeColor = Color.FromArgb(40, 140, 90);
            lblTerbaik.Location = new Point(33, 948);
            lblTerbaik.Margin = new Padding(6, 0, 6, 0);
            lblTerbaik.Name = "lblTerbaik";
            lblTerbaik.Size = new Size(646, 70);
            lblTerbaik.TabIndex = 1;
            lblTerbaik.Text = "-";
            lblTerbaik.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblChartJudul
            // 
            lblChartJudul.BackColor = Color.Transparent;
            lblChartJudul.Dock = DockStyle.Top;
            lblChartJudul.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblChartJudul.ForeColor = Color.FromArgb(13, 47, 110);
            lblChartJudul.Location = new Point(33, 27);
            lblChartJudul.Margin = new Padding(6, 0, 6, 0);
            lblChartJudul.Name = "lblChartJudul";
            lblChartJudul.Size = new Size(646, 65);
            lblChartJudul.TabIndex = 2;
            lblChartJudul.Text = "Grafik Laba";
            lblChartJudul.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // UC_LaporanLaba
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(234, 243, 252);
            Controls.Add(tlpRoot);
            Margin = new Padding(6, 5, 6, 5);
            Name = "UC_LaporanLaba";
            Size = new Size(1833, 1538);
            tlpRoot.ResumeLayout(false);
            pnlJudul.ResumeLayout(false);
            pnlJudul.PerformLayout();
            tlpContent.ResumeLayout(false);
            tlpStats.ResumeLayout(false);
            cardJual.ResumeLayout(false);
            cardJual.PerformLayout();
            cardModal.ResumeLayout(false);
            cardModal.PerformLayout();
            cardLaba.ResumeLayout(false);
            cardLaba.PerformLayout();
            cardPersen.ResumeLayout(false);
            cardPersen.PerformLayout();
            pnlFilter.ResumeLayout(false);
            pnlFilter.PerformLayout();
            tlpMain.ResumeLayout(false);
            pnlTabel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvLaba).EndInit();
            pnlChart.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpRoot;
        private RoundedPanelUI pnlJudul;
        private System.Windows.Forms.Label lblSub;
        private System.Windows.Forms.Label lblJudul;
        private System.Windows.Forms.TableLayoutPanel tlpContent;
        private System.Windows.Forms.TableLayoutPanel tlpStats;
        private RoundedPanelUI cardJual;
        private System.Windows.Forms.Label lblJualKet;
        private System.Windows.Forms.Label lblJualNilai;
        private System.Windows.Forms.Label lblJualJudul;
        private RoundedPanelUI cardModal;
        private System.Windows.Forms.Label lblModalKet;
        private System.Windows.Forms.Label lblModalNilai;
        private System.Windows.Forms.Label lblModalJudul;
        private RoundedPanelUI cardLaba;
        private System.Windows.Forms.Label lblLabaKet;
        private System.Windows.Forms.Label lblLabaNilai;
        private System.Windows.Forms.Label lblLabaJudul;
        private RoundedPanelUI cardPersen;
        private System.Windows.Forms.Label lblPersenKet;
        private System.Windows.Forms.Label lblPersenNilai;
        private System.Windows.Forms.Label lblPersenJudul;
        private RoundedPanelUI pnlFilter;
        private System.Windows.Forms.ComboBox cmbRentang;
        private System.Windows.Forms.Label lblDari;
        private System.Windows.Forms.DateTimePicker dtpDari;
        private System.Windows.Forms.Label lblSampai;
        private System.Windows.Forms.DateTimePicker dtpSampai;
        private System.Windows.Forms.ComboBox cmbKelompok;
        private RoundedButtonUI btnTampilkan;
        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private RoundedPanelUI pnlTabel;
        private System.Windows.Forms.DataGridView dgvLaba;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKelompok;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTransaksi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPenjualan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colModal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLaba;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMargin;
        private System.Windows.Forms.Label lblTabelJudul;
        private RoundedPanelUI pnlChart;
        private MiniBarChartUI chartLaba;
        private System.Windows.Forms.Label lblTerbaik;
        private System.Windows.Forms.Label lblChartJudul;
    }
}