using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Problem7
{
    internal class Problem7
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            int liters = 0;
            //
            for (int i = 1; i <= num; i++)
            {
                liters = int.Parse(Console.ReadLine());
                sum += liters;
                if (sum > 255)
                {
                    Console.WriteLine("Insufficient capacity!");
                    sum -= liters; 
                }
            }
            Console.WriteLine(sum);
        }
    }
}
