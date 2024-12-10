namespace TekananDarahApp
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
            labelName = new Label();
            label1 = new Label();
            labelPassword = new Label();
            labelUsername = new Label();
            labelAge = new Label();
            labelRegistTitle = new Label();
            textName = new TextBox();
            textPassword = new TextBox();
            textUsername = new TextBox();
            textAge = new TextBox();
            buttonRegister = new Button();
            SuspendLayout();
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Segoe UI", 16F);
            labelName.Location = new Point(27, 99);
            labelName.Name = "labelName";
            labelName.Size = new Size(71, 30);
            labelName.TabIndex = 0;
            labelName.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(326, 206);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 1;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Segoe UI", 16F);
            labelPassword.Location = new Point(27, 338);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(103, 30);
            labelPassword.TabIndex = 2;
            labelPassword.Text = "Password";
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Font = new Font("Segoe UI", 16F);
            labelUsername.Location = new Point(27, 250);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(111, 30);
            labelUsername.TabIndex = 3;
            labelUsername.Text = "Username";
            // 
            // labelAge
            // 
            labelAge.AutoSize = true;
            labelAge.Font = new Font("Segoe UI", 16F);
            labelAge.Location = new Point(27, 173);
            labelAge.Name = "labelAge";
            labelAge.Size = new Size(52, 30);
            labelAge.TabIndex = 4;
            labelAge.Text = "Age";
            // 
            // labelRegistTitle
            // 
            labelRegistTitle.AutoSize = true;
            labelRegistTitle.Font = new Font("Sans Serif Collection", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelRegistTitle.Location = new Point(12, 9);
            labelRegistTitle.Name = "labelRegistTitle";
            labelRegistTitle.Size = new Size(201, 67);
            labelRegistTitle.TabIndex = 5;
            labelRegistTitle.Text = "Register";
            // 
            // textName
            // 
            textName.Location = new Point(30, 132);
            textName.Name = "textName";
            textName.Size = new Size(259, 23);
            textName.TabIndex = 6;
            // 
            // textPassword
            // 
            textPassword.Location = new Point(30, 371);
            textPassword.Name = "textPassword";
            textPassword.Size = new Size(259, 23);
            textPassword.TabIndex = 7;
            // 
            // textUsername
            // 
            textUsername.Location = new Point(30, 283);
            textUsername.Name = "textUsername";
            textUsername.Size = new Size(259, 23);
            textUsername.TabIndex = 8;
            // 
            // textAge
            // 
            textAge.Location = new Point(30, 206);
            textAge.Name = "textAge";
            textAge.Size = new Size(259, 23);
            textAge.TabIndex = 9;
            // 
            // buttonRegister
            // 
            buttonRegister.Font = new Font("Segoe UI", 16F);
            buttonRegister.Location = new Point(30, 428);
            buttonRegister.Name = "buttonRegister";
            buttonRegister.Size = new Size(169, 70);
            buttonRegister.TabIndex = 10;
            buttonRegister.Text = "Register";
            buttonRegister.UseVisualStyleBackColor = true;
            buttonRegister.Click += buttonRegister_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(737, 526);
            Controls.Add(buttonRegister);
            Controls.Add(textAge);
            Controls.Add(textUsername);
            Controls.Add(textPassword);
            Controls.Add(textName);
            Controls.Add(labelRegistTitle);
            Controls.Add(labelAge);
            Controls.Add(labelUsername);
            Controls.Add(labelPassword);
            Controls.Add(label1);
            Controls.Add(labelName);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelName;
        private Label label1;
        private Label labelPassword;
        private Label labelUsername;
        private Label labelAge;
        private Label labelRegistTitle;
        private TextBox textName;
        private TextBox textPassword;
        private TextBox textUsername;
        private TextBox textAge;
        private Button buttonRegister;
    }
}