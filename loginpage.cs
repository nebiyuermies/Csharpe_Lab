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
    public partial class loginpage : Form
    {
        public loginpage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            if(username== "admin" && password == "1234")
            {
                mainhome mainhome = new mainhome(username,password);
                Hide();
                mainhome.Show();
            }
            else
            {
                MessageBox.Show("try again");
            }
        }
    }
}
