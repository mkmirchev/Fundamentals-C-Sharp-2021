﻿using System;

namespace PrintAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNumber = int.Parse(Console.ReadLine());
            int endNumber = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = startNumber; i <= endNumber; i++)
            {
                Console.Write("{0} ",i);
                sum += i;
            }
            Console.WriteLine();
            Console.WriteLine("Sum: {0}",sum);
        }
    }
}
