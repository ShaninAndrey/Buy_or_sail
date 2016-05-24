namespace Buy_Or_Sail
{
    partial class Form1
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
            this.Advertisment_Add = new System.Windows.Forms.Button();
            this.Theme_string = new System.Windows.Forms.Label();
            this.Theme_check = new System.Windows.Forms.ComboBox();
            this.tegs_box = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Buy = new System.Windows.Forms.CheckBox();
            this.Sell = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Log_in = new System.Windows.Forms.Button();
            this.Sign_in = new System.Windows.Forms.Button();
            this.my_advertisment = new System.Windows.Forms.CheckBox();
            this.delete_advertisment = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Advertisment_Add
            // 
            this.Advertisment_Add.Location = new System.Drawing.Point(12, 185);
            this.Advertisment_Add.Name = "Advertisment_Add";
            this.Advertisment_Add.Size = new System.Drawing.Size(121, 24);
            this.Advertisment_Add.TabIndex = 11;
            this.Advertisment_Add.Text = "Add Advertisment";
            this.Advertisment_Add.UseVisualStyleBackColor = true;
            this.Advertisment_Add.Visible = false;
            this.Advertisment_Add.Click += new System.EventHandler(this.Advertisment_Add_Click);
            // 
            // Theme_string
            // 
            this.Theme_string.AutoSize = true;
            this.Theme_string.Location = new System.Drawing.Point(12, 61);
            this.Theme_string.Name = "Theme_string";
            this.Theme_string.Size = new System.Drawing.Size(75, 13);
            this.Theme_string.TabIndex = 13;
            this.Theme_string.Text = "Choose theme";
            // 
            // Theme_check
            // 
            this.Theme_check.FormattingEnabled = true;
            this.Theme_check.Location = new System.Drawing.Point(12, 77);
            this.Theme_check.Name = "Theme_check";
            this.Theme_check.Size = new System.Drawing.Size(121, 21);
            this.Theme_check.Sorted = true;
            this.Theme_check.TabIndex = 12;
            this.Theme_check.SelectedIndexChanged += new System.EventHandler(this.Theme_check_SelectedIndexChanged);
            this.Theme_check.TextChanged += new System.EventHandler(this.Theme_check_TextChanged);
            // 
            // tegs_box
            // 
            this.tegs_box.Location = new System.Drawing.Point(166, 12);
            this.tegs_box.Multiline = true;
            this.tegs_box.Name = "tegs_box";
            this.tegs_box.Size = new System.Drawing.Size(534, 20);
            this.tegs_box.TabIndex = 14;
            this.tegs_box.TextChanged += new System.EventHandler(this.tegs_box_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dataGridView1.Location = new System.Drawing.Point(166, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(534, 200);
            this.dataGridView1.TabIndex = 19;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridView1_EditingControlShowing_1);
            // 
            // Buy
            // 
            this.Buy.AutoSize = true;
            this.Buy.Location = new System.Drawing.Point(15, 12);
            this.Buy.Name = "Buy";
            this.Buy.Size = new System.Drawing.Size(43, 17);
            this.Buy.TabIndex = 20;
            this.Buy.Text = "Sell";
            this.Buy.UseVisualStyleBackColor = true;
            this.Buy.CheckedChanged += new System.EventHandler(this.Buy_CheckedChanged);
            // 
            // Sell
            // 
            this.Sell.AutoSize = true;
            this.Sell.Location = new System.Drawing.Point(86, 12);
            this.Sell.Name = "Sell";
            this.Sell.Size = new System.Drawing.Size(44, 17);
            this.Sell.TabIndex = 21;
            this.Sell.Text = "Buy";
            this.Sell.UseVisualStyleBackColor = true;
            this.Sell.CheckedChanged += new System.EventHandler(this.Sell_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 65);
            this.label1.TabIndex = 22;
            this.label1.Text = "If you want to add or delete\r\nyour advertisments, you\r\nhave to log in. If your\r\na" +
    "ccount doesn\'t already\r\nexist, you must create it.";
            // 
            // Log_in
            // 
            this.Log_in.Location = new System.Drawing.Point(12, 185);
            this.Log_in.Name = "Log_in";
            this.Log_in.Size = new System.Drawing.Size(47, 65);
            this.Log_in.TabIndex = 23;
            this.Log_in.Text = "Log in";
            this.Log_in.UseVisualStyleBackColor = true;
            this.Log_in.Click += new System.EventHandler(this.Log_in_Click);
            // 
            // Sign_in
            // 
            this.Sign_in.Location = new System.Drawing.Point(86, 185);
            this.Sign_in.Name = "Sign_in";
            this.Sign_in.Size = new System.Drawing.Size(47, 65);
            this.Sign_in.TabIndex = 24;
            this.Sign_in.Text = "Sign up";
            this.Sign_in.UseVisualStyleBackColor = true;
            this.Sign_in.Click += new System.EventHandler(this.Sign_in_Click);
            // 
            // my_advertisment
            // 
            this.my_advertisment.AutoSize = true;
            this.my_advertisment.Location = new System.Drawing.Point(15, 35);
            this.my_advertisment.Name = "my_advertisment";
            this.my_advertisment.Size = new System.Drawing.Size(131, 17);
            this.my_advertisment.TabIndex = 25;
            this.my_advertisment.Text = "Only my advertisments";
            this.my_advertisment.UseVisualStyleBackColor = true;
            this.my_advertisment.Visible = false;
            this.my_advertisment.CheckedChanged += new System.EventHandler(this.my_advertisment_CheckedChanged);
            // 
            // delete_advertisment
            // 
            this.delete_advertisment.Location = new System.Drawing.Point(12, 226);
            this.delete_advertisment.Name = "delete_advertisment";
            this.delete_advertisment.Size = new System.Drawing.Size(121, 23);
            this.delete_advertisment.TabIndex = 26;
            this.delete_advertisment.Text = "Delete Advertisment";
            this.delete_advertisment.UseVisualStyleBackColor = true;
            this.delete_advertisment.Visible = false;
            this.delete_advertisment.Click += new System.EventHandler(this.delete_advertisment_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 27;
            this.label2.Visible = false;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 96);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 17);
            this.listBox1.TabIndex = 28;
            this.listBox1.Visible = false;
            this.listBox1.Click += new System.EventHandler(this.listBox1_Click);
            this.listBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseMove);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(166, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 29;
            this.button1.Text = "Statistic";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 262);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.delete_advertisment);
            this.Controls.Add(this.my_advertisment);
            this.Controls.Add(this.Sign_in);
            this.Controls.Add(this.Log_in);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Sell);
            this.Controls.Add(this.Buy);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tegs_box);
            this.Controls.Add(this.Theme_string);
            this.Controls.Add(this.Theme_check);
            this.Controls.Add(this.Advertisment_Add);
            this.Name = "Form1";
            this.Text = "Buy or Sell";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Advertisment_Add;
        private System.Windows.Forms.Label Theme_string;
        private System.Windows.Forms.TextBox tegs_box;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckBox Buy;
        private System.Windows.Forms.CheckBox Sell;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Log_in;
        private System.Windows.Forms.Button Sign_in;
        private System.Windows.Forms.CheckBox my_advertisment;
        private System.Windows.Forms.Button delete_advertisment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox Theme_check;
        private System.Windows.Forms.Button button1;
    }
}

