using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineCarRental.View.Customer
{
    public partial class Payment : System.Web.UI.Page
    {

        Models.Functions Conn;
        public override void VerifyRenderingInServerForm(Control control)
        {

        }

        protected void Page_Load(object sender, EventArgs e)
        {
            Conn = new Models.Functions();

            if (!IsPostBack)
            {
                if (Session["SelectedFees"] != null)
                {
                    amountTK.Text = Session["SelectedFees"].ToString();
                    CustName.Text = Session["SelectedFees1"].ToString();
                }
            }

        }

        private void UpdatePayment()
        {
            try
            {

                string Status = "Paid";
                string Query = "update ReturnTbl set Payment = '{0}' where RetId = '{1}' ";
                Query = string.Format(Query, Status, CustName.Text);
                Conn.SetData(Query);
                

            }
            catch (Exception Ex)
            {
                ErrorMsg.InnerText = Ex.Message;
            }
        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            string closeScript = "PaymentPopup.close();";
            ScriptManager.RegisterStartupScript(this, GetType(), "ClosePaymentPopup", closeScript, true);
        }

        protected void Unnamed2_Click(object sender, EventArgs e)
        {
            try
            {
                if (phone.Value == "" || password.Value == "")
                {
                    ErrorMsg.InnerText = "Missing Information";
                }
                else
                {

                    
                    string Query = "INSERT INTO PaymentTbl ([Amount], [DateTime], [CustomerName], [CustomerId] ) VALUES ('{0}', '{1}', '{2}', '{3}' )";
                    Query = string.Format(Query, amountTK.Text, System.DateTime.Today.Date.ToString(), Login.CustomerName, Login.CustId);
                    Conn.SetData(Query);
                    UpdatePayment();

                    
                    ErrorMsg.InnerText = "Payment Done!";
                }
            }
            catch (Exception ex)
            {
                ErrorMsg.InnerText = ex.Message;
                
            };
        }
    }
}