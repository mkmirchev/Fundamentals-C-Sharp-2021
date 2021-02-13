using System;
using System.Collections.Generic;
using System.Linq;

namespace SumAdjacentEqualNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> input = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            while (true)
            {
                if (input.Count != ListManipulation(input).Count)
                {
                    ListManipulation(input);
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(string.Join(' ', input));
        }

        private static List<double> ListManipulation(List<double> a)
        {
            List<double> input = a;
            int lstCount = input.Count;
            int i = 0;
            while (i < lstCount - 1)
            {
                if (input[i] == input[i + 1])
                {
                    input[i] = input[i] + input[i + 1];
                    input.RemoveAt(i + 1);
                    lstCount = -1;
                }
                else
                {
                    i++;
                }
            }
            return input;
        }
    }
}
