using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4
{
    internal class Problem4
    {
        static void Main(string[] args)
        {
            bool isValid = true;
            string password = Console.ReadLine();
            bool passLenght = PasswordLenght(password);
            bool passContains = PasswordContainsLimits(password);
            bool passDigits = PasswordMinimumDigits(password);
            //
            if (isValid == true && passLenght == true && passContains == true && passDigits == true)
            {
                Console.WriteLine("Password is valid");
                return;
            }
            if (passLenght == false)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if (passContains == false)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (passDigits == false)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
        }
        static bool PasswordLenght(string password)
        {
            if (password.Length >= 6 && password.Length <= 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static bool PasswordContainsLimits(string password) 
        {
            foreach (char c in password)
            {
                int charPassword = (int)c;
                if (charPassword > 47 && charPassword < 58 || charPassword > 64 && charPassword < 91 || charPassword > 96 && charPassword < 123)
                {
                    continue;
                }
                return false;
            }
            return true;
        }  
        static bool PasswordMinimumDigits(string password) 
        {
            int counter = 0;
            foreach (char c in password)
            {
                int charPassword = (int)c;
                if (charPassword > 47 && charPassword < 58)
                {
                    counter++;
                }
            }
            if (counter >= 2)
            {
                return true;
            }
            return false;
        }
    }
}
