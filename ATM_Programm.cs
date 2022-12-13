using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_Automat
{
    internal class ATM_Programm
    {
        //User u1 = new User(1, 1234);
        //User u2 = new Premium_User(2, 2345);
        Konto u1_konto = new(5000, 15, new User(3, 1234));
        Konto u2_konto = new(5000, 25, new Premium_User(4, 2345));
        List<Konto> konto_Liste = new List<Konto>();

        public List<Konto> Liste_erstellen()
        {
            konto_Liste.Add(u1_konto);
            konto_Liste.Add(u2_konto);
            return konto_Liste;
        }

        public Konto Konto_Finden(int kontonummer)
        {
            Konto k = konto_Liste.Find(x => x.Kontonummer == kontonummer);
            return k;
        }

    }
}
