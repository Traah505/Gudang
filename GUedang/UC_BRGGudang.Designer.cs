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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_BRGGudang));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            roundedPanel1 = new RoundedPanel();
            pictureBox2 = new PictureBox();
            label7 = new Label();
            roundedPanel3 = new RoundedPanel();
            lblBarangKeluar = new Label();
            label8 = new Label();
            roundedPanel2 = new RoundedPanel();
            lblBarangMasuk = new Label();
            label6 = new Label();
            panelTambahBarang = new RoundedPanel();
            btnReset = new RoundedButton();
            btnTambahBarang = new RoundedButton();
            numStokAwal = new NumericUpDown();
            label5 = new Label();
            cmbKategori = new ComboBox();
            label4 = new Label();
            txtNamaBarang = new RoundedTextBox();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label2 = new Label();
            dgvBarang = new DataGridView();
            colNo = new DataGridViewTextBoxColumn();
            colNamaBarang = new DataGridViewTextBoxColumn();
            colKode = new DataGridViewTextBoxColumn();
            colKategori = new DataGridViewTextBoxColumn();
            colStok = new DataGridViewTextBoxColumn();
            label1 = new Label();
            roundedPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            roundedPanel3.SuspendLayout();
            roundedPanel2.SuspendLayout();
            panelTambahBarang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numStokAwal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvBarang).BeginInit();
            SuspendLayout();
            // 
            // roundedPanel1
            // 
            roundedPanel1.BackColor = Color.Transparent;
            roundedPanel1.Controls.Add(pictureBox2);
            roundedPanel1.Controls.Add(label7);
            roundedPanel1.Controls.Add(roundedPanel3);
            roundedPanel1.Controls.Add(roundedPanel2);
            roundedPanel1.Controls.Add(panelTambahBarang);
            roundedPanel1.Controls.Add(dgvBarang);
            roundedPanel1.Controls.Add(label1);
            roundedPanel1.Location = new Point(3, 17);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Size = new Size(971, 622);
            roundedPanel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(584, 10);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(31, 35);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(609, 12);
            label7.Name = "label7";
            label7.Size = new Size(91, 30);
            label7.TabIndex = 5;
            label7.Text = "Gudang";
            // 
            // roundedPanel3
            // 
            roundedPanel3.BackColor = Color.Transparent;
            roundedPanel3.Controls.Add(lblBarangKeluar);
            roundedPanel3.Controls.Add(label8);
            roundedPanel3.Location = new Point(381, 527);
            roundedPanel3.Name = "roundedPanel3";
            roundedPanel3.Size = new Size(283, 80);
            roundedPanel3.TabIndex = 4;
            // 
            // lblBarangKeluar
            // 
            lblBarangKeluar.AutoSize = true;
            lblBarangKeluar.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBarangKeluar.ForeColor = Color.White;
            lblBarangKeluar.Location = new Point(21, 38);
            lblBarangKeluar.Name = "lblBarangKeluar";
            lblBarangKeluar.Size = new Size(33, 38);
            lblBarangKeluar.TabIndex = 2;
            lblBarangKeluar.Text = "0";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(21, 8);
            label8.Name = "label8";
            label8.Size = new Size(151, 30);
            label8.TabIndex = 1;
            label8.Text = "Barang Keluar";
            // 
            // roundedPanel2
            // 
            roundedPanel2.BackColor = Color.Transparent;
            roundedPanel2.Controls.Add(lblBarangMasuk);
            roundedPanel2.Controls.Add(label6);
            roundedPanel2.Location = new Point(73, 523);
            roundedPanel2.Name = "roundedPanel2";
            roundedPanel2.Size = new Size(283, 80);
            roundedPanel2.TabIndex = 3;
            // 
            // lblBarangMasuk
            // 
            lblBarangMasuk.AutoSize = true;
            lblBarangMasuk.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBarangMasuk.ForeColor = Color.White;
            lblBarangMasuk.Location = new Point(21, 38);
            lblBarangMasuk.Name = "lblBarangMasuk";
            lblBarangMasuk.Size = new Size(33, 38);
            lblBarangMasuk.TabIndex = 2;
            lblBarangMasuk.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(21, 8);
            label6.Name = "label6";
            label6.Size = new Size(153, 30);
            label6.TabIndex = 1;
            label6.Text = "Barang Masuk";
            // 
            // panelTambahBarang
            // 
            panelTambahBarang.BackColor = Color.Transparent;
            panelTambahBarang.BorderStyle = BorderStyle.FixedSingle;
            panelTambahBarang.Controls.Add(btnReset);
            panelTambahBarang.Controls.Add(btnTambahBarang);
            panelTambahBarang.Controls.Add(numStokAwal);
            panelTambahBarang.Controls.Add(label5);
            panelTambahBarang.Controls.Add(cmbKategori);
            panelTambahBarang.Controls.Add(label4);
            panelTambahBarang.Controls.Add(txtNamaBarang);
            panelTambahBarang.Controls.Add(pictureBox1);
            panelTambahBarang.Controls.Add(label3);
            panelTambahBarang.Controls.Add(label2);
            panelTambahBarang.Location = new Point(731, 73);
            panelTambahBarang.Name = "panelTambahBarang";
            panelTambahBarang.Size = new Size(221, 529);
            panelTambahBarang.TabIndex = 2;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.White;
            btnReset.FlatAppearance.BorderSize = 0;
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReset.ForeColor = Color.RoyalBlue;
            btnReset.Location = new Point(116, 410);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(94, 98);
            btnReset.TabIndex = 12;
            btnReset.Text = "⟳ Reset";
            btnReset.UseVisualStyleBackColor = false;
            // 
            // btnTambahBarang
            // 
            btnTambahBarang.BackColor = Color.RoyalBlue;
            btnTambahBarang.FlatAppearance.BorderSize = 0;
            btnTambahBarang.FlatStyle = FlatStyle.Flat;
            btnTambahBarang.ForeColor = Color.White;
            btnTambahBarang.Location = new Point(3, 413);
            btnTambahBarang.Name = "btnTambahBarang";
            btnTambahBarang.Size = new Size(94, 98);
            btnTambahBarang.TabIndex = 11;
            btnTambahBarang.Text = "+ Tambah Barang";
            btnTambahBarang.UseVisualStyleBackColor = false;
            btnTambahBarang.Click += btnTambahBarang_Click;
            // 
            // numStokAwal
            // 
            numStokAwal.Location = new Point(1, 355);
            numStokAwal.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numStokAwal.Name = "numStokAwal";
            numStokAwal.Size = new Size(211, 31);
            numStokAwal.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 327);
            label5.Name = "label5";
            label5.Size = new Size(90, 25);
            label5.TabIndex = 9;
            label5.Text = "Stok Awal";
            // 
            // cmbKategori
            // 
            cmbKategori.BackColor = Color.White;
            cmbKategori.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbKategori.FormattingEnabled = true;
            cmbKategori.Location = new Point(1, 258);
            cmbKategori.Name = "cmbKategori";
            cmbKategori.Size = new Size(213, 33);
            cmbKategori.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 230);
            label4.Name = "label4";
            label4.Size = new Size(78, 25);
            label4.TabIndex = 7;
            label4.Text = "Kategori";
            // 
            // txtNamaBarang
            // 
            txtNamaBarang.Location = new Point(1, 150);
            txtNamaBarang.Name = "txtNamaBarang";
            txtNamaBarang.Size = new Size(211, 50);
            txtNamaBarang.TabIndex = 6;
            txtNamaBarang.Text = "Masukan Nama Barang...";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 43);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 35);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 122);
            label3.Name = "label3";
            label3.Size = new Size(119, 25);
            label3.TabIndex = 1;
            label3.Text = "Nama Barang";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(37, 43);
            label2.Name = "label2";
            label2.Size = new Size(185, 32);
            label2.TabIndex = 0;
            label2.Text = "Tambah Barang";
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
            dataGridViewCellStyle1.BackColor = Color.MidnightBlue;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.Padding = new Padding(8);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvBarang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvBarang.ColumnHeadersHeight = 45;
            dgvBarang.Columns.AddRange(new DataGridViewColumn[] { colNo, colNamaBarang, colKode, colKategori, colStok });
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
            dgvBarang.Location = new Point(19, 48);
            dgvBarang.MultiSelect = false;
            dgvBarang.Name = "dgvBarang";
            dgvBarang.ReadOnly = true;
            dgvBarang.RowHeadersVisible = false;
            dgvBarang.RowHeadersWidth = 62;
            dgvBarang.RowTemplate.Height = 38;
            dgvBarang.Size = new Size(681, 467);
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
            // colNamaBarang
            // 
            colNamaBarang.FillWeight = 130F;
            colNamaBarang.HeaderText = "Nama Barang";
            colNamaBarang.MinimumWidth = 8;
            colNamaBarang.Name = "colNamaBarang";
            colNamaBarang.ReadOnly = true;
            // 
            // colKode
            // 
            colKode.HeaderText = "Kode Barang";
            colKode.MinimumWidth = 8;
            colKode.Name = "colKode";
            colKode.ReadOnly = true;
            // 
            // colKategori
            // 
            colKategori.FillWeight = 115F;
            colKategori.HeaderText = "Kategori";
            colKategori.MinimumWidth = 8;
            colKategori.Name = "colKategori";
            colKategori.ReadOnly = true;
            // 
            // colStok
            // 
            colStok.FillWeight = 90F;
            colStok.HeaderText = "Stok";
            colStok.MinimumWidth = 8;
            colStok.Name = "colStok";
            colStok.ReadOnly = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(21, 0);
            label1.Name = "label1";
            label1.Size = new Size(123, 45);
            label1.TabIndex = 0;
            label1.Text = "Barang";
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
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            roundedPanel3.ResumeLayout(false);
            roundedPanel3.PerformLayout();
            roundedPanel2.ResumeLayout(false);
            roundedPanel2.PerformLayout();
            panelTambahBarang.ResumeLayout(false);
            panelTambahBarang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numStokAwal).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvBarang).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private RoundedPanel roundedPanel1;
        private DataGridView dgvBarang;
        private Label label1;
        private RoundedPanel panelTambahBarang;
        private Label label3;
        private Label label2;
        private ComboBox cmbKategori;
        private Label label4;
        private RoundedTextBox txtNamaBarang;
        private PictureBox pictureBox1;
        private RoundedButton btnReset;
        private RoundedButton btnTambahBarang;
        private NumericUpDown numStokAwal;
        private Label label5;
        private RoundedPanel roundedPanel2;
        private Label label6;
        private Label label7;
        private RoundedPanel roundedPanel3;
        private Label lblBarangKeluar;
        private Label label8;
        private Label lblBarangMasuk;
        private PictureBox pictureBox2;
        private DataGridViewTextBoxColumn colNo;
        private DataGridViewTextBoxColumn colNamaBarang;
        private DataGridViewTextBoxColumn colKode;
        private DataGridViewTextBoxColumn colKategori;
        private DataGridViewTextBoxColumn colStok;
    }
}
