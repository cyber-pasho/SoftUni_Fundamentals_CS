using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Problem7
{
    internal class Problem7
    {
        static void Main(string[] args)
        {
            string moneyIn = Console.ReadLine();
            bool isValid = false;
            double sum = 0;
            //
            while (moneyIn != "Start")
            {
                double moneyInDouble = double.Parse(moneyIn);
                switch (moneyIn)
                {
                    case "0.1":
                        sum += moneyInDouble; 
                        break;
                    case "0.2":
                        sum += moneyInDouble;
                        break;
                    case "0.5":
                        sum += moneyInDouble;
                        break;
                    case "1":
                        sum += moneyInDouble;
                        break;
                    case "2":
                        sum += moneyInDouble;
                        break;
                    case "End":
                        isValid = true;
                        break;
                    default:
                        Console.WriteLine($"Cannot accept {moneyIn}");
                        break;
                }
                if (isValid == true)
                {
                    break;
                }
                else
                {
                    moneyIn = Console.ReadLine();
                }
            }
            string product = Console.ReadLine();
            while (product != "End")
            {
                //fix final sum [START]
                double productDouble = 0;
                bool invalidProduct = false;
                if (product == "Nuts")
                {
                    productDouble = 2.0;
                }
                else if (product == "Water")
                {
                    productDouble = 0.7;
                }
                else if (product == "Crisps")
                {
                    productDouble = 1.5;
                }
                else if (product == "Soda")
                {
                    productDouble = 0.8;
                }
                else if (product == "Coke")
                {
                    productDouble = 1.0;
                }
                else
                {
                    Console.WriteLine("Invalid product");
                    invalidProduct = true;
                }
                //fix final sum [END]
                if (!invalidProduct)
                {
                    sum -= productDouble;
                    if (sum < 0)
                    {
                        Console.WriteLine("Sorry, not enough money");
                        sum += productDouble;
                    }
                    else
                    {
                        string lowercase = product.ToLower();
                        Console.WriteLine($"Purchased {lowercase}");
                    }
                }
                product = Console.ReadLine();
            }
            Console.WriteLine($"Change: {sum:f2}");
        }
    }
}
