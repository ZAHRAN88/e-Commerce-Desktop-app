﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace online_shopping_project
{
    public partial class children : Form
    {
        public children()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            shoppingcart sh = new shoppingcart();
            this.Hide();
            sh.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Home CategoriePage = new Home();
            this.Hide();
            CategoriePage.Show();
        }

        private void children_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
