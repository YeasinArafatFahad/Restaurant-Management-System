﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        

        private void Burger_Click(object sender, EventArgs e)
        {
            Form3 f2 = new Form3();
            f2.Show();
            this.Hide();
        }

        private void Pizza_Click(object sender, EventArgs e)
        {
            Form4 f3 = new Form4();
            f3.Show();
            this.Hide();
        }

       

        private void Chicken_Click(object sender, EventArgs e)
        {
            Form7 f6 = new Form7();
            f6.Show();
            this.Hide();
        }

      

        

        private void Drinks_Click(object sender, EventArgs e)
        {
            Form10 f9 = new Form10();
            f9.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form13 f12 = new Form13();
            f12.Show();
            this.Hide();
        }
    }
}
