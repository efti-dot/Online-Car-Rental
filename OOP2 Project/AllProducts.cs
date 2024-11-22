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

    public partial class AllProducts : Form
    {
        public AllProducts()
        {
            InitializeComponent();
        }
        Product product = new Product();
        private void Back_Click(object sender, EventArgs e)
        {
            if (TitanTech.adminVerify == 1)
            {
                this.Hide();
                Admin admin = new Admin();
                admin.Show();
            }
            else
            {
                this.Hide();
                Staff staff = new Staff();
                staff.Show();
            }
        }

        private void Signout_Click(object sender, EventArgs e)
        {
            this.Hide();
            TitanTech titanTech = new TitanTech();
            titanTech.Show();
        }

        private void Show_All_Click(object sender, EventArgs e)
        {
            if (product.showAllProduct() != null)
            {
                dataGridView1.DataSource = product.showAllProduct();
            }
            else {
                MessageBox.Show("Unable to show Products!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Search_txt_TextChanged(object sender, EventArgs e)
        {
            if (product.showProductSerial(Search_txt.Text) != null)
            {
                dataGridView1.DataSource = product.showProductSerial(Search_txt.Text);
            }
        }
    }
}
