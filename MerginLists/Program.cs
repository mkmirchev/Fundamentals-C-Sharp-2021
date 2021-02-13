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
            int newListLenght = firstList.Count + secondList.Count;
            int shorterList;
            if (firstList.Count > secondList.Count)
            {
                shorterList = secondList.Count;
            }
            else
            {
                shorterList = firstList.Count;
            }

            List<int> output = new List<int>(newListLenght);
            int count = 0;
            for (int i = 0; i <= shorterList; i++)
            {
                    output[i] = firstList[count];
                    output[i + 1] = secondList[count];
                    count++;             
            }
            for (int j = shorterList; j <= newListLenght; j++)
            {
                if (firstList.Count==shorterList)
                {
                    output[j] = secondList[j];
                }
                else
                {
                    output[j] =firstList[j];
                }
            }
            Console.WriteLine(string.Join(' ', output));
        }
    }
}
