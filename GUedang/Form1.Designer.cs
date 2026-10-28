namespace GUedang
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Login = new RoundedPanel();
            label1 = new Label();
            pictureBox6 = new PictureBox();
            pictureBox5 = new PictureBox();
            roundedTextBox2 = new RoundedTextBox();
            label12 = new Label();
            label4 = new Label();
            label11 = new Label();
            label2 = new Label();
            roundedTextBox1 = new RoundedTextBox();
            roundedButton1 = new RoundedButton();
            label5 = new Label();
            label7 = new Label();
            label10 = new Label();
            checkBox1 = new CheckBox();
            label9 = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
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
            Login.Controls.Add(label3);
            Login.Controls.Add(label1);
            Login.Controls.Add(pictureBox6);
            Login.Controls.Add(pictureBox5);
            Login.Controls.Add(roundedTextBox2);
            Login.Controls.Add(label12);
            Login.Controls.Add(label4);
            Login.Controls.Add(label11);
            Login.Controls.Add(label2);
            Login.Controls.Add(roundedTextBox1);
            Login.Controls.Add(roundedButton1);
            Login.Controls.Add(label5);
            Login.Controls.Add(label7);
            Login.Controls.Add(label10);
            Login.Controls.Add(checkBox1);
            Login.Controls.Add(label9);
            Login.ForeColor = Color.Black;
            Login.Location = new Point(283, 1);
            Login.Name = "Login";
            Login.Size = new Size(327, 348);
            Login.TabIndex = 27;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.ForeColor = Color.RoyalBlue;
            label1.Location = new Point(228, 257);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 28;
            label1.Text = "Daftar";
            label1.Click += label1_Click_2;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(67, 155);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(16, 16);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 27;
            pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.WhiteSmoke;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(67, 100);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(16, 16);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 27;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // roundedTextBox2
            // 
            roundedTextBox2.BackColor = Color.White;
            roundedTextBox2.BorderColor = Color.Navy;
            roundedTextBox2.Location = new Point(57, 118);
            roundedTextBox2.Margin = new Padding(2);
            roundedTextBox2.Name = "roundedTextBox2";
            roundedTextBox2.Size = new Size(210, 29);
            roundedTextBox2.TabIndex = 26;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.White;
            label12.BorderStyle = BorderStyle.Fixed3D;
            label12.Location = new Point(88, 99);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(41, 17);
            label12.TabIndex = 25;
            label12.Text = "Nama";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Location = new Point(83, 54);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(184, 15);
            label4.TabIndex = 15;
            label4.Text = "Silahkan login untuk melanjutkan";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.White;
            label11.BorderStyle = BorderStyle.Fixed3D;
            label11.Location = new Point(88, 154);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(54, 17);
            label11.TabIndex = 24;
            label11.Text = "Pasword";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.Location = new Point(116, 35);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(120, 19);
            label2.TabIndex = 13;
            label2.Text = "Selamat Datang!";
            // 
            // roundedTextBox1
            // 
            roundedTextBox1.BackColor = Color.White;
            roundedTextBox1.BorderColor = Color.Navy;
            roundedTextBox1.Location = new Point(57, 176);
            roundedTextBox1.Margin = new Padding(2);
            roundedTextBox1.Name = "roundedTextBox1";
            roundedTextBox1.Size = new Size(210, 29);
            roundedTextBox1.TabIndex = 23;
            // 
            // roundedButton1
            // 
            roundedButton1.BackColor = Color.CornflowerBlue;
            roundedButton1.FlatAppearance.BorderSize = 0;
            roundedButton1.FlatStyle = FlatStyle.Flat;
            roundedButton1.ForeColor = Color.White;
            roundedButton1.Location = new Point(83, 229);
            roundedButton1.Name = "roundedButton1";
            roundedButton1.Size = new Size(158, 25);
            roundedButton1.TabIndex = 19;
            roundedButton1.Text = "Login";
            roundedButton1.UseVisualStyleBackColor = false;
            roundedButton1.Click += roundedButton1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Segoe UI", 11F);
            label5.ForeColor = Color.Blue;
            label5.Location = new Point(152, 315);
            label5.Name = "label5";
            label5.Size = new Size(33, 20);
            label5.TabIndex = 0;
            label5.Text = "Exit";
            label5.Click += label5_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.White;
            label7.ForeColor = Color.Black;
            label7.Location = new Point(191, 207);
            label7.Name = "label7";
            label7.Size = new Size(86, 15);
            label7.TabIndex = 22;
            label7.Text = "Lihat Password";
            label7.Click += label7_Click_1;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.White;
            label10.Location = new Point(95, 300);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(146, 15);
            label10.TabIndex = 18;
            label10.Text = "Gudang - Stok - Penjualan";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(170, 209);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(15, 14);
            checkBox1.TabIndex = 8;
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged_2;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.White;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label9.Location = new Point(138, 285);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(63, 15);
            label9.TabIndex = 17;
            label9.Text = "SMK Mart";
            label9.Click += label9_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-1, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(287, 348);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 28;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(116, 257);
            label3.Name = "label3";
            label3.Size = new Size(111, 15);
            label3.TabIndex = 29;
            label3.Text = "Belum punya akun?";
            label3.Click += label3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(620, 344);
            Controls.Add(pictureBox1);
            Controls.Add(Login);
            ForeColor = Color.FromArgb(0, 192, 192);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Form1_Load;
            Login.ResumeLayout(false);
            Login.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private CheckBox checkBox1;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label10;
        private Label label9;
        private RoundedButton roundedButton1;
        private Label label7;
        private RoundedPanel Login;
        private Label label12;
        private Label label11;
        private RoundedTextBox roundedTextBox1;
        private RoundedTextBox roundedTextBox2;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label3;
    }
}
