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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {  // if user name lower case is equal to password upper case then it will show valid otherwise invalid//
            string a =textBox1.Text;
            string b = textBox2.Text;
            string c= b.ToUpper();
            string d= a.ToLower();
            if ( a == d && c == b)
            {
                MessageBox.Show("Valid".ToString());
            }
            else
            {
                MessageBox.Show("Invalid".ToString());
            }
        }
    }
}
