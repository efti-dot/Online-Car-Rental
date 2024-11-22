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
    public partial class ShowOrder : Form
    {
        public ShowOrder()
        {
            InitializeComponent();
        }

        AdminClass admin = new AdminClass();
        private void Pc_Build_Orders_Click(object sender, EventArgs e)
        {
            if (admin.showPcbOrders() != null) { 
                dataGridView1.DataSource = admin.showPcbOrders();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (admin.showOrders() != null)
            {
                dataGridView1.DataSource = admin.showOrders();
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            if (TitanTech.adminVerify == 1)
            {
                this.Hide();
                Admin ad = new Admin();
                ad.Show();
            }
            else {
                this.Hide();
                Staff st = new Staff();
                st.Show();
            }
        }

        private void Signout_Click(object sender, EventArgs e)
        {
            this.Hide();
            TitanTech titan = new TitanTech();
            titan.Show();
        }


        private void Search_txt_TextChanged(object sender, EventArgs e)
        {
            

            
        }

        private void Search_txt_KeyPress(object sender, KeyPressEventArgs e)
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

        private void Search_txt_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void Search_Button_Click(object sender, EventArgs e)
        {
            if (admin.showOrdersByID(Type_combo.Text, int.Parse(Search_txt.Text.ToString())) != null)
            {
                dataGridView1.DataSource = admin.showOrdersByID(Type_combo.Text, int.Parse(Search_txt.Text.ToString()));
            }
        }
    }
}
