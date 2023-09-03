namespace Problem3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> players = new Dictionary<string, Dictionary<string, int>>();
            string input;

            while ((input = Console.ReadLine()) != "Season end")
            {
                var statement = input
                    .Split(new string[] { " -> ", " vs " }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
                if (statement.Count < 3)
                {
                    string dueler1 = statement[0];
                    string dueler2 = statement[1];

                    if (players.ContainsKey(dueler1) && players.ContainsKey(dueler2))
                    {
                        foreach (var pos1 in players[dueler1])
                        {
                            foreach (var pos2 in players[dueler2])
                            {
                                if (pos1.Key == pos2.Key)
                                {
                                    int player1TotalPoints = players[dueler1].Values.Sum();
                                    int player2TotalPoints = players[dueler2].Values.Sum();
                                    if (player1TotalPoints > player2TotalPoints)
                                    {
                                        players.Remove(dueler2);
                                    }
                                    else if (player2TotalPoints > player1TotalPoints)
                                    {
                                        players.Remove(dueler1);
                                    }
                                }
                            }
                        }
                    }
                }
                else
                {
                    string playerName = statement[0];
                    string playerPosition = statement[1];
                    int skill = int.Parse(statement[2]);

                    if (!players.ContainsKey(playerName))
                    {
                        players.Add(playerName, new Dictionary<string, int>());
                        players[playerName].Add(playerPosition, skill);
                    }
                    else
                    {
                        if (!players[playerName].ContainsKey(playerPosition))
                        {
                            players[playerName].Add(playerPosition, skill);
                        }
                        else
                        {
                            if (players[playerName][playerPosition] < skill)
                            {
                                players[playerName][playerPosition] = skill;
                            }
                        }
                    }
                }
            }
            //PRINTS
            int playerTotalPoints = 0;
            Dictionary<int, string> bestPlayers = new Dictionary<int, string>();
            foreach (var player in players)
            {
                playerTotalPoints = player.Value
                    .Values
                    .Sum();
                bestPlayers.Add(playerTotalPoints, player.Key);
            }
            var sortedPlayers = bestPlayers
                .OrderBy(p => p.Value)
                .OrderByDescending(p => p.Key);

            foreach (var sortedPlayer in sortedPlayers)
            {
                Console.WriteLine($"{sortedPlayer.Value}: {sortedPlayer.Key} skill");
                foreach (var player in players)
                {
                    if (player.Key == sortedPlayer.Value)
                    {
                       var sortedPositions = player.Value
                           .OrderBy(p => p.Key)
                           .OrderByDescending(p => p.Value);
                       foreach (var sortedPosition in sortedPositions)
                       {
                           Console.WriteLine($"- {sortedPosition.Key} <::> {sortedPosition.Value}");
                       }
                    }
                }
            }
        }
    }
}