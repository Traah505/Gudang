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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            panel1 = new Panel();
            panelRounded1 = new PanelRounded();
            roundedPanel6 = new RoundedPanel();
            dgvTransaksi = new DataGridView();
            colNoTransaksi = new DataGridViewTextBoxColumn();
            colWaktu = new DataGridViewTextBoxColumn();
            colKasir = new DataGridViewTextBoxColumn();
            colTotal = new DataGridViewTextBoxColumn();
            roundedPanel1 = new RoundedPanel();
            roundedPanel5 = new RoundedPanel();
            lblItemKeranjang = new Label();
            label5 = new Label();
            roundedPanel4 = new RoundedPanel();
            lblItemTerjual = new Label();
            label3 = new Label();
            roundedPanel3 = new RoundedPanel();
            lblJumlahTransaksi = new Label();
            CV = new Label();
            roundedPanel2 = new RoundedPanel();
            label4 = new Label();
            lblPendapatan = new Label();
            label1 = new Label();
            label2 = new Label();
            label6 = new Label();
            lblKeranjangItem = new Label();
            label8 = new Label();
            label9 = new Label();
            lblKeranjangTotal = new Label();
            label11 = new Label();
            label12 = new Label();
            panel1.SuspendLayout();
            panelRounded1.SuspendLayout();
            roundedPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTransaksi).BeginInit();
            roundedPanel1.SuspendLayout();
            roundedPanel5.SuspendLayout();
            roundedPanel4.SuspendLayout();
            roundedPanel3.SuspendLayout();
            roundedPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panelRounded1);
            panel1.Controls.Add(roundedPanel6);
            panel1.Controls.Add(roundedPanel1);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(2, 2);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1000, 385);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // panelRounded1
            // 
            panelRounded1.BackColor = Color.Transparent;
            panelRounded1.Controls.Add(label11);
            panelRounded1.Controls.Add(lblKeranjangTotal);
            panelRounded1.Controls.Add(label9);
            panelRounded1.Controls.Add(label8);
            panelRounded1.Controls.Add(lblKeranjangItem);
            panelRounded1.Controls.Add(label6);
            panelRounded1.Location = new Point(570, 140);
            panelRounded1.Name = "panelRounded1";
            panelRounded1.Size = new Size(404, 210);
            panelRounded1.TabIndex = 9;
            // 
            // roundedPanel6
            // 
            roundedPanel6.BackColor = Color.Transparent;
            roundedPanel6.Controls.Add(label12);
            roundedPanel6.Controls.Add(dgvTransaksi);
            roundedPanel6.Location = new Point(22, 140);
            roundedPanel6.Margin = new Padding(2);
            roundedPanel6.Name = "roundedPanel6";
            roundedPanel6.Size = new Size(517, 212);
            roundedPanel6.TabIndex = 8;
            // 
            // dgvTransaksi
            // 
            dgvTransaksi.AllowUserToAddRows = false;
            dataGridViewCellStyle4.BackColor = Color.AliceBlue;
            dgvTransaksi.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvTransaksi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTransaksi.BackgroundColor = Color.White;
            dgvTransaksi.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.RoyalBlue;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvTransaksi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvTransaksi.ColumnHeadersHeight = 34;
            dgvTransaksi.Columns.AddRange(new DataGridViewColumn[] { colNoTransaksi, colWaktu, colKasir, colTotal });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = Color.Gray;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvTransaksi.DefaultCellStyle = dataGridViewCellStyle6;
            dgvTransaksi.EnableHeadersVisualStyles = false;
            dgvTransaksi.Location = new Point(12, 34);
            dgvTransaksi.Margin = new Padding(2);
            dgvTransaksi.MultiSelect = false;
            dgvTransaksi.Name = "dgvTransaksi";
            dgvTransaksi.ReadOnly = true;
            dgvTransaksi.RowHeadersVisible = false;
            dgvTransaksi.RowHeadersWidth = 62;
            dgvTransaksi.SelectionMode = DataGridViewSelectionMode.FullColumnSelect;
            dgvTransaksi.Size = new Size(494, 150);
            dgvTransaksi.TabIndex = 7;
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
            // roundedPanel1
            // 
            roundedPanel1.BackColor = Color.Transparent;
            roundedPanel1.Controls.Add(roundedPanel5);
            roundedPanel1.Controls.Add(roundedPanel4);
            roundedPanel1.Controls.Add(roundedPanel3);
            roundedPanel1.Controls.Add(roundedPanel2);
            roundedPanel1.Location = new Point(21, 37);
            roundedPanel1.Margin = new Padding(2);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Size = new Size(965, 92);
            roundedPanel1.TabIndex = 6;
            // 
            // roundedPanel5
            // 
            roundedPanel5.BackColor = Color.Transparent;
            roundedPanel5.Controls.Add(lblItemKeranjang);
            roundedPanel5.Controls.Add(label5);
            roundedPanel5.Location = new Point(727, 13);
            roundedPanel5.Margin = new Padding(2);
            roundedPanel5.Name = "roundedPanel5";
            roundedPanel5.Size = new Size(226, 63);
            roundedPanel5.TabIndex = 3;
            // 
            // lblItemKeranjang
            // 
            lblItemKeranjang.AutoSize = true;
            lblItemKeranjang.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblItemKeranjang.ForeColor = Color.DarkGoldenrod;
            lblItemKeranjang.Location = new Point(22, 23);
            lblItemKeranjang.Margin = new Padding(2, 0, 2, 0);
            lblItemKeranjang.Name = "lblItemKeranjang";
            lblItemKeranjang.Size = new Size(26, 30);
            lblItemKeranjang.TabIndex = 5;
            lblItemKeranjang.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.DimGray;
            label5.Location = new Point(22, 8);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(100, 15);
            label5.TabIndex = 5;
            label5.Text = "Item di Keranjang";
            // 
            // roundedPanel4
            // 
            roundedPanel4.BackColor = Color.Transparent;
            roundedPanel4.Controls.Add(lblItemTerjual);
            roundedPanel4.Controls.Add(label3);
            roundedPanel4.Location = new Point(489, 13);
            roundedPanel4.Margin = new Padding(2);
            roundedPanel4.Name = "roundedPanel4";
            roundedPanel4.Size = new Size(226, 63);
            roundedPanel4.TabIndex = 2;
            // 
            // lblItemTerjual
            // 
            lblItemTerjual.AutoSize = true;
            lblItemTerjual.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblItemTerjual.ForeColor = Color.MediumPurple;
            lblItemTerjual.Location = new Point(17, 23);
            lblItemTerjual.Margin = new Padding(2, 0, 2, 0);
            lblItemTerjual.Name = "lblItemTerjual";
            lblItemTerjual.Size = new Size(26, 30);
            lblItemTerjual.TabIndex = 4;
            lblItemTerjual.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.DimGray;
            label3.Location = new Point(17, 8);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(68, 15);
            label3.TabIndex = 4;
            label3.Text = "Item Terjual";
            // 
            // roundedPanel3
            // 
            roundedPanel3.BackColor = Color.Transparent;
            roundedPanel3.Controls.Add(lblJumlahTransaksi);
            roundedPanel3.Controls.Add(CV);
            roundedPanel3.Location = new Point(251, 13);
            roundedPanel3.Margin = new Padding(2);
            roundedPanel3.Name = "roundedPanel3";
            roundedPanel3.Size = new Size(226, 63);
            roundedPanel3.TabIndex = 1;
            // 
            // lblJumlahTransaksi
            // 
            lblJumlahTransaksi.AutoSize = true;
            lblJumlahTransaksi.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblJumlahTransaksi.ForeColor = Color.SeaGreen;
            lblJumlahTransaksi.Location = new Point(19, 23);
            lblJumlahTransaksi.Margin = new Padding(2, 0, 2, 0);
            lblJumlahTransaksi.Name = "lblJumlahTransaksi";
            lblJumlahTransaksi.Size = new Size(26, 30);
            lblJumlahTransaksi.TabIndex = 3;
            lblJumlahTransaksi.Text = "0";
            // 
            // CV
            // 
            CV.AutoSize = true;
            CV.ForeColor = Color.DimGray;
            CV.Location = new Point(19, 8);
            CV.Margin = new Padding(2, 0, 2, 0);
            CV.Name = "CV";
            CV.Size = new Size(95, 15);
            CV.TabIndex = 3;
            CV.Text = "Jumlah Transaksi";
            // 
            // roundedPanel2
            // 
            roundedPanel2.BackColor = Color.Transparent;
            roundedPanel2.Controls.Add(label4);
            roundedPanel2.Controls.Add(lblPendapatan);
            roundedPanel2.Controls.Add(label1);
            roundedPanel2.Location = new Point(13, 13);
            roundedPanel2.Margin = new Padding(2);
            roundedPanel2.Name = "roundedPanel2";
            roundedPanel2.Size = new Size(226, 63);
            roundedPanel2.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.RoyalBlue;
            label4.Location = new Point(14, 23);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(41, 30);
            label4.TabIndex = 2;
            label4.Text = "Rp";
            // 
            // lblPendapatan
            // 
            lblPendapatan.AutoSize = true;
            lblPendapatan.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPendapatan.ForeColor = Color.RoyalBlue;
            lblPendapatan.Location = new Point(52, 23);
            lblPendapatan.Margin = new Padding(2, 0, 2, 0);
            lblPendapatan.Name = "lblPendapatan";
            lblPendapatan.Size = new Size(26, 30);
            lblPendapatan.TabIndex = 1;
            lblPendapatan.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(16, 8);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(98, 15);
            label1.TabIndex = 0;
            label1.Text = "Total Pendapatan";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.MidnightBlue;
            label2.Location = new Point(13, 12);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(163, 27);
            label2.TabIndex = 5;
            label2.Text = "Dashboard Kasir";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.HotPink;
            label6.Location = new Point(17, 10);
            label6.Name = "label6";
            label6.Size = new Size(209, 21);
            label6.TabIndex = 0;
            label6.Text = "Keranjang Belanja Hari Ini";
            // 
            // lblKeranjangItem
            // 
            lblKeranjangItem.AutoSize = true;
            lblKeranjangItem.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblKeranjangItem.ForeColor = Color.HotPink;
            lblKeranjangItem.Location = new Point(17, 142);
            lblKeranjangItem.Margin = new Padding(2, 0, 2, 0);
            lblKeranjangItem.Name = "lblKeranjangItem";
            lblKeranjangItem.Size = new Size(26, 30);
            lblKeranjangItem.TabIndex = 5;
            lblKeranjangItem.Text = "0";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.DimGray;
            label8.Location = new Point(17, 127);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(34, 15);
            label8.TabIndex = 5;
            label8.Text = "Item ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.HotPink;
            label9.Location = new Point(200, 142);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(41, 30);
            label9.TabIndex = 6;
            label9.Text = "Rp";
            // 
            // lblKeranjangTotal
            // 
            lblKeranjangTotal.AutoSize = true;
            lblKeranjangTotal.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblKeranjangTotal.ForeColor = Color.HotPink;
            lblKeranjangTotal.Location = new Point(233, 142);
            lblKeranjangTotal.Margin = new Padding(2, 0, 2, 0);
            lblKeranjangTotal.Name = "lblKeranjangTotal";
            lblKeranjangTotal.Size = new Size(26, 30);
            lblKeranjangTotal.TabIndex = 7;
            lblKeranjangTotal.Text = "0";
            lblKeranjangTotal.Click += label10_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = Color.DimGray;
            label11.Location = new Point(200, 127);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(73, 15);
            label11.TabIndex = 8;
            label11.Text = "Total Belanja";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Calibri", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.MidnightBlue;
            label12.Location = new Point(26, 4);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(178, 27);
            label12.TabIndex = 10;
            label12.Text = "Keranjang Belanja";
            // 
            // UC_DSHBRDKasir
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Margin = new Padding(2);
            Name = "UC_DSHBRDKasir";
            Size = new Size(1002, 361);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelRounded1.ResumeLayout(false);
            panelRounded1.PerformLayout();
            roundedPanel6.ResumeLayout(false);
            roundedPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTransaksi).EndInit();
            roundedPanel1.ResumeLayout(false);
            roundedPanel5.ResumeLayout(false);
            roundedPanel5.PerformLayout();
            roundedPanel4.ResumeLayout(false);
            roundedPanel4.PerformLayout();
            roundedPanel3.ResumeLayout(false);
            roundedPanel3.PerformLayout();
            roundedPanel2.ResumeLayout(false);
            roundedPanel2.PerformLayout();
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
        private Label lblPendapatan;
        private Label label1;
        private Label label4;
        private Label lblItemKeranjang;
        private Label label5;
        private Label lblItemTerjual;
        private Label label3;
        private Label lblJumlahTransaksi;
        private Label CV;
        private DataGridView dgvTransaksi;
        private RoundedPanel roundedPanel6;
        private DataGridViewTextBoxColumn colNoTransaksi;
        private DataGridViewTextBoxColumn colWaktu;
        private DataGridViewTextBoxColumn colKasir;
        private DataGridViewTextBoxColumn colTotal;
        private PanelRounded panelRounded1;
        private Label label6;
        private Label lblKeranjangTotal;
        private Label label9;
        private Label label8;
        private Label lblKeranjangItem;
        private Label label11;
        private Label label12;
    }
}
