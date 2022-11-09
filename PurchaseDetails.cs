using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventry_management_system
{
    public partial class PurchaseDetails : Form
    {
        public PurchaseDetails()
        {
            InitializeComponent();
        }

        private void PurchaseDetails_Load(object sender, EventArgs e)
        {
            LoadPD();
            loadDP();

        }
        private void LoadPD()
        {
            string sql = "select * from purchase";
            var dt = DbConnection.GetTableByQuery(sql);
            datagvpurchaseList.DataSource = dt;
        }

        private void loadDP()
            {
            string sql = "select  ProductID,ProductName,PurchaseRate,Quantity,Total from PurchaseDetail";
            var da = DbConnection.GetTableByQuery(sql);
            datagvPurchaseDetails.DataSource = da;
        }

        private void PurchaseDetails_Load_1(object sender, EventArgs e)
        {

        }
    }
}
