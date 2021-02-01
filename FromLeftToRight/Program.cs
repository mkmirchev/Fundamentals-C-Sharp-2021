using System;
using System.Linq;
using System.Numerics;

namespace FromLeftToRight
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputRows = int.Parse(Console.ReadLine());
            for (int i = 0; i < inputRows; i++)
            {
                string[] input = Console.ReadLine().Split(" ");
                BigInteger firstNumber = BigInteger.Parse(input[0]);
                
                BigInteger secondNumber = BigInteger.Parse(input[1]);
                if (firstNumber > secondNumber)
                {
                    Console.WriteLine(SumIntDigits(firstNumber));
                }
                else if (firstNumber <= secondNumber)
                {
                    Console.WriteLine(SumIntDigits(secondNumber)); 
                }

            }
        }
        static BigInteger SumIntDigits(BigInteger a)
        {
            BigInteger output = 0;
            int count = a.ToString().Length;
            for (int i = 0; i < count; i++)
            {
                output += a % 10;
                a /= 10;
            }
            if (output < 0)
            {
                output *= -1;
            }
            return output;
        }
    }
}
