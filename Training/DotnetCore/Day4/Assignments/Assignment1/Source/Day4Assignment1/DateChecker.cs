using System;
using System.Collections.Generic;
using System.Text;

namespace Day4Assignment1
{
    class DateChecker
    {
        public DateTime date;

        public void getDate()
        {
            int day, month, year;

            Console.WriteLine("Enter Day:");
            day = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Month:");
            month = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Year:");
            year = Convert.ToInt32(Console.ReadLine());

            date = new DateTime(year, month, day);
        }

        public void testDate(DateTime date)
        {
            if (date < DateTime.Today)
            {
                throw new DateException("Date is less than Today. Past dates cannot be accepted.");
            }
            else
            {
                Console.WriteLine("Date is accepted.");
            }
        }
    }
}
