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
            btnBatal = new Rondedbuton();
            btnSImpan = new Rondedbuton();
            txtPassword = new RoundedTextBox();
            comboBox1 = new ComboBox();
            label6 = new Label();
            txtNama = new RoundedTextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            roundedPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUser).BeginInit();
            roundedPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // roundedPanel1
            // 
            roundedPanel1.BackColor = Color.White;
            roundedPanel1.Controls.Add(dgvUser);
            roundedPanel1.Controls.Add(label2);
            roundedPanel1.Location = new Point(237, 68);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Size = new Size(572, 430);
            roundedPanel1.TabIndex = 0;
            // 
            // dgvUser
            // 
            dgvUser.AllowUserToAddRows = false;
            dgvUser.AllowUserToDeleteRows = false;
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
            dgvUser.Location = new Point(6, 45);
            dgvUser.Name = "dgvUser";
            dgvUser.ReadOnly = true;
            dgvUser.RowHeadersVisible = false;
            dgvUser.RowHeadersWidth = 62;
            dgvUser.RowTemplate.Height = 38;
            dgvUser.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUser.Size = new Size(563, 365);
            dgvUser.TabIndex = 3;
            // 
            // colNo
            // 
            colNo.FillWeight = 60F;
            colNo.HeaderText = "No";
            colNo.MinimumWidth = 8;
            colNo.Name = "colNo";
            colNo.ReadOnly = true;
            // 
            // colnNama
            // 
            colnNama.FillWeight = 175F;
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
            label2.Font = new Font("Bahnschrift SemiCondensed", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(17, 15);
            label2.Name = "label2";
            label2.Size = new Size(108, 27);
            label2.TabIndex = 2;
            label2.Tag = "";
            label2.Text = "Daftar User";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift SemiCondensed", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(297, 23);
            label1.Name = "label1";
            label1.Size = new Size(75, 39);
            label1.TabIndex = 1;
            label1.Text = "User";
            // 
            // roundedPanel2
            // 
            roundedPanel2.BackColor = Color.Transparent;
            roundedPanel2.Controls.Add(btnBatal);
            roundedPanel2.Controls.Add(btnSImpan);
            roundedPanel2.Controls.Add(txtPassword);
            roundedPanel2.Controls.Add(comboBox1);
            roundedPanel2.Controls.Add(label6);
            roundedPanel2.Controls.Add(txtNama);
            roundedPanel2.Controls.Add(label5);
            roundedPanel2.Controls.Add(label4);
            roundedPanel2.Controls.Add(label3);
            roundedPanel2.Location = new Point(836, 68);
            roundedPanel2.Name = "roundedPanel2";
            roundedPanel2.Size = new Size(225, 367);
            roundedPanel2.TabIndex = 2;
            // 
            // btnBatal
            // 
            btnBatal.BackColor = Color.White;
            btnBatal.FlatAppearance.BorderSize = 0;
            btnBatal.FlatStyle = FlatStyle.Flat;
            btnBatal.ForeColor = Color.RoyalBlue;
            btnBatal.Location = new Point(114, 303);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(88, 41);
            btnBatal.TabIndex = 12;
            btnBatal.Text = "Batal";
            btnBatal.UseVisualStyleBackColor = false;
            // 
            // btnSImpan
            // 
            btnSImpan.BackColor = Color.RoyalBlue;
            btnSImpan.FlatAppearance.BorderSize = 0;
            btnSImpan.FlatStyle = FlatStyle.Flat;
            btnSImpan.ForeColor = Color.White;
            btnSImpan.Location = new Point(20, 303);
            btnSImpan.Name = "btnSImpan";
            btnSImpan.Size = new Size(88, 41);
            btnSImpan.TabIndex = 11;
            btnSImpan.Text = "Simpan";
            btnSImpan.UseVisualStyleBackColor = false;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(19, 230);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(177, 48);
            txtPassword.TabIndex = 10;
            txtPassword.Text = "Password awal";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Kasir", "Gudang" });
            comboBox1.Location = new Point(20, 155);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 33);
            comboBox1.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri Light", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(19, 208);
            label6.Name = "label6";
            label6.Size = new Size(70, 19);
            label6.TabIndex = 8;
            label6.Text = "Password";
            // 
            // txtNama
            // 
            txtNama.Font = new Font("Calibri Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNama.Location = new Point(19, 67);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(183, 48);
            txtNama.TabIndex = 7;
            txtNama.Text = "Nama Lengkap";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri Light", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(19, 133);
            label5.Name = "label5";
            label5.Size = new Size(40, 19);
            label5.TabIndex = 6;
            label5.Text = "Jenis";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri Light", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(19, 45);
            label4.Name = "label4";
            label4.Size = new Size(48, 19);
            label4.TabIndex = 5;
            label4.Text = "Nama";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift SemiCondensed", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(19, 15);
            label3.Name = "label3";
            label3.Size = new Size(121, 27);
            label3.TabIndex = 4;
            label3.Tag = "";
            label3.Text = "Tambah User";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(237, 9);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(66, 53);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // UC_User
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pictureBox2);
            Controls.Add(roundedPanel2);
            Controls.Add(label1);
            Controls.Add(roundedPanel1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "UC_User";
            Size = new Size(1095, 533);
            roundedPanel1.ResumeLayout(false);
            roundedPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUser).EndInit();
            roundedPanel2.ResumeLayout(false);
            roundedPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RoundedPanel roundedPanel1;
        private DataGridView dgvUser;
        private Label label2;
        private Label label1;
        private DataGridViewTextBoxColumn colNo;
        private DataGridViewTextBoxColumn colnNama;
        private DataGridViewTextBoxColumn colJenis;
        private DataGridViewTextBoxColumn colStatus;
        private DataGridViewButtonColumn colAksi;
        private RoundedPanel roundedPanel2;
        private RoundedTextBox txtNama;
        private Label label5;
        private Label label4;
        private Label label3;
        private RoundedTextBox txtPassword;
        private ComboBox comboBox1;
        private Label label6;
        private Rondedbuton btnBatal;
        private Rondedbuton btnSImpan;
        private PictureBox pictureBox2;
    }
}
