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
            int code1 = int.Parse(Console.ReadLine());
            char asciiCode1 = (char)code1;
            int code2 = int.Parse(Console.ReadLine());
            char asciiCode2 = (char)code2;
            Console.Write($"{asciiCode1} ");
            for (int i = asciiCode1+1; i < asciiCode2; i++)
            {
                char iAscii = (char)i;
                Console.Write($"{iAscii} ");
            }
            Console.Write($"{asciiCode2}");
        }
    }
}
