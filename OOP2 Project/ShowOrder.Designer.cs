namespace OOP2_Project
{
    partial class ShowOrder
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Pc_Build_Orders = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Back = new System.Windows.Forms.Button();
            this.Signout = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Type_combo = new System.Windows.Forms.ComboBox();
            this.Search_txt = new System.Windows.Forms.TextBox();
            this.Search_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(261, 128);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(507, 320);
            this.dataGridView1.TabIndex = 0;
            // 
            // Pc_Build_Orders
            // 
            this.Pc_Build_Orders.Location = new System.Drawing.Point(490, 454);
            this.Pc_Build_Orders.Name = "Pc_Build_Orders";
            this.Pc_Build_Orders.Size = new System.Drawing.Size(137, 33);
            this.Pc_Build_Orders.TabIndex = 1;
            this.Pc_Build_Orders.Text = "All PC Build Orders";
            this.Pc_Build_Orders.UseVisualStyleBackColor = true;
            this.Pc_Build_Orders.Click += new System.EventHandler(this.Pc_Build_Orders_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(633, 454);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 33);
            this.button2.TabIndex = 2;
            this.button2.Text = "All Individual Orders";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(515, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Order List";
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.LightGray;
            this.Back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Back.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.ForeColor = System.Drawing.Color.Black;
            this.Back.Location = new System.Drawing.Point(34, 505);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(86, 38);
            this.Back.TabIndex = 59;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Signout
            // 
            this.Signout.BackColor = System.Drawing.Color.LightGray;
            this.Signout.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Signout.Location = new System.Drawing.Point(897, 504);
            this.Signout.Name = "Signout";
            this.Signout.Size = new System.Drawing.Size(96, 38);
            this.Signout.TabIndex = 60;
            this.Signout.Text = "Sign  Out";
            this.Signout.UseVisualStyleBackColor = false;
            this.Signout.Click += new System.EventHandler(this.Signout_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(270, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 62;
            this.label3.Text = "Order Type";
            // 
            // Type_combo
            // 
            this.Type_combo.FormattingEnabled = true;
            this.Type_combo.Items.AddRange(new object[] {
            "Individual",
            "PC Builds"});
            this.Type_combo.Location = new System.Drawing.Point(362, 66);
            this.Type_combo.Name = "Type_combo";
            this.Type_combo.Size = new System.Drawing.Size(406, 21);
            this.Type_combo.TabIndex = 63;
            // 
            // Search_txt
            // 
            this.Search_txt.Location = new System.Drawing.Point(362, 102);
            this.Search_txt.Name = "Search_txt";
            this.Search_txt.Size = new System.Drawing.Size(406, 20);
            this.Search_txt.TabIndex = 64;
            this.Search_txt.TextChanged += new System.EventHandler(this.Search_txt_TextChanged);
            this.Search_txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Search_txt_KeyDown);
            this.Search_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Search_txt_KeyPress);
            // 
            // Search_Button
            // 
            this.Search_Button.Location = new System.Drawing.Point(261, 99);
            this.Search_Button.Name = "Search_Button";
            this.Search_Button.Size = new System.Drawing.Size(84, 23);
            this.Search_Button.TabIndex = 65;
            this.Search_Button.Text = "Search";
            this.Search_Button.UseVisualStyleBackColor = true;
            this.Search_Button.Click += new System.EventHandler(this.Search_Button_Click);
            // 
            // ShowOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OOP2_Project.Properties.Resources.main;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1028, 579);
            this.Controls.Add(this.Search_Button);
            this.Controls.Add(this.Search_txt);
            this.Controls.Add(this.Type_combo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Signout);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Pc_Build_Orders);
            this.Controls.Add(this.dataGridView1);
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(1044, 618);
            this.MinimumSize = new System.Drawing.Size(1044, 618);
            this.Name = "ShowOrder";
            this.Text = "ShowOrder";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Pc_Build_Orders;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button Signout;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Type_combo;
        private System.Windows.Forms.TextBox Search_txt;
        private System.Windows.Forms.Button Search_Button;
    }
}