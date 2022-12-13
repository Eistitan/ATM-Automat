using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_Automat
{
    internal class Premium_User : User
    {
        double ueberschuss = 1000;
        public double Ueberschuss { get => ueberschuss; private set => ueberschuss = value; }
        public Premium_User(int user_ID, int pin) : base(user_ID, pin)
        {

        }
        public override double Ueberzug()
        {
            return ueberschuss;
        }
    }
}
