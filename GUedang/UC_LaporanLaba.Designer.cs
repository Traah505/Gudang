namespace GUedang
{
    partial class UC_LaporanLaba
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
            panelRounded1 = new PanelRounded();
            dgvLaporanLaba = new DataGridView();
            colNo = new DataGridViewTextBoxColumn();
            colTanggal = new DataGridViewTextBoxColumn();
            colTransaksi = new DataGridViewTextBoxColumn();
            colPenjualan = new DataGridViewTextBoxColumn();
            colModal = new DataGridViewTextBoxColumn();
            colLaba = new DataGridViewTextBoxColumn();
            label14 = new Label();
            roundedPanel5 = new RoundedPanel();
            roundedPanel6 = new RoundedPanel();
            btnTampilkanLaba = new Rondedbuton();
            dtpTanggalAkhir = new DateTimePicker();
            label13 = new Label();
            dtpTanggalAwal = new DateTimePicker();
            label12 = new Label();
            label5 = new Label();
            roundedPanel4 = new RoundedPanel();
            lblPersentase = new Label();
            label11 = new Label();
            roundedPanel3 = new RoundedPanel();
            lblTotalLaba = new Label();
            label6 = new Label();
            label9 = new Label();
            roundedPanel2 = new RoundedPanel();
            lblTotalBarangTerjual = new Label();
            label7 = new Label();
            label8 = new Label();
            roundedPanel1 = new RoundedPanel();
            lblTotalPenjualan = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            panelRounded1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLaporanLaba).BeginInit();
            roundedPanel5.SuspendLayout();
            roundedPanel4.SuspendLayout();
            roundedPanel3.SuspendLayout();
            roundedPanel2.SuspendLayout();
            roundedPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panelRounded1);
            panel1.Controls.Add(roundedPanel5);
            panel1.Controls.Add(roundedPanel4);
            panel1.Controls.Add(roundedPanel3);
            panel1.Controls.Add(roundedPanel2);
            panel1.Controls.Add(roundedPanel1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1406, 677);
            panel1.TabIndex = 0;
            // 
            // panelRounded1
            // 
            panelRounded1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelRounded1.BackColor = Color.Transparent;
            panelRounded1.Controls.Add(dgvLaporanLaba);
            panelRounded1.Controls.Add(label14);
            panelRounded1.Location = new Point(26, 383);
            panelRounded1.Name = "panelRounded1";
            panelRounded1.Size = new Size(1346, 237);
            panelRounded1.TabIndex = 9;
            // 
            // dgvLaporanLaba
            // 
            dgvLaporanLaba.AllowUserToAddRows = false;
            dgvLaporanLaba.AllowUserToDeleteRows = false;
            dgvLaporanLaba.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLaporanLaba.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.AliceBlue;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.RoyalBlue;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvLaporanLaba.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvLaporanLaba.ColumnHeadersHeight = 40;
            dgvLaporanLaba.Columns.AddRange(new DataGridViewColumn[] { colNo, colTanggal, colTransaksi, colPenjualan, colModal, colLaba });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.DarkSlateGray;
            dataGridViewCellStyle2.SelectionBackColor = Color.LightSteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = Color.MidnightBlue;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvLaporanLaba.DefaultCellStyle = dataGridViewCellStyle2;
            dgvLaporanLaba.EnableHeadersVisualStyles = false;
            dgvLaporanLaba.Location = new Point(19, 27);
            dgvLaporanLaba.MultiSelect = false;
            dgvLaporanLaba.Name = "dgvLaporanLaba";
            dgvLaporanLaba.ReadOnly = true;
            dgvLaporanLaba.RowHeadersVisible = false;
            dgvLaporanLaba.RowHeadersWidth = 62;
            dgvLaporanLaba.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLaporanLaba.Size = new Size(1299, 197);
            dgvLaporanLaba.TabIndex = 15;
            // 
            // colNo
            // 
            colNo.FillWeight = 50F;
            colNo.HeaderText = "No";
            colNo.MinimumWidth = 8;
            colNo.Name = "colNo";
            colNo.ReadOnly = true;
            colNo.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colTanggal
            // 
            colTanggal.HeaderText = "Tanggal";
            colTanggal.MinimumWidth = 8;
            colTanggal.Name = "colTanggal";
            colTanggal.ReadOnly = true;
            colTanggal.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colTransaksi
            // 
            colTransaksi.HeaderText = "Transaksi";
            colTransaksi.MinimumWidth = 8;
            colTransaksi.Name = "colTransaksi";
            colTransaksi.ReadOnly = true;
            colTransaksi.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colPenjualan
            // 
            colPenjualan.HeaderText = "Penjualan";
            colPenjualan.MinimumWidth = 8;
            colPenjualan.Name = "colPenjualan";
            colPenjualan.ReadOnly = true;
            colPenjualan.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colModal
            // 
            colModal.HeaderText = "Modal";
            colModal.MinimumWidth = 8;
            colModal.Name = "colModal";
            colModal.ReadOnly = true;
            colModal.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colLaba
            // 
            colLaba.HeaderText = "Laba";
            colLaba.MinimumWidth = 8;
            colLaba.Name = "colLaba";
            colLaba.ReadOnly = true;
            colLaba.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Calibri", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.MidnightBlue;
            label14.Location = new Point(19, 0);
            label14.Name = "label14";
            label14.Size = new Size(204, 24);
            label14.TabIndex = 14;
            label14.Text = "Rincian Laba Penjualan";
            // 
            // roundedPanel5
            // 
            roundedPanel5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            roundedPanel5.BackColor = Color.Transparent;
            roundedPanel5.Controls.Add(roundedPanel6);
            roundedPanel5.Controls.Add(btnTampilkanLaba);
            roundedPanel5.Controls.Add(dtpTanggalAkhir);
            roundedPanel5.Controls.Add(label13);
            roundedPanel5.Controls.Add(dtpTanggalAwal);
            roundedPanel5.Controls.Add(label12);
            roundedPanel5.Controls.Add(label5);
            roundedPanel5.Location = new Point(21, 243);
            roundedPanel5.Name = "roundedPanel5";
            roundedPanel5.Size = new Size(1349, 133);
            roundedPanel5.TabIndex = 8;
            // 
            // roundedPanel6
            // 
            roundedPanel6.BackColor = Color.Transparent;
            roundedPanel6.Location = new Point(0, 157);
            roundedPanel6.Name = "roundedPanel6";
            roundedPanel6.Size = new Size(1349, 222);
            roundedPanel6.TabIndex = 9;
            // 
            // btnTampilkanLaba
            // 
            btnTampilkanLaba.BackColor = Color.White;
            btnTampilkanLaba.BackgroundImageLayout = ImageLayout.None;
            btnTampilkanLaba.FlatAppearance.BorderSize = 0;
            btnTampilkanLaba.FlatStyle = FlatStyle.Flat;
            btnTampilkanLaba.ForeColor = Color.Black;
            btnTampilkanLaba.Location = new Point(1021, 63);
            btnTampilkanLaba.Name = "btnTampilkanLaba";
            btnTampilkanLaba.Size = new Size(226, 43);
            btnTampilkanLaba.TabIndex = 13;
            btnTampilkanLaba.Text = "Tampilkan";
            btnTampilkanLaba.UseVisualStyleBackColor = false;
            // 
            // dtpTanggalAkhir
            // 
            dtpTanggalAkhir.Format = DateTimePickerFormat.Short;
            dtpTanggalAkhir.Location = new Point(306, 77);
            dtpTanggalAkhir.Name = "dtpTanggalAkhir";
            dtpTanggalAkhir.Size = new Size(141, 31);
            dtpTanggalAkhir.TabIndex = 12;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Calibri Light", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(306, 55);
            label13.Name = "label13";
            label13.Size = new Size(98, 19);
            label13.TabIndex = 11;
            label13.Text = "Tanggal Akhir";
            // 
            // dtpTanggalAwal
            // 
            dtpTanggalAwal.Format = DateTimePickerFormat.Short;
            dtpTanggalAwal.Location = new Point(30, 77);
            dtpTanggalAwal.Name = "dtpTanggalAwal";
            dtpTanggalAwal.Size = new Size(141, 31);
            dtpTanggalAwal.TabIndex = 10;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Calibri Light", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(30, 55);
            label12.Name = "label12";
            label12.Size = new Size(96, 19);
            label12.TabIndex = 9;
            label12.Text = "Tanggal Awal";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(30, 15);
            label5.Name = "label5";
            label5.Size = new Size(104, 19);
            label5.TabIndex = 5;
            label5.Text = "Filter Laporan";
            // 
            // roundedPanel4
            // 
            roundedPanel4.BackColor = Color.Transparent;
            roundedPanel4.Controls.Add(lblPersentase);
            roundedPanel4.Controls.Add(label11);
            roundedPanel4.Location = new Point(1074, 102);
            roundedPanel4.Name = "roundedPanel4";
            roundedPanel4.Size = new Size(294, 123);
            roundedPanel4.TabIndex = 7;
            // 
            // lblPersentase
            // 
            lblPersentase.AutoSize = true;
            lblPersentase.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPersentase.Location = new Point(21, 45);
            lblPersentase.Name = "lblPersentase";
            lblPersentase.Size = new Size(57, 38);
            lblPersentase.TabIndex = 4;
            lblPersentase.Text = "0%";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Calibri", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Black;
            label11.Location = new Point(21, 23);
            label11.Name = "label11";
            label11.Size = new Size(171, 19);
            label11.TabIndex = 3;
            label11.Text = "Persentase Keuntungan";
            // 
            // roundedPanel3
            // 
            roundedPanel3.BackColor = Color.Transparent;
            roundedPanel3.Controls.Add(lblTotalLaba);
            roundedPanel3.Controls.Add(label6);
            roundedPanel3.Controls.Add(label9);
            roundedPanel3.Location = new Point(720, 102);
            roundedPanel3.Name = "roundedPanel3";
            roundedPanel3.Size = new Size(294, 123);
            roundedPanel3.TabIndex = 6;
            // 
            // lblTotalLaba
            // 
            lblTotalLaba.AutoSize = true;
            lblTotalLaba.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalLaba.ForeColor = Color.Black;
            lblTotalLaba.Location = new Point(64, 43);
            lblTotalLaba.Name = "lblTotalLaba";
            lblTotalLaba.Size = new Size(33, 38);
            lblTotalLaba.TabIndex = 4;
            lblTotalLaba.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(21, 43);
            label6.Name = "label6";
            label6.Size = new Size(52, 38);
            label6.TabIndex = 3;
            label6.Text = "Rp";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Calibri", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(21, 23);
            label9.Name = "label9";
            label9.Size = new Size(79, 19);
            label9.TabIndex = 3;
            label9.Text = "Total Laba";
            // 
            // roundedPanel2
            // 
            roundedPanel2.BackColor = Color.Transparent;
            roundedPanel2.Controls.Add(lblTotalBarangTerjual);
            roundedPanel2.Controls.Add(label7);
            roundedPanel2.Controls.Add(label8);
            roundedPanel2.Location = new Point(371, 102);
            roundedPanel2.Name = "roundedPanel2";
            roundedPanel2.Size = new Size(294, 123);
            roundedPanel2.TabIndex = 5;
            // 
            // lblTotalBarangTerjual
            // 
            lblTotalBarangTerjual.AutoSize = true;
            lblTotalBarangTerjual.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalBarangTerjual.ForeColor = Color.SeaGreen;
            lblTotalBarangTerjual.Location = new Point(64, 43);
            lblTotalBarangTerjual.Name = "lblTotalBarangTerjual";
            lblTotalBarangTerjual.Size = new Size(33, 38);
            lblTotalBarangTerjual.TabIndex = 4;
            lblTotalBarangTerjual.Text = "0";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.SeaGreen;
            label7.Location = new Point(21, 43);
            label7.Name = "label7";
            label7.Size = new Size(52, 38);
            label7.TabIndex = 3;
            label7.Text = "Rp";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Calibri", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(21, 23);
            label8.Name = "label8";
            label8.Size = new Size(193, 19);
            label8.TabIndex = 3;
            label8.Text = "Total Modal Barang Terjual";
            // 
            // roundedPanel1
            // 
            roundedPanel1.BackColor = Color.Transparent;
            roundedPanel1.Controls.Add(lblTotalPenjualan);
            roundedPanel1.Controls.Add(label4);
            roundedPanel1.Controls.Add(label3);
            roundedPanel1.Location = new Point(21, 102);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Size = new Size(294, 123);
            roundedPanel1.TabIndex = 2;
            // 
            // lblTotalPenjualan
            // 
            lblTotalPenjualan.AutoSize = true;
            lblTotalPenjualan.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalPenjualan.ForeColor = Color.RoyalBlue;
            lblTotalPenjualan.Location = new Point(64, 43);
            lblTotalPenjualan.Name = "lblTotalPenjualan";
            lblTotalPenjualan.Size = new Size(33, 38);
            lblTotalPenjualan.TabIndex = 4;
            lblTotalPenjualan.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.RoyalBlue;
            label4.Location = new Point(21, 43);
            label4.Name = "label4";
            label4.Size = new Size(52, 38);
            label4.TabIndex = 3;
            label4.Text = "Rp";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(21, 23);
            label3.Name = "label3";
            label3.Size = new Size(115, 19);
            label3.TabIndex = 3;
            label3.Text = "Total Penjualan";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri Light", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(21, 53);
            label2.Name = "label2";
            label2.Size = new Size(295, 19);
            label2.TabIndex = 1;
            label2.Text = "Ringkasan Keuntungan penjualan SMK MArt";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.RoyalBlue;
            label1.Location = new Point(21, 17);
            label1.Name = "label1";
            label1.Size = new Size(190, 38);
            label1.TabIndex = 0;
            label1.Text = "Laporan Laba";
            // 
            // UC_LaporanLaba
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "UC_LaporanLaba";
            Size = new Size(1409, 635);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelRounded1.ResumeLayout(false);
            panelRounded1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLaporanLaba).EndInit();
            roundedPanel5.ResumeLayout(false);
            roundedPanel5.PerformLayout();
            roundedPanel4.ResumeLayout(false);
            roundedPanel4.PerformLayout();
            roundedPanel3.ResumeLayout(false);
            roundedPanel3.PerformLayout();
            roundedPanel2.ResumeLayout(false);
            roundedPanel2.PerformLayout();
            roundedPanel1.ResumeLayout(false);
            roundedPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private RoundedPanel roundedPanel1;
        private Label label3;
        private Label label2;
        private RoundedPanel roundedPanel3;
        private Label lblTotalLaba;
        private Label label6;
        private Label label9;
        private RoundedPanel roundedPanel2;
        private Label lblTotalBarangTerjual;
        private Label label7;
        private Label label8;
        private Label lblTotalPenjualan;
        private Label label4;
        private RoundedPanel roundedPanel4;
        private Label lblPersentase;
        private Label label11;
        private RoundedPanel roundedPanel5;
        private DateTimePicker dtpTanggalAwal;
        private Label label12;
        private Label label5;
        private Rondedbuton btnTampilkanLaba;
        private DateTimePicker dtpTanggalAkhir;
        private Label label13;
        private PanelRounded panelRounded1;
        private DataGridView dgvLaporanLaba;
        private Label label14;
        private RoundedPanel roundedPanel6;
        private DataGridViewTextBoxColumn colNo;
        private DataGridViewTextBoxColumn colTanggal;
        private DataGridViewTextBoxColumn colTransaksi;
        private DataGridViewTextBoxColumn colPenjualan;
        private DataGridViewTextBoxColumn colModal;
        private DataGridViewTextBoxColumn colLaba;
    }
}
