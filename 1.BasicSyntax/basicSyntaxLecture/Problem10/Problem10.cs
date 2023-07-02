using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem10
{
    internal class Problem10
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int result = 0;
            //
            for (int i = 1; i <= 10; i++)
            {
                result = num * i;
                Console.WriteLine($"{num} X {i} = {result}");

            }
        }
    }
}
