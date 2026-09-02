using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net;
using System.Net.Mail;

namespace LoginRegisterV2
{
    public partial class ChangePasswordOTP : Form
    {

        SqlConnection sqlConnect = new SqlConnection(
            @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ICE\Documents\LoginRegisterDB.mdf;Integrated Security=True;Connect Timeout=30");

        private int generatedOTP;
        private string userEmail;



        public ChangePasswordOTP(string email)
        {
            InitializeComponent();

            userEmail = email;

            SendOTP();

        }


        private void SendOTP()
        {
            try
            {
                Random random = new Random();
                generatedOTP = random.Next(100000, 1000000);

                string senderEmail = "gr0upvappdev@gmail.com";
                string senderPassword = "ivqtvwgkoaqbvdkc";

                MailMessage message = new MailMessage();

                message.From = new MailAddress(senderEmail);
                message.To.Add(userEmail);

                message.Subject = "Password Change Verification";

                message.Body = "Hello,\n\n" +
                               "Your verification code is " + generatedOTP + "\n\n" +
                               "Please enter this code to continue changing your password.\n\n" +
                               "If you did not request a password change, you can ignore this email.";

                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);

                smtp.EnableSsl = true;
                smtp.Credentials = new NetworkCredential(
                    senderEmail,
                    senderPassword
                );

                smtp.Send(message);

                MessageBox.Show(
                    "A verification code has been sent to your e-mail address.",
                    "OTP Sent",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to send verification e-mail.\n\n" +
                    ex.Message,
                    "Email Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }



        private void buttonVerifyOTPChPW_Click(object sender, EventArgs e)
        {


            if (textBoxOTPChPW.Text == generatedOTP.ToString())
            {
                MessageBox.Show(
                    "OTP Verified Successfully",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                ChangePassword changePassword =
                    new ChangePassword(userEmail);

                changePassword.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show(
                    "Incorrect OTP",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }




        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
