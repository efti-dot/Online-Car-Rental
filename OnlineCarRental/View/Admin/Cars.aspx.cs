using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineCarRental.View.Admin
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        Models.Functions Conn;
        protected void Page_Load(object sender, EventArgs e)
        {
            Conn = new Models.Functions();
            ShowCars();

        }

        public override void VerifyRenderingInServerForm(Control control)
        {
            
        }

        private void ShowCars()
        {
            string Query = "select * from CarTbl";
            CarList.DataSource = Conn.GetData(Query);
            CarList.DataBind();
        }

        protected void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (LNumberTb.Value == "" || BrandTb.Value == "" || ModelTb.Value == "" || PriceTb.Value == "" || ColorTb.Value == "" || checkBox.Checked != true)
                {
                    ErrorMsg.InnerText = "Missing Information";
                }
                else
                {
                    string CPlateNum = LNumberTb.Value.ToString();
                    string Brand = BrandTb.Value;
                    string Model = ModelTb.Value;
                    int RPrice = Convert.ToInt32(PriceTb.Value.ToString());
                    string Color = ColorTb.Value;
                    string Status = AvailableTb.SelectedValue;
                    string Query = "insert into CarTbl values( '{0}' , '{1}' , '{2}' , '{3}' , '{4}' , '{5}' )";
                    Query = string.Format(Query, CPlateNum, Brand, Model, RPrice, Color, Status);
                    Conn.SetData(Query);
                    ShowCars();
                    ErrorMsg.InnerText = "Car added successfully";

                    LNumberTb.Value = "";
                    BrandTb.Value = "";
                    ModelTb.Value = "";
                    PriceTb.Value = "";
                    ColorTb.Value = "";
                    AvailableTb.SelectedValue = "";
                    checkBox.Checked = false;
                }
            }
            catch(Exception Ex) { 
                ErrorMsg.InnerText = Ex.Message;
            }
        }

        
        protected void CarList_SelectedIndexChanged(object sender, EventArgs e)
        {
            LNumberTb.Value = CarList.SelectedRow.Cells[1].Text;
            BrandTb.Value = CarList.SelectedRow.Cells[2].Text;
            ModelTb.Value = CarList.SelectedRow.Cells[3].Text;
            PriceTb.Value = CarList.SelectedRow.Cells[4].Text;
            ColorTb.Value = CarList.SelectedRow.Cells[5].Text;
            AvailableTb.SelectedValue = CarList.SelectedRow.Cells[6].Text;
        }

        protected void ClearBtn_Click(object sender, EventArgs e)
        {
            LNumberTb.Value = "";
            BrandTb.Value = "";
            ModelTb.Value = "";
            PriceTb.Value = "";
            ColorTb.Value = "";
            AvailableTb.SelectedValue = "";
            checkBox.Checked = false;
        }

        protected void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (LNumberTb.Value == "")
                {
                    ErrorMsg.InnerText = "Missing Information";
                }
                else
                {
                    string CPlateNum = LNumberTb.Value.ToString();
                    string Query = "delete from CarTbl where CPlateNum = '{0}'";
                    Query = string.Format(Query, CPlateNum);
                    Conn.SetData(Query);
                    ShowCars();
                    ErrorMsg.InnerText = "Car deleted successfully";

                    LNumberTb.Value = "";
                    BrandTb.Value = "";
                    ModelTb.Value = "";
                    PriceTb.Value = "";
                    ColorTb.Value = "";
                    AvailableTb.SelectedValue = "";
                    checkBox.Checked = false;
                }
            }
            catch (Exception Ex)
            {
                ErrorMsg.InnerText = Ex.Message;
            }
        }

        protected void EditBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (LNumberTb.Value == "" || BrandTb.Value == "" || ModelTb.Value == "" || PriceTb.Value == "" || ColorTb.Value == "" || checkBox.Checked != true)
                {
                    ErrorMsg.InnerText = "Missing Information";
                }
                else
                {
                    string CPlateNum = LNumberTb.Value.ToString();
                    string Brand = BrandTb.Value;
                    string Model = ModelTb.Value;
                    int RPrice = Convert.ToInt32(PriceTb.Value.ToString());
                    string Color = ColorTb.Value;
                    string Status = AvailableTb.SelectedValue;
                    string Query = "update CarTbl set Brand = '{0}' , Model = '{1}' , RPrice = {2} , Color = '{3}' , Status = '{4}' where CPlateNum = '{5}'";
                    Query = string.Format(Query, Brand, Model, RPrice, Color, Status, CPlateNum);
                    Conn.SetData(Query);
                    ShowCars();
                    ErrorMsg.InnerText = "Car edited successfully";

                    LNumberTb.Value = "";
                    BrandTb.Value = "";
                    ModelTb.Value = "";
                    PriceTb.Value = "";
                    ColorTb.Value = "";
                    AvailableTb.SelectedValue = "";
                    checkBox.Checked = false;
                }
            }
            catch (Exception Ex)
            {
                ErrorMsg.InnerText = Ex.Message;
            }
        }
    }
}