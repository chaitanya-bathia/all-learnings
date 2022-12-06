using System;
using System.Collections.Generic;

namespace Day5Practice1
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Student> studentList = new List<Student>();

            studentList.Add(new Student(1, "Jay", (decimal)98.5));
            studentList.Add(new Student(2, "Deep", (decimal)79.65));
            studentList.Add(new Student(3, "Kajal", (decimal)95));
            studentList.Add(new Student(4, "Meet", (decimal)68));
            studentList.Add(new Student(5, "Yash", (decimal)75.5));

            foreach(Student temp in studentList)
            {
                Console.WriteLine(temp);
            }

            Console.WriteLine("Enter Index of which you want the result:");
            int index = Convert.ToInt32(Console.ReadLine());

            if(studentList.Count < index)
            {
                Console.WriteLine("The Entered index does not exist in the List.");
            }
            else
            {
                Console.WriteLine(studentList[index-1]);
            }

            Console.WriteLine("Hello World!");
        }
    }
}
