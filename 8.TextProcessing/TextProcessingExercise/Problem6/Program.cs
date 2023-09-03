

namespace Problem6
{
    internal class Program
    {
        static void Main()
        {
            List<char> result = new List<char>();
            string input = Console.ReadLine();
            for (int i = 0; i < input.Length; i++)
            {
                if (!result.Contains(input[i]))
                {
                    result.Add((char)input[i]);
                }
                else
                {
                    if (input[i] == input[i-1])
                    {
                        continue;
                    }
                    else
                    {
                        result.Add((char)input[i]);
                    }
                }
            }
            string joinedResult = string.Join("", result);
            Console.WriteLine(joinedResult);

        }
    }
}