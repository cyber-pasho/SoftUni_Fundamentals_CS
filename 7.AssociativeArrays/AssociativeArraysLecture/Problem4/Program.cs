namespace Problem4
{
    internal class Program
    {
        static void Main()
        {
            var input = Console.ReadLine()
                .Split(" ")
                .Where(w => w.Length % 2 == 0)
                .ToArray();
            foreach (var w in input)
            {
                Console.WriteLine(w);
            }
        }
    }
}