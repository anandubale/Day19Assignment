using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Day19Assignment
{
    class LastNameRegex
    {
        public static string LASTNAME_REGEX = "^[A-Z]{1}[a-z]{2,}$";

        public bool validateLastName(string lastName)
        {
            return Regex.IsMatch(lastName, LASTNAME_REGEX);
        }
    }
}
