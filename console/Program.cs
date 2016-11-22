using System;
using ClassLibrary;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var c = new Class1();
            var i = c.Method1();

            Console.WriteLine("Output:");

            Console.WriteLine(i);

        }
    }
}
