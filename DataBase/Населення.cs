﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBase
{
    public partial class Населення : Form
    {
        public Населення()
        {
            InitializeComponent();
        }

        private void rjButtonПошук_Click(object sender, EventArgs e)
        {
            ВікноПошуку form = new ВікноПошуку();
            this.Hide();
            form.Show();
        }

        private void головнаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Головна form = new Головна();
            this.Hide();
            form.Show();
        }

        private void ButtonПовернутись_Click(object sender, EventArgs e)
        {
            Головна form = new Головна();
            this.Hide();
            form.Show();
        }

        private void rjButtonРедагувати_Click(object sender, EventArgs e)
        {
            ЗмінаДаних form = new ЗмінаДаних();
            this.Hide();
            form.Show();
        }

        private void rjButtonДодати_Click(object sender, EventArgs e)
        {
            Додати form = new Додати();
            this.Hide();
            form.Show();
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            ВивідДаних form = new ВивідДаних();
            this.Hide();
            form.Show();
        }
    }
}
