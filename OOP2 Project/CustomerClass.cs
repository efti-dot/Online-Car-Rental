using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Data;
using System.Diagnostics.Eventing.Reader;

namespace OOP2_Project
{
    internal class CustomerClass
    {
        public string name { get; set; }
        public string phone { get; set; }
        public string dob { get; set; }
        public string gender { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        //setting up the database connection
        SqlConnection sqlCon = new SqlConnection("Data Source=EFTI\\SQLEXPRESS;Initial Catalog=TitanTechDatabase;Integrated Security=True");



        public bool checkEmail(CustomerClass customer) {
            string query = "Select Email From [Login] Where Email='" + customer.email + "'";
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

        
        //Insert Method
        public bool insert(CustomerClass customer) {

            
            string cus = "Customer";
            string query = "insert INTO [Login] VALUES ('" + customer.email + "','" + customer.password + "','" + cus + "','" + 0 + "')";
            
            sqlCon.Open();

            SqlCommand command = new SqlCommand(query, sqlCon);
            if (sqlCon.State == ConnectionState.Open)
            {
                int rows = command.ExecuteNonQuery();
                if (rows > 0)
                {
                    query = "insert INTO Customer VALUES('" + customer.name + "','" + customer.phone + "','" + customer.dob + "','" + customer.gender + "','" + customer.email + "')";
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
            else
            {
                sqlCon.Close();
                return false;
            }
        }
    }
}
