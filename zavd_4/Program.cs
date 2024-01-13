using System.Collections.Generic;
using System;
using Microsoft.VisualBasic;
using System.Linq;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = new List<Person>();
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("1 - add, 2 - sort, 3 - exit");
                int choice = Int32.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Set name: ");
                        string name = Console.ReadLine();
                        Console.WriteLine("Set age");
                        int age = Int32.Parse(Console.ReadLine());
                        people.Add(new Person(name, age));
                        break;
                    case 2:
                        var youngPeople = people.Where(p => p.Age < 30);
                        foreach (var person in youngPeople)
                        {
                            Console.WriteLine(person);
                        }
                        break;
                    case 3:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }
        }
    }
}
