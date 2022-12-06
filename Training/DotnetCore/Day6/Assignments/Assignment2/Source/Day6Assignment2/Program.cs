using System;

namespace Day6Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Func<int, int, int> adderDelegate = (int num1, int num2) => { return num1 + num2; };
            Console.WriteLine($"Adder Delegate with Lambda Function: {adderDelegate(15,10)}");
        }
    }
}
