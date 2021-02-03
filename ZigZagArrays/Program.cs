using System;
using System.Linq;

namespace ZigZagArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int[] firstArr = new int[rows];
            int[] secondArr = new int[rows];
            for (int i = 0; i < rows; i++)
            {
                int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                if ((i+1)%2 == 0)
                {
                    firstArr[i] = input[1];
                    secondArr[i] = input[0];
                }
                else
                {
                    firstArr[i] = input[0];
                    secondArr[i] = input[1];
                }
            }
            foreach (var item in firstArr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            foreach (var item in secondArr)
            {
                Console.Write(item + " ");
            }
        }
    }
}
