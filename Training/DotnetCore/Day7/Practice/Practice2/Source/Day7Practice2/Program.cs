using System;
using System.Collections.Generic;
using System.Linq;

namespace Day7Practice2
{
    class Program
    {
        public static void display(IEnumerable<Object> collection)
        {
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            List<Employee> employees = new List<Employee>()
            { new Employee() { ID = 1, FirstName ="John", LastName ="Abraham", Salary = 1000000, JoiningDate = new DateTime(2013, 1, 1), Deparment ="Banking"},
                new Employee() { ID = 2, FirstName ="Michael", LastName ="Clarke", Salary = 800000, JoiningDate = new DateTime(), Deparment ="Insurance" },
                new Employee() { ID = 3, FirstName ="oy", LastName ="Thomas", Salary = 700000, JoiningDate = new DateTime(), Deparment ="Insurance"},
                new Employee() { ID = 4, FirstName ="Tom", LastName ="Jose", Salary = 600000, JoiningDate = new DateTime(), Deparment ="Banking"},
                new Employee() { ID = 4, FirstName ="TestName2", LastName ="Lname %", Salary = 600000, JoiningDate = new DateTime(2013, 1, 1), Deparment ="Services"}
            };

            List<Incentive> incentives = new List<Incentive>()
            { new Incentive() { ID = 1, IncentiveAmount = 5000, IncentiveDate = new DateTime(2013, 02, 02) },
                new Incentive() { ID = 2, IncentiveAmount = 10000, IncentiveDate = new DateTime(2013, 02, 4) },
                new Incentive() { ID = 1, IncentiveAmount = 6000, IncentiveDate = new DateTime(2012, 01, 5) },
                new Incentive() { ID = 2, IncentiveAmount = 3000, IncentiveDate = new DateTime(2012, 01, 5) }
            };

            //Group Join

            var groupJoinDemo = employees.GroupJoin(incentives,
                                                    emp => emp.ID,
                                                    inc => inc.ID,
                                                    (emp,empGroup) => new
                                                    {
                                                        em = empGroup,
                                                        Name = emp
                                                    });

            //foreach (var item in groupJoinDemo)
            //{
            //    Console.WriteLine(item.Name);
            //    foreach (var i in item.em)
            //    {
            //        Console.WriteLine(i.IncentiveAmount);
            //    }
            //}


            List<Object> multiTypeList = new List<Object>();

            multiTypeList.Add(6);
            multiTypeList.Add("Name");
            multiTypeList.Add(true);

            var getType = multiTypeList.Select(x => x.GetType());

            display(getType);


            var orderEmployees = employees.OrderBy(x => x.FirstName).ThenBy(y => y.Salary).Select(x=>$"{x.FirstName} {x.LastName}");

            display(orderEmployees);


            Console.WriteLine("---------------------------------------------------------------");

            var allEmployees = employees.All(x=>x.Salary < 1000);

            Console.WriteLine(allEmployees);


            Console.WriteLine("---------------------------------------------------------------");

            var anyEmployees = employees.Any(x => x.Salary > 500000);

            Console.WriteLine(anyEmployees);

            Console.WriteLine("---------------------------------------------------------------");

            var deptGroups = employees.GroupBy(x => x.Deparment);

            foreach (var dept in deptGroups)
            {
                foreach (var item in dept)
                {
                    Console.WriteLine(item.FirstName);
                }
            }

            Console.WriteLine("---------------------------------------------------------------");

            var avgSalary = employees.GroupBy(emp=>emp.Deparment).Select(x=> new{dept = x.Key , avg =x.Average(emp => emp.Salary)});

            foreach (var avg in avgSalary)
            {
                Console.WriteLine($"{avg.dept}, {avg.avg}") ;
            }

            var countDeptWiseEmps = employees.GroupBy(dep => dep.Deparment).Select(emp=>new { dept = emp.Key, count = emp.Count() });

            foreach (var item in countDeptWiseEmps)
            {
                Console.WriteLine(item);
            }


        }
    }
}
