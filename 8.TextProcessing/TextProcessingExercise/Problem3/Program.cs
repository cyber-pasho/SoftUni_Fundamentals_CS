namespace Problem3
{
    internal class Program
    {
        static void Main()
        {
            var input = Console.ReadLine()
                .Split('\\')
                .ToArray();

            foreach (var element in input)
            {
                if (element.Contains('.'))
                {
                    var result = element
                        .Split('.')
                        .ToArray();
                    string name = result[0];
                    string extension = result[1];
                    Console.WriteLine($"File name: {name}\nFile extension: {extension}");
                }
            }
        }
    }
}