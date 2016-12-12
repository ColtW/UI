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

        private void button1_Click(object sender, EventArgs e)
        {
            

            UIdll.CurrentParkingReservation searchReservation = new CurrentParkingReservation();

            searchReservation.reserveID = textBox13.Text;
            searchReservation.searchReservation();

            textBox1.Text = searchReservation.confirmation;
            textBox8.Text = searchReservation.reserveDate;
            textBox9.Text = searchReservation.start;
            textBox10.Text = searchReservation.end;
            textBox3.Text = searchReservation.spaceNumber;

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
