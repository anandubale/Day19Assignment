using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Day19Assignment
{
    public class PasswordRegexRule1
    {
        public static string PASS_REGEX_RULE1 = "^[A-Z a-z]{8,}$";

        public bool ValidatePasswordRule1(string password)
        {
            return Regex.IsMatch(password, PASS_REGEX_RULE1);
        }
    }
}
