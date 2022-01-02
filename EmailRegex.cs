using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Day19Assignment
{
    class EmailRegex
    {
        public static string EMAIL_REGEX = "^[a-z0-9][-a-z0-9._]+@([-a-z0-9]+[.])+[a-z]{2}[.][a-z]{2}$";
        public bool validateEmail(string email)
        {
            return Regex.IsMatch(email, EMAIL_REGEX);
        }
    }
}
