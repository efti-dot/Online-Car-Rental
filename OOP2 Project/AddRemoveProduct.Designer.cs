using System;
using System.Windows.Forms;

namespace OOP2_Project
{
    partial class AddRemoveProduct
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
            this.Signout = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.searchProduct = new System.Windows.Forms.Label();
            this.Search_Product = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Brand_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Model_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Name_txt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Price_txt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Quantity_txt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Serial_txt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Product_Type_2 = new System.Windows.Forms.ComboBox();
            this.DynamicLabel_1 = new System.Windows.Forms.Label();
            this.DynamicText_1 = new System.Windows.Forms.TextBox();
            this.DynamicLabel_2 = new System.Windows.Forms.Label();
            this.DynamicText_2 = new System.Windows.Forms.TextBox();
            this.DynamicLabel_5 = new System.Windows.Forms.Label();
            this.DynamicText_5 = new System.Windows.Forms.TextBox();
            this.DynamicLabel_4 = new System.Windows.Forms.Label();
            this.DynamicText_4 = new System.Windows.Forms.TextBox();
            this.DynamicLabel_3 = new System.Windows.Forms.Label();
            this.DynamicText_3 = new System.Windows.Forms.TextBox();
            this.Clear_All = new System.Windows.Forms.Button();
            this.Remove_Product = new System.Windows.Forms.Button();
            this.Add_Product = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Upload_Picture = new System.Windows.Forms.Button();
            this.Show_All = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Signout
            // 
            this.Signout.BackColor = System.Drawing.Color.LightGray;
            this.Signout.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Signout.Location = new System.Drawing.Point(804, 840);
            this.Signout.Name = "Signout";
            this.Signout.Size = new System.Drawing.Size(96, 38);
            this.Signout.TabIndex = 39;
            this.Signout.Text = "Sign  Out";
            this.Signout.UseVisualStyleBackColor = false;
            this.Signout.Click += new System.EventHandler(this.Signout_Click);
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.LightGray;
            this.Back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Back.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.ForeColor = System.Drawing.Color.Black;
            this.Back.Location = new System.Drawing.Point(12, 841);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(86, 38);
            this.Back.TabIndex = 40;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(33, 133);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(538, 361);
            this.dataGridView1.TabIndex = 41;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // searchProduct
            // 
            this.searchProduct.AutoSize = true;
            this.searchProduct.Location = new System.Drawing.Point(39, 100);
            this.searchProduct.Name = "searchProduct";
            this.searchProduct.Size = new System.Drawing.Size(41, 13);
            this.searchProduct.TabIndex = 43;
            this.searchProduct.Text = "Search";
            this.searchProduct.Click += new System.EventHandler(this.searchProduct_Click);
            // 
            // Search_Product
            // 
            this.Search_Product.Location = new System.Drawing.Point(106, 97);
            this.Search_Product.Name = "Search_Product";
            this.Search_Product.Size = new System.Drawing.Size(465, 20);
            this.Search_Product.TabIndex = 44;
            this.Search_Product.TextChanged += new System.EventHandler(this.Search_Product_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(591, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 55;
            this.label3.Text = "Brand";
            // 
            // Brand_txt
            // 
            this.Brand_txt.Location = new System.Drawing.Point(590, 169);
            this.Brand_txt.Name = "Brand_txt";
            this.Brand_txt.Size = new System.Drawing.Size(297, 20);
            this.Brand_txt.TabIndex = 54;
            this.Brand_txt.Click += new System.EventHandler(this.Brand_txt_Click);
            this.Brand_txt.TextChanged += new System.EventHandler(this.Brand_txt_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(591, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 57;
            this.label4.Text = "Model";
            // 
            // Model_txt
            // 
            this.Model_txt.Location = new System.Drawing.Point(590, 219);
            this.Model_txt.Name = "Model_txt";
            this.Model_txt.Size = new System.Drawing.Size(297, 20);
            this.Model_txt.TabIndex = 56;
            this.Model_txt.Click += new System.EventHandler(this.Model_txt_Click);
            this.Model_txt.TextChanged += new System.EventHandler(this.Model_txt_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(590, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 59;
            this.label5.Text = "Name";
            // 
            // Name_txt
            // 
            this.Name_txt.Location = new System.Drawing.Point(589, 119);
            this.Name_txt.Name = "Name_txt";
            this.Name_txt.Size = new System.Drawing.Size(297, 20);
            this.Name_txt.TabIndex = 58;
            this.Name_txt.Click += new System.EventHandler(this.Name_txt_Click);
            this.Name_txt.TextChanged += new System.EventHandler(this.Name_txt_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(591, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 61;
            this.label6.Text = "Price";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // Price_txt
            // 
            this.Price_txt.Location = new System.Drawing.Point(590, 269);
            this.Price_txt.Name = "Price_txt";
            this.Price_txt.Size = new System.Drawing.Size(297, 20);
            this.Price_txt.TabIndex = 60;
            this.Price_txt.Click += new System.EventHandler(this.Price_txt_Click);
            this.Price_txt.TextChanged += new System.EventHandler(this.Price_txt_TextChanged);
            this.Price_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Price_txt_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(591, 303);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 63;
            this.label7.Text = "Quantity";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // Quantity_txt
            // 
            this.Quantity_txt.Location = new System.Drawing.Point(590, 319);
            this.Quantity_txt.Name = "Quantity_txt";
            this.Quantity_txt.Size = new System.Drawing.Size(297, 20);
            this.Quantity_txt.TabIndex = 62;
            this.Quantity_txt.Click += new System.EventHandler(this.Quantity_txt_Click);
            this.Quantity_txt.TextChanged += new System.EventHandler(this.Quantity_txt_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(591, 395);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 65;
            this.label8.Text = "Product Image";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(591, 455);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 13);
            this.label9.TabIndex = 67;
            this.label9.Text = "Serial Number";
            // 
            // Serial_txt
            // 
            this.Serial_txt.Location = new System.Drawing.Point(590, 471);
            this.Serial_txt.Name = "Serial_txt";
            this.Serial_txt.Size = new System.Drawing.Size(297, 20);
            this.Serial_txt.TabIndex = 66;
            this.Serial_txt.Click += new System.EventHandler(this.Serial_txt_Click);
            this.Serial_txt.TextChanged += new System.EventHandler(this.Serial_txt_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(591, 54);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 13);
            this.label10.TabIndex = 69;
            this.label10.Text = "Product Type";
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
            this.Product_Type_2.Location = new System.Drawing.Point(589, 70);
            this.Product_Type_2.Name = "Product_Type_2";
            this.Product_Type_2.Size = new System.Drawing.Size(298, 21);
            this.Product_Type_2.TabIndex = 68;
            this.Product_Type_2.SelectedIndexChanged += new System.EventHandler(this.Product_Type_2_SelectedIndexChanged);
            // 
            // DynamicLabel_1
            // 
            this.DynamicLabel_1.AutoSize = true;
            this.DynamicLabel_1.Location = new System.Drawing.Point(591, 505);
            this.DynamicLabel_1.Name = "DynamicLabel_1";
            this.DynamicLabel_1.Size = new System.Drawing.Size(46, 13);
            this.DynamicLabel_1.TabIndex = 71;
            this.DynamicLabel_1.Text = "Quantity";
            this.DynamicLabel_1.Visible = false;
            // 
            // DynamicText_1
            // 
            this.DynamicText_1.Location = new System.Drawing.Point(590, 521);
            this.DynamicText_1.Name = "DynamicText_1";
            this.DynamicText_1.Size = new System.Drawing.Size(297, 20);
            this.DynamicText_1.TabIndex = 70;
            this.DynamicText_1.Visible = false;
            this.DynamicText_1.Click += new System.EventHandler(this.DynamicText_1_Click);
            this.DynamicText_1.TextChanged += new System.EventHandler(this.DynamicText_1_TextChanged);
            // 
            // DynamicLabel_2
            // 
            this.DynamicLabel_2.AutoSize = true;
            this.DynamicLabel_2.Location = new System.Drawing.Point(591, 554);
            this.DynamicLabel_2.Name = "DynamicLabel_2";
            this.DynamicLabel_2.Size = new System.Drawing.Size(46, 13);
            this.DynamicLabel_2.TabIndex = 73;
            this.DynamicLabel_2.Text = "Quantity";
            this.DynamicLabel_2.Visible = false;
            // 
            // DynamicText_2
            // 
            this.DynamicText_2.Location = new System.Drawing.Point(590, 570);
            this.DynamicText_2.Name = "DynamicText_2";
            this.DynamicText_2.Size = new System.Drawing.Size(297, 20);
            this.DynamicText_2.TabIndex = 72;
            this.DynamicText_2.Visible = false;
            this.DynamicText_2.Click += new System.EventHandler(this.DynamicText_2_Click);
            this.DynamicText_2.TextChanged += new System.EventHandler(this.DynamicText_2_TextChanged);
            // 
            // DynamicLabel_5
            // 
            this.DynamicLabel_5.AutoSize = true;
            this.DynamicLabel_5.Location = new System.Drawing.Point(590, 702);
            this.DynamicLabel_5.Name = "DynamicLabel_5";
            this.DynamicLabel_5.Size = new System.Drawing.Size(46, 13);
            this.DynamicLabel_5.TabIndex = 75;
            this.DynamicLabel_5.Text = "Quantity";
            this.DynamicLabel_5.Visible = false;
            // 
            // DynamicText_5
            // 
            this.DynamicText_5.Location = new System.Drawing.Point(589, 718);
            this.DynamicText_5.Name = "DynamicText_5";
            this.DynamicText_5.Size = new System.Drawing.Size(297, 20);
            this.DynamicText_5.TabIndex = 74;
            this.DynamicText_5.Visible = false;
            this.DynamicText_5.Click += new System.EventHandler(this.DynamicText_5_Click);
            this.DynamicText_5.TextChanged += new System.EventHandler(this.DynamicText_5_TextChanged);
            // 
            // DynamicLabel_4
            // 
            this.DynamicLabel_4.AutoSize = true;
            this.DynamicLabel_4.Location = new System.Drawing.Point(590, 653);
            this.DynamicLabel_4.Name = "DynamicLabel_4";
            this.DynamicLabel_4.Size = new System.Drawing.Size(46, 13);
            this.DynamicLabel_4.TabIndex = 77;
            this.DynamicLabel_4.Text = "Quantity";
            this.DynamicLabel_4.Visible = false;
            // 
            // DynamicText_4
            // 
            this.DynamicText_4.Location = new System.Drawing.Point(589, 669);
            this.DynamicText_4.Name = "DynamicText_4";
            this.DynamicText_4.Size = new System.Drawing.Size(297, 20);
            this.DynamicText_4.TabIndex = 76;
            this.DynamicText_4.Visible = false;
            this.DynamicText_4.Click += new System.EventHandler(this.DynamicText_4_Click);
            this.DynamicText_4.TextChanged += new System.EventHandler(this.DynamicText_4_TextChanged);
            // 
            // DynamicLabel_3
            // 
            this.DynamicLabel_3.AutoSize = true;
            this.DynamicLabel_3.Location = new System.Drawing.Point(591, 603);
            this.DynamicLabel_3.Name = "DynamicLabel_3";
            this.DynamicLabel_3.Size = new System.Drawing.Size(46, 13);
            this.DynamicLabel_3.TabIndex = 79;
            this.DynamicLabel_3.Text = "Quantity";
            this.DynamicLabel_3.Visible = false;
            // 
            // DynamicText_3
            // 
            this.DynamicText_3.Location = new System.Drawing.Point(590, 619);
            this.DynamicText_3.Name = "DynamicText_3";
            this.DynamicText_3.Size = new System.Drawing.Size(297, 20);
            this.DynamicText_3.TabIndex = 78;
            this.DynamicText_3.Visible = false;
            this.DynamicText_3.Click += new System.EventHandler(this.DynamicText_3_Click);
            this.DynamicText_3.TextChanged += new System.EventHandler(this.DynamicText_3_TextChanged);
            // 
            // Clear_All
            // 
            this.Clear_All.BackColor = System.Drawing.Color.LightGray;
            this.Clear_All.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Clear_All.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear_All.ForeColor = System.Drawing.Color.Black;
            this.Clear_All.Location = new System.Drawing.Point(485, 503);
            this.Clear_All.Name = "Clear_All";
            this.Clear_All.Size = new System.Drawing.Size(86, 38);
            this.Clear_All.TabIndex = 80;
            this.Clear_All.Text = "Clear All";
            this.Clear_All.UseVisualStyleBackColor = false;
            this.Clear_All.Click += new System.EventHandler(this.Clear_All_Click);
            // 
            // Remove_Product
            // 
            this.Remove_Product.BackColor = System.Drawing.Color.LightGray;
            this.Remove_Product.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Remove_Product.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Remove_Product.ForeColor = System.Drawing.Color.Black;
            this.Remove_Product.Location = new System.Drawing.Point(382, 503);
            this.Remove_Product.Name = "Remove_Product";
            this.Remove_Product.Size = new System.Drawing.Size(86, 38);
            this.Remove_Product.TabIndex = 81;
            this.Remove_Product.Text = "Remove";
            this.Remove_Product.UseVisualStyleBackColor = false;
            this.Remove_Product.Click += new System.EventHandler(this.Remove_Product_Click);
            // 
            // Add_Product
            // 
            this.Add_Product.BackColor = System.Drawing.Color.LightGray;
            this.Add_Product.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Add_Product.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_Product.ForeColor = System.Drawing.Color.Black;
            this.Add_Product.Location = new System.Drawing.Point(800, 755);
            this.Add_Product.Name = "Add_Product";
            this.Add_Product.Size = new System.Drawing.Size(86, 38);
            this.Add_Product.TabIndex = 82;
            this.Add_Product.Text = "Add";
            this.Add_Product.UseVisualStyleBackColor = false;
            this.Add_Product.Click += new System.EventHandler(this.Add_Product_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(685, 359);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(102, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 83;
            this.pictureBox1.TabStop = false;
            // 
            // Upload_Picture
            // 
            this.Upload_Picture.BackColor = System.Drawing.Color.LightGray;
            this.Upload_Picture.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Upload_Picture.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Upload_Picture.ForeColor = System.Drawing.Color.Black;
            this.Upload_Picture.Location = new System.Drawing.Point(804, 387);
            this.Upload_Picture.Name = "Upload_Picture";
            this.Upload_Picture.Size = new System.Drawing.Size(73, 28);
            this.Upload_Picture.TabIndex = 84;
            this.Upload_Picture.Text = "Upload";
            this.Upload_Picture.UseVisualStyleBackColor = false;
            this.Upload_Picture.Click += new System.EventHandler(this.Upload_Picture_Click);
            // 
            // Show_All
            // 
            this.Show_All.BackColor = System.Drawing.Color.LightGray;
            this.Show_All.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Show_All.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Show_All.ForeColor = System.Drawing.Color.Black;
            this.Show_All.Location = new System.Drawing.Point(33, 505);
            this.Show_All.Name = "Show_All";
            this.Show_All.Size = new System.Drawing.Size(86, 38);
            this.Show_All.TabIndex = 85;
            this.Show_All.Text = "All Products";
            this.Show_All.UseVisualStyleBackColor = false;
            this.Show_All.Click += new System.EventHandler(this.Show_All_Click);
            // 
            // AddRemoveProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OOP2_Project.Properties.Resources._5378441;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(912, 901);
            this.Controls.Add(this.Show_All);
            this.Controls.Add(this.Upload_Picture);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Add_Product);
            this.Controls.Add(this.Remove_Product);
            this.Controls.Add(this.Clear_All);
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
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Product_Type_2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Serial_txt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Quantity_txt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Price_txt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Name_txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Model_txt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Brand_txt);
            this.Controls.Add(this.Search_Product);
            this.Controls.Add(this.searchProduct);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Signout);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddRemoveProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add/Remove Product";
            this.Load += new System.EventHandler(this.AddRemoveProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Product_Type_2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Product_Type_2_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Product_Type_2_(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.Button Signout;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label searchProduct;
        private System.Windows.Forms.TextBox Search_Product;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Brand_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Model_txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Name_txt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Price_txt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Quantity_txt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Serial_txt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox Product_Type_2;
        private System.Windows.Forms.Label DynamicLabel_1;
        private System.Windows.Forms.TextBox DynamicText_1;
        private System.Windows.Forms.Label DynamicLabel_2;
        private System.Windows.Forms.TextBox DynamicText_2;
        private System.Windows.Forms.Label DynamicLabel_5;
        private System.Windows.Forms.TextBox DynamicText_5;
        private System.Windows.Forms.Label DynamicLabel_4;
        private System.Windows.Forms.TextBox DynamicText_4;
        private System.Windows.Forms.Label DynamicLabel_3;
        private System.Windows.Forms.TextBox DynamicText_3;
        private System.Windows.Forms.Button Clear_All;
        private System.Windows.Forms.Button Remove_Product;
        private System.Windows.Forms.Button Add_Product;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Upload_Picture;
        private Button Show_All;
    }
}