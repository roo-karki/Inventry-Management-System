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
    public partial class product : Form
    {
        public product()
        {
            InitializeComponent();
        }
        
        int ProductID;
        SqlConnection con = DbConnection.DbConnect();

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if(textProductName.Text == ""|| textUnit.Text ==""||textSellingPrice.Text == ""||textCostPrice.Text==""||textFreshQuantity.Text==""||textDamagedQuantity.Text=="" )
                {
                    MessageBox.Show("Please fill all the necessary details");
                }
                else
                {
                    string sql = "Insert into product (ProductName,Unit,SellingPrice,CostPrice,Stock) values ('" + textProductName.Text + "','" + textUnit.Text + "','" + textSellingPrice.Text + "','" + textCostPrice.Text + "','" + textStock.Text + "')";
                    DbConnection.ExecuteNonQuery(sql);
                    MessageBox.Show("saved");
                  
                    loadgv();
                }

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
                throw;
            }

        }

        private void groupProductList_Enter(object sender, EventArgs e)
        {

        }

        private void product_Load(object sender, EventArgs e)
        {
            loadgv();
        }
        private void loadgv()
        {
            using (SqlCommand cmd = new SqlCommand("select * from product", con))
            {
                DataTable dt = new DataTable();
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(dt);
                    GvProductList.DataSource = dt;
                }
            }

        }
       private void clear()
        {
            ProductID = 0;
            textProductName.Text = "";
            textUnit.Text = "";
            textSellingPrice.Text = "";
            textCostPrice.Text = "";
            textFreshQuantity.Text = "";
            textDamagedQuantity.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            /*using(SqlCommand cmd = new SqlCommand("delete from product where ProductID = @ProductID",con))
              {
              cmd.parameters.addwithvalue("@ProductID",ProductID);
              con.open();
              cmd.executeNonQuery();
              con.close();
              loadgv();

            }*/
            try
            {
                DialogResult da = MessageBox.Show("Are You want to sure to delete data?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (da == DialogResult.Yes)
                {
                    string sql = "Delete from product where productID=" + ProductID;
                    DbConnection.ExecuteNonQuery(sql);
                    MessageBox.Show("Deleted");
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

        private void GvProductList_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ProductID = int.Parse(GvProductList.Rows[e.RowIndex].Cells[0].Value.ToString());
            textProductName.Text = GvProductList.Rows[e.RowIndex].Cells[1].Value.ToString();
           textUnit.Text = GvProductList.Rows[e.RowIndex].Cells[2].Value.ToString();
            textSellingPrice.Text = GvProductList.Rows[e.RowIndex].Cells[3].Value.ToString();
            textCostPrice.Text = GvProductList.Rows[e.RowIndex].Cells[4].Value.ToString();
           
            /*textProductId = int.parse(GvProductList.currentrow.cells["ProductID"].value.Tostring();
             textUnit.Text = GvProductList.currentrow.cells["Unit"}.value .Tostring();
             textSellingPrice.Text = GvProductlist.Currentrow.cells["sellingprice"].value.Tostring();
             textcostprice.text = GvProductlist.currentrow.cells["cost price"].value .Tostring();
             textFreshQuantity.text = Gvproductlist.currentrow.cells["freshQuantity"].value.Tostring();
             textDamagedQuantity.text = GvproductList.cuurentrow.cells["DamagedQuantity"].value.Tostring();
             */
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            /*using(SqlCommand cmd = new SqlCommand("Update product Set ProductName = @a,unit = @b,SellingPrice = @c,Costprice = @d,FreshPrice = @e,DamagedPrice =@f where ProductID = @ProductID",con))
              {
              cmd.parameters.addwithvalue("@ProductID",ProductID);
              cmd.parameters.addwithvalue("@a",ProductName);
              cmd.parameters.addwithvalue("@b",Unit);
              cmd.parameters.addwithvalue("@c",sellingprice);
              cmd.parameters.addwithvalue("@d",costprice);
              cmd.parameters.addwithvalue("@e",FreshQuantity);
              cmd.parameters.addwithvalue("@f",DamagedQuantity);
              //con.open();
              cmd.executeNonquery();
              //con.close();

              */
              string Sql = "update product set ProductName = '"+textProductName.Text +"',Unit = " +textUnit.Text+",SellingPrice ="+textSellingPrice.Text+",CostPrice = "+textCostPrice.Text+",FreshQuantity="+textFreshQuantity.Text+",DamagedQuantity = "+textDamagedQuantity.Text+" where ProductID = "+ProductID;
            DbConnection.ExecuteNonQuery(Sql);
            MessageBox.Show("Edited ");
            loadgv();
            clear();
              
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            clear();
            textProductName.Focus();
        }

        

        private void btnNew_Click(object sender, EventArgs e)
        {
            clear();
            textProductName.Focus();
        }
    }
}
