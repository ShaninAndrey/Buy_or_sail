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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Advertisment_Add
            // 
            this.Advertisment_Add.Location = new System.Drawing.Point(12, 175);
            this.Advertisment_Add.Name = "Advertisment_Add";
            this.Advertisment_Add.Size = new System.Drawing.Size(121, 65);
            this.Advertisment_Add.TabIndex = 11;
            this.Advertisment_Add.Text = "Add Advertisment";
            this.Advertisment_Add.UseVisualStyleBackColor = true;
            this.Advertisment_Add.Click += new System.EventHandler(this.Advertisment_Add_Click);
            // 
            // Theme_string
            // 
            this.Theme_string.AutoSize = true;
            this.Theme_string.Location = new System.Drawing.Point(12, 50);
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
            this.Theme_check.TabIndex = 12;
            this.Theme_check.SelectedIndexChanged += new System.EventHandler(this.Theme_check_SelectedIndexChanged);
            // 
            // tegs_box
            // 
            this.tegs_box.Location = new System.Drawing.Point(166, 12);
            this.tegs_box.Multiline = true;
            this.tegs_box.Name = "tegs_box";
            this.tegs_box.Size = new System.Drawing.Size(534, 20);
            this.tegs_box.TabIndex = 14;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dataGridView1.Location = new System.Drawing.Point(166, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(534, 200);
            this.dataGridView1.TabIndex = 19;
            this.dataGridView1.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridView1_EditingControlShowing_1);
            // 
            // Buy
            // 
            this.Buy.AutoSize = true;
            this.Buy.Location = new System.Drawing.Point(15, 12);
            this.Buy.Name = "Buy";
            this.Buy.Size = new System.Drawing.Size(44, 17);
            this.Buy.TabIndex = 20;
            this.Buy.Text = "Buy";
            this.Buy.UseVisualStyleBackColor = true;
            this.Buy.CheckedChanged += new System.EventHandler(this.Buy_CheckedChanged);
            // 
            // Sell
            // 
            this.Sell.AutoSize = true;
            this.Sell.Location = new System.Drawing.Point(80, 12);
            this.Sell.Name = "Sell";
            this.Sell.Size = new System.Drawing.Size(43, 17);
            this.Sell.TabIndex = 21;
            this.Sell.Text = "Sell";
            this.Sell.UseVisualStyleBackColor = true;
            this.Sell.CheckedChanged += new System.EventHandler(this.Sell_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 262);
            this.Controls.Add(this.Sell);
            this.Controls.Add(this.Buy);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tegs_box);
            this.Controls.Add(this.Theme_string);
            this.Controls.Add(this.Theme_check);
            this.Controls.Add(this.Advertisment_Add);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Advertisment_Add;
        private System.Windows.Forms.Label Theme_string;
        private System.Windows.Forms.ComboBox Theme_check;
        private System.Windows.Forms.TextBox tegs_box;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckBox Buy;
        private System.Windows.Forms.CheckBox Sell;
    }
}

