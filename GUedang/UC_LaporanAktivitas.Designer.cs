namespace GUedang
{
    partial class UC_LaporanAktivitas
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
            lblJam = new Label();
            lblTanggal = new Label();
            lblSub = new Label();
            lblJudul = new Label();
            tlpContent = new TableLayoutPanel();
            tlpStats = new TableLayoutPanel();
            cardTotal = new RoundedPanelUI();
            lblTotalKet = new Label();
            lblTotalNilai = new Label();
            lblTotalJudul = new Label();
            cardAdmin = new RoundedPanelUI();
            lblAdminKet = new Label();
            lblAdminNilai = new Label();
            lblAdminJudul = new Label();
            cardKasir = new RoundedPanelUI();
            lblKasirKet = new Label();
            lblKasirNilai = new Label();
            lblKasirJudul = new Label();
            cardGudang = new RoundedPanelUI();
            lblGudangKet = new Label();
            lblGudangNilai = new Label();
            lblGudangJudul = new Label();
            pnlFilter = new RoundedPanelUI();
            cmbPeran = new ComboBox();
            cmbPeriode = new ComboBox();
            dtpDari = new DateTimePicker();
            lblSampai = new Label();
            dtpSampai = new DateTimePicker();
            txtCari = new TextBox();
            btnBersihkan = new RoundedButtonUI();
            pnlTabel = new RoundedPanelUI();
            dgvLog = new DataGridView();
            colWaktu = new DataGridViewTextBoxColumn();
            colNama = new DataGridViewTextBoxColumn();
            colPeran = new DataGridViewTextBoxColumn();
            colAktivitas = new DataGridViewTextBoxColumn();
            lblTabelJudul = new Label();
            tlpRoot.SuspendLayout();
            pnlJudul.SuspendLayout();
            tlpContent.SuspendLayout();
            tlpStats.SuspendLayout();
            cardTotal.SuspendLayout();
            cardAdmin.SuspendLayout();
            cardKasir.SuspendLayout();
            cardGudang.SuspendLayout();
            pnlFilter.SuspendLayout();
            pnlTabel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLog).BeginInit();
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
            tlpRoot.RowStyles.Add(new RowStyle(SizeType.Absolute, 158F));
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
            pnlJudul.Controls.Add(lblJam);
            pnlJudul.Controls.Add(lblTanggal);
            pnlJudul.Controls.Add(lblSub);
            pnlJudul.Controls.Add(lblJudul);
            pnlJudul.Dock = DockStyle.Fill;
            pnlJudul.Location = new Point(27, 30);
            pnlJudul.Margin = new Padding(0, 0, 0, 23);
            pnlJudul.Name = "pnlJudul";
            pnlJudul.Radius = 18;
            pnlJudul.Size = new Size(1779, 135);
            pnlJudul.TabIndex = 0;
            // 
            // lblJam
            // 
            lblJam.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblJam.BackColor = Color.Transparent;
            lblJam.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            lblJam.ForeColor = Color.FromArgb(24, 94, 224);
            lblJam.Location = new Point(1281, 15);
            lblJam.Margin = new Padding(6, 0, 6, 0);
            lblJam.Name = "lblJam";
            lblJam.Size = new Size(450, 62);
            lblJam.TabIndex = 0;
            lblJam.Text = "00:00:00";
            lblJam.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblTanggal
            // 
            lblTanggal.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTanggal.BackColor = Color.Transparent;
            lblTanggal.Font = new Font("Segoe UI", 9F);
            lblTanggal.ForeColor = Color.FromArgb(90, 110, 140);
            lblTanggal.Location = new Point(1231, 80);
            lblTanggal.Margin = new Padding(6, 0, 6, 0);
            lblTanggal.Name = "lblTanggal";
            lblTanggal.Size = new Size(500, 38);
            lblTanggal.TabIndex = 1;
            lblTanggal.Text = "Sabtu, 21 November 2026";
            lblTanggal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblSub
            // 
            lblSub.AutoSize = true;
            lblSub.BackColor = Color.Transparent;
            lblSub.Font = new Font("Segoe UI", 9.5F);
            lblSub.ForeColor = Color.FromArgb(90, 110, 140);
            lblSub.Location = new Point(40, 85);
            lblSub.Margin = new Padding(6, 0, 6, 0);
            lblSub.Name = "lblSub";
            lblSub.Size = new Size(363, 25);
            lblSub.TabIndex = 2;
            lblSub.Text = "Catatan aktivitas semua pengguna sistem.";
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
            lblJudul.Size = new Size(208, 45);
            lblJudul.TabIndex = 3;
            lblJudul.Text = "Log Aktivitas";
            // 
            // tlpContent
            // 
            tlpContent.ColumnCount = 1;
            tlpContent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpContent.Controls.Add(tlpStats, 0, 0);
            tlpContent.Controls.Add(pnlFilter, 0, 1);
            tlpContent.Controls.Add(pnlTabel, 0, 2);
            tlpContent.Dock = DockStyle.Fill;
            tlpContent.Location = new Point(27, 188);
            tlpContent.Margin = new Padding(0);
            tlpContent.Name = "tlpContent";
            tlpContent.RowCount = 3;
            tlpContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 151F));
            tlpContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 146F));
            tlpContent.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpContent.Size = new Size(1779, 1320);
            tlpContent.TabIndex = 1;
            
            // 
            // tlpStats
            // 
            tlpStats.ColumnCount = 4;
            tlpStats.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpStats.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpStats.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpStats.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpStats.Controls.Add(cardTotal, 0, 0);
            tlpStats.Controls.Add(cardAdmin, 1, 0);
            tlpStats.Controls.Add(cardKasir, 2, 0);
            tlpStats.Controls.Add(cardGudang, 3, 0);
            tlpStats.Location = new Point(0, 0);
            tlpStats.Margin = new Padding(0, 0, 0, 23);
            tlpStats.Name = "tlpStats";
            tlpStats.RowCount = 1;
            tlpStats.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpStats.Size = new Size(1779, 128);
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
            cardTotal.Margin = new Padding(0, 0, 20, 0);
            cardTotal.Name = "cardTotal";
            cardTotal.Radius = 18;
            cardTotal.Size = new Size(424, 128);
            cardTotal.TabIndex = 0;
            // 
            // lblTotalKet
            // 
            lblTotalKet.AutoSize = true;
            lblTotalKet.BackColor = Color.Transparent;
            lblTotalKet.Font = new Font("Segoe UI", 8.5F);
            lblTotalKet.ForeColor = Color.FromArgb(120, 135, 160);
            lblTotalKet.Location = new Point(50, 101);
            lblTotalKet.Margin = new Padding(6, 0, 6, 0);
            lblTotalKet.Name = "lblTotalKet";
            lblTotalKet.Size = new Size(97, 23);
            lblTotalKet.TabIndex = 0;
            lblTotalKet.Text = "Sesuai filter";
            // 
            // lblTotalNilai
            // 
            lblTotalNilai.AutoSize = true;
            lblTotalNilai.BackColor = Color.Transparent;
            lblTotalNilai.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            lblTotalNilai.ForeColor = Color.FromArgb(24, 94, 224);
            lblTotalNilai.Location = new Point(59, 52);
            lblTotalNilai.Margin = new Padding(6, 0, 6, 0);
            lblTotalNilai.Name = "lblTotalNilai";
            lblTotalNilai.Size = new Size(40, 48);
            lblTotalNilai.TabIndex = 1;
            lblTotalNilai.Text = "0";
            // 
            // lblTotalJudul
            // 
            lblTotalJudul.AutoSize = true;
            lblTotalJudul.BackColor = Color.Transparent;
            lblTotalJudul.Font = new Font("Segoe UI", 9.5F);
            lblTotalJudul.ForeColor = Color.FromArgb(90, 110, 140);
            lblTotalJudul.Location = new Point(50, 27);
            lblTotalJudul.Margin = new Padding(6, 0, 6, 0);
            lblTotalJudul.Name = "lblTotalJudul";
            lblTotalJudul.Size = new Size(127, 25);
            lblTotalJudul.TabIndex = 2;
            lblTotalJudul.Text = "Total Aktivitas";
            // 
            // cardAdmin
            // 
            cardAdmin.AccentColor = Color.FromArgb(126, 87, 194);
            cardAdmin.BackColor = Color.White;
            cardAdmin.BorderColor = Color.FromArgb(214, 228, 245);
            cardAdmin.Controls.Add(lblAdminKet);
            cardAdmin.Controls.Add(lblAdminNilai);
            cardAdmin.Controls.Add(lblAdminJudul);
            cardAdmin.Dock = DockStyle.Fill;
            cardAdmin.Location = new Point(444, 0);
            cardAdmin.Margin = new Padding(0, 0, 20, 0);
            cardAdmin.Name = "cardAdmin";
            cardAdmin.Radius = 18;
            cardAdmin.Size = new Size(424, 128);
            cardAdmin.TabIndex = 1;
            // 
            // lblAdminKet
            // 
            lblAdminKet.AutoSize = true;
            lblAdminKet.BackColor = Color.Transparent;
            lblAdminKet.Font = new Font("Segoe UI", 8.5F);
            lblAdminKet.ForeColor = Color.FromArgb(120, 135, 160);
            lblAdminKet.Location = new Point(50, 101);
            lblAdminKet.Margin = new Padding(6, 0, 6, 0);
            lblAdminKet.Name = "lblAdminKet";
            lblAdminKet.Size = new Size(126, 23);
            lblAdminKet.TabIndex = 0;
            lblAdminKet.Text = "Aktivitas admin";
            // 
            // lblAdminNilai
            // 
            lblAdminNilai.AutoSize = true;
            lblAdminNilai.BackColor = Color.Transparent;
            lblAdminNilai.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            lblAdminNilai.ForeColor = Color.FromArgb(126, 87, 194);
            lblAdminNilai.Location = new Point(50, 52);
            lblAdminNilai.Margin = new Padding(6, 0, 6, 0);
            lblAdminNilai.Name = "lblAdminNilai";
            lblAdminNilai.Size = new Size(40, 48);
            lblAdminNilai.TabIndex = 1;
            lblAdminNilai.Text = "0";
            // 
            // lblAdminJudul
            // 
            lblAdminJudul.AutoSize = true;
            lblAdminJudul.BackColor = Color.Transparent;
            lblAdminJudul.Font = new Font("Segoe UI", 9.5F);
            lblAdminJudul.ForeColor = Color.FromArgb(90, 110, 140);
            lblAdminJudul.Location = new Point(50, 27);
            lblAdminJudul.Margin = new Padding(6, 0, 6, 0);
            lblAdminJudul.Name = "lblAdminJudul";
            lblAdminJudul.Size = new Size(67, 25);
            lblAdminJudul.TabIndex = 2;
            lblAdminJudul.Text = "Admin";
            // 
            // cardKasir
            // 
            cardKasir.AccentColor = Color.FromArgb(46, 160, 100);
            cardKasir.BackColor = Color.White;
            cardKasir.BorderColor = Color.FromArgb(214, 228, 245);
            cardKasir.Controls.Add(lblKasirKet);
            cardKasir.Controls.Add(lblKasirNilai);
            cardKasir.Controls.Add(lblKasirJudul);
            cardKasir.Dock = DockStyle.Fill;
            cardKasir.Location = new Point(888, 0);
            cardKasir.Margin = new Padding(0, 0, 20, 0);
            cardKasir.Name = "cardKasir";
            cardKasir.Radius = 18;
            cardKasir.Size = new Size(424, 128);
            cardKasir.TabIndex = 2;
            // 
            // lblKasirKet
            // 
            lblKasirKet.AutoSize = true;
            lblKasirKet.BackColor = Color.Transparent;
            lblKasirKet.Font = new Font("Segoe UI", 8.5F);
            lblKasirKet.ForeColor = Color.FromArgb(120, 135, 160);
            lblKasirKet.Location = new Point(50, 101);
            lblKasirKet.Margin = new Padding(6, 0, 6, 0);
            lblKasirKet.Name = "lblKasirKet";
            lblKasirKet.Size = new Size(112, 23);
            lblKasirKet.TabIndex = 0;
            lblKasirKet.Text = "Aktivitas kasir";
            // 
            // lblKasirNilai
            // 
            lblKasirNilai.AutoSize = true;
            lblKasirNilai.BackColor = Color.Transparent;
            lblKasirNilai.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            lblKasirNilai.ForeColor = Color.FromArgb(40, 140, 90);
            lblKasirNilai.Location = new Point(50, 52);
            lblKasirNilai.Margin = new Padding(6, 0, 6, 0);
            lblKasirNilai.Name = "lblKasirNilai";
            lblKasirNilai.Size = new Size(40, 48);
            lblKasirNilai.TabIndex = 1;
            lblKasirNilai.Text = "0";
            // 
            // lblKasirJudul
            // 
            lblKasirJudul.AutoSize = true;
            lblKasirJudul.BackColor = Color.Transparent;
            lblKasirJudul.Font = new Font("Segoe UI", 9.5F);
            lblKasirJudul.ForeColor = Color.FromArgb(90, 110, 140);
            lblKasirJudul.Location = new Point(50, 27);
            lblKasirJudul.Margin = new Padding(6, 0, 6, 0);
            lblKasirJudul.Name = "lblKasirJudul";
            lblKasirJudul.Size = new Size(53, 25);
            lblKasirJudul.TabIndex = 2;
            lblKasirJudul.Text = "Kasir";
            // 
            // cardGudang
            // 
            cardGudang.AccentColor = Color.FromArgb(0, 172, 193);
            cardGudang.BackColor = Color.White;
            cardGudang.BorderColor = Color.FromArgb(214, 228, 245);
            cardGudang.Controls.Add(lblGudangKet);
            cardGudang.Controls.Add(lblGudangNilai);
            cardGudang.Controls.Add(lblGudangJudul);
            cardGudang.Dock = DockStyle.Fill;
            cardGudang.Location = new Point(1332, 0);
            cardGudang.Margin = new Padding(0);
            cardGudang.Name = "cardGudang";
            cardGudang.Radius = 18;
            cardGudang.Size = new Size(447, 128);
            cardGudang.TabIndex = 3;
            // 
            // lblGudangKet
            // 
            lblGudangKet.AutoSize = true;
            lblGudangKet.BackColor = Color.Transparent;
            lblGudangKet.Font = new Font("Segoe UI", 8.5F);
            lblGudangKet.ForeColor = Color.FromArgb(120, 135, 160);
            lblGudangKet.Location = new Point(50, 101);
            lblGudangKet.Margin = new Padding(6, 0, 6, 0);
            lblGudangKet.Name = "lblGudangKet";
            lblGudangKet.Size = new Size(137, 23);
            lblGudangKet.TabIndex = 0;
            lblGudangKet.Text = "Aktivitas gudang";
            // 
            // lblGudangNilai
            // 
            lblGudangNilai.AutoSize = true;
            lblGudangNilai.BackColor = Color.Transparent;
            lblGudangNilai.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            lblGudangNilai.ForeColor = Color.FromArgb(0, 150, 170);
            lblGudangNilai.Location = new Point(50, 52);
            lblGudangNilai.Margin = new Padding(6, 0, 6, 0);
            lblGudangNilai.Name = "lblGudangNilai";
            lblGudangNilai.Size = new Size(40, 48);
            lblGudangNilai.TabIndex = 1;
            lblGudangNilai.Text = "0";
            // 
            // lblGudangJudul
            // 
            lblGudangJudul.AutoSize = true;
            lblGudangJudul.BackColor = Color.Transparent;
            lblGudangJudul.Font = new Font("Segoe UI", 9.5F);
            lblGudangJudul.ForeColor = Color.FromArgb(90, 110, 140);
            lblGudangJudul.Location = new Point(50, 27);
            lblGudangJudul.Margin = new Padding(6, 0, 6, 0);
            lblGudangJudul.Name = "lblGudangJudul";
            lblGudangJudul.Size = new Size(79, 25);
            lblGudangJudul.TabIndex = 2;
            lblGudangJudul.Text = "Gudang";
            // 
            // pnlFilter
            // 
            pnlFilter.AccentColor = Color.Transparent;
            pnlFilter.BackColor = Color.White;
            pnlFilter.BorderColor = Color.FromArgb(214, 228, 245);
            pnlFilter.Controls.Add(cmbPeran);
            pnlFilter.Controls.Add(cmbPeriode);
            pnlFilter.Controls.Add(dtpDari);
            pnlFilter.Controls.Add(lblSampai);
            pnlFilter.Controls.Add(dtpSampai);
            pnlFilter.Controls.Add(txtCari);
            pnlFilter.Controls.Add(btnBersihkan);
            pnlFilter.Location = new Point(0, 151);
            pnlFilter.Margin = new Padding(0, 0, 0, 23);
            pnlFilter.Name = "pnlFilter";
            pnlFilter.Padding = new Padding(33, 0, 33, 0);
            pnlFilter.Radius = 18;
            pnlFilter.Size = new Size(1779, 123);
            pnlFilter.TabIndex = 1;
            // 
            // cmbPeran
            // 
            cmbPeran.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPeran.Font = new Font("Segoe UI", 10F);
            cmbPeran.FormattingEnabled = true;
            cmbPeran.Items.AddRange(new object[] { "Semua peran", "Admin", "Kasir", "Gudang" });
            cmbPeran.Location = new Point(33, 35);
            cmbPeran.Margin = new Padding(0);
            cmbPeran.Name = "cmbPeran";
            cmbPeran.Size = new Size(231, 36);
            cmbPeran.TabIndex = 0;
            // 
            // cmbPeriode
            // 
            cmbPeriode.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPeriode.Font = new Font("Segoe UI", 10F);
            cmbPeriode.FormattingEnabled = true;
            cmbPeriode.Items.AddRange(new object[] { "Hari ini", "7 hari terakhir", "30 hari terakhir", "Semua", "Pilih tanggal" });
            cmbPeriode.Location = new Point(287, 35);
            cmbPeriode.Margin = new Padding(0);
            cmbPeriode.Name = "cmbPeriode";
            cmbPeriode.Size = new Size(247, 36);
            cmbPeriode.TabIndex = 1;
            // 
            // dtpDari
            // 
            dtpDari.Font = new Font("Segoe UI", 9.5F);
            dtpDari.Format = DateTimePickerFormat.Short;
            dtpDari.Location = new Point(557, 35);
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
            lblSampai.Location = new Point(770, 42);
            lblSampai.Margin = new Padding(6, 0, 6, 0);
            lblSampai.Name = "lblSampai";
            lblSampai.Size = new Size(38, 25);
            lblSampai.TabIndex = 3;
            lblSampai.Text = "s/d";
            // 
            // dtpSampai
            // 
            dtpSampai.Font = new Font("Segoe UI", 9.5F);
            dtpSampai.Format = DateTimePickerFormat.Short;
            dtpSampai.Location = new Point(813, 35);
            dtpSampai.Margin = new Padding(6, 5, 6, 5);
            dtpSampai.Name = "dtpSampai";
            dtpSampai.Size = new Size(197, 33);
            dtpSampai.TabIndex = 4;
            // 
            // txtCari
            // 
            txtCari.Font = new Font("Segoe UI", 10F);
            txtCari.Location = new Point(1033, 35);
            txtCari.Margin = new Padding(0);
            txtCari.Name = "txtCari";
            txtCari.PlaceholderText = "Cari nama / aktivitas...";
            txtCari.Size = new Size(297, 34);
            txtCari.TabIndex = 5;
            // 
            // btnBersihkan
            // 
            btnBersihkan.BackColor = Color.White;
            btnBersihkan.BorderColor = Color.FromArgb(214, 69, 65);
            btnBersihkan.FlatStyle = FlatStyle.Flat;
            btnBersihkan.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            btnBersihkan.ForeColor = Color.FromArgb(214, 69, 65);
            btnBersihkan.HoverColor = Color.FromArgb(253, 236, 235);
            btnBersihkan.Location = new Point(1353, 23);
            btnBersihkan.Margin = new Padding(6, 5, 6, 5);
            btnBersihkan.Name = "btnBersihkan";
            btnBersihkan.Size = new Size(200, 70);
            btnBersihkan.TabIndex = 6;
            btnBersihkan.Text = "Bersihkan Log";
            btnBersihkan.UseVisualStyleBackColor = false;
            // 
            // pnlTabel
            // 
            pnlTabel.AccentColor = Color.Transparent;
            pnlTabel.BackColor = Color.White;
            pnlTabel.BorderColor = Color.FromArgb(214, 228, 245);
            pnlTabel.Controls.Add(dgvLog);
            pnlTabel.Controls.Add(lblTabelJudul);
            pnlTabel.Dock = DockStyle.Fill;
            pnlTabel.Location = new Point(0, 297);
            pnlTabel.Margin = new Padding(0);
            pnlTabel.Name = "pnlTabel";
            pnlTabel.Padding = new Padding(33, 27, 33, 30);
            pnlTabel.Radius = 18;
            pnlTabel.Size = new Size(1779, 1023);
            pnlTabel.TabIndex = 2;
            // 
            // dgvLog
            // 
            dgvLog.AllowUserToAddRows = false;
            dgvLog.AllowUserToDeleteRows = false;
            dgvLog.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLog.BackgroundColor = Color.White;
            dgvLog.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.AliceBlue;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.RoyalBlue;
            dataGridViewCellStyle1.SelectionBackColor = Color.RoyalBlue;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvLog.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvLog.ColumnHeadersHeight = 40;
            dgvLog.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.SlateGray;
            dataGridViewCellStyle2.SelectionBackColor = Color.AliceBlue;
            dataGridViewCellStyle2.SelectionForeColor = Color.MidnightBlue;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvLog.DefaultCellStyle = dataGridViewCellStyle2;
            dgvLog.Dock = DockStyle.Fill;
            dgvLog.EnableHeadersVisualStyles = false;
            dgvLog.Location = new Point(33, 92);
            dgvLog.Margin = new Padding(0);
            dgvLog.MultiSelect = false;
            dgvLog.Name = "dgvLog";
            dgvLog.ReadOnly = true;
            dgvLog.RowHeadersVisible = false;
            dgvLog.RowHeadersWidth = 62;
            dgvLog.RowTemplate.Height = 38;
            dgvLog.Size = new Size(1713, 901);
            dgvLog.TabIndex = 0;
            // 
            // colWaktu
            // 
            colWaktu.FillWeight = 20F;
            colWaktu.HeaderText = "Waktu";
            colWaktu.MinimumWidth = 8;
            colWaktu.Name = "colWaktu";
            colWaktu.ReadOnly = true;
            // 
            // colNama
            // 
            colNama.FillWeight = 22F;
            colNama.HeaderText = "Nama";
            colNama.MinimumWidth = 8;
            colNama.Name = "colNama";
            colNama.ReadOnly = true;
            // 
            // colPeran
            // 
            colPeran.FillWeight = 14F;
            colPeran.HeaderText = "Peran";
            colPeran.MinimumWidth = 8;
            colPeran.Name = "colPeran";
            colPeran.ReadOnly = true;
            // 
            // colAktivitas
            // 
            colAktivitas.FillWeight = 44F;
            colAktivitas.HeaderText = "Aktivitas";
            colAktivitas.MinimumWidth = 8;
            colAktivitas.Name = "colAktivitas";
            colAktivitas.ReadOnly = true;
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
            lblTabelJudul.Text = "Daftar Aktivitas";
            lblTabelJudul.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // UC_LaporanAktivitas
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(234, 243, 252);
            Controls.Add(tlpRoot);
            Margin = new Padding(6, 5, 6, 5);
            Name = "UC_LaporanAktivitas";
            Size = new Size(1833, 1538);
            tlpRoot.ResumeLayout(false);
            pnlJudul.ResumeLayout(false);
            pnlJudul.PerformLayout();
            tlpContent.ResumeLayout(false);
            tlpStats.ResumeLayout(false);
            cardTotal.ResumeLayout(false);
            cardTotal.PerformLayout();
            cardAdmin.ResumeLayout(false);
            cardAdmin.PerformLayout();
            cardKasir.ResumeLayout(false);
            cardKasir.PerformLayout();
            cardGudang.ResumeLayout(false);
            cardGudang.PerformLayout();
            pnlFilter.ResumeLayout(false);
            pnlFilter.PerformLayout();
            pnlTabel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvLog).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpRoot;
        private RoundedPanelUI pnlJudul;
        private System.Windows.Forms.Label lblJam;
        private System.Windows.Forms.Label lblTanggal;
        private System.Windows.Forms.Label lblSub;
        private System.Windows.Forms.Label lblJudul;
        private System.Windows.Forms.TableLayoutPanel tlpContent;
        private System.Windows.Forms.TableLayoutPanel tlpStats;
        private RoundedPanelUI cardTotal;
        private System.Windows.Forms.Label lblTotalKet;
        private System.Windows.Forms.Label lblTotalNilai;
        private System.Windows.Forms.Label lblTotalJudul;
        private RoundedPanelUI cardAdmin;
        private System.Windows.Forms.Label lblAdminKet;
        private System.Windows.Forms.Label lblAdminNilai;
        private System.Windows.Forms.Label lblAdminJudul;
        private RoundedPanelUI cardKasir;
        private System.Windows.Forms.Label lblKasirKet;
        private System.Windows.Forms.Label lblKasirNilai;
        private System.Windows.Forms.Label lblKasirJudul;
        private RoundedPanelUI cardGudang;
        private System.Windows.Forms.Label lblGudangKet;
        private System.Windows.Forms.Label lblGudangNilai;
        private System.Windows.Forms.Label lblGudangJudul;
        private RoundedPanelUI pnlFilter;
        private System.Windows.Forms.ComboBox cmbPeran;
        private System.Windows.Forms.ComboBox cmbPeriode;
        private System.Windows.Forms.DateTimePicker dtpDari;
        private System.Windows.Forms.Label lblSampai;
        private System.Windows.Forms.DateTimePicker dtpSampai;
        private System.Windows.Forms.TextBox txtCari;
        private RoundedButtonUI btnBersihkan;
        private RoundedPanelUI pnlTabel;
        private System.Windows.Forms.DataGridView dgvLog;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWaktu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNama;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPeran;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAktivitas;
        private System.Windows.Forms.Label lblTabelJudul;
    }
}