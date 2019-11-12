using System;
using System.IO;
using System.Linq;
using System.Reflection;

namespace CreateRandomName
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int number = random.Next(0, 21986);
            int number2 = random.Next(0, 21986);

            string firstName = File.ReadLines("names.txt").Skip(number-1).Take(1).First();
            string lastName = File.ReadLines("names.txt").Skip(number2 - 1).Take(1).First();
            string line = firstName + " " + lastName;
            Console.WriteLine(line);

            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            System.Console.ReadKey();
        }
    }
}
