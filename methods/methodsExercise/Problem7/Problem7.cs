using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem7
{
    internal class Problem7
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Matrix(num);
        }
        static void Matrix(int num)
        {
            for (int col = 1; col <= num; col++)
            {
                for (int redica = 1; redica <= num; redica++)
                {
                    Console.Write($"{num} ");
                }
                Console.WriteLine();    
            }
        }
    }
}
