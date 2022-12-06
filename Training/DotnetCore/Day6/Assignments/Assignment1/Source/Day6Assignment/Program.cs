using System;

namespace Day6Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int, decimal> areaDelegate = area;
            Console.WriteLine($"Area Delegate: {areaDelegate(20,10)}");
            Console.WriteLine("Hello World!");
        }
        public static decimal area(int length, int breadth)
        {
            return length * breadth;
        }
    }
}
