using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem7
{
    internal class Problem7
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
                .Split('|')
                .ToList();
            input.Reverse();
            string reverse = string.Join(" ", input);
            List<string> reverseList = reverse
                .Split(' ')
                .ToList();
            reverseList.RemoveAll(x => x == "");
            foreach (var number in reverseList)
            {
                Console.Write(number + " ");
            }
        }
    }
}