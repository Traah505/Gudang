namespace GUedang
{
    partial class DashBoardkeranjang1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashBoardkeranjang1));
            roundedPanel1 = new RoundedPanel();
            lblTanggal = new Label();
            label2 = new Label();
            roundedPanel2 = new RoundedPanel();
            label8 = new Label();
            pictureBox3 = new PictureBox();
            roundedPanel3 = new RoundedPanel();
            btnProsesPembayaran = new RoundedButton();
            roundedPanel4 = new RoundedPanel();
            lblKembalian = new Label();
            txtJumlahBayar = new RoundedTextBox();
            lblKembalianTitle = new Label();
            lblJumlahBayar = new Label();
            lblJudulRingkasan = new Label();
            panelRingkasan = new RoundedPanel();
            lblTotalHarga = new Label();
            lblTotalHargaTitle = new Label();
            lblTotalItem = new Label();
            lblTotalItemTitle = new Label();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            dgvKeranjang = new DataGridView();
            colNamaBarang = new DataGridViewTextBoxColumn();
            colHarga = new DataGridViewTextBoxColumn();
            colJumlah = new DataGridViewTextBoxColumn();
            colSubtotal = new DataGridViewTextBoxColumn();
            colAksi = new DataGridViewTextBoxColumn();
            label1 = new Label();
            pictureBox4 = new PictureBox();
            roundedPanel1.SuspendLayout();
            roundedPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            roundedPanel3.SuspendLayout();
            roundedPanel4.SuspendLayout();
            panelRingkasan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvKeranjang).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // roundedPanel1
            // 
            roundedPanel1.BackColor = Color.Transparent;
            roundedPanel1.Controls.Add(lblTanggal);
            roundedPanel1.Controls.Add(label2);
            roundedPanel1.Controls.Add(roundedPanel2);
            roundedPanel1.Controls.Add(label1);
            roundedPanel1.Controls.Add(pictureBox4);
            roundedPanel1.Dock = DockStyle.Fill;
            roundedPanel1.Location = new Point(0, 0);
            roundedPanel1.Margin = new Padding(2, 2, 2, 2);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Size = new Size(881, 398);
            roundedPanel1.TabIndex = 0;
            roundedPanel1.Paint += roundedPanel1_Paint;
            // 
            // lblTanggal
            // 
            lblTanggal.AutoSize = true;
            lblTanggal.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTanggal.Location = new Point(536, 17);
            lblTanggal.Margin = new Padding(2, 0, 2, 0);
            lblTanggal.Name = "lblTanggal";
            lblTanggal.Size = new Size(50, 19);
            lblTanggal.TabIndex = 3;
            lblTanggal.Text = "label1";
            lblTanggal.Click += lblTanggal_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Blue;
            label2.Location = new Point(150, 5);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(92, 45);
            label2.TabIndex = 17;
            label2.Text = "Mart";
            label2.Click += label2_Click;
            // 
            // roundedPanel2
            // 
            roundedPanel2.BackColor = Color.Transparent;
            roundedPanel2.Controls.Add(label8);
            roundedPanel2.Controls.Add(pictureBox3);
            roundedPanel2.Controls.Add(roundedPanel3);
            roundedPanel2.Controls.Add(lblJudulRingkasan);
            roundedPanel2.Controls.Add(panelRingkasan);
            roundedPanel2.Controls.Add(pictureBox2);
            roundedPanel2.Controls.Add(label3);
            roundedPanel2.Controls.Add(pictureBox1);
            roundedPanel2.Controls.Add(dgvKeranjang);
            roundedPanel2.ForeColor = Color.Navy;
            roundedPanel2.Location = new Point(26, 46);
            roundedPanel2.Margin = new Padding(2, 2, 2, 2);
            roundedPanel2.Name = "roundedPanel2";
            roundedPanel2.Size = new Size(834, 337);
            roundedPanel2.TabIndex = 0;
            roundedPanel2.Paint += roundedPanel2_Paint;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(542, 122);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(73, 15);
            label8.TabIndex = 29;
            label8.Text = "Pembayaran";
            label8.Click += label8_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.White;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(513, 116);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(31, 21);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 28;
            pictureBox3.TabStop = false;
            // 
            // roundedPanel3
            // 
            roundedPanel3.BackColor = Color.Gainsboro;
            roundedPanel3.Controls.Add(btnProsesPembayaran);
            roundedPanel3.Controls.Add(roundedPanel4);
            roundedPanel3.Controls.Add(txtJumlahBayar);
            roundedPanel3.Controls.Add(lblKembalianTitle);
            roundedPanel3.Controls.Add(lblJumlahBayar);
            roundedPanel3.Location = new Point(542, 139);
            roundedPanel3.Margin = new Padding(2, 2, 2, 2);
            roundedPanel3.Name = "roundedPanel3";
            roundedPanel3.Size = new Size(242, 122);
            roundedPanel3.TabIndex = 27;
            // 
            // btnProsesPembayaran
            // 
            btnProsesPembayaran.BackColor = Color.Navy;
            btnProsesPembayaran.FlatAppearance.BorderSize = 0;
            btnProsesPembayaran.FlatStyle = FlatStyle.Flat;
            btnProsesPembayaran.ForeColor = Color.White;
            btnProsesPembayaran.Location = new Point(18, 93);
            btnProsesPembayaran.Margin = new Padding(2, 2, 2, 2);
            btnProsesPembayaran.Name = "btnProsesPembayaran";
            btnProsesPembayaran.Size = new Size(192, 27);
            btnProsesPembayaran.TabIndex = 31;
            btnProsesPembayaran.Text = "Proses Pembayaran";
            btnProsesPembayaran.UseVisualStyleBackColor = false;
            btnProsesPembayaran.Click += btnProsesPembayaran_Click;
            // 
            // roundedPanel4
            // 
            roundedPanel4.BackColor = Color.Transparent;
            roundedPanel4.Controls.Add(lblKembalian);
            roundedPanel4.Location = new Point(18, 63);
            roundedPanel4.Margin = new Padding(2, 2, 2, 2);
            roundedPanel4.Name = "roundedPanel4";
            roundedPanel4.Size = new Size(192, 26);
            roundedPanel4.TabIndex = 30;
            // 
            // lblKembalian
            // 
            lblKembalian.AutoSize = true;
            lblKembalian.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblKembalian.Location = new Point(11, 6);
            lblKembalian.Margin = new Padding(2, 0, 2, 0);
            lblKembalian.Name = "lblKembalian";
            lblKembalian.Size = new Size(31, 15);
            lblKembalian.TabIndex = 27;
            lblKembalian.Text = "Rp.0";
            // 
            // txtJumlahBayar
            // 
            txtJumlahBayar.Location = new Point(18, 22);
            txtJumlahBayar.Margin = new Padding(2, 2, 2, 2);
            txtJumlahBayar.Name = "txtJumlahBayar";
            txtJumlahBayar.Size = new Size(192, 24);
            txtJumlahBayar.TabIndex = 26;
            txtJumlahBayar.TextChanged += roundedTextBox1_TextChanged;
            // 
            // lblKembalianTitle
            // 
            lblKembalianTitle.AutoSize = true;
            lblKembalianTitle.Font = new Font("Calibri Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblKembalianTitle.Location = new Point(18, 48);
            lblKembalianTitle.Margin = new Padding(2, 0, 2, 0);
            lblKembalianTitle.Name = "lblKembalianTitle";
            lblKembalianTitle.Size = new Size(59, 14);
            lblKembalianTitle.TabIndex = 25;
            lblKembalianTitle.Text = "Kembalian";
            // 
            // lblJumlahBayar
            // 
            lblJumlahBayar.AutoSize = true;
            lblJumlahBayar.Font = new Font("Candara Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblJumlahBayar.Location = new Point(18, 7);
            lblJumlahBayar.Margin = new Padding(2, 0, 2, 0);
            lblJumlahBayar.Name = "lblJumlahBayar";
            lblJumlahBayar.Size = new Size(73, 14);
            lblJumlahBayar.TabIndex = 23;
            lblJumlahBayar.Text = "Jumlah Bayar";
            // 
            // lblJudulRingkasan
            // 
            lblJudulRingkasan.AutoSize = true;
            lblJudulRingkasan.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblJudulRingkasan.Location = new Point(542, 9);
            lblJudulRingkasan.Margin = new Padding(2, 0, 2, 0);
            lblJudulRingkasan.Name = "lblJudulRingkasan";
            lblJudulRingkasan.Size = new Size(102, 15);
            lblJudulRingkasan.TabIndex = 22;
            lblJudulRingkasan.Text = "Ringkasan Belanja";
            // 
            // panelRingkasan
            // 
            panelRingkasan.BackColor = Color.Transparent;
            panelRingkasan.Controls.Add(lblTotalHarga);
            panelRingkasan.Controls.Add(lblTotalHargaTitle);
            panelRingkasan.Controls.Add(lblTotalItem);
            panelRingkasan.Controls.Add(lblTotalItemTitle);
            panelRingkasan.Location = new Point(542, 27);
            panelRingkasan.Margin = new Padding(2, 2, 2, 2);
            panelRingkasan.Name = "panelRingkasan";
            panelRingkasan.Size = new Size(242, 89);
            panelRingkasan.TabIndex = 21;
            // 
            // lblTotalHarga
            // 
            lblTotalHarga.AutoSize = true;
            lblTotalHarga.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalHarga.Location = new Point(141, 56);
            lblTotalHarga.Margin = new Padding(2, 0, 2, 0);
            lblTotalHarga.Name = "lblTotalHarga";
            lblTotalHarga.Size = new Size(14, 15);
            lblTotalHarga.TabIndex = 26;
            lblTotalHarga.Text = "0";
            // 
            // lblTotalHargaTitle
            // 
            lblTotalHargaTitle.AutoSize = true;
            lblTotalHargaTitle.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalHargaTitle.Location = new Point(18, 56);
            lblTotalHargaTitle.Margin = new Padding(2, 0, 2, 0);
            lblTotalHargaTitle.Name = "lblTotalHargaTitle";
            lblTotalHargaTitle.Size = new Size(68, 15);
            lblTotalHargaTitle.TabIndex = 25;
            lblTotalHargaTitle.Text = "Total Harga";
            // 
            // lblTotalItem
            // 
            lblTotalItem.AutoSize = true;
            lblTotalItem.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalItem.Location = new Point(141, 18);
            lblTotalItem.Margin = new Padding(2, 0, 2, 0);
            lblTotalItem.Name = "lblTotalItem";
            lblTotalItem.Size = new Size(14, 15);
            lblTotalItem.TabIndex = 24;
            lblTotalItem.Text = "0";
            // 
            // lblTotalItemTitle
            // 
            lblTotalItemTitle.AutoSize = true;
            lblTotalItemTitle.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalItemTitle.Location = new Point(18, 18);
            lblTotalItemTitle.Margin = new Padding(2, 0, 2, 0);
            lblTotalItemTitle.Name = "lblTotalItemTitle";
            lblTotalItemTitle.Size = new Size(61, 15);
            lblTotalItemTitle.TabIndex = 23;
            lblTotalItemTitle.Text = "Total Item";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.White;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(513, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(31, 21);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 20;
            pictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(50, 9);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(149, 15);
            label3.TabIndex = 19;
            label3.Text = "Daftar Barang di Keranjang";
            label3.Click += label3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(21, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(31, 21);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // dgvKeranjang
            // 
            dgvKeranjang.AllowUserToAddRows = false;
            dgvKeranjang.AllowUserToDeleteRows = false;
            dgvKeranjang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKeranjang.BackgroundColor = Color.FromArgb(192, 255, 255);
            dgvKeranjang.BorderStyle = BorderStyle.None;
            dgvKeranjang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKeranjang.Columns.AddRange(new DataGridViewColumn[] { colNamaBarang, colHarga, colJumlah, colSubtotal, colAksi });
            dgvKeranjang.EnableHeadersVisualStyles = false;
            dgvKeranjang.Location = new Point(21, 27);
            dgvKeranjang.Margin = new Padding(2, 2, 2, 2);
            dgvKeranjang.MultiSelect = false;
            dgvKeranjang.Name = "dgvKeranjang";
            dgvKeranjang.RowHeadersVisible = false;
            dgvKeranjang.RowHeadersWidth = 62;
            dgvKeranjang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKeranjang.Size = new Size(464, 254);
            dgvKeranjang.TabIndex = 0;
            // 
            // colNamaBarang
            // 
            colNamaBarang.FillWeight = 180F;
            colNamaBarang.HeaderText = "Nama Barang";
            colNamaBarang.MinimumWidth = 8;
            colNamaBarang.Name = "colNamaBarang";
            // 
            // colHarga
            // 
            colHarga.HeaderText = "Harga";
            colHarga.MinimumWidth = 8;
            colHarga.Name = "colHarga";
            // 
            // colJumlah
            // 
            colJumlah.FillWeight = 70F;
            colJumlah.HeaderText = "Jumlah";
            colJumlah.MinimumWidth = 8;
            colJumlah.Name = "colJumlah";
            // 
            // colSubtotal
            // 
            colSubtotal.FillWeight = 110F;
            colSubtotal.HeaderText = "Subtotal";
            colSubtotal.MinimumWidth = 8;
            colSubtotal.Name = "colSubtotal";
            // 
            // colAksi
            // 
            colAksi.FillWeight = 70F;
            colAksi.HeaderText = "Aksi";
            colAksi.MinimumWidth = 8;
            colAksi.Name = "colAksi";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(77, 5);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(87, 45);
            label1.TabIndex = 16;
            label1.Text = "SMK";
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.White;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(26, 5);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(57, 35);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 15;
            pictureBox4.TabStop = false;
            // 
            // DashBoardkeranjang1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(881, 398);
            Controls.Add(roundedPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "DashBoardkeranjang1";
            Text = "DashboardKeranjang1";
            FormClosed += Form3_FormClosed;
            Load += Form3_Load;
            roundedPanel1.ResumeLayout(false);
            roundedPanel1.PerformLayout();
            roundedPanel2.ResumeLayout(false);
            roundedPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            roundedPanel3.ResumeLayout(false);
            roundedPanel3.PerformLayout();
            roundedPanel4.ResumeLayout(false);
            roundedPanel4.PerformLayout();
            panelRingkasan.ResumeLayout(false);
            panelRingkasan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvKeranjang).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private RoundedPanel roundedPanel1;
        private Label lblTanggal;
        private PictureBox pictureBox4;
        private Label label1;
        private Label label2;
        private RoundedPanel roundedPanel2;
        private DataGridView dgvKeranjang;
        private DataGridViewTextBoxColumn colNamaBarang;
        private DataGridViewTextBoxColumn colHarga;
        private DataGridViewTextBoxColumn colJumlah;
        private DataGridViewTextBoxColumn colSubtotal;
        private DataGridViewTextBoxColumn colAksi;
        private Label label3;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label lblJudulRingkasan;
        private RoundedPanel panelRingkasan;
        private Label lblTotalItemTitle;
        private Label lblTotalItem;
        private Label lblTotalHargaTitle;
        private Label lblTotalHarga;
        private Label label8;
        private PictureBox pictureBox3;
        private RoundedPanel roundedPanel3;
        private Label lblKembalianTitle;
        private Label lblJumlahBayar;
        private RoundedTextBox txtJumlahBayar
            ;
        private RoundedButton btnProsesPembayaran;
        private RoundedPanel roundedPanel4;
        private Label lblKembalian;
    }
}