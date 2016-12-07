using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamBWindowsFormLoginPage
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {
            headerBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        public void button2_Click(object sender, EventArgs e)
        {

            TeamBWindowsFormSignupPage.SignupPage signup = new TeamBWindowsFormSignupPage.SignupPage();
            signup.Activate();
            signup.Visible = true;
            //this.Visible = false;

            UIdll.RegisteredCustomer newPerson = new UIdll.RegisteredCustomer();
            newPerson.MakeRegisteredCustomer();
            //newPerson.username() = textBox1.Text;
        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {
          //  newPerson.username() = textBox1.Text;
        }
    }
}
