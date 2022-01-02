using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Day19Assignment
{
    public class MobileNumberRegex
    {
        public static string MOB_NUM_REGEX = "^[0-9]{1,3}\\s{1}[6789]{1}[0-9]{9}$";

        public bool ValidateMobileNo(string MobileNo)
        {
            return Regex.IsMatch(MobileNo, MOB_NUM_REGEX);
        }
    }
}
