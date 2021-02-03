using System;

namespace PrintNumbersReversed
{
    class Program
    {
        static void Main(string[] args)
        {
            int readings = int.Parse(Console.ReadLine());
            int[] numbers = new int[readings];
            for (int i = 0; i < readings; i++)
            {
                int input = int.Parse(Console.ReadLine());
                numbers[i] = input;
            }
            for (int j = readings-1; j >= 0; j--)
            {
                Console.Write("{0} ", numbers[j]);
            }
        }
    }
}
