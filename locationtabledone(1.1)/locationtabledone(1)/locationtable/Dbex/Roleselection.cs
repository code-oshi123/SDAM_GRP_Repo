﻿using Microsoft.VisualBasic.ApplicationServices;
using System;
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
    public partial class Roleselection : Form
    {
        public Roleselection()
        {
            InitializeComponent();
        }
        private void admin_btn_Click(object sender, EventArgs e)
        {
            Form1 adminlogin = new Form1();
            adminlogin.Show();
            this.Hide();
        }
        //private void user_btn_Click(object sender, EventArgs e)
        //{
        //    User user = new User();
        //    user.Show();
        //    this.Hide();
        //}
        //private void organizer_btn_Click(object sender, EventArgs e)
        //{
        //    Organizer org = new Organizer();
        //    org.Show();
        //    this.Hide();
        //}
    }

}
