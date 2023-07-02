using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3
{
    internal class Problem3
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            bool isFirstSelected = true;
            string[] arrays1= new string[num]; //cherno
            string[] arrays2= new string[num]; //cherveno
            //
            for (int i = 0; i < num; i++)
            {
                string arraysInput = Console.ReadLine();
                string[] arraysInputSplit = arraysInput.Split();
                if (isFirstSelected)
                {
                    arrays1[i] = arraysInputSplit[0];
                    arrays2[i] = arraysInputSplit[1];
                }
                else
                {
                    arrays1[i] = arraysInputSplit[1];
                    arrays2[i] = arraysInputSplit[0];
                }
                isFirstSelected = !isFirstSelected;
            }
            Console.WriteLine(string.Join(" ", arrays1));
            Console.WriteLine(string.Join(" ", arrays2));
        }
    }
}
