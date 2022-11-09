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
    public partial class Sales : Form
    {
        public Sales()
        {
            InitializeComponent();
        }

        private void Sales_Load(object sender, EventArgs e)
        {
            LoadSalesCombo();
            LoadCustomerCombo();
        }
        private void LoadSalesCombo()
        {
            string sql = "select SalesID,CustomerName from Sales";
            var data = DbConnection.GetTableByQuery(sql);
            comboBoxSalesID.DataSource = data;
            comboBoxSalesID.DisplayMember = "CustomerName";
            comboBoxSalesID.ValueMember = "SalesID";
        }
        private void LoadCustomerCombo()
        {
            string sql = "select CustomerName From customer";
            var data = DbConnection.GetTableByQuery(sql);
            comboBoxCustomerName.DataSource = data;
            comboBoxCustomerName.DisplayMember = "CustomerName";
            comboBoxCustomerName.ValueMember = "CustomerName";
        }
        private void Clear()
        {
            textProductName.Text = "";
            textSalesRate.Text = "";
            textQuantity.Text = "";
            textTotal.Text = "";

        }


        private void textSalesRate_Enter(object sender, EventArgs e)
        {
            string sql = "select top 1 * from product where ProductName ='" + textProductName.Text + "' order by ProductID desc";
            DbConnection.ExecuteNonQuery(sql);
            var ds = DbConnection.GetTableByQuery(sql);
            foreach (DataRow dr in ds.Rows)
            {
                textSalesRate.Text = dr["SellingPrice"].ToString();
            }
        }

        private void textQuantity_Leave(object sender, EventArgs e)
        {
            try
            {
                textTotal.Text = (float.Parse(textSalesRate.Text) * float.Parse(textQuantity.Text)).ToString();

            }
            catch (Exception)
            {

                throw;
            }
        }
        void CalculateTotal()
        {
            decimal sum = 0;
            for (int i = 0; i < dataGridViewSales.Rows.Count; i++)
            {
                sum = sum + Convert.ToDecimal(dataGridViewSales.Rows[i].Cells[3].Value);
            }
            lblTotal.Text = sum.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {

                bool found = false;
                //double total = double.Parse(txtPurchaseRate.Text) * Convert.ToDouble(txtQuantity.Text);
                if (dataGridViewSales.Rows.Count > 0)
                {
                    foreach (DataGridViewRow row in dataGridViewSales.Rows)
                    {
                        if (Convert.ToString(row.Cells[0].Value) == textProductName.Text && Convert.ToString(row.Cells[1].Value) == textSalesRate.Text)
                        {
                            row.Cells[2].Value = (Convert.ToString(Convert.ToInt32(textQuantity.Text) + Convert.ToInt32(row.Cells[2].Value)));
                            row.Cells[3].Value = (Convert.ToDouble(row.Cells[1].Value) * Convert.ToDouble(row.Cells[2].Value));
                            found = true;
                        }
                        CalculateTotal();


                    }


                    if (!found)
                    {
                        dataGridViewSales.Rows.Add(textProductName.Text, textSalesRate.Text, textQuantity.Text, textTotal.Text);
                        CalculateTotal();
                        Clear();
                    }
                    else
                    {
                        dataGridViewSales.Rows.Add(textProductName.Text, textSalesRate.Text, textQuantity.Text, textTotal.Text);
                        CalculateTotal();

                        Clear();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            //GvPurchase.Rows.RemoveAt(int.Parse(GvPurchase.CurrentCell.RowIndex.ToString()));
            int rowindex = dataGridViewSales.CurrentCell.RowIndex;
            dataGridViewSales.Rows.RemoveAt(rowindex);
            CalculateTotal();

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataTable search = new DataTable();
            string sql = "Select * from Sales where SalesID=" + comboBoxSalesID.SelectedValue + "";
            search = DbConnection.GetTableByQuery(sql);
            if (search.Rows.Count > 0)
            {
                textInvoiceNumber.Text = search.Rows[0]["InvoiceNo"].ToString();
                dtp.Value = Convert.ToDateTime(search.Rows[0]["DateOfSales"]);
                comboBoxCustomerName.SelectedValue = Convert.ToString(search.Rows[0]["CustomerName"]);
                textAmountOfInvoice.Text = Convert.ToDecimal(search.Rows[0]["AmountofInvoice"]).ToString();
                textRemarks.Text = Convert.ToString(search.Rows[0]["Remarks"]);

            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            textProductName.Focus();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {

            textInvoiceNumber.Text = "";
            comboBoxCustomerName.Text = "";
            dtp.Text = "";
            textAmountOfInvoice.Text = "";
            textRemarks.Text = "";
            textProductName.Text = "";
            textSalesRate.Text = "";
            textQuantity.Text = "";
            textTotal.Text = "";

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int orderid = 0;
            string sql = "insert into Sales values ('" + textInvoiceNumber.Text + "','" + comboBoxCustomerName.SelectedValue + "','" + dtp.Value.ToString() + "','" + textAmountOfInvoice.Text + "','" + textRemarks.Text + "')";
            DbConnection.ExecuteNonQuery(sql);

            string sql1 = "select top 1 * from product order by ProductID desc";
            var ds1 = DbConnection.GetTableByQuery(sql1);
            foreach (DataRow dr2 in ds1.Rows)
            {
                orderid = int.Parse(dr2["ProductID"].ToString());
            }
            if (dataGridViewSales.Rows.Count > 0)
            {


                for (int i = 0; i < dataGridViewSales.Rows.Count - 1; i++)
                {
                    string col1 = dataGridViewSales.Rows[i].Cells[0].Value.ToString();

                    string col2 = dataGridViewSales.Rows[i].Cells[1].Value.ToString();

                    string col3 = dataGridViewSales.Rows[i].Cells[2].Value.ToString();

                    string col4 = dataGridViewSales.Rows[i].Cells[3].Value.ToString();

                    string sql2 = "insert into SalesDetail values ('" + col1.ToString() + "','" + col2.ToString() + "','" + col3.ToString() + "','" + col4.ToString() + "')";
                    DbConnection.ExecuteNonQuery(sql2);
                }
            }
            // }
            foreach (DataGridViewRow row in dataGridViewSales.Rows)
            {
                int q = 0;
                string pname = "";
                q = Convert.ToInt32(row.Cells[2].Value);
                pname = Convert.ToString(row.Cells[0].Value);

                string sql3 = "update product set Stock= Stock - '" + q + "' where ProductName='" + pname.ToString() + "'";
                DbConnection.ExecuteNonQuery(sql3);
            }
                textInvoiceNumber.Text = "";
            comboBoxCustomerName.Text = "";
            dtp.Text = "";
            textAmountOfInvoice.Text = "";
            textRemarks.Text = "";
            textProductName.Text = "";
            textSalesRate.Text = "";
            textQuantity.Text = "";
            textTotal.Text = "";
            MessageBox.Show("detail saved sucessfully");
            LoadSalesCombo();
            LoadCustomerCombo();
            dataGridViewSales.Rows.Clear();


        }

        
    }

}
