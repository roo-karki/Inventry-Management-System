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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void login_Load(object sender, EventArgs e)
        {

           
        }



        private void btnLogin_Click(object sender, EventArgs e)
        {

            {
                if (textUserName.Text == "" || textPassword.Text == "")
                {
                    MessageBox.Show("Give both  username and password");
                }
                else
                {
                    SqlConnection con = DbConnection.DbConnect();
                    SqlDataAdapter da = new SqlDataAdapter("select * from Users where UserName = '" + textUserName.Text + "' and Password= '" + textPassword.Text + "'", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count == 1)
                    {
                        Mainform main = new Mainform();
                        this.Hide();
                        main.Show();
                    }
                    else
                    {
                        MessageBox.Show("Invailed username and password");
                    }
                }



            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
