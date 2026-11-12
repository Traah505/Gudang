namespace GUedang
{
    partial class UC_User
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_User));
            roundedPanel1 = new RoundedPanel();
            dgvUser = new DataGridView();
            colNo = new DataGridViewTextBoxColumn();
            colnNama = new DataGridViewTextBoxColumn();
            colJenis = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            colAksi = new DataGridViewButtonColumn();
            label2 = new Label();
            label1 = new Label();
            roundedPanel2 = new RoundedPanel();
            btnBatal = new RoundedButton();
            btnSimpan = new RoundedButton();
            txtPassword = new RoundedTextBox();
            cmbJenis = new ComboBox();
            label6 = new Label();
            txtNama = new RoundedTextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            roundedPanel3 = new RoundedPanel();
            label11 = new Label();
            label8 = new Label();
            roundedTextBox4 = new RoundedTextBox();
            roundedTextBox3 = new RoundedTextBox();
            roundedButton1 = new RoundedButton();
            roundedButton2 = new RoundedButton();
            roundedTextBox1 = new RoundedTextBox();
            label7 = new Label();
            roundedTextBox2 = new RoundedTextBox();
            label9 = new Label();
            label10 = new Label();
            roundedPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUser).BeginInit();
            roundedPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            roundedPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // roundedPanel1
            // 
            roundedPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            roundedPanel1.BackColor = Color.White;
            roundedPanel1.Controls.Add(dgvUser);
            roundedPanel1.Controls.Add(label2);
            roundedPanel1.Location = new Point(16, 42);
            roundedPanel1.Margin = new Padding(2);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Size = new Size(725, 409);
            roundedPanel1.TabIndex = 0;
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
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvUser.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvUser.ColumnHeadersHeight = 40;
            dgvUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvUser.Columns.AddRange(new DataGridViewColumn[] { colNo, colnNama, colJenis, colStatus, colAksi });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.DimGray;
            dataGridViewCellStyle2.Padding = new Padding(8, 4, 8, 4);
            dataGridViewCellStyle2.SelectionBackColor = Color.AliceBlue;
            dataGridViewCellStyle2.SelectionForeColor = Color.MidnightBlue;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvUser.DefaultCellStyle = dataGridViewCellStyle2;
            dgvUser.EnableHeadersVisualStyles = false;
            dgvUser.GridColor = Color.Gainsboro;
            dgvUser.Location = new Point(12, 34);
            dgvUser.Margin = new Padding(2);
            dgvUser.Name = "dgvUser";
            dgvUser.ReadOnly = true;
            dgvUser.RowHeadersVisible = false;
            dgvUser.RowHeadersWidth = 62;
            dgvUser.RowTemplate.Height = 38;
            dgvUser.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUser.Size = new Size(685, 351);
            dgvUser.TabIndex = 3;
            // 
            // colNo
            // 
            colNo.FillWeight = 40F;
            colNo.HeaderText = "No";
            colNo.MinimumWidth = 8;
            colNo.Name = "colNo";
            colNo.ReadOnly = true;
            // 
            // colnNama
            // 
            colnNama.FillWeight = 160F;
            colnNama.HeaderText = "Nama";
            colnNama.MinimumWidth = 8;
            colnNama.Name = "colnNama";
            colnNama.ReadOnly = true;
            // 
            // colJenis
            // 
            colJenis.FillWeight = 75F;
            colJenis.HeaderText = "Jenis";
            colJenis.MinimumWidth = 8;
            colJenis.Name = "colJenis";
            colJenis.ReadOnly = true;
            // 
            // colStatus
            // 
            colStatus.FillWeight = 75F;
            colStatus.HeaderText = "Status";
            colStatus.MinimumWidth = 8;
            colStatus.Name = "colStatus";
            colStatus.ReadOnly = true;
            // 
            // colAksi
            // 
            colAksi.FillWeight = 75F;
            colAksi.HeaderText = "Aksi";
            colAksi.MinimumWidth = 8;
            colAksi.Name = "colAksi";
            colAksi.ReadOnly = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Bahnschrift SemiCondensed", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 14);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(76, 18);
            label2.TabIndex = 2;
            label2.Tag = "";
            label2.Text = "Daftar User";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift SemiCondensed", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(66, 11);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(52, 27);
            label1.TabIndex = 1;
            label1.Text = "User";
            // 
            // roundedPanel2
            // 
            roundedPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            roundedPanel2.BackColor = Color.Transparent;
            roundedPanel2.Controls.Add(btnBatal);
            roundedPanel2.Controls.Add(btnSimpan);
            roundedPanel2.Controls.Add(txtPassword);
            roundedPanel2.Controls.Add(cmbJenis);
            roundedPanel2.Controls.Add(label6);
            roundedPanel2.Controls.Add(txtNama);
            roundedPanel2.Controls.Add(label5);
            roundedPanel2.Controls.Add(label4);
            roundedPanel2.Controls.Add(label3);
            roundedPanel2.Location = new Point(769, 42);
            roundedPanel2.Margin = new Padding(2);
            roundedPanel2.Name = "roundedPanel2";
            roundedPanel2.Size = new Size(224, 205);
            roundedPanel2.TabIndex = 2;
            roundedPanel2.Paint += roundedPanel2_Paint;
            // 
            // btnBatal
            // 
            btnBatal.BackColor = Color.White;
            btnBatal.FlatAppearance.BorderSize = 0;
            btnBatal.FlatStyle = FlatStyle.Flat;
            btnBatal.ForeColor = Color.RoyalBlue;
            btnBatal.Location = new Point(113, 174);
            btnBatal.Margin = new Padding(2);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(62, 25);
            btnBatal.TabIndex = 12;
            btnBatal.Text = "Batal";
            btnBatal.UseVisualStyleBackColor = false;
            // 
            // btnSimpan
            // 
            btnSimpan.BackColor = Color.RoyalBlue;
            btnSimpan.FlatAppearance.BorderSize = 0;
            btnSimpan.FlatStyle = FlatStyle.Flat;
            btnSimpan.ForeColor = Color.White;
            btnSimpan.Location = new Point(47, 174);
            btnSimpan.Margin = new Padding(2);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(62, 25);
            btnSimpan.TabIndex = 11;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = false;
            // 
            // txtPassword
            // 
            txtPassword.BorderColor = Color.Black;
            txtPassword.Location = new Point(13, 140);
            txtPassword.Margin = new Padding(2);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(192, 30);
            txtPassword.TabIndex = 10;
            // 
            // cmbJenis
            // 
            cmbJenis.BackColor = SystemColors.Window;
            cmbJenis.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbJenis.FormattingEnabled = true;
            cmbJenis.Items.AddRange(new object[] { "Kasir", "Gudang" });
            cmbJenis.Location = new Point(14, 98);
            cmbJenis.Margin = new Padding(2);
            cmbJenis.Name = "cmbJenis";
            cmbJenis.Size = new Size(191, 23);
            cmbJenis.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri Light", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(12, 127);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(50, 13);
            label6.TabIndex = 8;
            label6.Text = "Password";
            // 
            // txtNama
            // 
            txtNama.BackColor = Color.White;
            txtNama.BorderColor = Color.Black;
            txtNama.Font = new Font("Calibri Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNama.Location = new Point(13, 53);
            txtNama.Margin = new Padding(2);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(192, 29);
            txtNama.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri Light", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(13, 85);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(27, 13);
            label5.TabIndex = 6;
            label5.Text = "Jenis";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri Light", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(13, 38);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(33, 13);
            label4.TabIndex = 5;
            label4.Text = "Nama";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift SemiCondensed", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(13, 9);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(84, 18);
            label3.TabIndex = 4;
            label3.Tag = "";
            label3.Text = "Tambah User";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(16, 6);
            pictureBox2.Margin = new Padding(2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(46, 32);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 465);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1190, 75);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // roundedPanel3
            // 
            roundedPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            roundedPanel3.BackColor = Color.Transparent;
            roundedPanel3.Controls.Add(label11);
            roundedPanel3.Controls.Add(label8);
            roundedPanel3.Controls.Add(roundedTextBox4);
            roundedPanel3.Controls.Add(roundedTextBox3);
            roundedPanel3.Controls.Add(roundedButton1);
            roundedPanel3.Controls.Add(roundedButton2);
            roundedPanel3.Controls.Add(roundedTextBox1);
            roundedPanel3.Controls.Add(label7);
            roundedPanel3.Controls.Add(roundedTextBox2);
            roundedPanel3.Controls.Add(label9);
            roundedPanel3.Controls.Add(label10);
            roundedPanel3.Location = new Point(769, 260);
            roundedPanel3.Margin = new Padding(2);
            roundedPanel3.Name = "roundedPanel3";
            roundedPanel3.Size = new Size(419, 191);
            roundedPanel3.TabIndex = 13;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Calibri Light", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(223, 90);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(124, 13);
            label11.TabIndex = 16;
            label11.Text = "Konfirmasi kata sandi baru";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Calibri Light", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(223, 43);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(75, 13);
            label8.TabIndex = 15;
            label8.Text = "Kata sandi baru";
            // 
            // roundedTextBox4
            // 
            roundedTextBox4.BackColor = Color.White;
            roundedTextBox4.BorderColor = Color.Black;
            roundedTextBox4.Font = new Font("Calibri Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            roundedTextBox4.Location = new Point(218, 105);
            roundedTextBox4.Margin = new Padding(2);
            roundedTextBox4.Name = "roundedTextBox4";
            roundedTextBox4.Size = new Size(190, 29);
            roundedTextBox4.TabIndex = 14;
            // 
            // roundedTextBox3
            // 
            roundedTextBox3.BackColor = Color.White;
            roundedTextBox3.BorderColor = Color.Black;
            roundedTextBox3.Font = new Font("Calibri Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            roundedTextBox3.Location = new Point(218, 58);
            roundedTextBox3.Margin = new Padding(2);
            roundedTextBox3.Name = "roundedTextBox3";
            roundedTextBox3.Size = new Size(190, 29);
            roundedTextBox3.TabIndex = 13;
            // 
            // roundedButton1
            // 
            roundedButton1.BackColor = Color.White;
            roundedButton1.FlatAppearance.BorderSize = 0;
            roundedButton1.FlatStyle = FlatStyle.Flat;
            roundedButton1.ForeColor = Color.RoyalBlue;
            roundedButton1.Location = new Point(91, 138);
            roundedButton1.Margin = new Padding(2);
            roundedButton1.Name = "roundedButton1";
            roundedButton1.Size = new Size(62, 25);
            roundedButton1.TabIndex = 12;
            roundedButton1.Text = "Batal";
            roundedButton1.UseVisualStyleBackColor = false;
            // 
            // roundedButton2
            // 
            roundedButton2.BackColor = Color.RoyalBlue;
            roundedButton2.FlatAppearance.BorderSize = 0;
            roundedButton2.FlatStyle = FlatStyle.Flat;
            roundedButton2.ForeColor = Color.White;
            roundedButton2.Location = new Point(25, 138);
            roundedButton2.Margin = new Padding(2);
            roundedButton2.Name = "roundedButton2";
            roundedButton2.Size = new Size(62, 25);
            roundedButton2.TabIndex = 11;
            roundedButton2.Text = "Simpan";
            roundedButton2.UseVisualStyleBackColor = false;
            // 
            // roundedTextBox1
            // 
            roundedTextBox1.BorderColor = Color.Black;
            roundedTextBox1.Location = new Point(12, 104);
            roundedTextBox1.Margin = new Padding(2);
            roundedTextBox1.Name = "roundedTextBox1";
            roundedTextBox1.Size = new Size(186, 30);
            roundedTextBox1.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Calibri Light", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(12, 89);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(75, 13);
            label7.TabIndex = 8;
            label7.Text = "Kata sandi lama";
            // 
            // roundedTextBox2
            // 
            roundedTextBox2.BackColor = Color.White;
            roundedTextBox2.BorderColor = Color.Black;
            roundedTextBox2.Font = new Font("Calibri Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            roundedTextBox2.Location = new Point(12, 58);
            roundedTextBox2.Margin = new Padding(2);
            roundedTextBox2.Name = "roundedTextBox2";
            roundedTextBox2.Size = new Size(190, 29);
            roundedTextBox2.TabIndex = 7;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Calibri Light", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(12, 43);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(33, 13);
            label9.TabIndex = 5;
            label9.Text = "Nama";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Bahnschrift SemiCondensed", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(23, 10);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(100, 18);
            label10.TabIndex = 4;
            label10.Tag = "";
            label10.Text = "Ganti Password";
            // 
            // UC_User
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            Controls.Add(roundedPanel3);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Controls.Add(roundedPanel2);
            Controls.Add(label1);
            Controls.Add(roundedPanel1);
            Name = "UC_User";
            Size = new Size(1190, 540);
            Load += UC_User_Load_1;
            roundedPanel1.ResumeLayout(false);
            roundedPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUser).EndInit();
            roundedPanel2.ResumeLayout(false);
            roundedPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            roundedPanel3.ResumeLayout(false);
            roundedPanel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RoundedPanel roundedPanel1;
        private DataGridView dgvUser;
        private Label label2;
        private Label label1;
        private RoundedPanel roundedPanel2;
        private RoundedTextBox txtNama;
        private Label label5;
        private Label label4;
        private Label label3;
        private RoundedTextBox txtPassword;
        private ComboBox cmbJenis;
        private Label label6;
        private RoundedButton btnBatal;
        private RoundedButton btnSimpan;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private DataGridViewTextBoxColumn colNo;
        private DataGridViewTextBoxColumn colnNama;
        private DataGridViewTextBoxColumn colJenis;
        private DataGridViewTextBoxColumn colStatus;
        private DataGridViewButtonColumn colAksi;
        private RoundedPanel roundedPanel3;
        private RoundedButton roundedButton1;
        private RoundedButton roundedButton2;
        private RoundedTextBox roundedTextBox1;
        private Label label7;
        private RoundedTextBox roundedTextBox2;
        private Label label9;
        private Label label10;
        private RoundedTextBox roundedTextBox4;
        private RoundedTextBox roundedTextBox3;
        private Label label8;
        private Label label11;
    }
}
