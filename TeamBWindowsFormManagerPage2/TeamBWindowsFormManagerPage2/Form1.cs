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

namespace TeamBWindowsFormManagerPage2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            headerBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // I've added only that, but looks like on the employee dll there needs to be more things...
            // such as last name, date of hire, job, and pay. - Colin
            UIdll.Employee hireEmployee = new UIdll.Employee();
            hireEmployee.name = textBox4.Text;
            
            

        }
    }
}
