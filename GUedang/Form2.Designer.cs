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
            button1 = new Button();
            label1 = new Label();
            lblAdmin = new Label();
            label3 = new Label();
            panel1 = new Panel();
            panelContent = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10F);
            button1.Location = new Point(506, 30);
            button1.Name = "button1";
            button1.Size = new Size(107, 32);
            button1.TabIndex = 0;
            button1.Text = "Logout/Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DarkGray;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label1.Location = new Point(118, 30);
            label1.Name = "label1";
            label1.Size = new Size(231, 30);
            label1.TabIndex = 2;
            label1.Text = "GUDANG SMK MART";
            label1.Click += label1_Click;
            // 
            // lblAdmin
            // 
            lblAdmin.AutoSize = true;
            lblAdmin.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblAdmin.Location = new Point(355, 30);
            lblAdmin.Name = "lblAdmin";
            lblAdmin.Size = new Size(93, 30);
            lblAdmin.TabIndex = 3;
            lblAdmin.Text = "Admin :";
            lblAdmin.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label3.Location = new Point(51, 26);
            label3.Name = "label3";
            label3.Size = new Size(61, 30);
            label3.TabIndex = 4;
            label3.Text = "Logs";
            label3.Click += label3_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkGray;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(lblAdmin);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-4, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(632, 82);
            panel1.TabIndex = 5;
            // 
            // panelContent
            // 
            panelContent.BackColor = Color.WhiteSmoke;
            panelContent.Location = new Point(-1, 74);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(629, 380);
            panelContent.TabIndex = 10;
            panelContent.Paint += panel3_Paint;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(626, 450);
            Controls.Add(panelContent);
            Controls.Add(panel1);
            Name = "Form2";
            Text = "DashboardAdmin";
            Load += Form2_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label lblAdmin;
        private Label label3;
        private Panel panel1;
        private FlowLayoutPanel flowLayoutPanel3;
        private Panel panelContent;
    }
}