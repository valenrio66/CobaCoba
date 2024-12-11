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
    public partial class UpdateForm : UserControl
    {
        private DailyHealthRecord _currentRecord;
        public UpdateForm()
        {
            InitializeComponent();
        }

        public DailyHealthRecord CurrentRecord
        {
            get { return _currentRecord; }
            set
            {
                _currentRecord = value;
                bloodPressInput.Text = _currentRecord.BloodPressure;
                bloodSugarLevelInput.Text = _currentRecord.BloodSugarLevel.ToString();
                datePicker.Value = _currentRecord.Date; // asumsikan CurrentRecord.Date sudah ada
                weightPicker.Value = Convert.ToDecimal(_currentRecord.Weight);
            }
        }

        private void buttonSubmitUpdate_Click(object sender, EventArgs e)
        {
            if (_currentRecord == null) return;

            try
            {
                _currentRecord.Date = datePicker.Value; // Simpan tanggal baru
                _currentRecord.Weight = Convert.ToDouble(weightPicker.Value);
                _currentRecord.BloodPressure = bloodPressInput.Text;
                _currentRecord.BloodSugarLevel = double.Parse(bloodSugarLevelInput.Text); // Asumsikan validasi input sudah dilakukan

                var dbService = new MongoDBService();
                dbService.UpdateHealthRecord(_currentRecord); // Implementasi harus ada di MongoDBService

                MessageBox.Show("Record updated successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }
    }
}
