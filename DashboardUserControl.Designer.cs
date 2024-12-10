namespace TekananDarahApp
{
    partial class DashboardUserControl
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            chartBloodData = new System.Windows.Forms.DataVisualization.Charting.Chart();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)chartBloodData).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // chartBloodData
            // 
            chartBloodData.BackColor = Color.FromArgb(41, 44, 51);
            chartArea1.AxisX.LineColor = Color.White;
            chartArea1.AxisX.ScrollBar.LineColor = Color.White;
            chartArea1.AxisX.TitleForeColor = Color.White;
            chartArea1.AxisX2.LineColor = Color.White;
            chartArea1.AxisX2.TitleForeColor = Color.White;
            chartArea1.AxisY.LineColor = Color.White;
            chartArea1.AxisY.TitleForeColor = Color.White;
            chartArea1.AxisY2.LineColor = Color.White;
            chartArea1.AxisY2.TitleForeColor = Color.White;
            chartArea1.BackColor = Color.FromArgb(41, 44, 51);
            chartArea1.Name = "ChartArea1";
            chartBloodData.ChartAreas.Add(chartArea1);
            legend1.BackColor = Color.FromArgb(41, 44, 51);
            legend1.ForeColor = Color.White;
            legend1.Name = "Legend1";
            chartBloodData.Legends.Add(legend1);
            chartBloodData.Location = new Point(19, 13);
            chartBloodData.Name = "chartBloodData";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Blood Pressure";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Blood Sugar Level";
            chartBloodData.Series.Add(series1);
            chartBloodData.Series.Add(series2);
            chartBloodData.Size = new Size(689, 287);
            chartBloodData.TabIndex = 0;
            chartBloodData.Text = "chart1";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(19, 365);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(689, 228);
            dataGridView1.TabIndex = 1;
            // 
            // DashboardUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(41, 44, 51);
            Controls.Add(dataGridView1);
            Controls.Add(chartBloodData);
            Name = "DashboardUserControl";
            Size = new Size(724, 612);
            ((System.ComponentModel.ISupportInitialize)chartBloodData).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartBloodData;
        private DataGridView dataGridView1;
    }
}
