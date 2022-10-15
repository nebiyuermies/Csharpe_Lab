using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WformLab
{
    public partial class DBconnectiion : Form
    {
        public DBconnectiion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DBservice dbservice = new DBservice();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DBservice DBS = new DBservice();
            
        }

        private void Test_Click(object sender, EventArgs e)
        {
            string src = "Data Source=SENSEI;Initial Catalog=testDB;Integrated Security=True; TrustServerCertificate=True";
            string Query = "Stduntproc";
            try
            {
                SqlConnection con = new SqlConnection(src);
                con.Open();
                SqlCommand com = new SqlCommand(Query, con);
                com.CommandText = Query;
                com.CommandType = CommandType.StoredProcedure;
                var result = com.ExecuteReader();
                //var rowsaffect = com.ExecuteNonQuery(); //ROws affected
                //.ExecuteScalar(); Single Element
                //MessageBox.Show(rowsaffect.ToString());
                //SqlDataReader sdr = com.ExecuteReader();
                int r = 0;
                while (result.Read())
                {
                    TableS.Rows.Add(1);
                    TableS[0, r].Value = result["StudentName"].ToString();
                    TableS[1, r].Value = result["StudnentPhone"].ToString();
                    TableS[2, r].Value = result["StudentId"].ToString();
                    r++;
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
