using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem8
{
    internal class Problem8
    {
        static void Main(string[] args)
        {
            int numKegs = int.Parse(Console.ReadLine());
            double[] volumes = new double[numKegs];
            string[] models= new string[numKegs];
            double largestVolume = double.MinValue;
            int largestIndex = -1;
            //
            for (int i = 0; i < numKegs; i++)
            {
                models[i] = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());
                volumes[i] = Math.PI * (radius * radius) * height;
                if (volumes[i] > largestVolume)
                {
                    largestVolume = volumes[i];
                    largestIndex = i;
                }
            }
            Console.WriteLine(models[largestIndex]);
        }
    }
}
