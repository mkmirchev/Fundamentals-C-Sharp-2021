using System;

namespace MultiplicationSign
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            MultiplicationSignCheck(a, b, c);
        }

        static void MultiplicationSignCheck(int a, int b, int c)
        {
            if (a == 0 || b == 0 || c == 0)
            {
                Console.WriteLine("zero");
            }
            else if (a > 0 && b < 0 && c < 0 
             || a > 0 && b > 0 && c > 0
             || b > 0 && a < 0 && c < 0
             || c > 0 && b < 0 && a < 0)
            {
                Console.WriteLine("positive");
            }
            else
            {
                Console.WriteLine("negative");
            }
            
        }
    }
}
