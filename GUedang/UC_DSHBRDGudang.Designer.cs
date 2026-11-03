namespace GUedang
{
    partial class UC_DSHBRDGudang
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_DSHBRDGudang));
            roundedPanel1 = new RoundedPanel();
            roundedPanel6 = new RoundedPanel();
            dgvBarangStokMenipis = new DataGridView();
            colNo = new DataGridViewTextBoxColumn();
            colNamaBarang = new DataGridViewTextBoxColumn();
            colStok = new DataGridViewTextBoxColumn();
            label8 = new Label();
            panelGrafikStok = new RoundedPanel();
            chartStokBarang = new System.Windows.Forms.DataVisualization.Charting.Chart();
            label7 = new Label();
            roundedPanel5 = new RoundedPanel();
            lblAngkaMenipis = new Label();
            label6 = new Label();
            roundedPanel4 = new RoundedPanel();
            lblAngkaKeluar = new Label();
            label5 = new Label();
            roundedPanel3 = new RoundedPanel();
            lblAngkaMasuk = new Label();
            label4 = new Label();
            roundedPanel2 = new RoundedPanel();
            label3 = new Label();
            lblAngkaTotal = new Label();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            roundedPanel1.SuspendLayout();
            roundedPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBarangStokMenipis).BeginInit();
            panelGrafikStok.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartStokBarang).BeginInit();
            roundedPanel5.SuspendLayout();
            roundedPanel4.SuspendLayout();
            roundedPanel3.SuspendLayout();
            roundedPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // roundedPanel1
            // 
            roundedPanel1.BackColor = Color.Transparent;
            roundedPanel1.Controls.Add(roundedPanel6);
            roundedPanel1.Controls.Add(panelGrafikStok);
            roundedPanel1.Controls.Add(roundedPanel5);
            roundedPanel1.Controls.Add(roundedPanel4);
            roundedPanel1.Controls.Add(roundedPanel3);
            roundedPanel1.Controls.Add(roundedPanel2);
            roundedPanel1.Controls.Add(pictureBox2);
            roundedPanel1.Controls.Add(label2);
            roundedPanel1.Controls.Add(label1);
            roundedPanel1.Location = new Point(2, 2);
            roundedPanel1.Margin = new Padding(2);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Size = new Size(657, 352);
            roundedPanel1.TabIndex = 0;
            // 
            // roundedPanel6
            // 
            roundedPanel6.BackColor = Color.Transparent;
            roundedPanel6.BorderStyle = BorderStyle.FixedSingle;
            roundedPanel6.Controls.Add(dgvBarangStokMenipis);
            roundedPanel6.Controls.Add(label8);
            roundedPanel6.Location = new Point(335, 134);
            roundedPanel6.Margin = new Padding(2);
            roundedPanel6.Name = "roundedPanel6";
            roundedPanel6.Size = new Size(304, 197);
            roundedPanel6.TabIndex = 11;
            // 
            // dgvBarangStokMenipis
            // 
            dgvBarangStokMenipis.AllowUserToAddRows = false;
            dgvBarangStokMenipis.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBarangStokMenipis.BackgroundColor = Color.White;
            dgvBarangStokMenipis.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.MidnightBlue;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvBarangStokMenipis.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvBarangStokMenipis.ColumnHeadersHeight = 40;
            dgvBarangStokMenipis.Columns.AddRange(new DataGridViewColumn[] { colNo, colNamaBarang, colStok });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.DimGray;
            dataGridViewCellStyle2.Padding = new Padding(6);
            dataGridViewCellStyle2.SelectionBackColor = Color.AliceBlue;
            dataGridViewCellStyle2.SelectionForeColor = Color.MidnightBlue;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvBarangStokMenipis.DefaultCellStyle = dataGridViewCellStyle2;
            dgvBarangStokMenipis.EnableHeadersVisualStyles = false;
            dgvBarangStokMenipis.Location = new Point(2, 27);
            dgvBarangStokMenipis.Margin = new Padding(2);
            dgvBarangStokMenipis.Name = "dgvBarangStokMenipis";
            dgvBarangStokMenipis.ReadOnly = true;
            dgvBarangStokMenipis.RowHeadersVisible = false;
            dgvBarangStokMenipis.RowHeadersWidth = 62;
            dgvBarangStokMenipis.RowTemplate.Height = 38;
            dgvBarangStokMenipis.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBarangStokMenipis.Size = new Size(285, 167);
            dgvBarangStokMenipis.TabIndex = 5;
            // 
            // colNo
            // 
            colNo.FillWeight = 40F;
            colNo.HeaderText = "No";
            colNo.MinimumWidth = 8;
            colNo.Name = "colNo";
            colNo.ReadOnly = true;
            // 
            // colNamaBarang
            // 
            colNamaBarang.FillWeight = 130F;
            colNamaBarang.HeaderText = "Nama Barang";
            colNamaBarang.MinimumWidth = 8;
            colNamaBarang.Name = "colNamaBarang";
            colNamaBarang.ReadOnly = true;
            // 
            // colStok
            // 
            colStok.FillWeight = 50F;
            colStok.HeaderText = "Stok";
            colStok.MinimumWidth = 8;
            colStok.Name = "colStok";
            colStok.ReadOnly = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(2, 7);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(150, 20);
            label8.TabIndex = 4;
            label8.Text = "Barang Stok Menipis";
            // 
            // panelGrafikStok
            // 
            panelGrafikStok.BackColor = Color.Transparent;
            panelGrafikStok.Controls.Add(chartStokBarang);
            panelGrafikStok.Controls.Add(label7);
            panelGrafikStok.Location = new Point(17, 134);
            panelGrafikStok.Margin = new Padding(2);
            panelGrafikStok.Name = "panelGrafikStok";
            panelGrafikStok.Size = new Size(304, 198);
            panelGrafikStok.TabIndex = 10;
            // 
            // chartStokBarang
            // 
            chartArea1.Name = "ChartArea1";
            chartStokBarang.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartStokBarang.Legends.Add(legend1);
            chartStokBarang.Location = new Point(2, 27);
            chartStokBarang.Margin = new Padding(2);
            chartStokBarang.Name = "chartStokBarang";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Stok Barang";
            chartStokBarang.Series.Add(series1);
            chartStokBarang.Size = new Size(300, 169);
            chartStokBarang.TabIndex = 3;
            chartStokBarang.Text = "chart1";
            chartStokBarang.Click += chartStokBarang_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(13, 7);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(137, 20);
            label7.TabIndex = 2;
            label7.Text = "Grafik Stok Barang";
            // 
            // roundedPanel5
            // 
            roundedPanel5.BackColor = Color.Transparent;
            roundedPanel5.Controls.Add(lblAngkaMenipis);
            roundedPanel5.Controls.Add(label6);
            roundedPanel5.Location = new Point(414, 57);
            roundedPanel5.Margin = new Padding(2);
            roundedPanel5.Name = "roundedPanel5";
            roundedPanel5.Size = new Size(128, 64);
            roundedPanel5.TabIndex = 9;
            // 
            // lblAngkaMenipis
            // 
            lblAngkaMenipis.AutoSize = true;
            lblAngkaMenipis.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAngkaMenipis.ForeColor = Color.White;
            lblAngkaMenipis.Location = new Point(8, 28);
            lblAngkaMenipis.Margin = new Padding(2, 0, 2, 0);
            lblAngkaMenipis.Name = "lblAngkaMenipis";
            lblAngkaMenipis.Size = new Size(27, 32);
            lblAngkaMenipis.TabIndex = 4;
            lblAngkaMenipis.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(8, 10);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(97, 20);
            label6.TabIndex = 3;
            label6.Text = "Stok Menipis";
            // 
            // roundedPanel4
            // 
            roundedPanel4.BackColor = Color.Transparent;
            roundedPanel4.Controls.Add(lblAngkaKeluar);
            roundedPanel4.Controls.Add(label5);
            roundedPanel4.Location = new Point(282, 57);
            roundedPanel4.Margin = new Padding(2);
            roundedPanel4.Name = "roundedPanel4";
            roundedPanel4.Size = new Size(128, 64);
            roundedPanel4.TabIndex = 8;
            // 
            // lblAngkaKeluar
            // 
            lblAngkaKeluar.AutoSize = true;
            lblAngkaKeluar.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAngkaKeluar.ForeColor = Color.White;
            lblAngkaKeluar.Location = new Point(10, 28);
            lblAngkaKeluar.Margin = new Padding(2, 0, 2, 0);
            lblAngkaKeluar.Name = "lblAngkaKeluar";
            lblAngkaKeluar.Size = new Size(27, 32);
            lblAngkaKeluar.TabIndex = 3;
            lblAngkaKeluar.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(10, 10);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(106, 20);
            label5.TabIndex = 2;
            label5.Text = "Barang Keluar";
            // 
            // roundedPanel3
            // 
            roundedPanel3.BackColor = Color.RoyalBlue;
            roundedPanel3.Controls.Add(lblAngkaMasuk);
            roundedPanel3.Controls.Add(label4);
            roundedPanel3.Location = new Point(149, 57);
            roundedPanel3.Margin = new Padding(2);
            roundedPanel3.Name = "roundedPanel3";
            roundedPanel3.Size = new Size(128, 64);
            roundedPanel3.TabIndex = 7;
            // 
            // lblAngkaMasuk
            // 
            lblAngkaMasuk.AutoSize = true;
            lblAngkaMasuk.BackColor = Color.DarkBlue;
            lblAngkaMasuk.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAngkaMasuk.ForeColor = Color.White;
            lblAngkaMasuk.Location = new Point(10, 28);
            lblAngkaMasuk.Margin = new Padding(2, 0, 2, 0);
            lblAngkaMasuk.Name = "lblAngkaMasuk";
            lblAngkaMasuk.Size = new Size(27, 32);
            lblAngkaMasuk.TabIndex = 2;
            lblAngkaMasuk.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.DarkBlue;
            label4.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(10, 10);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(107, 20);
            label4.TabIndex = 1;
            label4.Text = "Barang Masuk";
            // 
            // roundedPanel2
            // 
            roundedPanel2.BackColor = Color.Transparent;
            roundedPanel2.Controls.Add(label3);
            roundedPanel2.Controls.Add(lblAngkaTotal);
            roundedPanel2.Font = new Font("Segoe UI", 11F);
            roundedPanel2.ForeColor = Color.White;
            roundedPanel2.Location = new Point(17, 57);
            roundedPanel2.Margin = new Padding(2);
            roundedPanel2.Name = "roundedPanel2";
            roundedPanel2.Size = new Size(128, 64);
            roundedPanel2.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label3.Location = new Point(13, 10);
            label3.Name = "label3";
            label3.Size = new Size(95, 20);
            label3.TabIndex = 2;
            label3.Text = "Total Barang";
            // 
            // lblAngkaTotal
            // 
            lblAngkaTotal.AutoSize = true;
            lblAngkaTotal.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAngkaTotal.ForeColor = Color.White;
            lblAngkaTotal.Location = new Point(13, 28);
            lblAngkaTotal.Margin = new Padding(2, 0, 2, 0);
            lblAngkaTotal.Name = "lblAngkaTotal";
            lblAngkaTotal.Size = new Size(27, 32);
            lblAngkaTotal.TabIndex = 1;
            lblAngkaTotal.Text = "0";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(548, 13);
            pictureBox2.Margin = new Padding(2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(22, 21);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(574, 13);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(63, 20);
            label2.TabIndex = 1;
            label2.Text = "Gudang";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(17, 13);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(204, 30);
            label1.TabIndex = 0;
            label1.Text = "Dashboard Gudang";
            // 
            // UC_DSHBRDGudang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(roundedPanel1);
            Name = "UC_DSHBRDGudang";
            Size = new Size(672, 365);
            Load += UC_DSHBRDGudang_Load;
            roundedPanel1.ResumeLayout(false);
            roundedPanel1.PerformLayout();
            roundedPanel6.ResumeLayout(false);
            roundedPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBarangStokMenipis).EndInit();
            panelGrafikStok.ResumeLayout(false);
            panelGrafikStok.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartStokBarang).EndInit();
            roundedPanel5.ResumeLayout(false);
            roundedPanel5.PerformLayout();
            roundedPanel4.ResumeLayout(false);
            roundedPanel4.PerformLayout();
            roundedPanel3.ResumeLayout(false);
            roundedPanel3.PerformLayout();
            roundedPanel2.ResumeLayout(false);
            roundedPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private RoundedPanel roundedPanel1;
        private Label label2;
        private Label label1;
        private RoundedPanel roundedPanel4;
        private RoundedPanel roundedPanel3;
        private RoundedPanel roundedPanel2;
        private PictureBox pictureBox2;
        private RoundedPanel roundedPanel5;
        private Label label6;
        private Label label5;
        private Label label4;
        private RoundedPanel panelGrafikStok;
        private Label lblAngkaMenipis;
        private Label lblAngkaKeluar;
        private Label lblAngkaMasuk;
        private Label lblAngkaTotal;
        private Label label7;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartStokBarang;
        private RoundedPanel roundedPanel6;
        private DataGridView dgvBarangStokMenipis;
        private Label label8;
        private DataGridViewTextBoxColumn colNo;
        private DataGridViewTextBoxColumn colNamaBarang;
        private DataGridViewTextBoxColumn colStok;
        private Label label3;
    }
}
