using System;

namespace Day9Practice2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string input = Console.ReadLine();
            Console.WriteLine(input.charCount());
            Console.WriteLine( ExtensionMaker.charCount(input));
        }

    }
}
