using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace Buy_Or_Sail
{
    public class Table
    {
        List<string> keys;
        Dictionary<string, List<Advertisment>> db;

        public Dictionary<string, List<Advertisment>> DB
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
            db = new Dictionary<string, List<Advertisment>>();
            keys = new List<string>();
            int n = file.read_int();
            for (int i = 0; i < n; i++) file.read(db, keys, i+1);
        }

        public void add(string theme, Advertisment a)
        {
            //if (db.ContainsKey(theme)) db.Add(theme, 
            //File_work file = new File_work(new StreamReader("DB.txt"));
        }

        public System.Windows.Forms.ComboBox cmbbx()
        {
            System.Windows.Forms.ComboBox cmbbx = new System.Windows.Forms.ComboBox();
            for (int i = 0; i < keys.Count; i++) cmbbx.Items.Add(keys[i]);
            return cmbbx;
        }
    }

    public class Advertisment
    {
        string buyOrSail;
        private int id;
        private string content, text, telephone;
        private List<string> tegs;

        public string BuyOrSail { get { return buyOrSail; } }
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
        public string Telephone
        {
            get { return telephone; }
        }

        public Advertisment(int Id, string BuyOrSail, string Content, string Text, string Tegs, string Telephone)
        {
            id = Id;
            buyOrSail = BuyOrSail;
            content = Content;
            text = Text;
            tegs = new List<string>();
            telephone = Telephone;
            int l = 0, r = Tegs.Length;
            while (Tegs[l] == ' ') l++;
            while (Tegs[r - 1] == ' ') r--;
            for(int i=l; i<r; i++) if(Tegs[i] == ' '){tegs.Add(Tegs.Substring(l, i-l)); l=i+1;}
            tegs.Add(Tegs.Substring(l, r-l));
        }

        public void print()
        {
            Console.WriteLine(content);
            Console.WriteLine(text);
            for (int i = 0; i < tegs.Count; i++) Console.Write(tegs[i] + " ");
            Console.WriteLine();
            Console.WriteLine(telephone);
        }
        //public
    }

    class File_work
    {
        StreamReader sr;
        StreamWriter sw;
        FileInfo fi;

        public File_work(StreamReader a)
        {
            sr = a;
        }
        public File_work(StreamWriter a, FileInfo b)
        {
            sw = a;
            fi = b;
        }

        public int read_int() { return Convert.ToInt32(sr.ReadLine()); }
        public void read(Dictionary<string, List<Advertisment>> a, List<string> k, int id)
        {
            string theme, text, content, tegs, tel;
            string BOS = sr.ReadLine();
            theme = sr.ReadLine();
            content = sr.ReadLine();
            text = sr.ReadLine();
            tegs = sr.ReadLine();
            tel = sr.ReadLine();
            Console.WriteLine(theme);
            if (!(a.ContainsKey(theme))) { a.Add(theme, new List<Advertisment>()); k.Add(theme); }
            a[theme].Add(new Advertisment(id, BOS, content, text, tegs, tel));
        }

        public void write(string theme, Advertisment a)
        {
            sw = fi.AppendText();
            sw.WriteLine(a.BuyOrSail + theme);
            sw.WriteLine(a.Content);
            sw.WriteLine(a.Text);
            string tegs = "";
            for (int i = 0; i < a.Tegs.Count; i++) tegs = tegs + " " + Convert.ToString(a.Tegs[i]);
            sw.WriteLine(tegs);
            sw.WriteLine(a.Telephone);
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
        }
    }
}
