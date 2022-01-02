using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Day19Assignment
{
    public class AllEmailSamplesRegex
    {
        public static string ALL_EMAIL_SAMPLES_REGEX = @"^[0-9A-Za-z]+([._+-][0-9A-Za-z]+)*[@][0-9A-Za-z]+.[a-zA-Z]{2,3}(.[a-zA-Z]{2,3})?$";

        public bool ValidateFullEmail(string email)
        {
            return Regex.IsMatch(email, ALL_EMAIL_SAMPLES_REGEX);
        }
    }
}
