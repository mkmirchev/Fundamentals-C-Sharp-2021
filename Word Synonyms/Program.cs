using System;
using System.Linq;
using System.Collections.Generic;

namespace Word_Synonyms
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> input = new Dictionary<string, List<string>>();
            int words = int.Parse(Console.ReadLine());
            for (int i = 0; i < words; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();
                if (input.ContainsKey(word) == false)
                {
                    input.Add(word, new List<string>());
                    input[word].Add(synonym);
                }
                else
                {
                    input[word].Add(synonym);
                }
            }
            foreach (var word in input)
            {
                Console.WriteLine($"{word.Key} - {string.Join(", ", word.Value)}");
            }
        }
    }
}
