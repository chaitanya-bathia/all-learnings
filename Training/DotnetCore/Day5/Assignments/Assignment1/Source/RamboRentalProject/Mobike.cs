using System;
using System.Collections.Generic;
using System.Text;

namespace RamboRentalProject
{
    class Mobike
    {
        public string bikeNumber;
        public string phoneNumber;
        public string name;
        public int days;

        public void Input()
        {
            Console.WriteLine("Enter Bike Number:");
            bikeNumber = Console.ReadLine();

            Console.WriteLine("Enter Name:");
            name = Console.ReadLine();

            Console.WriteLine("Enter Phone Number:");
            phoneNumber = Console.ReadLine();

            Console.WriteLine("Enter number of Days:");
            days = Convert.ToInt32(Console.ReadLine());

        }

        public decimal compute(int days)
        {
            decimal rent = 0;

            if (days <= 5)
            {
                rent = days * 500;
            }
            else if(days>5 && days <=10)
            {
                rent = 2500 + (days - 5) * 400;
            }
            else
            {
                rent = 4500 + (days - 10) * 200;
            }

            return rent;
        }

        public void display()
        {
            Console.WriteLine("-----------------------------------------------------------------------------------------------");
            Console.WriteLine($"BikeNumber: {bikeNumber}, Phone Number: {phoneNumber}, Name: {name}, Days: {days}, Rent: {compute(days)}");
            Console.WriteLine("-----------------------------------------------------------------------------------------------");
        }
    }
}
