using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace OOP2_Project
{
    public partial class AddRemoveProduct : Form
    {
        public AddRemoveProduct()
        {
            InitializeComponent();
            this.dataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView1_DataError);
        }

        Product product = new Product();

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

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
            else {
                this.Hide();
                Staff staff = new Staff();
                staff.Show();
            }
            
        }

        private void AddRemoveProduct_Load(object sender, EventArgs e)
        {

        }

        private void searchProduct_Click(object sender, EventArgs e)
        {

        }

     

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Upload_Picture_Click(object sender, EventArgs e)
        {
            String imageLocation = "";
            try
            { 
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All Files(*.*)|*.*";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                    imageLocation = dialog.FileName;
                    pictureBox1.ImageLocation = imageLocation;
                }
            }catch (Exception)
            {
                MessageBox.Show("Something went wrong!", "Upload Fialed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        





        private void Add_Product_Click(object sender, EventArgs e)
        {
            int allOk = 1;
            if (Product_Type_2.Text == "" || Product_Type_2.Text == "Please select a product type!")
            {
                Product_Type_2.Text = "Please select a product type!";
                Product_Type_2.ForeColor = Color.Red;
                allOk = 0;
            }
            else
            {
                if (Name_txt.Text == "")
                {
                    Name_txt.Text = "Please enter product name";
                    Name_txt.ForeColor = Color.Red;
                    allOk = 0;
                }
                if (Brand_txt.Text == "")
                {
                    Brand_txt.Text = "Please enter a Brand";
                    Brand_txt.ForeColor = Color.Red;
                    allOk = 0;
                }
                if (Model_txt.Text == "")
                {
                    Model_txt.Text = "Please enter the product model";
                    Model_txt.ForeColor = Color.Red;
                    allOk = 0;
                }
                if (Price_txt.Text == "")
                {
                    Price_txt.Text = "Please enter the price";
                    Price_txt.ForeColor = Color.Red;
                    allOk = 0;
                }
                if (Quantity_txt.Text == "")
                {
                    Quantity_txt.Text = "Please enter the quantity";
                    Quantity_txt.ForeColor = Color.Red;
                    allOk = 0;
                }
                if (Serial_txt.Text == "")
                {
                    Serial_txt.Text = "Please enter the serial number";
                    Serial_txt.ForeColor = Color.Red;
                    allOk = 0;

                }



                if (Product_Type_2.Text == "Motherboard")
                {
                    if (DynamicText_1.Text == "")
                    {
                        DynamicText_1.Text = "Please enter the form factor";
                        DynamicText_1.ForeColor = Color.Red;
                        allOk = 0;
                    }
                    if (DynamicText_2.Text == "")
                    {
                        DynamicText_2.Text = "Please enter the pin number";
                        DynamicText_2.ForeColor = Color.Red;
                        allOk = 0;
                    }
                }
                else if (Product_Type_2.Text == "Processor")
                {

                    if (DynamicText_1.Text == "")
                    {
                        DynamicText_1.Text = "Please enter the generation";
                        DynamicText_1.ForeColor = Color.Red;
                        allOk = 0;
                    }
                    if (DynamicText_2.Text == "")
                    {
                        DynamicText_2.Text = "Please enter the pin number";
                        DynamicText_2.ForeColor = Color.Red;
                        allOk = 0;
                    }

                    if (DynamicText_3.Text == "")
                    {
                        DynamicText_3.Text = "Please enter the floor speed";
                        DynamicText_3.ForeColor = Color.Red;
                        allOk = 0;
                    }
                    if (DynamicText_4.Text == "")
                    {
                        DynamicText_4.Text = "Please enter the ceiling speed";
                        DynamicText_4.ForeColor = Color.Red;
                        allOk = 0;
                    }

                    if (DynamicText_5.Text == "")
                    {
                        DynamicText_5.Text = "Please enter the ram generation";
                        DynamicText_5.ForeColor = Color.Red;
                        allOk = 0;
                    }

                }
                else if (Product_Type_2.Text == "Ram")
                {
                    if (DynamicText_1.Text == "")
                    {
                        DynamicText_1.Text = "Please enter the generation";
                        DynamicText_1.ForeColor = Color.Red;
                        allOk = 0;
                    }
                    if (DynamicText_2.Text == "")
                    {
                        DynamicText_2.Text = "Please enter the bus speed";
                        DynamicText_2.ForeColor = Color.Red;
                        allOk = 0;
                    }

                    if (DynamicText_3.Text == "")
                    {
                        DynamicText_3.Text = "Please enter the memory";
                        DynamicText_3.ForeColor = Color.Red;
                        allOk = 0;
                    }


                }

                else if (Product_Type_2.Text == "Storage")
                {
                    if (DynamicText_1.Text == "")
                    {
                        DynamicText_1.Text = "Please enter the storage type";
                        DynamicText_1.ForeColor = Color.Red;
                        allOk = 0;
                    }
                    if (DynamicText_2.Text == "")
                    {
                        DynamicText_2.Text = "Please enter the memory";
                        DynamicText_2.ForeColor = Color.Red;
                        allOk = 0;
                    }

                    if (DynamicText_3.Text == "")
                    {
                        DynamicText_3.Text = "Please enter the rpm";
                        DynamicText_3.ForeColor = Color.Red;
                        allOk = 0;
                    }


                }
                else if (Product_Type_2.Text == "Power Supply")
                {

                    if (DynamicText_1.Text == "")
                    {
                        DynamicText_1.Text = "Please enter the form factor";
                        DynamicText_1.ForeColor = Color.Red;
                        allOk = 0;
                    }
                    if (DynamicText_2.Text == "")
                    {
                        DynamicText_2.Text = "Please enter the wattage";
                        DynamicText_2.ForeColor = Color.Red;
                        allOk = 0;
                    }

                    if (DynamicText_3.Text == "")
                    {
                        DynamicText_3.Text = "Please enter the certification";
                        DynamicText_3.ForeColor = Color.Red;
                        allOk = 0;
                    }


                }
                else if (Product_Type_2.Text == "Mouse")
                {

                    if (DynamicText_1.Text == "")
                    {
                        DynamicText_1.Text = "Please enter the mouse type";
                        DynamicText_1.ForeColor = Color.Red;
                        allOk = 0;
                    }
                    if (DynamicText_2.Text == "")
                    {
                        DynamicText_2.Text = "Please enter the switch";
                        DynamicText_2.ForeColor = Color.Red;
                        allOk = 0;
                    }


                }

                else if (Product_Type_2.Text == "Monitor")
                {
                    if (DynamicText_1.Text == "")
                    {
                        DynamicText_1.Text = "Please enter the resolution";
                        DynamicText_1.ForeColor = Color.Red;
                        allOk = 0;
                    }
                    if (DynamicText_2.Text == "")
                    {
                        DynamicText_2.Text = "Please enter the refresh rate";
                        DynamicText_2.ForeColor = Color.Red;
                        allOk = 0;
                    }

                    if (DynamicText_3.Text == "")
                    {
                        DynamicText_3.Text = "Please enter the panel";
                        DynamicText_3.ForeColor = Color.Red;
                        allOk = 0;
                    }
                    if (DynamicText_4.Text == "")
                    {
                        DynamicText_4.Text = "Please enter the Response Time";
                        DynamicText_4.ForeColor = Color.Red;
                        allOk = 0;
                    }

                    if (DynamicText_5.Text == "")
                    {
                        DynamicText_5.Text = "Please enter the Screen Size";
                        DynamicText_5.ForeColor = Color.Red;
                        allOk = 0;
                    }


                }
                else if (Product_Type_2.Text == "Keyboard")
                {
                    if (DynamicText_1.Text == "")
                    {
                        DynamicText_1.Text = "Please enter the Keyboard Type";
                        DynamicText_1.ForeColor = Color.Red;
                        allOk = 0;
                    }
                    if (DynamicText_2.Text == "")
                    {
                        DynamicText_2.Text = "Please enter the Switch";
                        DynamicText_2.ForeColor = Color.Red;
                        allOk = 0;
                    }

                    if (DynamicText_3.Text == "")
                    {
                        DynamicText_3.Text = "Please enter the Form Factor";
                        DynamicText_3.ForeColor = Color.Red;
                        allOk = 0;
                    }


                }
                else if (Product_Type_2.Text == "Headphone")
                {
                    if (DynamicText_1.Text == "")
                    {
                        DynamicText_1.Text = "Please enter the Headphone Type";
                        DynamicText_1.ForeColor = Color.Red;
                        allOk = 0;
                    }
                    if (DynamicText_2.Text == "")
                    {
                        DynamicText_2.Text = "Please enter the Port";
                        DynamicText_2.ForeColor = Color.Red;
                        allOk = 0;
                    }

                    if (DynamicText_3.Text == "")
                    {
                        DynamicText_3.Text = "Please enter the Sensitivity";
                        DynamicText_3.ForeColor = Color.Red;
                        allOk = 0;
                    }



                }
                else if (Product_Type_2.Text == "Graphics Card")
                {
                    if (DynamicText_1.Text == "")
                    {
                        DynamicText_1.Text = "Please enter the Distributor";
                        DynamicText_1.ForeColor = Color.Red;
                        allOk = 0;
                    }
                    if (DynamicText_2.Text == "")
                    {
                        DynamicText_2.Text = "Please enter the Generation";
                        DynamicText_2.ForeColor = Color.Red;
                        allOk = 0;
                    }

                    if (DynamicText_3.Text == "")
                    {
                        DynamicText_3.Text = "Please enter the Memory";
                        DynamicText_3.ForeColor = Color.Red;
                        allOk = 0;
                    }
                    if (DynamicText_4.Text == "")
                    {
                        DynamicText_4.Text = "Please enter the Wattage Requirement";
                        DynamicText_4.ForeColor = Color.Red;
                        allOk = 0;
                    }

                }
                else if (Product_Type_2.Text == "Cpu Cooler")
                {
                    if (DynamicText_1.Text == "")
                    {
                        DynamicText_1.Text = "Please enter the Cooler Type";
                        DynamicText_1.ForeColor = Color.Red;
                        allOk = 0;
                    }
                    if (DynamicText_2.Text == "")
                    {
                        DynamicText_2.Text = "Please enter the Size";
                        DynamicText_2.ForeColor = Color.Red;
                        allOk = 0;
                    }

                    if (DynamicText_3.Text == "")
                    {
                        DynamicText_3.Text = "Please enter the Processor Type";
                        DynamicText_3.ForeColor = Color.Red;
                        allOk = 0;
                    }
                    if (DynamicText_4.Text == "")
                    {
                        DynamicText_4.Text = "Please enter the Fan Speed";
                        DynamicText_4.ForeColor = Color.Red;
                        allOk = 0;
                    }

                }

                else if (Product_Type_2.Text == "Casing")
                {
                    if (DynamicText_1.Text == "")
                    {
                        DynamicText_1.Text = "Please enter the Form Factor";
                        DynamicText_1.ForeColor = Color.Red;
                        allOk = 0;
                    }
                    if (DynamicText_2.Text == "")
                    {
                        DynamicText_2.Text = "Please enter the Total Fan Slot";
                        DynamicText_2.ForeColor = Color.Red;
                        allOk = 0;
                    }

                    if (DynamicText_3.Text == "")
                    {
                        DynamicText_3.Text = "Please enter the Included Fan Number";
                        DynamicText_3.ForeColor = Color.Red;
                        allOk = 0;
                    }

                }

                if (DynamicLabel_1.Visible == false) {
                    allOk = 0;
                }

            }






            if (allOk == 1) {

                if (Product_Type_2.Text == "Motherboard")
                {
                    Motherboard motherboard = new Motherboard();
                    motherboard.productType = "Motherboard";
                    motherboard.brand = Brand_txt.Text;
                    motherboard.model = Model_txt.Text;
                    motherboard.name = Name_txt.Text;
                    motherboard.price = int.Parse(Price_txt.Text.ToString());
                    motherboard.availableQuantity = int.Parse(Quantity_txt.Text.ToString());
                    motherboard.image = pictureBox1.ImageLocation;
                    motherboard.serialKey = Serial_txt.Text;
                    motherboard.formFactor = DynamicText_1.Text;
                    motherboard.pin = DynamicText_2.Text;

                    if (product.addProduct(motherboard))
                    {
                        MessageBox.Show("Successfully Added the Product!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    }
                    else {
                        MessageBox.Show("Something went wrong. Could not add the Product!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else if (Product_Type_2.Text == "Processor")
                {
                    Processor processor = new Processor();
                    processor.productType = "Processor";
                    processor.brand = Brand_txt.Text;
                    processor.model = Model_txt.Text;
                    processor.name = Name_txt.Text;
                    processor.price = int.Parse(Price_txt.Text.ToString());
                    processor.availableQuantity = int.Parse(Quantity_txt.Text.ToString());
                    processor.image = pictureBox1.ImageLocation;
                    processor.serialKey = Serial_txt.Text;
                    processor.generation = DynamicText_1.Text;
                    processor.pin = DynamicText_2.Text;
                    processor.floorSpeed = DynamicText_3.Text;
                    processor.ceilingSpeed = DynamicText_4.Text;
                    processor.ramGeneration = DynamicText_5.Text;

                    if (product.addProduct(processor))
                    {
                        MessageBox.Show("Successfully Added the Product!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    }
                    else
                    {
                        MessageBox.Show("Something went wrong. Could not add the Product!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else if (Product_Type_2.Text == "Ram")
                {
                   Ram ram = new Ram();
                    ram.productType = "Ram";
                    ram.brand = Brand_txt.Text;
                    ram.model = Model_txt.Text;
                    ram.name = Name_txt.Text;
                    ram.price = int.Parse(Price_txt.Text.ToString());
                    ram.availableQuantity = int.Parse(Quantity_txt.Text.ToString());
                    ram.image = pictureBox1.ImageLocation;
                    ram.serialKey = Serial_txt.Text;
                    ram.generation = DynamicText_1.Text;
                    ram.busSpeed = DynamicText_2.Text;
                    ram.memory = DynamicText_3.Text;

                    if (product.addProduct(ram))
                    {
                        MessageBox.Show("Successfully Added the Product!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                        dataGridView1.DataSource = product.showAllProduct();
                    }
                    else
                    {
                        MessageBox.Show("Something went wrong. Could not add the Product!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }

                else if (Product_Type_2.Text == "Storage")
                {
                    Storage storage = new Storage();
                    storage.productType = "Storage";
                    storage.brand = Brand_txt.Text;
                    storage.model = Model_txt.Text;
                    storage.name = Name_txt.Text;
                    storage.price = int.Parse(Price_txt.Text.ToString());
                    storage.availableQuantity = int.Parse(Quantity_txt.Text.ToString());
                    storage.image = pictureBox1.ImageLocation;
                    storage.serialKey = Serial_txt.Text;
                    storage.storageType = DynamicText_1.Text;
                    storage.memory = DynamicText_2.Text;
                    storage.rpm = DynamicText_3.Text;

                    if (product.addProduct(storage))
                    {
                        MessageBox.Show("Successfully Added the Product!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    }
                    else
                    {
                        MessageBox.Show("Something went wrong. Could not add the Product!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else if (Product_Type_2.Text == "Power Supply")
                {
                    PowerSupply powerSupply = new PowerSupply();
                    powerSupply.productType = "Power Supply";
                    powerSupply.brand = Brand_txt.Text;
                    powerSupply.model = Model_txt.Text;
                    powerSupply.name = Name_txt.Text;
                    powerSupply.price = int.Parse(Price_txt.Text.ToString());
                    powerSupply.availableQuantity = int.Parse(Quantity_txt.Text.ToString());
                    powerSupply.image = pictureBox1.ImageLocation;
                    powerSupply.serialKey = Serial_txt.Text;
                    powerSupply.formFactor = DynamicText_1.Text;
                    powerSupply.wattage = DynamicText_2.Text;
                    powerSupply.certification = DynamicText_3.Text;

                    if (product.addProduct(powerSupply))
                    {
                        MessageBox.Show("Successfully Added the Product!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    }
                    else
                    {
                        MessageBox.Show("Something went wrong. Could not add the Product!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else if (Product_Type_2.Text == "Mouse")
                {
                    Mouse mouse = new Mouse();
                    mouse.productType = "Mouse";
                    mouse.brand = Brand_txt.Text;
                    mouse.model = Model_txt.Text;
                    mouse.name = Name_txt.Text;
                    mouse.price = int.Parse(Price_txt.Text.ToString());
                    mouse.availableQuantity = int.Parse(Quantity_txt.Text.ToString());
                    mouse.image = pictureBox1.ImageLocation;
                    mouse.serialKey = Serial_txt.Text;
                    mouse.type = DynamicText_1.Text;
                    mouse.mouseSwitch = DynamicText_2.Text;

                    if (product.addProduct(mouse))
                    {
                        MessageBox.Show("Successfully Added the Product!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    }
                    else
                    {
                        MessageBox.Show("Something went wrong. Could not add the Product!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                else if (Product_Type_2.Text == "Monitor")
                {
                    Monitor monitor = new Monitor();
                    monitor.productType = "Monitor";
                    monitor.brand = Brand_txt.Text;
                    monitor.model = Model_txt.Text;
                    monitor.name = Name_txt.Text;
                    monitor.price = int.Parse(Price_txt.Text.ToString());
                    monitor.availableQuantity = int.Parse(Quantity_txt.Text.ToString());
                    monitor.image = pictureBox1.ImageLocation;
                    monitor.serialKey = Serial_txt.Text;
                    monitor.resolution = DynamicText_1.Text;
                    monitor.refreshRate = DynamicText_2.Text;
                    monitor.panel = DynamicText_3.Text;
                    monitor.responseTime = DynamicText_4.Text;
                    monitor.screenSize = DynamicText_5.Text;

                    if (product.addProduct(monitor))
                    {
                        MessageBox.Show("Successfully Added the Product!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    }
                    else
                    {
                        MessageBox.Show("Something went wrong. Could not add the Product!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (Product_Type_2.Text == "Keyboard")
                {
                    Keyboard keyboard = new Keyboard();
                    keyboard.productType = "Keyboard";
                    keyboard.brand = Brand_txt.Text;
                    keyboard.model = Model_txt.Text;
                    keyboard.name = Name_txt.Text;
                    keyboard.price = int.Parse(Price_txt.Text.ToString());
                    keyboard.availableQuantity = int.Parse(Quantity_txt.Text.ToString());
                    keyboard.image = pictureBox1.ImageLocation;
                    keyboard.serialKey = Serial_txt.Text;
                    keyboard.type = DynamicText_1.Text;
                    keyboard.keyboardSwitch = DynamicText_2.Text;
                    keyboard.formFactor = DynamicText_3.Text;

                    if (product.addProduct(keyboard))
                    {
                        MessageBox.Show("Successfully Added the Product!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    }
                    else
                    {
                        MessageBox.Show("Something went wrong. Could not add the Product!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else if (Product_Type_2.Text == "Headphone")
                {
                    Headphone headphone = new Headphone();
                    headphone.productType = "Headphone";
                    headphone.brand = Brand_txt.Text;
                    headphone.model = Model_txt.Text;
                    headphone.name = Name_txt.Text;
                    headphone.price = int.Parse(Price_txt.Text.ToString());
                    headphone.availableQuantity = int.Parse(Quantity_txt.Text.ToString());
                    headphone.image = pictureBox1.ImageLocation;
                    headphone.serialKey = Serial_txt.Text;
                    headphone.type = DynamicText_1.Text;
                    headphone.portType = DynamicText_2.Text;
                    headphone.sensitivity = DynamicText_3.Text;

                    if (product.addProduct(headphone))
                    {
                        MessageBox.Show("Successfully Added the Product!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    }
                    else
                    {
                        MessageBox.Show("Something went wrong. Could not add the Product!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }


                else if (Product_Type_2.Text == "Graphics Card")
                {
                    GraphicsCard graphicsCard = new GraphicsCard();
                    graphicsCard.productType = "Graphics Card";
                    graphicsCard.brand = Brand_txt.Text;
                    graphicsCard.model = Model_txt.Text;
                    graphicsCard.name = Name_txt.Text;
                    graphicsCard.price = int.Parse(Price_txt.Text.ToString());
                    graphicsCard.availableQuantity = int.Parse(Quantity_txt.Text.ToString());
                    graphicsCard.image = pictureBox1.ImageLocation;
                    graphicsCard.serialKey = Serial_txt.Text;
                    graphicsCard.distributor = DynamicText_1.Text;
                    graphicsCard.generation = DynamicText_2.Text;
                    graphicsCard.memory = DynamicText_3.Text;
                    graphicsCard.wattageRequirement = int.Parse(DynamicText_4.Text.ToString());

                    if (product.addProduct(graphicsCard))
                    {
                        MessageBox.Show("Successfully Added the Product!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    }
                    else
                    {
                        MessageBox.Show("Something went wrong. Could not add the Product!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }


                else if (Product_Type_2.Text == "Cpu Cooler")
                {
                    CpuCooler cpuCooler = new CpuCooler();
                    cpuCooler.productType = "Cpu Cooler";
                    cpuCooler.brand = Brand_txt.Text;
                    cpuCooler.model = Model_txt.Text;
                    cpuCooler.name = Name_txt.Text;
                    cpuCooler.price = int.Parse(Price_txt.Text.ToString());
                    cpuCooler.availableQuantity = int.Parse(Quantity_txt.Text.ToString());
                    cpuCooler.image = pictureBox1.ImageLocation;
                    cpuCooler.serialKey = Serial_txt.Text;
                    cpuCooler.coolerType = DynamicText_1.Text;
                    cpuCooler.size = DynamicText_2.Text;
                    cpuCooler.processorBrand = DynamicText_3.Text;
                    cpuCooler.fanSpeed = DynamicText_4.Text;

                    if (product.addProduct(cpuCooler))
                    {
                        MessageBox.Show("Successfully Added the Product!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    }
                    else
                    {
                        MessageBox.Show("Something went wrong. Could not add the Product!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }

                else if (Product_Type_2.Text == "Casing")
                {
                    Casing casing = new Casing();
                    casing.productType = "Casing";
                    casing.brand = Brand_txt.Text;
                    casing.model = Model_txt.Text;
                    casing.name = Name_txt.Text;
                    casing.price = int.Parse(Price_txt.Text.ToString());
                    casing.availableQuantity = int.Parse(Quantity_txt.Text.ToString());
                    casing.image = pictureBox1.ImageLocation;
                    casing.serialKey = Serial_txt.Text;
                    casing.formFactor = DynamicText_1.Text;
                    casing.totalFanSlot = int.Parse(DynamicText_2.Text.ToString());
                    casing.includedFan = int.Parse(DynamicText_3.Text.ToString());
                    if (product.addProduct(casing))
                    {
                        MessageBox.Show("Successfully Added the Product!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    }
                    else
                    {
                        MessageBox.Show("Something went wrong. Could not add the Product!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }

                
            }
        }


        private void Product_Type_2_SelectedIndexChanged(object sender, EventArgs e)
        {
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
            else if (Product_Type_2.Text == "Processor") {
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

        private void label6_Click(object sender, EventArgs e)
        {

        }

       

        private void label7_Click(object sender, EventArgs e)
        {

        }

        

        private void Name_txt_TextChanged(object sender, EventArgs e)
        {
            Name_txt.ForeColor = Color.Black;
        }

        private void Brand_txt_TextChanged(object sender, EventArgs e)
        {
            Brand_txt.ForeColor = Color.Black;
        }

        private void Model_txt_TextChanged(object sender, EventArgs e)
        {
            Model_txt.ForeColor = Color.Black;
        }
        private void Price_txt_TextChanged(object sender, EventArgs e)
        {
            Price_txt.ForeColor = Color.Black;
        }
        private void Quantity_txt_TextChanged(object sender, EventArgs e)
        {
            Quantity_txt.ForeColor = Color.Black;
        }

        private void Serial_txt_TextChanged(object sender, EventArgs e)
        {
            Serial_txt.ForeColor = Color.Black;
        }

        private void DynamicText_1_TextChanged(object sender, EventArgs e)
        {
            DynamicText_1.ForeColor = Color.Black;
        }

        private void DynamicText_2_TextChanged(object sender, EventArgs e)
        {
            DynamicText_2.ForeColor = Color.Black;
        }

        private void DynamicText_3_TextChanged(object sender, EventArgs e)
        {
            DynamicText_3.ForeColor = Color.Black;
        }

        private void DynamicText_4_TextChanged(object sender, EventArgs e)
        {
            DynamicText_4.ForeColor = Color.Black;
        }

        private void DynamicText_5_TextChanged(object sender, EventArgs e)
        {
            DynamicText_5.ForeColor = Color.Black;
        }

        //Clearing the Warning text fields
        private void Name_txt_Click(object sender, EventArgs e)
        {
            if(Name_txt.ForeColor == Color.Red)
            {
                Name_txt.Clear();
            }
        }

        private void Brand_txt_Click(object sender, EventArgs e)
        {
            if (Brand_txt.ForeColor == Color.Red)
            {
                Brand_txt.Clear();
            }
        }

        private void Model_txt_Click(object sender, EventArgs e)
        {
            if (Model_txt.ForeColor == Color.Red)
            {
                Model_txt.Clear();
            }
        }

        private void Price_txt_Click(object sender, EventArgs e)
        {
            if (Price_txt.ForeColor == Color.Red)
            {
                Price_txt.Clear();
            }
        }

        private void Quantity_txt_Click(object sender, EventArgs e)
        {
            if (Quantity_txt.ForeColor == Color.Red)
            {
                Quantity_txt.Clear();
            }
        }

        private void Serial_txt_Click(object sender, EventArgs e)
        {
            if (Serial_txt.ForeColor == Color.Red)
            {
                Serial_txt.Clear();
            }
        }

        private void DynamicText_1_Click(object sender, EventArgs e)
        {
            if (DynamicText_1.ForeColor == Color.Red)
            {
                DynamicText_1.Clear();
            }
        }

        private void DynamicText_2_Click(object sender, EventArgs e)
        {
            if (DynamicText_2.ForeColor == Color.Red)
            {
                DynamicText_2.Clear();
            }
        }

        private void DynamicText_3_Click(object sender, EventArgs e)
        {
            if (DynamicText_3.ForeColor == Color.Red)
            {
                DynamicText_3.Clear();
            }
        }

        private void DynamicText_4_Click(object sender, EventArgs e)
        {
            if (DynamicText_4.ForeColor == Color.Red)
            {
                DynamicText_4.Clear();
            }
        }

        private void DynamicText_5_Click(object sender, EventArgs e)
        {
            if (DynamicText_5.ForeColor == Color.Red)
            {
                DynamicText_5.Clear();
            }
        }

        private void Clear_All_Click(object sender, EventArgs e)
        {
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
        }

        private void Price_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as System.Web.UI.WebControls.TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

       

        private void Remove_Product_Click(object sender, EventArgs e)
        {
            if (Serial_txt.Text == "" || Serial_txt.Text == "Please enter the serial number")
            {
                MessageBox.Show("Please select a product to remove!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                if (Product_Type_2.Text == "Cpu Cooler")
                {
                    if (product.removeProduct(Serial_txt.Text.ToString(), "CpuCooler"))
                    {
                        MessageBox.Show("Product Removed Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                        if (product.showProductSerial(Search_Product.Text.ToString()) != null)
                        {
                            dataGridView1.DataSource = product.showProductSerial(Search_Product.Text.ToString());
                        }
                    }
                    else
                    {
                        MessageBox.Show("Could not remove the product", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                else if (Product_Type_2.Text == "Power Supply")
                {
                    if (product.removeProduct(Serial_txt.Text.ToString(), "PowerSupply"))
                    {
                        MessageBox.Show("Product Removed Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                        if (product.showProductSerial(Search_Product.Text.ToString()) != null)
                        {
                            dataGridView1.DataSource = product.showProductSerial(Search_Product.Text.ToString());
                        }
                    }
                    else
                    {
                        MessageBox.Show("Could not remove the product", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                else if (Product_Type_2.Text == "Graphics Card") {
                    if (product.removeProduct(Serial_txt.Text.ToString(), "GraphicsCard"))
                    {
                        MessageBox.Show("Product Removed Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                        if (product.showProductSerial(Search_Product.Text.ToString()) != null)
                        {
                            dataGridView1.DataSource = product.showProductSerial(Search_Product.Text.ToString());
                        }
                    }
                    else
                    {
                        MessageBox.Show("Could not remove the product", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                else if (product.removeProduct(Serial_txt.Text.ToString(), Product_Type_2.Text.ToString()))
                {
                    MessageBox.Show("Product Removed Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    if (product.showProductSerial(Search_Product.Text.ToString()) != null)
                    {
                        dataGridView1.DataSource = product.showProductSerial(Search_Product.Text.ToString());
                    }
                }
                else
                {
                    MessageBox.Show("Could not remove the product", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Search_Product_TextChanged(object sender, EventArgs e)
        {
            if (product.showProductSerial(Search_Product.Text.ToString()) != null) {
                dataGridView1.DataSource = product.showProductSerial(Search_Product.Text.ToString());
            }
            
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row_index = e.RowIndex;

            if (row_index >= 0)
            {
                Product_Type_2.Text = dataGridView1.Rows[row_index].Cells[1].Value.ToString();
                Name_txt.Text = dataGridView1.Rows[row_index].Cells[2].Value.ToString();
                Brand_txt.Text = dataGridView1.Rows[row_index].Cells[3].Value.ToString();
                Model_txt.Text = dataGridView1.Rows[row_index].Cells[4].Value.ToString();
                Price_txt.Text = dataGridView1.Rows[row_index].Cells[5].Value.ToString();
                Quantity_txt.Text = dataGridView1.Rows[row_index].Cells[6].Value.ToString();
                pictureBox1.ImageLocation = dataGridView1.Rows[row_index].Cells[7].Value.ToString();
                Serial_txt.Text = dataGridView1.Rows[row_index].Cells[8].Value.ToString();

                DynamicLabel_1.Visible = false;
                DynamicText_1.Visible = false;

                DynamicLabel_2.Visible = false;
                DynamicText_2.Visible = false;

                DynamicLabel_3.Visible = false;
                DynamicText_3.Visible = false;

                DynamicLabel_4.Visible = false;
                DynamicText_4.Visible = false;

                DynamicLabel_5.Visible = false;
                DynamicText_5.Visible = false;
            }
        }

        private void Show_All_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = product.showAllProduct();
        }
    }
}
