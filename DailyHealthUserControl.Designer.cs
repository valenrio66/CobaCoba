namespace TekananDarahApp
{
    partial class DailyHealthUserControl
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
            buttonSave = new Button();
            bloodPressInput = new TextBox();
            weightInput = new TextBox();
            tanggalInput = new TextBox();
            usiaInput = new TextBox();
            namaInput = new TextBox();
            bloodSugarLevelInput = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(16, 215);
            buttonSave.Margin = new Padding(2);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(78, 33);
            buttonSave.TabIndex = 27;
            buttonSave.Text = "Simpan";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // bloodPressInput
            // 
            bloodPressInput.Location = new Point(149, 135);
            bloodPressInput.Margin = new Padding(2);
            bloodPressInput.Name = "bloodPressInput";
            bloodPressInput.Size = new Size(322, 23);
            bloodPressInput.TabIndex = 26;
            // 
            // weightInput
            // 
            weightInput.Location = new Point(149, 104);
            weightInput.Margin = new Padding(2);
            weightInput.Name = "weightInput";
            weightInput.Size = new Size(322, 23);
            weightInput.TabIndex = 25;
            // 
            // tanggalInput
            // 
            tanggalInput.Location = new Point(149, 72);
            tanggalInput.Margin = new Padding(2);
            tanggalInput.Name = "tanggalInput";
            tanggalInput.Size = new Size(322, 23);
            tanggalInput.TabIndex = 24;
            // 
            // usiaInput
            // 
            usiaInput.Location = new Point(149, 41);
            usiaInput.Margin = new Padding(2);
            usiaInput.Name = "usiaInput";
            usiaInput.Size = new Size(322, 23);
            usiaInput.TabIndex = 23;
            // 
            // namaInput
            // 
            namaInput.Location = new Point(149, 8);
            namaInput.Margin = new Padding(2);
            namaInput.Name = "namaInput";
            namaInput.Size = new Size(322, 23);
            namaInput.TabIndex = 22;
            // 
            // bloodSugarLevelInput
            // 
            bloodSugarLevelInput.Location = new Point(149, 170);
            bloodSugarLevelInput.Margin = new Padding(2);
            bloodSugarLevelInput.Name = "bloodSugarLevelInput";
            bloodSugarLevelInput.Size = new Size(322, 23);
            bloodSugarLevelInput.TabIndex = 21;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(16, 176);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(98, 15);
            label6.TabIndex = 20;
            label6.Text = "Kadar Gula Darah";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 143);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(84, 15);
            label5.TabIndex = 19;
            label5.Text = "Tekanan Darah";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 80);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(48, 15);
            label4.TabIndex = 18;
            label4.Text = "Tanggal";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 111);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 17;
            label3.Text = "Berat Badan";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 49);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 16;
            label2.Text = "Usia";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 16);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 15;
            label1.Text = "Nama";
            // 
            // DailyHealthUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(buttonSave);
            Controls.Add(bloodPressInput);
            Controls.Add(weightInput);
            Controls.Add(tanggalInput);
            Controls.Add(usiaInput);
            Controls.Add(namaInput);
            Controls.Add(bloodSugarLevelInput);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "DailyHealthUserControl";
            Size = new Size(480, 255);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonSave;
        private TextBox bloodPressInput;
        private TextBox weightInput;
        private TextBox tanggalInput;
        private TextBox usiaInput;
        private TextBox namaInput;
        private TextBox bloodSugarLevelInput;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}
