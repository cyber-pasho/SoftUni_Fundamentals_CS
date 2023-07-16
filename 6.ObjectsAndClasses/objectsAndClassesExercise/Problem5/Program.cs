using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem5
{
    internal class Program
    {
        static void Main()
        {
            int teamsCount = int.Parse(Console.ReadLine());
            List<Team> teams = new List<Team>();
            List<Team> disbandedTeams= new List<Team>();
            for (int i = 1; i <= teamsCount; i++)
            {
                var teamsCreation = Console.ReadLine()
                    .Split('-')
                    .ToArray();
                string creator = teamsCreation[0];
                string name = teamsCreation[1];
                bool existing = false;
                bool creatorClone = false;
                //Rule 1,2
                foreach (var item in teams)
                {
                    if (item.Name == name)
                    {
                        Console.WriteLine($"Team {name} was already created!");
                        existing = true;
                    }
                    if (item.Creator == creator)
                    {
                        Console.WriteLine($"{creator} cannot create another team!");
                        creatorClone = true;
                    }
                }
                if (existing)
                {
                    continue;
                }
                if (creatorClone)
                {
                    continue;
                }
                //Rule 1,2
                Team team = new Team(creator, name);
                teams.Add(team);
                Console.WriteLine($"Team {name} has been created by {creator}!");
            }
            var membersApplication = Console.ReadLine()
                    .Split(new string[] { "->" }, StringSplitOptions.None)
                    .ToArray();
            while (membersApplication[0] != "end of assignment")
            {
                string member = membersApplication[0];
                string teamName = membersApplication[1];
                bool teamFalse = false;
                bool memberClone = false;
                int falseCounter = 0;
                //Rule 3,4
                foreach (var item in teams)
                {
                    if (item.Member.Count == 0)
                    {
                        foreach (var creator in teams)
                        {
                            if (creator.Creator == member)
                            {
                                Console.WriteLine($"Member {member} cannot join team {teamName}!");
                                memberClone = true;
                                teamFalse = false;
                            }
                        }
                    }
                    if (teamName == item.Name)
                    {
                        teamFalse = false;
                        foreach (var person in item.Member)
                        {
                            if (person == member)
                            {
                                Console.WriteLine($"Member {member} cannot join team {teamName}!");
                                memberClone = true;
                            }
                        }
                        falseCounter++;
                    }
                    else
                    {
                        if (falseCounter > 0)
                        {
                            continue;
                        }
                        teamFalse = true;
                    }
                }
                if (teamFalse)
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                    membersApplication = Console.ReadLine()
                    .Split(new string[] { "->" }, StringSplitOptions.None)
                    .ToArray();
                    continue;
                }
                if (memberClone)
                {
                    membersApplication = Console.ReadLine()
                    .Split(new string[] { "->" }, StringSplitOptions.None)
                    .ToArray();
                    continue;
                }
                //Rule 3,4
                foreach (var item in teams)
                {
                    if (item.Name == teamName)
                    {
                        item.Member.Add(member);
                    }
                }
                membersApplication = Console.ReadLine()
                    .Split(new string[] { "->" }, StringSplitOptions.None)
                    .ToArray();
            }
            for (int i = teams.Count-1; i >= 0; i--)
            {
                var team = teams[i];
                if (team.Member.Count == 0)
                {
                    teams.RemoveAt(i);
                    disbandedTeams.Add(team);
                }
            }
            List<Team> sortedTeams = teams
                .OrderByDescending(t => t.Member.Count)
                .ThenBy(t => t.Name)
                .ToList()
                ;
            List<Team> sortedDisbanded = disbandedTeams
                .OrderBy(d => d.Name)
                .ToList()
                ;
            foreach (var team in sortedTeams)
            {
                team.Member.Sort();
            }
            foreach (var team in sortedTeams)
            {
                Console.WriteLine(team.Name);
                Console.WriteLine($"- {team.Creator}");
                foreach (var member in team.Member)
                {
                    Console.WriteLine($"-- {member}");
                }
            }
            Console.WriteLine("Teams to disband:");
            foreach (var team in sortedDisbanded)
            {
                Console.WriteLine(team.Name);
            }
        }
    }
    public class Team
    {
        public Team(string creator, string name)
        {
            Creator = creator;
            Name = name;
            Member = new List<string>();
        }

        public string Creator { get; set; }
        public List<string> Member { get; set; }
        public string Name { get; set; }
    }
}
