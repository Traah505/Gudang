namespace GUedang
{
    partial class UC_RIWYTTRNKSIKasir
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            roundedPanel2 = new RoundedPanel();
            label2 = new Label();
            btnLihatSemua = new RoundedButton();
            dgvTransaksi = new DataGridView();
            colAksi = new DataGridViewButtonColumn();
            colStatus = new DataGridViewTextBoxColumn();
            colTotal = new DataGridViewTextBoxColumn();
            colKasir = new DataGridViewTextBoxColumn();
            colTanggal = new DataGridViewTextBoxColumn();
            colNo = new DataGridViewTextBoxColumn();
            roundedPanel3 = new RoundedPanel();
            roundedPanel4 = new RoundedPanel();
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            roundedPanel1 = new RoundedPanel();
            label3 = new Label();
            lblNominalTransaksi = new Label();
            btnRefresh = new RoundedButton();
            btnCetakLaporan = new RoundedButton();
            roundedPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTransaksi).BeginInit();
            roundedPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // roundedPanel2
            // 
            roundedPanel2.BackColor = Color.Transparent;
            roundedPanel2.Controls.Add(roundedPanel4);
            roundedPanel2.Controls.Add(roundedPanel3);
            roundedPanel2.Controls.Add(dgvTransaksi);
            roundedPanel2.Controls.Add(btnLihatSemua);
            roundedPanel2.Controls.Add(label2);
            roundedPanel2.Location = new Point(19, 77);
            roundedPanel2.Name = "roundedPanel2";
            roundedPanel2.Size = new Size(600, 369);
            roundedPanel2.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(20, 14);
            label2.Name = "label2";
            label2.Size = new Size(204, 28);
            label2.TabIndex = 0;
            label2.Text = " ◷  Transaksi Terbaru";
            // 
            // btnLihatSemua
            // 
            btnLihatSemua.BackColor = Color.White;
            btnLihatSemua.FlatAppearance.BorderSize = 0;
            btnLihatSemua.FlatStyle = FlatStyle.Flat;
            btnLihatSemua.ForeColor = Color.RoyalBlue;
            btnLihatSemua.Location = new Point(427, 10);
            btnLihatSemua.Name = "btnLihatSemua";
            btnLihatSemua.Size = new Size(159, 38);
            btnLihatSemua.TabIndex = 1;
            btnLihatSemua.Text = "☷ Lihat Semua  ›";
            btnLihatSemua.UseVisualStyleBackColor = false;
            // 
            // dgvTransaksi
            // 
            dgvTransaksi.AllowUserToAddRows = false;
            dgvTransaksi.AllowUserToDeleteRows = false;
            dgvTransaksi.BackgroundColor = Color.White;
            dgvTransaksi.BorderStyle = BorderStyle.None;
            dgvTransaksi.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.MidnightBlue;
            dataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvTransaksi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvTransaksi.ColumnHeadersHeight = 38;
            dgvTransaksi.Columns.AddRange(new DataGridViewColumn[] { colNo, colTanggal, colKasir, colTotal, colStatus, colAksi });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = Color.MidnightBlue;
            dataGridViewCellStyle4.Padding = new Padding(5);
            dataGridViewCellStyle4.SelectionBackColor = Color.AliceBlue;
            dataGridViewCellStyle4.SelectionForeColor = Color.MidnightBlue;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvTransaksi.DefaultCellStyle = dataGridViewCellStyle4;
            dgvTransaksi.EnableHeadersVisualStyles = false;
            dgvTransaksi.GridColor = Color.Gainsboro;
            dgvTransaksi.Location = new Point(3, 61);
            dgvTransaksi.MultiSelect = false;
            dgvTransaksi.Name = "dgvTransaksi";
            dgvTransaksi.ReadOnly = true;
            dgvTransaksi.RowHeadersVisible = false;
            dgvTransaksi.RowHeadersWidth = 62;
            dgvTransaksi.RowTemplate.Height = 38;
            dgvTransaksi.Size = new Size(594, 305);
            dgvTransaksi.TabIndex = 2;
            // 
            // colAksi
            // 
            colAksi.HeaderText = "Aksi";
            colAksi.MinimumWidth = 8;
            colAksi.Name = "colAksi";
            colAksi.ReadOnly = true;
            colAksi.Width = 65;
            // 
            // colStatus
            // 
            colStatus.HeaderText = "Status";
            colStatus.MinimumWidth = 8;
            colStatus.Name = "colStatus";
            colStatus.ReadOnly = true;
            colStatus.SortMode = DataGridViewColumnSortMode.NotSortable;
            colStatus.Width = 105;
            // 
            // colTotal
            // 
            colTotal.HeaderText = "Total";
            colTotal.MinimumWidth = 8;
            colTotal.Name = "colTotal";
            colTotal.ReadOnly = true;
            colTotal.SortMode = DataGridViewColumnSortMode.NotSortable;
            colTotal.Width = 110;
            // 
            // colKasir
            // 
            colKasir.HeaderText = "Nama Kasir";
            colKasir.MinimumWidth = 8;
            colKasir.Name = "colKasir";
            colKasir.ReadOnly = true;
            colKasir.SortMode = DataGridViewColumnSortMode.NotSortable;
            colKasir.Width = 115;
            // 
            // colTanggal
            // 
            colTanggal.HeaderText = "Tanggal";
            colTanggal.MinimumWidth = 8;
            colTanggal.Name = "colTanggal";
            colTanggal.ReadOnly = true;
            colTanggal.SortMode = DataGridViewColumnSortMode.NotSortable;
            colTanggal.Width = 165;
            // 
            // colNo
            // 
            colNo.HeaderText = "No";
            colNo.MinimumWidth = 8;
            colNo.Name = "colNo";
            colNo.ReadOnly = true;
            colNo.SortMode = DataGridViewColumnSortMode.NotSortable;
            colNo.Width = 45;
            // 
            // roundedPanel3
            // 
            roundedPanel3.BackColor = Color.Transparent;
            roundedPanel3.Location = new Point(47, 372);
            roundedPanel3.Name = "roundedPanel3";
            roundedPanel3.Size = new Size(229, 63);
            roundedPanel3.TabIndex = 3;
            // 
            // roundedPanel4
            // 
            roundedPanel4.BackColor = Color.LightGray;
            roundedPanel4.Location = new Point(83, 372);
            roundedPanel4.Name = "roundedPanel4";
            roundedPanel4.Size = new Size(120, 60);
            roundedPanel4.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(19, 18);
            label1.Name = "label1";
            label1.Size = new Size(276, 45);
            label1.TabIndex = 1;
            label1.Text = "Riwayat Transaksi";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(343, 29);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(289, 31);
            dateTimePicker1.TabIndex = 2;
            // 
            // roundedPanel1
            // 
            roundedPanel1.BackColor = Color.Transparent;
            roundedPanel1.BorderStyle = BorderStyle.FixedSingle;
            roundedPanel1.Controls.Add(btnCetakLaporan);
            roundedPanel1.Controls.Add(btnRefresh);
            roundedPanel1.Controls.Add(lblNominalTransaksi);
            roundedPanel1.Controls.Add(label3);
            roundedPanel1.Controls.Add(dateTimePicker1);
            roundedPanel1.Controls.Add(label1);
            roundedPanel1.Controls.Add(roundedPanel2);
            roundedPanel1.Location = new Point(249, 3);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Size = new Size(637, 537);
            roundedPanel1.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.MidnightBlue;
            label3.Location = new Point(19, 459);
            label3.Name = "label3";
            label3.Size = new Size(184, 25);
            label3.TabIndex = 3;
            label3.Text = "Total Transaksi Hari ini";
            // 
            // lblNominalTransaksi
            // 
            lblNominalTransaksi.AutoSize = true;
            lblNominalTransaksi.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNominalTransaksi.ForeColor = Color.MidnightBlue;
            lblNominalTransaksi.Location = new Point(22, 484);
            lblNominalTransaksi.Name = "lblNominalTransaksi";
            lblNominalTransaksi.Size = new Size(47, 28);
            lblNominalTransaksi.TabIndex = 4;
            lblNominalTransaksi.Text = "Rp0";
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.White;
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefresh.ForeColor = Color.RoyalBlue;
            btnRefresh.Location = new Point(228, 459);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(140, 68);
            btnRefresh.TabIndex = 5;
            btnRefresh.Text = "⟳ Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            // 
            // btnCetakLaporan
            // 
            btnCetakLaporan.BackColor = Color.RoyalBlue;
            btnCetakLaporan.FlatAppearance.BorderSize = 0;
            btnCetakLaporan.FlatStyle = FlatStyle.Flat;
            btnCetakLaporan.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCetakLaporan.ForeColor = Color.White;
            btnCetakLaporan.Location = new Point(398, 459);
            btnCetakLaporan.Name = "btnCetakLaporan";
            btnCetakLaporan.Size = new Size(238, 65);
            btnCetakLaporan.TabIndex = 6;
            btnCetakLaporan.Text = "▣ Cetak Laporan  ›";
            btnCetakLaporan.UseVisualStyleBackColor = false;
            // 
            // UC_RIWYTTRNKSIKasir
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            Controls.Add(roundedPanel1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "UC_RIWYTTRNKSIKasir";
            Size = new Size(906, 543);
            roundedPanel2.ResumeLayout(false);
            roundedPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTransaksi).EndInit();
            roundedPanel1.ResumeLayout(false);
            roundedPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private RoundedPanel roundedPanel2;
        private RoundedPanel roundedPanel4;
        private RoundedPanel roundedPanel3;
        private DataGridView dgvTransaksi;
        private DataGridViewTextBoxColumn colNo;
        private DataGridViewTextBoxColumn colTanggal;
        private DataGridViewTextBoxColumn colKasir;
        private DataGridViewTextBoxColumn colTotal;
        private DataGridViewTextBoxColumn colStatus;
        private DataGridViewButtonColumn colAksi;
        private RoundedButton btnLihatSemua;
        private Label label2;
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private RoundedPanel roundedPanel1;
        private Label lblNominalTransaksi;
        private Label label3;
        private RoundedButton btnCetakLaporan;
        private RoundedButton btnRefresh;
    }
}
