using System;
using System.Linq;

namespace ArrayRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int rotations = int.Parse(Console.ReadLine());
            int l = input.Length;
            for (int j = 0; j < rotations; j++)
            {
                int[] output = new int[l];
                int[] firstSegment = {input[0]};
                int[] secondSegment = new int[input.Length - 1];
                for (int i = 1; i < input.Length; i++)
                {
                    secondSegment[i - 1] = input[i];
                }
                output = secondSegment.Concat(firstSegment).ToArray();
                input = output;
            }
            foreach (var item in input)
            {
                Console.Write(item + " ");
            }
        }
    }
}
