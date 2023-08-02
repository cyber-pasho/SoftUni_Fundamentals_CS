namespace Problem4
{
    internal class Program
    {
        static void Main()
        {
            int numberOperations = int.Parse(Console.ReadLine());
            Dictionary<string, string> users = new Dictionary<string, string>();
            string licensePlateNumber = string.Empty;
            for (int i = 0; i < numberOperations; i++)
            {
                var input = Console.ReadLine()
                    .Split(" ")
                    .ToList();
                string command = input[0];
                string username = input[1];
                if (command != "unregister")
                {
                    licensePlateNumber = input[2];
                }
                Operation(command, username, licensePlateNumber, users);
            }
            foreach (var user in users)
            {
                Console.WriteLine($"{user.Key} => {user.Value}");
            }
        }
        public static void Operation (string command, string username, string licensePlateNumber, Dictionary<string, string> users)
        {

            if (command == "register")
            {
                if (!users.ContainsKey(username))
                {
                    users.Add(username, licensePlateNumber);
                    Console.WriteLine($"{username} registered {licensePlateNumber} successfully");
                }
                else
                {
                    Console.WriteLine($"ERROR: already registered with plate number {licensePlateNumber}");  
                }
            }
            else
            {
                if (!users.ContainsKey(username))
                {
                    Console.WriteLine($"ERROR: user {username} not found");
                }
                else
                {
                    users.Remove(username);
                    Console.WriteLine($"{username} unregistered successfully");
                }
                
            }
        }
    }
}