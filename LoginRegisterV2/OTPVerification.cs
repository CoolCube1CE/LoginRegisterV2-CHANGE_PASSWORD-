using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LoginRegisterV2
{
    public partial class OTPVerification : Form
    {

        SqlConnection sqlConnect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ICE\Documents\LoginRegisterDB.mdf;Integrated Security=True;Connect Timeout=30");
        
        private int generatedOTP;

        private string fullname;
        private DateTime birthdate;
        private string address;
        private string email;
        private string number;
        private string accesstype;
        private string password;



        public OTPVerification(int otp, string fullname, DateTime birthdate, string address, string email, string number, string accesstype, string password)
        {
            InitializeComponent();

            generatedOTP = otp;

            this.fullname = fullname;
            this.birthdate = birthdate;
            this.address = address;
            this.email = email;
            this.number = number;
            this.accesstype = accesstype;
            this.password = password;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxOTP.Text == generatedOTP.ToString())
            {
                MessageBox.Show("OTP Verified Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                string insertINFO = "INSERT INTO admin" + "(fullname, birthdate, address, email, number, accesstype, password) " +
                                    "VALUES " + "(@fullname, @birthdate, @address, @email, @number, @accesstype, @password)";

                try
                {
                    sqlConnect.Open();
                    using (SqlCommand sqlcommand = new SqlCommand(insertINFO, sqlConnect))
                    {
                        sqlcommand.Parameters.AddWithValue("@fullname", fullname);
                        sqlcommand.Parameters.AddWithValue("@birthdate", birthdate);
                        sqlcommand.Parameters.AddWithValue("@address", address);
                        sqlcommand.Parameters.AddWithValue("@email", email);
                        sqlcommand.Parameters.AddWithValue("@number", number);
                        sqlcommand.Parameters.AddWithValue("@accesstype", accesstype);
                        sqlcommand.Parameters.AddWithValue("@password", password);

                        sqlcommand.ExecuteNonQuery();



                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving account: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally 
                {
                    sqlConnect.Close();
                }

                LoginPage login = new LoginPage();

                login.Show();
                this.Hide();
                
            }
            else 
            {
                MessageBox.Show("Incorrect OTP", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
