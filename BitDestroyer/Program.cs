using System;

namespace BitDestroyer
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int bitToConvert = int.Parse(Console.ReadLine());
            byte bt = 1;
            Console.WriteLine(number & ~(bt<<bitToConvert));

        }
    }
}
