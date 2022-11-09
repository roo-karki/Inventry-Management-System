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
    public partial class Supplier : Form
    {
        public Supplier()
        {
            InitializeComponent();
        }
         
        private void Supplier_Load(object sender, EventArgs e)
        {
            loadgv();
            clear();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if(textSuppliersName.Text == "" && textTelephone.Text == "" && textRemarks.Text == "")
                {
                    MessageBox.Show("please fill all the necessary details");
                }
                else
                {
                    string sql = "Insert into supplier(SupplierName,Address,Telephone,Remarks) values ('" + textSuppliersName.Text + "','" + textAddress.Text + "','" + textTelephone.Text + "','" + textRemarks.Text + "')";
                    DbConnection.ExecuteNonQuery(sql);
                    MessageBox.Show("Your Details Saved", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
                    loadgv();
                    clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            
        }
        private void loadgv()
        {
            string sql = "select * from supplier";
            var dt = DbConnection.GetTableByQuery(sql);
            gvSupplierList.DataSource = dt;
        }
       private int SupplierID;
        private void gvSupplierList_RowDividerDoubleClick(object sender, DataGridViewRowDividerDoubleClickEventArgs e)
        {
            SupplierID = int.Parse(gvSupplierList.Rows[e.RowIndex].Cells[0].Value.ToString());
            textSuppliersName.Text = gvSupplierList.Rows[e.RowIndex].Cells[1].Value.ToString();
            textAddress.Text = gvSupplierList.Rows[e.RowIndex].Cells[2].Value.ToString();
            textTelephone.Text = gvSupplierList.Rows[e.RowIndex].Cells[3].Value.ToString();
            textRemarks.Text = gvSupplierList.Rows[e.RowIndex].Cells[4].Value.ToString();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    DialogResult da = MessageBox.Show("Are You want to sure to delete data?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (da == DialogResult.Yes)
                    {
                        string sql = "Delete from supplier where SupplierID=" + SupplierID;
                        DbConnection.ExecuteNonQuery(sql);
                        MessageBox.Show("Your Details deleted", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
                        loadgv();


                    }
                    else
                    {
                        clear();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    throw;
                }

            }


        }
        private void clear()
        {
            textSuppliersName.Text = "";
            textTelephone.Text = "";
            textRemarks.Text = "";
            textAddress.Text = "";
            SupplierID = 0;
        }

        private void btnEdit(object sender, EventArgs e)
        {
            string sql = "update supplier set SupplierName='" + textSuppliersName.Text + "',Address='" + textAddress.Text + "',Telephone='" + textTelephone.Text + "',Remarks='" + textRemarks.Text + "' where SupplierID=" + SupplierID;
            DbConnection.ExecuteNonQuery(sql);
            MessageBox.Show("Your Details Updated", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
            loadgv();
            
        }



        private void btnReset(object sender, EventArgs e)
        {
            clear();
            textSuppliersName.Focus();
        }

        
        private void btnNew(object sender, EventArgs e)
        {
            clear();
            textSuppliersName.Focus();
        }

        private void gvSupplierList_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }
    }
}
