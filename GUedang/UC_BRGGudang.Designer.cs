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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            roundedPanel1 = new RoundedPanel();
            dtpTanggal = new DateTimePicker();
            panel1 = new Panel();
            label2 = new Label();
            roundedPanel2 = new RoundedPanel();
            label11 = new Label();
            txtHargaBeli = new CustomTextBox();
            label9 = new Label();
            btnSimpan = new RoundedButton();
            txtKeterangan = new CustomTextBox();
            label8 = new Label();
            numJumlah = new NumericUpDown();
            label10 = new Label();
            btnCari = new Button();
            txtNamaAtauKode = new CustomTextBox();
            panel2 = new Panel();
            label5 = new Label();
            roundedPanel4 = new RoundedPanel();
            lblTotalNilai = new Label();
            label6 = new Label();
            label7 = new Label();
            roundedPanel3 = new RoundedPanel();
            label4 = new Label();
            lblTotalBarang = new Label();
            lbl = new Label();
            dgvBarang = new DataGridView();
            colNo = new DataGridViewTextBoxColumn();
            colTanggal = new DataGridViewTextBoxColumn();
            colKode = new DataGridViewTextBoxColumn();
            colNamaBarang = new DataGridViewTextBoxColumn();
            colJumlah = new DataGridViewTextBoxColumn();
            colHargaBeli = new DataGridViewTextBoxColumn();
            colKeterangan = new DataGridViewTextBoxColumn();
            label1 = new Label();
            roundedPanel1.SuspendLayout();
            panel1.SuspendLayout();
            roundedPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numJumlah).BeginInit();
            panel2.SuspendLayout();
            roundedPanel4.SuspendLayout();
            roundedPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBarang).BeginInit();
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
            roundedPanel1.Location = new Point(2, 2);
            roundedPanel1.Margin = new Padding(2);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Size = new Size(723, 381);
            roundedPanel1.TabIndex = 0;
            // 
            // dtpTanggal
            // 
            dtpTanggal.CalendarForeColor = Color.DarkGray;
            dtpTanggal.Format = DateTimePickerFormat.Short;
            dtpTanggal.Location = new Point(573, 4);
            dtpTanggal.Margin = new Padding(2);
            dtpTanggal.Name = "dtpTanggal";
            dtpTanggal.Size = new Size(88, 23);
            dtpTanggal.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.BackColor = Color.RoyalBlue;
            panel1.Controls.Add(label2);
            panel1.Location = new Point(15, 170);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(692, 23);
            panel1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(2, 0);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(151, 19);
            label2.TabIndex = 0;
            label2.Text = "Riwayat Barang Masuk";
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
            roundedPanel2.Location = new Point(25, 32);
            roundedPanel2.Margin = new Padding(2);
            roundedPanel2.Name = "roundedPanel2";
            roundedPanel2.Size = new Size(682, 135);
            roundedPanel2.TabIndex = 2;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(17, 83);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(146, 15);
            label11.TabIndex = 22;
            label11.Text = "Masukan Nama atau Kode";
            // 
            // txtHargaBeli
            // 
            txtHargaBeli.BackColor = Color.White;
            txtHargaBeli.Font = new Font("Calibri Light", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtHargaBeli.Location = new Point(472, 106);
            txtHargaBeli.Margin = new Padding(2);
            txtHargaBeli.Name = "txtHargaBeli";
            txtHargaBeli.Padding = new Padding(7, 4, 7, 4);
            txtHargaBeli.Size = new Size(78, 25);
            txtHargaBeli.TabIndex = 21;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(472, 83);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(61, 15);
            label9.TabIndex = 20;
            label9.Text = "Harga Beli";
            // 
            // btnSimpan
            // 
            btnSimpan.BackColor = Color.RoyalBlue;
            btnSimpan.FlatAppearance.BorderSize = 0;
            btnSimpan.FlatStyle = FlatStyle.Flat;
            btnSimpan.ForeColor = Color.White;
            btnSimpan.Location = new Point(588, 71);
            btnSimpan.Margin = new Padding(2);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(71, 38);
            btnSimpan.TabIndex = 19;
            btnSimpan.Text = "💾Simpan";
            btnSimpan.UseVisualStyleBackColor = false;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // txtKeterangan
            // 
            txtKeterangan.BackColor = Color.White;
            txtKeterangan.Font = new Font("Calibri Light", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtKeterangan.Location = new Point(339, 105);
            txtKeterangan.Margin = new Padding(2);
            txtKeterangan.Name = "txtKeterangan";
            txtKeterangan.Padding = new Padding(7, 4, 7, 4);
            txtKeterangan.Size = new Size(129, 25);
            txtKeterangan.TabIndex = 18;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(339, 83);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(67, 15);
            label8.TabIndex = 17;
            label8.Text = "Ketarangan";
            // 
            // numJumlah
            // 
            numJumlah.BackColor = Color.White;
            numJumlah.Location = new Point(272, 105);
            numJumlah.Margin = new Padding(2);
            numJumlah.Name = "numJumlah";
            numJumlah.Size = new Size(63, 23);
            numJumlah.TabIndex = 16;
            numJumlah.TextAlign = HorizontalAlignment.Center;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(273, 83);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(45, 15);
            label10.TabIndex = 15;
            label10.Text = "Jumlah";
            // 
            // btnCari
            // 
            btnCari.BackColor = Color.RoyalBlue;
            btnCari.ForeColor = Color.White;
            btnCari.Location = new Point(222, 100);
            btnCari.Margin = new Padding(2);
            btnCari.Name = "btnCari";
            btnCari.Size = new Size(38, 26);
            btnCari.TabIndex = 14;
            btnCari.Text = "🔍︎";
            btnCari.UseVisualStyleBackColor = false;
            // 
            // txtNamaAtauKode
            // 
            txtNamaAtauKode.BackColor = Color.White;
            txtNamaAtauKode.Font = new Font("Calibri Light", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNamaAtauKode.Location = new Point(11, 100);
            txtNamaAtauKode.Margin = new Padding(2);
            txtNamaAtauKode.Name = "txtNamaAtauKode";
            txtNamaAtauKode.Padding = new Padding(7, 4, 7, 4);
            txtNamaAtauKode.Size = new Size(249, 26);
            txtNamaAtauKode.TabIndex = 13;
            txtNamaAtauKode.Tag = "Masukan Nama Barang";
            // 
            // panel2
            // 
            panel2.BackColor = Color.RoyalBlue;
            panel2.Controls.Add(label5);
            panel2.Location = new Point(2, 61);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(158, 23);
            panel2.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(15, 0);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(134, 19);
            label5.TabIndex = 0;
            label5.Text = "Input Barang Masuk";
            // 
            // roundedPanel4
            // 
            roundedPanel4.BackColor = Color.Transparent;
            roundedPanel4.Controls.Add(lblTotalNilai);
            roundedPanel4.Controls.Add(label6);
            roundedPanel4.Controls.Add(label7);
            roundedPanel4.Location = new Point(334, 4);
            roundedPanel4.Margin = new Padding(2);
            roundedPanel4.Name = "roundedPanel4";
            roundedPanel4.Size = new Size(301, 53);
            roundedPanel4.TabIndex = 3;
            roundedPanel4.Paint += roundedPanel4_Paint;
            // 
            // lblTotalNilai
            // 
            lblTotalNilai.AutoSize = true;
            lblTotalNilai.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalNilai.ForeColor = Color.ForestGreen;
            lblTotalNilai.Location = new Point(53, 19);
            lblTotalNilai.Margin = new Padding(2, 0, 2, 0);
            lblTotalNilai.Name = "lblTotalNilai";
            lblTotalNilai.Size = new Size(19, 21);
            lblTotalNilai.TabIndex = 2;
            lblTotalNilai.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.ForestGreen;
            label6.Location = new Point(26, 19);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(30, 21);
            label6.TabIndex = 1;
            label6.Text = "Rp";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.ForestGreen;
            label7.Location = new Point(26, 4);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(98, 15);
            label7.TabIndex = 0;
            label7.Text = "Total Nilai Masuk";
            // 
            // roundedPanel3
            // 
            roundedPanel3.BackColor = Color.Transparent;
            roundedPanel3.Controls.Add(label4);
            roundedPanel3.Controls.Add(lblTotalBarang);
            roundedPanel3.Controls.Add(lbl);
            roundedPanel3.Location = new Point(19, 4);
            roundedPanel3.Margin = new Padding(2);
            roundedPanel3.Name = "roundedPanel3";
            roundedPanel3.Size = new Size(301, 53);
            roundedPanel3.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.RoyalBlue;
            label4.Location = new Point(41, 19);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(61, 21);
            label4.TabIndex = 2;
            label4.Text = "Barang";
            // 
            // lblTotalBarang
            // 
            lblTotalBarang.AutoSize = true;
            lblTotalBarang.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalBarang.ForeColor = Color.RoyalBlue;
            lblTotalBarang.Location = new Point(26, 19);
            lblTotalBarang.Margin = new Padding(2, 0, 2, 0);
            lblTotalBarang.Name = "lblTotalBarang";
            lblTotalBarang.Size = new Size(19, 21);
            lblTotalBarang.TabIndex = 1;
            lblTotalBarang.Text = "0";
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl.ForeColor = Color.RoyalBlue;
            lbl.Location = new Point(26, 4);
            lbl.Margin = new Padding(2, 0, 2, 0);
            lbl.Name = "lbl";
            lbl.Size = new Size(111, 15);
            lbl.TabIndex = 0;
            lbl.Text = "Total Barang Masuk";
            // 
            // dgvBarang
            // 
            dgvBarang.AllowUserToAddRows = false;
            dgvBarang.AllowUserToDeleteRows = false;
            dgvBarang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBarang.BackgroundColor = Color.White;
            dgvBarang.BorderStyle = BorderStyle.None;
            dgvBarang.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.RoyalBlue;
            dataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.Padding = new Padding(8);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvBarang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvBarang.ColumnHeadersHeight = 45;
            dgvBarang.Columns.AddRange(new DataGridViewColumn[] { colNo, colTanggal, colKode, colNamaBarang, colJumlah, colHargaBeli, colKeterangan });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = Color.MidnightBlue;
            dataGridViewCellStyle4.SelectionBackColor = Color.AliceBlue;
            dataGridViewCellStyle4.SelectionForeColor = Color.MidnightBlue;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvBarang.DefaultCellStyle = dataGridViewCellStyle4;
            dgvBarang.EnableHeadersVisualStyles = false;
            dgvBarang.GridColor = Color.Gainsboro;
            dgvBarang.Location = new Point(15, 197);
            dgvBarang.Margin = new Padding(2);
            dgvBarang.MultiSelect = false;
            dgvBarang.Name = "dgvBarang";
            dgvBarang.ReadOnly = true;
            dgvBarang.RowHeadersVisible = false;
            dgvBarang.RowHeadersWidth = 62;
            dgvBarang.RowTemplate.Height = 38;
            dgvBarang.Size = new Size(692, 174);
            dgvBarang.TabIndex = 1;
            dgvBarang.CellContentClick += dgvBarang_CellContentClick;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(15, 0);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(156, 25);
            label1.TabIndex = 0;
            label1.Text = "📥Barang Masuk";
            // 
            // UC_BRGGudang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            Controls.Add(roundedPanel1);
            Name = "UC_BRGGudang";
            Size = new Size(727, 385);
            roundedPanel1.ResumeLayout(false);
            roundedPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            roundedPanel2.ResumeLayout(false);
            roundedPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numJumlah).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            roundedPanel4.ResumeLayout(false);
            roundedPanel4.PerformLayout();
            roundedPanel3.ResumeLayout(false);
            roundedPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBarang).EndInit();
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
        private Label lblTotalBarang;
        private Label lbl;
        private Panel panel2;
        private Label label5;
        private RoundedPanel roundedPanel4;
        private Label lblTotalNilai;
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
