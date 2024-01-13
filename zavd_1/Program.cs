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
            List<int> list = new List<int>();
            Console.WriteLine("Enter count numbers: ");
            int count=Int32.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 0;i<count;i++)
            {
                Console.WriteLine("Enter numbers:");
                int num = Int32.Parse(Console.ReadLine());
                list.Add(num);
                Console.WriteLine();
            }

            Console.WriteLine();
            var result = list.Where(x => x % 2 == 0);
            Console.Write("Result: ");
            foreach (var e in result)
            {
                Console.Write(e + " ");
            }
        }
    }
}
