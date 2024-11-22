using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP2_Project
{
    public partial class BuyProduct : Form
    {
        public BuyProduct()
        {
            InitializeComponent();
        }


        Product product = new Product();
        private void Product_Type_2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Name_txt.Clear();
            Brand_txt.Clear();
            Model_txt.Clear();
            Price_txt.Clear();
            Quantity_txt.Clear();
            DynamicText_1.Clear();
            DynamicText_2.Clear();
            DynamicText_3.Clear();
            DynamicText_4.Clear();
            DynamicText_5.Clear();
            pictureBox1.ImageLocation = "";



            Product_Type_2.ForeColor = Color.Black;
            //Dynamic Label and Textbox for each Product Type --------------------------------------------
            if (Product_Type_2.Text == "Motherboard")
            {
                DynamicLabel_1.Text = "Form Factor";
                DynamicLabel_1.Visible = true;
                DynamicText_1.Visible = true;

                DynamicLabel_2.Text = "Pin";
                DynamicLabel_2.Visible = true;
                DynamicText_2.Visible = true;
            }
            else if (Product_Type_2.Text == "Processor")
            {
                DynamicLabel_1.Text = "Generation";
                DynamicLabel_1.Visible = true;
                DynamicText_1.Visible = true;

                DynamicLabel_2.Text = "Pin";
                DynamicLabel_2.Visible = true;
                DynamicText_2.Visible = true;

                DynamicLabel_3.Text = "Floor Speed";
                DynamicLabel_3.Visible = true;
                DynamicText_3.Visible = true;

                DynamicLabel_4.Text = "Ceiling Speed";
                DynamicLabel_4.Visible = true;
                DynamicText_4.Visible = true;

                DynamicLabel_5.Text = "Ram Generation";
                DynamicLabel_5.Visible = true;
                DynamicText_5.Visible = true;

            }
            else if (Product_Type_2.Text == "Ram")
            {
                DynamicLabel_1.Text = "Generation";
                DynamicLabel_1.Visible = true;
                DynamicText_1.Visible = true;

                DynamicLabel_2.Text = "Bus Speed";
                DynamicLabel_2.Visible = true;
                DynamicText_2.Visible = true;

                DynamicLabel_3.Text = "Memory";
                DynamicLabel_3.Visible = true;
                DynamicText_3.Visible = true;

                DynamicLabel_4.Visible = false;
                DynamicText_4.Visible = false;

                DynamicLabel_5.Visible = false;
                DynamicText_5.Visible = false;

            }

            else if (Product_Type_2.Text == "Storage")
            {
                DynamicLabel_1.Text = "Storage Type";
                DynamicLabel_1.Visible = true;
                DynamicText_1.Visible = true;

                DynamicLabel_2.Text = "Memory";
                DynamicLabel_2.Visible = true;
                DynamicText_2.Visible = true;

                DynamicLabel_3.Text = "RPM";
                DynamicLabel_3.Visible = true;
                DynamicText_3.Visible = true;


                DynamicLabel_4.Visible = false;
                DynamicText_4.Visible = false;

                DynamicLabel_5.Visible = false;
                DynamicText_5.Visible = false;

            }
            else if (Product_Type_2.Text == "Power Supply")
            {
                DynamicLabel_1.Text = "Form Factor";
                DynamicLabel_1.Visible = true;
                DynamicText_1.Visible = true;

                DynamicLabel_2.Text = "Wattage";
                DynamicLabel_2.Visible = true;
                DynamicText_2.Visible = true;

                DynamicLabel_3.Text = "Certification";
                DynamicLabel_3.Visible = true;
                DynamicText_3.Visible = true;


                DynamicLabel_4.Visible = false;
                DynamicText_4.Visible = false;

                DynamicLabel_5.Visible = false;
                DynamicText_5.Visible = false;

            }
            else if (Product_Type_2.Text == "Mouse")
            {
                DynamicLabel_1.Text = "Mouse Type";
                DynamicLabel_1.Visible = true;
                DynamicText_1.Visible = true;

                DynamicLabel_2.Text = "Switch";
                DynamicLabel_2.Visible = true;
                DynamicText_2.Visible = true;


                DynamicLabel_3.Visible = false;
                DynamicText_3.Visible = false;

                DynamicLabel_4.Visible = false;
                DynamicText_4.Visible = false;

                DynamicLabel_5.Visible = false;
                DynamicText_5.Visible = false;

            }

            else if (Product_Type_2.Text == "Monitor")
            {
                DynamicLabel_1.Text = "Resolution";
                DynamicLabel_1.Visible = true;
                DynamicText_1.Visible = true;

                DynamicLabel_2.Text = "Refresh Rate";
                DynamicLabel_2.Visible = true;
                DynamicText_2.Visible = true;

                DynamicLabel_3.Text = "Panel";
                DynamicLabel_3.Visible = true;
                DynamicText_3.Visible = true;

                DynamicLabel_4.Text = "Response Time";
                DynamicLabel_4.Visible = true;
                DynamicText_4.Visible = true;

                DynamicLabel_5.Text = "Screen Size";
                DynamicLabel_5.Visible = true;
                DynamicText_5.Visible = true;

            }
            else if (Product_Type_2.Text == "Keyboard")
            {
                DynamicLabel_1.Text = "Keyboard Type";
                DynamicLabel_1.Visible = true;
                DynamicText_1.Visible = true;

                DynamicLabel_2.Text = "Switch";
                DynamicLabel_2.Visible = true;
                DynamicText_2.Visible = true;

                DynamicLabel_3.Text = "Form Factor";
                DynamicLabel_3.Visible = true;
                DynamicText_3.Visible = true;


                DynamicLabel_4.Visible = false;
                DynamicText_4.Visible = false;

                DynamicLabel_5.Visible = false;
                DynamicText_5.Visible = false;

            }
            else if (Product_Type_2.Text == "Headphone")
            {
                DynamicLabel_1.Text = "Headphone Type";
                DynamicLabel_1.Visible = true;
                DynamicText_1.Visible = true;

                DynamicLabel_2.Text = "Port";
                DynamicLabel_2.Visible = true;
                DynamicText_2.Visible = true;

                DynamicLabel_3.Text = "Sensitivity";
                DynamicLabel_3.Visible = true;
                DynamicText_3.Visible = true;


                DynamicLabel_4.Visible = false;
                DynamicText_4.Visible = false;

                DynamicLabel_5.Visible = false;
                DynamicText_5.Visible = false;

            }
            else if (Product_Type_2.Text == "Graphics Card")
            {
                DynamicLabel_1.Text = "Distributor";
                DynamicLabel_1.Visible = true;
                DynamicText_1.Visible = true;

                DynamicLabel_2.Text = "Generation";
                DynamicLabel_2.Visible = true;
                DynamicText_2.Visible = true;

                DynamicLabel_3.Text = "Memory";
                DynamicLabel_3.Visible = true;
                DynamicText_3.Visible = true;

                DynamicLabel_4.Text = "Wattage Requirement";
                DynamicLabel_4.Visible = true;
                DynamicText_4.Visible = true;


                DynamicLabel_5.Visible = false;
                DynamicText_5.Visible = false;

            }
            else if (Product_Type_2.Text == "Cpu Cooler")
            {
                DynamicLabel_1.Text = "Cooler Type";
                DynamicLabel_1.Visible = true;
                DynamicText_1.Visible = true;

                DynamicLabel_2.Text = "Size";
                DynamicLabel_2.Visible = true;
                DynamicText_2.Visible = true;

                DynamicLabel_3.Text = "Processor Type";
                DynamicLabel_3.Visible = true;
                DynamicText_3.Visible = true;

                DynamicLabel_4.Text = "Fan Speed";
                DynamicLabel_4.Visible = true;
                DynamicText_4.Visible = true;


                DynamicLabel_5.Visible = false;
                DynamicText_5.Visible = false;

            }

            else if (Product_Type_2.Text == "Casing")
            {
                DynamicLabel_1.Text = "Form Factor";
                DynamicLabel_1.Visible = true;
                DynamicText_1.Visible = true;

                DynamicLabel_2.Text = "Total Fan Slot";
                DynamicLabel_2.Visible = true;
                DynamicText_2.Visible = true;

                DynamicLabel_3.Text = "Included Fan Number";
                DynamicLabel_3.Visible = true;
                DynamicText_3.Visible = true;


                DynamicLabel_4.Visible = false;
                DynamicText_4.Visible = false;

                DynamicLabel_5.Visible = false;
                DynamicText_5.Visible = false;

            }
            //---------------------------------------------------------------------------------
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row_index = e.RowIndex;

            if (row_index >= 0)
            {
                Product_Type_2.Text = dataGridView1.Rows[row_index].Cells[0].Value.ToString();
                Name_txt.Text = dataGridView1.Rows[row_index].Cells[1].Value.ToString();
                Brand_txt.Text = dataGridView1.Rows[row_index].Cells[2].Value.ToString();
                Model_txt.Text = dataGridView1.Rows[row_index].Cells[3].Value.ToString();
                Price_txt.Text = dataGridView1.Rows[row_index].Cells[4].Value.ToString();
                Quantity_txt.Text = dataGridView1.Rows[row_index].Cells[5].Value.ToString();
                pictureBox1.ImageLocation = dataGridView1.Rows[row_index].Cells[6].Value.ToString();
                Serial_txt.Text = dataGridView1.Rows[row_index].Cells[7].Value.ToString();
                if (Product_Type_2.Text == "Casing")
                {
                    DynamicText_1.Text = dataGridView1.Rows[row_index].Cells[8].Value.ToString();
                    DynamicText_2.Text = dataGridView1.Rows[row_index].Cells[9].Value.ToString();
                    DynamicText_3.Text = dataGridView1.Rows[row_index].Cells[10].Value.ToString();
                }
                else if (Product_Type_2.Text == "Cpu Cooler")
                {
                    DynamicText_1.Text = dataGridView1.Rows[row_index].Cells[8].Value.ToString();
                    DynamicText_2.Text = dataGridView1.Rows[row_index].Cells[9].Value.ToString();
                    DynamicText_3.Text = dataGridView1.Rows[row_index].Cells[10].Value.ToString();
                    DynamicText_4.Text = dataGridView1.Rows[row_index].Cells[11].Value.ToString();
                }
                else if (Product_Type_2.Text == "Graphics Card") {
                    DynamicText_1.Text = dataGridView1.Rows[row_index].Cells[8].Value.ToString();
                    DynamicText_2.Text = dataGridView1.Rows[row_index].Cells[9].Value.ToString();
                    DynamicText_3.Text = dataGridView1.Rows[row_index].Cells[10].Value.ToString();
                    DynamicText_4.Text = dataGridView1.Rows[row_index].Cells[11].Value.ToString();
                }
                else if (Product_Type_2.Text == "Headphone")
                {
                    DynamicText_1.Text = dataGridView1.Rows[row_index].Cells[8].Value.ToString();
                    DynamicText_2.Text = dataGridView1.Rows[row_index].Cells[9].Value.ToString();
                    DynamicText_3.Text = dataGridView1.Rows[row_index].Cells[10].Value.ToString();
                }
                else if (Product_Type_2.Text == "Keyboard")
                {
                    DynamicText_1.Text = dataGridView1.Rows[row_index].Cells[8].Value.ToString();
                    DynamicText_2.Text = dataGridView1.Rows[row_index].Cells[9].Value.ToString();
                    DynamicText_3.Text = dataGridView1.Rows[row_index].Cells[10].Value.ToString();
                }

                else if (Product_Type_2.Text == "Monitor")
                {
                    DynamicText_1.Text = dataGridView1.Rows[row_index].Cells[8].Value.ToString();
                    DynamicText_2.Text = dataGridView1.Rows[row_index].Cells[9].Value.ToString();
                    DynamicText_3.Text = dataGridView1.Rows[row_index].Cells[10].Value.ToString();
                    DynamicText_4.Text = dataGridView1.Rows[row_index].Cells[11].Value.ToString();
                    DynamicText_5.Text = dataGridView1.Rows[row_index].Cells[12].Value.ToString();
                }
                else if (Product_Type_2.Text == "Mouse")
                {
                    DynamicText_1.Text = dataGridView1.Rows[row_index].Cells[8].Value.ToString();
                    DynamicText_2.Text = dataGridView1.Rows[row_index].Cells[9].Value.ToString();
                }
                else if (Product_Type_2.Text == "Power Supply")
                {
                    DynamicText_1.Text = dataGridView1.Rows[row_index].Cells[8].Value.ToString();
                    DynamicText_2.Text = dataGridView1.Rows[row_index].Cells[9].Value.ToString();
                    DynamicText_3.Text = dataGridView1.Rows[row_index].Cells[10].Value.ToString();
                }
                else if (Product_Type_2.Text == "Storage")
                {
                    DynamicText_1.Text = dataGridView1.Rows[row_index].Cells[8].Value.ToString();
                    DynamicText_2.Text = dataGridView1.Rows[row_index].Cells[9].Value.ToString();
                    DynamicText_3.Text = dataGridView1.Rows[row_index].Cells[10].Value.ToString();
                }
                else if (Product_Type_2.Text == "Ram")
                {
                    DynamicText_1.Text = dataGridView1.Rows[row_index].Cells[8].Value.ToString();
                    DynamicText_2.Text = dataGridView1.Rows[row_index].Cells[9].Value.ToString();
                    DynamicText_3.Text = dataGridView1.Rows[row_index].Cells[10].Value.ToString();
                }
                else if (Product_Type_2.Text == "Processor")
                {
                    DynamicText_1.Text = dataGridView1.Rows[row_index].Cells[8].Value.ToString();
                    DynamicText_2.Text = dataGridView1.Rows[row_index].Cells[9].Value.ToString();
                    DynamicText_3.Text = dataGridView1.Rows[row_index].Cells[10].Value.ToString();
                    DynamicText_4.Text = dataGridView1.Rows[row_index].Cells[11].Value.ToString();
                    DynamicText_5.Text = dataGridView1.Rows[row_index].Cells[12].Value.ToString();
                }
                else if (Product_Type_2.Text == "Motherboard")
                {
                    DynamicText_1.Text = dataGridView1.Rows[row_index].Cells[8].Value.ToString();
                    DynamicText_2.Text = dataGridView1.Rows[row_index].Cells[9].Value.ToString();
                }
            }
        }

        private void Product_Type_1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (product.showProductType(Product_Type_1.Text) != null) {
                dataGridView1.DataSource = product.showProductType(Product_Type_1.Text);
            }
        }

        private void Order_Click(object sender, EventArgs e)
        {
            if (Quantity_txt.Text == "")
            {
                MessageBox.Show("Please Select A Product!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {

                int allOk = 1;

                if (Order_Quantity_txt.Text == "" || Order_Quantity_txt.Text == "Please enter the quantity!") {
                    Order_Quantity_txt.Text = "Please enter the quantity!";
                    Order_Quantity_txt.ForeColor = Color.Red;
                    allOk = 0;
                }
                if (Delivery_Address_txt.Text == "" || Delivery_Address_txt.Text == "Please enter the delivery address!") {
                    Delivery_Address_txt.Text = "Please enter the delivery address!";
                    Delivery_Address_txt.ForeColor= Color.Red;
                    allOk = 0;
                }

                if (allOk == 1) {

                    

                    if (int.Parse(Order_Quantity_txt.Text.ToString()) <= 0) {
                        MessageBox.Show("Please select at least 1 quantity of the product!", "Order Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else {
                        if (int.Parse(Quantity_txt.Text.ToString()) - int.Parse(Order_Quantity_txt.Text.ToString()) < 0)
                        {
                            MessageBox.Show("Not enough quantity left!", "Order Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else {


                            
                            
                            if (product.orderProduct(Product_Type_2.Text, Name_txt.Text,int.Parse(Price_txt.Text.ToString()), Serial_txt.Text, int.Parse(Quantity_txt.Text.ToString()), int.Parse(Order_Quantity_txt.Text.ToString()), Delivery_Address_txt.Text))
                            {
                                MessageBox.Show("Ordered Successfully!", "Order", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                if (product.showProductType(Product_Type_1.Text) != null) {
                                    dataGridView1.DataSource = product.showProductType(Product_Type_1.Text);
                                }


                                Product_Type_2.Text = "";
                                Name_txt.Clear();
                                Brand_txt.Clear();
                                Model_txt.Clear();
                                Price_txt.Clear();
                                Quantity_txt.Clear();
                                Serial_txt.Clear();
                                DynamicText_1.Clear();
                                DynamicText_2.Clear();
                                DynamicText_3.Clear();
                                DynamicText_4.Clear();
                                DynamicText_5.Clear();
                                pictureBox1.ImageLocation = "";
                                Order_Quantity_txt.Clear();
                                Delivery_Address_txt.Clear();
                            }
                            else {
                                
                                MessageBox.Show("Could not place Order!", "Order", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }

                }
            }
        }

        private void Order_Quantity_txt_TextChanged(object sender, EventArgs e)
        {
            Order_Quantity_txt.ForeColor = Color.Black;
            Total_Price_txt.Text = (int.Parse(Price_txt.Text.ToString()) * int.Parse(Order_Quantity_txt.Text.ToString())).ToString();
        }

        private void Order_Quantity_txt_Click(object sender, EventArgs e)
        {
            if (Order_Quantity_txt.Text == "Please enter the quantity!") {
                Order_Quantity_txt.Clear();
            }
            
        }

        private void Delivery_Address_txt_TextChanged(object sender, EventArgs e)
        {
            Delivery_Address_txt.ForeColor = Color.Black;
        }

        private void Delivery_Address_txt_Click(object sender, EventArgs e)
        {
            if (Delivery_Address_txt.Text == "Please enter the delivery address!")
            {
                Delivery_Address_txt.Clear();
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Customer customer = new Customer();
            customer.Show();
        }

        private void Signout_Click(object sender, EventArgs e)
        {
            this.Hide();
            TitanTech titan = new TitanTech();
            titan.Show();
        }
    }
}
