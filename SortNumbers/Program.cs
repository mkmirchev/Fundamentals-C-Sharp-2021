using System;

namespace SortNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[3];
            for (int i = 0; i < 3; i++)
            {
                int input = int.Parse(Console.ReadLine());
                numbers[i] = input;
            }
            if (numbers[2] > numbers[0])
            {
                int temp = numbers[2];
                numbers[2] = numbers[0];
                numbers[0] = temp;
            }
            if (numbers[1] > numbers[0])
            {
                int temp = numbers[1];
                numbers[1] = numbers[0];
                numbers[0] = temp;
            }
            if (numbers[2] > numbers[1])
            {
                int temp = numbers[2];
                numbers[2] = numbers[1];
                numbers[1] = temp;
            }
            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }
        }
    }
}

