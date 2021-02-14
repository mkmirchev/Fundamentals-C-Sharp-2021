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
            bool isBasicManipulation = false;
            while (true)
            {
                List<string> command = Console.ReadLine().Split(' ').ToList();
                
                //Basic manipulation
                if (command[0] == "end")
                {
                    if (isBasicManipulation == true)
                    {
                         Console.WriteLine(string.Join(' ', input));
                         break;
                    }
                    else
                    {
                        break;
                    }
                   
                }
                else if (command[0] == "Add")
                {
                    AddToList(input, int.Parse(command[1]));
                    isBasicManipulation = true;
                }
                else if (command[0] == "Remove")
                {
                    RemoveFromList(input, int.Parse(command[1]));
                    isBasicManipulation = true;
                }
                else if (command[0] == "RemoveAt")
                {
                    RemoveAt(input, int.Parse(command[1]));
                    isBasicManipulation = true;
                }
                else if (command[0] == "Insert")
                {
                    input = Insert(input, int.Parse(command[1]), int.Parse(command[2]));
                    isBasicManipulation = true;
                }

                //Advanced manipulation
                if (command[0] == "Contains")
                {
                    Cont(input, int.Parse(command[1]));
                }
                else if (command[0] == "PrintEven")
                {
                    PrintEven(input);
                }
                else if (command[0] == "PrintOdd")
                {
                    PrintOdd(input);
                }
                else if (command[0] == "GetSum")
                {
                    GetSum(input);
                }
                else if (command[0] == "Filter")
                {
                    FilterList(input, command[1], int.Parse(command[2]));
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

        private static void Cont(List<int> input, int number)
        {
            if (input.Contains(number))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No such number");
            }
        }

        private static void PrintEven(List<int> input)
        {
            for (int i = 0; i < input.Count; i++)
            {
                if (input[i] % 2 == 0)
                {
                    Console.Write(input[i] + " ");
                }
            }
            Console.WriteLine();
        }

        private static void PrintOdd(List<int> input)
        {
            for (int i = 0; i < input.Count; i++)
            {
                if (input[i] % 2 == 1)
                {
                    Console.Write(input[i] + " ");
                }
            }
            Console.WriteLine();
        }

        private static void GetSum(List<int> input)
        {
            int output = 0;
            for (int i = 0; i < input.Count; i++)
            {
                output += input[i];
            }
            Console.WriteLine(output);
        }

        private static void FilterList(List<int> input, string filter, int number)
        {
            List<int> output = new List<int>();
            if (filter == "<")
            {
                foreach (var item in input)
                {
                    if (item < number)
                    {
                        output.Add(item);
                    }
                }
                Console.WriteLine(string.Join(' ', output));
            }
            else if (filter == ">")
            {
                foreach (var item in input)
                {
                    if (item > number)
                    {
                        output.Add(item);
                    }
                }
                Console.WriteLine(string.Join(' ', output));
            }
            else if (filter == "<=")
            {
                foreach (var item in input)
                {
                    if (item <= number)
                    {
                        output.Add(item);
                    }
                }
                Console.WriteLine(string.Join(' ', output));
            }
            else if (filter == ">=")
            {
                foreach (var item in input)
                {
                    if (item >= number)
                    {
                        output.Add(item);
                    }
                }
                Console.WriteLine(string.Join(' ', output));
            }

        }
        
    }
}
