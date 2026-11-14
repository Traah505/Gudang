namespace GUedang
{
    partial class UC_Barang
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
            label2 = new Label();
            txtCari = new RoundedTextBox();
            btnSemua = new RoundedButton();
            btnAman = new RoundedButton();
            btnMenipis = new RoundedButton();
            btnHabis = new RoundedButton();
            roundedPanel2 = new RoundedPanel();
            numMinimum = new NumericUpDown();
            label3 = new Label();
            roundedTextBox1 = new RoundedTextBox();
            btnHapus = new RoundedButton();
            btnReset = new RoundedButton();
            btnSimpan = new RoundedButton();
            numHargaJual = new NumericUpDown();
            label8 = new Label();
            numHargaBeli = new NumericUpDown();
            label7 = new Label();
            numStok = new NumericUpDown();
            label6 = new Label();
            label5 = new Label();
            txtNamaBarang = new RoundedTextBox();
            label4 = new Label();
            txtKode = new RoundedTextBox();
            label9 = new Label();
            label11 = new Label();
            panelDaftarBarang = new RoundedPanel();
            dgvKelolaBarang = new DataGridView();
            roundedPanel5 = new RoundedPanel();
            panelTotal = new RoundedPanel();
            lblTotalBarang = new Label();
            label10 = new Label();
            panelHabis = new RoundedPanel();
            lblStokHabis = new Label();
            label16 = new Label();
            panelMenipis = new RoundedPanel();
            lblStokMenipis = new Label();
            label14 = new Label();
            panelAman = new RoundedPanel();
            lblStokAman = new Label();
            label12 = new Label();
            roundedPanel1 = new RoundedPanel();
            colKode = new DataGridViewTextBoxColumn();
            colNama = new DataGridViewTextBoxColumn();
            colKategori = new DataGridViewTextBoxColumn();
            colHargaBeli = new DataGridViewTextBoxColumn();
            colHargaJual = new DataGridViewTextBoxColumn();
            colStok = new DataGridViewTextBoxColumn();
            colMinimum = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            colAksi = new DataGridViewTextBoxColumn();
            roundedPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numMinimum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numHargaJual).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numHargaBeli).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numStok).BeginInit();
            panelDaftarBarang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKelolaBarang).BeginInit();
            roundedPanel5.SuspendLayout();
            panelTotal.SuspendLayout();
            panelHabis.SuspendLayout();
            panelMenipis.SuspendLayout();
            panelAman.SuspendLayout();
            roundedPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(44, 13);
            label1.Name = "label1";
            label1.Size = new Size(171, 38);
            label1.TabIndex = 0;
            label1.Text = "Stok Barang";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.MidnightBlue;
            label2.Location = new Point(44, 55);
            label2.Name = "label2";
            label2.Size = new Size(165, 25);
            label2.TabIndex = 1;
            label2.Text = "Pantau stok barang";
            // 
            // txtCari
            // 
            txtCari.Font = new Font("Calibri Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCari.ForeColor = Color.MidnightBlue;
            txtCari.Location = new Point(43, 28);
            txtCari.Name = "txtCari";
            txtCari.Size = new Size(529, 47);
            txtCari.TabIndex = 0;
            txtCari.Text = "Cari nama barang atau kode...";
            // 
            // btnSemua
            // 
            btnSemua.BackColor = Color.RoyalBlue;
            btnSemua.FlatAppearance.BorderSize = 0;
            btnSemua.FlatStyle = FlatStyle.Flat;
            btnSemua.Font = new Font("Calibri", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSemua.ForeColor = Color.White;
            btnSemua.Location = new Point(665, 20);
            btnSemua.Name = "btnSemua";
            btnSemua.Size = new Size(97, 50);
            btnSemua.TabIndex = 1;
            btnSemua.Text = "Semua";
            btnSemua.UseVisualStyleBackColor = false;
            // 
            // btnAman
            // 
            btnAman.BackColor = Color.SeaGreen;
            btnAman.FlatAppearance.BorderSize = 0;
            btnAman.FlatStyle = FlatStyle.Flat;
            btnAman.Font = new Font("Calibri", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAman.ForeColor = Color.White;
            btnAman.Location = new Point(768, 20);
            btnAman.Name = "btnAman";
            btnAman.Size = new Size(93, 50);
            btnAman.TabIndex = 6;
            btnAman.Text = "Aman";
            btnAman.UseVisualStyleBackColor = false;
            // 
            // btnMenipis
            // 
            btnMenipis.BackColor = Color.Goldenrod;
            btnMenipis.FlatAppearance.BorderSize = 0;
            btnMenipis.FlatStyle = FlatStyle.Flat;
            btnMenipis.Font = new Font("Calibri", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMenipis.ForeColor = Color.White;
            btnMenipis.Location = new Point(967, 20);
            btnMenipis.Name = "btnMenipis";
            btnMenipis.Size = new Size(107, 50);
            btnMenipis.TabIndex = 7;
            btnMenipis.Text = "Menipis";
            btnMenipis.UseVisualStyleBackColor = false;
            // 
            // btnHabis
            // 
            btnHabis.BackColor = Color.IndianRed;
            btnHabis.FlatAppearance.BorderSize = 0;
            btnHabis.FlatStyle = FlatStyle.Flat;
            btnHabis.Font = new Font("Calibri", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHabis.ForeColor = Color.White;
            btnHabis.Location = new Point(867, 20);
            btnHabis.Name = "btnHabis";
            btnHabis.Size = new Size(94, 50);
            btnHabis.TabIndex = 8;
            btnHabis.Text = "Habis";
            btnHabis.UseVisualStyleBackColor = false;
            // 
            // roundedPanel2
            // 
            roundedPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            roundedPanel2.BackColor = Color.White;
            roundedPanel2.Controls.Add(numMinimum);
            roundedPanel2.Controls.Add(label3);
            roundedPanel2.Controls.Add(roundedTextBox1);
            roundedPanel2.Controls.Add(btnHapus);
            roundedPanel2.Controls.Add(btnReset);
            roundedPanel2.Controls.Add(btnSimpan);
            roundedPanel2.Controls.Add(numHargaJual);
            roundedPanel2.Controls.Add(label8);
            roundedPanel2.Controls.Add(numHargaBeli);
            roundedPanel2.Controls.Add(label7);
            roundedPanel2.Controls.Add(numStok);
            roundedPanel2.Controls.Add(label6);
            roundedPanel2.Controls.Add(label5);
            roundedPanel2.Controls.Add(txtNamaBarang);
            roundedPanel2.Controls.Add(label4);
            roundedPanel2.Controls.Add(txtKode);
            roundedPanel2.Controls.Add(label9);
            roundedPanel2.Controls.Add(label11);
            roundedPanel2.Location = new Point(1132, 238);
            roundedPanel2.Name = "roundedPanel2";
            roundedPanel2.Size = new Size(353, 558);
            roundedPanel2.TabIndex = 9;
            // 
            // numMinimum
            // 
            numMinimum.Location = new Point(9, 428);
            numMinimum.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numMinimum.Name = "numMinimum";
            numMinimum.Size = new Size(275, 31);
            numMinimum.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri Light", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(14, 406);
            label3.Name = "label3";
            label3.Size = new Size(73, 19);
            label3.TabIndex = 17;
            label3.Text = "Minimum";
            // 
            // roundedTextBox1
            // 
            roundedTextBox1.Font = new Font("Calibri Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            roundedTextBox1.Location = new Point(14, 182);
            roundedTextBox1.Name = "roundedTextBox1";
            roundedTextBox1.Size = new Size(271, 40);
            roundedTextBox1.TabIndex = 16;
            // 
            // btnHapus
            // 
            btnHapus.BackColor = Color.IndianRed;
            btnHapus.FlatAppearance.BorderSize = 0;
            btnHapus.FlatStyle = FlatStyle.Flat;
            btnHapus.ForeColor = Color.White;
            btnHapus.Location = new Point(186, 479);
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
            btnReset.Location = new Point(100, 479);
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
            btnSimpan.Location = new Point(14, 479);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(80, 35);
            btnSimpan.TabIndex = 13;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = false;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // numHargaJual
            // 
            numHargaJual.Location = new Point(10, 372);
            numHargaJual.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numHargaJual.Name = "numHargaJual";
            numHargaJual.Size = new Size(271, 31);
            numHargaJual.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Calibri Light", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(10, 350);
            label8.Name = "label8";
            label8.Size = new Size(78, 19);
            label8.TabIndex = 11;
            label8.Text = "Harga Jual";
            // 
            // numHargaBeli
            // 
            numHargaBeli.Location = new Point(10, 308);
            numHargaBeli.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numHargaBeli.Name = "numHargaBeli";
            numHargaBeli.Size = new Size(275, 31);
            numHargaBeli.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Calibri Light", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(10, 287);
            label7.Name = "label7";
            label7.Size = new Size(78, 19);
            label7.TabIndex = 9;
            label7.Text = "Harga Beli";
            // 
            // numStok
            // 
            numStok.Location = new Point(10, 245);
            numStok.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numStok.Name = "numStok";
            numStok.Size = new Size(275, 31);
            numStok.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri Light", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(10, 225);
            label6.Name = "label6";
            label6.Size = new Size(36, 19);
            label6.TabIndex = 7;
            label6.Text = "Stok";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri Light", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(9, 163);
            label5.Name = "label5";
            label5.Size = new Size(64, 19);
            label5.TabIndex = 5;
            label5.Text = "Kategori";
            // 
            // txtNamaBarang
            // 
            txtNamaBarang.Font = new Font("Calibri Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNamaBarang.Location = new Point(14, 125);
            txtNamaBarang.Name = "txtNamaBarang";
            txtNamaBarang.Size = new Size(271, 35);
            txtNamaBarang.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri Light", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(10, 105);
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
            txtKode.Size = new Size(275, 37);
            txtKode.TabIndex = 2;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Calibri Light", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(10, 45);
            label9.Name = "label9";
            label9.Size = new Size(41, 19);
            label9.TabIndex = 1;
            label9.Text = "Kode";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.MidnightBlue;
            label11.Location = new Point(10, 12);
            label11.Name = "label11";
            label11.Size = new Size(129, 28);
            label11.TabIndex = 0;
            label11.Text = "Ubah Barang";
            // 
            // panelDaftarBarang
            // 
            panelDaftarBarang.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelDaftarBarang.BackColor = Color.White;
            panelDaftarBarang.Controls.Add(dgvKelolaBarang);
            panelDaftarBarang.Controls.Add(btnMenipis);
            panelDaftarBarang.Controls.Add(txtCari);
            panelDaftarBarang.Controls.Add(btnHabis);
            panelDaftarBarang.Controls.Add(btnSemua);
            panelDaftarBarang.Controls.Add(btnAman);
            panelDaftarBarang.Location = new Point(33, 208);
            panelDaftarBarang.Name = "panelDaftarBarang";
            panelDaftarBarang.Size = new Size(1093, 588);
            panelDaftarBarang.TabIndex = 10;
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
            dgvKelolaBarang.Columns.AddRange(new DataGridViewColumn[] { colKode, colNama, colKategori, colHargaBeli, colHargaJual, colStok, colMinimum, colStatus, colAksi });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new Padding(6);
            dataGridViewCellStyle2.SelectionBackColor = Color.AliceBlue;
            dataGridViewCellStyle2.SelectionForeColor = Color.MidnightBlue;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvKelolaBarang.DefaultCellStyle = dataGridViewCellStyle2;
            dgvKelolaBarang.EnableHeadersVisualStyles = false;
            dgvKelolaBarang.Location = new Point(10, 95);
            dgvKelolaBarang.Margin = new Padding(4, 5, 4, 5);
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
            dgvKelolaBarang.Size = new Size(1064, 430);
            dgvKelolaBarang.TabIndex = 0;
            // 
            // roundedPanel5
            // 
            roundedPanel5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            roundedPanel5.BackColor = Color.Transparent;
            roundedPanel5.Controls.Add(panelTotal);
            roundedPanel5.Controls.Add(panelHabis);
            roundedPanel5.Controls.Add(panelMenipis);
            roundedPanel5.Controls.Add(panelAman);
            roundedPanel5.Location = new Point(3, 100);
            roundedPanel5.Name = "roundedPanel5";
            roundedPanel5.Size = new Size(1414, 102);
            roundedPanel5.TabIndex = 13;
            // 
            // panelTotal
            // 
            panelTotal.BackColor = Color.Transparent;
            panelTotal.Controls.Add(lblTotalBarang);
            panelTotal.Controls.Add(label10);
            panelTotal.ForeColor = Color.White;
            panelTotal.Location = new Point(17, 17);
            panelTotal.Name = "panelTotal";
            panelTotal.Size = new Size(254, 77);
            panelTotal.TabIndex = 9;
            // 
            // lblTotalBarang
            // 
            lblTotalBarang.AutoSize = true;
            lblTotalBarang.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalBarang.Location = new Point(19, 28);
            lblTotalBarang.Name = "lblTotalBarang";
            lblTotalBarang.Size = new Size(33, 38);
            lblTotalBarang.TabIndex = 1;
            lblTotalBarang.Text = "0";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Calibri Light", 9F, FontStyle.Bold);
            label10.Location = new Point(11, 8);
            label10.Name = "label10";
            label10.Size = new Size(109, 22);
            label10.TabIndex = 0;
            label10.Text = "Total Barang";
            // 
            // panelHabis
            // 
            panelHabis.BackColor = Color.Transparent;
            panelHabis.Controls.Add(lblStokHabis);
            panelHabis.Controls.Add(label16);
            panelHabis.ForeColor = Color.White;
            panelHabis.Location = new Point(927, 17);
            panelHabis.Name = "panelHabis";
            panelHabis.Size = new Size(254, 77);
            panelHabis.TabIndex = 15;
            // 
            // lblStokHabis
            // 
            lblStokHabis.AutoSize = true;
            lblStokHabis.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStokHabis.Location = new Point(16, 28);
            lblStokHabis.Name = "lblStokHabis";
            lblStokHabis.Size = new Size(33, 38);
            lblStokHabis.TabIndex = 14;
            lblStokHabis.Text = "0";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Calibri Light", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.Location = new Point(16, 8);
            label16.Name = "label16";
            label16.Size = new Size(94, 22);
            label16.TabIndex = 3;
            label16.Text = "Stok Habis";
            // 
            // panelMenipis
            // 
            panelMenipis.BackColor = Color.Transparent;
            panelMenipis.Controls.Add(lblStokMenipis);
            panelMenipis.Controls.Add(label14);
            panelMenipis.ForeColor = Color.White;
            panelMenipis.Location = new Point(624, 17);
            panelMenipis.Name = "panelMenipis";
            panelMenipis.Size = new Size(254, 77);
            panelMenipis.TabIndex = 14;
            // 
            // lblStokMenipis
            // 
            lblStokMenipis.AutoSize = true;
            lblStokMenipis.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStokMenipis.Location = new Point(14, 28);
            lblStokMenipis.Name = "lblStokMenipis";
            lblStokMenipis.Size = new Size(33, 38);
            lblStokMenipis.TabIndex = 13;
            lblStokMenipis.Text = "0";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Calibri Light", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(14, 8);
            label14.Name = "label14";
            label14.Size = new Size(114, 22);
            label14.TabIndex = 2;
            label14.Text = "Stok Menipis";
            // 
            // panelAman
            // 
            panelAman.BackColor = Color.Transparent;
            panelAman.Controls.Add(lblStokAman);
            panelAman.Controls.Add(label12);
            panelAman.ForeColor = Color.White;
            panelAman.Location = new Point(329, 17);
            panelAman.Name = "panelAman";
            panelAman.Size = new Size(254, 77);
            panelAman.TabIndex = 11;
            // 
            // lblStokAman
            // 
            lblStokAman.AutoSize = true;
            lblStokAman.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStokAman.Location = new Point(16, 28);
            lblStokAman.Name = "lblStokAman";
            lblStokAman.Size = new Size(33, 38);
            lblStokAman.TabIndex = 2;
            lblStokAman.Text = "0";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Calibri Light", 9F, FontStyle.Bold);
            label12.Location = new Point(16, 8);
            label12.Name = "label12";
            label12.Size = new Size(95, 22);
            label12.TabIndex = 1;
            label12.Text = "Stok Aman";
            // 
            // roundedPanel1
            // 
            roundedPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            roundedPanel1.BackColor = Color.Transparent;
            roundedPanel1.Controls.Add(panelDaftarBarang);
            roundedPanel1.Controls.Add(roundedPanel5);
            roundedPanel1.Controls.Add(roundedPanel2);
            roundedPanel1.Controls.Add(label2);
            roundedPanel1.Controls.Add(label1);
            roundedPanel1.Location = new Point(4, 5);
            roundedPanel1.Margin = new Padding(4, 5, 4, 5);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Size = new Size(1501, 890);
            roundedPanel1.TabIndex = 14;
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
            // colMinimum
            // 
            colMinimum.FillWeight = 80F;
            colMinimum.HeaderText = "Minimum";
            colMinimum.MinimumWidth = 8;
            colMinimum.Name = "colMinimum";
            colMinimum.ReadOnly = true;
            colMinimum.Width = 150;
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
            // UC_Barang
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(roundedPanel1);
            Name = "UC_Barang";
            Size = new Size(1506, 900);
            roundedPanel2.ResumeLayout(false);
            roundedPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numMinimum).EndInit();
            ((System.ComponentModel.ISupportInitialize)numHargaJual).EndInit();
            ((System.ComponentModel.ISupportInitialize)numHargaBeli).EndInit();
            ((System.ComponentModel.ISupportInitialize)numStok).EndInit();
            panelDaftarBarang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvKelolaBarang).EndInit();
            roundedPanel5.ResumeLayout(false);
            panelTotal.ResumeLayout(false);
            panelTotal.PerformLayout();
            panelHabis.ResumeLayout(false);
            panelHabis.PerformLayout();
            panelMenipis.ResumeLayout(false);
            panelMenipis.PerformLayout();
            panelAman.ResumeLayout(false);
            panelAman.PerformLayout();
            roundedPanel1.ResumeLayout(false);
            roundedPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private Label label2;
        private RoundedPanel panelDaftarBarang;
        private DataGridView dgvKelolaBarang;
        private RoundedButton btnHabis;
        private RoundedButton btnMenipis;
        private RoundedButton btnAman;
        private RoundedButton btnSemua;
        private RoundedTextBox txtCari;
        private RoundedPanel roundedPanel2;
        private RoundedButton btnHapus;
        private RoundedButton btnReset;
        private RoundedButton btnSimpan;
        private NumericUpDown numHargaJual;
        private Label label8;
        private NumericUpDown numHargaBeli;
        private Label label7;
        private NumericUpDown numStok;
        private Label label6;
        private Label label5;
        private RoundedTextBox txtNamaBarang;
        private Label label4;
        private RoundedTextBox txtKode;
        private Label label9;
        private Label label11;
        private RoundedPanel roundedPanel5;
        private RoundedPanel panelTotal;
        private Label lblTotalBarang;
        private Label label10;
        private RoundedPanel panelHabis;
        private Label lblStokHabis;
        private Label label16;
        private RoundedPanel panelMenipis;
        private Label lblStokMenipis;
        private Label label14;
        private RoundedPanel panelAman;
        private Label lblStokAman;
        private Label label12;
        private RoundedPanel roundedPanel1;
        private RoundedTextBox roundedTextBox1;
        private NumericUpDown numMinimum;
        private Label label3;
        private DataGridViewTextBoxColumn colKode;
        private DataGridViewTextBoxColumn colNama;
        private DataGridViewTextBoxColumn colKategori;
        private DataGridViewTextBoxColumn colHargaBeli;
        private DataGridViewTextBoxColumn colHargaJual;
        private DataGridViewTextBoxColumn colStok;
        private DataGridViewTextBoxColumn colMinimum;
        private DataGridViewTextBoxColumn colStatus;
        private DataGridViewTextBoxColumn colAksi;
    }
}
