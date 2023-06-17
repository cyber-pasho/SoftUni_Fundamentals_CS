using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Problem1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double totalPrice = 0;
            double taxes = 1.2;
            double specialPriceIndex = 0.9;
            //
            for (int i = 0; i < int.MaxValue; i++)
            {
                if (input == "special" || input == "regular")
                {
                    break;
                }
                else
                {
                    double entryPrice = double.Parse(input);
                    totalPrice += entryPrice;
                    //
                    if (entryPrice < 0)
                    {
                        totalPrice -= entryPrice;
                        Console.WriteLine($"Invalid price!");
                    }
                    else if (totalPrice <= 0)
                    {
                        totalPrice -= entryPrice;
                        Console.WriteLine($"Invalid order!");
                    }
                }
                input = Console.ReadLine();
            }
            //
            double a = 1;
            //
            if (input == "special")
            {
                a = specialPriceIndex;
            }
            Console.WriteLine("Congratulations you've just bought a new computer!");
            Console.WriteLine($"Price without taxes: {totalPrice:f2}$");
            Console.WriteLine($"Taxes: {(totalPrice*taxes)-totalPrice:f2}$");
            Console.WriteLine("-----------");
            Console.WriteLine($"Total price: {(totalPrice*taxes)*a:f2}$");
        }
    }
}