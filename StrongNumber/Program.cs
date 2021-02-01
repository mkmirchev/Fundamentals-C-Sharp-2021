using System;

namespace StrongNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int digits = input.Length;
            int number = int.Parse(input);
            int currentDigit = 1;
            int helpDigit = number;
            int fact = 1;
            int sum = 0;
            for (int i = 0; i < digits; i++)
            {
                currentDigit = helpDigit % 10;
                //calculating factorial
                for (int k = 1; k <= currentDigit; k++)
                {
                    fact = fact * k;
                }

                currentDigit = helpDigit / 10;
                sum += fact;
                fact = 1;
            }
            if (number == sum)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
