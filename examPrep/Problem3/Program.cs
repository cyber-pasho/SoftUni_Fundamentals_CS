using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> hood = Console.ReadLine()
               .Split('@')
               .Select(int.Parse)
               .ToList();
            List<string> input = Console.ReadLine()
                .Split(' ')
                .ToList();
            int currentHouse = 0;
            int houseCount = 0;
            //
            while (input[0] != "Love!")
            {
                int jump = int.Parse(input[1]);
                currentHouse += jump;
                if (currentHouse >= hood.Count)
                {
                    while (currentHouse >= hood.Count)
                    {
                        int remainingJumps = currentHouse - (hood.Count - 1);
                        currentHouse = remainingJumps;
                    }
                }
                if (hood[currentHouse] <= 0)
                {
                    Console.WriteLine($"Place {hood[currentHouse]} already had Valentine's day.");
                }
                else
                {
                    hood[currentHouse] -= 2;
                    if (hood[currentHouse] <= 0)
                    {
                        Console.WriteLine($"Place {currentHouse} has Valentine's day.");
                    }
                }
                input = Console.ReadLine()
                .Split(' ')
                .ToList();
            }
            Console.WriteLine($"Cupid's last position was {currentHouse}.");
            foreach (var item in hood)
            {
                if (item != 0)
                {
                    houseCount++;
                }
            }
            if (houseCount == 0)
            {
                Console.WriteLine("Mission was successful.");
            }
            else
            {
                Console.WriteLine($"Cupid has failed {houseCount} places.");
            }
        }
    }
}