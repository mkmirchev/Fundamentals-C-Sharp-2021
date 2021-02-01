using System;

namespace Refactoring_PrimeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            for (int i = 2; i <= input; i++)
            {
                bool isPrime = true;
                for (int k = 2; k < i; k++)
                {
                    if (i % k == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                Console.WriteLine("{0} -> {1}", i, isPrime.ToString().ToLower());
            }

        }
    }
}
