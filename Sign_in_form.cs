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
    public partial class Sign_in_form : Form
    {
        Form1 first;

        public Sign_in_form(Form1 form)
        {
            InitializeComponent();
            first = form;
            textBox2.PasswordChar = '*';
            textBox3.PasswordChar = '*';
        }


        private bool align_mask()
        {
            string mask = "0   00   0    ";
            for (int i = 0; i < mask.Length; i++) if (mask[i] == maskedTextBox1.Text[i]) return false;
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nick = "";
            for (int i = 0; i < textBox1.Text.Length; i++) nick = nick + Program.big_small(textBox1.Text[i]);

            if (textBox1.Text.Length < 1)
            {
                label4.Text = "Write your login please";
                label4.Visible = true;
                return;
            }
            if (textBox1.Text[0] >= '0' && textBox1.Text[0] <= '9')
            {
                label4.Text = "Use only a-z characters in your nick";
                label4.Visible = true;
                return;
            }
            if (textBox3.Text.Length < 1 || textBox2.Text.Length < 1)
            {
                label4.Text = "Write password please";
                label4.Visible = true;
                return;
            }
            if(!align_mask())
            {
                label4.Text = "Write telephone number please";
                label4.Visible = true;
                return;
            }
            if (textBox2.Text != textBox3.Text) { label4.Text = "Password aren't equale"; label4.Visible = true; return; }
            if (first.DB.Users.ContainsKey(nick))
            {
                label4.Text = "this nickname used";
                label4.Visible = true;
                return;
            }
            first.register_user(new Users(first.DB.Last_id, 0, nick, textBox2.Text, maskedTextBox1.Text, new List<int>()));
            this.Close();
        }
    }
}
