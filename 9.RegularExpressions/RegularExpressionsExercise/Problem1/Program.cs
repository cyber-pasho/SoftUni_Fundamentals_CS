using System.Text.RegularExpressions;

namespace Problem1
{
    internal class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string pattern = @"(?<FirstName>\b[A-Z][a-z]+)[ ](?<LastName>\b[A-Z][a-z]+)";
            Regex regex = new Regex(pattern);
            MatchCollection matches = Regex.Matches(input, pattern);
            foreach (Match name in matches)
            {
                Console.Write($"{name.Value} ");
            }
        }
    }
}