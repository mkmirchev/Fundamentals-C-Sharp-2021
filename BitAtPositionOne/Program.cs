using System;
using System.Collections.Generic;

namespace BitAtPositionOne
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            List<int> bits = new List<int>();
            while (a>0)
            {
                if (a%2 == 0)
                {
                    bits.Add(0);
                    a /= 2;
                }
                else
                {
                    bits.Add(1);
                    a /= 2;
                }
            }
            bits.Reverse();
            Console.WriteLine(bits[bits.Count-2]);
        }
    }
}
