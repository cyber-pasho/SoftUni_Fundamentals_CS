using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4
{
    internal class Problem4
    {
        static void Main(string[] args)
        {
            var numStart = int.Parse(Console.ReadLine());
            var numEnd = int.Parse(Console.ReadLine());
            var sum = 0;
            //
            for (int i = numStart; i <= numEnd; i++)
            {
                Console.Write($"{i} ");
                sum += i;
            }
            Console.WriteLine();
            Console.WriteLine($"Sum: {sum}");    
        }
    }
}
