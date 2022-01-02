using System;

namespace Day19Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            EmailRegex pattern3 = new EmailRegex();
            Console.WriteLine(pattern3.validateEmail("abc.xyz@bl.co.in"));
        }
    }
}
