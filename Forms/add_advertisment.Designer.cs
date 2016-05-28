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
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tag_box2 = new System.Windows.Forms.ComboBox();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.listBox5 = new System.Windows.Forms.ListBox();
            this.tag_check2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tag_box = new System.Windows.Forms.ComboBox();
            this.tag_check = new System.Windows.Forms.ComboBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
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
            this.Content.Location = new System.Drawing.Point(176, 72);
            this.Content.Name = "Content";
            this.Content.Size = new System.Drawing.Size(386, 20);
            this.Content.TabIndex = 7;
            this.Content.Text = "Content";
            this.Content.Click += new System.EventHandler(this.Content_Click);
            // 
            // Text
            // 
            this.Text.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(220)))));
            this.Text.Location = new System.Drawing.Point(176, 98);
            this.Text.Multiline = true;
            this.Text.Name = "Text";
            this.Text.Size = new System.Drawing.Size(386, 181);
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
            // listBox3
            // 
            this.listBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(240)))), ((int)(((byte)(180)))));
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(389, 33);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(104, 17);
            this.listBox3.TabIndex = 63;
            this.listBox3.Visible = false;
            this.listBox3.Click += new System.EventHandler(this.listBox3_Click);
            // 
            // listBox2
            // 
            this.listBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(240)))), ((int)(((byte)(180)))));
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(279, 34);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(104, 17);
            this.listBox2.TabIndex = 62;
            this.listBox2.Visible = false;
            this.listBox2.Click += new System.EventHandler(this.listBox2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(175, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 61;
            this.label4.Text = "Delete selected tag";
            // 
            // tag_box2
            // 
            this.tag_box2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(240)))), ((int)(((byte)(180)))));
            this.tag_box2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tag_box2.FormattingEnabled = true;
            this.tag_box2.Location = new System.Drawing.Point(389, 40);
            this.tag_box2.Name = "tag_box2";
            this.tag_box2.Size = new System.Drawing.Size(104, 21);
            this.tag_box2.TabIndex = 59;
            this.tag_box2.Visible = false;
            this.tag_box2.SelectedIndexChanged += new System.EventHandler(this.Tag_box2_SelectedIndexChanged);
            this.tag_box2.TextChanged += new System.EventHandler(this.Tag_box2_TextChanged);
            this.tag_box2.Click += new System.EventHandler(this.Tag_box2_Click);
            // 
            // listBox4
            // 
            this.listBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(240)))), ((int)(((byte)(180)))));
            this.listBox4.FormattingEnabled = true;
            this.listBox4.Location = new System.Drawing.Point(389, 60);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(104, 17);
            this.listBox4.TabIndex = 60;
            this.listBox4.Visible = false;
            this.listBox4.Click += new System.EventHandler(this.listBox4_Click);
            // 
            // listBox5
            // 
            this.listBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(240)))), ((int)(((byte)(180)))));
            this.listBox5.FormattingEnabled = true;
            this.listBox5.Location = new System.Drawing.Point(279, 61);
            this.listBox5.Name = "listBox5";
            this.listBox5.Size = new System.Drawing.Size(104, 17);
            this.listBox5.TabIndex = 58;
            this.listBox5.Visible = false;
            this.listBox5.Click += new System.EventHandler(this.listBox5_Click);
            // 
            // tag_check2
            // 
            this.tag_check2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(240)))), ((int)(((byte)(180)))));
            this.tag_check2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tag_check2.FormattingEnabled = true;
            this.tag_check2.Location = new System.Drawing.Point(279, 40);
            this.tag_check2.Name = "tag_check2";
            this.tag_check2.Size = new System.Drawing.Size(104, 21);
            this.tag_check2.TabIndex = 56;
            this.tag_check2.SelectedIndexChanged += new System.EventHandler(this.Tag_check2_SelectedIndexChanged);
            this.tag_check2.TextChanged += new System.EventHandler(this.Tag_check2_TextChanged);
            this.tag_check2.Click += new System.EventHandler(this.Tag_check2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(175, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 55;
            this.label3.Text = "Select new tag";
            // 
            // tag_box
            // 
            this.tag_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(240)))), ((int)(((byte)(180)))));
            this.tag_box.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tag_box.FormattingEnabled = true;
            this.tag_box.Location = new System.Drawing.Point(389, 13);
            this.tag_box.Name = "tag_box";
            this.tag_box.Size = new System.Drawing.Size(104, 21);
            this.tag_box.TabIndex = 54;
            this.tag_box.Visible = false;
            this.tag_box.SelectedIndexChanged += new System.EventHandler(this.Tag_box_SelectedIndexChanged);
            this.tag_box.TextChanged += new System.EventHandler(this.Tag_box_TextChanged);
            this.tag_box.Click += new System.EventHandler(this.Tag_box_Click);
            // 
            // tag_check
            // 
            this.tag_check.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(240)))), ((int)(((byte)(180)))));
            this.tag_check.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tag_check.FormattingEnabled = true;
            this.tag_check.Location = new System.Drawing.Point(279, 13);
            this.tag_check.Name = "tag_check";
            this.tag_check.Size = new System.Drawing.Size(104, 21);
            this.tag_check.TabIndex = 52;
            this.tag_check.SelectedIndexChanged += new System.EventHandler(this.Tag_check_SelectedIndexChanged);
            this.tag_check.TextChanged += new System.EventHandler(this.Tag_check_TextChanged);
            this.tag_check.Click += new System.EventHandler(this.Tag_check_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::Buy_Or_Sail.Properties.Resources.delete_tag;
            this.pictureBox7.Location = new System.Drawing.Point(503, 42);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(61, 26);
            this.pictureBox7.TabIndex = 65;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::Buy_Or_Sail.Properties.Resources.add_tag;
            this.pictureBox6.Location = new System.Drawing.Point(503, 12);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(61, 24);
            this.pictureBox6.TabIndex = 64;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.button1_Click);
            // 
            // add_advertisment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(243)))), ((int)(((byte)(217)))));
            this.ClientSize = new System.Drawing.Size(574, 317);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tag_box2);
            this.Controls.Add(this.listBox4);
            this.Controls.Add(this.listBox5);
            this.Controls.Add(this.tag_check2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tag_box);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "add_advertisment";
            this.Load += new System.EventHandler(this.add_advertisment_Load);
            this.Click += new System.EventHandler(this.add_advertisment_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
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
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox tag_box2;
        private System.Windows.Forms.ListBox listBox4;
        private System.Windows.Forms.ListBox listBox5;
        private System.Windows.Forms.ComboBox tag_check2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox tag_box;
        private System.Windows.Forms.ComboBox tag_check;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox6;
    }
}