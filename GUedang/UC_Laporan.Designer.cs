namespace GUedang
{
    partial class UC_Laporan
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
            lblTitleLaporan = new Label();
            roundedPanel1 = new RoundedPanel();
            roundedPanel2 = new RoundedPanel();
            SuspendLayout();
            // 
            // lblTitleLaporan
            // 
            lblTitleLaporan.AutoSize = true;
            lblTitleLaporan.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitleLaporan.ForeColor = Color.Navy;
            lblTitleLaporan.Location = new Point(221, 29);
            lblTitleLaporan.Name = "lblTitleLaporan";
            lblTitleLaporan.Size = new Size(121, 38);
            lblTitleLaporan.TabIndex = 0;
            lblTitleLaporan.Text = "Laporan";
            // 
            // roundedPanel1
            // 
            roundedPanel1.BackColor = Color.Transparent;
            roundedPanel1.Location = new Point(232, 84);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Size = new Size(737, 107);
            roundedPanel1.TabIndex = 1;
            // 
            // roundedPanel2
            // 
            roundedPanel2.BackColor = Color.Transparent;
            roundedPanel2.Location = new Point(442, 257);
            roundedPanel2.Name = "roundedPanel2";
            roundedPanel2.Size = new Size(525, 200);
            roundedPanel2.TabIndex = 2;
            // 
            // UC_Laporan
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(roundedPanel2);
            Controls.Add(roundedPanel1);
            Controls.Add(lblTitleLaporan);
            Name = "UC_Laporan";
            Size = new Size(1021, 533);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitleLaporan;
        private RoundedPanel roundedPanel1;
        private RoundedPanel roundedPanel2;
    }
}
