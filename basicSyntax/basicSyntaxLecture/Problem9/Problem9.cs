using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem9
{
    internal class Problem9
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            int counter = 0;
            //
            for (int i = 1; i <= 100; i++)
            {
                if (i%2==1)
                {
                    sum += i;
                    Console.WriteLine($"{i}");
                    counter++;
                    if (counter == num)
                    {
                        Console.WriteLine($"Sum: {sum}");
                        break;
                    }
                }
            }
        }
    }
}
