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
                    //Console.WriteLine(string.Join(' ', input));
                }
                else if(command[0] == "divide")
                {
                    DivideList(input, int.Parse(command[1]), int.Parse(command[2]));
                   // Console.WriteLine(string.Join(' ', input));
                }
            }

            static List<string> MergeList(List<string> input, int startIndex, int endIndex)
            {
                string mergedString = string.Empty;
                bool isValid = false;
                for (int i = startIndex; i <= endIndex; i++)
                {
                    if (startIndex <= input.Count-1 && startIndex >= 0)
                    {
                        mergedString += (input[startIndex]);
                        input.RemoveAt(startIndex);
                        isValid = true;
                    }
                }
                if (isValid == true)
                {
                    input.Insert(startIndex, mergedString);
                }
               
                return input;
            }

            static List<string> DivideList(List<string> input, int index, int partitions)
            {
                List<string> dividedElement = new List<string>();
                for (int s = 0; s < partitions; s++)
                {
                    dividedElement.Add("");
                }
                int capacity = input[index].ToString().Length;
                string stringToDivide = input[index];
                int elementValues = capacity / partitions;
                int count = 0;
                for (int i = 0; i < partitions; i++)
                {
                    if (i < partitions - 1)
                    {
                        for (int k = 0 + count; k < elementValues + count; k++)
                        {
                            dividedElement[i] += stringToDivide[k].ToString();
                        }
                    }
                    else if (i == partitions - 1)
                    {
                        for (int k = 0 + count; k < input[index].Length; k++)
                        {
                            dividedElement[i] += stringToDivide[k].ToString(); ;
                        }
                    }
                    count += elementValues;
                    
                }
                input.RemoveAt(index);
                dividedElement.Reverse();
                foreach (var item in dividedElement)
                {
                    input.Insert(index, item);
                }
                return input;

            }
        }
    }
}
