using System;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();
            Array.Reverse(input);
            input.ToString();
            Console.WriteLine(input);
        }
    }
}
