﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace Buy_Or_Sail
{
    public class Table
    {
        int last_id;
        List<string> keys;
        Dictionary<string, Users> users;
        Dictionary<string, List<int>> keys_id;
        Dictionary<string, Dictionary<int, Advertisment>> db;

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
            File_work file = new File_work(new StreamReader("DB.txt"));
            last_id = 0;
            db = new Dictionary<string, Dictionary<int, Advertisment>>();
            keys_id = new Dictionary<string, List<int>>();
            users = new Dictionary<string, Users>();
            keys = new List<string>();
            int n = file.read_int();
            last_id += n;
            for(int i=0; i<n; i++)
            {
                Users user = file.read_user();
                users.Add(user.User_name, user);
            }
            n = file.read_int();
            last_id += n;
            for (int i = 0; i < n; i++)
            {
                Advertisment adv = file.read_advertisment();
                if (!(db.ContainsKey(adv.Theme))) { db.Add(adv.Theme, new Dictionary<int, Advertisment>()); keys.Add(adv.Theme); keys_id.Add(adv.Theme, new List<int>()); }
                keys_id[adv.Theme].Add(adv.Id);
                db[adv.Theme].Add(adv.Id, adv);
                users[adv.User_name].add_advertisment(adv);
            }
            file.sr_close();
        }

        public void add_user(Users User)
        {
            users.Add(User.User_name, User);
        }
        public void add_advertisment(Advertisment a)
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
            users[a.User_name].add_advertisment(a);
        }
        public void delete_advertisment(Advertisment a)
        {
            keys_id[a.Theme].Remove(a.Id);
            db[a.Theme].Remove(a.Id);
        }
        public void write()
        {
            File_work file = new File_work(new StreamWriter("DB.txt"), new FileInfo("DB.txt"));
            List<Users> User = new List<Users>(users.Values);
            Dictionary<string, List<Advertisment>> dict = new Dictionary<string, List<Advertisment>>();
            for (int i = 0; i < keys.Count; i++) dict.Add(keys[i], new List<Advertisment>(db[keys[i]].Values));
            List<List<Advertisment>> adv = new List<List<Advertisment>>(dict.Values);
            file.write_int(User.Count);
            for (int i = 0; i < User.Count; i++) file.write_user(User[i]);
            int n=0;
            for (int i = 0; i < adv.Count; i++) n += adv[i].Count;
            file.write_int(n);
            for (int i = 0; i < adv.Count; i++) for (int q = 0; q < adv[i].Count; q++) file.write_advertisment(adv[i][q]);
            file.sw_close();
        }
    }

    public class Users
    {
        int id;
        string user_name, password, telephone;
        List<Advertisment> advertisment;

        public string Telephone { get { return telephone; } }
        public int Id { get { return id; } }
        public List<Advertisment> Advertisments { get { return advertisment; } }
        public string User_name { get { return user_name; } }
        public string Password { get { return password; } }

        public Users(int Id, string User_name, string Password, string Telephone)
        {
            id = Id;
            user_name = User_name;
            password = Password;
            telephone = Telephone;
            advertisment = new List<Advertisment>();
        }

        public void add_advertisment(Advertisment a)
        {
            advertisment.Add(a);
        }
    }

    public class Advertisment
    {
        string user_name, buyOrSail, content, text, theme;
        private int id;
        private List<string> tegs;

        public string User_name { get { return user_name; } }
        public string BuyOrSail { get { return buyOrSail; } }
        public string Theme { get { return theme; } }
        public int Id { get {return id;} }
        public string Content
        {
            get { return content; }
        }
        public string Text
        {
            get { return text; }
        }
        public List<string> Tegs
        {
            get { return tegs; }
        }

        public Advertisment(int Id, string User_name, string Theme, string BuyOrSail, string Content, string Text, string Tegs)
        {
            user_name = User_name;
            id = Id;
            theme = Theme;
            buyOrSail = BuyOrSail;
            content = Content;
            text = Text;
            tegs = new List<string>();
            int l = 0, r = Tegs.Length;
            while (Tegs[l] == ' ') l++;
            while (Tegs[r - 1] == ' ') r--;
            for(int i=l; i<r; i++) if(Tegs[i] == ' '){tegs.Add(Tegs.Substring(l, i-l)); l=i+1;}
            tegs.Add(Tegs.Substring(l, r-l));
        }
        public Advertisment(int Id, string User_name, string Theme)
        {
            id = Id;
            user_name = User_name;
            theme = Theme;
        }

    }

    class File_work
    {
        int id;
        StreamReader sr;
        StreamWriter sw;
        FileInfo fi;

        public File_work(StreamReader a)
        {
            id = 0;
            sr = a;
        }
        public File_work(StreamWriter a, FileInfo b)
        {
            id = 0;
            sw = a;
            fi = b;
        }

        public int read_int() { return Convert.ToInt32(sr.ReadLine()); }
        public Advertisment read_advertisment()
        {
            string user, theme, text, content, tegs, BOS;
            user = sr.ReadLine();
            BOS = sr.ReadLine();
            theme = sr.ReadLine();
            content = sr.ReadLine();
            text = sr.ReadLine();
            tegs = sr.ReadLine();
            id++;
            return new Advertisment(id, user, theme, BOS, content, text, tegs);
        }
        public Users read_user()
        {
            string user_name, password, tel;
            user_name = sr.ReadLine();
            password = sr.ReadLine();
            tel = sr.ReadLine();
            id++;
            return new Users(id, user_name, password, tel);
        }

        public void write_int(int a) { sw.WriteLine(a); }
        public void write_advertisment(Advertisment a)
        {
            sw.WriteLine(a.User_name);
            sw.WriteLine(a.BuyOrSail);
            sw.WriteLine(a.Theme);
            sw.WriteLine(a.Content);
            sw.WriteLine(a.Text);
            string tegs = "";
            if (a.Tegs.Count != 0) tegs = a.Tegs[0];
            for (int i = 1; i < a.Tegs.Count; i++) tegs = tegs + " " + a.Tegs[i];
            sw.WriteLine(tegs);
        }
        public void write_user(Users user)
        {
            sw.WriteLine(user.User_name);
            sw.WriteLine(user.Password);
            sw.WriteLine(user.Telephone);
        }

        public void sr_close()
        {
            sr.Close();
        }
        public void sw_close()
        {
            sw.Close();
        }
    }

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Table db = new Table();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(db));
            db.write();
        }

        public static char big_small(char a)
        {
            if (a >= 'A' && a <= 'Z') return (char)(a - 'A' + 'a');
            return a;
        }
    }
}
