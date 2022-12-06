using System;
using System.Collections.Generic;
using System.Text;

namespace Day4Assignment1
{
    class AgeChecker
    {
        public int age = 0;

        public void getAge()
        {
            Console.WriteLine("Enter Your age:");
            age = Convert.ToInt32(Console.ReadLine());
        }

        public void testAge(int age)
        {
            if(age<0)
            {
                throw new AgeException("Age Cannot be negative.");
            }
            else
            {
                Console.WriteLine("Your Age is Accepted.");
            }
        }
    }
}
