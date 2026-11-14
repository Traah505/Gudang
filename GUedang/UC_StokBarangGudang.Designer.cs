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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            panel1 = new Panel();
            roundedPanel3 = new RoundedPanel();
            panel3 = new Panel();
            label6 = new Label();
            panel2 = new Panel();
            label5 = new Label();
            roundedPanel2 = new RoundedPanel();
            dataGridView1 = new DataGridView();
            colNo = new DataGridViewTextBoxColumn();
            colKode = new DataGridViewTextBoxColumn();
            colNamaBarang = new DataGridViewTextBoxColumn();
            colStok = new DataGridViewTextBoxColumn();
            colMinimum = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            roundedPanel1 = new RoundedPanel();
            label4 = new Label();
            cmbStatus = new ComboBox();
            label3 = new Label();
            txtKategori = new RoundedTextBox();
            label2 = new Label();
            txtKodeAtauNama = new RoundedTextBox();
            label1 = new Label();
            label7 = new Label();
            lblJumlahStok = new Label();
            label8 = new Label();
            label9 = new Label();
            panel4 = new Panel();
            label10 = new Label();
            lblStokMinimum = new Label();
            label11 = new Label();
            panel5 = new Panel();
            lblStatus = new Label();
            label14 = new Label();
            label12 = new Label();
            label13 = new Label();
            label15 = new Label();
            numJumlahFisik = new NumericUpDown();
            label16 = new Label();
            txtSelisih = new RoundedTextBox();
            label17 = new Label();
            txtAlasan = new TextBox();
            rondedbuton1 = new Rondedbuton();
            panel1.SuspendLayout();
            roundedPanel3.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            roundedPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            roundedPanel1.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numJumlahFisik).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(roundedPanel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(roundedPanel2);
            panel1.Controls.Add(roundedPanel1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(999, 824);
            panel1.TabIndex = 0;
            // 
            // roundedPanel3
            // 
            roundedPanel3.BackColor = Color.Transparent;
            roundedPanel3.Controls.Add(rondedbuton1);
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
            roundedPanel3.Location = new Point(705, 199);
            roundedPanel3.Name = "roundedPanel3";
            roundedPanel3.Size = new Size(281, 610);
            roundedPanel3.TabIndex = 4;
            // 
            // panel3
            // 
            panel3.BackColor = Color.AliceBlue;
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(lblJumlahStok);
            panel3.Controls.Add(label7);
            panel3.Location = new Point(3, 40);
            panel3.Name = "panel3";
            panel3.Size = new Size(275, 125);
            panel3.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.RoyalBlue;
            label6.Location = new Point(22, 7);
            label6.Name = "label6";
            label6.Size = new Size(185, 30);
            label6.TabIndex = 7;
            label6.Text = "Detail Persediaan";
            // 
            // panel2
            // 
            panel2.BackColor = Color.RoyalBlue;
            panel2.Controls.Add(label5);
            panel2.Location = new Point(28, 197);
            panel2.Name = "panel2";
            panel2.Size = new Size(657, 34);
            panel2.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(16, 2);
            label5.Name = "label5";
            label5.Size = new Size(111, 25);
            label5.TabIndex = 6;
            label5.Text = "Stok Barang";
            // 
            // roundedPanel2
            // 
            roundedPanel2.BackColor = Color.Transparent;
            roundedPanel2.Controls.Add(dataGridView1);
            roundedPanel2.Location = new Point(28, 197);
            roundedPanel2.Name = "roundedPanel2";
            roundedPanel2.Size = new Size(657, 385);
            roundedPanel2.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = Color.AliceBlue;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = Color.RoyalBlue;
            dataGridViewCellStyle6.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.SelectionBackColor = Color.RoyalBlue;
            dataGridViewCellStyle6.SelectionForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dataGridView1.ColumnHeadersHeight = 40;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colNo, colKode, colNamaBarang, colStok, colMinimum, colStatus });
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(0, 30);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 38;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullColumnSelect;
            dataGridView1.Size = new Size(657, 582);
            dataGridView1.TabIndex = 0;
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
            roundedPanel1.BackColor = Color.Transparent;
            roundedPanel1.Controls.Add(label4);
            roundedPanel1.Controls.Add(cmbStatus);
            roundedPanel1.Controls.Add(label3);
            roundedPanel1.Controls.Add(txtKategori);
            roundedPanel1.Controls.Add(label2);
            roundedPanel1.Controls.Add(txtKodeAtauNama);
            roundedPanel1.Location = new Point(28, 79);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Size = new Size(937, 88);
            roundedPanel1.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(750, 8);
            label4.Name = "label4";
            label4.Size = new Size(60, 25);
            label4.TabIndex = 5;
            label4.Text = "Status\r\n";
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "Semua", "Aman", "Menipis", "Habis" });
            cmbStatus.Location = new Point(750, 37);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(161, 33);
            cmbStatus.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(356, 8);
            label3.Name = "label3";
            label3.Size = new Size(78, 50);
            label3.TabIndex = 3;
            label3.Text = "Kategori\r\n\r\n";
            // 
            // txtKategori
            // 
            txtKategori.Location = new Point(356, 40);
            txtKategori.Name = "txtKategori";
            txtKategori.Size = new Size(149, 30);
            txtKategori.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 8);
            label2.Name = "label2";
            label2.Size = new Size(280, 25);
            label2.TabIndex = 1;
            label2.Text = "Masukan Kode atau Nama Barang";
            // 
            // txtKodeAtauNama
            // 
            txtKodeAtauNama.Location = new Point(16, 40);
            txtKodeAtauNama.Name = "txtKodeAtauNama";
            txtKodeAtauNama.Size = new Size(300, 30);
            txtKodeAtauNama.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(28, 15);
            label1.Name = "label1";
            label1.Size = new Size(171, 38);
            label1.TabIndex = 0;
            label1.Text = "Stok Barang";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.RoyalBlue;
            label7.Location = new Point(0, 9);
            label7.Name = "label7";
            label7.Size = new Size(126, 28);
            label7.TabIndex = 9;
            label7.Text = "Stok Tersedia";
            // 
            // lblJumlahStok
            // 
            lblJumlahStok.AutoSize = true;
            lblJumlahStok.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblJumlahStok.ForeColor = Color.RoyalBlue;
            lblJumlahStok.Location = new Point(13, 37);
            lblJumlahStok.Name = "lblJumlahStok";
            lblJumlahStok.Size = new Size(33, 38);
            lblJumlahStok.TabIndex = 10;
            lblJumlahStok.Text = "0";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.RoyalBlue;
            label8.Location = new Point(41, 37);
            label8.Name = "label8";
            label8.Size = new Size(78, 38);
            label8.TabIndex = 11;
            label8.Text = "Item";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.RoyalBlue;
            label9.Location = new Point(3, 86);
            label9.Name = "label9";
            label9.Size = new Size(183, 28);
            label9.TabIndex = 12;
            label9.Text = "Pilih Barang Ditabel";
            // 
            // panel4
            // 
            panel4.BackColor = Color.WhiteSmoke;
            panel4.Controls.Add(label11);
            panel4.Controls.Add(lblStokMinimum);
            panel4.Controls.Add(label10);
            panel4.Location = new Point(705, 370);
            panel4.Name = "panel4";
            panel4.Size = new Size(133, 66);
            panel4.TabIndex = 9;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(6, 0);
            label10.Name = "label10";
            label10.Size = new Size(112, 21);
            label10.TabIndex = 13;
            label10.Text = "Stok Minimum\r\n";
            // 
            // lblStokMinimum
            // 
            lblStokMinimum.AutoSize = true;
            lblStokMinimum.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStokMinimum.ForeColor = Color.Black;
            lblStokMinimum.Location = new Point(6, 21);
            lblStokMinimum.Name = "lblStokMinimum";
            lblStokMinimum.Size = new Size(24, 28);
            lblStokMinimum.TabIndex = 14;
            lblStokMinimum.Text = "0";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Black;
            label11.Location = new Point(25, 21);
            label11.Name = "label11";
            label11.Size = new Size(55, 28);
            label11.TabIndex = 15;
            label11.Text = "Item";
            // 
            // panel5
            // 
            panel5.BackColor = Color.Honeydew;
            panel5.Controls.Add(lblStatus);
            panel5.Controls.Add(label14);
            panel5.Location = new Point(145, 171);
            panel5.Name = "panel5";
            panel5.Size = new Size(133, 66);
            panel5.TabIndex = 16;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStatus.ForeColor = Color.Black;
            lblStatus.Location = new Point(6, 21);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(67, 28);
            lblStatus.TabIndex = 14;
            lblStatus.Text = "Aman";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.Black;
            label14.Location = new Point(6, 0);
            label14.Name = "label14";
            label14.Size = new Size(52, 21);
            label14.TabIndex = 13;
            label14.Text = "Status";
            // 
            // label12
            // 
            label12.BorderStyle = BorderStyle.Fixed3D;
            label12.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.Black;
            label12.Location = new Point(0, 254);
            label12.Name = "label12";
            label12.Size = new Size(278, 31);
            label12.TabIndex = 16;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.Black;
            label13.Location = new Point(3, 271);
            label13.Name = "label13";
            label13.Size = new Size(177, 28);
            label13.TabIndex = 13;
            label13.Text = "Penyesuaian Stok";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.Black;
            label15.Location = new Point(6, 313);
            label15.Name = "label15";
            label15.Size = new Size(95, 21);
            label15.TabIndex = 16;
            label15.Text = "Jumlah Fisik";
            // 
            // numJumlahFisik
            // 
            numJumlahFisik.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            numJumlahFisik.Location = new Point(6, 333);
            numJumlahFisik.Name = "numJumlahFisik";
            numJumlahFisik.Size = new Size(254, 34);
            numJumlahFisik.TabIndex = 17;
            numJumlahFisik.TextAlign = HorizontalAlignment.Center;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label16.ForeColor = Color.Black;
            label16.Location = new Point(6, 370);
            label16.Name = "label16";
            label16.Size = new Size(89, 21);
            label16.TabIndex = 18;
            label16.Text = "Selisih Stok";
            // 
            // txtSelisih
            // 
            txtSelisih.Location = new Point(3, 394);
            txtSelisih.Name = "txtSelisih";
            txtSelisih.ReadOnly = true;
            txtSelisih.Size = new Size(257, 30);
            txtSelisih.TabIndex = 6;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label17.ForeColor = Color.Black;
            label17.Location = new Point(3, 427);
            label17.Name = "label17";
            label17.Size = new Size(146, 21);
            label17.TabIndex = 19;
            label17.Text = "Alasan Penyesuaian";
            // 
            // txtAlasan
            // 
            txtAlasan.Location = new Point(3, 451);
            txtAlasan.Name = "txtAlasan";
            txtAlasan.PlaceholderText = "Masukan Alasan";
            txtAlasan.Size = new Size(257, 31);
            txtAlasan.TabIndex = 20;
            // 
            // rondedbuton1
            // 
            rondedbuton1.BackColor = Color.RoyalBlue;
            rondedbuton1.FlatAppearance.BorderSize = 0;
            rondedbuton1.FlatStyle = FlatStyle.Flat;
            rondedbuton1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rondedbuton1.ForeColor = Color.White;
            rondedbuton1.Location = new Point(16, 523);
            rondedbuton1.Name = "rondedbuton1";
            rondedbuton1.Size = new Size(244, 50);
            rondedbuton1.TabIndex = 21;
            rondedbuton1.Text = "Simpan Penyesuaian";
            rondedbuton1.UseVisualStyleBackColor = false;
            // 
            // UC_StokBarangGudang
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "UC_StokBarangGudang";
            Size = new Size(999, 830);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            roundedPanel3.ResumeLayout(false);
            roundedPanel3.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            roundedPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            roundedPanel1.ResumeLayout(false);
            roundedPanel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numJumlahFisik).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private RoundedPanel roundedPanel1;
        private Label label3;
        private RoundedTextBox txtKategori;
        private Label label2;
        private RoundedTextBox txtKodeAtauNama;
        private Label label4;
        private ComboBox cmbStatus;
        private RoundedPanel roundedPanel2;
        private DataGridView dataGridView1;
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
        private Label lblJumlahStok;
        private Label label7;
        private Panel panel4;
        private Label label11;
        private Label lblStokMinimum;
        private Label label10;
        private Panel panel5;
        private Label lblStatus;
        private Label label14;
        private RoundedTextBox txtSelisih;
        private Label label16;
        private NumericUpDown numJumlahFisik;
        private Label label15;
        private Label label13;
        private Label label12;
        private Rondedbuton rondedbuton1;
        private TextBox txtAlasan;
        private Label label17;
    }
}
