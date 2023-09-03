using System.Text;

namespace Problem4
{
    internal class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            StringBuilder sb = new StringBuilder();

            foreach (var element in input)
            {
                sb.Append((char)((int)element+3));
            }
            Console.WriteLine(sb);
        }
    }
}