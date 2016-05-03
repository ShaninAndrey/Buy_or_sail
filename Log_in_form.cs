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
    public partial class Log_in_form : Form
    {
        Form1 first;

        public Log_in_form(Form1 First)
        {
            InitializeComponent();
            first = First;
            textBox2.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int flag = 0;
            if (textBox1.Text.Length < 1) { flag = 1; panel1.BackColor = System.Drawing.Color.Red; }
            if (textBox2.Text.Length < 1) { flag = 1; panel2.BackColor = System.Drawing.Color.Red; }
            if(flag == 1) return;
            if (!first.DB.Users.ContainsKey(textBox1.Text)) { label3.Visible = true; return; }
            else
            {
                if (first.DB.Users[textBox1.Text].Password != textBox2.Text) label4.Visible = true;
                else
                {
                    first.add_user(textBox1.Text);
                    this.Close();
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length < 1) panel1.BackColor = System.Drawing.Color.Red; else panel1.BackColor = System.Drawing.SystemColors.Control;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length < 1) panel2.BackColor = System.Drawing.Color.Red; else panel2.BackColor = System.Drawing.SystemColors.Control;
        }
    }
}
