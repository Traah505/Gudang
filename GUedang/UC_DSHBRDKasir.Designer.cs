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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label2 = new Label();
            roundedPanel1 = new RoundedPanel();
            roundedPanel2 = new RoundedPanel();
            roundedPanel3 = new RoundedPanel();
            roundedPanel4 = new RoundedPanel();
            roundedPanel5 = new RoundedPanel();
            label1 = new Label();
            lblTotalPendapatan = new Label();
            label4 = new Label();
            CV = new Label();
            lblJumlahTransaksi = new Label();
            label3 = new Label();
            lblItemTerjual = new Label();
            label5 = new Label();
            lblItemdiKeranjang = new Label();
            dgvTransaksiHariIni = new DataGridView();
            roundedPanel6 = new RoundedPanel();
            colNoTransaksi = new DataGridViewTextBoxColumn();
            colWaktu = new DataGridViewTextBoxColumn();
            colKasir = new DataGridViewTextBoxColumn();
            colTotal = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            roundedPanel1.SuspendLayout();
            roundedPanel2.SuspendLayout();
            roundedPanel3.SuspendLayout();
            roundedPanel4.SuspendLayout();
            roundedPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTransaksiHariIni).BeginInit();
            roundedPanel6.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(roundedPanel6);
            panel1.Controls.Add(roundedPanel1);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1429, 642);
            panel1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.MidnightBlue;
            label2.Location = new Point(18, 20);
            label2.Name = "label2";
            label2.Size = new Size(234, 39);
            label2.TabIndex = 5;
            label2.Text = "Dashboard Kasir";
            // 
            // roundedPanel1
            // 
            roundedPanel1.BackColor = Color.Transparent;
            roundedPanel1.Controls.Add(roundedPanel5);
            roundedPanel1.Controls.Add(roundedPanel4);
            roundedPanel1.Controls.Add(roundedPanel3);
            roundedPanel1.Controls.Add(roundedPanel2);
            roundedPanel1.Location = new Point(30, 62);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Size = new Size(1378, 154);
            roundedPanel1.TabIndex = 6;
            // 
            // roundedPanel2
            // 
            roundedPanel2.BackColor = Color.Transparent;
            roundedPanel2.Controls.Add(label4);
            roundedPanel2.Controls.Add(lblTotalPendapatan);
            roundedPanel2.Controls.Add(label1);
            roundedPanel2.Location = new Point(19, 22);
            roundedPanel2.Name = "roundedPanel2";
            roundedPanel2.Size = new Size(323, 105);
            roundedPanel2.TabIndex = 0;
            // 
            // roundedPanel3
            // 
            roundedPanel3.BackColor = Color.Transparent;
            roundedPanel3.Controls.Add(lblJumlahTransaksi);
            roundedPanel3.Controls.Add(CV);
            roundedPanel3.Location = new Point(358, 22);
            roundedPanel3.Name = "roundedPanel3";
            roundedPanel3.Size = new Size(323, 105);
            roundedPanel3.TabIndex = 1;
            // 
            // roundedPanel4
            // 
            roundedPanel4.BackColor = Color.Transparent;
            roundedPanel4.Controls.Add(lblItemTerjual);
            roundedPanel4.Controls.Add(label3);
            roundedPanel4.Location = new Point(698, 22);
            roundedPanel4.Name = "roundedPanel4";
            roundedPanel4.Size = new Size(323, 105);
            roundedPanel4.TabIndex = 2;
            // 
            // roundedPanel5
            // 
            roundedPanel5.BackColor = Color.Transparent;
            roundedPanel5.Controls.Add(lblItemdiKeranjang);
            roundedPanel5.Controls.Add(label5);
            roundedPanel5.Location = new Point(1038, 22);
            roundedPanel5.Name = "roundedPanel5";
            roundedPanel5.Size = new Size(323, 105);
            roundedPanel5.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(23, 14);
            label1.Name = "label1";
            label1.Size = new Size(147, 25);
            label1.TabIndex = 0;
            label1.Text = "Total Pendapatan";
            // 
            // lblTotalPendapatan
            // 
            lblTotalPendapatan.AutoSize = true;
            lblTotalPendapatan.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalPendapatan.ForeColor = Color.RoyalBlue;
            lblTotalPendapatan.Location = new Point(74, 39);
            lblTotalPendapatan.Name = "lblTotalPendapatan";
            lblTotalPendapatan.Size = new Size(38, 45);
            lblTotalPendapatan.TabIndex = 1;
            lblTotalPendapatan.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.RoyalBlue;
            label4.Location = new Point(20, 39);
            label4.Name = "label4";
            label4.Size = new Size(61, 45);
            label4.TabIndex = 2;
            label4.Text = "Rp";
            // 
            // CV
            // 
            CV.AutoSize = true;
            CV.ForeColor = Color.DimGray;
            CV.Location = new Point(27, 14);
            CV.Name = "CV";
            CV.Size = new Size(142, 25);
            CV.TabIndex = 3;
            CV.Text = "Jumlah Transaksi";
            // 
            // lblJumlahTransaksi
            // 
            lblJumlahTransaksi.AutoSize = true;
            lblJumlahTransaksi.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblJumlahTransaksi.ForeColor = Color.SeaGreen;
            lblJumlahTransaksi.Location = new Point(27, 39);
            lblJumlahTransaksi.Name = "lblJumlahTransaksi";
            lblJumlahTransaksi.Size = new Size(38, 45);
            lblJumlahTransaksi.TabIndex = 3;
            lblJumlahTransaksi.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.DimGray;
            label3.Location = new Point(24, 14);
            label3.Name = "label3";
            label3.Size = new Size(102, 25);
            label3.TabIndex = 4;
            label3.Text = "Item Terjual";
            // 
            // lblItemTerjual
            // 
            lblItemTerjual.AutoSize = true;
            lblItemTerjual.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblItemTerjual.ForeColor = Color.MediumPurple;
            lblItemTerjual.Location = new Point(24, 39);
            lblItemTerjual.Name = "lblItemTerjual";
            lblItemTerjual.Size = new Size(38, 45);
            lblItemTerjual.TabIndex = 4;
            lblItemTerjual.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.DimGray;
            label5.Location = new Point(31, 14);
            label5.Name = "label5";
            label5.Size = new Size(151, 25);
            label5.TabIndex = 5;
            label5.Text = "Item di Keranjang";
            // 
            // lblItemdiKeranjang
            // 
            lblItemdiKeranjang.AutoSize = true;
            lblItemdiKeranjang.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblItemdiKeranjang.ForeColor = Color.DarkGoldenrod;
            lblItemdiKeranjang.Location = new Point(31, 39);
            lblItemdiKeranjang.Name = "lblItemdiKeranjang";
            lblItemdiKeranjang.Size = new Size(38, 45);
            lblItemdiKeranjang.TabIndex = 5;
            lblItemdiKeranjang.Text = "0";
            // 
            // dgvTransaksiHariIni
            // 
            dgvTransaksiHariIni.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = Color.AliceBlue;
            dgvTransaksiHariIni.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvTransaksiHariIni.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTransaksiHariIni.BackgroundColor = Color.White;
            dgvTransaksiHariIni.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.RoyalBlue;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvTransaksiHariIni.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvTransaksiHariIni.ColumnHeadersHeight = 34;
            dgvTransaksiHariIni.Columns.AddRange(new DataGridViewColumn[] { colNoTransaksi, colWaktu, colKasir, colTotal });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.Gray;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvTransaksiHariIni.DefaultCellStyle = dataGridViewCellStyle3;
            dgvTransaksiHariIni.EnableHeadersVisualStyles = false;
            dgvTransaksiHariIni.Location = new Point(17, 17);
            dgvTransaksiHariIni.MultiSelect = false;
            dgvTransaksiHariIni.Name = "dgvTransaksiHariIni";
            dgvTransaksiHariIni.ReadOnly = true;
            dgvTransaksiHariIni.RowHeadersVisible = false;
            dgvTransaksiHariIni.RowHeadersWidth = 62;
            dgvTransaksiHariIni.SelectionMode = DataGridViewSelectionMode.FullColumnSelect;
            dgvTransaksiHariIni.Size = new Size(705, 316);
            dgvTransaksiHariIni.TabIndex = 7;
            // 
            // roundedPanel6
            // 
            roundedPanel6.BackColor = Color.Transparent;
            roundedPanel6.Controls.Add(dgvTransaksiHariIni);
            roundedPanel6.Location = new Point(32, 233);
            roundedPanel6.Name = "roundedPanel6";
            roundedPanel6.Size = new Size(739, 353);
            roundedPanel6.TabIndex = 8;
            // 
            // colNoTransaksi
            // 
            colNoTransaksi.HeaderText = "No Transaksi";
            colNoTransaksi.MinimumWidth = 8;
            colNoTransaksi.Name = "colNoTransaksi";
            colNoTransaksi.ReadOnly = true;
            colNoTransaksi.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colWaktu
            // 
            colWaktu.HeaderText = "Waktu";
            colWaktu.MinimumWidth = 8;
            colWaktu.Name = "colWaktu";
            colWaktu.ReadOnly = true;
            colWaktu.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colKasir
            // 
            colKasir.HeaderText = "Kasir";
            colKasir.MinimumWidth = 8;
            colKasir.Name = "colKasir";
            colKasir.ReadOnly = true;
            colKasir.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colTotal
            // 
            colTotal.HeaderText = "Total";
            colTotal.MinimumWidth = 8;
            colTotal.Name = "colTotal";
            colTotal.ReadOnly = true;
            colTotal.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // UC_DSHBRDKasir
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "UC_DSHBRDKasir";
            Size = new Size(1432, 602);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            roundedPanel1.ResumeLayout(false);
            roundedPanel2.ResumeLayout(false);
            roundedPanel2.PerformLayout();
            roundedPanel3.ResumeLayout(false);
            roundedPanel3.PerformLayout();
            roundedPanel4.ResumeLayout(false);
            roundedPanel4.PerformLayout();
            roundedPanel5.ResumeLayout(false);
            roundedPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTransaksiHariIni).EndInit();
            roundedPanel6.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private RoundedPanel roundedPanel1;
        private RoundedPanel roundedPanel2;
        private Label label2;
        private RoundedPanel roundedPanel4;
        private RoundedPanel roundedPanel3;
        private RoundedPanel roundedPanel5;
        private Label lblTotalPendapatan;
        private Label label1;
        private Label label4;
        private Label lblItemdiKeranjang;
        private Label label5;
        private Label lblItemTerjual;
        private Label label3;
        private Label lblJumlahTransaksi;
        private Label CV;
        private DataGridView dgvTransaksiHariIni;
        private RoundedPanel roundedPanel6;
        private DataGridViewTextBoxColumn colNoTransaksi;
        private DataGridViewTextBoxColumn colWaktu;
        private DataGridViewTextBoxColumn colKasir;
        private DataGridViewTextBoxColumn colTotal;
    }
}
