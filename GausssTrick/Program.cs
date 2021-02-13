using System;
using System.Collections.Generic;
using System.Linq;

namespace GausssTrick
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            int halfList = input.Count / 2;
            int lastIndex = input.Count-1;
            for (int i = 0; i < halfList; i++)
            {
                input[i] = input[i] + input[lastIndex];
                if (lastIndex >= halfList)
                {
                    input.RemoveAt(lastIndex);
                    lastIndex--;  
                }
                           
            }
            Console.WriteLine(string.Join(' ', input));
        }
    }
}
