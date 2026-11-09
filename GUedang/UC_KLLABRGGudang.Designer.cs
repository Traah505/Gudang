namespace GUedang
{
    partial class UC_KLLABRGGudang
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
            label1 = new Label();
            panelDaftarBarang = new RoundedPanel();
            roundedTextBox1 = new RoundedTextBox();
            label9 = new Label();
            dgvKelolaBarang = new DataGridView();
            colKode = new DataGridViewTextBoxColumn();
            colNama = new DataGridViewTextBoxColumn();
            colKategori = new DataGridViewTextBoxColumn();
            colHargaBeli = new DataGridViewTextBoxColumn();
            colHargaJual = new DataGridViewTextBoxColumn();
            colStok = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            colAksi = new DataGridViewTextBoxColumn();
            roundedPanel2 = new RoundedPanel();
            btnHapus = new RoundedButton();
            btnReset = new RoundedButton();
            btnSimpan = new RoundedButton();
            numHargaJual = new NumericUpDown();
            label8 = new Label();
            numHargaBeli = new NumericUpDown();
            label7 = new Label();
            numStok = new NumericUpDown();
            label6 = new Label();
            cmbKategori = new ComboBox();
            label5 = new Label();
            txtNama = new RoundedTextBox();
            label4 = new Label();
            txtKode = new RoundedTextBox();
            label3 = new Label();
            label2 = new Label();
            panelDaftarBarang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKelolaBarang).BeginInit();
            roundedPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numHargaJual).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numHargaBeli).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numStok).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(10, 14);
            label1.Name = "label1";
            label1.Size = new Size(193, 38);
            label1.TabIndex = 0;
            label1.Text = "Kelola Barang";
            // 
            // panelDaftarBarang
            // 
            panelDaftarBarang.BackColor = Color.White;
            panelDaftarBarang.BorderStyle = BorderStyle.FixedSingle;
            panelDaftarBarang.Controls.Add(roundedTextBox1);
            panelDaftarBarang.Controls.Add(label9);
            panelDaftarBarang.Controls.Add(dgvKelolaBarang);
            panelDaftarBarang.Location = new Point(10, 55);
            panelDaftarBarang.Name = "panelDaftarBarang";
            panelDaftarBarang.Size = new Size(700, 450);
            panelDaftarBarang.TabIndex = 1;
            // 
            // roundedTextBox1
            // 
            roundedTextBox1.Font = new Font("Calibri Light", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            roundedTextBox1.Location = new Point(347, 10);
            roundedTextBox1.Name = "roundedTextBox1";
            roundedTextBox1.Size = new Size(300, 30);
            roundedTextBox1.TabIndex = 17;
            roundedTextBox1.Text = "Cari kode atau nama barang...";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Calibri", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.MidnightBlue;
            label9.Location = new Point(235, 12);
            label9.Name = "label9";
            label9.Size = new Size(106, 24);
            label9.TabIndex = 16;
            label9.Text = "Cari Barang";
            // 
            // dgvKelolaBarang
            // 
            dgvKelolaBarang.AllowUserToAddRows = false;
            dgvKelolaBarang.BackgroundColor = Color.White;
            dgvKelolaBarang.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.MidnightBlue;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvKelolaBarang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvKelolaBarang.ColumnHeadersHeight = 40;
            dgvKelolaBarang.Columns.AddRange(new DataGridViewColumn[] { colKode, colNama, colKategori, colHargaBeli, colHargaJual, colStok, colStatus, colAksi });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.MidnightBlue;
            dataGridViewCellStyle2.Padding = new Padding(6);
            dataGridViewCellStyle2.SelectionBackColor = Color.AliceBlue;
            dataGridViewCellStyle2.SelectionForeColor = Color.MidnightBlue;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvKelolaBarang.DefaultCellStyle = dataGridViewCellStyle2;
            dgvKelolaBarang.EnableHeadersVisualStyles = false;
            dgvKelolaBarang.Location = new Point(15, 45);
            dgvKelolaBarang.MultiSelect = false;
            dgvKelolaBarang.Name = "dgvKelolaBarang";
            dgvKelolaBarang.ReadOnly = true;
            dgvKelolaBarang.RowHeadersVisible = false;
            dgvKelolaBarang.RowHeadersWidth = 62;
            dgvKelolaBarang.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvKelolaBarang.RowTemplate.DefaultCellStyle.BackColor = Color.White;
            dgvKelolaBarang.RowTemplate.DefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgvKelolaBarang.RowTemplate.DefaultCellStyle.ForeColor = Color.MidnightBlue;
            dgvKelolaBarang.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.AliceBlue;
            dgvKelolaBarang.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.MidnightBlue;
            dgvKelolaBarang.RowTemplate.Height = 38;
            dgvKelolaBarang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKelolaBarang.Size = new Size(680, 390);
            dgvKelolaBarang.TabIndex = 0;
            dgvKelolaBarang.CellClick += dataGridView1_CellClick;
            // 
            // colKode
            // 
            colKode.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colKode.HeaderText = "Kode";
            colKode.MinimumWidth = 8;
            colKode.Name = "colKode";
            colKode.ReadOnly = true;
            colKode.Width = 150;
            // 
            // colNama
            // 
            colNama.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colNama.FillWeight = 180F;
            colNama.HeaderText = "Nama";
            colNama.MinimumWidth = 8;
            colNama.Name = "colNama";
            colNama.ReadOnly = true;
            colNama.Width = 180;
            // 
            // colKategori
            // 
            colKategori.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colKategori.FillWeight = 130F;
            colKategori.HeaderText = "Kategori";
            colKategori.MinimumWidth = 8;
            colKategori.Name = "colKategori";
            colKategori.ReadOnly = true;
            colKategori.Width = 130;
            // 
            // colHargaBeli
            // 
            colHargaBeli.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colHargaBeli.FillWeight = 130F;
            colHargaBeli.HeaderText = "Hrg Beli";
            colHargaBeli.MinimumWidth = 8;
            colHargaBeli.Name = "colHargaBeli";
            colHargaBeli.ReadOnly = true;
            colHargaBeli.Width = 130;
            // 
            // colHargaJual
            // 
            colHargaJual.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colHargaJual.FillWeight = 130F;
            colHargaJual.HeaderText = "Hrg Jual";
            colHargaJual.MinimumWidth = 8;
            colHargaJual.Name = "colHargaJual";
            colHargaJual.ReadOnly = true;
            colHargaJual.Width = 130;
            // 
            // colStok
            // 
            colStok.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colStok.FillWeight = 80F;
            colStok.HeaderText = "Stok";
            colStok.MinimumWidth = 8;
            colStok.Name = "colStok";
            colStok.ReadOnly = true;
            colStok.Width = 80;
            // 
            // colStatus
            // 
            colStatus.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colStatus.FillWeight = 110F;
            colStatus.HeaderText = "Status";
            colStatus.MinimumWidth = 8;
            colStatus.Name = "colStatus";
            colStatus.ReadOnly = true;
            colStatus.Width = 110;
            // 
            // colAksi
            // 
            colAksi.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colAksi.HeaderText = "Aksi";
            colAksi.MinimumWidth = 8;
            colAksi.Name = "colAksi";
            colAksi.ReadOnly = true;
            colAksi.Width = 150;
            // 
            // roundedPanel2
            // 
            roundedPanel2.BackColor = Color.White;
            roundedPanel2.BorderStyle = BorderStyle.FixedSingle;
            roundedPanel2.Controls.Add(btnHapus);
            roundedPanel2.Controls.Add(btnReset);
            roundedPanel2.Controls.Add(btnSimpan);
            roundedPanel2.Controls.Add(numHargaJual);
            roundedPanel2.Controls.Add(label8);
            roundedPanel2.Controls.Add(numHargaBeli);
            roundedPanel2.Controls.Add(label7);
            roundedPanel2.Controls.Add(numStok);
            roundedPanel2.Controls.Add(label6);
            roundedPanel2.Controls.Add(cmbKategori);
            roundedPanel2.Controls.Add(label5);
            roundedPanel2.Controls.Add(txtNama);
            roundedPanel2.Controls.Add(label4);
            roundedPanel2.Controls.Add(txtKode);
            roundedPanel2.Controls.Add(label3);
            roundedPanel2.Controls.Add(label2);
            roundedPanel2.Location = new Point(732, 55);
            roundedPanel2.Name = "roundedPanel2";
            roundedPanel2.Size = new Size(280, 450);
            roundedPanel2.TabIndex = 2;
            // 
            // btnHapus
            // 
            btnHapus.BackColor = Color.IndianRed;
            btnHapus.FlatAppearance.BorderSize = 0;
            btnHapus.FlatStyle = FlatStyle.Flat;
            btnHapus.ForeColor = Color.White;
            btnHapus.Location = new Point(180, 390);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(80, 35);
            btnHapus.TabIndex = 15;
            btnHapus.Text = "Hapus";
            btnHapus.UseVisualStyleBackColor = false;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.DimGray;
            btnReset.FlatAppearance.BorderSize = 0;
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.ForeColor = Color.White;
            btnReset.Location = new Point(100, 390);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(80, 35);
            btnReset.TabIndex = 14;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            // 
            // btnSimpan
            // 
            btnSimpan.BackColor = Color.RoyalBlue;
            btnSimpan.FlatAppearance.BorderSize = 0;
            btnSimpan.FlatStyle = FlatStyle.Flat;
            btnSimpan.ForeColor = Color.White;
            btnSimpan.Location = new Point(10, 390);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(80, 35);
            btnSimpan.TabIndex = 13;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = false;
            // 
            // numHargaJual
            // 
            numHargaJual.Location = new Point(10, 340);
            numHargaJual.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numHargaJual.Name = "numHargaJual";
            numHargaJual.Size = new Size(250, 31);
            numHargaJual.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Calibri Light", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(10, 320);
            label8.Name = "label8";
            label8.Size = new Size(78, 19);
            label8.TabIndex = 11;
            label8.Text = "Harga Jual";
            // 
            // numHargaBeli
            // 
            numHargaBeli.Location = new Point(10, 287);
            numHargaBeli.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numHargaBeli.Name = "numHargaBeli";
            numHargaBeli.Size = new Size(250, 31);
            numHargaBeli.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Calibri Light", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(10, 265);
            label7.Name = "label7";
            label7.Size = new Size(78, 19);
            label7.TabIndex = 9;
            label7.Text = "Harga Beli";
            // 
            // numStok
            // 
            numStok.Location = new Point(10, 230);
            numStok.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numStok.Name = "numStok";
            numStok.Size = new Size(250, 31);
            numStok.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri Light", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(10, 210);
            label6.Name = "label6";
            label6.Size = new Size(36, 19);
            label6.TabIndex = 7;
            label6.Text = "Stok";
            // 
            // cmbKategori
            // 
            cmbKategori.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbKategori.FormattingEnabled = true;
            cmbKategori.Location = new Point(10, 175);
            cmbKategori.Name = "cmbKategori";
            cmbKategori.Size = new Size(250, 33);
            cmbKategori.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri Light", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(10, 155);
            label5.Name = "label5";
            label5.Size = new Size(64, 19);
            label5.TabIndex = 5;
            label5.Text = "Kategori";
            // 
            // txtNama
            // 
            txtNama.Font = new Font("Calibri Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNama.Location = new Point(10, 120);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(250, 30);
            txtNama.TabIndex = 4;
            txtNama.Text = "Nama Barang...";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri Light", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(10, 100);
            label4.Name = "label4";
            label4.Size = new Size(99, 19);
            label4.TabIndex = 3;
            label4.Text = "Nama Barang";
            // 
            // txtKode
            // 
            txtKode.BackColor = Color.Gainsboro;
            txtKode.Location = new Point(10, 65);
            txtKode.Name = "txtKode";
            txtKode.ReadOnly = true;
            txtKode.Size = new Size(250, 30);
            txtKode.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri Light", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(10, 45);
            label3.Name = "label3";
            label3.Size = new Size(41, 19);
            label3.TabIndex = 1;
            label3.Text = "Kode";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.MidnightBlue;
            label2.Location = new Point(10, 12);
            label2.Name = "label2";
            label2.Size = new Size(129, 28);
            label2.TabIndex = 0;
            label2.Text = "Ubah Barang";
            // 
            // UC_KLLABRGGudang
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            Controls.Add(roundedPanel2);
            Controls.Add(panelDaftarBarang);
            Controls.Add(label1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "UC_KLLABRGGudang";
            Size = new Size(1039, 542);
            panelDaftarBarang.ResumeLayout(false);
            panelDaftarBarang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKelolaBarang).EndInit();
            roundedPanel2.ResumeLayout(false);
            roundedPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numHargaJual).EndInit();
            ((System.ComponentModel.ISupportInitialize)numHargaBeli).EndInit();
            ((System.ComponentModel.ISupportInitialize)numStok).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RoundedPanel panelDaftarBarang;
        private DataGridView dgvKelolaBarang;
        private RoundedPanel roundedPanel2;
        private RoundedTextBox txtKode;
        private Label label3;
        private Label label2;
        private Label label5;
        private RoundedTextBox txtNama;
        private Label label4;
        private Label label7;
        private NumericUpDown numStok;
        private Label label6;
        private ComboBox cmbKategori;
        private RoundedButton btnSimpan;
        private NumericUpDown numHargaJual;
        private Label label8;
        private NumericUpDown numHargaBeli;
        private RoundedButton btnHapus;
        private RoundedButton btnReset;
        private RoundedTextBox roundedTextBox1;
        private Label label9;
        private DataGridViewTextBoxColumn colKode;
        private DataGridViewTextBoxColumn colNama;
        private DataGridViewTextBoxColumn colKategori;
        private DataGridViewTextBoxColumn colHargaBeli;
        private DataGridViewTextBoxColumn colHargaJual;
        private DataGridViewTextBoxColumn colStok;
        private DataGridViewTextBoxColumn colStatus;
        private DataGridViewTextBoxColumn colAksi;
    }
}
