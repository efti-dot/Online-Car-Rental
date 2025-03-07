using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Configuration;
using System.Drawing;

namespace OnlineCarRental.View
{
    
    
    public partial class ResetPassword : System.Web.UI.Page
    {
        private static int UserId;
        private static Guid guid;
        static string DBCS = ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString;
        Models.Functions Conn;
        protected void Page_Load(object sender, EventArgs e)
        {
            Conn = new Models.Functions();
            Customer = Login.CustId;


        }
        int Customer;

        


        protected void btnResetPass_Click(object sender, EventArgs e)
        {

            try
            {
                guid = new Guid(Request.QueryString["Guid"]);
                if (guid != null)
                {
                    using (SqlConnection conn = new SqlConnection(DBCS))
                    {
                        using (SqlCommand cmd = new SqlCommand("select * from ForgotPassTbl where Email = @Email"))
                        {
                            cmd.Parameters.AddWithValue("@Email", guid);
                            cmd.Connection = conn;
                            conn.Open();
                            using (SqlDataReader sqlRdr = cmd.ExecuteReader())
                            {
                                if (sqlRdr.HasRows)
                                {
                                    while (sqlRdr.Read())
                                    {
                                        UserId = sqlRdr.GetInt32(1);
                                        //Console.WriteLine(UserId);
                                    }
                                }
                                else
                                    Response.Redirect("~/Default.aspx", false);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                //Response.Redirect("~/Default.aspx", false);
                ErrorMsg.InnerText = Login.CustId + " " + ex.Message;
            }



            
        }

        protected void ResetBtn_Click(object sender, EventArgs e)
        {

            try
            {
                if (UId.Value == "" || inputPassword.Value == "" || inputRepeatPassword.Value == "" )
                {
                    ErrorMsg.InnerText = "Missing Information";
                }
                else if(inputPassword.Value == inputRepeatPassword.Value)
                {

                    if (!Conn.IsPasswordValid(inputPassword.Value))
                    {
                        ErrorMsg.InnerText = "Password does not meet complexity requirements. Your password should contain minimum 7 character (one upper letter and a symbol must contain).";
                        return;
                    }
                    else
                    {
                        string CustId = UId.Value.ToString();
                        string CustPass = inputPassword.Value;

                        string Query = "update CustomerTbl set CustPass = '{0}' where CustId = '{1}'";
                        Query = string.Format(Query, CustPass, CustId);
                        Conn.SetData(Query);

                        //ErrorMsg.InnerText = "Pass edited successfully";
                        Response.Write(UserId + "<script>alert( 'Password successfully updated.');</script>");
                        //Response.Redirect("Login.aspx", false);
                    }
                }
                else
                {
                    ErrorMsg.InnerText = "Password doesn't match";
                }
            }
            catch (Exception Ex)
            {
                ErrorMsg.InnerText = Ex.Message;
            }
            
        }

        private bool IsPasswordValid(string password)
        {
            return Conn.IsPasswordValid(password);
        }

        protected void LoginBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx", false);
        }
    }
}




