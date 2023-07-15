using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Problem3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int studentsCount = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();
            for (int i = 1; i <= studentsCount; i++)
            {
                var studentInput = Console.ReadLine()
                    .Split(' ')
                    .ToArray();
                string firstName = studentInput[0];
                string lastName = studentInput[1];
                double grade = double.Parse(studentInput[2]);
                Student student = new Student(firstName,lastName,grade);
                students.Add(student);
            }
            List<Student> sortedStudents = SortStudentsByGradeDescending(students);
            foreach (var entry in sortedStudents)
            {
                Console.WriteLine($"{entry.FirstName} {entry.LastName}: {entry.Grade:f2}");
            }
        }
        public static List<Student> SortStudentsByGradeDescending(List<Student> students)
        {
            students.Sort((s1, s2) => s2.Grade.CompareTo(s1.Grade));
            return students;
        }
    }

    public class Student
    {
        public Student(string firstName, string lastName, double grade)
        {
            FirstName = firstName;
            LastName = lastName;
            Grade = grade;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }
    }
}
