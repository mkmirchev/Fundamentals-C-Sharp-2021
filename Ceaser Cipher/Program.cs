﻿using System;

namespace Ceaser_Cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string output = string.Empty;
            for (int i = 0; i < input.Length; i++)
            {
                output +=(char)(input[i] + 3);
            }
            Console.WriteLine(output);
        }
    }
}
