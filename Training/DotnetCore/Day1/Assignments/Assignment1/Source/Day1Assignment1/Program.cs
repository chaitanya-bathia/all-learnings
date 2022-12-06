using System;

namespace Day1Assignment1
{
    class Program
    {
        //Declaring Days enum
        enum Days
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }
        static void Main(string[] args)
        {
            //Taking Max number from user to
            Console.WriteLine("Enter max Int to compute sum of even numbers:");
            int maxNum = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for(int i = 0;i<= maxNum;i++)
            {
                if(i%2==0)
                {
                    sum += i;
                }
            }
            Console.WriteLine($"Sum of Even Numbers upto {maxNum} = {sum}");

            //Getting number of vowels in name
            Console.WriteLine("Enter your Name:");
            String username = Console.ReadLine();
            int vowelCounter = 0;
            for(int j = 0; j < username.Length; j++)
            {
                if(username[j]=='a'|| username[j] == 'A' || username[j] == 'e' || username[j] == 'E' || username[j] == 'i' || username[j] == 'I' || username[j] == 'o' || username[j] == 'O' || username[j] == 'u' || username[j] == 'U')
                {
                    vowelCounter++;
                }
            }
            Console.WriteLine($"Number of vowels in your name are: {vowelCounter}");


            //Getting Week day from number using enum
            Console.WriteLine("Enter Weekday Number:");
            int day = Convert.ToInt32(Console.ReadLine());
            Days dayName = (Days)day;
            Console.WriteLine(dayName);
            Console.WriteLine("-----------------------------------------");


            //Student Report generation
            Console.WriteLine("****** StudentReports *****");

            Console.WriteLine("Enter number of students you want to have:");
            int studentCount = Convert.ToInt32(Console.ReadLine());

            Student[] studentArray = new Student[studentCount];

            for(int x = 0; x<studentArray.Length;x++)
            {
                Console.WriteLine($"***** Student {x+1}'s Details. *****");
                Student tempStudent = new Student();

                Console.WriteLine($"Enter Student {x + 1}'s Name: ");
                tempStudent.name = Console.ReadLine();

                Console.WriteLine($"Enter Student {x + 1}'s Address: ");
                tempStudent.address = Console.ReadLine();

                Console.WriteLine($"Enter Student {x + 1}'s English Marks: ");
                tempStudent.english = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"Enter Student {x + 1}'s Hindi Marks: ");
                tempStudent.hindi = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"Enter Student {x + 1}'s Math Marks: ");
                tempStudent.math = Convert.ToInt32(Console.ReadLine());


                studentArray[x] = tempStudent;
                Console.WriteLine($"Student {studentArray[x].name}'s Grade is {studentArray[x].grade}");
            }


            Console.WriteLine("~~~~~~~ REPORT CARD ~~~~~~~");
            Console.WriteLine("Name|Address|Eng|Hindi|Math|Grade");
            Console.WriteLine("----------------------------------");
            for(int t=0;t<studentArray.Length;t++)
            {
                Console.WriteLine($"{studentArray[t].name} | {studentArray[t].address}|{studentArray[t].english}|{studentArray[t].hindi}|{studentArray[t].math}|{studentArray[t].grade}");
            }

            Console.WriteLine("~~~~~~~ REPORT CARD END ~~~~~~~");
            Console.WriteLine("----------------------------------");


            //Voting Age check with Ternary operator
            Console.WriteLine("Enter Your Age:");
            int age = Convert.ToInt32(Console.ReadLine());
            string eligibility = age > 18 ? "You are Eligible to vote" : "You are not Eligible to vote";

            Console.WriteLine(eligibility);
        }

    }

    
}
