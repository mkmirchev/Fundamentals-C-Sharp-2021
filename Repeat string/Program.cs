using System;
using System.Collections.Generic;
using System.Linq;

namespace Repeat_string
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ').ToArray();
            for (int i = 0; i < input.Count(); i++)
            {
                for (int k = 0; k < input[i].Length; k++)
                {
                    Console.Write(input[i]);
                }
            }
        }
    }
}
