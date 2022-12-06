using System;
using System.Collections.Generic;
using System.Text;

namespace Day6Practice1
{
    class Calculator
    {
        int num1 = 0, num2 = 0;

        public static int calculate(int num1, int num2)
        {
            return num1 + num2;
        }

        public static testerDel newDel = calculate;

        public delegate int testerDel(int num1, int num2);
    }
}
