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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label3 = new Label();
            lblNominalTransaksi = new Label();
            btnRefresh = new RoundedButton();
            btnCetakLaporan = new RoundedButton();
            dgvTransaksi = new DataGridView();
            colNo = new DataGridViewTextBoxColumn();
            colTanggal = new DataGridViewTextBoxColumn();
            colKasir = new DataGridViewTextBoxColumn();
            colTotal = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            colAksi = new DataGridViewButtonColumn();
            btnLihatSemua = new RoundedButton();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTransaksi).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(lblNominalTransaksi);
            panel1.Controls.Add(btnRefresh);
            panel1.Controls.Add(btnCetakLaporan);
            panel1.Controls.Add(dgvTransaksi);
            panel1.Controls.Add(btnLihatSemua);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(614, 317);
            panel1.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(186, 30);
            label1.TabIndex = 8;
            label1.Text = "Riwayat Transaksi";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(402, 10);
            dateTimePicker1.Margin = new Padding(2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(204, 23);
            dateTimePicker1.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.MidnightBlue;
            label3.Location = new Point(8, 278);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(123, 15);
            label3.TabIndex = 12;
            label3.Text = "Total Transaksi Hari ini";
            // 
            // lblNominalTransaksi
            // 
            lblNominalTransaksi.AutoSize = true;
            lblNominalTransaksi.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNominalTransaksi.ForeColor = Color.MidnightBlue;
            lblNominalTransaksi.Location = new Point(8, 293);
            lblNominalTransaksi.Margin = new Padding(2, 0, 2, 0);
            lblNominalTransaksi.Name = "lblNominalTransaksi";
            lblNominalTransaksi.Size = new Size(34, 19);
            lblNominalTransaksi.TabIndex = 13;
            lblNominalTransaksi.Text = "Rp0";
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.White;
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefresh.ForeColor = Color.RoyalBlue;
            btnRefresh.Location = new Point(337, 271);
            btnRefresh.Margin = new Padding(2);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(98, 41);
            btnRefresh.TabIndex = 14;
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
            btnCetakLaporan.Location = new Point(439, 273);
            btnCetakLaporan.Margin = new Padding(2);
            btnCetakLaporan.Name = "btnCetakLaporan";
            btnCetakLaporan.Size = new Size(167, 39);
            btnCetakLaporan.TabIndex = 15;
            btnCetakLaporan.Text = "▣ Cetak Laporan  ›";
            btnCetakLaporan.UseVisualStyleBackColor = false;
            // 
            // dgvTransaksi
            // 
            dgvTransaksi.AllowUserToAddRows = false;
            dgvTransaksi.AllowUserToDeleteRows = false;
            dgvTransaksi.BackgroundColor = Color.White;
            dgvTransaksi.BorderStyle = BorderStyle.None;
            dgvTransaksi.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.MidnightBlue;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvTransaksi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvTransaksi.ColumnHeadersHeight = 38;
            dgvTransaksi.Columns.AddRange(new DataGridViewColumn[] { colNo, colTanggal, colKasir, colTotal, colStatus, colAksi });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.MidnightBlue;
            dataGridViewCellStyle2.Padding = new Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = Color.AliceBlue;
            dataGridViewCellStyle2.SelectionForeColor = Color.MidnightBlue;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvTransaksi.DefaultCellStyle = dataGridViewCellStyle2;
            dgvTransaksi.EnableHeadersVisualStyles = false;
            dgvTransaksi.GridColor = Color.Gainsboro;
            dgvTransaksi.Location = new Point(8, 71);
            dgvTransaksi.Margin = new Padding(2);
            dgvTransaksi.MultiSelect = false;
            dgvTransaksi.Name = "dgvTransaksi";
            dgvTransaksi.ReadOnly = true;
            dgvTransaksi.RowHeadersVisible = false;
            dgvTransaksi.RowHeadersWidth = 62;
            dgvTransaksi.RowTemplate.Height = 38;
            dgvTransaksi.Size = new Size(598, 183);
            dgvTransaksi.TabIndex = 11;
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
            // colTanggal
            // 
            colTanggal.HeaderText = "Tanggal";
            colTanggal.MinimumWidth = 8;
            colTanggal.Name = "colTanggal";
            colTanggal.ReadOnly = true;
            colTanggal.SortMode = DataGridViewColumnSortMode.NotSortable;
            colTanggal.Width = 165;
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
            // colTotal
            // 
            colTotal.HeaderText = "Total";
            colTotal.MinimumWidth = 8;
            colTotal.Name = "colTotal";
            colTotal.ReadOnly = true;
            colTotal.SortMode = DataGridViewColumnSortMode.NotSortable;
            colTotal.Width = 110;
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
            // colAksi
            // 
            colAksi.HeaderText = "Aksi";
            colAksi.MinimumWidth = 8;
            colAksi.Name = "colAksi";
            colAksi.ReadOnly = true;
            colAksi.Width = 65;
            // 
            // btnLihatSemua
            // 
            btnLihatSemua.BackColor = Color.White;
            btnLihatSemua.FlatAppearance.BorderSize = 0;
            btnLihatSemua.FlatStyle = FlatStyle.Flat;
            btnLihatSemua.ForeColor = Color.RoyalBlue;
            btnLihatSemua.Location = new Point(495, 48);
            btnLihatSemua.Margin = new Padding(2);
            btnLihatSemua.Name = "btnLihatSemua";
            btnLihatSemua.Size = new Size(111, 23);
            btnLihatSemua.TabIndex = 9;
            btnLihatSemua.Text = "☷ Lihat Semua  ›";
            btnLihatSemua.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(8, 50);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(142, 19);
            label2.TabIndex = 7;
            label2.Text = " ◷  Transaksi Terbaru";
            // 
            // UC_RIWYTTRNKSIKasir
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panel1);
            Name = "UC_RIWYTTRNKSIKasir";
            Size = new Size(614, 317);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTransaksi).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private Label label3;
        private Label lblNominalTransaksi;
        private RoundedButton btnRefresh;
        private RoundedButton btnCetakLaporan;
        private DataGridView dgvTransaksi;
        private DataGridViewTextBoxColumn colNo;
        private DataGridViewTextBoxColumn colTanggal;
        private DataGridViewTextBoxColumn colKasir;
        private DataGridViewTextBoxColumn colTotal;
        private DataGridViewTextBoxColumn colStatus;
        private DataGridViewButtonColumn colAksi;
        private RoundedButton btnLihatSemua;
        private Label label2;
    }
}
