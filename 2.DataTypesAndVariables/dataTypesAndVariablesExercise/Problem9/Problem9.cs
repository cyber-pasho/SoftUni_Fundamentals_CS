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
            while (num >= 100)
            {
                sum += (num-26);
                num -= 10;
                counter++;
                if (num < 100)
                {
                    sum -= 26;
                    break;
                }
            }
            Console.WriteLine(counter);
            Console.WriteLine(sum);
        }
    }
}
