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
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tag_check = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.tag_box = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.Sail.Text = "Sell";
            this.Sail.UseVisualStyleBackColor = true;
            this.Sail.CheckedChanged += new System.EventHandler(this.Sail_CheckedChanged);
            // 
            // Theme_check
            // 
            this.Theme_check.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(240)))), ((int)(((byte)(180)))));
            this.Theme_check.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Theme_check.FormattingEnabled = true;
            this.Theme_check.Location = new System.Drawing.Point(26, 72);
            this.Theme_check.Name = "Theme_check";
            this.Theme_check.Size = new System.Drawing.Size(121, 21);
            this.Theme_check.TabIndex = 3;
            this.Theme_check.SelectedIndexChanged += new System.EventHandler(this.Theme_check_SelectedIndexChanged);
            this.Theme_check.SelectionChangeCommitted += new System.EventHandler(this.Theme_check_SelectionChangeCommitted);
            this.Theme_check.TextChanged += new System.EventHandler(this.Theme_check_TextChanged);
            this.Theme_check.Click += new System.EventHandler(this.Theme_check_Click);
            // 
            // Theme_string
            // 
            this.Theme_string.AutoSize = true;
            this.Theme_string.Location = new System.Drawing.Point(23, 50);
            this.Theme_string.Name = "Theme_string";
            this.Theme_string.Size = new System.Drawing.Size(75, 13);
            this.Theme_string.TabIndex = 4;
            this.Theme_string.Text = "Choose theme";
            this.Theme_string.Click += new System.EventHandler(this.Theme_string_Click);
            // 
            // Content
            // 
            this.Content.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(220)))));
            this.Content.Location = new System.Drawing.Point(176, 53);
            this.Content.Name = "Content";
            this.Content.Size = new System.Drawing.Size(386, 20);
            this.Content.TabIndex = 7;
            this.Content.Text = "Content";
            this.Content.Click += new System.EventHandler(this.Content_Click);
            // 
            // Text
            // 
            this.Text.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(220)))));
            this.Text.Location = new System.Drawing.Point(176, 79);
            this.Text.Multiline = true;
            this.Text.Name = "Text";
            this.Text.Size = new System.Drawing.Size(386, 200);
            this.Text.TabIndex = 8;
            this.Text.Text = "Text";
            this.Text.Click += new System.EventHandler(this.Text_Click);
            this.Text.TextChanged += new System.EventHandler(this.Text_TextChanged);
            // 
            // Tegs
            // 
            this.Tegs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(220)))));
            this.Tegs.Location = new System.Drawing.Point(176, 285);
            this.Tegs.Name = "Tegs";
            this.Tegs.ReadOnly = true;
            this.Tegs.Size = new System.Drawing.Size(386, 20);
            this.Tegs.TabIndex = 9;
            this.Tegs.Text = "Tags";
            this.Tegs.Click += new System.EventHandler(this.Tegs_Click);
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
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(240)))), ((int)(((byte)(180)))));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(26, 91);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 17);
            this.listBox1.TabIndex = 15;
            this.listBox1.Visible = false;
            this.listBox1.Click += new System.EventHandler(this.listBox1_Click);
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            this.listBox1.MouseHover += new System.EventHandler(this.listBox1_MouseHover);
            this.listBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseMove);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Buy_Or_Sail.Properties.Resources.But5;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(26, 244);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 35);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.Advertisment_Add_Click);
            // 
            // tag_check
            // 
            this.tag_check.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(240)))), ((int)(((byte)(180)))));
            this.tag_check.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tag_check.FormattingEnabled = true;
            this.tag_check.Location = new System.Drawing.Point(267, 16);
            this.tag_check.Name = "tag_check";
            this.tag_check.Size = new System.Drawing.Size(104, 21);
            this.tag_check.TabIndex = 17;
            this.tag_check.SelectedIndexChanged += new System.EventHandler(this.Tag_check_SelectedIndexChanged);
            this.tag_check.TextChanged += new System.EventHandler(this.Tag_check_TextChanged);
            this.tag_check.Click += new System.EventHandler(this.Tag_check_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(487, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Add tag";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox2
            // 
            this.listBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(240)))), ((int)(((byte)(180)))));
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(267, 37);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(104, 17);
            this.listBox2.TabIndex = 20;
            this.listBox2.Visible = false;
            this.listBox2.Click += new System.EventHandler(this.listBox2_Click);
            // 
            // listBox3
            // 
            this.listBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(240)))), ((int)(((byte)(180)))));
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(377, 36);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(104, 17);
            this.listBox3.TabIndex = 23;
            this.listBox3.Visible = false;
            this.listBox3.Click += new System.EventHandler(this.listBox3_Click);
            // 
            // tag_box
            // 
            this.tag_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(240)))), ((int)(((byte)(180)))));
            this.tag_box.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tag_box.FormattingEnabled = true;
            this.tag_box.Location = new System.Drawing.Point(377, 16);
            this.tag_box.Name = "tag_box";
            this.tag_box.Size = new System.Drawing.Size(104, 21);
            this.tag_box.TabIndex = 22;
            this.tag_box.Visible = false;
            this.tag_box.SelectedIndexChanged += new System.EventHandler(this.Tag_box_SelectedIndexChanged);
            this.tag_box.TextChanged += new System.EventHandler(this.Tag_box_TextChanged);
            this.tag_box.Click += new System.EventHandler(this.Tag_box_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(182, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Select tags";
            // 
            // add_advertisment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(243)))), ((int)(((byte)(217)))));
            this.ClientSize = new System.Drawing.Size(574, 317);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tag_box);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tag_check);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label2);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox tag_check;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.ComboBox tag_box;
        private System.Windows.Forms.Label label1;
    }
}