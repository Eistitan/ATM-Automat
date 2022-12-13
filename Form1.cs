using System.IO;

namespace ATM_Automat
{
    public partial class Form1 : Form
    {
        ATM_Programm pro1 = new ATM_Programm();
        List<Konto> list;
        public Form1()
        {
            InitializeComponent();
            list = pro1.Liste_erstellen();
        }

        private void bt_OK_Click(object sender, EventArgs e)
        {
            int kontonummer = Int32.Parse(tB_Kontonummer.Text);
            int pin = Int32.Parse(tB_pin.Text);

            Konto k = pro1.Konto_Finden(kontonummer);
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
                }
                else
                {
                    MessageBox.Show("Pin ist Falsch");
                }
            }
        }

        private void bt_kontostand_Click(object sender, EventArgs e)
        {
            lb_kontostand.Text = Aktives_Konto().Kontostand_Abrufen().ToString();
        }

        private void bt_Einzahlen_Click(object sender, EventArgs e)
        {
            double einzahlung = double.Parse(tb_money.Text);
            bool isTrue = Aktives_Konto().Einzahlen(einzahlung);
            if (isTrue)
            {
                tb_money.Text = String.Empty;
                MessageBox.Show($"Einzahlung von {einzahlung} Euro erfolgreich.");
                lb_kontostand.Text = Aktives_Konto().Kontostand_Abrufen().ToString();
            }
            else
            {
                tb_money.Text = String.Empty;
                MessageBox.Show($"Einzahlung ist fehlgeschlagen");
                lb_kontostand.Text = Aktives_Konto().Kontostand_Abrufen().ToString();
            }
        }

        private void bt_Abheben_Click(object sender, EventArgs e)
        {
            double auszahlung = double.Parse(tb_money.Text);
            bool isTrue=Aktives_Konto().Auszahlung(auszahlung);
            if (isTrue)
            {
                tb_money.Text = String.Empty;
                MessageBox.Show($"Auszahlung von {auszahlung} Euro erfolgreich.");
                lb_kontostand.Text = Aktives_Konto().Kontostand_Abrufen().ToString();
            }
            else
            {
                tb_money.Text = String.Empty;
                MessageBox.Show($"Auszahlung ist fehlgeschlagen, zu wenig Geld auf dem Konto.");
                lb_kontostand.Text = Aktives_Konto().Kontostand_Abrufen().ToString();
            }
        }
        private Konto Aktives_Konto() //Sicherheitsrisiko
        {
            int kontonummer = Int32.Parse(tB_Kontonummer.Text);
            Konto k = pro1.Konto_Finden(kontonummer);
            return k;
        }
    }
}