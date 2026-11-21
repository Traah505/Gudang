namespace GUedang
{
    partial class UC_GANTIPWKasir
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
            pnlForm = new RoundedPanelUI();
            tlpForm = new TableLayoutPanel();
            lblLama = new Label();
            txtLama = new TextBox();
            lblBaru = new Label();
            txtBaru = new TextBox();
            lblKekuatan = new Label();
            lblKonf = new Label();
            txtKonf = new TextBox();
            chkTampil = new CheckBox();
            lblInfo = new Label();
            flowTombol = new FlowLayoutPanel();
            btnSimpan = new RoundedButtonUI();
            btnBatal = new RoundedButtonUI();
            lblFormJudul = new Label();
            pnlTips = new RoundedPanelUI();
            tlpTips = new TableLayoutPanel();
            lblTipIkon1 = new Label();
            lblTip1 = new Label();
            lblTipIkon2 = new Label();
            lblTip2 = new Label();
            lblTipIkon3 = new Label();
            lblTip3 = new Label();
            lblTipIkon4 = new Label();
            lblTip4 = new Label();
            lblTipIkon5 = new Label();
            lblTip5 = new Label();
            lblTipIkon6 = new Label();
            lblTip6 = new Label();
            lblTipsJudul = new Label();
            tlpRoot.SuspendLayout();
            pnlJudul.SuspendLayout();
            tlpContent.SuspendLayout();
            pnlForm.SuspendLayout();
            tlpForm.SuspendLayout();
            flowTombol.SuspendLayout();
            pnlTips.SuspendLayout();
            tlpTips.SuspendLayout();
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
            tlpRoot.Size = new Size(1283, 629);
            tlpRoot.TabIndex = 0;
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
            lblSub.Size = new Size(392, 17);
            lblSub.TabIndex = 0;
            lblSub.Text = "Gunakan password yang kuat dan jangan dibagikan ke orang lain.";
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
            lblJudul.Size = new Size(164, 30);
            lblJudul.TabIndex = 1;
            lblJudul.Text = "Ganti Password";
            // 
            // tlpContent
            // 
            tlpContent.ColumnCount = 2;
            tlpContent.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 560F));
            tlpContent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpContent.Controls.Add(pnlForm, 0, 0);
            tlpContent.Controls.Add(pnlTips, 1, 0);
            tlpContent.Dock = DockStyle.Fill;
            tlpContent.Location = new Point(19, 113);
            tlpContent.Margin = new Padding(0);
            tlpContent.Name = "tlpContent";
            tlpContent.RowCount = 2;
            tlpContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 496F));
            tlpContent.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpContent.Size = new Size(1245, 498);
            tlpContent.TabIndex = 1;
            // 
            // pnlForm
            // 
            pnlForm.AccentColor = Color.Transparent;
            pnlForm.BackColor = Color.White;
            pnlForm.BorderColor = Color.FromArgb(214, 228, 245);
            pnlForm.Controls.Add(tlpForm);
            pnlForm.Controls.Add(lblFormJudul);
            pnlForm.Dock = DockStyle.Fill;
            pnlForm.Location = new Point(0, 0);
            pnlForm.Margin = new Padding(0, 0, 14, 0);
            pnlForm.Name = "pnlForm";
            pnlForm.Padding = new Padding(23, 16, 23, 18);
            pnlForm.Radius = 18;
            pnlForm.Size = new Size(546, 496);
            pnlForm.TabIndex = 0;
            // 
            // tlpForm
            // 
            tlpForm.ColumnCount = 1;
            tlpForm.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpForm.Controls.Add(lblLama, 0, 0);
            tlpForm.Controls.Add(txtLama, 0, 1);
            tlpForm.Controls.Add(lblBaru, 0, 2);
            tlpForm.Controls.Add(txtBaru, 0, 3);
            tlpForm.Controls.Add(lblKekuatan, 0, 4);
            tlpForm.Controls.Add(lblKonf, 0, 5);
            tlpForm.Controls.Add(txtKonf, 0, 6);
            tlpForm.Controls.Add(chkTampil, 0, 7);
            tlpForm.Controls.Add(lblInfo, 0, 8);
            tlpForm.Controls.Add(flowTombol, 0, 9);
            tlpForm.Dock = DockStyle.Fill;
            tlpForm.Location = new Point(23, 55);
            tlpForm.Margin = new Padding(0);
            tlpForm.Name = "tlpForm";
            tlpForm.RowCount = 10;
            tlpForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tlpForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
            tlpForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tlpForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
            tlpForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tlpForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tlpForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
            tlpForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tlpForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tlpForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 58F));
            tlpForm.Size = new Size(500, 423);
            tlpForm.TabIndex = 0;
            // 
            // lblLama
            // 
            lblLama.BackColor = Color.Transparent;
            lblLama.Dock = DockStyle.Fill;
            lblLama.Font = new Font("Segoe UI", 9F);
            lblLama.ForeColor = Color.FromArgb(90, 110, 140);
            lblLama.Location = new Point(0, 0);
            lblLama.Margin = new Padding(0);
            lblLama.Name = "lblLama";
            lblLama.Size = new Size(500, 28);
            lblLama.TabIndex = 0;
            lblLama.Text = "Password lama";
            lblLama.TextAlign = ContentAlignment.BottomLeft;
            // 
            // txtLama
            // 
            txtLama.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtLama.Font = new Font("Segoe UI", 10F);
            txtLama.Location = new Point(0, 28);
            txtLama.Margin = new Padding(0);
            txtLama.Name = "txtLama";
            txtLama.Size = new Size(500, 25);
            txtLama.TabIndex = 1;
            txtLama.UseSystemPasswordChar = true;
            // 
            // lblBaru
            // 
            lblBaru.BackColor = Color.Transparent;
            lblBaru.Dock = DockStyle.Fill;
            lblBaru.Font = new Font("Segoe UI", 9F);
            lblBaru.ForeColor = Color.FromArgb(90, 110, 140);
            lblBaru.Location = new Point(0, 70);
            lblBaru.Margin = new Padding(0);
            lblBaru.Name = "lblBaru";
            lblBaru.Size = new Size(500, 28);
            lblBaru.TabIndex = 2;
            lblBaru.Text = "Password baru";
            lblBaru.TextAlign = ContentAlignment.BottomLeft;
            // 
            // txtBaru
            // 
            txtBaru.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBaru.Font = new Font("Segoe UI", 10F);
            txtBaru.Location = new Point(0, 98);
            txtBaru.Margin = new Padding(0);
            txtBaru.Name = "txtBaru";
            txtBaru.Size = new Size(500, 25);
            txtBaru.TabIndex = 3;
            txtBaru.UseSystemPasswordChar = true;
            // 
            // lblKekuatan
            // 
            lblKekuatan.BackColor = Color.Transparent;
            lblKekuatan.Dock = DockStyle.Fill;
            lblKekuatan.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblKekuatan.ForeColor = Color.FromArgb(90, 110, 140);
            lblKekuatan.Location = new Point(0, 140);
            lblKekuatan.Margin = new Padding(0);
            lblKekuatan.Name = "lblKekuatan";
            lblKekuatan.Size = new Size(500, 28);
            lblKekuatan.TabIndex = 4;
            lblKekuatan.Text = "Kekuatan: -";
            lblKekuatan.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblKonf
            // 
            lblKonf.BackColor = Color.Transparent;
            lblKonf.Dock = DockStyle.Fill;
            lblKonf.Font = new Font("Segoe UI", 9F);
            lblKonf.ForeColor = Color.FromArgb(90, 110, 140);
            lblKonf.Location = new Point(0, 168);
            lblKonf.Margin = new Padding(0);
            lblKonf.Name = "lblKonf";
            lblKonf.Size = new Size(500, 28);
            lblKonf.TabIndex = 5;
            lblKonf.Text = "Konfirmasi password baru";
            lblKonf.TextAlign = ContentAlignment.BottomLeft;
            // 
            // txtKonf
            // 
            txtKonf.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtKonf.Font = new Font("Segoe UI", 10F);
            txtKonf.Location = new Point(0, 196);
            txtKonf.Margin = new Padding(0);
            txtKonf.Name = "txtKonf";
            txtKonf.Size = new Size(500, 25);
            txtKonf.TabIndex = 6;
            txtKonf.UseSystemPasswordChar = true;
            // 
            // chkTampil
            // 
            chkTampil.AutoSize = true;
            chkTampil.BackColor = Color.Transparent;
            chkTampil.Font = new Font("Segoe UI", 9F);
            chkTampil.ForeColor = Color.FromArgb(90, 110, 140);
            chkTampil.Location = new Point(0, 245);
            chkTampil.Margin = new Padding(0, 7, 0, 0);
            chkTampil.Name = "chkTampil";
            chkTampil.Size = new Size(133, 19);
            chkTampil.TabIndex = 7;
            chkTampil.Text = "Tampilkan password";
            chkTampil.UseVisualStyleBackColor = true;
            // 
            // lblInfo
            // 
            lblInfo.BackColor = Color.Transparent;
            lblInfo.Dock = DockStyle.Fill;
            lblInfo.Font = new Font("Segoe UI", 8.5F);
            lblInfo.ForeColor = Color.FromArgb(90, 110, 140);
            lblInfo.Location = new Point(0, 273);
            lblInfo.Margin = new Padding(0);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(500, 30);
            lblInfo.TabIndex = 8;
            lblInfo.Text = "Minimal 6 karakter dan berbeda dari password lama.";
            lblInfo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // flowTombol
            // 
            flowTombol.BackColor = Color.White;
            flowTombol.Controls.Add(btnSimpan);
            flowTombol.Controls.Add(btnBatal);
            flowTombol.Dock = DockStyle.Fill;
            flowTombol.Location = new Point(0, 303);
            flowTombol.Margin = new Padding(0);
            flowTombol.Name = "flowTombol";
            flowTombol.Padding = new Padding(0, 7, 0, 0);
            flowTombol.Size = new Size(500, 120);
            flowTombol.TabIndex = 9;
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
            btnSimpan.Margin = new Padding(0, 0, 12, 0);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(198, 46);
            btnSimpan.TabIndex = 0;
            btnSimpan.Text = "Simpan Password";
            btnSimpan.UseVisualStyleBackColor = false;
            // 
            // btnBatal
            // 
            btnBatal.BackColor = Color.White;
            btnBatal.BorderColor = Color.FromArgb(30, 136, 229);
            btnBatal.FlatStyle = FlatStyle.Flat;
            btnBatal.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            btnBatal.ForeColor = Color.FromArgb(30, 136, 229);
            btnBatal.HoverColor = Color.FromArgb(225, 240, 255);
            btnBatal.Location = new Point(210, 7);
            btnBatal.Margin = new Padding(0);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(117, 46);
            btnBatal.TabIndex = 1;
            btnBatal.Text = "Batal";
            btnBatal.UseVisualStyleBackColor = false;
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
            lblFormJudul.Size = new Size(500, 39);
            lblFormJudul.TabIndex = 1;
            lblFormJudul.Text = "Ubah Password";
            lblFormJudul.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlTips
            // 
            pnlTips.AccentColor = Color.Transparent;
            pnlTips.BackColor = Color.White;
            pnlTips.BorderColor = Color.FromArgb(214, 228, 245);
            pnlTips.Controls.Add(tlpTips);
            pnlTips.Controls.Add(lblTipsJudul);
            pnlTips.Dock = DockStyle.Fill;
            pnlTips.Location = new Point(560, 0);
            pnlTips.Margin = new Padding(0);
            pnlTips.Name = "pnlTips";
            pnlTips.Padding = new Padding(23, 16, 23, 18);
            pnlTips.Radius = 18;
            pnlTips.Size = new Size(685, 496);
            pnlTips.TabIndex = 1;
            // 
            // tlpTips
            // 
            tlpTips.ColumnCount = 2;
            tlpTips.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 49F));
            tlpTips.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpTips.Controls.Add(lblTipIkon1, 0, 0);
            tlpTips.Controls.Add(lblTip1, 1, 0);
            tlpTips.Controls.Add(lblTipIkon2, 0, 1);
            tlpTips.Controls.Add(lblTip2, 1, 1);
            tlpTips.Controls.Add(lblTipIkon3, 0, 2);
            tlpTips.Controls.Add(lblTip3, 1, 2);
            tlpTips.Controls.Add(lblTipIkon4, 0, 3);
            tlpTips.Controls.Add(lblTip4, 1, 3);
            tlpTips.Controls.Add(lblTipIkon5, 0, 4);
            tlpTips.Controls.Add(lblTip5, 1, 4);
            tlpTips.Controls.Add(lblTipIkon6, 0, 5);
            tlpTips.Controls.Add(lblTip6, 1, 5);
            tlpTips.Dock = DockStyle.Fill;
            tlpTips.Location = new Point(23, 55);
            tlpTips.Margin = new Padding(0);
            tlpTips.Name = "tlpTips";
            tlpTips.RowCount = 7;
            tlpTips.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tlpTips.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tlpTips.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tlpTips.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tlpTips.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tlpTips.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tlpTips.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpTips.Size = new Size(639, 423);
            tlpTips.TabIndex = 0;
            // 
            // lblTipIkon1
            // 
            lblTipIkon1.BackColor = Color.Transparent;
            lblTipIkon1.Dock = DockStyle.Fill;
            lblTipIkon1.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblTipIkon1.ForeColor = Color.FromArgb(30, 136, 229);
            lblTipIkon1.Location = new Point(0, 0);
            lblTipIkon1.Margin = new Padding(0);
            lblTipIkon1.Name = "lblTipIkon1";
            lblTipIkon1.Size = new Size(49, 60);
            lblTipIkon1.TabIndex = 0;
            lblTipIkon1.Text = "✓";
            lblTipIkon1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTip1
            // 
            lblTip1.BackColor = Color.Transparent;
            lblTip1.Dock = DockStyle.Fill;
            lblTip1.Font = new Font("Segoe UI", 9.5F);
            lblTip1.ForeColor = Color.FromArgb(13, 47, 110);
            lblTip1.Location = new Point(49, 0);
            lblTip1.Margin = new Padding(0);
            lblTip1.Name = "lblTip1";
            lblTip1.Size = new Size(590, 60);
            lblTip1.TabIndex = 1;
            lblTip1.Text = "Gunakan minimal 8 karakter. Semakin panjang, semakin sulit ditebak.";
            lblTip1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTipIkon2
            // 
            lblTipIkon2.BackColor = Color.Transparent;
            lblTipIkon2.Dock = DockStyle.Fill;
            lblTipIkon2.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblTipIkon2.ForeColor = Color.FromArgb(30, 136, 229);
            lblTipIkon2.Location = new Point(0, 60);
            lblTipIkon2.Margin = new Padding(0);
            lblTipIkon2.Name = "lblTipIkon2";
            lblTipIkon2.Size = new Size(49, 60);
            lblTipIkon2.TabIndex = 2;
            lblTipIkon2.Text = "✓";
            lblTipIkon2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTip2
            // 
            lblTip2.BackColor = Color.Transparent;
            lblTip2.Dock = DockStyle.Fill;
            lblTip2.Font = new Font("Segoe UI", 9.5F);
            lblTip2.ForeColor = Color.FromArgb(13, 47, 110);
            lblTip2.Location = new Point(49, 60);
            lblTip2.Margin = new Padding(0);
            lblTip2.Name = "lblTip2";
            lblTip2.Size = new Size(590, 60);
            lblTip2.TabIndex = 3;
            lblTip2.Text = "Kombinasikan huruf besar, huruf kecil, angka, dan simbol (contoh: ! @ # $).";
            lblTip2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTipIkon3
            // 
            lblTipIkon3.BackColor = Color.Transparent;
            lblTipIkon3.Dock = DockStyle.Fill;
            lblTipIkon3.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblTipIkon3.ForeColor = Color.FromArgb(30, 136, 229);
            lblTipIkon3.Location = new Point(0, 120);
            lblTipIkon3.Margin = new Padding(0);
            lblTipIkon3.Name = "lblTipIkon3";
            lblTipIkon3.Size = new Size(49, 60);
            lblTipIkon3.TabIndex = 4;
            lblTipIkon3.Text = "✓";
            lblTipIkon3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTip3
            // 
            lblTip3.BackColor = Color.Transparent;
            lblTip3.Dock = DockStyle.Fill;
            lblTip3.Font = new Font("Segoe UI", 9.5F);
            lblTip3.ForeColor = Color.FromArgb(13, 47, 110);
            lblTip3.Location = new Point(49, 120);
            lblTip3.Margin = new Padding(0);
            lblTip3.Name = "lblTip3";
            lblTip3.Size = new Size(590, 60);
            lblTip3.TabIndex = 5;
            lblTip3.Text = "Hindari data pribadi seperti nama, tanggal lahir, atau nomor HP.";
            lblTip3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTipIkon4
            // 
            lblTipIkon4.BackColor = Color.Transparent;
            lblTipIkon4.Dock = DockStyle.Fill;
            lblTipIkon4.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblTipIkon4.ForeColor = Color.FromArgb(30, 136, 229);
            lblTipIkon4.Location = new Point(0, 180);
            lblTipIkon4.Margin = new Padding(0);
            lblTipIkon4.Name = "lblTipIkon4";
            lblTipIkon4.Size = new Size(49, 60);
            lblTipIkon4.TabIndex = 6;
            lblTipIkon4.Text = "✓";
            lblTipIkon4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTip4
            // 
            lblTip4.BackColor = Color.Transparent;
            lblTip4.Dock = DockStyle.Fill;
            lblTip4.Font = new Font("Segoe UI", 9.5F);
            lblTip4.ForeColor = Color.FromArgb(13, 47, 110);
            lblTip4.Location = new Point(49, 180);
            lblTip4.Margin = new Padding(0);
            lblTip4.Name = "lblTip4";
            lblTip4.Size = new Size(590, 60);
            lblTip4.TabIndex = 7;
            lblTip4.Text = "Jangan memakai password yang sama dengan akun lain.";
            lblTip4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTipIkon5
            // 
            lblTipIkon5.BackColor = Color.Transparent;
            lblTipIkon5.Dock = DockStyle.Fill;
            lblTipIkon5.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblTipIkon5.ForeColor = Color.FromArgb(30, 136, 229);
            lblTipIkon5.Location = new Point(0, 240);
            lblTipIkon5.Margin = new Padding(0);
            lblTipIkon5.Name = "lblTipIkon5";
            lblTipIkon5.Size = new Size(49, 60);
            lblTipIkon5.TabIndex = 8;
            lblTipIkon5.Text = "✓";
            lblTipIkon5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTip5
            // 
            lblTip5.BackColor = Color.Transparent;
            lblTip5.Dock = DockStyle.Fill;
            lblTip5.Font = new Font("Segoe UI", 9.5F);
            lblTip5.ForeColor = Color.FromArgb(13, 47, 110);
            lblTip5.Location = new Point(49, 240);
            lblTip5.Margin = new Padding(0);
            lblTip5.Name = "lblTip5";
            lblTip5.Size = new Size(590, 60);
            lblTip5.TabIndex = 9;
            lblTip5.Text = "Jangan bagikan password ke siapa pun, termasuk rekan kerja.";
            lblTip5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTipIkon6
            // 
            lblTipIkon6.BackColor = Color.Transparent;
            lblTipIkon6.Dock = DockStyle.Fill;
            lblTipIkon6.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblTipIkon6.ForeColor = Color.FromArgb(30, 136, 229);
            lblTipIkon6.Location = new Point(0, 300);
            lblTipIkon6.Margin = new Padding(0);
            lblTipIkon6.Name = "lblTipIkon6";
            lblTipIkon6.Size = new Size(49, 60);
            lblTipIkon6.TabIndex = 10;
            lblTipIkon6.Text = "✓";
            lblTipIkon6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTip6
            // 
            lblTip6.BackColor = Color.Transparent;
            lblTip6.Dock = DockStyle.Fill;
            lblTip6.Font = new Font("Segoe UI", 9.5F);
            lblTip6.ForeColor = Color.FromArgb(13, 47, 110);
            lblTip6.Location = new Point(49, 300);
            lblTip6.Margin = new Padding(0);
            lblTip6.Name = "lblTip6";
            lblTip6.Size = new Size(590, 60);
            lblTip6.TabIndex = 11;
            lblTip6.Text = "Ganti password secara berkala, misalnya setiap 3 bulan.";
            lblTip6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTipsJudul
            // 
            lblTipsJudul.BackColor = Color.Transparent;
            lblTipsJudul.Dock = DockStyle.Top;
            lblTipsJudul.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblTipsJudul.ForeColor = Color.FromArgb(13, 47, 110);
            lblTipsJudul.Location = new Point(23, 16);
            lblTipsJudul.Margin = new Padding(4, 0, 4, 0);
            lblTipsJudul.Name = "lblTipsJudul";
            lblTipsJudul.Size = new Size(639, 39);
            lblTipsJudul.TabIndex = 1;
            lblTipsJudul.Text = "Tips Membuat Password";
            lblTipsJudul.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // UC_GANTIPWKasir
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(234, 243, 252);
            Controls.Add(tlpRoot);
            Margin = new Padding(4, 3, 4, 3);
            Name = "UC_GANTIPWKasir";
            Size = new Size(1283, 629);
            tlpRoot.ResumeLayout(false);
            pnlJudul.ResumeLayout(false);
            pnlJudul.PerformLayout();
            tlpContent.ResumeLayout(false);
            pnlForm.ResumeLayout(false);
            tlpForm.ResumeLayout(false);
            tlpForm.PerformLayout();
            flowTombol.ResumeLayout(false);
            pnlTips.ResumeLayout(false);
            tlpTips.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpRoot;
        private RoundedPanelUI pnlJudul;
        private System.Windows.Forms.Label lblSub;
        private System.Windows.Forms.Label lblJudul;
        private System.Windows.Forms.TableLayoutPanel tlpContent;
        private RoundedPanelUI pnlForm;
        private System.Windows.Forms.TableLayoutPanel tlpForm;
        private System.Windows.Forms.Label lblLama;
        private System.Windows.Forms.TextBox txtLama;
        private System.Windows.Forms.Label lblBaru;
        private System.Windows.Forms.TextBox txtBaru;
        private System.Windows.Forms.Label lblKekuatan;
        private System.Windows.Forms.Label lblKonf;
        private System.Windows.Forms.TextBox txtKonf;
        private System.Windows.Forms.CheckBox chkTampil;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.FlowLayoutPanel flowTombol;
        private RoundedButtonUI btnSimpan;
        private RoundedButtonUI btnBatal;
        private System.Windows.Forms.Label lblFormJudul;
        private RoundedPanelUI pnlTips;
        private System.Windows.Forms.TableLayoutPanel tlpTips;
        private System.Windows.Forms.Label lblTipIkon1;
        private System.Windows.Forms.Label lblTip1;
        private System.Windows.Forms.Label lblTipIkon2;
        private System.Windows.Forms.Label lblTip2;
        private System.Windows.Forms.Label lblTipIkon3;
        private System.Windows.Forms.Label lblTip3;
        private System.Windows.Forms.Label lblTipIkon4;
        private System.Windows.Forms.Label lblTip4;
        private System.Windows.Forms.Label lblTipIkon5;
        private System.Windows.Forms.Label lblTip5;
        private System.Windows.Forms.Label lblTipIkon6;
        private System.Windows.Forms.Label lblTip6;
        private System.Windows.Forms.Label lblTipsJudul;
    }
}