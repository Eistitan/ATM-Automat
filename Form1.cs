using System.IO;

namespace ATM_Automat
{
    public partial class Form1 : Form
    {
        List<Konto> list;
        Konto temp_Konto;
        public Form1()
        {
            InitializeComponent();
            list = Excel_A.Liste_Konto_Auslesen();
        }

        private void bt_OK_Click(object sender, EventArgs e)
        {
            int kontonummer = Int32.Parse(tB_Kontonummer.Text);
            int pin = Int32.Parse(tB_pin.Text);

            Konto k = ATM_Programm.Konto_Finden(kontonummer, list);
            if (k is null)
            {
                MessageBox.Show("Kontonummer ist falsch");
            }
            else
            {
                if (k.PIN_Check(pin))
                {
                    pan_inter.Visible = true;
                    pan_autor.Visible = false;
                    MessageBox.Show("Angemeldet");
                    temp_Konto = k;
                    tB_Kontonummer.Text = String.Empty;
                    tB_pin.Text = String.Empty;
                    tB_Kontonummer.ReadOnly = true; //<<<<<<<<<<<<<<<<<<<<
                    pan_auswahl.Visible = false;
                }
                else
                {
                    MessageBox.Show("Pin ist Falsch");
                }
            }
        }
        private void bt_kontostand_Click(object sender, EventArgs e)
        {
            lb_kontostand.Text = temp_Konto.Kontostand_Abrufen().ToString();
        }
        private void bt_Einzahlen_Click(object sender, EventArgs e)
        {
            bool dau = double.TryParse(tb_money.Text, out double einzahlung);
            if (dau)
            {
                bool isTrue = temp_Konto.Einzahlen(einzahlung);
                if (isTrue)
                {
                    tb_money.Text = String.Empty;
                    MessageBox.Show($"Einzahlung von {einzahlung} Euro erfolgreich.");
                    lb_kontostand.Text = temp_Konto.Kontostand_Abrufen().ToString();
                }
                else
                {
                    tb_money.Text = String.Empty;
                    MessageBox.Show($"Einzahlung ist fehlgeschlagen");
                    lb_kontostand.Text = temp_Konto.Kontostand_Abrufen().ToString();
                }
            }
            else
            {
                MessageBox.Show("Wert ist falsch.");
            }
        }
        private void bt_Abheben_Click(object sender, EventArgs e)
        {
            bool dau = double.TryParse(tb_money.Text, out double auszahlung);
            if (dau)
            {
                bool isTrue = temp_Konto.Auszahlung(auszahlung);
                if (isTrue)
                {
                    tb_money.Text = String.Empty;
                    MessageBox.Show($"Auszahlung von {auszahlung} Euro erfolgreich.");
                    lb_kontostand.Text = temp_Konto.Kontostand_Abrufen().ToString();
                }
                else
                {
                    tb_money.Text = String.Empty;
                    MessageBox.Show($"Auszahlung ist fehlgeschlagen, zu wenig Geld auf dem Konto.");
                    lb_kontostand.Text = temp_Konto.Kontostand_Abrufen().ToString();
                }
            }
            else
            {
                MessageBox.Show("Wert ist falsch.");
            }
        }
        private void bt_ueberweisen_Click(object sender, EventArgs e)
        {
            int ueberweisungID = Int32.Parse(tB_ueberweisung.Text);

            bool dau = double.TryParse(tb_money.Text, out double ueberweisung);
            if (dau)
            {
                bool isTrue = temp_Konto.Auszahlung(ueberweisung);
                if (isTrue)
                {
                    Konto k = ATM_Programm.Konto_Finden(ueberweisungID, list);
                    if (k is not null)
                    {
                        k.Einzahlen(ueberweisung);
                        temp_Konto.Auszahlung(ueberweisung);
                        Excel_A.Kontostand_Speichern(k);
                        Excel_A.Kontostand_Speichern(temp_Konto);
                        tb_money.Text = String.Empty;
                        tB_ueberweisung.Text = String.Empty;
                        MessageBox.Show($"Auszahlung von {ueberweisung} Euro erfolgreich.");
                        lb_kontostand.Text = temp_Konto.Kontostand_Abrufen().ToString();
                        DateTime datum = DateTime.Now;
                        using (StreamWriter sw = new("Uebrweisungen.txt", true))
                        {
                            sw.WriteLine($"{temp_Konto.Kontonummer} überweist an {k.Kontonummer} am {datum} den Betrag von {ueberweisung} Euro");
                        }
                    }
                    else
                    {
                        MessageBox.Show($"Konto {ueberweisungID} wurde nicht gefunden");

                    }
                }
                else
                {
                    tb_money.Text = String.Empty;
                    MessageBox.Show($"Auszahlung ist fehlgeschlagen, zu wenig Geld auf dem Konto.");
                    lb_kontostand.Text = temp_Konto.Kontostand_Abrufen().ToString();
                }
            }
            else
            {
                MessageBox.Show("Wert ist falsch.");
            }
        }
        private void bt_Abmelden_Click(object sender, EventArgs e)
        {
            Excel_A.Kontostand_Speichern(temp_Konto);
            pan_inter.Visible = false;
            //pan_autor.Visible = true;
            MessageBox.Show("Abgemeldet");
            temp_Konto = null;
            tB_Kontonummer.Text = String.Empty;
            tB_pin.Text = String.Empty;
            lb_kontostand.Text = String.Empty;
            tB_Kontonummer.ReadOnly = false; //<<<<<<<<<<<<<<<<<<<<
            pan_auswahl.Visible = true;
        }
        private void bt_kunde_Click(object sender, EventArgs e)
        {
            pan_autor.Visible = true;
            pan_adm_login.Visible = false;
        }
        private void bt_admin_Click(object sender, EventArgs e)
        {
            pan_autor.Visible = false;
            pan_adm_login.Visible = true;
        }
        private void bt_admin_OK_Click(object sender, EventArgs e)
        {
            Admin a = Admin.Admin_Erstellen();
            string login = tB_admin_login.Text;
            string pass = tB_admin_pass.Text;

            if (login is null)
            {
                MessageBox.Show("Falsche Eingabe");
            }
            else if (a.Check_AD_Login(login))
            {
                if (pass is null)
                {
                    MessageBox.Show("Falsche Eingabe");
                }
                else if (a.Check_AD_Pass(pass))
                {
                    pan_administration.Visible = true;
                    pan_adm_login.Visible = false;
                    MessageBox.Show("Angemeldet");
                    tB_admin_login.Text = String.Empty;
                    tB_admin_pass.Text = String.Empty;
                    //tB_Kontonummer.ReadOnly = true; //<<<<<<<<<<<<<<<<<<<<
                    pan_auswahl.Visible = false;
                }
                else
                {
                    MessageBox.Show("Falsche Eingabe");
                }
            }
            else
            {
                MessageBox.Show("Falsche Eingabe");
            }
        }
        private void bt_ad_abmelden_Click(object sender, EventArgs e)
        {
            pan_administration.Visible = false;
            pan_adm_login.Visible = false;
            pan_auswahl.Visible = true;
            listBox1.Items.Clear();
        }
        private void bt_ad_kunden_anlegen_Click(object sender, EventArgs e)
        {
            pan_kunden_erstellen.Visible = true;
        }
        private void bt_ad_konto_anlegen_Click(object sender, EventArgs e)
        {
            pan_konto_erstellen.Visible = true;
            lb_konto_nr.Text = $"Kontonummer: {Excel_A.Ablesen_Konto_Freie_Position() - 1}";//EXcel wird weder geöffnet, noch geschlossen 
        }
        private void bt_user_erstellen_Click(object sender, EventArgs e)
        {
            int user_ID = Int32.Parse(tB_erstellen_userID.Text);
            int passpin = Int32.Parse(tB_erstellen_passpin.Text);
            bool isPremium = false; ;
            if (cB_iSPremium.Checked)
                isPremium = true;
            User u_new = ATM_Programm.Kunde_Erstellen(user_ID, passpin, isPremium);
            Excel_A.Excel_Kunde_Eintragen(u_new);
            tB_erstellen_userID.Text = String.Empty;
            tB_erstellen_passpin.Text = String.Empty;
            cB_iSPremium.Checked = false;
        }
        private void bt_erstellen_user_exit_Click(object sender, EventArgs e)
        {
            tB_erstellen_userID.Text = String.Empty;
            tB_erstellen_passpin.Text = String.Empty;
            cB_iSPremium.Checked = false;
            pan_kunden_erstellen.Visible = false;
        }
        private void bt_ad_kunden_uebersicht_Click(object sender, EventArgs e)
        {   //todo refresh Funktion einfügen
            pan_listbox.Visible = true;
            listBox1.Items.Clear();
            List<User> liste_archiv = Excel_A.Liste_Kunden_Auslesen();
            for (int i = 0; i < liste_archiv.Count; i++)
                listBox1.Items.Add($"Index {i + 1}) ID: {liste_archiv[i].User_ID.ToString()}, Premium: {liste_archiv[i].IsPremium.ToString()}");
        }
        private void bt_ad_konto_uebersicht_Click(object sender, EventArgs e)
        {
            pan_listbox.Visible = true;
            listBox1.Items.Clear();
            List<Konto> liste_archiv = Excel_A.Liste_Konto_Auslesen();
            for (int i = 0; i < liste_archiv.Count; i++)
                listBox1.Items.Add($"Index {i + 1}) Kontonummer: {liste_archiv[i].Kontonummer.ToString()}, Betrag: {liste_archiv[i].Kontostand.ToString()}, Kunde: {liste_archiv[i].User.User_ID.ToString()}");
        }
        private void bt_lB_close_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            pan_listbox.Visible = false;
        }
        private void bt_Konto_erstellen_ok(object sender, EventArgs e)
        {
            double betrag = Double.Parse(tB_erstellen_konto_betrag.Text);
            int pin = Int32.Parse(tB_erstellen_konto_pin.Text);
            int user_ID = Int32.Parse(tB_erstellen_konto_UserID.Text);
            List<User> u_List = Excel_A.Liste_Kunden_Auslesen();
            User u = u_List.Find(x => x.User_ID == user_ID);
            if (u is null)
                MessageBox.Show($"User mit der ID {user_ID} existiert nicht"); // übergang zur Kundenerstellung?
            else
            {
                lb_konto_nr.Text = $"Kontonummer: {Excel_A.Ablesen_Konto_Freie_Position() - 1}";//EXcel wird weder geöffnet, noch geschlossen 
                Konto k_new = Konto.Konto_hinzufuegen(u, betrag, pin, (Excel_A.Ablesen_Konto_Freie_Position() - 1));
                Excel_A.Excel_Konto_Eintragen(k_new);
                MessageBox.Show("Konto wurde erstellt");
                tB_erstellen_konto_betrag.Text = String.Empty;
                tB_erstellen_konto_pin.Text = String.Empty;
                tB_erstellen_konto_UserID.Text = String.Empty;
            }
        }
        private void bt_erstellen_konto_exit_Click(object sender, EventArgs e)
        {
            lb_konto_nr.Text = $"Kontonummer: ";
            tB_erstellen_konto_pin.Text = String.Empty;
            tB_erstellen_konto_betrag.Text = String.Empty;
            tB_erstellen_konto_UserID.Text = String.Empty;
            pan_konto_erstellen.Visible = false;
        }
    }

}
