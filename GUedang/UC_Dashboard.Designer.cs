namespace GUedang
{
    partial class UC_Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Dashboard));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panelContent2 = new RoundedPanel();
            label3 = new Label();
            roundedPanel1 = new RoundedPanel();
            lblBarangHabis = new Label();
            label6 = new Label();
            lblBarangMenipis = new Label();
            label5 = new Label();
            lblJumlahGudang = new Label();
            lblJumlahKasir = new Label();
            label2 = new Label();
            label7 = new Label();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            dgvUser = new DataGridView();
            label1 = new Label();
            colNo = new DataGridViewTextBoxColumn();
            colNama = new DataGridViewTextBoxColumn();
            colJenis = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            panelContent2.SuspendLayout();
            roundedPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvUser).BeginInit();
            SuspendLayout();
            // 
            // panelContent2
            // 
            panelContent2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelContent2.BackColor = Color.Transparent;
            panelContent2.Controls.Add(label3);
            panelContent2.Controls.Add(roundedPanel1);
            panelContent2.Controls.Add(dgvUser);
            panelContent2.Controls.Add(label1);
            panelContent2.Location = new Point(3, 3);
            panelContent2.Name = "panelContent2";
            panelContent2.Size = new Size(899, 348);
            panelContent2.TabIndex = 4;
            panelContent2.Paint += panelContent2_Paint;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri Light", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(20, 32);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(138, 17);
            label3.TabIndex = 14;
            label3.Text = "Selamat Datang,Admin";
            // 
            // roundedPanel1
            // 
            roundedPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            roundedPanel1.BackColor = Color.Transparent;
            roundedPanel1.Controls.Add(lblBarangHabis);
            roundedPanel1.Controls.Add(label6);
            roundedPanel1.Controls.Add(lblBarangMenipis);
            roundedPanel1.Controls.Add(label5);
            roundedPanel1.Controls.Add(lblJumlahGudang);
            roundedPanel1.Controls.Add(lblJumlahKasir);
            roundedPanel1.Controls.Add(label2);
            roundedPanel1.Controls.Add(label7);
            roundedPanel1.Controls.Add(pictureBox5);
            roundedPanel1.Controls.Add(pictureBox4);
            roundedPanel1.Location = new Point(707, 46);
            roundedPanel1.Margin = new Padding(2);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Size = new Size(172, 272);
            roundedPanel1.TabIndex = 8;
            // 
            // lblBarangHabis
            // 
            lblBarangHabis.AutoSize = true;
            lblBarangHabis.BackColor = Color.IndianRed;
            lblBarangHabis.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBarangHabis.ForeColor = Color.White;
            lblBarangHabis.Location = new Point(25, 210);
            lblBarangHabis.Margin = new Padding(2, 0, 2, 0);
            lblBarangHabis.Name = "lblBarangHabis";
            lblBarangHabis.Size = new Size(23, 25);
            lblBarangHabis.TabIndex = 19;
            lblBarangHabis.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.IndianRed;
            label6.Font = new Font("Calibri Light", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(25, 196);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(83, 17);
            label6.TabIndex = 18;
            label6.Text = "Barang Habis";
            // 
            // lblBarangMenipis
            // 
            lblBarangMenipis.AutoSize = true;
            lblBarangMenipis.BackColor = Color.Goldenrod;
            lblBarangMenipis.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBarangMenipis.ForeColor = Color.White;
            lblBarangMenipis.Location = new Point(25, 159);
            lblBarangMenipis.Margin = new Padding(2, 0, 2, 0);
            lblBarangMenipis.Name = "lblBarangMenipis";
            lblBarangMenipis.Size = new Size(23, 25);
            lblBarangMenipis.TabIndex = 17;
            lblBarangMenipis.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Goldenrod;
            label5.Font = new Font("Calibri Light", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(25, 145);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(107, 17);
            label5.TabIndex = 16;
            label5.Text = "Total Pendapatan";
            // 
            // lblJumlahGudang
            // 
            lblJumlahGudang.AutoSize = true;
            lblJumlahGudang.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblJumlahGudang.Location = new Point(51, 108);
            lblJumlahGudang.Margin = new Padding(2, 0, 2, 0);
            lblJumlahGudang.Name = "lblJumlahGudang";
            lblJumlahGudang.Size = new Size(23, 25);
            lblJumlahGudang.TabIndex = 15;
            lblJumlahGudang.Text = "0";
            // 
            // lblJumlahKasir
            // 
            lblJumlahKasir.AutoSize = true;
            lblJumlahKasir.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblJumlahKasir.Location = new Point(51, 58);
            lblJumlahKasir.Margin = new Padding(2, 0, 2, 0);
            lblJumlahKasir.Name = "lblJumlahKasir";
            lblJumlahKasir.Size = new Size(23, 25);
            lblJumlahKasir.TabIndex = 14;
            lblJumlahKasir.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri Light", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(51, 44);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(35, 17);
            label2.TabIndex = 11;
            label2.Text = "Kasir";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Calibri Light", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(51, 94);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(52, 17);
            label7.TabIndex = 13;
            label7.Text = "Gudang";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(25, 87);
            pictureBox5.Margin = new Padding(2);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(22, 21);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 10;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(25, 37);
            pictureBox4.Margin = new Padding(2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(22, 21);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 9;
            pictureBox4.TabStop = false;
            // 
            // dgvUser
            // 
            dgvUser.AllowUserToAddRows = false;
            dgvUser.AllowUserToDeleteRows = false;
            dgvUser.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvUser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUser.BackgroundColor = Color.White;
            dgvUser.BorderStyle = BorderStyle.None;
            dgvUser.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.SteelBlue;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvUser.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvUser.ColumnHeadersHeight = 40;
            dgvUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvUser.Columns.AddRange(new DataGridViewColumn[] { colNo, colNama, colJenis, colStatus });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.DimGray;
            dataGridViewCellStyle2.Padding = new Padding(6);
            dataGridViewCellStyle2.SelectionBackColor = Color.AliceBlue;
            dataGridViewCellStyle2.SelectionForeColor = Color.MidnightBlue;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvUser.DefaultCellStyle = dataGridViewCellStyle2;
            dgvUser.EnableHeadersVisualStyles = false;
            dgvUser.GridColor = Color.Gainsboro;
            dgvUser.Location = new Point(20, 51);
            dgvUser.Margin = new Padding(2);
            dgvUser.MultiSelect = false;
            dgvUser.Name = "dgvUser";
            dgvUser.ReadOnly = true;
            dgvUser.RowHeadersVisible = false;
            dgvUser.RowHeadersWidth = 62;
            dgvUser.RowTemplate.Height = 38;
            dgvUser.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUser.Size = new Size(676, 250);
            dgvUser.TabIndex = 6;
            dgvUser.CellContentClick += dgvUser_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(20, 5);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(178, 27);
            label1.TabIndex = 4;
            label1.Text = "Dashboard Admin";
            // 
            // colNo
            // 
            colNo.FillWeight = 50F;
            colNo.HeaderText = "No";
            colNo.MinimumWidth = 8;
            colNo.Name = "colNo";
            colNo.ReadOnly = true;
            // 
            // colNama
            // 
            colNama.FillWeight = 150F;
            colNama.HeaderText = "Nama";
            colNama.MinimumWidth = 8;
            colNama.Name = "colNama";
            colNama.ReadOnly = true;
            // 
            // colJenis
            // 
            colJenis.FillWeight = 80F;
            colJenis.HeaderText = "Jenis";
            colJenis.MinimumWidth = 8;
            colJenis.Name = "colJenis";
            colJenis.ReadOnly = true;
            // 
            // colStatus
            // 
            colStatus.FillWeight = 80F;
            colStatus.HeaderText = "Status";
            colStatus.MinimumWidth = 8;
            colStatus.Name = "colStatus";
            colStatus.ReadOnly = true;
            // 
            // UC_Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelContent2);
            Name = "UC_Dashboard";
            Size = new Size(893, 354);
            panelContent2.ResumeLayout(false);
            panelContent2.PerformLayout();
            roundedPanel1.ResumeLayout(false);
            roundedPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvUser).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private RoundedPanel panelContent2;
        private DataGridView dgvUser;
        private Label label1;
        private RoundedPanel roundedPanel1;
        private Label label2;
        private Label label7;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private Label label3;
        private Label lblJumlahKasir;
        private Label lblJumlahGudang;
        private Label label5;
        private Label lblBarangHabis;
        private Label label6;
        private Label lblBarangMenipis;
        private DataGridViewTextBoxColumn colNo;
        private DataGridViewTextBoxColumn colNama;
        private DataGridViewTextBoxColumn colJenis;
        private DataGridViewTextBoxColumn colStatus;
    }
}
