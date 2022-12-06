using System;
using System.Collections;
using System.Collections.Generic;

namespace Day5Practice2
{
    class Program
    {
        static void Main(string[] args)
        {

            Stack<int> age = new Stack<int>();
            string choice = "y";
            while (choice=="y")
            {
                Console.WriteLine("Enter a new Age:");
                age.Push(Convert.ToInt32(Console.ReadLine()));

                Console.WriteLine("Do you want to add another? Press Y or N:");
                choice = Console.ReadLine();
                if (choice != "y")
                {
                    break;
                }
            }

            Console.WriteLine("------------------------------------\n The Entered Ages are:");
            foreach(var ageUnit in age)
            {
                Console.WriteLine($"{ageUnit}");
            }

            Console.WriteLine("Hello World!");
        }
    }
}
