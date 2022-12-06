using System;
using System.Collections.Generic;
using System.Text;

namespace Day5Practice1
{
    class Student
    {
        public int ID;
        public string Name;
        public decimal Percentage;

        public Student(int id, string name, decimal percentage)
        {
            ID = id;
            Name = name;
            Percentage = percentage;
        }

        public override string ToString()
        {
            return ($"{ID},\t {Name},\t {Percentage}");
        }
    }
}
