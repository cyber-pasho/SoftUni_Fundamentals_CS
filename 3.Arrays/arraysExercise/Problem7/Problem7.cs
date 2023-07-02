using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem7
{
    internal class Problem7
    {
        static void Main(string[] args)
        {
            string[] nums = Console.ReadLine()
                .Split(' ');
            int[] numsInt = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                numsInt[i] = int.Parse(nums[i]);
            }
            //
            int counter = 1;
            int longest = 1;
            string result = string.Empty;
            //
            for (int i = 1; i < numsInt.Length; i++)
            {
                if (numsInt[i] == numsInt[i-1])
                {
                    counter++;
                    if (counter > longest)
                    {
                        longest = counter;
                        int[] newArray = new int[longest];
                        int position = numsInt[i];
                        for (int z = 0; z < newArray.Length; z++)
                        {
                            newArray[z] = position;
                        }
                        result = string.Join(" ", newArray);

                    }
                }
                else
                {
                    counter = 1;
                }
            }
            Console.WriteLine(result);
        }
    }
}
