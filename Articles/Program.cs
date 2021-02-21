using System;
using System.Linq;
using System.Collections.Generic;

namespace Articles
{
    class Program
    {
        static void Main(string[] args)
        {
           
            
            List<string> inputData = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();
            Article art = new Article (inputData[0], inputData[1], inputData[2]);
            
            int numberOfCommands = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfCommands; i++)
            {
                List<string> command = Console.ReadLine().Split(": ").ToList();
                string msg = command[1];
                msg.Trim(' ');
                if (command[0] == "Edit")
                {
                    art.Content = msg;
                }
                else if (command[0] == "ChangeAuthor")
                {
                    art.Author = msg;
                }
                else if (command[0] == "Rename")
                {
                    art.Title = msg;
                }
            }
            Console.WriteLine(art.Title + " - " + art.Content + ": "+ art.Author);

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
