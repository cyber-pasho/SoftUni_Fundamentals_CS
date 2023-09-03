using System.Diagnostics.CodeAnalysis;

namespace Problem2
{
    internal class Program
    {
        static void Main()
        {
            var input = Console.ReadLine()
                .Split(" ")
                .ToArray();
            string str1 = input[0];
            string str2 = input[1];
            int sum = SumOfChars(str1, str2);
            Console.WriteLine (sum);

        }
        public static int SumOfChars(string a, string b)
        {
            int sum = 0;
            int length = Math.Max(a.Length, b.Length);

            for (int i = 0; i < length; i++)
            {
               if (i < a.Length && i < b.Length)
               {
                    int num1 = (int)a[i];
                    int num2 = (int)b[i];
                    sum += num1 * num2;
               }
               else if (i < a.Length)
               {
                    int num1 = (int)a[i];
                    sum += num1;
               }
               else if (i < b.Length)
               {
                    int num2 = (int)b[i];
                    sum += num2;
               }
            }
            return sum;
        }
    }
}