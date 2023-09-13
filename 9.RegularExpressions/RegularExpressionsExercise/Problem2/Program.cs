using System.Text.RegularExpressions;
using System.Threading.Tasks.Dataflow;

namespace Problem2
{
    internal class Program
    {
        static void Main()
        {
            string pattern = @"(?:(?:\+359)(?:-)(?:2)(?:-)(?:[0-9]{3}\b)(?:-)(?:[0-9]{4}\b)|(?:\+359)(?:\s)(?:2)(?:\s)(?:[0-9]{3}\b)(?:\s)(?:[0-9]{4}\b))";
            string input = Console.ReadLine();
            Regex regex = new Regex(pattern);
            MatchCollection matches = Regex.Matches(input, pattern);
            var numbers = matches
                .Cast<Match>()
                .Select(a=>a.Value.Trim())
                .ToArray();
            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}