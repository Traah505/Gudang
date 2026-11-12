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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            roundedButtonLaporanGudang = new RoundedButton();
            roundedButtonBarang = new RoundedButton();
            roundedButtonLaporan = new RoundedButton();
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
            panelContent2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRequestUser).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.BackColor = Color.Navy;
            panel1.Controls.Add(roundedButtonLaporanGudang);
            panel1.Controls.Add(roundedButtonBarang);
            panel1.Controls.Add(roundedButtonLaporan);
            panel1.Controls.Add(roundedButtonUser);
            panel1.Controls.Add(roundedButtonDashboard);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(141, 289);
            panel1.TabIndex = 0;
            // 
            // roundedButtonLaporanGudang
            // 
            roundedButtonLaporanGudang.BackColor = Color.Navy;
            roundedButtonLaporanGudang.FlatAppearance.BorderSize = 0;
            roundedButtonLaporanGudang.FlatStyle = FlatStyle.Flat;
            roundedButtonLaporanGudang.ForeColor = Color.White;
            roundedButtonLaporanGudang.Location = new Point(16, 199);
            roundedButtonLaporanGudang.Name = "roundedButtonLaporanGudang";
            roundedButtonLaporanGudang.Size = new Size(142, 40);
            roundedButtonLaporanGudang.TabIndex = 4;
            roundedButtonLaporanGudang.Text = "Laporan Aktivitas";
            roundedButtonLaporanGudang.UseVisualStyleBackColor = false;
            roundedButtonLaporanGudang.Click += roundedButtonLaporanGudang_Click;
            // 
            // roundedButtonBarang
            // 
            roundedButtonBarang.BackColor = Color.Navy;
            roundedButtonBarang.FlatAppearance.BorderSize = 0;
            roundedButtonBarang.FlatStyle = FlatStyle.Flat;
            roundedButtonBarang.ForeColor = Color.White;
            roundedButtonBarang.Location = new Point(16, 107);
            roundedButtonBarang.Name = "roundedButtonBarang";
            roundedButtonBarang.Size = new Size(142, 40);
            roundedButtonBarang.TabIndex = 3;
            roundedButtonBarang.Text = "Kelola Barang";
            roundedButtonBarang.UseVisualStyleBackColor = false;
            roundedButtonBarang.Click += roundedButtonBarang_Click_1;
            // 
            // roundedButtonLaporan
            // 
            roundedButtonLaporan.BackColor = Color.Navy;
            roundedButtonLaporan.FlatAppearance.BorderSize = 0;
            roundedButtonLaporan.FlatStyle = FlatStyle.Flat;
            roundedButtonLaporan.ForeColor = Color.White;
            roundedButtonLaporan.Location = new Point(16, 153);
            roundedButtonLaporan.Name = "roundedButtonLaporan";
            roundedButtonLaporan.Size = new Size(142, 40);
            roundedButtonLaporan.TabIndex = 2;
            roundedButtonLaporan.Text = "Laporan Penjualan";
            roundedButtonLaporan.UseVisualStyleBackColor = false;
            roundedButtonLaporan.Click += roundedButtonLaporan_Click_1;
            // 
            // roundedButtonUser
            // 
            roundedButtonUser.BackColor = Color.Navy;
            roundedButtonUser.FlatAppearance.BorderSize = 0;
            roundedButtonUser.FlatStyle = FlatStyle.Flat;
            roundedButtonUser.ForeColor = Color.White;
            roundedButtonUser.Location = new Point(16, 61);
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
            roundedButtonDashboard.Location = new Point(16, 15);
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
            panelContent2.Location = new Point(147, 3);
            panelContent2.Name = "panelContent2";
            panelContent2.Size = new Size(900, 283);
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.SteelBlue;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvRequestUser.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvRequestUser.ColumnHeadersHeight = 40;
            dgvRequestUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvRequestUser.Columns.AddRange(new DataGridViewColumn[] { colNo, colNama, colJenis, colStatus, colAksi });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.DimGray;
            dataGridViewCellStyle2.Padding = new Padding(6);
            dataGridViewCellStyle2.SelectionBackColor = Color.AliceBlue;
            dataGridViewCellStyle2.SelectionForeColor = Color.MidnightBlue;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvRequestUser.DefaultCellStyle = dataGridViewCellStyle2;
            dgvRequestUser.EnableHeadersVisualStyles = false;
            dgvRequestUser.GridColor = Color.Gainsboro;
            dgvRequestUser.Location = new Point(-425, -263);
            dgvRequestUser.Margin = new Padding(2);
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
            Size = new Size(1050, 289);
            Load += UC_DashboardAdmin_Load;
            panel1.ResumeLayout(false);
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
        private RoundedButton roundedButtonLaporanGudang;
    }
}
