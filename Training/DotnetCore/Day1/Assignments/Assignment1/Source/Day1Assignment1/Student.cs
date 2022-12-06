using System;
using System.Collections.Generic;
using System.Text;

namespace Day1Assignment1
{
    class Student
    {
        
        public string name { get; set; }
        
        public string address { get; set; }
        
        public int english { get; set; }
        
        public int hindi { get; set; }
        
        public int math { get; set; }
        
        private int total { get { return english + math + hindi; } }

        public char grade { get { return ComputeGrade(total); } }

        private char ComputeGrade(int total)
        {
            var avg = total / 3.0F;
            char grade;
            if(avg >= 90)
            {
                grade = 'A';
            }
            else if(avg>= 75 && avg<90)
            {
                grade = 'B';
            }
            else if(avg >= 60 && avg<75)
            {
                grade = 'C';
            }
            else if(avg >= 40 && avg<60)
            {
                grade = 'D';
            }
            else
            {
                grade = 'F';
            }
            return grade;
        }
    }
}
