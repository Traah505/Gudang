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
            txtKategori = new RoundedTextBox();
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
            label1.Location = new Point(31, 8);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(114, 25);
            label1.TabIndex = 0;
            label1.Text = "Stok Barang";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.MidnightBlue;
            label2.Location = new Point(31, 33);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(109, 15);
            label2.TabIndex = 1;
            label2.Text = "Pantau stok barang";
            // 
            // txtCari
            // 
            txtCari.Font = new Font("Calibri Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCari.ForeColor = Color.MidnightBlue;
            txtCari.Location = new Point(30, 17);
            txtCari.Margin = new Padding(2);
            txtCari.Name = "txtCari";
            txtCari.Size = new Size(370, 28);
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
            btnSemua.Location = new Point(466, 12);
            btnSemua.Margin = new Padding(2);
            btnSemua.Name = "btnSemua";
            btnSemua.Size = new Size(68, 30);
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
            btnAman.Location = new Point(538, 12);
            btnAman.Margin = new Padding(2);
            btnAman.Name = "btnAman";
            btnAman.Size = new Size(65, 30);
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
            btnMenipis.Location = new Point(607, 12);
            btnMenipis.Margin = new Padding(2);
            btnMenipis.Name = "btnMenipis";
            btnMenipis.Size = new Size(75, 30);
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
            btnHabis.Location = new Point(685, 12);
            btnHabis.Margin = new Padding(2);
            btnHabis.Name = "btnHabis";
            btnHabis.Size = new Size(66, 30);
            btnHabis.TabIndex = 8;
            btnHabis.Text = "Habis";
            btnHabis.UseVisualStyleBackColor = false;
            // 
            // roundedPanel2
            // 
            roundedPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            roundedPanel2.BackColor = Color.White;
            roundedPanel2.Controls.Add(numMinimum);
            roundedPanel2.Controls.Add(label3);
            roundedPanel2.Controls.Add(txtKategori);
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
            roundedPanel2.Location = new Point(946, 142);
            roundedPanel2.Margin = new Padding(2);
            roundedPanel2.Name = "roundedPanel2";
            roundedPanel2.Size = new Size(247, 335);
            roundedPanel2.TabIndex = 9;
            // 
            // numMinimum
            // 
            numMinimum.Location = new Point(6, 257);
            numMinimum.Margin = new Padding(2);
            numMinimum.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numMinimum.Name = "numMinimum";
            numMinimum.Size = new Size(192, 23);
            numMinimum.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri Light", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(10, 244);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(50, 13);
            label3.TabIndex = 17;
            label3.Text = "Minimum";
            // 
            // txtKategori
            // 
            txtKategori.Font = new Font("Calibri Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtKategori.Location = new Point(10, 109);
            txtKategori.Margin = new Padding(2);
            txtKategori.Name = "txtKategori";
            txtKategori.Size = new Size(190, 24);
            txtKategori.TabIndex = 16;
            // 
            // btnHapus
            // 
            btnHapus.BackColor = Color.IndianRed;
            btnHapus.FlatAppearance.BorderSize = 0;
            btnHapus.FlatStyle = FlatStyle.Flat;
            btnHapus.ForeColor = Color.White;
            btnHapus.Location = new Point(130, 287);
            btnHapus.Margin = new Padding(2);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(56, 21);
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
            btnReset.Location = new Point(70, 287);
            btnReset.Margin = new Padding(2);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(56, 21);
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
            btnSimpan.Location = new Point(10, 287);
            btnSimpan.Margin = new Padding(2);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(56, 21);
            btnSimpan.TabIndex = 13;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = false;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // numHargaJual
            // 
            numHargaJual.Location = new Point(7, 223);
            numHargaJual.Margin = new Padding(2);
            numHargaJual.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numHargaJual.Name = "numHargaJual";
            numHargaJual.Size = new Size(190, 23);
            numHargaJual.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Calibri Light", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(7, 210);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(51, 13);
            label8.TabIndex = 11;
            label8.Text = "Harga Jual";
            // 
            // numHargaBeli
            // 
            numHargaBeli.Location = new Point(7, 185);
            numHargaBeli.Margin = new Padding(2);
            numHargaBeli.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numHargaBeli.Name = "numHargaBeli";
            numHargaBeli.Size = new Size(192, 23);
            numHargaBeli.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Calibri Light", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(7, 172);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(50, 13);
            label7.TabIndex = 9;
            label7.Text = "Harga Beli";
            // 
            // numStok
            // 
            numStok.Location = new Point(7, 147);
            numStok.Margin = new Padding(2);
            numStok.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numStok.Name = "numStok";
            numStok.Size = new Size(192, 23);
            numStok.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri Light", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(7, 135);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(27, 13);
            label6.TabIndex = 7;
            label6.Text = "Stok";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri Light", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(6, 98);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(44, 13);
            label5.TabIndex = 5;
            label5.Text = "Kategori";
            // 
            // txtNamaBarang
            // 
            txtNamaBarang.Font = new Font("Calibri Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNamaBarang.Location = new Point(10, 75);
            txtNamaBarang.Margin = new Padding(2);
            txtNamaBarang.Name = "txtNamaBarang";
            txtNamaBarang.Size = new Size(190, 21);
            txtNamaBarang.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri Light", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(7, 63);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(66, 13);
            label4.TabIndex = 3;
            label4.Text = "Nama Barang";
            // 
            // txtKode
            // 
            txtKode.BackColor = Color.Gainsboro;
            txtKode.Location = new Point(7, 39);
            txtKode.Margin = new Padding(2);
            txtKode.Name = "txtKode";
            txtKode.Size = new Size(192, 22);
            txtKode.TabIndex = 2;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Calibri Light", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(7, 27);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(30, 13);
            label9.TabIndex = 1;
            label9.Text = "Kode";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.MidnightBlue;
            label11.Location = new Point(7, 7);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(89, 19);
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
            panelDaftarBarang.Location = new Point(23, 125);
            panelDaftarBarang.Margin = new Padding(2);
            panelDaftarBarang.Name = "panelDaftarBarang";
            panelDaftarBarang.Size = new Size(906, 353);
            panelDaftarBarang.TabIndex = 10;
            panelDaftarBarang.Paint += panelDaftarBarang_Paint;
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
            dgvKelolaBarang.Columns.AddRange(new DataGridViewColumn[] { colKode, colNama, colKategori, colHargaBeli, colHargaJual, colStok, colMinimum, colStatus });
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
            dgvKelolaBarang.Location = new Point(7, 57);
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
            dgvKelolaBarang.Size = new Size(888, 258);
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
            roundedPanel5.Location = new Point(2, 60);
            roundedPanel5.Margin = new Padding(2);
            roundedPanel5.Name = "roundedPanel5";
            roundedPanel5.Size = new Size(1334, 61);
            roundedPanel5.TabIndex = 13;
            roundedPanel5.Paint += roundedPanel5_Paint;
            // 
            // panelTotal
            // 
            panelTotal.BackColor = Color.RoyalBlue;
            panelTotal.Controls.Add(lblTotalBarang);
            panelTotal.Controls.Add(label10);
            panelTotal.ForeColor = Color.White;
            panelTotal.Location = new Point(97, 9);
            panelTotal.Margin = new Padding(2);
            panelTotal.Name = "panelTotal";
            panelTotal.Size = new Size(178, 46);
            panelTotal.TabIndex = 9;
            panelTotal.Paint += panelTotal_Paint;
            // 
            // lblTotalBarang
            // 
            lblTotalBarang.AutoSize = true;
            lblTotalBarang.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalBarang.Location = new Point(13, 17);
            lblTotalBarang.Margin = new Padding(2, 0, 2, 0);
            lblTotalBarang.Name = "lblTotalBarang";
            lblTotalBarang.Size = new Size(23, 25);
            lblTotalBarang.TabIndex = 1;
            lblTotalBarang.Text = "0";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Calibri Light", 9F, FontStyle.Bold);
            label10.Location = new Point(8, 5);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(80, 14);
            label10.TabIndex = 0;
            label10.Text = "Total Barang";
            // 
            // panelHabis
            // 
            panelHabis.BackColor = Color.Transparent;
            panelHabis.Controls.Add(lblStokHabis);
            panelHabis.Controls.Add(label16);
            panelHabis.ForeColor = Color.White;
            panelHabis.Location = new Point(738, 9);
            panelHabis.Margin = new Padding(2);
            panelHabis.Name = "panelHabis";
            panelHabis.Size = new Size(178, 46);
            panelHabis.TabIndex = 15;
            // 
            // lblStokHabis
            // 
            lblStokHabis.AutoSize = true;
            lblStokHabis.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStokHabis.Location = new Point(11, 17);
            lblStokHabis.Margin = new Padding(2, 0, 2, 0);
            lblStokHabis.Name = "lblStokHabis";
            lblStokHabis.Size = new Size(23, 25);
            lblStokHabis.TabIndex = 14;
            lblStokHabis.Text = "0";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Calibri Light", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.Location = new Point(11, 5);
            label16.Margin = new Padding(2, 0, 2, 0);
            label16.Name = "label16";
            label16.Size = new Size(67, 14);
            label16.TabIndex = 3;
            label16.Text = "Stok Habis";
            // 
            // panelMenipis
            // 
            panelMenipis.BackColor = Color.Transparent;
            panelMenipis.Controls.Add(lblStokMenipis);
            panelMenipis.Controls.Add(label14);
            panelMenipis.ForeColor = Color.White;
            panelMenipis.Location = new Point(526, 9);
            panelMenipis.Margin = new Padding(2);
            panelMenipis.Name = "panelMenipis";
            panelMenipis.Size = new Size(178, 46);
            panelMenipis.TabIndex = 14;
            // 
            // lblStokMenipis
            // 
            lblStokMenipis.AutoSize = true;
            lblStokMenipis.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStokMenipis.Location = new Point(10, 17);
            lblStokMenipis.Margin = new Padding(2, 0, 2, 0);
            lblStokMenipis.Name = "lblStokMenipis";
            lblStokMenipis.Size = new Size(23, 25);
            lblStokMenipis.TabIndex = 13;
            lblStokMenipis.Text = "0";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Calibri Light", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(10, 5);
            label14.Margin = new Padding(2, 0, 2, 0);
            label14.Name = "label14";
            label14.Size = new Size(81, 14);
            label14.TabIndex = 2;
            label14.Text = "Stok Menipis";
            // 
            // panelAman
            // 
            panelAman.BackColor = Color.Transparent;
            panelAman.Controls.Add(lblStokAman);
            panelAman.Controls.Add(label12);
            panelAman.ForeColor = Color.White;
            panelAman.Location = new Point(317, 9);
            panelAman.Margin = new Padding(2);
            panelAman.Name = "panelAman";
            panelAman.Size = new Size(178, 46);
            panelAman.TabIndex = 11;
            panelAman.Paint += panelAman_Paint;
            // 
            // lblStokAman
            // 
            lblStokAman.AutoSize = true;
            lblStokAman.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStokAman.Location = new Point(11, 17);
            lblStokAman.Margin = new Padding(2, 0, 2, 0);
            lblStokAman.Name = "lblStokAman";
            lblStokAman.Size = new Size(23, 25);
            lblStokAman.TabIndex = 2;
            lblStokAman.Text = "0";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Calibri Light", 9F, FontStyle.Bold);
            label12.Location = new Point(11, 5);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(68, 14);
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
            roundedPanel1.Location = new Point(3, 3);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Size = new Size(1398, 534);
            roundedPanel1.TabIndex = 14;
            roundedPanel1.Paint += roundedPanel1_Paint;
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
            // UC_Barang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(roundedPanel1);
            Margin = new Padding(2);
            Name = "UC_Barang";
            Size = new Size(1208, 540);
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
        private RoundedTextBox txtKategori;
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
    }
}
