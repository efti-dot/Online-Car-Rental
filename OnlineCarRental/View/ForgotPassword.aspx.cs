using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace OnlineCarRental.View
{
    public partial class ForgotPassword : System.Web.UI.Page
    {
        Models.Functions Conn;


        protected void Page_Load(object sender, EventArgs e)
        {
            Conn = new Models.Functions();
        }

        protected void EditBtn_Click(object sender, EventArgs e)
        {
            string connectionString = WebConfigurationManager.ConnectionStrings["dbconnection"]?.ConnectionString;

            try
            {
                try
                {
                    if (connectionString != null)
                    {
                        using (SqlConnection conn = new SqlConnection(connectionString))
                        {

                            using (SqlCommand cmd = new SqlCommand("SELECT * FROM CustomerTbl WHERE CustEmail = @CustEmail"))
                            {

                                cmd.Parameters.AddWithValue("@CustEmail", exampleInputEmail.Text);
                                cmd.Connection = conn;
                                conn.Open();
                                //Response.Write("<script>alert('Connection');</script>");

                                using (SqlDataReader sqlRdr = cmd.ExecuteReader())
                                {
                                    if (sqlRdr.HasRows)
                                    {
                                        //Response.Write("<script>alert('Connection');</script>");
                                        while (sqlRdr.Read())
                                        {
                                            ///////
                                            int userId = sqlRdr.GetInt32(0);
                                            string fullName = sqlRdr.GetString(1);
                                            string emailId = exampleInputEmail.Text;
                                            var guid = Guid.NewGuid();

                                            // Close the first SqlDataReader before executing the second command
                                            sqlRdr.Close();

                                            using (SqlCommand cmd1 = new SqlCommand("INSERT INTO ForgotPassTbl VALUES(@Id, @UId, @RequestDateTime, @Email)"))
                                            {
                                                cmd1.Parameters.AddWithValue("@Id", guid);
                                                cmd1.Parameters.AddWithValue("@UId", userId);
                                                cmd1.Parameters.AddWithValue("@RequestDateTime", DateTime.Now);
                                                cmd1.Parameters.AddWithValue("@Email", emailId);
                                                cmd1.Connection = conn;
                                                cmd1.ExecuteNonQuery();

                                                Response.Write("<script>alert('Password reset link has mailed to you');</script>");

                                                string emailSubject = "Reset Password";
                                                string emailBody = "Hi, " + fullName + "and your ID is " + userId + "</h1>";
                                                emailBody += "<a href='https://localhost:44362/View/ResetPassword.aspx"  + "'>Reset Password</a>";
                                                string msg = SendMail(emailSubject, emailBody, emailId);
                                            }
                                        }
                                    }
                                    else
                                    {
                                        Response.Write("<script>alert('This Email Address does not exist in our database.');</script>");
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        Response.Write("<script>alert('Connection string not found in the web.config file.');</script>");
                    }
                }
                catch (Exception ex)
                {
                    Response.Write("<script>alert('Error: " + ex.Message + "');</script>");
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('Error: " + ex.Message + "');</script>");
            }
        }

        
        public static string SendMail(string emailSubject, string emailBody, string toEmail)
        {
            try
            {
                MailMessage PassRecMail = new MailMessage("eftih31@gmail.com", toEmail);
                PassRecMail.Body = emailBody;
                PassRecMail.IsBodyHtml = true;
                PassRecMail.Subject = emailSubject;
                PassRecMail.Priority = MailPriority.High;
                SmtpClient SMTP = new SmtpClient("smtp.gmail.com", 587);
                SMTP.DeliveryMethod = SmtpDeliveryMethod.Network;
                SMTP.UseDefaultCredentials = false;
                SMTP.UseDefaultCredentials = true;
                SMTP.Credentials = new NetworkCredential()
                {
                    UserName = "eftih31@gmail.com",
                    Password = "qbxsopkjzggzijjd"
                };
                SMTP.EnableSsl = true;
                SMTP.Send(PassRecMail);
                return "Mail Send Successfully";
            }
            catch (Exception ex)
            {
                return "Some Error Occurred.";
            }
            
        }
    }
}


