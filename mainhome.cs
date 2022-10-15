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
    public partial class mainhome : Form
    {
        public mainhome(string username, string password)
        {
            InitializeComponent();
        }

       
        private void mainhome_Load(object sender, EventArgs e)
        {

        }

        private void newStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var actvieScreen = ActiveMdiChild;
            if (actvieScreen != null)
            {
                actvieScreen.Close();
            }
            RegistrationForm screen = new RegistrationForm();
            screen.MdiParent = this;
            screen.Show();
        }

        private void dispayStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var actvieScreen = ActiveMdiChild;
            if (actvieScreen != null)
            {
                actvieScreen.Close();
            }
            DisplayallProducts screen = new DisplayallProducts();
            screen.MdiParent = this;
            screen.Show();
        }

        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
