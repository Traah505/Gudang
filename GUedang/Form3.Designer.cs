namespace GUedang
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            label5 = new Label();
            label8 = new Label();
            panel2 = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label8);
            panel1.Location = new Point(-1, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(121, 302);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(3, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(42, 30);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            // 
            // label5
            // 
            label5.BackColor = Color.White;
            label5.Font = new Font("Rockwell Condensed", 12F);
            label5.ForeColor = Color.Blue;
            label5.Location = new Point(83, 10);
            label5.Name = "label5";
            label5.Size = new Size(35, 20);
            label5.TabIndex = 19;
            label5.Text = "Mart";
            // 
            // label8
            // 
            label8.Font = new Font("Rockwell Condensed", 12F, FontStyle.Bold);
            label8.ForeColor = Color.Navy;
            label8.Location = new Point(47, 10);
            label8.Name = "label8";
            label8.Size = new Size(40, 19);
            label8.TabIndex = 18;
            label8.Text = "SMK ";
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Location = new Point(139, -1);
            panel2.Name = "panel2";
            panel2.Size = new Size(442, 302);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(16, 41);
            label1.Name = "label1";
            label1.Size = new Size(131, 15);
            label1.TabIndex = 0;
            label1.Text = "Selamat Datang, User!";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(993, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form3";
            Text = "DashboardPengguna";
            FormClosed += Form3_FormClosed;
            Load += Form3_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Label label8;
        private Label label5;
        private PictureBox pictureBox2;
    }
}