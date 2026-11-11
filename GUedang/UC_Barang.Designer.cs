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
            panelDaftarStok = new RoundedPanel();
            btnHabis = new RoundedButton();
            btnMenipis = new RoundedButton();
            btnAman = new RoundedButton();
            dgvDaftarStok = new DataGridView();
            btnSemua = new RoundedButton();
            txtCariStok = new RoundedTextBox();
            roundedPanel5 = new RoundedPanel();
            panelTotal = new RoundedPanel();
            lblTotalBarang = new Label();
            label10 = new Label();
            panelHabis = new RoundedPanel();
            lblStokHabis = new Label();
            label16 = new Label();
            panelMenipis = new RoundedPanel();
            lblStokMenipis = new Label();
            label14 = new Label();
            panelAman = new RoundedPanel();
            lblStokAman = new Label();
            label12 = new Label();
            colNo = new DataGridViewTextBoxColumn();
            colKode = new DataGridViewTextBoxColumn();
            colNamaBarang = new DataGridViewTextBoxColumn();
            colStok = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            Petugas = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panelDaftarStok.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDaftarStok).BeginInit();
            roundedPanel5.SuspendLayout();
            panelTotal.SuspendLayout();
            panelHabis.SuspendLayout();
            panelMenipis.SuspendLayout();
            panelAman.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(11, 6);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(114, 25);
            label1.TabIndex = 0;
            label1.Text = "Stok Barang";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.MidnightBlue;
            label2.Location = new Point(15, 29);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(109, 15);
            label2.TabIndex = 1;
            label2.Text = "Pantau stok barang";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(787, 21);
            pictureBox3.Margin = new Padding(2, 2, 2, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(18, 23);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.MidnightBlue;
            label3.Location = new Point(809, 29);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 7;
            label3.Text = "Admin";
            // 
            // panelDaftarStok
            // 
            panelDaftarStok.BackColor = Color.White;
            panelDaftarStok.BorderStyle = BorderStyle.FixedSingle;
            panelDaftarStok.Controls.Add(btnHabis);
            panelDaftarStok.Controls.Add(btnMenipis);
            panelDaftarStok.Controls.Add(btnAman);
            panelDaftarStok.Controls.Add(dgvDaftarStok);
            panelDaftarStok.Controls.Add(btnSemua);
            panelDaftarStok.Controls.Add(txtCariStok);
            panelDaftarStok.Location = new Point(15, 115);
            panelDaftarStok.Margin = new Padding(2, 2, 2, 2);
            panelDaftarStok.Name = "panelDaftarStok";
            panelDaftarStok.Size = new Size(860, 414);
            panelDaftarStok.TabIndex = 12;
            // 
            // btnHabis
            // 
            btnHabis.BackColor = Color.IndianRed;
            btnHabis.FlatAppearance.BorderSize = 0;
            btnHabis.FlatStyle = FlatStyle.Flat;
            btnHabis.Font = new Font("Calibri", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHabis.ForeColor = Color.White;
            btnHabis.Location = new Point(724, 8);
            btnHabis.Margin = new Padding(2, 2, 2, 2);
            btnHabis.Name = "btnHabis";
            btnHabis.Size = new Size(66, 30);
            btnHabis.TabIndex = 8;
            btnHabis.Text = "Habis";
            btnHabis.UseVisualStyleBackColor = false;
            // 
            // btnMenipis
            // 
            btnMenipis.BackColor = Color.Goldenrod;
            btnMenipis.FlatAppearance.BorderSize = 0;
            btnMenipis.FlatStyle = FlatStyle.Flat;
            btnMenipis.Font = new Font("Calibri", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMenipis.ForeColor = Color.White;
            btnMenipis.Location = new Point(636, 8);
            btnMenipis.Margin = new Padding(2, 2, 2, 2);
            btnMenipis.Name = "btnMenipis";
            btnMenipis.Size = new Size(75, 30);
            btnMenipis.TabIndex = 7;
            btnMenipis.Text = "Menipis";
            btnMenipis.UseVisualStyleBackColor = false;
            // 
            // btnAman
            // 
            btnAman.BackColor = Color.SeaGreen;
            btnAman.FlatAppearance.BorderSize = 0;
            btnAman.FlatStyle = FlatStyle.Flat;
            btnAman.Font = new Font("Calibri", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAman.ForeColor = Color.White;
            btnAman.Location = new Point(559, 8);
            btnAman.Margin = new Padding(2, 2, 2, 2);
            btnAman.Name = "btnAman";
            btnAman.Size = new Size(65, 30);
            btnAman.TabIndex = 6;
            btnAman.Text = "Aman";
            btnAman.UseVisualStyleBackColor = false;
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
            dgvDaftarStok.Columns.AddRange(new DataGridViewColumn[] { colNo, colKode, colNamaBarang, colStok, colStatus, Petugas });
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
            dgvDaftarStok.Location = new Point(15, 50);
            dgvDaftarStok.Margin = new Padding(2, 2, 2, 2);
            dgvDaftarStok.Name = "dgvDaftarStok";
            dgvDaftarStok.ReadOnly = true;
            dgvDaftarStok.RowHeadersVisible = false;
            dgvDaftarStok.RowHeadersWidth = 62;
            dgvDaftarStok.RowTemplate.Height = 35;
            dgvDaftarStok.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDaftarStok.Size = new Size(824, 343);
            dgvDaftarStok.TabIndex = 5;
            // 
            // btnSemua
            // 
            btnSemua.BackColor = Color.RoyalBlue;
            btnSemua.FlatAppearance.BorderSize = 0;
            btnSemua.FlatStyle = FlatStyle.Flat;
            btnSemua.Font = new Font("Calibri", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSemua.ForeColor = Color.White;
            btnSemua.Location = new Point(480, 8);
            btnSemua.Margin = new Padding(2, 2, 2, 2);
            btnSemua.Name = "btnSemua";
            btnSemua.Size = new Size(68, 30);
            btnSemua.TabIndex = 1;
            btnSemua.Text = "Semua";
            btnSemua.UseVisualStyleBackColor = false;
            // 
            // txtCariStok
            // 
            txtCariStok.Font = new Font("Calibri Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCariStok.ForeColor = Color.MidnightBlue;
            txtCariStok.Location = new Point(15, 10);
            txtCariStok.Margin = new Padding(2, 2, 2, 2);
            txtCariStok.Name = "txtCariStok";
            txtCariStok.Size = new Size(370, 28);
            txtCariStok.TabIndex = 0;
            txtCariStok.Text = "Cari nama barang atau kode...";
            // 
            // roundedPanel5
            // 
            roundedPanel5.BackColor = Color.Transparent;
            roundedPanel5.Controls.Add(panelTotal);
            roundedPanel5.Controls.Add(panelHabis);
            roundedPanel5.Controls.Add(panelMenipis);
            roundedPanel5.Controls.Add(panelAman);
            roundedPanel5.Location = new Point(18, 53);
            roundedPanel5.Margin = new Padding(2, 2, 2, 2);
            roundedPanel5.Name = "roundedPanel5";
            roundedPanel5.Size = new Size(862, 61);
            roundedPanel5.TabIndex = 13;
            // 
            // panelTotal
            // 
            panelTotal.BackColor = Color.Transparent;
            panelTotal.BorderStyle = BorderStyle.FixedSingle;
            panelTotal.Controls.Add(lblTotalBarang);
            panelTotal.Controls.Add(label10);
            panelTotal.ForeColor = Color.White;
            panelTotal.Location = new Point(13, 10);
            panelTotal.Margin = new Padding(2, 2, 2, 2);
            panelTotal.Name = "panelTotal";
            panelTotal.Size = new Size(178, 46);
            panelTotal.TabIndex = 9;
            // 
            // lblTotalBarang
            // 
            lblTotalBarang.AutoSize = true;
            lblTotalBarang.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalBarang.Location = new Point(13, 17);
            lblTotalBarang.Margin = new Padding(2, 0, 2, 0);
            lblTotalBarang.Name = "lblTotalBarang";
            lblTotalBarang.Size = new Size(23, 25);
            lblTotalBarang.TabIndex = 1;
            lblTotalBarang.Text = "0";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Calibri Light", 9F, FontStyle.Bold);
            label10.Location = new Point(8, 5);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(80, 14);
            label10.TabIndex = 0;
            label10.Text = "Total Barang";
            // 
            // panelHabis
            // 
            panelHabis.BackColor = Color.Transparent;
            panelHabis.BorderStyle = BorderStyle.FixedSingle;
            panelHabis.Controls.Add(lblStokHabis);
            panelHabis.Controls.Add(label16);
            panelHabis.ForeColor = Color.White;
            panelHabis.Location = new Point(659, 10);
            panelHabis.Margin = new Padding(2, 2, 2, 2);
            panelHabis.Name = "panelHabis";
            panelHabis.Size = new Size(178, 46);
            panelHabis.TabIndex = 15;
            // 
            // lblStokHabis
            // 
            lblStokHabis.AutoSize = true;
            lblStokHabis.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStokHabis.Location = new Point(11, 17);
            lblStokHabis.Margin = new Padding(2, 0, 2, 0);
            lblStokHabis.Name = "lblStokHabis";
            lblStokHabis.Size = new Size(23, 25);
            lblStokHabis.TabIndex = 14;
            lblStokHabis.Text = "0";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Calibri Light", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.Location = new Point(11, 5);
            label16.Margin = new Padding(2, 0, 2, 0);
            label16.Name = "label16";
            label16.Size = new Size(67, 14);
            label16.TabIndex = 3;
            label16.Text = "Stok Habis";
            // 
            // panelMenipis
            // 
            panelMenipis.BackColor = Color.Transparent;
            panelMenipis.BorderStyle = BorderStyle.FixedSingle;
            panelMenipis.Controls.Add(lblStokMenipis);
            panelMenipis.Controls.Add(label14);
            panelMenipis.ForeColor = Color.White;
            panelMenipis.Location = new Point(437, 10);
            panelMenipis.Margin = new Padding(2, 2, 2, 2);
            panelMenipis.Name = "panelMenipis";
            panelMenipis.Size = new Size(178, 46);
            panelMenipis.TabIndex = 14;
            // 
            // lblStokMenipis
            // 
            lblStokMenipis.AutoSize = true;
            lblStokMenipis.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStokMenipis.Location = new Point(10, 17);
            lblStokMenipis.Margin = new Padding(2, 0, 2, 0);
            lblStokMenipis.Name = "lblStokMenipis";
            lblStokMenipis.Size = new Size(23, 25);
            lblStokMenipis.TabIndex = 13;
            lblStokMenipis.Text = "0";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Calibri Light", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(10, 5);
            label14.Margin = new Padding(2, 0, 2, 0);
            label14.Name = "label14";
            label14.Size = new Size(81, 14);
            label14.TabIndex = 2;
            label14.Text = "Stok Menipis";
            // 
            // panelAman
            // 
            panelAman.BackColor = Color.Transparent;
            panelAman.BorderStyle = BorderStyle.FixedSingle;
            panelAman.Controls.Add(lblStokAman);
            panelAman.Controls.Add(label12);
            panelAman.ForeColor = Color.White;
            panelAman.Location = new Point(230, 10);
            panelAman.Margin = new Padding(2, 2, 2, 2);
            panelAman.Name = "panelAman";
            panelAman.Size = new Size(178, 46);
            panelAman.TabIndex = 11;
            // 
            // lblStokAman
            // 
            lblStokAman.AutoSize = true;
            lblStokAman.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStokAman.Location = new Point(11, 17);
            lblStokAman.Margin = new Padding(2, 0, 2, 0);
            lblStokAman.Name = "lblStokAman";
            lblStokAman.Size = new Size(23, 25);
            lblStokAman.TabIndex = 2;
            lblStokAman.Text = "0";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Calibri Light", 9F, FontStyle.Bold);
            label12.Location = new Point(11, 5);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(68, 14);
            label12.TabIndex = 1;
            label12.Text = "Stok Aman";
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
            // Petugas
            // 
            Petugas.HeaderText = "Petugas";
            Petugas.Name = "Petugas";
            Petugas.ReadOnly = true;
            // 
            // UC_Barang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(roundedPanel5);
            Controls.Add(panelDaftarStok);
            Controls.Add(label3);
            Controls.Add(pictureBox3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "UC_Barang";
            Size = new Size(896, 540);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panelDaftarStok.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDaftarStok).EndInit();
            roundedPanel5.ResumeLayout(false);
            panelTotal.ResumeLayout(false);
            panelTotal.PerformLayout();
            panelHabis.ResumeLayout(false);
            panelHabis.PerformLayout();
            panelMenipis.ResumeLayout(false);
            panelMenipis.PerformLayout();
            panelAman.ResumeLayout(false);
            panelAman.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private PictureBox pictureBox3;
        private Label label3;
        private RoundedPanel panelDaftarStok;
        private RoundedTextBox txtCariStok;
        private RoundedButton btnSemua;
        private DataGridView dgvDaftarStok;
        private RoundedButton btnHabis;
        private RoundedButton btnMenipis;
        private RoundedButton btnAman;
        private RoundedPanel roundedPanel5;
        private RoundedPanel panelTotal;
        private Label lblTotalBarang;
        private Label label10;
        private RoundedPanel panelAman;
        private Label lblStokAman;
        private Label label12;
        private RoundedPanel panelMenipis;
        private Label lblStokMenipis;
        private Label label14;
        private RoundedPanel panelHabis;
        private Label lblStokHabis;
        private Label label16;
        private DataGridViewTextBoxColumn colNo;
        private DataGridViewTextBoxColumn colKode;
        private DataGridViewTextBoxColumn colNamaBarang;
        private DataGridViewTextBoxColumn colStok;
        private DataGridViewTextBoxColumn colStatus;
        private DataGridViewTextBoxColumn Petugas;
    }
}
