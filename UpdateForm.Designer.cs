namespace TekananDarahApp
{
    partial class UpdateForm
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
            buttonSubmitUpdate = new Button();
            bloodPressInput = new TextBox();
            usiaInput = new TextBox();
            namaInput = new TextBox();
            bloodSugarLevelInput = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            datePicker = new DateTimePicker();
            weightPicker = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)weightPicker).BeginInit();
            SuspendLayout();
            // 
            // buttonSubmitUpdate
            // 
            buttonSubmitUpdate.Location = new Point(8, 211);
            buttonSubmitUpdate.Margin = new Padding(2);
            buttonSubmitUpdate.Name = "buttonSubmitUpdate";
            buttonSubmitUpdate.Size = new Size(78, 33);
            buttonSubmitUpdate.TabIndex = 40;
            buttonSubmitUpdate.Text = "Update";
            buttonSubmitUpdate.UseVisualStyleBackColor = true;
            buttonSubmitUpdate.Click += buttonSubmitUpdate_Click;
            // 
            // bloodPressInput
            // 
            bloodPressInput.Location = new Point(141, 139);
            bloodPressInput.Margin = new Padding(2);
            bloodPressInput.Name = "bloodPressInput";
            bloodPressInput.Size = new Size(322, 23);
            bloodPressInput.TabIndex = 39;
            // 
            // usiaInput
            // 
            usiaInput.Location = new Point(141, 45);
            usiaInput.Margin = new Padding(2);
            usiaInput.Name = "usiaInput";
            usiaInput.Size = new Size(322, 23);
            usiaInput.TabIndex = 36;
            // 
            // namaInput
            // 
            namaInput.Location = new Point(141, 12);
            namaInput.Margin = new Padding(2);
            namaInput.Name = "namaInput";
            namaInput.Size = new Size(322, 23);
            namaInput.TabIndex = 35;
            // 
            // bloodSugarLevelInput
            // 
            bloodSugarLevelInput.Location = new Point(141, 174);
            bloodSugarLevelInput.Margin = new Padding(2);
            bloodSugarLevelInput.Name = "bloodSugarLevelInput";
            bloodSugarLevelInput.Size = new Size(322, 23);
            bloodSugarLevelInput.TabIndex = 34;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(8, 180);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(98, 15);
            label6.TabIndex = 33;
            label6.Text = "Kadar Gula Darah";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(8, 147);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(84, 15);
            label5.TabIndex = 32;
            label5.Text = "Tekanan Darah";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 84);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(48, 15);
            label4.TabIndex = 31;
            label4.Text = "Tanggal";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 115);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 30;
            label3.Text = "Berat Badan";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 53);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 29;
            label2.Text = "Usia";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 20);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 28;
            label1.Text = "Nama";
            // 
            // datePicker
            // 
            datePicker.Location = new Point(141, 78);
            datePicker.Name = "datePicker";
            datePicker.Size = new Size(200, 23);
            datePicker.TabIndex = 41;
            // 
            // weightPicker
            // 
            weightPicker.Location = new Point(141, 111);
            weightPicker.Name = "weightPicker";
            weightPicker.Size = new Size(120, 23);
            weightPicker.TabIndex = 42;
            // 
            // UpdateForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(weightPicker);
            Controls.Add(datePicker);
            Controls.Add(buttonSubmitUpdate);
            Controls.Add(bloodPressInput);
            Controls.Add(usiaInput);
            Controls.Add(namaInput);
            Controls.Add(bloodSugarLevelInput);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UpdateForm";
            Size = new Size(478, 252);
            ((System.ComponentModel.ISupportInitialize)weightPicker).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonSubmitUpdate;
        private TextBox bloodPressInput;
        private TextBox usiaInput;
        private TextBox namaInput;
        private TextBox bloodSugarLevelInput;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DateTimePicker datePicker;
        private NumericUpDown weightPicker;
    }
}
