using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ReGex_UserRegistration
{
    public class UC1_EnterFirstName
    {
        public string Regex_Pattern = "^[A-Za-z]{3,}$";

        public bool validateFirstName(string FirstName)
        {
            return Regex.IsMatch(FirstName, Regex_Pattern);
        }
    }
}
