using System;

namespace MultiplyEvenByOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int input = Math.Abs(a);
            Console.WriteLine(MultiplyEvenByOdds(GetSumOfEven(input),GetSumOfOdd(input)));

        }
        static int GetSumOfEven(int a)
        {
            int output = 0;
            while (a > 0)
            {
                int number = a % 10;
                if (number % 2 == 0)
                {
                    output += number;                 
                }
                a /= 10;
            }
            return output;
        }
        static int GetSumOfOdd(int a)
        {
            int output = 0;
            while (a>0)
            {
                int number = a % 10;
                if (number % 2 == 1)
                {
                    output += number;
                }
                a /= 10;
            }
            return output;
        }
        static uint MultiplyEvenByOdds(int a, int b)
        {
            uint output = (uint)a * (uint)b;
            return output;
        }
    }
}
