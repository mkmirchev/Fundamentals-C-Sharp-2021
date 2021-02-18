using System;
using System.Linq;
using System.Collections.Generic;

namespace AppendArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Trim(' ').Split('|', StringSplitOptions.RemoveEmptyEntries).ToList();
            input.Reverse();
            List<int> output = new List<int>();
            for (int i = 0; i < input.Count; i++)
            {
                List<int> temp = input[i].Trim(' ').Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
                foreach (var item in temp)
                {
                    output.Add(item);
                }
            }
            Console.WriteLine(string.Join(' ', output).ToString());
        }
    }
}
