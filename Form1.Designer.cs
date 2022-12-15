namespace ATM_Automat
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_money = new System.Windows.Forms.TextBox();
            this.bt_kontostand = new System.Windows.Forms.Button();
            this.bt_Einzahlen = new System.Windows.Forms.Button();
            this.bt_Abheben = new System.Windows.Forms.Button();
            this.bt_OK = new System.Windows.Forms.Button();
            this.pan_inter = new System.Windows.Forms.Panel();
            this.bt_Abmelden = new System.Windows.Forms.Button();
            this.lb_kontostand = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pan_auswahl = new System.Windows.Forms.Panel();
            this.pan_administration = new System.Windows.Forms.Panel();
            this.bt_ad_abmelden = new System.Windows.Forms.Button();
            this.bt_ad_konto_uebersicht = new System.Windows.Forms.Button();
            this.bt_ad_konto_loeschen = new System.Windows.Forms.Button();
            this.bt_ad_konto_anlegen = new System.Windows.Forms.Button();
            this.bt_ad_kunden_uebersicht = new System.Windows.Forms.Button();
            this.bt_ad_kunden_loeschen = new System.Windows.Forms.Button();
            this.bt_ad_kunden_anlegen = new System.Windows.Forms.Button();
            this.bt_admin = new System.Windows.Forms.Button();
            this.bt_kunde = new System.Windows.Forms.Button();
            this.pan_adm_login = new System.Windows.Forms.Panel();
            this.tB_admin_login = new System.Windows.Forms.TextBox();
            this.tB_admin_pass = new System.Windows.Forms.TextBox();
            this.bt_admin_OK = new System.Windows.Forms.Button();
            this.pan_autor = new System.Windows.Forms.Panel();
            this.tB_Kontonummer = new System.Windows.Forms.TextBox();
            this.tB_pin = new System.Windows.Forms.TextBox();
            this.pan_kunden_erstellen = new System.Windows.Forms.Panel();
            this.bt_erstellen_user_exit = new System.Windows.Forms.Button();
            this.bt_user_erstellen = new System.Windows.Forms.Button();
            this.cB_iSPremium = new System.Windows.Forms.CheckBox();
            this.tB_erstellen_passpin = new System.Windows.Forms.TextBox();
            this.tB_erstellen_userID = new System.Windows.Forms.TextBox();
            this.pan_listbox = new System.Windows.Forms.Panel();
            this.bt_lB_close = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.pan_konto_erstellen = new System.Windows.Forms.Panel();
            this.bt_erstellen_konto_exit = new System.Windows.Forms.Button();
            this.lb_konto_nr = new System.Windows.Forms.Label();
            this.tB_erstellen_konto_betrag = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tB_erstellen_konto_pin = new System.Windows.Forms.TextBox();
            this.tB_erstellen_konto_UserID = new System.Windows.Forms.TextBox();
            this.tB_ueberweisung = new System.Windows.Forms.TextBox();
            this.bt_ueberweisen = new System.Windows.Forms.Button();
            this.pan_inter.SuspendLayout();
            this.pan_auswahl.SuspendLayout();
            this.pan_administration.SuspendLayout();
            this.pan_adm_login.SuspendLayout();
            this.pan_autor.SuspendLayout();
            this.pan_kunden_erstellen.SuspendLayout();
            this.pan_listbox.SuspendLayout();
            this.pan_konto_erstellen.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_money
            // 
            this.tb_money.Location = new System.Drawing.Point(46, 52);
            this.tb_money.Name = "tb_money";
            this.tb_money.PlaceholderText = "Betrag";
            this.tb_money.Size = new System.Drawing.Size(200, 39);
            this.tb_money.TabIndex = 1;
            // 
            // bt_kontostand
            // 
            this.bt_kontostand.Location = new System.Drawing.Point(46, 154);
            this.bt_kontostand.Name = "bt_kontostand";
            this.bt_kontostand.Size = new System.Drawing.Size(150, 46);
            this.bt_kontostand.TabIndex = 2;
            this.bt_kontostand.Text = "Kontostand";
            this.bt_kontostand.UseVisualStyleBackColor = true;
            this.bt_kontostand.Click += new System.EventHandler(this.bt_kontostand_Click);
            // 
            // bt_Einzahlen
            // 
            this.bt_Einzahlen.Location = new System.Drawing.Point(252, 154);
            this.bt_Einzahlen.Name = "bt_Einzahlen";
            this.bt_Einzahlen.Size = new System.Drawing.Size(150, 46);
            this.bt_Einzahlen.TabIndex = 3;
            this.bt_Einzahlen.Text = "Einzahlen";
            this.bt_Einzahlen.UseVisualStyleBackColor = true;
            this.bt_Einzahlen.Click += new System.EventHandler(this.bt_Einzahlen_Click);
            // 
            // bt_Abheben
            // 
            this.bt_Abheben.Location = new System.Drawing.Point(466, 154);
            this.bt_Abheben.Name = "bt_Abheben";
            this.bt_Abheben.Size = new System.Drawing.Size(150, 46);
            this.bt_Abheben.TabIndex = 4;
            this.bt_Abheben.Text = "Abheben";
            this.bt_Abheben.UseVisualStyleBackColor = true;
            this.bt_Abheben.Click += new System.EventHandler(this.bt_Abheben_Click);
            // 
            // bt_OK
            // 
            this.bt_OK.Location = new System.Drawing.Point(527, 76);
            this.bt_OK.Name = "bt_OK";
            this.bt_OK.Size = new System.Drawing.Size(150, 46);
            this.bt_OK.TabIndex = 5;
            this.bt_OK.Text = "OK";
            this.bt_OK.UseVisualStyleBackColor = true;
            this.bt_OK.Click += new System.EventHandler(this.bt_OK_Click);
            // 
            // pan_inter
            // 
            this.pan_inter.Controls.Add(this.bt_ueberweisen);
            this.pan_inter.Controls.Add(this.tB_ueberweisung);
            this.pan_inter.Controls.Add(this.bt_Abmelden);
            this.pan_inter.Controls.Add(this.lb_kontostand);
            this.pan_inter.Controls.Add(this.label2);
            this.pan_inter.Controls.Add(this.tb_money);
            this.pan_inter.Controls.Add(this.bt_Abheben);
            this.pan_inter.Controls.Add(this.bt_kontostand);
            this.pan_inter.Controls.Add(this.bt_Einzahlen);
            this.pan_inter.Location = new System.Drawing.Point(184, 55);
            this.pan_inter.Name = "pan_inter";
            this.pan_inter.Size = new System.Drawing.Size(882, 335);
            this.pan_inter.TabIndex = 6;
            this.pan_inter.Visible = false;
            // 
            // bt_Abmelden
            // 
            this.bt_Abmelden.Location = new System.Drawing.Point(692, 154);
            this.bt_Abmelden.Name = "bt_Abmelden";
            this.bt_Abmelden.Size = new System.Drawing.Size(150, 46);
            this.bt_Abmelden.TabIndex = 7;
            this.bt_Abmelden.Text = "Abmelden";
            this.bt_Abmelden.UseVisualStyleBackColor = true;
            this.bt_Abmelden.Click += new System.EventHandler(this.bt_Abmelden_Click);
            // 
            // lb_kontostand
            // 
            this.lb_kontostand.AutoSize = true;
            this.lb_kontostand.Location = new System.Drawing.Point(787, 189);
            this.lb_kontostand.Name = "lb_kontostand";
            this.lb_kontostand.Size = new System.Drawing.Size(0, 32);
            this.lb_kontostand.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "Kontostand:";
            // 
            // pan_auswahl
            // 
            this.pan_auswahl.Controls.Add(this.pan_administration);
            this.pan_auswahl.Controls.Add(this.bt_admin);
            this.pan_auswahl.Controls.Add(this.bt_kunde);
            this.pan_auswahl.Controls.Add(this.pan_autor);
            this.pan_auswahl.Controls.Add(this.pan_adm_login);
            this.pan_auswahl.Location = new System.Drawing.Point(184, 554);
            this.pan_auswahl.Name = "pan_auswahl";
            this.pan_auswahl.Size = new System.Drawing.Size(1247, 514);
            this.pan_auswahl.TabIndex = 8;
            // 
            // pan_administration
            // 
            this.pan_administration.Controls.Add(this.bt_ad_abmelden);
            this.pan_administration.Controls.Add(this.bt_ad_konto_uebersicht);
            this.pan_administration.Controls.Add(this.bt_ad_konto_loeschen);
            this.pan_administration.Controls.Add(this.bt_ad_konto_anlegen);
            this.pan_administration.Controls.Add(this.bt_ad_kunden_uebersicht);
            this.pan_administration.Controls.Add(this.bt_ad_kunden_loeschen);
            this.pan_administration.Controls.Add(this.bt_ad_kunden_anlegen);
            this.pan_administration.Location = new System.Drawing.Point(42, 252);
            this.pan_administration.Name = "pan_administration";
            this.pan_administration.Size = new System.Drawing.Size(1182, 247);
            this.pan_administration.TabIndex = 9;
            this.pan_administration.Visible = false;
            // 
            // bt_ad_abmelden
            // 
            this.bt_ad_abmelden.Location = new System.Drawing.Point(820, 47);
            this.bt_ad_abmelden.Name = "bt_ad_abmelden";
            this.bt_ad_abmelden.Size = new System.Drawing.Size(150, 46);
            this.bt_ad_abmelden.TabIndex = 9;
            this.bt_ad_abmelden.Text = "Abmelden";
            this.bt_ad_abmelden.UseVisualStyleBackColor = true;
            this.bt_ad_abmelden.Click += new System.EventHandler(this.bt_ad_abmelden_Click);
            // 
            // bt_ad_konto_uebersicht
            // 
            this.bt_ad_konto_uebersicht.Location = new System.Drawing.Point(403, 184);
            this.bt_ad_konto_uebersicht.Name = "bt_ad_konto_uebersicht";
            this.bt_ad_konto_uebersicht.Size = new System.Drawing.Size(293, 46);
            this.bt_ad_konto_uebersicht.TabIndex = 8;
            this.bt_ad_konto_uebersicht.Text = "Kontenübersicht";
            this.bt_ad_konto_uebersicht.UseVisualStyleBackColor = true;
            this.bt_ad_konto_uebersicht.Click += new System.EventHandler(this.bt_ad_konto_uebersicht_Click);
            // 
            // bt_ad_konto_loeschen
            // 
            this.bt_ad_konto_loeschen.Location = new System.Drawing.Point(403, 116);
            this.bt_ad_konto_loeschen.Name = "bt_ad_konto_loeschen";
            this.bt_ad_konto_loeschen.Size = new System.Drawing.Size(293, 46);
            this.bt_ad_konto_loeschen.TabIndex = 7;
            this.bt_ad_konto_loeschen.Text = "Konto löschen";
            this.bt_ad_konto_loeschen.UseVisualStyleBackColor = true;
            // 
            // bt_ad_konto_anlegen
            // 
            this.bt_ad_konto_anlegen.Location = new System.Drawing.Point(403, 47);
            this.bt_ad_konto_anlegen.Name = "bt_ad_konto_anlegen";
            this.bt_ad_konto_anlegen.Size = new System.Drawing.Size(293, 46);
            this.bt_ad_konto_anlegen.TabIndex = 6;
            this.bt_ad_konto_anlegen.Text = "Konto anlegen";
            this.bt_ad_konto_anlegen.UseVisualStyleBackColor = true;
            this.bt_ad_konto_anlegen.Click += new System.EventHandler(this.bt_ad_konto_anlegen_Click);
            // 
            // bt_ad_kunden_uebersicht
            // 
            this.bt_ad_kunden_uebersicht.Location = new System.Drawing.Point(35, 184);
            this.bt_ad_kunden_uebersicht.Name = "bt_ad_kunden_uebersicht";
            this.bt_ad_kunden_uebersicht.Size = new System.Drawing.Size(283, 46);
            this.bt_ad_kunden_uebersicht.TabIndex = 5;
            this.bt_ad_kunden_uebersicht.Text = "Kundenübersicht";
            this.bt_ad_kunden_uebersicht.UseVisualStyleBackColor = true;
            this.bt_ad_kunden_uebersicht.Click += new System.EventHandler(this.bt_ad_kunden_uebersicht_Click);
            // 
            // bt_ad_kunden_loeschen
            // 
            this.bt_ad_kunden_loeschen.Location = new System.Drawing.Point(35, 116);
            this.bt_ad_kunden_loeschen.Name = "bt_ad_kunden_loeschen";
            this.bt_ad_kunden_loeschen.Size = new System.Drawing.Size(293, 46);
            this.bt_ad_kunden_loeschen.TabIndex = 4;
            this.bt_ad_kunden_loeschen.Text = "Kunden löschen";
            this.bt_ad_kunden_loeschen.UseVisualStyleBackColor = true;
            // 
            // bt_ad_kunden_anlegen
            // 
            this.bt_ad_kunden_anlegen.Location = new System.Drawing.Point(35, 47);
            this.bt_ad_kunden_anlegen.Name = "bt_ad_kunden_anlegen";
            this.bt_ad_kunden_anlegen.Size = new System.Drawing.Size(293, 46);
            this.bt_ad_kunden_anlegen.TabIndex = 3;
            this.bt_ad_kunden_anlegen.Text = "Kunden anlegen";
            this.bt_ad_kunden_anlegen.UseVisualStyleBackColor = true;
            this.bt_ad_kunden_anlegen.Click += new System.EventHandler(this.bt_ad_kunden_anlegen_Click);
            // 
            // bt_admin
            // 
            this.bt_admin.Location = new System.Drawing.Point(45, 137);
            this.bt_admin.Name = "bt_admin";
            this.bt_admin.Size = new System.Drawing.Size(252, 51);
            this.bt_admin.TabIndex = 1;
            this.bt_admin.Text = "Administration";
            this.bt_admin.UseVisualStyleBackColor = true;
            this.bt_admin.Click += new System.EventHandler(this.bt_admin_Click);
            // 
            // bt_kunde
            // 
            this.bt_kunde.Location = new System.Drawing.Point(45, 57);
            this.bt_kunde.Name = "bt_kunde";
            this.bt_kunde.Size = new System.Drawing.Size(252, 51);
            this.bt_kunde.TabIndex = 0;
            this.bt_kunde.Text = "Kunde";
            this.bt_kunde.UseVisualStyleBackColor = true;
            this.bt_kunde.Click += new System.EventHandler(this.bt_kunde_Click);
            // 
            // pan_adm_login
            // 
            this.pan_adm_login.Controls.Add(this.tB_admin_login);
            this.pan_adm_login.Controls.Add(this.tB_admin_pass);
            this.pan_adm_login.Controls.Add(this.bt_admin_OK);
            this.pan_adm_login.Location = new System.Drawing.Point(483, 40);
            this.pan_adm_login.Name = "pan_adm_login";
            this.pan_adm_login.Size = new System.Drawing.Size(737, 183);
            this.pan_adm_login.TabIndex = 8;
            this.pan_adm_login.Visible = false;
            // 
            // tB_admin_login
            // 
            this.tB_admin_login.Location = new System.Drawing.Point(55, 75);
            this.tB_admin_login.Name = "tB_admin_login";
            this.tB_admin_login.PlaceholderText = "Login";
            this.tB_admin_login.Size = new System.Drawing.Size(200, 39);
            this.tB_admin_login.TabIndex = 7;
            // 
            // tB_admin_pass
            // 
            this.tB_admin_pass.Location = new System.Drawing.Point(303, 75);
            this.tB_admin_pass.Name = "tB_admin_pass";
            this.tB_admin_pass.PlaceholderText = "Password";
            this.tB_admin_pass.Size = new System.Drawing.Size(200, 39);
            this.tB_admin_pass.TabIndex = 5;
            // 
            // bt_admin_OK
            // 
            this.bt_admin_OK.Location = new System.Drawing.Point(535, 71);
            this.bt_admin_OK.Name = "bt_admin_OK";
            this.bt_admin_OK.Size = new System.Drawing.Size(150, 46);
            this.bt_admin_OK.TabIndex = 5;
            this.bt_admin_OK.Text = "OK";
            this.bt_admin_OK.UseVisualStyleBackColor = true;
            this.bt_admin_OK.Click += new System.EventHandler(this.bt_admin_OK_Click);
            // 
            // pan_autor
            // 
            this.pan_autor.Controls.Add(this.tB_Kontonummer);
            this.pan_autor.Controls.Add(this.tB_pin);
            this.pan_autor.Controls.Add(this.bt_OK);
            this.pan_autor.Location = new System.Drawing.Point(482, 39);
            this.pan_autor.Name = "pan_autor";
            this.pan_autor.Size = new System.Drawing.Size(737, 183);
            this.pan_autor.TabIndex = 7;
            this.pan_autor.Visible = false;
            // 
            // tB_Kontonummer
            // 
            this.tB_Kontonummer.Location = new System.Drawing.Point(47, 80);
            this.tB_Kontonummer.Name = "tB_Kontonummer";
            this.tB_Kontonummer.PlaceholderText = "KontoNr";
            this.tB_Kontonummer.Size = new System.Drawing.Size(200, 39);
            this.tB_Kontonummer.TabIndex = 7;
            // 
            // tB_pin
            // 
            this.tB_pin.Location = new System.Drawing.Point(295, 80);
            this.tB_pin.Name = "tB_pin";
            this.tB_pin.PlaceholderText = "Pin";
            this.tB_pin.Size = new System.Drawing.Size(200, 39);
            this.tB_pin.TabIndex = 5;
            // 
            // pan_kunden_erstellen
            // 
            this.pan_kunden_erstellen.Controls.Add(this.bt_erstellen_user_exit);
            this.pan_kunden_erstellen.Controls.Add(this.bt_user_erstellen);
            this.pan_kunden_erstellen.Controls.Add(this.cB_iSPremium);
            this.pan_kunden_erstellen.Controls.Add(this.tB_erstellen_passpin);
            this.pan_kunden_erstellen.Controls.Add(this.tB_erstellen_userID);
            this.pan_kunden_erstellen.Location = new System.Drawing.Point(159, 430);
            this.pan_kunden_erstellen.Name = "pan_kunden_erstellen";
            this.pan_kunden_erstellen.Size = new System.Drawing.Size(502, 380);
            this.pan_kunden_erstellen.TabIndex = 9;
            this.pan_kunden_erstellen.Visible = false;
            // 
            // bt_erstellen_user_exit
            // 
            this.bt_erstellen_user_exit.Location = new System.Drawing.Point(287, 281);
            this.bt_erstellen_user_exit.Name = "bt_erstellen_user_exit";
            this.bt_erstellen_user_exit.Size = new System.Drawing.Size(115, 57);
            this.bt_erstellen_user_exit.TabIndex = 7;
            this.bt_erstellen_user_exit.Text = "Exit";
            this.bt_erstellen_user_exit.UseVisualStyleBackColor = true;
            this.bt_erstellen_user_exit.Click += new System.EventHandler(this.bt_erstellen_user_exit_Click);
            // 
            // bt_user_erstellen
            // 
            this.bt_user_erstellen.Location = new System.Drawing.Point(75, 281);
            this.bt_user_erstellen.Name = "bt_user_erstellen";
            this.bt_user_erstellen.Size = new System.Drawing.Size(206, 57);
            this.bt_user_erstellen.TabIndex = 3;
            this.bt_user_erstellen.Text = "Erstellen";
            this.bt_user_erstellen.UseVisualStyleBackColor = true;
            this.bt_user_erstellen.Click += new System.EventHandler(this.bt_user_erstellen_Click);
            // 
            // cB_iSPremium
            // 
            this.cB_iSPremium.AutoSize = true;
            this.cB_iSPremium.Location = new System.Drawing.Point(72, 214);
            this.cB_iSPremium.Name = "cB_iSPremium";
            this.cB_iSPremium.Size = new System.Drawing.Size(196, 36);
            this.cB_iSPremium.TabIndex = 2;
            this.cB_iSPremium.Text = "Premium User";
            this.cB_iSPremium.UseVisualStyleBackColor = true;
            // 
            // tB_erstellen_passpin
            // 
            this.tB_erstellen_passpin.Location = new System.Drawing.Point(72, 138);
            this.tB_erstellen_passpin.Name = "tB_erstellen_passpin";
            this.tB_erstellen_passpin.PlaceholderText = "Pass Pin";
            this.tB_erstellen_passpin.Size = new System.Drawing.Size(330, 39);
            this.tB_erstellen_passpin.TabIndex = 1;
            // 
            // tB_erstellen_userID
            // 
            this.tB_erstellen_userID.Location = new System.Drawing.Point(72, 56);
            this.tB_erstellen_userID.Name = "tB_erstellen_userID";
            this.tB_erstellen_userID.PlaceholderText = "User ID";
            this.tB_erstellen_userID.Size = new System.Drawing.Size(330, 39);
            this.tB_erstellen_userID.TabIndex = 0;
            // 
            // pan_listbox
            // 
            this.pan_listbox.Controls.Add(this.bt_lB_close);
            this.pan_listbox.Controls.Add(this.listBox1);
            this.pan_listbox.Location = new System.Drawing.Point(800, 51);
            this.pan_listbox.Name = "pan_listbox";
            this.pan_listbox.Size = new System.Drawing.Size(630, 650);
            this.pan_listbox.TabIndex = 10;
            this.pan_listbox.Visible = false;
            // 
            // bt_lB_close
            // 
            this.bt_lB_close.Location = new System.Drawing.Point(197, 582);
            this.bt_lB_close.Name = "bt_lB_close";
            this.bt_lB_close.Size = new System.Drawing.Size(244, 43);
            this.bt_lB_close.TabIndex = 1;
            this.bt_lB_close.Text = "Exit";
            this.bt_lB_close.UseVisualStyleBackColor = true;
            this.bt_lB_close.Click += new System.EventHandler(this.bt_lB_close_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 32;
            this.listBox1.Location = new System.Drawing.Point(41, 37);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(554, 516);
            this.listBox1.TabIndex = 0;
            // 
            // pan_konto_erstellen
            // 
            this.pan_konto_erstellen.Controls.Add(this.bt_erstellen_konto_exit);
            this.pan_konto_erstellen.Controls.Add(this.lb_konto_nr);
            this.pan_konto_erstellen.Controls.Add(this.tB_erstellen_konto_betrag);
            this.pan_konto_erstellen.Controls.Add(this.button1);
            this.pan_konto_erstellen.Controls.Add(this.tB_erstellen_konto_pin);
            this.pan_konto_erstellen.Controls.Add(this.tB_erstellen_konto_UserID);
            this.pan_konto_erstellen.Location = new System.Drawing.Point(155, 423);
            this.pan_konto_erstellen.Name = "pan_konto_erstellen";
            this.pan_konto_erstellen.Size = new System.Drawing.Size(502, 380);
            this.pan_konto_erstellen.TabIndex = 10;
            this.pan_konto_erstellen.Visible = false;
            // 
            // bt_erstellen_konto_exit
            // 
            this.bt_erstellen_konto_exit.Location = new System.Drawing.Point(291, 281);
            this.bt_erstellen_konto_exit.Name = "bt_erstellen_konto_exit";
            this.bt_erstellen_konto_exit.Size = new System.Drawing.Size(115, 57);
            this.bt_erstellen_konto_exit.TabIndex = 6;
            this.bt_erstellen_konto_exit.Text = "Exit";
            this.bt_erstellen_konto_exit.UseVisualStyleBackColor = true;
            this.bt_erstellen_konto_exit.Click += new System.EventHandler(this.bt_erstellen_konto_exit_Click);
            // 
            // lb_konto_nr
            // 
            this.lb_konto_nr.AutoSize = true;
            this.lb_konto_nr.Location = new System.Drawing.Point(72, 47);
            this.lb_konto_nr.Name = "lb_konto_nr";
            this.lb_konto_nr.Size = new System.Drawing.Size(184, 32);
            this.lb_konto_nr.TabIndex = 5;
            this.lb_konto_nr.Text = "KontoNummer: ";
            // 
            // tB_erstellen_konto_betrag
            // 
            this.tB_erstellen_konto_betrag.Location = new System.Drawing.Point(69, 170);
            this.tB_erstellen_konto_betrag.Name = "tB_erstellen_konto_betrag";
            this.tB_erstellen_konto_betrag.PlaceholderText = "Anfangsbetrag";
            this.tB_erstellen_konto_betrag.Size = new System.Drawing.Size(330, 39);
            this.tB_erstellen_konto_betrag.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(75, 281);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(210, 57);
            this.button1.TabIndex = 3;
            this.button1.Text = "Erstellen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.bt_Konto_erstellen_ok);
            // 
            // tB_erstellen_konto_pin
            // 
            this.tB_erstellen_konto_pin.Location = new System.Drawing.Point(69, 108);
            this.tB_erstellen_konto_pin.Name = "tB_erstellen_konto_pin";
            this.tB_erstellen_konto_pin.PlaceholderText = "Pin";
            this.tB_erstellen_konto_pin.Size = new System.Drawing.Size(330, 39);
            this.tB_erstellen_konto_pin.TabIndex = 1;
            // 
            // tB_erstellen_konto_UserID
            // 
            this.tB_erstellen_konto_UserID.Location = new System.Drawing.Point(71, 223);
            this.tB_erstellen_konto_UserID.Name = "tB_erstellen_konto_UserID";
            this.tB_erstellen_konto_UserID.PlaceholderText = "User ID";
            this.tB_erstellen_konto_UserID.Size = new System.Drawing.Size(330, 39);
            this.tB_erstellen_konto_UserID.TabIndex = 0;
            // 
            // tB_ueberweisung
            // 
            this.tB_ueberweisung.Location = new System.Drawing.Point(328, 52);
            this.tB_ueberweisung.Name = "tB_ueberweisung";
            this.tB_ueberweisung.PlaceholderText = "KontoNr";
            this.tB_ueberweisung.Size = new System.Drawing.Size(200, 39);
            this.tB_ueberweisung.TabIndex = 8;
            // 
            // bt_ueberweisen
            // 
            this.bt_ueberweisen.Location = new System.Drawing.Point(692, 48);
            this.bt_ueberweisen.Name = "bt_ueberweisen";
            this.bt_ueberweisen.Size = new System.Drawing.Size(150, 46);
            this.bt_ueberweisen.TabIndex = 9;
            this.bt_ueberweisen.Text = "Überweisen";
            this.bt_ueberweisen.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1553, 1101);
            this.Controls.Add(this.pan_kunden_erstellen);
            this.Controls.Add(this.pan_auswahl);
            this.Controls.Add(this.pan_inter);
            this.Controls.Add(this.pan_listbox);
            this.Controls.Add(this.pan_konto_erstellen);
            this.Name = "Form1";
            this.Text = "ATM";
            this.pan_inter.ResumeLayout(false);
            this.pan_inter.PerformLayout();
            this.pan_auswahl.ResumeLayout(false);
            this.pan_administration.ResumeLayout(false);
            this.pan_adm_login.ResumeLayout(false);
            this.pan_adm_login.PerformLayout();
            this.pan_autor.ResumeLayout(false);
            this.pan_autor.PerformLayout();
            this.pan_kunden_erstellen.ResumeLayout(false);
            this.pan_kunden_erstellen.PerformLayout();
            this.pan_listbox.ResumeLayout(false);
            this.pan_konto_erstellen.ResumeLayout(false);
            this.pan_konto_erstellen.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TextBox tb_money;
        private Button bt_kontostand;
        private Button bt_Einzahlen;
        private Button bt_Abheben;
        private Button bt_OK;
        private Panel pan_inter;
        private Label lb_kontostand;
        private Label label2;
        private TextBox tB_pin;
        private Panel pan_autor;
        private TextBox tB_Kontonummer;
        private Button bt_Abmelden;
        private Panel pan_auswahl;
        private Button bt_admin;
        private Button bt_kunde;
        private Panel pan_adm_login;
        private TextBox tB_admin_login;
        private TextBox tB_admin_pass;
        private Button bt_admin_OK;
        private Panel pan_administration;
        private Button bt_ad_abmelden;
        private Button bt_ad_konto_uebersicht;
        private Button bt_ad_konto_loeschen;
        private Button bt_ad_konto_anlegen;
        private Button bt_ad_kunden_uebersicht;
        private Button bt_ad_kunden_loeschen;
        private Button bt_ad_kunden_anlegen;
        private Panel pan_kunden_erstellen;
        private TextBox tB_erstellen_userID;
        private CheckBox cB_iSPremium;
        private TextBox tB_erstellen_passpin;
        private Button bt_user_erstellen;
        private Panel pan_listbox;
        private ListBox listBox1;
        private Button bt_lB_close;
        private Button bt_erstellen_user_exit;
        private Panel pan_konto_erstellen;
        private Button bt_erstellen_konto_exit;
        private Label lb_konto_nr;
        private TextBox tB_erstellen_konto_betrag;
        private Button button1;
        private TextBox tB_erstellen_konto_pin;
        private TextBox tB_erstellen_konto_UserID;
        private Button bt_ueberweisen;
        private TextBox tB_ueberweisung;
    }
}