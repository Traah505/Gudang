namespace GUedang
{
    partial class Form4
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            curvedSplitPanel1 = new CurvedSplitPanel();
            rondedbuton1 = new Rondedbuton();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            curvedSplitPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.Controls.Add(dataGridView1);
            panel2.Location = new Point(133, 1);
            panel2.Name = "panel2";
            panel2.Size = new Size(578, 397);
            panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(581, 397);
            dataGridView1.TabIndex = 1;
            // 
            // curvedSplitPanel1
            // 
            curvedSplitPanel1.BackColor = Color.Transparent;
            curvedSplitPanel1.Controls.Add(rondedbuton1);
            curvedSplitPanel1.Location = new Point(1, 1);
            curvedSplitPanel1.Name = "curvedSplitPanel1";
            curvedSplitPanel1.Size = new Size(133, 400);
            curvedSplitPanel1.TabIndex = 2;
            // 
            // rondedbuton1
            // 
            rondedbuton1.BackColor = Color.FromArgb(24, 43, 73);
            rondedbuton1.FlatAppearance.BorderSize = 0;
            rondedbuton1.FlatStyle = FlatStyle.Flat;
            rondedbuton1.ForeColor = Color.White;
            rondedbuton1.Location = new Point(4, 39);
            rondedbuton1.Name = "rondedbuton1";
            rondedbuton1.Size = new Size(125, 32);
            rondedbuton1.TabIndex = 0;
            rondedbuton1.Text = "rondedbuton1";
            rondedbuton1.UseVisualStyleBackColor = false;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(711, 391);
            Controls.Add(curvedSplitPanel1);
            Controls.Add(panel2);
            Name = "Form4";
            Text = "Gudang";
            Load += Form4_Load;
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            curvedSplitPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TextBox textBox2;
        private TextBox textBox11;
        private Label label4;
        private Label label3;
        private Panel panel2;
        private CurvedSplitPanel curvedSplitPanel1;
        private DataGridView dataGridView1;
        private Rondedbuton rondedbuton1;
    }
}