using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Buy_Or_Sail
{
    public partial class add_advertisment : Form
    {
        Form1 first;

        public add_advertisment(Form1 First)
        {
            first = First;
            InitializeComponent();
            foreach (string key in first.DB.DB.Keys) Theme_check.Items.Add(key);
        }

        private void click_text(TextBox a)
        {
            if (a.Text != a.Name) return;
            a.SelectionStart = 0;
            a.SelectionLength = a.Text.Length;
        }
        public void add()
        {
            string str = Theme_check.Text, BOS = "";
            if(Buy.Checked) BOS = "Buy"; else BOS = "Sell";
            first.DB.add_advertisment(new Advertisment(first.DB.Last_id, first.Nick, str, BOS, Content.Text, Text.Lines, Tegs.Text));
            first.update_table();
            this.Close();
        }

        private void Content_Click(object sender, EventArgs e)
        {
            listBox1.Visible = false;
            click_text(Content);
        }
        private void Text_Click(object sender, EventArgs e)
        {
            listBox1.Visible = false;
            click_text(Text);
        }
        private void Tegs_Click(object sender, EventArgs e)
        {
            listBox1.Visible = false;
            click_text(Tegs);
        }
        private void Advertisment_Add_Click(object sender, EventArgs e)
        {
            listBox1.Visible = false;
            if (!((Theme_check.Text.Length > 0)))
            {
                label2.Text = "Please, choose or write theme\nof you advetisment";
                label2.Visible = true;
                return;
            }
            if (Content.Text.Length < 1 || Content.Text == "Content")
            {
                label2.Text = "Please, write content\nof your advertisment";
                label2.Visible = true;
                return;
            }
            if (Text.Text.Length < 1 || Text.Text == "Text")
            {
                label2.Text = "Please, write text\nof your advertisment";
                label2.Visible = true;
                return;
            }
            Add_success form = new Add_success(this);
            form.Show();
        }
        private void Theme_check_TextChanged(object sender, EventArgs e)
        {
            List<string> a = new List<string>();
            foreach (string key in first.DB.DB.Keys)
            {
                int k = 0;
                for (int i = 0; i < Math.Min(key.Length, Theme_check.Text.Length); i++)
                    if (Program.big_small(key[i]) != Program.big_small(Theme_check.Text[i])) k++;
                if (k < 2) a.Add(key);
            }
            listBox1.Items.Clear();
            for (int i = 0; i < Math.Min(a.Count, 5); i++) listBox1.Items.Add(a[i]);
            if (a.Count > 0)
            {
                listBox1.Size = new System.Drawing.Size(listBox1.Size.Width, 4 + 13 * Math.Min(5, a.Count));
                listBox1.Visible = true;
            }
            else listBox1.Visible = false;
        }
        private void Theme_check_SelectionChangeCommitted(object sender, EventArgs e)
        {
        }
        private void Text_TextChanged(object sender, EventArgs e)
        {

        }
        private void Sail_CheckedChanged(object sender, EventArgs e)
        {
            listBox1.Visible = false;
        }
        private void Buy_CheckedChanged(object sender, EventArgs e)
        {
            listBox1.Visible = false;
        }
        private void Theme_string_Click(object sender, EventArgs e)
        {
            listBox1.Visible = false;
        }
        private void label2_Click(object sender, EventArgs e)
        {
            listBox1.Visible = false;
        }
        private void add_advertisment_Click(object sender, EventArgs e)
        {
            listBox1.Visible = false;
        }
        private void add_advertisment_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Theme_check.Text = listBox1.Items[listBox1.SelectedIndex].ToString();
            listBox1.Visible = false;
        }
    }
}
