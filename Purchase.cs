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
    public partial class Purchase : Form
    {
        public Purchase()
        {
            InitializeComponent();
        }
        int id = 0;

        private void LoadSupplierCombo()
        {
            string sql = "select SupplierName From supplier";
            var data = DbConnection.GetTableByQuery(sql);
            comboBoxSupplierID.DataSource = data;
            comboBoxSupplierID.DisplayMember = "SupplierName";
            comboBoxSupplierID.ValueMember = "SupplierName";
        }
        private void LoadPurchaseCombo()
        {
            string sql = "select PurchaseID,SupplierName From purchase";
            var data = DbConnection.GetTableByQuery(sql);
            comboBoxPuchaseID.DataSource = data;
            comboBoxPuchaseID.DisplayMember = "SupplierName";
            comboBoxPuchaseID.ValueMember = "PurchaseID";
        }

        private void Purchase_Load(object sender, EventArgs e)
        {

            LoadSupplierCombo();
            LoadSupplierCombo();
        }

        public void Clear()
        {
           
            comboBoxPuchaseID.Text = "";
            textProductName.Text = "";
            comboBoxSupplierID.Text = "";
            textRemarks.Text = "";
            textAmountofInvoice.Text = "";
            textQuantity.Text = "";
            textPurchaseRate.Text = "";
            textInvoiceNo.Text = "";
            textTotal.Text = "";

        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            Clear();

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = DbConnection.DbConnect();
            SqlCommand cmd = new SqlCommand("Delete purchase  where PurchaseID=@e", con);

            cmd.Parameters.AddWithValue("@e", id);

            int i = cmd.ExecuteNonQuery();
            con.Close();
            if (i > 0)
            {
                MessageBox.Show("data deleted successfully");
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {

            if (Validate() == 1)
            {
                SqlConnection con = DbConnection.DbConnect();
                SqlCommand cmd = new SqlCommand("update purchase set InvoiceNo=@a, DateOfPurchase=@b, AmountOfInvoice=@c, Remarks=@d where PurchaseID=@e", con);
                cmd.Parameters.AddWithValue("@a", textInvoiceNo.Text);
                cmd.Parameters.AddWithValue("@b", DateTime.Parse(dt.Text));
                cmd.Parameters.AddWithValue("@c", textAmountofInvoice.Text);
                cmd.Parameters.AddWithValue("@d", textRemarks.Text);
                cmd.Parameters.AddWithValue("@e", id);

                int i = cmd.ExecuteNonQuery();
                con.Close();
                if (i > 0)
                {
                    MessageBox.Show("data edited successfully");
                }
            }
            else
            {
                MessageBox.Show("DateOfPurchase,InvoiceNo,AmountOfInvoice and Remarks are mandatory!");
            }
        }

        new int Validate()
        {
            int a = 1;
            if (textAmountofInvoice.Text == string.Empty || textInvoiceNo.Text == string.Empty || dt.Text == string.Empty || textRemarks.Text == string.Empty)
            {
                a = 0;
            }
            return a;
        }
        private void TextInvoiceNo_TextChanged(object sender, EventArgs e)
        {

            int i;
            string inv = textInvoiceNo.Text;
            for (i = 0; i < inv.Length; i++)
            {
                if (!char.IsNumber(inv[i]))
                {
                    MessageBox.Show("Enter integer number only");
                    textInvoiceNo.Text = "";

                }
            }

        }

        private void TextAmountofInvoice_TextChanged(object sender, EventArgs e)
        {
            int i;
            string inv = textAmountofInvoice.Text;
            for (i = 0; i < inv.Length; i++)
            {
                if (!char.IsNumber(inv[i]))
                {
                    MessageBox.Show("Enter integer number only");
                    textAmountofInvoice.Text = "";

                }
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {

            bool found = false;
            //double total = double.Parse(txtPurchaseRate.Text) * Convert.ToDouble(txtQuantity.Text);
            if (dataGridViewPurchase.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridViewPurchase.Rows)
                {
                    if (Convert.ToString(row.Cells[0].Value) == textProductName.Text && Convert.ToString(row.Cells[1].Value) == textPurchaseRate.Text)
                    {
                        row.Cells[2].Value = (Convert.ToString(Convert.ToInt32(textQuantity.Text) + Convert.ToInt32(row.Cells[2].Value)));
                        row.Cells[3].Value = (Convert.ToDouble(row.Cells[1].Value) * Convert.ToDouble(row.Cells[2].Value));
                        found = true;
                    }

                }

                if (!found)
                {
                    dataGridViewPurchase.Rows.Add(textProductName.Text, textPurchaseRate.Text, textQuantity.Text, textTotal.Text);

                    Clear();
                }
            }
            else
            {
                dataGridViewPurchase.Rows.Add(textProductName.Text, textPurchaseRate.Text, textQuantity.Text, textTotal.Text);

                Clear();
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           
            string sql = "Insert into purchase values ('" + textInvoiceNo.Text + "','" + comboBoxSupplierID.SelectedValue + "','" + dt.Value.ToString() + "','" + textAmountofInvoice.Text + "','" + textRemarks.Text + "')";
            DbConnection.ExecuteNonQuery(sql);

            

            
           
            if (dataGridViewPurchase.Rows.Count > 0)
            {


                for (int i = 0; i < dataGridViewPurchase.Rows.Count - 1; i++)
                {
                    string col1 = dataGridViewPurchase.Rows[i].Cells[0].Value.ToString();

                    string col2 = dataGridViewPurchase.Rows[i].Cells[1].Value.ToString();

                    string col3 = dataGridViewPurchase.Rows[i].Cells[2].Value.ToString();

                    string col4 = dataGridViewPurchase.Rows[i].Cells[3].Value.ToString();

                    string sql2 = "insert into PurchaseDetail values ('" + col1.ToString() + "','" + col2.ToString() + "','" + col3.ToString() + "','" + col4.ToString() + "')";
                    DbConnection.ExecuteNonQuery(sql2);
                    
                }
            }
            // }
            foreach (DataGridViewRow row in dataGridViewPurchase.Rows)
            {
                int q = 0;
                string pname = "";
                q = Convert.ToInt32(row.Cells[2].Value);
                pname = Convert.ToString(row.Cells[0].Value);

                string sql3 = "update product set Stock= Stock + '" + q + "' where ProductName='" + pname.ToString() + "'";
                DbConnection.ExecuteNonQuery(sql3);
            }




                textInvoiceNo.Text = "";
            comboBoxSupplierID.Text = "";
            dataGridViewPurchase.Text = "";
            textAmountofInvoice.Text = "";
            textRemarks.Text = "";
            textProductName.Text = "";
            textPurchaseRate.Text = "";
            textQuantity.Text = "";
            textTotal.Text = "";

            MessageBox.Show("detail saved sucessfully");
            LoadPurchaseCombo();
            LoadSupplierCombo();
            dataGridViewPurchase.Rows.Clear();
        }
    }

}

  
        

        
        
    
