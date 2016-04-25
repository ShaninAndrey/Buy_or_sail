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
    public partial class Form1 : Form
    {
        Table db;

        public Table DB { get { return db; } }
        public ComboBox Theme_Check { get { return Theme_check; } }

        public Form1(Table DB)
        {
            InitializeComponent();
            db = DB;
            List<string> keys = DB.Keys;
            //dataGridView1.Width = this.Width / 3 * 2;
            dataGridView1.Columns.Add("Id", "Id");
            dataGridView1.Columns.Add("Theme", "Theme");
            dataGridView1.Columns.Add("BOS", "Buy or sell");
            dataGridView1.Columns.Add("Content", "Content");
            dataGridView1.Columns.Add("Text", "Text");
            dataGridView1.Columns.Add("Telephone", "Telephone");
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[1].Width = dataGridView1.Width / 5;
            dataGridView1.Columns[2].Width = dataGridView1.Width / 6;
            dataGridView1.Columns[3].Width = dataGridView1.Width - dataGridView1.Columns[1].Width - 3 - dataGridView1.Columns[2].Width;
            Theme_check.Items.Add("All Themes");
            for (int i = 0; i < keys.Count; i++)
            {
                Theme_check.Items.Add(keys[i]);
                for (int q = 0; q < (DB.DB[keys[i]]).Count; q++)
                {
                    Advertisment a = DB.DB[keys[i]][q];
                    dataGridView1.Rows.Add(a.Id, keys[i], a.BuyOrSail, a.Content, a.Text, a.Telephone);
                }
            }
        }

        //public void add_Theme(string  

        private void Advertisment_Add_Click(object sender, EventArgs e)
        {
            add_advertisment form = new add_advertisment(this);
            form.Show();
        }
        private void Theme_check_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            if (Theme_check.SelectedItem.ToString() != "All Themes")
            {
                for (int i = 0; i < db.DB[Theme_check.SelectedItem.ToString()].Count; i++)
                    if (Buy.Checked && db.DB[Theme_check.SelectedItem.ToString()][i].BuyOrSail == "Buy" ||
                       Sell.Checked && db.DB[Theme_check.SelectedItem.ToString()][i].BuyOrSail == "Sell" ||
                        !Sell.Checked && !Buy.Checked)
                    {
                        Advertisment a = db.DB[Theme_check.SelectedItem.ToString()][i];
                        dataGridView1.Rows.Add(a.Id, Theme_check.SelectedItem.ToString(), a.BuyOrSail, a.Content, a.Text, a.Telephone);
                    }
                return;
            }
            for(int q=0; q<db.Keys.Count; q++) for (int i = 0; i < db.DB[db.Keys[q]].Count; i++)
                if (Buy.Checked && db.DB[db.Keys[q]][i].BuyOrSail == "Buy" ||
                   Sell.Checked && db.DB[db.Keys[q]][i].BuyOrSail == "Sell" ||
                    !Sell.Checked && !Buy.Checked)
                {
                    Advertisment a = db.DB[db.Keys[q]][i];
                    dataGridView1.Rows.Add(a.Id, db.Keys[q], a.BuyOrSail, a.Content, a.Text, a.Telephone);
                }
        }
        private void dataGridView1_EditingControlShowing_1(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            TextBox txt = (TextBox)e.Control;
            txt.ReadOnly = true;
        }
        private void Sell_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            if (Theme_check.Text != "All Themes" && Theme_check.Text != "")
            {
                for (int i = 0; i < db.DB[Theme_check.Text].Count; i++)
                    if (Buy.Checked && db.DB[Theme_check.Text][i].BuyOrSail == "Buy" ||
                       Sell.Checked && db.DB[Theme_check.Text][i].BuyOrSail == "Sell" ||
                        !Sell.Checked && !Buy.Checked)
                    {
                        Advertisment a = db.DB[Theme_check.Text][i];
                        dataGridView1.Rows.Add(a.Id, Theme_check.Text, a.BuyOrSail, a.Content, a.Text, a.Telephone);
                    }
                return;
            }
            for (int q = 0; q < db.Keys.Count; q++) for (int i = 0; i < db.DB[db.Keys[q]].Count; i++)
                    if (Buy.Checked && db.DB[db.Keys[q]][i].BuyOrSail == "Buy" ||
                       Sell.Checked && db.DB[db.Keys[q]][i].BuyOrSail == "Sell" ||
                        !Sell.Checked && !Buy.Checked)
                    {
                        Advertisment a = db.DB[db.Keys[q]][i];
                        dataGridView1.Rows.Add(a.Id, db.Keys[q], a.BuyOrSail, a.Content, a.Text, a.Telephone);
                    }
        }
        private void Buy_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            if (Theme_check.Text != "All Themes" && Theme_check.Text != "")
            {
                for (int i = 0; i < db.DB[Theme_check.Text].Count; i++)
                    if (Buy.Checked && db.DB[Theme_check.Text][i].BuyOrSail == "Buy" ||
                       Sell.Checked && db.DB[Theme_check.Text][i].BuyOrSail == "Sell" ||
                        !Sell.Checked && !Buy.Checked)
                    {
                        Advertisment a = db.DB[Theme_check.Text][i];
                        dataGridView1.Rows.Add(a.Id, Theme_check.Text, a.BuyOrSail, a.Content, a.Text, a.Telephone);
                    }
                return;
            }
            for (int q = 0; q < db.Keys.Count; q++) for (int i = 0; i < db.DB[db.Keys[q]].Count; i++)
                    if (Buy.Checked && db.DB[db.Keys[q]][i].BuyOrSail == "Buy" ||
                       Sell.Checked && db.DB[db.Keys[q]][i].BuyOrSail == "Sell" ||
                        !Sell.Checked && !Buy.Checked)
                    {
                        Advertisment a = db.DB[db.Keys[q]][i];
                        dataGridView1.Rows.Add(a.Id, db.Keys[q], a.BuyOrSail, a.Content, a.Text, a.Telephone);
                    }
        }
    }
}
