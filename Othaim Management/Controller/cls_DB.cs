using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Othaim_Management.Model;

namespace Othaim_Management.Controller
{   
    class cls_DB
    {
        
        // Connection String
        SqlConnection con = new SqlConnection(@"Data Source=TP550L\MSSQL;Initial Catalog=Sales_System;Integrated Security=True");
        //false;User ID = sa; password='"+Properties.Settings.Default.saPass+"'


        SqlCommand cmd = new SqlCommand();

        // Select Data From Database Function
        public DataTable readData(string stmt, string Message)
        {
            DataTable tbl = new DataTable();
            try
            {
                cmd.Connection = con;
                cmd.CommandText = stmt;

                con.Open();

                tbl.Load(cmd.ExecuteReader());

                con.Close();
                if (Message != "")
                {
                    MessageBox.Show(Message, "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

            return tbl;
        }

        // Insert Update Delete
        public bool exceuteData(string stmt, string Message)
        {
            try
            {

                cmd.Connection = con;
                cmd.CommandText = stmt;

                con.Open();

                cmd.ExecuteNonQuery();

                con.Close();

                if (Message != "")
                {
                    MessageBox.Show(Message, "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                con.Close();
            }
        }


    }
}
