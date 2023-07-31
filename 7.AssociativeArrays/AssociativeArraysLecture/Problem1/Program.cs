namespace Problem1
{
    internal class Program
    {
        static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();
            SortedDictionary<int, int> counts = new SortedDictionary<int, int>();
            foreach (var number in numbers) 
            {
                if (counts.ContainsKey(number))
                {
                    counts[number]++;
                }
                else
                { 
                    counts.Add(number, 1);
                }
            }
            foreach (var count in counts)
            {
                Console.WriteLine($"{count.Key} -> {count.Value}");
            }
        }
    }
}