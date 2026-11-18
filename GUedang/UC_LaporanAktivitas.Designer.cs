namespace GUedang
{
    partial class UC_LaporanAktivitas
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            panelLaporanAktivitas = new Panel();
            roundedPanel2 = new RoundedPanel();
            dgvAktivitas = new DataGridView();
            colWaktu = new DataGridViewTextBoxColumn();
            colNama = new DataGridViewTextBoxColumn();
            colPeran = new DataGridViewTextBoxColumn();
            colAktivitas = new DataGridViewTextBoxColumn();
            roundedPanel1 = new RoundedPanel();
            label3 = new Label();
            cmbPeriode = new ComboBox();
            dtpWaktu = new DateTimePicker();
            label2 = new Label();
            cmbPeran = new ComboBox();
            label1 = new Label();
            timerJam = new System.Windows.Forms.Timer(components);
            panelLaporanAktivitas.SuspendLayout();
            roundedPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAktivitas).BeginInit();
            roundedPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panelLaporanAktivitas
            // 
            panelLaporanAktivitas.BackColor = Color.White;
            panelLaporanAktivitas.Controls.Add(roundedPanel2);
            panelLaporanAktivitas.Controls.Add(roundedPanel1);
            panelLaporanAktivitas.Controls.Add(label1);
            panelLaporanAktivitas.Dock = DockStyle.Fill;
            panelLaporanAktivitas.Location = new Point(0, 0);
            panelLaporanAktivitas.Name = "panelLaporanAktivitas";
            panelLaporanAktivitas.Size = new Size(1094, 593);
            panelLaporanAktivitas.TabIndex = 0;
            panelLaporanAktivitas.Paint += panelLaporanAktivitas_Paint;
            // 
            // roundedPanel2
            // 
            roundedPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            roundedPanel2.BackColor = Color.Transparent;
            roundedPanel2.Controls.Add(dgvAktivitas);
            roundedPanel2.Location = new Point(20, 148);
            roundedPanel2.Name = "roundedPanel2";
            roundedPanel2.Size = new Size(1040, 427);
            roundedPanel2.TabIndex = 4;
            // 
            // dgvAktivitas
            // 
            dgvAktivitas.AllowUserToAddRows = false;
            dgvAktivitas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = Color.AliceBlue;
            dgvAktivitas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvAktivitas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAktivitas.BackgroundColor = Color.White;
            dgvAktivitas.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.RoyalBlue;
            dataGridViewCellStyle5.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvAktivitas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvAktivitas.ColumnHeadersHeight = 45;
            dgvAktivitas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvAktivitas.Columns.AddRange(new DataGridViewColumn[] { colWaktu, colNama, colPeran, colAktivitas });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = Color.LightSlateGray;
            dataGridViewCellStyle6.SelectionBackColor = Color.LightSteelBlue;
            dataGridViewCellStyle6.SelectionForeColor = Color.DarkBlue;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvAktivitas.DefaultCellStyle = dataGridViewCellStyle6;
            dgvAktivitas.EnableHeadersVisualStyles = false;
            dgvAktivitas.Location = new Point(19, 23);
            dgvAktivitas.MultiSelect = false;
            dgvAktivitas.Name = "dgvAktivitas";
            dgvAktivitas.RowHeadersVisible = false;
            dgvAktivitas.RowHeadersWidth = 62;
            dgvAktivitas.RowTemplate.Height = 40;
            dgvAktivitas.Size = new Size(993, 387);
            dgvAktivitas.TabIndex = 3;
            // 
            // colWaktu
            // 
            colWaktu.DataPropertyName = "Waktu";
            colWaktu.FillWeight = 160F;
            colWaktu.HeaderText = "Waktu";
            colWaktu.MinimumWidth = 8;
            colWaktu.Name = "colWaktu";
            // 
            // colNama
            // 
            colNama.DataPropertyName = "Nama";
            colNama.FillWeight = 150F;
            colNama.HeaderText = "Nama";
            colNama.MinimumWidth = 8;
            colNama.Name = "colNama";
            // 
            // colPeran
            // 
            colPeran.DataPropertyName = "Peran";
            colPeran.FillWeight = 130F;
            colPeran.HeaderText = "peran";
            colPeran.MinimumWidth = 8;
            colPeran.Name = "colPeran";
            // 
            // colAktivitas
            // 
            colAktivitas.DataPropertyName = "Aktivitas";
            colAktivitas.FillWeight = 150F;
            colAktivitas.HeaderText = "Aktivitas";
            colAktivitas.MinimumWidth = 8;
            colAktivitas.Name = "colAktivitas";
            // 
            // roundedPanel1
            // 
            roundedPanel1.Anchor = AnchorStyles.Top;
            roundedPanel1.BackColor = Color.Transparent;
            roundedPanel1.Controls.Add(label3);
            roundedPanel1.Controls.Add(cmbPeriode);
            roundedPanel1.Controls.Add(dtpWaktu);
            roundedPanel1.Controls.Add(label2);
            roundedPanel1.Controls.Add(cmbPeran);
            roundedPanel1.Location = new Point(260, 20);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Size = new Size(800, 123);
            roundedPanel1.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(266, 18);
            label3.Name = "label3";
            label3.Size = new Size(71, 25);
            label3.TabIndex = 5;
            label3.Text = "Periode";
            // 
            // cmbPeriode
            // 
            cmbPeriode.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPeriode.FormattingEnabled = true;
            cmbPeriode.Items.AddRange(new object[] { "Semua", "Hari Ini", "7 Hari Terakhir", "1 Bulan Terakhir" });
            cmbPeriode.Location = new Point(266, 40);
            cmbPeriode.Name = "cmbPeriode";
            cmbPeriode.Size = new Size(182, 33);
            cmbPeriode.TabIndex = 4;
            // 
            // dtpWaktu
            // 
            dtpWaktu.CustomFormat = "dd MM yyyy HH;mm;ss";
            dtpWaktu.Format = DateTimePickerFormat.Custom;
            dtpWaktu.Location = new Point(559, 12);
            dtpWaktu.Name = "dtpWaktu";
            dtpWaktu.Size = new Size(200, 31);
            dtpWaktu.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 12);
            label2.Name = "label2";
            label2.Size = new Size(55, 25);
            label2.TabIndex = 3;
            label2.Text = "Peran";
            // 
            // cmbPeran
            // 
            cmbPeran.FormattingEnabled = true;
            cmbPeran.Items.AddRange(new object[] { "Semua Peran", "Admin", "Kasir", "Gudang" });
            cmbPeran.Location = new Point(29, 40);
            cmbPeran.Name = "cmbPeran";
            cmbPeran.Size = new Size(183, 33);
            cmbPeran.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(3, 32);
            label1.Name = "label1";
            label1.Size = new Size(188, 33);
            label1.TabIndex = 0;
            label1.Text = "Log Aktivitas";
            label1.Click += label1_Click;
            // 
            // timerJam
            // 
            timerJam.Enabled = true;
            timerJam.Interval = 1000;
            timerJam.Tick += timerJam_Tick;
            // 
            // UC_LaporanAktivitas
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelLaporanAktivitas);
            Name = "UC_LaporanAktivitas";
            Size = new Size(1094, 593);
            panelLaporanAktivitas.ResumeLayout(false);
            panelLaporanAktivitas.PerformLayout();
            roundedPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAktivitas).EndInit();
            roundedPanel1.ResumeLayout(false);
            roundedPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelLaporanAktivitas;
        private Label label1;
        private RoundedPanel roundedPanel1;
        private ComboBox cmbPeran;
        private DateTimePicker dtpWaktu;
        private Label label2;
        private DataGridView dgvAktivitas;
        private RoundedPanel roundedPanel2;
        private System.Windows.Forms.Timer timerJam;
        private DataGridViewTextBoxColumn colWaktu;
        private DataGridViewTextBoxColumn colNama;
        private DataGridViewTextBoxColumn colPeran;
        private DataGridViewTextBoxColumn colAktivitas;
        private Label label3;
        private ComboBox cmbPeriode;
    }
}
