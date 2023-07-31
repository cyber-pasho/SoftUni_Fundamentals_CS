namespace Problem2
{
    internal class Program
    {
        static void Main()
        {
            var input = Console.ReadLine()
                .Split(" ")
                .Select(w => w.ToLower())
                .ToList();
            Dictionary<string, int> words = new Dictionary<string, int>();
            foreach (var word in input)
            {
                if (words.ContainsKey(word))
                {
                    words[word]++;
                }
                else
                {
                    words.Add(word, 1);
                }
            }
            foreach (var word in words)
            {
                if (word.Value % 2 != 0)
                {
                    Console.Write($"{word.Key} ");
                }
            }
        }
    }
}