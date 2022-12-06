using System;
using System.IO;

namespace FileHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            using (FileStream f = new FileStream(@"D:\testfile.txt", FileMode.Append,FileAccess.Write))
            {
                Console.WriteLine("Enter Your Name:");
                string name = Console.ReadLine();

                using(StreamWriter sw = new StreamWriter(f))
                {
                    sw.WriteLine($"Your name is: {name}");
                    Console.WriteLine("Name has been Written in the file.");
                }
            }

            DirectoryInfo directoryInfo = new DirectoryInfo(@"D:\demo");
            directoryInfo.Create();
            foreach (var item in directoryInfo.GetFiles())
            {
                Console.WriteLine(item.FullName);
            }

            try
            {
                directoryInfo.CreateSubdirectory("TestDir");
                directoryInfo.CreateSubdirectory(@"TestDir\Test");
                Console.WriteLine("sub-directory Created.");
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
