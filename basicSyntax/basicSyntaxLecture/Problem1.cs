using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basicSyntaxLecture
{
    internal class Problem1
    {
        private static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            float avarageAge = float.Parse(Console.ReadLine());
            //
            Console.WriteLine($"Name: {name}, Age: {age}, Grade: {avarageAge:f2}");

        }
    }
}
