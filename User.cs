using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_Automat
{
    internal class User
    {
        int user_ID;
        int pin;
        public int User_ID { get => user_ID; private set => user_ID = value; }
        public int Pin { get => pin; private set => pin = value; }

        public User(int user_ID, int pin)
        {
            this.User_ID = user_ID;
            this.Pin = pin;
        }
        public virtual double Ueberzug()
        {
            return 0;
        }
    }
}
