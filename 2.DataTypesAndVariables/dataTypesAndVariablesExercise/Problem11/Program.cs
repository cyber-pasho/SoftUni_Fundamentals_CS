using System;
using System.Numerics;
namespace Problem11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            BigInteger theBestSnowball = int.MinValue;
            int bestSnow = 0;
            int bestTime = 0;
            int bestQuality = 0;
            //
            for (int i = 1; i <= num; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());
                //
                //snowballValue = (snowballSnow / snowballTime) ^ snowballQuality;
                BigInteger value = BigInteger.Pow((snowballSnow / snowballTime), snowballQuality);
                if (value > theBestSnowball)
                {
                    theBestSnowball = value;
                    bestSnow = snowballSnow;
                    bestTime = snowballTime;
                    bestQuality = snowballQuality;
                }
            }
            Console.WriteLine($"{bestSnow} : {bestTime} = {theBestSnowball} ({bestQuality})");
        }
    }
}
