using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ReGex_UserRegistration
{
    public class UC5_EnterPreDefinedPassword
    {
        public string Regex_Pattern = @"[a-z,A-Z,0-9]{8,}$";

        public bool validatePassword(string Password)
        {
            return Regex.IsMatch(Password, Regex_Pattern);
        }
    }
}
