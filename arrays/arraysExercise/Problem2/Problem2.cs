using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    internal class Problem2
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] words1 = input.Split();
            input = Console.ReadLine();
            string[] words2 = input.Split();
            //
            foreach (string item2 in words2)
            {
                foreach (string item1 in words1)
                {
                    if (item1 == item2)
                    {
                        Console.Write($"{item1} ");

                    }
                }
            }
        }
    }
}
