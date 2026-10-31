namespace GUedang
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            button1 = new Button();
            label1 = new Label();
            lblAdmin = new Label();
            panel1 = new Panel();
            panelContent = new Panel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.DodgerBlue;
            button1.Font = new Font("Segoe UI", 10F);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(802, 50);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(153, 53);
            button1.TabIndex = 0;
            button1.Text = "Logout/Back";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label1.Location = new Point(256, 28);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(201, 45);
            label1.TabIndex = 2;
            label1.Text = " SMK MART";
            label1.Click += label1_Click;
            // 
            // lblAdmin
            // 
            lblAdmin.AutoSize = true;
            lblAdmin.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblAdmin.Location = new Point(577, 58);
            lblAdmin.Margin = new Padding(4, 0, 4, 0);
            lblAdmin.Name = "lblAdmin";
            lblAdmin.Size = new Size(138, 45);
            lblAdmin.TabIndex = 3;
            lblAdmin.Text = "Admin :";
            lblAdmin.Click += label2_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(lblAdmin);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-6, -3);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1087, 137);
            panel1.TabIndex = 5;
            // 
            // panelContent
            // 
            panelContent.BackColor = Color.WhiteSmoke;
            panelContent.Location = new Point(-1, 123);
            panelContent.Margin = new Padding(4, 5, 4, 5);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(1086, 538);
            panelContent.TabIndex = 10;
            panelContent.Paint += panel3_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(177, 28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(90, 75);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(273, 78);
            label2.Name = "label2";
            label2.Size = new Size(184, 25);
            label2.TabIndex = 5;
            label2.Text = "Selamt datang,Admin";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(516, 50);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(66, 53);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(1073, 629);
            Controls.Add(panelContent);
            Controls.Add(panel1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form2";
            Text = "DashboardAdmin";
            Load += Form2_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label lblAdmin;
        private Panel panel1;
        private FlowLayoutPanel flowLayoutPanel3;
        private Panel panelContent;
        private Label label2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}