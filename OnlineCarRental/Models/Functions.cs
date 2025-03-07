using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace OnlineCarRental.Models
{
    public class Functions
    {
        private SqlConnection conn;
        private SqlCommand cmd;
        private DataTable dt;
        private string ConnStr;
        private SqlDataAdapter sda;

        public Functions() 
        {
            ConnStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\eftih\Documents\CarRentalDbASP.mdf;Integrated Security=True;Connect Timeout=30";
            conn = new SqlConnection(ConnStr);
            cmd = new SqlCommand();
            cmd.Connection = conn;
        }

        public DataTable GetData(String Query)
        {
            dt = new DataTable();
            sda = new SqlDataAdapter(Query, ConnStr);
            sda.Fill(dt);
            return dt;
        }

        public int SetData(String Query)
        {
            int rcnt = 0;
            if(conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            cmd.CommandText = Query;
            rcnt = cmd.ExecuteNonQuery();
            conn.Close();
            return rcnt;
        }

        public bool UsernameExists(string username)
        {
            string query = $"SELECT COUNT(*) FROM CustomerTbl WHERE CustName = '{username}'";
            int count = Convert.ToInt32(GetData(query).Rows[0][0]);
            return count > 0;
        }

        public bool EmailExists(string email)
        {
            string query = $"SELECT COUNT(*) FROM CustomerTbl WHERE CustEmail = '{email}'";
            int count = Convert.ToInt32(GetData(query).Rows[0][0]);
            return count > 0;
        }

        public bool PhoneNumberExists(string phoneNumber)
        {
            string query = $"SELECT COUNT(*) FROM CustomerTbl WHERE CustPhone = '{phoneNumber}'";
            int count = Convert.ToInt32(GetData(query).Rows[0][0]);
            return count > 0;
        }

        public bool NIDNumberExists(string nidNumber)
        {
            string query = $"SELECT COUNT(*) FROM CustomerTbl WHERE NIdNo = '{nidNumber}'";
            int count = Convert.ToInt32(GetData(query).Rows[0][0]);
            return count > 0;
        }

        public bool LicenseNumberExists(string licenseNumber)
        {
            string query = $"SELECT COUNT(*) FROM CustomerTbl WHERE LicenceNo = '{licenseNumber}'";
            int count = Convert.ToInt32(GetData(query).Rows[0][0]);
            return count > 0;
        }


        public bool IsPasswordValid(string password)
        {
            
            // For example, check minimum length, at least one uppercase letter, and at least one symbol
            bool hasUpperCase = false;
            bool hasSymbol = false;

            foreach (char c in password)
            {
                if (char.IsUpper(c))
                {
                    hasUpperCase = true;
                }
                else if (char.IsSymbol(c) || char.IsPunctuation(c))
                {
                    hasSymbol = true;
                }
            }

            return password.Length >= 7 && hasUpperCase && hasSymbol;
        }


    }
}