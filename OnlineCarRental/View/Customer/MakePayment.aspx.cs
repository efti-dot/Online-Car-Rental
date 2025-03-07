using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineCarRental.View.Customer
{
    public partial class MakePayment : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Conn = new Models.Functions();
            ShowCars();
        }

        Models.Functions Conn;
        public override void VerifyRenderingInServerForm(Control control)
        {

        }

        private void ShowCars()
        {
            string st = "Available";
            string Query = "select * from ReturnTbl where Customer = '" + Login.CustId + "' ";
            PaymentList.DataSource = Conn.GetData(Query);
            PaymentList.DataBind();
        }

        protected void PayBtn_Click1(object sender, EventArgs e)
        {
            try
            {
                if (PaymentList.SelectedRow == null || PaymentList.SelectedRow.Cells[1] == null)
                {
                    ErrorMsg.InnerText = "No row selected or missing information";
                }
                else
                {
                    string selectedFees = PaymentList.SelectedRow.Cells[8].Text;
                    Session["SelectedFees"] = selectedFees;

                    string selectedFees1 = PaymentList.SelectedRow.Cells[1].Text;
                    Session["SelectedFees1"] = selectedFees1;

                    string script = "window.open('Payment.aspx', 'PaymentPopup', 'width=600,height=600');";
                    ScriptManager.RegisterStartupScript(this, GetType(), "PaymentPopup", script, true);
                }
            }
            catch (Exception ex)
            {
                ErrorMsg.InnerText = ex.Message;
            }
        }


        public static int amountTK;
        string LNumberTb;
        protected void PaymentList_SelectedIndexChanged(object sender, EventArgs e)
        {
            LNumberTb = PaymentList.SelectedRow.Cells[1].Text;
        }
    }
}