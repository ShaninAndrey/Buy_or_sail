using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Buy_Or_Sail.Classes
{
    public class Table
    {
        int last_id;
        List<string> keys;
        Dictionary<string, Users> users;
        List<Users> users_to_admin;
        Dictionary<string, List<int>> keys_id;
        Dictionary<int, Advertisment> advertisment;
        Dictionary<string, Dictionary<int, Advertisment>> db;
        Dictionary<string, Dictionary<string, List<Advertisment>>> tag;
        Dictionary<string, Dictionary<string, List<Advertisment>>> new_tag;

        public List<Users> Users_to_admin { get { return users_to_admin; } }
        public Dictionary<string, Dictionary<string, List<Advertisment>>> Tags { get { return tag; } }
        public Dictionary<string, Dictionary<string, List<Advertisment>>> New_tags { get { return new_tag; } }
        public Dictionary<int, Advertisment> Advertisment { get { return advertisment; } }
        public Dictionary<string, List<int>> Keys_id { get { return keys_id; } }
        public int Last_id { get { last_id++; return last_id; } }
        public Dictionary<string, Users> Users { get { return users; } }
        public Dictionary<string, Dictionary<int, Advertisment>> DB
        {
            get { return db; }
        }
        public List<string> Keys
        {
            get { return keys; }
        }

        public Table()
        {
            File_work file = new File_work(new System.IO.StreamReader("DB.txt"));
            last_id = 0;
            db = new Dictionary<string, Dictionary<int, Advertisment>>();
            keys_id = new Dictionary<string, List<int>>();
            users = new Dictionary<string, Users>();
            keys = new List<string>();
            users_to_admin = new List<Buy_Or_Sail.Users>();
            advertisment = new Dictionary<int, Advertisment>();
            tag = new Dictionary<string, Dictionary<string, List<Buy_Or_Sail.Advertisment>>>();
            new_tag = new Dictionary<string, Dictionary<string, List<Buy_Or_Sail.Advertisment>>>();

            //------------------------------------Read_users--------------------------------
            int n = file.read_int();
            for (int i = 0; i < n; i++)
            {
                Users user = file.read_user();
                users.Add(user.User_name, user);
                last_id = Math.Max(last_id, user.Id);
            }

            //------------------------------------Read_users_to_admin----------------------------
            n = file.read_int();
            for (int i = 0; i < n; i++) users_to_admin.Add(users[file.read_str()]);

            //------------------------------------Read_advertisments--------------------------------
            n = file.read_int();
            for (int i = 0; i < n; i++)
            {
                Advertisment adv = file.read_advertisment();
                if (!(db.ContainsKey(adv.Theme))) { db.Add(adv.Theme, new Dictionary<int, Advertisment>()); keys.Add(adv.Theme); keys_id.Add(adv.Theme, new List<int>()); }
                keys_id[adv.Theme].Add(adv.Id);
                db[adv.Theme].Add(adv.Id, adv);
                advertisment.Add(adv.Id, adv);
                users[adv.User_name].Advertisment.Add(adv.Id, adv);
                last_id = Math.Max(last_id, adv.Id);
            }

            //------------------------------------Read_tags--------------------------------
            n = file.read_int();
            for (int i = 0; i < n; i++)
            {
                string name = file.read_str();
                tag.Add(name, new Dictionary<string, List<Advertisment>>());
                int m = file.read_int();
                for (int q = 0; q < m; q++)
                {
                    KeyValuePair<string, List<int>> a = file.read_tag();
                    tag[name].Add(a.Key, new List<Advertisment>());
                    for (int w = 0; w < a.Value.Count; w++)
                        if (advertisment.ContainsKey(a.Value[w]))
                            tag[name][a.Key].Add(advertisment[a.Value[w]]);
                }
            }

            //------------------------------------Read_new_tags--------------------------------
            n = file.read_int();
            for (int i = 0; i < n; i++)
            {
                string name = file.read_str();
                new_tag.Add(name, new Dictionary<string, List<Advertisment>>());
                int m = file.read_int();
                for (int q = 0; q < m; q++)
                {
                    KeyValuePair<string, List<int>> a = file.read_tag();
                    new_tag[name].Add(a.Key, new List<Advertisment>());
                    for (int w = 0; w < a.Value.Count; w++)
                        if (advertisment.ContainsKey(a.Value[w]))
                            new_tag[name][a.Key].Add(advertisment[a.Value[w]]);
                }

            }

            file.sr_close();
        }

        public void add_user(Users User)
        {
            users.Add(User.User_name, User);
        }
        public void add_user_to_admin(Users User)
        {
            users[User.User_name].user_to_admin();
        }
        public void add_user_form_admin(Users User)
        {
            users[User.User_name].user_form_admin();
        }
        public void add_advertisment(Advertisment a, Dictionary<string, List<string>> tags)
        {
            string theme = a.Theme;
            if (!(db.ContainsKey(theme)))
            {
                db.Add(theme, new Dictionary<int, Advertisment>());
                keys.Add(theme);
                keys_id.Add(theme, new List<int>());
            }
            keys_id[theme].Add(a.Id);
            db[theme].Add(a.Id, a);
            advertisment.Add(a.Id, a);
            users[a.User_name].add_advertisment(a);

            foreach (KeyValuePair<string, List<string>> x in tags)
            {
                add_tag(a, x);
            }
        }
        public void delete_advertisment(Advertisment a)
        {
            keys_id[a.Theme].Remove(a.Id);
            advertisment.Remove(a.Id);
            db[a.Theme].Remove(a.Id);
            users[a.User_name].delete_advertisment(a);
        }
        public void write()
        {
            File_work file = new File_work(new System.IO.StreamWriter("DB.txt"), new System.IO.FileInfo("DB.txt"));
            List<Users> User = new List<Users>(users.Values);
            Dictionary<string, List<Advertisment>> dict = new Dictionary<string, List<Advertisment>>();
            List<Advertisment> adv = new List<Advertisment>(advertisment.Values);


            file.write_int(User.Count);
            for (int i = 0; i < User.Count; i++) file.write_user(User[i]);
            file.write_int(users_to_admin.Count);
            for (int i = 0; i < users_to_admin.Count; i++) file.write_str(users_to_admin[i].User_name);
            file.write_int(adv.Count);
            for (int i = 0; i < adv.Count; i++) file.write_advertisment(adv[i]);


            file.write_int(tag.Count);
            foreach (KeyValuePair<string, Dictionary<string, List<Advertisment>>> a in tag)
            {
                file.write_str(a.Key);
                file.write_int(a.Value.Count);
                foreach (KeyValuePair<string, List<Advertisment>> b in a.Value)
                {
                    file.write_tag(b);
                }
            }

            file.write_int(new_tag.Count);
            foreach (KeyValuePair<string, Dictionary<string, List<Advertisment>>> a in new_tag)
            {
                file.write_str(a.Key);
                file.write_int(a.Value.Count);
                foreach (KeyValuePair<string, List<Advertisment>> b in a.Value)
                {
                    file.write_tag(b);
                }
            }

            file.sw_close();
        }

        private void add_new_tag(Advertisment a, KeyValuePair<string, List<string>> x)
        {
            if (!new_tag.ContainsKey(x.Key)) new_tag.Add(x.Key, new Dictionary<string, List<Advertisment>>());
            for (int i = 0; i < x.Value.Count; i++)
            {
                add_new_tag(a, new KeyValuePair<string, string>(x.Key, x.Value[i]));
            }
        }
        private void add_new_tag(Advertisment a, KeyValuePair<string, string> x)
        {
            if (!new_tag.ContainsKey(x.Key)) new_tag.Add(x.Key, new Dictionary<string, List<Advertisment>>());
            if (!new_tag[x.Key].ContainsKey(x.Value)) new_tag[x.Key].Add(x.Value, new List<Advertisment>());
            new_tag[x.Key][x.Value].Add(a);
        }
        private void add_tag(Advertisment a, KeyValuePair<string, List<string>> x)
        {
            if (!tag.ContainsKey(x.Key)) add_new_tag(a, x);
            else
            {
                for (int i = 0; i < x.Value.Count; i++)
                {
                    add_tag(a, new KeyValuePair<string, string>(x.Key, x.Value[i]));
                }
            }
        }
        private void add_tag(Advertisment a, KeyValuePair<string, string> x)
        {
            if (!tag[x.Key].ContainsKey(x.Value)) add_new_tag(a, x);
            else
                tag[x.Key][x.Value].Add(a);
        }
    }
}
