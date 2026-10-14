namespace GUedang
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            label1 = new Label();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            button1 = new Button();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox21 = new TextBox();
            textBox3 = new TextBox();
            label2 = new Label();
            label5 = new Label();
            label8 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label1.Location = new Point(15, 108);
            label1.Name = "label1";
            label1.Size = new Size(178, 28);
            label1.TabIndex = 0;
            label1.Text = "Daftar Akun Baru";
            label1.Click += label1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(15, 27);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(69, 56);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(checkBox2);
            panel1.Controls.Add(checkBox1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(textBox5);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(textBox21);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(-3, -3);
            panel1.Name = "panel1";
            panel1.Size = new Size(270, 341);
            panel1.TabIndex = 13;
            panel1.Paint += panel1_Paint;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(199, 202);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(15, 14);
            checkBox2.TabIndex = 26;
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(199, 231);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(15, 14);
            checkBox1.TabIndex = 25;
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.HotTrack;
            button1.ForeColor = Color.White;
            button1.ImageKey = "(none)";
            button1.Location = new Point(15, 285);
            button1.Name = "button1";
            button1.Size = new Size(237, 30);
            button1.TabIndex = 24;
            button1.Text = "Daftar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(15, 256);
            textBox5.Name = "textBox5";
            textBox5.PlaceholderText = "📞  No.HP";
            textBox5.Size = new Size(178, 23);
            textBox5.TabIndex = 23;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(15, 227);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "🔒  Konfirmasi Password";
            textBox4.Size = new Size(178, 23);
            textBox4.TabIndex = 22;
            textBox4.UseSystemPasswordChar = true;
            // 
            // textBox21
            // 
            textBox21.Location = new Point(15, 198);
            textBox21.Name = "textBox21";
            textBox21.PlaceholderText = "🔒  Password";
            textBox21.Size = new Size(178, 23);
            textBox21.TabIndex = 15;
            textBox21.UseSystemPasswordChar = true;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(15, 169);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "👤  Username";
            textBox3.Size = new Size(178, 23);
            textBox3.TabIndex = 21;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 136);
            label2.Name = "label2";
            label2.Size = new Size(220, 15);
            label2.TabIndex = 19;
            label2.Text = "Buat akun untuk berbelanja di SMK Mart";
            // 
            // label5
            // 
            label5.BackColor = Color.White;
            label5.Font = new Font("Rockwell Condensed", 17F);
            label5.ForeColor = Color.Blue;
            label5.Location = new Point(136, 41);
            label5.Name = "label5";
            label5.Size = new Size(71, 29);
            label5.TabIndex = 18;
            label5.Text = "Mart";
            // 
            // label8
            // 
            label8.Font = new Font("Rockwell Condensed", 17F, FontStyle.Bold);
            label8.ForeColor = Color.Navy;
            label8.Location = new Point(90, 41);
            label8.Name = "label8";
            label8.Size = new Size(52, 29);
            label8.TabIndex = 17;
            label8.Text = "SMK ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(262, -3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(250, 341);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(510, 335);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Name = "Form4";
            Text = "Register";
            Load += Form4_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox2;
        private Panel panel1;
        private Label label8;
        private Label label5;
        private PictureBox pictureBox1;
        private Label label2;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox11;
        private TextBox textBox5;
        private TextBox textBox4;
        private Button button1;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private Label label4;
        private Label label3;
        private TextBox textBox21;
    }
}