using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TekananDarahApp
{
    public partial class Dashboard : Form
    {
        private DailyHealthUserControl dailyHealthUserControl;
        private DashboardUserControl dashboardView;
        private string _currentUserId;

        // Modifikasi untuk menerima userId sebagai parameter
        public Dashboard(string userId)
        {
            InitializeComponent();
            _currentUserId = userId;  // Simpan userId yang diterima ke variabel lokal

            //buttonDashboard_Click(null, EventArgs.Empty);
        }

        private void buttonDashboard_Click(object sender, EventArgs e)
        {
            panelLeft.Height = buttonDashboard.Height;
            panelLeft.Top = buttonDashboard.Top;

            // Bersihkan semua konten yang ada di panel2
            panel2.Controls.Clear();

            // Instansiasi atau gunakan instance yang sudah ada
            if (dashboardView == null)
            {
                dashboardView = new DashboardUserControl();  // Buat instance baru jika belum ada
            }

            // Tambahkan UserControl ke panel2
            panel2.Controls.Add(dashboardView);
            dashboardView.Dock = DockStyle.Fill;

            dashboardView.LoadHealthRecords();
            dashboardView.RefreshChart();
        }

        private void buttonHealth_Click(object sender, EventArgs e)
        {
            panelLeft.Height = buttonHealth.Height;
            panelLeft.Top = buttonHealth.Top;

            // Bersihkan semua konten yang ada di panel2
            panel2.Controls.Clear();

            // Instansiasi atau gunakan instance yang sudah ada
            if (dailyHealthUserControl == null)
            {
                dailyHealthUserControl = new DailyHealthUserControl(_currentUserId);  // Gunakan userId yang disimpan
            }
            else
            {
                dailyHealthUserControl.SetUserId(_currentUserId);  // Jika sudah ada, update userId
            }

            // Tambahkan UserControl ke panel2
            panel2.Controls.Add(dailyHealthUserControl);
            dailyHealthUserControl.Dock = DockStyle.Fill;
        }

        private void buttonUser_Click(object sender, EventArgs e)
        {
            panelLeft.Height = buttonUser.Height;
            panelLeft.Top = buttonUser.Top;
        }
    }
}
