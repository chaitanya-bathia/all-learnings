using System;

namespace Day2Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Person[] personArray = new Person[5];

            for(int i = 0; i < personArray.Length; i++)
            {
                string fname = "", lname = "", email = "";
                int day = 0,month=0,year=0 ;
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine($"Taking Input for User {i + 1}");
                Console.WriteLine("Enter First Name:");
                fname = Console.ReadLine();
                Console.WriteLine("Enter Last Name:");
                lname = Console.ReadLine();
                Console.WriteLine("Enter Email:");
                email = Console.ReadLine();
                Console.WriteLine("Enter Year of Birth:");
                year = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Month of Birth:");
                month = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Date of Birth:");
                day = Convert.ToInt32(Console.ReadLine());


                Person demoPerson = new Person(fname, lname, email, new DateTime(year, month, day));
                personArray[i] = demoPerson;
            }

            for(int i = 0; i < personArray.Length; i++)
            {
                Console.WriteLine("----------------------------------------");
                Console.WriteLine($"Displaying Data of Person{i+1}");
                Console.WriteLine(personArray[i].FirstName);
                Console.WriteLine(personArray[i].LastName);
                Console.WriteLine(personArray[i].EmailAddress);
                Console.WriteLine(personArray[i].DateOfBirth);
                Console.WriteLine(personArray[i].Adult);
                Console.WriteLine(personArray[i].Birthday);
                Console.WriteLine(personArray[i].ZodiacSign);
                Console.WriteLine(personArray[i].ChineseZodiac);
                Console.WriteLine(personArray[i].Username);
            }
        }
    }
}
