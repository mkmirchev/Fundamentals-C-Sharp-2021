using System;
using System.Linq;

namespace KaminoFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            int dnaLenght = int.Parse(Console.ReadLine());
            int[] bestDNA = new int[dnaLenght];
            int maxLenght = 0;
            int minIndex = int.MaxValue;
            int maxSum = 0;
            int count = 0;
            int sample = 0;
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Clone them!")
                {
                    break;
                }
                int[] currentDNA = input.Split('!').Select(int.Parse).ToArray();
                int currentLenght = 0;
                int currentMinIndex = 0;
                int currentSum = 0;
                count++;
                for (int i = 0; i < dnaLenght; i++)
                {
                    currentSum += currentDNA[i];
                    if (currentDNA[i] == 1)
                    {
                        currentLenght += 1;
                    }
                    else
                    {
                        if (currentLenght >= maxLenght)
                        {
                            maxLenght = currentLenght;
                            currentMinIndex = i - maxLenght;
                        }
                        currentLenght = 0;
                    }
                }
                if (currentMinIndex < minIndex)
                {
                    minIndex = currentMinIndex;
                    maxLenght = currentLenght;
                    sample = count;
                    maxSum = currentSum;
                    bestDNA = currentDNA;
                }
                else if (currentMinIndex == minIndex && currentSum > maxSum)
                {
                    minIndex = currentMinIndex;
                    maxLenght = currentLenght;
                    sample = count;
                    bestDNA = currentDNA;
                    maxSum = currentSum;
                }
            }
            Console.WriteLine("Best DNA sample {0} with sum: {1}.",sample,maxSum);
            foreach (var item in bestDNA)
            {
                Console.Write(item + " ");
            }
        }
    }
}
