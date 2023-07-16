using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem7
{
    internal class Program
    {
        static void Main()
        {
            List<Person> people = new List<Person>();
            string input;
            string name;
            string iD;
            int age;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] statement = input.Split(' ');
                name = statement[0];
                age = int.Parse(statement[2]);
                iD = statement[1];
                bool personExists = people.Any(person => person.ID == iD);
                if (personExists)
                {
                    people = people
                        .Select(p =>
                        {
                            if (p.ID == iD)
                            {
                                p.Name = name;
                                p.Age = age;
                            }
                            return p;
                        })
                        .ToList();
                    continue;
                }
                people.Add(new Person(name, iD, age));

            }
            people = people.OrderBy(p => p.Age)
                .ToList();
            foreach (var person in people)
            {
                Console.WriteLine(person);
            }
        }
    }
    public class Person
    {
        public Person(string name, string iD, int age)
        {
            Name = name;
            ID = iD;
            Age = age;
        }
        public override string ToString()
        {
            return $"{Name} with ID: {ID} is {Age} years old.";
        }

        public string Name { get; set; }
        public string ID { get; set; }
        public int Age { get; set; }
    }
}
