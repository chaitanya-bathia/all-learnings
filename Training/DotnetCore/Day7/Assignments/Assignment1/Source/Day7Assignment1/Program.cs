using System;
using System.Collections.Generic;
using System.Linq;

namespace Day7Assignment1
{
    class Program
    {
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


            //Get employee with first name = John
            var nameJohn = employees.Where(x => x.FirstName == "John");


            foreach (var item in nameJohn)
            {
                Console.WriteLine(item);
            }

            //Get first name and last name of all employees
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("----------All Employees' First and Last Names:----------");
            Console.WriteLine("---------------------------------------------------------");

            var fullNameGetter = from emp in employees
                                 select new { emp.FirstName, emp.LastName };
            foreach (var employee in fullNameGetter)
            {
                Console.WriteLine($"{employee.FirstName} {employee.LastName}");
            }

            var fullNamebyMethod = employees.Select(emp => $"{ emp.FirstName}  {emp.LastName}");

            Console.WriteLine("-------------------Test Name by Method-------------------------");
            foreach (var item in fullNamebyMethod)
            {
                Console.WriteLine($"{item}");
            }

            //Employee + Incentive details

            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("----------Employee's FirstName and Incentive Amount:----------");
            Console.WriteLine("---------------------------------------------------------");

            var getIncentive = from emp in employees
                               join inc in incentives on emp.ID equals inc.ID
                               select new
                               {
                                   FirstName = emp.FirstName,
                                   incentive = inc.IncentiveAmount
                               };

            foreach (var incDetails in getIncentive)
            {
                Console.WriteLine($"Employee Name:{incDetails.FirstName}\tIncentive Amount: {incDetails.incentive}");
            }

            Console.WriteLine("-------------Incentive by Method-------------");

            var getIncentiveByMethod = employees.Join(incentives,
                                                      emp => emp.ID,
                                                      inc => inc.ID,
                                                      (emp, inc) => new
                                                      {
                                                          Name = emp.FirstName,
                                                          incentive = inc.IncentiveAmount
                                                      });

            foreach (var item in getIncentiveByMethod)
            {
                Console.WriteLine($"Name: {item.Name}\t  Incentive: {item.incentive}");
            }

            //Department Wise maximum salary

            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("------------Department-Wise Maximum Salary:--------------");
            Console.WriteLine("---------------------------------------------------------");

            var deptMaxSalary = from emp in employees
                                group emp by emp.Deparment into deptGroup
                                let maxSalary = deptGroup.Max(x => x.Salary)
                                orderby maxSalary
                                select maxSalary;

            foreach (var coll in deptMaxSalary)
            {
                Console.WriteLine(coll);
            }

            Console.WriteLine("-----------------Department wise salary by method syntax----------------");

            var deptMaxSalMethod = employees.GroupBy(x => x.Deparment)
                                            .Select(emp=>
                                                        new {
                                                                dept=emp.Key,
                                                                maxSal = emp.Max(sal=>sal.Salary)
                                                            }
                                                    ).OrderBy(x=>x.maxSal);

            foreach (var item in deptMaxSalMethod)
            {
                Console.WriteLine($"{item}");
            }

            // Select department, total salary with respect to a department from employees object where total salary greater than 800000 order by TotalSalary descending(group by having)
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("----------Department Wise Salary Total:----------");
            Console.WriteLine("---------------------------------------------------------");
            var totalSalByDept = from emp in employees
                                 group emp by emp.Deparment into deptGroup
                                 let salarySum = deptGroup.Sum(x => x.Salary)
                                 where salarySum > 800000
                                 orderby salarySum descending
                                 select new { deptName= deptGroup.Key, total = salarySum };




            foreach (var item in totalSalByDept)
            {
                Console.WriteLine($"{item.deptName} \t {item.total}");
            }

            //Dept wise total > 800000 by method

            Console.WriteLine("--------------------Dept Wise Sal total over 800000 by method------------------");
            var salTotal = employees.GroupBy(x => x.Deparment).Where(y=>y.Sum(p=>p.Salary)>800000).Select(emp => new { deptName = emp.Key, total = emp.Sum(x => x.Salary) }).OrderByDescending(emp=>emp.total);

            foreach (var item in salTotal)
            {
                Console.WriteLine($"{item.deptName},\t {item.total}");
            }
        }
    }
}
