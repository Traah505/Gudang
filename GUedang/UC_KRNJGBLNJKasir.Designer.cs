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
            lblNominalTotal = new Label();
            label2 = new Label();
            btnReset = new RoundedButton();
            btnBayar = new RoundedButton();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            label5 = new Label();
            rondedbuton1 = new Rondedbuton();
            textBox4 = new TextBox();
            label6 = new Label();
            textBox5 = new TextBox();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvKeranjang).BeginInit();
            roundedPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(51, 13);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(191, 30);
            label1.TabIndex = 4;
            label1.Text = "Keranjang Belanja";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(2, 7);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(45, 41);
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
            btnHapusSemua.Location = new Point(509, 15);
            btnHapusSemua.Margin = new Padding(2);
            btnHapusSemua.Name = "btnHapusSemua";
            btnHapusSemua.Size = new Size(113, 28);
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
            dgvKeranjang.Location = new Point(0, 174);
            dgvKeranjang.Margin = new Padding(2);
            dgvKeranjang.MultiSelect = false;
            dgvKeranjang.Name = "dgvKeranjang";
            dgvKeranjang.ReadOnly = true;
            dgvKeranjang.RowHeadersVisible = false;
            dgvKeranjang.RowHeadersWidth = 62;
            dgvKeranjang.RowTemplate.Height = 40;
            dgvKeranjang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKeranjang.Size = new Size(638, 183);
            dgvKeranjang.TabIndex = 7;
            dgvKeranjang.CellContentClick += dgvKeranjang_CellContentClick;
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
            roundedPanel1.Location = new Point(11, 433);
            roundedPanel1.Margin = new Padding(2);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Size = new Size(193, 48);
            roundedPanel1.TabIndex = 8;
            // 
            // lblNominalTotal
            // 
            lblNominalTotal.AutoSize = true;
            lblNominalTotal.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNominalTotal.ForeColor = Color.MidnightBlue;
            lblNominalTotal.Location = new Point(41, 17);
            lblNominalTotal.Margin = new Padding(2, 0, 2, 0);
            lblNominalTotal.Name = "lblNominalTotal";
            lblNominalTotal.Size = new Size(54, 30);
            lblNominalTotal.TabIndex = 1;
            lblNominalTotal.Text = "Rp0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(17, 0);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(112, 19);
            label2.TabIndex = 0;
            label2.Text = "📄Total Belanja";
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.White;
            btnReset.FlatAppearance.BorderSize = 0;
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReset.ForeColor = Color.RoyalBlue;
            btnReset.Location = new Point(392, 435);
            btnReset.Margin = new Padding(2);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(98, 45);
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
            btnBayar.Location = new Point(494, 435);
            btnBayar.Margin = new Padding(2);
            btnBayar.Name = "btnBayar";
            btnBayar.Size = new Size(126, 45);
            btnBayar.TabIndex = 10;
            btnBayar.Text = "▣ Bayar  ›";
            btnBayar.UseVisualStyleBackColor = false;
            btnBayar.Click += btnBayar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(3, 84);
            label3.Name = "label3";
            label3.Size = new Size(78, 15);
            label3.TabIndex = 12;
            label3.Text = "Kode Barang";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(0, 102);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(144, 23);
            textBox1.TabIndex = 13;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(153, 102);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(144, 23);
            textBox2.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(153, 84);
            label4.Name = "label4";
            label4.Size = new Size(81, 15);
            label4.TabIndex = 15;
            label4.Text = "Nama Barang";
            label4.Click += label4_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(153, 146);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(144, 23);
            textBox3.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(153, 128);
            label5.Name = "label5";
            label5.Size = new Size(88, 15);
            label5.TabIndex = 17;
            label5.Text = "Jumlah Barang";
            // 
            // rondedbuton1
            // 
            rondedbuton1.BackColor = Color.RoyalBlue;
            rondedbuton1.FlatAppearance.BorderSize = 0;
            rondedbuton1.FlatStyle = FlatStyle.Flat;
            rondedbuton1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rondedbuton1.ForeColor = Color.White;
            rondedbuton1.Location = new Point(453, 96);
            rondedbuton1.Name = "rondedbuton1";
            rondedbuton1.Size = new Size(57, 50);
            rondedbuton1.TabIndex = 19;
            rondedbuton1.Text = "+";
            rondedbuton1.UseVisualStyleBackColor = false;
            rondedbuton1.Click += rondedbuton1_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(3, 146);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(144, 23);
            textBox4.TabIndex = 20;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(3, 128);
            label6.Name = "label6";
            label6.Size = new Size(97, 15);
            label6.TabIndex = 21;
            label6.Text = "Kategori Barang";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(303, 102);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(144, 23);
            textBox5.TabIndex = 22;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.Location = new Point(303, 84);
            label7.Name = "label7";
            label7.Size = new Size(81, 15);
            label7.TabIndex = 23;
            label7.Text = "Harga barang";
            // 
            // UC_KRNJGBLNJKasir
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label7);
            Controls.Add(textBox5);
            Controls.Add(label6);
            Controls.Add(textBox4);
            Controls.Add(rondedbuton1);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(btnBayar);
            Controls.Add(btnReset);
            Controls.Add(roundedPanel1);
            Controls.Add(dgvKeranjang);
            Controls.Add(btnHapusSemua);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "UC_KRNJGBLNJKasir";
            Size = new Size(1500, 900);
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
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label4;
        private TextBox textBox3;
        private Label label5;
        private Rondedbuton rondedbuton1;
        private TextBox textBox4;
        private Label label6;
        private TextBox textBox5;
        private Label label7;
    }
}
