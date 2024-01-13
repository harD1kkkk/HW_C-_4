using System.Collections.Generic;
using System;
using Microsoft.VisualBasic;
using System.Linq;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            Console.WriteLine("Enter count strings: ");
            int count = Int32.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Enter string: ");
                string str = Console.ReadLine();
                list.Add(str);
                Console.WriteLine();
            }
            Console.WriteLine();
            var result = list.OrderDescending().First();
            Console.WriteLine("Result: " + result + " ");
        }
    }
}