using TekananDarahApp.Services;

namespace TekananDarahApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            var username = textUsername.Text;
            var password = textPassword.Text;

            var dbService = new MongoDBService();
            var user = dbService.LoginUser(username, password);
            if (user != null)
            {
                MessageBox.Show("Login successful!");

                this.Hide();  // Sembunyikan form login
                Dashboard dashboard = new Dashboard(user.UserId);  // Membuat instance form Dashboard
                dashboard.ShowDialog();
                this.Close();  // Tutup form login
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }
    }
}
