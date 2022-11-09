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
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
        }

     private void Users_Load(object sender, EventArgs e)
        {
            load();
            Clear();
        }
        int id;
        DataTable gv;
        private void Clear()
        {
            textStaffName.Text = "";
            textStaffPhoneNo.Text = "";
            textUserName.Text = "";
            textStaffAddress.Text = "";
            textRemarks.Text = "";
            textPassword.Text = "";
            textIsAdmin.Text = "";
            id = 0;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (textStaffName.Text == "" || textStaffAddress.Text == "" || textStaffPhoneNo.Text == "" || textUserName.Text == "" || textPassword.Text == "")
                {
                    MessageBox.Show("please fill the necessary details");
                }
                else
                {
                    string Sql = "Insert into Users(StaffName,staffAddress,StaffPhoneNo,Remarks,IsAdmin,Username,Password) values('" + textStaffName.Text + "','" + textStaffAddress.Text + "','" + textStaffPhoneNo.Text + "','" + textRemarks.Text + "','" + textIsAdmin.Text + "','" + textUserName.Text + "','" + textPassword.Text + "')";
                    DbConnection.ExecuteNonQuery(Sql);
                     MessageBox.Show("Your Details Saved", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
                    load();
                    Clear();

                }
            }
            catch (Exception)
            {
               // MessageBox.Show("ex.message");
                throw;
            }
           
         }
        private void load()
        {
            string sql = "select * from SalesDetail";
            gv = DbConnection.GetTableByQuery(sql);
            gvUserList.DataSource = gv;
        }
        private void btnDelete_Click(object sender, EventArgs e)
        { 
            string Sql = "Delete from Users where StaffID = "+textStaffID.Text+"";
            DbConnection.ExecuteNonQuery(Sql);
            MessageBox.Show("Deleted");
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult da = MessageBox.Show("Are You want to sure to delete data?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (da == DialogResult.Yes)
                {
                    string sql = "update SalesDetail set StaffName='" + textStaffName.Text + "',StaffAddress='" + textStaffAddress.Text + "',StaffPhoneNumber='" + textStaffPhoneNo.Text + "',Remark='" + textRemarks.Text + "',Username='" + textUserName.Text + "',Password='" + textPassword.Text + "',IsAdmin='" + textIsAdmin.Text + "' where StaffID=" + id;
                    DbConnection.ExecuteNonQuery(sql);
                    MessageBox.Show("Your Details Updated", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
                    load();
                    Clear();
                }
                else
                {
                    Clear();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Clear();
            textStaffName.Focus();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Clear();
            textStaffName.Focus();
        }

        private void gvUserList_RowDividerDoubleClick(object sender, DataGridViewRowDividerDoubleClickEventArgs e)
        {
            id = int.Parse(gvUserList.Rows[e.RowIndex].Cells[0].Value.ToString());
            textStaffName.Text = gvUserList.Rows[e.RowIndex].Cells[1].Value.ToString();
            textStaffAddress.Text = gvUserList.Rows[e.RowIndex].Cells[2].Value.ToString();
            textStaffPhoneNo.Text = gvUserList.Rows[e.RowIndex].Cells[3].Value.ToString();
            textUserName.Text = gvUserList.Rows[e.RowIndex].Cells[4].Value.ToString();
           textPassword.Text = gvUserList.Rows[e.RowIndex].Cells[5].Value.ToString();
            textRemarks.Text = gvUserList.Rows[e.RowIndex].Cells[6].Value.ToString();
            textIsAdmin.Text = gvUserList.Rows[e.RowIndex].Cells[7].Value.ToString();
        }
    }
}
