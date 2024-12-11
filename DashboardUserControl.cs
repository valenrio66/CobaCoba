using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using TekananDarahApp.Services;

namespace TekananDarahApp
{
    public partial class DashboardUserControl : UserControl
    {
        public DashboardUserControl()
        {
            InitializeComponent();
            LoadHealthRecords();
            RefreshChart();
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
        }

        public void LoadHealthRecords()
        {
            var dbService = new MongoDBService();
            var records = dbService.GetAllHealthRecords();

            dataGridView1.DataSource = records;

            if (!dataGridView1.Columns.Contains("UpdateButton"))
            {
                DataGridViewButtonColumn btnUpdate = new DataGridViewButtonColumn();
                btnUpdate.HeaderText = "Update";
                btnUpdate.Text = "Update";
                btnUpdate.Name = "UpdateButton";
                btnUpdate.UseColumnTextForButtonValue = true;  // Tombol akan menampilkan teks "Update"
                dataGridView1.Columns.Add(btnUpdate);
            }

            if (!dataGridView1.Columns.Contains("DeleteButton"))
            {
                DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
                btnDelete.HeaderText = "Delete";
                btnDelete.Text = "Delete";
                btnDelete.Name = "DeleteButton";
                btnDelete.UseColumnTextForButtonValue = true;  // Tombol akan menampilkan teks "Delete"
                dataGridView1.Columns.Add(btnDelete);
            }
        }

        public void RefreshChart()
        {
            var dbService = new MongoDBService();
            var records = dbService.GetAllHealthRecords();

            chartBloodData.Series.Clear();

            // Set up chart area and X axis for monthly data
            var chartArea = chartBloodData.ChartAreas[0];
            chartArea.AxisX.IntervalType = DateTimeIntervalType.Months;
            chartArea.AxisX.Interval = 1;
            chartArea.AxisX.LabelStyle.Format = "MM/yyyy";
            chartArea.AxisX.LabelStyle.Angle = -45; // Optional: rotate labels for better visibility
            chartArea.AxisX.LabelStyle.IsEndLabelVisible = true;
            chartArea.AxisX.MajorGrid.LineColor = Color.LightGray;
            chartArea.AxisX.MajorGrid.LineDashStyle = ChartDashStyle.Dot;

            chartArea.AxisY.MajorGrid.LineColor = Color.LightGray;
            chartArea.AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dot;

            // Blood Pressure series
            Series bloodPressureSeries = new Series("Blood Pressure")
            {
                ChartType = SeriesChartType.Line,
                Color = Color.Red,
                BorderWidth = 2
            };

            // Blood Sugar Level series
            Series bloodSugarSeries = new Series("Blood Sugar Level")
            {
                ChartType = SeriesChartType.Line,
                Color = Color.Blue,
                BorderWidth = 2
            };

            // Add points to series
            foreach (var record in records)
            {
                if (record.Date != null)
                {
                    var dateValue = record.Date; // Assuming record.Date is a DateTime

                    if (!string.IsNullOrEmpty(record.BloodPressure))
                    {
                        var bpParts = record.BloodPressure.Split('/');
                        if (bpParts.Length == 2 && double.TryParse(bpParts[0], out double bpSystolic))
                        {
                            bloodPressureSeries.Points.AddXY(dateValue, bpSystolic);
                        }
                    }

                    if (record.BloodSugarLevel != null)
                    {
                        bloodSugarSeries.Points.AddXY(dateValue, record.BloodSugarLevel);
                    }
                }
            }

            // Add series to chart
            chartBloodData.Series.Add(bloodPressureSeries);
            chartBloodData.Series.Add(bloodSugarSeries);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var record = dataGridView1.Rows[e.RowIndex].DataBoundItem as DailyHealthRecord;
                if (e.ColumnIndex == dataGridView1.Columns["UpdateButton"].Index)
                {
                    ShowUpdateForm(record);
                }
                else if (e.ColumnIndex == dataGridView1.Columns["DeleteButton"].Index)
                {
                    ConfirmAndDeleteRecord(record);
                }
            }
        }

        private void ShowUpdateForm(DailyHealthRecord record)
        {
            Dashboard dashboard = this.FindForm() as Dashboard; // Temukan form Dashboard menggunakan FindForm()
            if (dashboard != null)
            {
                dashboard.ShowUpdatePanel(record);
            }
            else
            {
                MessageBox.Show("Error: Could not find the Dashboard form.");
            }
        }

        private void ConfirmAndDeleteRecord(DailyHealthRecord record)
        {
            if (MessageBox.Show("Are you sure you want to delete this record?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var dbService = new MongoDBService();
                dbService.DeleteHealthRecord(record.Id);
                LoadHealthRecords();
            }
        }
    }
}
