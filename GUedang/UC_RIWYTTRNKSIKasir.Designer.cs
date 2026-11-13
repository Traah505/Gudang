namespace GUedang
{
    partial class UC_RIWYTTRNKSIKasir
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
            panel1 = new Panel();
            roundedPanel5 = new RoundedPanel();
            dgvRiwayatTransaksi = new DataGridView();
            colNoTransaksi = new DataGridViewTextBoxColumn();
            colWaktu = new DataGridViewTextBoxColumn();
            colKasir = new DataGridViewTextBoxColumn();
            colItem = new DataGridViewTextBoxColumn();
            colTotal = new DataGridViewTextBoxColumn();
            roundedPanel4 = new RoundedPanel();
            roundedPanel3 = new RoundedPanel();
            roundedPanel2 = new RoundedPanel();
            lblJumlahTransaksi = new Label();
            label6 = new Label();
            roundedPanel1 = new RoundedPanel();
            label2 = new Label();
            lblPendapatan = new Label();
            label3 = new Label();
            label1 = new Label();
            dtpTransaksi = new DateTimePicker();
            btnCetakLaporan = new RoundedButton();
            timerTransaksi = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            roundedPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRiwayatTransaksi).BeginInit();
            roundedPanel2.SuspendLayout();
            roundedPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(roundedPanel5);
            panel1.Controls.Add(roundedPanel4);
            panel1.Controls.Add(roundedPanel3);
            panel1.Controls.Add(roundedPanel2);
            panel1.Controls.Add(roundedPanel1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(dtpTransaksi);
            panel1.Controls.Add(btnCetakLaporan);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(877, 528);
            panel1.TabIndex = 7;
            // 
            // roundedPanel5
            // 
            roundedPanel5.BackColor = Color.Transparent;
            roundedPanel5.Controls.Add(dgvRiwayatTransaksi);
            roundedPanel5.Location = new Point(21, 159);
            roundedPanel5.Name = "roundedPanel5";
            roundedPanel5.Size = new Size(827, 304);
            roundedPanel5.TabIndex = 21;
            // 
            // dgvRiwayatTransaksi
            // 
            dgvRiwayatTransaksi.AllowUserToAddRows = false;
            dgvRiwayatTransaksi.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(239, 244, 252);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(45, 55, 72);
            dgvRiwayatTransaksi.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvRiwayatTransaksi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRiwayatTransaksi.BackgroundColor = Color.White;
            dgvRiwayatTransaksi.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.RoyalBlue;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.RoyalBlue;
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvRiwayatTransaksi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvRiwayatTransaksi.ColumnHeadersHeight = 42;
            dgvRiwayatTransaksi.Columns.AddRange(new DataGridViewColumn[] { colNoTransaksi, colWaktu, colKasir, colItem, colTotal });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(45, 55, 72);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(239, 244, 252);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(30, 64, 72);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvRiwayatTransaksi.DefaultCellStyle = dataGridViewCellStyle6;
            dgvRiwayatTransaksi.EnableHeadersVisualStyles = false;
            dgvRiwayatTransaksi.GridColor = Color.FromArgb(220, 225, 235);
            dgvRiwayatTransaksi.Location = new Point(18, 15);
            dgvRiwayatTransaksi.MultiSelect = false;
            dgvRiwayatTransaksi.Name = "dgvRiwayatTransaksi";
            dgvRiwayatTransaksi.RowHeadersVisible = false;
            dgvRiwayatTransaksi.RowHeadersWidth = 62;
            dgvRiwayatTransaksi.RowTemplate.Height = 38;
            dgvRiwayatTransaksi.Size = new Size(787, 271);
            dgvRiwayatTransaksi.TabIndex = 0;
            // 
            // colNoTransaksi
            // 
            colNoTransaksi.FillWeight = 150F;
            colNoTransaksi.HeaderText = "No Transaksi";
            colNoTransaksi.MinimumWidth = 8;
            colNoTransaksi.Name = "colNoTransaksi";
            // 
            // colWaktu
            // 
            colWaktu.FillWeight = 110F;
            colWaktu.HeaderText = "Waktu";
            colWaktu.MinimumWidth = 8;
            colWaktu.Name = "colWaktu";
            // 
            // colKasir
            // 
            colKasir.FillWeight = 120F;
            colKasir.HeaderText = "Kasir";
            colKasir.MinimumWidth = 8;
            colKasir.Name = "colKasir";
            // 
            // colItem
            // 
            colItem.FillWeight = 90F;
            colItem.HeaderText = "Item";
            colItem.MinimumWidth = 8;
            colItem.Name = "colItem";
            // 
            // colTotal
            // 
            colTotal.FillWeight = 110F;
            colTotal.HeaderText = "Total";
            colTotal.MinimumWidth = 8;
            colTotal.Name = "colTotal";
            // 
            // roundedPanel4
            // 
            roundedPanel4.BackColor = Color.Transparent;
            roundedPanel4.Location = new Point(333, 62);
            roundedPanel4.Name = "roundedPanel4";
            roundedPanel4.Size = new Size(26, 91);
            roundedPanel4.TabIndex = 20;
            // 
            // roundedPanel3
            // 
            roundedPanel3.BackColor = Color.Transparent;
            roundedPanel3.Location = new Point(39, 62);
            roundedPanel3.Name = "roundedPanel3";
            roundedPanel3.Size = new Size(26, 91);
            roundedPanel3.TabIndex = 19;
            // 
            // roundedPanel2
            // 
            roundedPanel2.BackColor = Color.Transparent;
            roundedPanel2.BorderStyle = BorderStyle.Fixed3D;
            roundedPanel2.Controls.Add(lblJumlahTransaksi);
            roundedPanel2.Controls.Add(label6);
            roundedPanel2.Location = new Point(333, 62);
            roundedPanel2.Name = "roundedPanel2";
            roundedPanel2.Size = new Size(245, 91);
            roundedPanel2.TabIndex = 18;
            // 
            // lblJumlahTransaksi
            // 
            lblJumlahTransaksi.AutoSize = true;
            lblJumlahTransaksi.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblJumlahTransaksi.ForeColor = Color.White;
            lblJumlahTransaksi.Location = new Point(30, 38);
            lblJumlahTransaksi.Name = "lblJumlahTransaksi";
            lblJumlahTransaksi.Size = new Size(31, 33);
            lblJumlahTransaksi.TabIndex = 13;
            lblJumlahTransaksi.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.White;
            label6.Location = new Point(30, 13);
            label6.Name = "label6";
            label6.Size = new Size(142, 25);
            label6.TabIndex = 12;
            label6.Text = "Jumlah Transaksi";
            // 
            // roundedPanel1
            // 
            roundedPanel1.BackColor = Color.Transparent;
            roundedPanel1.BorderStyle = BorderStyle.Fixed3D;
            roundedPanel1.Controls.Add(label2);
            roundedPanel1.Controls.Add(lblPendapatan);
            roundedPanel1.Controls.Add(label3);
            roundedPanel1.Location = new Point(39, 62);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Size = new Size(266, 91);
            roundedPanel1.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(30, 38);
            label2.Name = "label2";
            label2.Size = new Size(52, 33);
            label2.TabIndex = 16;
            label2.Text = "Rp";
            label2.Click += label2_Click;
            // 
            // lblPendapatan
            // 
            lblPendapatan.AutoSize = true;
            lblPendapatan.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPendapatan.ForeColor = Color.White;
            lblPendapatan.Location = new Point(77, 38);
            lblPendapatan.Name = "lblPendapatan";
            lblPendapatan.Size = new Size(31, 33);
            lblPendapatan.TabIndex = 13;
            lblPendapatan.Text = "0";
            lblPendapatan.Click += lblNominalTransaksi_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(30, 13);
            label3.Name = "label3";
            label3.Size = new Size(147, 25);
            label3.TabIndex = 12;
            label3.Text = "Total Pendapatan";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(153, 45);
            label1.TabIndex = 8;
            label1.Text = "Transaksi";
            // 
            // dtpTransaksi
            // 
            dtpTransaksi.CustomFormat = "dd/MM/yyyy ; HH.mm.ss";
            dtpTransaksi.Format = DateTimePickerFormat.Custom;
            dtpTransaksi.Location = new Point(618, 14);
            dtpTransaksi.Name = "dtpTransaksi";
            dtpTransaksi.Size = new Size(230, 31);
            dtpTransaksi.TabIndex = 10;
            // 
            // btnCetakLaporan
            // 
            btnCetakLaporan.BackColor = Color.RoyalBlue;
            btnCetakLaporan.FlatAppearance.BorderSize = 0;
            btnCetakLaporan.FlatStyle = FlatStyle.Flat;
            btnCetakLaporan.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCetakLaporan.ForeColor = Color.White;
            btnCetakLaporan.Location = new Point(666, 469);
            btnCetakLaporan.Name = "btnCetakLaporan";
            btnCetakLaporan.Size = new Size(200, 51);
            btnCetakLaporan.TabIndex = 15;
            btnCetakLaporan.Text = "▣ Cetak Struk  ›";
            btnCetakLaporan.UseVisualStyleBackColor = false;
            // 
            // timerTransaksi
            // 
            timerTransaksi.Enabled = true;
            timerTransaksi.Interval = 1000;
            timerTransaksi.Tick += timerTransaksi_Tick;
            // 
            // UC_RIWYTTRNKSIKasir
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panel1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "UC_RIWYTTRNKSIKasir";
            Size = new Size(877, 528);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            roundedPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRiwayatTransaksi).EndInit();
            roundedPanel2.ResumeLayout(false);
            roundedPanel2.PerformLayout();
            roundedPanel1.ResumeLayout(false);
            roundedPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Label label1;
        private DateTimePicker dtpTransaksi;
        private Label label3;
        private Label lblPendapatan;
        private RoundedButton btnCetakLaporan;
        private Label label2;
        private RoundedPanel roundedPanel1;
        private RoundedPanel roundedPanel2;
        private Label label4;
        private Label lblJumlahTransaksi;
        private Label label6;
        private RoundedPanel roundedPanel4;
        private RoundedPanel roundedPanel3;
        private RoundedPanel roundedPanel5;
        private DataGridView dgvRiwayatTransaksi;
        private DataGridViewTextBoxColumn colNoTransaksi;
        private DataGridViewTextBoxColumn colWaktu;
        private DataGridViewTextBoxColumn colKasir;
        private DataGridViewTextBoxColumn colItem;
        private DataGridViewTextBoxColumn colTotal;
        private System.Windows.Forms.Timer timerTransaksi;
    }
}
