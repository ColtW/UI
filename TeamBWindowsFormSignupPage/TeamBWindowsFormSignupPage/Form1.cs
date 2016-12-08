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
using UIdll;     //added a reference to the form but I belive this needs have a reference
                 // to the UIdll  instead se we can use our classes in this form .SR

namespace TeamBWindowsFormSignupPage
{
    public partial class SignupPage : Form
    {
        List<int> guestList = new List<int>(50);

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
            newCustomer.username = textBox1.Text;
            newCustomer.password = textBox2.Text;
            newCustomer.email = textBox3.Text;
            newCustomer.creditCardNumber = textBox4.Text;
            newCustomer.plateNumber = textBox5.Text;

            this.Visible = false;
            TeamBWindowsFormLoginPage.LoginPage goBackToSignup = new TeamBWindowsFormLoginPage.LoginPage();
            goBackToSignup.Activate();
            goBackToSignup.Visible = true;

            newCustomer.MakeCustomer();



            if(checkBox1.Checked == true)
            {
                guestList.Add(1);
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
