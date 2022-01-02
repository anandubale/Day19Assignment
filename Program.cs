using System;

namespace Day19Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            FirstNameRegex pattern = new FirstNameRegex();
            Console.WriteLine(pattern.validateFirstName("And"));
        }
    }
}
