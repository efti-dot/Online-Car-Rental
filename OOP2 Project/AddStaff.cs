using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP2_Project
{
    public partial class AddStaff : Form
    {
        public AddStaff()
        {
            InitializeComponent();
        }

        StaffClass staff = new StaffClass();
        AdminClass admin = new AdminClass();
        private void AddStaff_Load(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
            Admin admin = new Admin();
            admin.Show();
        }

        private void Signout_Click(object sender, EventArgs e)
        {
            this.Close();
            TitanTech titanTech = new TitanTech();
            titanTech.Show();
        }


        private void Add_Staff_Click(object sender, EventArgs e)
        {
            int allOk = 1;

            
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

            if (Male_Radio.Checked == false && Female_Radio.Checked == false && Other_Radio.Checked == false)
            {
                gender = 0;
            }

            //---------------------------------------------------------------------------------------------------------------------------------------------------------













            //Checking criterias for Password, Email & Phone ------------------------------------------------------------------------------------------------------------
            if (name == 1 && email == 1 && phone == 1 && pass == 1 && gender == 1)
            {

                //Condition for the password to be accepted by the system ---------------------------------------
                string password = Password.Text.ToString();
                int upper = 0;
                int number = 0;
                int specialchar = 0;


                for (int i = 0; i < password.Length; i++)
                {

                    //Checking for Uppercase Letter in the password 
                    if (System.Convert.ToInt32(password[i]) >= 65 && System.Convert.ToInt32(password[i]) <= 90)
                    {
                        upper = 1;
                    }

                    //Checking for Number in the password
                    if (System.Convert.ToInt32(password[i]) >= 48 && System.Convert.ToInt32(password[i]) <= 57)
                    {
                        number = 1;
                    }

                    //Checking for Special Character in the password
                    if ((System.Convert.ToInt32(password[i]) >= 33 && System.Convert.ToInt32(password[i]) <= 47) || (System.Convert.ToInt32(password[i]) >= 58 && System.Convert.ToInt32(password[i]) <= 64))
                    {
                        specialchar = 1;
                    }
                }

                if (upper == 0 || number == 0 || specialchar == 0)
                {
                    MessageBox.Show("Password should contain atleast 1 upper case letter(A-Z), 1 number (0-9), 1 special character(!@#$%...)", "Password Criteria", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    allOk = 0;
                }




                //Condition for the email to be accepted by the system --------------------------------------------
                int addtherate = 0;

                string email_string = Email.Text.ToString();

                for (int i = 0; i < email_string.Length; i++)
                {
                    if (email_string[i] == '@')
                    {
                        addtherate = 1;
                        break;
                    }
                }

                if (addtherate == 0)
                {
                    MessageBox.Show("Incorrect Email", "Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    allOk = 0;
                }
                
            }

            //---------------------------------------------------------------------------------------------------------------------------------------------------------------






            if (allOk == 1) {
                staff.initializeCertificate();
                staff.name = Name_txt.Text;
                staff.phone = Phone.Text;
                staff.email = Email.Text;
                staff.dob = DOB.Text;
                staff.password = Password.Text;
                if (certificationCount == 0)
                {
                    staff.certificate[0] = ((TextBox)this.Controls["dlgt1"]).Text;
                }
                else if (certificationCount == 1)
                {
                    staff.certificate[0] = ((TextBox)this.Controls["dlgt1"]).Text;
                    staff.certificate[1] = ((TextBox)this.Controls["dlgt2"]).Text;
                }
                else if (certificationCount == 2)
                {
                    staff.certificate[0] = ((TextBox)this.Controls["dlgt1"]).Text;
                    staff.certificate[1] = ((TextBox)this.Controls["dlgt2"]).Text;
                    staff.certificate[2] = ((TextBox)this.Controls["dlgt3"]).Text;
                }
                else if (certificationCount == 3)
                {
                    staff.certificate[0] = ((TextBox)this.Controls["dlgt1"]).Text;
                    staff.certificate[1] = ((TextBox)this.Controls["dlgt2"]).Text;
                    staff.certificate[2] = ((TextBox)this.Controls["dlgt3"]).Text;
                    staff.certificate[3] = ((TextBox)this.Controls["dlgt4"]).Text;
                }
                else if (certificationCount == 4) {
                    staff.certificate[0] = ((TextBox)this.Controls["dlgt1"]).Text;
                    staff.certificate[1] = ((TextBox)this.Controls["dlgt2"]).Text;
                    staff.certificate[2] = ((TextBox)this.Controls["dlgt3"]).Text;
                    staff.certificate[3] = ((TextBox)this.Controls["dlgt4"]).Text;
                    staff.certificate[4] = ((TextBox)this.Controls["dlgt5"]).Text;
                }


                if (Male_Radio.Checked)
                {
                    staff.gender = "Male";
                }
                else if (Female_Radio.Checked)
                {
                    staff.gender = "Female";
                }
                else
                {
                    staff.gender = "Other";
                }

                if (admin.checkEmail(staff))
                {
                    MessageBox.Show("Email already exists!", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else {
                    if (admin.addStaff(staff))
                    {
                        MessageBox.Show("Staff Added Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Registration Failed!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                
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
        private void Name_txt_TextChanged(object sender, EventArgs e)
        {
            if (Name_txt.Text != "Please enter your name!")
            {
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


        static int certificationCount = 0;
        static int i = 1;
        private void dlgt_Click(object sender, EventArgs e)
        {


            if (certificationCount + 1 < 6)
            {
                if (((TextBox)this.Controls["dlgt" + (certificationCount + 1).ToString()]).Text == "")
                {
                    MessageBox.Show("Please fill every available certification first", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    certificationCount += 1;
                    int buttonBaseX = 702;
                    int buttonBaseY = 533;

                    int textboxBaseX = 361;
                    int textboxBaseY = 502;

                    int addStaffBaseX = 673;
                    int addStaffBaseY = 580;

                    int labelBaseX = 220;
                    int labelBaseY = 502;

                    int formBaseX = 1044;
                    int formBaseY = 718;

                    int signOutBaseX = 904;
                    int signOutBaseY = 617;

                    int backBaseX = 28;
                    int backBaseY = 617;
                    if (certificationCount <= 4)
                    {
                        Add_Staff.Location = new Point(addStaffBaseX, addStaffBaseY + (certificationCount * 47));
                        Back.Location = new Point(backBaseX, backBaseY + (certificationCount * 47));
                        Signout.Location = new Point(signOutBaseX, signOutBaseY + (certificationCount * 47));
                        this.Size = new Size(formBaseX, formBaseY + (certificationCount * 47));


                        AddStaff.i += 1;
                        dlgt.Location = new Point(buttonBaseX, buttonBaseY + (47 * certificationCount));

                        TextBox textBox = new TextBox();
                        textBox.Name = "dlgt" + AddStaff.i.ToString();
                        textBox.Location = new Point(textboxBaseX, textboxBaseY + (certificationCount * 47));
                        textBox.Size = dlgt1.Size;
                        textBox.Multiline = true;
                        this.Controls.Add(textBox);

                        Label label = new Label();
                        label.Name = "Certification" + certificationCount.ToString();
                        label.Location = new Point(labelBaseX, labelBaseY + (certificationCount * 47));
                        label.Text = "Certification " + AddStaff.i.ToString() + ".";
                        label.Size = new Size(135, 40);
                        label.BackColor = Color.Transparent;
                        label.Font = new Font("Candara", 14.25f, FontStyle.Bold);
                        label.ForeColor = Color.White;
                        this.Controls.Add(label);
                    }
                }
            }
            else {
                MessageBox.Show("Maximum Certificate Reached", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            
        }

        private void Phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
