using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using TekananDarahApp.Services;

namespace TekananDarahApp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            var name = textName.Text;
            if (!int.TryParse(textAge.Text, out int age))
            {
                MessageBox.Show("Please enter a valid age.");
                return;
            }
            var username = textUsername.Text;
            var password = textPassword.Text;

            var dbService = new MongoDBService();
            var newUser = dbService.RegisterUser(name, age, username, password);
            MessageBox.Show($"User {newUser.Username} registered with UserID {newUser.UserId}");

            this.Hide();  // Menyembunyikan form registrasi
            Form1 loginForm = new Form1();  // Membuat instance baru dari Form1
            loginForm.ShowDialog();  // Menampilkan Form1 sebagai dialog
            this.Close();  // Menutup Form2 setelah Form1 ditutup
        }
    }
}
