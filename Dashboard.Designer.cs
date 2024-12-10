namespace TekananDarahApp
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            labelHello = new Label();
            panel1 = new Panel();
            buttonLogout = new Button();
            buttonUser = new Button();
            buttonHealth = new Button();
            buttonDashboard = new Button();
            panel3 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            label2 = new Label();
            panelLeft = new Panel();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // labelHello
            // 
            labelHello.AutoSize = true;
            labelHello.Font = new Font("Segoe UI", 20F);
            labelHello.Location = new Point(303, 191);
            labelHello.Name = "labelHello";
            labelHello.Size = new Size(0, 37);
            labelHello.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonLogout);
            panel1.Controls.Add(buttonUser);
            panel1.Controls.Add(buttonHealth);
            panel1.Controls.Add(buttonDashboard);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(174, 730);
            panel1.TabIndex = 1;
            // 
            // buttonLogout
            // 
            buttonLogout.FlatAppearance.BorderSize = 0;
            buttonLogout.FlatStyle = FlatStyle.Flat;
            buttonLogout.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonLogout.ForeColor = Color.White;
            buttonLogout.Image = (Image)resources.GetObject("buttonLogout.Image");
            buttonLogout.Location = new Point(0, 639);
            buttonLogout.Name = "buttonLogout";
            buttonLogout.Size = new Size(174, 88);
            buttonLogout.TabIndex = 7;
            buttonLogout.Text = "Logout";
            buttonLogout.TextAlign = ContentAlignment.BottomCenter;
            buttonLogout.TextImageRelation = TextImageRelation.ImageAboveText;
            buttonLogout.UseVisualStyleBackColor = true;
            // 
            // buttonUser
            // 
            buttonUser.FlatAppearance.BorderSize = 0;
            buttonUser.FlatStyle = FlatStyle.Flat;
            buttonUser.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonUser.ForeColor = Color.White;
            buttonUser.Image = (Image)resources.GetObject("buttonUser.Image");
            buttonUser.Location = new Point(0, 291);
            buttonUser.Name = "buttonUser";
            buttonUser.Size = new Size(174, 88);
            buttonUser.TabIndex = 6;
            buttonUser.Text = "User";
            buttonUser.TextAlign = ContentAlignment.BottomCenter;
            buttonUser.TextImageRelation = TextImageRelation.ImageAboveText;
            buttonUser.UseVisualStyleBackColor = true;
            buttonUser.Click += buttonUser_Click;
            // 
            // buttonHealth
            // 
            buttonHealth.FlatAppearance.BorderSize = 0;
            buttonHealth.FlatStyle = FlatStyle.Flat;
            buttonHealth.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonHealth.ForeColor = Color.White;
            buttonHealth.Image = (Image)resources.GetObject("buttonHealth.Image");
            buttonHealth.Location = new Point(0, 197);
            buttonHealth.Name = "buttonHealth";
            buttonHealth.Size = new Size(174, 88);
            buttonHealth.TabIndex = 5;
            buttonHealth.Text = "Daily Health";
            buttonHealth.TextAlign = ContentAlignment.BottomCenter;
            buttonHealth.TextImageRelation = TextImageRelation.ImageAboveText;
            buttonHealth.UseVisualStyleBackColor = true;
            buttonHealth.Click += buttonHealth_Click;
            // 
            // buttonDashboard
            // 
            buttonDashboard.FlatAppearance.BorderSize = 0;
            buttonDashboard.FlatStyle = FlatStyle.Flat;
            buttonDashboard.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonDashboard.ForeColor = Color.White;
            buttonDashboard.Image = (Image)resources.GetObject("buttonDashboard.Image");
            buttonDashboard.Location = new Point(0, 103);
            buttonDashboard.Name = "buttonDashboard";
            buttonDashboard.Size = new Size(174, 88);
            buttonDashboard.TabIndex = 4;
            buttonDashboard.Text = "Dashboard";
            buttonDashboard.TextAlign = ContentAlignment.BottomCenter;
            buttonDashboard.TextImageRelation = TextImageRelation.ImageAboveText;
            buttonDashboard.UseVisualStyleBackColor = true;
            buttonDashboard.Click += buttonDashboard_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(41, 44, 51);
            panel3.Controls.Add(label1);
            panel3.Dock = DockStyle.Top;
            panel3.ForeColor = Color.FromArgb(192, 255, 255);
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(174, 83);
            panel3.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Monotype Corsiva", 72F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(21, -17);
            label1.Name = "label1";
            label1.Size = new Size(112, 117);
            label1.TabIndex = 3;
            label1.Text = "V";
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(174, 82);
            panel2.Name = "panel2";
            panel2.Size = new Size(1122, 648);
            panel2.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(214, 31);
            label2.Name = "label2";
            label2.Size = new Size(106, 21);
            label2.TabIndex = 3;
            label2.Text = "Data Harian";
            // 
            // panelLeft
            // 
            panelLeft.BackColor = Color.FromArgb(192, 255, 255);
            panelLeft.Location = new Point(174, 103);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(10, 88);
            panelLeft.TabIndex = 5;
            // 
            // Dashboard
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(41, 44, 51);
            ClientSize = new Size(1296, 730);
            Controls.Add(panelLeft);
            Controls.Add(label2);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(labelHello);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(62, 120, 138);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Dashboard";
            Text = "Dashboard";
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelHello;
        private Panel panel1;
        private Panel panel3;
        private Label label1;
        private Panel panel2;
        private Button buttonDashboard;
        private Label label2;
        private Button buttonUser;
        private Button buttonHealth;
        private Button buttonLogout;
        private Panel panelLeft;
    }
}