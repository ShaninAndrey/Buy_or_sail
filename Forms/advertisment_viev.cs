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
            this.MaximizeBox = false;
            first = form;
            ths = A;
            Text1.Lines = A.Text;
            Content1.Text = A.Content;
            User_name.Text = A.User_name;
            Telephone.Text = form.DB.Users[User_name.Text].Telephone;
            label2.Text = label2.Text + form.DB.Users[User_name.Text].Rating.ToString();
            if (form.Nick != "" && A.Rating == false && A.User_name != form.Nick) { pictureBox1.Visible = true; }
            if (A.History.Last().ToLongDateString() == System.DateTime.Now.ToLongDateString())
            {
                DateTime.Text = "Time of last change";
                dateval.Text = A.History.Last().ToLongTimeString();
            }
            else
            {
                DateTime.Text = "Date of last change";
                dateval.Text = A.History.Last().ToLongDateString();
            }
            if (A.User_name == form.Nick)
            {
                Text1.ReadOnly = false;
                Content1.ReadOnly = false;
                label3.Visible = true;
            }
            this.FormClosing += advertisment_view_FormClosing;
        }

        public void save_advertisment()
        {
            ths.Text = Text1.Lines;
            ths.Content = Content1.Text;
            ths.History.Add(System.DateTime.Now);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void advertisment_viev_Load(object sender, EventArgs e)
        {

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            first.DB.Users[User_name.Text].rating_inc();
            ths.Rating = true;
            first.DB.Users[User_name.Text].Id_adv.Add(ths.Id);
            pictureBox1.Visible = false;
            label2.Text = label2.Text.Substring(0, 9) + first.DB.Users[User_name.Text].Rating.ToString();
            first.update_table();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            first.DB.Users[User_name.Text].rating_dec();
            first.DB.Advertisment[ths.Id].Rating = true;
            first.DB.Users[User_name.Text].Id_adv.Add(ths.Id);
            pictureBox1.Visible = false;
            label2.Text = label2.Text.Substring(0, 9) + first.DB.Users[User_name.Text].Rating.ToString();
        }
        private void advertisment_view_FormClosing(object sender, FormClosingEventArgs e)
        {
            int l = 0;
            for (int i = 0; i < Math.Min(ths.Text.Length, Text1.Lines.Length); i++)
                if (ths.Text[i] != Text1.Lines[i]) l = 1;
            if (ths.User_name != first.Nick || Content1.Text == ths.Content && l == 0) return;
            save_advertisment();
            Is_saved form = new Is_saved();
            form.Show();
        }

        private void Content1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
