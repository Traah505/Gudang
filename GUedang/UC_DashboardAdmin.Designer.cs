namespace GUedang
{
    partial class UC_DashboardAdmin
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
            roundedButtonBarang = new RoundedButton();
            roundedButtonLaporan = new RoundedButton();
            roundedButtonUser = new RoundedButton();
            roundedButtonDashboard = new RoundedButton();
            roundedPanel1 = new RoundedPanel();
            roundedPanel2 = new RoundedPanel();
            panelContent2 = new RoundedPanel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateGray;
            panel1.Controls.Add(roundedButtonBarang);
            panel1.Controls.Add(roundedButtonLaporan);
            panel1.Controls.Add(roundedButtonUser);
            panel1.Controls.Add(roundedButtonDashboard);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(141, 323);
            panel1.TabIndex = 0;
            // 
            // roundedButtonBarang
            // 
            roundedButtonBarang.BackColor = Color.DarkSlateGray;
            roundedButtonBarang.FlatAppearance.BorderSize = 0;
            roundedButtonBarang.FlatStyle = FlatStyle.Flat;
            roundedButtonBarang.ForeColor = Color.White;
            roundedButtonBarang.Location = new Point(14, 111);
            roundedButtonBarang.Name = "roundedButtonBarang";
            roundedButtonBarang.Size = new Size(142, 40);
            roundedButtonBarang.TabIndex = 3;
            roundedButtonBarang.Text = "Barang";
            roundedButtonBarang.UseVisualStyleBackColor = false;
            // 
            // roundedButtonLaporan
            // 
            roundedButtonLaporan.BackColor = Color.DarkSlateGray;
            roundedButtonLaporan.FlatAppearance.BorderSize = 0;
            roundedButtonLaporan.FlatStyle = FlatStyle.Flat;
            roundedButtonLaporan.ForeColor = Color.White;
            roundedButtonLaporan.Location = new Point(14, 157);
            roundedButtonLaporan.Name = "roundedButtonLaporan";
            roundedButtonLaporan.Size = new Size(142, 40);
            roundedButtonLaporan.TabIndex = 2;
            roundedButtonLaporan.Text = "Laporan";
            roundedButtonLaporan.UseVisualStyleBackColor = false;
            // 
            // roundedButtonUser
            // 
            roundedButtonUser.BackColor = Color.DarkSlateGray;
            roundedButtonUser.FlatAppearance.BorderSize = 0;
            roundedButtonUser.FlatStyle = FlatStyle.Flat;
            roundedButtonUser.ForeColor = Color.White;
            roundedButtonUser.Location = new Point(14, 65);
            roundedButtonUser.Name = "roundedButtonUser";
            roundedButtonUser.Size = new Size(142, 40);
            roundedButtonUser.TabIndex = 1;
            roundedButtonUser.Text = "User";
            roundedButtonUser.UseVisualStyleBackColor = false;
            roundedButtonUser.Click += roundedButtonUser_Click_2;
            // 
            // roundedButtonDashboard
            // 
            roundedButtonDashboard.BackColor = Color.DarkSlateGray;
            roundedButtonDashboard.FlatAppearance.BorderSize = 0;
            roundedButtonDashboard.FlatStyle = FlatStyle.Flat;
            roundedButtonDashboard.ForeColor = Color.White;
            roundedButtonDashboard.Location = new Point(14, 19);
            roundedButtonDashboard.Name = "roundedButtonDashboard";
            roundedButtonDashboard.Size = new Size(142, 40);
            roundedButtonDashboard.TabIndex = 0;
            roundedButtonDashboard.Text = "Dashboard";
            roundedButtonDashboard.UseVisualStyleBackColor = false;
            roundedButtonDashboard.Click += roundedButtonDashboard_Click;
            // 
            // roundedPanel1
            // 
            roundedPanel1.BackColor = Color.Transparent;
            roundedPanel1.Location = new Point(458, 3);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Size = new Size(100, 173);
            roundedPanel1.TabIndex = 1;
            // 
            // roundedPanel2
            // 
            roundedPanel2.BackColor = Color.Transparent;
            roundedPanel2.Location = new Point(444, 192);
            roundedPanel2.Name = "roundedPanel2";
            roundedPanel2.Size = new Size(114, 95);
            roundedPanel2.TabIndex = 2;
            // 
            // panelContent2
            // 
            panelContent2.BackColor = Color.Transparent;
            panelContent2.Location = new Point(175, 79);
            panelContent2.Name = "panelContent2";
            panelContent2.Size = new Size(208, 193);
            panelContent2.TabIndex = 3;
            // 
            // UC_DashboardAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelContent2);
            Controls.Add(roundedPanel2);
            Controls.Add(roundedPanel1);
            Controls.Add(panel1);
            Name = "UC_DashboardAdmin";
            Size = new Size(736, 323);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }



        #endregion

        private Panel panel1;
        private RoundedPanel roundedPanel1;
        private RoundedButton roundedButtonDashboard;
        private RoundedPanel roundedPanel2;
        private RoundedButton roundedButtonBarang;
        private RoundedButton roundedButtonLaporan;
        private RoundedButton roundedButtonUser;
        private RoundedPanel panelContent2;
    }
}
