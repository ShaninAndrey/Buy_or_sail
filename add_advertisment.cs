using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Buy_Or_Sail
{
    public partial class add_advertisment : Form
    {
        Form1 first;
        Dictionary<string, List<string>> tags;
        Dictionary<string, List<string>> db_tags;
        delegate void asdasdfasdfasdf();
        event asdasdfasdfasdf tag_check_selected;

        public add_advertisment(Form1 First)
        {
            first = First;
            this.MaximizeBox = false;
            InitializeComponent();
            foreach (string key in first.DB.DB.Keys) Theme_check.Items.Add(key);
            Theme_check.LostFocus += new System.EventHandler(Theme_check_ChangeFocused);
            tags = new Dictionary<string, List<string>>();
            db_tags = new Dictionary<string, List<string>>();
            tag_check_selected += select_tag_check;
            tag_check.LostFocus += Tag_check_ChangeFocused;
            tag_box.LostFocus += Tag_box_ChangeFocused;
            listBox2.MouseMove += listBox2_MouseMove;
            listBox3.MouseMove += listBox3_MouseMove;
            listBox1.MouseLeave += listBox1_MouseLeave;
            listBox2.MouseLeave += listBox2_MouseLeave;
            listBox3.MouseLeave += listBox3_MouseLeave;

            foreach (KeyValuePair<string, Dictionary<string, List<Advertisment>>> x in first.DB.Tags)
            {
                db_tags.Add(x.Key, new List<string>(x.Value.Keys));
            }
            if (db_tags.Count > 0) foreach (string a in db_tags.Keys) tag_check.Items.Add(a);
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
            List<DateTime> date = new List<DateTime>();
            date.Add(DateTime.Now);
            first.DB.add_advertisment(new Advertisment(first.DB.Last_id, first.Nick, str, BOS, Content.Text, Text.Lines, date), tags);
            first.update_table();
            this.Close();
        }
        private void select_tag_check()
        {
            tag_box.Text = "";
            tag_box.DataSource = db_tags[tag_check.Text];
            listBox3.Visible = false;
            tag_box.Visible = true;
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
        }
        private void Advertisment_Add_Click(object sender, EventArgs e)
        {
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
            Success form = new Success(this);
            form.Show();
        }
        private void Text_TextChanged(object sender, EventArgs e)
        {

        }
        private void Sail_CheckedChanged(object sender, EventArgs e)
        {
        }
        private void Buy_CheckedChanged(object sender, EventArgs e)
        {
        }
        private void Theme_string_Click(object sender, EventArgs e)
        {
        }
        private void label2_Click(object sender, EventArgs e)
        {
        }
        private void add_advertisment_Click(object sender, EventArgs e)
        {
            listBox1.Visible = false;
            listBox2.Visible = false;
            listBox3.Visible = false;
        }
        private void add_advertisment_Load(object sender, EventArgs e)
        {

        }

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
                if (db_tags[tag_check.Text.ToString()].Count < 1) { db_tags.Remove(tag_check.Text.ToString()); update_tag_check(); }
            }
        }

        private void update_tag_check()
        {
            tag_box.Visible = false;
            tag_check.Items.Clear();
            foreach (string a in db_tags.Keys) tag_check.Items.Add(a);
        }
        private void update_tag_box()
        {
            tag_box.Items.Clear();
            foreach (string a in db_tags[tag_check.Text.ToString()]) tag_box.Items.Add(a);
            tag_box.Visible = true;
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
        private void Theme_check_ChangeFocused(object sender, EventArgs e)
        {
            if(!listBox1.Focused) listBox1.Visible = false;
        }
        private void Theme_check_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Visible = false;
        }
        private void Theme_check_Click(object sender, EventArgs e)
        {
            listBox1.Visible = false;
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void listBox1_MouseHover(object sender, EventArgs e)
        {

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
            if (db_tags.ContainsKey(tag_check.Text))
            {
                listBox2.Visible = false;
                tag_check_selected();
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
            tag_check_selected();
        }
        private void Tag_check_Click(object sender, EventArgs e)
        {
            listBox2.Visible = false;
        }
        private void listBox2_Click(object sender, EventArgs e)
        {
            tag_check.Text = listBox2.Items[listBox2.SelectedIndex].ToString();
            listBox2.Visible = false;
            tag_check_selected();
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
    }
}
