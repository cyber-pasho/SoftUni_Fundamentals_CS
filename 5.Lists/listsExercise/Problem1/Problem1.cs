using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listsExercise
{
    internal class Problem1
    {
        static void Main(string[] args)
        {
            List<int> train = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList(); 
            int capacity = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            //
            while (input != "end")
            {
                List<string> inputs = input
                .Split(' ')
                .ToList();
                if (inputs.Count > 1)
                {
                    int inputInt = int.Parse(inputs[1]);
                    train.Add(inputInt);
                }
                else
                {
                    for (int i = 0; i < train.Count; i++)
                    {
                        int inputInt = int.Parse(inputs[0]);
                        if (train[i] + inputInt <= capacity)
                        {
                            train[i] += inputInt;
                            break;
                        }
                    }
                }
                input = Console.ReadLine();

            }
            Console.WriteLine(string.Join(" ", train));
        }
    }
}
