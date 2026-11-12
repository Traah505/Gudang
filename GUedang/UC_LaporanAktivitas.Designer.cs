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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panelLaporanAktivitas = new Panel();
            roundedPanel1 = new RoundedPanel();
            label1 = new Label();
            cmbPeran = new ComboBox();
            dtpWaktu = new DateTimePicker();
            label2 = new Label();
            dgvAktivitas = new DataGridView();
            roundedPanel2 = new RoundedPanel();
            colWaktu = new DataGridViewTextBoxColumn();
            colNama = new DataGridViewTextBoxColumn();
            colPeran = new DataGridViewTextBoxColumn();
            colAktivitas = new DataGridViewTextBoxColumn();
            timerJam = new System.Windows.Forms.Timer(components);
            panelLaporanAktivitas.SuspendLayout();
            roundedPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAktivitas).BeginInit();
            roundedPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // panelLaporanAktivitas
            // 
            panelLaporanAktivitas.BackColor = Color.White;
            panelLaporanAktivitas.Controls.Add(roundedPanel2);
            panelLaporanAktivitas.Controls.Add(roundedPanel1);
            panelLaporanAktivitas.Dock = DockStyle.Fill;
            panelLaporanAktivitas.Location = new Point(0, 0);
            panelLaporanAktivitas.Name = "panelLaporanAktivitas";
            panelLaporanAktivitas.Size = new Size(1095, 593);
            panelLaporanAktivitas.TabIndex = 0;
            panelLaporanAktivitas.Paint += panelLaporanAktivitas_Paint;
            // 
            // roundedPanel1
            // 
            roundedPanel1.BackColor = Color.Transparent;
            roundedPanel1.Controls.Add(dtpWaktu);
            roundedPanel1.Controls.Add(label2);
            roundedPanel1.Controls.Add(label1);
            roundedPanel1.Controls.Add(cmbPeran);
            roundedPanel1.Location = new Point(20, 20);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Size = new Size(1040, 123);
            roundedPanel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(19, 12);
            label1.Name = "label1";
            label1.Size = new Size(188, 33);
            label1.TabIndex = 0;
            label1.Text = "Log Aktivitas";
            label1.Click += label1_Click;
            // 
            // cmbPeran
            // 
            cmbPeran.FormattingEnabled = true;
            cmbPeran.Items.AddRange(new object[] { "Semua Peran", "Admin", "Kasir", "Gudang" });
            cmbPeran.Location = new Point(830, 69);
            cmbPeran.Name = "cmbPeran";
            cmbPeran.Size = new Size(182, 33);
            cmbPeran.TabIndex = 1;
            // 
            // dtpWaktu
            // 
            dtpWaktu.CustomFormat = "dd MM yyyy HH;mm;ss";
            dtpWaktu.Format = DateTimePickerFormat.Custom;
            dtpWaktu.Location = new Point(812, 13);
            dtpWaktu.Name = "dtpWaktu";
            dtpWaktu.Size = new Size(200, 31);
            dtpWaktu.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(769, 72);
            label2.Name = "label2";
            label2.Size = new Size(55, 25);
            label2.TabIndex = 3;
            label2.Text = "Peran";
            // 
            // dgvAktivitas
            // 
            dgvAktivitas.AllowUserToAddRows = false;
            dgvAktivitas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.AliceBlue;
            dgvAktivitas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvAktivitas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAktivitas.BackgroundColor = Color.White;
            dgvAktivitas.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.RoyalBlue;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvAktivitas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvAktivitas.ColumnHeadersHeight = 45;
            dgvAktivitas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvAktivitas.Columns.AddRange(new DataGridViewColumn[] { colWaktu, colNama, colPeran, colAktivitas });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.LightSlateGray;
            dataGridViewCellStyle3.SelectionBackColor = Color.LightSteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = Color.DarkBlue;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvAktivitas.DefaultCellStyle = dataGridViewCellStyle3;
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
            // roundedPanel2
            // 
            roundedPanel2.BackColor = Color.Transparent;
            roundedPanel2.Controls.Add(dgvAktivitas);
            roundedPanel2.Location = new Point(20, 149);
            roundedPanel2.Name = "roundedPanel2";
            roundedPanel2.Size = new Size(1040, 427);
            roundedPanel2.TabIndex = 4;
            // 
            // colWaktu
            // 
            colWaktu.FillWeight = 160F;
            colWaktu.HeaderText = "Waktu";
            colWaktu.MinimumWidth = 8;
            colWaktu.Name = "colWaktu";
            // 
            // colNama
            // 
            colNama.FillWeight = 150F;
            colNama.HeaderText = "Nama";
            colNama.MinimumWidth = 8;
            colNama.Name = "colNama";
            // 
            // colPeran
            // 
            colPeran.FillWeight = 130F;
            colPeran.HeaderText = "peran";
            colPeran.MinimumWidth = 8;
            colPeran.Name = "colPeran";
            // 
            // colAktivitas
            // 
            colAktivitas.FillWeight = 150F;
            colAktivitas.HeaderText = "Aktivitas";
            colAktivitas.MinimumWidth = 8;
            colAktivitas.Name = "colAktivitas";
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
            Size = new Size(1095, 593);
            panelLaporanAktivitas.ResumeLayout(false);
            roundedPanel1.ResumeLayout(false);
            roundedPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAktivitas).EndInit();
            roundedPanel2.ResumeLayout(false);
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
        private DataGridViewTextBoxColumn colWaktu;
        private DataGridViewTextBoxColumn colNama;
        private DataGridViewTextBoxColumn colPeran;
        private DataGridViewTextBoxColumn colAktivitas;
        private System.Windows.Forms.Timer timerJam;
    }
}
