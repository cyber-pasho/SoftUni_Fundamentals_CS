using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    internal class Problem2
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            //
            string numString = num.ToString();
            foreach (var digitChar in numString)
            {
                sum += int.Parse(digitChar.ToString());
            }
            Console.WriteLine(sum);
        }
    }
}
