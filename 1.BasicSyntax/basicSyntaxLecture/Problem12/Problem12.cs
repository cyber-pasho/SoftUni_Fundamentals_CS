using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem12
{
    internal class Problem12
    {
        static void Main(string[] args)
        {
            int num = Math.Abs(int.Parse(Console.ReadLine()));
            //
            while (num % 2 != 0)
            {
                Console.WriteLine($"Please write an even number.");
                num = Math.Abs(int.Parse(Console.ReadLine()));
            }
            Console.WriteLine($"The number is: {num}");

        }
    }
}
