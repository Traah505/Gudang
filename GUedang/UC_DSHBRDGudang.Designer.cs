namespace GUedang
{
    partial class UC_DSHBRDGudang
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
            roundedPanel1 = new RoundedPanel();
            roundedPanel8 = new RoundedPanel();
            dgvPerhatian = new DataGridView();
            label6 = new Label();
            roundedPanel3 = new RoundedPanel();
            label4 = new Label();
            dgvAktivitasGudang = new DataGridView();
            colWaktu = new DataGridViewTextBoxColumn();
            colJenis = new DataGridViewTextBoxColumn();
            colNamaBarang = new DataGridViewTextBoxColumn();
            colJumlah = new DataGridViewTextBoxColumn();
            colStokAkhir = new DataGridViewTextBoxColumn();
            roundedPanel2 = new RoundedPanel();
            roundedPanel5 = new RoundedPanel();
            lblPerluPerhatian = new Label();
            label5 = new Label();
            roundedPanel4 = new RoundedPanel();
            lblStokSaatIni = new Label();
            label3 = new Label();
            roundedPanel6 = new RoundedPanel();
            lblBarangKeluar = new Label();
            CV = new Label();
            roundedPanel7 = new RoundedPanel();
            lblBarangMasuk = new Label();
            label2 = new Label();
            label1 = new Label();
            roundedPanel1.SuspendLayout();
            roundedPanel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPerhatian).BeginInit();
            roundedPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAktivitasGudang).BeginInit();
            roundedPanel2.SuspendLayout();
            roundedPanel5.SuspendLayout();
            roundedPanel4.SuspendLayout();
            roundedPanel6.SuspendLayout();
            roundedPanel7.SuspendLayout();
            SuspendLayout();
            // 
            // roundedPanel1
            // 
            roundedPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            roundedPanel1.BackColor = Color.Transparent;
            roundedPanel1.Controls.Add(roundedPanel8);
            roundedPanel1.Controls.Add(roundedPanel3);
            roundedPanel1.Controls.Add(roundedPanel2);
            roundedPanel1.Controls.Add(label1);
            roundedPanel1.Location = new Point(3, 3);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Size = new Size(1386, 587);
            roundedPanel1.TabIndex = 0;
            // 
            // roundedPanel8
            // 
            roundedPanel8.BackColor = Color.Transparent;
            roundedPanel8.Controls.Add(dgvPerhatian);
            roundedPanel8.Controls.Add(label6);
            roundedPanel8.Location = new Point(665, 250);
            roundedPanel8.Name = "roundedPanel8";
            roundedPanel8.Size = new Size(674, 261);
            roundedPanel8.TabIndex = 10;
            // 
            // dgvPerhatian
            // 
            dgvPerhatian.AllowUserToAddRows = false;
            dgvPerhatian.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPerhatian.BackgroundColor = Color.White;
            dgvPerhatian.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvPerhatian.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPerhatian.ColumnHeadersVisible = false;
            dgvPerhatian.Location = new Point(27, 36);
            dgvPerhatian.Name = "dgvPerhatian";
            dgvPerhatian.ReadOnly = true;
            dgvPerhatian.RowHeadersVisible = false;
            dgvPerhatian.RowHeadersWidth = 62;
            dgvPerhatian.Size = new Size(635, 207);
            dgvPerhatian.TabIndex = 4;
            dgvPerhatian.CellContentClick += dgvPerhatian_CellContentClick;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(18, 8);
            label6.Name = "label6";
            label6.Size = new Size(179, 25);
            label6.TabIndex = 3;
            label6.Text = "Stok Perlu Perhatian";
            // 
            // roundedPanel3
            // 
            roundedPanel3.BackColor = Color.Transparent;
            roundedPanel3.Controls.Add(label4);
            roundedPanel3.Controls.Add(dgvAktivitasGudang);
            roundedPanel3.Location = new Point(26, 250);
            roundedPanel3.Name = "roundedPanel3";
            roundedPanel3.Size = new Size(557, 337);
            roundedPanel3.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(19, 8);
            label4.Name = "label4";
            label4.Size = new Size(219, 25);
            label4.TabIndex = 2;
            label4.Text = "Aktivitas Gudang Hari ini";
            // 
            // dgvAktivitasGudang
            // 
            dgvAktivitasGudang.AllowUserToAddRows = false;
            dgvAktivitasGudang.AllowUserToDeleteRows = false;
            dgvAktivitasGudang.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dgvAktivitasGudang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAktivitasGudang.BackgroundColor = Color.White;
            dgvAktivitasGudang.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.RoyalBlue;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.AliceBlue;
            dataGridViewCellStyle1.SelectionBackColor = Color.AliceBlue;
            dataGridViewCellStyle1.SelectionForeColor = Color.MidnightBlue;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvAktivitasGudang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvAktivitasGudang.ColumnHeadersHeight = 35;
            dgvAktivitasGudang.Columns.AddRange(new DataGridViewColumn[] { colWaktu, colJenis, colNamaBarang, colJumlah, colStokAkhir });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.SlateGray;
            dataGridViewCellStyle2.SelectionBackColor = Color.LightSteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = Color.MidnightBlue;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvAktivitasGudang.DefaultCellStyle = dataGridViewCellStyle2;
            dgvAktivitasGudang.EnableHeadersVisualStyles = false;
            dgvAktivitasGudang.Location = new Point(19, 36);
            dgvAktivitasGudang.MultiSelect = false;
            dgvAktivitasGudang.Name = "dgvAktivitasGudang";
            dgvAktivitasGudang.ReadOnly = true;
            dgvAktivitasGudang.RowHeadersVisible = false;
            dgvAktivitasGudang.RowHeadersWidth = 62;
            dgvAktivitasGudang.RowTemplate.Height = 38;
            dgvAktivitasGudang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAktivitasGudang.Size = new Size(524, 281);
            dgvAktivitasGudang.TabIndex = 0;
            // 
            // colWaktu
            // 
            colWaktu.HeaderText = "Waktu";
            colWaktu.MinimumWidth = 8;
            colWaktu.Name = "colWaktu";
            colWaktu.ReadOnly = true;
            colWaktu.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colJenis
            // 
            colJenis.HeaderText = "Jenis";
            colJenis.MinimumWidth = 8;
            colJenis.Name = "colJenis";
            colJenis.ReadOnly = true;
            colJenis.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colNamaBarang
            // 
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
            colStokAkhir.HeaderText = "Stok Akhir";
            colStokAkhir.MinimumWidth = 8;
            colStokAkhir.Name = "colStokAkhir";
            colStokAkhir.ReadOnly = true;
            colStokAkhir.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // roundedPanel2
            // 
            roundedPanel2.BackColor = Color.Transparent;
            roundedPanel2.Controls.Add(roundedPanel5);
            roundedPanel2.Controls.Add(roundedPanel4);
            roundedPanel2.Controls.Add(roundedPanel6);
            roundedPanel2.Controls.Add(roundedPanel7);
            roundedPanel2.Location = new Point(3, 70);
            roundedPanel2.Name = "roundedPanel2";
            roundedPanel2.Size = new Size(1378, 154);
            roundedPanel2.TabIndex = 8;
            // 
            // roundedPanel5
            // 
            roundedPanel5.BackColor = Color.Transparent;
            roundedPanel5.Controls.Add(lblPerluPerhatian);
            roundedPanel5.Controls.Add(label5);
            roundedPanel5.Location = new Point(1038, 22);
            roundedPanel5.Name = "roundedPanel5";
            roundedPanel5.Size = new Size(323, 105);
            roundedPanel5.TabIndex = 3;
            // 
            // lblPerluPerhatian
            // 
            lblPerluPerhatian.AutoSize = true;
            lblPerluPerhatian.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPerluPerhatian.ForeColor = Color.MediumPurple;
            lblPerluPerhatian.Location = new Point(31, 39);
            lblPerluPerhatian.Name = "lblPerluPerhatian";
            lblPerluPerhatian.Size = new Size(38, 45);
            lblPerluPerhatian.TabIndex = 5;
            lblPerluPerhatian.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.DimGray;
            label5.Location = new Point(31, 14);
            label5.Name = "label5";
            label5.Size = new Size(127, 25);
            label5.TabIndex = 5;
            label5.Text = "Perlu Perhatian";
            // 
            // roundedPanel4
            // 
            roundedPanel4.BackColor = Color.Transparent;
            roundedPanel4.Controls.Add(lblStokSaatIni);
            roundedPanel4.Controls.Add(label3);
            roundedPanel4.Location = new Point(698, 22);
            roundedPanel4.Name = "roundedPanel4";
            roundedPanel4.Size = new Size(323, 105);
            roundedPanel4.TabIndex = 2;
            // 
            // lblStokSaatIni
            // 
            lblStokSaatIni.AutoSize = true;
            lblStokSaatIni.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStokSaatIni.ForeColor = Color.LightSeaGreen;
            lblStokSaatIni.Location = new Point(24, 39);
            lblStokSaatIni.Name = "lblStokSaatIni";
            lblStokSaatIni.Size = new Size(38, 45);
            lblStokSaatIni.TabIndex = 4;
            lblStokSaatIni.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.DimGray;
            label3.Location = new Point(24, 14);
            label3.Name = "label3";
            label3.Size = new Size(110, 25);
            label3.TabIndex = 4;
            label3.Text = "Stok Saat Ini";
            // 
            // roundedPanel6
            // 
            roundedPanel6.BackColor = Color.Transparent;
            roundedPanel6.Controls.Add(lblBarangKeluar);
            roundedPanel6.Controls.Add(CV);
            roundedPanel6.Location = new Point(358, 22);
            roundedPanel6.Name = "roundedPanel6";
            roundedPanel6.Size = new Size(323, 105);
            roundedPanel6.TabIndex = 1;
            // 
            // lblBarangKeluar
            // 
            lblBarangKeluar.AutoSize = true;
            lblBarangKeluar.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBarangKeluar.ForeColor = Color.SpringGreen;
            lblBarangKeluar.Location = new Point(27, 39);
            lblBarangKeluar.Name = "lblBarangKeluar";
            lblBarangKeluar.Size = new Size(38, 45);
            lblBarangKeluar.TabIndex = 3;
            lblBarangKeluar.Text = "0";
            // 
            // CV
            // 
            CV.AutoSize = true;
            CV.ForeColor = Color.DimGray;
            CV.Location = new Point(27, 14);
            CV.Name = "CV";
            CV.Size = new Size(181, 25);
            CV.TabIndex = 3;
            CV.Text = "Barang Keluar Hari Ini";
            // 
            // roundedPanel7
            // 
            roundedPanel7.BackColor = Color.Transparent;
            roundedPanel7.Controls.Add(lblBarangMasuk);
            roundedPanel7.Controls.Add(label2);
            roundedPanel7.Location = new Point(19, 22);
            roundedPanel7.Name = "roundedPanel7";
            roundedPanel7.Size = new Size(323, 105);
            roundedPanel7.TabIndex = 0;
            // 
            // lblBarangMasuk
            // 
            lblBarangMasuk.AutoSize = true;
            lblBarangMasuk.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBarangMasuk.ForeColor = Color.RoyalBlue;
            lblBarangMasuk.Location = new Point(23, 39);
            lblBarangMasuk.Name = "lblBarangMasuk";
            lblBarangMasuk.Size = new Size(38, 45);
            lblBarangMasuk.TabIndex = 1;
            lblBarangMasuk.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(23, 14);
            label2.Name = "label2";
            label2.Size = new Size(184, 25);
            label2.TabIndex = 0;
            label2.Text = "Barang Masuk Hari ini";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(24, 22);
            label1.Name = "label1";
            label1.Size = new Size(303, 45);
            label1.TabIndex = 0;
            label1.Text = "Dashboard Gudang";
            // 
            // UC_DSHBRDGudang
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(roundedPanel1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "UC_DSHBRDGudang";
            Size = new Size(1389, 608);
            Load += UC_DSHBRDGudang_Load;
            roundedPanel1.ResumeLayout(false);
            roundedPanel1.PerformLayout();
            roundedPanel8.ResumeLayout(false);
            roundedPanel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPerhatian).EndInit();
            roundedPanel3.ResumeLayout(false);
            roundedPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAktivitasGudang).EndInit();
            roundedPanel2.ResumeLayout(false);
            roundedPanel5.ResumeLayout(false);
            roundedPanel5.PerformLayout();
            roundedPanel4.ResumeLayout(false);
            roundedPanel4.PerformLayout();
            roundedPanel6.ResumeLayout(false);
            roundedPanel6.PerformLayout();
            roundedPanel7.ResumeLayout(false);
            roundedPanel7.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private RoundedPanel roundedPanel1;
        private Label label1;
        private RoundedPanel roundedPanel2;
        private RoundedPanel roundedPanel5;
        private Label lblPerluPerhatian;
        private Label label5;
        private RoundedPanel roundedPanel4;
        private Label lblStokSaatIni;
        private Label label3;
        private RoundedPanel roundedPanel6;
        private Label lblBarangKeluar;
        private Label CV;
        private RoundedPanel roundedPanel7;
        private Label lblBarangMasuk;
        private Label label2;
        private RoundedPanel roundedPanel3;
        private Label label4;
        private DataGridView dgvAktivitasGudang;
        private DataGridViewTextBoxColumn colWaktu;
        private DataGridViewTextBoxColumn colJenis;
        private DataGridViewTextBoxColumn colNamaBarang;
        private DataGridViewTextBoxColumn colJumlah;
        private DataGridViewTextBoxColumn colStokAkhir;
        private RoundedPanel roundedPanel8;
        private DataGridView dgvPerhatian;
        private Label label6;
    }
}
