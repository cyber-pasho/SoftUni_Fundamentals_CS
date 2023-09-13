using System.Globalization;
using System.Text.RegularExpressions;

namespace Problem1
{
    internal class Program
    {
        static void Main()
        {
            string pattern = @">>(?<Product>[A-Za-z]+)<<(?<Price>[0-9]+|[0-9]+.[0-9]+)!(?<Quantity>[0-9]+)";
            string input;
            decimal totalPrice = 0;
            List<string> products = new List<string>();
            while ((input = Console.ReadLine()) != "Purchase")
            {
                Regex regex = new Regex(pattern);
                MatchCollection matches = Regex.Matches(input, pattern);
                foreach (Match match in matches)
                {
                    string product = match.Groups["Product"].Value;
                    decimal cost = decimal.Parse(match.Groups["Price"].Value, CultureInfo.InvariantCulture);
                    decimal price = cost * int.Parse(match.Groups["Quantity"].Value);
                    products.Add(product);
                    totalPrice += price;
                }
            }
            Console.WriteLine($"Bought furniture:");
            foreach (var item in products)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"Total money spend: {totalPrice:f2}");
        }
    }
}