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
    public partial class Edit_tags : Form
    {
        Form1 first;
        Dictionary<string, List<string>> tag, new_tag;
        List<string> user_admin;
        List<string> user_user;

        public Edit_tags(Form1 First)
        {
            InitializeComponent();
            this.MaximizeBox = false;
            first = First;
            tag = new Dictionary<string, List<string>>();
            new_tag = new Dictionary<string, List<string>>();
            user_admin = new List<string>();
            user_user = new List<string>();

            foreach (KeyValuePair<string, Dictionary<string, List<Advertisment>>> a in First.DB.Tags) tag.Add(a.Key, a.Value.Keys.ToList());
            foreach (KeyValuePair<string, Dictionary<string, List<Advertisment>>> a in First.DB.New_tags) new_tag.Add(a.Key, a.Value.Keys.ToList());
            foreach (Users user in First.DB.Users.Values.ToList()) if (user.State == "admin" && user.User_name != "andrey") user_admin.Add(user.User_name);
            for (int i = 0; i < First.DB.Users_to_admin.Count; i++) user_user.Add(First.DB.Users_to_admin[i].User_name);
            if (first.Nick == "andrey")
            {
                this.Text = "Admin window";
                this.Height += 85;
                comboBox6.Visible = true;
                comboBox5.Visible = true;
                button6.Visible = true;
                button4.Visible = true;
                button3.Visible = true;
                label5.Visible = true;
                label4.Visible = true;
            }
            update_comboxes(true, 3);
        }

        public void remove_user_from_admin()
        {
            first.DB.Users[comboBox6.Text.ToString()].user_form_admin();
            user_admin.Remove(comboBox6.Text.ToString());
            update_comboxes(false, 1);
        }
        public void add_user_to_admin()
        {
            first.DB.Users[comboBox5.Text.ToString()].user_to_admin();
            first.DB.Users_to_admin.Remove(first.DB.Users[comboBox5.Text.ToString()]);
            user_admin.Add(comboBox5.Text.ToString());
            user_user.Remove(comboBox5.Text.ToString());
            update_comboxes(false, 2);
        }
        public void remove_user_from_candedat()
        {
            first.DB.Users_to_admin.Remove(first.DB.Users[comboBox5.Text.ToString()]);
            user_user.Remove(comboBox5.Text.ToString());
            update_comboxes(false, 2);
        }

        private void update_comboxes(bool x, int y)
        {
            comboBox1.DataSource = tag.Keys.ToList();
            comboBox3.DataSource = new_tag.Keys.ToList();
            comboBox5.DataSource = user_user.ToList();
            comboBox6.DataSource = user_admin.ToList();
            if(y == 2 || y == 3) comboBox5.Text = "";
            if(y == 1 || y == 3) comboBox6.Text = "";
            if (x)
            {
                comboBox2.Visible = false;
                comboBox4.Visible = false;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            comboBox2.Text = "";
            foreach (string a in tag[comboBox1.Text.ToString()]) comboBox2.Items.Add(a);
            comboBox2.Visible = true;
        }
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox4.Items.Clear();
            comboBox4.Text = "";
            foreach (string a in new_tag[comboBox3.Text.ToString()]) comboBox4.Items.Add(a);
            comboBox4.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!new_tag.ContainsKey(comboBox3.Text)) return;
            if (!new_tag[comboBox3.Text].Contains(comboBox4.Text)) return;
            first.DB.Tags.Add(comboBox3.Text, new Dictionary<string, List<Advertisment>>());
            first.DB.Tags[comboBox3.Text].Add(comboBox4.Text, new List<Advertisment>());
            foreach(Advertisment a in first.DB.New_tags[comboBox3.Text][comboBox4.Text]) first.DB.Tags[comboBox3.Text][comboBox4.Text].Add(a);
            first.DB.New_tags[comboBox3.Text].Remove(comboBox4.Text);
            if (first.DB.New_tags[comboBox3.Text].Count < 1) first.DB.New_tags.Remove(comboBox3.Text);
            if (!tag.ContainsKey(comboBox3.Text)) tag.Add(comboBox3.Text, new List<string>());
            tag[comboBox3.Text].Add(comboBox4.Text);
            new_tag[comboBox3.Text].Remove(comboBox4.Text);
            if(new_tag[comboBox3.Text].Count == 0) new_tag.Remove(comboBox3.Text);
            update_comboxes(true, 0);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (!new_tag.ContainsKey(comboBox3.Text)) return;
            if (!new_tag[comboBox3.Text].Contains(comboBox4.Text)) return;
            first.DB.New_tags[comboBox3.Text].Remove(comboBox4.Text);
            if (first.DB.New_tags[comboBox3.Text].Count < 1) first.DB.New_tags.Remove(comboBox3.Text);
            new_tag[comboBox3.Text].Remove(comboBox4.Text);
            if (new_tag[comboBox3.Text].Count == 0) new_tag.Remove(comboBox3.Text);
            update_comboxes(true, 0);
        }
        private void Edit_tags_Click(object sender, EventArgs e)
        {
            
        }
        private void button6_Click(object sender, EventArgs e)
        {
            if (!user_admin.Contains(comboBox6.Text)) return;
            Success form = new Success(this, 0);
            form.Show();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (!user_user.Contains(comboBox5.Text)) return;
            Success form = new Success(this, 1);
            form.Show();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (!user_user.Contains(comboBox5.Text)) return;
            remove_user_from_candedat();
        }
    }
}
