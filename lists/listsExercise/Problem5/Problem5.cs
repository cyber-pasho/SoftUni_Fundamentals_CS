using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem5
{
    internal class Problem5
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            List<int> specials = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            //
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == specials[0])
                {
                    for (int j = 0; j < specials[1]; j++)
                    {
                        if (i < 1)
                        {
                            break;
                        }
                        else
                        {
                            list.RemoveAt(i - 1);
                            i--;
                        }
                    }
                    for (int j = 0; j < specials[1]; j++)
                    {
                        if (i > list.Count - 2)
                        {
                            break;
                        }
                        else
                        {
                            list.RemoveAt(i + 1);
                        }
                    }
                }
            }
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == specials[0])
                {
                    list.RemoveAt(i);
                    i--;
                }
            }
            Console.WriteLine(list.Sum());
        }
    }
}
