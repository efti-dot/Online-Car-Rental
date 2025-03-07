using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineCarRental.View.Admin
{
    public partial class Rents : System.Web.UI.Page
    {

        Models.Functions Conn;
        public override void VerifyRenderingInServerForm(Control control)
        {

        }

        private void ShowRents()
        {
            
            string Query = "select * from RentTbl ";
            GridView1.DataSource = Conn.GetData(Query);
            GridView1.DataBind();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            Conn = new Models.Functions();
            ShowRents();
        }

        private void ReturnCar()
        {
            try
            {
                    string Query = "delete from RentTbl where RentId = '{0}'";
                    Query = string.Format(Query, GridView1.SelectedRow.Cells[1].Text);
                    Conn.SetData(Query);
            
            }
            catch (Exception Ex)
            {
                ErrorMsg.InnerText = Ex.Message;
            }
        }

        string LNumberTb;
        protected void RentList_SelectedIndexChanged(object sender, EventArgs e)
        {
            LNumberTb = GridView1.SelectedRow.Cells[1].Text;
        }

        private void UpdateCar()
        {
            try
            {

                string Status = "Available";
                string Query = "update CarTbl set Status = '{0}' where CPlateNum = '{1}' ";
                Query = string.Format(Query, Status, GridView1.SelectedRow.Cells[2].Text);
                Conn.SetData(Query);
                ShowRents();

            }
            catch (Exception Ex)
            {
                ErrorMsg.InnerText = Ex.Message;
            }
        }

        protected void ReturnBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (GridView1.SelectedRow == null || GridView1.SelectedRow.Cells[1] == null)
                {
                    ErrorMsg.InnerText = "Missing Information";
                }
                else
                {

                    int amount = int.Parse(GridView1.SelectedRow.Cells[6].Text) + int.Parse(FineTb.Value);
                    string Query = "INSERT INTO ReturnTbl ([Car], [Customer], [Date], [Delay], [Fine], [Payment], [Amount]) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}')";
                    Query = string.Format(Query, GridView1.SelectedRow.Cells[2].Text, GridView1.SelectedRow.Cells[3].Text, System.DateTime.Today.Date.ToString(), DelayTb.Value, FineTb.Value, "Due", amount);
                    Conn.SetData(Query);
                    UpdateCar();
                    ReturnCar();
                    ShowRents();
                    ErrorMsg.InnerText = "Car Returned";
                }
            }
            catch (Exception Ex)
            {
                ErrorMsg.InnerText = Ex.Message;
            }
        }
    }
}