using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Problem10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            byte y = byte.Parse(Console.ReadLine());
            ulong count = 0;
            double sumToCheck = n*0.50d;
            //
            while (n>=m)
            {
                n -= m;
                if (sumToCheck == n && y != 0)
                {
                    n /= y;
                }
                count++;
            }
            Console.WriteLine(n);
            Console.WriteLine(count);
        }
    }
}
