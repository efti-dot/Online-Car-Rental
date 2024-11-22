using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace OOP2_Project
{

    public partial class TitanTech : Form
    {
        
        public TitanTech()
        {

            InitializeComponent();
        }

        public static int adminVerify;
        public static int staffVerify;
        public static string cEmail;

        SqlConnection sqlCon = new SqlConnection("Data Source=EFTI\\SQLEXPRESS;Initial Catalog=TitanTechDatabase;Integrated Security=True");
        private void password_TextChanged(object sender, EventArgs e)
        {
            Password.ForeColor = Color.Black;
            Password.UseSystemPasswordChar = false;
            Password.PasswordChar = '*';
        }

        //Disabling the Login button if there isn't any input in the Login textbox-----------------------------------
        private void email_TextChanged(object sender, EventArgs e)
        {
           
            
            if (email.Text == "")
            {
                Login.Enabled = false;
            }
            else {
                Login.Enabled = true;
            }
            

        }


        private void TitanTech_Load(object sender, EventArgs e)
        {

            Login.Enabled = false;
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void Signup_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register reg = new Register();
            reg.Show();
        }

        private void Login_Click_1(object sender, EventArgs e)
        {
            //Checking if the password text field is empty
            if (Password.Text == "" || Password.Text == "Please enter your password!") {
                Password.Text = "Please enter your password!";
                Password.ForeColor = Color.Red;
                Password.UseSystemPasswordChar = true;
            }
            else
            {
                string query = "Select Password From Login Where Email='"+email.Text+"'";
                string pass;
                SqlCommand command = new SqlCommand(query, sqlCon);
                sqlCon.Open();


                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();
                    pass = reader.GetString(0);
                    reader.Close();

                    if (Password.Text == pass)
                    {
                        //Fetching the Status from the Login table
                        
                        query = "Select Status From Login Where Email='" + email.Text + "'";
                        bool status;
                        
                        command = new SqlCommand(query, sqlCon);

                        reader = command.ExecuteReader();

                        if(reader.HasRows)
                        {
                            reader.Read();
                            status = reader.GetBoolean(0);
                            reader.Close();

                            if (status) {
                                MessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


                                query = "Select Role From Login Where Email = '" + email.Text + "'";
                                
                                command = new SqlCommand(query, sqlCon);
                                string role;
                                reader = command.ExecuteReader();

                                if (reader.HasRows)
                                {
                                    reader.Read();
                                    role = reader.GetString(0);
                                    reader.Close();

                                    if (role == "Staff")
                                    {
                                        cEmail = null;
                                        adminVerify = 0;
                                        staffVerify = 1;
                                        this.Hide();
                                        Staff staff = new Staff();
                                        staff.Show();

                                    }
                                    else if (role == "Admin")
                                    {
                                        cEmail = null;
                                        adminVerify = 1;
                                        staffVerify = 0;
                                        this.Hide();
                                        Admin admin = new Admin();
                                        admin.Show();
                                    }
                                    else {
                                        cEmail = email.Text;
                                        this.Hide();
                                        Customer customer = new Customer();
                                        customer.Show();
                                    }
                                    
                                } 
                            }
                            else { 
                                MessageBox.Show("Your account has not been approved by an admin!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                            }
                        }

                    }   
                    else
                    {
                        MessageBox.Show("Wrong Password!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                else {
                    MessageBox.Show("Wrong Email!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                sqlCon.Close();
            }
        }

        private void Password_Click(object sender, EventArgs e)
        {
            Password.Clear();
        }
    }
}
