using System;

namespace P_thBit
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            byte n = 1;
            Console.WriteLine(input>>p & n);

        }
    }
}
