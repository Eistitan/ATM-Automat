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
        User user;

        public int Kontonummer { get => kontonummer; private set => kontonummer = value; }

        public Konto(double kontostand,int kontonummer, User user)
        {
            this.Kontonummer = kontonummer;
            this.kontostand = kontostand;
            this.user = user;
        }

        public bool PIN_Check(int pin)
        {
            bool isTrue = false;
            if (pin == user.Pin)
                isTrue = true;
            return isTrue;
        }

        public double Kontostand_Abrufen()
        {
            return kontostand;
        }

        public bool Einzahlen(double einzahlung)
        {
            bool isTrue = false;
            kontostand = kontostand + einzahlung;
            return isTrue = true;
        }

        public bool Auszahlung(double auszahlung)
        {
            bool isTrue = false;
            if ((kontostand + user.Ueberzug()) >= auszahlung)
            {
                kontostand = kontostand - auszahlung;
                isTrue = true;
            }
            return isTrue;
        }
    }
}
