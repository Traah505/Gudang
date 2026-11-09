namespace GUedang
{
    partial class LoginAkun

    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginAkun));
            Login = new RoundedPanel();
            pictureBox6 = new PictureBox();
            pictureBox5 = new PictureBox();
            txtNama = new RoundedTextBox();
            label12 = new Label();
            label4 = new Label();
            label11 = new Label();
            label2 = new Label();
            txtPassword = new RoundedTextBox();
            btnLogin = new RoundedButton();
            lblExit = new Label();
            label7 = new Label();
            label10 = new Label();
            chkLihatPassword = new CheckBox();
            label9 = new Label();
            pictureBox1 = new PictureBox();
            Login.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Login
            // 
            Login.BackColor = Color.WhiteSmoke;
            Login.BorderStyle = BorderStyle.Fixed3D;
            Login.Controls.Add(pictureBox6);
            Login.Controls.Add(pictureBox5);
            Login.Controls.Add(txtNama);
            Login.Controls.Add(label12);
            Login.Controls.Add(label4);
            Login.Controls.Add(label11);
            Login.Controls.Add(label2);
            Login.Controls.Add(txtPassword);
            Login.Controls.Add(btnLogin);
            Login.Controls.Add(lblExit);
            Login.Controls.Add(label7);
            Login.Controls.Add(label10);
            Login.Controls.Add(chkLihatPassword);
            Login.Controls.Add(label9);
            Login.ForeColor = Color.Black;
            Login.Location = new Point(404, 2);
            Login.Margin = new Padding(4, 5, 4, 5);
            Login.Name = "Login";
            Login.Size = new Size(465, 577);
            Login.TabIndex = 27;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(96, 247);
            pictureBox6.Margin = new Padding(4, 5, 4, 5);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(23, 27);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 27;
            pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.WhiteSmoke;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(96, 155);
            pictureBox5.Margin = new Padding(4, 5, 4, 5);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(23, 27);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 27;
            pictureBox5.TabStop = false;
            // 
            // txtNama
            // 
            txtNama.BackColor = Color.White;
            txtNama.BorderColor = Color.Navy;
            txtNama.Location = new Point(81, 185);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(300, 50);
            txtNama.TabIndex = 26;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.White;
            label12.BorderStyle = BorderStyle.Fixed3D;
            label12.Location = new Point(126, 153);
            label12.Name = "label12";
            label12.Size = new Size(61, 27);
            label12.TabIndex = 25;
            label12.Text = "Nama";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Location = new Point(119, 73);
            label4.Name = "label4";
            label4.Size = new Size(273, 25);
            label4.TabIndex = 15;
            label4.Text = "Silahkan login untuk melanjutkan";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.White;
            label11.BorderStyle = BorderStyle.Fixed3D;
            label11.Location = new Point(126, 245);
            label11.Name = "label11";
            label11.Size = new Size(81, 27);
            label11.TabIndex = 24;
            label11.Text = "Pasword";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.Location = new Point(163, 42);
            label2.Name = "label2";
            label2.Size = new Size(170, 28);
            label2.TabIndex = 13;
            label2.Text = "Selamat Datang!";
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.White;
            txtPassword.BorderColor = Color.Navy;
            txtPassword.Location = new Point(81, 282);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(300, 50);
            txtPassword.TabIndex = 23;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.CornflowerBlue;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(119, 370);
            btnLogin.Margin = new Padding(4, 5, 4, 5);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(226, 42);
            btnLogin.TabIndex = 19;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblExit
            // 
            lblExit.AutoSize = true;
            lblExit.BackColor = Color.White;
            lblExit.Font = new Font("Segoe UI", 11F);
            lblExit.ForeColor = Color.Blue;
            lblExit.Location = new Point(207, 503);
            lblExit.Margin = new Padding(4, 0, 4, 0);
            lblExit.Name = "lblExit";
            lblExit.Size = new Size(46, 30);
            lblExit.TabIndex = 0;
            lblExit.Text = "Exit";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.White;
            label7.ForeColor = Color.Black;
            label7.Location = new Point(273, 333);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(129, 25);
            label7.TabIndex = 22;
            label7.Text = "Lihat Password";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.White;
            label10.Location = new Point(126, 478);
            label10.Name = "label10";
            label10.Size = new Size(218, 25);
            label10.TabIndex = 18;
            label10.Text = "Gudang - Stok - Penjualan";
            // 
            // chkLihatPassword
            // 
            chkLihatPassword.AutoSize = true;
            chkLihatPassword.Location = new Point(243, 337);
            chkLihatPassword.Margin = new Padding(4, 5, 4, 5);
            chkLihatPassword.Name = "chkLihatPassword";
            chkLihatPassword.Size = new Size(22, 21);
            chkLihatPassword.TabIndex = 8;
            chkLihatPassword.UseVisualStyleBackColor = true;
            chkLihatPassword.CheckedChanged += chkLihatPassword_CheckedChanged_1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.White;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label9.Location = new Point(187, 453);
            label9.Name = "label9";
            label9.Size = new Size(98, 25);
            label9.TabIndex = 17;
            label9.Text = "SMK Mart";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-1, 2);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(410, 580);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 28;
            pictureBox1.TabStop = false;
            // 
            // LoginAkun
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(886, 582);
            Controls.Add(pictureBox1);
            Controls.Add(Login);
            ForeColor = Color.FromArgb(0, 192, 192);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "LoginAkun";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Login.ResumeLayout(false);
            Login.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private CheckBox chkLihatPassword;
        private Label label2;
        private Label label4;
        private Label lblExit;
        private Label label10;
        private Label label9;
        private RoundedButton btnLogin;
        private Label label7;
        private RoundedPanel Login;
        private Label label12;
        private Label label11;
        private RoundedTextBox txtPassword;
        private RoundedTextBox txtNama;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private PictureBox pictureBox1;
    }
}
