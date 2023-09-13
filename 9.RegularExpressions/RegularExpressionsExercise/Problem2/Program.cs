namespace Problem2
{
    internal class Program
    {
        static void Main()
        {
            var participants = Console.ReadLine()
                .Split(", ")
                .ToList();
            string patternName = @"[A-Za-z]+";
            string patternDistance = @"[0-9]";
        }
    }
}