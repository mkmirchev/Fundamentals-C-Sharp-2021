using System;
using System.Numerics;

namespace BigFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            BigInteger aFactrorial = 1;
            for (int i = 1; i <= a; i++)
            {
                aFactrorial *= i;
            }
            Console.WriteLine(aFactrorial);
        }
    }
}
