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
        }

        public void LoadHealthRecords()
        {
            var dbService = new MongoDBService();
            var records = dbService.GetAllHealthRecords();

            dataGridView1.DataSource = records;
        }

        public void RefreshChart()
        {
            var dbService = new MongoDBService();
            var records = dbService.GetAllHealthRecords();

            chartBloodData.Series.Clear();

            Series bloodPressureSeries = new Series("Blood Pressure")
            {
                ChartType = SeriesChartType.Line,
                Color = Color.Red
            };

            Series bloodSugarSeries = new Series("Blood Sugar Level")
            {
                ChartType = SeriesChartType.Line,
                Color = Color.Blue
            };

            foreach (var record in records)
            {
                if (record.BloodPressure != null && double.TryParse(record.BloodPressure, out double bpValue))
                {
                    bloodPressureSeries.Points.AddXY(record.Date.ToString("MM/dd/yyyy"), bpValue);
                }

                if (record.BloodSugarLevel != null)
                {
                    bloodSugarSeries.Points.AddXY(record.Date.ToString("MM/dd/yyyy"), record.BloodSugarLevel);
                }
            }

            chartBloodData.Series.Add(bloodPressureSeries);
            chartBloodData.Series.Add(bloodSugarSeries);
        }
    }
}
