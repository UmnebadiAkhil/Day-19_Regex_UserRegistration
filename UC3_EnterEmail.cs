using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ReGex_UserRegistration
{
    public class UC3_EnterEmail
    {
        public string Regex_Pattern = "^[a-zA-Z0-9+_.-]+@[a-zA-Z0-9.-]+$";

        public bool validateEmail(string Email)
        {
            return Regex.IsMatch(Email, Regex_Pattern);
        }
    }
}
