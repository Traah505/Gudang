namespace GUedang
{
    partial class UC_RiwayatGudang
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            roundedPanel5 = new RoundedPanel();
            dgvRiwayatGudang = new DataGridView();
            colNo = new DataGridViewTextBoxColumn();
            colTanggal = new DataGridViewTextBoxColumn();
            colJenisTransaksi = new DataGridViewTextBoxColumn();
            colNamaBarang = new DataGridViewTextBoxColumn();
            colJumlah = new DataGridViewTextBoxColumn();
            colStokAkhir = new DataGridViewTextBoxColumn();
            colKeterangan = new DataGridViewTextBoxColumn();
            panel4 = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            label1 = new Label();
            roundedPanel4 = new RoundedPanel();
            panel6 = new Panel();
            lblStokSaatIni = new Label();
            label5 = new Label();
            roundedPanel3 = new RoundedPanel();
            panel5 = new Panel();
            lblTotalBrgKeluar = new Label();
            label4 = new Label();
            roundedPanel2 = new RoundedPanel();
            panel7 = new Panel();
            lblTotalBrgMasuk = new Label();
            label2 = new Label();
            roundedPanel1 = new RoundedPanel();
            btnCari = new RoundedButton();
            cmbJenisTransaksi = new ComboBox();
            label6 = new Label();
            panel8 = new Panel();
            label3 = new Label();
            dtpDari = new DateTimePicker();
            dtpSampai = new DateTimePicker();
            panel1.SuspendLayout();
            roundedPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRiwayatGudang).BeginInit();
            roundedPanel4.SuspendLayout();
            roundedPanel3.SuspendLayout();
            roundedPanel2.SuspendLayout();
            roundedPanel1.SuspendLayout();
            panel8.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(roundedPanel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(roundedPanel4);
            panel1.Controls.Add(roundedPanel3);
            panel1.Controls.Add(roundedPanel2);
            panel1.Controls.Add(roundedPanel1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1080, 557);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // roundedPanel5
            // 
            roundedPanel5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            roundedPanel5.BackColor = Color.Transparent;
            roundedPanel5.Controls.Add(dgvRiwayatGudang);
            roundedPanel5.Location = new Point(26, 237);
            roundedPanel5.Name = "roundedPanel5";
            roundedPanel5.Size = new Size(1029, 300);
            roundedPanel5.TabIndex = 7;
            // 
            // dgvRiwayatGudang
            // 
            dgvRiwayatGudang.AllowUserToAddRows = false;
            dgvRiwayatGudang.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.DeepSkyBlue;
            dgvRiwayatGudang.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvRiwayatGudang.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvRiwayatGudang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRiwayatGudang.BackgroundColor = Color.White;
            dgvRiwayatGudang.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.RoyalBlue;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvRiwayatGudang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvRiwayatGudang.ColumnHeadersHeight = 45;
            dgvRiwayatGudang.Columns.AddRange(new DataGridViewColumn[] { colNo, colTanggal, colJenisTransaksi, colNamaBarang, colJumlah, colStokAkhir, colKeterangan });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.RoyalBlue;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvRiwayatGudang.DefaultCellStyle = dataGridViewCellStyle3;
            dgvRiwayatGudang.EnableHeadersVisualStyles = false;
            dgvRiwayatGudang.GridColor = Color.White;
            dgvRiwayatGudang.Location = new Point(19, 3);
            dgvRiwayatGudang.MultiSelect = false;
            dgvRiwayatGudang.Name = "dgvRiwayatGudang";
            dgvRiwayatGudang.ReadOnly = true;
            dgvRiwayatGudang.RowHeadersVisible = false;
            dgvRiwayatGudang.RowHeadersWidth = 62;
            dgvRiwayatGudang.RowTemplate.Height = 40;
            dgvRiwayatGudang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRiwayatGudang.Size = new Size(996, 268);
            dgvRiwayatGudang.TabIndex = 0;
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
            colTanggal.FillWeight = 150F;
            colTanggal.HeaderText = "Tanggal Waktu";
            colTanggal.MinimumWidth = 8;
            colTanggal.Name = "colTanggal";
            colTanggal.ReadOnly = true;
            colTanggal.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colJenisTransaksi
            // 
            colJenisTransaksi.FillWeight = 140F;
            colJenisTransaksi.HeaderText = "Jenis Transaksi";
            colJenisTransaksi.MinimumWidth = 8;
            colJenisTransaksi.Name = "colJenisTransaksi";
            colJenisTransaksi.ReadOnly = true;
            colJenisTransaksi.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colNamaBarang
            // 
            colNamaBarang.FillWeight = 160F;
            colNamaBarang.HeaderText = "Nama Barang";
            colNamaBarang.MinimumWidth = 8;
            colNamaBarang.Name = "colNamaBarang";
            colNamaBarang.ReadOnly = true;
            colNamaBarang.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colJumlah
            // 
            colJumlah.HeaderText = "Jumlah";
            colJumlah.MinimumWidth = 8;
            colJumlah.Name = "colJumlah";
            colJumlah.ReadOnly = true;
            colJumlah.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colStokAkhir
            // 
            colStokAkhir.FillWeight = 110F;
            colStokAkhir.HeaderText = "Stok Akhir";
            colStokAkhir.MinimumWidth = 8;
            colStokAkhir.Name = "colStokAkhir";
            colStokAkhir.ReadOnly = true;
            colStokAkhir.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colKeterangan
            // 
            colKeterangan.FillWeight = 200F;
            colKeterangan.HeaderText = "Keterangan";
            colKeterangan.MinimumWidth = 8;
            colKeterangan.Name = "colKeterangan";
            colKeterangan.ReadOnly = true;
            colKeterangan.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Purple;
            panel4.Location = new Point(753, 107);
            panel4.Name = "panel4";
            panel4.Size = new Size(19, 115);
            panel4.TabIndex = 6;
            // 
            // panel3
            // 
            panel3.BackColor = Color.SeaGreen;
            panel3.Location = new Point(396, 103);
            panel3.Name = "panel3";
            panel3.Size = new Size(19, 115);
            panel3.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.BackColor = Color.RoyalBlue;
            panel2.Location = new Point(41, 107);
            panel2.Name = "panel2";
            panel2.Size = new Size(19, 115);
            panel2.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(45, 14);
            label1.Name = "label1";
            label1.Size = new Size(225, 38);
            label1.TabIndex = 0;
            label1.Text = "Riwayat Gudang";
            // 
            // roundedPanel4
            // 
            roundedPanel4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            roundedPanel4.BackColor = Color.Transparent;
            roundedPanel4.Controls.Add(panel6);
            roundedPanel4.Controls.Add(lblStokSaatIni);
            roundedPanel4.Controls.Add(label5);
            roundedPanel4.Location = new Point(753, 103);
            roundedPanel4.Name = "roundedPanel4";
            roundedPanel4.Size = new Size(300, 115);
            roundedPanel4.TabIndex = 3;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Purple;
            panel6.Location = new Point(279, 3);
            panel6.Name = "panel6";
            panel6.Size = new Size(19, 115);
            panel6.TabIndex = 7;
            // 
            // lblStokSaatIni
            // 
            lblStokSaatIni.AutoSize = true;
            lblStokSaatIni.Font = new Font("Arial", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStokSaatIni.ForeColor = Color.Purple;
            lblStokSaatIni.Location = new Point(27, 53);
            lblStokSaatIni.Name = "lblStokSaatIni";
            lblStokSaatIni.Size = new Size(35, 37);
            lblStokSaatIni.TabIndex = 4;
            lblStokSaatIni.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri Light", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(27, 20);
            label5.Name = "label5";
            label5.Size = new Size(88, 19);
            label5.TabIndex = 2;
            label5.Text = "Stok Saat Ini";
            // 
            // roundedPanel3
            // 
            roundedPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            roundedPanel3.BackColor = Color.Transparent;
            roundedPanel3.Controls.Add(panel5);
            roundedPanel3.Controls.Add(lblTotalBrgKeluar);
            roundedPanel3.Controls.Add(label4);
            roundedPanel3.Location = new Point(396, 103);
            roundedPanel3.Name = "roundedPanel3";
            roundedPanel3.Size = new Size(300, 115);
            roundedPanel3.TabIndex = 2;
            // 
            // panel5
            // 
            panel5.BackColor = Color.SeaGreen;
            panel5.Location = new Point(281, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(19, 115);
            panel5.TabIndex = 6;
            // 
            // lblTotalBrgKeluar
            // 
            lblTotalBrgKeluar.AutoSize = true;
            lblTotalBrgKeluar.Font = new Font("Arial", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalBrgKeluar.ForeColor = Color.SeaGreen;
            lblTotalBrgKeluar.Location = new Point(36, 53);
            lblTotalBrgKeluar.Name = "lblTotalBrgKeluar";
            lblTotalBrgKeluar.Size = new Size(35, 37);
            lblTotalBrgKeluar.TabIndex = 3;
            lblTotalBrgKeluar.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri Light", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(36, 20);
            label4.Name = "label4";
            label4.Size = new Size(138, 19);
            label4.TabIndex = 1;
            label4.Text = "Total Barang Keluar";
            // 
            // roundedPanel2
            // 
            roundedPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            roundedPanel2.BackColor = Color.Transparent;
            roundedPanel2.Controls.Add(panel7);
            roundedPanel2.Controls.Add(lblTotalBrgMasuk);
            roundedPanel2.Controls.Add(label2);
            roundedPanel2.Location = new Point(41, 103);
            roundedPanel2.Name = "roundedPanel2";
            roundedPanel2.Size = new Size(300, 115);
            roundedPanel2.TabIndex = 1;
            // 
            // panel7
            // 
            panel7.BackColor = Color.RoyalBlue;
            panel7.Location = new Point(279, 3);
            panel7.Name = "panel7";
            panel7.Size = new Size(19, 115);
            panel7.TabIndex = 5;
            // 
            // lblTotalBrgMasuk
            // 
            lblTotalBrgMasuk.AutoSize = true;
            lblTotalBrgMasuk.Font = new Font("Arial", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalBrgMasuk.ForeColor = Color.RoyalBlue;
            lblTotalBrgMasuk.Location = new Point(26, 53);
            lblTotalBrgMasuk.Name = "lblTotalBrgMasuk";
            lblTotalBrgMasuk.Size = new Size(35, 37);
            lblTotalBrgMasuk.TabIndex = 2;
            lblTotalBrgMasuk.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri Light", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(26, 20);
            label2.Name = "label2";
            label2.Size = new Size(139, 19);
            label2.TabIndex = 0;
            label2.Text = "Total Barang Masuk";
            // 
            // roundedPanel1
            // 
            roundedPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            roundedPanel1.BackColor = Color.Transparent;
            roundedPanel1.Controls.Add(btnCari);
            roundedPanel1.Controls.Add(cmbJenisTransaksi);
            roundedPanel1.Controls.Add(label6);
            roundedPanel1.Controls.Add(panel8);
            roundedPanel1.Location = new Point(325, 12);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Size = new Size(730, 85);
            roundedPanel1.TabIndex = 0;
            roundedPanel1.Paint += roundedPanel1_Paint;
            // 
            // btnCari
            // 
            btnCari.BackColor = Color.RoyalBlue;
            btnCari.FlatAppearance.BorderSize = 0;
            btnCari.FlatStyle = FlatStyle.Flat;
            btnCari.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCari.ForeColor = Color.White;
            btnCari.Location = new Point(939, 42);
            btnCari.Name = "btnCari";
            btnCari.Size = new Size(99, 42);
            btnCari.TabIndex = 6;
            btnCari.Text = "🔍Cari";
            btnCari.UseVisualStyleBackColor = false;
            // 
            // cmbJenisTransaksi
            // 
            cmbJenisTransaksi.FormattingEnabled = true;
            cmbJenisTransaksi.Items.AddRange(new object[] { "Masuk", "Keluar" });
            cmbJenisTransaksi.Location = new Point(538, 42);
            cmbJenisTransaksi.Name = "cmbJenisTransaksi";
            cmbJenisTransaksi.Size = new Size(183, 33);
            cmbJenisTransaksi.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(529, 13);
            label6.Name = "label6";
            label6.Size = new Size(124, 25);
            label6.TabIndex = 4;
            label6.Text = "Jenis Transaksi";
            // 
            // panel8
            // 
            panel8.BackColor = Color.White;
            panel8.Controls.Add(label3);
            panel8.Controls.Add(dtpDari);
            panel8.Controls.Add(dtpSampai);
            panel8.Location = new Point(216, 4);
            panel8.Name = "panel8";
            panel8.Size = new Size(300, 78);
            panel8.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(72, 17);
            label3.Name = "label3";
            label3.Size = new Size(157, 25);
            label3.TabIndex = 3;
            label3.Text = "📅Rentang Waktu";
            // 
            // dtpDari
            // 
            dtpDari.Format = DateTimePickerFormat.Custom;
            dtpDari.Location = new Point(3, 45);
            dtpDari.MaxDate = new DateTime(9994, 12, 31, 0, 0, 0, 0);
            dtpDari.Name = "dtpDari";
            dtpDari.Size = new Size(124, 31);
            dtpDari.TabIndex = 1;
            // 
            // dtpSampai
            // 
            dtpSampai.CalendarForeColor = Color.White;
            dtpSampai.CalendarMonthBackground = Color.RoyalBlue;
            dtpSampai.Format = DateTimePickerFormat.Custom;
            dtpSampai.Location = new Point(173, 45);
            dtpSampai.MaxDate = new DateTime(9994, 12, 31, 0, 0, 0, 0);
            dtpSampai.Name = "dtpSampai";
            dtpSampai.Size = new Size(124, 31);
            dtpSampai.TabIndex = 2;
            // 
            // UC_RiwayatGudang
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "UC_RiwayatGudang";
            Size = new Size(1080, 557);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            roundedPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRiwayatGudang).EndInit();
            roundedPanel4.ResumeLayout(false);
            roundedPanel4.PerformLayout();
            roundedPanel3.ResumeLayout(false);
            roundedPanel3.PerformLayout();
            roundedPanel2.ResumeLayout(false);
            roundedPanel2.PerformLayout();
            roundedPanel1.ResumeLayout(false);
            roundedPanel1.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private RoundedPanel roundedPanel1;
        private Label label1;
        private RoundedPanel roundedPanel3;
        private RoundedPanel roundedPanel2;
        private Label lblTotalBrgKeluar;
        private Label label4;
        private Label lblTotalBrgMasuk;
        private Label label2;
        private Panel panel4;
        private Panel panel3;
        private Panel panel2;
        private RoundedPanel roundedPanel4;
        private Panel panel6;
        private Label lblStokSaatIni;
        private Label label5;
        private Panel panel5;
        private Panel panel7;
        private RoundedPanel roundedPanel5;
        private DataGridView dgvRiwayatGudang;
        private DateTimePicker dtpSampai;
        private DateTimePicker dtpDari;
        private Panel panel8;
        private DataGridViewTextBoxColumn colNo;
        private DataGridViewTextBoxColumn colTanggal;
        private DataGridViewTextBoxColumn colJenisTransaksi;
        private DataGridViewTextBoxColumn colNamaBarang;
        private DataGridViewTextBoxColumn colJumlah;
        private DataGridViewTextBoxColumn colStokAkhir;
        private DataGridViewTextBoxColumn colKeterangan;
        private Label label6;
        private Label label3;
        private RoundedButton btnCari;
        private ComboBox cmbJenisTransaksi;
    }
}
