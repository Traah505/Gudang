namespace GUedang
{
    partial class Gudang
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
            panelGudang = new Panel();
            SuspendLayout();
            // 
            // panelGudang
            // 
            panelGudang.BackColor = Color.White;
            panelGudang.Location = new Point(0, 3);
            panelGudang.Name = "panelGudang";
            panelGudang.Size = new Size(998, 466);
            panelGudang.TabIndex = 0;
            panelGudang.Paint += panel1_Paint;
            // 
            // Gudang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(998, 469);
            Controls.Add(panelGudang);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Gudang";
            Text = "Gudang";
            Load += Gudang_Load;
            ResumeLayout(false);
        }

        #endregion

        private Panel panelGudang;
    }
}