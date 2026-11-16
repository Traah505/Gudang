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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panelContent2 = new RoundedPanel();
            panel2 = new Panel();
            roundedPanel2 = new RoundedPanel();
            label16 = new Label();
            label2 = new Label();
            lblJumlahKasir = new Label();
            roundedPanel3 = new RoundedPanel();
            label15 = new Label();
            label7 = new Label();
            lblJumlahGudang = new Label();
            roundedPanel4 = new RoundedPanel();
            label18 = new Label();
            label5 = new Label();
            lblBarangMenipis = new Label();
            roundedPanel5 = new RoundedPanel();
            label19 = new Label();
            lblBarangHabis = new Label();
            label6 = new Label();
            panel1 = new Panel();
            roundedPanel7 = new RoundedPanel();
            label17 = new Label();
            roundedPanel6 = new RoundedPanel();
            lblStokSaatIni = new Label();
            label13 = new Label();
            lblKeluar = new Label();
            label14 = new Label();
            lblMasuk = new Label();
            label12 = new Label();
            label11 = new Label();
            roundedPanel1 = new RoundedPanel();
            lblTransaksiHariIni = new Label();
            label9 = new Label();
            label10 = new Label();
            lblPendapatanHariIni = new Label();
            label8 = new Label();
            label4 = new Label();
            label3 = new Label();
            dgvPengguna = new DataGridView();
            colNo = new DataGridViewTextBoxColumn();
            colNama = new DataGridViewTextBoxColumn();
            colJenis = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            label1 = new Label();
            panelContent2.SuspendLayout();
            panel2.SuspendLayout();
            roundedPanel2.SuspendLayout();
            roundedPanel3.SuspendLayout();
            roundedPanel4.SuspendLayout();
            roundedPanel5.SuspendLayout();
            panel1.SuspendLayout();
            roundedPanel6.SuspendLayout();
            roundedPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPengguna).BeginInit();
            SuspendLayout();
            // 
            // panelContent2
            // 
            panelContent2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelContent2.BackColor = Color.Transparent;
            panelContent2.Controls.Add(panel2);
            panelContent2.Controls.Add(panel1);
            panelContent2.Controls.Add(roundedPanel6);
            panelContent2.Controls.Add(roundedPanel1);
            panelContent2.Controls.Add(label3);
            panelContent2.Controls.Add(dgvPengguna);
            panelContent2.Controls.Add(label1);
            panelContent2.Location = new Point(3, 3);
            panelContent2.Name = "panelContent2";
            panelContent2.Size = new Size(993, 381);
            panelContent2.TabIndex = 4;
            panelContent2.Paint += panelContent2_Paint;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(roundedPanel2);
            panel2.Controls.Add(roundedPanel3);
            panel2.Controls.Add(roundedPanel4);
            panel2.Controls.Add(roundedPanel5);
            panel2.Location = new Point(2, 44);
            panel2.Margin = new Padding(2, 2, 2, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(977, 85);
            panel2.TabIndex = 22;
            // 
            // roundedPanel2
            // 
            roundedPanel2.BackColor = Color.Transparent;
            roundedPanel2.Controls.Add(label16);
            roundedPanel2.Controls.Add(label2);
            roundedPanel2.Controls.Add(lblJumlahKasir);
            roundedPanel2.Location = new Point(18, 15);
            roundedPanel2.Margin = new Padding(2, 2, 2, 2);
            roundedPanel2.Name = "roundedPanel2";
            roundedPanel2.Size = new Size(226, 63);
            roundedPanel2.TabIndex = 15;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Arial", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label16.ForeColor = Color.RoyalBlue;
            label16.Location = new Point(18, 46);
            label16.Margin = new Padding(2, 0, 2, 0);
            label16.Name = "label16";
            label16.Size = new Size(74, 14);
            label16.TabIndex = 17;
            label16.Text = "Petugas Kasir";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.RoyalBlue;
            label2.Location = new Point(18, 9);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(76, 15);
            label2.TabIndex = 11;
            label2.Text = "Jumlah Kasir";
            // 
            // lblJumlahKasir
            // 
            lblJumlahKasir.AutoSize = true;
            lblJumlahKasir.Font = new Font("Arial", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblJumlahKasir.ForeColor = Color.RoyalBlue;
            lblJumlahKasir.Location = new Point(18, 24);
            lblJumlahKasir.Margin = new Padding(2, 0, 2, 0);
            lblJumlahKasir.Name = "lblJumlahKasir";
            lblJumlahKasir.Size = new Size(24, 26);
            lblJumlahKasir.TabIndex = 14;
            lblJumlahKasir.Text = "0";
            // 
            // roundedPanel3
            // 
            roundedPanel3.BackColor = Color.Transparent;
            roundedPanel3.Controls.Add(label15);
            roundedPanel3.Controls.Add(label7);
            roundedPanel3.Controls.Add(lblJumlahGudang);
            roundedPanel3.Location = new Point(248, 16);
            roundedPanel3.Margin = new Padding(2, 2, 2, 2);
            roundedPanel3.Name = "roundedPanel3";
            roundedPanel3.Size = new Size(226, 63);
            roundedPanel3.TabIndex = 16;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Arial", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.SeaGreen;
            label15.Location = new Point(28, 43);
            label15.Margin = new Padding(2, 0, 2, 0);
            label15.Name = "label15";
            label15.Size = new Size(87, 14);
            label15.TabIndex = 16;
            label15.Text = "Petugas Gudang";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.SeaGreen;
            label7.Location = new Point(27, 7);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(50, 15);
            label7.TabIndex = 13;
            label7.Text = "Gudang";
            // 
            // lblJumlahGudang
            // 
            lblJumlahGudang.AutoSize = true;
            lblJumlahGudang.Font = new Font("Arial", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblJumlahGudang.ForeColor = Color.SeaGreen;
            lblJumlahGudang.Location = new Point(28, 21);
            lblJumlahGudang.Margin = new Padding(2, 0, 2, 0);
            lblJumlahGudang.Name = "lblJumlahGudang";
            lblJumlahGudang.Size = new Size(24, 26);
            lblJumlahGudang.TabIndex = 15;
            lblJumlahGudang.Text = "0";
            // 
            // roundedPanel4
            // 
            roundedPanel4.BackColor = Color.Transparent;
            roundedPanel4.Controls.Add(label18);
            roundedPanel4.Controls.Add(label5);
            roundedPanel4.Controls.Add(lblBarangMenipis);
            roundedPanel4.Location = new Point(492, 16);
            roundedPanel4.Margin = new Padding(2, 2, 2, 2);
            roundedPanel4.Name = "roundedPanel4";
            roundedPanel4.Size = new Size(226, 63);
            roundedPanel4.TabIndex = 17;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.BackColor = Color.Transparent;
            label18.Font = new Font("Calibri Light", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label18.ForeColor = Color.Goldenrod;
            label18.Location = new Point(15, 43);
            label18.Margin = new Padding(2, 0, 2, 0);
            label18.Name = "label18";
            label18.Size = new Size(93, 17);
            label18.TabIndex = 18;
            label18.Text = "Perlu di Periksa";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Goldenrod;
            label5.Location = new Point(15, 7);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(92, 15);
            label5.TabIndex = 16;
            label5.Text = "Barang Menipis";
            // 
            // lblBarangMenipis
            // 
            lblBarangMenipis.AutoSize = true;
            lblBarangMenipis.BackColor = Color.Transparent;
            lblBarangMenipis.Font = new Font("Arial", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBarangMenipis.ForeColor = Color.Goldenrod;
            lblBarangMenipis.Location = new Point(15, 20);
            lblBarangMenipis.Margin = new Padding(2, 0, 2, 0);
            lblBarangMenipis.Name = "lblBarangMenipis";
            lblBarangMenipis.Size = new Size(24, 26);
            lblBarangMenipis.TabIndex = 17;
            lblBarangMenipis.Text = "0";
            // 
            // roundedPanel5
            // 
            roundedPanel5.BackColor = Color.Transparent;
            roundedPanel5.Controls.Add(label19);
            roundedPanel5.Controls.Add(lblBarangHabis);
            roundedPanel5.Controls.Add(label6);
            roundedPanel5.Location = new Point(735, 16);
            roundedPanel5.Margin = new Padding(2, 2, 2, 2);
            roundedPanel5.Name = "roundedPanel5";
            roundedPanel5.Size = new Size(226, 63);
            roundedPanel5.TabIndex = 18;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.BackColor = Color.MistyRose;
            label19.Font = new Font("Calibri Light", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label19.ForeColor = Color.IndianRed;
            label19.Location = new Point(27, 43);
            label19.Margin = new Padding(2, 0, 2, 0);
            label19.Name = "label19";
            label19.Size = new Size(94, 17);
            label19.TabIndex = 20;
            label19.Text = "Perlu ditambah";
            // 
            // lblBarangHabis
            // 
            lblBarangHabis.AutoSize = true;
            lblBarangHabis.BackColor = Color.MistyRose;
            lblBarangHabis.Font = new Font("Arial", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBarangHabis.ForeColor = Color.IndianRed;
            lblBarangHabis.Location = new Point(27, 23);
            lblBarangHabis.Margin = new Padding(2, 0, 2, 0);
            lblBarangHabis.Name = "lblBarangHabis";
            lblBarangHabis.Size = new Size(24, 26);
            lblBarangHabis.TabIndex = 19;
            lblBarangHabis.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.MistyRose;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.IndianRed;
            label6.Location = new Point(27, 9);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(79, 15);
            label6.TabIndex = 18;
            label6.Text = "Barang Habis";
            label6.Click += label6_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.RoyalBlue;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(roundedPanel7);
            panel1.Controls.Add(label17);
            panel1.Location = new Point(22, 126);
            panel1.Margin = new Padding(2, 2, 2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(410, 21);
            panel1.TabIndex = 21;
            // 
            // roundedPanel7
            // 
            roundedPanel7.BackColor = Color.Transparent;
            roundedPanel7.Location = new Point(-1, 20);
            roundedPanel7.Margin = new Padding(2, 2, 2, 2);
            roundedPanel7.Name = "roundedPanel7";
            roundedPanel7.Size = new Size(410, 227);
            roundedPanel7.TabIndex = 23;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.ForeColor = Color.White;
            label17.Location = new Point(8, 5);
            label17.Margin = new Padding(2, 0, 2, 0);
            label17.Name = "label17";
            label17.Size = new Size(124, 16);
            label17.TabIndex = 20;
            label17.Text = "Daftar Pengguna";
            // 
            // roundedPanel6
            // 
            roundedPanel6.Anchor = AnchorStyles.Right;
            roundedPanel6.BackColor = Color.Transparent;
            roundedPanel6.Controls.Add(lblStokSaatIni);
            roundedPanel6.Controls.Add(label13);
            roundedPanel6.Controls.Add(lblKeluar);
            roundedPanel6.Controls.Add(label14);
            roundedPanel6.Controls.Add(lblMasuk);
            roundedPanel6.Controls.Add(label12);
            roundedPanel6.Controls.Add(label11);
            roundedPanel6.Location = new Point(465, 264);
            roundedPanel6.Margin = new Padding(2, 2, 2, 2);
            roundedPanel6.Name = "roundedPanel6";
            roundedPanel6.Size = new Size(514, 117);
            roundedPanel6.TabIndex = 20;
            // 
            // lblStokSaatIni
            // 
            lblStokSaatIni.AutoSize = true;
            lblStokSaatIni.Font = new Font("Arial", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStokSaatIni.ForeColor = Color.CadetBlue;
            lblStokSaatIni.Location = new Point(324, 79);
            lblStokSaatIni.Margin = new Padding(2, 0, 2, 0);
            lblStokSaatIni.Name = "lblStokSaatIni";
            lblStokSaatIni.Size = new Size(24, 26);
            lblStokSaatIni.TabIndex = 24;
            lblStokSaatIni.Text = "0";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Calibri Light", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.Gray;
            label13.Location = new Point(319, 64);
            label13.Margin = new Padding(2, 0, 2, 0);
            label13.Name = "label13";
            label13.Size = new Size(76, 17);
            label13.TabIndex = 23;
            label13.Text = "Stok Saat ini";
            // 
            // lblKeluar
            // 
            lblKeluar.AutoSize = true;
            lblKeluar.Font = new Font("Arial", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblKeluar.ForeColor = Color.CadetBlue;
            lblKeluar.Location = new Point(181, 79);
            lblKeluar.Margin = new Padding(2, 0, 2, 0);
            lblKeluar.Name = "lblKeluar";
            lblKeluar.Size = new Size(24, 26);
            lblKeluar.TabIndex = 22;
            lblKeluar.Text = "0";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Calibri Light", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.Gray;
            label14.Location = new Point(181, 64);
            label14.Margin = new Padding(2, 0, 2, 0);
            label14.Name = "label14";
            label14.Size = new Size(88, 17);
            label14.TabIndex = 21;
            label14.Text = "Barang Keluar";
            // 
            // lblMasuk
            // 
            lblMasuk.AutoSize = true;
            lblMasuk.Font = new Font("Arial", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMasuk.ForeColor = Color.CadetBlue;
            lblMasuk.Location = new Point(18, 79);
            lblMasuk.Margin = new Padding(2, 0, 2, 0);
            lblMasuk.Name = "lblMasuk";
            lblMasuk.Size = new Size(24, 26);
            lblMasuk.TabIndex = 20;
            lblMasuk.Text = "0";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Calibri Light", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.Gray;
            label12.Location = new Point(18, 64);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(89, 17);
            label12.TabIndex = 20;
            label12.Text = "Barang Masuk";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.DarkCyan;
            label11.Location = new Point(18, 19);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(126, 16);
            label11.TabIndex = 20;
            label11.Text = "Aktivitas Gudang";
            // 
            // roundedPanel1
            // 
            roundedPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            roundedPanel1.BackColor = Color.Transparent;
            roundedPanel1.Controls.Add(lblTransaksiHariIni);
            roundedPanel1.Controls.Add(label9);
            roundedPanel1.Controls.Add(label10);
            roundedPanel1.Controls.Add(lblPendapatanHariIni);
            roundedPanel1.Controls.Add(label8);
            roundedPanel1.Controls.Add(label4);
            roundedPanel1.Location = new Point(465, 133);
            roundedPanel1.Margin = new Padding(2, 2, 2, 2);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Size = new Size(514, 117);
            roundedPanel1.TabIndex = 19;
            // 
            // lblTransaksiHariIni
            // 
            lblTransaksiHariIni.AutoSize = true;
            lblTransaksiHariIni.Font = new Font("Arial", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTransaksiHariIni.ForeColor = Color.RoyalBlue;
            lblTransaksiHariIni.Location = new Point(324, 67);
            lblTransaksiHariIni.Margin = new Padding(2, 0, 2, 0);
            lblTransaksiHariIni.Name = "lblTransaksiHariIni";
            lblTransaksiHariIni.Size = new Size(24, 26);
            lblTransaksiHariIni.TabIndex = 19;
            lblTransaksiHariIni.Text = "0";
            lblTransaksiHariIni.Click += label11_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Calibri Light", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Gray;
            label9.Location = new Point(315, 53);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(90, 17);
            label9.TabIndex = 18;
            label9.Text = "Total Transaksi";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.RoyalBlue;
            label10.Location = new Point(9, 67);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(41, 26);
            label10.TabIndex = 17;
            label10.Text = "Rp";
            // 
            // lblPendapatanHariIni
            // 
            lblPendapatanHariIni.AutoSize = true;
            lblPendapatanHariIni.Font = new Font("Arial", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPendapatanHariIni.ForeColor = Color.RoyalBlue;
            lblPendapatanHariIni.Location = new Point(47, 67);
            lblPendapatanHariIni.Margin = new Padding(2, 0, 2, 0);
            lblPendapatanHariIni.Name = "lblPendapatanHariIni";
            lblPendapatanHariIni.Size = new Size(24, 26);
            lblPendapatanHariIni.TabIndex = 16;
            lblPendapatanHariIni.Text = "0";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Calibri Light", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Gray;
            label8.Location = new Point(18, 53);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(107, 17);
            label8.TabIndex = 16;
            label8.Text = "Total Pendapatan";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.MidnightBlue;
            label4.Location = new Point(18, 13);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(133, 16);
            label4.TabIndex = 16;
            label4.Text = "Penjualan Hari Ini ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri Light", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(20, 28);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(138, 17);
            label3.TabIndex = 14;
            label3.Text = "Selamat Datang,Admin";
            // 
            // dgvPengguna
            // 
            dgvPengguna.AllowUserToAddRows = false;
            dgvPengguna.AllowUserToDeleteRows = false;
            dgvPengguna.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvPengguna.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPengguna.BackgroundColor = Color.White;
            dgvPengguna.BorderStyle = BorderStyle.None;
            dgvPengguna.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.RoyalBlue;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvPengguna.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvPengguna.ColumnHeadersHeight = 40;
            dgvPengguna.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvPengguna.Columns.AddRange(new DataGridViewColumn[] { colNo, colNama, colJenis, colStatus });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.DimGray;
            dataGridViewCellStyle4.Padding = new Padding(6);
            dataGridViewCellStyle4.SelectionBackColor = Color.AliceBlue;
            dataGridViewCellStyle4.SelectionForeColor = Color.MidnightBlue;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvPengguna.DefaultCellStyle = dataGridViewCellStyle4;
            dgvPengguna.EnableHeadersVisualStyles = false;
            dgvPengguna.GridColor = Color.Gainsboro;
            dgvPengguna.Location = new Point(22, 146);
            dgvPengguna.Margin = new Padding(2, 2, 2, 2);
            dgvPengguna.MultiSelect = false;
            dgvPengguna.Name = "dgvPengguna";
            dgvPengguna.ReadOnly = true;
            dgvPengguna.RowHeadersVisible = false;
            dgvPengguna.RowHeadersWidth = 62;
            dgvPengguna.RowTemplate.Height = 38;
            dgvPengguna.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPengguna.Size = new Size(410, 227);
            dgvPengguna.TabIndex = 6;
            dgvPengguna.CellContentClick += dgvUser_CellContentClick;
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
            // UC_Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelContent2);
            Name = "UC_Dashboard";
            Size = new Size(996, 387);
            panelContent2.ResumeLayout(false);
            panelContent2.PerformLayout();
            panel2.ResumeLayout(false);
            roundedPanel2.ResumeLayout(false);
            roundedPanel2.PerformLayout();
            roundedPanel3.ResumeLayout(false);
            roundedPanel3.PerformLayout();
            roundedPanel4.ResumeLayout(false);
            roundedPanel4.PerformLayout();
            roundedPanel5.ResumeLayout(false);
            roundedPanel5.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            roundedPanel6.ResumeLayout(false);
            roundedPanel6.PerformLayout();
            roundedPanel1.ResumeLayout(false);
            roundedPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPengguna).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private RoundedPanel panelContent2;
        private DataGridView dgvPengguna;
        private Label label1;
        private Label label2;
        private Label label7;
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
        private RoundedPanel roundedPanel2;
        private RoundedPanel roundedPanel5;
        private RoundedPanel roundedPanel4;
        private RoundedPanel roundedPanel3;
        private RoundedPanel roundedPanel6;
        private RoundedPanel roundedPanel1;
        private Label label10;
        private Label lblPendapatanHariIni;
        private Label label8;
        private Label label4;
        private Label lblTransaksiHariIni;
        private Label label9;
        private Label lblKeluar;
        private Label label14;
        private Label lblMasuk;
        private Label label12;
        private Label label11;
        private Panel panel1;
        private Label label17;
        private Label lblStokSaatIni;
        private Label label13;
        private Label label15;
        private Label label16;
        private Label label19;
        private Label label18;
        private Panel panel2;
        private RoundedPanel roundedPanel7;
    }
}
