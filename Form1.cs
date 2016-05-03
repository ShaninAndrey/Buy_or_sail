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
        string nick;
        Table db;

        public string Nick { get { return nick; } }
        public Table DB { get { return db; } }
        public ComboBox Theme_Check { get { return Theme_check; } }

        public Form1(Table DB)
        {
            InitializeComponent();
            db = DB;
            List<string> keys = DB.Keys;
            dataGridView1.Columns.Add("Id", "Id");
            dataGridView1.Columns.Add("User", "User");
            dataGridView1.Columns.Add("Theme", "Theme");
            dataGridView1.Columns.Add("BOS", "Buy or sell");
            dataGridView1.Columns.Add("Content", "Content");
            dataGridView1.Columns.Add("Text", "Text");
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Width = dataGridView1.Width / 5;
            dataGridView1.Columns[3].Width = dataGridView1.Width / 6;
            dataGridView1.Columns[4].Width = dataGridView1.Width - dataGridView1.Columns[2].Width - 2 - dataGridView1.Columns[3].Width - dataGridView1.RowHeadersWidth;
            Theme_check.Items.Add("All Themes");
            for (int i = 0; i < keys.Count; i++)
            {
                Theme_check.Items.Add(keys[i]);
                for (int q = 0; q < DB.Keys_id[keys[i]].Count; q++)
                {
                    Advertisment a = DB.DB[keys[i]][DB.Keys_id[DB.Keys[i]][q]];
                    dataGridView1.Rows.Add(a.Id, a.User_name, a.Theme, a.BuyOrSail, a.Content, a.Text);
                }
            }
        }

        public void add_user(string Nick)
        {
            nick = Nick;
            my_advertisment.Location = new Point(my_advertisment.Location.X, my_advertisment.Location.Y + 64);
            Buy.Location = new Point(Buy.Location.X, Buy.Location.Y + 64);
            Sell.Location = new Point(Sell.Location.X, Sell.Location.Y + 64);
            Theme_check.Location = new Point(Theme_check.Location.X, Theme_check.Location.Y + 64);
            Theme_string.Location = new Point(Theme_string.Location.X, Theme_string.Location.Y + 64);
            label2.Text = "Hello, " + Nick;
            label2.Visible = true;
            my_advertisment.Visible = true;
            label1.Visible = false;
            Sign_in.Visible = false;
            Log_in.Visible = false;
            Advertisment_Add.Visible = true;
            delete_advertisment.Visible = true;
        }
        public void register_user(Users user)
        {
            DB.add_user(user);
        }
        public void add_theme(string theme)
        {
            Theme_check.Items.Add(theme);
        }
        public void update_table()
        {
            dataGridView1.Rows.Clear();
            if (tegs_box.Text.Length < 1)
            {
                if (Theme_check.Text != "All Themes" && Theme_check.Text.Length > 0)
                {
                    for (int i = 0; i < db.Keys_id[Theme_check.Text].Count; i++)
                        if (Buy.Checked && db.DB[Theme_check.Text][db.Keys_id[Theme_check.Text][i]].BuyOrSail == "Buy" ||
                           Sell.Checked && db.DB[Theme_check.Text][db.Keys_id[Theme_check.Text][i]].BuyOrSail == "Sell" ||
                            !Sell.Checked && !Buy.Checked)
                        {
                            if (my_advertisment.Checked && db.DB[Theme_check.Text][db.Keys_id[Theme_check.Text][i]].User_name == nick || !(my_advertisment.Checked))
                            {
                                Advertisment a = db.DB[Theme_check.Text][db.Keys_id[Theme_check.Text][i]];
                                dataGridView1.Rows.Add(a.Id, a.User_name, a.Theme, a.BuyOrSail, a.Content, a.Text);
                            }
                        }
                    return;
                }
                for (int q = 0; q < db.Keys.Count; q++) for (int i = 0; i < db.Keys_id[db.Keys[q]].Count; i++)
                        if (Buy.Checked && db.DB[db.Keys[q]][db.Keys_id[db.Keys[q]][i]].BuyOrSail == "Buy" ||
                           Sell.Checked && db.DB[db.Keys[q]][db.Keys_id[db.Keys[q]][i]].BuyOrSail == "Sell" ||
                            !Sell.Checked && !Buy.Checked)
                        {
                            if (my_advertisment.Checked && db.DB[db.Keys[q]][db.Keys_id[db.Keys[q]][i]].User_name == nick || !(my_advertisment.Checked))
                            {
                                Advertisment a = db.DB[db.Keys[q]][db.Keys_id[db.Keys[q]][i]];
                                dataGridView1.Rows.Add(a.Id, a.User_name, a.Theme, a.BuyOrSail, a.Content, a.Text);
                            }
                        }
            }
            else
            {
                List<string> tegs = get_tegs();
                if (Theme_check.Text != "All Themes" && Theme_check.Text.Length > 0)
                {
                    for (int i = 0; i < db.Keys_id[Theme_check.Text].Count; i++)
                        if (Buy.Checked && db.DB[Theme_check.Text][db.Keys_id[Theme_check.Text][i]].BuyOrSail == "Buy" ||
                           Sell.Checked && db.DB[Theme_check.Text][db.Keys_id[Theme_check.Text][i]].BuyOrSail == "Sell" ||
                            !Sell.Checked && !Buy.Checked)
                        {
                            if (my_advertisment.Checked && db.DB[Theme_check.Text][db.Keys_id[Theme_check.Text][i]].User_name == nick || !(my_advertisment.Checked))
                            {
                                Advertisment a = db.DB[Theme_check.Text][db.Keys_id[Theme_check.Text][i]];
                                for (int w = 0; w < tegs.Count; w++) if (align_tegs(tegs[w], a))
                                    {
                                        dataGridView1.Rows.Add(a.Id, a.User_name, a.Theme, a.BuyOrSail, a.Content, a.Text);
                                        break;
                                    }
                            }
                        }
                    return;
                }
                for (int q = 0; q < db.Keys.Count; q++) for (int i = 0; i < db.Keys_id[db.Keys[q]].Count; i++)
                        if (Buy.Checked && db.DB[db.Keys[q]][db.Keys_id[db.Keys[q]][i]].BuyOrSail == "Buy" ||
                           Sell.Checked && db.DB[db.Keys[q]][db.Keys_id[db.Keys[q]][i]].BuyOrSail == "Sell" ||
                            !Sell.Checked && !Buy.Checked)
                        {
                            if (my_advertisment.Checked && db.DB[db.Keys[q]][db.Keys_id[db.Keys[q]][i]].User_name == nick || !(my_advertisment.Checked))
                            {
                                Advertisment a = db.DB[db.Keys[q]][db.Keys_id[db.Keys[q]][i]];
                                for (int w = 0; w < tegs.Count; w++) if (align_tegs(tegs[w], a))
                                    {
                                        dataGridView1.Rows.Add(a.Id, a.User_name, a.Theme, a.BuyOrSail, a.Content, a.Text);
                                        break;
                                    }
                            }
                        }
            }
        }

        private void Advertisment_Add_Click(object sender, EventArgs e)
        {
            add_advertisment form = new add_advertisment(this);
            form.Show();
        }
        private void Theme_check_SelectedIndexChanged(object sender, EventArgs e)
        {
            update_table();
        }
        private void dataGridView1_EditingControlShowing_1(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            TextBox txt = (TextBox)e.Control;
            txt.ReadOnly = true;
        }
        private void Sell_CheckedChanged(object sender, EventArgs e)
        {
            update_table();
        }
        private void Buy_CheckedChanged(object sender, EventArgs e)
        {
            update_table();
        }
        private void Log_in_Click(object sender, EventArgs e)
        {
            Log_in_form form = new Log_in_form(this);
            form.Show();
        }
        private void Sign_in_Click(object sender, EventArgs e)
        {
            Sign_in_form form = new Sign_in_form(this);
            form.Show();
        }
        private void my_advertisment_CheckedChanged(object sender, EventArgs e)
        {
            update_table();
        }
        private void delete_advertisment_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
                if (dataGridView1.SelectedRows[i].Cells[1].Value.ToString() == nick)
                    DB.delete_advertisment(new Advertisment(Convert.ToInt32(dataGridView1.SelectedRows[i].Cells[0].Value.ToString()),
                                                            dataGridView1.SelectedRows[i].Cells[1].Value.ToString(),
                                                            dataGridView1.SelectedRows[i].Cells[2].Value.ToString()));
            update_table();
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedCells[0].Value.ToString().Length > 0)
            {
                DataGridViewRow row = dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex];
                advertisment_viev form = new advertisment_viev(DB.DB[row.Cells[2].Value.ToString()][Convert.ToInt32(row.Cells[0].Value.ToString())], this);
                form.Show();
            }
        }
        private List<string> get_tegs()
        {
            Sign_in.Text = "asdf";
            List<string> teg = new List<string>();
            int l = 0;
            for (int i = 1; i < tegs_box.Text.Length; i++) if (tegs_box.Text[i] == ' ' && tegs_box.Text[i - 1] != ' ')
                {
                    teg.Add(tegs_box.Text.Substring(l, i - l));
                    l = i + 1;
                }
                else if (tegs_box.Text[i] == ' ') l = i + 1;
            if(l!=tegs_box.Text.Length) teg.Add(tegs_box.Text.Substring(l));
            return teg;
        }
        private bool align_tegs(string teg, Advertisment adv)
        {
            if (adv.Tegs.Count == 0) return true;
            for (int i = 0; i < adv.Tegs.Count; i++)
            {
                for (int q = 0; q < Math.Min(teg.Length, adv.Tegs[i].Length); q++)
                    if (Program.big_small(teg[q]) != Program.big_small(adv.Tegs[i][q])) return false;
                return true;
            }
            return false;
        }
        private void tegs_box_TextChanged(object sender, EventArgs e)
        {
            update_table();
        }
    }
}
