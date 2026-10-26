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
            panel1 = new Panel();
            roundedPanel1 = new RoundedPanel();
            pictureBox4 = new PictureBox();
            roundedButton1 = new RoundedButton();
            label3 = new Label();
            label1 = new Label();
            label5 = new Label();
            label7 = new Label();
            label10 = new Label();
            checkBox1 = new CheckBox();
            label9 = new Label();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            label8 = new Label();
            label6 = new Label();
            label4 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            roundedTextBox1 = new RoundedTextBox();
            label11 = new Label();
            label12 = new Label();
            roundedTextBox2 = new RoundedTextBox();
            panel1.SuspendLayout();
            roundedPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightBlue;
            panel1.Controls.Add(roundedPanel1);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(260, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(484, 613);
            panel1.TabIndex = 10;
            panel1.Paint += panel1_Paint;
            // 
            // roundedPanel1
            // 
            roundedPanel1.BackColor = Color.WhiteSmoke;
            roundedPanel1.BorderStyle = BorderStyle.Fixed3D;
            roundedPanel1.Controls.Add(roundedTextBox2);
            roundedPanel1.Controls.Add(label12);
            roundedPanel1.Controls.Add(label11);
            roundedPanel1.Controls.Add(roundedTextBox1);
            roundedPanel1.Controls.Add(pictureBox4);
            roundedPanel1.Controls.Add(roundedButton1);
            roundedPanel1.Controls.Add(label3);
            roundedPanel1.Controls.Add(label1);
            roundedPanel1.Controls.Add(label5);
            roundedPanel1.Controls.Add(label7);
            roundedPanel1.Controls.Add(label10);
            roundedPanel1.Controls.Add(checkBox1);
            roundedPanel1.Controls.Add(label9);
            roundedPanel1.Location = new Point(14, 5);
            roundedPanel1.Margin = new Padding(4, 5, 4, 5);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Size = new Size(466, 595);
            roundedPanel1.TabIndex = 27;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.White;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(199, 32);
            pictureBox4.Margin = new Padding(4, 5, 4, 5);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(91, 72);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 14;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // roundedButton1
            // 
            roundedButton1.BackColor = Color.CornflowerBlue;
            roundedButton1.FlatAppearance.BorderSize = 0;
            roundedButton1.FlatStyle = FlatStyle.Flat;
            roundedButton1.ForeColor = Color.White;
            roundedButton1.Location = new Point(132, 413);
            roundedButton1.Margin = new Padding(4, 5, 4, 5);
            roundedButton1.Name = "roundedButton1";
            roundedButton1.Size = new Size(215, 41);
            roundedButton1.TabIndex = 19;
            roundedButton1.Text = "Login";
            roundedButton1.UseVisualStyleBackColor = false;
            roundedButton1.Click += roundedButton1_Click;
            // 
            // label3
            // 
            label3.BackColor = Color.White;
            label3.Font = new Font("Microsoft Sans Serif", 28F);
            label3.ForeColor = Color.Blue;
            label3.Location = new Point(285, 32);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(140, 70);
            label3.TabIndex = 14;
            label3.Text = "Mart";
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.Font = new Font("Microsoft Sans Serif", 28F, FontStyle.Bold);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(66, 30);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(154, 70);
            label1.TabIndex = 12;
            label1.Text = "SMK";
            label1.Click += label1_Click_1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Segoe UI", 11F);
            label5.ForeColor = Color.Blue;
            label5.Location = new Point(210, 535);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(46, 30);
            label5.TabIndex = 0;
            label5.Text = "Exit";
            label5.Click += label5_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.White;
            label7.ForeColor = Color.Black;
            label7.Location = new Point(273, 345);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(129, 25);
            label7.TabIndex = 22;
            label7.Text = "Lihat Password";
            label7.Click += label7_Click_1;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.White;
            label10.Location = new Point(129, 510);
            label10.Name = "label10";
            label10.Size = new Size(218, 25);
            label10.TabIndex = 18;
            label10.Text = "Gudang - Stok - Penjualan";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(243, 349);
            checkBox1.Margin = new Padding(4, 5, 4, 5);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(22, 21);
            checkBox1.TabIndex = 8;
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged_2;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.White;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label9.Location = new Point(189, 474);
            label9.Name = "label9";
            label9.Size = new Size(98, 25);
            label9.TabIndex = 17;
            label9.Text = "SMK Mart";
            label9.Click += label9_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(49, 330);
            pictureBox3.Margin = new Padding(4, 5, 4, 5);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(23, 27);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 26;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.WhiteSmoke;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(49, 242);
            pictureBox2.Margin = new Padding(4, 5, 4, 5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(23, 27);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 25;
            pictureBox2.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(70, 243);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(59, 25);
            label8.TabIndex = 24;
            label8.Text = "Nama";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(70, 332);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(87, 25);
            label6.TabIndex = 23;
            label6.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(90, 183);
            label4.Name = "label4";
            label4.Size = new Size(273, 25);
            label4.TabIndex = 15;
            label4.Text = "Silahkan login untuk melanjutkan";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.Location = new Point(133, 152);
            label2.Name = "label2";
            label2.Size = new Size(170, 28);
            label2.TabIndex = 13;
            label2.Text = "Selamat Datang!";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-1, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(280, 613);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // roundedTextBox1
            // 
            roundedTextBox1.BackColor = Color.WhiteSmoke;
            roundedTextBox1.BorderColor = Color.Navy;
            roundedTextBox1.Location = new Point(82, 293);
            roundedTextBox1.Name = "roundedTextBox1";
            roundedTextBox1.Size = new Size(300, 48);
            roundedTextBox1.TabIndex = 23;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.White;
            label11.BorderStyle = BorderStyle.Fixed3D;
            label11.Location = new Point(84, 263);
            label11.Name = "label11";
            label11.Size = new Size(81, 27);
            label11.TabIndex = 24;
            label11.Text = "Pasword";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.White;
            label12.BorderStyle = BorderStyle.Fixed3D;
            label12.Location = new Point(84, 168);
            label12.Name = "label12";
            label12.Size = new Size(61, 27);
            label12.TabIndex = 25;
            label12.Text = "Nama";
            // 
            // roundedTextBox2
            // 
            roundedTextBox2.BackColor = Color.WhiteSmoke;
            roundedTextBox2.BorderColor = Color.Navy;
            roundedTextBox2.Location = new Point(82, 196);
            roundedTextBox2.Name = "roundedTextBox2";
            roundedTextBox2.Size = new Size(300, 48);
            roundedTextBox2.TabIndex = 26;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(746, 602);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            roundedPanel1.ResumeLayout(false);
            roundedPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private CheckBox checkBox1;
        private Label label6;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox2;
        private Label label5;
        private Label label8;
        private Label label10;
        private Label label9;
        private PictureBox pictureBox1;
        private RoundedButton roundedButton1;
        private Label label7;
        private PictureBox pictureBox3;
        private RoundedPanel roundedPanel1;
        private PictureBox pictureBox4;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label12;
        private Label label11;
        private RoundedTextBox roundedTextBox1;
        private RoundedTextBox roundedTextBox2;
    }
}
