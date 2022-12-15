using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_Automat
{
    internal class User : Person
    {
        int user_ID;
        int pass_pin;
        bool isPremium;
        public int User_ID { get => user_ID; private set => user_ID = value; }
        public int Pass_Pin { get => pass_pin; private set => pass_pin = value; }
        public bool IsPremium { get => isPremium; private set => isPremium = value; }

        public User(int user_ID, int pin, bool isPremium)
        {
            this.User_ID = user_ID;
            this.Pass_Pin = pin;
            this.IsPremium = isPremium;
        }
        public double Ueberzug()
        {
            if (IsPremium)
                return 1000;
            return 0;
        }
        
        static List<User> user_liste = new();
        public static List<User> Liste_User_hinzufügen(User u)
        {
            user_liste.Add(u);
            return user_liste;
        }
    }
}
