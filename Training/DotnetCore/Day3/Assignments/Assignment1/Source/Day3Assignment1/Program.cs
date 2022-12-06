using System;

namespace Day3Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("Part Time Employee Details: \n -----------------------------------------------");
            PartTime partTimeEmployee = new PartTime();
            partTimeEmployee.Get();
            partTimeEmployee.Display();

            Console.WriteLine("Full Time Employee Details: \n -----------------------------------------------");
            FullTime fullTimeEmployee = new FullTime();
            fullTimeEmployee.Get();
            fullTimeEmployee.Display();
        }
    }
}
