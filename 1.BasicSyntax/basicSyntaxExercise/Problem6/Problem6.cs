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
            var num = int.Parse(Console.ReadLine());
            string numString = num.ToString();
            var factorialSumWhole = 0;
            //
            foreach (char digitChar in numString)
            {
                int digit = int.Parse(digitChar.ToString());
                if (digit == 0)
                {
                    //if digit is 0 - error! by default 0! = 1!!!
                    digit = 1;
                }
                int factorialSum = digit;
                for (int i = digit-1; i >= 1; i--)
                {
                    factorialSum *= i;
                }
                factorialSumWhole += factorialSum;
            }
            if (factorialSumWhole == num)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}