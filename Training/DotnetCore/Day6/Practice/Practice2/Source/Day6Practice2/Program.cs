using System;

namespace Day6Practice2
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Func<string, string> testFuncDel = display;
            Console.WriteLine(testFuncDel("Hello There. Demo of Func Delegate"));

            Console.WriteLine("--------------------------------------------------------");
            Func<int, int, int> anonymousTest = delegate (int x, int y)
            {
                return x + y;
            };
            Console.WriteLine($"Anonymous Delegate: {anonymousTest(10, 20)}");

            Console.WriteLine("--------------------------------------------------------");

            Func<int,int,int> lambdaTest = (int x, int y) => { return x*y; };
            Console.WriteLine($"Lambda Function Multiplication Test: {lambdaTest(10,20)}");
        }

        

        public static string display(string msg)
        {
            return msg.ToUpper();
        }
    }
}
