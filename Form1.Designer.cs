namespace TekananDarahApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            labelUsername = new Label();
            labelPassword = new Label();
            textUsername = new TextBox();
            textPassword = new TextBox();
            buttonLogin = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(80, 99);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(215, 208);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Font = new Font("Segoe UI", 16F);
            labelUsername.Location = new Point(357, 130);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(111, 30);
            labelUsername.TabIndex = 1;
            labelUsername.Text = "Username";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Segoe UI", 16F);
            labelPassword.Location = new Point(357, 186);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(103, 30);
            labelPassword.TabIndex = 2;
            labelPassword.Text = "Password";
            // 
            // textUsername
            // 
            textUsername.Location = new Point(495, 137);
            textUsername.Name = "textUsername";
            textUsername.Size = new Size(211, 23);
            textUsername.TabIndex = 3;
            // 
            // textPassword
            // 
            textPassword.Location = new Point(495, 193);
            textPassword.Name = "textPassword";
            textPassword.Size = new Size(211, 23);
            textPassword.TabIndex = 4;
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = Color.FromArgb(57, 153, 242);
            buttonLogin.FlatAppearance.BorderSize = 0;
            buttonLogin.FlatStyle = FlatStyle.Flat;
            buttonLogin.Font = new Font("Segoe UI", 16F);
            buttonLogin.Location = new Point(430, 238);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(202, 50);
            buttonLogin.TabIndex = 5;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(789, 438);
            Controls.Add(buttonLogin);
            Controls.Add(textPassword);
            Controls.Add(textUsername);
            Controls.Add(labelPassword);
            Controls.Add(labelUsername);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label labelUsername;
        private Label labelPassword;
        private TextBox textUsername;
        private TextBox textPassword;
        private Button buttonLogin;
    }
}
