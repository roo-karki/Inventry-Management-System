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
    public partial class SalesDetails : Form
    {
        public SalesDetails()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void SalesDetails_Load(object sender, EventArgs e)
        {
            SqlConnection con = DbConnection.DbConnect();
            SqlCommand cmd = new SqlCommand("select SalesId,DateOfSales,InvoiceNo,AmountOfInvoice from Sales", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
           dataGridViewSalesList.DataSource = dt;

            SqlConnection con1 = DbConnection.DbConnect();
            SqlDataAdapter da1 = new SqlDataAdapter("select ProductName,SalesRate,Quantity from Salesdetail", con);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            gvdSalesDetails.DataSource = dt1;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {

        }
    }
}
