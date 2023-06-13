using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Problem3
{
    internal class Problem3
    {
        static void Main(string[] args)
        {
            int itterations = int.Parse(Console.ReadLine());
            List<string> party = new List<string>();
            party.Add(" ");
            //
            for (int i = 0; i < itterations; i++)
            {
                string input = Console.ReadLine();
                List<string> inputs = input
                .Split(' ')
                .ToList();
                if (inputs.Count == 3)
                {
                    bool isTrue = false;
                    foreach (var name in party)
                    {
                        if (name != inputs[0])
                        {
                            isTrue = true;
                        }
                        else
                        {
                            Console.WriteLine($"{inputs[0]} is already in the list!");
                            isTrue= false;
                            break;
                        }
                    }
                    if (isTrue)
                    {
                        party.Add(inputs[0]);
                    }
                }
                else
                {
                    bool isHere = false;
                    for (int x = 0; x < party.Count; x++)
                    {
                        if (party[x] != inputs[0])
                        {
                            isHere = true;
                        }
                        else
                        {
                            party.Remove(inputs[0]);
                            isHere= false;
                            break;
                        }
                    }
                    if (isHere == true)
                    {
                        Console.WriteLine($"{inputs[0]} is not in the list!");
                    }
                }
            }
            for (int i = 1; i < party.Count; i++)
            {
                Console.WriteLine(party[i]);
            }
        }
    }
}
