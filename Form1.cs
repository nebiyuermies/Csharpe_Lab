﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WformLab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String messaage = txtname.Text;
            // MessageBox.Show("hello "  +  messaage);
            MessageBox.Show($" hello {messaage}");
        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
