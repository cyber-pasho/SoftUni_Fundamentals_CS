using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4
{
    internal class Problem4
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            string[] nums= new string[lines];
            int sum = 0;
            for (int i = 0; i < lines; i++)
            {
                nums[i] = Console.ReadLine();
                foreach (char numsChar in nums[i])
                {
                    int asciiValue = (int)numsChar;
                    sum += asciiValue;
                }
            }
            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
