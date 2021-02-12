using System;

namespace TopNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            for (int i = 1; i <= input; i++)
            {
                if (IsSumDivisibleByEight(i) && IsThereOddNumbeer(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        static bool IsSumDivisibleByEight(int a)
        {
            bool output = false;
            int data = 0;
            while (a>0)
            {
                data += a % 10;
                a /= 10;
            }
            if (data%8==0)
            {
                output = true;
            }
            return output;
        }

        static bool IsThereOddNumbeer(int a)
        {
            bool output = false;
            while (a>0)
            {
                if (a%2==1)
                {
                    output = true;
                }
                a /= 10;
            }
            return output;
        }
    }
}
