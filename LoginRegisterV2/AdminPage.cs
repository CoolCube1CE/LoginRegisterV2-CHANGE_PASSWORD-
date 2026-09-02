using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LoginRegisterV2
{
    public partial class AdminPage : Form
    {

        public string userEmail;


        public AdminPage(string email)
        {
            InitializeComponent();

            userEmail = email;
        }

        private void buttonLogOutAdmin_Click(object sender, EventArgs e)
        {
            LoginPage loginPage = new LoginPage();
            loginPage.Show();
            this.Hide();
        }

        private void labelloggedInExitAD_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonChangePWAD_Click(object sender, EventArgs e)
        {
            ChangePasswordOTP otp = new ChangePasswordOTP(userEmail);

            otp.Show();

            this.Hide();
        }
    }
}
