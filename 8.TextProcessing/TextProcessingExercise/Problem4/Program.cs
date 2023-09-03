namespace Problem4
{
    internal class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string encryption = string.Empty;
            string decryption = string.Empty;
            foreach (char letter in input)
            {
                char newChar = (char)((int)letter+3);
                encryption += newChar;
            }
            Console.WriteLine(encryption);
            foreach (char letter in encryption)
            {
                char newChar = (char)((int)letter - 3);
                decryption += newChar;
            }
            Console.WriteLine(decryption);
        }
    }
}