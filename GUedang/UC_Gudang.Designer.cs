namespace GUedang
{
    partial class UC_Gudang
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
            roundedButtonStok = new RoundedButton();
            roundedButtonBRGKLR = new RoundedButton();
            roundedButtonGNTPWGD = new RoundedButton();
            roundedButtonBRGMSK = new RoundedButton();
            roundedButtonGudang = new RoundedButton();
            panelGudang = new RoundedPanel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.BackColor = Color.Navy;
            panel1.Controls.Add(roundedButtonStok);
            panel1.Controls.Add(roundedButtonBRGKLR);
            panel1.Controls.Add(roundedButtonGNTPWGD);
            panel1.Controls.Add(roundedButtonBRGMSK);
            panel1.Controls.Add(roundedButtonGudang);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(141, 435);
            panel1.TabIndex = 1;
            // 
            // roundedButtonStok
            // 
            roundedButtonStok.BackColor = Color.Navy;
            roundedButtonStok.FlatAppearance.BorderSize = 0;
            roundedButtonStok.FlatStyle = FlatStyle.Flat;
            roundedButtonStok.ForeColor = Color.White;
            roundedButtonStok.Location = new Point(20, 153);
            roundedButtonStok.Name = "roundedButtonStok";
            roundedButtonStok.Size = new Size(142, 40);
            roundedButtonStok.TabIndex = 8;
            roundedButtonStok.Text = "Stok Barang";
            roundedButtonStok.UseVisualStyleBackColor = false;
            roundedButtonStok.Click += roundedButtonStok_Click;
            // 
            // roundedButtonBRGKLR
            // 
            roundedButtonBRGKLR.BackColor = Color.Navy;
            roundedButtonBRGKLR.FlatAppearance.BorderSize = 0;
            roundedButtonBRGKLR.FlatStyle = FlatStyle.Flat;
            roundedButtonBRGKLR.ForeColor = Color.White;
            roundedButtonBRGKLR.Location = new Point(20, 107);
            roundedButtonBRGKLR.Name = "roundedButtonBRGKLR";
            roundedButtonBRGKLR.Size = new Size(142, 40);
            roundedButtonBRGKLR.TabIndex = 7;
            roundedButtonBRGKLR.Text = "Barang Keluar";
            roundedButtonBRGKLR.UseVisualStyleBackColor = false;
            roundedButtonBRGKLR.Click += roundedButtonBRGKLR_Click;
            // 
            // roundedButtonGNTPWGD
            // 
            roundedButtonGNTPWGD.BackColor = Color.Navy;
            roundedButtonGNTPWGD.FlatAppearance.BorderSize = 0;
            roundedButtonGNTPWGD.FlatStyle = FlatStyle.Flat;
            roundedButtonGNTPWGD.ForeColor = Color.White;
            roundedButtonGNTPWGD.Location = new Point(20, 199);
            roundedButtonGNTPWGD.Name = "roundedButtonGNTPWGD";
            roundedButtonGNTPWGD.Size = new Size(142, 40);
            roundedButtonGNTPWGD.TabIndex = 6;
            roundedButtonGNTPWGD.Text = "Ganti password";
            roundedButtonGNTPWGD.UseVisualStyleBackColor = false;
            roundedButtonGNTPWGD.Click += roundedButtonGNTPWGD_Click;
            // 
            // roundedButtonBRGMSK
            // 
            roundedButtonBRGMSK.BackColor = Color.Navy;
            roundedButtonBRGMSK.FlatAppearance.BorderSize = 0;
            roundedButtonBRGMSK.FlatStyle = FlatStyle.Flat;
            roundedButtonBRGMSK.ForeColor = Color.White;
            roundedButtonBRGMSK.Location = new Point(20, 61);
            roundedButtonBRGMSK.Name = "roundedButtonBRGMSK";
            roundedButtonBRGMSK.Size = new Size(142, 40);
            roundedButtonBRGMSK.TabIndex = 1;
            roundedButtonBRGMSK.Text = "Barang Masuk";
            roundedButtonBRGMSK.UseVisualStyleBackColor = false;
            roundedButtonBRGMSK.Click += roundedButtonBRG_Click;
            // 
            // roundedButtonGudang
            // 
            roundedButtonGudang.BackColor = Color.Navy;
            roundedButtonGudang.FlatAppearance.BorderSize = 0;
            roundedButtonGudang.FlatStyle = FlatStyle.Flat;
            roundedButtonGudang.ForeColor = Color.White;
            roundedButtonGudang.Location = new Point(20, 15);
            roundedButtonGudang.Name = "roundedButtonGudang";
            roundedButtonGudang.Size = new Size(142, 40);
            roundedButtonGudang.TabIndex = 0;
            roundedButtonGudang.Text = "Dashboard";
            roundedButtonGudang.UseVisualStyleBackColor = false;
            roundedButtonGudang.Click += roundedButtonGudang_Click;
            // 
            // panelGudang
            // 
            panelGudang.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelGudang.BackColor = Color.Transparent;
            panelGudang.Location = new Point(147, 3);
            panelGudang.Name = "panelGudang";
            panelGudang.Size = new Size(706, 423);
            panelGudang.TabIndex = 2;
            // 
            // UC_Gudang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            Controls.Add(panelGudang);
            Controls.Add(panel1);
            Name = "UC_Gudang";
            Size = new Size(885, 435);
            Load += UC_Gudang_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private RoundedButton roundedButtonBRGMSK;
        private RoundedButton roundedButtonGudang;
        private RoundedPanel panelGudang;
        private RoundedButton roundedButtonGNTPWGD;
        private RoundedButton roundedButtonBRGKLR;
        private RoundedButton roundedButtonStok;
    }
}
