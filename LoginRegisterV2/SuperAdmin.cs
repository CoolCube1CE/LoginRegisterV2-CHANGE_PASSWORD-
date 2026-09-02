using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LoginRegisterV2
{
    public partial class SuperAdmin : Form
    {

        public string userEmail;

        public SuperAdmin(string email)
        {
            InitializeComponent();

            userEmail = email;

        }

        private void buttonLogOutSuperAdmin_Click(object sender, EventArgs e)
        {
            LoginPage loginPage = new LoginPage();
            loginPage.Show();
            this.Hide();
        }

        private void labelloggedInExitSAD_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SuperAdmin_Load(object sender, EventArgs e)
        {

        }

        private void buttonChangePWSAD_Click(object sender, EventArgs e)
        {
            ChangePasswordOTP otp = new ChangePasswordOTP(userEmail);

            otp.Show();

            this.Hide();

        }
    }
}
