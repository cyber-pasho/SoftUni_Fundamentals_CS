using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    internal class Problem2
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            string input = Console.ReadLine();
            //
            while (input != "end")
            {
                List<string> inputs = input
                .Split(' ')
                .ToList();
                if (inputs.Count == 2)
                {
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (list[i] == int.Parse(inputs[1]))
                        {
                            list.Remove(int.Parse(inputs[1]));
                            i -= 1;
                        }
                    }
                }
                else
                {
                    list.Insert(int.Parse(inputs[2]), int.Parse(inputs[1]));
                }
                input = Console.ReadLine(); 
            }
            Console.WriteLine(string.Join(" ", list));
        }
    }
}
