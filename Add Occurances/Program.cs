using System;
using System.Linq;
using System.Collections.Generic;

namespace Add_Occurances
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(' ').ToList();
            Dictionary<string, int> inputDictionary = new Dictionary<string, int>();
            foreach (var item in input)
            {
                if (inputDictionary.ContainsKey(item.ToLower()))
                {
                    inputDictionary[item.ToLower()]++;
                }
                else
                {
                    inputDictionary.Add(item.ToLower(), 1);
                }
            }
            Dictionary<string, int> output = new Dictionary<string, int>();
            foreach (var item in inputDictionary)
            {
                if (item.Value % 2 == 1)
                {
                    output.Add(item.Key, item.Value);
                }
            }
            Console.WriteLine(string.Join(' ', output.Select(x=>x.Key)));
        }
    }
}
