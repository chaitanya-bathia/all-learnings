using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Day9Practice1
{
    class AsyncDemo
    {

        public static async Task method1()
        {

            await Task.Run(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    Console.WriteLine($"Method 1 {i}");
                    Task.Delay(100).Wait();
                }
            });
        }

        public static void method2()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine($"Method 2 {i}");
                Task.Delay(100).Wait();
            }
        }
    }
}
