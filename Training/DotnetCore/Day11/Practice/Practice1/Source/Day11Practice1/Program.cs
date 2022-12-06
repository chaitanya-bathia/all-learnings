using System;
using System.Collections.Generic;

namespace Day11Practice1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Data d = new Data();
            List<Employee> list = d.GetEmployees();

            foreach (var item in list)
            {
                Console.WriteLine(item.JobTitle);
            }

            List<Employee> listContext = d.getEmployeesByContext();
            Console.WriteLine("ByContext");
            foreach (var item in listContext)
            {
                Console.WriteLine(item.JobTitle);
            }
        }
    }
}