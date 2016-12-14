using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using TeamBWindowsFormSignupPage;
using TeamBWindowsFormCustomerPage;
using UIdll;
using System.Data.Sql;
using System.Data.SqlClient;

namespace TeamBWindowsFormLoginPage
{
    public partial class LoginPage : Form
    {

        public LoginPage()
        {
            InitializeComponent();
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {
            headerBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        public void btnSignUp_Click(object sender, EventArgs e)
        {
            TeamBWindowsFormSignupPage.SignupPage signup = new TeamBWindowsFormSignupPage.SignupPage();
            signup.Activate();
            signup.Visible = true;
            this.Visible = false;

            UIdll.RegisteredCustomer newPerson = new UIdll.RegisteredCustomer();
            newPerson.MakeRegisteredCustomer();
        }
        string user = "";
        string pass = "";

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Server=cis1.actx.edu;Database=project2;User Id=db2;Password = db20;";
            connection.Open();

            //login check

            using (SqlCommand findUsername = connection.CreateCommand())
            {
                findUsername.CommandText = "select * from dbo.Customers where Username = '" + textBox1.Text + "'";
                using (SqlDataReader reader = findUsername.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        user = reader.GetString(5);
                        pass = reader.GetString(6);
                    }
                    
                }
            }

                if (user == textBox1.Text && pass == textBox2.Text)
                        {
                             TeamBWindowsFormCustomerPage.CustomerPage loginSuccess = new CustomerPage();
                             loginSuccess.Activate();
                             loginSuccess.Visible = true;
                             this.Visible = false;
                        }
            else
            {
                MessageBox.Show("Incorrect credentials, try again.");
            }
                 
        }

        private void btnGuestSignIn_Click(object sender, EventArgs e)
        {
            TeamBWindowsFormSignupPage.SignupPage guestSignup = new TeamBWindowsFormSignupPage.SignupPage();
            guestSignup.Activate();
            guestSignup.chkIfGuest.Checked = true; // auto sets check true when guest is clicked...
            guestSignup.Visible = true;
            this.Visible = false;

            //UIdll.RegisteredCustomer newPerson = new UIdll.RegisteredCustomer();

            //if () 
            // still need to find a way to put 
            //in the list from the other form somehow without screwing up everyone.
        }
    }
}
