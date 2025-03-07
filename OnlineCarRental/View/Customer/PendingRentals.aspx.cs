using OnlineCarRental.Models;
using OnlineCarRental.View.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineCarRental.View.Customer
{
    public partial class PendingRentals : System.Web.UI.Page
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
            string Query = "select * from RentTbl where Customer = '" + Login.CustId + "' ";
            RentList.DataSource = Conn.GetData(Query);
            RentList.DataBind();
        }




        public static int amountTK;
        string LNumberTb;
        protected void RentList_SelectedIndexChanged(object sender, EventArgs e)
        {
            LNumberTb = RentList.SelectedRow.Cells[1].Text;
            /*CustomerNameTb.Value = RentList.SelectedRow.Cells[2].Text;
            LicenceTb.Value = RentList.SelectedRow.Cells[3].Text;
            AddTb.Value = RentList.SelectedRow.Cells[4].Text;
            EmailTb.Value = RentList.SelectedRow.Cells[5].Text;
            NIdTb.Value = RentList.SelectedRow.Cells[6].Text;
            PhoneTb.Value = RentList.SelectedRow.Cells[7].Text;
            PassTb.Value = RentList.SelectedRow.Cells[8].Text;*/
        }

        

        protected void PayBtn_Click1(object sender, EventArgs e)
        {



            try
            {
                if (RentList.SelectedRow == null || RentList.SelectedRow.Cells[1] == null)
                {
                    ErrorMsg.InnerText = "No row selected or missing information";
                }
                else
                {
                    string selectedFees = RentList.SelectedRow.Cells[6].Text;
                    Session["SelectedFees"] = selectedFees;

                    string script = "window.open('Payment.aspx', 'PaymentPopup', 'width=600,height=600');";
                    ScriptManager.RegisterStartupScript(this, GetType(), "PaymentPopup", script, true);
                }
            }
            catch (Exception ex)
            {
                ErrorMsg.InnerText = ex.Message;
            }
        }
    }
}