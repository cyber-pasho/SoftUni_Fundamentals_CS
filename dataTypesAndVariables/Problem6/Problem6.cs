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
            int num = int.Parse(Console.ReadLine());
            char letter = (char)('a' + num-1);
            //
            for (int i = 0; i < num; i++)
            {
                for (int k = 0; k < num; k++)
                {
                    for (int z = 0; z < num; z++)
                    {
                        char firstChar = (char)('a' + i);
                        char secondChar = (char)('a' + k);
                        char thirdChar = (char)('a' + z);
                        Console.WriteLine($"{firstChar}{secondChar}{thirdChar}");
                    }
                }
            }
        }
    }
}
