using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Buy_Or_Sail
{
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
        public int Id { get { return id; } }
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

}
