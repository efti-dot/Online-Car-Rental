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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }


        private void Signout_Click(object sender, EventArgs e)
        {
            this.Hide();
            TitanTech titanTech = new TitanTech();
            titanTech.Show();
        }

  
        private void Remove_Staff_Click(object sender, EventArgs e)
        {
            this.Hide();
            RemoveStaff removeStaff = new RemoveStaff();
            removeStaff.Show();
        }

        private void Add_Staff_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddStaff addStaff = new AddStaff();
            addStaff.Show();
        }
        private void addproduct_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddRemoveProduct addProduct = new AddRemoveProduct();
            addProduct.Show();
        }

  
        private void All_Product_Click(object sender, EventArgs e)
        {
            this.Hide();
            AllProducts allProducts = new AllProducts();
            allProducts.Show();
        }

        private void Available_Products_Click(object sender, EventArgs e)
        {
            this.Hide();
            AvailableProducts availableProducts = new AvailableProducts();
            availableProducts.Show();
        }

        private void Stockout_Products_Click(object sender, EventArgs e)
        {
            this.Hide();
            StockoutProducts stockoutProducts = new StockoutProducts();
            stockoutProducts.Show();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            Available_Products.Visible = false;
            All_Product.Visible = false;
            Stockout_Products.Visible = false;
        }

        private void Products_Click(object sender, EventArgs e)
        {
            Available_Products.Visible = true;
            All_Product.Visible = true;
            Stockout_Products.Visible = true;
        }

        private void Approve_Customer_Click(object sender, EventArgs e)
        {
            this.Hide();
            ApproveCustomer approveCustomer = new ApproveCustomer();
            approveCustomer.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            RemoveStaff removeStaff = new RemoveStaff();
            removeStaff.Show();
        }

        private void Show_Orders_Click(object sender, EventArgs e)
        {
            this.Hide();
            ShowOrder showOrder = new ShowOrder();
            showOrder.Show();
        }
    }
}
