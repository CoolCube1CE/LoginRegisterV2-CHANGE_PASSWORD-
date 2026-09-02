using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace LoginRegisterV2
{
    public partial class RegisterPage : Form
    {
        SqlConnection sqlConnect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ICE\Documents\LoginRegisterDB.mdf;Integrated Security=True;Connect Timeout=30");

        public RegisterPage()
        {
            InitializeComponent();

            textBoxregisterCPW.ContextMenuStrip = new ContextMenuStrip();
        }

        private bool is18(DateTime birthDate) 
        {
            DateTime today = DateTime.Today;
            int age = today.Year - birthDate.Year;

            if (birthDate.Date > today.AddYears(-age)) 
            {
                age--;
            }
            
            return age >= 18;
        }

        private void checkPassword()
        {
            string password = textBoxregisterPW.Text;

            bool length = password.Length >= 8 && password.Length <= 16;
            bool upper = Regex.IsMatch(password, @"[A-Z]");
            bool lower = Regex.IsMatch(password, @"[a-z]");
            bool number = Regex.IsMatch(password, @"[0-9]");
            bool special = Regex.IsMatch(password, @"[^a-zA-Z0-9]");

            labelLength.Text = length ? "8-16 characters" : "8-16 characters";
            labelUpperc.Text = upper ? "uppercase letter" : "uppercase letter";
            labelLowerc.Text = lower ? "lowercase letter" : "lowercase letter";
            labelNumPW.Text = number ? "number" : "number";
            labelSP.Text = special ? "special character" : "special character";

            labelLength.ForeColor = length ? Color.Green : Color.Red;
            labelUpperc.ForeColor = upper ? Color.Green : Color.Red;
            labelLowerc.ForeColor = lower ? Color.Green : Color.Red;
            labelNumPW.ForeColor = number ? Color.Green : Color.Red;
            labelSP.ForeColor = special ? Color.Green : Color.Red;
        }


        private bool SendOTPEmail(string recipientEmail, int otp){

            try
            {
                string senderEmail = "gr0upvappdev@gmail.com";
                string senderPassword = "ivqtvwgkoaqbvdkc";

                MailMessage message = new MailMessage();

                message.From = new MailAddress(senderEmail);
                message.To.Add(recipientEmail);
                message.Body = "Hello, \n\n" +
                               "Your verification code is " + otp + "\n\n" +
                               "Please enter this code in the registration form to verify your e-mail address. \n\n" +
                               "If you did not request this registration, you can ignore thid email.";

                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);

                smtp.EnableSsl = true;
                smtp.Credentials = new NetworkCredential(senderEmail, senderPassword);
                smtp.Send(message);

                return true;
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Unable to send verification e-mail. \n\n" + ex.Message + "\n\n" + "Details" + ex.InnerException?.Message, "Email Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }


        private void passwordStrength()
        {

            string password = textBoxregisterPW.Text;
            int strength = 0;

            if (password.Length >= 8 && password.Length <= 16)
            {
                strength++;
            }
            if (Regex.IsMatch(password, @"[A-Z]"))
            {
                strength++;
            }
            if (Regex.IsMatch(password, @"[a-z]"))
            {
                strength++;
            }
            if (Regex.IsMatch(password, @"[0-9]"))
            {
                strength++;
            }
            if (Regex.IsMatch(password, @"[^a-zA-Z0-9]"))
            {
                strength++;
            }


            if (strength <= 2)
            {
                labelPWStrength.Text = "Weak";
                labelPWStrength.ForeColor = Color.Red;
            }
            else if (strength <= 4)
            {
                labelPWStrength.Text = "Weak";
                labelPWStrength.ForeColor = Color.Yellow;
            }
            else
            {
                labelPWStrength.Text = "Strong";
                labelPWStrength.ForeColor = Color.Green;
            }

        }

        private void RegisterPage_Load(object sender, EventArgs e)
        {
        }

        private void buttonregisterBack_Click(object sender, EventArgs e)
        {
            LoginPage login = new LoginPage();
            login.Show();
            this.Hide();
        }

        private void labelregisterExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonregisterRegister_Click(object sender, EventArgs e)
        {

            int min = 5;

            int minNum09 = 11;
            int maxNum09 = 11;
            int minNum63 = 13;
            int maxNum63 = 13;




            if (textBoxFN.Text == "")
            {
                labelinvalidFN.Text = "Full Name is required";
            }
            else if (!Regex.IsMatch(textBoxFN.Text, @"^[a-z A-Z'-.]+$"))
            {
                labelinvalidFN.Text = "Invalid, must only contain letters, hypens, and apostrophes";
            }
            else if (textBoxFN.Text.Length < min)
            {
                labelinvalidFN.Text = "Full Name is too short";
            }
            else
            {
                labelinvalidFN.Text = "";
            }




            if (textBoxAdd.Text == "")
            {
                labelinvalidAdd.Text = "Address is required";
            }
            else if (!Regex.IsMatch(textBoxAdd.Text, @"^[a-z A-Z0-9!#$%&'*+-/=?^_`{|}~,]+$"))
            {
                labelinvalidAdd.Text = "Invalid address";
            }
            else if (textBoxAdd.Text.Length < min)
            {
                labelinvalidAdd.Text = "Address is too short";
            }
            else
            {
                labelinvalidAdd.Text = "";
            }




            if (textBoxEM.Text == "")
            {
                labelinvalidEM.Text = "E-mail is required";
            }
            else if (!Regex.IsMatch(textBoxEM.Text, @"^[a-zA-Z0-9!#$%&'*+-/=?^_`{|}~,@]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"))
            {
                labelinvalidEM.Text = "Invalid E-mail";
            }
            else if (textBoxEM.Text.Length < min)
            {
                labelinvalidEM.Text = "E-mail is too short";
            }
            else
            {
                labelinvalidEM.Text = "";
            }




            if (textBoxNum.Text == "")
            {
                labelinvalidNum.Text = "Phone Number is required";
            }
            else if (Regex.IsMatch(textBoxNum.Text, @"^09[0-9]{9}$"))
            {
                labelinvalidNum.Text = "";
            }
            else if (Regex.IsMatch(textBoxNum.Text, @"^\+639[0-9]{9}$"))
            {
                labelinvalidNum.Text = "";
            }
            else if (textBoxNum.Text.Length < min)
            {
                labelinvalidNum.Text = "Phone Number is too short";
            }
            else
            {
                labelinvalidNum.Text = "Invalid Phone Number. Must be in the format 09XXXXXXXXX or +639XXXXXXXXX";
            }




            if (!is18(dateTimeBirthDate.Value))
            {
                labelinvalidBD.Text = "You must be at least 18 years old.";
            }
            else
            {
                labelinvalidBD.Text = "";
            }




            if (textBoxregisterPW.Text == "")
            {
                labelinvalidPW.Text = "Password is required";
                labelinvalidPW.ForeColor = Color.Red;
            }
            else if (labelPWStrength.Text == "Strong") 
            {
                labelinvalidPW.Text = "Password Requirement:";
                labelinvalidPW.ForeColor = Color.Green;
            }
            else
            {
                labelinvalidPW.Text = "Invalid Password";
                labelinvalidPW.ForeColor = Color.Red;
            }



            if (textBoxregisterCPW.Text == "")
            {
                labelinvalidCPW.Text = "Confirm Password Required";
            }

            else if (textBoxregisterPW.Text == textBoxregisterCPW.Text)
            {
                labelinvalidCPW.Text = "Password Match";
                labelinvalidCPW.ForeColor = Color.Green;
            }
            else
            {
                labelinvalidCPW.Text = "Password does not match";
                labelinvalidCPW.ForeColor = Color.Red;
            }





            if (comboBoxAcc.SelectedIndex == -1)
            {
                labelinvalidAcc.Text = "Access Type is required";
            }
            else
            {
                labelinvalidAcc.Text = "";
            }




            if (labelinvalidFN.Text == "Full Name is too short" | labelinvalidAdd.Text == "Address is too short" | labelinvalidNum.Text == "Phone Number is too short") 
            {
                return;
            }

            if (textBoxFN.Text == "" | labelinvalidBD.Text == "You must be at least 18 years old." | textBoxAdd.Text == "" |
                textBoxEM.Text == "" | textBoxNum.Text == "" | textBoxregisterPW.Text == "" | textBoxregisterCPW.Text == "" |
                comboBoxAcc.SelectedIndex == -1) 
            {
                return;
            }


            if (labelinvalidFN.Text == "Invalid, must only contain letters, hypens, and apostrophes" | labelinvalidAdd.Text == "Invalid address" |
                labelinvalidEM.Text == "Invalid E-mail" | labelinvalidNum.Text == "Invalid Phone Number. Must be in the format 09XXXXXXXXX or +639XXXXXXXXX" |
                labelinvalidPW.Text == "Invalid Password" | labelinvalidCPW.Text == "Password does not match") 
            {
                return;
            }





            if (sqlConnect.State != ConnectionState.Open)
                {
                    try
                    {
                        sqlConnect.Open();
                        string validateEmailadd = "SELECT COUNT(*) FROM admin WHERE email = @email";

                        using (SqlCommand validateEmail = new SqlCommand(validateEmailadd, sqlConnect))
                        {
                            validateEmail.Parameters.AddWithValue("@email", textBoxEM.Text.Trim());
                            int count = Convert.ToInt32(validateEmail.ExecuteScalar());
                            
                            if (count > 0)
                            {
                            labelinvalidEM.Text = "Email is registered already, please use a different e-mail address.";
                            return;
                            }
                            else
                            {
                                
                                Random random = new Random();
                                int otp = random .Next(100000, 1000000);
                                bool emailSent = SendOTPEmail(textBoxEM.Text.Trim(), otp);

                            if (emailSent)
                                {
                                

                                OTPVerification verification = new OTPVerification(otp, textBoxFN.Text.Trim(), dateTimeBirthDate.Value, textBoxAdd.Text.Trim(),
                                                                                    textBoxEM.Text.Trim(), textBoxNum.Text.Trim(), comboBoxAcc.Text.Trim(),
                                                                                    textBoxregisterPW.Text.Trim());

                                verification.Show();
                                this.Hide();
                                }
                            else
                                {
                                MessageBox.Show("Registration cannot continue because the verification e-mail could not be sent.", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }

                                


                            }

                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error Connecting" + ex, "Error  Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        sqlConnect.Close();
                    }

                }








        }
        private void buttonshowregPW_Click(object sender, EventArgs e)
        {
            textBoxregisterPW.PasswordChar = '\0';
            buttonhideregPW.BringToFront();
        }

        private void buttonhideregPW_Click(object sender, EventArgs e)
        {
            textBoxregisterPW.PasswordChar = '*';
            buttonshowregPW.BringToFront();
        }

        private void buttonshowregCPW_Click(object sender, EventArgs e)
        {
            textBoxregisterCPW.PasswordChar = '\0';
            buttonhideregCPW.BringToFront();
        }

        private void buttonhideregCPW_Click(object sender, EventArgs e)
        {
            textBoxregisterCPW.PasswordChar = '*';
            buttonshowregCPW.BringToFront();
        }

        private void textBoxregisterPW_TextChanged(object sender, EventArgs e)
        {
            checkPassword();
            passwordStrength();
        }

        private void textBoxregisterCPW_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBoxregisterCPW_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && (e.KeyCode == Keys.C || e.KeyCode == Keys.V || e.KeyCode == Keys.X))
            {
                e.SuppressKeyPress = true;
            }
        }

        private void textBoxregisterCPW_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                return;
            }
        }
    }
}
