namespace OOP2_Project
{
    partial class BuyProducts
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
            this.Signout.TabIndex = 25;
            this.Signout.Text = "Sign  Out";
            this.Signout.UseVisualStyleBackColor = false;
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
            this.Back.TabIndex = 43;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = false;
            // 
            // BuyProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OOP2_Project.Properties.Resources.main;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1368, 705);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Signout);
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(1386, 752);
            this.MinimumSize = new System.Drawing.Size(1386, 752);
            this.Name = "BuyProducts";
            this.Text = "BuyProducts";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Signout;
        private System.Windows.Forms.Button Back;
    }
}