using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3
{
    internal class Problem3
    {
        static void Main()
        {
            char a = char.Parse(Console.ReadLine());
            char b = char.Parse(Console.ReadLine());
            ToAscii(a, b);
        }
        static void ToAscii(char a, char b)
        {
            int num1 = Convert.ToInt32(a);
            int num2 = Convert.ToInt32(b);
            if (num1 > num2)
            {
                int temp = num2;
                num2 = num1;
                num1 = temp;
            }
            for (int i = num1+1; i <= num2-1; i++)
            {
                Console.Write($"{(char)i} ");
            }
            Console.WriteLine();
        }
    }
}
