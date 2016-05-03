namespace Buy_Or_Sail
{
    partial class add_advertisment
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
            this.Buy = new System.Windows.Forms.RadioButton();
            this.Sail = new System.Windows.Forms.RadioButton();
            this.Theme_check = new System.Windows.Forms.ComboBox();
            this.Theme_string = new System.Windows.Forms.Label();
            this.Theme_add_string = new System.Windows.Forms.TextBox();
            this.Content = new System.Windows.Forms.TextBox();
            this.Text = new System.Windows.Forms.TextBox();
            this.Tegs = new System.Windows.Forms.TextBox();
            this.Advertisment_Add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Buy
            // 
            this.Buy.AutoSize = true;
            this.Buy.Location = new System.Drawing.Point(26, 12);
            this.Buy.Name = "Buy";
            this.Buy.Size = new System.Drawing.Size(43, 17);
            this.Buy.TabIndex = 0;
            this.Buy.TabStop = true;
            this.Buy.Text = "Buy";
            this.Buy.UseVisualStyleBackColor = true;
            // 
            // Sail
            // 
            this.Sail.AutoSize = true;
            this.Sail.Location = new System.Drawing.Point(105, 13);
            this.Sail.Name = "Sail";
            this.Sail.Size = new System.Drawing.Size(42, 17);
            this.Sail.TabIndex = 1;
            this.Sail.TabStop = true;
            this.Sail.Text = "Sail";
            this.Sail.UseVisualStyleBackColor = true;
            // 
            // Theme_check
            // 
            this.Theme_check.FormattingEnabled = true;
            this.Theme_check.Location = new System.Drawing.Point(26, 63);
            this.Theme_check.Name = "Theme_check";
            this.Theme_check.Size = new System.Drawing.Size(121, 21);
            this.Theme_check.TabIndex = 3;
            // 
            // Theme_string
            // 
            this.Theme_string.AutoSize = true;
            this.Theme_string.Location = new System.Drawing.Point(23, 41);
            this.Theme_string.Name = "Theme_string";
            this.Theme_string.Size = new System.Drawing.Size(73, 13);
            this.Theme_string.TabIndex = 4;
            this.Theme_string.Text = "Check_theme";
            // 
            // Theme_add_string
            // 
            this.Theme_add_string.Location = new System.Drawing.Point(26, 115);
            this.Theme_add_string.Name = "Theme_add_string";
            this.Theme_add_string.Size = new System.Drawing.Size(121, 20);
            this.Theme_add_string.TabIndex = 5;
            // 
            // Content
            // 
            this.Content.Location = new System.Drawing.Point(176, 12);
            this.Content.Name = "Content";
            this.Content.Size = new System.Drawing.Size(386, 20);
            this.Content.TabIndex = 7;
            this.Content.Text = "Content";
            this.Content.Click += new System.EventHandler(this.Content_Click);
            // 
            // Text
            // 
            this.Text.Location = new System.Drawing.Point(176, 38);
            this.Text.Multiline = true;
            this.Text.Name = "Text";
            this.Text.Size = new System.Drawing.Size(386, 231);
            this.Text.TabIndex = 8;
            this.Text.Text = "Text";
            this.Text.Click += new System.EventHandler(this.Text_Click);
            // 
            // Tegs
            // 
            this.Tegs.Location = new System.Drawing.Point(176, 285);
            this.Tegs.Name = "Tegs";
            this.Tegs.Size = new System.Drawing.Size(386, 20);
            this.Tegs.TabIndex = 9;
            this.Tegs.Text = "Tegs";
            this.Tegs.Click += new System.EventHandler(this.Tegs_Click);
            // 
            // Advertisment_Add
            // 
            this.Advertisment_Add.Location = new System.Drawing.Point(26, 240);
            this.Advertisment_Add.Name = "Advertisment_Add";
            this.Advertisment_Add.Size = new System.Drawing.Size(121, 65);
            this.Advertisment_Add.TabIndex = 10;
            this.Advertisment_Add.Text = "Add Advertisment";
            this.Advertisment_Add.UseVisualStyleBackColor = true;
            this.Advertisment_Add.Click += new System.EventHandler(this.Advertisment_Add_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Your theme";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 26);
            this.label2.TabIndex = 14;
            this.label2.Text = "Please, choose or write theme\r\nof you advetisment";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Visible = false;
            // 
            // add_advertisment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 317);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Advertisment_Add);
            this.Controls.Add(this.Tegs);
            this.Controls.Add(this.Text);
            this.Controls.Add(this.Content);
            this.Controls.Add(this.Theme_add_string);
            this.Controls.Add(this.Theme_string);
            this.Controls.Add(this.Theme_check);
            this.Controls.Add(this.Sail);
            this.Controls.Add(this.Buy);
            this.Name = "add_advertisment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton Buy;
        private System.Windows.Forms.RadioButton Sail;
        private System.Windows.Forms.ComboBox Theme_check;
        private System.Windows.Forms.Label Theme_string;
        private System.Windows.Forms.TextBox Theme_add_string;
        private System.Windows.Forms.TextBox Content;
        private System.Windows.Forms.TextBox Text;
        private System.Windows.Forms.TextBox Tegs;
        private System.Windows.Forms.Button Advertisment_Add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}