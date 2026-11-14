namespace GUedang
{
    partial class Gudang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gudang));
            panelGudang = new Panel();
            panel1 = new Panel();
            panel2 = new Panel();
            label7 = new Label();
            label6 = new Label();
            roundedButton1 = new RoundedButton();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            lblGudang = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelGudang
            // 
            panelGudang.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelGudang.BackColor = Color.White;
            panelGudang.Location = new Point(0, 120);
            panelGudang.Margin = new Padding(4, 5, 4, 5);
            panelGudang.Name = "panelGudang";
            panelGudang.Size = new Size(1087, 662);
            panelGudang.TabIndex = 0;
            panelGudang.Paint += panel1_Paint;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(roundedButton1);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(lblGudang);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1087, 125);
            panel1.TabIndex = 6;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Location = new Point(424, 20);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(7, 90);
            panel2.TabIndex = 0;
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI Semibold", 19F, FontStyle.Bold);
            label7.ForeColor = Color.Blue;
            label7.Location = new Point(208, 28);
            label7.Name = "label7";
            label7.Size = new Size(104, 50);
            label7.TabIndex = 21;
            label7.Text = "Mart";
            // 
            // label6
            // 
            label6.BackColor = Color.White;
            label6.Font = new Font("Segoe UI Semibold", 19F, FontStyle.Bold);
            label6.ForeColor = Color.DodgerBlue;
            label6.Location = new Point(117, 28);
            label6.Name = "label6";
            label6.Size = new Size(100, 50);
            label6.TabIndex = 20;
            label6.Text = "SMK";
            // 
            // roundedButton1
            // 
            roundedButton1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            roundedButton1.BackColor = Color.RoyalBlue;
            roundedButton1.FlatAppearance.BorderSize = 0;
            roundedButton1.FlatStyle = FlatStyle.Flat;
            roundedButton1.ForeColor = Color.White;
            roundedButton1.Location = new Point(884, 28);
            roundedButton1.Margin = new Padding(4, 5, 4, 5);
            roundedButton1.Name = "roundedButton1";
            roundedButton1.Size = new Size(199, 60);
            roundedButton1.TabIndex = 7;
            roundedButton1.Text = "Keluar";
            roundedButton1.UseVisualStyleBackColor = false;
            roundedButton1.Click += roundedButton1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(449, 35);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(66, 53);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(117, 78);
            label2.Name = "label2";
            label2.Size = new Size(208, 25);
            label2.TabIndex = 5;
            label2.Text = "Selamat datang, Gudang";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(21, 28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(90, 75);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // lblGudang
            // 
            lblGudang.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblGudang.Location = new Point(521, 35);
            lblGudang.Margin = new Padding(4, 0, 4, 0);
            lblGudang.Name = "lblGudang";
            lblGudang.Size = new Size(153, 57);
            lblGudang.TabIndex = 3;
            lblGudang.Text = "Gudang :";
            lblGudang.Click += lblGudang_Click;
            // 
            // Gudang
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(panelGudang);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Gudang";
            Size = new Size(1087, 782);
            Load += Gudang_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelGudang;
        private Panel panel1;
        private Panel panel2;
        private Label label7;
        private Label label6;
        private RoundedButton roundedButton1;
        private PictureBox pictureBox2;
        private Label label2;
        private PictureBox pictureBox1;
        private Label lblGudang;
    }
}