using System;
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
        Dictionary<int, Advertisment> advertisment;
        Dictionary<string, Dictionary<int, Advertisment>> db;
        Dictionary<string, Dictionary<string, List<Advertisment>>> tag;
        Dictionary<string, Dictionary<string, List<Advertisment>>> new_tag;

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
            File_work file = new File_work(new StreamReader("DB.txt"));
            last_id = 0;
            db = new Dictionary<string, Dictionary<int, Advertisment>>();
            keys_id = new Dictionary<string, List<int>>();
            users = new Dictionary<string, Users>();
            keys = new List<string>();
            advertisment = new Dictionary<int, Advertisment>();
            tag = new Dictionary<string, Dictionary<string, List<Buy_Or_Sail.Advertisment>>>();
            new_tag = new Dictionary<string, Dictionary<string, List<Buy_Or_Sail.Advertisment>>>();

            //------------------------------------Read_users--------------------------------
            int n = file.read_int();
            for(int i=0; i<n; i++)
            {
                Users user = file.read_user();
                users.Add(user.User_name, user);
                last_id = Math.Max(last_id, user.Id);
            }

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
                        if(advertisment.ContainsKey(a.Value[w]))
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
                        if(advertisment.ContainsKey(a.Value[w]))
                            new_tag[name][a.Key].Add(advertisment[a.Value[w]]);
                }

            }

            file.sr_close();
        }

        public void add_user(Users User)
        {
            users.Add(User.User_name, User);
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
            if (!tag[x.Key].ContainsKey(x.Value)) add_new_tag(a, x); else
                tag[x.Key][x.Value].Add(a);
        }
    }

    public class Users
    {
        int id, rating;
        string user_name, password, telephone;
        List<int> id_adv;
        Dictionary<int, Advertisment> advertisment;
        List<KeyValuePair<bool, DateTime>> history;

        public List<KeyValuePair<bool, DateTime>> History { get { return history; } }
        public Dictionary<int, Advertisment> Advertisment { get { return advertisment; } }
        public List<int> Id_adv { get { return id_adv; } }
        public int Rating { get { return rating; } }
        public string Telephone { get { return telephone; } }
        public int Id { get { return id; } }
        public string User_name { get { return user_name; } }
        public string Password { get { return password; } }

        public Users(int Id, int Rating, string User_name, string Password, 
                    string Telephone, List<int> Id_adv, List<KeyValuePair<bool, DateTime>> History)
        {
            advertisment = new Dictionary<int, Advertisment>();
            history = History;
            rating = Rating;
            id = Id;
            user_name = User_name;
            password = Password;
            telephone = Telephone;
            id_adv = Id_adv;
        }

        public void rating_inc() { rating++; }
        public void rating_dec() { rating--; }
        public void add_advertisment(Advertisment a)
        {
            advertisment.Add(a.Id, a);
            history.Add(new KeyValuePair<bool, DateTime>(true, a.History.Last()));
        }
        public void delete_advertisment(Advertisment a)
        {
            advertisment.Remove(a.Id);
            history.Add(new KeyValuePair<bool, DateTime>(false, DateTime.Now));
        }
    }

    public class Advertisment : IComparable<Advertisment>
    {
        string user_name, buyOrSail, content, theme;
        string[] text;
        private int id;
        bool rating;
        List<DateTime> history;

        public List<DateTime> History { get { return history; } }
        public bool Rating { get { return rating; } set { rating = value; } }
        public string User_name { get { return user_name; } }
        public string BuyOrSail { get { return buyOrSail; } }
        public string Theme { get { return theme; } }
        public int Id { get {return id;} }
        public string Content
        {
            get { return content; }
            set { content = value; }
        }
        public string[] Text
        {
            get { return text; }
            set { text = value; }
        }

        public Advertisment(int Id, string User_name, string Theme, string BuyOrSail, string Content, string[] Text, List<DateTime> Date)
        {
            history = Date;
            rating = false;
            user_name = User_name;
            id = Id;
            theme = Theme;
            buyOrSail = BuyOrSail;
            content = Content;
            text = Text;
        }
        public Advertisment(int Id, string User_name, string Theme)
        {
            rating = false;
            id = Id;
            user_name = User_name;
            theme = Theme;
        }

        public int CompareTo(Advertisment other)
        {
            return History.Last().CompareTo(other.History.Last());
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
            string user, theme, content, BOS;
            List<DateTime> date = new List<DateTime>();
            List<string> text = new List<string>();
            user = sr.ReadLine();
            id = read_int();
            BOS = sr.ReadLine();
            theme = sr.ReadLine();
            content = sr.ReadLine();
            int m = read_int();
            for (int i = 0; i < m; i++) date.Add(Program.get_date(sr.ReadLine()));
            int n = read_int();
            for (int i = 0; i < n; i++) text.Add(sr.ReadLine());
            return new Advertisment(id, user, theme, BOS, content, text.ToArray(), date);
        }
        public Users read_user()
        {
            string user_name, password, tel, adv;
            int rating, n;
            List<KeyValuePair<bool, DateTime>> time = new List<KeyValuePair<bool, DateTime>>();
            user_name = sr.ReadLine();
            id = read_int();
            password = sr.ReadLine();
            rating = read_int();
            tel = sr.ReadLine();
            adv = sr.ReadLine();
            n = read_int();
            for (int i = 0; i < n; i++)
            {
                string s = sr.ReadLine();
                DateTime date = Program.get_date(s.Substring(1));
                if (s[0] == '0') time.Add(new KeyValuePair<bool, DateTime>(false, date)); else
                    time.Add(new KeyValuePair<bool, DateTime>(true, date));
            }
            string[] ids = adv.Split(' ');
            List<int> a = new List<int>();
            for (int i = 0; i < ids.Length-1; i++) a.Add(Convert.ToInt32(ids[i]));
            return new Users(id, rating, user_name, password, tel, a, time);
        }
        public KeyValuePair<string, List<int>> read_tag()
        {
            string name = sr.ReadLine(), x;
            int n = read_int();
            KeyValuePair<string, List<int>> ans = new KeyValuePair<string, List<int>>(name, new List<int>());
            for (int i = 0; i < n; i++)
            {
                x = sr.ReadLine();
                ans.Value.Add(Convert.ToInt32(x));
            }
            return ans;
        }
        public string read_str()
        {
            return sr.ReadLine();
        }

        public void write_int(int a) { sw.WriteLine(a); }
        public void write_advertisment(Advertisment a)
        {
            sw.WriteLine(a.User_name);
            sw.WriteLine(a.Id);
            sw.WriteLine(a.BuyOrSail);
            sw.WriteLine(a.Theme);
            sw.WriteLine(a.Content);
            write_int(a.History.Count);
            for(int i=0; i<a.History.Count; i++) sw.WriteLine(Program.set_date(a.History[i]));
            write_int(a.Text.Length);
            for(int i=0; i<a.Text.Length; i++) sw.WriteLine(a.Text[i]);
        }
        public void write_user(Users user)
        {
            sw.WriteLine(user.User_name);
            sw.WriteLine(user.Id);
            sw.WriteLine(user.Password);
            sw.WriteLine(user.Rating);
            sw.WriteLine(user.Telephone);
            for (int i = 0; i < user.Id_adv.Count; i++) sw.Write(user.Id_adv[i].ToString() + " ");
            sw.WriteLine();
            write_int(user.History.Count);
            for (int i = 0; i < user.History.Count; i++)
                if (user.History[i].Key) sw.WriteLine("1" + Program.set_date(user.History[i].Value)); else
                    sw.WriteLine("0" + Program.set_date(user.History[i].Value));
        }
        public void write_tag(KeyValuePair<string, List<Advertisment>> a)
        {
            sw.WriteLine(a.Key);
            write_int(a.Value.Count);
            for (int i = 0; i < a.Value.Count; i++) sw.WriteLine(a.Value[i].Id);
        }
        public void write_str(string a)
        {
            sw.WriteLine(a);
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

        public static DateTime get_date(string str)
        {
            int l = 0, k = 0;
            int[] b = new int[111];
            for (int i = 1; i < str.Length; i++) if (str[i] == '/' || str[i] == ' ' || str[i] == ':')
                {
                    int x = Convert.ToInt32(str.Substring(l, i - l));
                    l = i + 1;
                    b[k] = x;
                    k++;
                }
            if (str[str.Length - 2] == 'P') b[3] += 12;
            return new DateTime(b[2], b[0], b[1], b[3], b[4], b[5]);
        }
        public static string set_date(DateTime date)
        {
            string s = date.Month.ToString()+"/"+date.Day.ToString()+"/"+date.Year.ToString()+" "+(date.Hour%12).ToString()+":"+date.Minute.ToString()+":"+date.Second.ToString();
            if(date.Hour < 12) s = s+" AM"; else s = s+" PM";
            return s;
        }
    }
}
