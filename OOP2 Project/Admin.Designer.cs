namespace OOP2_Project
{
    partial class Admin
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
            this.AddRemove_Staff = new System.Windows.Forms.Button();
            this.AddRemove_Product = new System.Windows.Forms.Button();
            this.Products = new System.Windows.Forms.Button();
            this.Stockout_Products = new System.Windows.Forms.Button();
            this.All_Product = new System.Windows.Forms.Button();
            this.Available_Products = new System.Windows.Forms.Button();
            this.Approve_Customer = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Show_Orders = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Signout
            // 
            this.Signout.BackColor = System.Drawing.Color.LightGray;
            this.Signout.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Signout.Location = new System.Drawing.Point(896, 511);
            this.Signout.Name = "Signout";
            this.Signout.Size = new System.Drawing.Size(96, 38);
            this.Signout.TabIndex = 23;
            this.Signout.Text = "Sign  Out";
            this.Signout.UseVisualStyleBackColor = false;
            this.Signout.Click += new System.EventHandler(this.Signout_Click);
            // 
            // AddRemove_Staff
            // 
            this.AddRemove_Staff.BackColor = System.Drawing.Color.Silver;
            this.AddRemove_Staff.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddRemove_Staff.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddRemove_Staff.Location = new System.Drawing.Point(346, 223);
            this.AddRemove_Staff.Name = "AddRemove_Staff";
            this.AddRemove_Staff.Size = new System.Drawing.Size(380, 51);
            this.AddRemove_Staff.TabIndex = 24;
            this.AddRemove_Staff.Text = "Add Staff";
            this.AddRemove_Staff.UseVisualStyleBackColor = false;
            this.AddRemove_Staff.Click += new System.EventHandler(this.Add_Staff_Click);
            // 
            // AddRemove_Product
            // 
            this.AddRemove_Product.BackColor = System.Drawing.Color.WhiteSmoke;
            this.AddRemove_Product.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddRemove_Product.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddRemove_Product.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AddRemove_Product.Location = new System.Drawing.Point(346, 156);
            this.AddRemove_Product.Name = "AddRemove_Product";
            this.AddRemove_Product.Size = new System.Drawing.Size(380, 51);
            this.AddRemove_Product.TabIndex = 26;
            this.AddRemove_Product.Text = "Add / Remove Product";
            this.AddRemove_Product.UseVisualStyleBackColor = false;
            this.AddRemove_Product.Click += new System.EventHandler(this.addproduct_Click);
            // 
            // Products
            // 
            this.Products.BackColor = System.Drawing.Color.Silver;
            this.Products.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Products.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Products.Location = new System.Drawing.Point(346, 90);
            this.Products.Name = "Products";
            this.Products.Size = new System.Drawing.Size(380, 51);
            this.Products.TabIndex = 28;
            this.Products.Text = "Products";
            this.Products.UseVisualStyleBackColor = false;
            this.Products.Click += new System.EventHandler(this.Products_Click);
            // 
            // Stockout_Products
            // 
            this.Stockout_Products.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Stockout_Products.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stockout_Products.Location = new System.Drawing.Point(614, 43);
            this.Stockout_Products.Margin = new System.Windows.Forms.Padding(2);
            this.Stockout_Products.Name = "Stockout_Products";
            this.Stockout_Products.Size = new System.Drawing.Size(112, 41);
            this.Stockout_Products.TabIndex = 41;
            this.Stockout_Products.Text = "Stockout Products";
            this.Stockout_Products.UseVisualStyleBackColor = false;
            this.Stockout_Products.Click += new System.EventHandler(this.Stockout_Products_Click);
            // 
            // All_Product
            // 
            this.All_Product.BackColor = System.Drawing.Color.WhiteSmoke;
            this.All_Product.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.All_Product.Location = new System.Drawing.Point(346, 43);
            this.All_Product.Margin = new System.Windows.Forms.Padding(2);
            this.All_Product.Name = "All_Product";
            this.All_Product.Size = new System.Drawing.Size(112, 41);
            this.All_Product.TabIndex = 40;
            this.All_Product.Text = "All Products";
            this.All_Product.UseVisualStyleBackColor = false;
            this.All_Product.Click += new System.EventHandler(this.All_Product_Click);
            // 
            // Available_Products
            // 
            this.Available_Products.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Available_Products.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Available_Products.Location = new System.Drawing.Point(480, 43);
            this.Available_Products.Margin = new System.Windows.Forms.Padding(2);
            this.Available_Products.Name = "Available_Products";
            this.Available_Products.Size = new System.Drawing.Size(112, 41);
            this.Available_Products.TabIndex = 39;
            this.Available_Products.Text = "Available Products";
            this.Available_Products.UseVisualStyleBackColor = false;
            this.Available_Products.Click += new System.EventHandler(this.Available_Products_Click);
            // 
            // Approve_Customer
            // 
            this.Approve_Customer.BackColor = System.Drawing.Color.Silver;
            this.Approve_Customer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Approve_Customer.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Approve_Customer.Location = new System.Drawing.Point(346, 355);
            this.Approve_Customer.Name = "Approve_Customer";
            this.Approve_Customer.Size = new System.Drawing.Size(380, 51);
            this.Approve_Customer.TabIndex = 42;
            this.Approve_Customer.Text = "Approve Customer";
            this.Approve_Customer.UseVisualStyleBackColor = false;
            this.Approve_Customer.Click += new System.EventHandler(this.Approve_Customer_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(346, 289);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(380, 51);
            this.button1.TabIndex = 43;
            this.button1.Text = "Remove Staff";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Show_Orders
            // 
            this.Show_Orders.BackColor = System.Drawing.Color.Silver;
            this.Show_Orders.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Show_Orders.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Show_Orders.Location = new System.Drawing.Point(346, 421);
            this.Show_Orders.Name = "Show_Orders";
            this.Show_Orders.Size = new System.Drawing.Size(380, 51);
            this.Show_Orders.TabIndex = 45;
            this.Show_Orders.Text = "Orders";
            this.Show_Orders.UseVisualStyleBackColor = false;
            this.Show_Orders.Click += new System.EventHandler(this.Show_Orders_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OOP2_Project.Properties.Resources._537844;
            this.ClientSize = new System.Drawing.Size(1028, 579);
            this.Controls.Add(this.Show_Orders);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Approve_Customer);
            this.Controls.Add(this.Stockout_Products);
            this.Controls.Add(this.All_Product);
            this.Controls.Add(this.Available_Products);
            this.Controls.Add(this.Products);
            this.Controls.Add(this.AddRemove_Product);
            this.Controls.Add(this.AddRemove_Staff);
            this.Controls.Add(this.Signout);
            this.MaximumSize = new System.Drawing.Size(1044, 618);
            this.MinimumSize = new System.Drawing.Size(1044, 618);
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Signout;
        private System.Windows.Forms.Button AddRemove_Staff;
        private System.Windows.Forms.Button AddRemove_Product;
        private System.Windows.Forms.Button Products;
        private System.Windows.Forms.Button Stockout_Products;
        private System.Windows.Forms.Button All_Product;
        private System.Windows.Forms.Button Available_Products;
        private System.Windows.Forms.Button Approve_Customer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Show_Orders;
    }
}