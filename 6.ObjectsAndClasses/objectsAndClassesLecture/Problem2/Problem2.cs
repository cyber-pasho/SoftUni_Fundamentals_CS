using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    internal class Problem2
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            BigInteger factorel = num;

            for (int i = num-1; i > 0; i--)
            {
                factorel *= i;
            }
            Console.WriteLine($"{factorel}");
        }
    }
}
