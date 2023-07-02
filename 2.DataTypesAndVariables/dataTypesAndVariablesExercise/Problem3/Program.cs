using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double people = int.Parse(Console.ReadLine());
            double capacity = int.Parse(Console.ReadLine());
            //
            int runs = (int)Math.Ceiling((double)people / capacity);
            Console.WriteLine(runs);
        }
    }
}
