using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basicSyntaxExercise
{
    internal class Problem8
    {
        static void Main(string[] args)
        {
            long a = long.Parse(Console.ReadLine());
            long b = long.Parse(Console.ReadLine());
            double result = (double)FactorelA(a) / FactorelA(b);
            Console.WriteLine($"{result:f2}");
        }
        static long FactorelA(long a)
        {
            long factorelA = a;
            if (factorelA == 0) 
            {
                factorelA = 1;
            }
            for (int i = (int)factorelA - 1; i >= 1; i--)
            {
                if (i == 0)
                {
                    i = 1;
                }
                factorelA *= i;
            }
            return factorelA;
        }
       
    }
}