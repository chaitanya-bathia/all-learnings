using System;
using System.Collections.Generic;

namespace RamboRentalProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            List<Mobike> list = new List<Mobike>();


            int choice;

            bool closeApp = false;
            
            while (closeApp == false)
            {
                Console.WriteLine("-----------------------------------------------------------------------------------------------");
                Console.WriteLine("Press 1 to Enter New Bike Details. \nPress 2 to show All details\nPress 3 to Delete a record\nPress 4 to Edit existing record.\nPress 5 to Search over list\nPress 6 to Exit\n Enter your choice:");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        {
                            Mobike temp = new Mobike();
                            temp.Input();
                            list.Add(temp);
                            break;
                        }
                    case 2:
                        {
                            foreach(var item in list)
                            {
                                item.display();
                            }
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Enter the index you want to delete");
                            int index = Convert.ToInt32(Console.ReadLine());
                            try
                            {
                                list.RemoveAt(index);
                                Console.WriteLine("Data Deleted.");
                            }
                            catch(Exception e)
                            {
                                Console.WriteLine("This Index does not have any data. Either enter some data upto this index, or try to delete data at some other index....");
                            }
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Enter index of data you want to modify:");
                            int index = Convert.ToInt32(Console.ReadLine());

                            Mobike temp = list[index];
                            while (true)
                            {
                                Console.WriteLine("What Do You want to modify?\n" +
                                    "Press 1. For Bike Number\n" +
                                    "Press 2. For Name\n" +
                                    "Press 3. For Phone Number\n" +
                                    "Press 4. For Days\n");
                                int editChoice = Convert.ToInt32(Console.ReadLine());
                                switch (editChoice)
                                {
                                    case 1:
                                        {
                                            Console.WriteLine("Enter new Bike Number:");
                                            temp.bikeNumber = Console.ReadLine();
                                            break;
                                        }
                                    case 2:
                                        {
                                            Console.WriteLine("Enter new Name:");
                                            temp.name = Console.ReadLine();
                                            break;
                                        }
                                    case 3:
                                        {
                                            Console.WriteLine("Enter new Phone Number:");
                                            temp.phoneNumber = Console.ReadLine();
                                            break;
                                        }
                                    case 4:
                                        {
                                            Console.WriteLine("Enter days:");
                                            temp.days = Convert.ToInt32(Console.ReadLine());
                                            break;
                                        }
                                    default:
                                        {
                                            break;
                                        }
                                }
                                Console.WriteLine("Press y to continue:");
                                string cont = Console.ReadLine();
                                if( cont != "y")
                                {
                                    break;
                                }
                            }
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("Enter Bike number you want to search for:");
                            string bikeNumber = Console.ReadLine();
                            foreach(var item in list)
                            {
                                if(item.bikeNumber == bikeNumber)
                                {
                                    item.display();
                                }
                            }
                            break;
                        }
                    case 6:
                        {
                            closeApp = true;
                            foreach (var item in list)
                            {
                                item.display();
                            }

                            Console.WriteLine("App Ended.");
                            break;
                        }
                    default:
                        {
                            break;
                        }
                }
            }
        }
    }
}
