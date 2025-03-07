using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineCarRental.View
{
    public partial class Registration : System.Web.UI.Page
    {
        Models.Functions Conn;

        protected void Page_Load(object sender, EventArgs e)
        {
            Conn = new Models.Functions();
        }

        protected void RegBtn(object sender, EventArgs e)
        {
            try
            {
                if (CustomerId.Value == "" || CustomerNameTb.Value == "" || LicenceTb.Value == "" || AddTb.Value == "" || EmailTb.Value == "" || NIdTb.Value == "" || PhoneTb.Value == "" || PassTb.Value == "" || checkBox.Checked != true)
                {
                    ErrorMsg.InnerText = "Missing Information";
                }
                else
                {
                    
                    if (Conn.UsernameExists(CustomerNameTb.Value))
                    {
                        ErrorMsg.InnerText = "Username already exists. Please choose a different username.";
                        return;
                    }

                    
                    if (Conn.EmailExists(EmailTb.Value))
                    {
                        ErrorMsg.InnerText = "Email already exists. Please use a different email address.";
                        return;
                    }

                    if (Conn.PhoneNumberExists(PhoneTb.Value))
                    {
                        ErrorMsg.InnerText = "Phone number already exists. Please use a different phone number.";
                        return;
                    }

                    if (Conn.NIDNumberExists(NIdTb.Value))
                    {
                        ErrorMsg.InnerText = "NID number already exists. Please use a different NID number.";
                        return;
                    }

                    if (Conn.LicenseNumberExists(LicenceTb.Value))
                    {
                        ErrorMsg.InnerText = "License number already exists. Please use a different license number.";
                        return;
                    }


                    if (!Conn.IsPasswordValid(PassTb.Value))
                    {
                        ErrorMsg.InnerText = "Password does not meet complexity requirements. Your password should contain minimum 7 character (one upper letter and a symbol must contain).";
                        return;
                    }

                    if (!EmailTb.Value.EndsWith("@gmail.com", StringComparison.OrdinalIgnoreCase))
                    {
                        ErrorMsg.InnerText = "Email must be a valid Gmail address.";
                        return;
                    }

                    if (PhoneTb.Value.Length != 11 || !PhoneTb.Value.All(char.IsDigit))
                    {
                        ErrorMsg.InnerText = "Phone number must be 11 digits long and contain only numbers.";
                        return;
                    }

                    // Check if NID number is unique and valid
                    if (NIdTb.Value.Length != 10 || !NIdTb.Value.All(char.IsDigit))
                    {
                        ErrorMsg.InnerText = "NID number must be 10 digits long and contain only numbers.";
                        return;
                    }

                    // Check if license number is unique and valid
                    if (LicenceTb.Value.Length != 8 || !LicenceTb.Value.All(char.IsDigit))
                    {
                        ErrorMsg.InnerText = "License number must be 8 digits long and contain only numbers.";
                        return;
                    }


                    int CustId = Convert.ToInt32(CustomerId.Value.ToString());
                    string CustName = CustomerNameTb.Value;
                    string LicenceNo = LicenceTb.Value;
                    String CustAdd = AddTb.Value;
                    string CustEmail = EmailTb.Value;
                    string NIdNo = NIdTb.Value;
                    string CustPhone = PhoneTb.Value;
                    String CustPass = PassTb.Value;

                    string Query = "insert into CustomerTbl values('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}')";
                    Query = string.Format(Query, CustId, CustName, CustAdd, CustPhone, CustEmail, LicenceNo, NIdNo, CustPass);
                    Conn.SetData(Query);

                    ErrorMsg.InnerText = "Registration successful";

                    
                    ClearFormFields();
                }
            }
            catch (Exception Ex)
            {
                ErrorMsg.InnerText = Ex.Message;
            }
        }

        
        private bool UsernameExists(string username)
        {
            return Conn.UsernameExists(username);
        }

        
        private bool EmailExists(string email)
        {
            return Conn.EmailExists(email);
        }

        
        private bool IsPasswordValid(string password)
        {
            return Conn.IsPasswordValid(password);
        }

        private bool PhoneNumberExists(string phone)
        {
            return Conn.PhoneNumberExists(phone);
        }

        
        private void ClearFormFields()
        {
            CustomerId.Value = "";
            CustomerNameTb.Value = "";
            LicenceTb.Value = "";
            AddTb.Value = "";
            EmailTb.Value = "";
            NIdTb.Value = "";
            PhoneTb.Value = "";
            PassTb.Value = "";
            checkBox.Checked = false;
        }

        protected void ClearBtn_Click(object sender, EventArgs e)
        {
            ClearFormFields();
        }

        protected void LoginBtn(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
    }
}