using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fix4
{
    internal class Problem4
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            string input = Console.ReadLine();
            //
            while (input != "End")
            {
                List<string> inputs = input
                .Split(' ')
                .ToList();
                //
                if (inputs[0] == "Add")
                {
                    int num = int.Parse(inputs[1]);
                    list.Add(num);
                }
                else if (inputs[0] == "Insert")
                {
                    int num1 = int.Parse(inputs[1]);
                    int num2 = int.Parse(inputs[2]);
                    if (num2 > list.Count-1)
                    {
                        Console.WriteLine("Invalid index");
                        input = Console.ReadLine();
                        continue;
                    }
                    list.Insert(num2, num1);
                }
                else if (inputs[0] == "Remove")
                {
                    int num = int.Parse(inputs[1]);
                    if (num > list.Count-1)
                    {
                        Console.WriteLine("Invalid index");
                        input = Console.ReadLine();
                        continue;
                    }
                    list.RemoveAt(num);
                }
                else if (inputs[1] == "left")
                {
                    int num = int.Parse(inputs[2]);
                    for (int i = 0; i < num; i++)
                    {
                        list.Add(list[0]);
                        list.RemoveAt(0);
                    }
                }
                else if (inputs[1] == "right")
                {
                    int num = int.Parse(inputs[2]);
                    for (int i = 0; i < num; i++)
                    {
                        list.Insert(0, list[list.Count - 1]);
                        list.RemoveAt(list.Count - 1);
                    }
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", list));
        }
    }
}
