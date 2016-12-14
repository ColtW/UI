using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeamBWindowsFormSignupPage;
using TeamBWindowsFormLoginPage;
using UIdll;
using System.IO;
using System.Data.Sql;
using System.Data.SqlClient;

//added a reference to the form but I belive this needs have a reference
// to the UIdll  instead se we can use our classes in this form .SR

namespace TeamBWindowsFormSignupPage
{
    public partial class SignupPage : Form
    {
        public List<int> guestList = new List<int>(50);

        public SignupPage()
        {
            InitializeComponent();
        }

        private void SignupPage_Load(object sender, EventArgs e)
        {
            headerBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }


        public void btnSignUp_Click(object sender, EventArgs e)
        {
            // when button clicked this will save all of the text the EU has provided... Colin
            UIdll.RegisteredCustomer newCustomer = new UIdll.RegisteredCustomer();
            newCustomer.username = txtUsername.Text;
            newCustomer.password = txtPassword.Text;
            newCustomer.email = txtEmail.Text;
            newCustomer.creditCardNumber = txtCreditCard.Text;
            newCustomer.plateNumber = txtLicensePlate.Text;
            newCustomer.MakeCustomer();

            if (txtPassword.Text == txtConfirmPassword.Text)
            {
                newCustomer.password = txtPassword.Text;
                TeamBWindowsFormLoginPage.LoginPage goBackToSignup = new TeamBWindowsFormLoginPage.LoginPage();
                this.Visible = false;
                goBackToSignup.Activate();
                goBackToSignup.Visible = true;

                // Following code will add the customer and all their information to the customer database
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = "Server=cis1.actx.edu;Database=project2;User Id=db2;Password = db20;";
                connection.Open();

                using (SqlCommand addCustomer = connection.CreateCommand())
                {
                    addCustomer.CommandText = "insert into dbo.Customers (FirstName, LastName, EmailAddress, CreditCardNumber, Username, Password) values ('" + txtFirstName.Text + "," + txtLastName.Text + "," + txtEmail.Text + "," + int.Parse(txtCreditCard.Text) + "," + txtUsername.Text + "," + txtLicensePlate.Text + "');";
                    addCustomer.ExecuteNonQuery();
                }
            }
            else
            {
                MessageBox.Show("Password verification failed.  Re-enter password.");
                txtPassword.Text = "";
                txtConfirmPassword.Text = "";
            }

            if (chkIfGuest.Checked == true)
            {
                guestList.Add(1);
                Console.WriteLine(guestList);
                UIdll.Customer guest = new UIdll.Customer();
                guest.MakeCustomer();
                guest.name = txtFirstName.Text + " " + txtLastName.Text;
                guest.username = txtUsername.Text;

                if (txtPassword.Text == txtConfirmPassword.Text)
                {
                    guest.password = txtPassword.Text;
                    TeamBWindowsFormLoginPage.LoginPage goBackToSignup = new TeamBWindowsFormLoginPage.LoginPage();
                    this.Visible = false;
                    goBackToSignup.Activate();
                    goBackToSignup.Visible = true;

                }
                else
                {
                    MessageBox.Show("Password verification failed.  Re-enter password.");
                    txtPassword.Text = "";
                    txtConfirmPassword.Text = "";

                }

                guest.email = txtEmail.Text;
                guest.creditCardNumber = txtCreditCard.Text;
                guest.plateNumber = txtLicensePlate.Text;

                
            //    //MessageBox.Show(guestList.ToString());
            //    if(textBox1.Text != "")
            //    {
            //        if(textBox2.Text != "")
            //        {
            //            if(textBox4.Text != "")
            //            {
            //                button1.Enabled = true;
            //            }
            //            else
            //            {
            //                MessageBox.Show("Please fill out necessary information.");
            //            }
            //        }
            //        else
            //        {
            //            MessageBox.Show("Please fill out necessary information.");
            //        }
            //    }
            //    else
            //    {
            //        MessageBox.Show("Please fill out necessary information.");
            //    }
            }

        }

        public void chkIfGuest_CheckedChanged(object sender, EventArgs e)
        {
            if (chkIfGuest.Checked == true)
            {
                txtEmail.Visible = false;
                txtLicensePlate.Visible = false;
                txtUsername.Visible = false;
                txtPassword.Visible = false;
                txtConfirmPassword.Visible = false;
                label3.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
            }
            else
            {
                txtEmail.Visible = true;
                txtCreditCard.Visible = true;
                txtLicensePlate.Visible = true;
                txtUsername.Visible = true;
                txtPassword.Visible = true;
                txtConfirmPassword.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
            }

        }

       
    }
}
