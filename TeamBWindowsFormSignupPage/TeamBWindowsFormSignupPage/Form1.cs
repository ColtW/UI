using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeamBWindowsFormSignupPage;//added a reference to the form but I belive this needs have a reference
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

        public void textBox1_TextChanged(object sender, EventArgs e)
        {
            UIdll.RegisteredCustomer informationUpdate = new UIdll.RegisteredCustomer();
            informationUpdate.username = textBox1.Text;
            informationUpdate.password = textBox2.Text;
            

          

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
            // when button clicked this will save all of the text the EU has provided... Colin
            UIdll.RegisteredCustomer informationUpdate = new UIdll.RegisteredCustomer();
            informationUpdate.username = textBox1.Text;
            informationUpdate.password = textBox2.Text;
            //informationUpdate.email = textBox3.Text;
            //informationUpdate.creditCardNumber = textBox4.Text;
            //informationUpdate.plateNumber = textBox5.Text;
        }
    }
}
