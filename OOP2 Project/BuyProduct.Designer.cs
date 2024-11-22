using System;
using System.Windows.Forms;

namespace OOP2_Project
{
    partial class BuyProduct
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Product_Type_1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Back = new System.Windows.Forms.Button();
            this.Signout = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Quantity_txt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Price_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Name_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Model_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Brand_txt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Product_Type_2 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.DynamicLabel_3 = new System.Windows.Forms.Label();
            this.DynamicText_3 = new System.Windows.Forms.TextBox();
            this.DynamicLabel_4 = new System.Windows.Forms.Label();
            this.DynamicText_4 = new System.Windows.Forms.TextBox();
            this.DynamicLabel_5 = new System.Windows.Forms.Label();
            this.DynamicText_5 = new System.Windows.Forms.TextBox();
            this.DynamicLabel_2 = new System.Windows.Forms.Label();
            this.DynamicText_2 = new System.Windows.Forms.TextBox();
            this.DynamicLabel_1 = new System.Windows.Forms.Label();
            this.DynamicText_1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Order_Quantity_txt = new System.Windows.Forms.TextBox();
            this.OrderDetails_lbl = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Delivery_Address_txt = new System.Windows.Forms.TextBox();
            this.Order = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.Serial_txt = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.Total_Price_txt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Product_Type_1
            // 
            this.Product_Type_1.FormattingEnabled = true;
            this.Product_Type_1.Items.AddRange(new object[] {
            "Motherboard",
            "Processor",
            "Ram",
            "Cpu Cooler",
            "Power Supply",
            "Graphics Card",
            "Storage",
            "Monitor",
            "Casing",
            "Keyboard",
            "Mouse",
            "Headphone"});
            this.Product_Type_1.Location = new System.Drawing.Point(93, 54);
            this.Product_Type_1.Name = "Product_Type_1";
            this.Product_Type_1.Size = new System.Drawing.Size(413, 21);
            this.Product_Type_1.TabIndex = 0;
            this.Product_Type_1.SelectedIndexChanged += new System.EventHandler(this.Product_Type_1_SelectedIndexChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Category";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(93, 81);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(413, 663);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.LightGray;
            this.Back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Back.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.ForeColor = System.Drawing.Color.Black;
            this.Back.Location = new System.Drawing.Point(24, 764);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(86, 38);
            this.Back.TabIndex = 60;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Signout
            // 
            this.Signout.BackColor = System.Drawing.Color.LightGray;
            this.Signout.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Signout.Location = new System.Drawing.Point(1211, 763);
            this.Signout.Name = "Signout";
            this.Signout.Size = new System.Drawing.Size(96, 38);
            this.Signout.TabIndex = 59;
            this.Signout.Text = "Sign  Out";
            this.Signout.UseVisualStyleBackColor = false;
            this.Signout.Click += new System.EventHandler(this.Signout_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(639, 370);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(102, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 96;
            this.pictureBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(545, 406);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 93;
            this.label8.Text = "Product Image";
            // 
            // Quantity_txt
            // 
            this.Quantity_txt.Location = new System.Drawing.Point(544, 330);
            this.Quantity_txt.Name = "Quantity_txt";
            this.Quantity_txt.Size = new System.Drawing.Size(297, 20);
            this.Quantity_txt.TabIndex = 92;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(545, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 91;
            this.label6.Text = "Price";
            // 
            // Price_txt
            // 
            this.Price_txt.Location = new System.Drawing.Point(544, 280);
            this.Price_txt.Name = "Price_txt";
            this.Price_txt.Size = new System.Drawing.Size(297, 20);
            this.Price_txt.TabIndex = 90;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(544, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 89;
            this.label5.Text = "Name";
            // 
            // Name_txt
            // 
            this.Name_txt.Location = new System.Drawing.Point(543, 130);
            this.Name_txt.Name = "Name_txt";
            this.Name_txt.Size = new System.Drawing.Size(297, 20);
            this.Name_txt.TabIndex = 88;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(545, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 87;
            this.label4.Text = "Model";
            // 
            // Model_txt
            // 
            this.Model_txt.Location = new System.Drawing.Point(544, 230);
            this.Model_txt.Name = "Model_txt";
            this.Model_txt.Size = new System.Drawing.Size(297, 20);
            this.Model_txt.TabIndex = 86;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(545, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 85;
            this.label3.Text = "Brand";
            // 
            // Brand_txt
            // 
            this.Brand_txt.Location = new System.Drawing.Point(544, 180);
            this.Brand_txt.Name = "Brand_txt";
            this.Brand_txt.Size = new System.Drawing.Size(297, 20);
            this.Brand_txt.TabIndex = 84;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(545, 65);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 95;
            this.label10.Text = "Category";
            // 
            // Product_Type_2
            // 
            this.Product_Type_2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Product_Type_2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Product_Type_2.FormattingEnabled = true;
            this.Product_Type_2.Items.AddRange(new object[] {
            "Motherboard",
            "Processor",
            "Ram",
            "Cpu Cooler",
            "Power Supply",
            "Graphics Card",
            "Storage",
            "Monitor",
            "Casing",
            "Keyboard",
            "Mouse",
            "Headphone"});
            this.Product_Type_2.Location = new System.Drawing.Point(542, 81);
            this.Product_Type_2.Name = "Product_Type_2";
            this.Product_Type_2.Size = new System.Drawing.Size(298, 21);
            this.Product_Type_2.TabIndex = 94;
            this.Product_Type_2.SelectedIndexChanged += new System.EventHandler(this.Product_Type_2_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(545, 314);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 13);
            this.label7.TabIndex = 97;
            this.label7.Text = "Available Quantity";
            // 
            // DynamicLabel_3
            // 
            this.DynamicLabel_3.AutoSize = true;
            this.DynamicLabel_3.Location = new System.Drawing.Point(546, 609);
            this.DynamicLabel_3.Name = "DynamicLabel_3";
            this.DynamicLabel_3.Size = new System.Drawing.Size(46, 13);
            this.DynamicLabel_3.TabIndex = 107;
            this.DynamicLabel_3.Text = "Quantity";
            this.DynamicLabel_3.Visible = false;
            // 
            // DynamicText_3
            // 
            this.DynamicText_3.Location = new System.Drawing.Point(545, 625);
            this.DynamicText_3.Name = "DynamicText_3";
            this.DynamicText_3.Size = new System.Drawing.Size(297, 20);
            this.DynamicText_3.TabIndex = 106;
            this.DynamicText_3.Visible = false;
            // 
            // DynamicLabel_4
            // 
            this.DynamicLabel_4.AutoSize = true;
            this.DynamicLabel_4.Location = new System.Drawing.Point(545, 659);
            this.DynamicLabel_4.Name = "DynamicLabel_4";
            this.DynamicLabel_4.Size = new System.Drawing.Size(46, 13);
            this.DynamicLabel_4.TabIndex = 105;
            this.DynamicLabel_4.Text = "Quantity";
            this.DynamicLabel_4.Visible = false;
            // 
            // DynamicText_4
            // 
            this.DynamicText_4.Location = new System.Drawing.Point(544, 675);
            this.DynamicText_4.Name = "DynamicText_4";
            this.DynamicText_4.Size = new System.Drawing.Size(297, 20);
            this.DynamicText_4.TabIndex = 104;
            this.DynamicText_4.Visible = false;
            // 
            // DynamicLabel_5
            // 
            this.DynamicLabel_5.AutoSize = true;
            this.DynamicLabel_5.Location = new System.Drawing.Point(545, 708);
            this.DynamicLabel_5.Name = "DynamicLabel_5";
            this.DynamicLabel_5.Size = new System.Drawing.Size(46, 13);
            this.DynamicLabel_5.TabIndex = 103;
            this.DynamicLabel_5.Text = "Quantity";
            this.DynamicLabel_5.Visible = false;
            // 
            // DynamicText_5
            // 
            this.DynamicText_5.Location = new System.Drawing.Point(544, 724);
            this.DynamicText_5.Name = "DynamicText_5";
            this.DynamicText_5.Size = new System.Drawing.Size(297, 20);
            this.DynamicText_5.TabIndex = 102;
            this.DynamicText_5.Visible = false;
            // 
            // DynamicLabel_2
            // 
            this.DynamicLabel_2.AutoSize = true;
            this.DynamicLabel_2.Location = new System.Drawing.Point(546, 560);
            this.DynamicLabel_2.Name = "DynamicLabel_2";
            this.DynamicLabel_2.Size = new System.Drawing.Size(46, 13);
            this.DynamicLabel_2.TabIndex = 101;
            this.DynamicLabel_2.Text = "Quantity";
            this.DynamicLabel_2.Visible = false;
            // 
            // DynamicText_2
            // 
            this.DynamicText_2.Location = new System.Drawing.Point(545, 576);
            this.DynamicText_2.Name = "DynamicText_2";
            this.DynamicText_2.Size = new System.Drawing.Size(297, 20);
            this.DynamicText_2.TabIndex = 100;
            this.DynamicText_2.Visible = false;
            // 
            // DynamicLabel_1
            // 
            this.DynamicLabel_1.AutoSize = true;
            this.DynamicLabel_1.Location = new System.Drawing.Point(546, 511);
            this.DynamicLabel_1.Name = "DynamicLabel_1";
            this.DynamicLabel_1.Size = new System.Drawing.Size(46, 13);
            this.DynamicLabel_1.TabIndex = 99;
            this.DynamicLabel_1.Text = "Quantity";
            this.DynamicLabel_1.Visible = false;
            // 
            // DynamicText_1
            // 
            this.DynamicText_1.Location = new System.Drawing.Point(545, 527);
            this.DynamicText_1.Name = "DynamicText_1";
            this.DynamicText_1.Size = new System.Drawing.Size(297, 20);
            this.DynamicText_1.TabIndex = 98;
            this.DynamicText_1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(974, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 109;
            this.label2.Text = "Order Quantity";
            // 
            // Order_Quantity_txt
            // 
            this.Order_Quantity_txt.Location = new System.Drawing.Point(973, 130);
            this.Order_Quantity_txt.Name = "Order_Quantity_txt";
            this.Order_Quantity_txt.Size = new System.Drawing.Size(297, 20);
            this.Order_Quantity_txt.TabIndex = 108;
            this.Order_Quantity_txt.Click += new System.EventHandler(this.Order_Quantity_txt_Click);
            this.Order_Quantity_txt.TextChanged += new System.EventHandler(this.Order_Quantity_txt_TextChanged);
            // 
            // OrderDetails_lbl
            // 
            this.OrderDetails_lbl.AutoSize = true;
            this.OrderDetails_lbl.Location = new System.Drawing.Point(1089, 81);
            this.OrderDetails_lbl.Name = "OrderDetails_lbl";
            this.OrderDetails_lbl.Size = new System.Drawing.Size(68, 13);
            this.OrderDetails_lbl.TabIndex = 110;
            this.OrderDetails_lbl.Text = "Order Details";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(636, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 13);
            this.label9.TabIndex = 111;
            this.label9.Text = "Product Details";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(974, 176);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 13);
            this.label11.TabIndex = 113;
            this.label11.Text = "Delivery Address";
            // 
            // Delivery_Address_txt
            // 
            this.Delivery_Address_txt.Location = new System.Drawing.Point(973, 192);
            this.Delivery_Address_txt.Name = "Delivery_Address_txt";
            this.Delivery_Address_txt.Size = new System.Drawing.Size(297, 20);
            this.Delivery_Address_txt.TabIndex = 112;
            this.Delivery_Address_txt.Click += new System.EventHandler(this.Delivery_Address_txt_Click);
            this.Delivery_Address_txt.TextChanged += new System.EventHandler(this.Delivery_Address_txt_TextChanged);
            // 
            // Order
            // 
            this.Order.BackColor = System.Drawing.Color.LightGray;
            this.Order.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Order.Location = new System.Drawing.Point(1174, 289);
            this.Order.Name = "Order";
            this.Order.Size = new System.Drawing.Size(96, 38);
            this.Order.TabIndex = 114;
            this.Order.Text = "Order";
            this.Order.UseVisualStyleBackColor = false;
            this.Order.Click += new System.EventHandler(this.Order_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(545, 461);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 13);
            this.label12.TabIndex = 116;
            this.label12.Text = "Serial Number";
            // 
            // Serial_txt
            // 
            this.Serial_txt.Location = new System.Drawing.Point(544, 477);
            this.Serial_txt.Name = "Serial_txt";
            this.Serial_txt.Size = new System.Drawing.Size(297, 20);
            this.Serial_txt.TabIndex = 115;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(974, 238);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 13);
            this.label13.TabIndex = 118;
            this.label13.Text = "Total Price";
            // 
            // Total_Price_txt
            // 
            this.Total_Price_txt.Location = new System.Drawing.Point(973, 254);
            this.Total_Price_txt.Name = "Total_Price_txt";
            this.Total_Price_txt.ReadOnly = true;
            this.Total_Price_txt.Size = new System.Drawing.Size(297, 20);
            this.Total_Price_txt.TabIndex = 117;
            // 
            // BuyProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OOP2_Project.Properties.Resources.main;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1334, 831);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.Total_Price_txt);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.Serial_txt);
            this.Controls.Add(this.Order);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Delivery_Address_txt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.OrderDetails_lbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Order_Quantity_txt);
            this.Controls.Add(this.DynamicLabel_3);
            this.Controls.Add(this.DynamicText_3);
            this.Controls.Add(this.DynamicLabel_4);
            this.Controls.Add(this.DynamicText_4);
            this.Controls.Add(this.DynamicLabel_5);
            this.Controls.Add(this.DynamicText_5);
            this.Controls.Add(this.DynamicLabel_2);
            this.Controls.Add(this.DynamicText_2);
            this.Controls.Add(this.DynamicLabel_1);
            this.Controls.Add(this.DynamicText_1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Product_Type_2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Quantity_txt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Price_txt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Name_txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Model_txt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Brand_txt);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Signout);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Product_Type_1);
            this.DoubleBuffered = true;
            this.Name = "BuyProduct";
            this.Text = "BuyProduct";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Product_Type_1_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.ComboBox Product_Type_1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button Signout;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Quantity_txt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Price_txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Name_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Model_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Brand_txt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox Product_Type_2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label DynamicLabel_3;
        private System.Windows.Forms.TextBox DynamicText_3;
        private System.Windows.Forms.Label DynamicLabel_4;
        private System.Windows.Forms.TextBox DynamicText_4;
        private System.Windows.Forms.Label DynamicLabel_5;
        private System.Windows.Forms.TextBox DynamicText_5;
        private System.Windows.Forms.Label DynamicLabel_2;
        private System.Windows.Forms.TextBox DynamicText_2;
        private System.Windows.Forms.Label DynamicLabel_1;
        private System.Windows.Forms.TextBox DynamicText_1;
        private Label label2;
        private TextBox Order_Quantity_txt;
        private Label OrderDetails_lbl;
        private Label label9;
        private Label label11;
        private TextBox Delivery_Address_txt;
        private Button Order;
        private Label label12;
        private TextBox Serial_txt;
        private Label label13;
        private TextBox Total_Price_txt;
    }
}