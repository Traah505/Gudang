
namespace GUedang
{
    partial class LoginAkun
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginAkun));
            lblCopy = new Label();
            lblChip = new Label();
            btnExit = new Button();
            chkLihatPassword = new CheckBox();
            lblIconPass = new Label();
            lblPassword = new Label();
            lblIconNama = new Label();
            lblNama = new Label();
            lblSub = new Label();
            lblWelcome = new Label();
            picLogo = new PictureBox();
            lblTagline = new Label();
            lblHeadline = new Label();
            pnlLeft = new SmkGradientPanel();
            pnlRight = new SmkSoftPanel();
            txtPassword = new RoundedTextBox();
            txtNama = new RoundedTextBox();
            btnLogin = new SmkRoundButton();
            pnlChip = new SmkRoundPanel();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            pnlLeft.SuspendLayout();
            pnlRight.SuspendLayout();
            SuspendLayout();
            // 
            // lblCopy
            // 
            lblCopy.BackColor = Color.Transparent;
            lblCopy.Font = new Font("Segoe UI", 8.5F);
            lblCopy.ForeColor = Color.FromArgb(150, 160, 182);
            lblCopy.Location = new Point(70, 522);
            lblCopy.Name = "lblCopy";
            lblCopy.Size = new Size(380, 20);
            lblCopy.TabIndex = 10;
            lblCopy.Text = "© 2026 SMK Mart  •  Gudang · Stok · Penjualan";
            lblCopy.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblChip
            // 
            lblChip.AutoSize = true;
            lblChip.BackColor = Color.Transparent;
            lblChip.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblChip.ForeColor = Color.FromArgb(76, 102, 255);
            lblChip.Location = new Point(49, 35);
            lblChip.Name = "lblChip";
            lblChip.Size = new Size(112, 19);
            lblChip.TabIndex = 0;
            lblChip.Text = "●  LOGIN AKUN";
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.White;
            btnExit.Cursor = Cursors.Hand;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 228, 232);
            btnExit.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 240, 242);
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnExit.ForeColor = Color.FromArgb(220, 70, 90);
            btnExit.Location = new Point(70, 458);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(380, 32);
            btnExit.TabIndex = 9;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // chkLihatPassword
            // 
            chkLihatPassword.AutoSize = true;
            chkLihatPassword.BackColor = Color.Transparent;
            chkLihatPassword.Cursor = Cursors.Hand;
            chkLihatPassword.Font = new Font("Segoe UI", 9F);
            chkLihatPassword.ForeColor = Color.FromArgb(110, 122, 148);
            chkLihatPassword.Location = new Point(74, 358);
            chkLihatPassword.Name = "chkLihatPassword";
            chkLihatPassword.Size = new Size(105, 19);
            chkLihatPassword.TabIndex = 7;
            chkLihatPassword.Text = "Lihat Password";
            chkLihatPassword.UseVisualStyleBackColor = true;
            // 
            // lblIconPass
            // 
            lblIconPass.AutoSize = true;
            lblIconPass.BackColor = Color.Transparent;
            lblIconPass.Font = new Font("Segoe MDL2 Assets", 13F);
            lblIconPass.ForeColor = Color.FromArgb(76, 102, 255);
            lblIconPass.Location = new Point(20, 12);
            lblIconPass.Name = "lblIconPass";
            lblIconPass.Size = new Size(100, 23);
            lblIconPass.TabIndex = 1;
            lblIconPass.Text = "";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.BackColor = Color.Transparent;
            lblPassword.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblPassword.ForeColor = Color.FromArgb(60, 72, 100);
            lblPassword.Location = new Point(72, 272);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(66, 17);
            lblPassword.TabIndex = 5;
            lblPassword.Text = "Password";
            // 
            // lblIconNama
            // 
            lblIconNama.AutoSize = true;
            lblIconNama.BackColor = Color.Transparent;
            lblIconNama.Font = new Font("Segoe MDL2 Assets", 13F);
            lblIconNama.ForeColor = Color.FromArgb(76, 102, 255);
            lblIconNama.Location = new Point(20, 12);
            lblIconNama.Name = "lblIconNama";
            lblIconNama.Size = new Size(100, 23);
            lblIconNama.TabIndex = 1;
            lblIconNama.Text = "";
            // 
            // lblNama
            // 
            lblNama.AutoSize = true;
            lblNama.BackColor = Color.Transparent;
            lblNama.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblNama.ForeColor = Color.FromArgb(60, 72, 100);
            lblNama.Location = new Point(72, 182);
            lblNama.Name = "lblNama";
            lblNama.Size = new Size(44, 17);
            lblNama.TabIndex = 3;
            lblNama.Text = "Nama";
            // 
            // lblSub
            // 
            lblSub.AutoSize = true;
            lblSub.BackColor = Color.Transparent;
            lblSub.Font = new Font("Segoe UI", 10F);
            lblSub.ForeColor = Color.FromArgb(110, 122, 148);
            lblSub.Location = new Point(70, 136);
            lblSub.Name = "lblSub";
            lblSub.Size = new Size(204, 19);
            lblSub.TabIndex = 2;
            lblSub.Text = "Silakan login untuk melanjutkan";
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.BackColor = Color.Transparent;
            lblWelcome.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblWelcome.ForeColor = Color.FromArgb(22, 41, 94);
            lblWelcome.Location = new Point(66, 90);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(252, 41);
            lblWelcome.TabIndex = 1;
            lblWelcome.Text = "Selamat Datang!";
            // 
            // picLogo
            // 
            picLogo.BackColor = Color.Transparent;
            picLogo.Image = (Image)resources.GetObject("picLogo.Image");
            picLogo.Location = new Point(57, 26);
            picLogo.Margin = new Padding(4, 5, 4, 5);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(217, 97);
            picLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // lblTagline
            // 
            lblTagline.AutoSize = true;
            lblTagline.BackColor = Color.Transparent;
            lblTagline.Font = new Font("Segoe UI", 10.5F);
            lblTagline.ForeColor = Color.FromArgb(226, 236, 255);
            lblTagline.Location = new Point(40, 182);
            lblTagline.Name = "lblTagline";
            lblTagline.Size = new Size(213, 38);
            lblTagline.TabIndex = 1;
            lblTagline.Text = "Pantau gudang, stok barang, dan\r\npenjualan dalam satu aplikasi.";
            // 
            // lblHeadline
            // 
            lblHeadline.AutoSize = true;
            lblHeadline.BackColor = Color.Transparent;
            lblHeadline.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblHeadline.ForeColor = Color.White;
            lblHeadline.Location = new Point(36, 138);
            lblHeadline.Name = "lblHeadline";
            lblHeadline.Size = new Size(342, 37);
            lblHeadline.TabIndex = 0;
            lblHeadline.Text = "Kelola Toko Lebih Mudah";
            // 
            // pnlLeft
            // 
            pnlLeft.ColorBottom = Color.FromArgb(40, 175, 255);
            pnlLeft.ColorTop = Color.FromArgb(76, 102, 255);
            pnlLeft.Controls.Add(picLogo);
            pnlLeft.Controls.Add(lblHeadline);
            pnlLeft.Controls.Add(lblTagline);
            pnlLeft.FooterText = "Gudang   •   Stok   •   Penjualan";
            pnlLeft.Location = new Point(0, 0);
            pnlLeft.LogoCard = new Rectangle(28, 26, 280, 94);
            pnlLeft.Name = "pnlLeft";
            pnlLeft.Size = new Size(440, 580);
            pnlLeft.TabIndex = 1;
            // 
            // pnlRight
            // 
            pnlRight.AccentBottom = Color.FromArgb(40, 175, 255);
            pnlRight.AccentTop = Color.FromArgb(76, 102, 255);
            pnlRight.CardMarginX = 28;
            pnlRight.CardMarginY = 24;
            pnlRight.Controls.Add(txtPassword);
            pnlRight.Controls.Add(txtNama);
            pnlRight.Controls.Add(lblChip);
            pnlRight.Controls.Add(lblWelcome);
            pnlRight.Controls.Add(lblSub);
            pnlRight.Controls.Add(lblNama);
            pnlRight.Controls.Add(lblPassword);
            pnlRight.Controls.Add(chkLihatPassword);
            pnlRight.Controls.Add(btnLogin);
            pnlRight.Controls.Add(btnExit);
            pnlRight.Controls.Add(lblCopy);
            pnlRight.Location = new Point(440, 0);
            pnlRight.Name = "pnlRight";
            pnlRight.Size = new Size(520, 580);
            pnlRight.TabIndex = 0;
            pnlRight.Paint += pnlRight_Paint;
            // 
            // txtPassword
            // 
            txtPassword.BorderThickness = 2;
            txtPassword.Location = new Point(74, 290);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(376, 44);
            txtPassword.TabIndex = 12;
            // 
            // txtNama
            // 
            txtNama.BackgroundImageLayout = ImageLayout.Zoom;
            txtNama.BorderThickness = 2;
            txtNama.Location = new Point(74, 202);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(376, 44);
            txtNama.TabIndex = 11;
            // 
            // btnLogin
            // 
            btnLogin.ColorEnd = Color.FromArgb(40, 175, 255);
            btnLogin.ColorStart = Color.FromArgb(76, 102, 255);
            btnLogin.CornerRadius = 25;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(70, 399);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(380, 53);
            btnLogin.TabIndex = 8;
            btnLogin.Text = "LOGIN";
            btnLogin.Click += btnLogin_Click;
            // 
            // pnlChip
            // 
            pnlChip.BorderColor = Color.FromArgb(205, 215, 235);
            pnlChip.CornerRadius = 24;
            pnlChip.FillColor = Color.White;
            pnlChip.FocusColor = Color.FromArgb(76, 102, 255);
            pnlChip.Location = new Point(0, 0);
            pnlChip.Name = "pnlChip";
            pnlChip.Size = new Size(200, 100);
            pnlChip.TabIndex = 0;
            // 
            // LoginAkun
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(960, 570);
            Controls.Add(pnlRight);
            Controls.Add(pnlLeft);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginAkun";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SMK Mart - Login";
            Load += LoginAkun_Load;
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            pnlLeft.ResumeLayout(false);
            pnlLeft.PerformLayout();
            pnlRight.ResumeLayout(false);
            pnlRight.PerformLayout();
            ResumeLayout(false);

            // Sambungkan event sesuai nama method di LoginAkun.cs kamu, contoh:
            // this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // this.chkLihat.CheckedChanged += new System.EventHandler(this.chkLihat_CheckedChanged);
        }

        #endregion

        private SmkSoftPanel pnlRight;
        private System.Windows.Forms.Label lblCopy;
        private SmkRoundPanel pnlChip;
        private System.Windows.Forms.Label lblChip;
        private System.Windows.Forms.Button btnExit;
        private SmkRoundButton btnLogin;
        private System.Windows.Forms.CheckBox chkLihatPassword;
        private System.Windows.Forms.Label lblIconPass;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblIconNama;
        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.Label lblSub;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.PictureBox picLogo;
        private SmkGradientPanel pnlLeft;
        private System.Windows.Forms.Label lblTagline;
        private System.Windows.Forms.Label lblHeadline;
        private RoundedTextBox txtPassword;
        private RoundedTextBox txtNama;
    }
}