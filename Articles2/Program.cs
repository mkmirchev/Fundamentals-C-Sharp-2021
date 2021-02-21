using System;
using System.Linq;
using System.Collections.Generic; 

namespace Articles2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Article> artList = new List<Article>();
            int a = int.Parse(Console.ReadLine());
            for (int i = 0; i < a; i++)
            {
                List<string> inputData = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();
                Article art = new Article(inputData[0], inputData[1], inputData[2]);
                artList.Add(art);
            }
            string filter = Console.ReadLine();
            //filter results
            if (filter == "content")
            {
                artList = artList.OrderBy(x => x.Content).ToList();
            }
            else if (filter == "title")
            {
                artList = artList.OrderBy(x => x.Title).ToList();
            }
            else if (filter == "author")
            {
                artList = artList.OrderBy(x => x.Author).ToList();
            }

            foreach (var item in artList)
            {
                Console.WriteLine(item.Title + " - " + item.Content + ": " + item.Author);
            }
        }
    }
    class Article
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
        public Article(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }
    }
}
