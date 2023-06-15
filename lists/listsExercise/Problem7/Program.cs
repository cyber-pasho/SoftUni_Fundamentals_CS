using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
                .Split('|')
                .ToList();
            input.Reverse();
            string reverse = string.Join(" ", input);
            List<string> reverseList = reverse
                .Split(' ')
                .ToList();
            reverseList.RemoveAll(x => x == "");
            foreach (var number in reverseList)
            {
                Console.Write(number + " ");
            }
        }
    }
}


//List<string> output = new List<string>();
//for (int i = 0; i < input.Count; i++)
//{
    //List<string> inputEach = input[i]
        //.Split()
        //.ToList();
    //for (int j = 0; j < inputEach.Count; j++)
    //{
        //output.Add(inputEach[j]);
   //}
//}