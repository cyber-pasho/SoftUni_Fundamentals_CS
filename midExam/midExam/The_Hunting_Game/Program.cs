using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Hunting_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int playersCount = int.Parse(Console.ReadLine());
            double energy = double.Parse(Console.ReadLine());
            double water = ((double.Parse(Console.ReadLine())) * playersCount) * days;
            double food = ((double.Parse(Console.ReadLine())) * playersCount) * days;
            double energyLoss = double.Parse((Console.ReadLine()));
            bool tired = false;
            //
            for (int i = 1; i <= days; i++)
            {
                energy -= energyLoss;
                if (i % 2 == 0 && i % 3 == 0)
                {
                    energy += energy*0.05;
                    energy += energy * 0.1;
                    water *= 0.7;
                    food -= (food / playersCount);
                    energy = Math.Round(energy, 2);
                    energyLoss = double.Parse((Console.ReadLine()));
                    continue;
                }
                else if (i % 2 == 0)
                {
                    energy += energy*0.05;
                    water *= 0.7;
                }
                else if (i % 3 == 0)
                {
                    energy += energy*0.10;
                    food -= (food / playersCount);
                }
                if (energy <= 0)
                {
                    tired = true;
                    break;
                }
                energy = Math.Round(energy, 2);
                if (i != days)
                {
                    energyLoss = double.Parse(Console.ReadLine());
                }
            }
            if (tired)
            {
                Console.WriteLine($"You will run out of energy. You will be left with {food:f2} food and {water:f2} water.");
            }
            else
            {
                Console.WriteLine($"You are ready for the quest. You will be left with - {energy:f2} energy!");
            }
        }
    }
}
