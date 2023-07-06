using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Problem4
{
    internal class Problem4
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(' ')
                .ToList();
            List<Student> students = new List<Student>();
            //
            while (input[0] != "end")
            {
                string firstName = input[0];
                string lastName = input[1];
                int age = int.Parse(input[2]);
                string homeTown = input[3];
                var student = new Student(firstName, lastName, age, homeTown);
                students.Add(student);
                input = Console.ReadLine()
                .Split(' ')
                .ToList();
            }
            var input2 = Console.ReadLine();
            foreach (var person in students)
            {
                if (person.HomeTown == input2)
                {
                    Console.WriteLine($"{person.FirstName} {person.LastName} is {person.Age} years old.");
                }
            }
            
        }
    }
    public class Student
    {
        public Student(string firstName, string lastName, int age, string homeTown)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            HomeTown = homeTown;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string HomeTown { get; set; }

    }
}
