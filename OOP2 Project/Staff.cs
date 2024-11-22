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

namespace OOP2_Project
{
    public partial class Staff : Form
    {
        public Staff()
        {
            InitializeComponent();
        }

        private void Add_Product_Click(object sender, EventArgs e)
        {
            this.Hide();

            AddRemoveProduct addRemoveProduct = new AddRemoveProduct();
            addRemoveProduct.Show();
        }
    

        private void Signout_Click_1(object sender, EventArgs e)
        {
            this.Hide();

            TitanTech titanTech = new TitanTech();
            titanTech.Show();

            
        }

        private void Staff_Load(object sender, EventArgs e)
        {
            Available_Products.Visible = false;
            All_Product.Visible = false;
            Stockout_Products.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Available_Products.Visible = true;
            All_Product.Visible = true;
            Stockout_Products.Visible = true;
        }

        private void Stockout_Products_Click(object sender, EventArgs e)
        {
            this.Hide();
            StockoutProducts stockoutProducts = new StockoutProducts();
            stockoutProducts.Show();
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

        private void Show_Orders_Click(object sender, EventArgs e)
        {
            this.Hide();
            ShowOrder show = new ShowOrder();
            show.Show();
        }
    }
}
