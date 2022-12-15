using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using _Excel = Microsoft.Office.Interop.Excel; //Shortcut


namespace ATM_Automat
{
    internal class Excel_A
    {   //Escape Sequenz \, \"
        //@"" - Alles Escapesequenzen werden ausgesetzt
        static string path = @"X:\Programm\ATM-Automat\bin\Debug\net7.0-windows\Archiv.xlsx";
        static int sheet_kunden = 1;
        static int sheet_konten = 2;
        static _Application excel = new _Excel.Application();
        static Workbook wb;
        static Worksheet ws;

        public static void Excel_Kunden_Oeffnen()
        {
            wb = excel.Workbooks.Open(path);
            ws = wb.Worksheets[sheet_kunden];
        }
        public static void Excel_Konten_Oeffnen()
        {
            wb = excel.Workbooks.Open(path);
            ws = wb.Worksheets[sheet_konten];
        }
        private static int Ablesen_Kunden_Freie_Position()
        {
            Excel_Kunden_Oeffnen();
            int i = 1;
            int j = 1;
            do
            {
                i++;
            } while (ws.Cells[i, j].Value2 != null);
            wb.Close();
            return i;
        }
        public static int Ablesen_Konto_Freie_Position()
        {
            Excel_Konten_Oeffnen();
            int i = 1;
            int j = 1;
            do
            {
                i++;
            } while (ws.Cells[i, j].Value2 != null);
            wb.Close();
            return i;
        }
        public static List<User> Liste_Kunden_Auslesen()
        {
            List<User> liste = new List<User>();
            Excel_Kunden_Oeffnen();
            int i = 2;
            int j;
            int user_ID = 0;
            int passpin = 0;
            bool isPremium = false;
            do
            {
                for (j = 1; j < 4; j++)
                {
                    switch (j)
                    {
                        case 1:
                            user_ID = (int)ws.Cells[i, j].Value;
                            break;
                        case 2:
                            passpin = (int)ws.Cells[i, j].Value;
                            break;
                        case 3:
                            isPremium = (Boolean)ws.Cells[i, j].Value;
                            break;
                    }
                }
                User u_new = ATM_Programm.Kunde_Erstellen(user_ID, passpin, isPremium);
                liste.Add(u_new);
                i++;

            } while (ws.Cells[i, 1].Value2 != null);
            wb.Save();
            wb.Close();
            return liste;
        }
        public static List<Konto> Liste_Konto_Auslesen()
        {
            List<User> liste_Kunden = Liste_Kunden_Auslesen();
            List<Konto> liste_Konten = new();
            Excel_Konten_Oeffnen();
            int i = 2;
            int j;
            int kontonummer = 0;
            int pin = 0;
            double kontostand = 0;
            User u=null;
            do
            {
                for (j = 1; j < 5; j++)
                {
                    switch (j)
                    {
                        case 1:
                            kontonummer = (int)ws.Cells[i, j].Value;
                            break;
                        case 2:
                            pin = (int)ws.Cells[i, j].Value;
                            break;
                        case 3:
                            kontostand = (double)ws.Cells[i, j].Value;
                            break;
                        case 4:
                            int user_ID = (int)ws.Cells[i, j].Value;
                            u = liste_Kunden.Find(x => x.User_ID == user_ID);
                            break;
                    }
                }
                Konto k_new = new(kontostand, kontonummer, pin, u);
                liste_Konten.Add(k_new);
                i++;

            } while (ws.Cells[i, 1].Value2 != null);
            wb.Save();
            wb.Close();
            return liste_Konten;
        }
        public static void Kontostand_Speichern(Konto k)
        {
            Excel_Konten_Oeffnen();
            int i = 1;
            do
            {
                i++;
                if (ws.Cells[i,1].Value==k.Kontonummer)
                {
                    ws.Cells[i, 3].Value = k.Kontostand;
                    break;
                }
            } while (ws.Cells[i, 1].Value2 != null);
            wb.Save();
            wb.Close();
        }
        public static void Excel_Kunde_Eintragen(User u)
        {
            int i = Ablesen_Kunden_Freie_Position();//der LeerePlatz
            Excel_Kunden_Oeffnen();

            for (int j = 1; j < 4; j++)
            {
                switch (j)
                {
                    case 1:
                        ws.Cells[i, j].Value = u.User_ID;
                        break;
                    case 2:
                        ws.Cells[i, j].Value = u.Pass_Pin;
                        break;
                    case 3:
                        ws.Cells[i, j].Value = u.IsPremium;
                        break;
                }
            }
            wb.Save();
            wb.Close();
        }
        public static void Excel_Konto_Eintragen(Konto k)
        {

            int i = Ablesen_Konto_Freie_Position();
            Excel_Konten_Oeffnen();

            for (int j = 1; j < 5; j++)
            {
                switch (j)
                {
                    case 1:
                        ws.Cells[i, j].Value = k.Kontonummer;
                        break;
                    case 2:
                        ws.Cells[i, j].Value = k.Pin;
                        break;
                    case 3:
                        ws.Cells[i, j].Value = k.Kontostand;
                        break;
                    case 4:
                        ws.Cells[i, j].Value = k.User.User_ID;
                        break;
                }
            }
            wb.Save();
            wb.Close();
        }
    }
}
