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
            int multi = int.Parse(Console.ReadLine());
            int result = num*multi;
            Console.WriteLine($"{num} X {multi} = {result}");

            //
            for (int i = multi+1; i <= 10; i++)
            {
                result = num * i;
                Console.WriteLine($"{num} X {i} = {result}");

            }
        }
    }
}
