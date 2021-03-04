using System;
using System.Collections.Generic;
using System.Linq;

namespace ExamNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> inputList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> topIntegers = new List<int>();
            if (inputList.Count == 1)
            {
                Console.WriteLine("No");
            }
            else
            {
                double avg = inputList.Average();
                for (int i = 1; i < 6; i++)
                {
                    int currentMax = GetTopElementIndex(inputList);
                    if ((double)inputList[currentMax] > avg)
                    {
                        topIntegers.Add(inputList[currentMax]);
                        inputList.RemoveAt(currentMax);
                    }
                    else
                    {
                        continue;
                    }
                }
                List<int> output = topIntegers.OrderByDescending(x=>x).ToList();
                Console.WriteLine(string.Join(' ',output));
            }
        }
        static int GetTopElementIndex(List<int> input)
        {
            int a = int.MinValue;
            int maxIntIndex = -1;
            for (int i = 0; i < input.Count; i++)
            {
                if (input[i] > a)
                {
                    a = input[i];
                    maxIntIndex = i;

                }
            }
            return maxIntIndex;
        }
    }
}
