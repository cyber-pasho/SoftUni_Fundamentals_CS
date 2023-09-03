namespace Problem1
{
    internal class Program
    {
        static void Main()
        {
            var input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToArray();


            foreach (var username in input)
            {
                if (username.Length < 3 || username.Length > 16 )
                {
                    continue;
                }
                bool isValidName = username.All(character => char.IsLetterOrDigit(character) || character == '-' || character == '_');
                if (isValidName)
                {
                    Console.WriteLine(username);
                }

            }
        }
    }
}