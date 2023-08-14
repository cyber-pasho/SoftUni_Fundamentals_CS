using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Problem5
{
    internal class Program
    {
        static void Main()
        {
            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();
            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] inputs = input
                    .Split(" : ");
                List<string> students = new List<string>();
                string courseName = inputs[0];
                string studentName = inputs[1];
                if (!courses.ContainsKey(courseName))
                {
                    students.Add(studentName);
                    courses.Add(courseName, students);
                }
                else 
                {
                    foreach (var item in courses)
                    {
                        if (item.Key == courseName)
                        {
                            item.Value.Add(studentName);
                        }
                    }
                }
            }
            foreach (var item in courses)
            {
                Console.WriteLine($"{item.Key}: {item.Value.Count}");
                foreach (var name in item.Value)
                {
                    Console.WriteLine($"-- {name}");
                }
            }
        }
    }
}