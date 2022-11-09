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

namespace Inventry_management_system
{
    public class DbConnection
    {
        public static SqlConnection DbConnect()
        {
            var conn = new SqlConnection();
            conn.ConnectionString = "Data Source=ROSHANK;Initial Catalog=Inventrymanagementsystem;Integrated Security=True";
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            return conn;
        }


        public static DataSet GetDataSet(string SqlQuery)
        {
            try
            {
                SqlCommand cmd =new SqlCommand();
                cmd.Connection = DbConnect();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = SqlQuery;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;
            }
            catch (Exception ex )
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
        public static DataTable GetTableByQuery (string SqlQuery)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = DbConnect();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = SqlQuery;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    throw;
                    
                }
            
        }
        public static void ExecuteNonQuery(string SqlQuery)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = DbConnect();
                cmd.CommandText = SqlQuery;
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
    }
}