using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Buy_Or_Sail
{
    public class Users
    {
        int id, rating;
        string user_name, password, telephone, state;
        List<int> id_adv;
        Dictionary<int, Advertisment> advertisment;
        List<KeyValuePair<bool, DateTime>> history;

        public string State { get { return state; } }
        public List<KeyValuePair<bool, DateTime>> History { get { return history; } }
        public Dictionary<int, Advertisment> Advertisment { get { return advertisment; } }
        public List<int> Id_adv { get { return id_adv; } }
        public int Rating { get { return rating; } }
        public string Telephone { get { return telephone; } }
        public int Id { get { return id; } }
        public string User_name { get { return user_name; } }
        public string Password { get { return password; } }

        public Users(int Id, int Rating, string User_name, string State, string Password,
                    string Telephone, List<int> Id_adv, List<KeyValuePair<bool, DateTime>> History)
        {
            advertisment = new Dictionary<int, Advertisment>();
            state = State;
            history = History;
            rating = Rating;
            id = Id;
            user_name = User_name;
            password = Password;
            telephone = Telephone;
            id_adv = Id_adv;
        }

        public void user_to_admin() { state = "admin"; }
        public void user_form_admin() { state = "user"; }
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

}
