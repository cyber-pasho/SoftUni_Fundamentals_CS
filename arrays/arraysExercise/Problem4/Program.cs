using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var items = Console.ReadLine()
                .Split(' ')
                .ToArray();
            //
            int rule = int.Parse(Console.ReadLine());
            //
            if (rule < items.Length)
            {
                rule = rule;
            }
            else
            {
                rule %= items.Length;
            }
            string[] itemsMoved= new string[rule];
            Array.Copy(items, itemsMoved, rule);
            Array.Copy(items, rule, items, 0, items.Length - rule);
            Array.Copy(itemsMoved, 0, items, items.Length - rule, rule);

            //
            Console.WriteLine(string.Join(" ", items));
        }
    }
}
