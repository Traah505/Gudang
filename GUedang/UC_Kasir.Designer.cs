namespace GUedang
{
    partial class UC_Kasir
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            roundedButton1 = new RoundedButton();
            roundedButtonRIWYTTRNKSIKasir = new RoundedButton();
            roundedButtonKRNJGBLNJKasir = new RoundedButton();
            roundedButtonDSHBRDKasir = new RoundedButton();
            panelKasir = new RoundedPanel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.BackColor = Color.Navy;
            panel1.Controls.Add(roundedButton1);
            panel1.Controls.Add(roundedButtonRIWYTTRNKSIKasir);
            panel1.Controls.Add(roundedButtonKRNJGBLNJKasir);
            panel1.Controls.Add(roundedButtonDSHBRDKasir);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(141, 214);
            panel1.TabIndex = 1;
            // 
            // roundedButton1
            // 
            roundedButton1.BackColor = Color.Navy;
            roundedButton1.FlatAppearance.BorderSize = 0;
            roundedButton1.FlatStyle = FlatStyle.Flat;
            roundedButton1.ForeColor = Color.White;
            roundedButton1.Location = new Point(17, 152);
            roundedButton1.Name = "roundedButton1";
            roundedButton1.Size = new Size(142, 40);
            roundedButton1.TabIndex = 6;
            roundedButton1.Text = "Ganti password";
            roundedButton1.UseVisualStyleBackColor = false;
            // 
            // roundedButtonRIWYTTRNKSIKasir
            // 
            roundedButtonRIWYTTRNKSIKasir.BackColor = Color.Navy;
            roundedButtonRIWYTTRNKSIKasir.FlatAppearance.BorderSize = 0;
            roundedButtonRIWYTTRNKSIKasir.FlatStyle = FlatStyle.Flat;
            roundedButtonRIWYTTRNKSIKasir.ForeColor = Color.White;
            roundedButtonRIWYTTRNKSIKasir.Location = new Point(17, 106);
            roundedButtonRIWYTTRNKSIKasir.Name = "roundedButtonRIWYTTRNKSIKasir";
            roundedButtonRIWYTTRNKSIKasir.Size = new Size(142, 40);
            roundedButtonRIWYTTRNKSIKasir.TabIndex = 3;
            roundedButtonRIWYTTRNKSIKasir.Text = "Riwayat transaksi";
            roundedButtonRIWYTTRNKSIKasir.UseVisualStyleBackColor = false;
            roundedButtonRIWYTTRNKSIKasir.Click += roundedButtonRIWYTTRNKSIKasir_Click;
            // 
            // roundedButtonKRNJGBLNJKasir
            // 
            roundedButtonKRNJGBLNJKasir.BackColor = Color.Navy;
            roundedButtonKRNJGBLNJKasir.FlatAppearance.BorderSize = 0;
            roundedButtonKRNJGBLNJKasir.FlatStyle = FlatStyle.Flat;
            roundedButtonKRNJGBLNJKasir.ForeColor = Color.White;
            roundedButtonKRNJGBLNJKasir.Location = new Point(17, 60);
            roundedButtonKRNJGBLNJKasir.Name = "roundedButtonKRNJGBLNJKasir";
            roundedButtonKRNJGBLNJKasir.Size = new Size(142, 40);
            roundedButtonKRNJGBLNJKasir.TabIndex = 1;
            roundedButtonKRNJGBLNJKasir.Text = "Keranjang belanja";
            roundedButtonKRNJGBLNJKasir.UseVisualStyleBackColor = false;
            roundedButtonKRNJGBLNJKasir.Click += roundedButtonKRNJGBLNJKasir_Click;
            // 
            // roundedButtonDSHBRDKasir
            // 
            roundedButtonDSHBRDKasir.BackColor = Color.Navy;
            roundedButtonDSHBRDKasir.FlatAppearance.BorderSize = 0;
            roundedButtonDSHBRDKasir.FlatStyle = FlatStyle.Flat;
            roundedButtonDSHBRDKasir.ForeColor = Color.White;
            roundedButtonDSHBRDKasir.Location = new Point(17, 15);
            roundedButtonDSHBRDKasir.Name = "roundedButtonDSHBRDKasir";
            roundedButtonDSHBRDKasir.Size = new Size(142, 40);
            roundedButtonDSHBRDKasir.TabIndex = 0;
            roundedButtonDSHBRDKasir.Text = "Dashboard";
            roundedButtonDSHBRDKasir.UseVisualStyleBackColor = false;
            roundedButtonDSHBRDKasir.Click += roundedButtonDSHBRDKasir_Click;
            // 
            // panelKasir
            // 
            panelKasir.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelKasir.BackColor = Color.Transparent;
            panelKasir.Location = new Point(147, 14);
            panelKasir.Name = "panelKasir";
            panelKasir.Size = new Size(689, 184);
            panelKasir.TabIndex = 2;
            panelKasir.Paint += panelKasir_Paint;
            // 
            // UC_Kasir
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelKasir);
            Controls.Add(panel1);
            Name = "UC_Kasir";
            Size = new Size(839, 212);
            Load += UC_Kasir_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private RoundedButton roundedButtonRIWYTTRNKSIKasir;
        private RoundedButton roundedButtonKRNJGBLNJKasir;
        private RoundedButton roundedButtonDSHBRDKasir;
        private RoundedPanel panelKasir;
        private RoundedButton roundedButton1;
    }
}
