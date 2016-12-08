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

        }
    }
}
