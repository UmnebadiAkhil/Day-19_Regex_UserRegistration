using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ReGex_UserRegistration
{
    public class UC9_CheckDifferentEmail
    {
        public string Regex_Pattern = "^[a-zA-Z0-9+_.-]+@[a-zA-Z0-9.-]+$";

        public bool validatePassword(string Password)
        {
            return Regex.IsMatch(Password, Regex_Pattern);
        }
    }
}
