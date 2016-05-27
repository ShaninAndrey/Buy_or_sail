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
        Dictionary<string, List<string>> tags;
        Dictionary<string, List<string>> db_tags;

        public string Nick { get { return nick; } }
        public Table DB { get { return db; } }
        public ComboBox Theme_Check { get { return Theme_check; } }

        public Form1(Table DB)
        {
            InitializeComponent();
            this.MaximizeBox = false;
            nick = "";
            db = DB;
            List<string> keys = DB.Keys;
            this.Resize += Form1_Resize;
            listBox1.MouseLeave += listBox1_MouseLeave;
            Theme_check.LostFocus += Theme_check_ChangeFocused;
            dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            dataGridView1.DefaultCellStyle.BackColor = Color.FromArgb(250, 243, 217);
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(144, 250, 136);
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.Black;
            dataGridView1.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(250, 223, 128);
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Width = dataGridView1.Width / 10;
            dataGridView1.Columns[2].Width = dataGridView1.Width / 5;
            dataGridView1.Columns[3].Width = dataGridView1.Width / 6;
            dataGridView1.Columns[4].Width = dataGridView1.Width - dataGridView1.Columns[2].Width - 2 - dataGridView1.Columns[3].Width - dataGridView1.RowHeadersWidth - dataGridView1.Columns[1].Width;
            Theme_check.Items.Add("All Themes");
            for (int i = 0; i < keys.Count; i++)
            {
                Theme_check.Items.Add(keys[i]);
            }
            tags = new Dictionary<string, List<string>>();
            db_tags = new Dictionary<string, List<string>>();
            tag_check.LostFocus += Tag_check_ChangeFocused;
            tag_box.LostFocus += Tag_box_ChangeFocused;
            listBox2.MouseMove += listBox2_MouseMove;
            listBox3.MouseMove += listBox3_MouseMove;
            listBox1.MouseLeave += listBox1_MouseLeave;
            listBox2.MouseLeave += listBox2_MouseLeave;
            listBox3.MouseLeave += listBox3_MouseLeave;
            foreach (KeyValuePair<string, Dictionary<string, List<Advertisment>>> x in db.Tags)
            {
                db_tags.Add(x.Key, new List<string>(x.Value.Keys));
            }
            if (db_tags.Count > 0) foreach (string a in db_tags.Keys) tag_check.Items.Add(a);
            update_table();
        }

        public void add_user(string Nick)
        {
            nick = Nick;
            if (db.Users[nick].State == "admin")
            {
                if (nick != "andrey") tag_edit_but.Text = "window";
                tag_edit_but.Visible = true;
            }
            else
                if (!db.Users_to_admin.Contains(db.Users[nick])) goto_admin.Visible = true;
            my_advertisment.Location = new Point(my_advertisment.Location.X, my_advertisment.Location.Y + 113);
            Buy.Location = new Point(Buy.Location.X, Buy.Location.Y + 113);
            Sell.Location = new Point(Sell.Location.X, Sell.Location.Y + 113);
            Theme_check.Location = new Point(Theme_check.Location.X, Theme_check.Location.Y + 20);
            Theme_string.Location = new Point(Theme_string.Location.X, Theme_string.Location.Y + 20);
            listBox1.Location = new Point(listBox1.Location.X, listBox1.Location.Y + 20);
            for (int i = 0; i < db.Users[Nick].Id_adv.Count; i++) db.Advertisment[db.Users[Nick].Id_adv[i]].Rating = true;
            label2.Text = "Hello, " + Nick;
            label2.Visible = true;
            my_advertisment.Visible = true;
            label1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox1.Visible = false;
            pictureBox3.Visible = true;
            pictureBox4.Visible = true;
        }
        public void register_user(Users user)
        {
            DB.add_user(user);
        }
        public void delete_adv()
        {
            for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
                if (db.Advertisment[Convert.ToInt32(dataGridView1.SelectedRows[i].Cells[0].Value)].User_name == nick)
                    DB.delete_advertisment(new Advertisment(Convert.ToInt32(dataGridView1.SelectedRows[i].Cells[0].Value.ToString()),
                                                            nick,
                                                            dataGridView1.SelectedRows[i].Cells[2].Value.ToString()));
            update_table();
        }
        public void update_table()
        {
            dataGridView1.Rows.Clear();
            Dictionary<Advertisment, int> adv = new Dictionary<Advertisment,int>();
            foreach (KeyValuePair<string, List<string>> x in tags)
                for(int i=0; i<x.Value.Count; i++)
                    for(int q=0; q<db.Tags[x.Key][x.Value[i]].Count; q++)
                    {
                        Advertisment advertisment = db.Tags[x.Key][x.Value[i]][q];
                        if(advertisment.Theme != Theme_check.Text && Theme_check.Text.Length > 0 && Theme_check.Text != "All Themes") continue;
                        if((Buy.Checked && advertisment.BuyOrSail != "Buy" ||
                           Sell.Checked && advertisment.BuyOrSail != "Sell") && Buy.Checked != Sell.Checked) continue;
                        if(my_advertisment.Checked && advertisment.User_name != nick) continue;
                        if(!adv.ContainsKey(advertisment))
                            adv.Add(advertisment, 1); else
                            adv[advertisment]++;
                    }
            if (tags.Count == 0)
            {
                foreach (Advertisment advertisment in db.Advertisment.Values)
                {
                    if (advertisment.Theme != Theme_check.Text && Theme_check.Text.Length > 0 && Theme_check.Text != "All Themes") continue;
                    if ((Buy.Checked && advertisment.BuyOrSail != "Buy" ||
                       Sell.Checked && advertisment.BuyOrSail != "Sell") && Buy.Checked != Sell.Checked) continue;
                    if (my_advertisment.Checked && advertisment.User_name != nick) continue;
                    adv.Add(advertisment, 1);
                }
            }
            List<KeyValuePair<Advertisment, int>> a = new List<KeyValuePair<Advertisment, int>>();
            foreach (KeyValuePair<Advertisment, int> x in adv)
                a.Add(x);
            a.Sort(compare);
            for (int i = a.Count - 1; i>=0; i--)
                dataGridView1.Rows.Add(a[i].Key.Id, db.Users[a[i].Key.User_name].Rating, a[i].Key.Theme, a[i].Key.BuyOrSail, a[i].Key.Content);
        }
        private int compare(KeyValuePair<Advertisment, int> a, KeyValuePair<Advertisment, int> b)
        {
            if (a.Value == b.Value) return db.Users[a.Key.User_name].Rating.CompareTo(db.Users[b.Key.User_name].Rating);
            return a.Value.CompareTo(b.Value);
        }

        private void Advertisment_Add_Click(object sender, EventArgs e)
        {
            add_advertisment form = new add_advertisment(this);
            form.Show();
        }
        private void Theme_check_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Visible = false;
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
            Success a = new Success(this);
            a.Show();
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
        
        private void tegs_box_TextChanged(object sender, EventArgs e)
        {
            update_table();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void Form1_Click(object sender, EventArgs e)
        {
            listBox1.Visible = false;
            update_table();
        }
        private void listBox1_Click(object sender, EventArgs e)
        {
            Theme_check.Text = listBox1.Items[listBox1.SelectedIndex].ToString();
            listBox1.Visible = false;
        }
        private void listBox1_MouseMove(object sender, MouseEventArgs e)
        {
            int x = listBox1.Location.Y, y = this.Location.Y, z = MousePosition.Y;
            int a = z - y - x - 32;
            listBox1.SelectedIndex = a / 13;
        }
        private void listBox1_MouseLeave(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox1.Items.Count; i++) listBox1.SelectedIndex = -1;
        }
        private void Theme_check_ChangeFocused(object sender, EventArgs e)
        {
            if (!(listBox1.Focused)) listBox1.Visible = false;
            update_table();
        }
        private void Theme_check_TextChanged(object sender, EventArgs e)
        {
            List<string> a = new List<string>();
            foreach (string key in DB.DB.Keys)
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
        private void pictireBox5_Click(object sender, EventArgs e)
        {
            Statistic form = new Statistic(db);
            form.Show();
        }
        private void Theme_check_Click(object sender, EventArgs e)
        {
            listBox1.Visible = false;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            int x = this.Width, y = this.Height;

        }
        private void dataGridView1_Resize(int width, int height)
        {
        }

        private void tag_edit_but_Click(object sender, EventArgs e)
        {
            Edit_tags form = new Edit_tags(this);
            form.Show();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            db.Users_to_admin.Add(db.Users[nick]);
            goto_admin.Visible = false;
        }

        //---------------------------------Add_tag------------------------------------
        private void button1_Click(object sender, EventArgs e)
        {
            if (tag_check.Text.Length < 1 || tag_box.Text.Length < 1) return;
            if (!tags.ContainsKey(tag_check.Text)) tags.Add(tag_check.Text, new List<string>());
            if (!tags[tag_check.Text].Contains(tag_box.Text))
            {
                tags[tag_check.Text].Add(tag_box.Text);
                if (Tegs.Text == "Tags") Tegs.Text = "";
                Tegs.Text = Tegs.Text + tag_box.Text + "; ";
                db_tags[tag_check.Text.ToString()].Remove(tag_box.Text.ToString());
                update_tag_box();
                if (db_tags[tag_check.Text.ToString()].Count < 1)
                {
                    db_tags.Remove(tag_check.Text.ToString());
                    update_tag_check();
                    listBox2.Visible = false;
                }
                if (tag_check2.Text == tag_check.Text && tag_check2.Text != "") update_tag_box2(); else update_tag_check2();
                update_table();
            }
        }

        private void update_tag_check()
        {
            tag_box.Visible = false;
            if (tag_check.Items.Count < 1 || !db_tags.ContainsKey(tag_check.Text)) tag_check.Text = "";
            tag_check.Items.Clear();
            foreach (string a in db_tags.Keys) tag_check.Items.Add(a);
        }
        private void update_tag_box()
        {
            tag_box.Items.Clear();
            tag_box.Text = "";
            listBox3.Visible = false;
            foreach (string a in db_tags[tag_check.Text.ToString()]) tag_box.Items.Add(a);
            tag_box.Visible = true;
        }
        private void update_tag_check2()
        {
            tag_box2.Visible = false;
            if (tag_check2.Items.Count < 1 || !tags.ContainsKey(tag_check2.Text)) tag_check2.Text = "";
            tag_check2.Items.Clear();
            foreach (string a in tags.Keys) tag_check2.Items.Add(a);
        }
        private void update_tag_box2()
        {
            tag_box2.Text = "";
            tag_box2.Items.Clear();
            listBox4.Visible = false;
            foreach (string a in tags[tag_check2.Text.ToString()]) tag_box2.Items.Add(a);
            tag_box2.Visible = true;
        }

        private void Tag_check_TextChanged(object sender, EventArgs e)
        {
            List<string> a = new List<string>();
            foreach (string key in db_tags.Keys)
            {
                int k = 0;
                for (int i = 0; i < Math.Min(key.Length, tag_check.Text.Length); i++)
                    if (Program.big_small(key[i]) != Program.big_small(tag_check.Text[i])) k++;
                if (k < 2) a.Add(key);
            }
            listBox2.Items.Clear();
            for (int i = 0; i < Math.Min(a.Count, 5); i++) listBox2.Items.Add(a[i]);
            if (a.Count > 0)
            {
                listBox2.Size = new System.Drawing.Size(listBox2.Size.Width, 4 + 13 * Math.Min(5, a.Count));
                listBox2.Visible = true;
            }
            else listBox2.Visible = false;
            if (db_tags.ContainsKey(tag_check.Text.ToString()))
            {
                listBox2.Visible = false;
                update_tag_box();
            }
            tag_box.Visible = true;
        }
        private void Tag_check_ChangeFocused(object sender, EventArgs e)
        {
            if (!listBox2.Focused) listBox2.Visible = false;
        }
        private void Tag_check_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox2.Visible = false;
            update_tag_box();
        }
        private void Tag_check_Click(object sender, EventArgs e)
        {
            listBox2.Visible = false;
        }
        private void listBox2_Click(object sender, EventArgs e)
        {
            tag_check.Text = listBox2.Items[listBox2.SelectedIndex].ToString();
            listBox2.Visible = false;
            update_tag_box();
        }
        private void listBox2_MouseMove(object sender, MouseEventArgs e)
        {
            int x = listBox2.Location.Y, y = this.Location.Y, z = MousePosition.Y;
            int a = z - y - x - 32;
            listBox2.SelectedIndex = a / 13;
        }
        private void listBox2_MouseLeave(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox2.Items.Count; i++) listBox2.SelectedIndex = -1;
        }

        private void Tag_box_TextChanged(object sender, EventArgs e)
        {
            if (!db_tags.ContainsKey(tag_check.Text)) return;
            List<string> a = new List<string>();
            foreach (string key in db_tags[tag_check.Text])
            {
                int k = 0;
                for (int i = 0; i < Math.Min(key.Length, tag_box.Text.Length); i++)
                    if (Program.big_small(key[i]) != Program.big_small(tag_box.Text[i])) k++;
                if (k < 2) a.Add(key);
            }
            listBox3.Items.Clear();
            for (int i = 0; i < Math.Min(a.Count, 5); i++) listBox3.Items.Add(a[i]);
            if (a.Count > 0)
            {
                listBox3.Size = new System.Drawing.Size(listBox3.Size.Width, 4 + 13 * Math.Min(5, a.Count));
                listBox3.Visible = true;
            }
            else listBox3.Visible = false;
        }
        private void Tag_box_ChangeFocused(object sender, EventArgs e)
        {
            if (!listBox3.Focused) listBox3.Visible = false;
        }
        private void Tag_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox3.Visible = false;
        }
        private void Tag_box_Click(object sender, EventArgs e)
        {
            listBox3.Visible = false;
        }
        private void listBox3_Click(object sender, EventArgs e)
        {
            tag_box.Text = listBox3.Items[listBox3.SelectedIndex].ToString();
            listBox3.Visible = false;
        }
        private void listBox3_MouseMove(object sender, MouseEventArgs e)
        {
            int x = listBox3.Location.Y, y = this.Location.Y, z = MousePosition.Y;
            int a = z - y - x - 32;
            listBox3.SelectedIndex = a / 13;
        }
        private void listBox3_MouseLeave(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox3.Items.Count; i++) listBox3.SelectedIndex = -1;
        }

        //-----------------------------------------------delete_tag---------------------------------------
        private void button2_Click(object sender, EventArgs e)
        {
            if (!tags.ContainsKey(tag_check2.Text.ToString()) || !tags[tag_check2.Text.ToString()].Contains(tag_box2.Text.ToString())) return;
            tags[tag_check2.Text.ToString()].Remove(tag_box2.Text);
            int k = Tegs.Text.IndexOf(tag_box2.Text);
            Tegs.Text = Tegs.Text.Substring(0, k) + Tegs.Text.Substring(k + tag_box2.Text.Length + 2);

            if (!db_tags.ContainsKey(tag_check2.Text)) db_tags.Add(tag_check2.Text, new List<string>());
            db_tags[tag_check2.Text].Add(tag_box2.Text);
            if (tag_check2.Text == tag_check.Text && tag_check2.Text != "") update_tag_box(); else update_tag_check();

            update_tag_box2();
            if (tags[tag_check2.Text].Count < 1) { tags.Remove(tag_check2.Text); update_tag_check2(); }
            listBox5.Visible = false;
            update_table();
        }


        private void Tag_check2_TextChanged(object sender, EventArgs e)
        {
            List<string> a = new List<string>();
            foreach (string key in tags.Keys)
            {
                int k = 0;
                for (int i = 0; i < Math.Min(key.Length, tag_check2.Text.Length); i++)
                    if (Program.big_small(key[i]) != Program.big_small(tag_check2.Text[i])) k++;
                if (k < 2) a.Add(key);
            }
            listBox5.Items.Clear();
            for (int i = 0; i < Math.Min(a.Count, 5); i++) listBox5.Items.Add(a[i]);
            if (a.Count > 0)
            {
                listBox5.Size = new System.Drawing.Size(listBox5.Size.Width, 4 + 13 * Math.Min(5, a.Count));
                listBox5.Visible = true;
            }
            else listBox5.Visible = false;
            if (tags.ContainsKey(tag_check2.Text))
            {
                listBox5.Visible = false;
                update_tag_box2();
            }
            tag_box2.Visible = true;
        }
        private void Tag_check2_ChangeFocused(object sender, EventArgs e)
        {
            if (!listBox5.Focused) listBox5.Visible = false;
        }
        private void Tag_check2_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox5.Visible = false;
            update_tag_box2();
        }
        private void Tag_check2_Click(object sender, EventArgs e)
        {
            listBox5.Visible = false;
        }
        private void listBox5_Click(object sender, EventArgs e)
        {
            tag_check2.Text = listBox5.Items[listBox5.SelectedIndex].ToString();
            listBox5.Visible = false;
            update_tag_box2();
        }
        private void listBox5_MouseMove(object sender, MouseEventArgs e)
        {
            int x = listBox5.Location.Y, y = this.Location.Y, z = MousePosition.Y;
            int a = z - y - x - 32;
            listBox5.SelectedIndex = a / 13;
        }
        private void listBox5_MouseLeave(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox5.Items.Count; i++) listBox5.SelectedIndex = -1;
        }

        private void Tag_box2_TextChanged(object sender, EventArgs e)
        {
            if (!tags.ContainsKey(tag_check2.Text)) return;
            List<string> a = new List<string>();
            foreach (string key in tags[tag_check2.Text])
            {
                int k = 0;
                for (int i = 0; i < Math.Min(key.Length, tag_box2.Text.Length); i++)
                    if (Program.big_small(key[i]) != Program.big_small(tag_box2.Text[i])) k++;
                if (k < 2) a.Add(key);
            }
            listBox4.Items.Clear();
            for (int i = 0; i < Math.Min(a.Count, 5); i++) listBox4.Items.Add(a[i]);
            if (a.Count > 0)
            {
                listBox4.Size = new System.Drawing.Size(listBox4.Size.Width, 4 + 13 * Math.Min(5, a.Count));
                listBox4.Visible = true;
            }
            else listBox4.Visible = false;
        }
        private void Tag_box2_ChangeFocused(object sender, EventArgs e)
        {
            if (!listBox4.Focused) listBox4.Visible = false;
        }
        private void Tag_box2_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox4.Visible = false;
        }
        private void Tag_box2_Click(object sender, EventArgs e)
        {
            listBox4.Visible = false;
        }
        private void listBox4_Click(object sender, EventArgs e)
        {
            tag_box2.Text = listBox4.Items[listBox4.SelectedIndex].ToString();
            listBox4.Visible = false;
        }
        private void listBox4_MouseMove(object sender, MouseEventArgs e)
        {
            int x = listBox4.Location.Y, y = this.Location.Y, z = MousePosition.Y;
            int a = z - y - x - 32;
            listBox4.SelectedIndex = a / 13;
        }
        private void listBox4_MouseLeave(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox4.Items.Count; i++) listBox4.SelectedIndex = -1;
        }
    }
}
