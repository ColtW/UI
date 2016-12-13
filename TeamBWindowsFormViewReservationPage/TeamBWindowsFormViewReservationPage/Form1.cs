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

namespace TeamBWindowsFormViewReservationPage
{
    public partial class ViewandModifyReservationsFrm : Form
    {
        SqlConnection connection = new SqlConnection();
        connection.ConnectionString = "Server=cis1.actx.edu;Database=project2;User Id=db2;Password = db20;";
        connection.Open();

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
            // goes to the customer windows form
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // would want to search for existing reservations that exist with this name
            int customer = 0;

            using (SqlCommand readAllNames = new SqlCommand())
            {
                readAllNames.CommandText = "select * dbo.Customers";

                using (SqlDataReader reader = readAllNames.ExecuteReader())
                {
                    bool tryAgain = false;
                    string firstNameLibrary = "";
                    string lastNameLibrary = "";
                    do
                    {
                        reader.Read();
                        firstNameLibrary = reader.GetString(1);
                        if(firstNameLibrary == firstName.Text)
                        {
                            lastNameLibrary = reader.GetString(2);
                            if(lastNameLibrary == lastName.Text)
                            {
                                customer = reader.GetInt32(0);
                                tryAgain = true;
                            }
                        }
                    }
                    while (tryAgain == true);
                }
            }

            using (SqlCommand readAllReservations = new SqlCommand())
            {
                readAllReservations.CommandText = "select * dbo.Reservations";

                using (SqlDataReader reader = readAllReservations.ExecuteReader())
                {
                    bool tryAgain = false;
                    int customerId;
                    do
                    {
                        reader.Read();
                        customerId = reader.GetInt32(5);
                        if(customerId == customer)
                        {
                            reader.GetDateTime(2);
                            reader.GetDateTime(3);
                            reader.GetDateTime(4);
                        }
                    }
                    while (tryAgain == true);
                }
            }
        }
    }
}
