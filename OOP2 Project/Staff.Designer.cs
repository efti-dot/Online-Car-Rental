namespace OOP2_Project
{
    partial class Staff
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
            this.AddRemove_Product = new System.Windows.Forms.Button();
            this.Signout = new System.Windows.Forms.Button();
            this.Products = new System.Windows.Forms.Button();
            this.Available_Products = new System.Windows.Forms.Button();
            this.All_Product = new System.Windows.Forms.Button();
            this.Stockout_Products = new System.Windows.Forms.Button();
            this.Show_Orders = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddRemove_Product
            // 
            this.AddRemove_Product.BackColor = System.Drawing.Color.WhiteSmoke;
            this.AddRemove_Product.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddRemove_Product.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddRemove_Product.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AddRemove_Product.Location = new System.Drawing.Point(327, 253);
            this.AddRemove_Product.Name = "AddRemove_Product";
            this.AddRemove_Product.Size = new System.Drawing.Size(380, 51);
            this.AddRemove_Product.TabIndex = 27;
            this.AddRemove_Product.Text = "Add/Remove Product";
            this.AddRemove_Product.UseVisualStyleBackColor = false;
            this.AddRemove_Product.Click += new System.EventHandler(this.Add_Product_Click);
            // 
            // Signout
            // 
            this.Signout.BackColor = System.Drawing.Color.LightGray;
            this.Signout.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Signout.Location = new System.Drawing.Point(874, 509);
            this.Signout.Name = "Signout";
            this.Signout.Size = new System.Drawing.Size(96, 38);
            this.Signout.TabIndex = 30;
            this.Signout.Text = "Sign  Out";
            this.Signout.UseVisualStyleBackColor = false;
            this.Signout.Click += new System.EventHandler(this.Signout_Click_1);
            // 
            // Products
            // 
            this.Products.BackColor = System.Drawing.Color.Silver;
            this.Products.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Products.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Products.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Products.Location = new System.Drawing.Point(327, 167);
            this.Products.Name = "Products";
            this.Products.Size = new System.Drawing.Size(380, 51);
            this.Products.TabIndex = 33;
            this.Products.Text = "Products";
            this.Products.UseVisualStyleBackColor = false;
            this.Products.Click += new System.EventHandler(this.button3_Click);
            // 
            // Available_Products
            // 
            this.Available_Products.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Available_Products.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Available_Products.Location = new System.Drawing.Point(462, 106);
            this.Available_Products.Margin = new System.Windows.Forms.Padding(2);
            this.Available_Products.Name = "Available_Products";
            this.Available_Products.Size = new System.Drawing.Size(112, 41);
            this.Available_Products.TabIndex = 34;
            this.Available_Products.Text = "Available Products";
            this.Available_Products.UseVisualStyleBackColor = false;
            this.Available_Products.Click += new System.EventHandler(this.Available_Products_Click);
            // 
            // All_Product
            // 
            this.All_Product.BackColor = System.Drawing.Color.WhiteSmoke;
            this.All_Product.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.All_Product.Location = new System.Drawing.Point(327, 106);
            this.All_Product.Margin = new System.Windows.Forms.Padding(2);
            this.All_Product.Name = "All_Product";
            this.All_Product.Size = new System.Drawing.Size(112, 41);
            this.All_Product.TabIndex = 37;
            this.All_Product.Text = "All Products";
            this.All_Product.UseVisualStyleBackColor = false;
            this.All_Product.Click += new System.EventHandler(this.All_Product_Click);
            // 
            // Stockout_Products
            // 
            this.Stockout_Products.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Stockout_Products.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stockout_Products.Location = new System.Drawing.Point(595, 106);
            this.Stockout_Products.Margin = new System.Windows.Forms.Padding(2);
            this.Stockout_Products.Name = "Stockout_Products";
            this.Stockout_Products.Size = new System.Drawing.Size(112, 41);
            this.Stockout_Products.TabIndex = 38;
            this.Stockout_Products.Text = "Stockout Products";
            this.Stockout_Products.UseVisualStyleBackColor = false;
            this.Stockout_Products.Click += new System.EventHandler(this.Stockout_Products_Click);
            // 
            // Show_Orders
            // 
            this.Show_Orders.BackColor = System.Drawing.Color.Silver;
            this.Show_Orders.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Show_Orders.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Show_Orders.Location = new System.Drawing.Point(327, 331);
            this.Show_Orders.Name = "Show_Orders";
            this.Show_Orders.Size = new System.Drawing.Size(380, 51);
            this.Show_Orders.TabIndex = 46;
            this.Show_Orders.Text = "Orders";
            this.Show_Orders.UseVisualStyleBackColor = false;
            this.Show_Orders.Click += new System.EventHandler(this.Show_Orders_Click);
            // 
            // Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OOP2_Project.Properties.Resources._5378441;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1028, 579);
            this.Controls.Add(this.Show_Orders);
            this.Controls.Add(this.Stockout_Products);
            this.Controls.Add(this.All_Product);
            this.Controls.Add(this.Available_Products);
            this.Controls.Add(this.Products);
            this.Controls.Add(this.Signout);
            this.Controls.Add(this.AddRemove_Product);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(1044, 618);
            this.MinimumSize = new System.Drawing.Size(1044, 618);
            this.Name = "Staff";
            this.Text = "s";
            this.Load += new System.EventHandler(this.Staff_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddRemove_Product;
        private System.Windows.Forms.Button Signout;
        private System.Windows.Forms.Button Products;
        private System.Windows.Forms.Button Available_Products;
        private System.Windows.Forms.Button All_Product;
        private System.Windows.Forms.Button Stockout_Products;
        private System.Windows.Forms.Button Show_Orders;
    }
}