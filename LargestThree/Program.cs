using System;
using System.Linq;

namespace LargestThree
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int[] newMax = arr.OrderByDescending(x => x).ToArray();
            if (arr.Length <= 3)
            {
                Console.WriteLine(string.Join(' ',newMax));
            }
            else
            {
                int[] output = new int[3];
                for (int i = 0; i < 3; i++)
                {
                    output[i] = newMax[i];
                }
                Console.WriteLine(string.Join(' ', output));
            }
        }
    }
}
