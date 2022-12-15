using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;

namespace ATM_Automat
{
    internal class ATM_Programm
    {
        static public User Kunde_Erstellen(int user_id, int pin, bool isPremium)
        {
            User u = new(user_id, pin, isPremium);
            return u;
        }
        static public Konto Konto_Finden(int kontonummer, List<Konto> konto_Liste)
        {
            Konto k = konto_Liste.Find(x => x.Kontonummer == kontonummer);
            return k;
        }

    }
}
