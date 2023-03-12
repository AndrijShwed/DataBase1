﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBase
{
    public partial class Головна : Form
    {
       
        public Головна()
        {
            InitializeComponent();
        }

        private void ButtonНаселення_MouseClick(object sender, MouseEventArgs e)
        {
            Населення form = new Населення();
            this.Hide();
            form.Show();
        }

        private void ButtonНаселеніПункти_MouseClick(object sender, MouseEventArgs e)
        {
            Населені_Пункти form = new Населені_Пункти();
            this.Hide();
            form.Show();
        }

        private void ПерейменуванняВулиць_MouseClick(object sender, MouseEventArgs e)
        {
            ПерейменуванняВулиць form = new ПерейменуванняВулиць();
            this.Hide();
            form.Show();
        }
    }
}
