using System;
using System.Collections.Generic;
using System.Text;

namespace Day9Practice2
{
    static class ExtensionMaker
    {
        public static int charCount(this string test)
        {
            int counter = 0;
            foreach (var character in test)
            {
                counter++;
            }
            return counter;
        }
    }
}
