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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            roundedPanel1 = new RoundedPanel();
            roundedPanel8 = new RoundedPanel();
            dgvPerhatian = new DataGridView();
            label6 = new Label();
            roundedPanel3 = new RoundedPanel();
            label4 = new Label();
            dgvAktivitas = new DataGridView();
            colWaktu = new DataGridViewTextBoxColumn();
            colJenis = new DataGridViewTextBoxColumn();
            colNamaBarang = new DataGridViewTextBoxColumn();
            colJumlah = new DataGridViewTextBoxColumn();
            colStokAkhir = new DataGridViewTextBoxColumn();
            roundedPanel2 = new RoundedPanel();
            roundedPanel5 = new RoundedPanel();
            lblPerluPerhatian = new Label();
            label5 = new Label();
            roundedPanel4 = new RoundedPanel();
            lblStokSaatIni = new Label();
            label3 = new Label();
            roundedPanel6 = new RoundedPanel();
            lblKeluarHariIni = new Label();
            CV = new Label();
            roundedPanel7 = new RoundedPanel();
            lblMasukHariIni = new Label();
            label2 = new Label();
            label1 = new Label();
            roundedPanel1.SuspendLayout();
            roundedPanel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPerhatian).BeginInit();
            roundedPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAktivitas).BeginInit();
            roundedPanel2.SuspendLayout();
            roundedPanel5.SuspendLayout();
            roundedPanel4.SuspendLayout();
            roundedPanel6.SuspendLayout();
            roundedPanel7.SuspendLayout();
            SuspendLayout();
            // 
            // roundedPanel1
            // 
            roundedPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            roundedPanel1.BackColor = Color.Transparent;
            roundedPanel1.Controls.Add(roundedPanel8);
            roundedPanel1.Controls.Add(roundedPanel3);
            roundedPanel1.Controls.Add(roundedPanel2);
            roundedPanel1.Controls.Add(label1);
            roundedPanel1.Location = new Point(2, 2);
            roundedPanel1.Margin = new Padding(2, 2, 2, 2);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Size = new Size(970, 352);
            roundedPanel1.TabIndex = 0;
            roundedPanel1.Paint += roundedPanel1_Paint;
            // 
            // roundedPanel8
            // 
            roundedPanel8.BackColor = Color.Transparent;
            roundedPanel8.Controls.Add(dgvPerhatian);
            roundedPanel8.Controls.Add(label6);
            roundedPanel8.Location = new Point(466, 150);
            roundedPanel8.Margin = new Padding(2, 2, 2, 2);
            roundedPanel8.Name = "roundedPanel8";
            roundedPanel8.Size = new Size(472, 157);
            roundedPanel8.TabIndex = 10;
            // 
            // dgvPerhatian
            // 
            dgvPerhatian.AllowUserToAddRows = false;
            dgvPerhatian.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPerhatian.BackgroundColor = Color.White;
            dgvPerhatian.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvPerhatian.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPerhatian.ColumnHeadersVisible = false;
            dgvPerhatian.Location = new Point(19, 22);
            dgvPerhatian.Margin = new Padding(2, 2, 2, 2);
            dgvPerhatian.Name = "dgvPerhatian";
            dgvPerhatian.ReadOnly = true;
            dgvPerhatian.RowHeadersVisible = false;
            dgvPerhatian.RowHeadersWidth = 62;
            dgvPerhatian.Size = new Size(444, 124);
            dgvPerhatian.TabIndex = 4;
            dgvPerhatian.CellContentClick += dgvPerhatian_CellContentClick;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(13, 5);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(114, 15);
            label6.TabIndex = 3;
            label6.Text = "Stok Perlu Perhatian";
            // 
            // roundedPanel3
            // 
            roundedPanel3.BackColor = Color.Transparent;
            roundedPanel3.Controls.Add(label4);
            roundedPanel3.Controls.Add(dgvAktivitas);
            roundedPanel3.Location = new Point(18, 150);
            roundedPanel3.Margin = new Padding(2, 2, 2, 2);
            roundedPanel3.Name = "roundedPanel3";
            roundedPanel3.Size = new Size(390, 202);
            roundedPanel3.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(13, 5);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(138, 15);
            label4.TabIndex = 2;
            label4.Text = "Aktivitas Gudang Hari ini";
            // 
            // dgvAktivitas
            // 
            dgvAktivitas.AllowUserToAddRows = false;
            dgvAktivitas.AllowUserToDeleteRows = false;
            dgvAktivitas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dgvAktivitas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAktivitas.BackgroundColor = Color.White;
            dgvAktivitas.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.RoyalBlue;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.AliceBlue;
            dataGridViewCellStyle5.SelectionBackColor = Color.AliceBlue;
            dataGridViewCellStyle5.SelectionForeColor = Color.MidnightBlue;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvAktivitas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvAktivitas.ColumnHeadersHeight = 35;
            dgvAktivitas.Columns.AddRange(new DataGridViewColumn[] { colWaktu, colJenis, colNamaBarang, colJumlah, colStokAkhir });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = Color.SlateGray;
            dataGridViewCellStyle6.SelectionBackColor = Color.LightSteelBlue;
            dataGridViewCellStyle6.SelectionForeColor = Color.MidnightBlue;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvAktivitas.DefaultCellStyle = dataGridViewCellStyle6;
            dgvAktivitas.EnableHeadersVisualStyles = false;
            dgvAktivitas.Location = new Point(13, 22);
            dgvAktivitas.Margin = new Padding(2, 2, 2, 2);
            dgvAktivitas.MultiSelect = false;
            dgvAktivitas.Name = "dgvAktivitas";
            dgvAktivitas.ReadOnly = true;
            dgvAktivitas.RowHeadersVisible = false;
            dgvAktivitas.RowHeadersWidth = 62;
            dgvAktivitas.RowTemplate.Height = 38;
            dgvAktivitas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAktivitas.Size = new Size(367, 169);
            dgvAktivitas.TabIndex = 0;
            // 
            // colWaktu
            // 
            colWaktu.HeaderText = "Waktu";
            colWaktu.MinimumWidth = 8;
            colWaktu.Name = "colWaktu";
            colWaktu.ReadOnly = true;
            colWaktu.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colJenis
            // 
            colJenis.HeaderText = "Jenis";
            colJenis.MinimumWidth = 8;
            colJenis.Name = "colJenis";
            colJenis.ReadOnly = true;
            colJenis.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colNamaBarang
            // 
            colNamaBarang.HeaderText = "Nama Barang";
            colNamaBarang.MinimumWidth = 8;
            colNamaBarang.Name = "colNamaBarang";
            colNamaBarang.ReadOnly = true;
            colNamaBarang.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colJumlah
            // 
            colJumlah.HeaderText = "Jumlah";
            colJumlah.MinimumWidth = 8;
            colJumlah.Name = "colJumlah";
            colJumlah.ReadOnly = true;
            colJumlah.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colStokAkhir
            // 
            colStokAkhir.HeaderText = "Stok Akhir";
            colStokAkhir.MinimumWidth = 8;
            colStokAkhir.Name = "colStokAkhir";
            colStokAkhir.ReadOnly = true;
            colStokAkhir.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // roundedPanel2
            // 
            roundedPanel2.BackColor = Color.Transparent;
            roundedPanel2.Controls.Add(roundedPanel5);
            roundedPanel2.Controls.Add(roundedPanel4);
            roundedPanel2.Controls.Add(roundedPanel6);
            roundedPanel2.Controls.Add(roundedPanel7);
            roundedPanel2.Location = new Point(2, 42);
            roundedPanel2.Margin = new Padding(2, 2, 2, 2);
            roundedPanel2.Name = "roundedPanel2";
            roundedPanel2.Size = new Size(965, 92);
            roundedPanel2.TabIndex = 8;
            // 
            // roundedPanel5
            // 
            roundedPanel5.BackColor = Color.Transparent;
            roundedPanel5.Controls.Add(lblPerluPerhatian);
            roundedPanel5.Controls.Add(label5);
            roundedPanel5.Location = new Point(727, 13);
            roundedPanel5.Margin = new Padding(2, 2, 2, 2);
            roundedPanel5.Name = "roundedPanel5";
            roundedPanel5.Size = new Size(226, 63);
            roundedPanel5.TabIndex = 3;
            // 
            // lblPerluPerhatian
            // 
            lblPerluPerhatian.AutoSize = true;
            lblPerluPerhatian.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPerluPerhatian.ForeColor = Color.MediumPurple;
            lblPerluPerhatian.Location = new Point(22, 23);
            lblPerluPerhatian.Margin = new Padding(2, 0, 2, 0);
            lblPerluPerhatian.Name = "lblPerluPerhatian";
            lblPerluPerhatian.Size = new Size(26, 30);
            lblPerluPerhatian.TabIndex = 5;
            lblPerluPerhatian.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.DimGray;
            label5.Location = new Point(22, 8);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(87, 15);
            label5.TabIndex = 5;
            label5.Text = "Perlu Perhatian";
            // 
            // roundedPanel4
            // 
            roundedPanel4.BackColor = Color.Transparent;
            roundedPanel4.Controls.Add(lblStokSaatIni);
            roundedPanel4.Controls.Add(label3);
            roundedPanel4.Location = new Point(489, 13);
            roundedPanel4.Margin = new Padding(2, 2, 2, 2);
            roundedPanel4.Name = "roundedPanel4";
            roundedPanel4.Size = new Size(226, 63);
            roundedPanel4.TabIndex = 2;
            // 
            // lblStokSaatIni
            // 
            lblStokSaatIni.AutoSize = true;
            lblStokSaatIni.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStokSaatIni.ForeColor = Color.LightSeaGreen;
            lblStokSaatIni.Location = new Point(17, 23);
            lblStokSaatIni.Margin = new Padding(2, 0, 2, 0);
            lblStokSaatIni.Name = "lblStokSaatIni";
            lblStokSaatIni.Size = new Size(26, 30);
            lblStokSaatIni.TabIndex = 4;
            lblStokSaatIni.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.DimGray;
            label3.Location = new Point(17, 8);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(71, 15);
            label3.TabIndex = 4;
            label3.Text = "Stok Saat Ini";
            // 
            // roundedPanel6
            // 
            roundedPanel6.BackColor = Color.Transparent;
            roundedPanel6.Controls.Add(lblKeluarHariIni);
            roundedPanel6.Controls.Add(CV);
            roundedPanel6.Location = new Point(251, 13);
            roundedPanel6.Margin = new Padding(2, 2, 2, 2);
            roundedPanel6.Name = "roundedPanel6";
            roundedPanel6.Size = new Size(226, 63);
            roundedPanel6.TabIndex = 1;
            // 
            // lblKeluarHariIni
            // 
            lblKeluarHariIni.AutoSize = true;
            lblKeluarHariIni.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblKeluarHariIni.ForeColor = Color.SpringGreen;
            lblKeluarHariIni.Location = new Point(19, 23);
            lblKeluarHariIni.Margin = new Padding(2, 0, 2, 0);
            lblKeluarHariIni.Name = "lblKeluarHariIni";
            lblKeluarHariIni.Size = new Size(26, 30);
            lblKeluarHariIni.TabIndex = 3;
            lblKeluarHariIni.Text = "0";
            // 
            // CV
            // 
            CV.AutoSize = true;
            CV.ForeColor = Color.DimGray;
            CV.Location = new Point(19, 8);
            CV.Margin = new Padding(2, 0, 2, 0);
            CV.Name = "CV";
            CV.Size = new Size(121, 15);
            CV.TabIndex = 3;
            CV.Text = "Barang Keluar Hari Ini";
            // 
            // roundedPanel7
            // 
            roundedPanel7.BackColor = Color.Transparent;
            roundedPanel7.Controls.Add(lblMasukHariIni);
            roundedPanel7.Controls.Add(label2);
            roundedPanel7.Location = new Point(13, 13);
            roundedPanel7.Margin = new Padding(2, 2, 2, 2);
            roundedPanel7.Name = "roundedPanel7";
            roundedPanel7.Size = new Size(226, 63);
            roundedPanel7.TabIndex = 0;
            // 
            // lblMasukHariIni
            // 
            lblMasukHariIni.AutoSize = true;
            lblMasukHariIni.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMasukHariIni.ForeColor = Color.RoyalBlue;
            lblMasukHariIni.Location = new Point(16, 23);
            lblMasukHariIni.Margin = new Padding(2, 0, 2, 0);
            lblMasukHariIni.Name = "lblMasukHariIni";
            lblMasukHariIni.Size = new Size(26, 30);
            lblMasukHariIni.TabIndex = 1;
            lblMasukHariIni.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(16, 8);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(123, 15);
            label2.TabIndex = 0;
            label2.Text = "Barang Masuk Hari ini";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MidnightBlue;
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
            Size = new Size(972, 365);
            Load += UC_DSHBRDGudang_Load;
            roundedPanel1.ResumeLayout(false);
            roundedPanel1.PerformLayout();
            roundedPanel8.ResumeLayout(false);
            roundedPanel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPerhatian).EndInit();
            roundedPanel3.ResumeLayout(false);
            roundedPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAktivitas).EndInit();
            roundedPanel2.ResumeLayout(false);
            roundedPanel5.ResumeLayout(false);
            roundedPanel5.PerformLayout();
            roundedPanel4.ResumeLayout(false);
            roundedPanel4.PerformLayout();
            roundedPanel6.ResumeLayout(false);
            roundedPanel6.PerformLayout();
            roundedPanel7.ResumeLayout(false);
            roundedPanel7.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private RoundedPanel roundedPanel1;
        private Label label1;
        private RoundedPanel roundedPanel2;
        private RoundedPanel roundedPanel5;
        private Label lblPerluPerhatian;
        private Label label5;
        private RoundedPanel roundedPanel4;
        private Label lblStokSaatIni;
        private Label label3;
        private RoundedPanel roundedPanel6;
        private Label lblKeluarHariIni;
        private Label CV;
        private RoundedPanel roundedPanel7;
        private Label lblMasukHariIni;
        private Label label2;
        private RoundedPanel roundedPanel3;
        private Label label4;
        private DataGridView dgvAktivitas;
        private DataGridViewTextBoxColumn colWaktu;
        private DataGridViewTextBoxColumn colJenis;
        private DataGridViewTextBoxColumn colNamaBarang;
        private DataGridViewTextBoxColumn colJumlah;
        private DataGridViewTextBoxColumn colStokAkhir;
        private RoundedPanel roundedPanel8;
        private DataGridView dgvPerhatian;
        private Label label6;
    }
}
