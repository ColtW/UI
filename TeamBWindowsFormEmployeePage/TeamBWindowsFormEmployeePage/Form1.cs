using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamBWindowsFormEmployeePage
{
    public partial class EmployeePage : Form
    {
        public EmployeePage()
        {
            InitializeComponent();
        }

        private void EmployeePage_Load(object sender, EventArgs e)
        {
            headerBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNumber.Text = "";
        }

        private void btnCheckSpaces_Click(object sender, EventArgs e)
        {
            //SqlConnection connection = new SqlConnection();
            //connection.ConnectionString = "Server=cis1.actx.edu;Database=project2;User Id=db2;Password=db20;";
            //connection.Open()
            //    using (SqlCommand readReservations = connection.CreateCommand())
            //{
            //    readReservations.CommandText = "select * fromdbo.Reservations where ReservationConfirmationNumber = '" + txtNumber.Text + "';";
            //    readReservations.CommandText = "select * fromdbo.Reservations where CustomerID = '" + txtNumber.Text + "';";

            //}
        }
    }
}
