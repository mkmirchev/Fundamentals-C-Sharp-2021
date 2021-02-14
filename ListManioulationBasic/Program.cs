using System;
using System.Linq;
using System.Collections.Generic;

namespace ListManioulationBasic
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            while (true)
            {
                List<string> command = Console.ReadLine().Split(' ').ToList();
                if (command[0] == "end")
                {
                    Console.WriteLine(string.Join(' ', input));
                    break;
                }
                else if (command[0] == "Add")
                {
                    AddToList(input, int.Parse(command[1]));
                }
                else if (command[0] == "Remove")
                {
                    RemoveFromList(input, int.Parse(command[1]));
                }
                else if (command[0] == "RemoveAt")
                {
                    RemoveAt(input, int.Parse(command[1]));
                }
                else if (command[0] == "Insert")
                {
                   input = Insert(input, int.Parse(command[1]), int.Parse(command[2]));
                }
            }
        }

        private static List<int> AddToList(List<int> input, int valueToAdd)
        {
            input.Add(valueToAdd);
            return input;
        }

        private static List<int> RemoveFromList(List<int> input, int valueToRemove)
        {
            input.Remove(valueToRemove);
            return input;
        }

        private static List<int> RemoveAt(List<int> input, int valueIndex)
        {
            input.RemoveAt(valueIndex);
            return input;
        }

        private static List<int> Insert(List<int> input, int number, int valueIndex)
        {
            input.Insert(valueIndex, number);
            return input;
        }
    }
}
