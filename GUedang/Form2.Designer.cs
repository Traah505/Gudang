namespace GUedang
{
    partial class Form2
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
            button1 = new Button();
            label1 = new Label();
            lblAdmin = new Label();
            label3 = new Label();
            panel1 = new Panel();
            panel4 = new Panel();
            button5 = new Button();
            panel2 = new Panel();
            panel3 = new Panel();
            label2 = new Label();
            label4 = new Label();
            panel5 = new Panel();
            label5 = new Label();
            label6 = new Label();
            panel6 = new Panel();
            label7 = new Label();
            label8 = new Label();
            panel7 = new Panel();
            label9 = new Label();
            label10 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            panel8 = new Panel();
            label11 = new Label();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(631, 12);
            button1.Name = "button1";
            button1.Size = new Size(83, 23);
            button1.TabIndex = 0;
            button1.Text = "Logout/Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Gray;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label1.Location = new Point(204, 12);
            label1.Name = "label1";
            label1.Size = new Size(160, 20);
            label1.TabIndex = 2;
            label1.Text = "GUDANG SMK MART";
            label1.Click += label1_Click;
            // 
            // lblAdmin
            // 
            lblAdmin.AutoSize = true;
            lblAdmin.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblAdmin.Location = new Point(515, 16);
            lblAdmin.Name = "lblAdmin";
            lblAdmin.Size = new Size(49, 15);
            lblAdmin.TabIndex = 3;
            lblAdmin.Text = "Admin :";
            lblAdmin.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(33, 16);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 4;
            label3.Text = "Logs";
            label3.Click += label3_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gray;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(lblAdmin);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(49, 29);
            panel1.Name = "panel1";
            panel1.Size = new Size(724, 45);
            panel1.TabIndex = 5;
            // 
            // panel4
            // 
            panel4.Controls.Add(button5);
            panel4.Location = new Point(3, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(185, 239);
            panel4.TabIndex = 10;
            panel4.Paint += panel4_Paint;
            // 
            // button5
            // 
            button5.Location = new Point(33, 22);
            button5.Name = "button5";
            button5.Size = new Size(104, 23);
            button5.TabIndex = 5;
            button5.Text = "[D]Pengguna";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(204, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(90, 71);
            panel2.TabIndex = 9;
            panel2.Paint += panel2_Paint;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(192, 192, 255);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(panel8);
            panel3.Controls.Add(panel6);
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(panel7);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(panel2);
            panel3.Location = new Point(49, 70);
            panel3.Name = "panel3";
            panel3.Size = new Size(724, 314);
            panel3.TabIndex = 10;
            // 
            // label2
            // 
            label2.Location = new Point(3, 31);
            label2.Name = "label2";
            label2.Size = new Size(84, 19);
            label2.TabIndex = 0;
            label2.Text = "Total Barang";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(128, 128, 255);
            label4.Location = new Point(9, 51);
            label4.Name = "label4";
            label4.Size = new Size(14, 15);
            label4.TabIndex = 1;
            label4.Text = "0";
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(pictureBox4);
            panel5.Controls.Add(label5);
            panel5.Controls.Add(label6);
            panel5.Location = new Point(492, 12);
            panel5.Name = "panel5";
            panel5.Size = new Size(90, 71);
            panel5.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(192, 0, 192);
            label5.Location = new Point(9, 51);
            label5.Name = "label5";
            label5.Size = new Size(14, 15);
            label5.TabIndex = 1;
            label5.Text = "0";
            // 
            // label6
            // 
            label6.Location = new Point(3, 31);
            label6.Name = "label6";
            label6.Size = new Size(84, 19);
            label6.TabIndex = 0;
            label6.Text = "Total Transaksi";
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Controls.Add(pictureBox2);
            panel6.Controls.Add(label7);
            panel6.Controls.Add(label8);
            panel6.Location = new Point(300, 12);
            panel6.Name = "panel6";
            panel6.Size = new Size(90, 71);
            panel6.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.ForeColor = Color.Lime;
            label7.Location = new Point(9, 51);
            label7.Name = "label7";
            label7.Size = new Size(14, 15);
            label7.TabIndex = 1;
            label7.Text = "0";
            // 
            // label8
            // 
            label8.Location = new Point(3, 31);
            label8.Name = "label8";
            label8.Size = new Size(84, 19);
            label8.TabIndex = 0;
            label8.Text = "Stok Tersedia";
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.Controls.Add(pictureBox3);
            panel7.Controls.Add(label9);
            panel7.Controls.Add(label10);
            panel7.Location = new Point(396, 12);
            panel7.Name = "panel7";
            panel7.Size = new Size(90, 71);
            panel7.TabIndex = 10;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label9.ForeColor = Color.FromArgb(255, 128, 0);
            label9.Location = new Point(9, 51);
            label9.Name = "label9";
            label9.Size = new Size(14, 15);
            label9.TabIndex = 1;
            label9.Text = "0";
            // 
            // label10
            // 
            label10.Location = new Point(3, 31);
            label10.Name = "label10";
            label10.Size = new Size(84, 19);
            label10.TabIndex = 0;
            label10.Text = "Stok Menipis";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(9, 11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(20, 17);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(9, 11);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(20, 17);
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(9, 10);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(20, 17);
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Location = new Point(9, 11);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(20, 17);
            pictureBox4.TabIndex = 5;
            pictureBox4.TabStop = false;
            // 
            // panel8
            // 
            panel8.Location = new Point(204, 104);
            panel8.Name = "panel8";
            panel8.Size = new Size(375, 135);
            panel8.TabIndex = 11;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label11.Location = new Point(204, 86);
            label11.Name = "label11";
            label11.Size = new Size(98, 15);
            label11.TabIndex = 0;
            label11.Text = "Grafik Penjualan";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "Form2";
            Text = "DashboardAdmin";
            Load += Form2_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label lblAdmin;
        private Label label3;
        private Panel panel1;
        private FlowLayoutPanel flowLayoutPanel3;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Button button5;
        private Label label2;
        private Label label4;
        private Panel panel6;
        private Label label7;
        private Label label8;
        private Panel panel5;
        private Label label5;
        private Label label6;
        private Panel panel7;
        private Label label9;
        private Label label10;
        private PictureBox pictureBox1;
        private Panel panel8;
        private PictureBox pictureBox2;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private Label label11;
    }
}