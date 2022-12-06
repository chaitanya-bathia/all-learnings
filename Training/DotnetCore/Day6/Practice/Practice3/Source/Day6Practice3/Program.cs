using System;

namespace Day6Practice3
{
    class Program
    {
        public delegate void calcDelegate(int num1, int num2);
        static void Main(string[] args)
        {
            calcDelegate newDel = add;
            newDel += sub;
            newDel += mul;

            newDel(10, 5);

            Console.WriteLine("Hello World!");
        }

        public static void add(int num1, int num2)
        {
            Console.WriteLine(num1 + num2);
        }

        public static void sub(int num1, int num2)
        {
            Console.WriteLine(num1 - num2);
        }

        public static void mul(int num1, int num2)
        {
            Console.WriteLine(num1 * num2);
        }
    }
}
