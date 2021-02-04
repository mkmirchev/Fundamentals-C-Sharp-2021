using System;
using System.Linq;

namespace EqualSums
{
    class Program
    {
        static void Main(string[] args)
        {
            //reading input
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            bool isEquals = false;
            int equalIndex =0;

            //implement logic to processing data
            for (int i = 0; i < input.Length; i++)
            {
                int leftSum = 0;
                int rightSum = 0;
                for (int k = 0; k < i; k++)
                {
                    leftSum += input[k];
                }
                for (int j = i+1; j < input.Length; j++)
                {
                    rightSum += input[j];
                }
                if (leftSum == rightSum && isEquals == false)
                {
                    isEquals = true;
                    equalIndex = i;
                }
                if (isEquals == true)
                {
                    break;
                }
            }
            //generating output messages
            if (isEquals == true)
            {
                Console.WriteLine(equalIndex);
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
