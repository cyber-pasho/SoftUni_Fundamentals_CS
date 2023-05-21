using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basicSyntaxLecture
{
    internal class Problem4
    {
        private static void Main(string[] args)
        {
            int hrs = int.Parse(Console.ReadLine());
            int mins = int.Parse(Console.ReadLine());
            //
            if (mins >= 30)
            {
                hrs += 1;
                mins =(mins + 30)%60;
                if (hrs >=24)
                {
                    hrs %= hrs;
                }
                Console.WriteLine($"{hrs}:{mins:d2}");
            }
            else
            {
                mins += 30;
                Console.WriteLine($"{hrs}:{mins:d2}");
            }
        }
    }
}
