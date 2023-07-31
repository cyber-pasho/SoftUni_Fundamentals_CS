namespace Problem3
{
    internal class Program
    {
        static void Main()
        {
            int count = int.Parse(Console.ReadLine());
            Dictionary<string, List<string>> synonims = new Dictionary<string, List<string>>();
            for (int i = 1; i <= count; i++)
            {
                string key = Console.ReadLine();
                string value = Console.ReadLine();
                if (!synonims.ContainsKey(key))
                {
                    synonims.Add(key, new List<string>());
                    synonims[key].Add(value);
                }
                else
                {
                    synonims[key].Add(value);
                }
            }
            foreach (var item in synonims)
            {
                Console.WriteLine($"{item.Key} - {string.Join(", ", item.Value)}");
            }

        }
    }
}