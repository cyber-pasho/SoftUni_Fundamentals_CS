using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataTypesAndVariablesExercise
{
    internal class Problem1
    {
        static void Main(string[] args)
        {
            int inputNumCount = 4;
            int[] numbers = new int[inputNumCount];
            for (int i = 0; i < inputNumCount; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            int sum = ((numbers[0]+numbers[1])/numbers[2])*numbers[3];
            Console.WriteLine(sum);

        }
    }
}
