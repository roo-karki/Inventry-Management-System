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
    public partial class customer : Form
    {
        public customer()
        {
            InitializeComponent();
        }

       
        private void btnSave_Click(object sender, EventArgs e)
        {
            string sql = "Insert into Customer(CustomerName,Address,Telephone,Remark) values('" + textCustomerName.Text + "','" + textAddress.Text + "','" + textTelephone.Text + "','" + textRemarks.Text + "')";
            DbConnection.ExecuteNonQuery(sql);
            MessageBox.Show("saved");
            loadgv();

        }
        private void  loadgv()
        {
            string Sql = "select *from customer";
            var dt = DbConnection.GetTableByQuery(Sql);
             

        }

        private void customer_Load(object sender, EventArgs e)
        {
            loadgv();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {

        }

        private void grpCustomer_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
