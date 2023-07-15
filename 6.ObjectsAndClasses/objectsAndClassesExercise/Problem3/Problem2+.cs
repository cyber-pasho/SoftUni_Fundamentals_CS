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
            int commandsCount = int.Parse(Console.ReadLine());
            List<Article> articles = new List<Article>();
            for (int i = 1; i <= commandsCount; i++)
            {
                var input1 = Console.ReadLine()
                .Split(new string[] { ", " }, StringSplitOptions.None)
                .ToArray();
                Article article = new Article(input1[0], input1[1], input1[2]);
                articles.Add(article);
            }
            foreach (var article in articles)
            {
                Console.WriteLine(article.ToString());
            }
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
        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
}
