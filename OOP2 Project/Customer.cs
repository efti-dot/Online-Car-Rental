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
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            TitanTech titan = new TitanTech();
            titan.Show();
        }

        private void Signout_Click(object sender, EventArgs e)
        {
            this.Hide();
            TitanTech titan = new TitanTech();
            titan.Show();
        }

        private void Buy_Products_Click(object sender, EventArgs e)
        {
            this.Hide();
            BuyProduct product = new BuyProduct();
            product.Show();
        }

        private void Build_A_Pc_Click(object sender, EventArgs e)
        {
            this.Hide();
            BuildPC buildPC = new BuildPC();
            buildPC.Show();
        }
    }
}
