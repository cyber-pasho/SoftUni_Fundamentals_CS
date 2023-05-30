using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem6
{
    internal class Problem6
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine()
                .Split(' ');
            int[] arrayInt = new int[array.Length];
            bool isValid = false;
            for (int i = 0; i < array.Length; i++)
            {
                if (!int.TryParse(array[i], out arrayInt[i]))
                {
                    Console.WriteLine();
                    return;
                }
            }
            if (arrayInt.Length <= 2)
            {
                if (arrayInt.Length == 1 || (arrayInt.Length == 2 && arrayInt[0] == arrayInt[1]))
                {
                    Console.WriteLine("0");
                    return;
                }
                else
                {
                    isValid = false;
                }
            }
            for (int i = 0; i < arrayInt.Length; i++)
            {
                int sumNegative = 0;
                int sumPositive = 0;
                for (int m = 0; m < i; m++)
                {
                    sumNegative += arrayInt[m];
                }
                for (int y = i+1; y < arrayInt.Length; y++)
                {
                    sumPositive += arrayInt[y];
                }
                if (sumNegative == sumPositive)
                {
                    isValid = true;
                    Console.WriteLine(i);
                    break;
                }

            }
            if (!isValid)
            {
                Console.WriteLine("no");
            }
        }
    }
}
