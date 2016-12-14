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

namespace TeamBWindowsFormCustomerPage
{
    public partial class CustomerPage : Form
    {

        public CustomerPage()
        {
            InitializeComponent();
            textBox1.Visible = false;
            label4.Visible = false;

            textBox2.Visible = false;
            label5.Visible = false;
        }

        private void CustomerPage_Load(object sender, EventArgs e)
        {
            headerBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        

        //when this is clicked in save all the textboxes.
        //I Added this SJR.
        private void button1_Click(object sender, EventArgs e)
        {
            UIdll.CurrentParkingReservation makeReservation = new UIdll.CurrentParkingReservation();

            textBox1.Text = makeReservation.plateNumber;
            textBox2.Text = makeReservation.plateNumber;

            dateTimePicker1.Text = makeReservation.reserveDate;
            dateTimePicker2.Text = makeReservation.start;
            dateTimePicker3.Text = makeReservation.end;


        }
        //I added This SJR.
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
            {
                textBox1.Visible = true;
                label4.Visible = true;
                textBox2.Visible = false;
                label5.Visible = false;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                textBox2.Visible = true;
                label5.Visible = true;
                textBox1.Visible = false;
                label4.Visible = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
