namespace GUedang
{
    partial class UC_Barang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Barang));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            label1 = new Label();
            label2 = new Label();
            pictureBox3 = new PictureBox();
            label3 = new Label();
            roundedPanel1 = new RoundedPanel();
            roundedPanel2 = new RoundedPanel();
            roundedPanel3 = new RoundedPanel();
            roundedPanel4 = new RoundedPanel();
            panelDaftarStok = new RoundedPanel();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            lblTotalBarang = new Label();
            roundedPanel6 = new RoundedPanel();
            label9 = new Label();
            lblStokAman = new Label();
            lblStokMenipis = new Label();
            lblStokHabis = new Label();
            txtCariStok = new RoundedTextBox();
            btnSemua = new RoundedButton();
            btnAman = new RoundedButton();
            btnMenipis = new RoundedButton();
            btnHabis = new RoundedButton();
            dgvDaftarStok = new DataGridView();
            colNo = new DataGridViewTextBoxColumn();
            colKode = new DataGridViewTextBoxColumn();
            colNamaBarang = new DataGridViewTextBoxColumn();
            colStok = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            roundedPanel1.SuspendLayout();
            roundedPanel2.SuspendLayout();
            roundedPanel3.SuspendLayout();
            roundedPanel4.SuspendLayout();
            panelDaftarStok.SuspendLayout();
            roundedPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDaftarStok).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(16, 10);
            label1.Name = "label1";
            label1.Size = new Size(171, 38);
            label1.TabIndex = 0;
            label1.Text = "Stok Barang";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.MidnightBlue;
            label2.Location = new Point(22, 48);
            label2.Name = "label2";
            label2.Size = new Size(165, 25);
            label2.TabIndex = 1;
            label2.Text = "Pantau stok barang";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(642, 10);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(26, 38);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.MidnightBlue;
            label3.Location = new Point(674, 23);
            label3.Name = "label3";
            label3.Size = new Size(65, 25);
            label3.TabIndex = 7;
            label3.Text = "Admin";
            // 
            // roundedPanel1
            // 
            roundedPanel1.BackColor = Color.Transparent;
            roundedPanel1.BorderStyle = BorderStyle.FixedSingle;
            roundedPanel1.Controls.Add(lblTotalBarang);
            roundedPanel1.Controls.Add(label4);
            roundedPanel1.Location = new Point(22, 101);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Size = new Size(180, 75);
            roundedPanel1.TabIndex = 8;
            // 
            // roundedPanel2
            // 
            roundedPanel2.BackColor = Color.Transparent;
            roundedPanel2.BorderStyle = BorderStyle.FixedSingle;
            roundedPanel2.Controls.Add(roundedPanel6);
            roundedPanel2.Controls.Add(label5);
            roundedPanel2.Location = new Point(230, 101);
            roundedPanel2.Name = "roundedPanel2";
            roundedPanel2.Size = new Size(180, 75);
            roundedPanel2.TabIndex = 9;
            // 
            // roundedPanel3
            // 
            roundedPanel3.BackColor = Color.Transparent;
            roundedPanel3.BorderStyle = BorderStyle.FixedSingle;
            roundedPanel3.Controls.Add(lblStokMenipis);
            roundedPanel3.Controls.Add(label6);
            roundedPanel3.Location = new Point(434, 101);
            roundedPanel3.Name = "roundedPanel3";
            roundedPanel3.Size = new Size(180, 75);
            roundedPanel3.TabIndex = 10;
            // 
            // roundedPanel4
            // 
            roundedPanel4.BackColor = Color.Transparent;
            roundedPanel4.BorderStyle = BorderStyle.FixedSingle;
            roundedPanel4.Controls.Add(lblStokHabis);
            roundedPanel4.Controls.Add(label7);
            roundedPanel4.Location = new Point(642, 101);
            roundedPanel4.Name = "roundedPanel4";
            roundedPanel4.Size = new Size(180, 75);
            roundedPanel4.TabIndex = 11;
            // 
            // panelDaftarStok
            // 
            panelDaftarStok.BackColor = Color.White;
            panelDaftarStok.BorderStyle = BorderStyle.FixedSingle;
            panelDaftarStok.Controls.Add(dgvDaftarStok);
            panelDaftarStok.Controls.Add(btnHabis);
            panelDaftarStok.Controls.Add(btnMenipis);
            panelDaftarStok.Controls.Add(btnAman);
            panelDaftarStok.Controls.Add(btnSemua);
            panelDaftarStok.Controls.Add(txtCariStok);
            panelDaftarStok.Location = new Point(22, 192);
            panelDaftarStok.Name = "panelDaftarStok";
            panelDaftarStok.Size = new Size(800, 300);
            panelDaftarStok.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri Light", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(11, 9);
            label4.Name = "label4";
            label4.Size = new Size(92, 19);
            label4.TabIndex = 0;
            label4.Text = "Total Barang";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri Light", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(16, 9);
            label5.Name = "label5";
            label5.Size = new Size(92, 19);
            label5.TabIndex = 1;
            label5.Text = "Total Barang";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri Light", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(14, 9);
            label6.Name = "label6";
            label6.Size = new Size(92, 19);
            label6.TabIndex = 2;
            label6.Text = "Stok Menipis";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Calibri Light", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(16, 9);
            label7.Name = "label7";
            label7.Size = new Size(76, 19);
            label7.TabIndex = 3;
            label7.Text = "Stok Habis";
            // 
            // lblTotalBarang
            // 
            lblTotalBarang.AutoSize = true;
            lblTotalBarang.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalBarang.Location = new Point(19, 28);
            lblTotalBarang.Name = "lblTotalBarang";
            lblTotalBarang.Size = new Size(33, 38);
            lblTotalBarang.TabIndex = 1;
            lblTotalBarang.Text = "0";
            // 
            // roundedPanel6
            // 
            roundedPanel6.BackColor = Color.Transparent;
            roundedPanel6.BorderStyle = BorderStyle.FixedSingle;
            roundedPanel6.Controls.Add(lblStokAman);
            roundedPanel6.Controls.Add(label9);
            roundedPanel6.Location = new Point(-1, -1);
            roundedPanel6.Name = "roundedPanel6";
            roundedPanel6.Size = new Size(180, 75);
            roundedPanel6.TabIndex = 10;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Calibri Light", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(16, 9);
            label9.Name = "label9";
            label9.Size = new Size(78, 19);
            label9.TabIndex = 1;
            label9.Text = "Stok Aman";
            // 
            // lblStokAman
            // 
            lblStokAman.AutoSize = true;
            lblStokAman.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStokAman.Location = new Point(16, 28);
            lblStokAman.Name = "lblStokAman";
            lblStokAman.Size = new Size(33, 38);
            lblStokAman.TabIndex = 2;
            lblStokAman.Text = "0";
            // 
            // lblStokMenipis
            // 
            lblStokMenipis.AutoSize = true;
            lblStokMenipis.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStokMenipis.Location = new Point(14, 28);
            lblStokMenipis.Name = "lblStokMenipis";
            lblStokMenipis.Size = new Size(33, 38);
            lblStokMenipis.TabIndex = 13;
            lblStokMenipis.Text = "0";
            // 
            // lblStokHabis
            // 
            lblStokHabis.AutoSize = true;
            lblStokHabis.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStokHabis.Location = new Point(16, 28);
            lblStokHabis.Name = "lblStokHabis";
            lblStokHabis.Size = new Size(33, 38);
            lblStokHabis.TabIndex = 14;
            lblStokHabis.Text = "0";
            // 
            // txtCariStok
            // 
            txtCariStok.Font = new Font("Calibri Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCariStok.ForeColor = Color.MidnightBlue;
            txtCariStok.Location = new Point(9, 13);
            txtCariStok.Name = "txtCariStok";
            txtCariStok.Size = new Size(450, 30);
            txtCariStok.TabIndex = 0;
            txtCariStok.Text = "Cari nama barang atau kode...";
            // 
            // btnSemua
            // 
            btnSemua.BackColor = Color.RoyalBlue;
            btnSemua.FlatAppearance.BorderSize = 0;
            btnSemua.FlatStyle = FlatStyle.Flat;
            btnSemua.Font = new Font("Calibri", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSemua.ForeColor = Color.White;
            btnSemua.Location = new Point(487, 12);
            btnSemua.Name = "btnSemua";
            btnSemua.Size = new Size(65, 30);
            btnSemua.TabIndex = 1;
            btnSemua.Text = "Semua";
            btnSemua.UseVisualStyleBackColor = false;
            // 
            // btnAman
            // 
            btnAman.BackColor = Color.SeaGreen;
            btnAman.FlatAppearance.BorderSize = 0;
            btnAman.FlatStyle = FlatStyle.Flat;
            btnAman.Font = new Font("Calibri", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAman.ForeColor = Color.White;
            btnAman.Location = new Point(558, 13);
            btnAman.Name = "btnAman";
            btnAman.Size = new Size(65, 30);
            btnAman.TabIndex = 2;
            btnAman.Text = "Aman";
            btnAman.UseVisualStyleBackColor = false;
            // 
            // btnMenipis
            // 
            btnMenipis.BackColor = Color.Goldenrod;
            btnMenipis.FlatAppearance.BorderSize = 0;
            btnMenipis.FlatStyle = FlatStyle.Flat;
            btnMenipis.Font = new Font("Calibri", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMenipis.ForeColor = Color.White;
            btnMenipis.Location = new Point(629, 13);
            btnMenipis.Name = "btnMenipis";
            btnMenipis.Size = new Size(74, 30);
            btnMenipis.TabIndex = 3;
            btnMenipis.Text = "Menipis";
            btnMenipis.UseVisualStyleBackColor = false;
            // 
            // btnHabis
            // 
            btnHabis.BackColor = Color.IndianRed;
            btnHabis.FlatAppearance.BorderSize = 0;
            btnHabis.FlatStyle = FlatStyle.Flat;
            btnHabis.Font = new Font("Calibri", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHabis.ForeColor = Color.White;
            btnHabis.Location = new Point(709, 13);
            btnHabis.Name = "btnHabis";
            btnHabis.Size = new Size(65, 30);
            btnHabis.TabIndex = 4;
            btnHabis.Text = "Habis";
            btnHabis.UseVisualStyleBackColor = false;
            // 
            // dgvDaftarStok
            // 
            dgvDaftarStok.AllowUserToAddRows = false;
            dgvDaftarStok.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDaftarStok.BackgroundColor = Color.White;
            dgvDaftarStok.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.AliceBlue;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.MidnightBlue;
            dataGridViewCellStyle1.Padding = new Padding(6);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvDaftarStok.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvDaftarStok.ColumnHeadersHeight = 40;
            dgvDaftarStok.Columns.AddRange(new DataGridViewColumn[] { colNo, colKode, colNamaBarang, colStok, colStatus });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.MidnightBlue;
            dataGridViewCellStyle2.Padding = new Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = Color.AliceBlue;
            dataGridViewCellStyle2.SelectionForeColor = Color.MidnightBlue;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvDaftarStok.DefaultCellStyle = dataGridViewCellStyle2;
            dgvDaftarStok.EnableHeadersVisualStyles = false;
            dgvDaftarStok.GridColor = Color.White;
            dgvDaftarStok.Location = new Point(9, 49);
            dgvDaftarStok.Name = "dgvDaftarStok";
            dgvDaftarStok.ReadOnly = true;
            dgvDaftarStok.RowHeadersVisible = false;
            dgvDaftarStok.RowHeadersWidth = 62;
            dgvDaftarStok.RowTemplate.Height = 35;
            dgvDaftarStok.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDaftarStok.Size = new Size(778, 235);
            dgvDaftarStok.TabIndex = 5;
            // 
            // colNo
            // 
            colNo.FillWeight = 40F;
            colNo.HeaderText = "No";
            colNo.MinimumWidth = 8;
            colNo.Name = "colNo";
            colNo.ReadOnly = true;
            colNo.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colKode
            // 
            colKode.FillWeight = 90F;
            colKode.HeaderText = "Kode";
            colKode.MinimumWidth = 70;
            colKode.Name = "colKode";
            colKode.ReadOnly = true;
            colKode.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colNamaBarang
            // 
            colNamaBarang.FillWeight = 180F;
            colNamaBarang.HeaderText = "Nama Barang";
            colNamaBarang.MinimumWidth = 120;
            colNamaBarang.Name = "colNamaBarang";
            colNamaBarang.ReadOnly = true;
            colNamaBarang.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colStok
            // 
            colStok.FillWeight = 60F;
            colStok.HeaderText = "Stok";
            colStok.MinimumWidth = 50;
            colStok.Name = "colStok";
            colStok.ReadOnly = true;
            colStok.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colStatus
            // 
            colStatus.FillWeight = 90F;
            colStatus.HeaderText = "Status";
            colStatus.MinimumWidth = 70;
            colStatus.Name = "colStatus";
            colStatus.ReadOnly = true;
            colStatus.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // UC_Barang
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            Controls.Add(panelDaftarStok);
            Controls.Add(roundedPanel4);
            Controls.Add(roundedPanel3);
            Controls.Add(roundedPanel2);
            Controls.Add(roundedPanel1);
            Controls.Add(label3);
            Controls.Add(pictureBox3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UC_Barang";
            Size = new Size(845, 538);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            roundedPanel1.ResumeLayout(false);
            roundedPanel1.PerformLayout();
            roundedPanel2.ResumeLayout(false);
            roundedPanel2.PerformLayout();
            roundedPanel3.ResumeLayout(false);
            roundedPanel3.PerformLayout();
            roundedPanel4.ResumeLayout(false);
            roundedPanel4.PerformLayout();
            panelDaftarStok.ResumeLayout(false);
            roundedPanel6.ResumeLayout(false);
            roundedPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDaftarStok).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private PictureBox pictureBox3;
        private Label label3;
        private RoundedPanel roundedPanel1;
        private RoundedPanel roundedPanel2;
        private RoundedPanel roundedPanel3;
        private RoundedPanel roundedPanel4;
        private RoundedPanel panelDaftarStok;
        private Label lblTotalBarang;
        private Label label4;
        private RoundedPanel roundedPanel6;
        private Label lblStokAman;
        private Label label9;
        private Label label5;
        private Label lblStokMenipis;
        private Label label6;
        private Label lblStokHabis;
        private Label label7;
        private RoundedTextBox txtCariStok;
        private RoundedButton btnMenipis;
        private RoundedButton btnAman;
        private RoundedButton btnSemua;
        private RoundedButton btnHabis;
        private DataGridView dgvDaftarStok;
        private DataGridViewTextBoxColumn colNo;
        private DataGridViewTextBoxColumn colKode;
        private DataGridViewTextBoxColumn colNamaBarang;
        private DataGridViewTextBoxColumn colStok;
        private DataGridViewTextBoxColumn colStatus;
    }
}
