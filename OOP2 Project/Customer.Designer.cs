namespace OOP2_Project
{
    partial class Customer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer));
            this.Signout = new System.Windows.Forms.Button();
            this.Buy_Products = new System.Windows.Forms.Button();
            this.Build_A_Pc = new System.Windows.Forms.Button();
            this.buy_product_image = new System.Windows.Forms.PictureBox();
            this.build_a_PC_image = new System.Windows.Forms.PictureBox();
            this.Back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.buy_product_image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.build_a_PC_image)).BeginInit();
            this.SuspendLayout();
            // 
            // Signout
            // 
            this.Signout.BackColor = System.Drawing.Color.LightGray;
            this.Signout.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Signout.Location = new System.Drawing.Point(896, 511);
            this.Signout.Name = "Signout";
            this.Signout.Size = new System.Drawing.Size(96, 38);
            this.Signout.TabIndex = 24;
            this.Signout.Text = "Sign  Out";
            this.Signout.UseVisualStyleBackColor = false;
            this.Signout.Click += new System.EventHandler(this.Signout_Click);
            // 
            // Buy_Products
            // 
            this.Buy_Products.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Buy_Products.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Buy_Products.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Buy_Products.Location = new System.Drawing.Point(43, 372);
            this.Buy_Products.Name = "Buy_Products";
            this.Buy_Products.Size = new System.Drawing.Size(380, 51);
            this.Buy_Products.TabIndex = 30;
            this.Buy_Products.Text = "Buy Products";
            this.Buy_Products.UseVisualStyleBackColor = false;
            this.Buy_Products.Click += new System.EventHandler(this.Buy_Products_Click);
            // 
            // Build_A_Pc
            // 
            this.Build_A_Pc.BackColor = System.Drawing.Color.Silver;
            this.Build_A_Pc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Build_A_Pc.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Build_A_Pc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Build_A_Pc.Location = new System.Drawing.Point(570, 372);
            this.Build_A_Pc.Name = "Build_A_Pc";
            this.Build_A_Pc.Size = new System.Drawing.Size(380, 51);
            this.Build_A_Pc.TabIndex = 29;
            this.Build_A_Pc.Text = "Build A PC!";
            this.Build_A_Pc.UseVisualStyleBackColor = false;
            this.Build_A_Pc.Click += new System.EventHandler(this.Build_A_Pc_Click);
            // 
            // buy_product_image
            // 
            this.buy_product_image.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buy_product_image.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buy_product_image.BackgroundImage")));
            this.buy_product_image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buy_product_image.Location = new System.Drawing.Point(82, 135);
            this.buy_product_image.Margin = new System.Windows.Forms.Padding(2);
            this.buy_product_image.Name = "buy_product_image";
            this.buy_product_image.Size = new System.Drawing.Size(308, 220);
            this.buy_product_image.TabIndex = 32;
            this.buy_product_image.TabStop = false;
            // 
            // build_a_PC_image
            // 
            this.build_a_PC_image.BackColor = System.Drawing.Color.Silver;
            this.build_a_PC_image.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("build_a_PC_image.BackgroundImage")));
            this.build_a_PC_image.Location = new System.Drawing.Point(604, 135);
            this.build_a_PC_image.Margin = new System.Windows.Forms.Padding(2);
            this.build_a_PC_image.Name = "build_a_PC_image";
            this.build_a_PC_image.Size = new System.Drawing.Size(308, 220);
            this.build_a_PC_image.TabIndex = 33;
            this.build_a_PC_image.TabStop = false;
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.LightGray;
            this.Back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Back.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.ForeColor = System.Drawing.Color.Black;
            this.Back.Location = new System.Drawing.Point(43, 511);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(86, 38);
            this.Back.TabIndex = 34;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OOP2_Project.Properties.Resources.main;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1028, 579);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.build_a_PC_image);
            this.Controls.Add(this.buy_product_image);
            this.Controls.Add(this.Buy_Products);
            this.Controls.Add(this.Build_A_Pc);
            this.Controls.Add(this.Signout);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(1044, 618);
            this.MinimumSize = new System.Drawing.Size(1044, 618);
            this.Name = "Customer";
            this.Text = "Customer";
            ((System.ComponentModel.ISupportInitialize)(this.buy_product_image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.build_a_PC_image)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Signout;
        private System.Windows.Forms.Button Buy_Products;
        private System.Windows.Forms.Button Build_A_Pc;
        private System.Windows.Forms.PictureBox buy_product_image;
        private System.Windows.Forms.PictureBox build_a_PC_image;
        private System.Windows.Forms.Button Back;
    }
}