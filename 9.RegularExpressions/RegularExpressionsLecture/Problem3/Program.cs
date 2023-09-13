using System.Text.RegularExpressions;

namespace Problem3
{
    internal class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string pattern = @"(?<day>\b[0-9]{2}\b)(\.|-|\/)(?<Month>[A-Z][a-z]{2})\1(?<Year>[0-9]{4})";
            Regex regex = new Regex(pattern);
            MatchCollection matches = Regex.Matches(input, pattern);

            foreach (Match match in matches)
            {
                Console.WriteLine($"Day: {match.Groups["day"]}, Month: {match.Groups["Month"]}, Year: {match.Groups["Year"]}");
            }
        }
    }
}