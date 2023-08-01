namespace Problem1
{
    internal class Program
    {
        static void Main()
        {
            Dictionary<char, int> chars = new Dictionary<char, int>();
            var input = Console.ReadLine()
                .Where(c => !char.IsWhiteSpace(c))
                .ToArray();
            for (int i = 0; i < input.Length; i++)
            {
                char key = input[i];
                if (!chars.ContainsKey(input[i]))
                {
                    chars.Add(key, 1);
                }
                else
                {
                    chars[key]++;
                }
            }
            foreach (var item in chars)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}