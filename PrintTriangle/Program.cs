using System;

namespace PrintTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            TrianglePrinter(input);
        }

        static void TrianglePrinter(int a)
        {
            for (int i = 1; i <= a; i++)
            {
                for (int l = 1; l <= i; l++)
                {
                    Console.Write(l + " ");
                }
                Console.WriteLine();
            }
            for (int s = a-1; s > 0; s--)
            {
                for (int k = 1; k <= s; k++)
                {
                    Console.Write(k + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
