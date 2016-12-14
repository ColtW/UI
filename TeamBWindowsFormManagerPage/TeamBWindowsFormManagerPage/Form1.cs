using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UIdll;
using System.Data.SqlClient;
using System.Data.Sql;

namespace TeamBWindowsFormManagerPage
{
    public partial class ManagerPage : Form
    {
        public ManagerPage()
        {
            InitializeComponent();
        }

        private void ManagerPage_Load(object sender, EventArgs e)
        {
            headerBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            

            UIdll.CurrentParkingReservation searchReservation = new CurrentParkingReservation();

            searchReservation.reserveID = txtReservationId.Text;
            searchReservation.searchReservation();

            txtConfirmationId.Text = searchReservation.confirmation;
            txtDate.Text = searchReservation.reserveDate;
            txtStartTime.Text = searchReservation.start;
            txtEndTime.Text = searchReservation.end;
            txtLotNumber.Text = searchReservation.spaceNumber;

        }

        private void btnModifyReservation_Click(object sender, EventArgs e)
        {
            UIdll.CurrentParkingReservation modifyReservation = new CurrentParkingReservation();
            modifyReservation.reserveDate = txtDate.Text;
            {

            }
        }

        private void btnDeleteReservation_Click(object sender, EventArgs e)
        {
            UIdll.CurrentParkingReservation deleteReservation = new CurrentParkingReservation();
            deleteReservation.deleteReservation();
        }
    }
}
