using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Library
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string shelf = Console.ReadLine();
            List<string> books = shelf
                .Split('&')
                .ToList();
            bool isBookPresent = false;
            bool isBookPresent1 = false;
            int index1 = 0;
            int index2 = 0;
                List<string> command = Console.ReadLine()
                .Split(new string[] { " | " }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();
                //
                while (command[0] != "Done")
                {
                    switch (command[0])
                    {
                        case "Add Book":
                            isBookPresent = books.Contains(command[1]);
                            if (isBookPresent == false)
                            {
                                books.Insert(0, command[1]);
                                break;
                            }
                            break;
                            //
                        case "Take Book":
                            isBookPresent = books.Contains(command[1]);
                            if (isBookPresent)
                            {
                                books.Remove(command[1]);
                                break;
                            }
                            break;
                        //
                        case "Swap Books":
                            for (int j = 0; j < books.Count; j++)
                            {
                                if (books[j] == command[1])
                                {
                                    isBookPresent = true;
                                    index1 = j;
                                }
                                if (books[j] == command[2])
                                {
                                    isBookPresent1 = true;
                                    index2 = j;
                                }
                            }
                            if (isBookPresent && isBookPresent1)
                            {
                                string temp = books[index1];
                                books[index1] = books[index2];
                                books[index2] = temp;
                            }
                            break;
                        //
                        case "Insert Book":
                            isBookPresent = books.Contains(command[1]);
                            if (isBookPresent == false)
                            {
                                books.Add(command[1]);
                                break;
                            }
                            break;
                        case "Check Book":
                            if (int.Parse(command[1]) <= books.Count-1 && int.Parse(command[1]) >= 0)
                            {
                                Console.WriteLine($"{books[int.Parse(command[1])]}");
                                break;
                            }
                            break;
                    }
                        command = Console.ReadLine()
                            .Split(new string[] { " | " }, StringSplitOptions.RemoveEmptyEntries)
                            .ToList();
                }
            Console.WriteLine(string.Join(", ", books));
        }
    }
}
