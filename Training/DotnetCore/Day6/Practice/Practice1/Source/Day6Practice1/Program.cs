using System;

namespace Day6Practice1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            testDel newDel = Calculator.calculate;

            Console.WriteLine(newDel(15, 20));

            displayDel inst = display;

            inst();



            Console.WriteLine(Calculator.newDel(10, 20));
        }
        

        public static void display()
        {
            Console.WriteLine("This is delegate Demo");
        }
    }
        public delegate int testDel(int num1, int num2);
        public delegate void displayDel();
}
