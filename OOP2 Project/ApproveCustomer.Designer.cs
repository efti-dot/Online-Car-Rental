namespace OOP2_Project
{
    partial class ApproveCustomer
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
            this.components = new System.ComponentModel.Container();
            this.Back = new System.Windows.Forms.Button();
            this.Signout = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.titanTechDataSet = new OOP2_Project.TitanTechDataSet();
            this.ShowCustomer = new System.Windows.Forms.Button();
            this.customerTableAdapter = new OOP2_Project.TitanTechDataSetTableAdapters.CustomerTableAdapter();
            this.cusID = new System.Windows.Forms.TextBox();
            this.cusName = new System.Windows.Forms.TextBox();
            this.cusEmail = new System.Windows.Forms.TextBox();
            this.cusPhone = new System.Windows.Forms.TextBox();
            this.cusGender = new System.Windows.Forms.TextBox();
            this.cusStatus = new System.Windows.Forms.TextBox();
            this.Approve = new System.Windows.Forms.Button();
            this.Staff_ID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cusDOB = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.titanTechDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.LightGray;
            this.Back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Back.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.ForeColor = System.Drawing.Color.Black;
            this.Back.Location = new System.Drawing.Point(33, 512);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(86, 38);
            this.Back.TabIndex = 22;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Signout
            // 
            this.Signout.BackColor = System.Drawing.Color.LightGray;
            this.Signout.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Signout.Location = new System.Drawing.Point(896, 511);
            this.Signout.Name = "Signout";
            this.Signout.Size = new System.Drawing.Size(96, 38);
            this.Signout.TabIndex = 23;
            this.Signout.Text = "Sign Out";
            this.Signout.UseVisualStyleBackColor = false;
            this.Signout.Click += new System.EventHandler(this.Signout_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeight = 50;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Location = new System.Drawing.Point(22, 105);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 100;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.Size = new System.Drawing.Size(604, 369);
            this.dataGridView1.TabIndex = 24;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.titanTechDataSet;
            // 
            // titanTechDataSet
            // 
            this.titanTechDataSet.DataSetName = "TitanTechDataSet";
            this.titanTechDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ShowCustomer
            // 
            this.ShowCustomer.BackColor = System.Drawing.SystemColors.Control;
            this.ShowCustomer.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowCustomer.Location = new System.Drawing.Point(499, 55);
            this.ShowCustomer.Name = "ShowCustomer";
            this.ShowCustomer.Size = new System.Drawing.Size(128, 44);
            this.ShowCustomer.TabIndex = 25;
            this.ShowCustomer.Text = "Show Customer";
            this.ShowCustomer.UseVisualStyleBackColor = false;
            this.ShowCustomer.Click += new System.EventHandler(this.ShowCustomer_Click);
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // cusID
            // 
            this.cusID.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cusID.Location = new System.Drawing.Point(782, 105);
            this.cusID.Multiline = true;
            this.cusID.Name = "cusID";
            this.cusID.Size = new System.Drawing.Size(234, 25);
            this.cusID.TabIndex = 26;
            this.cusID.TextChanged += new System.EventHandler(this.cusID_TextChanged);
            // 
            // cusName
            // 
            this.cusName.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cusName.Location = new System.Drawing.Point(782, 146);
            this.cusName.Multiline = true;
            this.cusName.Name = "cusName";
            this.cusName.Size = new System.Drawing.Size(234, 25);
            this.cusName.TabIndex = 27;
            this.cusName.TextChanged += new System.EventHandler(this.cusName_TextChanged);
            // 
            // cusEmail
            // 
            this.cusEmail.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cusEmail.Location = new System.Drawing.Point(782, 186);
            this.cusEmail.Multiline = true;
            this.cusEmail.Name = "cusEmail";
            this.cusEmail.Size = new System.Drawing.Size(234, 25);
            this.cusEmail.TabIndex = 28;
            this.cusEmail.TextChanged += new System.EventHandler(this.cusEmail_TextChanged);
            // 
            // cusPhone
            // 
            this.cusPhone.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cusPhone.Location = new System.Drawing.Point(782, 226);
            this.cusPhone.Multiline = true;
            this.cusPhone.Name = "cusPhone";
            this.cusPhone.Size = new System.Drawing.Size(234, 25);
            this.cusPhone.TabIndex = 29;
            this.cusPhone.TextChanged += new System.EventHandler(this.cusPhone_TextChanged);
            // 
            // cusGender
            // 
            this.cusGender.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cusGender.Location = new System.Drawing.Point(782, 301);
            this.cusGender.Multiline = true;
            this.cusGender.Name = "cusGender";
            this.cusGender.ReadOnly = true;
            this.cusGender.Size = new System.Drawing.Size(234, 25);
            this.cusGender.TabIndex = 31;
            this.cusGender.TextChanged += new System.EventHandler(this.cusGender_TextChanged);
            // 
            // cusStatus
            // 
            this.cusStatus.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cusStatus.Location = new System.Drawing.Point(782, 342);
            this.cusStatus.Multiline = true;
            this.cusStatus.Name = "cusStatus";
            this.cusStatus.ReadOnly = true;
            this.cusStatus.Size = new System.Drawing.Size(234, 25);
            this.cusStatus.TabIndex = 32;
            this.cusStatus.TextChanged += new System.EventHandler(this.cusStatus_TextChanged);
            // 
            // Approve
            // 
            this.Approve.BackColor = System.Drawing.Color.LightGray;
            this.Approve.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Approve.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Approve.ForeColor = System.Drawing.Color.Black;
            this.Approve.Location = new System.Drawing.Point(862, 388);
            this.Approve.Name = "Approve";
            this.Approve.Size = new System.Drawing.Size(86, 38);
            this.Approve.TabIndex = 34;
            this.Approve.Text = "Approve";
            this.Approve.UseVisualStyleBackColor = false;
            this.Approve.Click += new System.EventHandler(this.Approve_Click);
            // 
            // Staff_ID
            // 
            this.Staff_ID.AutoSize = true;
            this.Staff_ID.BackColor = System.Drawing.Color.Transparent;
            this.Staff_ID.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Staff_ID.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Staff_ID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Staff_ID.Location = new System.Drawing.Point(680, 102);
            this.Staff_ID.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.Staff_ID.MaximumSize = new System.Drawing.Size(100, 100);
            this.Staff_ID.MinimumSize = new System.Drawing.Size(10, 10);
            this.Staff_ID.Name = "Staff_ID";
            this.Staff_ID.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.Staff_ID.Size = new System.Drawing.Size(93, 29);
            this.Staff_ID.TabIndex = 44;
            this.Staff_ID.Text = "Customer ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(722, 144);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.label1.MaximumSize = new System.Drawing.Size(100, 100);
            this.label1.MinimumSize = new System.Drawing.Size(10, 10);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.label1.Size = new System.Drawing.Size(49, 29);
            this.label1.TabIndex = 45;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(723, 184);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.label2.MaximumSize = new System.Drawing.Size(100, 100);
            this.label2.MinimumSize = new System.Drawing.Size(10, 10);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.label2.Size = new System.Drawing.Size(46, 29);
            this.label2.TabIndex = 46;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(718, 223);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.label3.MaximumSize = new System.Drawing.Size(100, 100);
            this.label3.MinimumSize = new System.Drawing.Size(10, 10);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.label3.Size = new System.Drawing.Size(53, 29);
            this.label3.TabIndex = 47;
            this.label3.Text = "Phone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label4.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(675, 259);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.label4.MaximumSize = new System.Drawing.Size(100, 100);
            this.label4.MinimumSize = new System.Drawing.Size(10, 10);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.label4.Size = new System.Drawing.Size(99, 29);
            this.label4.TabIndex = 48;
            this.label4.Text = "Date Of Birth";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label5.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(712, 298);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.label5.MaximumSize = new System.Drawing.Size(100, 100);
            this.label5.MinimumSize = new System.Drawing.Size(10, 10);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.label5.Size = new System.Drawing.Size(59, 29);
            this.label5.TabIndex = 49;
            this.label5.Text = "Gender";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label6.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(719, 340);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.label6.MaximumSize = new System.Drawing.Size(100, 100);
            this.label6.MinimumSize = new System.Drawing.Size(10, 10);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.label6.Size = new System.Drawing.Size(53, 29);
            this.label6.TabIndex = 50;
            this.label6.Text = "Status";
            // 
            // cusDOB
            // 
            this.cusDOB.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cusDOB.Location = new System.Drawing.Point(780, 263);
            this.cusDOB.Multiline = true;
            this.cusDOB.Name = "cusDOB";
            this.cusDOB.ReadOnly = true;
            this.cusDOB.Size = new System.Drawing.Size(236, 25);
            this.cusDOB.TabIndex = 51;
            // 
            // ApproveCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OOP2_Project.Properties.Resources.main;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1028, 578);
            this.Controls.Add(this.cusDOB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Staff_ID);
            this.Controls.Add(this.Approve);
            this.Controls.Add(this.cusStatus);
            this.Controls.Add(this.cusGender);
            this.Controls.Add(this.cusPhone);
            this.Controls.Add(this.cusEmail);
            this.Controls.Add(this.cusName);
            this.Controls.Add(this.cusID);
            this.Controls.Add(this.ShowCustomer);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Signout);
            this.Controls.Add(this.Back);
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(1044, 617);
            this.MinimumSize = new System.Drawing.Size(1044, 617);
            this.Name = "ApproveCustomer";
            this.Text = "ApproveCustomer";
            this.Load += new System.EventHandler(this.ApproveCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.titanTechDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button Signout;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ShowCustomer;
        private TitanTechDataSet titanTechDataSet;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private TitanTechDataSetTableAdapters.CustomerTableAdapter customerTableAdapter;
        private System.Windows.Forms.TextBox cusID;
        private System.Windows.Forms.TextBox cusName;
        private System.Windows.Forms.TextBox cusEmail;
        private System.Windows.Forms.TextBox cusPhone;
        private System.Windows.Forms.TextBox cusGender;
        private System.Windows.Forms.TextBox cusStatus;
        private System.Windows.Forms.Button Approve;
        private System.Windows.Forms.Label Staff_ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox cusDOB;
    }
}