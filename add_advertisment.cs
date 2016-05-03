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
            for (int i = 0; i < first.Theme_Check.Items.Count; i++) Theme_check.Items.Add(first.Theme_Check.Items[i]);
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
            if(Theme_add_string.Text.Length > 0) str = Theme_add_string.Text;
            first.DB.add_advertisment(new Advertisment(first.DB.Last_id, first.Nick, str, BOS, Content.Text, Text.Text, Tegs.Text));
            first.update_table();
            this.Close();
        }

        private void Content_Click(object sender, EventArgs e)
        {
            click_text(Content);
        }

        private void Text_Click(object sender, EventArgs e)
        {
            click_text(Text);
        }

        private void Tegs_Click(object sender, EventArgs e)
        {
            click_text(Tegs);
        }

        private void Advertisment_Add_Click(object sender, EventArgs e)
        {
            if (Theme_check.Text.Length > 0 || Theme_add_string.Text.Length > 0)
            {
                Add_success form = new Add_success(this);
                form.Show();
            }
            else
            {
                label2.Visible = true;
            }
        }
    }
}
