using System;
using System.Linq;
using System.Collections.Generic;

namespace ListOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<string> commands = new List<string>(3);
            while (true)
            {
                commands = Console.ReadLine().Split(' ').ToList();
                if (commands.Contains("End"))
                {
                    Console.WriteLine(string.Join(' ', input));
                    break;
                }
                if (commands.Contains("Add"))
                {
                    AddToLst(input, int.Parse(commands[1]));
                }
                else if (commands.Contains("Insert"))
                {
                    if (int.Parse(commands[2]) < input.Count && int.Parse(commands[2]) >= 0)
                    {
                        InsertToLst(input, int.Parse(commands[1]), int.Parse(commands[2]));
                    }
                    else if (int.Parse(commands[2]) >= input.Count || int.Parse(commands[2]) < 0)
                    {
                        Console.WriteLine("Invalid index");
                    }
                }
                else if (commands.Contains("Remove"))
                {
                    if (int.Parse(commands[1]) < input.Count && int.Parse(commands[1]) >= 0)
                    {
                        RemoveToLst(input, int.Parse(commands[1]));
                    }
                    else if (int.Parse(commands[1]) >= input.Count || int.Parse(commands[1]) < 0)
                    {
                        Console.WriteLine("Invalid index");
                    }
                }
                else if (commands.Contains("Shift"))
                {
                    LstShift(input, commands[1], int.Parse(commands[2]));  
                }
            }
        }

        static List<int> AddToLst(List<int> input, int number)
        {
            input.Add(number);
            return input;
        }

        static List<int> InsertToLst(List<int> input, int number, int index)
        {
            input.Insert(index, number);
            return input;
        }
        static List<int> RemoveToLst(List<int> input, int index)
        {
            input.RemoveAt(index);
            return input; 
        }

        static List<int> LstShift(List<int> input, string shiftWay, int count)
        {
            if (shiftWay == "left")
            {
                for (int i = 0; i < count; i++)
                {
                    input.Add(input[0]);
                    input.RemoveAt(0);
                }
            }
            else if (shiftWay =="right")
            {
                for (int i = 0; i < count; i++)
                {
                    input.Insert(0, input[input.Count - 1]);
                    input.RemoveAt(input.Count - 1);
                }
            }
            return input;
        }
    }
}
