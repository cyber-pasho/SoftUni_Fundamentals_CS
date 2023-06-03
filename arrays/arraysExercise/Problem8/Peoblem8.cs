using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem8
{
    internal class Peoblem8
    {
        static int[] StringToIntArray()
        {
            string[] input = Console.ReadLine()
                .Split(' ');
            int []arrayInt = new int[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                arrayInt[i] = int.Parse(input[i]);
            }
            return arrayInt;
        }
        static void Main()
        {
            int[] arrayInt = StringToIntArray();
            int num = int.Parse(Console.ReadLine());
            //
            for (int i = 0; i < arrayInt.Length; i++)
            {
                for (int x = i; x < arrayInt.Length; x++)
                {
                    if (arrayInt[i] + arrayInt[x] == num)
                    {
                        if (i == x)
                        {
                            continue;
                        }
                        else
                        {
                            int[] newArray = { arrayInt[i],arrayInt[x]};
                            for (int m = 0; m < newArray.Length; m++)
                            {
                                Console.Write($"{newArray[m]} ");
                            }
                            Console.WriteLine();
                        }
                    }
                }
            }
        }
    }
}
