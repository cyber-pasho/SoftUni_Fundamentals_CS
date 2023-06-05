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
            int volweCount = CountVowels(input);
            Console.WriteLine(volweCount);

        }
        static int CountVowels(string input)
        {
            int count = 0;
            input = input.ToLower();
            foreach (char c in input)
            {
                if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
                    count++;
            }
            return count;
        }
    }
}
