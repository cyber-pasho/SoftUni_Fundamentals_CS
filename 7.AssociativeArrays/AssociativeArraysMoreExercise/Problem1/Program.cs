namespace Problem1
{
    internal class Program
    {
        static void Main()
        {
            List<Contest> contests = new List<Contest>();
            Dictionary<string, int> usersTotalPoints = new Dictionary<string, int>();
            string input1;
            string contestName;
            string contestPassword;
            while ((input1 = Console.ReadLine()) != "end of contests")
            {
                var contestInput = input1
                    .Split(":")
                    .ToArray();
                contestName = contestInput[0];
                contestPassword = contestInput[1];
                Contest contest = new Contest(contestName, contestPassword);
                contests.Add(contest);
            }
            string input2;
            string username;
            int points = 0;
            while ((input2 = Console.ReadLine()) != "end of submissions")
            {
                var submissionsInput = input2
                    .Split("=>")
                    .ToArray();
                contestName = submissionsInput[0];
                contestPassword = submissionsInput[1];
                username = submissionsInput[2];
                points = int.Parse(submissionsInput[3]);
                for (int i = 0; i < contests.Count; i++)
                {
                    if (contests[i].Name == contestName && contests[i].Password == contestPassword)
                    {
                        bool isValid = true;
                        if (!contests[i].Users.ContainsKey(username))
                        {
                            contests[i].Users.Add(username, points);
                        }
                        else
                        {
                            if (contests[i].Users[username] < points)
                            {
                                contests[i].Users[username] = points;
                            }
                            else
                            {
                                isValid = false;
                            }
                        }
                    }
                }
            }
            for (int x = 0; x < contests.Count; x++)
            {
                foreach (var user in contests[x].Users)
                {
                    if (!usersTotalPoints.ContainsKey(user.Key))
                    {
                        usersTotalPoints.Add(user.Key, user.Value);
                    }
                    else
                    {
                        usersTotalPoints[user.Key] += user.Value;
                    }
                }
            }
            var elementWithMaxValue = usersTotalPoints.OrderByDescending(x => x.Value).FirstOrDefault();
            var orderedContestants = usersTotalPoints.OrderBy(c => c.Key);

            Console.WriteLine($"Best candidate is {elementWithMaxValue.Key} with total {elementWithMaxValue.Value} points.");
            Console.WriteLine("Ranking: ");
            foreach (var contestant in orderedContestants)
            {
                Console.WriteLine(contestant.Key);
                var contestPoints = new Dictionary<string, int>();
                foreach (var contest in contests)
                {
                    if (contest.Users.ContainsKey(contestant.Key))
                    {
                        contestPoints.Add(contest.Name, contest.Users[contestant.Key]);
                    }
                }
                var orderedPoints = contestPoints
                    .OrderByDescending(x=>x.Value);
                foreach (var item in orderedPoints)
                {
                    Console.WriteLine($"#  {item.Key} -> {item.Value}");
                }
            }

        }
    }
    public class Contest
    {
        public Contest(string name, string password)
        {
            Name = name;
            Password = password;
            Users = new Dictionary<string, int>();
        }

        public string Name { get; set; }
        public string Password { get; set; }
        public Dictionary<string, int> Users { get; set; }
    }
}