using System;
using System.Linq;

namespace ReverseArrayOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            foreach (var item in input.Reverse())
            {
                Console.Write(item + " ");
            }
        }
    }
}
