using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Problem2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int health = 100;
            int bitcoins = 0;
            bool isDead = false;
            int counter = 0;
            List<string> dungeon = Console.ReadLine()
                .Split('|')
                .ToList();
            while (health > 0)
            {
                foreach (var item in dungeon)
                {
                    List<string> room = item
                    .Split(' ')
                    .ToList();
                    switch (room[0])
                    {
                        case "potion":
                            health += int.Parse(room[1]);
                            int healed = 0;
                            if (health > 100)
                            {
                                healed = health - 100;
                                health = 100;
                            }
                            Console.WriteLine($"You healed for {int.Parse(room[1])-healed} hp.");
                            Console.WriteLine($"Current health: {health} hp.");
                            counter++;
                            continue;

                        case "chest":
                            bitcoins += int.Parse(room[1]);
                            Console.WriteLine($"You found {room[1]} bitcoins.");
                            counter++;
                            continue;

                        default:
                            health -= int.Parse(room[1]);
                            counter++;
                            if (health > 0)
                            {
                                Console.WriteLine($"You slayed {room[0]}.");
                                continue;
                            }
                            else
                            {
                                Console.WriteLine($"You died! Killed by {room[0]}.");
                                Console.WriteLine($"Best room: {counter}");
                                isDead = true;
                                break;
                            }
                    }
                            if (isDead)
                            {
                                break;
                            }
                }
                if (isDead == false)
                {
                    Console.WriteLine($"You've made it!");
                    Console.WriteLine($"Bitcoins: {bitcoins}");
                    Console.WriteLine($"Health: {health}");
                    break;
                }

            }
        }
    }
}
