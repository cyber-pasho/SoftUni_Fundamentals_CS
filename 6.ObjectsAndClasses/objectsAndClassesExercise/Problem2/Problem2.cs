using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    internal class Problem2
    {
        static void Main(string[] args)
        {
            var input1 = Console.ReadLine()
                .Split(new string[] { ", " }, StringSplitOptions.None)
                .ToArray();
            Article article = new Article(input1[0], input1[1], input1[2]);
            int commandsCount = int.Parse(Console.ReadLine());
            for (int i = 1; i <= commandsCount; i++)
            {
                var input2 = Console.ReadLine()
                .Split(new string[] { ": " }, StringSplitOptions.None)
                .ToArray();
                switch (input2[0])
                {
                    case "Edit":
                        string newContent = input2[1];
                        article.Edit(newContent);
                        break;
                    case "ChangeAuthor":
                        string newAuthor = input2[1];
                        article.ChangeAuthor(newAuthor);
                        break;
                    case "Rename":
                        string newTitle = input2[1];
                        article.Rename(newTitle);
                        break;
                }
            }
            Console.WriteLine(article.ToString());
        }
    }
    public class Article
    {
        public Article(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }

        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
        public void Edit(string newContent)
        {
            Content = newContent;
        }
        public void ChangeAuthor(string newAuthor)
        {
            Author = newAuthor;
        }
        public void Rename(string newTitle)
        {
            Title = newTitle;
        }
        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
}
