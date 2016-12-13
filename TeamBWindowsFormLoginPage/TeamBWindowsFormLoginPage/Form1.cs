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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Server=cis1.actx.edu;Database=project2;User Id=db2;Password = db20;";
            connection.Open();

            using (SqlCommand readUsername = connection.CreateCommand())
                 {
                    SqlCommand readPassword = connection.CreateCommand();
                    readUsername.CommandText = "select * from dbo.Customer where Username = " + textBox1;
                    readPassword.CommandText = "select * from dbo.Customer where Password = " + textBox2;
                if (readUsername.CommandText == textBox1.Text && readPassword.CommandText == textBox2.Text)
                        {
                             TeamBWindowsFormCustomerPage.CustomerPage loginSuccess = new CustomerPage();
                             loginSuccess.Activate();
                             loginSuccess.Visible = true;
                             this.Visible = false;
                        }
                 }
        }

        private void btnGuestSignIn_Click(object sender, EventArgs e)
        {
            TeamBWindowsFormSignupPage.SignupPage guestSignup = new TeamBWindowsFormSignupPage.SignupPage();
            guestSignup.Activate();
            guestSignup.checkBox1.Checked = true; // auto sets check true when guest is clicked...
            guestSignup.Visible = true;
            this.Visible = false;

            //UIdll.RegisteredCustomer newPerson = new UIdll.RegisteredCustomer();

            //if () 
            // still need to find a way to put 
            //in the list from the other form somehow without screwing up everyone.
            {

            }
        }
    }
}
