using System;
using System.Collections.Generic;
using System.Linq;

namespace Day7Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string[] names = { "Josh", "Neil", "Meredith", "Joseph" };
            var query = from name in names
                        where name.StartsWith("J")
                        select name;


            foreach (var res in query)
            {
                Console.WriteLine(res);
            }

            studentList.Add(new Student() { StudentID = 1, StudentName = "John", Age = 18 });
            studentList.Add(new Student() { StudentID = 2, StudentName = "Steve", Age = 21 });
            studentList.Add(new Student() { StudentID = 3, StudentName = "Bill", Age = 25 });
            studentList.Add(new Student() { StudentID = 4, StudentName = "Ram", Age = 20 });
            studentList.Add(new Student() { StudentID = 5, StudentName = "Ron", Age = 31 });
            studentList.Add(new Student() { StudentID = 6, StudentName = "Chris", Age = 17 });
            studentList.Add(new Student() { StudentID = 7, StudentName = "Rob", Age = 19 });

            var methodSyntax = studentList.Where((x) => x.Age >= 13 && x.Age <= 19).OrderByDescending(x=>x.Age);

            displayResult(methodSyntax);

            var querySyntax = from student in studentList
                              where student.Age >= 13 && student.Age <= 19
                              orderby student.StudentName
                              select student;

            Console.WriteLine("-----------Query Syntax Testing-----------");
            displayResult(querySyntax);

            var addAge = from studenttest in studentList
                         where studenttest.Age >= 13 && studenttest.Age <= 19 && studenttest.StudentName.StartsWith("J")
                         group studenttest by studenttest.Age into ageGroup
                         select ageGroup;

            foreach(var ager in addAge)
            {
                Console.WriteLine($"{ ager.Key}");
                foreach (var item in ager)
                {
                    Console.WriteLine(item);
                }
            }

            //displayResult(addAge);
        }

        public static void displayResult(IEnumerable<Object> testEnumerable)
        {
            foreach (var item in testEnumerable)
            {
                Console.WriteLine(item);
            }
        }

        public static List<Student> studentList = new List<Student>();
    }
}
