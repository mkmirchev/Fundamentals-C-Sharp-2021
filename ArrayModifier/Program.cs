using System;
using System.Collections.Generic;
using System.Linq;

namespace ArrayModifier
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> inputArray = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            while (true)
            {
                List<string> command = Console.ReadLine().Split(' ').ToList();
                if (command[0] == "end")
                {
                    Console.WriteLine(string.Join(", ", inputArray));
                    break;
                }
                if (command[0] == "swap")
                {
                    SwapArr(inputArray, int.Parse(command[1]), int.Parse(command[2]));
                }
                if (command[0] == "multiply")
                {
                    MultiplyElement(inputArray, int.Parse(command[1]), int.Parse(command[2]));
                }
                if (command[0] == "decrease")
                {
                    DecreaseAll(inputArray);
                }
            }

           
        }
        static void SwapArr(List<int> input, int first, int second)
        {
            int temp = input[first];
            input[first] = input[second];
            input[second] = temp;
        }
        static void MultiplyElement(List<int> input, int first, int second)
        {
            input[first] = input[first] * input[second];
        }
        static void DecreaseAll(List<int> input)
        {
            for (int i = 0; i < input.Count; i++)
            {
                input[i] -= 1;
            }
        }
    }
}
