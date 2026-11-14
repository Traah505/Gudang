namespace GUedang
{
    partial class UC_DSHBRDKasir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_DSHBRDKasir));
            panelKasir = new RoundedPanel();
            label7 = new Label();
            dgvTransaksiTerbaru = new DataGridView();
            colNo = new DataGridViewTextBoxColumn();
            colTanggal = new DataGridViewTextBoxColumn();
            colNamaKasir = new DataGridViewTextBoxColumn();
            colTotal = new DataGridViewTextBoxColumn();
            roundedPanel4 = new RoundedPanel();
            lblUserAktif = new Label();
            label6 = new Label();
            roundedPanel3 = new RoundedPanel();
            lblBarangTerjual = new Label();
            label5 = new Label();
            roundedPanel2 = new RoundedPanel();
            lblTotalPendapatan = new Label();
            label4 = new Label();
            roundedPanel1 = new RoundedPanel();
            lblTotalTransaksi = new Label();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            panelKasir.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTransaksiTerbaru).BeginInit();
            roundedPanel4.SuspendLayout();
            roundedPanel3.SuspendLayout();
            roundedPanel2.SuspendLayout();
            roundedPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelKasir
            // 
            panelKasir.BackColor = Color.Transparent;
            panelKasir.Controls.Add(label7);
            panelKasir.Controls.Add(dgvTransaksiTerbaru);
            panelKasir.Controls.Add(roundedPanel4);
            panelKasir.Controls.Add(roundedPanel3);
            panelKasir.Controls.Add(roundedPanel2);
            panelKasir.Controls.Add(roundedPanel1);
            panelKasir.Location = new Point(2, 28);
            panelKasir.Name = "panelKasir";
            panelKasir.Size = new Size(465, 309);
            panelKasir.TabIndex = 3;
            panelKasir.Paint += panelKasir_Paint;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(17, 139);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(134, 21);
            label7.TabIndex = 6;
            label7.Text = "Transaksi Terbaru";
            // 
            // dgvTransaksiTerbaru
            // 
            dgvTransaksiTerbaru.AllowUserToAddRows = false;
            dgvTransaksiTerbaru.AllowUserToDeleteRows = false;
            dgvTransaksiTerbaru.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTransaksiTerbaru.BackgroundColor = Color.White;
            dgvTransaksiTerbaru.BorderStyle = BorderStyle.None;
            dgvTransaksiTerbaru.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(23, 59, 103);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.Padding = new Padding(8);
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvTransaksiTerbaru.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvTransaksiTerbaru.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTransaksiTerbaru.Columns.AddRange(new DataGridViewColumn[] { colNo, colTanggal, colNamaKasir, colTotal });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(51, 65, 85);
            dataGridViewCellStyle6.Padding = new Padding(6);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(219, 234, 254);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(23, 59, 103);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvTransaksiTerbaru.DefaultCellStyle = dataGridViewCellStyle6;
            dgvTransaksiTerbaru.EnableHeadersVisualStyles = false;
            dgvTransaksiTerbaru.GridColor = Color.FromArgb(226, 232, 240);
            dgvTransaksiTerbaru.Location = new Point(15, 160);
            dgvTransaksiTerbaru.Margin = new Padding(2);
            dgvTransaksiTerbaru.MultiSelect = false;
            dgvTransaksiTerbaru.Name = "dgvTransaksiTerbaru";
            dgvTransaksiTerbaru.ReadOnly = true;
            dgvTransaksiTerbaru.RowHeadersVisible = false;
            dgvTransaksiTerbaru.RowHeadersWidth = 62;
            dgvTransaksiTerbaru.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTransaksiTerbaru.Size = new Size(418, 118);
            dgvTransaksiTerbaru.TabIndex = 4;
            // 
            // colNo
            // 
            colNo.FillWeight = 40F;
            colNo.HeaderText = "No";
            colNo.MinimumWidth = 8;
            colNo.Name = "colNo";
            colNo.ReadOnly = true;
            // 
            // colTanggal
            // 
            colTanggal.FillWeight = 130F;
            colTanggal.HeaderText = "Tanggal";
            colTanggal.MinimumWidth = 8;
            colTanggal.Name = "colTanggal";
            colTanggal.ReadOnly = true;
            // 
            // colNamaKasir
            // 
            colNamaKasir.HeaderText = "Nama Kasir";
            colNamaKasir.MinimumWidth = 8;
            colNamaKasir.Name = "colNamaKasir";
            colNamaKasir.ReadOnly = true;
            // 
            // colTotal
            // 
            colTotal.FillWeight = 70F;
            colTotal.HeaderText = "Total";
            colTotal.MinimumWidth = 8;
            colTotal.Name = "colTotal";
            colTotal.ReadOnly = true;
            // 
            // roundedPanel4
            // 
            roundedPanel4.BackColor = Color.Transparent;
            roundedPanel4.Controls.Add(lblUserAktif);
            roundedPanel4.Controls.Add(label6);
            roundedPanel4.Location = new Point(247, 65);
            roundedPanel4.Margin = new Padding(2);
            roundedPanel4.Name = "roundedPanel4";
            roundedPanel4.Size = new Size(186, 55);
            roundedPanel4.TabIndex = 3;
            // 
            // lblUserAktif
            // 
            lblUserAktif.AutoSize = true;
            lblUserAktif.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUserAktif.ForeColor = Color.White;
            lblUserAktif.Location = new Point(27, 28);
            lblUserAktif.Margin = new Padding(2, 0, 2, 0);
            lblUserAktif.Name = "lblUserAktif";
            lblUserAktif.Size = new Size(19, 21);
            lblUserAktif.TabIndex = 7;
            lblUserAktif.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(20, 9);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(82, 21);
            label6.TabIndex = 7;
            label6.Text = "User Aktif";
            // 
            // roundedPanel3
            // 
            roundedPanel3.BackColor = Color.Transparent;
            roundedPanel3.BackgroundImageLayout = ImageLayout.None;
            roundedPanel3.Controls.Add(lblBarangTerjual);
            roundedPanel3.Controls.Add(label5);
            roundedPanel3.Location = new Point(15, 65);
            roundedPanel3.Margin = new Padding(2);
            roundedPanel3.Name = "roundedPanel3";
            roundedPanel3.Size = new Size(186, 55);
            roundedPanel3.TabIndex = 2;
            // 
            // lblBarangTerjual
            // 
            lblBarangTerjual.AutoSize = true;
            lblBarangTerjual.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBarangTerjual.ForeColor = Color.White;
            lblBarangTerjual.Location = new Point(18, 28);
            lblBarangTerjual.Margin = new Padding(2, 0, 2, 0);
            lblBarangTerjual.Name = "lblBarangTerjual";
            lblBarangTerjual.Size = new Size(19, 21);
            lblBarangTerjual.TabIndex = 7;
            lblBarangTerjual.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(11, 9);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(112, 21);
            label5.TabIndex = 6;
            label5.Text = "Barang Terjual";
            // 
            // roundedPanel2
            // 
            roundedPanel2.BackColor = Color.Transparent;
            roundedPanel2.Controls.Add(lblTotalPendapatan);
            roundedPanel2.Controls.Add(label4);
            roundedPanel2.Location = new Point(247, 7);
            roundedPanel2.Margin = new Padding(2);
            roundedPanel2.Name = "roundedPanel2";
            roundedPanel2.Size = new Size(186, 55);
            roundedPanel2.TabIndex = 1;
            roundedPanel2.Paint += roundedPanel2_Paint;
            // 
            // lblTotalPendapatan
            // 
            lblTotalPendapatan.AutoSize = true;
            lblTotalPendapatan.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalPendapatan.ForeColor = Color.White;
            lblTotalPendapatan.Location = new Point(20, 31);
            lblTotalPendapatan.Margin = new Padding(2, 0, 2, 0);
            lblTotalPendapatan.Name = "lblTotalPendapatan";
            lblTotalPendapatan.Size = new Size(19, 21);
            lblTotalPendapatan.TabIndex = 6;
            lblTotalPendapatan.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(20, 8);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(134, 21);
            label4.TabIndex = 6;
            label4.Text = "Total Pendapatan";
            // 
            // roundedPanel1
            // 
            roundedPanel1.BackColor = Color.Transparent;
            roundedPanel1.BackgroundImageLayout = ImageLayout.None;
            roundedPanel1.Controls.Add(lblTotalTransaksi);
            roundedPanel1.Controls.Add(label3);
            roundedPanel1.Location = new Point(15, 7);
            roundedPanel1.Margin = new Padding(2);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Size = new Size(186, 55);
            roundedPanel1.TabIndex = 0;
            // 
            // lblTotalTransaksi
            // 
            lblTotalTransaksi.AutoSize = true;
            lblTotalTransaksi.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalTransaksi.ForeColor = Color.White;
            lblTotalTransaksi.Location = new Point(18, 31);
            lblTotalTransaksi.Margin = new Padding(2, 0, 2, 0);
            lblTotalTransaksi.Name = "lblTotalTransaksi";
            lblTotalTransaksi.Size = new Size(19, 21);
            lblTotalTransaksi.TabIndex = 6;
            lblTotalTransaksi.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(11, 8);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(114, 21);
            label3.TabIndex = 6;
            label3.Text = "Total Transaksi";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(2, 2);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(128, 21);
            label1.TabIndex = 7;
            label1.Text = "Dashboard Kasir";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(387, 2);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(45, 21);
            label2.TabIndex = 8;
            label2.Text = "Kasir";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(361, 2);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(22, 21);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // UC_DSHBRDKasir
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panelKasir);
            Margin = new Padding(2);
            Name = "UC_DSHBRDKasir";
            Size = new Size(481, 340);
            panelKasir.ResumeLayout(false);
            panelKasir.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTransaksiTerbaru).EndInit();
            roundedPanel4.ResumeLayout(false);
            roundedPanel4.PerformLayout();
            roundedPanel3.ResumeLayout(false);
            roundedPanel3.PerformLayout();
            roundedPanel2.ResumeLayout(false);
            roundedPanel2.PerformLayout();
            roundedPanel1.ResumeLayout(false);
            roundedPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RoundedPanel panelKasir;
        private Label label7;
        private DataGridView dgvTransaksiTerbaru;
        private DataGridViewTextBoxColumn colNo;
        private DataGridViewTextBoxColumn colTanggal;
        private DataGridViewTextBoxColumn colNamaKasir;
        private DataGridViewTextBoxColumn colTotal;
        private RoundedPanel roundedPanel4;
        private Label lblUserAktif;
        private Label label6;
        private RoundedPanel roundedPanel3;
        private Label lblBarangTerjual;
        private Label label5;
        private RoundedPanel roundedPanel2;
        private Label lblTotalPendapatan;
        private Label label4;
        private RoundedPanel roundedPanel1;
        private Label lblTotalTransaksi;
        private Label label3;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
    }
}
