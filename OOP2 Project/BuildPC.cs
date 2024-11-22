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
    public partial class BuildPC : Form
    {
        public BuildPC()
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

        private void Motherboard_add_Click(object sender, EventArgs e)
        {
            if (product.showMotherboard(Casing_Hidden.Text, Processor_Hidden.Text) != null) {
                dataGridView1.DataSource = product.showMotherboard(Casing_Hidden.Text, Processor_Hidden.Text);
            }
        }

        private void Processor_add_Click(object sender, EventArgs e)
        {
            if (product.showProcessor(Motherboard_hidden.Text, Ram_Hidden.Text) != null)
            {
                dataGridView1.DataSource = product.showProcessor(Motherboard_hidden.Text, Ram_Hidden.Text);
            }
        }

        private void Ram_add_Click(object sender, EventArgs e)
        {
            if (product.showRam(Processor_Hidden.Text) != null) {
                dataGridView1.DataSource = product.showRam(Processor_Hidden.Text);
            }
        }

        private void PowerSupply_add_Click(object sender, EventArgs e)
        {
            if(product.showPowerSupply(GraphicsCard_Hidden.Text) != null) {
                dataGridView1.DataSource = product.showPowerSupply(GraphicsCard_Hidden.Text);
            }
        }

        private void GraphicsCard_add_Click(object sender, EventArgs e)
        {
            if (product.showGraphicsCard(PowerSupply_Hidden.Text) != null) {
                dataGridView1.DataSource = product.showGraphicsCard(PowerSupply_Hidden.Text);
            }
        }

        private void CpuCooler_add_Click(object sender, EventArgs e)
        {
            if(product.showCpuCooler(Processor_Hidden.Text) != null)
            {

                dataGridView1.DataSource = product.showCpuCooler(Processor_Hidden.Text);
            }
        }

        private void Storage_add_Click(object sender, EventArgs e)
        {
            if (product.showStorage() != null)
            {

                dataGridView1.DataSource = product.showStorage();
            }
        }

        private void Monitor_add_Click(object sender, EventArgs e)
        {
            if (product.showMonitor() != null)
            {

                dataGridView1.DataSource = product.showMonitor();
            }
        }

        private void Casing_add_Click(object sender, EventArgs e)
        {
            if (product.showCasing(Motherboard_hidden.Text) != null)
            {

                dataGridView1.DataSource = product.showCasing(Motherboard_hidden.Text);
            }
        }

        private void Keyboard_add_Click(object sender, EventArgs e)
        {
            if (product.showKeyboard() != null)
            {

                dataGridView1.DataSource = product.showKeyboard();
            }
        }

        private void Mouse_add_Click(object sender, EventArgs e)
        {
            if (product.showMouse() != null)
            {

                dataGridView1.DataSource = product.showMouse();
            }
        }

        private void Headphone_add_Click(object sender, EventArgs e)
        {
            if (product.showHeadphone() != null)
            {

                dataGridView1.DataSource = product.showHeadphone();
            }
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
                else if (Product_Type_2.Text == "Graphics Card")
                {
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

        private void Add_Product_Click(object sender, EventArgs e)
        {

            if (Quantity_txt.Text == "") {
                MessageBox.Show("Please select a product!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            if (Product_Type_2.Text == "Casing")
            {
                if (int.Parse(Quantity_txt.Text.ToString()) > 0)
                {
                    Casing_Hidden.Text = Serial_txt.Text;
                    Casing_txt.Text = Name_txt.Text;
                }
                else {
                    MessageBox.Show("Not enough product left!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else if (Product_Type_2.Text == "Cpu Cooler")
            {
                

                if (int.Parse(Quantity_txt.Text.ToString()) > 0)
                {
                    CpuCooler_Hidden.Text = Serial_txt.Text;
                    Cpu_Cooler_txt.Text = Name_txt.Text;
                }
                else
                {
                    MessageBox.Show("Not enough product left!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (Product_Type_2.Text == "Graphics Card")
            {
                

                if (int.Parse(Quantity_txt.Text.ToString()) > 0)
                {
                    GraphicsCard_Hidden.Text = Serial_txt.Text;
                    Graphics_Card_txt.Text = Name_txt.Text;
                }
                else
                {
                    MessageBox.Show("Not enough product left!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (Product_Type_2.Text == "Headphone")
            {
                

                if (int.Parse(Quantity_txt.Text.ToString()) > 0)
                {
                    Headphone_txt.Text = Name_txt.Text;
                    Headphone_Hidden.Text = Serial_txt.Text;
                }
                else
                {
                    MessageBox.Show("Not enough product left!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else if (Product_Type_2.Text == "Keyboard")
            {
                

                if (int.Parse(Quantity_txt.Text.ToString()) > 0)
                {
                    Keyboard_txt.Text = Name_txt.Text;
                    Keyboard_Hidden.Text = Serial_txt.Text;
                }
                else
                {
                    MessageBox.Show("Not enough product left!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else if (Product_Type_2.Text == "Monitor")
            {
                

                if (int.Parse(Quantity_txt.Text.ToString()) > 0)
                {
                    Monitor_txt.Text = Name_txt.Text;
                    Monitor_Hidden.Text = Serial_txt.Text;
                }
                else
                {
                    MessageBox.Show("Not enough product left!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (Product_Type_2.Text == "Mouse")
            {
                

                if (int.Parse(Quantity_txt.Text.ToString()) > 0)
                {
                    Mouse_txt.Text = Name_txt.Text;
                    Mouse_Hidden.Text = Serial_txt.Text;
                }
                else
                {
                    MessageBox.Show("Not enough product left!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (Product_Type_2.Text == "Power Supply")
            {
                

                if (int.Parse(Quantity_txt.Text.ToString()) > 0)
                {
                    Power_Supply_txt.Text = Name_txt.Text;
                    PowerSupply_Hidden.Text = Serial_txt.Text;
                }
                else
                {
                    MessageBox.Show("Not enough product left!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (Product_Type_2.Text == "Storage")
            {
                

                if (int.Parse(Quantity_txt.Text.ToString()) > 0)
                {
                    Storage_txt.Text = Name_txt.Text;
                    Storage_Hidden.Text = Serial_txt.Text;
                }
                else
                {
                    MessageBox.Show("Not enough product left!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else if (Product_Type_2.Text == "Ram")
            {
                

                if (int.Parse(Quantity_txt.Text.ToString()) > 0)
                {
                    Ram_txt.Text = Name_txt.Text;
                    Ram_Hidden.Text = Serial_txt.Text;
                }
                else
                {
                    MessageBox.Show("Not enough product left!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (Product_Type_2.Text == "Processor")
            {
                

                if (int.Parse(Quantity_txt.Text.ToString()) > 0)
                {
                    Processor_txt.Text = Name_txt.Text;
                    Processor_Hidden.Text = Serial_txt.Text;
                }
                else
                {
                    MessageBox.Show("Not enough product left!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else if (Product_Type_2.Text == "Motherboard")
            {
                

                if (int.Parse(Quantity_txt.Text.ToString()) > 0)
                {
                    Motherboard_txt.Text = Name_txt.Text;
                    Motherboard_hidden.Text = Serial_txt.Text;
                }
                else
                {
                    MessageBox.Show("Not enough product left!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


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
            Serial_txt.Clear();
            Product_Type_2.Text = "";
        }

        private void OrderPC_Click(object sender, EventArgs e)
        {
            if (Motherboard_txt.Text == "" || Processor_txt.Text == "" || Ram_txt.Text == "" || Storage_txt.Text == "" || Power_Supply_txt.Text == "")
            {
                MessageBox.Show("You'll atleast have to choose Motherboard, Processor, Ram, Storage and Power Supply to build a PC.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                if (product.orderPCB(Motherboard_hidden.Text, Processor_Hidden.Text, Ram_Hidden.Text, "", "", "", PowerSupply_Hidden.Text, GraphicsCard_Hidden.Text, CpuCooler_Hidden.Text, Storage_Hidden.Text, Monitor_Hidden.Text, Casing_Hidden.Text, Keyboard_Hidden.Text, Mouse_Hidden.Text, Headphone_Hidden.Text))
                {
                    MessageBox.Show("Congratulations! You have successfully ordered a PC!.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else {
                    MessageBox.Show("Something went wrong!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Quantity_txt_TextChanged(object sender, EventArgs e)
        {
            if (Quantity_txt.Text == "0")
            {
                Quantity_txt.ForeColor = Color.Red;
            }
            else {
                Quantity_txt.ForeColor = Color.Black ;
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

        private void button12_Click(object sender, EventArgs e)
        {
            Motherboard_txt.Clear();
            Motherboard_hidden.Clear();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Processor_txt.Clear();
            Processor_Hidden.Clear();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Ram_txt.Clear();
            Ram_Hidden.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Power_Supply_txt.Clear();
            PowerSupply_Hidden.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Graphics_Card_txt.Clear();
            GraphicsCard_Hidden.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Cpu_Cooler_txt.Clear();
            CpuCooler_Hidden.Clear();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Storage_txt.Clear();
            Storage_Hidden.Clear();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Monitor_txt.Clear();
            Monitor_Hidden.Clear();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Casing_txt.Clear();
            Casing_Hidden.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Keyboard_txt.Clear();
            Keyboard_Hidden.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Mouse_txt.Clear();
            Mouse_Hidden.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Headphone_txt.Clear();
            Headphone_Hidden.Clear();
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }
    }
}
