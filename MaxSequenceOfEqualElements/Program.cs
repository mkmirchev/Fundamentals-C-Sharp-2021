using System;
using System.Linq;

namespace MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int maxSequence = 0;
            int maxSeqValue = 0;
            int currentSequence = 0;
            for (int i = 0; i < input.Length-1; i++)
            {
                if (input[i] == input[i+1])
                {
                    currentSequence++;
                }

                if (maxSequence<currentSequence)
                {
                    maxSequence = currentSequence;
                    maxSeqValue = input[i];
                }
                if (input[i] != input[i + 1])
                {
                currentSequence = 0;
                }
            }
            for (int i = 0; i <= maxSequence; i++)
            {
                Console.Write(maxSeqValue + " ");
            }
        }
    }
}
