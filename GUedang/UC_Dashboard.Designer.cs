using GUedang;

namespace GUedang
{
    partial class UC_Dashboard
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panelHeader = new RoundedPanel();
            btnRefresh = new RoundedButton3();
            lblTanggal = new Label();
            lblJam = new Label();
            lblSalam = new Label();
            lblJudul = new Label();
            panelBody = new Panel();
            tblMain = new TableLayoutPanel();
            tblKiri = new TableLayoutPanel();
            panelPengguna = new RoundedPanel();
            dgvPengguna = new DataGridView();
            panelPenggunaTop = new Panel();
            cmbJenis = new ComboBox();
            panelCari = new RoundedPanel();
            txtCari = new TextBox();
            lblPenggunaJudul = new Label();
            panelGrafik = new RoundedPanel();
            panelChart = new Panel();
            lblGrafikJudul = new Label();
            tblKanan = new TableLayoutPanel();
            panelPenjualan = new RoundedPanel();
            tblPenjualan = new TableLayoutPanel();
            lblPendapatanJudul = new Label();
            lblPendapatanNilai = new Label();
            lblTransaksiJudul = new Label();
            lblRataNilai = new Label();
            lblTransaksiNilai = new Label();
            lblRataJudul = new Label();
            lblPenjualanJudul = new Label();
            panelAktivitas = new RoundedPanel();
            tblAktivitas = new TableLayoutPanel();
            lblMasukNilai = new Label();
            lblKeluarNilai = new Label();
            lblKeluarJudul = new Label();
            lblMasukJudul = new Label();
            lblStokNilai = new Label();
            lblStokJudul = new Label();
            lblAktivitasJudul = new Label();
            panelStokMenipis = new RoundedPanel();
            dgvStokMenipis = new DataGridView();
            lblStokMenipisJudul = new Label();
            panelAksi = new Panel();
            flowAksi = new FlowLayoutPanel();
            tblStats = new TableLayoutPanel();
            cardKasir = new RoundedPanel();
            panel1 = new Panel();
            lblKasirKet = new Label();
            lblKasirNilai = new Label();
            lblKasirJudul = new Label();
            cardGudang = new RoundedPanel();
            panel2 = new Panel();
            lblGudangKet = new Label();
            lblGudangNilai = new Label();
            lblGudangJudul = new Label();
            cardMenipis = new RoundedPanel();
            panel3 = new Panel();
            lblMenipisKet = new Label();
            lblMenipisNilai = new Label();
            lblMenipisJudul = new Label();
            cardHabis = new RoundedPanel();
            panel4 = new Panel();
            lblHabisKet = new Label();
            lblHabisNilai = new Label();
            lblHabisJudul = new Label();
            timerJam = new System.Windows.Forms.Timer(components);
            timerRefresh = new System.Windows.Forms.Timer(components);
            toolTip1 = new ToolTip(components);
            panelHeader.SuspendLayout();
            panelBody.SuspendLayout();
            tblMain.SuspendLayout();
            tblKiri.SuspendLayout();
            panelPengguna.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPengguna).BeginInit();
            panelPenggunaTop.SuspendLayout();
            panelCari.SuspendLayout();
            panelGrafik.SuspendLayout();
            tblKanan.SuspendLayout();
            panelPenjualan.SuspendLayout();
            tblPenjualan.SuspendLayout();
            panelAktivitas.SuspendLayout();
            tblAktivitas.SuspendLayout();
            panelStokMenipis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStokMenipis).BeginInit();
            panelAksi.SuspendLayout();
            tblStats.SuspendLayout();
            cardKasir.SuspendLayout();
            cardGudang.SuspendLayout();
            cardMenipis.SuspendLayout();
            cardHabis.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelHeader.BackColor = Color.White;
            panelHeader.Controls.Add(btnRefresh);
            panelHeader.Controls.Add(lblTanggal);
            panelHeader.Controls.Add(lblJam);
            panelHeader.Controls.Add(lblSalam);
            panelHeader.Controls.Add(lblJudul);
            panelHeader.Location = new Point(14, 0);
            panelHeader.Margin = new Padding(4, 3, 4, 3);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1255, 52);
            panelHeader.TabIndex = 1;
            // 
            // btnRefresh
            // 
            btnRefresh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRefresh.BackColor = Color.FromArgb(30, 100, 220);
            btnRefresh.CornerRadius = 19;
            btnRefresh.Cursor = Cursors.Hand;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(1088, 5);
            btnRefresh.Margin = new Padding(4, 3, 4, 3);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(131, 33);
            btnRefresh.TabIndex = 4;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // lblTanggal
            // 
            lblTanggal.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTanggal.Font = new Font("Segoe UI", 9.75F);
            lblTanggal.ForeColor = Color.FromArgb(100, 120, 160);
            lblTanggal.Location = new Point(742, 26);
            lblTanggal.Margin = new Padding(4, 0, 4, 0);
            lblTanggal.Name = "lblTanggal";
            lblTanggal.Size = new Size(338, 25);
            lblTanggal.TabIndex = 3;
            lblTanggal.Text = "Kamis, 19 November 2026";
            lblTanggal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblJam
            // 
            lblJam.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblJam.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            lblJam.ForeColor = Color.FromArgb(30, 100, 220);
            lblJam.Location = new Point(729, -4);
            lblJam.Margin = new Padding(4, 0, 4, 0);
            lblJam.Name = "lblJam";
            lblJam.Size = new Size(338, 42);
            lblJam.TabIndex = 2;
            lblJam.Text = "00:00:00";
            lblJam.TextAlign = ContentAlignment.MiddleRight;
            lblJam.Click += lblJam_Click;
            // 
            // lblSalam
            // 
            lblSalam.AutoSize = true;
            lblSalam.Font = new Font("Segoe UI", 10.5F);
            lblSalam.ForeColor = Color.FromArgb(100, 120, 160);
            lblSalam.Location = new Point(33, 32);
            lblSalam.Margin = new Padding(4, 0, 4, 0);
            lblSalam.Name = "lblSalam";
            lblSalam.Size = new Size(153, 19);
            lblSalam.TabIndex = 1;
            lblSalam.Text = "Selamat Datang, Admin";
            // 
            // lblJudul
            // 
            lblJudul.AutoSize = true;
            lblJudul.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            lblJudul.ForeColor = Color.FromArgb(13, 71, 161);
            lblJudul.Location = new Point(26, -1);
            lblJudul.Margin = new Padding(4, 0, 4, 0);
            lblJudul.Name = "lblJudul";
            lblJudul.Size = new Size(238, 37);
            lblJudul.TabIndex = 0;
            lblJudul.Text = "Dashboard Admin";
            // 
            // panelBody
            // 
            panelBody.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelBody.BackColor = Color.FromArgb(240, 246, 255);
            panelBody.Controls.Add(tblMain);
            panelBody.Controls.Add(panelAksi);
            panelBody.Controls.Add(tblStats);
            panelBody.Location = new Point(10, 53);
            panelBody.Margin = new Padding(4, 3, 4, 3);
            panelBody.Name = "panelBody";
            panelBody.Padding = new Padding(0, 12, 0, 0);
            panelBody.Size = new Size(1255, 745);
            panelBody.TabIndex = 0;
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 2;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tblMain.Controls.Add(tblKiri, 0, 0);
            tblMain.Controls.Add(tblKanan, 1, 0);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 92);
            tblMain.Margin = new Padding(4, 3, 4, 3);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 1;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblMain.Size = new Size(1255, 647);
            tblMain.TabIndex = 2;
            // 
            // tblKiri
            // 
            tblKiri.ColumnCount = 1;
            tblKiri.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblKiri.Controls.Add(panelPengguna, 0, 0);
            tblKiri.Controls.Add(panelGrafik, 0, 1);
            tblKiri.Dock = DockStyle.Fill;
            tblKiri.Location = new Point(0, 0);
            tblKiri.Margin = new Padding(0);
            tblKiri.Name = "tblKiri";
            tblKiri.RowCount = 2;
            tblKiri.RowStyles.Add(new RowStyle(SizeType.Percent, 48.4708061F));
            tblKiri.RowStyles.Add(new RowStyle(SizeType.Percent, 51.5291939F));
            tblKiri.Size = new Size(753, 647);
            tblKiri.TabIndex = 0;
            // 
            // panelPengguna
            // 
            panelPengguna.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelPengguna.BackColor = Color.White;
            panelPengguna.Controls.Add(dgvPengguna);
            panelPengguna.Controls.Add(panelPenggunaTop);
            panelPengguna.Location = new Point(9, 9);
            panelPengguna.Margin = new Padding(9);
            panelPengguna.Name = "panelPengguna";
            panelPengguna.Padding = new Padding(14, 5, 14, 14);
            panelPengguna.Size = new Size(735, 295);
            panelPengguna.TabIndex = 0;
            // 
            // dgvPengguna
            // 
            dgvPengguna.BackgroundColor = Color.White;
            dgvPengguna.ColumnHeadersHeight = 34;
            dgvPengguna.Dock = DockStyle.Fill;
            dgvPengguna.Location = new Point(14, 45);
            dgvPengguna.Margin = new Padding(4, 3, 4, 3);
            dgvPengguna.Name = "dgvPengguna";
            dgvPengguna.RowHeadersWidth = 62;
            dgvPengguna.Size = new Size(707, 236);
            dgvPengguna.TabIndex = 1;
            dgvPengguna.CellContentClick += dgvPengguna_CellContentClick;
            // 
            // panelPenggunaTop
            // 
            panelPenggunaTop.BackColor = Color.White;
            panelPenggunaTop.Controls.Add(cmbJenis);
            panelPenggunaTop.Controls.Add(panelCari);
            panelPenggunaTop.Controls.Add(lblPenggunaJudul);
            panelPenggunaTop.Dock = DockStyle.Top;
            panelPenggunaTop.Location = new Point(14, 5);
            panelPenggunaTop.Margin = new Padding(4, 3, 4, 3);
            panelPenggunaTop.Name = "panelPenggunaTop";
            panelPenggunaTop.Size = new Size(707, 40);
            panelPenggunaTop.TabIndex = 0;
            // 
            // cmbJenis
            // 
            cmbJenis.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cmbJenis.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbJenis.FlatStyle = FlatStyle.Flat;
            cmbJenis.Font = new Font("Segoe UI", 9.5F);
            cmbJenis.Location = new Point(553, 15);
            cmbJenis.Margin = new Padding(4, 3, 4, 3);
            cmbJenis.Name = "cmbJenis";
            cmbJenis.Size = new Size(139, 25);
            cmbJenis.TabIndex = 2;
            cmbJenis.SelectedIndexChanged += FilterPengguna_Changed;
            // 
            // panelCari
            // 
            panelCari.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panelCari.BackColor = Color.FromArgb(246, 250, 255);
            panelCari.Controls.Add(txtCari);
            panelCari.Location = new Point(325, 10);
            panelCari.Margin = new Padding(4, 3, 4, 3);
            panelCari.Name = "panelCari";
            panelCari.Padding = new Padding(14, 7, 12, 0);
            panelCari.Size = new Size(216, 37);
            panelCari.TabIndex = 1;
            // 
            // txtCari
            // 
            txtCari.BackColor = Color.FromArgb(246, 250, 255);
            txtCari.BorderStyle = BorderStyle.None;
            txtCari.Dock = DockStyle.Fill;
            txtCari.Font = new Font("Segoe UI", 9.5F);
            txtCari.Location = new Point(14, 7);
            txtCari.Margin = new Padding(4, 3, 4, 3);
            txtCari.Name = "txtCari";
            txtCari.Size = new Size(190, 17);
            txtCari.TabIndex = 0;
            txtCari.TextChanged += FilterPengguna_Changed;
            // 
            // lblPenggunaJudul
            // 
            lblPenggunaJudul.AutoSize = true;
            lblPenggunaJudul.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblPenggunaJudul.ForeColor = Color.FromArgb(13, 71, 161);
            lblPenggunaJudul.Location = new Point(7, 10);
            lblPenggunaJudul.Margin = new Padding(4, 0, 4, 0);
            lblPenggunaJudul.Name = "lblPenggunaJudul";
            lblPenggunaJudul.Size = new Size(131, 21);
            lblPenggunaJudul.TabIndex = 0;
            lblPenggunaJudul.Text = "Daftar Pengguna";
            // 
            // panelGrafik
            // 
            panelGrafik.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelGrafik.BackColor = Color.White;
            panelGrafik.Controls.Add(panelChart);
            panelGrafik.Controls.Add(lblGrafikJudul);
            panelGrafik.Location = new Point(9, 322);
            panelGrafik.Margin = new Padding(9);
            panelGrafik.Name = "panelGrafik";
            panelGrafik.Padding = new Padding(9, 0, 9, 9);
            panelGrafik.Size = new Size(735, 316);
            panelGrafik.TabIndex = 1;
            // 
            // panelChart
            // 
            panelChart.Dock = DockStyle.Fill;
            panelChart.Location = new Point(9, 46);
            panelChart.Margin = new Padding(4, 3, 4, 3);
            panelChart.Name = "panelChart";
            panelChart.Size = new Size(717, 261);
            panelChart.TabIndex = 1;
            panelChart.Paint += panelChart_Paint;
            panelChart.MouseLeave += panelChart_MouseLeave;
            panelChart.MouseMove += panelChart_MouseMove;
            panelChart.Resize += panelChart_Resize;
            // 
            // lblGrafikJudul
            // 
            lblGrafikJudul.Dock = DockStyle.Top;
            lblGrafikJudul.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblGrafikJudul.ForeColor = Color.FromArgb(13, 71, 161);
            lblGrafikJudul.Location = new Point(9, 0);
            lblGrafikJudul.Margin = new Padding(4, 0, 4, 0);
            lblGrafikJudul.Name = "lblGrafikJudul";
            lblGrafikJudul.Padding = new Padding(16, 12, 0, 0);
            lblGrafikJudul.Size = new Size(717, 46);
            lblGrafikJudul.TabIndex = 0;
            lblGrafikJudul.Text = "Grafik Penjualan 7 Hari Terakhir";
            // 
            // tblKanan
            // 
            tblKanan.ColumnCount = 1;
            tblKanan.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblKanan.Controls.Add(panelPenjualan, 0, 0);
            tblKanan.Controls.Add(panelAktivitas, 0, 1);
            tblKanan.Controls.Add(panelStokMenipis, 0, 2);
            tblKanan.Location = new Point(753, 0);
            tblKanan.Margin = new Padding(0);
            tblKanan.Name = "tblKanan";
            tblKanan.RowCount = 3;
            tblKanan.RowStyles.Add(new RowStyle(SizeType.Percent, 36.60797F));
            tblKanan.RowStyles.Add(new RowStyle(SizeType.Percent, 33.73494F));
            tblKanan.RowStyles.Add(new RowStyle(SizeType.Percent, 29.5644112F));
            tblKanan.Size = new Size(502, 647);
            tblKanan.TabIndex = 1;
            tblKanan.Paint += tblKanan_Paint;
            // 
            // panelPenjualan
            // 
            panelPenjualan.BackColor = Color.White;
            panelPenjualan.Controls.Add(tblPenjualan);
            panelPenjualan.Controls.Add(lblPenjualanJudul);
            panelPenjualan.Location = new Point(9, 9);
            panelPenjualan.Margin = new Padding(9);
            panelPenjualan.Name = "panelPenjualan";
            panelPenjualan.Size = new Size(475, 107);
            panelPenjualan.TabIndex = 0;
            // 
            // tblPenjualan
            // 
            tblPenjualan.ColumnCount = 2;
            tblPenjualan.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblPenjualan.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblPenjualan.Controls.Add(lblPendapatanJudul, 0, 0);
            tblPenjualan.Controls.Add(lblPendapatanNilai, 1, 0);
            tblPenjualan.Controls.Add(lblTransaksiJudul, 0, 1);
            tblPenjualan.Controls.Add(lblRataNilai, 1, 2);
            tblPenjualan.Controls.Add(lblTransaksiNilai, 1, 1);
            tblPenjualan.Controls.Add(lblRataJudul, 0, 2);
            tblPenjualan.Location = new Point(0, 34);
            tblPenjualan.Margin = new Padding(4, 3, 4, 3);
            tblPenjualan.Name = "tblPenjualan";
            tblPenjualan.Padding = new Padding(16, 0, 16, 7);
            tblPenjualan.RowCount = 3;
            tblPenjualan.RowStyles.Add(new RowStyle(SizeType.Percent, 27.6073627F));
            tblPenjualan.RowStyles.Add(new RowStyle(SizeType.Percent, 22.6993866F));
            tblPenjualan.RowStyles.Add(new RowStyle(SizeType.Percent, 49.6932526F));
            tblPenjualan.Size = new Size(373, 89);
            tblPenjualan.TabIndex = 1;
            // 
            // lblPendapatanJudul
            // 
            lblPendapatanJudul.Dock = DockStyle.Fill;
            lblPendapatanJudul.Font = new Font("Segoe UI", 9.5F);
            lblPendapatanJudul.ForeColor = Color.FromArgb(100, 120, 160);
            lblPendapatanJudul.Location = new Point(20, 0);
            lblPendapatanJudul.Margin = new Padding(4, 0, 4, 0);
            lblPendapatanJudul.Name = "lblPendapatanJudul";
            lblPendapatanJudul.Size = new Size(162, 22);
            lblPendapatanJudul.TabIndex = 0;
            lblPendapatanJudul.Text = "Total Pendapatan";
            lblPendapatanJudul.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblPendapatanNilai
            // 
            lblPendapatanNilai.Dock = DockStyle.Fill;
            lblPendapatanNilai.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            lblPendapatanNilai.ForeColor = Color.FromArgb(30, 100, 220);
            lblPendapatanNilai.Location = new Point(190, 0);
            lblPendapatanNilai.Margin = new Padding(4, 0, 4, 0);
            lblPendapatanNilai.Name = "lblPendapatanNilai";
            lblPendapatanNilai.Size = new Size(163, 22);
            lblPendapatanNilai.TabIndex = 1;
            lblPendapatanNilai.Text = "Rp 0";
            lblPendapatanNilai.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblTransaksiJudul
            // 
            lblTransaksiJudul.Dock = DockStyle.Fill;
            lblTransaksiJudul.Font = new Font("Segoe UI", 9.5F);
            lblTransaksiJudul.ForeColor = Color.FromArgb(100, 120, 160);
            lblTransaksiJudul.Location = new Point(20, 22);
            lblTransaksiJudul.Margin = new Padding(4, 0, 4, 0);
            lblTransaksiJudul.Name = "lblTransaksiJudul";
            lblTransaksiJudul.Size = new Size(162, 18);
            lblTransaksiJudul.TabIndex = 2;
            lblTransaksiJudul.Text = "Total Transaksi";
            lblTransaksiJudul.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblRataNilai
            // 
            lblRataNilai.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblRataNilai.ForeColor = Color.FromArgb(13, 71, 161);
            lblRataNilai.Location = new Point(190, 40);
            lblRataNilai.Margin = new Padding(4, 0, 4, 0);
            lblRataNilai.Name = "lblRataNilai";
            lblRataNilai.Size = new Size(162, 28);
            lblRataNilai.TabIndex = 5;
            lblRataNilai.Text = "Rp 0";
            lblRataNilai.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblTransaksiNilai
            // 
            lblTransaksiNilai.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblTransaksiNilai.ForeColor = Color.FromArgb(13, 71, 161);
            lblTransaksiNilai.Location = new Point(190, 22);
            lblTransaksiNilai.Margin = new Padding(4, 0, 4, 0);
            lblTransaksiNilai.Name = "lblTransaksiNilai";
            lblTransaksiNilai.Size = new Size(162, 18);
            lblTransaksiNilai.TabIndex = 3;
            lblTransaksiNilai.Text = "0";
            lblTransaksiNilai.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblRataJudul
            // 
            lblRataJudul.Font = new Font("Segoe UI", 9.5F);
            lblRataJudul.ForeColor = Color.FromArgb(100, 120, 160);
            lblRataJudul.Location = new Point(20, 40);
            lblRataJudul.Margin = new Padding(4, 0, 4, 0);
            lblRataJudul.Name = "lblRataJudul";
            lblRataJudul.Size = new Size(162, 28);
            lblRataJudul.TabIndex = 4;
            lblRataJudul.Text = "Rata-rata / Transaksi";
            lblRataJudul.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblPenjualanJudul
            // 
            lblPenjualanJudul.Dock = DockStyle.Top;
            lblPenjualanJudul.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblPenjualanJudul.ForeColor = Color.FromArgb(13, 71, 161);
            lblPenjualanJudul.Location = new Point(0, 0);
            lblPenjualanJudul.Margin = new Padding(4, 0, 4, 0);
            lblPenjualanJudul.Name = "lblPenjualanJudul";
            lblPenjualanJudul.Padding = new Padding(16, 9, 0, 0);
            lblPenjualanJudul.Size = new Size(475, 31);
            lblPenjualanJudul.TabIndex = 0;
            lblPenjualanJudul.Text = "Penjualan Hari Ini";
            // 
            // panelAktivitas
            // 
            panelAktivitas.BackColor = Color.White;
            panelAktivitas.Controls.Add(tblAktivitas);
            panelAktivitas.Controls.Add(lblAktivitasJudul);
            panelAktivitas.Location = new Point(9, 246);
            panelAktivitas.Margin = new Padding(9);
            panelAktivitas.Name = "panelAktivitas";
            panelAktivitas.Size = new Size(484, 122);
            panelAktivitas.TabIndex = 1;
            // 
            // tblAktivitas
            // 
            tblAktivitas.ColumnCount = 2;
            tblAktivitas.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblAktivitas.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblAktivitas.Controls.Add(lblMasukNilai, 1, 0);
            tblAktivitas.Controls.Add(lblKeluarNilai, 1, 1);
            tblAktivitas.Controls.Add(lblKeluarJudul, 0, 1);
            tblAktivitas.Controls.Add(lblMasukJudul, 0, 0);
            tblAktivitas.Controls.Add(lblStokNilai, 1, 2);
            tblAktivitas.Controls.Add(lblStokJudul, 0, 2);
            tblAktivitas.Location = new Point(0, 39);
            tblAktivitas.Margin = new Padding(4, 3, 4, 3);
            tblAktivitas.Name = "tblAktivitas";
            tblAktivitas.Padding = new Padding(16, 0, 16, 7);
            tblAktivitas.RowCount = 3;
            tblAktivitas.RowStyles.Add(new RowStyle(SizeType.Percent, 38.98305F));
            tblAktivitas.RowStyles.Add(new RowStyle(SizeType.Percent, 29.9435024F));
            tblAktivitas.RowStyles.Add(new RowStyle(SizeType.Percent, 30.5084743F));
            tblAktivitas.Size = new Size(373, 67);
            tblAktivitas.TabIndex = 1;
            // 
            // lblMasukNilai
            // 
            lblMasukNilai.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblMasukNilai.ForeColor = Color.FromArgb(30, 100, 220);
            lblMasukNilai.Location = new Point(190, 0);
            lblMasukNilai.Margin = new Padding(4, 0, 4, 0);
            lblMasukNilai.Name = "lblMasukNilai";
            lblMasukNilai.Size = new Size(162, 23);
            lblMasukNilai.TabIndex = 1;
            lblMasukNilai.Text = "0";
            lblMasukNilai.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblKeluarNilai
            // 
            lblKeluarNilai.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblKeluarNilai.ForeColor = Color.FromArgb(13, 71, 161);
            lblKeluarNilai.Location = new Point(190, 23);
            lblKeluarNilai.Margin = new Padding(4, 0, 4, 0);
            lblKeluarNilai.Name = "lblKeluarNilai";
            lblKeluarNilai.Size = new Size(162, 14);
            lblKeluarNilai.TabIndex = 3;
            lblKeluarNilai.Text = "0";
            lblKeluarNilai.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblKeluarJudul
            // 
            lblKeluarJudul.Font = new Font("Segoe UI", 9.5F);
            lblKeluarJudul.ForeColor = Color.FromArgb(100, 120, 160);
            lblKeluarJudul.Location = new Point(20, 23);
            lblKeluarJudul.Margin = new Padding(4, 0, 4, 0);
            lblKeluarJudul.Name = "lblKeluarJudul";
            lblKeluarJudul.Size = new Size(162, 14);
            lblKeluarJudul.TabIndex = 2;
            lblKeluarJudul.Text = "Barang Keluar";
            lblKeluarJudul.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblMasukJudul
            // 
            lblMasukJudul.Font = new Font("Segoe UI", 9.5F);
            lblMasukJudul.ForeColor = Color.FromArgb(100, 120, 160);
            lblMasukJudul.Location = new Point(20, 0);
            lblMasukJudul.Margin = new Padding(4, 0, 4, 0);
            lblMasukJudul.Name = "lblMasukJudul";
            lblMasukJudul.Size = new Size(162, 23);
            lblMasukJudul.TabIndex = 0;
            lblMasukJudul.Text = "Barang Masuk";
            lblMasukJudul.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblStokNilai
            // 
            lblStokNilai.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblStokNilai.ForeColor = Color.FromArgb(13, 71, 161);
            lblStokNilai.Location = new Point(190, 41);
            lblStokNilai.Margin = new Padding(4, 0, 4, 0);
            lblStokNilai.Name = "lblStokNilai";
            lblStokNilai.Size = new Size(162, 19);
            lblStokNilai.TabIndex = 5;
            lblStokNilai.Text = "0";
            lblStokNilai.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblStokJudul
            // 
            lblStokJudul.Font = new Font("Segoe UI", 9.5F);
            lblStokJudul.ForeColor = Color.FromArgb(100, 120, 160);
            lblStokJudul.Location = new Point(20, 41);
            lblStokJudul.Margin = new Padding(4, 0, 4, 0);
            lblStokJudul.Name = "lblStokJudul";
            lblStokJudul.Size = new Size(162, 19);
            lblStokJudul.TabIndex = 4;
            lblStokJudul.Text = "Stok Saat Ini";
            lblStokJudul.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblAktivitasJudul
            // 
            lblAktivitasJudul.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblAktivitasJudul.ForeColor = Color.FromArgb(13, 71, 161);
            lblAktivitasJudul.Location = new Point(0, 10);
            lblAktivitasJudul.Margin = new Padding(4, 0, 4, 0);
            lblAktivitasJudul.Name = "lblAktivitasJudul";
            lblAktivitasJudul.Padding = new Padding(16, 9, 0, 0);
            lblAktivitasJudul.Size = new Size(484, 26);
            lblAktivitasJudul.TabIndex = 0;
            lblAktivitasJudul.Text = "Aktivitas Gudang";
            // 
            // panelStokMenipis
            // 
            panelStokMenipis.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelStokMenipis.BackColor = Color.White;
            panelStokMenipis.Controls.Add(dgvStokMenipis);
            panelStokMenipis.Controls.Add(lblStokMenipisJudul);
            panelStokMenipis.Location = new Point(9, 464);
            panelStokMenipis.Margin = new Padding(9);
            panelStokMenipis.Name = "panelStokMenipis";
            panelStokMenipis.Padding = new Padding(14, 0, 14, 14);
            panelStokMenipis.Size = new Size(484, 174);
            panelStokMenipis.TabIndex = 2;
            // 
            // dgvStokMenipis
            // 
            dgvStokMenipis.ColumnHeadersHeight = 34;
            dgvStokMenipis.Dock = DockStyle.Fill;
            dgvStokMenipis.Location = new Point(14, 39);
            dgvStokMenipis.Margin = new Padding(4, 3, 4, 3);
            dgvStokMenipis.Name = "dgvStokMenipis";
            dgvStokMenipis.RowHeadersWidth = 62;
            dgvStokMenipis.Size = new Size(456, 121);
            dgvStokMenipis.TabIndex = 1;
            dgvStokMenipis.CellContentClick += dgvStokMenipis_CellContentClick;
            // 
            // lblStokMenipisJudul
            // 
            lblStokMenipisJudul.Dock = DockStyle.Top;
            lblStokMenipisJudul.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblStokMenipisJudul.ForeColor = Color.FromArgb(13, 71, 161);
            lblStokMenipisJudul.Location = new Point(14, 0);
            lblStokMenipisJudul.Margin = new Padding(4, 0, 4, 0);
            lblStokMenipisJudul.Name = "lblStokMenipisJudul";
            lblStokMenipisJudul.Padding = new Padding(16, 9, 0, 0);
            lblStokMenipisJudul.Size = new Size(456, 39);
            lblStokMenipisJudul.TabIndex = 0;
            lblStokMenipisJudul.Text = "Perlu Diperiksa / Ditambah";
            // 
            // panelAksi
            // 
            panelAksi.Controls.Add(flowAksi);
            panelAksi.Dock = DockStyle.Bottom;
            panelAksi.Location = new Point(0, 739);
            panelAksi.Margin = new Padding(4, 3, 4, 3);
            panelAksi.Name = "panelAksi";
            panelAksi.Padding = new Padding(0, 9, 0, 0);
            panelAksi.Size = new Size(1255, 6);
            panelAksi.TabIndex = 1;
            // 
            // flowAksi
            // 
            flowAksi.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowAksi.Location = new Point(0, 9);
            flowAksi.Margin = new Padding(4, 3, 4, 3);
            flowAksi.Name = "flowAksi";
            flowAksi.Size = new Size(1255, 0);
            flowAksi.TabIndex = 0;
            // 
            // tblStats
            // 
            tblStats.ColumnCount = 4;
            tblStats.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblStats.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblStats.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblStats.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblStats.Controls.Add(cardKasir, 0, 0);
            tblStats.Controls.Add(cardGudang, 1, 0);
            tblStats.Controls.Add(cardMenipis, 2, 0);
            tblStats.Controls.Add(cardHabis, 3, 0);
            tblStats.Dock = DockStyle.Top;
            tblStats.Location = new Point(0, 12);
            tblStats.Margin = new Padding(4, 3, 4, 3);
            tblStats.Name = "tblStats";
            tblStats.RowCount = 1;
            tblStats.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblStats.Size = new Size(1255, 80);
            tblStats.TabIndex = 0;
            // 
            // cardKasir
            // 
            cardKasir.BackColor = Color.White;
            cardKasir.Controls.Add(panel1);
            cardKasir.Controls.Add(lblKasirKet);
            cardKasir.Controls.Add(lblKasirNilai);
            cardKasir.Controls.Add(lblKasirJudul);
            cardKasir.Dock = DockStyle.Fill;
            cardKasir.Location = new Point(9, 9);
            cardKasir.Margin = new Padding(9);
            cardKasir.Name = "cardKasir";
            cardKasir.Size = new Size(295, 62);
            cardKasir.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.RoyalBlue;
            panel1.Location = new Point(19, 14);
            panel1.Name = "panel1";
            panel1.Size = new Size(7, 52);
            panel1.TabIndex = 3;
            // 
            // lblKasirKet
            // 
            lblKasirKet.AutoSize = true;
            lblKasirKet.Font = new Font("Segoe UI", 8.5F);
            lblKasirKet.ForeColor = Color.FromArgb(100, 120, 160);
            lblKasirKet.Location = new Point(84, 47);
            lblKasirKet.Margin = new Padding(4, 0, 4, 0);
            lblKasirKet.Name = "lblKasirKet";
            lblKasirKet.Size = new Size(77, 15);
            lblKasirKet.TabIndex = 0;
            lblKasirKet.Text = "Petugas Kasir";
            // 
            // lblKasirNilai
            // 
            lblKasirNilai.AutoSize = true;
            lblKasirNilai.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold);
            lblKasirNilai.ForeColor = Color.FromArgb(30, 100, 220);
            lblKasirNilai.Location = new Point(37, 26);
            lblKasirNilai.Margin = new Padding(4, 0, 4, 0);
            lblKasirNilai.Name = "lblKasirNilai";
            lblKasirNilai.Size = new Size(38, 45);
            lblKasirNilai.TabIndex = 1;
            lblKasirNilai.Text = "0";
            // 
            // lblKasirJudul
            // 
            lblKasirJudul.AutoSize = true;
            lblKasirJudul.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblKasirJudul.ForeColor = Color.FromArgb(13, 71, 161);
            lblKasirJudul.Location = new Point(37, 12);
            lblKasirJudul.Margin = new Padding(4, 0, 4, 0);
            lblKasirJudul.Name = "lblKasirJudul";
            lblKasirJudul.Size = new Size(89, 19);
            lblKasirJudul.TabIndex = 2;
            lblKasirJudul.Text = "Jumlah Kasir";
            // 
            // cardGudang
            // 
            cardGudang.BackColor = Color.White;
            cardGudang.Controls.Add(panel2);
            cardGudang.Controls.Add(lblGudangKet);
            cardGudang.Controls.Add(lblGudangNilai);
            cardGudang.Controls.Add(lblGudangJudul);
            cardGudang.Dock = DockStyle.Fill;
            cardGudang.Location = new Point(322, 9);
            cardGudang.Margin = new Padding(9);
            cardGudang.Name = "cardGudang";
            cardGudang.Size = new Size(295, 62);
            cardGudang.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Blue;
            panel2.Location = new Point(19, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(7, 52);
            panel2.TabIndex = 4;
            panel2.Paint += panel2_Paint;
            // 
            // lblGudangKet
            // 
            lblGudangKet.AutoSize = true;
            lblGudangKet.Font = new Font("Segoe UI", 8.5F);
            lblGudangKet.ForeColor = Color.FromArgb(100, 120, 160);
            lblGudangKet.Location = new Point(84, 47);
            lblGudangKet.Margin = new Padding(4, 0, 4, 0);
            lblGudangKet.Name = "lblGudangKet";
            lblGudangKet.Size = new Size(94, 15);
            lblGudangKet.TabIndex = 0;
            lblGudangKet.Text = "Petugas Gudang";
            // 
            // lblGudangNilai
            // 
            lblGudangNilai.AutoSize = true;
            lblGudangNilai.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold);
            lblGudangNilai.ForeColor = Color.FromArgb(13, 71, 161);
            lblGudangNilai.Location = new Point(30, 26);
            lblGudangNilai.Margin = new Padding(4, 0, 4, 0);
            lblGudangNilai.Name = "lblGudangNilai";
            lblGudangNilai.Size = new Size(38, 45);
            lblGudangNilai.TabIndex = 1;
            lblGudangNilai.Text = "0";
            // 
            // lblGudangJudul
            // 
            lblGudangJudul.AutoSize = true;
            lblGudangJudul.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblGudangJudul.ForeColor = Color.FromArgb(13, 71, 161);
            lblGudangJudul.Location = new Point(37, 12);
            lblGudangJudul.Margin = new Padding(4, 0, 4, 0);
            lblGudangJudul.Name = "lblGudangJudul";
            lblGudangJudul.Size = new Size(58, 19);
            lblGudangJudul.TabIndex = 2;
            lblGudangJudul.Text = "Gudang";
            // 
            // cardMenipis
            // 
            cardMenipis.BackColor = Color.White;
            cardMenipis.Controls.Add(panel3);
            cardMenipis.Controls.Add(lblMenipisKet);
            cardMenipis.Controls.Add(lblMenipisNilai);
            cardMenipis.Controls.Add(lblMenipisJudul);
            cardMenipis.Dock = DockStyle.Fill;
            cardMenipis.Location = new Point(635, 9);
            cardMenipis.Margin = new Padding(9);
            cardMenipis.Name = "cardMenipis";
            cardMenipis.Size = new Size(295, 62);
            cardMenipis.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightSkyBlue;
            panel3.Location = new Point(19, 12);
            panel3.Name = "panel3";
            panel3.Size = new Size(7, 53);
            panel3.TabIndex = 4;
            // 
            // lblMenipisKet
            // 
            lblMenipisKet.AutoSize = true;
            lblMenipisKet.Font = new Font("Segoe UI", 8.5F);
            lblMenipisKet.ForeColor = Color.FromArgb(100, 120, 160);
            lblMenipisKet.Location = new Point(80, 47);
            lblMenipisKet.Margin = new Padding(4, 0, 4, 0);
            lblMenipisKet.Name = "lblMenipisKet";
            lblMenipisKet.Size = new Size(87, 15);
            lblMenipisKet.TabIndex = 0;
            lblMenipisKet.Text = "Perlu di Periksa";
            // 
            // lblMenipisNilai
            // 
            lblMenipisNilai.AutoSize = true;
            lblMenipisNilai.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold);
            lblMenipisNilai.ForeColor = Color.FromArgb(66, 133, 244);
            lblMenipisNilai.Location = new Point(33, 26);
            lblMenipisNilai.Margin = new Padding(4, 0, 4, 0);
            lblMenipisNilai.Name = "lblMenipisNilai";
            lblMenipisNilai.Size = new Size(38, 45);
            lblMenipisNilai.TabIndex = 1;
            lblMenipisNilai.Text = "0";
            // 
            // lblMenipisJudul
            // 
            lblMenipisJudul.AutoSize = true;
            lblMenipisJudul.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblMenipisJudul.ForeColor = Color.FromArgb(13, 71, 161);
            lblMenipisJudul.Location = new Point(37, 12);
            lblMenipisJudul.Margin = new Padding(4, 0, 4, 0);
            lblMenipisJudul.Name = "lblMenipisJudul";
            lblMenipisJudul.Size = new Size(106, 19);
            lblMenipisJudul.TabIndex = 2;
            lblMenipisJudul.Text = "Barang Menipis";
            // 
            // cardHabis
            // 
            cardHabis.BackColor = Color.White;
            cardHabis.Controls.Add(panel4);
            cardHabis.Controls.Add(lblHabisKet);
            cardHabis.Controls.Add(lblHabisNilai);
            cardHabis.Controls.Add(lblHabisJudul);
            cardHabis.Dock = DockStyle.Fill;
            cardHabis.Location = new Point(948, 9);
            cardHabis.Margin = new Padding(9);
            cardHabis.Name = "cardHabis";
            cardHabis.Size = new Size(298, 62);
            cardHabis.TabIndex = 3;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Navy;
            panel4.Location = new Point(19, 14);
            panel4.Name = "panel4";
            panel4.Size = new Size(7, 51);
            panel4.TabIndex = 4;
            // 
            // lblHabisKet
            // 
            lblHabisKet.AutoSize = true;
            lblHabisKet.Font = new Font("Segoe UI", 8.5F);
            lblHabisKet.ForeColor = Color.FromArgb(100, 120, 160);
            lblHabisKet.Location = new Point(71, 47);
            lblHabisKet.Margin = new Padding(4, 0, 4, 0);
            lblHabisKet.Name = "lblHabisKet";
            lblHabisKet.Size = new Size(88, 15);
            lblHabisKet.TabIndex = 0;
            lblHabisKet.Text = "Perlu ditambah";
            // 
            // lblHabisNilai
            // 
            lblHabisNilai.AutoSize = true;
            lblHabisNilai.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold);
            lblHabisNilai.ForeColor = Color.FromArgb(10, 50, 120);
            lblHabisNilai.Location = new Point(33, 26);
            lblHabisNilai.Margin = new Padding(4, 0, 4, 0);
            lblHabisNilai.Name = "lblHabisNilai";
            lblHabisNilai.Size = new Size(38, 45);
            lblHabisNilai.TabIndex = 1;
            lblHabisNilai.Text = "0";
            // 
            // lblHabisJudul
            // 
            lblHabisJudul.AutoSize = true;
            lblHabisJudul.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblHabisJudul.ForeColor = Color.FromArgb(13, 71, 161);
            lblHabisJudul.Location = new Point(29, 10);
            lblHabisJudul.Margin = new Padding(4, 0, 4, 0);
            lblHabisJudul.Name = "lblHabisJudul";
            lblHabisJudul.Size = new Size(91, 19);
            lblHabisJudul.TabIndex = 2;
            lblHabisJudul.Text = "Barang Habis";
            // 
            // timerJam
            // 
            timerJam.Interval = 1000;
            timerJam.Tick += timerJam_Tick;
            // 
            // timerRefresh
            // 
            timerRefresh.Interval = 60000;
            timerRefresh.Tick += timerRefresh_Tick;
            // 
            // UC_Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 246, 255);
            Controls.Add(panelBody);
            Controls.Add(panelHeader);
            Margin = new Padding(4, 3, 4, 3);
            Name = "UC_Dashboard";
            Padding = new Padding(14, 14, 14, 7);
            Size = new Size(1283, 808);
            Load += UC_Dashboard_Load;
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelBody.ResumeLayout(false);
            tblMain.ResumeLayout(false);
            tblKiri.ResumeLayout(false);
            panelPengguna.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPengguna).EndInit();
            panelPenggunaTop.ResumeLayout(false);
            panelPenggunaTop.PerformLayout();
            panelCari.ResumeLayout(false);
            panelCari.PerformLayout();
            panelGrafik.ResumeLayout(false);
            tblKanan.ResumeLayout(false);
            panelPenjualan.ResumeLayout(false);
            tblPenjualan.ResumeLayout(false);
            panelAktivitas.ResumeLayout(false);
            tblAktivitas.ResumeLayout(false);
            panelStokMenipis.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvStokMenipis).EndInit();
            panelAksi.ResumeLayout(false);
            tblStats.ResumeLayout(false);
            cardKasir.ResumeLayout(false);
            cardKasir.PerformLayout();
            cardGudang.ResumeLayout(false);
            cardGudang.PerformLayout();
            cardMenipis.ResumeLayout(false);
            cardMenipis.PerformLayout();
            cardHabis.ResumeLayout(false);
            cardHabis.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private RoundedPanel panelHeader;
        private RoundedButton3 btnRefresh;
        private System.Windows.Forms.Label lblTanggal;
        private System.Windows.Forms.Label lblJam;
        private System.Windows.Forms.Label lblSalam;
        private System.Windows.Forms.Label lblJudul;
        private System.Windows.Forms.Panel panelBody;
        private System.Windows.Forms.TableLayoutPanel tblMain;
        private System.Windows.Forms.TableLayoutPanel tblKiri;
        private RoundedPanel panelPengguna;
        private System.Windows.Forms.DataGridView dgvPengguna;
        private System.Windows.Forms.Panel panelPenggunaTop;
        private RoundedPanel panelCari;
        private System.Windows.Forms.ComboBox cmbJenis;
        private System.Windows.Forms.TextBox txtCari;
        private System.Windows.Forms.Label lblPenggunaJudul;
        private RoundedPanel panelGrafik;
        private System.Windows.Forms.Panel panelChart;
        private System.Windows.Forms.Label lblGrafikJudul;
        private System.Windows.Forms.TableLayoutPanel tblKanan;
        private RoundedPanel panelPenjualan;
        private System.Windows.Forms.TableLayoutPanel tblPenjualan;
        private System.Windows.Forms.Label lblPendapatanJudul;
        private System.Windows.Forms.Label lblPendapatanNilai;
        private System.Windows.Forms.Label lblTransaksiJudul;
        private System.Windows.Forms.Label lblTransaksiNilai;
        private System.Windows.Forms.Label lblRataJudul;
        private System.Windows.Forms.Label lblRataNilai;
        private System.Windows.Forms.Label lblPenjualanJudul;
        private RoundedPanel panelAktivitas;
        private System.Windows.Forms.TableLayoutPanel tblAktivitas;
        private System.Windows.Forms.Label lblMasukJudul;
        private System.Windows.Forms.Label lblMasukNilai;
        private System.Windows.Forms.Label lblKeluarJudul;
        private System.Windows.Forms.Label lblKeluarNilai;
        private System.Windows.Forms.Label lblStokJudul;
        private System.Windows.Forms.Label lblStokNilai;
        private System.Windows.Forms.Label lblAktivitasJudul;
        private RoundedPanel panelStokMenipis;
        private System.Windows.Forms.DataGridView dgvStokMenipis;
        private System.Windows.Forms.Label lblStokMenipisJudul;
        private System.Windows.Forms.Panel panelAksi;
        private System.Windows.Forms.FlowLayoutPanel flowAksi;
        private System.Windows.Forms.TableLayoutPanel tblStats;
        private RoundedPanel cardKasir;
        private System.Windows.Forms.Label lblKasirKet;
        private System.Windows.Forms.Label lblKasirNilai;
        private System.Windows.Forms.Label lblKasirJudul;
        private RoundedPanel cardGudang;
        private System.Windows.Forms.Label lblGudangKet;
        private System.Windows.Forms.Label lblGudangNilai;
        private System.Windows.Forms.Label lblGudangJudul;
        private RoundedPanel cardMenipis;
        private System.Windows.Forms.Label lblMenipisKet;
        private System.Windows.Forms.Label lblMenipisNilai;
        private System.Windows.Forms.Label lblMenipisJudul;
        private RoundedPanel cardHabis;
        private System.Windows.Forms.Label lblHabisKet;
        private System.Windows.Forms.Label lblHabisNilai;
        private System.Windows.Forms.Label lblHabisJudul;
        private System.Windows.Forms.Timer timerJam;
        private System.Windows.Forms.Timer timerRefresh;
        private System.Windows.Forms.ToolTip toolTip1;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
    }
}