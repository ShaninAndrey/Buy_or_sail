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
    public partial class advertisment_viev : Form
    {
        Advertisment ths;
        Form1 first;

        public advertisment_viev(Advertisment A, Form1 form)
        {
            InitializeComponent();
            first = form;
            ths = A;
            Text1.Lines = A.Text;
            Content1.Text = A.Content;
            User_name.Text = A.User_name;
            Telephone.Text = form.DB.Users[User_name.Text].Telephone;
            label2.Text = label2.Text + form.DB.Users[User_name.Text].Rating.ToString();
            if (form.Nick != "" && A.Rating == false && A.User_name != form.Nick) { button1.Visible = true; button2.Visible = true; }
            //label2.Text.Concat(
        }

        private void button1_Click(object sender, EventArgs e)
        {
            first.DB.Users[User_name.Text].rating_inc();
            first.DB.Advertisment[ths.Id].Rating = true;
            first.DB.Users[User_name.Text].Id_adv.Add(ths.Id);
            button1.Visible = false;
            button2.Visible = false;
            label2.Text = label2.Text.Substring(0, 9) + first.DB.Users[User_name.Text].Rating.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            first.DB.Users[User_name.Text].rating_dec();
            first.DB.Advertisment[ths.Id].Rating = true;
            first.DB.Users[User_name.Text].Id_adv.Add(ths.Id);
            button1.Visible = false;
            button2.Visible = false;
            label2.Text = label2.Text.Substring(0, 9) + first.DB.Users[User_name.Text].Rating.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
