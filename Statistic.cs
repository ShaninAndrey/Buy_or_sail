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
        Dictionary<string, Users> users;
        List<KeyValuePair<bool, DateTime>> all;
        Brush[] b;
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
            n = 9;
            m = 5;
            Oy = "Advertisments";
            DateTime now = DateTime.Now;
            comboBox13.Text = now.Year.ToString();
            comboBox12.Text = now.Month.ToString();
            comboBox11.Text = now.Day.ToString();
            comboBox10.Text = now.Hour.ToString();
            comboBox9.Text = now.Minute.ToString();
            comboBox8.Text = now.Second.ToString();
            for (int i = 2000; i < DateTime.Now.Year+1; i++) { comboBox2.Items.Add(i); comboBox13.Items.Add(i); }
            for (int i = 1; i < 13; i++) { comboBox3.Items.Add(i); comboBox12.Items.Add(i); }
            for (int i = 1; i < 32; i++) { comboBox4.Items.Add(i); comboBox11.Items.Add(i); }
            for (int i = 0; i < 24; i++) { comboBox5.Items.Add(i); comboBox10.Items.Add(i); }
            for (int i = 0; i < 60; i++) { comboBox6.Items.Add(i); comboBox9.Items.Add(i); }
            for (int i = 0; i < 60; i++) { comboBox7.Items.Add(i); comboBox8.Items.Add(i); }
            b = PickBrush(users.Values.Count);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        void draw_user(Brush b, Users user, int x, int y)
        {
            Graphics g = this.CreateGraphics();
            g.FillRectangle(b, x, y, 10, 10);
            g.DrawRectangle(new Pen(Color.Black), x, y, 10, 10);
            g.DrawString(user.User_name + " : " + user.Rating.ToString(), this.Font, Brushes.Black, new Point(x + 20, y-2));
            g.Dispose();
        }
        void draw_diagram(List<KeyValuePair<bool, DateTime>> lst, int start)
        {
            int x0 = 300, y0 = 300, length = 500, height = 250;
            KeyValuePair<int, int> segmentation = get_segmentation(lst, start);
            KeyValuePair<int, int> borders = draw_decart(x0, y0, x0+length, y0, x0, y0-height, n, m, segmentation, get_int(lst[0].Value));
            y0 -= start * borders.Value / segmentation.Value;

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
        void draw_circle(List<Users> lst)
        {
            int x0 = 160, y0 = 200, r = 80, n = lst.Count;
            int sum = 0, s=0;
            for (int i = 0; i < lst.Count; i++) sum += lst[i].Rating;

            Graphics g = this.CreateGraphics();
            Random rand = new Random();
            for (int i = 0; i < lst.Count; i++)
            {
                g.FillPie(b[i], x0 - r, y0 - r, r * 2, r * 2, s * 360 / sum, lst[i].Rating * 360 / sum);
                s += lst[i].Rating;
            }
            g.Dispose();
        }
        void draw_borders(List<Users> lst, string ths)
        {
            int x0 = 160, y0 = 200, r = 80, n = lst.Count;
            int sum = 0, s = 0;
            for (int i = 0; i < lst.Count; i++) sum += lst[i].Rating;

            Pen p = new Pen(Color.Black);
            Graphics g = this.CreateGraphics();
            for (int i = 0; i <= 20; i++) g.DrawEllipse(p, Convert.ToInt32(x0 - r - 0.1 * i), Convert.ToInt32(y0 - r - 0.1 * i), Convert.ToInt32((0.1 * i + r) * 2), Convert.ToInt32((0.1 * i + r) * 2));
            lst.Add(lst[0]);
            for (int i = 0; i < lst.Count; i++)
            {
                int su = s + lst[i].Rating, x1 = Convert.ToInt32(Math.Cos(Math.PI * 2 * su / sum) * r) + x0, y1 = y0 + Convert.ToInt32(Math.Sin(Math.PI * 2 * su / sum) * r);
                if (ths == lst[i].User_name || i == lst.Count-1 && ths == lst[1].User_name || (i < lst.Count - 1 && ths == lst[i + 1].User_name))
                {
                    p.Color = Color.Gold;
                    if(ths == lst[i].User_name) for (int q = 0; q <= 20; q++)
                        g.DrawArc(p, Convert.ToInt32(x0 - r - 0.1 * q), Convert.ToInt32(y0 - r - 0.1 * q),
                                    Convert.ToInt32((0.1 * q + r) * 2), Convert.ToInt32((0.1 * q + r) * 2),
                                    s * 360 / sum, lst[i].Rating * 360 / sum);
                }
                g.DrawLine(p, x0, y0, x1, y1);
                g.DrawLine(p, x0 - 1, y0, x1 - 1, y1);
                g.DrawLine(p, x0 + 1, y0, x1 + 1, y1);
                g.DrawLine(p, x0, y0 - 1, x1, y1 - 1);
                g.DrawLine(p, x0, y0 + 1, x1, y1 + 1);
                p.Color = Color.Black;
                s += lst[i].Rating;
            }
            p.Dispose();
            g.Dispose();
        }

        private void Statistic_Load(object sender, EventArgs e)
        {
        }
        private void Statistic_Shown(object sender, EventArgs e)
        {
            draw_diagram(all, 0);
            Graphics g = this.CreateGraphics();
            g.DrawString("Rating :", this.Font, Brushes.Black, new Point(10, 15));
            for (int i = 0; i < users.Values.Count; i++)
            {
                draw_user(b[i], new List<Users>(users.Values)[i], 20, 50 + 20 * i);
            }
            draw_circle(new List<Users>(users.Values));
            draw_borders(new List<Users>(users.Values), "All users");
        }

        KeyValuePair<int, int> get_segmentation(List<KeyValuePair<bool, DateTime>> a, int start)
        {
            int first = get_min(a.First().Value);
            int last = get_min(a.Last().Value);
            int x_min = last - first;
            Ox = "Minutes";
            if (x_min > 120)
            {
                first = get_hour(a.First().Value);
                last = get_hour(a.Last().Value);
                x_min = last - first;
                Ox = "Hours";
            }
            if (Ox[0] == 'H' && x_min > 48)
            {
                first = get_day(a.First().Value);
                last = get_day(a.Last().Value);
                x_min = last - first;
                Ox = "Days";
                n = 8;
            }
            else n = 10;
            int l = start, mx = 0;
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
        private Brush[] PickBrush(int n)
        {
            Brush[] res = new Brush[n];
            Random rand = new Random();
            for(int i=0; i<n; i++) res[i] = new SolidBrush(Color.FromArgb(rand.Next(0, 255), rand.Next(0, 255), rand.Next(0, 255)));
            return res;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Graphics a = this.CreateGraphics();
            a.Clear(Color.FromArgb(250, 243, 217));
            a.DrawString("Rating :", this.Font, Brushes.Black, new Point(10, 15));
            for (int i = 0; i < users.Values.Count; i++)
            {
                draw_user(b[i], new List<Users>(users.Values)[i], 20, 50 + 20 * i);
            }
            a.Dispose();
            draw_circle(new List<Users>(users.Values));
            draw_borders(new List<Users>(users.Values), comboBox1.Text);
            List<KeyValuePair<bool, DateTime>> c;
            int start = 0;
            if (comboBox1.Text == "All users") c = all;
            else
               c = users[comboBox1.SelectedItem.ToString()].History;
            DateTime l = new DateTime(Convert.ToInt32(comboBox2.Text),
                Convert.ToInt32(comboBox3.Text),
                Convert.ToInt32(comboBox4.Text),
                Convert.ToInt32(comboBox5.Text),
                Convert.ToInt32(comboBox6.Text),
                Convert.ToInt32(comboBox7.Text));
            DateTime r = new DateTime(Convert.ToInt32(comboBox13.Text),
                Convert.ToInt32(comboBox12.Text),
                Convert.ToInt32(comboBox11.Text),
                Convert.ToInt32(comboBox10.Text),
                Convert.ToInt32(comboBox9.Text),
                Convert.ToInt32(comboBox8.Text));
            if (l >= r) { textBox9.Text = "Your date are invalid"; textBox9.Visible = true; return; }
            int first = 0, last = c.Count - 1;

            for (int i = 0; i < c.Count; i++)
            {
                if (c[i].Value < l)
                {
                    if (c[i].Key) start++; else start--;
                    first++;
                }
                if (c[i].Value > r) last--;
            }
            if (first >= last) { textBox9.Text = "No one changes in this range"; textBox9.Visible = true; return; }
            textBox9.Visible = false;
            draw_diagram(c.GetRange(first, last-first+1), start);
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
