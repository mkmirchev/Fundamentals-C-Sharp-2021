using System;

namespace SumOfChars
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < input; i++)
            {
                char charInput = char.Parse(Console.ReadLine());
                int tempValue = (int)charInput;
                sum += tempValue;
            }
            Console.WriteLine("The sum equals: " + sum);
        }
    }
}
