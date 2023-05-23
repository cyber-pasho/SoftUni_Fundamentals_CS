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
            int people = int.Parse(Console.ReadLine());
            string groupType = Console.ReadLine();
            string day = Console.ReadLine();
            decimal price = 0;
            //
            if (groupType == "Students")
            {
                if (day == "Friday")
                {
                    price = people * 8.45m;
                }
                else if (day == "Saturday")
                {
                    price = people * 9.80m;
                }
                else
                {
                    price = people * 10.46m;
                }
                if (people >= 30)
                {
                    price *= 0.85m;
                }
            }
            else if (groupType == "Business")
            {
                if (day == "Friday")
                {
                    price = people * 10.90m;
                }
                else if (day == "Saturday")
                {
                    price = people * 15.60m;
                }
                else
                {
                    price = people * 16m;
                }
                if (people >= 10)
                {
                    var ratio = price / people;
                    price -= ratio*10; 
                }
            }
            else if (groupType == "Regular")
            {
                if (day == "Friday")
                {
                    price = people * 15m;
                }
                else if (day == "Saturday")
                {
                    price = people * 20m;
                }
                else
                {
                    price = people * 22.50m;
                }
                if (people >= 10 && people <= 20)
                {
                    price *= 0.95m;
                }
            }
            //
            Console.WriteLine($"Total price: {price:f2}");

        }
    }
}
