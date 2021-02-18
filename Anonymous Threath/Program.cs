using System;
using System.Collections.Generic;
using System.Linq;

namespace Anonymous_Threath
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();
            while (true)
            {
                List<string> command = Console.ReadLine().Split(' ').ToList();
                if (command[0] == "3:1")
                {
                    Console.WriteLine(string.Join(' ', input));
                    break;
                }
                if (command[0] == "merge")
                {
                    MergeList(input, int.Parse(command[1]), int.Parse(command[2]));
                }
                else if(command[0] == "divide")
                {

                }
            }

            static List<string> MergeList(List<string> input, int startIndex, int endIndex)
            {
                string mergedString = string.Empty;
                for (int i = startIndex; i < endIndex; i++)
                {
                    if (i < input.Count)
                    {
                        mergedString += (input[startIndex]);
                        input.RemoveAt(startIndex);
                    }
                }
                input.Insert(startIndex, mergedString);
                return input;
            }

            static List<string> DivideList(List<string> input, int index, int partitions)
            {
                List<string> dividedElement = new List<string>(partitions);
                int capacity = input[index].ToString().Length;
                string stringToDivide = input[index];
                int elementValues = capacity / partitions;
                for (int i = 0; i < partitions; i++)
                {
                    for (int i = 0; i < elementValues; i++)
                    {

                    }
                    dividedElement.Add(string.Concat(ch));
                }
                input.RemoveAt(index);
                foreach (var item in dividedElement)
                {
                    input.Insert(index, item);
                }
                return input;
            }
        }
    }
}
