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
            string str;
            if (Theme_check.Text == "" && Theme_add_string.Text == "")
                str = "Are you sure want to create\nnew advertisment without theme?";
            else
                if (Theme_add_string.Text != "") str = "Are you sure want to create\nnew advertisment about " + Theme_add_string.Text;
                else
                    str = "Are you sure want to create\nnew advertisment about " + Theme_check.Text;
            Add_success form = new Add_success(this, str);
            form.Show();
        }
    }
}
