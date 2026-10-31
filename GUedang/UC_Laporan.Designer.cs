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
            lblTitleLaporan = new Label();
            roundedPanel1 = new RoundedPanel();
            btnTampilkan = new RoundedButton();
            label1 = new Label();
            cmbJenisLaporan = new ComboBox();
            lblSampaiTanggal = new Label();
            dtpSampaiTanggal = new DateTimePicker();
            lblDaruTanggal = new Label();
            dtpDariTanggal = new DateTimePicker();
            roundedPanel2 = new RoundedPanel();
            dataGridView1 = new DataGridView();
            roundedPanel1.SuspendLayout();
            roundedPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblTitleLaporan
            // 
            lblTitleLaporan.AutoSize = true;
            lblTitleLaporan.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitleLaporan.ForeColor = Color.Navy;
            lblTitleLaporan.Location = new Point(232, 25);
            lblTitleLaporan.Name = "lblTitleLaporan";
            lblTitleLaporan.Size = new Size(121, 38);
            lblTitleLaporan.TabIndex = 0;
            lblTitleLaporan.Text = "Laporan";
            lblTitleLaporan.Click += lblTitleLaporan_Click;
            // 
            // roundedPanel1
            // 
            roundedPanel1.BackColor = Color.Transparent;
            roundedPanel1.Controls.Add(btnTampilkan);
            roundedPanel1.Controls.Add(label1);
            roundedPanel1.Controls.Add(cmbJenisLaporan);
            roundedPanel1.Controls.Add(lblSampaiTanggal);
            roundedPanel1.Controls.Add(dtpSampaiTanggal);
            roundedPanel1.Controls.Add(lblDaruTanggal);
            roundedPanel1.Controls.Add(dtpDariTanggal);
            roundedPanel1.Location = new Point(232, 84);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Size = new Size(737, 107);
            roundedPanel1.TabIndex = 1;
            // 
            // btnTampilkan
            // 
            btnTampilkan.BackColor = Color.RoyalBlue;
            btnTampilkan.FlatAppearance.BorderSize = 0;
            btnTampilkan.FlatStyle = FlatStyle.Flat;
            btnTampilkan.ForeColor = Color.White;
            btnTampilkan.Location = new Point(594, 47);
            btnTampilkan.Name = "btnTampilkan";
            btnTampilkan.Size = new Size(124, 39);
            btnTampilkan.TabIndex = 6;
            btnTampilkan.Text = "Tampilkan";
            btnTampilkan.UseVisualStyleBackColor = false;
            btnTampilkan.Click += btnTampilkan_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(396, 24);
            label1.Name = "label1";
            label1.Size = new Size(107, 18);
            label1.TabIndex = 5;
            label1.Text = "Jenis Laporan";
            // 
            // cmbJenisLaporan
            // 
            cmbJenisLaporan.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbJenisLaporan.FormattingEnabled = true;
            cmbJenisLaporan.Items.AddRange(new object[] { "Penjualan", "Barang", "Kasir" });
            cmbJenisLaporan.Location = new Point(396, 53);
            cmbJenisLaporan.Name = "cmbJenisLaporan";
            cmbJenisLaporan.Size = new Size(192, 33);
            cmbJenisLaporan.TabIndex = 4;
            // 
            // lblSampaiTanggal
            // 
            lblSampaiTanggal.AutoSize = true;
            lblSampaiTanggal.Font = new Font("Arial", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSampaiTanggal.Location = new Point(229, 24);
            lblSampaiTanggal.Name = "lblSampaiTanggal";
            lblSampaiTanggal.Size = new Size(121, 18);
            lblSampaiTanggal.TabIndex = 3;
            lblSampaiTanggal.Text = "Sampai Tanggal";
            lblSampaiTanggal.Click += lblSampaiTanggal_Click;
            // 
            // dtpSampaiTanggal
            // 
            dtpSampaiTanggal.CustomFormat = "dd//MM/yyyy";
            dtpSampaiTanggal.Format = DateTimePickerFormat.Custom;
            dtpSampaiTanggal.Location = new Point(229, 55);
            dtpSampaiTanggal.Name = "dtpSampaiTanggal";
            dtpSampaiTanggal.Size = new Size(174, 31);
            dtpSampaiTanggal.TabIndex = 2;
            // 
            // lblDaruTanggal
            // 
            lblDaruTanggal.AutoSize = true;
            lblDaruTanggal.Font = new Font("Arial", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDaruTanggal.Location = new Point(39, 24);
            lblDaruTanggal.Name = "lblDaruTanggal";
            lblDaruTanggal.Size = new Size(96, 18);
            lblDaruTanggal.TabIndex = 1;
            lblDaruTanggal.Text = "Dari Tanggal";
            // 
            // dtpDariTanggal
            // 
            dtpDariTanggal.CustomFormat = "dd//MM/yyyy";
            dtpDariTanggal.Format = DateTimePickerFormat.Custom;
            dtpDariTanggal.Location = new Point(39, 55);
            dtpDariTanggal.Name = "dtpDariTanggal";
            dtpDariTanggal.Size = new Size(184, 31);
            dtpDariTanggal.TabIndex = 0;
            // 
            // roundedPanel2
            // 
            roundedPanel2.BackColor = Color.Transparent;
            roundedPanel2.Controls.Add(dataGridView1);
            roundedPanel2.Location = new Point(232, 214);
            roundedPanel2.Name = "roundedPanel2";
            roundedPanel2.Size = new Size(737, 288);
            roundedPanel2.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(39, 34);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(679, 225);
            dataGridView1.TabIndex = 0;
            // 
            // UC_Laporan
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(roundedPanel2);
            Controls.Add(roundedPanel1);
            Controls.Add(lblTitleLaporan);
            Name = "UC_Laporan";
            Size = new Size(1021, 533);
            Load += UC_Laporan_Load;
            roundedPanel1.ResumeLayout(false);
            roundedPanel1.PerformLayout();
            roundedPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitleLaporan;
        private RoundedPanel roundedPanel1;
        private RoundedPanel roundedPanel2;
        private Label lblSampaiTanggal;
        private DateTimePicker dtpSampaiTanggal;
        private Label lblDaruTanggal;
        private DateTimePicker dtpDariTanggal;
        private ComboBox cmbJenisLaporan;
        private Label label1;
        private RoundedButton btnTampilkan;
        private DataGridView dataGridView1;
    }
}
