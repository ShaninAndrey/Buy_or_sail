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
    public partial class Statistic : Form
    {
        Graphics diagram;
        Dictionary<string, Users> users;
        List<KeyValuePair<bool, DateTime>> all;
        int n, m;
        string Ox, Oy;

        public Statistic(Table DB)
        {
            InitializeComponent();
            users = DB.Users;
            all = new List<KeyValuePair<bool, DateTime>>();
            DateTime mn = DateTime.Now;
            foreach (Users first in users.Values) if (mn > first.History[0].Value) mn = first.History[0].Value;
            all.Add(new KeyValuePair<bool, DateTime>(true, mn));
            comboBox1.Items.Add("All users");
            foreach (Users first in users.Values)
            {
                all.AddRange(first.History.GetRange(1, first.History.Count - 1));
                comboBox1.Items.Add(first.User_name);
            }
            all.Sort(CompareTo);
            n = 10;
            m = 5;
            Oy = "Advertisments";
        }

        void draw_diagram(List<KeyValuePair<bool, DateTime>> lst)
        {
            int x0 = 100, y0 = 300, length = 600, height = 250;
            KeyValuePair<int, int> segmentation = get_segmentation(lst);
            KeyValuePair<int, int> borders = draw_decart(x0, y0, x0+length, y0, x0, y0-height, n, m, segmentation, get_int(lst[0].Value));
            
            int x = 0, y = 0;

            Pen p = new Pen(Color.Red);
            Graphics red = this.CreateGraphics();
            for (int i = 1; i < lst.Count; )
            {
                int x1 = get_int(lst[i].Value) - get_int(lst[i - 1].Value), y1 = 0, k = i;
                for (; i < lst.Count && get_int(lst[i].Value) == x1 + get_int(lst[k - 1].Value); i++)
                    if (lst[i].Key) y1++; else y1--;

                red.DrawLine(p, x + x0, y0 - y, x0 + x + x1 * borders.Key / segmentation.Key, y0 - y - y1 * borders.Value / segmentation.Value);
                red.DrawLine(p, x + x0+1, y0 - y, x0 + x + 1+x1 * borders.Key / segmentation.Key, y0 - y - y1 * borders.Value / segmentation.Value);
                red.DrawLine(p, x + x0, y0 - y-1, x0 + x + x1 * borders.Key / segmentation.Key, y0 - y - 1-y1 * borders.Value / segmentation.Value);
                x += x1 * borders.Key / segmentation.Key;
                y += y1 * borders.Value / segmentation.Value;

            }
            p.Dispose();
            red.Dispose();
        }

        KeyValuePair<int, int> draw_decart(int x0, int y0, int xx, int xy, int yx, int yy, int nx, int ny, KeyValuePair<int, int> segm, int start)
        {
            Graphics decart = this.CreateGraphics();
            Pen p = new Pen(Color.Black);
            decart.DrawLine(p, x0, y0, xx, xy);
            decart.DrawString(Ox, this.Font, Brushes.Black, new PointF(xx, xy));
            decart.DrawLine(p, x0, y0, yx, yy);
            decart.DrawString(Oy, this.Font, Brushes.Black, new PointF(yx-35, yy-20));
            decart.DrawLine(p, xx, xy, xx - 3, xy + 3);
            decart.DrawLine(p, xx, xy, xx - 3, xy - 3);
            decart.DrawLine(p, yx, yy, yx - 3, yy + 3);
            decart.DrawLine(p, yx, yy, yx + 3, yy + 3);
            int x = xx - x0, y = y0 - yy;
            for (int i = 1; i < nx; i++)
            {
                decart.DrawLine(p, x0 + x / nx * i, xy - 3, x0 + x / nx * i, xy + 3);
                string str;
                if(Ox[0] != 'D') str = get_date(start + segm.Key * i).ToShortTimeString(); else
                    str = get_date(start + segm.Key * i).ToShortDateString();
                decart.DrawString(str, this.Font, Brushes.Black, new PointF(x0 + x / nx * i - 20, xy + 7));
            }
            for (int i = 1; i < ny; i++)
            {
                decart.DrawLine(p, yx - 3, y0 - y / ny * i, yx + 3, y0 - y / ny * i);
                decart.DrawString((i * segm.Value).ToString(), this.Font, Brushes.Black, new PointF(x0 - 30, y0 - y / ny * i - 7));
            }
            p.Dispose();
            decart.Dispose();
            return new KeyValuePair<int, int>(x / nx, y / ny);
        }

        private void Statistic_Load(object sender, EventArgs e)
        {
        }

        private void Statistic_Shown(object sender, EventArgs e)
        {
            List<Users> a = new List<Users>(users.Values);
            draw_diagram(all);
        }

        KeyValuePair<int, int> get_segmentation(List<KeyValuePair<bool, DateTime>> a)
        {
            int first = get_min(a.First().Value);
            int last = get_min(a.Last().Value);
            int x_min = last - first;
            Ox = "Minutes";
            if (x_min > 600)
            {
                first = get_hour(a.First().Value);
                last = get_hour(a.Last().Value);
                x_min = last - first;
                Ox = "Hours";
            }
            if (x_min > 240)
            {
                first = get_day(a.First().Value);
                last = get_day(a.Last().Value);
                x_min = last - first;
                Ox = "Days";
            }
            int l = 0, mx = 0;
            for (int i = 1; i < a.Count; i++) { if (a[i].Key) l++; else l--; mx = Math.Max(l, mx); }
            return new KeyValuePair<int, int>(x_min / n + 1, mx / m + 1);
        }
        int get_min(DateTime a)
        {
            int year = 365;
            return ((year * a.Year + a.DayOfYear) * 24 + a.Hour) * 60 + a.Minute;
        }
        int get_hour(DateTime a)
        {
            int year = 365;
            return (year * a.Year + a.DayOfYear) * 24 + a.Hour;
        }
        int get_day(DateTime a)
        {
            int year = 365;
            return year * a.Year + a.DayOfYear;
        }
        int get_int(DateTime a)
        {
            int year = 365;
            if(Ox[0] == 'M') return ((year * a.Year + a.DayOfYear) * 24 + a.Hour) * 60 + a.Minute;
            if(Ox[0] == 'H') return (year * a.Year + a.DayOfYear) * 24 + a.Hour;
            return year * a.Year + a.DayOfYear;
        }
        DateTime get_date(int x)
        {
            int minute = 0, hour = 0, second = 0;
            DateTime date;
            if (Ox[0] == 'M')
            {
                minute = x % 60;
                x /= 60;
                hour = x % 24;
                x /= 24;
            }
            if (Ox[0] == 'H')
            {
                hour = x % 24;
                x /= 24;
            }
            int[] m = new int[14];
            for (int i = 0; i < 13; i++) m[i] = 30;
            m[1] = 31;
            m[2] = 28;
            m[3] = 31;
            m[5] = 31;
            m[7] = 31;
            m[8] = 31;
            m[10] = 31;
            m[12] = 31;
            int day = x % 365;
            x /= 365;
            int year = x, month = 1;
            for (; month < 13 && day > m[month]; month++) day -= m[month];
            date = new DateTime(year, month, day, hour, minute, second);
            return date;
        }
        int CompareTo(KeyValuePair<bool, DateTime> a, KeyValuePair<bool, DateTime> b)
        {
            return a.Value.CompareTo(b.Value);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Graphics a = this.CreateGraphics();
            a.Clear(Color.White);
            if (comboBox1.SelectedItem.ToString() == "All users")
                draw_diagram(all); else
                draw_diagram(users[comboBox1.SelectedItem.ToString()].History);
        }
    }
}
