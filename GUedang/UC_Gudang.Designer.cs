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
            roundedButton1 = new RoundedButton();
            roundedButtonKLLABRGGudang = new RoundedButton();
            roundedButtonBRG = new RoundedButton();
            roundedButtonGudang = new RoundedButton();
            panelGudang = new RoundedPanel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.BackColor = Color.Navy;
            panel1.Controls.Add(roundedButton1);
            panel1.Controls.Add(roundedButtonKLLABRGGudang);
            panel1.Controls.Add(roundedButtonBRG);
            panel1.Controls.Add(roundedButtonGudang);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(141, 435);
            panel1.TabIndex = 1;
            // 
            // roundedButton1
            // 
            roundedButton1.BackColor = Color.Navy;
            roundedButton1.FlatAppearance.BorderSize = 0;
            roundedButton1.FlatStyle = FlatStyle.Flat;
            roundedButton1.ForeColor = Color.White;
            roundedButton1.Location = new Point(20, 153);
            roundedButton1.Name = "roundedButton1";
            roundedButton1.Size = new Size(142, 40);
            roundedButton1.TabIndex = 6;
            roundedButton1.Text = "Ganti password";
            roundedButton1.UseVisualStyleBackColor = false;
            // 
            // roundedButtonKLLABRGGudang
            // 
            roundedButtonKLLABRGGudang.BackColor = Color.Navy;
            roundedButtonKLLABRGGudang.FlatAppearance.BorderSize = 0;
            roundedButtonKLLABRGGudang.FlatStyle = FlatStyle.Flat;
            roundedButtonKLLABRGGudang.ForeColor = Color.White;
            roundedButtonKLLABRGGudang.Location = new Point(20, 107);
            roundedButtonKLLABRGGudang.Name = "roundedButtonKLLABRGGudang";
            roundedButtonKLLABRGGudang.Size = new Size(142, 40);
            roundedButtonKLLABRGGudang.TabIndex = 2;
            roundedButtonKLLABRGGudang.Text = "Kelola barang";
            roundedButtonKLLABRGGudang.UseVisualStyleBackColor = false;
            roundedButtonKLLABRGGudang.Click += roundedButtonKLLABRGGudang_Click;
            // 
            // roundedButtonBRG
            // 
            roundedButtonBRG.BackColor = Color.Navy;
            roundedButtonBRG.FlatAppearance.BorderSize = 0;
            roundedButtonBRG.FlatStyle = FlatStyle.Flat;
            roundedButtonBRG.ForeColor = Color.White;
            roundedButtonBRG.Location = new Point(20, 61);
            roundedButtonBRG.Name = "roundedButtonBRG";
            roundedButtonBRG.Size = new Size(142, 40);
            roundedButtonBRG.TabIndex = 1;
            roundedButtonBRG.Text = "Barang";
            roundedButtonBRG.UseVisualStyleBackColor = false;
            roundedButtonBRG.Click += roundedButtonBRG_Click;
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
        private RoundedButton roundedButtonBRG;
        private RoundedButton roundedButtonGudang;
        private RoundedPanel panelGudang;
        private RoundedButton roundedButtonKLLABRGGudang;
        private RoundedButton roundedButton1;
    }
}
