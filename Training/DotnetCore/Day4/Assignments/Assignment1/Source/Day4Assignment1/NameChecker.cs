using System;
using System.Collections.Generic;
using System.Text;

namespace Day4Assignment1
{
    class NameChecker
    {
        public string name = "";

        public void getName()
        {
            Console.WriteLine("Enter Your Name:");
            name = Console.ReadLine();
        }

        public void testName(string name)
        {
            if (name.Length > 1)
            {
                throw new NameException("Name cannot be longer than 1 character.");
            }
            else
            {
                Console.WriteLine($"{name} is Valid.");
            }
        }
    }
}
