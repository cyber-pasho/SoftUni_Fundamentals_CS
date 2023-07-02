using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace arraysExercise
{
    internal class Problem1
    {
        static void Main(string[] args)
        {
            int numWagons = int.Parse(Console.ReadLine());
            int[] passangers = new int[numWagons];
            int sum = 0;
            for (int i = 0; i < numWagons; i++)
            {
                passangers[i] = int.Parse(Console.ReadLine());
                sum += passangers[i];
            }
            foreach (int number in passangers)
            {
                Console.Write($"{number} ");
            }
            Console.WriteLine();
            Console.WriteLine(sum);
        }
    }
}
