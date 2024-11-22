using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Collections;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.ComponentModel.Design.Serialization;

namespace OOP2_Project
{
    internal class AdminClass
    {
        SqlConnection sqlCon = new SqlConnection("Data Source=DESKTOP-C0SQF8D\\SQLEXPRESS;Initial Catalog=TitanTech;Integrated Security=True");
        public DataTable showCustomer() {

            string query = "SELECT C.CustomerID, C.Name, C.Phone, C.DOB, C.Gender, L.Email, L.Role, L.Status FROM LOGIN L INNER JOIN Customer C ON L.Email=C.Email WHERE L.ROLE='Customer' AND L.STATUS=0";
            DataTable dtbl = new DataTable();
            sqlCon.Open();
            if(sqlCon.State == ConnectionState.Open)
            {
                SqlDataAdapter sqlDa = new SqlDataAdapter(query, sqlCon);
                sqlDa.Fill(dtbl);
                sqlCon.Close();
                return dtbl;
            }
            else {
                sqlCon.Close();
                return null;
            }
            
        }



        public bool checkEmail(StaffClass staff)
        {
            string query = "Select Email From [Login] Where Email='" + staff.email + "'";
            sqlCon.Open();
            SqlCommand command = new SqlCommand(query, sqlCon);
            if (sqlCon.State == ConnectionState.Open)
            {
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    sqlCon.Close();
                    return true;
                }
                else
                {
                    sqlCon.Close();
                    return false;
                }
            }
            else
            {
                sqlCon.Close();
                return true;
            }
        }




        public bool updateCustomer(CustomerClass customer)
        {
            string query = "UPDATE LOGIN SET STATUS=1 WHERE EMAIL='"+customer.email+"' ";

            sqlCon.Open();
            if (sqlCon.State == ConnectionState.Open) {
                SqlCommand command = new SqlCommand(query, sqlCon);
                int rows = command.ExecuteNonQuery();

                if (rows > 0)
                {
                    sqlCon.Close();
                    return true;
                }
                else {
                    sqlCon.Close();
                    return false;
                }
            }
            else {
                sqlCon.Close();
                return false;
            }
        }

        public bool addStaff(StaffClass staff) {
            string st = "Staff";
            string query = "insert INTO [Login] VALUES ('" + staff.email + "','" + staff.password + "','" + st + "','" + 1 + "')";
            sqlCon.Open();
            SqlCommand command = new SqlCommand(query, sqlCon);
            if (sqlCon.State == ConnectionState.Open)
            {
                int rows = command.ExecuteNonQuery();
                if (rows > 0)
                {
                    query = "INSERT INTO STAFF VALUES('" + staff.name + "','" + staff.phone + "','" + staff.dob + "','" + staff.gender + "','" + staff.email + "','" + staff.certificate[0] +"','" + staff.certificate[1] +"','" + staff.certificate[2] +"','" + staff.certificate[3] +"','" + staff.certificate[4] +"')";
                    command = new SqlCommand(query, sqlCon);
                    rows = command.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        sqlCon.Close();
                        return true;
                    }
                    else
                    {
                        sqlCon.Close();
                        return false;
                    }
                }
                else
                {
                    sqlCon.Close();
                    return false;
                }
            }
            else {
                sqlCon.Close();
                return false;
            }
          
        }



        public DataTable showStaffWithName(string s)
        {

            string query = "SELECT StaffID, Name, Phone, DOB, Gender, Email FROM Staff WHERE Name Like '%" + s+ "%'";
            DataTable dtbl = new DataTable();
            sqlCon.Open();
            if (sqlCon.State == ConnectionState.Open)
            {
                SqlDataAdapter sqlDa = new SqlDataAdapter(query, sqlCon);
                sqlDa.Fill(dtbl);
                sqlCon.Close();
                return dtbl;
            }
            else
            {
                sqlCon.Close();
                return null;
            }

        }


        public DataTable showAllStaff()
        {

            string query = "SELECT StaffID, Name, Phone, DOB, Gender, Email FROM Staff";
            DataTable dtbl = new DataTable();
            sqlCon.Open();
            if (sqlCon.State == ConnectionState.Open)
            {
                SqlDataAdapter sqlDa = new SqlDataAdapter(query, sqlCon);
                sqlDa.Fill(dtbl);
                sqlCon.Close();
                return dtbl;
            }
            else
            {
                sqlCon.Close();
                return null;
            }

        }


        public bool removeStaff(StaffClass staff)
        {
            string query = "Delete FROM STAFF WHERE Email='"+staff.email+"'";
            sqlCon.Open();

            if (sqlCon.State == ConnectionState.Open)
            {
                SqlCommand command = new SqlCommand(query, sqlCon);
                int rows = command.ExecuteNonQuery();

                if (rows > 0)
                {
                    query = "DELETE FROM LOGIN WHERE EMAIL='" + staff.email + "'";
                    command = new SqlCommand(query, sqlCon);
                    rows = command.ExecuteNonQuery();

                    if (rows > 0)
                    {
                        sqlCon.Close();
                        return true;

                    }
                    else {
                        sqlCon.Close();
                        return false;
                    }
                }
                else {
                    sqlCon.Close();
                    return false;
                }
            }
            else {
                sqlCon.Close();
                return false;
            }
            
        }


        public DataTable showPcbOrders() {
            string query = "Select * From OrderPCB";
            sqlCon.Open();
            DataTable dtbl = new DataTable();

            if (sqlCon.State == ConnectionState.Open)
            {
                SqlDataAdapter sqlDa = new SqlDataAdapter(query, sqlCon);
                sqlDa.Fill(dtbl);
                sqlCon.Close();
                return dtbl;
            }
            else {
                sqlCon.Close();
                return null;
            }
        }


        public DataTable showOrders()
        {
            string query = "Select * From [Order]";
            sqlCon.Open();
            DataTable dtbl = new DataTable();

            if (sqlCon.State == ConnectionState.Open)
            {
                SqlDataAdapter sqlDa = new SqlDataAdapter(query, sqlCon);
                sqlDa.Fill(dtbl);
                sqlCon.Close();
                return dtbl;
            }
            else
            {
                sqlCon.Close();
                return null;
            }
        }



        public DataTable showOrdersByID(string orderType, int id)
        {
            string query = "";
            if (orderType == "Individual")
            {
                query = "Select * From [Order] Where CustomerID = " + id + "";
                sqlCon.Open();
                DataTable dtbl = new DataTable();

                if (sqlCon.State == ConnectionState.Open)
                {
                    SqlDataAdapter sqlDa = new SqlDataAdapter(query, sqlCon);
                    sqlDa.Fill(dtbl);
                    sqlCon.Close();
                    return dtbl;
                }
                else
                {
                    sqlCon.Close();
                    return null;
                }
            }
            else if (orderType == "PC Builds")
            {
                query = "Select * From OrderPCB Where CustomerID = " + id + "";
                sqlCon.Open();
                DataTable dtbl = new DataTable();

                if (sqlCon.State == ConnectionState.Open)
                {
                    SqlDataAdapter sqlDa = new SqlDataAdapter(query, sqlCon);
                    sqlDa.Fill(dtbl);
                    sqlCon.Close();
                    return dtbl;
                }
                else
                {
                    sqlCon.Close();
                    return null;
                }
            }
            else {
                return null;
            }
            
            
        }


    }

    
}
