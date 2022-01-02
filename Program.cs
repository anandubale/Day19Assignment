using System;

namespace Day19Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            PasswordRegexRule1 pattern5 = new PasswordRegexRule1();
            Console.WriteLine(pattern5.ValidatePasswordRule1("AnandUbale"));
        }
    }
}
