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
            roundedButtonRIWYTTRNKSIKasir = new RoundedButton();
            roundedButtonKRNJGBLNJKasir = new RoundedButton();
            roundedButtonDSHBRDKasir = new RoundedButton();
            panelKasir = new RoundedPanel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Navy;
            panel1.Controls.Add(roundedButtonRIWYTTRNKSIKasir);
            panel1.Controls.Add(roundedButtonKRNJGBLNJKasir);
            panel1.Controls.Add(roundedButtonDSHBRDKasir);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(141, 335);
            panel1.TabIndex = 1;
            // 
            // roundedButtonRIWYTTRNKSIKasir
            // 
            roundedButtonRIWYTTRNKSIKasir.BackColor = Color.Navy;
            roundedButtonRIWYTTRNKSIKasir.FlatAppearance.BorderSize = 0;
            roundedButtonRIWYTTRNKSIKasir.FlatStyle = FlatStyle.Flat;
            roundedButtonRIWYTTRNKSIKasir.ForeColor = Color.White;
            roundedButtonRIWYTTRNKSIKasir.Location = new Point(20, 132);
            roundedButtonRIWYTTRNKSIKasir.Name = "roundedButtonRIWYTTRNKSIKasir";
            roundedButtonRIWYTTRNKSIKasir.Size = new Size(142, 40);
            roundedButtonRIWYTTRNKSIKasir.TabIndex = 3;
            roundedButtonRIWYTTRNKSIKasir.Text = "Riwayat Transaksi";
            roundedButtonRIWYTTRNKSIKasir.UseVisualStyleBackColor = false;
            roundedButtonRIWYTTRNKSIKasir.Click += roundedButtonRIWYTTRNKSIKasir_Click;
            // 
            // roundedButtonKRNJGBLNJKasir
            // 
            roundedButtonKRNJGBLNJKasir.BackColor = Color.Navy;
            roundedButtonKRNJGBLNJKasir.FlatAppearance.BorderSize = 0;
            roundedButtonKRNJGBLNJKasir.FlatStyle = FlatStyle.Flat;
            roundedButtonKRNJGBLNJKasir.ForeColor = Color.White;
            roundedButtonKRNJGBLNJKasir.Location = new Point(20, 86);
            roundedButtonKRNJGBLNJKasir.Name = "roundedButtonKRNJGBLNJKasir";
            roundedButtonKRNJGBLNJKasir.Size = new Size(142, 40);
            roundedButtonKRNJGBLNJKasir.TabIndex = 1;
            roundedButtonKRNJGBLNJKasir.Text = "Keranjang Belanja";
            roundedButtonKRNJGBLNJKasir.UseVisualStyleBackColor = false;
            roundedButtonKRNJGBLNJKasir.Click += roundedButtonKRNJGBLNJKasir_Click;
            // 
            // roundedButtonDSHBRDKasir
            // 
            roundedButtonDSHBRDKasir.BackColor = Color.Navy;
            roundedButtonDSHBRDKasir.FlatAppearance.BorderSize = 0;
            roundedButtonDSHBRDKasir.FlatStyle = FlatStyle.Flat;
            roundedButtonDSHBRDKasir.ForeColor = Color.White;
            roundedButtonDSHBRDKasir.Location = new Point(20, 40);
            roundedButtonDSHBRDKasir.Name = "roundedButtonDSHBRDKasir";
            roundedButtonDSHBRDKasir.Size = new Size(142, 40);
            roundedButtonDSHBRDKasir.TabIndex = 0;
            roundedButtonDSHBRDKasir.Text = "Dashboard";
            roundedButtonDSHBRDKasir.UseVisualStyleBackColor = false;
            roundedButtonDSHBRDKasir.Click += roundedButtonDSHBRDKasir_Click;
            // 
            // panelKasir
            // 
            panelKasir.BackColor = Color.Transparent;
            panelKasir.Location = new Point(187, 3);
            panelKasir.Name = "panelKasir";
            panelKasir.Size = new Size(279, 286);
            panelKasir.TabIndex = 2;
            // 
            // UC_Kasir
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelKasir);
            Controls.Add(panel1);
            Name = "UC_Kasir";
            Size = new Size(634, 326);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private RoundedButton roundedButtonRIWYTTRNKSIKasir;
        private RoundedButton roundedButtonKRNJGBLNJKasir;
        private RoundedButton roundedButtonDSHBRDKasir;
        private RoundedPanel panelKasir;
    }
}
