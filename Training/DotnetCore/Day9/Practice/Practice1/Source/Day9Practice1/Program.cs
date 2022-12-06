using System;
using System.Threading.Tasks;

namespace Day9Practice1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            AsyncDemo ad = new AsyncDemo();

            AsyncDemo.method1();
            AsyncDemo.method2();
        }
    }
}
