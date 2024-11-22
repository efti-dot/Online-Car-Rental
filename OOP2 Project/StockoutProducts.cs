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
    public partial class StockoutProducts : Form
    {
        public StockoutProducts()
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

        private void StockoutProducts_Load(object sender, EventArgs e)
        {

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

        private void label3_Click(object sender, EventArgs e)
        {

        }

    
        private void Search_txt_TextChanged(object sender, EventArgs e)
        {
            if (product.showStockoutProductSerial(Search_txt.Text) != null)
            {
                dataGridView1.DataSource = product.showStockoutProductSerial(Search_txt.Text);
            }
        }

        private void All_Stockout_Products_Click_1(object sender, EventArgs e)
        {
            if (product.showAllStockoutProduct() != null)
            {
                dataGridView1.DataSource = product.showAllStockoutProduct();
            }
        }
    }
}
