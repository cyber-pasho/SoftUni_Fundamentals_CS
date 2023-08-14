using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Problem5
{
    internal class Program
    {
        static void Main()
        {
            Dictionary<string, List<string>> companies = new Dictionary<string, List<string>>();
            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] inputs = input
                    .Split(" -> ");
                List<string> employees = new List<string>();
                string companyName = inputs[0];
                string employeeID = inputs[1];
                if (!companies.ContainsKey(companyName))
                {
                    employees.Add(employeeID);
                    companies.Add(companyName, employees);
                }
                else
                {
                    foreach (var item in companies)
                    {
                        if (item.Key == companyName && !item.Value.Contains(employeeID))
                        {
                            item.Value.Add(employeeID);
                        }
                    }
                }
            }
            foreach (var item in companies)
            {
                Console.WriteLine($"{item.Key}");
                foreach (var id in item.Value)
                {
                    Console.WriteLine($"-- {id}");
                }
            }
        }
    }
}