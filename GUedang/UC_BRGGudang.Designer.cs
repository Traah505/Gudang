namespace GUedang
{
    partial class UC_BRGGudang
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
            dgvBarang = new DataGridView();
            label1 = new Label();
            roundedPanel2 = new RoundedPanel();
            colNo = new DataGridViewTextBoxColumn();
            colTanggal = new DataGridViewTextBoxColumn();
            colKode = new DataGridViewTextBoxColumn();
            colNamaBarang = new DataGridViewTextBoxColumn();
            colJumlah = new DataGridViewTextBoxColumn();
            colHargaBeli = new DataGridViewTextBoxColumn();
            colKeterangan = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            label2 = new Label();
            roundedPanel3 = new RoundedPanel();
            label3 = new Label();
            lblTotalBarangMasuk = new Label();
            label4 = new Label();
            roundedPanel4 = new RoundedPanel();
            lblTotalNilaiMasuk = new Label();
            label6 = new Label();
            label7 = new Label();
            panel2 = new Panel();
            label5 = new Label();
            btnSimpan = new RoundedButton();
            txtKeterangan = new CustomTextBox();
            label8 = new Label();
            numJumlah = new NumericUpDown();
            label10 = new Label();
            btnCari = new Button();
            txtNamaAtauKode = new CustomTextBox();
            label9 = new Label();
            txtHargaBeli = new CustomTextBox();
            label11 = new Label();
            dtpTanggal = new DateTimePicker();
            roundedPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBarang).BeginInit();
            roundedPanel2.SuspendLayout();
            panel1.SuspendLayout();
            roundedPanel3.SuspendLayout();
            roundedPanel4.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numJumlah).BeginInit();
            SuspendLayout();
            // 
            // roundedPanel1
            // 
            roundedPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            roundedPanel1.BackColor = Color.Transparent;
            roundedPanel1.Controls.Add(dtpTanggal);
            roundedPanel1.Controls.Add(panel1);
            roundedPanel1.Controls.Add(roundedPanel2);
            roundedPanel1.Controls.Add(dgvBarang);
            roundedPanel1.Controls.Add(label1);
            roundedPanel1.Location = new Point(3, 17);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Size = new Size(971, 622);
            roundedPanel1.TabIndex = 0;
            // 
            // dgvBarang
            // 
            dgvBarang.AllowUserToAddRows = false;
            dgvBarang.AllowUserToDeleteRows = false;
            dgvBarang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBarang.BackgroundColor = Color.White;
            dgvBarang.BorderStyle = BorderStyle.None;
            dgvBarang.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.RoyalBlue;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.Padding = new Padding(8);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvBarang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvBarang.ColumnHeadersHeight = 45;
            dgvBarang.Columns.AddRange(new DataGridViewColumn[] { colNo, colTanggal, colKode, colNamaBarang, colJumlah, colHargaBeli, colKeterangan });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.MidnightBlue;
            dataGridViewCellStyle2.SelectionBackColor = Color.AliceBlue;
            dataGridViewCellStyle2.SelectionForeColor = Color.MidnightBlue;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvBarang.DefaultCellStyle = dataGridViewCellStyle2;
            dgvBarang.EnableHeadersVisualStyles = false;
            dgvBarang.GridColor = Color.Gainsboro;
            dgvBarang.Location = new Point(21, 329);
            dgvBarang.MultiSelect = false;
            dgvBarang.Name = "dgvBarang";
            dgvBarang.ReadOnly = true;
            dgvBarang.RowHeadersVisible = false;
            dgvBarang.RowHeadersWidth = 62;
            dgvBarang.RowTemplate.Height = 38;
            dgvBarang.Size = new Size(947, 290);
            dgvBarang.TabIndex = 1;
            dgvBarang.CellContentClick += dgvBarang_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(21, 0);
            label1.Name = "label1";
            label1.Size = new Size(238, 38);
            label1.TabIndex = 0;
            label1.Text = "📥Barang Masuk";
            // 
            // roundedPanel2
            // 
            roundedPanel2.BackColor = Color.Transparent;
            roundedPanel2.Controls.Add(label11);
            roundedPanel2.Controls.Add(txtHargaBeli);
            roundedPanel2.Controls.Add(label9);
            roundedPanel2.Controls.Add(btnSimpan);
            roundedPanel2.Controls.Add(txtKeterangan);
            roundedPanel2.Controls.Add(label8);
            roundedPanel2.Controls.Add(numJumlah);
            roundedPanel2.Controls.Add(label10);
            roundedPanel2.Controls.Add(btnCari);
            roundedPanel2.Controls.Add(txtNamaAtauKode);
            roundedPanel2.Controls.Add(panel2);
            roundedPanel2.Controls.Add(roundedPanel4);
            roundedPanel2.Controls.Add(roundedPanel3);
            roundedPanel2.Location = new Point(36, 53);
            roundedPanel2.Name = "roundedPanel2";
            roundedPanel2.Size = new Size(920, 225);
            roundedPanel2.TabIndex = 2;
            // 
            // colNo
            // 
            colNo.FillWeight = 65F;
            colNo.HeaderText = "No";
            colNo.MinimumWidth = 8;
            colNo.Name = "colNo";
            colNo.ReadOnly = true;
            // 
            // colTanggal
            // 
            colTanggal.HeaderText = "Tanggal";
            colTanggal.MinimumWidth = 8;
            colTanggal.Name = "colTanggal";
            colTanggal.ReadOnly = true;
            // 
            // colKode
            // 
            colKode.HeaderText = "Kode Barang";
            colKode.MinimumWidth = 8;
            colKode.Name = "colKode";
            colKode.ReadOnly = true;
            // 
            // colNamaBarang
            // 
            colNamaBarang.FillWeight = 130F;
            colNamaBarang.HeaderText = "Nama Barang";
            colNamaBarang.MinimumWidth = 8;
            colNamaBarang.Name = "colNamaBarang";
            colNamaBarang.ReadOnly = true;
            // 
            // colJumlah
            // 
            colJumlah.FillWeight = 115F;
            colJumlah.HeaderText = "Jumlah";
            colJumlah.MinimumWidth = 8;
            colJumlah.Name = "colJumlah";
            colJumlah.ReadOnly = true;
            // 
            // colHargaBeli
            // 
            colHargaBeli.FillWeight = 90F;
            colHargaBeli.HeaderText = "Harga Beli";
            colHargaBeli.MinimumWidth = 8;
            colHargaBeli.Name = "colHargaBeli";
            colHargaBeli.ReadOnly = true;
            // 
            // colKeterangan
            // 
            colKeterangan.HeaderText = "Keterangan";
            colKeterangan.MinimumWidth = 8;
            colKeterangan.Name = "colKeterangan";
            colKeterangan.ReadOnly = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.RoyalBlue;
            panel1.Controls.Add(label2);
            panel1.Location = new Point(21, 284);
            panel1.Name = "panel1";
            panel1.Size = new Size(947, 39);
            panel1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(216, 28);
            label2.TabIndex = 0;
            label2.Text = "Riwayat Barang Masuk";
            // 
            // roundedPanel3
            // 
            roundedPanel3.BackColor = Color.Transparent;
            roundedPanel3.Controls.Add(label4);
            roundedPanel3.Controls.Add(lblTotalBarangMasuk);
            roundedPanel3.Controls.Add(label3);
            roundedPanel3.Location = new Point(27, 6);
            roundedPanel3.Name = "roundedPanel3";
            roundedPanel3.Size = new Size(430, 89);
            roundedPanel3.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.RoyalBlue;
            label3.Location = new Point(37, 7);
            label3.Name = "label3";
            label3.Size = new Size(174, 25);
            label3.TabIndex = 0;
            label3.Text = "Total Barang Masuk";
            // 
            // lblTotalBarangMasuk
            // 
            lblTotalBarangMasuk.AutoSize = true;
            lblTotalBarangMasuk.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalBarangMasuk.ForeColor = Color.RoyalBlue;
            lblTotalBarangMasuk.Location = new Point(37, 32);
            lblTotalBarangMasuk.Name = "lblTotalBarangMasuk";
            lblTotalBarangMasuk.Size = new Size(27, 32);
            lblTotalBarangMasuk.TabIndex = 1;
            lblTotalBarangMasuk.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.RoyalBlue;
            label4.Location = new Point(58, 32);
            label4.Name = "label4";
            label4.Size = new Size(92, 32);
            label4.TabIndex = 2;
            label4.Text = "Barang";
            // 
            // roundedPanel4
            // 
            roundedPanel4.BackColor = Color.Transparent;
            roundedPanel4.Controls.Add(lblTotalNilaiMasuk);
            roundedPanel4.Controls.Add(label6);
            roundedPanel4.Controls.Add(label7);
            roundedPanel4.Location = new Point(477, 6);
            roundedPanel4.Name = "roundedPanel4";
            roundedPanel4.Size = new Size(430, 89);
            roundedPanel4.TabIndex = 3;
            // 
            // lblTotalNilaiMasuk
            // 
            lblTotalNilaiMasuk.AutoSize = true;
            lblTotalNilaiMasuk.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalNilaiMasuk.ForeColor = Color.ForestGreen;
            lblTotalNilaiMasuk.Location = new Point(76, 32);
            lblTotalNilaiMasuk.Name = "lblTotalNilaiMasuk";
            lblTotalNilaiMasuk.Size = new Size(27, 32);
            lblTotalNilaiMasuk.TabIndex = 2;
            lblTotalNilaiMasuk.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.ForestGreen;
            label6.Location = new Point(37, 32);
            label6.Name = "label6";
            label6.Size = new Size(43, 32);
            label6.TabIndex = 1;
            label6.Text = "Rp";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.ForestGreen;
            label7.Location = new Point(37, 7);
            label7.Name = "label7";
            label7.Size = new Size(154, 25);
            label7.TabIndex = 0;
            label7.Text = "Total Nilai Masuk";
            // 
            // panel2
            // 
            panel2.BackColor = Color.RoyalBlue;
            panel2.Controls.Add(label5);
            panel2.Location = new Point(3, 101);
            panel2.Name = "panel2";
            panel2.Size = new Size(225, 39);
            panel2.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(13, 0);
            label5.Name = "label5";
            label5.Size = new Size(196, 28);
            label5.TabIndex = 0;
            label5.Text = "Input Barang Masuk";
            // 
            // btnSimpan
            // 
            btnSimpan.BackColor = Color.RoyalBlue;
            btnSimpan.FlatAppearance.BorderSize = 0;
            btnSimpan.FlatStyle = FlatStyle.Flat;
            btnSimpan.ForeColor = Color.White;
            btnSimpan.Location = new Point(806, 146);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(101, 64);
            btnSimpan.TabIndex = 19;
            btnSimpan.Text = "💾Simpan";
            btnSimpan.UseVisualStyleBackColor = false;
            // 
            // txtKeterangan
            // 
            txtKeterangan.BackColor = Color.White;
            txtKeterangan.Font = new Font("Calibri Light", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtKeterangan.Location = new Point(484, 170);
            txtKeterangan.Name = "txtKeterangan";
            txtKeterangan.Padding = new Padding(10, 7, 10, 7);
            txtKeterangan.Size = new Size(184, 40);
            txtKeterangan.TabIndex = 18;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(484, 142);
            label8.Name = "label8";
            label8.Size = new Size(101, 25);
            label8.TabIndex = 17;
            label8.Text = "Ketarangan";
            // 
            // numJumlah
            // 
            numJumlah.BackColor = Color.White;
            numJumlah.Location = new Point(388, 179);
            numJumlah.Name = "numJumlah";
            numJumlah.Size = new Size(90, 31);
            numJumlah.TabIndex = 16;
            numJumlah.TextAlign = HorizontalAlignment.Center;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(390, 142);
            label10.Name = "label10";
            label10.Size = new Size(67, 25);
            label10.TabIndex = 15;
            label10.Text = "Jumlah";
            // 
            // btnCari
            // 
            btnCari.BackColor = Color.RoyalBlue;
            btnCari.ForeColor = Color.White;
            btnCari.Location = new Point(317, 166);
            btnCari.Name = "btnCari";
            btnCari.Size = new Size(55, 44);
            btnCari.TabIndex = 14;
            btnCari.Text = "🔍︎";
            btnCari.UseVisualStyleBackColor = false;
            // 
            // txtNamaAtauKode
            // 
            txtNamaAtauKode.BackColor = Color.White;
            txtNamaAtauKode.Font = new Font("Calibri Light", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNamaAtauKode.Location = new Point(16, 166);
            txtNamaAtauKode.Name = "txtNamaAtauKode";
            txtNamaAtauKode.Padding = new Padding(10, 7, 10, 7);
            txtNamaAtauKode.Size = new Size(356, 44);
            txtNamaAtauKode.TabIndex = 13;
            txtNamaAtauKode.Tag = "Masukan Nama Barang";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(669, 142);
            label9.Name = "label9";
            label9.Size = new Size(92, 25);
            label9.TabIndex = 20;
            label9.Text = "Harga Beli";
            // 
            // txtHargaBeli
            // 
            txtHargaBeli.BackColor = Color.White;
            txtHargaBeli.Font = new Font("Calibri Light", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtHargaBeli.Location = new Point(674, 170);
            txtHargaBeli.Name = "txtHargaBeli";
            txtHargaBeli.Padding = new Padding(10, 7, 10, 7);
            txtHargaBeli.Size = new Size(111, 40);
            txtHargaBeli.TabIndex = 21;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(24, 138);
            label11.Name = "label11";
            label11.Size = new Size(220, 25);
            label11.TabIndex = 22;
            label11.Text = "Masukan Nama atau Kode";
            // 
            // dtpTanggal
            // 
            dtpTanggal.CalendarForeColor = Color.DarkGray;
            dtpTanggal.Format = DateTimePickerFormat.Short;
            dtpTanggal.Location = new Point(819, 7);
            dtpTanggal.Name = "dtpTanggal";
            dtpTanggal.Size = new Size(124, 31);
            dtpTanggal.TabIndex = 4;
            // 
            // UC_BRGGudang
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            Controls.Add(roundedPanel1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "UC_BRGGudang";
            Size = new Size(987, 642);
            roundedPanel1.ResumeLayout(false);
            roundedPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBarang).EndInit();
            roundedPanel2.ResumeLayout(false);
            roundedPanel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            roundedPanel3.ResumeLayout(false);
            roundedPanel3.PerformLayout();
            roundedPanel4.ResumeLayout(false);
            roundedPanel4.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numJumlah).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private RoundedPanel roundedPanel1;
        private DataGridView dgvBarang;
        private Label label1;
        private Panel panel1;
        private Label label2;
        private RoundedPanel roundedPanel2;
        private DataGridViewTextBoxColumn colNo;
        private DataGridViewTextBoxColumn colTanggal;
        private DataGridViewTextBoxColumn colKode;
        private DataGridViewTextBoxColumn colNamaBarang;
        private DataGridViewTextBoxColumn colJumlah;
        private DataGridViewTextBoxColumn colHargaBeli;
        private DataGridViewTextBoxColumn colKeterangan;
        private RoundedPanel roundedPanel3;
        private Label lblTotalBarangMasuk;
        private Label label3;
        private Panel panel2;
        private Label label5;
        private RoundedPanel roundedPanel4;
        private Label lblTotalNilaiMasuk;
        private Label label6;
        private Label label7;
        private Label label4;
        private Label label11;
        private CustomTextBox txtHargaBeli;
        private Label label9;
        private RoundedButton btnSimpan;
        private CustomTextBox txtKeterangan;
        private Label label8;
        private NumericUpDown numJumlah;
        private Label label10;
        private Button btnCari;
        private CustomTextBox txtNamaAtauKode;
        private DateTimePicker dtpTanggal;
    }
}
