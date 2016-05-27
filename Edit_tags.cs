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

        public Edit_tags(Form1 First)
        {
            InitializeComponent();
            this.MaximizeBox = false;
            first = First;
            tag = new Dictionary<string, List<string>>();
            new_tag = new Dictionary<string, List<string>>();

            foreach (KeyValuePair<string, Dictionary<string, List<Advertisment>>> a in First.DB.Tags) tag.Add(a.Key, a.Value.Keys.ToList());
            foreach (KeyValuePair<string, Dictionary<string, List<Advertisment>>> a in First.DB.New_tags) new_tag.Add(a.Key, a.Value.Keys.ToList());

            update_comboxes();
        }

        private void update_comboxes()
        {
            comboBox1.DataSource = tag.Keys.ToList();
            comboBox3.DataSource = new_tag.Keys.ToList();
            comboBox2.Visible = false;
            comboBox4.Visible = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            foreach (string a in new_tag[comboBox1.Text]) comboBox2.Items.Add(a);
            comboBox2.Visible = true;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox4.Items.Clear();
            foreach (string a in new_tag[comboBox3.Text]) comboBox4.Items.Add(a);
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
            update_comboxes();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!new_tag.ContainsKey(comboBox3.Text)) return;
            if (!new_tag[comboBox3.Text].Contains(comboBox4.Text)) return;
            first.DB.New_tags[comboBox3.Text].Remove(comboBox4.Text);
            if (first.DB.New_tags[comboBox3.Text].Count < 1) first.DB.New_tags.Remove(comboBox3.Text);
            new_tag[comboBox3.Text].Remove(comboBox4.Text);
            if (new_tag[comboBox3.Text].Count == 0) new_tag.Remove(comboBox3.Text);
            update_comboxes();
        }
    }
}
