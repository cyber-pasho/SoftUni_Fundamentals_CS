using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Space_Travel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<string> commands = input
                .Split(new string[] { "||" }, StringSplitOptions.None)
                .ToList();
            int fuel = int.Parse(Console.ReadLine());
            int ammo = int.Parse(Console.ReadLine());
            //
            for (int i = 0; i < commands.Count; i++)
            {
                List<string> command = commands[i]
                .Split(' ')
                .ToList();
                switch (command[0])
                {
                    //
                    case "Travel":
                        if (fuel < int.Parse(command[1]))
                        {
                            Console.WriteLine("Mission failed.");
                            return;
                        }
                        else
                        {
                            fuel -= int.Parse(command[1]);
                            Console.WriteLine($"The spaceship travelled {command[1]} light-years.");
                            continue;
                        }
                        //
                    case "Enemy":
                        if (ammo < int.Parse(command[1]))
                        {
                            fuel -= (int.Parse(command[1]) * 2);
                            if (fuel < 0)
                            {
                                Console.WriteLine("Mission failed.");
                                return;
                            }
                            else
                            {
                                Console.WriteLine($"An enemy with {command[1]} armour is outmaneuvered.");
                                continue;
                            }
                        }
                        else
                        {
                            ammo -= int.Parse(command[1]);
                            Console.WriteLine($"An enemy with {command[1]} armour is defeated.");
                            continue;
                        }
                        //
                    case "Repair":
                        fuel += int.Parse(command[1]);
                        ammo += 2* int.Parse(command[1]);
                        Console.WriteLine($"Ammunitions added: {int.Parse(command[1])*2}.");
                        Console.WriteLine($"Fuel added: {command[1]}.");
                        continue;
                        //
                    case "Titan":
                        Console.WriteLine($"You have reached Titan, all passengers are safe.");
                        break;
                        //
                }
            }
        }
    }
}
