using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineCarRental.View.Customer
{
    public partial class Cars : System.Web.UI.Page
    {
        Models.Functions Conn;



        public override void VerifyRenderingInServerForm(Control control)
        {

        }

        private void ShowCars()
        {
            string st = "Available";
            string Query = "select * from CarTbl where Status = '" +st+"' ";
            GridView1.DataSource = Conn.GetData(Query);
            GridView1.DataBind();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            Conn = new Models.Functions();
            ShowCars();
            CustName.InnerText = Login.CName;
            Customer = Login.CustId;
        }

        private void UpdateCar()
        {
            try
            {
                
                    string Status = "Booked";
                    string Query = "update CarTbl set Status = '{0}' where CPlateNum = '{1}' ";
                    Query = string.Format(Query, Status, GridView1.SelectedRow.Cells[1].Text);
                    Conn.SetData(Query);
                    ShowCars();
                
            }
            catch (Exception Ex)
            {
                InfoMsg.InnerText = Ex.Message;
            }
        }

        protected void BookBtn_Click(object sender, EventArgs e)
        {
            
            DateTime selectedReturnDate = Convert.ToDateTime(ReturnDate.Value);

            
            if (selectedReturnDate < DateTime.Today)
            {
                
                InfoMsg.InnerText = "Return date cannot be in the past";
                return; 
            }

            
            TimeSpan rentalPeriod = selectedReturnDate - DateTime.Today;
            int daysRented = rentalPeriod.Days;

            
            int rentalPrice = Convert.ToInt32(GridView1.SelectedRow.Cells[4].Text);
            int fees = rentalPrice * daysRented;

            
            try
            {
                
                string query = "INSERT INTO RentTbl ([Car], [Customer], [RentDate], [ReturnDate], [Fees]) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}')";
                query = string.Format(query, GridView1.SelectedRow.Cells[1].Text, Login.CustId, System.DateTime.Today.Date.ToString(), selectedReturnDate.ToString(), fees);

                
                Conn.SetData(query);

                
                UpdateCar();
                ShowCars();

                
                InfoMsg.InnerText = "Car Rented";
            }
            catch (Exception ex)
            {
                
                InfoMsg.InnerText = ex.Message;
            }
        }


        string LNumber, RentDate, RtnDate;

        int fees = 0, Dprice, Customer;
         
        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LNumber = GridView1.SelectedRow.Cells[1].Text;
            RentDate = System.DateTime.Today.Date.ToString();
            RtnDate = ReturnDate.Value;
            Dprice = Convert.ToInt32(GridView1.SelectedRow.Cells[4].Text);
            
        }
    }
}