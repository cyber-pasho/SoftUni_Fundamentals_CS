using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem9
{
    internal class Problem9
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            while (input != "END")
            {
                if (BackwardsString(input) == input)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
                input = Console.ReadLine();
            }

        }
        static string BackwardsString(string input)
        {
            string palindrome = string.Empty;
            for (int i = input.Length-1; i >= 0; i--)
            {
                palindrome += input[i];
            }
            return palindrome;
        }
    }
}
