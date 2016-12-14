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
using UIdll;
using TeamBWindowsFormViewReservationPage;

namespace TeamBElevatorDisplayAndConsolePage
{
    public partial class Form1 : Form
    {
        public string runningTotal { get; set; }
        public int CustomerID { get; set; }
        public int ReservationID { get; set; }
        public DateTime startTime { get; set; }

        public Form1()
        {
            InitializeComponent();

            button1.Click += GetNumericButtonText;
            button2.Click += GetNumericButtonText;
            button3.Click += GetNumericButtonText;
            button4.Click += GetNumericButtonText;
            button5.Click += GetNumericButtonText;
            button6.Click += GetNumericButtonText;
            button7.Click += GetNumericButtonText;
            button8.Click += GetNumericButtonText;
            button9.Click += GetNumericButtonText;
            button0.Click += GetNumericButtonText;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            headerBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void button10_Click(object sender, EventArgs e)
        {

            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Server=cis1.actx.edu;Database=project2;User Id=db2;Password = db20;";
            connection.Open();

            using (SqlCommand readAllCustomer = new SqlCommand())
            {
                readAllCustomer.CommandText = "select * dbo.Customers";

                using (SqlDataReader reader = readAllCustomer.ExecuteReader())
                {
                    bool tryAgain = false;
                    int customerID = 0;
                    do
                    {
                        reader.Read();
                        customerID = reader.GetInt32(0);
                        if(CustomerID == customerID)
                        {
                            tryAgain = true;
                        }
                        else
                        {
                            MessageBox.Show("You're Customer ID does not match with the database");
                        }
                    }
                    while (tryAgain == true);
                }
            }
            DateTime reservedDate = DateTime.Now;

            using (SqlCommand readAllReservations = new SqlCommand())
            {
                readAllReservations.CommandText = "select * dbo.Reservations";

                using (SqlDataReader reader = readAllReservations.ExecuteReader())
                {
                    reader.Read();
                    bool tryAgain = false;
                    int customerID = 0;
                    do
                    {
                        // searching for a reservation
                        customerID = reader.GetInt32(5);
                        if(customerID == CustomerID)
                        {
                            // it has found a reservation, now have to compare times to see if they are late
                            // or early
                            reservedDate = reader.GetDateTime(3);
                        }
                    }
                    while (tryAgain == true);
                }
            }

            startTime = DateTime.Now;
            
            if (startTime.Subtract(reservedDate) <= TimeSpan.FromMinutes(30))
            {
                //less than 30 minutes have passed
                if (startTime.Subtract(reservedDate) >= TimeSpan.FromMinutes(0))
                {
                    // it is after the time has started

                }
                else
                {
                    lbl1.Text = "Your reserved period of time has not yet started, please get off the elevator and wait for the specified time";
                }
            }
            else
            {
                lbl1.Text = "Your reserved period of time has gone beyond 30 minutes, please click the button to go back to reservations or get off the elevator";
                toReservations.Visible = true;
            }
        }

        


        private void GetNumericButtonText(object sender, EventArgs e)
        {
            Button theButtonClicked = (Button)sender;
            int convertedNumber = 0;
            runningTotal += theButtonClicked.Text;
            if (int.TryParse(runningTotal, out convertedNumber))
            {
                CustomerID = convertedNumber;
            }
            else
            {
                MessageBox.Show("");
            }
        }

        private void toReservations_Click(object sender, EventArgs e)
        {
            TeamBWindowsFormViewReservationPage.ViewandModifyReservationsFrm reservationPage = new TeamBWindowsFormViewReservationPage.ViewandModifyReservationsFrm();
            reservationPage.Activate();
            reservationPage.Visible = true;
            this.Visible = false;
        }
    }
}
