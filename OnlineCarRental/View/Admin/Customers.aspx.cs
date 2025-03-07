using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineCarRental.View.Admin
{
    public partial class Customers : System.Web.UI.Page
    {
        Models.Functions Conn;
        protected void Page_Load(object sender, EventArgs e)
        {
            Conn = new Models.Functions();
            ShowCustomers();
        }

        public override void VerifyRenderingInServerForm(Control control)
        {

        }

        private void ShowCustomers()
        {
            string Query = "SELECT CustId, CustName, CustAdd, CustPhone, CustEmail, LicenceNo, NIdNo  FROM CustomerTbl";
            CustomersList.DataSource = Conn.GetData(Query);
            CustomersList.DataBind();
        }

        protected void EditBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (CustomerId.Value == "" || CustomerNameTb.Value == "" || LicenceTb.Value == "" || AddTb.Value == "" || EmailTb.Value == "" || NIdTb.Value == "" || PhoneTb.Value == "" || PassTb.Value == "" || checkBox.Checked != true)
                {
                    ErrorMsg.InnerText = "Missing Information";
                }
                else
                {
                    int CustId = Convert.ToInt32(CustomerId.Value.ToString());
                    string CustName = CustomerNameTb.Value;
                    string LicenceNo = LicenceTb.Value;
                    String CustAdd = AddTb.Value;
                    string CustEmail = EmailTb.Value;
                    string NIdNo = NIdTb.Value;
                    string CustPhone = PhoneTb.Value;
                    String CustPass = PassTb.Value;
                    string Query = "update CustomerTbl set CustName = '{0}' , CustAdd = '{1}' , CustPhone = '{2}' , CustEmail = '{3}' , LicenceNo = '{4}' , NIdNo = '{5}' where CustId = '{6}' ";
                    Query = string.Format(Query, CustName, CustAdd, CustPhone, CustEmail, LicenceNo, NIdNo, CustId);
                    Conn.SetData(Query);
                    ShowCustomers();
                    ErrorMsg.InnerText = "Customer edited successfully";

                    CustomerId.Value = "";
                    CustomerNameTb.Value = "";
                    LicenceTb.Value = "";
                    AddTb.Value = "";
                    EmailTb.Value = "";
                    NIdTb.Value = "";
                    PhoneTb.Value = "";
                    PassTb.Value = "";
                    checkBox.Enabled = false;
                }
            }
            catch (Exception Ex)
            {
                ErrorMsg.InnerText = Ex.Message;
            }
        }



        protected void SaveBtn_Click(object sender, EventArgs e)
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

                    if (PhoneTb.Value.Length != 11 || !PhoneTb.Value.All(char.IsDigit))
                    {
                        ErrorMsg.InnerText = "Phone number must be 11 digits long and contain only numbers.";
                        return;
                    }

                    if (!EmailTb.Value.EndsWith("@gmail.com", StringComparison.OrdinalIgnoreCase))
                    {
                        ErrorMsg.InnerText = "Email must be a valid Gmail address.";
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

        
        protected void CarList_SelectedIndexChanged(object sender, EventArgs e)
        {
            CustomerId.Value = CustomersList.SelectedRow.Cells[1].Text;
            CustomerNameTb.Value = CustomersList.SelectedRow.Cells[2].Text;
            LicenceTb.Value = CustomersList.SelectedRow.Cells[3].Text;
            AddTb.Value = CustomersList.SelectedRow.Cells[4].Text;
            EmailTb.Value = CustomersList.SelectedRow.Cells[5].Text;
            NIdTb.Value = CustomersList.SelectedRow.Cells[6].Text;
            PhoneTb.Value = CustomersList.SelectedRow.Cells[7].Text;
            PassTb.Value = CustomersList.SelectedRow.Cells[8].Text;
        }

        protected void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (CustomerId.Value == "")
                {
                    ErrorMsg.InnerText = "Missing Information";
                }
                else
                {
                    string CustId = CustomerId.Value.ToString();
                    string Query = "delete from CustomerTbl where CustId = '{0}'";
                    Query = string.Format(Query, CustId);
                    Conn.SetData(Query);
                    ShowCustomers();
                    ErrorMsg.InnerText = "Customer deleted successfully";

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
            }
            catch (Exception Ex)
            {
                ErrorMsg.InnerText = Ex.Message;
            }
        }

        protected void ClearBtn_Click(object sender, EventArgs e)
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
    }
}