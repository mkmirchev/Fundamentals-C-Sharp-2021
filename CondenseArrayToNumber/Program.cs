using System;
using System.Linq; 

namespace CondenseArrayToNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            while (true)
            {
                if (input.Length == 1)
                {
                    break;
                }
                int currentLenght = input.Length;
                int[] a = new int[currentLenght-1];
                for (int i = 0; i < currentLenght - 1; i++)
                {
                    a[i] = input[i] + input[i + 1];
                }
                input = a;

            }
            Console.WriteLine(input[0]);
        }
    }
}
