using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem2
{
    internal class Program
    {
        static void Main()
        {
            int familyCoult = int.Parse(Console.ReadLine());
            Family family = new Family();
            for (int i = 0; i < familyCoult; i++)
            {
                var input = Console.ReadLine()
                    .Split(" ")
                    .ToArray();
                string name = input[0];
                int age = int.Parse(input[1]);
                Person person = new Person(name, age);
                family.AddMember(person);
            }

            Console.WriteLine($"{ family.GetOldestMember().Name} {family.GetOldestMember().Age}");
        }
    }
    public class Family
    {
        public Family()
        {
            People = new List<Person>();
        }

        public void AddMember(Person person)
        {
            People.Add(person);
        }
        public Person GetOldestMember()
        {
            return People.OrderByDescending(p => p.Age).FirstOrDefault();
        }
        public List<Person> People { get; set; } 
    }
    public class Person
    {
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name  { get; set; }
        public int Age { get; set; }
    }
}