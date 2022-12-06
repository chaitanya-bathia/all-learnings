using System;

namespace DemoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 42;
            int b = 119;
            int c = a + b;
            Console.WriteLine(c);
            Console.ReadKey();

            

            String newSTR = "aasdf";
            Console.WriteLine(newSTR.Contains("jhj"));
            Console.WriteLine(newSTR.Replace("asd","bcd"));
            Console.WriteLine(newSTR.Substring(2,2));

            String trySplit = "This is a demo String,Trying Split from comma,Showing result.";
            String[] results = trySplit.Split(',');

            for (int j = 0; j < results.Length; j++)
            {
                Console.WriteLine(results[j]);
            }


            int[] newArray = new int[5];

            for(int i = 0; i < newArray.Length; i++)
            {
                newArray[i] = i + 1;
            }

            for (int i = 0; i < newArray.Length; i++)
            {
                Console.WriteLine(newArray[i]);
            }

            
            float num1 = 0, num2 = 0;

            Console.WriteLine("Calculator in a Console App for C#!\r");
            Console.WriteLine("------------------------------------\n");

            Console.WriteLine("Enter a number and press Enter");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter another number and press Enter");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a Choice:");
            Console.WriteLine("\ta - for Addition");
            Console.WriteLine("\ts - for Subtraction");
            Console.WriteLine("\tm - for Multiplication");
            Console.WriteLine("\td - for Division");

            Console.Write("Your Choice?: ");
            
            switch(Console.ReadLine())
            {
                case "a":
                    Console.WriteLine($"Addition Result is: {num1+num2}");
                    break;

                case "s":
                    Console.WriteLine($"Subtraction Result is: {num1 - num2}");
                    break;

                case "m":
                    Console.WriteLine($"Multiplication Result is: {num1 * num2}");
                    break;

                case "d":
                    while (num2 == 0)
                    {
                        Console.WriteLine("Enter a non-zero divisor: ");
                        num2 = Convert.ToInt32(Console.ReadLine());
                    }
                    Console.WriteLine($"Division Result is: {num1 / num2}");
                    break;

                default:
                    Console.WriteLine("Invalid Input.");
                    break;
            }

            Console.Write("Press any key to close the Calculator console app...");
            Console.ReadKey();

        }
    }
}
