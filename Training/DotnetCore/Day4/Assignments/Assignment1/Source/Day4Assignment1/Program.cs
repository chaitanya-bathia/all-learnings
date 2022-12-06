using System;

namespace Day4Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            NameChecker newName = new NameChecker();

            newName.getName();

            try
            {
                newName.testName(newName.name);
            }
            catch(NameException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("----------------------------------------------------");

            AgeChecker newAge = new AgeChecker();

            newAge.getAge();

            try
            {
                newAge.testAge(newAge.age);
            }
            catch(AgeException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("----------------------------------------------------");

            DateChecker newDateCheck = new DateChecker();

            newDateCheck.getDate();

            try
            {
                newDateCheck.testDate(newDateCheck.date);
            }
            catch(DateException de)
            {
                Console.WriteLine(de.Message);
            }
        }
    }
}
