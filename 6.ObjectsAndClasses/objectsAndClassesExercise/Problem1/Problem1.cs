using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Problem1
{
    internal class Problem1
    {
        static void Main(string[] args)
        {
            var phrases = "Excellent product./Such a great product./I always use that product./Best product of its category./Exceptional product./I can't live without this product."
                .Split('/')
                .ToArray();
            var events = "Now I feel good./I have succeeded with this product./Makes miracles. I am happy of the results!/I cannot believe but now I feel awesome./Try it yourself, I am very satisfied./I feel great!"
                .Split('/')
                .ToArray();
            var authors = "Diana/Petya/Stella/Elena/Katya/Iva/Annie/Eva"
                .Split('/')
                .ToArray();
            var cities = "Burgas/Sofia/Plovdiv/Varna/Ruse"
                .Split('/')
                .ToArray();
            //
            int input = int.Parse(Console.ReadLine());
            //
            Random random= new Random();
            //
            for (int i = 1; i <= input; i++)
            {
                int index1 = random.Next(phrases.Length);
                int index2 = random.Next(events.Length);
                int index3 = random.Next(authors.Length);
                int index4 = random.Next(cities.Length);
                Console.WriteLine($"{phrases[index1]} {events[index2]} {authors[index3]} – {cities[index4]}.");
            }
        }
    }
}

    

﻿