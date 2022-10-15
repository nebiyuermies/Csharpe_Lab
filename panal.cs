using System;
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
    public partial class panal : Form
    {
        public panal()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            incator.Top = 150;
            panel2.Visible=false;
           
            
        }

        private void label3_Click(object sender, EventArgs e)
        {
            incator.Top = 250;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            incator.Top = 90;

        }
    }
}
