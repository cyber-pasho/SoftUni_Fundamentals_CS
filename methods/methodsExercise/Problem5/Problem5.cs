using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem5
{
    internal class Problem5
    {
        static void Main()
        {
            int sum = SumMethod() - IntTree();
            Console.WriteLine(sum);
        }
        static int SumMethod()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c= a + b;
            return c;
        }
        static int IntTree()
        {
            int d = int.Parse(Console.ReadLine());
            return d;
        }
    }
}
