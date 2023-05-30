using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem5
{
    internal class Problem5
    {
        static void Main(string[] args)
        {
            var array = Console.ReadLine()
                .Split(' ')
                .ToArray();
            int[] intArray = new int[array.Length];
            string[] stringArray = new string[array.Length];
            int counter = 0;
            int newIndex = 0;
            for (int i = 0; i < array.Length; i++)
            {
                int.TryParse(array[i], out intArray[i]);
            }
            for (int i = 0; i < array.Length-1; i++)
            {
                if (intArray[i] > intArray[i+1])
                {
                    counter++;
                }
                else
                {
                    intArray[i] = 0;
                }
            }
            string[] newArray= new string[counter];
            for (int i = 0; i < intArray.Length-1; i++)
            {
                if (intArray[i] != 0)
                {
                    newArray[newIndex] = intArray[i].ToString();
                    newIndex++;
                }
            }
            Console.Write(string.Join(" ", newArray));
            Console.Write($" {intArray[intArray.Length-1]} ");
        }
    }
}