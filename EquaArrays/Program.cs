using System;
using System.Linq;

namespace EquaArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] secondArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int diffIndex = int.MinValue;
            for (int i = 0; i < firstArray.Length; i++)
            {
                if (firstArray[i] != secondArray[i])
                {
                    diffIndex = i;
                    break;
                }
            }
            if (diffIndex != int.MinValue)
            {
                Console.WriteLine("Arrays are not identical. Found difference at {0} index", diffIndex);
            }
            else
            {
                int sum = 0;
                foreach (var item in firstArray)
                {
                    sum += item;
                }
                Console.WriteLine("Arrays are identical. Sum: {0}",sum);
            }
        }
    }
}
