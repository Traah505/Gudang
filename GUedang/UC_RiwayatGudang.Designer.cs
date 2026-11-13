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
            roundedPanel4 = new RoundedPanel();
            panel6 = new Panel();
            lblStokSaatIni = new Label();
            label5 = new Label();
            roundedPanel3 = new RoundedPanel();
            panel5 = new Panel();
            lblTotalBarangKeluar = new Label();
            label4 = new Label();
            roundedPanel2 = new RoundedPanel();
            panel7 = new Panel();
            lblTotalBrgMasuk = new Label();
            label2 = new Label();
            roundedPanel1 = new RoundedPanel();
            roundedButton1 = new RoundedButton();
            cmbJenisTransaksi = new ComboBox();
            label6 = new Label();
            panel8 = new Panel();
            label3 = new Label();
            dtpTanggalAwal = new DateTimePicker();
            dtpTanggalAkhir = new DateTimePicker();
            label1 = new Label();
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
            panel1.Controls.Add(roundedPanel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(roundedPanel4);
            panel1.Controls.Add(roundedPanel3);
            panel1.Controls.Add(roundedPanel2);
            panel1.Controls.Add(roundedPanel1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2, 2, 2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(756, 334);
            panel1.TabIndex = 0;
            // 
            // roundedPanel5
            // 
            roundedPanel5.BackColor = Color.Transparent;
            roundedPanel5.Controls.Add(dgvRiwayatGudang);
            roundedPanel5.Location = new Point(18, 142);
            roundedPanel5.Margin = new Padding(2, 2, 2, 2);
            roundedPanel5.Name = "roundedPanel5";
            roundedPanel5.Size = new Size(720, 180);
            roundedPanel5.TabIndex = 7;
            // 
            // dgvRiwayatGudang
            // 
            dgvRiwayatGudang.AllowUserToAddRows = false;
            dgvRiwayatGudang.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.DeepSkyBlue;
            dgvRiwayatGudang.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
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
            dgvRiwayatGudang.Location = new Point(11, 8);
            dgvRiwayatGudang.Margin = new Padding(2, 2, 2, 2);
            dgvRiwayatGudang.MultiSelect = false;
            dgvRiwayatGudang.Name = "dgvRiwayatGudang";
            dgvRiwayatGudang.ReadOnly = true;
            dgvRiwayatGudang.RowHeadersVisible = false;
            dgvRiwayatGudang.RowHeadersWidth = 62;
            dgvRiwayatGudang.RowTemplate.Height = 40;
            dgvRiwayatGudang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRiwayatGudang.Size = new Size(697, 161);
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
            panel4.Location = new Point(527, 64);
            panel4.Margin = new Padding(2, 2, 2, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(13, 69);
            panel4.TabIndex = 6;
            // 
            // panel3
            // 
            panel3.BackColor = Color.SeaGreen;
            panel3.Location = new Point(277, 62);
            panel3.Margin = new Padding(2, 2, 2, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(13, 69);
            panel3.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.BackColor = Color.RoyalBlue;
            panel2.Location = new Point(29, 64);
            panel2.Margin = new Padding(2, 2, 2, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(13, 69);
            panel2.TabIndex = 4;
            // 
            // roundedPanel4
            // 
            roundedPanel4.BackColor = Color.Transparent;
            roundedPanel4.Controls.Add(panel6);
            roundedPanel4.Controls.Add(lblStokSaatIni);
            roundedPanel4.Controls.Add(label5);
            roundedPanel4.Location = new Point(527, 62);
            roundedPanel4.Margin = new Padding(2, 2, 2, 2);
            roundedPanel4.Name = "roundedPanel4";
            roundedPanel4.Size = new Size(210, 69);
            roundedPanel4.TabIndex = 3;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Purple;
            panel6.Location = new Point(195, 2);
            panel6.Margin = new Padding(2, 2, 2, 2);
            panel6.Name = "panel6";
            panel6.Size = new Size(13, 69);
            panel6.TabIndex = 7;
            // 
            // lblStokSaatIni
            // 
            lblStokSaatIni.AutoSize = true;
            lblStokSaatIni.Font = new Font("Arial", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStokSaatIni.ForeColor = Color.Purple;
            lblStokSaatIni.Location = new Point(19, 32);
            lblStokSaatIni.Margin = new Padding(2, 0, 2, 0);
            lblStokSaatIni.Name = "lblStokSaatIni";
            lblStokSaatIni.Size = new Size(24, 26);
            lblStokSaatIni.TabIndex = 4;
            lblStokSaatIni.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri Light", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(19, 12);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(61, 13);
            label5.TabIndex = 2;
            label5.Text = "Stok Saat Ini";
            // 
            // roundedPanel3
            // 
            roundedPanel3.BackColor = Color.Transparent;
            roundedPanel3.Controls.Add(panel5);
            roundedPanel3.Controls.Add(lblTotalBarangKeluar);
            roundedPanel3.Controls.Add(label4);
            roundedPanel3.Location = new Point(277, 62);
            roundedPanel3.Margin = new Padding(2, 2, 2, 2);
            roundedPanel3.Name = "roundedPanel3";
            roundedPanel3.Size = new Size(210, 69);
            roundedPanel3.TabIndex = 2;
            // 
            // panel5
            // 
            panel5.BackColor = Color.SeaGreen;
            panel5.Location = new Point(197, 2);
            panel5.Margin = new Padding(2, 2, 2, 2);
            panel5.Name = "panel5";
            panel5.Size = new Size(13, 69);
            panel5.TabIndex = 6;
            // 
            // lblTotalBarangKeluar
            // 
            lblTotalBarangKeluar.AutoSize = true;
            lblTotalBarangKeluar.Font = new Font("Arial", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalBarangKeluar.ForeColor = Color.SeaGreen;
            lblTotalBarangKeluar.Location = new Point(25, 32);
            lblTotalBarangKeluar.Margin = new Padding(2, 0, 2, 0);
            lblTotalBarangKeluar.Name = "lblTotalBarangKeluar";
            lblTotalBarangKeluar.Size = new Size(24, 26);
            lblTotalBarangKeluar.TabIndex = 3;
            lblTotalBarangKeluar.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri Light", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(25, 12);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(91, 13);
            label4.TabIndex = 1;
            label4.Text = "Total Barang Keluar";
            // 
            // roundedPanel2
            // 
            roundedPanel2.BackColor = Color.Transparent;
            roundedPanel2.Controls.Add(panel7);
            roundedPanel2.Controls.Add(lblTotalBrgMasuk);
            roundedPanel2.Controls.Add(label2);
            roundedPanel2.Location = new Point(29, 62);
            roundedPanel2.Margin = new Padding(2, 2, 2, 2);
            roundedPanel2.Name = "roundedPanel2";
            roundedPanel2.Size = new Size(210, 69);
            roundedPanel2.TabIndex = 1;
            // 
            // panel7
            // 
            panel7.BackColor = Color.RoyalBlue;
            panel7.Location = new Point(195, 2);
            panel7.Margin = new Padding(2, 2, 2, 2);
            panel7.Name = "panel7";
            panel7.Size = new Size(13, 69);
            panel7.TabIndex = 5;
            // 
            // lblTotalBrgMasuk
            // 
            lblTotalBrgMasuk.AutoSize = true;
            lblTotalBrgMasuk.Font = new Font("Arial", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalBrgMasuk.ForeColor = Color.RoyalBlue;
            lblTotalBrgMasuk.Location = new Point(18, 32);
            lblTotalBrgMasuk.Margin = new Padding(2, 0, 2, 0);
            lblTotalBrgMasuk.Name = "lblTotalBrgMasuk";
            lblTotalBrgMasuk.Size = new Size(24, 26);
            lblTotalBrgMasuk.TabIndex = 2;
            lblTotalBrgMasuk.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri Light", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(18, 12);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(92, 13);
            label2.TabIndex = 0;
            label2.Text = "Total Barang Masuk";
            // 
            // roundedPanel1
            // 
            roundedPanel1.BackColor = Color.Transparent;
            roundedPanel1.Controls.Add(roundedButton1);
            roundedPanel1.Controls.Add(cmbJenisTransaksi);
            roundedPanel1.Controls.Add(label6);
            roundedPanel1.Controls.Add(panel8);
            roundedPanel1.Controls.Add(label1);
            roundedPanel1.Location = new Point(2, 2);
            roundedPanel1.Margin = new Padding(2, 2, 2, 2);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Size = new Size(752, 51);
            roundedPanel1.TabIndex = 0;
            // 
            // roundedButton1
            // 
            roundedButton1.BackColor = Color.RoyalBlue;
            roundedButton1.FlatAppearance.BorderSize = 0;
            roundedButton1.FlatStyle = FlatStyle.Flat;
            roundedButton1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            roundedButton1.ForeColor = Color.White;
            roundedButton1.Location = new Point(657, 25);
            roundedButton1.Margin = new Padding(2, 2, 2, 2);
            roundedButton1.Name = "roundedButton1";
            roundedButton1.Size = new Size(69, 25);
            roundedButton1.TabIndex = 6;
            roundedButton1.Text = "🔍Cari";
            roundedButton1.UseVisualStyleBackColor = false;
            // 
            // cmbJenisTransaksi
            // 
            cmbJenisTransaksi.FormattingEnabled = true;
            cmbJenisTransaksi.Items.AddRange(new object[] { "Masuk", "Keluar" });
            cmbJenisTransaksi.Location = new Point(525, 29);
            cmbJenisTransaksi.Margin = new Padding(2, 2, 2, 2);
            cmbJenisTransaksi.Name = "cmbJenisTransaksi";
            cmbJenisTransaksi.Size = new Size(129, 23);
            cmbJenisTransaksi.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(525, 11);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(82, 15);
            label6.TabIndex = 4;
            label6.Text = "Jenis Transaksi";
            // 
            // panel8
            // 
            panel8.BackColor = Color.White;
            panel8.Controls.Add(label3);
            panel8.Controls.Add(dtpTanggalAwal);
            panel8.Controls.Add(dtpTanggalAkhir);
            panel8.Location = new Point(291, 4);
            panel8.Margin = new Padding(2, 2, 2, 2);
            panel8.Name = "panel8";
            panel8.Size = new Size(210, 47);
            panel8.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(52, 9);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(100, 15);
            label3.TabIndex = 3;
            label3.Text = "📅Rentang Waktu";
            // 
            // dtpTanggalAwal
            // 
            dtpTanggalAwal.Format = DateTimePickerFormat.Custom;
            dtpTanggalAwal.Location = new Point(2, 27);
            dtpTanggalAwal.Margin = new Padding(2, 2, 2, 2);
            dtpTanggalAwal.MaxDate = new DateTime(9994, 12, 31, 0, 0, 0, 0);
            dtpTanggalAwal.Name = "dtpTanggalAwal";
            dtpTanggalAwal.Size = new Size(88, 23);
            dtpTanggalAwal.TabIndex = 1;
            // 
            // dtpTanggalAkhir
            // 
            dtpTanggalAkhir.CalendarForeColor = Color.White;
            dtpTanggalAkhir.CalendarMonthBackground = Color.RoyalBlue;
            dtpTanggalAkhir.Format = DateTimePickerFormat.Custom;
            dtpTanggalAkhir.Location = new Point(121, 27);
            dtpTanggalAkhir.Margin = new Padding(2, 2, 2, 2);
            dtpTanggalAkhir.MaxDate = new DateTime(9994, 12, 31, 0, 0, 0, 0);
            dtpTanggalAkhir.Name = "dtpTanggalAkhir";
            dtpTanggalAkhir.Size = new Size(88, 23);
            dtpTanggalAkhir.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(15, 11);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(152, 25);
            label1.TabIndex = 0;
            label1.Text = "Riwayat Gudang";
            // 
            // UC_RiwayatGudang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "UC_RiwayatGudang";
            Size = new Size(756, 334);
            panel1.ResumeLayout(false);
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
        private Label lblTotalBarangKeluar;
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
        private DateTimePicker dtpTanggalAkhir;
        private DateTimePicker dtpTanggalAwal;
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
        private RoundedButton roundedButton1;
        private ComboBox cmbJenisTransaksi;
    }
}
