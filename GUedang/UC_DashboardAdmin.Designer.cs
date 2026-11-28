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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_DashboardAdmin));
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panel1 = new Panel();
            roundedButtonLaporan = new RoundedButton();
            roundedButtonLaba = new RoundedButton();
            roundedButtonLaporanAktivitas = new RoundedButton();
            roundedButtonRiwayat = new RoundedButton();
            pictureBox1 = new PictureBox();
            roundedButtonBarang = new RoundedButton();
            roundedButtonUser = new RoundedButton();
            roundedButtonDashboard = new RoundedButton();
            panelContent2 = new RoundedPanel();
            dgvRequestUser = new DataGridView();
            colNo = new DataGridViewTextBoxColumn();
            colNama = new DataGridViewTextBoxColumn();
            colJenis = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            colAksi = new DataGridViewButtonColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelContent2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRequestUser).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.BackColor = Color.Navy;
            panel1.Controls.Add(roundedButtonLaporan);
            panel1.Controls.Add(roundedButtonLaba);
            panel1.Controls.Add(roundedButtonLaporanAktivitas);
            panel1.Controls.Add(roundedButtonRiwayat);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(roundedButtonBarang);
            panel1.Controls.Add(roundedButtonUser);
            panel1.Controls.Add(roundedButtonDashboard);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(148, 406);
            panel1.TabIndex = 0;
            // 
            // roundedButtonLaporan
            // 
            roundedButtonLaporan.BackColor = Color.Navy;
            roundedButtonLaporan.FlatAppearance.BorderSize = 0;
            roundedButtonLaporan.FlatStyle = FlatStyle.Flat;
            roundedButtonLaporan.ForeColor = Color.White;
            roundedButtonLaporan.Location = new Point(20, 153);
            roundedButtonLaporan.Name = "roundedButtonLaporan";
            roundedButtonLaporan.Size = new Size(142, 40);
            roundedButtonLaporan.TabIndex = 2;
            roundedButtonLaporan.Text = "Laporan Penjualan";
            roundedButtonLaporan.UseVisualStyleBackColor = false;
            roundedButtonLaporan.Click += roundedButtonLaporan_Click_1;
            // 
            // roundedButtonLaba
            // 
            roundedButtonLaba.BackColor = Color.Navy;
            roundedButtonLaba.FlatAppearance.BorderSize = 0;
            roundedButtonLaba.FlatStyle = FlatStyle.Flat;
            roundedButtonLaba.ForeColor = Color.White;
            roundedButtonLaba.Location = new Point(20, 286);
            roundedButtonLaba.Name = "roundedButtonLaba";
            roundedButtonLaba.Size = new Size(142, 40);
            roundedButtonLaba.TabIndex = 7;
            roundedButtonLaba.Text = "Laporan Laba";
            roundedButtonLaba.UseVisualStyleBackColor = false;
            roundedButtonLaba.Click += roundedButtonLaba_Click;
            // 
            // roundedButtonLaporanAktivitas
            // 
            roundedButtonLaporanAktivitas.BackColor = Color.Navy;
            roundedButtonLaporanAktivitas.FlatAppearance.BorderSize = 0;
            roundedButtonLaporanAktivitas.FlatStyle = FlatStyle.Flat;
            roundedButtonLaporanAktivitas.ForeColor = Color.White;
            roundedButtonLaporanAktivitas.Location = new Point(20, 240);
            roundedButtonLaporanAktivitas.Name = "roundedButtonLaporanAktivitas";
            roundedButtonLaporanAktivitas.Size = new Size(142, 40);
            roundedButtonLaporanAktivitas.TabIndex = 6;
            roundedButtonLaporanAktivitas.Text = "Log Aktivitas";
            roundedButtonLaporanAktivitas.UseVisualStyleBackColor = false;
            roundedButtonLaporanAktivitas.Click += roundedButtonLaporanAktivitas_Click;
            // 
            // roundedButtonRiwayat
            // 
            roundedButtonRiwayat.BackColor = Color.Navy;
            roundedButtonRiwayat.FlatAppearance.BorderSize = 0;
            roundedButtonRiwayat.FlatStyle = FlatStyle.Flat;
            roundedButtonRiwayat.ForeColor = Color.White;
            roundedButtonRiwayat.Location = new Point(20, 194);
            roundedButtonRiwayat.Name = "roundedButtonRiwayat";
            roundedButtonRiwayat.Size = new Size(142, 40);
            roundedButtonRiwayat.TabIndex = 5;
            roundedButtonRiwayat.Text = "Riwayat Gudang";
            roundedButtonRiwayat.UseVisualStyleBackColor = false;
            roundedButtonRiwayat.Click += roundedButtonRiwayat_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 150);
            pictureBox1.Margin = new Padding(2, 2, 2, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(148, 254);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // roundedButtonBarang
            // 
            roundedButtonBarang.BackColor = Color.Navy;
            roundedButtonBarang.FlatAppearance.BorderSize = 0;
            roundedButtonBarang.FlatStyle = FlatStyle.Flat;
            roundedButtonBarang.ForeColor = Color.White;
            roundedButtonBarang.Location = new Point(20, 107);
            roundedButtonBarang.Name = "roundedButtonBarang";
            roundedButtonBarang.Size = new Size(142, 40);
            roundedButtonBarang.TabIndex = 3;
            roundedButtonBarang.Text = "Kelola Barang";
            roundedButtonBarang.UseVisualStyleBackColor = false;
            roundedButtonBarang.Click += roundedButtonBarang_Click_1;
            // 
            // roundedButtonUser
            // 
            roundedButtonUser.BackColor = Color.Navy;
            roundedButtonUser.FlatAppearance.BorderSize = 0;
            roundedButtonUser.FlatStyle = FlatStyle.Flat;
            roundedButtonUser.ForeColor = Color.White;
            roundedButtonUser.Location = new Point(20, 61);
            roundedButtonUser.Name = "roundedButtonUser";
            roundedButtonUser.Size = new Size(142, 40);
            roundedButtonUser.TabIndex = 1;
            roundedButtonUser.Text = "Kelola Pengguna";
            roundedButtonUser.UseVisualStyleBackColor = false;
            roundedButtonUser.Click += roundedButtonUser_Click_2;
            // 
            // roundedButtonDashboard
            // 
            roundedButtonDashboard.BackColor = Color.Navy;
            roundedButtonDashboard.FlatAppearance.BorderSize = 0;
            roundedButtonDashboard.FlatStyle = FlatStyle.Flat;
            roundedButtonDashboard.ForeColor = Color.White;
            roundedButtonDashboard.Location = new Point(20, 15);
            roundedButtonDashboard.Name = "roundedButtonDashboard";
            roundedButtonDashboard.Size = new Size(142, 40);
            roundedButtonDashboard.TabIndex = 0;
            roundedButtonDashboard.Text = "Dashboard";
            roundedButtonDashboard.UseVisualStyleBackColor = false;
            roundedButtonDashboard.Click += roundedButtonDashboard_Click;
            // 
            // panelContent2
            // 
            panelContent2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelContent2.BackColor = Color.Transparent;
            panelContent2.Controls.Add(dgvRequestUser);
            panelContent2.Location = new Point(154, 3);
            panelContent2.Name = "panelContent2";
            panelContent2.Size = new Size(893, 395);
            panelContent2.TabIndex = 3;
            panelContent2.Paint += panelContent2_Paint;
            // 
            // dgvRequestUser
            // 
            dgvRequestUser.AllowUserToAddRows = false;
            dgvRequestUser.AllowUserToDeleteRows = false;
            dgvRequestUser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRequestUser.BackgroundColor = Color.WhiteSmoke;
            dgvRequestUser.BorderStyle = BorderStyle.None;
            dgvRequestUser.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.SteelBlue;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvRequestUser.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvRequestUser.ColumnHeadersHeight = 40;
            dgvRequestUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvRequestUser.Columns.AddRange(new DataGridViewColumn[] { colNo, colNama, colJenis, colStatus, colAksi });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.DimGray;
            dataGridViewCellStyle4.Padding = new Padding(6);
            dataGridViewCellStyle4.SelectionBackColor = Color.AliceBlue;
            dataGridViewCellStyle4.SelectionForeColor = Color.MidnightBlue;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvRequestUser.DefaultCellStyle = dataGridViewCellStyle4;
            dgvRequestUser.EnableHeadersVisualStyles = false;
            dgvRequestUser.GridColor = Color.Gainsboro;
            dgvRequestUser.Location = new Point(-425, -263);
            dgvRequestUser.Margin = new Padding(2, 2, 2, 2);
            dgvRequestUser.MultiSelect = false;
            dgvRequestUser.Name = "dgvRequestUser";
            dgvRequestUser.ReadOnly = true;
            dgvRequestUser.RowHeadersVisible = false;
            dgvRequestUser.RowHeadersWidth = 62;
            dgvRequestUser.RowTemplate.Height = 38;
            dgvRequestUser.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRequestUser.Size = new Size(440, 233);
            dgvRequestUser.TabIndex = 6;
            dgvRequestUser.CellContentClick += dgvRequestUser_CellContentClick;
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
            // UC_DashboardAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            Controls.Add(panelContent2);
            Controls.Add(panel1);
            Name = "UC_DashboardAdmin";
            Size = new Size(1050, 406);
            Load += UC_DashboardAdmin_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelContent2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRequestUser).EndInit();
            ResumeLayout(false);
        }



        #endregion

        private Panel panel1;
        private RoundedButton roundedButtonDashboard;
        private RoundedButton roundedButtonBarang;
        private RoundedButton roundedButtonLaporan;
        private RoundedButton roundedButtonUser;
        private RoundedPanel panelContent2;
        private DataGridView dgvRequestUser;
        private DataGridViewTextBoxColumn colNo;
        private DataGridViewTextBoxColumn colNama;
        private DataGridViewTextBoxColumn colJenis;
        private DataGridViewTextBoxColumn colStatus;
        private DataGridViewButtonColumn colAksi;
        private RoundedButton roundedButtonRiwayat;
        private RoundedButton roundedButtonLaporanAktivitas;
        private RoundedButton roundedButtonLaba;
        private PictureBox pictureBox1;
    }
}
