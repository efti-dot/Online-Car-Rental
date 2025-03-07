using OnlineCarRental.View.Customer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineCarRental.View
{
    public partial class Login : System.Web.UI.Page
    {
        Models.Functions Conn;
        protected void Page_Load(object sender, EventArgs e)
        {
            Conn = new Models.Functions();
        }

        public static string CName = "";
        public static int CustId;
        public static String CustomerName = "";
        //private object InfoMsg;

        protected void LoginBtn_Click(object sender, EventArgs e)
        {
            if (AdminRadio.Checked)
            {
                if(EmailTb.Value == "eftih31@gmail.com" && PasswordTb.Value == "qbxsopkjzggzijjd")
                {
                    CName = "Admin";
                    Response.Redirect("Admin/Home.aspx");
                }
                else
                {
                    ErrorMsg.InnerText = "Invalid Admin!!";
                }
            }
            else
            {
                string sql = "SELECT CustEmail, CustPass, CustId, CustName FROM CustomerTbl WHERE CustEmail = '{0}' AND CustPass = '{1}'";
                sql = string.Format(sql, EmailTb.Value, PasswordTb.Value);

                DataTable dt = Conn.GetData(sql);

                if (dt.Rows.Count == 0)
                {
                    ErrorMsg.InnerText = "Invalid Customer!!";
                }
                else
                {
                    CName = dt.Rows[0]["CustEmail"].ToString();
                    CustomerName = dt.Rows[0]["CustName"].ToString();
                    CustId = Convert.ToInt32(dt.Rows[0][2].ToString());
                    Response.Redirect("Customer/Home.aspx");
                }
            }
        }

        protected void RegBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Registration.aspx");
        }

        protected void ForBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("ForgotPassword.aspx");
        }
    }
}