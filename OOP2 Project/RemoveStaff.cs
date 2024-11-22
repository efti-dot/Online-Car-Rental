using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP2_Project
{
    public partial class RemoveStaff : Form
    {
        public RemoveStaff()
        {
            InitializeComponent();
        }

        AdminClass admin = new AdminClass();
        StaffClass staff = new StaffClass();
        private void RemoveStaff_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row_index = e.RowIndex;

            if (row_index >= 0)
            {
                stID.Text = dataGridView1.Rows[row_index].Cells[0].Value.ToString();
                stName.Text = dataGridView1.Rows[row_index].Cells[1].Value.ToString();
                stPhone.Text = dataGridView1.Rows[row_index].Cells[2].Value.ToString();
                stDOB.Text = dataGridView1.Rows[row_index].Cells[3].Value.ToString();
                stGender.Text = dataGridView1.Rows[row_index].Cells[4].Value.ToString();
                stEmail.Text = dataGridView1.Rows[row_index].Cells[5].Value.ToString();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Search_TextChanged(object sender, EventArgs e)
        {
            if (admin.showStaffWithName(Search.Text) != null)
            {
                dataGridView1.DataSource = admin.showStaffWithName(Search.Text);
            }
        }

        private void All_Staff_Click(object sender, EventArgs e)
        {
            if (admin.showAllStaff() != null)
            {
                dataGridView1.DataSource = admin.showAllStaff();
            }
        }

        private void DeleteStaff_Click(object sender, EventArgs e)
        {
            if (stEmail.Text != null)
            {
                staff.email = stEmail.Text;
                if (admin.removeStaff(staff))
                {
                    MessageBox.Show("Staff Removed Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = admin.showAllStaff();
                }
                else
                {
                    MessageBox.Show("Could not remove staff. Please Try Again!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else {
                MessageBox.Show("Please select a Staff", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void stID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin admin = new Admin();
            admin.Show();

        }

        private void Signout_Click(object sender, EventArgs e)
        {
            this.Hide();
            TitanTech Titan = new TitanTech();
            Titan.Show();
        }
    }
}
