using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectsAndClassesLecture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine()
                .Split(' ')
                .ToArray();
            Random rnd = new Random();
            for (int i = 0; i < words.Length; i++)
            {
                
                int randomNumber = rnd.Next(0, words.Length);
                string valueAtIndex = words[i];
                string randomValueAtIndex = words[randomNumber];

                words[i] = randomValueAtIndex;
                words[randomNumber] = valueAtIndex;
            }
            foreach (var item in words)
            {
                Console.WriteLine(item);
            }
        }
    }
}
