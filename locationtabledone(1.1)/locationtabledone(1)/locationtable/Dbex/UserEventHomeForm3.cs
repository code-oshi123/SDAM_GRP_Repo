﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dbex
{
    public partial class UserEventHomeForm3 : Form
    {
        public UserEventHomeForm3()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EventuserForm2 eventuser = new EventuserForm2();
            eventuser.Show();
            this.Hide();
        }
    }
}
