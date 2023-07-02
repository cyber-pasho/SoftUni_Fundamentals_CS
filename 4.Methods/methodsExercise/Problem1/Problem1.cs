using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodsExercise
{
    internal class Problem1
    {
        static void Main()
        {
            PrintSmallest();
        }
        static void PrintSmallest()
        {
            int smallest = int.MaxValue;
            for (int i = 1; i <= 3; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num < smallest)
                {
                    smallest = num;
                }
                else
                {
                    continue;
                }

            }
            Console.WriteLine(smallest);
        }
    }
}
  