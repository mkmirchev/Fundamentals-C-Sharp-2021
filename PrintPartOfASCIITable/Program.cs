﻿using System;

namespace PrintPartOfASCIITable
{
    class Program
    {
        static void Main(string[] args)
        {
            int startIndex = int.Parse(Console.ReadLine());        
            int endIndex = int.Parse(Console.ReadLine());
            string output = "";
            for (int  i = startIndex;  i <= endIndex;  i++)
            {
                char currentChar = (char)i;
                output = output + currentChar.ToString() + " ";
            }
            Console.WriteLine(output);
        }
    }
}
