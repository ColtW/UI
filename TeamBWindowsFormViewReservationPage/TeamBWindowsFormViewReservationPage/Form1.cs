﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamBWindowsFormViewReservationPage
{
    public partial class ViewandModifyReservationsFrm : Form
    {
        public ViewandModifyReservationsFrm()
        {
            InitializeComponent();
        }

        private void ViewandModifyReservationsFrm_Load(object sender, EventArgs e)
        {
            headerBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
