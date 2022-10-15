using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WformLab.model;

using System.Text.RegularExpressions;

namespace WformLab
{
    public partial class Inventory : Form
    {
      //  string username, string password used for geting parameters
        public Inventory()
        {
            InitializeComponent();
           // used for taking string from the form
           // username = username;
           // password = password;
           // user.Text = username;
        }

        private void Inventory_Load(object sender, EventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {

            Regex regex = new Regex(@"[a-z]{2} $");
           // useed to match text from the txt box
            if (regex.IsMatch(txtinventory.Text))
                { 
            
                }
            else
            {
                MessageBox.Show("dont match");
            }


            if (string.IsNullOrEmpty(txtobjname.Text))
            {
                errorPvd.SetError(txtobjname, "name requied");
            }
            else
            {
              // errorPvd.c

            }


            Item it = new Item();
            it.number = txtnum.Text;
            it.date = txtdate.Text;
            it.inventorynumber = txtinventory.Text;
            it.objectname = txtobjname.Text;
            it.count = int.Parse (txtcount.Text);
            it.price = txtcprice.Text;
            it.chbox = chbox.Checked;

            MessageBox.Show("added");

            displaytbl.DataSource = null;
            displaytbl.DataSource = Item.getall();





        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chbox_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string message = "  ";

            foreach(var item in cklistbox.CheckedItems)
            {
                message += item.ToString();
            }
            MessageBox.Show(message);

            string simple = "male";
            string var = "female";

            if ( rbtnvar.Checked== true)
            {
                MessageBox.Show(simple);
            }
            else
            {
                MessageBox.Show(var);
            }

        }

        private void displaytbl_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
