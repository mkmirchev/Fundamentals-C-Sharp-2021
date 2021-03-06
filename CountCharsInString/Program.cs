using System;
using System.Linq;
using System.Collections.Generic;

namespace CountCharsInString
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(' ').ToList();
            Dictionary<char, int> charCounter = new Dictionary<char, int>();
            foreach (string str in input)
            {
                foreach (char ch in str)
                {
                    if (!charCounter.ContainsKey(ch))
                    {
                        charCounter.Add(ch, 1);
                    }
                    else
                    {
                        charCounter[ch]++;
                    }
                }
            }
            foreach (var pair in charCounter)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }
    }
}
