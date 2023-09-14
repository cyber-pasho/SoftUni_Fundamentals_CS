using System.Text.RegularExpressions;

namespace Problem3
{
    internal class Program
    {
        static void Main()
        {
            string pattern = @"%(?<customer>[A-Z][a-z]+)%[^|$%.]*<(?<product>\w+)>[^|$%.]*\|(?<count>\d+)\|[^|$%.]*?(?<price>\d+\.\d+|\d+)\$";
            Regex regex = new Regex(pattern);
            string input;
            decimal totalMoney = 0;
            while ((input = Console.ReadLine())!= "end of shift")
            {
                MatchCollection matches = Regex.Matches(input, pattern);
                foreach (Match match in matches)
                {
                    int count = int.Parse(match.Groups["count"].Value);
                    decimal price = decimal.Parse(match.Groups["price"].Value);
                    decimal money = count*price;
                    totalMoney += money;
                    Console.WriteLine($"{match.Groups["customer"].Value}: {match.Groups["product"].Value} - {money}");
                }
                Console.WriteLine($"Total income: {totalMoney}");
            }
        }
    }
    
}