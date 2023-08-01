namespace Problem2
{
    internal class Program
    {
        static void Main()
        {
            Dictionary<string, int> resourses = new Dictionary<string, int>();
            string key;
            while ((key = Console.ReadLine()) != "stop")
            {
               int value = int.Parse(Console.ReadLine());
                if (!resourses.ContainsKey(key))
                {
                    resourses.Add(key,value);
                }
                else
                {
                    resourses[key] += value;
                }
            }
            foreach (var item in resourses)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}