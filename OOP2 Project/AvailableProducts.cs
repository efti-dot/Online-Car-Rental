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
    public partial class AvailableProducts : Form
    {
        public AvailableProducts()
        {
            InitializeComponent();
        }

        Product product = new Product();
        private void Signout_Click(object sender, EventArgs e)
        {
            this.Hide();
            TitanTech titanTech = new TitanTech();
            titanTech.Show();
        }

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

        private void All_Available_Products_Click(object sender, EventArgs e)
        {
            if (product.showAllAvailableProduct() != null)
            {
                dataGridView1.DataSource = product.showAllAvailableProduct();
            }
        }

        private void Search_txt_TextChanged(object sender, EventArgs e)
        {
            if (product.showAvailableProductSerial(Search_txt.Text) != null)
            {
                dataGridView1.DataSource = product.showAvailableProductSerial(Search_txt.Text);
            }
        }
    }
}
