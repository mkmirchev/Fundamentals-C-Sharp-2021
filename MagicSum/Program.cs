using System;
using System.Linq;

namespace MagicSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int sum = int.Parse(Console.ReadLine());
            int[] uniqueValues = new int[input.Length];
            bool isPrinted = false;
            for (int i = 0; i < input.Length-1; i++)
            {
                for (int j = i+1; j < input.Length; j++)
                {
                    int currentSum = input[i] + input[j];
                    if (currentSum == sum && isPrinted == false)
                    {
                        Console.WriteLine("{0} {1}", input[i], input[j]);
                        isPrinted = true;
                    }
                }
                isPrinted = false;
            }
        }
    }
}
