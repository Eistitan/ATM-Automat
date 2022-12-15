using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_Automat
{
    internal class Konto
    {
        double kontostand;
        int kontonummer;
        int pin;
        User user;

        public int Kontonummer { get => kontonummer; private set => kontonummer = value; }
        internal User User { get => user; private set => user = value; }
        public int Pin { get => pin; private set => pin = value; }
        public double Kontostand { get => kontostand; private set => kontostand = value; }

        public Konto(double kontostand,int kontonummer,int pin, User user)
        {
            this.Kontonummer = kontonummer;
            this.Pin = pin;
            this.Kontostand = kontostand;
            this.User = user;
        }

        static List<Konto> konto_Liste = new List<Konto>();
        public static Konto Konto_hinzufuegen(User u, double kontostand, int pin,int kontonr)
        {
            Konto u_konto = new(kontostand, Excel_A.Ablesen_Konto_Freie_Position()-1, pin,u);
            return u_konto;
        }
        //public static List<Konto> Liste_Konto_Erstellen()
        //{   //TEst
        //    konto_Liste.Add(new Konto(50,1,1,new User(1,1,true)));
        //    konto_Liste.Add(new Konto(50,2,2,new User(2,2,false)));

        //    return konto_Liste;
        //}

        public bool PIN_Check(int check_pin)
        {
            bool isTrue = false;
            if (check_pin == Pin) //
                isTrue = true;
            return isTrue;
        }

        public double Kontostand_Abrufen()
        {
            return Kontostand;
        }

        public bool Einzahlen(double einzahlung)
        {
            bool isTrue = false;
            Kontostand = Kontostand + einzahlung;
            return isTrue = true;
        }

        public bool Auszahlung(double auszahlung)
        {
            bool isTrue = false;
            if ((Kontostand + User.Ueberzug()) >= auszahlung)
            {
                Kontostand = Kontostand - auszahlung;
                isTrue = true;
            }
            return isTrue;
        }
    }
}
