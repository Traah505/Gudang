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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_DashboardAdmin));
            panel1 = new Panel();
            roundedButtonBarang = new RoundedButton();
            roundedButtonLaporan = new RoundedButton();
            roundedButtonUser = new RoundedButton();
            roundedButtonDashboard = new RoundedButton();
            panelJUmlahUser = new RoundedPanel();
            roundedPanel2 = new RoundedPanel();
            panelContent2 = new RoundedPanel();
            label1 = new Label();
            label2 = new Label();
            dgvRequestUser = new DataGridView();
            colNo = new DataGridViewTextBoxColumn();
            colNama = new DataGridViewTextBoxColumn();
            colJenis = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            colAksi = new DataGridViewButtonColumn();
            lblJumlahUser = new Label();
            lblKasir = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label4 = new Label();
            pictureBox3 = new PictureBox();
            label5 = new Label();
            roundedButton1 = new RoundedButton();
            panel1.SuspendLayout();
            panelJUmlahUser.SuspendLayout();
            roundedPanel2.SuspendLayout();
            panelContent2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRequestUser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
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
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(201, 538);
            panel1.TabIndex = 0;
            // 
            // roundedButtonBarang
            // 
            roundedButtonBarang.BackColor = Color.DarkSlateGray;
            roundedButtonBarang.FlatAppearance.BorderSize = 0;
            roundedButtonBarang.FlatStyle = FlatStyle.Flat;
            roundedButtonBarang.ForeColor = Color.White;
            roundedButtonBarang.Location = new Point(20, 185);
            roundedButtonBarang.Margin = new Padding(4, 5, 4, 5);
            roundedButtonBarang.Name = "roundedButtonBarang";
            roundedButtonBarang.Size = new Size(203, 67);
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
            roundedButtonLaporan.Location = new Point(20, 262);
            roundedButtonLaporan.Margin = new Padding(4, 5, 4, 5);
            roundedButtonLaporan.Name = "roundedButtonLaporan";
            roundedButtonLaporan.Size = new Size(203, 67);
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
            roundedButtonUser.Location = new Point(20, 108);
            roundedButtonUser.Margin = new Padding(4, 5, 4, 5);
            roundedButtonUser.Name = "roundedButtonUser";
            roundedButtonUser.Size = new Size(203, 67);
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
            roundedButtonDashboard.Location = new Point(20, 32);
            roundedButtonDashboard.Margin = new Padding(4, 5, 4, 5);
            roundedButtonDashboard.Name = "roundedButtonDashboard";
            roundedButtonDashboard.Size = new Size(203, 67);
            roundedButtonDashboard.TabIndex = 0;
            roundedButtonDashboard.Text = "Dashboard";
            roundedButtonDashboard.UseVisualStyleBackColor = false;
            roundedButtonDashboard.Click += roundedButtonDashboard_Click;
            // 
            // panelJUmlahUser
            // 
            panelJUmlahUser.BackColor = Color.Transparent;
            panelJUmlahUser.BorderStyle = BorderStyle.FixedSingle;
            panelJUmlahUser.Controls.Add(pictureBox2);
            panelJUmlahUser.Controls.Add(pictureBox1);
            panelJUmlahUser.Controls.Add(label3);
            panelJUmlahUser.Controls.Add(lblKasir);
            panelJUmlahUser.Controls.Add(lblJumlahUser);
            panelJUmlahUser.Location = new Point(837, 77);
            panelJUmlahUser.Margin = new Padding(4, 5, 4, 5);
            panelJUmlahUser.Name = "panelJUmlahUser";
            panelJUmlahUser.Padding = new Padding(10);
            panelJUmlahUser.Size = new Size(175, 222);
            panelJUmlahUser.TabIndex = 1;
            panelJUmlahUser.Paint += roundedPanel1_Paint;
            // 
            // roundedPanel2
            // 
            roundedPanel2.BackColor = Color.RoyalBlue;
            roundedPanel2.Controls.Add(roundedButton1);
            roundedPanel2.Controls.Add(label5);
            roundedPanel2.Location = new Point(837, 357);
            roundedPanel2.Margin = new Padding(4, 5, 4, 5);
            roundedPanel2.Name = "roundedPanel2";
            roundedPanel2.Size = new Size(175, 137);
            roundedPanel2.TabIndex = 2;
            // 
            // panelContent2
            // 
            panelContent2.BackColor = Color.Transparent;
            panelContent2.Controls.Add(dgvRequestUser);
            panelContent2.Controls.Add(label2);
            panelContent2.Location = new Point(250, 68);
            panelContent2.Margin = new Padding(4, 5, 4, 5);
            panelContent2.Name = "panelContent2";
            panelContent2.Size = new Size(551, 435);
            panelContent2.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(278, 16);
            label1.Name = "label1";
            label1.Size = new Size(255, 39);
            label1.TabIndex = 4;
            label1.Text = "Dashboard Admin";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cascadia Code SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(28, 9);
            label2.Name = "label2";
            label2.Size = new Size(252, 32);
            label2.TabIndex = 5;
            label2.Text = "Data Request User";
            // 
            // dgvRequestUser
            // 
            dgvRequestUser.AllowUserToAddRows = false;
            dgvRequestUser.AllowUserToDeleteRows = false;
            dgvRequestUser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRequestUser.BackgroundColor = Color.WhiteSmoke;
            dgvRequestUser.BorderStyle = BorderStyle.None;
            dgvRequestUser.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.SteelBlue;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvRequestUser.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvRequestUser.ColumnHeadersHeight = 40;
            dgvRequestUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvRequestUser.Columns.AddRange(new DataGridViewColumn[] { colNo, colNama, colJenis, colStatus, colAksi });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = Color.DimGray;
            dataGridViewCellStyle6.Padding = new Padding(6);
            dataGridViewCellStyle6.SelectionBackColor = Color.AliceBlue;
            dataGridViewCellStyle6.SelectionForeColor = Color.MidnightBlue;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvRequestUser.DefaultCellStyle = dataGridViewCellStyle6;
            dgvRequestUser.EnableHeadersVisualStyles = false;
            dgvRequestUser.GridColor = Color.Gainsboro;
            dgvRequestUser.Location = new Point(28, 63);
            dgvRequestUser.MultiSelect = false;
            dgvRequestUser.Name = "dgvRequestUser";
            dgvRequestUser.ReadOnly = true;
            dgvRequestUser.RowHeadersVisible = false;
            dgvRequestUser.RowHeadersWidth = 62;
            dgvRequestUser.RowTemplate.Height = 38;
            dgvRequestUser.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRequestUser.Size = new Size(498, 351);
            dgvRequestUser.TabIndex = 6;
            // 
            // colNo
            // 
            colNo.FillWeight = 50F;
            colNo.HeaderText = "No";
            colNo.MinimumWidth = 8;
            colNo.Name = "colNo";
            colNo.ReadOnly = true;
            // 
            // colNama
            // 
            colNama.FillWeight = 150F;
            colNama.HeaderText = "Nama";
            colNama.MinimumWidth = 8;
            colNama.Name = "colNama";
            colNama.ReadOnly = true;
            // 
            // colJenis
            // 
            colJenis.FillWeight = 80F;
            colJenis.HeaderText = "Jenis";
            colJenis.MinimumWidth = 8;
            colJenis.Name = "colJenis";
            colJenis.ReadOnly = true;
            // 
            // colStatus
            // 
            colStatus.FillWeight = 80F;
            colStatus.HeaderText = "Status";
            colStatus.MinimumWidth = 8;
            colStatus.Name = "colStatus";
            colStatus.ReadOnly = true;
            // 
            // colAksi
            // 
            colAksi.FillWeight = 70F;
            colAksi.HeaderText = "Aksi";
            colAksi.MinimumWidth = 8;
            colAksi.Name = "colAksi";
            colAksi.ReadOnly = true;
            // 
            // lblJumlahUser
            // 
            lblJumlahUser.AutoSize = true;
            lblJumlahUser.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblJumlahUser.Location = new Point(13, 10);
            lblJumlahUser.Name = "lblJumlahUser";
            lblJumlahUser.Size = new Size(124, 28);
            lblJumlahUser.TabIndex = 0;
            lblJumlahUser.Text = "Jumlah User";
            lblJumlahUser.Click += lblJumlahUser_Click;
            // 
            // lblKasir
            // 
            lblKasir.AutoSize = true;
            lblKasir.Font = new Font("Calibri Light", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblKasir.Location = new Point(50, 73);
            lblKasir.Name = "lblKasir";
            lblKasir.Size = new Size(48, 24);
            lblKasir.TabIndex = 1;
            lblKasir.Text = "Kasir";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri Light", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(50, 141);
            label3.Name = "label3";
            label3.Size = new Size(71, 24);
            label3.TabIndex = 2;
            label3.Text = "Gudang";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(13, 62);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(31, 35);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(13, 130);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(31, 35);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(940, 16);
            label4.Name = "label4";
            label4.Size = new Size(72, 28);
            label4.TabIndex = 5;
            label4.Text = "Admin";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(903, 9);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(31, 35);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(14, 26);
            label5.Name = "label5";
            label5.Size = new Size(90, 28);
            label5.TabIndex = 6;
            label5.Text = "Shortcut";
            label5.Click += label5_Click;
            // 
            // roundedButton1
            // 
            roundedButton1.BackColor = Color.RoyalBlue;
            roundedButton1.FlatAppearance.BorderSize = 0;
            roundedButton1.FlatStyle = FlatStyle.Flat;
            roundedButton1.ForeColor = Color.White;
            roundedButton1.Location = new Point(14, 77);
            roundedButton1.Name = "roundedButton1";
            roundedButton1.Size = new Size(141, 38);
            roundedButton1.TabIndex = 7;
            roundedButton1.Text = "Buat Pasword";
            roundedButton1.TextAlign = ContentAlignment.TopCenter;
            roundedButton1.UseVisualStyleBackColor = false;
            // 
            // UC_DashboardAdmin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            Controls.Add(pictureBox3);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(panelContent2);
            Controls.Add(roundedPanel2);
            Controls.Add(panelJUmlahUser);
            Controls.Add(panel1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "UC_DashboardAdmin";
            Size = new Size(1051, 538);
            panel1.ResumeLayout(false);
            panelJUmlahUser.ResumeLayout(false);
            panelJUmlahUser.PerformLayout();
            roundedPanel2.ResumeLayout(false);
            roundedPanel2.PerformLayout();
            panelContent2.ResumeLayout(false);
            panelContent2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRequestUser).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private Panel panel1;
        private RoundedPanel panelJUmlahUser;
        private RoundedButton roundedButtonDashboard;
        private RoundedPanel roundedPanel2;
        private RoundedButton roundedButtonBarang;
        private RoundedButton roundedButtonLaporan;
        private RoundedButton roundedButtonUser;
        private RoundedPanel panelContent2;
        private DataGridView dgvRequestUser;
        private Label label2;
        private Label label1;
        private DataGridViewTextBoxColumn colNo;
        private DataGridViewTextBoxColumn colNama;
        private DataGridViewTextBoxColumn colJenis;
        private DataGridViewTextBoxColumn colStatus;
        private DataGridViewButtonColumn colAksi;
        private Label lblJumlahUser;
        private PictureBox pictureBox1;
        private Label label3;
        private Label lblKasir;
        private PictureBox pictureBox2;
        private Label label4;
        private RoundedButton roundedButton1;
        private Label label5;
        private PictureBox pictureBox3;
    }
}
