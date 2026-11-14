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
            roundedButton1 = new RoundedButton();
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
            panel1.Controls.Add(roundedButton1);
            panel1.Controls.Add(roundedButtonBRGMSK);
            panel1.Controls.Add(roundedButtonGudang);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(201, 725);
            panel1.TabIndex = 1;
            // 
            // roundedButtonStok
            // 
            roundedButtonStok.BackColor = Color.Navy;
            roundedButtonStok.FlatAppearance.BorderSize = 0;
            roundedButtonStok.FlatStyle = FlatStyle.Flat;
            roundedButtonStok.ForeColor = Color.White;
            roundedButtonStok.Location = new Point(29, 243);
            roundedButtonStok.Margin = new Padding(4, 5, 4, 5);
            roundedButtonStok.Name = "roundedButtonStok";
            roundedButtonStok.Size = new Size(203, 67);
            roundedButtonStok.TabIndex = 8;
            roundedButtonStok.Text = "Stok Barang";
            roundedButtonStok.UseVisualStyleBackColor = false;
            // 
            // roundedButtonBRGKLR
            // 
            roundedButtonBRGKLR.BackColor = Color.Navy;
            roundedButtonBRGKLR.FlatAppearance.BorderSize = 0;
            roundedButtonBRGKLR.FlatStyle = FlatStyle.Flat;
            roundedButtonBRGKLR.ForeColor = Color.White;
            roundedButtonBRGKLR.Location = new Point(29, 166);
            roundedButtonBRGKLR.Margin = new Padding(4, 5, 4, 5);
            roundedButtonBRGKLR.Name = "roundedButtonBRGKLR";
            roundedButtonBRGKLR.Size = new Size(203, 67);
            roundedButtonBRGKLR.TabIndex = 7;
            roundedButtonBRGKLR.Text = "Barang Keluar";
            roundedButtonBRGKLR.UseVisualStyleBackColor = false;
            // 
            // roundedButton1
            // 
            roundedButton1.BackColor = Color.Navy;
            roundedButton1.FlatAppearance.BorderSize = 0;
            roundedButton1.FlatStyle = FlatStyle.Flat;
            roundedButton1.ForeColor = Color.White;
            roundedButton1.Location = new Point(29, 307);
            roundedButton1.Margin = new Padding(4, 5, 4, 5);
            roundedButton1.Name = "roundedButton1";
            roundedButton1.Size = new Size(203, 67);
            roundedButton1.TabIndex = 6;
            roundedButton1.Text = "Ganti password";
            roundedButton1.UseVisualStyleBackColor = false;
            // 
            // roundedButtonBRGMSK
            // 
            roundedButtonBRGMSK.BackColor = Color.Navy;
            roundedButtonBRGMSK.FlatAppearance.BorderSize = 0;
            roundedButtonBRGMSK.FlatStyle = FlatStyle.Flat;
            roundedButtonBRGMSK.ForeColor = Color.White;
            roundedButtonBRGMSK.Location = new Point(29, 102);
            roundedButtonBRGMSK.Margin = new Padding(4, 5, 4, 5);
            roundedButtonBRGMSK.Name = "roundedButtonBRGMSK";
            roundedButtonBRGMSK.Size = new Size(203, 67);
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
            roundedButtonGudang.Location = new Point(29, 25);
            roundedButtonGudang.Margin = new Padding(4, 5, 4, 5);
            roundedButtonGudang.Name = "roundedButtonGudang";
            roundedButtonGudang.Size = new Size(203, 67);
            roundedButtonGudang.TabIndex = 0;
            roundedButtonGudang.Text = "Dashboard";
            roundedButtonGudang.UseVisualStyleBackColor = false;
            roundedButtonGudang.Click += roundedButtonGudang_Click;
            // 
            // panelGudang
            // 
            panelGudang.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelGudang.BackColor = Color.Transparent;
            panelGudang.Location = new Point(210, 5);
            panelGudang.Margin = new Padding(4, 5, 4, 5);
            panelGudang.Name = "panelGudang";
            panelGudang.Size = new Size(1009, 705);
            panelGudang.TabIndex = 2;
            // 
            // UC_Gudang
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            Controls.Add(panelGudang);
            Controls.Add(panel1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "UC_Gudang";
            Size = new Size(1264, 725);
            Load += UC_Gudang_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private RoundedButton roundedButtonBRGMSK;
        private RoundedButton roundedButtonGudang;
        private RoundedPanel panelGudang;
        private RoundedButton roundedButton1;
        private RoundedButton roundedButtonBRGKLR;
        private RoundedButton roundedButtonStok;
    }
}
