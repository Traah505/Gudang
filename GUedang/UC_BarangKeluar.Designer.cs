namespace GUedang
{
    partial class UC_BarangKeluar
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
            panelUCBarangKeluar = new Panel();
            panel1 = new Panel();
            label8 = new Label();
            roundedPanel4 = new RoundedPanel();
            dataGridView1 = new DataGridView();
            colNo = new DataGridViewTextBoxColumn();
            colTanggal = new DataGridViewTextBoxColumn();
            colKode = new DataGridViewTextBoxColumn();
            colNamaBarang = new DataGridViewTextBoxColumn();
            colJumlah = new DataGridViewTextBoxColumn();
            Keterangan = new DataGridViewTextBoxColumn();
            dtpTanggal = new DateTimePicker();
            roundedPanel1 = new RoundedPanel();
            label9 = new Label();
            btnSimpan = new RoundedButton();
            customTextBox2 = new CustomTextBox();
            label7 = new Label();
            numJumlah = new NumericUpDown();
            roundedPanel2 = new RoundedPanel();
            label3 = new Label();
            lblBarangKeluar = new Label();
            label2 = new Label();
            label5 = new Label();
            btnCari = new Button();
            customTextBox1 = new CustomTextBox();
            roundedPanel3 = new RoundedPanel();
            label4 = new Label();
            lblTotalPengeluaran = new Label();
            label6 = new Label();
            label1 = new Label();
            panelUCBarangKeluar.SuspendLayout();
            panel1.SuspendLayout();
            roundedPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            roundedPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numJumlah).BeginInit();
            roundedPanel2.SuspendLayout();
            roundedPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // panelUCBarangKeluar
            // 
            panelUCBarangKeluar.BackColor = Color.White;
            panelUCBarangKeluar.Controls.Add(panel1);
            panelUCBarangKeluar.Controls.Add(roundedPanel4);
            panelUCBarangKeluar.Controls.Add(dtpTanggal);
            panelUCBarangKeluar.Controls.Add(roundedPanel1);
            panelUCBarangKeluar.Controls.Add(label1);
            panelUCBarangKeluar.Dock = DockStyle.Fill;
            panelUCBarangKeluar.Location = new Point(0, 0);
            panelUCBarangKeluar.Name = "panelUCBarangKeluar";
            panelUCBarangKeluar.Size = new Size(1014, 578);
            panelUCBarangKeluar.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.RoyalBlue;
            panel1.Controls.Add(label8);
            panel1.ForeColor = SystemColors.ControlText;
            panel1.Location = new Point(29, 308);
            panel1.Name = "panel1";
            panel1.Size = new Size(930, 43);
            panel1.TabIndex = 0;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(30, 0);
            label8.Name = "label8";
            label8.Size = new Size(235, 30);
            label8.TabIndex = 11;
            label8.Text = "Riwayat Barang Keluar";
            // 
            // roundedPanel4
            // 
            roundedPanel4.BackColor = Color.Transparent;
            roundedPanel4.Controls.Add(dataGridView1);
            roundedPanel4.Location = new Point(29, 308);
            roundedPanel4.Name = "roundedPanel4";
            roundedPanel4.Size = new Size(930, 240);
            roundedPanel4.TabIndex = 12;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = Color.AliceBlue;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.RoyalBlue;
            dataGridViewCellStyle4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.RoyalBlue;
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.ColumnHeadersHeight = 42;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colNo, colTanggal, colKode, colNamaBarang, colJumlah, Keterangan });
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = SystemColors.HotTrack;
            dataGridView1.Location = new Point(0, 49);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 38;
            dataGridView1.Size = new Size(927, 188);
            dataGridView1.TabIndex = 0;
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
            colTanggal.FillWeight = 130F;
            colTanggal.HeaderText = "Tanggal";
            colTanggal.MinimumWidth = 8;
            colTanggal.Name = "colTanggal";
            colTanggal.ReadOnly = true;
            colTanggal.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colKode
            // 
            colKode.FillWeight = 120F;
            colKode.HeaderText = "Kode Barang";
            colKode.MinimumWidth = 8;
            colKode.Name = "colKode";
            colKode.ReadOnly = true;
            colKode.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colNamaBarang
            // 
            colNamaBarang.FillWeight = 180F;
            colNamaBarang.HeaderText = "Nama Barang";
            colNamaBarang.MinimumWidth = 8;
            colNamaBarang.Name = "colNamaBarang";
            colNamaBarang.ReadOnly = true;
            colNamaBarang.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colJumlah
            // 
            colJumlah.FillWeight = 110F;
            colJumlah.HeaderText = "Jumlah Keluar";
            colJumlah.MinimumWidth = 8;
            colJumlah.Name = "colJumlah";
            colJumlah.ReadOnly = true;
            colJumlah.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Keterangan
            // 
            Keterangan.FillWeight = 200F;
            Keterangan.HeaderText = "Keterangan";
            Keterangan.MinimumWidth = 8;
            Keterangan.Name = "Keterangan";
            Keterangan.ReadOnly = true;
            Keterangan.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // dtpTanggal
            // 
            dtpTanggal.Format = DateTimePickerFormat.Short;
            dtpTanggal.Location = new Point(822, 23);
            dtpTanggal.Name = "dtpTanggal";
            dtpTanggal.Size = new Size(137, 31);
            dtpTanggal.TabIndex = 11;
            // 
            // roundedPanel1
            // 
            roundedPanel1.BackColor = Color.Transparent;
            roundedPanel1.Controls.Add(label9);
            roundedPanel1.Controls.Add(btnSimpan);
            roundedPanel1.Controls.Add(customTextBox2);
            roundedPanel1.Controls.Add(label7);
            roundedPanel1.Controls.Add(numJumlah);
            roundedPanel1.Controls.Add(roundedPanel2);
            roundedPanel1.Controls.Add(label5);
            roundedPanel1.Controls.Add(btnCari);
            roundedPanel1.Controls.Add(customTextBox1);
            roundedPanel1.Controls.Add(roundedPanel3);
            roundedPanel1.Location = new Point(29, 84);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Size = new Size(930, 203);
            roundedPanel1.TabIndex = 1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.RoyalBlue;
            label9.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.White;
            label9.Location = new Point(37, 106);
            label9.Name = "label9";
            label9.Size = new Size(210, 30);
            label9.TabIndex = 12;
            label9.Text = "Input Barang Keluar";
            // 
            // btnSimpan
            // 
            btnSimpan.BackColor = Color.RoyalBlue;
            btnSimpan.FlatAppearance.BorderSize = 0;
            btnSimpan.FlatStyle = FlatStyle.Flat;
            btnSimpan.ForeColor = Color.White;
            btnSimpan.Location = new Point(795, 120);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(101, 64);
            btnSimpan.TabIndex = 10;
            btnSimpan.Text = "💾Simpan";
            btnSimpan.UseVisualStyleBackColor = false;
            // 
            // customTextBox2
            // 
            customTextBox2.BackColor = Color.White;
            customTextBox2.Font = new Font("Calibri Light", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            customTextBox2.Location = new Point(536, 144);
            customTextBox2.Name = "customTextBox2";
            customTextBox2.Padding = new Padding(10, 7, 10, 7);
            customTextBox2.Size = new Size(244, 40);
            customTextBox2.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(536, 120);
            label7.Name = "label7";
            label7.Size = new Size(101, 25);
            label7.TabIndex = 8;
            label7.Text = "Ketarangan";
            // 
            // numJumlah
            // 
            numJumlah.BackColor = Color.White;
            numJumlah.Location = new Point(421, 148);
            numJumlah.Name = "numJumlah";
            numJumlah.Size = new Size(90, 31);
            numJumlah.TabIndex = 7;
            numJumlah.TextAlign = HorizontalAlignment.Center;
            // 
            // roundedPanel2
            // 
            roundedPanel2.BackColor = Color.White;
            roundedPanel2.BorderStyle = BorderStyle.Fixed3D;
            roundedPanel2.Controls.Add(label3);
            roundedPanel2.Controls.Add(lblBarangKeluar);
            roundedPanel2.Controls.Add(label2);
            roundedPanel2.Location = new Point(200, 3);
            roundedPanel2.Name = "roundedPanel2";
            roundedPanel2.Size = new Size(352, 100);
            roundedPanel2.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.RoyalBlue;
            label3.Location = new Point(53, 35);
            label3.Name = "label3";
            label3.Size = new Size(92, 32);
            label3.TabIndex = 2;
            label3.Text = "Barang";
            // 
            // lblBarangKeluar
            // 
            lblBarangKeluar.AutoSize = true;
            lblBarangKeluar.BackColor = Color.Transparent;
            lblBarangKeluar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBarangKeluar.ForeColor = Color.RoyalBlue;
            lblBarangKeluar.Location = new Point(29, 35);
            lblBarangKeluar.Name = "lblBarangKeluar";
            lblBarangKeluar.Size = new Size(27, 32);
            lblBarangKeluar.TabIndex = 1;
            lblBarangKeluar.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.RoyalBlue;
            label2.Location = new Point(29, 10);
            label2.Name = "label2";
            label2.Size = new Size(173, 25);
            label2.TabIndex = 0;
            label2.Text = "Total Barang Keluar";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(421, 120);
            label5.Name = "label5";
            label5.Size = new Size(67, 25);
            label5.TabIndex = 6;
            label5.Text = "Jumlah";
            // 
            // btnCari
            // 
            btnCari.BackColor = Color.RoyalBlue;
            btnCari.ForeColor = Color.White;
            btnCari.Location = new Point(339, 140);
            btnCari.Name = "btnCari";
            btnCari.Size = new Size(55, 44);
            btnCari.TabIndex = 5;
            btnCari.Text = "🔍︎";
            btnCari.UseVisualStyleBackColor = false;
            // 
            // customTextBox1
            // 
            customTextBox1.BackColor = Color.White;
            customTextBox1.Font = new Font("Calibri Light", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            customTextBox1.Location = new Point(37, 140);
            customTextBox1.Name = "customTextBox1";
            customTextBox1.Padding = new Padding(10, 7, 10, 7);
            customTextBox1.Size = new Size(356, 44);
            customTextBox1.TabIndex = 4;
            customTextBox1.Tag = "Masukan Nama Barang";
            // 
            // roundedPanel3
            // 
            roundedPanel3.BackColor = Color.White;
            roundedPanel3.BorderStyle = BorderStyle.Fixed3D;
            roundedPanel3.Controls.Add(label4);
            roundedPanel3.Controls.Add(lblTotalPengeluaran);
            roundedPanel3.Controls.Add(label6);
            roundedPanel3.Location = new Point(575, 3);
            roundedPanel3.Name = "roundedPanel3";
            roundedPanel3.Size = new Size(321, 100);
            roundedPanel3.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.RoyalBlue;
            label4.Location = new Point(15, 35);
            label4.Name = "label4";
            label4.Size = new Size(43, 32);
            label4.TabIndex = 2;
            label4.Text = "Rp";
            label4.Click += label4_Click;
            // 
            // lblTotalPengeluaran
            // 
            lblTotalPengeluaran.AutoSize = true;
            lblTotalPengeluaran.BackColor = Color.Transparent;
            lblTotalPengeluaran.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalPengeluaran.ForeColor = Color.RoyalBlue;
            lblTotalPengeluaran.Location = new Point(52, 35);
            lblTotalPengeluaran.Name = "lblTotalPengeluaran";
            lblTotalPengeluaran.Size = new Size(27, 32);
            lblTotalPengeluaran.TabIndex = 1;
            lblTotalPengeluaran.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.RoyalBlue;
            label6.Location = new Point(29, 10);
            label6.Name = "label6";
            label6.Size = new Size(161, 25);
            label6.TabIndex = 0;
            label6.Text = "Total Pengeluaran";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(29, 23);
            label1.Name = "label1";
            label1.Size = new Size(270, 45);
            label1.TabIndex = 0;
            label1.Text = "📤Barang Keluar";
            // 
            // UC_BarangKeluar
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelUCBarangKeluar);
            Name = "UC_BarangKeluar";
            Size = new Size(1014, 578);
            panelUCBarangKeluar.ResumeLayout(false);
            panelUCBarangKeluar.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            roundedPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            roundedPanel1.ResumeLayout(false);
            roundedPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numJumlah).EndInit();
            roundedPanel2.ResumeLayout(false);
            roundedPanel2.PerformLayout();
            roundedPanel3.ResumeLayout(false);
            roundedPanel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelUCBarangKeluar;
        private Label label1;
        private RoundedPanel roundedPanel1;
        private RoundedPanel roundedPanel2;
        private Label lblBarangKeluar;
        private Label label2;
        private RoundedPanel roundedPanel3;
        private Label label4;
        private Label lblTotalPengeluaran;
        private Label label6;
        private Label label3;
        private CustomTextBox customTextBox1;
        private Label label5;
        private Button btnCari;
        private RoundedButton btnSimpan;
        private CustomTextBox customTextBox2;
        private Label label7;
        private NumericUpDown numJumlah;
        private Panel panel1;
        private RoundedPanel roundedPanel4;
        private DateTimePicker dtpTanggal;
        private Label label8;
        private DataGridView dataGridView1;
        private Label label9;
        private DataGridViewTextBoxColumn colNo;
        private DataGridViewTextBoxColumn colTanggal;
        private DataGridViewTextBoxColumn colKode;
        private DataGridViewTextBoxColumn colNamaBarang;
        private DataGridViewTextBoxColumn colJumlah;
        private DataGridViewTextBoxColumn Keterangan;
    }
}
