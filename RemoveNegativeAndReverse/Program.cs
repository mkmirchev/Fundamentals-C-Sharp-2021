using System;
using System.Collections.Generic;
using System.Linq;

namespace RemoveNegativeAndReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> input = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            for (int i = 0; i < input.Count; i++)
            {
                if (input[i] < 0)
                {
                    input.RemoveAt(i);
                    i--;
                }
            }
            if (input.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                input.Reverse();
                Console.WriteLine(string.Join(' ', input)) ;
            }
        }
    }
}
