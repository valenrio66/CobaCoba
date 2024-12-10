using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TekananDarahApp.Services;

namespace TekananDarahApp
{
    public partial class DailyHealthUserControl : UserControl
    {
        private string _userId;
        public DailyHealthUserControl(string userId = null)
        {
            InitializeComponent();
            _userId = userId;
        }

        public void SetUserId(string userId)
        {
            _userId = userId;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (!DateTime.TryParse(tanggalInput.Text, out DateTime date))
            {
                MessageBox.Show("Please enter a valid date.");
                return;
            }
            if (!double.TryParse(weightInput.Text, out double weight))
            {
                MessageBox.Show("Please enter a valid weight.");
                return;
            }
            var bloodPressure = bloodPressInput.Text;
            if (!double.TryParse(bloodSugarLevelInput.Text, out double bloodSugarLevel))
            {
                MessageBox.Show("Please enter a valid blood sugar level.");
                return;
            }

            var dbService = new MongoDBService();
            dbService.AddDailyHealthRecord(_userId, date, weight, bloodPressure, bloodSugarLevel);
            MessageBox.Show("Health record added.");
        }
    }
}
