namespace Buy_Or_Sail
{
    partial class advertisment_viev
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
            this.Content1 = new System.Windows.Forms.TextBox();
            this.Text1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Name1 = new System.Windows.Forms.Label();
            this.User_name = new System.Windows.Forms.Label();
            this.Telephone1 = new System.Windows.Forms.Label();
            this.Telephone = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Content1
            // 
            this.Content1.Location = new System.Drawing.Point(12, 12);
            this.Content1.Name = "Content1";
            this.Content1.ReadOnly = true;
            this.Content1.Size = new System.Drawing.Size(550, 20);
            this.Content1.TabIndex = 7;
            // 
            // Text1
            // 
            this.Text1.Location = new System.Drawing.Point(12, 55);
            this.Text1.Multiline = true;
            this.Text1.Name = "Text1";
            this.Text1.ReadOnly = true;
            this.Text1.Size = new System.Drawing.Size(550, 202);
            this.Text1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(380, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 9;
            // 
            // Name1
            // 
            this.Name1.AutoSize = true;
            this.Name1.Location = new System.Drawing.Point(12, 277);
            this.Name1.Name = "Name1";
            this.Name1.Size = new System.Drawing.Size(41, 13);
            this.Name1.TabIndex = 10;
            this.Name1.Text = "Name :";
            // 
            // User_name
            // 
            this.User_name.AutoSize = true;
            this.User_name.Location = new System.Drawing.Point(59, 277);
            this.User_name.Name = "User_name";
            this.User_name.Size = new System.Drawing.Size(0, 13);
            this.User_name.TabIndex = 11;
            // 
            // Telephone1
            // 
            this.Telephone1.AutoSize = true;
            this.Telephone1.Location = new System.Drawing.Point(229, 277);
            this.Telephone1.Name = "Telephone1";
            this.Telephone1.Size = new System.Drawing.Size(102, 13);
            this.Telephone1.TabIndex = 12;
            this.Telephone1.Text = "Telephone number :";
            // 
            // Telephone
            // 
            this.Telephone.AutoSize = true;
            this.Telephone.Location = new System.Drawing.Point(338, 277);
            this.Telephone.Name = "Telephone";
            this.Telephone.Size = new System.Drawing.Size(0, 13);
            this.Telephone.TabIndex = 13;
            // 
            // advertisment_viev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 302);
            this.Controls.Add(this.Telephone);
            this.Controls.Add(this.Telephone1);
            this.Controls.Add(this.User_name);
            this.Controls.Add(this.Name1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Text1);
            this.Controls.Add(this.Content1);
            this.Name = "advertisment_viev";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Content1;
        private System.Windows.Forms.TextBox Text1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Name1;
        private System.Windows.Forms.Label User_name;
        private System.Windows.Forms.Label Telephone1;
        private System.Windows.Forms.Label Telephone;
    }
}