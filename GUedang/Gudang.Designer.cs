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
            panelGudang.Location = new Point(0, -2);
            panelGudang.Name = "panelGudang";
            panelGudang.Size = new Size(617, 289);
            panelGudang.TabIndex = 0;
            panelGudang.Paint += panel1_Paint;
            // 
            // Gudang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(618, 286);
            Controls.Add(panelGudang);
            Name = "Gudang";
            Text = "Gudang";
            ResumeLayout(false);
        }

        #endregion

        private Panel panelGudang;
    }
}