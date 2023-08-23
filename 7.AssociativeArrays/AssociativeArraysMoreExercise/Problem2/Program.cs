using System.Collections.Generic;
using System.Globalization;

namespace Problem2
{
    internal class Program
    {
        static void Main()
        {
            string input;
            Dictionary<string, int> people = new Dictionary<string, int>();
            List<Contest> contests = new List<Contest>();
            while ((input = Console.ReadLine()) != "no more time")
            {
                var statement = input
                    .Split(" -> ")
                    .ToList();
                string nameUser = statement[0];
                string nameContest = statement[1];
                int points = int.Parse(statement[2]);
                //
                if (!contests.Any(x=>x.Name == nameContest))
                {
                    contests.Add(new Contest(nameContest));  
                }
                
            }
        }
    }
    public class Contest
    {
        public Contest(string name)
        {
            Name = name;
            Person = new List<Dictionary<string, int>>();
        }

        public string Name { get; set; }

        public List<Dictionary<string, int>> Person { get; set; }
    }
}
