using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem10
{
    internal class Problem10
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            int currentNum = 0;
            for (int i = 1; i <= num; i++)
            {
                currentNum = i;
                if (DivisibleByEight(currentNum) && HoldsOddDigit(currentNum))
                {
                    Console.WriteLine($"{currentNum}");
                }
            }
        }
        static bool DivisibleByEight(int currentNum)
        {
            string currentNumString = currentNum.ToString();
            int currentNumSum = 0;
            for (int i = 0; i < currentNumString.Length; i++)
            {
                currentNumSum += (int)currentNumString[i]; 
            }
            if (currentNumSum % 8 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static bool HoldsOddDigit(int currentNum)
        {
            string currentNumString = currentNum.ToString();

            for (int i = 0; i < currentNumString.Length; i++)
            {
                int currentNumInt = (int)currentNumString[i];
                if (currentNumInt % 2 == 1)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
