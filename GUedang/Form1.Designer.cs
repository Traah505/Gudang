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
            customTextBox1 = new CustomTextBox();
            customTextBox2 = new CustomTextBox();
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
            panel1.Location = new Point(182, -1);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(339, 368);
            panel1.TabIndex = 10;
            panel1.Paint += panel1_Paint;
            // 
            // roundedPanel1
            // 
            roundedPanel1.BackColor = Color.WhiteSmoke;
            roundedPanel1.Controls.Add(pictureBox4);
            roundedPanel1.Controls.Add(roundedButton1);
            roundedPanel1.Controls.Add(customTextBox1);
            roundedPanel1.Controls.Add(customTextBox2);
            roundedPanel1.Controls.Add(label3);
            roundedPanel1.Controls.Add(label1);
            roundedPanel1.Controls.Add(label5);
            roundedPanel1.Controls.Add(label7);
            roundedPanel1.Controls.Add(label10);
            roundedPanel1.Controls.Add(checkBox1);
            roundedPanel1.Controls.Add(label9);
            roundedPanel1.Location = new Point(10, 13);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Size = new Size(326, 336);
            roundedPanel1.TabIndex = 27;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.White;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(139, 36);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(64, 43);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 14;
            pictureBox4.TabStop = false;
            // 
            // roundedButton1
            // 
            roundedButton1.BackColor = Color.CornflowerBlue;
            roundedButton1.FlatAppearance.BorderSize = 0;
            roundedButton1.FlatStyle = FlatStyle.Flat;
            roundedButton1.ForeColor = Color.White;
            roundedButton1.Location = new Point(83, 213);
            roundedButton1.Name = "roundedButton1";
            roundedButton1.Size = new Size(184, 40);
            roundedButton1.TabIndex = 19;
            roundedButton1.Text = "Login";
            roundedButton1.UseVisualStyleBackColor = false;
            roundedButton1.Click += roundedButton1_Click;
            // 
            // customTextBox1
            // 
            customTextBox1.BackColor = Color.White;
            customTextBox1.Location = new Point(46, 119);
            customTextBox1.Name = "customTextBox1";
            customTextBox1.Padding = new Padding(10, 7, 10, 7);
            customTextBox1.Size = new Size(245, 31);
            customTextBox1.TabIndex = 20;
            customTextBox1.TextChanged += customTextBox1_TextChanged;
            // 
            // customTextBox2
            // 
            customTextBox2.BackColor = Color.White;
            customTextBox2.Location = new Point(46, 156);
            customTextBox2.Name = "customTextBox2";
            customTextBox2.Padding = new Padding(10, 7, 10, 7);
            customTextBox2.Size = new Size(245, 31);
            customTextBox2.TabIndex = 21;
            // 
            // label3
            // 
            label3.BackColor = Color.White;
            label3.Font = new Font("Microsoft Sans Serif", 28F);
            label3.ForeColor = Color.Blue;
            label3.Location = new Point(193, 37);
            label3.Name = "label3";
            label3.Size = new Size(98, 42);
            label3.TabIndex = 14;
            label3.Text = "Mart";
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.Font = new Font("Microsoft Sans Serif", 28F, FontStyle.Bold);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(46, 36);
            label1.Name = "label1";
            label1.Size = new Size(108, 42);
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
            label5.Location = new Point(152, 286);
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
            label7.Location = new Point(191, 192);
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
            label10.Location = new Point(100, 271);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(146, 15);
            label10.TabIndex = 18;
            label10.Text = "Gudang - Stok - Penjualan";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(170, 193);
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
            label9.Location = new Point(140, 256);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(63, 15);
            label9.TabIndex = 17;
            label9.Text = "SMK Mart";
            label9.Click += label9_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(34, 198);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(16, 16);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 26;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.WhiteSmoke;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(34, 145);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(16, 16);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 25;
            pictureBox2.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(49, 146);
            label8.Name = "label8";
            label8.Size = new Size(39, 15);
            label8.TabIndex = 24;
            label8.Text = "Nama";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(49, 199);
            label6.Name = "label6";
            label6.Size = new Size(57, 15);
            label6.TabIndex = 23;
            label6.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(63, 110);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(184, 15);
            label4.TabIndex = 15;
            label4.Text = "Silahkan login untuk melanjutkan";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.Location = new Point(93, 91);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(120, 19);
            label2.TabIndex = 13;
            label2.Text = "Selamat Datang!";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-1, -1);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(188, 368);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(522, 361);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
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
        private CustomTextBox customTextBox2;
        private CustomTextBox customTextBox1;
        private Label label7;
        private PictureBox pictureBox3;
        private RoundedPanel roundedPanel1;
        private PictureBox pictureBox4;
    }
}
