using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace OOP2_Project
{
    public partial class ApproveCustomer : Form
    {
        public ApproveCustomer()
        {
            InitializeComponent();
        }

        SqlConnection sqlCon = new SqlConnection("Data Source=EFTI\\SQLEXPRESS;Initial Catalog=TitanTechDatabase;Integrated Security=True");
        AdminClass admin = new AdminClass();
        CustomerClass customer = new CustomerClass();
        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin admin = new Admin();
            admin.Show();
        }

        private void Signout_Click(object sender, EventArgs e)
        {
            this.Hide();
            TitanTech titanTech = new TitanTech(); 
            titanTech.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void ShowCustomer_Click(object sender, EventArgs e)
        {
            if (admin.showCustomer() != null) { 
                dataGridView1.DataSource = admin.showCustomer();
            }

        }

        private void ApproveCustomer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'titanTechDataSet.Customer' table. You can move, or remove it, as needed.
            //this.customerTableAdapter.Fill(this.titanTechDataSet.Customer);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row_index = e.RowIndex;

            if (row_index >= 0) {
                cusID.Text = dataGridView1.Rows[row_index].Cells[0].Value.ToString();
                cusName.Text = dataGridView1.Rows[row_index].Cells[1].Value.ToString();
                cusPhone.Text = dataGridView1.Rows[row_index].Cells[2].Value.ToString();
                cusDOB.Text = dataGridView1.Rows[row_index].Cells[3].Value.ToString();
                cusGender.Text = dataGridView1.Rows[row_index].Cells[4].Value.ToString();
                cusEmail.Text = dataGridView1.Rows[row_index].Cells[5].Value.ToString();
                cusStatus.Text = dataGridView1.Rows[row_index].Cells[7].Value.ToString();
            }
            
        }

        private void cusStatus_TextChanged(object sender, EventArgs e)
        {

        }

        private void cusGender_TextChanged(object sender, EventArgs e)
        {

        }

        private void cusDOB_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cusPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void cusEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void cusName_TextChanged(object sender, EventArgs e)
        {

        }

        private void cusID_TextChanged(object sender, EventArgs e)
        {

        }

        private void Approve_Click(object sender, EventArgs e)
        {
            if (cusEmail.Text == "")
            {
                MessageBox.Show("Please Select A Customer!", "Approval Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                customer.email = cusEmail.Text;
                if (admin.updateCustomer(customer))
                {
                    MessageBox.Show("Approved Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = admin.showCustomer();
                }
                else {
                    MessageBox.Show("Approval Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }
    }
}
