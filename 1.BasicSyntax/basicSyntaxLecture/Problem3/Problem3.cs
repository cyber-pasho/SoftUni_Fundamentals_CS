using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basicSyntaxLecture
{
    internal class Problem3
    {
        private static void Main(string[] args)
        {
            float grade = float.Parse(Console.ReadLine());
            //
            if (grade >= 3.00)
            {
                Console.WriteLine($"Passed!");
            }
            else
            {
                Console.WriteLine($"Failed!");
            }
        }
    }
}
