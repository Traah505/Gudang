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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Gudang));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            roundedButtonLogoutKsir = new RoundedButton();
            roundedButtonKLLABRGGudang = new RoundedButton();
            roundedButtonBRG = new RoundedButton();
            roundedButtonGudang = new RoundedButton();
            panelGudang = new RoundedPanel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Navy;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(roundedButtonLogoutKsir);
            panel1.Controls.Add(roundedButtonKLLABRGGudang);
            panel1.Controls.Add(roundedButtonBRG);
            panel1.Controls.Add(roundedButtonGudang);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(141, 477);
            panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(20, 13);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(98, 45);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // roundedButtonLogoutKsir
            // 
            roundedButtonLogoutKsir.BackColor = Color.Navy;
            roundedButtonLogoutKsir.FlatAppearance.BorderSize = 0;
            roundedButtonLogoutKsir.FlatStyle = FlatStyle.Flat;
            roundedButtonLogoutKsir.ForeColor = Color.White;
            roundedButtonLogoutKsir.Location = new Point(0, 414);
            roundedButtonLogoutKsir.Name = "roundedButtonLogoutKsir";
            roundedButtonLogoutKsir.Size = new Size(141, 43);
            roundedButtonLogoutKsir.TabIndex = 5;
            roundedButtonLogoutKsir.Text = "Logout";
            roundedButtonLogoutKsir.UseVisualStyleBackColor = false;
            roundedButtonLogoutKsir.Click += roundedButtonLogoutKsir_Click;
            // 
            // roundedButtonKLLABRGGudang
            // 
            roundedButtonKLLABRGGudang.BackColor = Color.Navy;
            roundedButtonKLLABRGGudang.FlatAppearance.BorderSize = 0;
            roundedButtonKLLABRGGudang.FlatStyle = FlatStyle.Flat;
            roundedButtonKLLABRGGudang.ForeColor = Color.White;
            roundedButtonKLLABRGGudang.Location = new Point(20, 155);
            roundedButtonKLLABRGGudang.Name = "roundedButtonKLLABRGGudang";
            roundedButtonKLLABRGGudang.Size = new Size(142, 40);
            roundedButtonKLLABRGGudang.TabIndex = 2;
            roundedButtonKLLABRGGudang.Text = "Kelola Barang";
            roundedButtonKLLABRGGudang.UseVisualStyleBackColor = false;
            roundedButtonKLLABRGGudang.Click += roundedButtonKLLABRGGudang_Click;
            // 
            // roundedButtonBRG
            // 
            roundedButtonBRG.BackColor = Color.Navy;
            roundedButtonBRG.FlatAppearance.BorderSize = 0;
            roundedButtonBRG.FlatStyle = FlatStyle.Flat;
            roundedButtonBRG.ForeColor = Color.White;
            roundedButtonBRG.Location = new Point(20, 109);
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
            roundedButtonGudang.Location = new Point(20, 63);
            roundedButtonGudang.Name = "roundedButtonGudang";
            roundedButtonGudang.Size = new Size(142, 40);
            roundedButtonGudang.TabIndex = 0;
            roundedButtonGudang.Text = "Dashboard";
            roundedButtonGudang.UseVisualStyleBackColor = false;
            roundedButtonGudang.Click += roundedButtonGudang_Click;
            // 
            // panelGudang
            // 
            panelGudang.BackColor = Color.Transparent;
            panelGudang.Location = new Point(168, 34);
            panelGudang.Name = "panelGudang";
            panelGudang.Size = new Size(1166, 423);
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
            Size = new Size(1337, 477);
            Load += UC_Gudang_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private RoundedButton roundedButtonBRG;
        private RoundedButton roundedButtonGudang;
        private RoundedPanel panelGudang;
        private RoundedButton roundedButtonKLLABRGGudang;
        private RoundedButton roundedButtonLogoutKsir;
        private PictureBox pictureBox1;
    }
}
