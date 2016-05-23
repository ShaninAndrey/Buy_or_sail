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
            this.Content = new System.Windows.Forms.TextBox();
            this.Text = new System.Windows.Forms.TextBox();
            this.Tegs = new System.Windows.Forms.TextBox();
            this.Advertisment_Add = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
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
            this.Buy.CheckedChanged += new System.EventHandler(this.Buy_CheckedChanged);
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
            this.Sail.CheckedChanged += new System.EventHandler(this.Sail_CheckedChanged);
            // 
            // Theme_check
            // 
            this.Theme_check.FormattingEnabled = true;
            this.Theme_check.Location = new System.Drawing.Point(26, 72);
            this.Theme_check.Name = "Theme_check";
            this.Theme_check.Size = new System.Drawing.Size(121, 21);
            this.Theme_check.TabIndex = 3;
            this.Theme_check.SelectionChangeCommitted += new System.EventHandler(this.Theme_check_SelectionChangeCommitted);
            this.Theme_check.TextChanged += new System.EventHandler(this.Theme_check_TextChanged);
            // 
            // Theme_string
            // 
            this.Theme_string.AutoSize = true;
            this.Theme_string.Location = new System.Drawing.Point(23, 50);
            this.Theme_string.Name = "Theme_string";
            this.Theme_string.Size = new System.Drawing.Size(73, 13);
            this.Theme_string.TabIndex = 4;
            this.Theme_string.Text = "Check_theme";
            this.Theme_string.Click += new System.EventHandler(this.Theme_string_Click);
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
            this.Text.TextChanged += new System.EventHandler(this.Text_TextChanged);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 26);
            this.label2.TabIndex = 14;
            this.label2.Text = "Please, choose or write theme\r\nof you advetisment";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Visible = false;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(26, 90);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(121, 17);
            this.listBox1.TabIndex = 15;
            this.listBox1.Visible = false;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // add_advertisment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 317);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Advertisment_Add);
            this.Controls.Add(this.Tegs);
            this.Controls.Add(this.Text);
            this.Controls.Add(this.Content);
            this.Controls.Add(this.Theme_string);
            this.Controls.Add(this.Theme_check);
            this.Controls.Add(this.Sail);
            this.Controls.Add(this.Buy);
            this.Name = "add_advertisment";
            this.Load += new System.EventHandler(this.add_advertisment_Load);
            this.Click += new System.EventHandler(this.add_advertisment_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton Buy;
        private System.Windows.Forms.RadioButton Sail;
        private System.Windows.Forms.ComboBox Theme_check;
        private System.Windows.Forms.Label Theme_string;
        private System.Windows.Forms.TextBox Content;
        private System.Windows.Forms.TextBox Text;
        private System.Windows.Forms.TextBox Tegs;
        private System.Windows.Forms.Button Advertisment_Add;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox1;
    }
}