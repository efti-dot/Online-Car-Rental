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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        CustomerClass customer = new CustomerClass();

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            TitanTech titanTech = new TitanTech();
            titanTech.Show();
            
        }

        private void Signup_Click(object sender, EventArgs e)
        {
            int allOk1 = 0;
            int allOk2 = 0;


            //Checking if all the input fields are filled -------------------------------------------------------------------------------------------------------------
            int name = 1, email = 1, phone = 1, pass = 1, gender = 1;
            if (Name_txt.Text == "" || Name_txt.Text == "Please enter your name!")
            {
                Name_txt.Text = "Please enter your name!";
                Name_txt.ForeColor = Color.Red;
                name = 0;
            }


            if (Password.Text == "" || Password.Text == "Please enter your password!")
            {
                Password.Text = "Please enter your password!";
                Password.ForeColor = Color.Red;
                Password.UseSystemPasswordChar = true;
                pass = 0;
            }

            if (Phone.Text == "" || Phone.Text == "Please enter your phone number!")
            {
                Phone.Text = "Please enter your phone number!";
                Phone.ForeColor = Color.Red;
                phone = 0;
            }

            if (Email.Text == "" || Email.Text == "Please enter your email!")
            {
                Email.Text = "Please enter your email!";
                Email.ForeColor = Color.Red;
                email = 0;
            }

            if (Male_Radio.Checked == false && Female_Radio.Checked == false && Other_Radio.Checked == false){
                gender = 0;
            }

            //---------------------------------------------------------------------------------------------------------------------------------------------------------


            if (name == 1 && email == 1 && phone == 1 && pass == 1 && gender == 0)
            {
                MessageBox.Show("Please select your gender!", "Select Gender", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            //Checking criterias for Password, Email------------------------------------------------------------------------------------------------------------
            if (name == 1 && email == 1 && phone==1 && pass == 1 && gender == 1) {

                //Condition for the password to be accepted by the system ---------------------------------------
                string password = Password.Text.ToString();
                int upper = 0;
                int number = 0;
                int specialchar = 0;


                for (int i = 0; i < password.Length; i++) {

                    //Checking for Uppercase Letter in the password 
                    if (System.Convert.ToInt32(password[i]) >= 65 && System.Convert.ToInt32(password[i]) <= 90)
                    {
                        upper = 1;
                    }

                    //Checking for Number in the password
                    if (System.Convert.ToInt32(password[i]) >= 48 && System.Convert.ToInt32(password[i]) <= 57) {
                        number = 1;
                    }

                    //Checking for Special Character in the password
                    if ((System.Convert.ToInt32(password[i]) >= 33 && System.Convert.ToInt32(password[i]) <= 47) || (System.Convert.ToInt32(password[i]) >= 58 && System.Convert.ToInt32(password[i]) <= 64)) {
                        specialchar = 1;
                    }
                }

                if (upper == 0 || number == 0 || specialchar == 0)
                {
                    MessageBox.Show("Password should contain atleast 1 upper case letter(A-Z), 1 number (0-9), 1 special character(!@#$%...)", "Password Criteria", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    allOk1 = 0;
                }
                else {
                    allOk1 = 1;
                }




                //Condition for the email to be accepted by the system --------------------------------------------
                int addtherate = 0;

                string email_string = Email.Text.ToString();

                for (int i = 0; i < email_string.Length; i++) {
                    if (email_string[i] == '@') {
                        addtherate = 1;
                        break;
                    }
                }

                if (addtherate == 0)
                {
                    MessageBox.Show("Incorrect Email", "Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    allOk2 = 0;
                }
                else {
                    allOk2 = 1;
                }
            }

            //---------------------------------------------------------------------------------------------------------------------------------------------------------------



            if (allOk1 == 1 && allOk2 == 1) {
                customer.name = Name_txt.Text;
                customer.phone = Phone.Text;
                customer.email = Email.Text;
                customer.dob = DateOfBirth.Text;
                customer.password = Password.Text;
                if (Male_Radio.Checked)
                {
                    customer.gender = "Male";
                }
                else if (Female_Radio.Checked)
                {
                    customer.gender = "Female";
                }
                else {
                    customer.gender = "Other";
                }

                if (customer.checkEmail(customer))
                {
                    MessageBox.Show("Email already exists!", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else {
                    if (customer.insert(customer))
                    {
                        MessageBox.Show("Registration Successful! Please wait for ADMIN approval.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        TitanTech titanTech = new TitanTech();
                        titanTech.Show();
                    }
                    else
                    {
                        MessageBox.Show("Registration Failed!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            

        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void Male_Radio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Name_txt_TextChanged(object sender, EventArgs e)
        {
            if (Name_txt.Text != "Please enter your name!") {
                Name_txt.ForeColor = Color.Black;
            }
        }

        private void Phone_TextChanged(object sender, EventArgs e)
        {
            if (Phone.Text != "Please enter your phone number!")
            {
                Phone.ForeColor = Color.Black;
            }
        }

        private void Email_TextChanged(object sender, EventArgs e)
        {
            if (Email.Text != "Please enter your email!")
            {
                Email.ForeColor = Color.Black;
            }
        }

        private void Password_TextChanged(object sender, EventArgs e)
        {
            if (Password.Text != "Please enter your password!")
            {
                Password.ForeColor = Color.Black;
                Password.UseSystemPasswordChar = false;
                Password.PasswordChar = '*';
            }
        }


       
        private void Phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Condition for the phone number textbox to only accept numerical values ----------------------------
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as System.Windows.Forms.TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void Name_txt_Click(object sender, EventArgs e)
        {
            if (Name_txt.Text == "Please enter your name!")
            {
                Name_txt.Clear();
            }
            
        }

        private void Phone_Click(object sender, EventArgs e)
        {
            if (Phone.Text == "Please enter your phone number!")
            {
                Phone.Clear();
            }
            
        }

        private void Email_Click(object sender, EventArgs e)
        {
            if (Email.Text == "please enter your email!")
            {
                Email.Clear();
            }
            
        }

        private void Password_Click(object sender, EventArgs e)
        {
            if (Password.Text == "Please enter your password!")
            {
                Password.Clear();
            }
        }
    }
}
