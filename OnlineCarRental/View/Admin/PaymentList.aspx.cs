using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineCarRental.View.Admin
{
    public partial class PaymentList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Conn = new Models.Functions();
            ShowPayment();
        }

        Models.Functions Conn;
        public override void VerifyRenderingInServerForm(Control control)
        {

        }

        private void ShowPayment()
        {

            string Query = "select * from PaymentTbl ";
            paymentList.DataSource = Conn.GetData(Query);
            paymentList.DataBind();
        }
    }
}