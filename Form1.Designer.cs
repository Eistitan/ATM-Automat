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
            this.lb_kontostand = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tB_pin = new System.Windows.Forms.TextBox();
            this.pan_autor = new System.Windows.Forms.Panel();
            this.lb_Kontonummer = new System.Windows.Forms.Label();
            this.tB_Kontonummer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pan_inter.SuspendLayout();
            this.pan_autor.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_money
            // 
            this.tb_money.Location = new System.Drawing.Point(112, 95);
            this.tb_money.Name = "tb_money";
            this.tb_money.Size = new System.Drawing.Size(200, 39);
            this.tb_money.TabIndex = 1;
            // 
            // bt_kontostand
            // 
            this.bt_kontostand.Location = new System.Drawing.Point(103, 323);
            this.bt_kontostand.Name = "bt_kontostand";
            this.bt_kontostand.Size = new System.Drawing.Size(150, 46);
            this.bt_kontostand.TabIndex = 2;
            this.bt_kontostand.Text = "Kontostand";
            this.bt_kontostand.UseVisualStyleBackColor = true;
            this.bt_kontostand.Click += new System.EventHandler(this.bt_kontostand_Click);
            // 
            // bt_Einzahlen
            // 
            this.bt_Einzahlen.Location = new System.Drawing.Point(309, 323);
            this.bt_Einzahlen.Name = "bt_Einzahlen";
            this.bt_Einzahlen.Size = new System.Drawing.Size(150, 46);
            this.bt_Einzahlen.TabIndex = 3;
            this.bt_Einzahlen.Text = "Einzahlen";
            this.bt_Einzahlen.UseVisualStyleBackColor = true;
            this.bt_Einzahlen.Click += new System.EventHandler(this.bt_Einzahlen_Click);
            // 
            // bt_Abheben
            // 
            this.bt_Abheben.Location = new System.Drawing.Point(523, 323);
            this.bt_Abheben.Name = "bt_Abheben";
            this.bt_Abheben.Size = new System.Drawing.Size(150, 46);
            this.bt_Abheben.TabIndex = 4;
            this.bt_Abheben.Text = "Abheben";
            this.bt_Abheben.UseVisualStyleBackColor = true;
            this.bt_Abheben.Click += new System.EventHandler(this.bt_Abheben_Click);
            // 
            // bt_OK
            // 
            this.bt_OK.Location = new System.Drawing.Point(525, 97);
            this.bt_OK.Name = "bt_OK";
            this.bt_OK.Size = new System.Drawing.Size(150, 46);
            this.bt_OK.TabIndex = 5;
            this.bt_OK.Text = "OK";
            this.bt_OK.UseVisualStyleBackColor = true;
            this.bt_OK.Click += new System.EventHandler(this.bt_OK_Click);
            // 
            // pan_inter
            // 
            this.pan_inter.Controls.Add(this.lb_kontostand);
            this.pan_inter.Controls.Add(this.label2);
            this.pan_inter.Controls.Add(this.tb_money);
            this.pan_inter.Controls.Add(this.bt_Abheben);
            this.pan_inter.Controls.Add(this.bt_kontostand);
            this.pan_inter.Controls.Add(this.bt_Einzahlen);
            this.pan_inter.Location = new System.Drawing.Point(129, 89);
            this.pan_inter.Name = "pan_inter";
            this.pan_inter.Size = new System.Drawing.Size(1247, 630);
            this.pan_inter.TabIndex = 6;
            this.pan_inter.Visible = false;
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
            this.label2.Location = new System.Drawing.Point(787, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "Kontostand:";
            // 
            // tB_pin
            // 
            this.tB_pin.Location = new System.Drawing.Point(293, 101);
            this.tB_pin.Name = "tB_pin";
            this.tB_pin.Size = new System.Drawing.Size(200, 39);
            this.tB_pin.TabIndex = 5;
            // 
            // pan_autor
            // 
            this.pan_autor.Controls.Add(this.lb_Kontonummer);
            this.pan_autor.Controls.Add(this.tB_Kontonummer);
            this.pan_autor.Controls.Add(this.label1);
            this.pan_autor.Controls.Add(this.tB_pin);
            this.pan_autor.Controls.Add(this.bt_OK);
            this.pan_autor.Location = new System.Drawing.Point(366, 736);
            this.pan_autor.Name = "pan_autor";
            this.pan_autor.Size = new System.Drawing.Size(737, 183);
            this.pan_autor.TabIndex = 7;
            // 
            // lb_Kontonummer
            // 
            this.lb_Kontonummer.AutoSize = true;
            this.lb_Kontonummer.Location = new System.Drawing.Point(45, 20);
            this.lb_Kontonummer.Name = "lb_Kontonummer";
            this.lb_Kontonummer.Size = new System.Drawing.Size(108, 32);
            this.lb_Kontonummer.TabIndex = 7;
            this.lb_Kontonummer.Text = "KontoNr.";
            // 
            // tB_Kontonummer
            // 
            this.tB_Kontonummer.Location = new System.Drawing.Point(45, 101);
            this.tB_Kontonummer.Name = "tB_Kontonummer";
            this.tB_Kontonummer.Size = new System.Drawing.Size(200, 39);
            this.tB_Kontonummer.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(249, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(474, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "PIN-Code eingeben und mit OK bestätigen";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1553, 951);
            this.Controls.Add(this.pan_autor);
            this.Controls.Add(this.pan_inter);
            this.Name = "Form1";
            this.Text = "ATM";
            this.pan_inter.ResumeLayout(false);
            this.pan_inter.PerformLayout();
            this.pan_autor.ResumeLayout(false);
            this.pan_autor.PerformLayout();
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
        private Label label1;
        private Label lb_Kontonummer;
        private TextBox tB_Kontonummer;
    }
}