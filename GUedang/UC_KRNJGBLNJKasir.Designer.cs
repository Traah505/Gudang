namespace GUedang
{
    partial class UC_KRNJGBLNJKasir
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            label1 = new Label();
            btnHapusSemua = new RoundedButton();
            dgvBarang = new DataGridView();
            colNo = new DataGridViewTextBoxColumn();
            colKode = new DataGridViewTextBoxColumn();
            colNama = new DataGridViewTextBoxColumn();
            colHarga = new DataGridViewTextBoxColumn();
            colKategori = new DataGridViewTextBoxColumn();
            colStok = new DataGridViewTextBoxColumn();
            btnBayar = new RoundedButton();
            label3 = new Label();
            txtKodeKasir = new TextBox();
            txtNamaKasir = new TextBox();
            label4 = new Label();
            textKategoriKasir = new TextBox();
            label6 = new Label();
            roundedPanel2 = new RoundedPanel();
            numJumlah = new NumericUpDown();
            label9 = new Label();
            panel1 = new Panel();
            label5 = new Label();
            label8 = new Label();
            roundedPanel3 = new RoundedPanel();
            btnBatal = new RoundedButton();
            lblKembalian = new Label();
            label18 = new Label();
            label11 = new Label();
            txtUangDiterima = new RoundedTextBox();
            label17 = new Label();
            lblTotalBayar = new Label();
            label13 = new Label();
            label14 = new Label();
            lblSubtotal = new Label();
            label12 = new Label();
            CV = new Label();
            lblNominalTotalBelanja = new Label();
            label15 = new Label();
            label2 = new Label();
            label7 = new Label();
            label10 = new Label();
            dgvKeranjang = new DataGridView();
            colNamaBarang = new DataGridViewTextBoxColumn();
            colJumlah = new DataGridViewTextBoxColumn();
            colHarga2 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvBarang).BeginInit();
            roundedPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numJumlah).BeginInit();
            panel1.SuspendLayout();
            roundedPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKeranjang).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(191, 30);
            label1.TabIndex = 4;
            label1.Text = "Keranjang Belanja";
            // 
            // btnHapusSemua
            // 
            btnHapusSemua.BackColor = Color.AliceBlue;
            btnHapusSemua.FlatAppearance.BorderSize = 0;
            btnHapusSemua.FlatStyle = FlatStyle.Flat;
            btnHapusSemua.ForeColor = Color.RoyalBlue;
            btnHapusSemua.Location = new Point(610, 12);
            btnHapusSemua.Margin = new Padding(2);
            btnHapusSemua.Name = "btnHapusSemua";
            btnHapusSemua.Size = new Size(113, 28);
            btnHapusSemua.TabIndex = 6;
            btnHapusSemua.Text = "🗑️Hapus Semua";
            btnHapusSemua.UseVisualStyleBackColor = false;
            // 
            // dgvBarang
            // 
            dgvBarang.AllowUserToAddRows = false;
            dgvBarang.AllowUserToDeleteRows = false;
            dgvBarang.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvBarang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBarang.BackgroundColor = Color.White;
            dgvBarang.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.SteelBlue;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvBarang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvBarang.ColumnHeadersHeight = 40;
            dgvBarang.Columns.AddRange(new DataGridViewColumn[] { colNo, colKode, colNama, colHarga, colKategori, colStok });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.DimGray;
            dataGridViewCellStyle2.Padding = new Padding(6);
            dataGridViewCellStyle2.SelectionBackColor = Color.DodgerBlue;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvBarang.DefaultCellStyle = dataGridViewCellStyle2;
            dgvBarang.EnableHeadersVisualStyles = false;
            dgvBarang.Location = new Point(15, 109);
            dgvBarang.Margin = new Padding(2);
            dgvBarang.MultiSelect = false;
            dgvBarang.Name = "dgvBarang";
            dgvBarang.ReadOnly = true;
            dgvBarang.RowHeadersVisible = false;
            dgvBarang.RowHeadersWidth = 62;
            dgvBarang.RowTemplate.Height = 40;
            dgvBarang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBarang.Size = new Size(489, 280);
            dgvBarang.TabIndex = 7;
            dgvBarang.CellContentClick += dgvBarang_CellContentClick;
            // 
            // colNo
            // 
            colNo.FillWeight = 45F;
            colNo.HeaderText = "No";
            colNo.MinimumWidth = 8;
            colNo.Name = "colNo";
            colNo.ReadOnly = true;
            // 
            // colKode
            // 
            colKode.FillWeight = 105F;
            colKode.HeaderText = "Kode Barang";
            colKode.MinimumWidth = 8;
            colKode.Name = "colKode";
            colKode.ReadOnly = true;
            // 
            // colNama
            // 
            colNama.FillWeight = 125F;
            colNama.HeaderText = "Nama Barang";
            colNama.MinimumWidth = 8;
            colNama.Name = "colNama";
            colNama.ReadOnly = true;
            // 
            // colHarga
            // 
            colHarga.FillWeight = 85F;
            colHarga.HeaderText = "Harga";
            colHarga.MinimumWidth = 8;
            colHarga.Name = "colHarga";
            colHarga.ReadOnly = true;
            // 
            // colKategori
            // 
            colKategori.HeaderText = "Kategori";
            colKategori.MinimumWidth = 8;
            colKategori.Name = "colKategori";
            colKategori.ReadOnly = true;
            // 
            // colStok
            // 
            colStok.HeaderText = "Stok";
            colStok.MinimumWidth = 8;
            colStok.Name = "colStok";
            colStok.ReadOnly = true;
            // 
            // btnBayar
            // 
            btnBayar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnBayar.BackColor = Color.RoyalBlue;
            btnBayar.FlatAppearance.BorderSize = 0;
            btnBayar.FlatStyle = FlatStyle.Flat;
            btnBayar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBayar.ForeColor = Color.White;
            btnBayar.Location = new Point(4, 325);
            btnBayar.Margin = new Padding(2);
            btnBayar.Name = "btnBayar";
            btnBayar.Size = new Size(91, 28);
            btnBayar.TabIndex = 10;
            btnBayar.Text = "💵 Bayar  ›";
            btnBayar.UseVisualStyleBackColor = false;
            btnBayar.Click += btnBayar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(15, 49);
            label3.Name = "label3";
            label3.Size = new Size(78, 15);
            label3.TabIndex = 12;
            label3.Text = "Kode Barang";
            // 
            // txtKodeKasir
            // 
            txtKodeKasir.Location = new Point(15, 67);
            txtKodeKasir.Name = "txtKodeKasir";
            txtKodeKasir.Size = new Size(144, 23);
            txtKodeKasir.TabIndex = 13;
            // 
            // txtNamaKasir
            // 
            txtNamaKasir.Location = new Point(163, 67);
            txtNamaKasir.Name = "txtNamaKasir";
            txtNamaKasir.Size = new Size(144, 23);
            txtNamaKasir.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(163, 49);
            label4.Name = "label4";
            label4.Size = new Size(81, 15);
            label4.TabIndex = 15;
            label4.Text = "Nama Barang";
            label4.Click += label4_Click;
            // 
            // textKategoriKasir
            // 
            textKategoriKasir.Location = new Point(312, 67);
            textKategoriKasir.Name = "textKategoriKasir";
            textKategoriKasir.Size = new Size(144, 23);
            textKategoriKasir.TabIndex = 20;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(312, 51);
            label6.Name = "label6";
            label6.Size = new Size(97, 15);
            label6.TabIndex = 21;
            label6.Text = "Kategori Barang";
            // 
            // roundedPanel2
            // 
            roundedPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            roundedPanel2.BackColor = Color.Transparent;
            roundedPanel2.Controls.Add(numJumlah);
            roundedPanel2.Controls.Add(label9);
            roundedPanel2.Controls.Add(panel1);
            roundedPanel2.Controls.Add(label8);
            roundedPanel2.Controls.Add(roundedPanel3);
            roundedPanel2.Controls.Add(label3);
            roundedPanel2.Controls.Add(dgvBarang);
            roundedPanel2.Controls.Add(txtKodeKasir);
            roundedPanel2.Controls.Add(txtNamaKasir);
            roundedPanel2.Controls.Add(label6);
            roundedPanel2.Controls.Add(btnHapusSemua);
            roundedPanel2.Controls.Add(label4);
            roundedPanel2.Controls.Add(textKategoriKasir);
            roundedPanel2.Controls.Add(label1);
            roundedPanel2.Location = new Point(0, 0);
            roundedPanel2.Name = "roundedPanel2";
            roundedPanel2.Size = new Size(734, 408);
            roundedPanel2.TabIndex = 24;
            roundedPanel2.Paint += roundedPanel2_Paint;
            // 
            // numJumlah
            // 
            numJumlah.Location = new Point(458, 67);
            numJumlah.Margin = new Padding(2);
            numJumlah.Name = "numJumlah";
            numJumlah.Size = new Size(46, 23);
            numJumlah.TabIndex = 26;
            numJumlah.TextAlign = HorizontalAlignment.Center;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label9.Location = new Point(452, 49);
            label9.Name = "label9";
            label9.Size = new Size(46, 15);
            label9.TabIndex = 25;
            label9.Text = "Jumlah";
            // 
            // panel1
            // 
            panel1.BackColor = Color.RoyalBlue;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label5);
            panel1.Location = new Point(526, 44);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(198, 34);
            panel1.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(17, 7);
            label5.Name = "label5";
            label5.Size = new Size(80, 20);
            label5.TabIndex = 25;
            label5.Text = "Keranjang";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label8.Location = new Point(15, 93);
            label8.Name = "label8";
            label8.Size = new Size(85, 15);
            label8.TabIndex = 24;
            label8.Text = "Daftar Barang";
            // 
            // roundedPanel3
            // 
            roundedPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            roundedPanel3.BackColor = Color.Transparent;
            roundedPanel3.Controls.Add(btnBatal);
            roundedPanel3.Controls.Add(lblKembalian);
            roundedPanel3.Controls.Add(label18);
            roundedPanel3.Controls.Add(label11);
            roundedPanel3.Controls.Add(txtUangDiterima);
            roundedPanel3.Controls.Add(label17);
            roundedPanel3.Controls.Add(lblTotalBayar);
            roundedPanel3.Controls.Add(label13);
            roundedPanel3.Controls.Add(label14);
            roundedPanel3.Controls.Add(lblSubtotal);
            roundedPanel3.Controls.Add(label12);
            roundedPanel3.Controls.Add(CV);
            roundedPanel3.Controls.Add(lblNominalTotalBelanja);
            roundedPanel3.Controls.Add(label15);
            roundedPanel3.Controls.Add(label2);
            roundedPanel3.Controls.Add(label7);
            roundedPanel3.Controls.Add(label10);
            roundedPanel3.Controls.Add(dgvKeranjang);
            roundedPanel3.Controls.Add(btnBayar);
            roundedPanel3.Location = new Point(526, 51);
            roundedPanel3.Margin = new Padding(2);
            roundedPanel3.Name = "roundedPanel3";
            roundedPanel3.Size = new Size(197, 355);
            roundedPanel3.TabIndex = 23;
            roundedPanel3.Paint += roundedPanel3_Paint;
            // 
            // btnBatal
            // 
            btnBatal.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnBatal.BackColor = Color.Gray;
            btnBatal.FlatAppearance.BorderSize = 0;
            btnBatal.FlatStyle = FlatStyle.Flat;
            btnBatal.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBatal.ForeColor = Color.White;
            btnBatal.Location = new Point(99, 325);
            btnBatal.Margin = new Padding(2);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(90, 28);
            btnBatal.TabIndex = 24;
            btnBatal.Text = " Batal  ›";
            btnBatal.UseVisualStyleBackColor = false;
            // 
            // lblKembalian
            // 
            lblKembalian.AutoSize = true;
            lblKembalian.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblKembalian.ForeColor = Color.SeaGreen;
            lblKembalian.Location = new Point(38, 287);
            lblKembalian.Margin = new Padding(2, 0, 2, 0);
            lblKembalian.Name = "lblKembalian";
            lblKembalian.Size = new Size(26, 30);
            lblKembalian.TabIndex = 23;
            lblKembalian.Text = "0";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.ForeColor = Color.SeaGreen;
            label18.Location = new Point(0, 287);
            label18.Margin = new Padding(2, 0, 2, 0);
            label18.Name = "label18";
            label18.Size = new Size(41, 30);
            label18.TabIndex = 22;
            label18.Text = "Rp";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(2, 270);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(80, 19);
            label11.TabIndex = 21;
            label11.Text = "Kembalian";
            // 
            // txtUangDiterima
            // 
            txtUangDiterima.Location = new Point(2, 241);
            txtUangDiterima.Margin = new Padding(2);
            txtUangDiterima.Name = "txtUangDiterima";
            txtUangDiterima.Size = new Size(186, 27);
            txtUangDiterima.TabIndex = 20;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.Location = new Point(0, 224);
            label17.Margin = new Padding(2, 0, 2, 0);
            label17.Name = "label17";
            label17.Size = new Size(88, 15);
            label17.TabIndex = 19;
            label17.Text = "Uang Diterima";
            // 
            // lblTotalBayar
            // 
            lblTotalBayar.AutoSize = true;
            lblTotalBayar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalBayar.Location = new Point(27, 209);
            lblTotalBayar.Margin = new Padding(2, 0, 2, 0);
            lblTotalBayar.Name = "lblTotalBayar";
            lblTotalBayar.Size = new Size(14, 15);
            lblTotalBayar.TabIndex = 18;
            lblTotalBayar.Text = "0";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.MidnightBlue;
            label13.Location = new Point(2, 209);
            label13.Margin = new Padding(2, 0, 2, 0);
            label13.Name = "label13";
            label13.Size = new Size(22, 15);
            label13.TabIndex = 17;
            label13.Text = "Rp";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BorderStyle = BorderStyle.Fixed3D;
            label14.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.RoyalBlue;
            label14.Location = new Point(3, 79);
            label14.Margin = new Padding(2, 0, 2, 0);
            label14.Name = "label14";
            label14.Size = new Size(186, 17);
            label14.TabIndex = 16;
            label14.Text = "                                                           ";
            // 
            // lblSubtotal
            // 
            lblSubtotal.AutoSize = true;
            lblSubtotal.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSubtotal.Location = new Point(27, 109);
            lblSubtotal.Margin = new Padding(2, 0, 2, 0);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(17, 19);
            lblSubtotal.TabIndex = 15;
            lblSubtotal.Text = "0";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.MidnightBlue;
            label12.Location = new Point(2, 109);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(27, 19);
            label12.TabIndex = 14;
            label12.Text = "Rp";
            // 
            // CV
            // 
            CV.AutoSize = true;
            CV.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CV.Location = new Point(2, 92);
            CV.Margin = new Padding(2, 0, 2, 0);
            CV.Name = "CV";
            CV.Size = new Size(65, 19);
            CV.TabIndex = 13;
            CV.Text = "Subtotal";
            // 
            // lblNominalTotalBelanja
            // 
            lblNominalTotalBelanja.AutoSize = true;
            lblNominalTotalBelanja.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNominalTotalBelanja.ForeColor = Color.RoyalBlue;
            lblNominalTotalBelanja.Location = new Point(38, 160);
            lblNominalTotalBelanja.Margin = new Padding(2, 0, 2, 0);
            lblNominalTotalBelanja.Name = "lblNominalTotalBelanja";
            lblNominalTotalBelanja.Size = new Size(26, 30);
            lblNominalTotalBelanja.TabIndex = 2;
            lblNominalTotalBelanja.Text = "0";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(2, 194);
            label15.Margin = new Padding(2, 0, 2, 0);
            label15.Name = "label15";
            label15.Size = new Size(68, 15);
            label15.TabIndex = 3;
            label15.Text = "Total Bayar";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(0, 143);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(112, 19);
            label2.TabIndex = 3;
            label2.Text = "📄Total Belanja";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.RoyalBlue;
            label7.Location = new Point(0, 160);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(41, 30);
            label7.TabIndex = 1;
            label7.Text = "Rp";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BorderStyle = BorderStyle.Fixed3D;
            label10.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.RoyalBlue;
            label10.Location = new Point(-28, 136);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(186, 17);
            label10.TabIndex = 12;
            label10.Text = "                                                           ";
            // 
            // dgvKeranjang
            // 
            dgvKeranjang.AllowUserToResizeColumns = false;
            dataGridViewCellStyle3.BackColor = Color.AliceBlue;
            dgvKeranjang.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvKeranjang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKeranjang.BackgroundColor = Color.White;
            dgvKeranjang.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.RoyalBlue;
            dataGridViewCellStyle4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvKeranjang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvKeranjang.ColumnHeadersHeight = 40;
            dgvKeranjang.Columns.AddRange(new DataGridViewColumn[] { colNamaBarang, colJumlah, colHarga2 });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = Color.DarkSlateGray;
            dataGridViewCellStyle5.SelectionBackColor = Color.LightSteelBlue;
            dataGridViewCellStyle5.SelectionForeColor = Color.DarkBlue;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgvKeranjang.DefaultCellStyle = dataGridViewCellStyle5;
            dgvKeranjang.EnableHeadersVisualStyles = false;
            dgvKeranjang.Location = new Point(0, 23);
            dgvKeranjang.Margin = new Padding(2);
            dgvKeranjang.MultiSelect = false;
            dgvKeranjang.Name = "dgvKeranjang";
            dgvKeranjang.RowHeadersVisible = false;
            dgvKeranjang.RowHeadersWidth = 62;
            dgvKeranjang.RowTemplate.Height = 35;
            dgvKeranjang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKeranjang.Size = new Size(215, 54);
            dgvKeranjang.TabIndex = 11;
            // 
            // colNamaBarang
            // 
            colNamaBarang.HeaderText = "Nama Barang";
            colNamaBarang.MinimumWidth = 8;
            colNamaBarang.Name = "colNamaBarang";
            // 
            // colJumlah
            // 
            colJumlah.HeaderText = "Jumlah";
            colJumlah.MinimumWidth = 8;
            colJumlah.Name = "colJumlah";
            // 
            // colHarga2
            // 
            colHarga2.HeaderText = "Harga";
            colHarga2.MinimumWidth = 8;
            colHarga2.Name = "colHarga2";
            // 
            // UC_KRNJGBLNJKasir
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(roundedPanel2);
            Margin = new Padding(2);
            Name = "UC_KRNJGBLNJKasir";
            Size = new Size(734, 408);
            ((System.ComponentModel.ISupportInitialize)dgvBarang).EndInit();
            roundedPanel2.ResumeLayout(false);
            roundedPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numJumlah).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            roundedPanel3.ResumeLayout(false);
            roundedPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKeranjang).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private RoundedButton btnHapusSemua;
        private DataGridView dgvBarang;
        private RoundedButton btnBayar;
        private Label label3;
        private TextBox txtKodeKasir;
        private TextBox txtNamaKasir;
        private Label label4;
        private TextBox textKategoriKasir;
        private Label label6;
        private RoundedPanel roundedPanel2;
        private DataGridViewTextBoxColumn colNo;
        private DataGridViewTextBoxColumn colKode;
        private DataGridViewTextBoxColumn colNama;
        private DataGridViewTextBoxColumn colHarga;
        private DataGridViewTextBoxColumn colKategori;
        private DataGridViewTextBoxColumn colStok;
        private RoundedPanel roundedPanel3;
        private Label lblNominalTotalBelanja;
        private Label label7;
        private Label label2;
        private Label label8;
        private DataGridView dgvKeranjang;
        private Panel panel1;
        private Label label5;
        private Label label9;
        private NumericUpDown numJumlah;
        private Label label10;
        private DataGridViewTextBoxColumn colNamaBarang;
        private DataGridViewTextBoxColumn colJumlah;
        private DataGridViewTextBoxColumn colHarga2;
        private Label label12;
        private Label CV;
        private Label label14;
        private Label lblSubtotal;
        private Label label15;
        private Label label17;
        private Label lblTotalBayar;
        private Label label13;
        private RoundedTextBox txtUangDiterima;
        private Label lblKembalian;
        private Label label18;
        private Label label11;
        private RoundedButton btnBatal;
    }
}
