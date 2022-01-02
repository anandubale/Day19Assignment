using System;

namespace Day19Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            MobileNumberRegex pattern4 = new MobileNumberRegex();
            Console.WriteLine(pattern4.ValidateMobileNo("91 9999999999"));
        }
    }
}
