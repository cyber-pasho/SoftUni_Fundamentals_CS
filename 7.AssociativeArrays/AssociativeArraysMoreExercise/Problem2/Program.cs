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
            //add contests and people// START
            while ((input = Console.ReadLine()) != "no more time")
            {
                var statement = input
                    .Split(" -> ")
                    .ToList();
                string nameUser = statement[0];
                string nameContest = statement[1];
                int points = int.Parse(statement[2]);
                if (!contests.Any(x=>x.Name == nameContest))
                {
                    Contest contest = new Contest(nameContest);
                    contest.Person.Add(nameUser, points);
                    contests.Add(contest);
                }
                else
                {
                    foreach (var contest in contests)
                    {
                        if (contest.Name == nameContest)
                        {
                            if (!contest.Person.ContainsKey(nameUser))
                            {
                                contest.Person.Add(nameUser, points);
                            }
                            else
                            {
                                if (contest.Person[nameUser] < points)
                                {
                                    contest.Person[nameUser] = points;
                                }
                            }
                        }
                    }
                }
            }
            //add contests and people// END
            //add people total points// START
            foreach (var contest in contests)
            {
                foreach (var person in contest.Person)
                {
                    if (!people.ContainsKey(person.Key))
                    {
                        people.Add(person.Key, person.Value);
                    }
                    else
                    {
                        people[person.Key] += person.Value;
                    }
                }
            }
            //add people total points// END
            // print // START
            foreach (var contest in contests)
            {
                Console.WriteLine($"{contest.Name}: {contest.Person.Count} participants");
                var sortedPeople = contest.Person
                    .OrderBy(p => p.Key)
                    .OrderByDescending(p => p.Value);
                int count = 0;
                foreach (var person in sortedPeople)
                {
                    count++;
                    Console.WriteLine($"{count}. {person.Key} <::> {person.Value}");
                }
            }
            Console.WriteLine("Individual standings:");
            var sortedPeopleTotal = people
                .OrderBy(p => p.Key)
                .OrderByDescending(p => p.Value);
            int count2 = 0;
            foreach (var person in sortedPeopleTotal)
            {
                count2++;
                Console.WriteLine($"{count2}. {person.Key} -> {person.Value}");
            }
            // print // END
        }
    }
    public class Contest
    {
        public Contest(string name)
        {
            Name = name;
            Person = new Dictionary<string, int>();
        }

        public string Name { get; set; }

        public Dictionary<string, int> Person { get; set; }
    }
}
