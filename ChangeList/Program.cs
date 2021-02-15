using System;
using System.Linq;
using System.Collections.Generic;

namespace ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            while (true)
            {
                List<string> command = Console.ReadLine().Split(' ').ToList();
                if (command.Contains("end"))
                {
                    Console.WriteLine(string.Join(' ', input));
                    break;
                }
                if (command.Contains("Delete"))
                {
                    DeleteItems(input, int.Parse(command[1]));
                }
                else if (command.Contains("Insert"))
                {
                    InsertItem(input, int.Parse(command[1]), int.Parse(command[2]));
                }
            }
        }


        public static List<int> DeleteItems(List<int> input, int number)
        {
            int lenght = input.Count;
            for (int i = 0; i < lenght; i++)
            {
                if (input[i] == number)
                {
                    input.RemoveAt(i);
                    lenght--;
                }
            }
            return input;
        }

        public static List<int> InsertItem(List<int> input, int number, int index)
        {
            input.Insert(index, number);
            return input;
        }
    }
}
