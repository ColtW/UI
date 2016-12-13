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


        public void button1_Click(object sender, EventArgs e)
        {
            // when button clicked this will save all of the text the EU has provided... Colin
            UIdll.RegisteredCustomer newCustomer = new UIdll.RegisteredCustomer();
            newCustomer.username = textBox6.Text;
            newCustomer.password = textBox7.Text;
            newCustomer.email = textBox3.Text;
            newCustomer.creditCardNumber = textBox4.Text;
            newCustomer.plateNumber = textBox5.Text;
            newCustomer.MakeCustomer();

            if (textBox7.Text == textBox8.Text)
            {
                newCustomer.password = textBox7.Text;
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
                    addCustomer.CommandText = "insert into dbo.Customers values ('" + textBox1 + "," + textBox2 + "," + textBox3 + "," + textBox4 + ",," + textBox6 + "," + textBox8 + "," + textBox5 + "');";
                    addCustomer.ExecuteNonQuery();
                }
            }
            else
            {
                MessageBox.Show("Password verification failed.  Re-enter password.");
                textBox7.Text = "";
                textBox8.Text = "";
            }

            if (checkBox1.Checked == true)
            {
                guestList.Add(1);
                Console.WriteLine(guestList);
                UIdll.Customer guest = new UIdll.Customer();
                guest.MakeCustomer();
                guest.name = textBox1.Text + " " + textBox2.Text;
                guest.username = textBox6.Text;

                if (textBox7.Text == textBox8.Text)
                {
                    guest.password = textBox7.Text;
                    TeamBWindowsFormLoginPage.LoginPage goBackToSignup = new TeamBWindowsFormLoginPage.LoginPage();
                    this.Visible = false;
                    goBackToSignup.Activate();
                    goBackToSignup.Visible = true;

                }
                else
                {
                    MessageBox.Show("Password verification failed.  Re-enter password.");
                    textBox7.Text = "";
                    textBox8.Text = "";

                }

                guest.email = textBox3.Text;
                guest.creditCardNumber = textBox4.Text;
                guest.plateNumber = textBox5.Text;

                
                //MessageBox.Show(guestList.ToString());
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                textBox3.Visible = false;
                textBox5.Visible = false;
                textBox6.Visible = false;
                textBox7.Visible = false;
                textBox8.Visible = false;
                label3.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
            }
            else
            {
                textBox3.Visible = true;
                textBox4.Visible = true;
                textBox5.Visible = true;
                textBox6.Visible = true;
                textBox7.Visible = true;
                textBox8.Visible = true;
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
