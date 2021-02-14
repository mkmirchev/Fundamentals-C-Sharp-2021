using System;
using System.Linq;
using System.Collections.Generic;

namespace MerginLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> secondList = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            List<int> output = new List<int>();
            if (firstList.Count <= secondList.Count)
            {
                for (int i = 0; i < firstList.Count; i++)
                {
                    output.Add(firstList[i]);
                    output.Add(secondList[i]);
                }
                if (firstList.Count <= secondList.Count)
                {
                    for (int i = firstList.Count; i < secondList.Count; i++)
                    {
                        output.Add(secondList[i]);
                    }
                }
             
            }
            else
            {
                for (int i = 0; i < secondList.Count; i++)
                {
                    output.Add(firstList[i]);
                    output.Add(secondList[i]);
                }
                for (int i = secondList.Count; i < firstList.Count; i++)
                {
                    output.Add(firstList[i]);
                }
            }
   
            Console.WriteLine(string.Join(' ', output));
        }
    }
}
