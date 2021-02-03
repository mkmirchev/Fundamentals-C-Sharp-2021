using System;
using System.Linq;

namespace TopIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int varMax = input.Max();
            bool initialize = false;
            for (int i = 0; i < input.Length; i++)
            {

                int[] output = new int[input.Length - i];
                for (int j = 0; j < output.Length; j++)
                {
                    output[j] = input[i + j];
                }
                if (input[i] >= output.Max() && initialize == false)
                {                
                    Console.Write(input[i] + " ");
                    varMax--;
                    initialize = true;
                }
                else if (input[i] >= output.Max() && input[i] <= varMax)
                {
                    Console.Write(input[i] + " ");
                    varMax--;
                  
                }

            }
        }
    }
}
