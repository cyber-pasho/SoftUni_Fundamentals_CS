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
            string input = Console.ReadLine();
            Console.WriteLine(MidChars(input));
        }
        static string MidChars(string input)
        {
            double index = input.Length / 2;
            int newIndex = (int)Math.Ceiling(index);
            if (input.Length % 2 == 0)
            {
                string output = ($"{input[newIndex-1]}{input[newIndex]}");
                return output;
            }
            else
            {
                string output = ($"{input[newIndex]}");
                return output;
            }
        }
    }
}
