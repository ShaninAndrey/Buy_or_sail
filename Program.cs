using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace Buy_Or_Sail
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Buy_Or_Sail.Classes.Table db = new Classes.Table();

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
