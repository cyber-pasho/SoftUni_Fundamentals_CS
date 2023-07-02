using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var array = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            List<string> input = Console.ReadLine()
                .Split(' ')
                .ToList();
            int a = 0;
            int b = 0;
            string arrayInput;
            while (input[0] != "end")
            {
                //
                switch (input[0])
                {
                    case "swap":
                        a = int.Parse(input[1]);
                        b = int.Parse(input[2]);
                        arrayInput = string.Join(" ", array);
                        array = Swap(a, b, arrayInput)
                            .Split()
                            .Select(int.Parse)
                            .ToArray();
                        break;
                    //
                    case "multiply":
                        a = int.Parse(input[1]);
                        b = int.Parse(input[2]);
                        arrayInput = string.Join(" ", array);
                        array = Multiply(a, b, arrayInput)
                            .Split()
                            .Select(int.Parse)
                            .ToArray();
                        break;
                    //
                    case "decrease":
                        arrayInput = string.Join(" ", array);
                        array = Decrease(arrayInput)
                            .Split()
                            .Select(int.Parse)
                            .ToArray();
                        break;
                        //
                }
                input = Console.ReadLine()
                .Split(' ')
                .ToList();
            }
            Console.Write(string.Join(", ", array));
            Console.WriteLine();
        }
        static string Swap (int a, int b, string arrayInput)
        {
            var input = arrayInput
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int temp = input[a];
            input[a] = input[b];
            input[b] = temp;
            return string.Join(" ", input);
        }
        static string Multiply(int a, int b, string arrayInput)
        {
            var input = arrayInput
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            input[a] = input[b]*input[a];
            return string.Join(" ", input);
        }
        static string Decrease(string arrayInput)
        {
            var input = arrayInput
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            for (int i = 0; i < input.Length; i++)
            {
                input[i] -= 1;
            }
            return string.Join(" ", input);
        }
    }
}
