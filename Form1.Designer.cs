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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Theme_string = new System.Windows.Forms.Label();
            this.Theme_check = new System.Windows.Forms.ComboBox();
            this.tegs_box = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rating = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Theme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BOS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Content = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Buy = new System.Windows.Forms.CheckBox();
            this.Sell = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.my_advertisment = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.Theme_check.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(240)))), ((int)(((byte)(180)))));
            this.Theme_check.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Theme_check.FormattingEnabled = true;
            this.Theme_check.Location = new System.Drawing.Point(12, 77);
            this.Theme_check.Name = "Theme_check";
            this.Theme_check.Size = new System.Drawing.Size(121, 21);
            this.Theme_check.Sorted = true;
            this.Theme_check.TabIndex = 12;
            this.Theme_check.SelectedIndexChanged += new System.EventHandler(this.Theme_check_SelectedIndexChanged);
            this.Theme_check.TextChanged += new System.EventHandler(this.Theme_check_TextChanged);
            this.Theme_check.Click += new System.EventHandler(this.Theme_check_Click);
            // 
            // tegs_box
            // 
            this.tegs_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(220)))));
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
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(243)))), ((int)(((byte)(217)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(223)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(250)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Rating,
            this.Theme,
            this.BOS,
            this.Content});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dataGridView1.Location = new System.Drawing.Point(166, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(534, 200);
            this.dataGridView1.TabIndex = 19;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridView1_EditingControlShowing_1);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Rating
            // 
            this.Rating.HeaderText = "Rating";
            this.Rating.Name = "Rating";
            this.Rating.ReadOnly = true;
            this.Rating.Width = 50;
            // 
            // Theme
            // 
            this.Theme.HeaderText = "Theme";
            this.Theme.Name = "Theme";
            this.Theme.ReadOnly = true;
            // 
            // BOS
            // 
            this.BOS.HeaderText = "Buy or Sell";
            this.BOS.Name = "BOS";
            this.BOS.ReadOnly = true;
            this.BOS.Width = 80;
            // 
            // Content
            // 
            this.Content.HeaderText = "Content";
            this.Content.Name = "Content";
            this.Content.ReadOnly = true;
            this.Content.Width = 260;
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
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(240)))), ((int)(((byte)(180)))));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 96);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 17);
            this.listBox1.TabIndex = 28;
            this.listBox1.Visible = false;
            this.listBox1.Click += new System.EventHandler(this.listBox1_Click);
            this.listBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseMove);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImage = global::Buy_Or_Sail.Properties.Resources.Statistic;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox5.Location = new System.Drawing.Point(152, 17);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(124, 35);
            this.pictureBox5.TabIndex = 34;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::Buy_Or_Sail.Properties.Resources.But6;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox4.Location = new System.Drawing.Point(15, 221);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(128, 33);
            this.pictureBox4.TabIndex = 33;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Visible = false;
            this.pictureBox4.Click += new System.EventHandler(this.delete_advertisment_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::Buy_Or_Sail.Properties.Resources.But5;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox3.Location = new System.Drawing.Point(15, 180);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(126, 32);
            this.pictureBox3.TabIndex = 32;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Visible = false;
            this.pictureBox3.Click += new System.EventHandler(this.Advertisment_Add_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Buy_Or_Sail.Properties.Resources.But4;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.Location = new System.Drawing.Point(15, 221);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(128, 34);
            this.pictureBox2.TabIndex = 31;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.Sign_in_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Buy_Or_Sail.Properties.Resources.But3;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(15, 180);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(126, 35);
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.Log_in_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(243)))), ((int)(((byte)(217)))));
            this.ClientSize = new System.Drawing.Size(712, 262);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.my_advertisment);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Sell);
            this.Controls.Add(this.Buy);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tegs_box);
            this.Controls.Add(this.Theme_string);
            this.Controls.Add(this.Theme_check);
            this.Name = "Form1";
            this.Text = "Buy or Sell";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Theme_string;
        private System.Windows.Forms.TextBox tegs_box;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckBox Buy;
        private System.Windows.Forms.CheckBox Sell;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox my_advertisment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox Theme_check;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rating;
        private System.Windows.Forms.DataGridViewTextBoxColumn Theme;
        private System.Windows.Forms.DataGridViewTextBoxColumn BOS;
        private System.Windows.Forms.DataGridViewTextBoxColumn Content;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}

