namespace GUedang
{
    partial class UC_User
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
            tlpStats = new TableLayoutPanel();
            cardTotal = new RoundedPanelUI();
            lblTotalKet = new Label();
            lblTotalNilai = new Label();
            lblTotalJudul = new Label();
            cardKasir = new RoundedPanelUI();
            lblKasirKet = new Label();
            lblKasirNilai = new Label();
            lblKasirJudul = new Label();
            cardGudang = new RoundedPanelUI();
            lblGudangKet = new Label();
            lblGudangNilai = new Label();
            lblGudangJudul = new Label();
            cardNonaktif = new RoundedPanelUI();
            lblNonaktifKet = new Label();
            lblNonaktifNilai = new Label();
            lblNonaktifJudul = new Label();
            tlpMain = new TableLayoutPanel();
            pnlDaftar = new RoundedPanelUI();
            tlpDaftar = new TableLayoutPanel();
            tlpToolbar = new TableLayoutPanel();
            lblDaftarJudul = new Label();
            txtCari = new TextBox();
            cmbFilterJenis = new ComboBox();
            dgvUser = new DataGridView();
            colNo = new DataGridViewTextBoxColumn();
            colNama = new DataGridViewTextBoxColumn();
            colJenis = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            colDibuat = new DataGridViewTextBoxColumn();
            colAksi = new DataGridViewButtonColumn();
            tlpKanan = new TableLayoutPanel();
            pnlTambah = new RoundedPanelUI();
            tlpTambah = new TableLayoutPanel();
            lblNama = new Label();
            lblJenis = new Label();
            flowTambah = new FlowLayoutPanel();
            btnTambah = new RoundedButtonUI();
            btnResetTambah = new RoundedButtonUI();
            ChkBox1 = new CheckBox();
            txtNama = new TextBox();
            cmbJenis = new ComboBox();
            txtPass = new TextBox();
            lblPass = new Label();
            lblTambahJudul = new Label();
            pnlKelola = new RoundedPanelUI();
            tlpKelola = new TableLayoutPanel();
            lblTerpilih = new Label();
            lblLama = new Label();
            lblBaru = new Label();
            txtLama = new TextBox();
            txtBaru = new TextBox();
            flowGanti = new FlowLayoutPanel();
            btnGanti = new RoundedButtonUI();
            btnBatalGanti = new RoundedButtonUI();
            flowAksi = new FlowLayoutPanel();
            btnResetPw = new RoundedButtonUI();
            btnStatus = new RoundedButtonUI();
            btnHapus = new RoundedButtonUI();
            lblKelolaJudul = new Label();
            tlpRoot.SuspendLayout();
            pnlJudul.SuspendLayout();
            tlpContent.SuspendLayout();
            tlpStats.SuspendLayout();
            cardTotal.SuspendLayout();
            cardKasir.SuspendLayout();
            cardGudang.SuspendLayout();
            cardNonaktif.SuspendLayout();
            tlpMain.SuspendLayout();
            pnlDaftar.SuspendLayout();
            tlpDaftar.SuspendLayout();
            tlpToolbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUser).BeginInit();
            tlpKanan.SuspendLayout();
            pnlTambah.SuspendLayout();
            tlpTambah.SuspendLayout();
            flowTambah.SuspendLayout();
            pnlKelola.SuspendLayout();
            tlpKelola.SuspendLayout();
            flowGanti.SuspendLayout();
            flowAksi.SuspendLayout();
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
            tlpRoot.RowStyles.Add(new RowStyle(SizeType.Absolute, 69F));
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
            pnlJudul.Location = new Point(19, 18);
            pnlJudul.Margin = new Padding(0, 0, 0, 14);
            pnlJudul.Name = "pnlJudul";
            pnlJudul.Radius = 18;
            pnlJudul.Size = new Size(1245, 55);
            pnlJudul.TabIndex = 0;
            // 
            // lblSub
            // 
            lblSub.AutoSize = true;
            lblSub.BackColor = Color.Transparent;
            lblSub.Font = new Font("Segoe UI", 9.5F);
            lblSub.ForeColor = Color.FromArgb(90, 110, 140);
            lblSub.Location = new Point(34, 36);
            lblSub.Margin = new Padding(4, 0, 4, 0);
            lblSub.Name = "lblSub";
            lblSub.Size = new Size(384, 17);
            lblSub.TabIndex = 0;
            lblSub.Text = "Tambah, nonaktifkan, dan kelola akun Admin, Kasir, dan Gudang.";
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
            lblJudul.Size = new Size(180, 30);
            lblJudul.TabIndex = 1;
            lblJudul.Text = "Kelola Pengguna";
            // 
            // tlpContent
            // 
            tlpContent.ColumnCount = 1;
            tlpContent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpContent.Controls.Add(tlpStats, 0, 0);
            tlpContent.Controls.Add(tlpMain, 0, 1);
            tlpContent.Dock = DockStyle.Fill;
            tlpContent.Location = new Point(19, 87);
            tlpContent.Margin = new Padding(0);
            tlpContent.Name = "tlpContent";
            tlpContent.RowCount = 2;
            tlpContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tlpContent.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpContent.Size = new Size(1245, 818);
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
            tlpStats.Controls.Add(cardKasir, 1, 0);
            tlpStats.Controls.Add(cardGudang, 2, 0);
            tlpStats.Controls.Add(cardNonaktif, 3, 0);
            tlpStats.Location = new Point(0, 0);
            tlpStats.Margin = new Padding(0, 0, 0, 14);
            tlpStats.Name = "tlpStats";
            tlpStats.RowCount = 1;
            tlpStats.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpStats.Size = new Size(1245, 66);
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
            cardTotal.Size = new Size(297, 66);
            cardTotal.TabIndex = 0;
            // 
            // lblTotalKet
            // 
            lblTotalKet.AutoSize = true;
            lblTotalKet.BackColor = Color.Transparent;
            lblTotalKet.Font = new Font("Segoe UI", 8.5F);
            lblTotalKet.ForeColor = Color.FromArgb(120, 135, 160);
            lblTotalKet.Location = new Point(71, 44);
            lblTotalKet.Margin = new Padding(4, 0, 4, 0);
            lblTotalKet.Name = "lblTotalKet";
            lblTotalKet.Size = new Size(72, 15);
            lblTotalKet.TabIndex = 0;
            lblTotalKet.Text = "Semua akun";
            // 
            // lblTotalNilai
            // 
            lblTotalNilai.AutoSize = true;
            lblTotalNilai.BackColor = Color.Transparent;
            lblTotalNilai.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            lblTotalNilai.ForeColor = Color.FromArgb(24, 94, 224);
            lblTotalNilai.Location = new Point(35, 31);
            lblTotalNilai.Margin = new Padding(4, 0, 4, 0);
            lblTotalNilai.Name = "lblTotalNilai";
            lblTotalNilai.Size = new Size(27, 32);
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
            lblTotalJudul.Size = new Size(98, 17);
            lblTotalJudul.TabIndex = 2;
            lblTotalJudul.Text = "Total Pengguna";
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
            cardKasir.Location = new Point(311, 0);
            cardKasir.Margin = new Padding(0, 0, 14, 0);
            cardKasir.Name = "cardKasir";
            cardKasir.Radius = 18;
            cardKasir.Size = new Size(297, 66);
            cardKasir.TabIndex = 1;
            // 
            // lblKasirKet
            // 
            lblKasirKet.AutoSize = true;
            lblKasirKet.BackColor = Color.Transparent;
            lblKasirKet.Font = new Font("Segoe UI", 8.5F);
            lblKasirKet.ForeColor = Color.FromArgb(120, 135, 160);
            lblKasirKet.Location = new Point(61, 46);
            lblKasirKet.Margin = new Padding(4, 0, 4, 0);
            lblKasirKet.Name = "lblKasirKet";
            lblKasirKet.Size = new Size(76, 15);
            lblKasirKet.TabIndex = 0;
            lblKasirKet.Text = "Petugas kasir";
            // 
            // lblKasirNilai
            // 
            lblKasirNilai.AutoSize = true;
            lblKasirNilai.BackColor = Color.Transparent;
            lblKasirNilai.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            lblKasirNilai.ForeColor = Color.FromArgb(40, 140, 90);
            lblKasirNilai.Location = new Point(35, 31);
            lblKasirNilai.Margin = new Padding(4, 0, 4, 0);
            lblKasirNilai.Name = "lblKasirNilai";
            lblKasirNilai.Size = new Size(27, 32);
            lblKasirNilai.TabIndex = 1;
            lblKasirNilai.Text = "0";
            // 
            // lblKasirJudul
            // 
            lblKasirJudul.AutoSize = true;
            lblKasirJudul.BackColor = Color.Transparent;
            lblKasirJudul.Font = new Font("Segoe UI", 9.5F);
            lblKasirJudul.ForeColor = Color.FromArgb(90, 110, 140);
            lblKasirJudul.Location = new Point(35, 16);
            lblKasirJudul.Margin = new Padding(4, 0, 4, 0);
            lblKasirJudul.Name = "lblKasirJudul";
            lblKasirJudul.Size = new Size(37, 17);
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
            cardGudang.Location = new Point(622, 0);
            cardGudang.Margin = new Padding(0, 0, 14, 0);
            cardGudang.Name = "cardGudang";
            cardGudang.Radius = 18;
            cardGudang.Size = new Size(297, 66);
            cardGudang.TabIndex = 2;
            // 
            // lblGudangKet
            // 
            lblGudangKet.AutoSize = true;
            lblGudangKet.BackColor = Color.Transparent;
            lblGudangKet.Font = new Font("Segoe UI", 8.5F);
            lblGudangKet.ForeColor = Color.FromArgb(120, 135, 160);
            lblGudangKet.Location = new Point(71, 44);
            lblGudangKet.Margin = new Padding(4, 0, 4, 0);
            lblGudangKet.Name = "lblGudangKet";
            lblGudangKet.Size = new Size(93, 15);
            lblGudangKet.TabIndex = 0;
            lblGudangKet.Text = "Petugas gudang";
            // 
            // lblGudangNilai
            // 
            lblGudangNilai.AutoSize = true;
            lblGudangNilai.BackColor = Color.Transparent;
            lblGudangNilai.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            lblGudangNilai.ForeColor = Color.FromArgb(0, 150, 170);
            lblGudangNilai.Location = new Point(35, 31);
            lblGudangNilai.Margin = new Padding(4, 0, 4, 0);
            lblGudangNilai.Name = "lblGudangNilai";
            lblGudangNilai.Size = new Size(27, 32);
            lblGudangNilai.TabIndex = 1;
            lblGudangNilai.Text = "0";
            // 
            // lblGudangJudul
            // 
            lblGudangJudul.AutoSize = true;
            lblGudangJudul.BackColor = Color.Transparent;
            lblGudangJudul.Font = new Font("Segoe UI", 9.5F);
            lblGudangJudul.ForeColor = Color.FromArgb(90, 110, 140);
            lblGudangJudul.Location = new Point(35, 16);
            lblGudangJudul.Margin = new Padding(4, 0, 4, 0);
            lblGudangJudul.Name = "lblGudangJudul";
            lblGudangJudul.Size = new Size(54, 17);
            lblGudangJudul.TabIndex = 2;
            lblGudangJudul.Text = "Gudang";
            // 
            // cardNonaktif
            // 
            cardNonaktif.AccentColor = Color.FromArgb(214, 69, 65);
            cardNonaktif.BackColor = Color.White;
            cardNonaktif.BorderColor = Color.FromArgb(214, 228, 245);
            cardNonaktif.Controls.Add(lblNonaktifKet);
            cardNonaktif.Controls.Add(lblNonaktifNilai);
            cardNonaktif.Controls.Add(lblNonaktifJudul);
            cardNonaktif.Dock = DockStyle.Fill;
            cardNonaktif.Location = new Point(933, 0);
            cardNonaktif.Margin = new Padding(0);
            cardNonaktif.Name = "cardNonaktif";
            cardNonaktif.Radius = 18;
            cardNonaktif.Size = new Size(312, 66);
            cardNonaktif.TabIndex = 3;
            // 
            // lblNonaktifKet
            // 
            lblNonaktifKet.AutoSize = true;
            lblNonaktifKet.BackColor = Color.Transparent;
            lblNonaktifKet.Font = new Font("Segoe UI", 8.5F);
            lblNonaktifKet.ForeColor = Color.FromArgb(120, 135, 160);
            lblNonaktifKet.Location = new Point(69, 44);
            lblNonaktifKet.Margin = new Padding(4, 0, 4, 0);
            lblNonaktifKet.Name = "lblNonaktifKet";
            lblNonaktifKet.Size = new Size(89, 15);
            lblNonaktifKet.TabIndex = 0;
            lblNonaktifKet.Text = "Tidak bisa login";
            // 
            // lblNonaktifNilai
            // 
            lblNonaktifNilai.AutoSize = true;
            lblNonaktifNilai.BackColor = Color.Transparent;
            lblNonaktifNilai.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            lblNonaktifNilai.ForeColor = Color.FromArgb(210, 50, 50);
            lblNonaktifNilai.Location = new Point(33, 34);
            lblNonaktifNilai.Margin = new Padding(4, 0, 4, 0);
            lblNonaktifNilai.Name = "lblNonaktifNilai";
            lblNonaktifNilai.Size = new Size(27, 32);
            lblNonaktifNilai.TabIndex = 1;
            lblNonaktifNilai.Text = "0";
            // 
            // lblNonaktifJudul
            // 
            lblNonaktifJudul.AutoSize = true;
            lblNonaktifJudul.BackColor = Color.Transparent;
            lblNonaktifJudul.Font = new Font("Segoe UI", 9.5F);
            lblNonaktifJudul.ForeColor = Color.FromArgb(90, 110, 140);
            lblNonaktifJudul.Location = new Point(35, 16);
            lblNonaktifJudul.Margin = new Padding(4, 0, 4, 0);
            lblNonaktifJudul.Name = "lblNonaktifJudul";
            lblNonaktifJudul.Size = new Size(57, 17);
            lblNonaktifJudul.TabIndex = 2;
            lblNonaktifJudul.Text = "Nonaktif";
            // 
            // tlpMain
            // 
            tlpMain.ColumnCount = 2;
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 62F));
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38F));
            tlpMain.Controls.Add(pnlDaftar, 0, 0);
            tlpMain.Controls.Add(tlpKanan, 1, 0);
            tlpMain.Dock = DockStyle.Fill;
            tlpMain.Location = new Point(0, 80);
            tlpMain.Margin = new Padding(0);
            tlpMain.Name = "tlpMain";
            tlpMain.RowCount = 1;
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpMain.Size = new Size(1245, 738);
            tlpMain.TabIndex = 1;
            // 
            // pnlDaftar
            // 
            pnlDaftar.AccentColor = Color.Transparent;
            pnlDaftar.BackColor = Color.White;
            pnlDaftar.BorderColor = Color.FromArgb(214, 228, 245);
            pnlDaftar.Controls.Add(tlpDaftar);
            pnlDaftar.Dock = DockStyle.Fill;
            pnlDaftar.Location = new Point(0, 0);
            pnlDaftar.Margin = new Padding(0, 0, 14, 0);
            pnlDaftar.Name = "pnlDaftar";
            pnlDaftar.Padding = new Padding(23, 16, 23, 18);
            pnlDaftar.Radius = 18;
            pnlDaftar.Size = new Size(757, 738);
            pnlDaftar.TabIndex = 0;
            // 
            // tlpDaftar
            // 
            tlpDaftar.ColumnCount = 1;
            tlpDaftar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpDaftar.Controls.Add(tlpToolbar, 0, 0);
            tlpDaftar.Controls.Add(dgvUser, 0, 1);
            tlpDaftar.Dock = DockStyle.Fill;
            tlpDaftar.Location = new Point(23, 16);
            tlpDaftar.Margin = new Padding(0);
            tlpDaftar.Name = "tlpDaftar";
            tlpDaftar.RowCount = 2;
            tlpDaftar.RowStyles.Add(new RowStyle(SizeType.Absolute, 51F));
            tlpDaftar.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpDaftar.Size = new Size(711, 704);
            tlpDaftar.TabIndex = 0;
            // 
            // tlpToolbar
            // 
            tlpToolbar.ColumnCount = 3;
            tlpToolbar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpToolbar.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 222F));
            tlpToolbar.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 175F));
            tlpToolbar.Controls.Add(lblDaftarJudul, 0, 0);
            tlpToolbar.Controls.Add(txtCari, 1, 0);
            tlpToolbar.Controls.Add(cmbFilterJenis, 2, 0);
            tlpToolbar.Dock = DockStyle.Fill;
            tlpToolbar.Location = new Point(0, 0);
            tlpToolbar.Margin = new Padding(0);
            tlpToolbar.Name = "tlpToolbar";
            tlpToolbar.RowCount = 1;
            tlpToolbar.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpToolbar.Size = new Size(711, 51);
            tlpToolbar.TabIndex = 0;
            // 
            // lblDaftarJudul
            // 
            lblDaftarJudul.BackColor = Color.Transparent;
            lblDaftarJudul.Dock = DockStyle.Fill;
            lblDaftarJudul.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblDaftarJudul.ForeColor = Color.FromArgb(13, 47, 110);
            lblDaftarJudul.Location = new Point(0, 0);
            lblDaftarJudul.Margin = new Padding(0);
            lblDaftarJudul.Name = "lblDaftarJudul";
            lblDaftarJudul.Size = new Size(314, 51);
            lblDaftarJudul.TabIndex = 0;
            lblDaftarJudul.Text = "Daftar Pengguna";
            lblDaftarJudul.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtCari
            // 
            txtCari.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtCari.Font = new Font("Segoe UI", 10F);
            txtCari.Location = new Point(314, 10);
            txtCari.Margin = new Padding(0, 10, 12, 0);
            txtCari.Name = "txtCari";
            txtCari.PlaceholderText = "Cari nama...";
            txtCari.Size = new Size(210, 25);
            txtCari.TabIndex = 1;
            // 
            // cmbFilterJenis
            // 
            cmbFilterJenis.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cmbFilterJenis.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFilterJenis.Font = new Font("Segoe UI", 10F);
            cmbFilterJenis.FormattingEnabled = true;
            cmbFilterJenis.Items.AddRange(new object[] { "Semua jenis", "Admin", "Kasir", "Gudang" });
            cmbFilterJenis.Location = new Point(536, 10);
            cmbFilterJenis.Margin = new Padding(0, 10, 0, 0);
            cmbFilterJenis.Name = "cmbFilterJenis";
            cmbFilterJenis.Size = new Size(175, 25);
            cmbFilterJenis.TabIndex = 2;
            // 
            // dgvUser
            // 
            dgvUser.AllowUserToAddRows = false;
            dgvUser.AllowUserToDeleteRows = false;
            dgvUser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUser.BackgroundColor = Color.White;
            dgvUser.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.AliceBlue;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.RoyalBlue;
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            dataGridViewCellStyle1.SelectionForeColor = Color.RoyalBlue;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvUser.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvUser.ColumnHeadersHeight = 40;
            dgvUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvUser.Columns.AddRange(new DataGridViewColumn[] { colNo, colNama, colJenis, colStatus, colDibuat, colAksi });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.GhostWhite;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.DimGray;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvUser.DefaultCellStyle = dataGridViewCellStyle2;
            dgvUser.Dock = DockStyle.Fill;
            dgvUser.EnableHeadersVisualStyles = false;
            dgvUser.Location = new Point(0, 51);
            dgvUser.Margin = new Padding(0);
            dgvUser.MultiSelect = false;
            dgvUser.Name = "dgvUser";
            dgvUser.ReadOnly = true;
            dgvUser.RowHeadersVisible = false;
            dgvUser.RowHeadersWidth = 62;
            dgvUser.RowTemplate.Height = 38;
            dgvUser.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUser.Size = new Size(711, 653);
            dgvUser.TabIndex = 1;
            // 
            // colNo
            // 
            colNo.FillWeight = 7F;
            colNo.HeaderText = "No";
            colNo.MinimumWidth = 8;
            colNo.Name = "colNo";
            colNo.ReadOnly = true;
            // 
            // colNama
            // 
            colNama.FillWeight = 27F;
            colNama.HeaderText = "Nama";
            colNama.MinimumWidth = 8;
            colNama.Name = "colNama";
            colNama.ReadOnly = true;
            // 
            // colJenis
            // 
            colJenis.FillWeight = 15F;
            colJenis.HeaderText = "Jenis";
            colJenis.MinimumWidth = 8;
            colJenis.Name = "colJenis";
            colJenis.ReadOnly = true;
            // 
            // colStatus
            // 
            colStatus.FillWeight = 15F;
            colStatus.HeaderText = "Status";
            colStatus.MinimumWidth = 8;
            colStatus.Name = "colStatus";
            colStatus.ReadOnly = true;
            // 
            // colDibuat
            // 
            colDibuat.FillWeight = 18F;
            colDibuat.HeaderText = "Dibuat";
            colDibuat.MinimumWidth = 8;
            colDibuat.Name = "colDibuat";
            colDibuat.ReadOnly = true;
            // 
            // colAksi
            // 
            colAksi.FillWeight = 18F;
            colAksi.HeaderText = "Aksi";
            colAksi.MinimumWidth = 8;
            colAksi.Name = "colAksi";
            colAksi.ReadOnly = true;
            // 
            // tlpKanan
            // 
            tlpKanan.ColumnCount = 1;
            tlpKanan.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpKanan.Controls.Add(pnlTambah, 0, 0);
            tlpKanan.Controls.Add(pnlKelola, 0, 1);
            tlpKanan.Dock = DockStyle.Fill;
            tlpKanan.Location = new Point(771, 0);
            tlpKanan.Margin = new Padding(0);
            tlpKanan.Name = "tlpKanan";
            tlpKanan.RowCount = 2;
            tlpKanan.RowStyles.Add(new RowStyle(SizeType.Absolute, 172F));
            tlpKanan.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpKanan.Size = new Size(474, 738);
            tlpKanan.TabIndex = 1;
            // 
            // pnlTambah
            // 
            pnlTambah.AccentColor = Color.Transparent;
            pnlTambah.BackColor = Color.White;
            pnlTambah.BorderColor = Color.FromArgb(214, 228, 245);
            pnlTambah.Controls.Add(tlpTambah);
            pnlTambah.Controls.Add(lblTambahJudul);
            pnlTambah.Location = new Point(0, 0);
            pnlTambah.Margin = new Padding(0, 0, 0, 14);
            pnlTambah.Name = "pnlTambah";
            pnlTambah.Padding = new Padding(23, 16, 23, 18);
            pnlTambah.Radius = 18;
            pnlTambah.Size = new Size(452, 158);
            pnlTambah.TabIndex = 0;
            // 
            // tlpTambah
            // 
            tlpTambah.ColumnCount = 2;
            tlpTambah.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 53.78788F));
            tlpTambah.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 46.21212F));
            tlpTambah.Controls.Add(lblNama, 0, 0);
            tlpTambah.Controls.Add(lblJenis, 1, 0);
            tlpTambah.Controls.Add(flowTambah, 0, 4);
            tlpTambah.Controls.Add(txtNama, 0, 1);
            tlpTambah.Controls.Add(cmbJenis, 1, 1);
            tlpTambah.Controls.Add(txtPass, 0, 3);
            tlpTambah.Controls.Add(lblPass, 0, 2);
            tlpTambah.Location = new Point(23, 16);
            tlpTambah.Margin = new Padding(0);
            tlpTambah.Name = "tlpTambah";
            tlpTambah.RowCount = 5;
            tlpTambah.RowStyles.Add(new RowStyle(SizeType.Absolute, 13F));
            tlpTambah.RowStyles.Add(new RowStyle(SizeType.Absolute, 21F));
            tlpTambah.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tlpTambah.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            tlpTambah.RowStyles.Add(new RowStyle(SizeType.Absolute, 83F));
            tlpTambah.RowStyles.Add(new RowStyle(SizeType.Absolute, 12F));
            tlpTambah.Size = new Size(396, 141);
            tlpTambah.TabIndex = 0;
            tlpTambah.Paint += tlpTambah_Paint;
            // 
            // lblNama
            // 
            lblNama.BackColor = Color.Transparent;
            lblNama.Dock = DockStyle.Fill;
            lblNama.Font = new Font("Segoe UI", 9F);
            lblNama.ForeColor = Color.FromArgb(90, 110, 140);
            lblNama.Location = new Point(0, 0);
            lblNama.Margin = new Padding(0);
            lblNama.Name = "lblNama";
            lblNama.Size = new Size(213, 13);
            lblNama.TabIndex = 0;
            lblNama.Text = "Nama pengguna";
            lblNama.TextAlign = ContentAlignment.BottomLeft;
            // 
            // lblJenis
            // 
            lblJenis.BackColor = Color.Transparent;
            lblJenis.Font = new Font("Segoe UI", 9F);
            lblJenis.ForeColor = Color.FromArgb(90, 110, 140);
            lblJenis.Location = new Point(213, 0);
            lblJenis.Margin = new Padding(0);
            lblJenis.Name = "lblJenis";
            lblJenis.Size = new Size(173, 13);
            lblJenis.TabIndex = 1;
            lblJenis.Text = "Jenis";
            lblJenis.TextAlign = ContentAlignment.BottomLeft;
            // 
            // flowTambah
            // 
            flowTambah.BackColor = Color.White;
            tlpTambah.SetColumnSpan(flowTambah, 2);
            flowTambah.Controls.Add(btnTambah);
            flowTambah.Controls.Add(btnResetTambah);
            flowTambah.Controls.Add(ChkBox1);
            flowTambah.Location = new Point(0, 99);
            flowTambah.Margin = new Padding(0);
            flowTambah.Name = "flowTambah";
            flowTambah.Padding = new Padding(0, 7, 0, 0);
            flowTambah.Size = new Size(396, 43);
            flowTambah.TabIndex = 6;
            flowTambah.WrapContents = false;
            // 
            // btnTambah
            // 
            btnTambah.BackColor = Color.FromArgb(30, 136, 229);
            btnTambah.BorderColor = Color.Transparent;
            btnTambah.FlatStyle = FlatStyle.Flat;
            btnTambah.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            btnTambah.ForeColor = Color.White;
            btnTambah.HoverColor = Color.FromArgb(21, 101, 192);
            btnTambah.Location = new Point(0, 7);
            btnTambah.Margin = new Padding(0, 0, 12, 0);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(140, 25);
            btnTambah.TabIndex = 0;
            btnTambah.Text = "Simpan";
            btnTambah.UseVisualStyleBackColor = false;
            btnTambah.Click += btnTambah_Click;
            // 
            // btnResetTambah
            // 
            btnResetTambah.BackColor = Color.White;
            btnResetTambah.BorderColor = Color.FromArgb(30, 136, 229);
            btnResetTambah.FlatStyle = FlatStyle.Flat;
            btnResetTambah.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            btnResetTambah.ForeColor = Color.FromArgb(30, 136, 229);
            btnResetTambah.HoverColor = Color.FromArgb(225, 240, 255);
            btnResetTambah.Location = new Point(152, 7);
            btnResetTambah.Margin = new Padding(0);
            btnResetTambah.Name = "btnResetTambah";
            btnResetTambah.Size = new Size(105, 25);
            btnResetTambah.TabIndex = 1;
            btnResetTambah.Text = "Reset";
            btnResetTambah.UseVisualStyleBackColor = false;
            // 
            // ChkBox1
            // 
            ChkBox1.AutoSize = true;
            ChkBox1.Location = new Point(260, 10);
            ChkBox1.Name = "ChkBox1";
            ChkBox1.Size = new Size(105, 19);
            ChkBox1.TabIndex = 2;
            ChkBox1.Text = "Lihat Password";
            ChkBox1.UseVisualStyleBackColor = true;
            ChkBox1.CheckedChanged += ChkBox1_CheckedChanged;
            // 
            // txtNama
            // 
            txtNama.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtNama.Font = new Font("Segoe UI", 10F);
            txtNama.Location = new Point(0, 13);
            txtNama.Margin = new Padding(0, 0, 9, 0);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(204, 25);
            txtNama.TabIndex = 2;
            // 
            // cmbJenis
            // 
            cmbJenis.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cmbJenis.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbJenis.Font = new Font("Segoe UI", 10F);
            cmbJenis.FormattingEnabled = true;
            cmbJenis.Items.AddRange(new object[] { "", "Kasir", "Gudang" });
            cmbJenis.Location = new Point(213, 13);
            cmbJenis.Margin = new Padding(0);
            cmbJenis.Name = "cmbJenis";
            cmbJenis.Size = new Size(183, 25);
            cmbJenis.TabIndex = 3;
            // 
            // txtPass
            // 
            txtPass.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tlpTambah.SetColumnSpan(txtPass, 2);
            txtPass.Font = new Font("Segoe UI", 10F);
            txtPass.Location = new Point(0, 68);
            txtPass.Margin = new Padding(0);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(396, 25);
            txtPass.TabIndex = 5;
            // 
            // lblPass
            // 
            lblPass.BackColor = Color.Transparent;
            tlpTambah.SetColumnSpan(lblPass, 2);
            lblPass.Font = new Font("Segoe UI", 9F);
            lblPass.ForeColor = Color.FromArgb(90, 110, 140);
            lblPass.Location = new Point(0, 34);
            lblPass.Margin = new Padding(0);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(174, 34);
            lblPass.TabIndex = 4;
            lblPass.Text = "Password (minimal 6 karakter)";
            lblPass.TextAlign = ContentAlignment.BottomLeft;
            // 
            // lblTambahJudul
            // 
            lblTambahJudul.BackColor = Color.Transparent;
            lblTambahJudul.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblTambahJudul.ForeColor = Color.FromArgb(13, 47, 110);
            lblTambahJudul.Location = new Point(19, 0);
            lblTambahJudul.Margin = new Padding(4, 0, 4, 0);
            lblTambahJudul.Name = "lblTambahJudul";
            lblTambahJudul.Size = new Size(372, 20);
            lblTambahJudul.TabIndex = 1;
            lblTambahJudul.Text = "Tambah Pengguna";
            lblTambahJudul.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlKelola
            // 
            pnlKelola.AccentColor = Color.Transparent;
            pnlKelola.BackColor = Color.White;
            pnlKelola.BorderColor = Color.FromArgb(214, 228, 245);
            pnlKelola.Controls.Add(tlpKelola);
            pnlKelola.Controls.Add(lblKelolaJudul);
            pnlKelola.Location = new Point(0, 172);
            pnlKelola.Margin = new Padding(0);
            pnlKelola.Name = "pnlKelola";
            pnlKelola.Padding = new Padding(23, 16, 23, 18);
            pnlKelola.Radius = 18;
            pnlKelola.Size = new Size(452, 182);
            pnlKelola.TabIndex = 1;
            // 
            // tlpKelola
            // 
            tlpKelola.ColumnCount = 2;
            tlpKelola.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpKelola.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpKelola.Controls.Add(lblTerpilih, 0, 0);
            tlpKelola.Controls.Add(lblLama, 0, 1);
            tlpKelola.Controls.Add(lblBaru, 1, 1);
            tlpKelola.Controls.Add(txtLama, 0, 2);
            tlpKelola.Controls.Add(txtBaru, 1, 2);
            tlpKelola.Controls.Add(flowGanti, 0, 3);
            tlpKelola.Controls.Add(flowAksi, 0, 4);
            tlpKelola.Location = new Point(23, 35);
            tlpKelola.Margin = new Padding(0);
            tlpKelola.Name = "tlpKelola";
            tlpKelola.RowCount = 5;
            tlpKelola.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tlpKelola.RowStyles.Add(new RowStyle(SizeType.Absolute, 13F));
            tlpKelola.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tlpKelola.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tlpKelola.RowStyles.Add(new RowStyle(SizeType.Absolute, 86F));
            tlpKelola.Size = new Size(402, 154);
            tlpKelola.TabIndex = 0;
            // 
            // lblTerpilih
            // 
            lblTerpilih.BackColor = Color.Transparent;
            tlpKelola.SetColumnSpan(lblTerpilih, 2);
            lblTerpilih.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblTerpilih.ForeColor = Color.FromArgb(13, 47, 110);
            lblTerpilih.Location = new Point(0, 0);
            lblTerpilih.Margin = new Padding(0);
            lblTerpilih.Name = "lblTerpilih";
            lblTerpilih.Size = new Size(402, 22);
            lblTerpilih.TabIndex = 0;
            lblTerpilih.Text = "Pilih pengguna di tabel";
            lblTerpilih.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblLama
            // 
            lblLama.BackColor = Color.Transparent;
            lblLama.Dock = DockStyle.Fill;
            lblLama.Font = new Font("Segoe UI", 9F);
            lblLama.ForeColor = Color.FromArgb(90, 110, 140);
            lblLama.Location = new Point(0, 30);
            lblLama.Margin = new Padding(0);
            lblLama.Name = "lblLama";
            lblLama.Size = new Size(201, 13);
            lblLama.TabIndex = 1;
            lblLama.Text = "Kata sandi lama";
            lblLama.TextAlign = ContentAlignment.BottomLeft;
            // 
            // lblBaru
            // 
            lblBaru.BackColor = Color.Transparent;
            lblBaru.Dock = DockStyle.Fill;
            lblBaru.Font = new Font("Segoe UI", 9F);
            lblBaru.ForeColor = Color.FromArgb(90, 110, 140);
            lblBaru.Location = new Point(201, 30);
            lblBaru.Margin = new Padding(0);
            lblBaru.Name = "lblBaru";
            lblBaru.Size = new Size(201, 13);
            lblBaru.TabIndex = 2;
            lblBaru.Text = "Kata sandi baru";
            lblBaru.TextAlign = ContentAlignment.BottomLeft;
            // 
            // txtLama
            // 
            txtLama.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtLama.Font = new Font("Segoe UI", 10F);
            txtLama.Location = new Point(0, 43);
            txtLama.Margin = new Padding(0, 0, 9, 0);
            txtLama.Name = "txtLama";
            txtLama.Size = new Size(192, 25);
            txtLama.TabIndex = 3;
            txtLama.UseSystemPasswordChar = true;
            // 
            // txtBaru
            // 
            txtBaru.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBaru.Font = new Font("Segoe UI", 10F);
            txtBaru.Location = new Point(201, 43);
            txtBaru.Margin = new Padding(0);
            txtBaru.Name = "txtBaru";
            txtBaru.Size = new Size(201, 25);
            txtBaru.TabIndex = 4;
            txtBaru.UseSystemPasswordChar = true;
            // 
            // flowGanti
            // 
            flowGanti.BackColor = Color.White;
            tlpKelola.SetColumnSpan(flowGanti, 2);
            flowGanti.Controls.Add(btnGanti);
            flowGanti.Controls.Add(btnBatalGanti);
            flowGanti.Location = new Point(0, 75);
            flowGanti.Margin = new Padding(0);
            flowGanti.Name = "flowGanti";
            flowGanti.Padding = new Padding(0, 7, 0, 0);
            flowGanti.Size = new Size(402, 36);
            flowGanti.TabIndex = 5;
            flowGanti.WrapContents = false;
            // 
            // btnGanti
            // 
            btnGanti.BackColor = Color.FromArgb(30, 136, 229);
            btnGanti.BorderColor = Color.Transparent;
            btnGanti.FlatStyle = FlatStyle.Flat;
            btnGanti.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            btnGanti.ForeColor = Color.White;
            btnGanti.HoverColor = Color.FromArgb(21, 101, 192);
            btnGanti.Location = new Point(0, 7);
            btnGanti.Margin = new Padding(0, 0, 12, 0);
            btnGanti.Name = "btnGanti";
            btnGanti.Size = new Size(140, 26);
            btnGanti.TabIndex = 0;
            btnGanti.Text = "Ganti Password";
            btnGanti.UseVisualStyleBackColor = false;
            btnGanti.Click += btnGanti_Click;
            // 
            // btnBatalGanti
            // 
            btnBatalGanti.BackColor = Color.White;
            btnBatalGanti.BorderColor = Color.FromArgb(30, 136, 229);
            btnBatalGanti.FlatStyle = FlatStyle.Flat;
            btnBatalGanti.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            btnBatalGanti.ForeColor = Color.FromArgb(30, 136, 229);
            btnBatalGanti.HoverColor = Color.FromArgb(225, 240, 255);
            btnBatalGanti.Location = new Point(152, 7);
            btnBatalGanti.Margin = new Padding(0);
            btnBatalGanti.Name = "btnBatalGanti";
            btnBatalGanti.Size = new Size(82, 26);
            btnBatalGanti.TabIndex = 1;
            btnBatalGanti.Text = "Batal";
            btnBatalGanti.UseVisualStyleBackColor = false;
            // 
            // flowAksi
            // 
            flowAksi.BackColor = Color.White;
            tlpKelola.SetColumnSpan(flowAksi, 2);
            flowAksi.Controls.Add(btnResetPw);
            flowAksi.Controls.Add(btnStatus);
            flowAksi.Controls.Add(btnHapus);
            flowAksi.Location = new Point(0, 111);
            flowAksi.Margin = new Padding(0);
            flowAksi.Name = "flowAksi";
            flowAksi.Padding = new Padding(0, 7, 0, 0);
            flowAksi.Size = new Size(402, 36);
            flowAksi.TabIndex = 6;
            flowAksi.WrapContents = false;
            // 
            // btnResetPw
            // 
            btnResetPw.BackColor = Color.White;
            btnResetPw.BorderColor = Color.FromArgb(30, 136, 229);
            btnResetPw.FlatStyle = FlatStyle.Flat;
            btnResetPw.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            btnResetPw.ForeColor = Color.FromArgb(30, 136, 229);
            btnResetPw.HoverColor = Color.FromArgb(225, 240, 255);
            btnResetPw.Location = new Point(0, 7);
            btnResetPw.Margin = new Padding(0, 0, 9, 0);
            btnResetPw.Name = "btnResetPw";
            btnResetPw.Size = new Size(140, 23);
            btnResetPw.TabIndex = 0;
            btnResetPw.Text = "Reset Password";
            btnResetPw.UseVisualStyleBackColor = false;
            // 
            // btnStatus
            // 
            btnStatus.BackColor = Color.White;
            btnStatus.BorderColor = Color.FromArgb(30, 136, 229);
            btnStatus.FlatStyle = FlatStyle.Flat;
            btnStatus.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            btnStatus.ForeColor = Color.FromArgb(30, 136, 229);
            btnStatus.HoverColor = Color.FromArgb(225, 240, 255);
            btnStatus.Location = new Point(149, 7);
            btnStatus.Margin = new Padding(0, 0, 9, 0);
            btnStatus.Name = "btnStatus";
            btnStatus.Size = new Size(128, 23);
            btnStatus.TabIndex = 1;
            btnStatus.Text = "Nonaktifkan";
            btnStatus.UseVisualStyleBackColor = false;
            btnStatus.Click += btnStatus_Click;
            // 
            // btnHapus
            // 
            btnHapus.BackColor = Color.White;
            btnHapus.BorderColor = Color.FromArgb(214, 69, 65);
            btnHapus.FlatStyle = FlatStyle.Flat;
            btnHapus.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            btnHapus.ForeColor = Color.FromArgb(214, 69, 65);
            btnHapus.HoverColor = Color.FromArgb(253, 236, 235);
            btnHapus.Location = new Point(286, 7);
            btnHapus.Margin = new Padding(0);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(82, 23);
            btnHapus.TabIndex = 2;
            btnHapus.Text = "Hapus";
            btnHapus.UseVisualStyleBackColor = false;
            btnHapus.Click += btnHapus_Click;
            // 
            // lblKelolaJudul
            // 
            lblKelolaJudul.BackColor = Color.Transparent;
            lblKelolaJudul.Dock = DockStyle.Top;
            lblKelolaJudul.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblKelolaJudul.ForeColor = Color.FromArgb(13, 47, 110);
            lblKelolaJudul.Location = new Point(23, 16);
            lblKelolaJudul.Margin = new Padding(4, 0, 4, 0);
            lblKelolaJudul.Name = "lblKelolaJudul";
            lblKelolaJudul.Size = new Size(406, 19);
            lblKelolaJudul.TabIndex = 1;
            lblKelolaJudul.Text = "Kelola Pengguna Terpilih";
            lblKelolaJudul.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // UC_User
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(234, 243, 252);
            Controls.Add(tlpRoot);
            Margin = new Padding(4, 3, 4, 3);
            Name = "UC_User";
            Size = new Size(1283, 923);
            tlpRoot.ResumeLayout(false);
            pnlJudul.ResumeLayout(false);
            pnlJudul.PerformLayout();
            tlpContent.ResumeLayout(false);
            tlpStats.ResumeLayout(false);
            cardTotal.ResumeLayout(false);
            cardTotal.PerformLayout();
            cardKasir.ResumeLayout(false);
            cardKasir.PerformLayout();
            cardGudang.ResumeLayout(false);
            cardGudang.PerformLayout();
            cardNonaktif.ResumeLayout(false);
            cardNonaktif.PerformLayout();
            tlpMain.ResumeLayout(false);
            pnlDaftar.ResumeLayout(false);
            tlpDaftar.ResumeLayout(false);
            tlpToolbar.ResumeLayout(false);
            tlpToolbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUser).EndInit();
            tlpKanan.ResumeLayout(false);
            pnlTambah.ResumeLayout(false);
            tlpTambah.ResumeLayout(false);
            tlpTambah.PerformLayout();
            flowTambah.ResumeLayout(false);
            flowTambah.PerformLayout();
            pnlKelola.ResumeLayout(false);
            tlpKelola.ResumeLayout(false);
            tlpKelola.PerformLayout();
            flowGanti.ResumeLayout(false);
            flowAksi.ResumeLayout(false);
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
        private RoundedPanelUI cardKasir;
        private System.Windows.Forms.Label lblKasirKet;
        private System.Windows.Forms.Label lblKasirNilai;
        private System.Windows.Forms.Label lblKasirJudul;
        private RoundedPanelUI cardGudang;
        private System.Windows.Forms.Label lblGudangKet;
        private System.Windows.Forms.Label lblGudangNilai;
        private System.Windows.Forms.Label lblGudangJudul;
        private RoundedPanelUI cardNonaktif;
        private System.Windows.Forms.Label lblNonaktifKet;
        private System.Windows.Forms.Label lblNonaktifNilai;
        private System.Windows.Forms.Label lblNonaktifJudul;
        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private RoundedPanelUI pnlDaftar;
        private System.Windows.Forms.TableLayoutPanel tlpDaftar;
        private System.Windows.Forms.TableLayoutPanel tlpToolbar;
        private System.Windows.Forms.Label lblDaftarJudul;
        private System.Windows.Forms.TextBox txtCari;
        private System.Windows.Forms.ComboBox cmbFilterJenis;
        private System.Windows.Forms.DataGridView dgvUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNama;
        private System.Windows.Forms.DataGridViewTextBoxColumn colJenis;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDibuat;
        private System.Windows.Forms.DataGridViewButtonColumn colAksi;
        private System.Windows.Forms.TableLayoutPanel tlpKanan;
        private RoundedPanelUI pnlTambah;
        private System.Windows.Forms.TableLayoutPanel tlpTambah;
        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.Label lblJenis;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.ComboBox cmbJenis;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.FlowLayoutPanel flowTambah;
        private RoundedButtonUI btnTambah;
        private RoundedButtonUI btnResetTambah;
        private System.Windows.Forms.Label lblTambahJudul;
        private RoundedPanelUI pnlKelola;
        private System.Windows.Forms.TableLayoutPanel tlpKelola;
        private System.Windows.Forms.Label lblTerpilih;
        private System.Windows.Forms.Label lblLama;
        private System.Windows.Forms.Label lblBaru;
        private System.Windows.Forms.TextBox txtLama;
        private System.Windows.Forms.TextBox txtBaru;
        private System.Windows.Forms.FlowLayoutPanel flowGanti;
        private RoundedButtonUI btnGanti;
        private RoundedButtonUI btnBatalGanti;
        private System.Windows.Forms.FlowLayoutPanel flowAksi;
        private RoundedButtonUI btnResetPw;
        private RoundedButtonUI btnStatus;
        private RoundedButtonUI btnHapus;
        private System.Windows.Forms.Label lblKelolaJudul;
        private Label lblPass;
        private CheckBox ChkBox1;
    }
}