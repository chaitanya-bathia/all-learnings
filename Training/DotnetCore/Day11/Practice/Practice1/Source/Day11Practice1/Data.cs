using Day11Practice1.Models;
using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Protocols;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;

namespace Day11Practice1
{
    class Data
    {
        SqlConnection con;

        public Data()
        {
            string conString = ConfigurationManager.ConnectionStrings["con"].ConnectionString;

            con = new SqlConnection(conString);
        }

        public List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>();
            SqlCommand sqlCommand = new SqlCommand("SELECT BusinessEntityID, JobTitle FROM HumanResources.Employee", con);

            con.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                employees.Add(new Employee() { BusinessEntityID = Convert.ToInt32(sqlDataReader[0].ToString()), JobTitle = sqlDataReader[1].ToString()});
            }

            sqlDataReader.Close();
            con.Close();

            return employees;
        }

        public List<Employee> getEmployeesByContext()
        {
            List<Employee> empList = new List<Employee>();

            using(AdventureWorks2019Context context = new AdventureWorks2019Context())
            {
                empList = context.Employees.Select(a => new Employee { BusinessEntityID = a.BusinessEntityId, JobTitle = a.JobTitle }).ToList();
            }



            return empList;
        } 
    }
}
