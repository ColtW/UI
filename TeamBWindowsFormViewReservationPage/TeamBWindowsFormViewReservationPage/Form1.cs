using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
using TeamBWindowsFormCustomerPage;

namespace TeamBWindowsFormViewReservationPage
{
    public partial class ViewandModifyReservationsFrm : Form
    {
        

        public ViewandModifyReservationsFrm()
        {
            InitializeComponent();
        }

        private void ViewandModifyReservationsFrm_Load(object sender, EventArgs e)
        {
            headerBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Server=cis1.actx.edu;Database=project2;User Id=db2;Password = db20;";
            connection.Open();

            // goes to the customer windows form
            string reservationIdChanging = "";
            reservationIdChanging = textBox3.Text;
            if(reservationIdChanging == reservationId.ToString())
            {
                // if they want to extend their reservation time
                if (radioButton1.Checked == true)
                {
                    TeamBWindowsFormCustomerPage.CustomerPage customerPage = new TeamBWindowsFormCustomerPage.CustomerPage();
                    customerPage.Activate();
                    customerPage.Visible = true;
                    this.Visible = false;
                }
                // if the want to cancel their reservation
                else if (radioButton2.Checked == true)
                {
                    using (SqlCommand deleteReservation = new SqlCommand())
                    {
                        deleteReservation.CommandText = "delete from dbo.Reservations where ReservationID = " + reservationIdChanging + ";";
                    }

                    TeamBWindowsFormCustomerPage.CustomerPage customerPage = new TeamBWindowsFormCustomerPage.CustomerPage();
                    customerPage.Activate();
                    customerPage.Visible = true;
                    this.Visible = false;
                }
                // they dont select to extend or cancel, just going back to the customer form
                else
                {
                    TeamBWindowsFormCustomerPage.CustomerPage customerPage = new TeamBWindowsFormCustomerPage.CustomerPage();
                    customerPage.Activate();
                    customerPage.Visible = true;
                    this.Visible = false;
                }
            }
            connection.Close();
        }

        int reservationId = 0;

        // this method is to take the first name and last name you have given to find a customer that has
        // a reservation that matches 
        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Server=cis1.actx.edu;Database=project2;User Id=db2;Password = db20;";
            connection.Open();

            // would want to search for existing reservations that exist with this name
            int customer = 0;
            DateTime date = DateTime.Now;
            DateTime startTime = DateTime.Now;
            DateTime endTime = DateTime.Now;

            listBox1.Items.Add(reservationId.ToString() + date.ToString() + startTime.ToString() + endTime.ToString());

            // read all the names and check for them
            using (SqlCommand readAllNames = new SqlCommand())
            {
                readAllNames.CommandText = "select * dbo.Customers;";

                using (SqlDataReader reader = readAllNames.ExecuteReader())
                {
                    bool tryAgain = false;
                    string firstNameLibrary = "";
                    string lastNameLibrary = "";
                    do
                    {
                        // searching for the first name
                        reader.Read();
                        firstNameLibrary = reader.GetString(1);
                        if(firstNameLibrary == firstName.Text)
                        {
                            // searching for the last name
                            lastNameLibrary = reader.GetString(2);
                            if(lastNameLibrary == lastName.Text)
                            {
                                // the first and last names match with someone in the datatbase
                                // and it will record their customer id
                                customer = reader.GetInt32(0);
                                tryAgain = true;
                            }
                            // if it cannot find one with their last name
                            else
                            {
                                MessageBox.Show("The last name does not match anything in our database");
                                tryAgain = false;
                            }
                        }
                        // if it cannot find one with their first name
                        else
                        {
                            MessageBox.Show("The first name does not match anything in our database");
                            tryAgain = false;
                        }
                    }
                    while (tryAgain == true);
                }
            }

            // searches the reservations for one that exist with their customerID
            using (SqlCommand readAllReservations = new SqlCommand())
            {
                readAllReservations.CommandText = "select * dbo.Reservations;";

                using (SqlDataReader reader = readAllReservations.ExecuteReader())
                {
                    bool tryAgain = false;
                    int customerId;
                    do
                    {
                        // it will search for one that matches
                        reader.Read();
                        customerId = reader.GetInt32(5);
                        if(customerId == customer)
                        {
                            // the customerID has matched with the one in reservations, so it will pull information
                            // from the database
                            reservationId = reader.GetInt32(0);
                            date = reader.GetDateTime(2);
                            startTime = reader.GetDateTime(3);
                            endTime = reader.GetDateTime(4);
                        }
                        // it could not find one that matches with your customerID
                        else
                        {
                            MessageBox.Show("There is not any reservations in our database with your account");
                        }
                    }
                    while (tryAgain == true);
                }
            }

            
            connection.Close();
        }
    }
}
