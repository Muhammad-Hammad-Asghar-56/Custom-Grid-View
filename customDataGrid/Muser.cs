using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace customDataGrid
{
    public class Muser
    {
        private string userName;
        private string userPassword;
        private string passwordHint;
        private string userRole;

        public string UserName { get => userName; set => userName = value; }
        public string UserPassword { get => userPassword; set => userPassword = value; }
        public string PasswordHint { get => passwordHint; set => passwordHint = value; }
        public string UserRole { get => userRole; set => userRole = value; }

        //-------------------------------------------------------------------
        public string getUserName() => UserName;
        public string getUserPassword() => UserPassword;
        public string getPasswordHint() => PasswordHint;
        public string getUserRole() => UserRole;
        public string getUserName(string userName) => this.UserName = userName;
        public string getUserPassword(string userPassword) => this.UserPassword = userPassword;
        public string getPasswordHint(string passwordHint) => this.PasswordHint = passwordHint;
        public string getUserRole(string userRole) => this.UserRole = userRole;
        //-------------------------------------------------------------------
        public Muser()
        { }
        public Muser(string userName)
        {
            userName = " ";
            UserPassword = " ";
            UserRole = " ";
            this.UserName = userName;
        }
        public Muser(string userName, string userPassword, string passwordHint, string userRole)
        {
            this.UserName = userName;
            this.UserPassword = userPassword;
            this.PasswordHint = passwordHint;
            this.UserRole = userRole;
        }
        private static bool specialcharacter(string password)
        {
            foreach (char i in password)
            {
                if (i == '~' || i == '!' || i == '$')
                {
                    return true;
                }
            }
            return false;
        }
        private static bool smallcharacter(string password)
        {
            int alphabet;
            foreach (char i in password)
            {
                for (int num = 97; num < 123; num++)
                {
                    alphabet = i;
                    if (alphabet == num)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public static bool passwordvalidation(String Password)
        {
            if (specialcharacter(Password) && smallcharacter(Password))
            {
                return true;
            }
            return false;
        }
    }
}
