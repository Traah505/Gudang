namespace GUedang
{
    partial class UC_KRNJGBLNJKasir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_KRNJGBLNJKasir));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            btnHapusSemua = new RoundedButton();
            dgvKeranjang = new DataGridView();
            colNo = new DataGridViewTextBoxColumn();
            colKode = new DataGridViewTextBoxColumn();
            colNama = new DataGridViewTextBoxColumn();
            colHarga = new DataGridViewTextBoxColumn();
            colJumlah = new DataGridViewTextBoxColumn();
            colSubtotal = new DataGridViewTextBoxColumn();
            colAksi = new DataGridViewButtonColumn();
            roundedPanel1 = new RoundedPanel();
            label2 = new Label();
            lblNominalTotal = new Label();
            btnReset = new RoundedButton();
            btnBayar = new RoundedButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvKeranjang).BeginInit();
            roundedPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(216, 25);
            label1.Name = "label1";
            label1.Size = new Size(212, 32);
            label1.TabIndex = 4;
            label1.Text = "Keranjang Belanja";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(188, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(31, 35);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // btnHapusSemua
            // 
            btnHapusSemua.BackColor = Color.AliceBlue;
            btnHapusSemua.FlatAppearance.BorderSize = 0;
            btnHapusSemua.FlatStyle = FlatStyle.Flat;
            btnHapusSemua.ForeColor = Color.RoyalBlue;
            btnHapusSemua.Location = new Point(686, 25);
            btnHapusSemua.Name = "btnHapusSemua";
            btnHapusSemua.Size = new Size(162, 46);
            btnHapusSemua.TabIndex = 6;
            btnHapusSemua.Text = "🗑️Hapus Semua";
            btnHapusSemua.UseVisualStyleBackColor = false;
            // 
            // dgvKeranjang
            // 
            dgvKeranjang.AllowUserToAddRows = false;
            dgvKeranjang.AllowUserToDeleteRows = false;
            dgvKeranjang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKeranjang.BackgroundColor = Color.White;
            dgvKeranjang.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.SteelBlue;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvKeranjang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvKeranjang.ColumnHeadersHeight = 40;
            dgvKeranjang.Columns.AddRange(new DataGridViewColumn[] { colNo, colKode, colNama, colHarga, colJumlah, colSubtotal, colAksi });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.DimGray;
            dataGridViewCellStyle2.Padding = new Padding(6);
            dataGridViewCellStyle2.SelectionBackColor = Color.DodgerBlue;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvKeranjang.DefaultCellStyle = dataGridViewCellStyle2;
            dgvKeranjang.EnableHeadersVisualStyles = false;
            dgvKeranjang.Location = new Point(216, 84);
            dgvKeranjang.MultiSelect = false;
            dgvKeranjang.Name = "dgvKeranjang";
            dgvKeranjang.ReadOnly = true;
            dgvKeranjang.RowHeadersVisible = false;
            dgvKeranjang.RowHeadersWidth = 62;
            dgvKeranjang.RowTemplate.Height = 40;
            dgvKeranjang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKeranjang.Size = new Size(656, 356);
            dgvKeranjang.TabIndex = 7;
            // 
            // colNo
            // 
            colNo.FillWeight = 45F;
            colNo.HeaderText = "No";
            colNo.MinimumWidth = 8;
            colNo.Name = "colNo";
            colNo.ReadOnly = true;
            // 
            // colKode
            // 
            colKode.FillWeight = 105F;
            colKode.HeaderText = "Kode Barang";
            colKode.MinimumWidth = 8;
            colKode.Name = "colKode";
            colKode.ReadOnly = true;
            // 
            // colNama
            // 
            colNama.FillWeight = 125F;
            colNama.HeaderText = "Nama Barang";
            colNama.MinimumWidth = 8;
            colNama.Name = "colNama";
            colNama.ReadOnly = true;
            // 
            // colHarga
            // 
            colHarga.FillWeight = 85F;
            colHarga.HeaderText = "Harga";
            colHarga.MinimumWidth = 8;
            colHarga.Name = "colHarga";
            colHarga.ReadOnly = true;
            // 
            // colJumlah
            // 
            colJumlah.HeaderText = "Jumlah";
            colJumlah.MinimumWidth = 8;
            colJumlah.Name = "colJumlah";
            colJumlah.ReadOnly = true;
            // 
            // colSubtotal
            // 
            colSubtotal.FillWeight = 105F;
            colSubtotal.HeaderText = "Subtotal";
            colSubtotal.MinimumWidth = 8;
            colSubtotal.Name = "colSubtotal";
            colSubtotal.ReadOnly = true;
            // 
            // colAksi
            // 
            colAksi.FillWeight = 65F;
            colAksi.HeaderText = "Aksi";
            colAksi.MinimumWidth = 8;
            colAksi.Name = "colAksi";
            colAksi.ReadOnly = true;
            // 
            // roundedPanel1
            // 
            roundedPanel1.BackColor = Color.Transparent;
            roundedPanel1.Controls.Add(lblNominalTotal);
            roundedPanel1.Controls.Add(label2);
            roundedPanel1.Location = new Point(216, 460);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Size = new Size(276, 80);
            roundedPanel1.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(24, 0);
            label2.Name = "label2";
            label2.Size = new Size(163, 28);
            label2.TabIndex = 0;
            label2.Text = "📄Total Belanja";
            // 
            // lblNominalTotal
            // 
            lblNominalTotal.AutoSize = true;
            lblNominalTotal.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNominalTotal.ForeColor = Color.MidnightBlue;
            lblNominalTotal.Location = new Point(59, 28);
            lblNominalTotal.Name = "lblNominalTotal";
            lblNominalTotal.Size = new Size(79, 45);
            lblNominalTotal.TabIndex = 1;
            lblNominalTotal.Text = "Rp0";
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.White;
            btnReset.FlatAppearance.BorderSize = 0;
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReset.ForeColor = Color.RoyalBlue;
            btnReset.Location = new Point(534, 458);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(140, 75);
            btnReset.TabIndex = 9;
            btnReset.Text = "⟳ Reset";
            btnReset.UseVisualStyleBackColor = false;
            // 
            // btnBayar
            // 
            btnBayar.BackColor = Color.RoyalBlue;
            btnBayar.FlatAppearance.BorderSize = 0;
            btnBayar.FlatStyle = FlatStyle.Flat;
            btnBayar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBayar.ForeColor = Color.White;
            btnBayar.Location = new Point(709, 458);
            btnBayar.Name = "btnBayar";
            btnBayar.Size = new Size(180, 75);
            btnBayar.TabIndex = 10;
            btnBayar.Text = "▣ Bayar  ›";
            btnBayar.UseVisualStyleBackColor = false;
            // 
            // UC_KRNJGBLNJKasir
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnBayar);
            Controls.Add(btnReset);
            Controls.Add(roundedPanel1);
            Controls.Add(dgvKeranjang);
            Controls.Add(btnHapusSemua);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "UC_KRNJGBLNJKasir";
            Size = new Size(906, 543);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvKeranjang).EndInit();
            roundedPanel1.ResumeLayout(false);
            roundedPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private RoundedButton btnHapusSemua;
        private DataGridView dgvKeranjang;
        private DataGridViewTextBoxColumn colNo;
        private DataGridViewTextBoxColumn colKode;
        private DataGridViewTextBoxColumn colNama;
        private DataGridViewTextBoxColumn colHarga;
        private DataGridViewTextBoxColumn colJumlah;
        private DataGridViewTextBoxColumn colSubtotal;
        private DataGridViewButtonColumn colAksi;
        private RoundedPanel roundedPanel1;
        private Label lblNominalTotal;
        private Label label2;
        private RoundedButton btnReset;
        private RoundedButton btnBayar;
    }
}
