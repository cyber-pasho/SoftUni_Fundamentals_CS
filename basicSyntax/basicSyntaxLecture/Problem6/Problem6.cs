using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem5
{
    internal class Problem6
    {
        static void Main(string[] args)
        {
            string monthNumber = Console.ReadLine();
            //
            if (monthNumber == "USA" || monthNumber == "Englang")
            {
                Console.WriteLine("English");
            }
            else if (monthNumber == "Spain" || monthNumber == "Argentina" || monthNumber == "Mexico")
            {
                Console.WriteLine("Spanish");
            }
            else
            {
                Console.WriteLine("unknown");
            }

        }
    }
}
