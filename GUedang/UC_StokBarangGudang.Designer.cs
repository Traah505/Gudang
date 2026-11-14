namespace GUedang
{
    partial class UC_StokBarangGudang
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
            panel1 = new Panel();
            roundedPanel3 = new RoundedPanel();
            panel4 = new Panel();
            label11 = new Label();
            lblStokMinimum = new Label();
            label10 = new Label();
            btnSimpanPenyesuaian = new Rondedbuton();
            txtAlasan = new TextBox();
            label17 = new Label();
            txtSelisih = new RoundedTextBox();
            label16 = new Label();
            numJumlahFisik = new NumericUpDown();
            label15 = new Label();
            label13 = new Label();
            label12 = new Label();
            panel5 = new Panel();
            lblStatusStok = new Label();
            label14 = new Label();
            panel3 = new Panel();
            label9 = new Label();
            label8 = new Label();
            lblStokTersedia = new Label();
            label7 = new Label();
            label6 = new Label();
            panel2 = new Panel();
            label5 = new Label();
            roundedPanel2 = new RoundedPanel();
            dgvStok = new DataGridView();
            colNo = new DataGridViewTextBoxColumn();
            colKode = new DataGridViewTextBoxColumn();
            colNamaBarang = new DataGridViewTextBoxColumn();
            colStok = new DataGridViewTextBoxColumn();
            colMinimum = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            roundedPanel1 = new RoundedPanel();
            label4 = new Label();
            cmbStatusStok = new ComboBox();
            label3 = new Label();
            txtKategoriStok = new RoundedTextBox();
            label2 = new Label();
            txtCariStok = new RoundedTextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            roundedPanel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numJumlahFisik).BeginInit();
            panel5.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            roundedPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStok).BeginInit();
            roundedPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(roundedPanel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(roundedPanel2);
            panel1.Controls.Add(roundedPanel1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(697, 496);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // roundedPanel3
            // 
            roundedPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            roundedPanel3.BackColor = Color.Transparent;
            roundedPanel3.Controls.Add(panel4);
            roundedPanel3.Controls.Add(btnSimpanPenyesuaian);
            roundedPanel3.Controls.Add(txtAlasan);
            roundedPanel3.Controls.Add(label17);
            roundedPanel3.Controls.Add(txtSelisih);
            roundedPanel3.Controls.Add(label16);
            roundedPanel3.Controls.Add(numJumlahFisik);
            roundedPanel3.Controls.Add(label15);
            roundedPanel3.Controls.Add(label13);
            roundedPanel3.Controls.Add(label12);
            roundedPanel3.Controls.Add(panel5);
            roundedPanel3.Controls.Add(panel3);
            roundedPanel3.Controls.Add(label6);
            roundedPanel3.Location = new Point(484, 119);
            roundedPanel3.Margin = new Padding(2);
            roundedPanel3.Name = "roundedPanel3";
            roundedPanel3.Size = new Size(207, 366);
            roundedPanel3.TabIndex = 4;
            // 
            // panel4
            // 
            panel4.BackColor = Color.WhiteSmoke;
            panel4.Controls.Add(label11);
            panel4.Controls.Add(lblStokMinimum);
            panel4.Controls.Add(label10);
            panel4.Location = new Point(4, 110);
            panel4.Margin = new Padding(2);
            panel4.Name = "panel4";
            panel4.Size = new Size(102, 40);
            panel4.TabIndex = 9;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Black;
            label11.Location = new Point(18, 13);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(39, 19);
            label11.TabIndex = 15;
            label11.Text = "Item";
            // 
            // lblStokMinimum
            // 
            lblStokMinimum.AutoSize = true;
            lblStokMinimum.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStokMinimum.ForeColor = Color.Black;
            lblStokMinimum.Location = new Point(4, 13);
            lblStokMinimum.Margin = new Padding(2, 0, 2, 0);
            lblStokMinimum.Name = "lblStokMinimum";
            lblStokMinimum.Size = new Size(17, 19);
            lblStokMinimum.TabIndex = 14;
            lblStokMinimum.Text = "0";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(4, 0);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(81, 13);
            label10.TabIndex = 13;
            label10.Text = "Stok Minimum\r\n";
            // 
            // btnSimpanPenyesuaian
            // 
            btnSimpanPenyesuaian.BackColor = Color.RoyalBlue;
            btnSimpanPenyesuaian.FlatAppearance.BorderSize = 0;
            btnSimpanPenyesuaian.FlatStyle = FlatStyle.Flat;
            btnSimpanPenyesuaian.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSimpanPenyesuaian.ForeColor = Color.White;
            btnSimpanPenyesuaian.Location = new Point(11, 314);
            btnSimpanPenyesuaian.Margin = new Padding(2);
            btnSimpanPenyesuaian.Name = "btnSimpanPenyesuaian";
            btnSimpanPenyesuaian.Size = new Size(171, 30);
            btnSimpanPenyesuaian.TabIndex = 21;
            btnSimpanPenyesuaian.Text = "Simpan Penyesuaian";
            btnSimpanPenyesuaian.UseVisualStyleBackColor = false;
            // 
            // txtAlasan
            // 
            txtAlasan.Location = new Point(2, 287);
            txtAlasan.Margin = new Padding(2);
            txtAlasan.Name = "txtAlasan";
            txtAlasan.PlaceholderText = "Masukan Alasan";
            txtAlasan.Size = new Size(181, 23);
            txtAlasan.TabIndex = 20;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label17.ForeColor = Color.Black;
            label17.Location = new Point(2, 272);
            label17.Margin = new Padding(2, 0, 2, 0);
            label17.Name = "label17";
            label17.Size = new Size(108, 13);
            label17.TabIndex = 19;
            label17.Text = "Alasan Penyesuaian";
            // 
            // txtSelisih
            // 
            txtSelisih.Location = new Point(2, 248);
            txtSelisih.Margin = new Padding(2);
            txtSelisih.Name = "txtSelisih";
            txtSelisih.ReadOnly = true;
            txtSelisih.Size = new Size(180, 22);
            txtSelisih.TabIndex = 6;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label16.ForeColor = Color.Black;
            label16.Location = new Point(2, 233);
            label16.Margin = new Padding(2, 0, 2, 0);
            label16.Name = "label16";
            label16.Size = new Size(66, 13);
            label16.TabIndex = 18;
            label16.Text = "Selisih Stok";
            // 
            // numJumlahFisik
            // 
            numJumlahFisik.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            numJumlahFisik.Location = new Point(4, 205);
            numJumlahFisik.Margin = new Padding(2);
            numJumlahFisik.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numJumlahFisik.Name = "numJumlahFisik";
            numJumlahFisik.Size = new Size(178, 25);
            numJumlahFisik.TabIndex = 17;
            numJumlahFisik.TextAlign = HorizontalAlignment.Center;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.Black;
            label15.Location = new Point(4, 188);
            label15.Margin = new Padding(2, 0, 2, 0);
            label15.Name = "label15";
            label15.Size = new Size(69, 13);
            label15.TabIndex = 16;
            label15.Text = "Jumlah Fisik";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.Black;
            label13.Location = new Point(2, 163);
            label13.Margin = new Padding(2, 0, 2, 0);
            label13.Name = "label13";
            label13.Size = new Size(126, 19);
            label13.TabIndex = 13;
            label13.Text = "Penyesuaian Stok";
            // 
            // label12
            // 
            label12.BorderStyle = BorderStyle.Fixed3D;
            label12.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.Black;
            label12.Location = new Point(0, 152);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(205, 19);
            label12.TabIndex = 16;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Honeydew;
            panel5.Controls.Add(lblStatusStok);
            panel5.Controls.Add(label14);
            panel5.Location = new Point(112, 110);
            panel5.Margin = new Padding(2);
            panel5.Name = "panel5";
            panel5.Size = new Size(93, 40);
            panel5.TabIndex = 16;
            // 
            // lblStatusStok
            // 
            lblStatusStok.AutoSize = true;
            lblStatusStok.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStatusStok.ForeColor = Color.Black;
            lblStatusStok.Location = new Point(4, 13);
            lblStatusStok.Margin = new Padding(2, 0, 2, 0);
            lblStatusStok.Name = "lblStatusStok";
            lblStatusStok.Size = new Size(48, 19);
            lblStatusStok.TabIndex = 14;
            lblStatusStok.Text = "Aman";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.Black;
            label14.Location = new Point(4, 0);
            label14.Margin = new Padding(2, 0, 2, 0);
            label14.Name = "label14";
            label14.Size = new Size(39, 13);
            label14.TabIndex = 13;
            label14.Text = "Status";
            // 
            // panel3
            // 
            panel3.BackColor = Color.AliceBlue;
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(lblStokTersedia);
            panel3.Controls.Add(label7);
            panel3.Location = new Point(8, 26);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(192, 75);
            panel3.TabIndex = 8;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.RoyalBlue;
            label9.Location = new Point(2, 52);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(128, 19);
            label9.TabIndex = 12;
            label9.Text = "Pilih Barang Ditabel";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.RoyalBlue;
            label8.Location = new Point(29, 22);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(52, 25);
            label8.TabIndex = 11;
            label8.Text = "Item";
            // 
            // lblStokTersedia
            // 
            lblStokTersedia.AutoSize = true;
            lblStokTersedia.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStokTersedia.ForeColor = Color.RoyalBlue;
            lblStokTersedia.Location = new Point(9, 22);
            lblStokTersedia.Margin = new Padding(2, 0, 2, 0);
            lblStokTersedia.Name = "lblStokTersedia";
            lblStokTersedia.Size = new Size(23, 25);
            lblStokTersedia.TabIndex = 10;
            lblStokTersedia.Text = "0";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.RoyalBlue;
            label7.Location = new Point(0, 5);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(89, 19);
            label7.TabIndex = 9;
            label7.Text = "Stok Tersedia";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.RoyalBlue;
            label6.Location = new Point(15, 4);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(127, 20);
            label6.TabIndex = 7;
            label6.Text = "Detail Persediaan";
            // 
            // panel2
            // 
            panel2.BackColor = Color.RoyalBlue;
            panel2.Controls.Add(label5);
            panel2.Location = new Point(20, 118);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(460, 20);
            panel2.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(11, 1);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(71, 15);
            label5.TabIndex = 6;
            label5.Text = "Stok Barang";
            // 
            // roundedPanel2
            // 
            roundedPanel2.BackColor = Color.Transparent;
            roundedPanel2.Controls.Add(dgvStok);
            roundedPanel2.Location = new Point(20, 118);
            roundedPanel2.Margin = new Padding(2);
            roundedPanel2.Name = "roundedPanel2";
            roundedPanel2.Size = new Size(460, 231);
            roundedPanel2.TabIndex = 2;
            // 
            // dgvStok
            // 
            dgvStok.AllowUserToAddRows = false;
            dgvStok.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.AliceBlue;
            dgvStok.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvStok.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvStok.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStok.BackgroundColor = Color.White;
            dgvStok.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.RoyalBlue;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.RoyalBlue;
            dataGridViewCellStyle2.SelectionForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvStok.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvStok.ColumnHeadersHeight = 40;
            dgvStok.Columns.AddRange(new DataGridViewColumn[] { colNo, colKode, colNamaBarang, colStok, colMinimum, colStatus });
            dgvStok.EnableHeadersVisualStyles = false;
            dgvStok.Location = new Point(0, 24);
            dgvStok.Margin = new Padding(2);
            dgvStok.Name = "dgvStok";
            dgvStok.RowHeadersVisible = false;
            dgvStok.RowHeadersWidth = 62;
            dgvStok.RowTemplate.Height = 38;
            dgvStok.SelectionMode = DataGridViewSelectionMode.FullColumnSelect;
            dgvStok.Size = new Size(460, 343);
            dgvStok.TabIndex = 0;
            // 
            // colNo
            // 
            colNo.HeaderText = "No";
            colNo.MinimumWidth = 8;
            colNo.Name = "colNo";
            colNo.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colKode
            // 
            colKode.HeaderText = "Kode";
            colKode.MinimumWidth = 8;
            colKode.Name = "colKode";
            colKode.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colNamaBarang
            // 
            colNamaBarang.HeaderText = "Nama Barang";
            colNamaBarang.MinimumWidth = 8;
            colNamaBarang.Name = "colNamaBarang";
            colNamaBarang.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colStok
            // 
            colStok.HeaderText = "Stok";
            colStok.MinimumWidth = 8;
            colStok.Name = "colStok";
            colStok.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colMinimum
            // 
            colMinimum.HeaderText = "Minimum";
            colMinimum.MinimumWidth = 8;
            colMinimum.Name = "colMinimum";
            colMinimum.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colStatus
            // 
            colStatus.HeaderText = "Status";
            colStatus.MinimumWidth = 8;
            colStatus.Name = "colStatus";
            colStatus.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // roundedPanel1
            // 
            roundedPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            roundedPanel1.BackColor = Color.Transparent;
            roundedPanel1.Controls.Add(label4);
            roundedPanel1.Controls.Add(cmbStatusStok);
            roundedPanel1.Controls.Add(label3);
            roundedPanel1.Controls.Add(txtKategoriStok);
            roundedPanel1.Controls.Add(label2);
            roundedPanel1.Controls.Add(txtCariStok);
            roundedPanel1.Location = new Point(20, 47);
            roundedPanel1.Margin = new Padding(2);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Size = new Size(656, 53);
            roundedPanel1.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(525, 5);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 5;
            label4.Text = "Status\r\n";
            // 
            // cmbStatusStok
            // 
            cmbStatusStok.FormattingEnabled = true;
            cmbStatusStok.Items.AddRange(new object[] { "Semua", "Aman", "Menipis", "Habis" });
            cmbStatusStok.Location = new Point(525, 22);
            cmbStatusStok.Margin = new Padding(2);
            cmbStatusStok.Name = "cmbStatusStok";
            cmbStatusStok.Size = new Size(114, 23);
            cmbStatusStok.TabIndex = 4;
            // 
            // label3
            // 
            label3.Location = new Point(249, 5);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(67, 18);
            label3.TabIndex = 3;
            label3.Text = "Kategori\r\n\r\n";
            // 
            // txtKategoriStok
            // 
            txtKategoriStok.Location = new Point(249, 24);
            txtKategoriStok.Margin = new Padding(2);
            txtKategoriStok.Name = "txtKategoriStok";
            txtKategoriStok.Size = new Size(104, 22);
            txtKategoriStok.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 5);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(186, 15);
            label2.TabIndex = 1;
            label2.Text = "Masukan Kode atau Nama Barang";
            // 
            // txtCariStok
            // 
            txtCariStok.Location = new Point(11, 24);
            txtCariStok.Margin = new Padding(2);
            txtCariStok.Name = "txtCariStok";
            txtCariStok.Size = new Size(210, 22);
            txtCariStok.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(20, 9);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(114, 25);
            label1.TabIndex = 0;
            label1.Text = "Stok Barang";
            // 
            // UC_StokBarangGudang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Margin = new Padding(2);
            Name = "UC_StokBarangGudang";
            Size = new Size(699, 498);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            roundedPanel3.ResumeLayout(false);
            roundedPanel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numJumlahFisik).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            roundedPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvStok).EndInit();
            roundedPanel1.ResumeLayout(false);
            roundedPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private RoundedPanel roundedPanel1;
        private Label label3;
        private RoundedTextBox txtKategoriStok;
        private Label label2;
        private RoundedTextBox txtCariStok;
        private Label label4;
        private ComboBox cmbStatusStok;
        private RoundedPanel roundedPanel2;
        private DataGridView dgvStok;
        private Panel panel2;
        private RoundedPanel roundedPanel3;
        private Label label5;
        private Panel panel3;
        private Label label6;
        private DataGridViewTextBoxColumn colNo;
        private DataGridViewTextBoxColumn colKode;
        private DataGridViewTextBoxColumn colNamaBarang;
        private DataGridViewTextBoxColumn colStok;
        private DataGridViewTextBoxColumn colMinimum;
        private DataGridViewTextBoxColumn colStatus;
        private Label label9;
        private Label label8;
        private Label lblStokTersedia;
        private Label label7;
        private Panel panel4;
        private Label label11;
        private Label lblStokMinimum;
        private Label label10;
        private Panel panel5;
        private Label lblStatusStok;
        private Label label14;
        private RoundedTextBox txtSelisih;
        private Label label16;
        private NumericUpDown numJumlahFisik;
        private Label label15;
        private Label label13;
        private Label label12;
        private Rondedbuton btnSimpanPenyesuaian;
        private TextBox txtAlasan;
        private Label label17;
    }
}
