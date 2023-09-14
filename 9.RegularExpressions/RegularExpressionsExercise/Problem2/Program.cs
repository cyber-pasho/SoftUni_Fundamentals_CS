using System.Text.RegularExpressions;

namespace Problem2
{
    internal class Program
    {
        static void Main()
        {
            Dictionary <string, int> participantsLog = new Dictionary<string, int>();
            var participants = Console.ReadLine()
                .Split(", ")
                .ToList();
            foreach ( var participant in participants)
            {
                participantsLog.Add(participant, 0);
            }
            string patternName = @"[A-Za-z]+";
            string patternDistance = @"[0-9]";
            string input;
            while ((input = Console.ReadLine()) != "end of race")
            {
                Regex regexName = new Regex(patternName);
                Regex regexDistance = new Regex(patternDistance);
                MatchCollection matchesName = Regex.Matches(input, patternName);
                MatchCollection matchesDistance = Regex.Matches(input, patternDistance);
                string participantName = string.Join("", matchesName);
                int participantDistance = 0;
                foreach (Match match1 in matchesDistance)
                {
                    participantDistance += int.Parse(match1.Value);
                }
                if (participantsLog.ContainsKey(participantName))
                {
                    participantsLog[participantName] += participantDistance;
                }
            }
            var sortedDictionaryParticipants = participantsLog
                .OrderByDescending(p => p.Value);
            int counter = 0;
            foreach (var person in sortedDictionaryParticipants)
            {
                counter++;
                if (counter == 1)
                {
                    Console.WriteLine($"1st place: {person.Key}");
                }
                else if (counter == 2)
                {
                    Console.WriteLine($"2nd place: {person.Key}");
                }
                else if (counter == 3)
                {
                    Console.WriteLine($"3rd place: {person.Key}");
                }
                else
                {
                    break;
                }
            }
        }
    }
}