using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WformLab.models;

namespace WformLab
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(nametxt.Text, IDtxt.Text, Coursetxt.Text);
           //item it = new item();
           // it.Studentname = nametxt.Text;
           // it.StudentID = IDtxt.Text;
           // it.Coursename = Coursetxt.Text; 
            
        }
       

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
