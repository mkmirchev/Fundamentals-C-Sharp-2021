using System;
using System.Collections.Generic;
using System.Numerics;

namespace Multiply_big_numbers
{
    class Program
    {
        static void Main(string[] args)
        { 
        BigInteger a = BigInteger.Parse(Console.ReadLine());
        BigInteger b = BigInteger.Parse(Console.ReadLine());
        Console.WriteLine(a*b);
        }
    }
}
