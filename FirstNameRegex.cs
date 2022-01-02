using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Day19Assignment
{
    class FirstNameRegex
    {
        public static string FIRSTNAME_REGEX = "^[A-Z]{1}[a-z]{2,}$";
        public bool validateFirstName(string firstName)
        {
            return Regex.IsMatch(firstName, FIRSTNAME_REGEX);
        }
    }
}
