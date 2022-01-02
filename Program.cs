using System;

namespace Day19Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            AllEmailSamplesRegex pattern9 = new AllEmailSamplesRegex();
            Console.WriteLine(pattern9.ValidateFullEmail("Anand@bl.co.in"));

        }
    }
}
