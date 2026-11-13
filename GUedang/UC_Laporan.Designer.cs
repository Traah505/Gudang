namespace GUedang
{
    partial class UC_Laporan
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
            lblTitleLaporan = new Label();
            roundedPanel1 = new RoundedPanel();
            label4 = new Label();
            dtpTanggal = new DateTimePicker();
            panelJumlahTransaksi = new RoundedPanel();
            lblJumlahTransaksi = new Label();
            label3 = new Label();
            panelPendapatan = new RoundedPanel();
            lblTotalPendapatan = new Label();
            label2 = new Label();
            label1 = new Label();
            btnTampilkan = new RoundedButton();
            roundedPanel2 = new RoundedPanel();
            label5 = new Label();
            txtCariPenjualan = new CustomTextBox();
            dgvPenjualan = new DataGridView();
            colNo = new DataGridViewTextBoxColumn();
            colKode = new DataGridViewTextBoxColumn();
            colTanggal = new DataGridViewTextBoxColumn();
            colNamaKasir = new DataGridViewTextBoxColumn();
            colTotalHarga = new DataGridViewTextBoxColumn();
            roundedPanel3 = new RoundedPanel();
            roundedPanel1.SuspendLayout();
            panelJumlahTransaksi.SuspendLayout();
            panelPendapatan.SuspendLayout();
            roundedPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPenjualan).BeginInit();
            roundedPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitleLaporan
            // 
            lblTitleLaporan.AutoSize = true;
            lblTitleLaporan.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitleLaporan.ForeColor = Color.MidnightBlue;
            lblTitleLaporan.Location = new Point(29, 15);
            lblTitleLaporan.Margin = new Padding(2, 0, 2, 0);
            lblTitleLaporan.Name = "lblTitleLaporan";
            lblTitleLaporan.Size = new Size(169, 25);
            lblTitleLaporan.TabIndex = 0;
            lblTitleLaporan.Text = "Laporan Penjualan";
            lblTitleLaporan.Click += lblTitleLaporan_Click;
            // 
            // roundedPanel1
            // 
            roundedPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            roundedPanel1.BackColor = Color.Transparent;
            roundedPanel1.Controls.Add(label4);
            roundedPanel1.Controls.Add(dtpTanggal);
            roundedPanel1.Controls.Add(panelJumlahTransaksi);
            roundedPanel1.Controls.Add(panelPendapatan);
            roundedPanel1.Controls.Add(btnTampilkan);
            roundedPanel1.Location = new Point(2, 56);
            roundedPanel1.Margin = new Padding(2);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Size = new Size(886, 64);
            roundedPanel1.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(534, 22);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 10;
            label4.Text = "📅Tanggal";
            // 
            // dtpTanggal
            // 
            dtpTanggal.Format = DateTimePickerFormat.Custom;
            dtpTanggal.Location = new Point(607, 22);
            dtpTanggal.Margin = new Padding(2);
            dtpTanggal.Name = "dtpTanggal";
            dtpTanggal.Size = new Size(103, 23);
            dtpTanggal.TabIndex = 9;
            // 
            // panelJumlahTransaksi
            // 
            panelJumlahTransaksi.BackColor = Color.Transparent;
            panelJumlahTransaksi.Controls.Add(lblJumlahTransaksi);
            panelJumlahTransaksi.Controls.Add(label3);
            panelJumlahTransaksi.Location = new Point(282, 10);
            panelJumlahTransaksi.Margin = new Padding(2);
            panelJumlahTransaksi.Name = "panelJumlahTransaksi";
            panelJumlahTransaksi.Size = new Size(208, 44);
            panelJumlahTransaksi.TabIndex = 8;
            // 
            // lblJumlahTransaksi
            // 
            lblJumlahTransaksi.AutoSize = true;
            lblJumlahTransaksi.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblJumlahTransaksi.ForeColor = Color.White;
            lblJumlahTransaksi.Location = new Point(24, 17);
            lblJumlahTransaksi.Margin = new Padding(2, 0, 2, 0);
            lblJumlahTransaksi.Name = "lblJumlahTransaksi";
            lblJumlahTransaksi.Size = new Size(23, 25);
            lblJumlahTransaksi.TabIndex = 3;
            lblJumlahTransaksi.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri Light", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(24, 4);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(79, 13);
            label3.TabIndex = 3;
            label3.Text = "Jumlah Transaksi";
            // 
            // panelPendapatan
            // 
            panelPendapatan.BackColor = Color.Transparent;
            panelPendapatan.Controls.Add(lblTotalPendapatan);
            panelPendapatan.Controls.Add(label2);
            panelPendapatan.Controls.Add(label1);
            panelPendapatan.Location = new Point(27, 10);
            panelPendapatan.Margin = new Padding(2);
            panelPendapatan.Name = "panelPendapatan";
            panelPendapatan.Size = new Size(208, 44);
            panelPendapatan.TabIndex = 7;
            // 
            // lblTotalPendapatan
            // 
            lblTotalPendapatan.AutoSize = true;
            lblTotalPendapatan.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalPendapatan.ForeColor = Color.White;
            lblTotalPendapatan.Location = new Point(48, 17);
            lblTotalPendapatan.Margin = new Padding(2, 0, 2, 0);
            lblTotalPendapatan.Name = "lblTotalPendapatan";
            lblTotalPendapatan.Size = new Size(23, 25);
            lblTotalPendapatan.TabIndex = 2;
            lblTotalPendapatan.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(19, 17);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(35, 25);
            label2.TabIndex = 1;
            label2.Text = "Rp";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri Light", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(19, 5);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(84, 13);
            label1.TabIndex = 0;
            label1.Text = "Total Pendapatan";
            // 
            // btnTampilkan
            // 
            btnTampilkan.BackColor = Color.RoyalBlue;
            btnTampilkan.FlatAppearance.BorderSize = 0;
            btnTampilkan.FlatStyle = FlatStyle.Flat;
            btnTampilkan.ForeColor = Color.White;
            btnTampilkan.Location = new Point(738, 10);
            btnTampilkan.Margin = new Padding(2);
            btnTampilkan.Name = "btnTampilkan";
            btnTampilkan.Size = new Size(107, 39);
            btnTampilkan.TabIndex = 6;
            btnTampilkan.Text = "Tampilkan";
            btnTampilkan.UseVisualStyleBackColor = false;
            btnTampilkan.Click += btnTampilkan_Click;
            // 
            // roundedPanel2
            // 
            roundedPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            roundedPanel2.BackColor = Color.Transparent;
            roundedPanel2.Controls.Add(label5);
            roundedPanel2.Controls.Add(txtCariPenjualan);
            roundedPanel2.Controls.Add(dgvPenjualan);
            roundedPanel2.Location = new Point(2, 124);
            roundedPanel2.Margin = new Padding(2);
            roundedPanel2.Name = "roundedPanel2";
            roundedPanel2.Size = new Size(863, 401);
            roundedPanel2.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(239, 14);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(32, 21);
            label5.TabIndex = 3;
            label5.Tag = "";
            label5.Text = "🔍";
            // 
            // txtCariPenjualan
            // 
            txtCariPenjualan.BackColor = Color.White;
            txtCariPenjualan.Location = new Point(27, 10);
            txtCariPenjualan.Margin = new Padding(2);
            txtCariPenjualan.Name = "txtCariPenjualan";
            txtCariPenjualan.Padding = new Padding(7, 4, 7, 4);
            txtCariPenjualan.Size = new Size(208, 25);
            txtCariPenjualan.TabIndex = 2;
            // 
            // dgvPenjualan
            // 
            dgvPenjualan.AllowUserToAddRows = false;
            dgvPenjualan.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvPenjualan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPenjualan.BackgroundColor = Color.White;
            dgvPenjualan.BorderStyle = BorderStyle.None;
            dgvPenjualan.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.RoyalBlue;
            dataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvPenjualan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvPenjualan.ColumnHeadersHeight = 40;
            dgvPenjualan.Columns.AddRange(new DataGridViewColumn[] { colNo, colKode, colTanggal, colNamaKasir, colTotalHarga });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = Color.LightSteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = Color.DarkBlue;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvPenjualan.DefaultCellStyle = dataGridViewCellStyle4;
            dgvPenjualan.EnableHeadersVisualStyles = false;
            dgvPenjualan.GridColor = Color.Gainsboro;
            dgvPenjualan.Location = new Point(27, 46);
            dgvPenjualan.Margin = new Padding(2);
            dgvPenjualan.MultiSelect = false;
            dgvPenjualan.Name = "dgvPenjualan";
            dgvPenjualan.RowHeadersVisible = false;
            dgvPenjualan.RowHeadersWidth = 62;
            dgvPenjualan.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvPenjualan.RowTemplate.Height = 35;
            dgvPenjualan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPenjualan.Size = new Size(805, 337);
            dgvPenjualan.TabIndex = 0;
            // 
            // colNo
            // 
            colNo.FillWeight = 55F;
            colNo.HeaderText = "No";
            colNo.MinimumWidth = 8;
            colNo.Name = "colNo";
            // 
            // colKode
            // 
            colKode.FillWeight = 170F;
            colKode.HeaderText = "Kode Transaksi";
            colKode.MinimumWidth = 8;
            colKode.Name = "colKode";
            // 
            // colTanggal
            // 
            colTanggal.FillWeight = 150F;
            colTanggal.HeaderText = "Tanggal";
            colTanggal.MinimumWidth = 8;
            colTanggal.Name = "colTanggal";
            // 
            // colNamaKasir
            // 
            colNamaKasir.FillWeight = 170F;
            colNamaKasir.HeaderText = "Nama Kasir";
            colNamaKasir.MinimumWidth = 8;
            colNamaKasir.Name = "colNamaKasir";
            // 
            // colTotalHarga
            // 
            colTotalHarga.FillWeight = 150F;
            colTotalHarga.HeaderText = "Total Harga";
            colTotalHarga.MinimumWidth = 8;
            colTotalHarga.Name = "colTotalHarga";
            // 
            // roundedPanel3
            // 
            roundedPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            roundedPanel3.BackColor = Color.Transparent;
            roundedPanel3.Controls.Add(roundedPanel1);
            roundedPanel3.Controls.Add(lblTitleLaporan);
            roundedPanel3.Controls.Add(roundedPanel2);
            roundedPanel3.Location = new Point(0, 0);
            roundedPanel3.Name = "roundedPanel3";
            roundedPanel3.Size = new Size(890, 515);
            roundedPanel3.TabIndex = 3;
            // 
            // UC_Laporan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(roundedPanel3);
            Margin = new Padding(2);
            Name = "UC_Laporan";
            Size = new Size(896, 540);
            Load += UC_Laporan_Load;
            roundedPanel1.ResumeLayout(false);
            roundedPanel1.PerformLayout();
            panelJumlahTransaksi.ResumeLayout(false);
            panelJumlahTransaksi.PerformLayout();
            panelPendapatan.ResumeLayout(false);
            panelPendapatan.PerformLayout();
            roundedPanel2.ResumeLayout(false);
            roundedPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPenjualan).EndInit();
            roundedPanel3.ResumeLayout(false);
            roundedPanel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitleLaporan;
        private RoundedPanel roundedPanel1;
        private RoundedPanel roundedPanel2;
        private RoundedButton btnTampilkan;
        private DataGridView dgvPenjualan;
        private RoundedPanel roundedPanel3;
        private RoundedPanel panelPendapatan;
        private Label label2;
        private Label label1;
        private DateTimePicker dtpTanggal;
        private RoundedPanel panelJumlahTransaksi;
        private Label lblJumlahTransaksi;
        private Label label3;
        private Label lblTotalPendapatan;
        private Label label4;
        private DataGridViewTextBoxColumn colNo;
        private DataGridViewTextBoxColumn colKode;
        private DataGridViewTextBoxColumn colTanggal;
        private DataGridViewTextBoxColumn colNamaKasir;
        private DataGridViewTextBoxColumn colTotalHarga;
        private CustomTextBox txtCariPenjualan;
        private Label label5;
    }
}
