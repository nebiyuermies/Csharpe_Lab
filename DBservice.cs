using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace WformLab
{
    internal class DBservice
    {
        string path = "server =SENSEI;Database =test;Integrated security = true;";
        SqlConnection conn;

        public DBservice()
      {
            try
            {
                conn = new SqlConnection(path);
                conn.ConnectionString = path;
                conn.Open();
                MessageBox.Show("Connection is successful !");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            
         }

        public void  totatbrands(int Brandid) 
        {
            string path = "data source =SENSEI;Database =test;Integrated security = true;";
            string query = "select * from brands where id ="+Brandid;

            try
            {
                using (SqlConnection conn = new SqlConnection(path))
            {
                SqlCommand cmd = new SqlCommand(query , conn);
                conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery(); // returns rows affected
                if (rowsAffected > 0) { }
                    //MessageBox.Show("delete Successfully");

            }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }





        }
    
    }
}
