using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_Automat
{
    internal class Admin : Person
    {
        string login_name;
        string password;

        public Admin(string login_name, string password)
        {
            this.login_name = login_name;
            this.password = password;
        }

        public static Admin Admin_Erstellen()
        {
            Admin a = new("admin", "padmin");
            return a;
        }
        public bool Check_AD_Login(string check)
        {
            bool isTrue = false;
            if (check == login_name)
                isTrue = true;
            return isTrue;
        }
        public bool Check_AD_Pass(string pass)
        {bool isTrue = false;
            if (pass == password)
                isTrue = true;
            return isTrue;
        }
    }
}
