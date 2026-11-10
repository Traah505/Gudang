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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Dashboard));
            panelContent2 = new RoundedPanel();
            pictureBox3 = new PictureBox();
            dgvRequestUser = new DataGridView();
            colNo = new DataGridViewTextBoxColumn();
            colNama = new DataGridViewTextBoxColumn();
            colJenis = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            colAksi = new DataGridViewButtonColumn();
            label4 = new Label();
            label1 = new Label();
            roundedPanel1 = new RoundedPanel();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            label2 = new Label();
            label7 = new Label();
            label3 = new Label();
            panelContent2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvRequestUser).BeginInit();
            roundedPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // panelContent2
            // 
            panelContent2.BackColor = Color.Transparent;
            panelContent2.Controls.Add(label3);
            panelContent2.Controls.Add(roundedPanel1);
            panelContent2.Controls.Add(pictureBox3);
            panelContent2.Controls.Add(dgvRequestUser);
            panelContent2.Controls.Add(label4);
            panelContent2.Controls.Add(label1);
            panelContent2.Location = new Point(4, 5);
            panelContent2.Margin = new Padding(4, 5, 4, 5);
            panelContent2.Name = "panelContent2";
            panelContent2.Size = new Size(1284, 923);
            panelContent2.TabIndex = 4;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(1117, 28);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(31, 35);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // dgvRequestUser
            // 
            dgvRequestUser.AllowUserToAddRows = false;
            dgvRequestUser.AllowUserToDeleteRows = false;
            dgvRequestUser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRequestUser.BackgroundColor = Color.WhiteSmoke;
            dgvRequestUser.BorderStyle = BorderStyle.None;
            dgvRequestUser.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.SteelBlue;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvRequestUser.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvRequestUser.ColumnHeadersHeight = 40;
            dgvRequestUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvRequestUser.Columns.AddRange(new DataGridViewColumn[] { colNo, colNama, colJenis, colStatus, colAksi });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.DimGray;
            dataGridViewCellStyle2.Padding = new Padding(6);
            dataGridViewCellStyle2.SelectionBackColor = Color.AliceBlue;
            dataGridViewCellStyle2.SelectionForeColor = Color.MidnightBlue;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvRequestUser.DefaultCellStyle = dataGridViewCellStyle2;
            dgvRequestUser.EnableHeadersVisualStyles = false;
            dgvRequestUser.GridColor = Color.Gainsboro;
            dgvRequestUser.Location = new Point(29, 77);
            dgvRequestUser.MultiSelect = false;
            dgvRequestUser.Name = "dgvRequestUser";
            dgvRequestUser.ReadOnly = true;
            dgvRequestUser.RowHeadersVisible = false;
            dgvRequestUser.RowHeadersWidth = 62;
            dgvRequestUser.RowTemplate.Height = 38;
            dgvRequestUser.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRequestUser.Size = new Size(965, 769);
            dgvRequestUser.TabIndex = 6;
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
            // colAksi
            // 
            colAksi.FillWeight = 70F;
            colAksi.HeaderText = "Aksi";
            colAksi.MinimumWidth = 8;
            colAksi.Name = "colAksi";
            colAksi.ReadOnly = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(1154, 35);
            label4.Name = "label4";
            label4.Size = new Size(72, 28);
            label4.TabIndex = 5;
            label4.Text = "Admin";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(29, 9);
            label1.Name = "label1";
            label1.Size = new Size(255, 39);
            label1.TabIndex = 4;
            label1.Text = "Dashboard Admin";
            // 
            // roundedPanel1
            // 
            roundedPanel1.BackColor = Color.Transparent;
            roundedPanel1.Controls.Add(label2);
            roundedPanel1.Controls.Add(label7);
            roundedPanel1.Controls.Add(pictureBox5);
            roundedPanel1.Controls.Add(pictureBox4);
            roundedPanel1.Location = new Point(1010, 77);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Size = new Size(246, 790);
            roundedPanel1.TabIndex = 8;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(36, 62);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(31, 35);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 9;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(36, 145);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(31, 35);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 10;
            pictureBox5.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri Light", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(73, 73);
            label2.Name = "label2";
            label2.Size = new Size(48, 24);
            label2.TabIndex = 11;
            label2.Text = "Kasir";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Calibri Light", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(73, 145);
            label7.Name = "label7";
            label7.Size = new Size(71, 24);
            label7.TabIndex = 13;
            label7.Text = "Gudang";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri Light", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(38, 39);
            label3.Name = "label3";
            label3.Size = new Size(191, 24);
            label3.TabIndex = 14;
            label3.Text = "Selamat Datang,Admin";
            // 
            // UC_Dashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelContent2);
            Margin = new Padding(4, 5, 4, 5);
            Name = "UC_Dashboard";
            Size = new Size(1276, 900);
            panelContent2.ResumeLayout(false);
            panelContent2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvRequestUser).EndInit();
            roundedPanel1.ResumeLayout(false);
            roundedPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private RoundedPanel panelContent2;
        private PictureBox pictureBox3;
        private DataGridView dgvRequestUser;
        private DataGridViewTextBoxColumn colNo;
        private DataGridViewTextBoxColumn colNama;
        private DataGridViewTextBoxColumn colJenis;
        private DataGridViewTextBoxColumn colStatus;
        private DataGridViewButtonColumn colAksi;
        private Label label4;
        private Label label1;
        private RoundedPanel roundedPanel1;
        private Label label2;
        private Label label7;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private Label label3;
    }
}
