using System;
using System.Collections.Generic;
using System.Linq;

namespace Text_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> bannedWords = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();
            string text = Console.ReadLine();
            foreach (var item in bannedWords)
            {
                string strMask = string.Empty;
                for (int i = 0; i < item.Length; i++)
                {
                    strMask += "*";
                }
                text = text.Replace(item, strMask);
            }
            Console.WriteLine(text);
        }
    }
}
