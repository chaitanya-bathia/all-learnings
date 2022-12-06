using System;
using System.Collections.Generic;
using System.Text;

namespace Day7Practice
{
    class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return ($"ID:{StudentID}, Name: {StudentName}, Age:{Age}");
        }
    }
}
