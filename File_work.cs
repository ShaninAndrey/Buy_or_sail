using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Buy_Or_Sail
{
    public class File_work
    {
        int id;
        System.IO.StreamReader sr;
        System.IO.StreamWriter sw;
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
            string user_name, password, tel, adv, state;
            int rating, n;
            List<KeyValuePair<bool, DateTime>> time = new List<KeyValuePair<bool, DateTime>>();
            user_name = sr.ReadLine();
            state = sr.ReadLine();
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
                if (s[0] == '0') time.Add(new KeyValuePair<bool, DateTime>(false, date));
                else
                    time.Add(new KeyValuePair<bool, DateTime>(true, date));
            }
            string[] ids = adv.Split(' ');
            List<int> a = new List<int>();
            for (int i = 0; i < ids.Length - 1; i++) a.Add(Convert.ToInt32(ids[i]));
            return new Users(id, rating, user_name, state, password, tel, a, time);
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
            for (int i = 0; i < a.History.Count; i++) sw.WriteLine(Program.set_date(a.History[i]));
            write_int(a.Text.Length);
            for (int i = 0; i < a.Text.Length; i++) sw.WriteLine(a.Text[i]);
        }
        public void write_user(Users user)
        {
            sw.WriteLine(user.User_name);
            sw.WriteLine(user.State);
            sw.WriteLine(user.Id);
            sw.WriteLine(user.Password);
            sw.WriteLine(user.Rating);
            sw.WriteLine(user.Telephone);
            for (int i = 0; i < user.Id_adv.Count; i++) sw.Write(user.Id_adv[i].ToString() + " ");
            sw.WriteLine();
            write_int(user.History.Count);
            for (int i = 0; i < user.History.Count; i++)
                if (user.History[i].Key) sw.WriteLine("1" + Program.set_date(user.History[i].Value));
                else
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

}
