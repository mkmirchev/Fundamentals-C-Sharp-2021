using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            //reading input
            List<int> input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries)
                                .Select(int.Parse)
                                .ToList();

            //reading commands
            while (true)
            {
                List<string> commands = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();

                //end the program condition
                if (commands[0] == "Mort")
                {
                    Console.WriteLine(string.Join(' ', input));
                    break;
                }

                if (commands[0] == "Add")
                {
                    AddElements(input, int.Parse(commands[1]));
                }
                if (commands[0] == "Remove")
                {
                    RemoveElements(input, int.Parse(commands[1]));
                }
                if (commands[0] == "Replace")
                {
                    ReplaceElements(input, int.Parse(commands[1]), int.Parse(commands[2]));
                }
                if (commands[0] == "Collapse")
                {
                    input = CollapseElements(input, int.Parse(commands[1]));
                }
            }

            static List<int> AddElements(List<int> input, int elementToAdd)
            {
                input.Add(elementToAdd);
                return input;
            }

            static List<int> RemoveElements(List<int> input, int elementToRemove)
            {
                for (int i = 0; i < input.Count; i++)
                {
                    if (input[i] == elementToRemove)
                    {
                        input.RemoveAt(i);
                        break;
                    }
                }
                return input;
            }

            static List<int> ReplaceElements(List<int> input, int elementToReplace, int newElement)
            {
                for (int i = 0; i < input.Count; i++)
                {
                    if (input[i] == elementToReplace)
                    {
                        input[i] = newElement;
                        break;
                    }
                }
                return input;
            }

            static List<int> CollapseElements(List<int> input, int elementsToCollapse)
            {
                for (int i = 0; i < input.Count; i++)
                {
                    if (input[i] < elementsToCollapse)
                    {
                        input[i] = 2000;
                    }
                }
                List<int> output = new List<int>();
                foreach (var item in input)
                {
                    if (item <= 1000)
                    {
                        output.Add(item);
                    }
                }
                return output;
            }
        }
    }
}
