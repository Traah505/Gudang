namespace GUedang
{
    partial class Kasir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kasir));
            panelKasirHalaman = new Panel();
            panel1 = new Panel();
            label7 = new Label();
            label6 = new Label();
            roundedButton1 = new RoundedButton();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelKasirHalaman
            // 
            panelKasirHalaman.Location = new Point(0, 77);
            panelKasirHalaman.Name = "panelKasirHalaman";
            panelKasirHalaman.Size = new Size(816, 380);
            panelKasirHalaman.TabIndex = 0;
            panelKasirHalaman.Paint += panelKasirHalaman_Paint;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label7);
            panel1.Controls.Add(panelKasirHalaman);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(roundedButton1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(1, -3);
            panel1.Name = "panel1";
            panel1.Size = new Size(817, 82);
            panel1.TabIndex = 6;
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI Semibold", 19F, FontStyle.Bold);
            label7.ForeColor = Color.Blue;
            label7.Location = new Point(144, 24);
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
            label6.ForeColor = Color.DodgerBlue;
            label6.Location = new Point(82, 24);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(70, 30);
            label6.TabIndex = 20;
            label6.Text = "SMK";
            // 
            // roundedButton1
            // 
            roundedButton1.BackColor = Color.RoyalBlue;
            roundedButton1.FlatAppearance.BorderSize = 0;
            roundedButton1.FlatStyle = FlatStyle.Flat;
            roundedButton1.ForeColor = Color.White;
            roundedButton1.Location = new Point(664, 24);
            roundedButton1.Name = "roundedButton1";
            roundedButton1.Size = new Size(139, 36);
            roundedButton1.TabIndex = 7;
            roundedButton1.Text = "Logout/Back";
            roundedButton1.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(82, 47);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 5;
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
            // Kasir
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(816, 380);
            Controls.Add(panel1);
            //FormBorderStyle = FormBorderStyle.None;
            Name = "Kasir";
            Text = "Kasir";
            Load += Kasir_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelKasirHalaman;
        private Panel panel1;
        private Label label7;
        private Label label6;
        private RoundedButton roundedButton1;
        private Label label2;
        private PictureBox pictureBox1;
    }
}