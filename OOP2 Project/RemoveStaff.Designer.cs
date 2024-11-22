namespace OOP2_Project
{
    partial class RemoveStaff
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
            this.Search = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.stDOB = new System.Windows.Forms.DateTimePicker();
            this.stGender = new System.Windows.Forms.TextBox();
            this.stPhone = new System.Windows.Forms.TextBox();
            this.stEmail = new System.Windows.Forms.TextBox();
            this.stName = new System.Windows.Forms.TextBox();
            this.stID = new System.Windows.Forms.TextBox();
            this.DeleteStaff = new System.Windows.Forms.Button();
            this.All_Staff = new System.Windows.Forms.Button();
            this.Staff_ID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Signout
            // 
            this.Signout.BackColor = System.Drawing.Color.LightGray;
            this.Signout.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Signout.Location = new System.Drawing.Point(1195, 629);
            this.Signout.Margin = new System.Windows.Forms.Padding(4);
            this.Signout.Name = "Signout";
            this.Signout.Size = new System.Drawing.Size(128, 47);
            this.Signout.TabIndex = 26;
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
            this.Back.Location = new System.Drawing.Point(44, 630);
            this.Back.Margin = new System.Windows.Forms.Padding(4);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(115, 47);
            this.Back.TabIndex = 25;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(44, 132);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(788, 442);
            this.dataGridView1.TabIndex = 27;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Search.Location = new System.Drawing.Point(184, 90);
            this.Search.Margin = new System.Windows.Forms.Padding(4);
            this.Search.Multiline = true;
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(647, 21);
            this.Search.TabIndex = 29;
            this.Search.TextChanged += new System.EventHandler(this.Search_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Font = new System.Drawing.Font("Candara", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 89);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.MaximumSize = new System.Drawing.Size(107, 23);
            this.label1.MinimumSize = new System.Drawing.Size(107, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 23);
            this.label1.TabIndex = 30;
            this.label1.Text = "Search";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // stDOB
            // 
            this.stDOB.Location = new System.Drawing.Point(1011, 383);
            this.stDOB.Margin = new System.Windows.Forms.Padding(4);
            this.stDOB.Name = "stDOB";
            this.stDOB.Size = new System.Drawing.Size(265, 22);
            this.stDOB.TabIndex = 40;
            // 
            // stGender
            // 
            this.stGender.BackColor = System.Drawing.SystemColors.ControlLight;
            this.stGender.Location = new System.Drawing.Point(1011, 426);
            this.stGender.Margin = new System.Windows.Forms.Padding(4);
            this.stGender.Multiline = true;
            this.stGender.Name = "stGender";
            this.stGender.Size = new System.Drawing.Size(311, 30);
            this.stGender.TabIndex = 38;
            // 
            // stPhone
            // 
            this.stPhone.BackColor = System.Drawing.SystemColors.ControlLight;
            this.stPhone.Location = new System.Drawing.Point(1011, 334);
            this.stPhone.Margin = new System.Windows.Forms.Padding(4);
            this.stPhone.Multiline = true;
            this.stPhone.Name = "stPhone";
            this.stPhone.Size = new System.Drawing.Size(311, 30);
            this.stPhone.TabIndex = 37;
            // 
            // stEmail
            // 
            this.stEmail.BackColor = System.Drawing.SystemColors.ControlLight;
            this.stEmail.Location = new System.Drawing.Point(1011, 284);
            this.stEmail.Margin = new System.Windows.Forms.Padding(4);
            this.stEmail.Multiline = true;
            this.stEmail.Name = "stEmail";
            this.stEmail.Size = new System.Drawing.Size(311, 30);
            this.stEmail.TabIndex = 36;
            // 
            // stName
            // 
            this.stName.BackColor = System.Drawing.SystemColors.ControlLight;
            this.stName.Location = new System.Drawing.Point(1011, 235);
            this.stName.Margin = new System.Windows.Forms.Padding(4);
            this.stName.Multiline = true;
            this.stName.Name = "stName";
            this.stName.Size = new System.Drawing.Size(311, 30);
            this.stName.TabIndex = 35;
            // 
            // stID
            // 
            this.stID.BackColor = System.Drawing.SystemColors.ControlLight;
            this.stID.Location = new System.Drawing.Point(1011, 185);
            this.stID.Margin = new System.Windows.Forms.Padding(4);
            this.stID.Multiline = true;
            this.stID.Name = "stID";
            this.stID.Size = new System.Drawing.Size(311, 30);
            this.stID.TabIndex = 34;
            this.stID.TextChanged += new System.EventHandler(this.stID_TextChanged);
            // 
            // DeleteStaff
            // 
            this.DeleteStaff.BackColor = System.Drawing.Color.LightGray;
            this.DeleteStaff.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteStaff.Location = new System.Drawing.Point(1091, 486);
            this.DeleteStaff.Margin = new System.Windows.Forms.Padding(4);
            this.DeleteStaff.Name = "DeleteStaff";
            this.DeleteStaff.Size = new System.Drawing.Size(128, 33);
            this.DeleteStaff.TabIndex = 41;
            this.DeleteStaff.Text = "Delete";
            this.DeleteStaff.UseVisualStyleBackColor = false;
            this.DeleteStaff.Click += new System.EventHandler(this.DeleteStaff_Click);
            // 
            // All_Staff
            // 
            this.All_Staff.BackColor = System.Drawing.Color.LightGray;
            this.All_Staff.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.All_Staff.Location = new System.Drawing.Point(704, 581);
            this.All_Staff.Margin = new System.Windows.Forms.Padding(4);
            this.All_Staff.Name = "All_Staff";
            this.All_Staff.Size = new System.Drawing.Size(128, 33);
            this.All_Staff.TabIndex = 42;
            this.All_Staff.Text = "All Staff";
            this.All_Staff.UseVisualStyleBackColor = false;
            this.All_Staff.Click += new System.EventHandler(this.All_Staff_Click);
            // 
            // Staff_ID
            // 
            this.Staff_ID.AutoSize = true;
            this.Staff_ID.BackColor = System.Drawing.Color.Transparent;
            this.Staff_ID.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Staff_ID.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Staff_ID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Staff_ID.Location = new System.Drawing.Point(920, 182);
            this.Staff_ID.Margin = new System.Windows.Forms.Padding(4);
            this.Staff_ID.MaximumSize = new System.Drawing.Size(133, 123);
            this.Staff_ID.MinimumSize = new System.Drawing.Size(13, 12);
            this.Staff_ID.Name = "Staff_ID";
            this.Staff_ID.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.Staff_ID.Size = new System.Drawing.Size(73, 36);
            this.Staff_ID.TabIndex = 43;
            this.Staff_ID.Text = "Staff ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(933, 232);
            this.label2.Margin = new System.Windows.Forms.Padding(4);
            this.label2.MaximumSize = new System.Drawing.Size(133, 123);
            this.label2.MinimumSize = new System.Drawing.Size(13, 12);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.label2.Size = new System.Drawing.Size(60, 36);
            this.label2.TabIndex = 44;
            this.label2.Text = "Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(935, 281);
            this.label3.Margin = new System.Windows.Forms.Padding(4);
            this.label3.MaximumSize = new System.Drawing.Size(133, 123);
            this.label3.MinimumSize = new System.Drawing.Size(13, 12);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.label3.Size = new System.Drawing.Size(58, 36);
            this.label3.TabIndex = 45;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label4.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(929, 334);
            this.label4.Margin = new System.Windows.Forms.Padding(4);
            this.label4.MaximumSize = new System.Drawing.Size(133, 123);
            this.label4.MinimumSize = new System.Drawing.Size(13, 12);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.label4.Size = new System.Drawing.Size(64, 36);
            this.label4.TabIndex = 46;
            this.label4.Text = "Phone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label5.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(871, 378);
            this.label5.Margin = new System.Windows.Forms.Padding(4);
            this.label5.MaximumSize = new System.Drawing.Size(133, 123);
            this.label5.MinimumSize = new System.Drawing.Size(13, 12);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.label5.Size = new System.Drawing.Size(122, 36);
            this.label5.TabIndex = 47;
            this.label5.Text = "Date Of Birth";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label6.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(921, 420);
            this.label6.Margin = new System.Windows.Forms.Padding(4);
            this.label6.MaximumSize = new System.Drawing.Size(133, 123);
            this.label6.MinimumSize = new System.Drawing.Size(13, 12);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.label6.Size = new System.Drawing.Size(72, 36);
            this.label6.TabIndex = 48;
            this.label6.Text = "Gender";
            // 
            // RemoveStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OOP2_Project.Properties.Resources.main;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1368, 703);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Staff_ID);
            this.Controls.Add(this.All_Staff);
            this.Controls.Add(this.DeleteStaff);
            this.Controls.Add(this.stDOB);
            this.Controls.Add(this.stGender);
            this.Controls.Add(this.stPhone);
            this.Controls.Add(this.stEmail);
            this.Controls.Add(this.stName);
            this.Controls.Add(this.stID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Signout);
            this.Controls.Add(this.Back);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1386, 750);
            this.MinimumSize = new System.Drawing.Size(1386, 750);
            this.Name = "RemoveStaff";
            this.Text = "RemoveStaff";
            this.Load += new System.EventHandler(this.RemoveStaff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Signout;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox Search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker stDOB;
        private System.Windows.Forms.TextBox stGender;
        private System.Windows.Forms.TextBox stPhone;
        private System.Windows.Forms.TextBox stEmail;
        private System.Windows.Forms.TextBox stName;
        private System.Windows.Forms.TextBox stID;
        private System.Windows.Forms.Button DeleteStaff;
        private System.Windows.Forms.Button All_Staff;
        private System.Windows.Forms.Label Staff_ID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}