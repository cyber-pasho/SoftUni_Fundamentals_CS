using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem5
{
    internal class Problem5
    {
        static void Main(string[] args)
        {
            var username = Console.ReadLine();
            var passwordInput = Console.ReadLine();
            char[] password = username.ToCharArray();
            Array.Reverse(password);
            string passwordValid = new string(password);
            //
            var isValid = false;
            var counter = 1;
            //
            while (isValid != true)
            {
                if (passwordInput == passwordValid)
                {
                    Console.WriteLine($"User {username} logged in.");
                    break;
                }
                else
                {
                    if (counter >= 4)
                    {
                        isValid = true;
                        break;
                    }
                    Console.WriteLine($"Incorrect password. Try again.");
                    counter++;
                }
                passwordInput = Console.ReadLine();
            }
            if (isValid == true)
            {
                Console.WriteLine($"User {username} blocked!");
            }

        }
    }
}
