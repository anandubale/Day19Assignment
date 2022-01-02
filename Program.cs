using System;

namespace Day19Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            LastNameRegex pattern2 = new LastNameRegex();
            Console.WriteLine(pattern2.validateLastName("Ubale"));
        }
    }
}
