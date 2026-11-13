namespace GUedang
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            lblAdmin = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            label7 = new Label();
            label6 = new Label();
            roundedButton1 = new RoundedButton();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            panelContent = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblAdmin
            // 
            lblAdmin.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblAdmin.Location = new Point(365, 21);
            lblAdmin.Name = "lblAdmin";
            lblAdmin.Size = new Size(93, 34);
            lblAdmin.TabIndex = 3;
            lblAdmin.Text = "Admin :";
            lblAdmin.Click += label2_Click;
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
            panel1.Controls.Add(lblAdmin);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(761, 82);
            panel1.TabIndex = 5;
            panel1.Paint += panel1_Paint;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Location = new Point(297, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(5, 54);
            panel2.TabIndex = 0;
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI Semibold", 19F, FontStyle.Bold);
            label7.ForeColor = Color.LightSkyBlue;
            label7.Location = new Point(140, 17);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(73, 30);
            label7.TabIndex = 21;
            label7.Text = "Mart";
            // 
            // label6
            // 
            label6.BackColor = Color.White;
            label6.Font = new Font("Segoe UI Semibold", 19F, FontStyle.Bold);
            label6.ForeColor = Color.Navy;
            label6.Location = new Point(82, 17);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(70, 30);
            label6.TabIndex = 20;
            label6.Text = "SMK";
            label6.Click += label6_Click;
            // 
            // roundedButton1
            // 
            roundedButton1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            roundedButton1.BackColor = Color.RoyalBlue;
            roundedButton1.FlatAppearance.BorderSize = 0;
            roundedButton1.FlatStyle = FlatStyle.Flat;
            roundedButton1.ForeColor = Color.White;
            roundedButton1.Location = new Point(616, 19);
            roundedButton1.Name = "roundedButton1";
            roundedButton1.Size = new Size(139, 36);
            roundedButton1.TabIndex = 7;
            roundedButton1.Text = "Keluar";
            roundedButton1.UseVisualStyleBackColor = false;
            roundedButton1.Click += roundedButton1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(314, 21);
            pictureBox2.Margin = new Padding(2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(46, 32);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(82, 47);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(131, 15);
            label2.TabIndex = 5;
            label2.Text = "Selamat datang, Admin";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(15, 17);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(63, 45);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // panelContent
            // 
            panelContent.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelContent.BackColor = Color.WhiteSmoke;
            panelContent.Location = new Point(-1, 74);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(758, 328);
            panelContent.TabIndex = 10;
            panelContent.Paint += panel3_Paint;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            Controls.Add(panelContent);
            Controls.Add(panel1);
            Name = "Admin";
            Size = new Size(758, 400);
            Load += Form2_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label lblAdmin;
        private Panel panel1;
        private FlowLayoutPanel flowLayoutPanel3;
        private Panel panelContent;
        private Label label2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private RoundedButton roundedButton1;
        private Label label7;
        private Label label6;
        private Panel panel2;
    }
}