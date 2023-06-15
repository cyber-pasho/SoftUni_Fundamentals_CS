using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem6
{
    internal class Problem6
    {
        static void Main()
        {
            List<int> cards1 = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            List<int> cards2 = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            int card1 = 0;
            int card2 = 0;
            for (int i = 0; i < cards1.Count; i = 0)
            {
                card1 = cards1[0];
                for (int j = 0; j < cards2.Count; j = 0)
                {
                    card2 = cards2[0];
                    break;
                }
                if (card1 > card2)
                {
                    cards1.Add(card2);
                    cards1.Add(card1);
                    cards1.RemoveAt(0);
                    cards2.RemoveAt(0);
                    int c1 = cards1.Sum();
                    int c2 = cards2.Sum();
                    if (Winner(cards1.Count, cards2.Count, c1, c2))
                    {
                        break;
                    }
                }
                else if (card2 > card1)
                {
                    cards2.Add(card1);
                    cards2.Add(card2);
                    cards1.RemoveAt(0);
                    cards2.RemoveAt(0);
                    int c1 = cards1.Sum();
                    int c2 = cards2.Sum();
                    if (Winner(cards1.Count, cards2.Count, c1, c2))
                    {
                        break;
                    }
                }
                else
                {
                    cards1.RemoveAt(0);
                    cards2.RemoveAt(0);
                    int c1 = cards1.Sum();
                    int c2 = cards2.Sum();
                    if (Winner(cards1.Count, cards2.Count, c1, c2))
                    {
                        break;
                    }
                }

            }
            
        }
        static bool Winner(int a, int b, int c1, int c2)
        {
            if (a == 0)
            {
                int sum1 = c2;
                Console.WriteLine($"Second player wins! Sum: {sum1}");
                return true;
            }
            else if (b == 0)
            {
                int sum2 = c1;
                Console.WriteLine($"First player wins! Sum: {sum2}");
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
