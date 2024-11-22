using System;

namespace OOP2_Project
{
    partial class Register
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.TextBox();
            this.Name_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.TextBox();
            this.DateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.Phone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Male_Radio = new System.Windows.Forms.RadioButton();
            this.Female_Radio = new System.Windows.Forms.RadioButton();
            this.Other_Radio = new System.Windows.Forms.RadioButton();
            this.Back = new System.Windows.Forms.Button();
            this.Signup = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::OOP2_Project.Properties.Resources._32officeicons_31_89708;
            this.pictureBox1.Location = new System.Drawing.Point(516, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(227, 419);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.MaximumSize = new System.Drawing.Size(120, 50);
            this.label2.MinimumSize = new System.Drawing.Size(70, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 40);
            this.label2.TabIndex = 9;
            this.label2.Text = "Date of Birth";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(286, 285);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.MaximumSize = new System.Drawing.Size(100, 100);
            this.label1.MinimumSize = new System.Drawing.Size(10, 10);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.label1.Size = new System.Drawing.Size(55, 33);
            this.label1.TabIndex = 8;
            this.label1.Text = "Email";
            // 
            // Email
            // 
            this.Email.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Email.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.Email.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.Location = new System.Drawing.Point(367, 293);
            this.Email.Multiline = true;
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(408, 25);
            this.Email.TabIndex = 7;
            this.Email.Click += new System.EventHandler(this.Email_Click);
            this.Email.TextChanged += new System.EventHandler(this.Email_TextChanged);
            // 
            // Name_txt
            // 
            this.Name_txt.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Name_txt.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_txt.Location = new System.Drawing.Point(367, 163);
            this.Name_txt.Multiline = true;
            this.Name_txt.Name = "Name_txt";
            this.Name_txt.Size = new System.Drawing.Size(408, 25);
            this.Name_txt.TabIndex = 6;
            this.Name_txt.Click += new System.EventHandler(this.Name_txt_Click);
            this.Name_txt.TextChanged += new System.EventHandler(this.Name_txt_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(283, 159);
            this.label3.Margin = new System.Windows.Forms.Padding(3);
            this.label3.MaximumSize = new System.Drawing.Size(100, 100);
            this.label3.MinimumSize = new System.Drawing.Size(10, 10);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.label3.Size = new System.Drawing.Size(58, 33);
            this.label3.TabIndex = 11;
            this.label3.Text = "Name";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label4.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(252, 354);
            this.label4.Margin = new System.Windows.Forms.Padding(3);
            this.label4.MaximumSize = new System.Drawing.Size(100, 100);
            this.label4.MinimumSize = new System.Drawing.Size(10, 10);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.label4.Size = new System.Drawing.Size(89, 33);
            this.label4.TabIndex = 13;
            this.label4.Text = "Password";
            // 
            // Password
            // 
            this.Password.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Password.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.Location = new System.Drawing.Point(367, 358);
            this.Password.Multiline = true;
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.Size = new System.Drawing.Size(408, 25);
            this.Password.TabIndex = 12;
            this.Password.Click += new System.EventHandler(this.Password_Click);
            this.Password.TextChanged += new System.EventHandler(this.Password_TextChanged);
            // 
            // DateOfBirth
            // 
            this.DateOfBirth.CalendarFont = new System.Drawing.Font("Candara Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateOfBirth.CustomFormat = "yyyy-MM-dd";
            this.DateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateOfBirth.Location = new System.Drawing.Point(367, 420);
            this.DateOfBirth.Name = "DateOfBirth";
            this.DateOfBirth.Size = new System.Drawing.Size(200, 20);
            this.DateOfBirth.TabIndex = 14;
            // 
            // Phone
            // 
            this.Phone.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Phone.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Phone.Location = new System.Drawing.Point(367, 223);
            this.Phone.Multiline = true;
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(408, 25);
            this.Phone.TabIndex = 15;
            this.Phone.Click += new System.EventHandler(this.Phone_Click);
            this.Phone.TextChanged += new System.EventHandler(this.Phone_TextChanged);
            this.Phone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Phone_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label5.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(279, 215);
            this.label5.Margin = new System.Windows.Forms.Padding(3);
            this.label5.MaximumSize = new System.Drawing.Size(100, 100);
            this.label5.MinimumSize = new System.Drawing.Size(10, 10);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.label5.Size = new System.Drawing.Size(62, 33);
            this.label5.TabIndex = 16;
            this.label5.Text = "Phone";
            // 
            // Male_Radio
            // 
            this.Male_Radio.AutoSize = true;
            this.Male_Radio.BackColor = System.Drawing.Color.Transparent;
            this.Male_Radio.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Male_Radio.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Male_Radio.Location = new System.Drawing.Point(367, 475);
            this.Male_Radio.Name = "Male_Radio";
            this.Male_Radio.Size = new System.Drawing.Size(52, 19);
            this.Male_Radio.TabIndex = 17;
            this.Male_Radio.TabStop = true;
            this.Male_Radio.Text = "Male";
            this.Male_Radio.UseVisualStyleBackColor = false;
            this.Male_Radio.CheckedChanged += new System.EventHandler(this.Male_Radio_CheckedChanged);
            // 
            // Female_Radio
            // 
            this.Female_Radio.AutoSize = true;
            this.Female_Radio.BackColor = System.Drawing.Color.Transparent;
            this.Female_Radio.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Female_Radio.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Female_Radio.Location = new System.Drawing.Point(436, 475);
            this.Female_Radio.Name = "Female_Radio";
            this.Female_Radio.Size = new System.Drawing.Size(65, 19);
            this.Female_Radio.TabIndex = 18;
            this.Female_Radio.TabStop = true;
            this.Female_Radio.Text = "Female";
            this.Female_Radio.UseVisualStyleBackColor = false;
            // 
            // Other_Radio
            // 
            this.Other_Radio.AutoSize = true;
            this.Other_Radio.BackColor = System.Drawing.Color.Transparent;
            this.Other_Radio.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Other_Radio.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Other_Radio.Location = new System.Drawing.Point(516, 475);
            this.Other_Radio.Name = "Other_Radio";
            this.Other_Radio.Size = new System.Drawing.Size(58, 19);
            this.Other_Radio.TabIndex = 19;
            this.Other_Radio.TabStop = true;
            this.Other_Radio.Text = "Other";
            this.Other_Radio.UseVisualStyleBackColor = false;
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
            this.Back.TabIndex = 21;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Signup
            // 
            this.Signup.BackColor = System.Drawing.Color.LightGray;
            this.Signup.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Signup.Location = new System.Drawing.Point(896, 511);
            this.Signup.Name = "Signup";
            this.Signup.Size = new System.Drawing.Size(96, 38);
            this.Signup.TabIndex = 22;
            this.Signup.Text = "Sign Up";
            this.Signup.UseVisualStyleBackColor = false;
            this.Signup.Click += new System.EventHandler(this.Signup_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OOP2_Project.Properties.Resources._537844;
            this.ClientSize = new System.Drawing.Size(1028, 578);
            this.Controls.Add(this.Signup);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Other_Radio);
            this.Controls.Add(this.Female_Radio);
            this.Controls.Add(this.Male_Radio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Phone);
            this.Controls.Add(this.DateOfBirth);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Name_txt);
            this.MaximumSize = new System.Drawing.Size(1044, 617);
            this.MinimumSize = new System.Drawing.Size(1044, 617);
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label3_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.TextBox Name_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.DateTimePicker DateOfBirth;
        private System.Windows.Forms.TextBox Phone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton Male_Radio;
        private System.Windows.Forms.RadioButton Female_Radio;
        private System.Windows.Forms.RadioButton Other_Radio;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button Signup;
    }
}