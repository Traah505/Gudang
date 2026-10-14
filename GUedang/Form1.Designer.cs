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
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            panel1 = new Panel();
            label10 = new Label();
            label9 = new Label();
            label4 = new Label();
            label12 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label7 = new Label();
            checkBox1 = new CheckBox();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.HotTrack;
            button1.ForeColor = Color.White;
            button1.ImageKey = "(none)";
            button1.Location = new Point(31, 214);
            button1.Name = "button1";
            button1.Size = new Size(237, 30);
            button1.TabIndex = 0;
            button1.Text = "Log in";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(31, 184);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "🔒  Password";
            textBox1.Size = new Size(237, 23);
            textBox1.TabIndex = 2;
            textBox1.UseSystemPasswordChar = true;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(31, 155);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "👤  Username";
            textBox2.Size = new Size(237, 23);
            textBox2.TabIndex = 3;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(checkBox1);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(270, -3);
            panel1.Name = "panel1";
            panel1.Size = new Size(342, 370);
            panel1.TabIndex = 10;
            panel1.Paint += panel1_Paint;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(96, 294);
            label10.Name = "label10";
            label10.Size = new Size(146, 15);
            label10.TabIndex = 18;
            label10.Text = "Gudang - Stok - Penjualan";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label9.Location = new Point(136, 279);
            label9.Name = "label9";
            label9.Size = new Size(63, 15);
            label9.TabIndex = 17;
            label9.Text = "SMK Mart";
            label9.Click += label9_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(84, 112);
            label4.Name = "label4";
            label4.Size = new Size(184, 15);
            label4.TabIndex = 15;
            label4.Text = "Silahkan login untuk melanjutkan";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(44, 247);
            label12.Name = "label12";
            label12.Size = new Size(127, 15);
            label12.TabIndex = 9;
            label12.Text = "Belum memiliki akun? ";
            label12.Click += label12_Click;
            // 
            // label3
            // 
            label3.BackColor = Color.White;
            label3.Font = new Font("Rockwell Condensed", 28F);
            label3.ForeColor = Color.Blue;
            label3.Location = new Point(170, 34);
            label3.Name = "label3";
            label3.Size = new Size(98, 42);
            label3.TabIndex = 14;
            label3.Text = "Mart";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.Location = new Point(110, 93);
            label2.Name = "label2";
            label2.Size = new Size(120, 19);
            label2.TabIndex = 13;
            label2.Text = "Selamat Datang!";
            // 
            // label1
            // 
            label1.Font = new Font("Rockwell Condensed", 28F, FontStyle.Bold);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(96, 34);
            label1.Name = "label1";
            label1.Size = new Size(86, 42);
            label1.TabIndex = 12;
            label1.Text = "SMK ";
            label1.Click += label1_Click_1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.ForeColor = Color.DodgerBlue;
            label7.Location = new Point(167, 247);
            label7.Name = "label7";
            label7.Size = new Size(75, 15);
            label7.TabIndex = 10;
            label7.Text = "daftar di sini";
            label7.Click += label7_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(274, 188);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(15, 14);
            checkBox1.TabIndex = 8;
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged_2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-1, -30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(277, 397);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(612, 367);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Panel panel1;
        private CheckBox checkBox1;
        private Label label6;
        private Label label7;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Panel panel2;
        private PictureBox pictureBox2;
        private Label label12;
        private Label label5;
        private Label label8;
        private Label label10;
        private Label label9;
        private PictureBox pictureBox1;
    }
}
