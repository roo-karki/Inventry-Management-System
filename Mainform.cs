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
    public partial class Mainform : Form
    {
        public Mainform()
        {
            InitializeComponent();
        }

        private void masterEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void purchaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Purchase p = new Purchase();
            p.Show();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Users formuser = new Users();
            this.Hide();
            formuser.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            login formlogin = new login();
            DialogResult da = MessageBox.Show("Are you sure you want to logout", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
               if(da == DialogResult.Yes)
            {
                this.Hide();
                formlogin.Show();
            }
          
                
        }

        private void salesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sales s = new Sales();
            s.Show();
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            customer c = new customer();
            c.Show();
               
        }

        private void utilitiesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            product p = new product();
            p.Show();
            this.Hide();
        }

        private void purchaseDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PurchaseDetails pd = new PurchaseDetails();
            pd.Show();

                

            
                

        }

        private void salesDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalesDetails sd = new SalesDetails();
            sd.Show();
        }

        private void supplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Supplier s = new Supplier();
            s.Show();

        }
        /* private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
{
DialogResult da = MessageBox.Show("Are you want to sure to logout", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
if (da==DialogResult.Yes)
{
this.Hide();
formlogin.Show();
}
else
{
////
}
}*/
    }
}
