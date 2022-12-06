using System;
using System.Collections;
using System.Collections.Generic;

namespace Day5Practice3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Dictionary<string,int> productDictionary = new Dictionary<string, int>();

            productDictionary.Add("Pencil", 10);
            productDictionary.Add("Eraser", 15);
            productDictionary.Add("Pen", 20);
            productDictionary.Add("Sharpener", 5);
            productDictionary.Add("Book", 50);

            foreach(var item in productDictionary)
            {
                Console.WriteLine($"{item.Key}, => \t{item.Value}");
            }

            Console.WriteLine("--------------------------\nEnter a Product name to Search from the Dictionary:");

            string choice = Console.ReadLine();

            if (productDictionary.ContainsKey(choice))
            {
                Console.WriteLine($"{choice} => {productDictionary[choice]}");
            }
            else
            {
                Console.WriteLine("Product Not Found.");
            }
        }
    }
}
