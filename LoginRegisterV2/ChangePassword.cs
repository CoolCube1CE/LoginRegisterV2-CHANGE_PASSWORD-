using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace LoginRegisterV2
{
    public partial class ChangePassword : Form
    {

        SqlConnection sqlConnect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ICE\Documents\LoginRegisterDB.mdf;Integrated Security=True;Connect Timeout=30");

        private string userEmail;


        public ChangePassword(string email)
        {
            InitializeComponent();

            userEmail = email;
        }



        private bool IsPasswordStrong(string password)
        {
            bool length = password.Length >= 8 && password.Length <= 16;
            bool upper = Regex.IsMatch(password, @"[A-Z]");
            bool lower = Regex.IsMatch(password, @"[a-z]");
            bool number = Regex.IsMatch(password, @"[0-9]");
            bool special = Regex.IsMatch(password, @"[^a-zA-Z0-9]");

            return length && upper && lower && number && special;
        }



        private void buttonChangePW_Click(object sender, EventArgs e)
        {

            string newPassword = textBoxNewPW.Text;
            string confirmPassword = textBoxChCPW.Text;




            if (newPassword == "")
            {
                MessageBox.Show(
                    "New Password is required.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                return;
            }


            if (!IsPasswordStrong(newPassword))
            {
                MessageBox.Show(
                    "Password must be 8-16 characters long and contain:\n\n" +
                    "- An uppercase letter\n" +
                    "- A lowercase letter\n" +
                    "- A number\n" +
                    "- A special character",
                    "Invalid Password",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                return;
            }


            if (confirmPassword == "")
            {
                MessageBox.Show(
                    "Confirm Password is required.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                return;
            }



            if (newPassword != confirmPassword)
            {
                MessageBox.Show(
                    "Password does not match.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                return;
            }



            try
            {
                sqlConnect.Open();

                string updatePassword =
                    "UPDATE admin SET password = @password WHERE email = @email";

                using (SqlCommand command =
                    new SqlCommand(updatePassword, sqlConnect))
                {
                    command.Parameters.AddWithValue(
                        "@password",
                        newPassword
                    );

                    command.Parameters.AddWithValue(
                        "@email",
                        userEmail
                    );

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show(
                            "Password changed successfully!",
                            "Success",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );

                        LoginPage login = new LoginPage();

                        login.Show();

                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show(
                            "Unable to change password. Account was not found.",
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error changing password:\n\n" + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            finally
            {
                sqlConnect.Close();
            }




        }

        private void buttonBackChPW2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
